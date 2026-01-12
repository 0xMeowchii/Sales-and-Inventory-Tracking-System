Imports System.Data.SqlClient
Public Class frmAdmin
    Public Sub viewdata()
        Try
            Connection.Query("SELECT * FROM AdminAccount")

            If Connection.Datacount > 0 Then
                dgvAdmin.DataSource = Connection.Data.Tables(0)
            Else
                MsgBox("No data found.")
                dgvAdmin.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Public Sub totalAdmin()
        Try
            Connection.Query("SELECT count(*) as TotalAdmin FROM AdminAccount")

            If Connection.Datacount > 0 Then
                lblTotalAdmin.Text = Connection.Data.Tables(0).Rows(0)("TotalAdmin").ToString()
            Else
                lblTotalAdmin.Text = "0"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load
        viewdata()
        totalAdmin()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim modalAdd As New modalAdd()
        modalAdd.ShowDialog()

        viewdata()
        totalAdmin()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ' Check if a row is selected
            If dgvAdmin.SelectedRows.Count = 0 Then
                MsgBox("Please select a record to delete.", MsgBoxStyle.Exclamation)
                Return
            End If

            ' Get selected row data
            Dim selectedRow As DataGridViewRow = dgvAdmin.SelectedRows(0)
            Dim adminID As Integer = Convert.ToInt32(selectedRow.Cells("AdminAccountID").Value)
            Dim adminName As String = selectedRow.Cells("FirstName").Value.ToString() & " " & selectedRow.Cells("LastName").Value.ToString()

            ' Confirm deletion
            Dim result As DialogResult = MessageBox.Show(
                $"Are you sure you want to delete '{adminName}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )

            If result = DialogResult.Yes Then
                Connection.AddParam("@AdminID", adminID.ToString())

                Dim query As String = "DELETE FROM AdminAccount WHERE AdminAccountID = @AdminID"

                If Connection.Delete(query) Then
                    MsgBox("Admin deleted successfully!", MsgBoxStyle.Information)
                    viewdata() ' Refresh grid
                    totalAdmin() ' Update count
                Else
                    MsgBox("Failed to delete admin account.", MsgBoxStyle.Exclamation)
                End If
            End If

        Catch ex As Exception
            MsgBox($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvAdmin.SelectedRows.Count > 0 Then
            Dim adminID As Integer = Convert.ToInt32(dgvAdmin.SelectedRows(0).Cells("AdminAccountID").Value)

            Dim modalEdit As New modalEdit()
            modalEdit.AdminID = adminID

            If modalEdit.ShowDialog() = DialogResult.OK Then
                viewdata()
                totalAdmin()
            End If
        Else
            MsgBox("Please select a record to edit.", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class
