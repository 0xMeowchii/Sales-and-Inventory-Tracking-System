Public Class frmInventory

    Public Sub fetchProducts()
        Try
            Connection.Query("SELECT * FROM Products")
            If Connection.Datacount > 0 Then
                dgvInventory.DataSource = Connection.Data.Tables(0)
            Else
                MsgBox("No data found.")
                dgvInventory.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Public Sub fetchMobileDevices()
        Try
            Connection.Query("SELECT * FROM Products WHERE ProductType = 'Mobile Devices'")

            If Connection.Datacount > 0 Then
                dgvInventory.DataSource = Connection.Data.Tables(0)
            Else
                MsgBox("No data found.")
                dgvInventory.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Public Sub fetchPhoneAccessories()
        Try
            Connection.Query("SELECT * FROM Products WHERE ProductType = 'Phone Accessories'")

            If Connection.Datacount > 0 Then
                dgvInventory.DataSource = Connection.Data.Tables(0)
            Else
                MsgBox("No data found.")
                dgvInventory.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Public Sub fetchAudioDevices()
        Try
            Connection.Query("SELECT * FROM Products WHERE ProductType = 'Audio Devices'")

            If Connection.Datacount > 0 Then
                dgvInventory.DataSource = Connection.Data.Tables(0)
            Else
                MsgBox("No data found.")
                dgvInventory.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Public Sub fetchStorageDevices()
        Try
            Connection.Query("SELECT * FROM Products WHERE ProductType = 'Storage Devices'")

            If Connection.Datacount > 0 Then
                dgvInventory.DataSource = Connection.Data.Tables(0)
            Else
                MsgBox("No data found.")
                dgvInventory.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Public Sub TotalProducts()
        Connection.Query("SELECT count(*) as TotalProducts FROM Products")
        If Connection.Datacount > 0 Then
            lblTotal.Text = Connection.Data.Tables(0).Rows(0)("TotalProducts").ToString()
        Else
            lblTotal.Text = "0"
        End If
    End Sub

    Public Sub TotalMobileDevies()
        Connection.Query("SELECT count(*) as TotalMobileDevices FROM Products WHERE ProductType = 'Mobile Devices'")

        If Connection.Datacount > 0 Then
            lblTotal.Text = Connection.Data.Tables(0).Rows(0)("TotalMobileDevices").ToString()
        Else
            lblTotal.Text = "0"
        End If
    End Sub

    Public Sub TotalPhoneAccessories()
        Connection.Query("SELECT count(*) as TotalPhoneAccessories FROM Products WHERE ProductType = 'Phone Accessories'")

        If Connection.Datacount > 0 Then
            lblTotal.Text = Connection.Data.Tables(0).Rows(0)("TotalPhoneAccessories").ToString()
        Else
            lblTotal.Text = "0"
        End If
    End Sub

    Public Sub TotalAudioDevices()
        Connection.Query("SELECT count(*) as TotalAudioDevices FROM Products WHERE ProductType = 'Audio Devices'")

        If Connection.Datacount > 0 Then
            lblTotal.Text = Connection.Data.Tables(0).Rows(0)("TotalAudioDevices").ToString()
        Else
            lblTotal.Text = "0"
        End If
    End Sub

    Public Sub TotalStorageDevices()
        Connection.Query("SELECT count(*) as TotalStorageDevices FROM Products WHERE ProductType = 'Storage Devices'")

        If Connection.Datacount > 0 Then
            lblTotal.Text = Connection.Data.Tables(0).Rows(0)("TotalStorageDevices").ToString()
        Else
            lblTotal.Text = "0"
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnPhoneAcce.Click
        lblName.Text = "Phone Accessories"
        TotalPhoneAccessories()
        fetchPhoneAccessories()

    End Sub

    Private Sub btnMobileDevices_Click(sender As Object, e As EventArgs) Handles btnMobileDevices.Click
        lblName.Text = "Mobile Devices"
        TotalMobileDevies()
        fetchMobileDevices()
    End Sub

    Private Sub btnAudio_Click(sender As Object, e As EventArgs) Handles btnAudio.Click
        lblName.Text = "Audio Devices"
        TotalAudioDevices()
        fetchAudioDevices()
    End Sub

    Private Sub btnStorageDevices_Click(sender As Object, e As EventArgs) Handles btnStorageDevices.Click
        lblName.Text = "Storage Devices"
        TotalStorageDevices()
        fetchStorageDevices()

    End Sub

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles Me.Load
        TotalProducts()
        fetchProducts()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim modalAddProducts As New modalAddProducts()
        modalAddProducts.ShowDialog()

        fetchProducts()
        TotalProducts()
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        fetchProducts()
        TotalProducts()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvInventory.SelectedRows.Count > 0 Then
            Dim productID As Integer = Convert.ToInt32(dgvInventory.SelectedRows(0).Cells("product_id").Value)

            Dim modalEdit As New modalEditProducts()
            modalEdit.product_id = productID

            If modalEdit.ShowDialog() = DialogResult.OK Then
                fetchProducts()
                TotalProducts()
            End If
        Else
            MsgBox("Please select a record to edit.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ' Check if a row is selected
            If dgvInventory.SelectedRows.Count = 0 Then
                MsgBox("Please select a record to delete.", MsgBoxStyle.Exclamation)
                Return
            End If

            ' Get selected row data
            Dim selectedRow As DataGridViewRow = dgvInventory.SelectedRows(0)
            Dim productID As Integer = Convert.ToInt32(selectedRow.Cells("product_id").Value)
            Dim productName As String = selectedRow.Cells("ItemName").Value.ToString()

            ' Confirm deletion
            Dim result As DialogResult = MessageBox.Show(
                $"Are you sure you want to delete '{productName}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )

            If result = DialogResult.Yes Then
                Connection.AddParam("@product_id", productID.ToString())

                Dim query As String = "DELETE FROM Products WHERE product_id = @product_id"

                If Connection.Delete(query) Then
                    MsgBox("Product deleted successfully!", MsgBoxStyle.Information)
                    fetchProducts() ' Refresh grid
                    TotalProducts() ' Update count
                Else
                    MsgBox("Failed to delete product.", MsgBoxStyle.Exclamation)
                End If
            End If

        Catch ex As Exception
            MsgBox($"Error: {ex.Message}")
        End Try
    End Sub
End Class
