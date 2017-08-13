<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lblChangelog = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lnklblDL = New System.Windows.Forms.LinkLabel()
        Me.lblRequires = New System.Windows.Forms.Label()
        Me.pBoxLogo = New System.Windows.Forms.PictureBox()
        Me.lnkLblLicense = New System.Windows.Forms.LinkLabel()
        CType(Me.pBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblChangelog
        '
        Me.lblChangelog.AutoSize = True
        Me.lblChangelog.Location = New System.Drawing.Point(12, 56)
        Me.lblChangelog.MaximumSize = New System.Drawing.Size(250, 0)
        Me.lblChangelog.Name = "lblChangelog"
        Me.lblChangelog.Size = New System.Drawing.Size(248, 78)
        Me.lblChangelog.TabIndex = 28
        Me.lblChangelog.Text = resources.GetString("lblChangelog.Text")
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(12, 34)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(69, 13)
        Me.lblVersion.TabIndex = 27
        Me.lblVersion.Text = "Version 2.0.1"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 11)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(161, 13)
        Me.lblTitle.TabIndex = 26
        Me.lblTitle.Text = "easy_get_iplayer © jamerst 2017"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lnklblDL
        '
        Me.lnklblDL.AutoSize = True
        Me.lnklblDL.Location = New System.Drawing.Point(12, 165)
        Me.lnklblDL.Name = "lnklblDL"
        Me.lnklblDL.Size = New System.Drawing.Size(193, 13)
        Me.lnklblDL.TabIndex = 25
        Me.lnklblDL.TabStop = True
        Me.lnklblDL.Text = "Get the latest version for Windows here"
        Me.lnklblDL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRequires
        '
        Me.lblRequires.AutoSize = True
        Me.lblRequires.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequires.Location = New System.Drawing.Point(12, 152)
        Me.lblRequires.Name = "lblRequires"
        Me.lblRequires.Size = New System.Drawing.Size(219, 13)
        Me.lblRequires.TabIndex = 24
        Me.lblRequires.Text = "Requires get_iplayer © 2008-2010 Phil Lewis"
        Me.lblRequires.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pBoxLogo
        '
        Me.pBoxLogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.pBoxLogo.Image = Global.easy_get_iplayer_2._0.My.Resources.Resources.logo
        Me.pBoxLogo.Location = New System.Drawing.Point(262, 11)
        Me.pBoxLogo.Name = "pBoxLogo"
        Me.pBoxLogo.Size = New System.Drawing.Size(110, 110)
        Me.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pBoxLogo.TabIndex = 29
        Me.pBoxLogo.TabStop = False
        '
        'lnkLblLicense
        '
        Me.lnkLblLicense.AutoSize = True
        Me.lnkLblLicense.Location = New System.Drawing.Point(228, 152)
        Me.lnkLblLicense.Name = "lnkLblLicense"
        Me.lnkLblLicense.Size = New System.Drawing.Size(70, 13)
        Me.lnkLblLicense.TabIndex = 30
        Me.lnkLblLicense.TabStop = True
        Me.lnkLblLicense.Text = "View License"
        Me.lnkLblLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 187)
        Me.Controls.Add(Me.lnkLblLicense)
        Me.Controls.Add(Me.pBoxLogo)
        Me.Controls.Add(Me.lblChangelog)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lnklblDL)
        Me.Controls.Add(Me.lblRequires)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        CType(Me.pBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pBoxLogo As PictureBox
    Friend WithEvents lblChangelog As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lnklblDL As LinkLabel
    Friend WithEvents lblRequires As Label
    Friend WithEvents lnkLblLicense As LinkLabel
End Class
