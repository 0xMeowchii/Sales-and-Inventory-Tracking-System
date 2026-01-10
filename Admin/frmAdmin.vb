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
End Class
