<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStock
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnManageStock = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblHigh = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblNormal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblCritical = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvStock = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(992, 52)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock Level:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cboCategory)
        Me.Panel2.Controls.Add(Me.txtSearch)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnManageStock)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(25, 5, 0, 5)
        Me.Panel2.Size = New System.Drawing.Size(992, 100)
        Me.Panel2.TabIndex = 1
        '
        'cboCategory
        '
        Me.cboCategory.BackColor = System.Drawing.Color.Transparent
        Me.cboCategory.BorderRadius = 5
        Me.cboCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.FillColor = System.Drawing.SystemColors.Control
        Me.cboCategory.FocusedColor = System.Drawing.Color.Empty
        Me.cboCategory.FocusedState.Parent = Me.cboCategory
        Me.cboCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.HoverState.Parent = Me.cboCategory
        Me.cboCategory.ItemHeight = 30
        Me.cboCategory.ItemsAppearance.Parent = Me.cboCategory
        Me.cboCategory.Location = New System.Drawing.Point(452, 59)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.ShadowDecoration.Parent = Me.cboCategory
        Me.cboCategory.Size = New System.Drawing.Size(234, 36)
        Me.cboCategory.StartIndex = 0
        Me.cboCategory.TabIndex = 9
        Me.cboCategory.TextOffset = New System.Drawing.Point(2, 0)
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
        Me.txtSearch.Location = New System.Drawing.Point(694, 58)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(285, 32)
        Me.txtSearch.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(370, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Category:"
        '
        'btnManageStock
        '
        Me.btnManageStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnManageStock.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnManageStock.BorderRadius = 5
        Me.btnManageStock.BorderThickness = 1
        Me.btnManageStock.CheckedState.Parent = Me.btnManageStock
        Me.btnManageStock.CustomImages.Parent = Me.btnManageStock
        Me.btnManageStock.FillColor = System.Drawing.Color.Transparent
        Me.btnManageStock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnManageStock.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnManageStock.HoverState.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnManageStock.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnManageStock.HoverState.Parent = Me.btnManageStock
        Me.btnManageStock.Location = New System.Drawing.Point(823, 13)
        Me.btnManageStock.Margin = New System.Windows.Forms.Padding(4)
        Me.btnManageStock.Name = "btnManageStock"
        Me.btnManageStock.ShadowDecoration.Parent = Me.btnManageStock
        Me.btnManageStock.Size = New System.Drawing.Size(156, 36)
        Me.btnManageStock.TabIndex = 6
        Me.btnManageStock.Text = "Manage Stock"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Guna2Panel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(25, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(367, 90)
        Me.Panel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Guna2Panel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(90, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.Panel4.Size = New System.Drawing.Size(264, 90)
        Me.Panel4.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Guna2Panel3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(115, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.Panel5.Size = New System.Drawing.Size(134, 90)
        Me.Panel5.TabIndex = 3
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderRadius = 2
        Me.Guna2Panel3.Controls.Add(Me.lblHigh)
        Me.Guna2Panel3.Controls.Add(Me.Label7)
        Me.Guna2Panel3.CustomBorderColor = System.Drawing.Color.Green
        Me.Guna2Panel3.CustomBorderThickness = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel3.Location = New System.Drawing.Point(25, 0)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(5)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(90, 90)
        Me.Guna2Panel3.TabIndex = 3
        '
        'lblHigh
        '
        Me.lblHigh.BackColor = System.Drawing.Color.Transparent
        Me.lblHigh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHigh.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHigh.ForeColor = System.Drawing.Color.Green
        Me.lblHigh.Location = New System.Drawing.Point(0, 40)
        Me.lblHigh.Name = "lblHigh"
        Me.lblHigh.Size = New System.Drawing.Size(90, 50)
        Me.lblHigh.TabIndex = 3
        Me.lblHigh.Text = "0"
        Me.lblHigh.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 40)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "High"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 2
        Me.Guna2Panel2.Controls.Add(Me.lblNormal)
        Me.Guna2Panel2.Controls.Add(Me.Label5)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.Orange
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel2.Location = New System.Drawing.Point(25, 0)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(90, 90)
        Me.Guna2Panel2.TabIndex = 2
        '
        'lblNormal
        '
        Me.lblNormal.BackColor = System.Drawing.Color.Transparent
        Me.lblNormal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNormal.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNormal.ForeColor = System.Drawing.Color.Orange
        Me.lblNormal.Location = New System.Drawing.Point(0, 40)
        Me.lblNormal.Name = "lblNormal"
        Me.lblNormal.Size = New System.Drawing.Size(90, 50)
        Me.lblNormal.TabIndex = 3
        Me.lblNormal.Text = "0"
        Me.lblNormal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 40)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Normal"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Red
        Me.Guna2Panel1.BorderRadius = 2
        Me.Guna2Panel1.Controls.Add(Me.lblCritical)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.Red
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(90, 90)
        Me.Guna2Panel1.TabIndex = 1
        '
        'lblCritical
        '
        Me.lblCritical.BackColor = System.Drawing.Color.Transparent
        Me.lblCritical.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCritical.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCritical.ForeColor = System.Drawing.Color.Red
        Me.lblCritical.Location = New System.Drawing.Point(0, 40)
        Me.lblCritical.Name = "lblCritical"
        Me.lblCritical.Size = New System.Drawing.Size(90, 50)
        Me.lblCritical.TabIndex = 1
        Me.lblCritical.Text = "0"
        Me.lblCritical.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 40)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Critical"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvStock
        '
        Me.dgvStock.AllowUserToAddRows = False
        Me.dgvStock.AllowUserToDeleteRows = False
        Me.dgvStock.AllowUserToOrderColumns = True
        Me.dgvStock.AllowUserToResizeColumns = False
        Me.dgvStock.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvStock.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvStock.BackgroundColor = System.Drawing.Color.White
        Me.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStock.ColumnHeadersHeight = 50
        Me.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.SlateBlue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStock.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStock.EnableHeadersVisualStyles = False
        Me.dgvStock.GridColor = System.Drawing.Color.White
        Me.dgvStock.Location = New System.Drawing.Point(19, 174)
        Me.dgvStock.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.ReadOnly = True
        Me.dgvStock.RowHeadersVisible = False
        Me.dgvStock.RowHeadersWidth = 51
        Me.dgvStock.RowTemplate.Height = 40
        Me.dgvStock.RowTemplate.ReadOnly = True
        Me.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStock.Size = New System.Drawing.Size(960, 573)
        Me.dgvStock.TabIndex = 4
        Me.dgvStock.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvStock.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvStock.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvStock.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvStock.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvStock.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvStock.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvStock.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgvStock.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvStock.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvStock.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStock.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvStock.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStock.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvStock.ThemeStyle.ReadOnly = True
        Me.dgvStock.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvStock.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStock.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStock.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.SlateBlue
        Me.dgvStock.ThemeStyle.RowsStyle.Height = 40
        Me.dgvStock.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.dgvStock.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'frmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvStock)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmStock"
        Me.Size = New System.Drawing.Size(992, 764)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblHigh As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblNormal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCritical As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnManageStock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cboCategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvStock As Guna.UI2.WinForms.Guna2DataGridView
End Class
