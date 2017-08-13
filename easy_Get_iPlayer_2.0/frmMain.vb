Public Class frmMain
    Dim fileName, fileDirectory As String
    Dim finished As Boolean = False
    Dim dlPID As Integer
    Dim dlSizes(2) As Integer
    Dim sizeStrings As String() = {"hvfhd", "hvfxsd", "hvfxhigh"}
    Dim chosenQualityIndex As Integer = 0

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cBoxQuality.SelectedIndex = chosenQualityIndex
        AddHandler cBoxQuality.SelectedIndexChanged, AddressOf UpdateSize 'Set inital value, then add handler
    End Sub

#Region "Info Fetching"
    Private Sub btnFetchInfo_Click(sender As Object, e As EventArgs) Handles btnFetchInfo.Click
        tBoxURL.Enabled = False
        btnFetchInfo.Enabled = False
        btnHelp.Enabled = False
        btnAbout.Enabled = False
        pBoxLoadingGif.Visible = True
        lblFetchMsg.Visible = True 'Disable controls and show message
        ClearLabels() 'Clear any existing label text
        bgWorkerInfoFetcher.RunWorkerAsync() 'Start backgroundworker
    End Sub

    Private Sub bgWorkerInfoFetcher_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorkerInfoFetcher.DoWork
        Dim infoFetcher = New Process()
        infoFetcher.StartInfo = New ProcessStartInfo() With {
            .WorkingDirectory = Environment.GetEnvironmentVariable("ProgramFiles(x86)") & "\get_iplayer\",
            .FileName = Environment.GetEnvironmentVariable("ProgramFiles(x86)") & "\get_iplayer\get_iplayer.cmd",
            .Arguments = " """ & tBoxURL.Text & """" & " --info ",
            .CreateNoWindow = True,
            .UseShellExecute = False,
            .RedirectStandardOutput = True}
        'Define and configure process

        infoFetcher.Start()

        Dim output As String

        Using outputStreamReader As System.IO.StreamReader = infoFetcher.StandardOutput
            output = outputStreamReader.ReadToEnd() 'Capture standard output
        End Using

        Dim outputArr As String() = output.Split(Chr(10) & Chr(13)) 'Split each line of output into an index

        Try
            For Each i In outputArr
                If i.Contains("brand:") Then
                    UpdateLbl(lblProgTitle, RemoveNewLine(i.Remove(0, 16))) 'Get title and set label value
                    Exit For
                End If
            Next

            For Each i In outputArr
                If i.Contains("senum:") Then
                    UpdateLbl(lblEpNum, RemoveNewLine(i.Remove(0, 16).ToUpper()))
                    Exit For
                End If
            Next

            For Each i In outputArr
                If i.Contains("episodeshort:") Then
                    UpdateLbl(lblEpTitle, RemoveNewLine(i.Remove(0, 16)))
                    Exit For
                End If
            Next

            For Each i In outputArr
                If i.Contains("descshort:") Then
                    UpdateLbl(lblDesc, RemoveNewLine(i.Remove(0, 16)))
                    Exit For
                End If
            Next

            Dim modesizes As String()
            For Each i In outputArr
                If i.Contains("modesizes:      original:") Then
                    modesizes = Split(i.Remove(0, 25), ",") 'Get array of file sizes
                    Exit For
                End If
            Next

            For Each i In modesizes
                If i.Contains("hvfhd1") Then
                    dlSizes(0) = Int(Mid(i, 8, Len(i) - 10)) 'High 50fps
                    'ElseIf i.Contains("hlshd1") Then
                    '    dlSizes(1) = Int(Mid(i, 8, i.Length - 10)) 'High 25fps - stream no longer available
                ElseIf i.Contains("hvfxsd1") Then
                    dlSizes(1) = Int(Mid(i, 9, i.Length - 11)) 'Medium
                ElseIf i.Contains("hvfxhigh1") Then
                    dlSizes(2) = Int(Mid(i, 11, i.Length - 13)) 'Low
                End If
            Next
            Invoke(New MethodInvoker(AddressOf EnableLabelLabels)) 'Enable labels for labels
            UpdateLbl(lblDLSize, dlSizes(chosenQualityIndex) & "MB")

        Catch ex As Exception
            Invoke(New MethodInvoker(Sub() MsgBox("Error Fetching Info: " & ex.Message & ". This may be caused by the URL you entered being invalid, the program being unavailable, or being located outside of the UK.", MsgBoxStyle.Critical, "Info Fetching Error"))) 'Display error message

        Finally
            Invoke(New MethodInvoker(Sub()
                                         pBoxLoadingGif.Visible = False
                                         lblFetchMsg.Visible = False
                                         EnableControls()
                                     End Sub)) 'Hide message and re-enable controls
        End Try
    End Sub

    Private Delegate Sub LblInvoker(lbl As Label, value As String)
    Private Sub UpdateLbl(lbl As Label, value As String)
        lbl.Invoke(New LblInvoker(AddressOf SetLabelValue), lbl, value) 'Set value of passed label
    End Sub

    Private Sub SetLabelValue(lbl As Label, value As String)
        lbl.Text = value
        lbl.Visible = True
    End Sub

    Private Sub EnableLabelLabels()
        lblProgTitleLabel.Enabled = True
        lblEpNumLabel.Enabled = True
        lblEpTitleLabel.Enabled = True
        lblDescLabel.Enabled = True
        lblDLSizeLabel.Enabled = True
    End Sub

    Private Function RemoveNewLine(str As String)
        Return str.Replace(vbCr, "").Replace(vbLf, "") 'Remove carriage return and line feed characters
    End Function
#End Region

#Region "Downloading"
    Private Sub btnDL_Click(sender As Object, e As EventArgs) Handles btnDL.Click
        DisableCloseButton(Me.Handle) 'Disable close button

        tBoxURL.Enabled = False
        btnFetchInfo.Enabled = False
        tBoxPath.Enabled = False
        btnBrowse.Enabled = False
        cBoxQuality.Enabled = False 'Disable UI elements

        pBarDownload.Visible = True
        lblDownloaded.Visible = True
        lblAmountDL.Visible = True
        lblDLPercent.Visible = True
        btnCancel.Visible = True
        btnDL.Visible = False 'Show and hide UI elements

        bgWorkerDownload.RunWorkerAsync() 'Start backgroundworker
    End Sub

    Private Sub bgWorkerDownload_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorkerDownload.DoWork
        Dim downloader = New Process()
        downloader.StartInfo = New ProcessStartInfo() With {
            .WorkingDirectory = Environment.GetEnvironmentVariable("ProgramFiles(x86)") & "\get_iplayer\",
            .FileName = Environment.GetEnvironmentVariable("ProgramFiles(x86)") & "\get_iplayer\get_iplayer.cmd",
            .Arguments = " """ & tBoxURL.Text & """" & " --modes " & sizeStrings(chosenQualityIndex) & " --output """ & fileDirectory & """" & " --file-prefix """ & fileName & """ --force -w 0 --overwrite", '--force to ignore any previous downloads, -w allows whitespace
            .CreateNoWindow = True,
            .UseShellExecute = False
        }
        downloader.EnableRaisingEvents = True

        AddHandler downloader.Exited, AddressOf downloaderExitHandler 'Add handler for process exit event

        downloader.Start()

        dlPID = downloader.Id 'Get process ID of downloader - so it can be killed when cancelling

        Dim intSize As Integer = Int(lblDLSize.Text.Substring(0, lblDLSize.Text.Length - 2))
        Dim currentSize As Double = GetFileSize(fileDirectory & "\" & fileName & ".video.ts") 'Get estimated download size and assign an initial value to current size

        While finished = False And currentSize < intSize
            currentSize = GetFileSize(fileDirectory & "\" & fileName & ".video.ts") 'Get current size
            lblAmountDL.Invoke(New MethodInvoker(Sub() lblAmountDL.Text = Math.Round(currentSize, 1).ToString("0.0" & "MB"))) 'Set label value to current file size
            UpdatePercentage(currentSize / intSize * 100)
            UpdatePBar(Int((currentSize / intSize) * 100)) 'Set percentage label and progress bar values
            Threading.Thread.Sleep(250) 'Wait for 0.25s - prevents excessive resource usage
        End While

    End Sub

    Private Sub UpdatePercentage(value As Single)
        If value > 100 Then
            lblDLPercent.Invoke(New MethodInvoker(Sub() lblDLPercent.Text = "(100.0%)")) 'Set value manually if above 100%
        Else
            lblDLPercent.Invoke(New MethodInvoker(Sub() lblDLPercent.Text = "(" & Math.Round(value, 1).ToString("0.0") & "%)")) 'Set value
        End If
    End Sub

    Private Sub UpdatePBar(value As Integer)
        If value > 100 Then
            pBarDownload.Invoke(New MethodInvoker(Sub() pBarDownload.Value = 100)) 'Set value manually if above 100%
        Else
            pBarDownload.Invoke(New MethodInvoker(Sub() pBarDownload.Value = value)) 'Set value
        End If
    End Sub

    Private Sub downloaderExitHandler(sender As Object, ByVal e As System.EventArgs)
        If finished = False Then
            finished = True 'Stop while loop
            My.Computer.Audio.Play(Environment.GetEnvironmentVariable("windir") & "\Media\tada.wav") 'Play the most amazing sound
            Invoke(New MethodInvoker(Sub() MsgBox("Download complete! Thanks for using easy_get_iplayer. Click 'Ok' to exit.", MsgBoxStyle.OkOnly, "Download Complete!")))
            Application.Exit()
        End If
    End Sub

    Private Function GetFileSize(path As String)
        Try
            Return My.Computer.FileSystem.GetFileInfo(path).Length / 1000000 'Get file size, and convert to MB
        Catch ex As Exception
            Return 0 'Return file size of 0 if file not found
        End Try
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to stop downloading? Any progress will be lost and downloads cannot be resumed.", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Confirmation") = MsgBoxResult.Yes Then
            finished = True 'Stop while loop and prevent exit handler from running code

            Dim processKiller = New Process
            processKiller.StartInfo = New ProcessStartInfo() With {
                .WorkingDirectory = "C:\Windows\system32",
            .FileName = "C:\Windows\System32\taskkill.exe",
            .Arguments = "/f /t /pid " & dlPID,
            .CreateNoWindow = True,
            .UseShellExecute = False}

            processKiller.Start() 'Run process to kill downloader process and any child processes

            If MsgBox("Would you like to remove the partially downloaded files?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Confirmation") = MsgBoxResult.Yes Then
                Try
                    My.Computer.FileSystem.DeleteFile(fileDirectory & "\" & fileName & ".video.ts")
                Catch
                End Try

                Try
                    My.Computer.FileSystem.DeleteFile(fileDirectory & "\" & fileName & ".video.txt")
                Catch
                End Try 'Try to delete each file, and just ignore if the file doesn't exist
            End If

            Application.Exit()
        End If
    End Sub
#End Region

#Region "Other UI Code"
    Private Sub UpdateSize(sender As Object, e As EventArgs)
        chosenQualityIndex = sender.SelectedIndex
        lblDLSize.Text = dlSizes(sender.SelectedIndex).ToString & "MB"
    End Sub

    Private Sub EnableControls()
        tBoxURL.Enabled = True
        btnFetchInfo.Enabled = True
        btnBrowse.Enabled = True
        tBoxPath.Enabled = True
        cBoxQuality.Enabled = True
        btnHelp.Enabled = True
        btnAbout.Enabled = True
    End Sub

    Private Sub ClearLabels()
        lblProgTitle.ResetText()
        lblEpNum.ResetText()
        lblEpTitle.ResetText()
        lblDesc.ResetText()
        lblDLSize.ResetText()
    End Sub

    Private Sub tBoxURL_TextChanged(sender As Object, e As EventArgs) Handles tBoxURL.TextChanged
        If sender.text.Contains("http://www.bbc.co.uk/iplayer/") Then
            btnFetchInfo.Enabled = True
        Else
            btnFetchInfo.Enabled = False
            btnBrowse.Enabled = False
            btnDL.Enabled = False
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        dlgSaveOutputFile.FileName = lblProgTitle.Text & " " & lblEpNum.Text & " - " & lblEpTitle.Text & ".mp4" 'Set initial file name
        If dlgSaveOutputFile.ShowDialog() = MsgBoxResult.Ok Then
            fileName = IO.Path.GetFileNameWithoutExtension(dlgSaveOutputFile.FileName)
            fileDirectory = IO.Path.GetDirectoryName(dlgSaveOutputFile.FileName) 'Get file name and directory
            tBoxPath.Text = dlgSaveOutputFile.FileName
            btnDL.Enabled = True
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        frmHelp.ShowDialog()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmAbout.ShowDialog()
    End Sub
#End Region

#Region "Close button disabling"
    'Requirements for disabling the "X" button
    Private Const MF_BYPOSITION As Int32 = &H400
    Private Const MF_REMOVE As Int32 = &H1000
    Private Declare Auto Function GetSystemMenu Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal bRevert As Int32) As IntPtr
    Private Declare Auto Function GetMenuItemCount Lib "user32.dll" (ByVal hMenu As IntPtr) As Int32
    Private Declare Function DrawMenuBar Lib "user32.dll" (ByVal hwnd As IntPtr) As Boolean
    Private Declare Auto Function RemoveMenu Lib "user32.dll" (ByVal hMenu As IntPtr, ByVal nPosition As Int32, ByVal wFlags As Int32) As Int32

    'This method will be used to disable the Form "X" button
    Public Shared Sub DisableCloseButton(ByVal hwnd As IntPtr)
        Dim hMenu As IntPtr, n As Int32
        hMenu = GetSystemMenu(hwnd, 0)
        If Not hMenu.Equals(IntPtr.Zero) Then
            n = GetMenuItemCount(hMenu)
            If n > 0 Then
                RemoveMenu(hMenu, n - 1, MF_BYPOSITION Or MF_REMOVE)
                RemoveMenu(hMenu, n - 2, MF_BYPOSITION Or MF_REMOVE)
                DrawMenuBar(hwnd)
            End If
        End If
    End Sub

    Private Sub lblFetchMsg_Click(sender As Object, e As EventArgs) Handles lblFetchMsg.Click

    End Sub

    Private Sub tBoxPath_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tBoxPath.KeyPress
        e.Handled = True
    End Sub
#End Region
End Class