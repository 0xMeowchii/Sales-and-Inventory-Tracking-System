<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.panelControl = New System.Windows.Forms.Panel()
        Me.btnHide = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnMin = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnExit = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.panelRight = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelLeft = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.panelTop.SuspendLayout()
        Me.panelControl.SuspendLayout()
        Me.panelRight.SuspendLayout()
        Me.panelLeft.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 25
        Me.Guna2Elipse1.TargetControl = Me
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.panelTop.Controls.Add(Me.panelControl)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1067, 36)
        Me.panelTop.TabIndex = 4
        '
        'panelControl
        '
        Me.panelControl.Controls.Add(Me.btnHide)
        Me.panelControl.Controls.Add(Me.btnMin)
        Me.panelControl.Controls.Add(Me.btnExit)
        Me.panelControl.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelControl.Location = New System.Drawing.Point(895, 0)
        Me.panelControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelControl.Name = "panelControl"
        Me.panelControl.Padding = New System.Windows.Forms.Padding(0, 0, 9, 0)
        Me.panelControl.Size = New System.Drawing.Size(172, 36)
        Me.panelControl.TabIndex = 0
        '
        'btnHide
        '
        Me.btnHide.CheckedState.Parent = Me.btnHide
        Me.btnHide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHide.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnHide.HoverState.Parent = Me.btnHide
        Me.btnHide.Image = Global.attendancesystem.My.Resources.Resources.icons8_minimize_15__1_
        Me.btnHide.ImageSize = New System.Drawing.Size(15, 16)
        Me.btnHide.Location = New System.Drawing.Point(-6, 0)
        Me.btnHide.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.PressedState.Parent = Me.btnHide
        Me.btnHide.Size = New System.Drawing.Size(55, 36)
        Me.btnHide.TabIndex = 6
        '
        'btnMin
        '
        Me.btnMin.CheckedState.Parent = Me.btnMin
        Me.btnMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMin.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMin.HoverState.Parent = Me.btnMin
        Me.btnMin.Image = Global.attendancesystem.My.Resources.Resources.icons8_minimize_15
        Me.btnMin.ImageSize = New System.Drawing.Size(15, 16)
        Me.btnMin.Location = New System.Drawing.Point(49, 0)
        Me.btnMin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.PressedState.Parent = Me.btnMin
        Me.btnMin.Size = New System.Drawing.Size(63, 36)
        Me.btnMin.TabIndex = 5
        '
        'btnExit
        '
        Me.btnExit.CheckedState.Parent = Me.btnExit
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExit.HoverState.Parent = Me.btnExit
        Me.btnExit.Image = Global.attendancesystem.My.Resources.Resources.icons8_x_15__1_
        Me.btnExit.ImageSize = New System.Drawing.Size(15, 16)
        Me.btnExit.Location = New System.Drawing.Point(112, 0)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.PressedState.Parent = Me.btnExit
        Me.btnExit.Size = New System.Drawing.Size(51, 36)
        Me.btnExit.TabIndex = 4
        '
        'panelRight
        '
        Me.panelRight.BackColor = System.Drawing.Color.Transparent
        Me.panelRight.Controls.Add(Me.Label2)
        Me.panelRight.Controls.Add(Me.Label1)
        Me.panelRight.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelRight.Location = New System.Drawing.Point(0, 36)
        Me.panelRight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelRight.Name = "panelRight"
        Me.panelRight.ShadowDecoration.Parent = Me.panelRight
        Me.panelRight.Size = New System.Drawing.Size(561, 556)
        Me.panelRight.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(334, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sales and Inventory Tracker System"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(36, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(561, 556)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "A-Z TECH Computer Store"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelLeft
        '
        Me.panelLeft.BackColor = System.Drawing.Color.Transparent
        Me.panelLeft.Controls.Add(Me.Guna2PictureBox1)
        Me.panelLeft.Controls.Add(Me.btnLogin)
        Me.panelLeft.Controls.Add(Me.txtPassword)
        Me.panelLeft.Controls.Add(Me.txtUsername)
        Me.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelLeft.Location = New System.Drawing.Point(561, 36)
        Me.panelLeft.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelLeft.Name = "panelLeft"
        Me.panelLeft.ShadowDecoration.Parent = Me.panelLeft
        Me.panelLeft.Size = New System.Drawing.Size(506, 556)
        Me.panelLeft.TabIndex = 6
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.attendancesystem.My.Resources.Resources.logo_
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(96, 97)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(267, 156)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 7
        Me.Guna2PictureBox1.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.BorderRadius = 15
        Me.btnLogin.CheckedState.Parent = Me.btnLogin
        Me.btnLogin.CustomImages.Parent = Me.btnLogin
        Me.btnLogin.FillColor = System.Drawing.Color.Red
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.btnLogin.HoverState.Parent = Me.btnLogin
        Me.btnLogin.Location = New System.Drawing.Point(96, 372)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.btnLogin.ShadowDecoration.Parent = Me.btnLogin
        Me.btnLogin.Size = New System.Drawing.Size(267, 39)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.BorderColor = System.Drawing.Color.Transparent
        Me.txtPassword.BorderRadius = 15
        Me.txtPassword.BorderThickness = 0
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.Parent = Me.txtPassword
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FillColor = System.Drawing.Color.DimGray
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.FocusedState.Parent = Me.txtPassword
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.HoverState.Parent = Me.txtPassword
        Me.txtPassword.Location = New System.Drawing.Point(96, 309)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txtPassword.PlaceholderText = "Enter Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.ShadowDecoration.Parent = Me.txtPassword
        Me.txtPassword.Size = New System.Drawing.Size(267, 39)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtUsername.BorderColor = System.Drawing.Color.Transparent
        Me.txtUsername.BorderRadius = 15
        Me.txtUsername.BorderThickness = 0
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.Parent = Me.txtUsername
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FillColor = System.Drawing.Color.DimGray
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.FocusedState.Parent = Me.txtUsername
        Me.txtUsername.ForeColor = System.Drawing.Color.White
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.HoverState.Parent = Me.txtUsername
        Me.txtUsername.Location = New System.Drawing.Point(96, 261)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txtUsername.PlaceholderText = "Enter Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.ShadowDecoration.Parent = Me.txtUsername
        Me.txtUsername.Size = New System.Drawing.Size(267, 39)
        Me.txtUsername.TabIndex = 4
        Me.txtUsername.TextOffset = New System.Drawing.Point(5, 0)
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.attendancesystem.My.Resources.Resources.v915_techi_002
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 592)
        Me.Controls.Add(Me.panelLeft)
        Me.Controls.Add(Me.panelRight)
        Me.Controls.Add(Me.panelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.panelTop.ResumeLayout(False)
        Me.panelControl.ResumeLayout(False)
        Me.panelRight.ResumeLayout(False)
        Me.panelRight.PerformLayout()
        Me.panelLeft.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents panelTop As Panel
    Friend WithEvents panelControl As Panel
    Friend WithEvents btnHide As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnMin As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents panelLeft As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents panelRight As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
