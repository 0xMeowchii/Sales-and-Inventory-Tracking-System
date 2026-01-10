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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.panelTop = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.panelControls = New System.Windows.Forms.Panel()
        Me.panelName = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelbuttons = New System.Windows.Forms.Panel()
        Me.dropdownStock = New System.Windows.Forms.Panel()
        Me.btnStockOut = New Guna.UI2.WinForms.Guna2Button()
        Me.btnStockIn = New Guna.UI2.WinForms.Guna2Button()
        Me.dropdownUsers = New System.Windows.Forms.Panel()
        Me.btnUsers = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdmin = New Guna.UI2.WinForms.Guna2Button()
        Me.panelLogo = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelFill = New System.Windows.Forms.Panel()
        Me.btnDatabase = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSales = New Guna.UI2.WinForms.Guna2Button()
        Me.btnStock = New Guna.UI2.WinForms.Guna2Button()
        Me.btnInventory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSignOut = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUsersManagement = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.picLogo = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnHide = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnMin = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnExit = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.FrmDashboard1 = New attendancesystem.frmDashboard()
        Me.FrmUsers1 = New attendancesystem.frmUsers()
        Me.FrmAdmin1 = New attendancesystem.frmAdmin()
        Me.FrmInventory1 = New attendancesystem.frmInventory()
        Me.FrmStock1 = New attendancesystem.frmStock()
        Me.panelTop.SuspendLayout()
        Me.panelControls.SuspendLayout()
        Me.panelName.SuspendLayout()
        Me.panelMenu.SuspendLayout()
        Me.panelbuttons.SuspendLayout()
        Me.dropdownStock.SuspendLayout()
        Me.dropdownUsers.SuspendLayout()
        Me.panelLogo.SuspendLayout()
        Me.panelFill.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panelTop.Controls.Add(Me.lblTitle)
        Me.panelTop.Controls.Add(Me.PictureBox1)
        Me.panelTop.Controls.Add(Me.panelControls)
        Me.panelTop.Controls.Add(Me.panelName)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Margin = New System.Windows.Forms.Padding(0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.ShadowDecoration.Parent = Me.panelTop
        Me.panelTop.Size = New System.Drawing.Size(1267, 36)
        Me.panelTop.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(275, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblTitle.Size = New System.Drawing.Size(807, 36)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "DASHBOARD"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelControls
        '
        Me.panelControls.BackColor = System.Drawing.Color.Transparent
        Me.panelControls.Controls.Add(Me.btnHide)
        Me.panelControls.Controls.Add(Me.btnMin)
        Me.panelControls.Controls.Add(Me.btnExit)
        Me.panelControls.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelControls.Location = New System.Drawing.Point(1082, 0)
        Me.panelControls.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelControls.Name = "panelControls"
        Me.panelControls.Padding = New System.Windows.Forms.Padding(0, 4, 13, 4)
        Me.panelControls.Size = New System.Drawing.Size(185, 36)
        Me.panelControls.TabIndex = 2
        '
        'panelName
        '
        Me.panelName.BackColor = System.Drawing.Color.Transparent
        Me.panelName.Controls.Add(Me.Label1)
        Me.panelName.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelName.Location = New System.Drawing.Point(0, 0)
        Me.panelName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelName.Name = "panelName"
        Me.panelName.ShadowDecoration.Parent = Me.panelName
        Me.panelName.Size = New System.Drawing.Size(236, 36)
        Me.panelName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(236, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AZ TECH"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.panelbuttons)
        Me.panelMenu.Controls.Add(Me.panelLogo)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 36)
        Me.panelMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.panelMenu.ShadowDecoration.Parent = Me.panelMenu
        Me.panelMenu.Size = New System.Drawing.Size(275, 764)
        Me.panelMenu.TabIndex = 1
        '
        'panelbuttons
        '
        Me.panelbuttons.BackColor = System.Drawing.Color.Transparent
        Me.panelbuttons.Controls.Add(Me.btnDatabase)
        Me.panelbuttons.Controls.Add(Me.btnSales)
        Me.panelbuttons.Controls.Add(Me.dropdownStock)
        Me.panelbuttons.Controls.Add(Me.btnStock)
        Me.panelbuttons.Controls.Add(Me.btnInventory)
        Me.panelbuttons.Controls.Add(Me.dropdownUsers)
        Me.panelbuttons.Controls.Add(Me.btnSignOut)
        Me.panelbuttons.Controls.Add(Me.btnUsersManagement)
        Me.panelbuttons.Controls.Add(Me.btnDashboard)
        Me.panelbuttons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelbuttons.Location = New System.Drawing.Point(0, 117)
        Me.panelbuttons.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelbuttons.Name = "panelbuttons"
        Me.panelbuttons.Padding = New System.Windows.Forms.Padding(13, 20, 13, 20)
        Me.panelbuttons.Size = New System.Drawing.Size(275, 647)
        Me.panelbuttons.TabIndex = 2
        '
        'dropdownStock
        '
        Me.dropdownStock.Controls.Add(Me.btnStockOut)
        Me.dropdownStock.Controls.Add(Me.btnStockIn)
        Me.dropdownStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.dropdownStock.Location = New System.Drawing.Point(13, 303)
        Me.dropdownStock.Margin = New System.Windows.Forms.Padding(4)
        Me.dropdownStock.Name = "dropdownStock"
        Me.dropdownStock.Size = New System.Drawing.Size(249, 106)
        Me.dropdownStock.TabIndex = 15
        '
        'btnStockOut
        '
        Me.btnStockOut.BorderRadius = 15
        Me.btnStockOut.CheckedState.Parent = Me.btnStockOut
        Me.btnStockOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStockOut.CustomImages.Parent = Me.btnStockOut
        Me.btnStockOut.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStockOut.FillColor = System.Drawing.Color.Transparent
        Me.btnStockOut.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockOut.ForeColor = System.Drawing.Color.White
        Me.btnStockOut.HoverState.BorderColor = System.Drawing.Color.Maroon
        Me.btnStockOut.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnStockOut.HoverState.Parent = Me.btnStockOut
        Me.btnStockOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStockOut.Location = New System.Drawing.Point(0, 47)
        Me.btnStockOut.Margin = New System.Windows.Forms.Padding(0)
        Me.btnStockOut.Name = "btnStockOut"
        Me.btnStockOut.ShadowDecoration.Parent = Me.btnStockOut
        Me.btnStockOut.Size = New System.Drawing.Size(249, 47)
        Me.btnStockOut.TabIndex = 5
        Me.btnStockOut.Text = "Stock Out"
        '
        'btnStockIn
        '
        Me.btnStockIn.BorderRadius = 15
        Me.btnStockIn.CheckedState.Parent = Me.btnStockIn
        Me.btnStockIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStockIn.CustomImages.Parent = Me.btnStockIn
        Me.btnStockIn.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStockIn.FillColor = System.Drawing.Color.Transparent
        Me.btnStockIn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockIn.ForeColor = System.Drawing.Color.White
        Me.btnStockIn.HoverState.BorderColor = System.Drawing.Color.Maroon
        Me.btnStockIn.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnStockIn.HoverState.Parent = Me.btnStockIn
        Me.btnStockIn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStockIn.Location = New System.Drawing.Point(0, 0)
        Me.btnStockIn.Margin = New System.Windows.Forms.Padding(0)
        Me.btnStockIn.Name = "btnStockIn"
        Me.btnStockIn.ShadowDecoration.Parent = Me.btnStockIn
        Me.btnStockIn.Size = New System.Drawing.Size(249, 47)
        Me.btnStockIn.TabIndex = 4
        Me.btnStockIn.Text = "Stock In"
        '
        'dropdownUsers
        '
        Me.dropdownUsers.Controls.Add(Me.btnUsers)
        Me.dropdownUsers.Controls.Add(Me.btnAdmin)
        Me.dropdownUsers.Dock = System.Windows.Forms.DockStyle.Top
        Me.dropdownUsers.Location = New System.Drawing.Point(13, 114)
        Me.dropdownUsers.Margin = New System.Windows.Forms.Padding(4)
        Me.dropdownUsers.Name = "dropdownUsers"
        Me.dropdownUsers.Size = New System.Drawing.Size(249, 95)
        Me.dropdownUsers.TabIndex = 10
        '
        'btnUsers
        '
        Me.btnUsers.BorderRadius = 15
        Me.btnUsers.CheckedState.Parent = Me.btnUsers
        Me.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsers.CustomImages.Parent = Me.btnUsers
        Me.btnUsers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsers.FillColor = System.Drawing.Color.Transparent
        Me.btnUsers.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.ForeColor = System.Drawing.Color.White
        Me.btnUsers.HoverState.BorderColor = System.Drawing.Color.Maroon
        Me.btnUsers.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnUsers.HoverState.Parent = Me.btnUsers
        Me.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUsers.Location = New System.Drawing.Point(0, 47)
        Me.btnUsers.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.ShadowDecoration.Parent = Me.btnUsers
        Me.btnUsers.Size = New System.Drawing.Size(249, 47)
        Me.btnUsers.TabIndex = 4
        Me.btnUsers.Text = "Users"
        '
        'btnAdmin
        '
        Me.btnAdmin.BorderRadius = 15
        Me.btnAdmin.CheckedState.Parent = Me.btnAdmin
        Me.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdmin.CustomImages.Parent = Me.btnAdmin
        Me.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAdmin.FillColor = System.Drawing.Color.Transparent
        Me.btnAdmin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAdmin.HoverState.BorderColor = System.Drawing.Color.Maroon
        Me.btnAdmin.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnAdmin.HoverState.Parent = Me.btnAdmin
        Me.btnAdmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdmin.Location = New System.Drawing.Point(0, 0)
        Me.btnAdmin.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.ShadowDecoration.Parent = Me.btnAdmin
        Me.btnAdmin.Size = New System.Drawing.Size(249, 47)
        Me.btnAdmin.TabIndex = 3
        Me.btnAdmin.Text = "Admin"
        '
        'panelLogo
        '
        Me.panelLogo.Controls.Add(Me.picLogo)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 20)
        Me.panelLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.ShadowDecoration.Parent = Me.panelLogo
        Me.panelLogo.Size = New System.Drawing.Size(275, 97)
        Me.panelLogo.TabIndex = 0
        '
        'panelFill
        '
        Me.panelFill.Controls.Add(Me.FrmDashboard1)
        Me.panelFill.Controls.Add(Me.FrmUsers1)
        Me.panelFill.Controls.Add(Me.FrmAdmin1)
        Me.panelFill.Controls.Add(Me.FrmInventory1)
        Me.panelFill.Controls.Add(Me.FrmStock1)
        Me.panelFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelFill.Location = New System.Drawing.Point(275, 36)
        Me.panelFill.Margin = New System.Windows.Forms.Padding(4)
        Me.panelFill.Name = "panelFill"
        Me.panelFill.Size = New System.Drawing.Size(992, 764)
        Me.panelFill.TabIndex = 2
        '
        'btnDatabase
        '
        Me.btnDatabase.BorderRadius = 15
        Me.btnDatabase.CheckedState.Parent = Me.btnDatabase
        Me.btnDatabase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDatabase.CustomImages.Parent = Me.btnDatabase
        Me.btnDatabase.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDatabase.FillColor = System.Drawing.Color.Transparent
        Me.btnDatabase.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDatabase.ForeColor = System.Drawing.Color.White
        Me.btnDatabase.HoverState.BorderColor = System.Drawing.Color.Maroon
        Me.btnDatabase.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnDatabase.HoverState.Parent = Me.btnDatabase
        Me.btnDatabase.Image = Global.attendancesystem.My.Resources.Resources.icons8_database_15
        Me.btnDatabase.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDatabase.Location = New System.Drawing.Point(13, 456)
        Me.btnDatabase.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDatabase.Name = "btnDatabase"
        Me.btnDatabase.ShadowDecoration.Parent = Me.btnDatabase
        Me.btnDatabase.Size = New System.Drawing.Size(249, 47)
        Me.btnDatabase.TabIndex = 17
        Me.btnDatabase.Text = "Backup/Restore"
        Me.btnDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnSales
        '
        Me.btnSales.BorderRadius = 15
        Me.btnSales.CheckedState.Parent = Me.btnSales
        Me.btnSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSales.CustomImages.Parent = Me.btnSales
        Me.btnSales.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSales.FillColor = System.Drawing.Color.Transparent
        Me.btnSales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSales.ForeColor = System.Drawing.Color.White
        Me.btnSales.HoverState.BorderColor = System.Drawing.Color.Maroon
        Me.btnSales.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnSales.HoverState.Parent = Me.btnSales
        Me.btnSales.Image = Global.attendancesystem.My.Resources.Resources.icons8_bar_graph_15
        Me.btnSales.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSales.Location = New System.Drawing.Point(13, 409)
        Me.btnSales.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.ShadowDecoration.Parent = Me.btnSales
        Me.btnSales.Size = New System.Drawing.Size(249, 47)
        Me.btnSales.TabIndex = 16
        Me.btnSales.Text = "Sales History"
        Me.btnSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnStock
        '
        Me.btnStock.BorderRadius = 15
        Me.btnStock.CheckedState.Parent = Me.btnStock
        Me.btnStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStock.CustomImages.Parent = Me.btnStock
        Me.btnStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStock.FillColor = System.Drawing.Color.Transparent
        Me.btnStock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStock.ForeColor = System.Drawing.Color.White
        Me.btnStock.HoverState.BorderColor = System.Drawing.Color.Maroon
        Me.btnStock.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnStock.HoverState.Parent = Me.btnStock
        Me.btnStock.Image = Global.attendancesystem.My.Resources.Resources.icons8_boxes_151
        Me.btnStock.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStock.Location = New System.Drawing.Point(13, 256)
        Me.btnStock.Margin = New System.Windows.Forms.Padding(0)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.ShadowDecoration.Parent = Me.btnStock
        Me.btnStock.Size = New System.Drawing.Size(249, 47)
        Me.btnStock.TabIndex = 12
        Me.btnStock.Text = "Stock"
        Me.btnStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnInventory
        '
        Me.btnInventory.BorderRadius = 15
        Me.btnInventory.CheckedState.Parent = Me.btnInventory
        Me.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventory.CustomImages.Parent = Me.btnInventory
        Me.btnInventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInventory.FillColor = System.Drawing.Color.Transparent
        Me.btnInventory.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.Color.White
        Me.btnInventory.HoverState.BorderColor = System.Drawing.Color.Maroon
        Me.btnInventory.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnInventory.HoverState.Parent = Me.btnInventory
        Me.btnInventory.Image = Global.attendancesystem.My.Resources.Resources.icons8_calendar_15
        Me.btnInventory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnInventory.Location = New System.Drawing.Point(13, 209)
        Me.btnInventory.Margin = New System.Windows.Forms.Padding(0)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.ShadowDecoration.Parent = Me.btnInventory
        Me.btnInventory.Size = New System.Drawing.Size(249, 47)
        Me.btnInventory.TabIndex = 11
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnSignOut
        '
        Me.btnSignOut.BorderRadius = 15
        Me.btnSignOut.CheckedState.Parent = Me.btnSignOut
        Me.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignOut.CustomImages.Parent = Me.btnSignOut
        Me.btnSignOut.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSignOut.FillColor = System.Drawing.Color.Transparent
        Me.btnSignOut.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignOut.ForeColor = System.Drawing.Color.White
        Me.btnSignOut.HoverState.BorderColor = System.Drawing.Color.Maroon
        Me.btnSignOut.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnSignOut.HoverState.Parent = Me.btnSignOut
        Me.btnSignOut.Image = Global.attendancesystem.My.Resources.Resources.icons8_sign_out_15
        Me.btnSignOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSignOut.Location = New System.Drawing.Point(13, 580)
        Me.btnSignOut.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.ShadowDecoration.Parent = Me.btnSignOut
        Me.btnSignOut.Size = New System.Drawing.Size(249, 47)
        Me.btnSignOut.TabIndex = 7
        Me.btnSignOut.Text = "SIgn Out"
        Me.btnSignOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnUsersManagement
        '
        Me.btnUsersManagement.BorderRadius = 15
        Me.btnUsersManagement.CheckedState.Parent = Me.btnUsersManagement
        Me.btnUsersManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsersManagement.CustomImages.Parent = Me.btnUsersManagement
        Me.btnUsersManagement.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsersManagement.FillColor = System.Drawing.Color.Transparent
        Me.btnUsersManagement.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsersManagement.ForeColor = System.Drawing.Color.White
        Me.btnUsersManagement.HoverState.BorderColor = System.Drawing.Color.Maroon
        Me.btnUsersManagement.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnUsersManagement.HoverState.Parent = Me.btnUsersManagement
        Me.btnUsersManagement.Image = Global.attendancesystem.My.Resources.Resources.icons8_person_15
        Me.btnUsersManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUsersManagement.Location = New System.Drawing.Point(13, 67)
        Me.btnUsersManagement.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUsersManagement.Name = "btnUsersManagement"
        Me.btnUsersManagement.ShadowDecoration.Parent = Me.btnUsersManagement
        Me.btnUsersManagement.Size = New System.Drawing.Size(249, 47)
        Me.btnUsersManagement.TabIndex = 2
        Me.btnUsersManagement.Text = "User Management"
        Me.btnUsersManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnDashboard
        '
        Me.btnDashboard.BorderRadius = 15
        Me.btnDashboard.CheckedState.Parent = Me.btnDashboard
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.CustomImages.Parent = Me.btnDashboard
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FillColor = System.Drawing.Color.Transparent
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.HoverState.BorderColor = System.Drawing.Color.Maroon
        Me.btnDashboard.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnDashboard.HoverState.Parent = Me.btnDashboard
        Me.btnDashboard.Image = Global.attendancesystem.My.Resources.Resources.icons8_laptop_15
        Me.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.Location = New System.Drawing.Point(13, 20)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.ShadowDecoration.Parent = Me.btnDashboard
        Me.btnDashboard.Size = New System.Drawing.Size(249, 47)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'picLogo
        '
        Me.picLogo.Image = Global.attendancesystem.My.Resources.Resources.logo_
        Me.picLogo.Location = New System.Drawing.Point(63, 0)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.picLogo.ShadowDecoration.Parent = Me.picLogo
        Me.picLogo.Size = New System.Drawing.Size(109, 97)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.attendancesystem.My.Resources.Resources.icons8_menu_15
        Me.PictureBox1.Location = New System.Drawing.Point(236, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnHide
        '
        Me.btnHide.CheckedState.Parent = Me.btnHide
        Me.btnHide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHide.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnHide.HoverState.Parent = Me.btnHide
        Me.btnHide.Image = Global.attendancesystem.My.Resources.Resources.icons8_minimize_15__1_
        Me.btnHide.ImageSize = New System.Drawing.Size(15, 16)
        Me.btnHide.Location = New System.Drawing.Point(3, 4)
        Me.btnHide.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.PressedState.Parent = Me.btnHide
        Me.btnHide.Size = New System.Drawing.Size(55, 28)
        Me.btnHide.TabIndex = 3
        '
        'btnMin
        '
        Me.btnMin.CheckedState.Parent = Me.btnMin
        Me.btnMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMin.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMin.HoverState.Parent = Me.btnMin
        Me.btnMin.Image = Global.attendancesystem.My.Resources.Resources.icons8_minimize_15
        Me.btnMin.ImageSize = New System.Drawing.Size(15, 16)
        Me.btnMin.Location = New System.Drawing.Point(58, 4)
        Me.btnMin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.PressedState.Parent = Me.btnMin
        Me.btnMin.Size = New System.Drawing.Size(63, 28)
        Me.btnMin.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.CheckedState.Parent = Me.btnExit
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExit.HoverState.Parent = Me.btnExit
        Me.btnExit.Image = Global.attendancesystem.My.Resources.Resources.icons8_x_15__1_
        Me.btnExit.ImageSize = New System.Drawing.Size(15, 16)
        Me.btnExit.Location = New System.Drawing.Point(121, 4)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.PressedState.Parent = Me.btnExit
        Me.btnExit.Size = New System.Drawing.Size(51, 28)
        Me.btnExit.TabIndex = 1
        '
        'FrmDashboard1
        '
        Me.FrmDashboard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmDashboard1.Location = New System.Drawing.Point(0, 0)
        Me.FrmDashboard1.Margin = New System.Windows.Forms.Padding(5)
        Me.FrmDashboard1.Name = "FrmDashboard1"
        Me.FrmDashboard1.Size = New System.Drawing.Size(992, 764)
        Me.FrmDashboard1.TabIndex = 0
        '
        'FrmUsers1
        '
        Me.FrmUsers1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmUsers1.Location = New System.Drawing.Point(0, 0)
        Me.FrmUsers1.Margin = New System.Windows.Forms.Padding(5)
        Me.FrmUsers1.Name = "FrmUsers1"
        Me.FrmUsers1.Size = New System.Drawing.Size(992, 764)
        Me.FrmUsers1.TabIndex = 2
        '
        'FrmAdmin1
        '
        Me.FrmAdmin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmAdmin1.Location = New System.Drawing.Point(0, 0)
        Me.FrmAdmin1.Margin = New System.Windows.Forms.Padding(5)
        Me.FrmAdmin1.Name = "FrmAdmin1"
        Me.FrmAdmin1.Size = New System.Drawing.Size(992, 764)
        Me.FrmAdmin1.TabIndex = 0
        '
        'FrmInventory1
        '
        Me.FrmInventory1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmInventory1.Location = New System.Drawing.Point(0, 0)
        Me.FrmInventory1.Margin = New System.Windows.Forms.Padding(4)
        Me.FrmInventory1.Name = "FrmInventory1"
        Me.FrmInventory1.Size = New System.Drawing.Size(992, 764)
        Me.FrmInventory1.TabIndex = 3
        '
        'FrmStock1
        '
        Me.FrmStock1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmStock1.Location = New System.Drawing.Point(0, 0)
        Me.FrmStock1.Name = "FrmStock1"
        Me.FrmStock1.Size = New System.Drawing.Size(992, 764)
        Me.FrmStock1.TabIndex = 4
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 800)
        Me.Controls.Add(Me.panelFill)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.panelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panelTop.ResumeLayout(False)
        Me.panelControls.ResumeLayout(False)
        Me.panelName.ResumeLayout(False)
        Me.panelMenu.ResumeLayout(False)
        Me.panelbuttons.ResumeLayout(False)
        Me.dropdownStock.ResumeLayout(False)
        Me.dropdownUsers.ResumeLayout(False)
        Me.panelLogo.ResumeLayout(False)
        Me.panelFill.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents panelTop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelName As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelLogo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents picLogo As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelbuttons As Panel
    Friend WithEvents btnUsersManagement As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents panelControls As Panel
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnHide As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnMin As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents lblTitle As Label
    Friend WithEvents btnSignOut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDatabase As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSales As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dropdownStock As Panel
    Friend WithEvents btnStock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnInventory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dropdownUsers As Panel
    Friend WithEvents btnAdmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUsers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnStockOut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnStockIn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelFill As Panel
    Friend WithEvents FrmUsers1 As frmUsers
    Friend WithEvents FrmDashboard1 As frmDashboard
    Friend WithEvents FrmAdmin1 As frmAdmin
    Friend WithEvents FrmInventory1 As frmInventory
    Friend WithEvents FrmStock1 As frmStock
End Class
