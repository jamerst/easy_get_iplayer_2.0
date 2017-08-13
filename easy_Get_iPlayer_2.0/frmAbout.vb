Public Class frmAbout
    Private Sub lnklblDL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblDL.LinkClicked
        lnklblDL.LinkVisited = True
        Process.Start("https://github.com/get-iplayer/get_iplayer_win32/releases/latest")
    End Sub

    Private Sub lnkLblLicense_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLblLicense.LinkClicked
        lnkLblLicense.LinkVisited = True
        Process.Start("https://github.com/get-iplayer/get_iplayer/blob/master/LICENSE.txt")
    End Sub
End Class