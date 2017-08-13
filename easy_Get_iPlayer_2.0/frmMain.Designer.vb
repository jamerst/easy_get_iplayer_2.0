<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.bgWorkerInfoFetcher = New System.ComponentModel.BackgroundWorker()
        Me.tBoxPath = New System.Windows.Forms.TextBox()
        Me.lblDLPercent = New System.Windows.Forms.Label()
        Me.lblAmountDL = New System.Windows.Forms.Label()
        Me.lblDownloaded = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblDLSize = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblEpTitle = New System.Windows.Forms.Label()
        Me.lblEpNum = New System.Windows.Forms.Label()
        Me.lblProgTitle = New System.Windows.Forms.Label()
        Me.lblDLSizeLabel = New System.Windows.Forms.Label()
        Me.lblDescLabel = New System.Windows.Forms.Label()
        Me.lblEpTitleLabel = New System.Windows.Forms.Label()
        Me.lblEpNumLabel = New System.Windows.Forms.Label()
        Me.pBarDownload = New System.Windows.Forms.ProgressBar()
        Me.btnFetchInfo = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.lblProgTitleLabel = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblOutputFile = New System.Windows.Forms.Label()
        Me.lblProgURL = New System.Windows.Forms.Label()
        Me.tBoxURL = New System.Windows.Forms.TextBox()
        Me.btnDL = New System.Windows.Forms.Button()
        Me.dlgSaveOutputFile = New System.Windows.Forms.SaveFileDialog()
        Me.bgWorkerDownload = New System.ComponentModel.BackgroundWorker()
        Me.lblQuality = New System.Windows.Forms.Label()
        Me.cBoxQuality = New System.Windows.Forms.ComboBox()
        Me.lblFetchMsg = New System.Windows.Forms.Label()
        Me.pBoxLoadingGif = New System.Windows.Forms.PictureBox()
        CType(Me.pBoxLoadingGif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bgWorkerInfoFetcher
        '
        '
        'tBoxPath
        '
        Me.tBoxPath.Enabled = False
        Me.tBoxPath.Location = New System.Drawing.Point(12, 68)
        Me.tBoxPath.Name = "tBoxPath"
        Me.tBoxPath.Size = New System.Drawing.Size(479, 20)
        Me.tBoxPath.TabIndex = 63
        '
        'lblDLPercent
        '
        Me.lblDLPercent.AutoSize = True
        Me.lblDLPercent.Location = New System.Drawing.Point(297, 214)
        Me.lblDLPercent.Name = "lblDLPercent"
        Me.lblDLPercent.Size = New System.Drawing.Size(36, 13)
        Me.lblDLPercent.TabIndex = 62
        Me.lblDLPercent.Text = "(0.0%)"
        Me.lblDLPercent.Visible = False
        '
        'lblAmountDL
        '
        Me.lblAmountDL.AutoSize = True
        Me.lblAmountDL.Location = New System.Drawing.Point(244, 214)
        Me.lblAmountDL.Name = "lblAmountDL"
        Me.lblAmountDL.Size = New System.Drawing.Size(38, 13)
        Me.lblAmountDL.TabIndex = 61
        Me.lblAmountDL.Text = "0.0MB"
        Me.lblAmountDL.Visible = False
        '
        'lblDownloaded
        '
        Me.lblDownloaded.AutoSize = True
        Me.lblDownloaded.Location = New System.Drawing.Point(168, 214)
        Me.lblDownloaded.Name = "lblDownloaded"
        Me.lblDownloaded.Size = New System.Drawing.Size(70, 13)
        Me.lblDownloaded.TabIndex = 60
        Me.lblDownloaded.Text = "Downloaded:"
        Me.lblDownloaded.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(12, 187)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 40)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'lblDLSize
        '
        Me.lblDLSize.AutoSize = True
        Me.lblDLSize.Location = New System.Drawing.Point(297, 173)
        Me.lblDLSize.Name = "lblDLSize"
        Me.lblDLSize.Size = New System.Drawing.Size(51, 13)
        Me.lblDLSize.TabIndex = 58
        Me.lblDLSize.Text = "lblDLSize"
        Me.lblDLSize.Visible = False
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(260, 146)
        Me.lblDesc.MaximumSize = New System.Drawing.Size(310, 27)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(42, 13)
        Me.lblDesc.TabIndex = 57
        Me.lblDesc.Text = "lblDesc"
        Me.lblDesc.Visible = False
        '
        'lblEpTitle
        '
        Me.lblEpTitle.AutoSize = True
        Me.lblEpTitle.Location = New System.Drawing.Point(260, 133)
        Me.lblEpTitle.Name = "lblEpTitle"
        Me.lblEpTitle.Size = New System.Drawing.Size(50, 13)
        Me.lblEpTitle.TabIndex = 56
        Me.lblEpTitle.Text = "lblEpTitle"
        Me.lblEpTitle.Visible = False
        '
        'lblEpNum
        '
        Me.lblEpNum.AutoSize = True
        Me.lblEpNum.Location = New System.Drawing.Point(260, 119)
        Me.lblEpNum.Name = "lblEpNum"
        Me.lblEpNum.Size = New System.Drawing.Size(52, 13)
        Me.lblEpNum.TabIndex = 55
        Me.lblEpNum.Text = "lblEpNum"
        Me.lblEpNum.Visible = False
        '
        'lblProgTitle
        '
        Me.lblProgTitle.AutoSize = True
        Me.lblProgTitle.Location = New System.Drawing.Point(260, 106)
        Me.lblProgTitle.Name = "lblProgTitle"
        Me.lblProgTitle.Size = New System.Drawing.Size(59, 13)
        Me.lblProgTitle.TabIndex = 54
        Me.lblProgTitle.Text = "lblProgTitle"
        Me.lblProgTitle.Visible = False
        '
        'lblDLSizeLabel
        '
        Me.lblDLSizeLabel.AutoSize = True
        Me.lblDLSizeLabel.Enabled = False
        Me.lblDLSizeLabel.Location = New System.Drawing.Point(168, 173)
        Me.lblDLSizeLabel.Name = "lblDLSizeLabel"
        Me.lblDLSizeLabel.Size = New System.Drawing.Size(130, 13)
        Me.lblDLSizeLabel.TabIndex = 53
        Me.lblDLSizeLabel.Text = "Estimated Download Size:"
        '
        'lblDescLabel
        '
        Me.lblDescLabel.AutoSize = True
        Me.lblDescLabel.Enabled = False
        Me.lblDescLabel.Location = New System.Drawing.Point(168, 146)
        Me.lblDescLabel.Name = "lblDescLabel"
        Me.lblDescLabel.Size = New System.Drawing.Size(63, 13)
        Me.lblDescLabel.TabIndex = 52
        Me.lblDescLabel.Text = "Description:"
        '
        'lblEpTitleLabel
        '
        Me.lblEpTitleLabel.AutoSize = True
        Me.lblEpTitleLabel.Enabled = False
        Me.lblEpTitleLabel.Location = New System.Drawing.Point(168, 133)
        Me.lblEpTitleLabel.Name = "lblEpTitleLabel"
        Me.lblEpTitleLabel.Size = New System.Drawing.Size(71, 13)
        Me.lblEpTitleLabel.TabIndex = 51
        Me.lblEpTitleLabel.Text = "Episode Title:"
        '
        'lblEpNumLabel
        '
        Me.lblEpNumLabel.AutoSize = True
        Me.lblEpNumLabel.Enabled = False
        Me.lblEpNumLabel.Location = New System.Drawing.Point(168, 119)
        Me.lblEpNumLabel.Name = "lblEpNumLabel"
        Me.lblEpNumLabel.Size = New System.Drawing.Size(88, 13)
        Me.lblEpNumLabel.TabIndex = 50
        Me.lblEpNumLabel.Text = "Episode Number:"
        '
        'pBarDownload
        '
        Me.pBarDownload.Location = New System.Drawing.Point(171, 187)
        Me.pBarDownload.Name = "pBarDownload"
        Me.pBarDownload.Size = New System.Drawing.Size(401, 24)
        Me.pBarDownload.TabIndex = 48
        Me.pBarDownload.Visible = False
        '
        'btnFetchInfo
        '
        Me.btnFetchInfo.Enabled = False
        Me.btnFetchInfo.Location = New System.Drawing.Point(497, 28)
        Me.btnFetchInfo.Name = "btnFetchInfo"
        Me.btnFetchInfo.Size = New System.Drawing.Size(75, 20)
        Me.btnFetchInfo.TabIndex = 2
        Me.btnFetchInfo.Text = "Fetch Info"
        Me.btnFetchInfo.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(12, 160)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(150, 21)
        Me.btnAbout.TabIndex = 7
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(12, 133)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(150, 21)
        Me.btnHelp.TabIndex = 6
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'lblProgTitleLabel
        '
        Me.lblProgTitleLabel.AutoSize = True
        Me.lblProgTitleLabel.Enabled = False
        Me.lblProgTitleLabel.Location = New System.Drawing.Point(168, 106)
        Me.lblProgTitleLabel.Name = "lblProgTitleLabel"
        Me.lblProgTitleLabel.Size = New System.Drawing.Size(86, 13)
        Me.lblProgTitleLabel.TabIndex = 49
        Me.lblProgTitleLabel.Text = "Programme Title:"
        '
        'btnBrowse
        '
        Me.btnBrowse.Enabled = False
        Me.btnBrowse.Location = New System.Drawing.Point(497, 67)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 20)
        Me.btnBrowse.TabIndex = 3
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lblOutputFile
        '
        Me.lblOutputFile.AutoSize = True
        Me.lblOutputFile.Location = New System.Drawing.Point(12, 51)
        Me.lblOutputFile.Name = "lblOutputFile"
        Me.lblOutputFile.Size = New System.Drawing.Size(61, 13)
        Me.lblOutputFile.TabIndex = 40
        Me.lblOutputFile.Text = "Output File:"
        '
        'lblProgURL
        '
        Me.lblProgURL.AutoSize = True
        Me.lblProgURL.Location = New System.Drawing.Point(12, 12)
        Me.lblProgURL.Name = "lblProgURL"
        Me.lblProgURL.Size = New System.Drawing.Size(88, 13)
        Me.lblProgURL.TabIndex = 39
        Me.lblProgURL.Text = "Programme URL:"
        '
        'tBoxURL
        '
        Me.tBoxURL.BackColor = System.Drawing.SystemColors.Window
        Me.tBoxURL.Location = New System.Drawing.Point(12, 28)
        Me.tBoxURL.Name = "tBoxURL"
        Me.tBoxURL.Size = New System.Drawing.Size(479, 20)
        Me.tBoxURL.TabIndex = 1
        '
        'btnDL
        '
        Me.btnDL.Enabled = False
        Me.btnDL.Location = New System.Drawing.Point(12, 186)
        Me.btnDL.Name = "btnDL"
        Me.btnDL.Size = New System.Drawing.Size(150, 40)
        Me.btnDL.TabIndex = 5
        Me.btnDL.Text = "Download"
        Me.btnDL.UseVisualStyleBackColor = True
        '
        'dlgSaveOutputFile
        '
        Me.dlgSaveOutputFile.DefaultExt = "mp4"
        Me.dlgSaveOutputFile.Filter = "MP4 Files|*.mp4"
        '
        'bgWorkerDownload
        '
        '
        'lblQuality
        '
        Me.lblQuality.AutoSize = True
        Me.lblQuality.Location = New System.Drawing.Point(12, 90)
        Me.lblQuality.Name = "lblQuality"
        Me.lblQuality.Size = New System.Drawing.Size(42, 13)
        Me.lblQuality.TabIndex = 65
        Me.lblQuality.Text = "Quality:"
        '
        'cBoxQuality
        '
        Me.cBoxQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxQuality.Enabled = False
        Me.cBoxQuality.FormattingEnabled = True
        Me.cBoxQuality.Items.AddRange(New Object() {"High (720p)", "Medium (540p)", "Low (396p)"})
        Me.cBoxQuality.Location = New System.Drawing.Point(12, 106)
        Me.cBoxQuality.Name = "cBoxQuality"
        Me.cBoxQuality.Size = New System.Drawing.Size(150, 21)
        Me.cBoxQuality.TabIndex = 4
        '
        'lblFetchMsg
        '
        Me.lblFetchMsg.AutoSize = True
        Me.lblFetchMsg.BackColor = System.Drawing.SystemColors.Control
        Me.lblFetchMsg.Location = New System.Drawing.Point(326, 145)
        Me.lblFetchMsg.Name = "lblFetchMsg"
        Me.lblFetchMsg.Size = New System.Drawing.Size(225, 39)
        Me.lblFetchMsg.TabIndex = 67
        Me.lblFetchMsg.Text = "Please Wait.." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fetching programme information, this may take" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a few seconds."
        Me.lblFetchMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFetchMsg.UseWaitCursor = True
        Me.lblFetchMsg.Visible = False
        '
        'pBoxLoadingGif
        '
        Me.pBoxLoadingGif.BackColor = System.Drawing.SystemColors.Control
        Me.pBoxLoadingGif.Image = Global.easy_get_iplayer_2._0.My.Resources.Resources.loading
        Me.pBoxLoadingGif.Location = New System.Drawing.Point(171, 106)
        Me.pBoxLoadingGif.Name = "pBoxLoadingGif"
        Me.pBoxLoadingGif.Size = New System.Drawing.Size(120, 120)
        Me.pBoxLoadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pBoxLoadingGif.TabIndex = 66
        Me.pBoxLoadingGif.TabStop = False
        Me.pBoxLoadingGif.Visible = False
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnFetchInfo
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 238)
        Me.Controls.Add(Me.lblFetchMsg)
        Me.Controls.Add(Me.pBoxLoadingGif)
        Me.Controls.Add(Me.lblQuality)
        Me.Controls.Add(Me.cBoxQuality)
        Me.Controls.Add(Me.tBoxPath)
        Me.Controls.Add(Me.lblDLPercent)
        Me.Controls.Add(Me.lblAmountDL)
        Me.Controls.Add(Me.lblDownloaded)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblDLSize)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblEpTitle)
        Me.Controls.Add(Me.lblEpNum)
        Me.Controls.Add(Me.lblProgTitle)
        Me.Controls.Add(Me.lblDLSizeLabel)
        Me.Controls.Add(Me.lblDescLabel)
        Me.Controls.Add(Me.lblEpTitleLabel)
        Me.Controls.Add(Me.lblEpNumLabel)
        Me.Controls.Add(Me.pBarDownload)
        Me.Controls.Add(Me.btnFetchInfo)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblProgTitleLabel)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.lblOutputFile)
        Me.Controls.Add(Me.lblProgURL)
        Me.Controls.Add(Me.tBoxURL)
        Me.Controls.Add(Me.btnDL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "easy_get_iplayer 2.0.1"
        CType(Me.pBoxLoadingGif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bgWorkerInfoFetcher As System.ComponentModel.BackgroundWorker
    Friend WithEvents tBoxPath As TextBox
    Friend WithEvents lblDLPercent As Label
    Friend WithEvents lblAmountDL As Label
    Friend WithEvents lblDownloaded As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblDLSize As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblEpTitle As Label
    Friend WithEvents lblEpNum As Label
    Friend WithEvents lblProgTitle As Label
    Friend WithEvents lblDLSizeLabel As Label
    Friend WithEvents lblDescLabel As Label
    Friend WithEvents lblEpTitleLabel As Label
    Friend WithEvents lblEpNumLabel As Label
    Friend WithEvents pBarDownload As ProgressBar
    Friend WithEvents btnFetchInfo As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents lblProgTitleLabel As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblOutputFile As Label
    Friend WithEvents lblProgURL As Label
    Friend WithEvents tBoxURL As TextBox
    Friend WithEvents btnDL As Button
    Friend WithEvents dlgSaveOutputFile As SaveFileDialog
    Friend WithEvents bgWorkerDownload As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblQuality As Label
    Friend WithEvents cBoxQuality As ComboBox
    Friend WithEvents lblFetchMsg As Label
    Friend WithEvents pBoxLoadingGif As PictureBox
End Class
