<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modalAddProducts
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
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProductName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSelect = New Guna.UI2.WinForms.Guna2Button()
        Me.btnConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.picProduct = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cboSupplier = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboBrand = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboCondition = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboLocation = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.picProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 25
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 50)
        Me.Panel1.TabIndex = 19
        '
        'btnExit
        '
        Me.btnExit.CheckedState.Parent = Me.btnExit
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExit.HoverState.Parent = Me.btnExit
        Me.btnExit.Image = Global.attendancesystem.My.Resources.Resources.icons8_x_15__1_
        Me.btnExit.ImageSize = New System.Drawing.Size(15, 16)
        Me.btnExit.Location = New System.Drawing.Point(727, 0)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.PressedState.Parent = Me.btnExit
        Me.btnExit.Size = New System.Drawing.Size(65, 50)
        Me.btnExit.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Product"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 28)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Product Name"
        '
        'txtProductName
        '
        Me.txtProductName.BorderColor = System.Drawing.Color.Black
        Me.txtProductName.BorderRadius = 5
        Me.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductName.DefaultText = ""
        Me.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductName.DisabledState.Parent = Me.txtProductName
        Me.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductName.FocusedState.Parent = Me.txtProductName
        Me.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductName.HoverState.Parent = Me.txtProductName
        Me.txtProductName.Location = New System.Drawing.Point(37, 126)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProductName.PlaceholderText = ""
        Me.txtProductName.SelectedText = ""
        Me.txtProductName.ShadowDecoration.Parent = Me.txtProductName
        Me.txtProductName.Size = New System.Drawing.Size(217, 33)
        Me.txtProductName.TabIndex = 21
        '
        'txtQuantity
        '
        Me.txtQuantity.BorderColor = System.Drawing.Color.Black
        Me.txtQuantity.BorderRadius = 5
        Me.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQuantity.DefaultText = ""
        Me.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantity.DisabledState.Parent = Me.txtQuantity
        Me.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQuantity.FocusedState.Parent = Me.txtQuantity
        Me.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQuantity.HoverState.Parent = Me.txtQuantity
        Me.txtQuantity.Location = New System.Drawing.Point(287, 126)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQuantity.PlaceholderText = ""
        Me.txtQuantity.SelectedText = ""
        Me.txtQuantity.ShadowDecoration.Parent = Me.txtQuantity
        Me.txtQuantity.Size = New System.Drawing.Size(239, 33)
        Me.txtQuantity.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(283, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 28)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Quantity (Initial Stock)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 28)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Brand"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(284, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 28)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Condition"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 28)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Type"
        '
        'txtNumber
        '
        Me.txtNumber.BorderColor = System.Drawing.Color.Black
        Me.txtNumber.BorderRadius = 5
        Me.txtNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumber.DefaultText = ""
        Me.txtNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumber.DisabledState.Parent = Me.txtNumber
        Me.txtNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumber.Enabled = False
        Me.txtNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNumber.FocusedState.Parent = Me.txtNumber
        Me.txtNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNumber.HoverState.Parent = Me.txtNumber
        Me.txtNumber.Location = New System.Drawing.Point(551, 391)
        Me.txtNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumber.PlaceholderText = ""
        Me.txtNumber.SelectedText = ""
        Me.txtNumber.ShadowDecoration.Parent = Me.txtNumber
        Me.txtNumber.Size = New System.Drawing.Size(215, 36)
        Me.txtNumber.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(546, 355)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 28)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Serial Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(35, 355)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 28)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Unit Price (Php)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(282, 279)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 28)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Supplier Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(280, 350)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(173, 28)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Product Location"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(546, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 28)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Image:"
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCancel.BorderColor = System.Drawing.Color.Tomato
        Me.btnCancel.BorderRadius = 5
        Me.btnCancel.BorderThickness = 1
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.Color.Transparent
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.Tomato
        Me.btnCancel.HoverState.FillColor = System.Drawing.Color.Tomato
        Me.btnCancel.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(547, 498)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(112, 36)
        Me.btnCancel.TabIndex = 42
        Me.btnCancel.Text = "Cancel"
        '
        'btnSelect
        '
        Me.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSelect.BorderColor = System.Drawing.Color.LimeGreen
        Me.btnSelect.BorderRadius = 5
        Me.btnSelect.BorderThickness = 1
        Me.btnSelect.CheckedState.Parent = Me.btnSelect
        Me.btnSelect.CustomImages.Parent = Me.btnSelect
        Me.btnSelect.FillColor = System.Drawing.Color.Transparent
        Me.btnSelect.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSelect.ForeColor = System.Drawing.Color.LimeGreen
        Me.btnSelect.HoverState.FillColor = System.Drawing.Color.LimeGreen
        Me.btnSelect.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnSelect.HoverState.Parent = Me.btnSelect
        Me.btnSelect.Location = New System.Drawing.Point(667, 101)
        Me.btnSelect.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.ShadowDecoration.Parent = Me.btnSelect
        Me.btnSelect.Size = New System.Drawing.Size(106, 36)
        Me.btnSelect.TabIndex = 43
        Me.btnSelect.Text = "Select"
        '
        'btnConfirm
        '
        Me.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnConfirm.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnConfirm.BorderRadius = 5
        Me.btnConfirm.BorderThickness = 1
        Me.btnConfirm.CheckedState.Parent = Me.btnConfirm
        Me.btnConfirm.CustomImages.Parent = Me.btnConfirm
        Me.btnConfirm.FillColor = System.Drawing.Color.Transparent
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnConfirm.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnConfirm.HoverState.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnConfirm.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnConfirm.HoverState.Parent = Me.btnConfirm
        Me.btnConfirm.Location = New System.Drawing.Point(667, 498)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.ShadowDecoration.Parent = Me.btnConfirm
        Me.btnConfirm.Size = New System.Drawing.Size(106, 36)
        Me.btnConfirm.TabIndex = 44
        Me.btnConfirm.Text = "Confirm"
        '
        'picProduct
        '
        Me.picProduct.BackColor = System.Drawing.Color.White
        Me.picProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picProduct.Location = New System.Drawing.Point(551, 156)
        Me.picProduct.Name = "picProduct"
        Me.picProduct.ShadowDecoration.Parent = Me.picProduct
        Me.picProduct.Size = New System.Drawing.Size(222, 177)
        Me.picProduct.TabIndex = 39
        Me.picProduct.TabStop = False
        '
        'txtPrice
        '
        Me.txtPrice.BorderColor = System.Drawing.Color.Black
        Me.txtPrice.BorderRadius = 5
        Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.DefaultText = ""
        Me.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.DisabledState.Parent = Me.txtPrice
        Me.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.FocusedState.Parent = Me.txtPrice
        Me.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.HoverState.Parent = Me.txtPrice
        Me.txtPrice.IconLeft = Global.attendancesystem.My.Resources.Resources.icons8_peso_symbol_15
        Me.txtPrice.Location = New System.Drawing.Point(40, 387)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.PlaceholderText = ""
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.ShadowDecoration.Parent = Me.txtPrice
        Me.txtPrice.Size = New System.Drawing.Size(217, 36)
        Me.txtPrice.TabIndex = 33
        Me.txtPrice.TextOffset = New System.Drawing.Point(5, 0)
        '
        'cboSupplier
        '
        Me.cboSupplier.BackColor = System.Drawing.Color.Transparent
        Me.cboSupplier.BorderColor = System.Drawing.SystemColors.Control
        Me.cboSupplier.BorderRadius = 5
        Me.cboSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSupplier.FillColor = System.Drawing.SystemColors.Control
        Me.cboSupplier.FocusedColor = System.Drawing.Color.Empty
        Me.cboSupplier.FocusedState.Parent = Me.cboSupplier
        Me.cboSupplier.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboSupplier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.HoverState.Parent = Me.cboSupplier
        Me.cboSupplier.ItemHeight = 30
        Me.cboSupplier.ItemsAppearance.Parent = Me.cboSupplier
        Me.cboSupplier.Location = New System.Drawing.Point(285, 311)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.ShadowDecoration.Parent = Me.cboSupplier
        Me.cboSupplier.Size = New System.Drawing.Size(241, 36)
        Me.cboSupplier.TabIndex = 45
        '
        'cboType
        '
        Me.cboType.BackColor = System.Drawing.Color.Transparent
        Me.cboType.BorderColor = System.Drawing.SystemColors.Control
        Me.cboType.BorderRadius = 5
        Me.cboType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FillColor = System.Drawing.SystemColors.Control
        Me.cboType.FocusedColor = System.Drawing.Color.Empty
        Me.cboType.FocusedState.Parent = Me.cboType
        Me.cboType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboType.FormattingEnabled = True
        Me.cboType.HoverState.Parent = Me.cboType
        Me.cboType.ItemHeight = 30
        Me.cboType.Items.AddRange(New Object() {"Mobile Devices", "Phone Accessories", "Audio Devices", "Storage Devices"})
        Me.cboType.ItemsAppearance.Parent = Me.cboType
        Me.cboType.Location = New System.Drawing.Point(39, 297)
        Me.cboType.Name = "cboType"
        Me.cboType.ShadowDecoration.Parent = Me.cboType
        Me.cboType.Size = New System.Drawing.Size(216, 36)
        Me.cboType.StartIndex = 0
        Me.cboType.TabIndex = 46
        '
        'cboBrand
        '
        Me.cboBrand.BackColor = System.Drawing.Color.Transparent
        Me.cboBrand.BorderColor = System.Drawing.SystemColors.Control
        Me.cboBrand.BorderRadius = 5
        Me.cboBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBrand.FillColor = System.Drawing.SystemColors.Control
        Me.cboBrand.FocusedColor = System.Drawing.Color.Empty
        Me.cboBrand.FocusedState.Parent = Me.cboBrand
        Me.cboBrand.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboBrand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboBrand.FormattingEnabled = True
        Me.cboBrand.HoverState.Parent = Me.cboBrand
        Me.cboBrand.ItemHeight = 30
        Me.cboBrand.ItemsAppearance.Parent = Me.cboBrand
        Me.cboBrand.Location = New System.Drawing.Point(39, 213)
        Me.cboBrand.Name = "cboBrand"
        Me.cboBrand.ShadowDecoration.Parent = Me.cboBrand
        Me.cboBrand.Size = New System.Drawing.Size(216, 36)
        Me.cboBrand.TabIndex = 47
        '
        'cboCondition
        '
        Me.cboCondition.BackColor = System.Drawing.Color.Transparent
        Me.cboCondition.BorderColor = System.Drawing.SystemColors.Control
        Me.cboCondition.BorderRadius = 5
        Me.cboCondition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCondition.FillColor = System.Drawing.SystemColors.Control
        Me.cboCondition.FocusedColor = System.Drawing.Color.Empty
        Me.cboCondition.FocusedState.Parent = Me.cboCondition
        Me.cboCondition.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboCondition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboCondition.FormattingEnabled = True
        Me.cboCondition.HoverState.Parent = Me.cboCondition
        Me.cboCondition.ItemHeight = 30
        Me.cboCondition.Items.AddRange(New Object() {"Brand New", "2nd Hand"})
        Me.cboCondition.ItemsAppearance.Parent = Me.cboCondition
        Me.cboCondition.Location = New System.Drawing.Point(289, 213)
        Me.cboCondition.Name = "cboCondition"
        Me.cboCondition.ShadowDecoration.Parent = Me.cboCondition
        Me.cboCondition.Size = New System.Drawing.Size(237, 36)
        Me.cboCondition.StartIndex = 0
        Me.cboCondition.TabIndex = 48
        '
        'cboLocation
        '
        Me.cboLocation.BackColor = System.Drawing.Color.Transparent
        Me.cboLocation.BorderColor = System.Drawing.SystemColors.Control
        Me.cboLocation.BorderRadius = 5
        Me.cboLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocation.FillColor = System.Drawing.SystemColors.Control
        Me.cboLocation.FocusedColor = System.Drawing.Color.Empty
        Me.cboLocation.FocusedState.Parent = Me.cboLocation
        Me.cboLocation.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.HoverState.Parent = Me.cboLocation
        Me.cboLocation.ItemHeight = 30
        Me.cboLocation.Items.AddRange(New Object() {"Inventory Shelf A", "Inventory Shelf B", "Storage Room A", "Storage Room B"})
        Me.cboLocation.ItemsAppearance.Parent = Me.cboLocation
        Me.cboLocation.Location = New System.Drawing.Point(285, 391)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.ShadowDecoration.Parent = Me.cboLocation
        Me.cboLocation.Size = New System.Drawing.Size(241, 36)
        Me.cboLocation.StartIndex = 0
        Me.cboLocation.TabIndex = 49
        '
        'modalAddProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 564)
        Me.Controls.Add(Me.cboLocation)
        Me.Controls.Add(Me.cboCondition)
        Me.Controls.Add(Me.cboBrand)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.cboSupplier)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.picProduct)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "modalAddProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "modalAddProducts"
        Me.Panel1.ResumeLayout(False)
        CType(Me.picProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProductName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents picProduct As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSelect As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cboLocation As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboCondition As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboBrand As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboSupplier As Guna.UI2.WinForms.Guna2ComboBox
End Class
