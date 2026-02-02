Public Class frmStock

    Private Const CRITICAL_STOCK As Integer = 5
    Private Const NORMAL_STOCK As Integer = 10

    Public Sub LoadCategoriesToComboBox()
        Try
            ' Add category options to ComboBox
            cboCategory.Items.Clear()
            cboCategory.Items.Add("Mobile Devices")
            cboCategory.Items.Add("Phone Accessories")
            cboCategory.Items.Add("Audio Devices")
            cboCategory.Items.Add("Storage Devices")

            ' Set default selection
            If cboCategory.Items.Count > 0 Then
                cboCategory.SelectedIndex = 0
            End If

        Catch ex As Exception
            MsgBox($"Error: {ex.Message}")
        End Try
    End Sub
    Public Sub fetchMobileDevices()
        Try
            Connection.Query("SELECT * FROM Products WHERE ProductType = 'Mobile Devices'")

            If Connection.Datacount > 0 Then
                dgvStock.DataSource = Connection.Data.Tables(0)
                CheckLowStock()
                UpdateStockCounts()
            Else
                MsgBox("No data found.")
                dgvStock.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Public Sub fetchPhoneAccessories()
        Try
            Connection.Query("SELECT * FROM Products WHERE ProductType = 'Phone Accessories'")

            If Connection.Datacount > 0 Then
                dgvStock.DataSource = Connection.Data.Tables(0)
                CheckLowStock()
                UpdateStockCounts()
            Else
                MsgBox("No data found.")
                dgvStock.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Public Sub fetchAudioDevices()
        Try
            Connection.Query("SELECT * FROM Products WHERE ProductType = 'Audio Devices'")

            If Connection.Datacount > 0 Then
                dgvStock.DataSource = Connection.Data.Tables(0)
                CheckLowStock()
                UpdateStockCounts()
            Else
                MsgBox("No data found.")
                dgvStock.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Public Sub fetchStorageDevices()
        Try
            Connection.Query("SELECT * FROM Products WHERE ProductType = 'Storage Devices'")

            If Connection.Datacount > 0 Then
                dgvStock.DataSource = Connection.Data.Tables(0)
                CheckLowStock()
                UpdateStockCounts()
            Else
                MsgBox("No data found.")
                dgvStock.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    ' Function to check and notify low stock
    Public Sub CheckLowStock()
        Try
            Dim criticalItems As New List(Of String)
            Dim normalItems As New List(Of String)

            ' Check each row for low stock
            For Each row As DataRow In Connection.Data.Tables(0).Rows
                Dim stockQuantity As Integer = Convert.ToInt32(row("Quantity"))
                Dim productName As String = row("ItemName").ToString()

                If stockQuantity <= CRITICAL_STOCK Then
                    criticalItems.Add($"{productName} ({stockQuantity} units)")
                ElseIf stockQuantity <= NORMAL_STOCK Then
                    normalItems.Add($"{productName} ({stockQuantity} units)")
                End If
            Next

            ' Display notification if there are critical or low stock items
            If criticalItems.Count > 0 Then
                Dim message As String = "CRITICAL STOCK ALERT!" & vbNewLine & vbNewLine
                message &= String.Join(vbNewLine, criticalItems)
                MsgBox(message, MsgBoxStyle.Critical, "Critical Stock Warning")
            ElseIf normalItems.Count > 0 Then
                Dim message As String = "Low Stock Warning!" & vbNewLine & vbNewLine
                message &= String.Join(vbNewLine, normalItems)
                MsgBox(message, MsgBoxStyle.Exclamation, "Low Stock Alert")
            End If

        Catch ex As Exception
            MsgBox($"Error checking stock: {ex.Message}")
        End Try
    End Sub

    ' NEW FUNCTION: Count and display stock levels
    Public Sub UpdateStockCounts()
        Try
            Dim criticalCount As Integer = 0
            Dim lowCount As Integer = 0
            Dim normalCount As Integer = 0

            ' Count items in each category
            For Each row As DataRow In Connection.Data.Tables(0).Rows
                Dim stockQuantity As Integer = Convert.ToInt32(row("Quantity"))

                If stockQuantity <= CRITICAL_STOCK Then
                    criticalCount += 1
                ElseIf stockQuantity <= NORMAL_STOCK Then
                    lowCount += 1
                Else
                    normalCount += 1
                End If
            Next

            ' Update labels (make sure these label names match yours)
            lblCritical.Text = criticalCount.ToString()
            lblNormal.Text = lowCount.ToString()
            lblHigh.Text = normalCount.ToString()

        Catch ex As Exception
            MsgBox($"Error updating stock counts: {ex.Message}")
        End Try
    End Sub

    ' NEW FUNCTION: Clear stock counts when no data
    Public Sub ClearStockCounts()
        lblCritical.Text = "0"
        lblNormal.Text = "0"
        lblHigh.Text = "0"
    End Sub

    Private Sub dgvStock_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        Try
            If dgvStock.Columns(e.ColumnIndex).Name = "Quantity" OrElse e.ColumnIndex >= 0 Then
                If dgvStock.Rows(e.RowIndex).Cells("ItemName").Value IsNot Nothing Then
                    Dim stockQuantity As Integer = Convert.ToInt32(dgvStock.Rows(e.RowIndex).Cells("Quantity").Value)

                    If stockQuantity <= CRITICAL_STOCK Then
                        ' Critical stock - Red background
                        dgvStock.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightCoral
                        dgvStock.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
                        dgvStock.Rows(e.RowIndex).DefaultCellStyle.Font = New Font(dgvStock.Font, FontStyle.Bold)
                    ElseIf stockQuantity <= NORMAL_STOCK Then
                        ' Low stock - Yellow background
                        dgvStock.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow
                        dgvStock.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
                    Else
                        ' Normal stock - Default colors
                        dgvStock.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
                        dgvStock.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
                        dgvStock.Rows(e.RowIndex).DefaultCellStyle.Font = New Font(dgvStock.Font, FontStyle.Regular)
                    End If
                End If
            End If
        Catch ex As Exception
            ' Silently handle formatting errors
        End Try
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
        Select Case cboCategory.SelectedItem.ToString()
            Case "Mobile Devices"
                fetchMobileDevices()
            Case "Phone Accessories"
                fetchPhoneAccessories()
            Case "Audio Devices"
                fetchAudioDevices()
            Case "Storage Devices"
                fetchStorageDevices()
        End Select
    End Sub

    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadCategoriesToComboBox()
    End Sub

    Private Sub dgvStock_SelectionChanged(sender As Object, e As EventArgs)
        dgvStock.ClearSelection()
    End Sub
End Class
