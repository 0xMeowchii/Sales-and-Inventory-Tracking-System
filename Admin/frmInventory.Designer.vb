<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvInventory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMobileDevices = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPhoneAcce = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAudio = New Guna.UI2.WinForms.Guna2Button()
        Me.btnStorageDevices = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAll = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 64)
        Me.Panel1.TabIndex = 1
        '
        'txtSearch
        '
        Me.txtSearch.BorderRadius = 5
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.Parent = Me.txtSearch
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.FocusedState.Parent = Me.txtSearch
        Me.txtSearch.ForeColor = System.Drawing.Color.DimGray
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.IconLeft = Global.attendancesystem.My.Resources.Resources.icons8_magnifier_15
        Me.txtSearch.Location = New System.Drawing.Point(688, 17)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(285, 32)
        Me.txtSearch.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(67, 0)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(268, 64)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Product/s"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotal
        '
        Me.lblTotal.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(0, 0)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(67, 64)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.BorderColor = System.Drawing.Color.ForestGreen
        Me.btnAdd.BorderRadius = 5
        Me.btnAdd.BorderThickness = 1
        Me.btnAdd.CheckedState.Parent = Me.btnAdd
        Me.btnAdd.CustomImages.Parent = Me.btnAdd
        Me.btnAdd.FillColor = System.Drawing.Color.Transparent
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnAdd.HoverState.FillColor = System.Drawing.Color.ForestGreen
        Me.btnAdd.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAdd.HoverState.Parent = Me.btnAdd
        Me.btnAdd.Location = New System.Drawing.Point(817, 79)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.Size = New System.Drawing.Size(156, 36)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add  Product"
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToAddRows = False
        Me.dgvInventory.AllowUserToDeleteRows = False
        Me.dgvInventory.AllowUserToOrderColumns = True
        Me.dgvInventory.AllowUserToResizeColumns = False
        Me.dgvInventory.AllowUserToResizeRows = False
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.dgvInventory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvInventory.BackgroundColor = System.Drawing.Color.White
        Me.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvInventory.ColumnHeadersHeight = 50
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.SlateBlue
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInventory.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvInventory.EnableHeadersVisualStyles = False
        Me.dgvInventory.GridColor = System.Drawing.Color.White
        Me.dgvInventory.Location = New System.Drawing.Point(22, 129)
        Me.dgvInventory.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.ReadOnly = True
        Me.dgvInventory.RowHeadersVisible = False
        Me.dgvInventory.RowHeadersWidth = 51
        Me.dgvInventory.RowTemplate.Height = 40
        Me.dgvInventory.RowTemplate.ReadOnly = True
        Me.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventory.Size = New System.Drawing.Size(951, 549)
        Me.dgvInventory.TabIndex = 8
        Me.dgvInventory.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvInventory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvInventory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvInventory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvInventory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvInventory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvInventory.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvInventory.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgvInventory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvInventory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvInventory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvInventory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvInventory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvInventory.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvInventory.ThemeStyle.ReadOnly = True
        Me.dgvInventory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvInventory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvInventory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvInventory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.SlateBlue
        Me.dgvInventory.ThemeStyle.RowsStyle.Height = 40
        Me.dgvInventory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvInventory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDelete.BorderColor = System.Drawing.Color.Tomato
        Me.btnDelete.BorderRadius = 5
        Me.btnDelete.BorderThickness = 1
        Me.btnDelete.CheckedState.Parent = Me.btnDelete
        Me.btnDelete.CustomImages.Parent = Me.btnDelete
        Me.btnDelete.FillColor = System.Drawing.Color.Transparent
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.Tomato
        Me.btnDelete.HoverState.FillColor = System.Drawing.Color.Tomato
        Me.btnDelete.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.HoverState.Parent = Me.btnDelete
        Me.btnDelete.Location = New System.Drawing.Point(854, 710)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(119, 36)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        '
        'btnEdit
        '
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEdit.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnEdit.BorderRadius = 5
        Me.btnEdit.BorderThickness = 1
        Me.btnEdit.CheckedState.Parent = Me.btnEdit
        Me.btnEdit.CustomImages.Parent = Me.btnEdit
        Me.btnEdit.FillColor = System.Drawing.Color.Transparent
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnEdit.HoverState.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnEdit.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.HoverState.Parent = Me.btnEdit
        Me.btnEdit.Location = New System.Drawing.Point(715, 710)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShadowDecoration.Parent = Me.btnEdit
        Me.btnEdit.Size = New System.Drawing.Size(119, 36)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "Edit"
        '
        'btnMobileDevices
        '
        Me.btnMobileDevices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMobileDevices.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.btnMobileDevices.BorderRadius = 5
        Me.btnMobileDevices.BorderThickness = 1
        Me.btnMobileDevices.CheckedState.Parent = Me.btnMobileDevices
        Me.btnMobileDevices.CustomImages.Parent = Me.btnMobileDevices
        Me.btnMobileDevices.FillColor = System.Drawing.Color.Transparent
        Me.btnMobileDevices.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMobileDevices.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btnMobileDevices.HoverState.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.btnMobileDevices.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnMobileDevices.HoverState.Parent = Me.btnMobileDevices
        Me.btnMobileDevices.Location = New System.Drawing.Point(102, 79)
        Me.btnMobileDevices.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMobileDevices.Name = "btnMobileDevices"
        Me.btnMobileDevices.ShadowDecoration.Parent = Me.btnMobileDevices
        Me.btnMobileDevices.Size = New System.Drawing.Size(144, 36)
        Me.btnMobileDevices.TabIndex = 10
        Me.btnMobileDevices.Text = "Mobile Devices"
        '
        'btnPhoneAcce
        '
        Me.btnPhoneAcce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPhoneAcce.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.btnPhoneAcce.BorderRadius = 5
        Me.btnPhoneAcce.BorderThickness = 1
        Me.btnPhoneAcce.CheckedState.Parent = Me.btnPhoneAcce
        Me.btnPhoneAcce.CustomImages.Parent = Me.btnPhoneAcce
        Me.btnPhoneAcce.FillColor = System.Drawing.Color.Transparent
        Me.btnPhoneAcce.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPhoneAcce.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btnPhoneAcce.HoverState.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.btnPhoneAcce.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnPhoneAcce.HoverState.Parent = Me.btnPhoneAcce
        Me.btnPhoneAcce.Location = New System.Drawing.Point(254, 79)
        Me.btnPhoneAcce.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPhoneAcce.Name = "btnPhoneAcce"
        Me.btnPhoneAcce.ShadowDecoration.Parent = Me.btnPhoneAcce
        Me.btnPhoneAcce.Size = New System.Drawing.Size(144, 36)
        Me.btnPhoneAcce.TabIndex = 11
        Me.btnPhoneAcce.Text = "Phone Accessories"
        '
        'btnAudio
        '
        Me.btnAudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAudio.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.btnAudio.BorderRadius = 5
        Me.btnAudio.BorderThickness = 1
        Me.btnAudio.CheckedState.Parent = Me.btnAudio
        Me.btnAudio.CustomImages.Parent = Me.btnAudio
        Me.btnAudio.FillColor = System.Drawing.Color.Transparent
        Me.btnAudio.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAudio.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btnAudio.HoverState.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.btnAudio.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAudio.HoverState.Parent = Me.btnAudio
        Me.btnAudio.Location = New System.Drawing.Point(406, 79)
        Me.btnAudio.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAudio.Name = "btnAudio"
        Me.btnAudio.ShadowDecoration.Parent = Me.btnAudio
        Me.btnAudio.Size = New System.Drawing.Size(130, 36)
        Me.btnAudio.TabIndex = 12
        Me.btnAudio.Text = "Audio Devices"
        '
        'btnStorageDevices
        '
        Me.btnStorageDevices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnStorageDevices.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.btnStorageDevices.BorderRadius = 5
        Me.btnStorageDevices.BorderThickness = 1
        Me.btnStorageDevices.CheckedState.Parent = Me.btnStorageDevices
        Me.btnStorageDevices.CustomImages.Parent = Me.btnStorageDevices
        Me.btnStorageDevices.FillColor = System.Drawing.Color.Transparent
        Me.btnStorageDevices.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnStorageDevices.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btnStorageDevices.HoverState.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.btnStorageDevices.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnStorageDevices.HoverState.Parent = Me.btnStorageDevices
        Me.btnStorageDevices.Location = New System.Drawing.Point(544, 79)
        Me.btnStorageDevices.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStorageDevices.Name = "btnStorageDevices"
        Me.btnStorageDevices.ShadowDecoration.Parent = Me.btnStorageDevices
        Me.btnStorageDevices.Size = New System.Drawing.Size(131, 36)
        Me.btnStorageDevices.TabIndex = 13
        Me.btnStorageDevices.Text = "Storage Devices"
        '
        'btnAll
        '
        Me.btnAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAll.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.btnAll.BorderRadius = 5
        Me.btnAll.BorderThickness = 1
        Me.btnAll.CheckedState.Parent = Me.btnAll
        Me.btnAll.CustomImages.Parent = Me.btnAll
        Me.btnAll.FillColor = System.Drawing.Color.Transparent
        Me.btnAll.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAll.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.btnAll.HoverState.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.btnAll.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAll.HoverState.Parent = Me.btnAll
        Me.btnAll.Location = New System.Drawing.Point(22, 79)
        Me.btnAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.ShadowDecoration.Parent = Me.btnAll
        Me.btnAll.Size = New System.Drawing.Size(72, 36)
        Me.btnAll.TabIndex = 14
        Me.btnAll.Text = "All"
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.btnStorageDevices)
        Me.Controls.Add(Me.btnAudio)
        Me.Controls.Add(Me.btnPhoneAcce)
        Me.Controls.Add(Me.btnMobileDevices)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvInventory)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmInventory"
        Me.Size = New System.Drawing.Size(992, 764)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvInventory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMobileDevices As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPhoneAcce As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAudio As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnStorageDevices As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAll As Guna.UI2.WinForms.Guna2Button
End Class
