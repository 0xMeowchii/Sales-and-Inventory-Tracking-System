Public Class frmMain

    Sub HideMenu()
        If dropdownUsers.Visible = True Then
            dropdownUsers.Visible = False
        ElseIf dropdownStock.Visible = True Then
            dropdownStock.Visible = False
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Me.Dispose()
        frmLogin.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        dropdownStock.Visible = False
        dropdownUsers.Visible = False

    End Sub

    Private Sub btnUsersManagement_Click(sender As Object, e As EventArgs) Handles btnUsersManagement.Click
        If dropdownUsers.Visible = False Then
            dropdownUsers.Visible = True
        Else
            dropdownUsers.Visible = False
        End If
    End Sub

    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        HideMenu()
        lblTitle.Text = "STOCK MANAGEMENT"
        FrmStock1.Visible = True
        FrmStock1.BringToFront()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        HideMenu()
        lblTitle.Text = "USERS MANAGEMENT"
        FrmAdmin1.BringToFront()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        HideMenu()
        lblTitle.Text = "USERS MANAGEMENT"
        FrmUsers1.BringToFront()
    End Sub

    Private Sub btnStockIn_Click(sender As Object, e As EventArgs) Handles btnStockIn.Click
        HideMenu()
    End Sub

    Private Sub btnStockOut_Click(sender As Object, e As EventArgs) Handles btnStockOut.Click
        HideMenu()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        lblTitle.Text = "DASHBOARD"
        FrmDashboard1.BringToFront()
    End Sub

    Private Sub btnInventory_Click_1(sender As Object, e As EventArgs) Handles btnInventory.Click
        lblTitle.Text = "INVENTORY MANAGEMENT"
        FrmInventory1.BringToFront()
    End Sub
End Class
