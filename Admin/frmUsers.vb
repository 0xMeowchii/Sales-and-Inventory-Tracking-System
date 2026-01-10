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
End Class
