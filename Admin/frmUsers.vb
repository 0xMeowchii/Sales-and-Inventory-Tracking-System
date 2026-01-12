Public Class frmUsers
    Public Sub viewdata()
        Try
            Connection.Query("SELECT * FROM UserAccount")

            If Connection.Datacount > 0 Then
                dgvUsers.DataSource = Connection.Data.Tables(0)
            Else
                MsgBox("No data found.")
                dgvUsers.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Public Sub totalUsers()
        Try
            Connection.Query("SELECT count(*) as TotalUsers FROM UserAccount")

            If Connection.Datacount > 0 Then
                lblTotalUsers.Text = Connection.Data.Tables(0).Rows(0)("TotalUsers").ToString()
            Else
                lblTotalUsers.Text = "0"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        viewdata()
        totalUsers()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim modalAdd As New modalAddUser()
        modalAdd.ShowDialog()

        viewdata()
        totalUsers()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvUsers.SelectedRows.Count > 0 Then
            Dim userID As Integer = Convert.ToInt32(dgvUsers.SelectedRows(0).Cells("UserAccountID").Value)

            Dim modalEdit As New modalEditUser()
            modalEdit.userID = userID

            If modalEdit.ShowDialog() = DialogResult.OK Then
                viewdata()
                totalUsers()
            End If
        Else
            MsgBox("Please select a record to edit.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ' Check if a row is selected
            If dgvUsers.SelectedRows.Count = 0 Then
                MsgBox("Please select a record to delete.", MsgBoxStyle.Exclamation)
                Return
            End If

            ' Get selected row data
            Dim selectedRow As DataGridViewRow = dgvUsers.SelectedRows(0)
            Dim userID As Integer = Convert.ToInt32(selectedRow.Cells("UserAccountID").Value)
            Dim userName As String = selectedRow.Cells("FirstName").Value.ToString() & " " & selectedRow.Cells("LastName").Value.ToString()

            ' Confirm deletion
            Dim result As DialogResult = MessageBox.Show(
                $"Are you sure you want to delete '{userName}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )

            If result = DialogResult.Yes Then
                Connection.AddParam("@userID", userID.ToString())

                Dim query As String = "DELETE FROM UserAccount WHERE UserAccountID = @userID"

                If Connection.Delete(query) Then
                    MsgBox("User deleted successfully!", MsgBoxStyle.Information)
                    viewdata() ' Refresh grid
                    totalUsers() ' Update count
                Else
                    MsgBox("Failed to delete user account.", MsgBoxStyle.Exclamation)
                End If
            End If

        Catch ex As Exception
            MsgBox($"Error: {ex.Message}")
        End Try
    End Sub
End Class
