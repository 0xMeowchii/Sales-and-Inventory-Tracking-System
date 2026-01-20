Public Class frmBrand
    Private Sub ClearFields()
        txtBrandName.Clear()
        txtID.Clear()
        txtBrandName.Focus()
    End Sub

    Public Sub TotalBrand()
        Connection.Query("SELECT count(*) as TotalBrand FROM Brand")

        If Connection.Datacount > 0 Then
            lblTotal.Text = Connection.Data.Tables(0).Rows(0)("TotalBrand").ToString()
        Else
            lblTotal.Text = "0"
        End If
    End Sub
    Public Sub fetchBrand()
        Try
            Connection.Query("SELECT * FROM Brand")

            If Connection.Datacount > 0 Then
                dgvBrand.DataSource = Connection.Data.Tables(0)
            Else
                MsgBox("No data found.")
                dgvBrand.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Private Sub frmBrand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TotalBrand()
        fetchBrand()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try

            ' Validate brand name is not empty
            If String.IsNullOrWhiteSpace(txtBrandName.Text) Then
                MsgBox("Please enter a brand name.", MsgBoxStyle.Exclamation, "Validation Error")
                txtBrandName.Focus()
                Return
            End If

            ' Validate minimum length (optional)
            If txtBrandName.Text.Trim().Length < 2 Then
                MsgBox("Brand name must be at least 2 characters long.", MsgBoxStyle.Exclamation, "Validation Error")
                txtBrandName.Focus()
                Return
            End If

            ' Check if brand already exists
            Connection.AddParam("@Name", txtBrandName.Text.Trim())
            Connection.Query("SELECT * FROM Brand WHERE Name = @Name")

            If Connection.Datacount > 0 Then
                MsgBox("This brand already exists!", MsgBoxStyle.Exclamation, "Duplicate Entry")
                txtBrandName.Focus()
                txtBrandName.SelectAll()
                Return
            End If

            Connection.AddParam("@Name", txtBrandName.Text)

            Dim query As String = "INSERT INTO Brand (Name) " &
                                  "VALUES (@Name)"

            If Connection.Insert(query) Then
                MsgBox("Brand added successfully!", MsgBoxStyle.Information)
                txtBrandName.Clear()
                TotalBrand()
                fetchBrand()
            Else
                MsgBox("Failed to add brand.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Private Sub dgvBrand_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBrand.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvBrand.Rows(e.RowIndex)

                ' Populate textboxes with selected row data
                txtBrandName.Text = row.Cells("Name").Value.ToString()

                ' Optional: Store the ID for updating
                txtID.Text = row.Cells("id").Value.ToString()
            End If
        Catch ex As Exception
            MsgBox($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Dim brandID As Integer = 0
            Dim brandName As String = txtBrandName.Text.Trim()

            ' Validate ID
            If Not Integer.TryParse(txtID.Text, brandID) OrElse brandID <= 0 Then
                MsgBox("Please select a brand to update.", MsgBoxStyle.Exclamation)
                Return
            End If

            ' Validate brand name
            If String.IsNullOrWhiteSpace(brandName) Then
                MsgBox("Please enter a brand name.", MsgBoxStyle.Exclamation, "Validation Error")
                txtBrandName.Focus()
                Return
            End If

            ' Validate minimum length
            If brandName.Length < 2 Then
                MsgBox("Brand name must be at least 2 characters long.", MsgBoxStyle.Exclamation, "Validation Error")
                txtBrandName.Focus()
                Return
            End If

            ' Validate maximum length
            If brandName.Length > 50 Then
                MsgBox("Brand name must not exceed 50 characters.", MsgBoxStyle.Exclamation, "Validation Error")
                txtBrandName.Focus()
                Return
            End If

            ' Check if brand name already exists (excluding current brand)
            Connection.AddParam("@Name", brandName)
            Connection.AddParam("@BrandID", brandID.ToString())
            Connection.Query("SELECT * FROM Brand WHERE LOWER(Name) = LOWER(@Name) AND id != @BrandID")

            If Connection.Datacount > 0 Then
                MsgBox("This brand name already exists!", MsgBoxStyle.Exclamation, "Duplicate Entry")
                txtBrandName.Focus()
                txtBrandName.SelectAll()
                Return
            End If

            ' Confirm update
            Dim result As DialogResult = MessageBox.Show(
            $"Update brand to '{brandName}'?",
            "Confirm Update",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

            If result = DialogResult.No Then
                Return
            End If

            ' Update brand
            Connection.AddParam("@Name", brandName)
            Connection.AddParam("@BrandID", brandID.ToString())

            Dim query As String = "UPDATE Brand SET Name = @Name WHERE id = @BrandID"

            If Connection.Update(query) Then
                MsgBox("Brand updated successfully!", MsgBoxStyle.Information, "Success")
                ClearFields()
                fetchBrand()
            Else
                MsgBox("Failed to update brand.", MsgBoxStyle.Exclamation, "Error")
            End If

        Catch ex As Exception
            MsgBox($"Error: {ex.Message}", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ' Check if a row is selected
            If dgvBrand.SelectedRows.Count = 0 Then
                MsgBox("Please select a record to delete.", MsgBoxStyle.Exclamation)
                Return
            End If

            ' Get selected row data
            Dim selectedRow As DataGridViewRow = dgvBrand.SelectedRows(0)
            Dim brandID As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)
            Dim brandName As String = selectedRow.Cells("Name").Value.ToString()

            ' Confirm deletion
            Dim result As DialogResult = MessageBox.Show(
                $"Are you sure you want to delete '{brandName}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )

            If result = DialogResult.Yes Then
                Connection.AddParam("@brandID", brandID.ToString())

                Dim query As String = "DELETE FROM Brand WHERE id = @brandID"

                If Connection.Delete(query) Then
                    MsgBox("Brand deleted successfully!", MsgBoxStyle.Information)
                    ClearFields()
                    fetchBrand()
                Else
                    MsgBox("Failed to delete brand account.", MsgBoxStyle.Exclamation)
                End If
            End If

        Catch ex As Exception
            MsgBox($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub
End Class
