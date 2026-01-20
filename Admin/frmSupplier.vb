Public Class frmSupplier

    Private Sub ClearFields()
        txtSupplierName.Clear()
        txtID.Clear()
        txtSupplierName.Focus()
    End Sub
    Public Sub TotalSupplier()
        Connection.Query("SELECT count(*) as TotalSupplier FROM SupplierName")

        If Connection.Datacount > 0 Then
            lblTotal.Text = Connection.Data.Tables(0).Rows(0)("TotalSupplier").ToString()
        Else
            lblTotal.Text = "0"
        End If
    End Sub
    Public Sub fetchSupplier()
        Try
            Connection.Query("SELECT * FROM SupplierName")

            If Connection.Datacount > 0 Then
                dgvSupplier.DataSource = Connection.Data.Tables(0)
            Else
                MsgBox("No data found.")
                dgvSupplier.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Private Sub frmSupplier_Load(sender As Object, e As EventArgs) Handles Me.Load
        fetchSupplier()
        TotalSupplier()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try

            ' Validate brand name is not empty
            If String.IsNullOrWhiteSpace(txtSupplierName.Text) Then
                MsgBox("Please enter a supplier name.", MsgBoxStyle.Exclamation, "Validation Error")
                txtSupplierName.Focus()
                Return
            End If

            ' Validate minimum length (optional)
            If txtSupplierName.Text.Trim().Length < 2 Then
                MsgBox("Supplier name must be at least 2 characters long.", MsgBoxStyle.Exclamation, "Validation Error")
                txtSupplierName.Focus()
                Return
            End If

            ' Check if brand already exists
            Connection.AddParam("@Name", txtSupplierName.Text.Trim())
            Connection.Query("SELECT * FROM SupplierName WHERE Name = @Name")

            If Connection.Datacount > 0 Then
                MsgBox("This supplier already exists!", MsgBoxStyle.Exclamation, "Duplicate Entry")
                txtSupplierName.Focus()
                txtSupplierName.SelectAll()
                Return
            End If

            Connection.AddParam("@Name", txtSupplierName.Text)

            Dim query As String = "INSERT INTO SupplierName (Name) " &
                                  "VALUES (@Name)"

            If Connection.Insert(query) Then
                MsgBox("Supplier added successfully!", MsgBoxStyle.Information)
                txtSupplierName.Clear()
                TotalSupplier()
                fetchSupplier()
            Else
                MsgBox("Failed to add supplier.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Dim ID As Integer = 0
            Dim Name As String = txtSupplierName.Text.Trim()

            ' Validate ID
            If Not Integer.TryParse(txtID.Text, ID) OrElse ID <= 0 Then
                MsgBox("Please select a supplier to update.", MsgBoxStyle.Exclamation)
                Return
            End If

            ' Validate brand name
            If String.IsNullOrWhiteSpace(Name) Then
                MsgBox("Please enter a supplier name.", MsgBoxStyle.Exclamation, "Validation Error")
                txtSupplierName.Focus()
                Return
            End If

            ' Validate minimum length
            If Name.Length < 2 Then
                MsgBox("supplier name must be at least 2 characters long.", MsgBoxStyle.Exclamation, "Validation Error")
                txtSupplierName.Focus()
                Return
            End If

            ' Validate maximum length
            If Name.Length > 50 Then
                MsgBox("supplier name must not exceed 50 characters.", MsgBoxStyle.Exclamation, "Validation Error")
                txtSupplierName.Focus()
                Return
            End If

            ' Check if name already exists (excluding current brand)
            Connection.AddParam("@Name", Name)
            Connection.AddParam("@ID", ID.ToString())
            Connection.Query("SELECT * FROM SupplierName WHERE LOWER(Name) = LOWER(@Name) AND id != @ID")

            If Connection.Datacount > 0 Then
                MsgBox("This supplier name already exists!", MsgBoxStyle.Exclamation, "Duplicate Entry")
                txtSupplierName.Focus()
                txtSupplierName.SelectAll()
                Return
            End If

            ' Confirm update
            Dim result As DialogResult = MessageBox.Show(
            $"Update brand to '{Name}'?",
            "Confirm Update",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

            If result = DialogResult.No Then
                Return
            End If

            ' Update brand
            Connection.AddParam("@Name", Name)
            Connection.AddParam("@ID", ID.ToString())

            Dim query As String = "UPDATE SupplierName SET Name = @Name WHERE id = @ID"

            If Connection.Update(query) Then
                MsgBox("Supplier updated successfully!", MsgBoxStyle.Information, "Success")
                ClearFields()
                fetchSupplier()
            Else
                MsgBox("Failed to update Supplier.", MsgBoxStyle.Exclamation, "Error")
            End If

        Catch ex As Exception
            MsgBox($"Error: {ex.Message}", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dgvSupplier_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplier.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvSupplier.Rows(e.RowIndex)

                ' Populate textboxes with selected row data
                txtSupplierName.Text = row.Cells("Name").Value.ToString()

                ' Optional: Store the ID for updating
                txtID.Text = row.Cells("id").Value.ToString()
            End If
        Catch ex As Exception
            MsgBox($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ' Check if a row is selected
            If dgvSupplier.SelectedRows.Count = 0 Then
                MsgBox("Please select a record to delete.", MsgBoxStyle.Exclamation)
                Return
            End If

            ' Get selected row data
            Dim selectedRow As DataGridViewRow = dgvSupplier.SelectedRows(0)
            Dim ID As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)
            Dim Name As String = selectedRow.Cells("Name").Value.ToString()

            ' Confirm deletion
            Dim result As DialogResult = MessageBox.Show(
                $"Are you sure you want to delete '{Name}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )

            If result = DialogResult.Yes Then
                Connection.AddParam("@ID", ID.ToString())

                Dim query As String = "DELETE FROM SupplierName WHERE id = @ID"

                If Connection.Delete(query) Then
                    MsgBox("Supplier deleted successfully!", MsgBoxStyle.Information)
                    ClearFields()
                    fetchSupplier()
                Else
                    MsgBox("Failed to delete supplier account.", MsgBoxStyle.Exclamation)
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
