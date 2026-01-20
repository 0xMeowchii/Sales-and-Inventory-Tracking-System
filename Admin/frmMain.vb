Public Class frmMain

    Sub HideMenu()
        If dropdownUsers.Visible = True Then
            dropdownUsers.Visible = False
        ElseIf dropdownInventory.Visible = True Then
            dropdownInventory.Visible = False
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
        dropdownInventory.Visible = False
        dropdownUsers.Visible = False

    End Sub

    Private Sub btnUsersManagement_Click(sender As Object, e As EventArgs) Handles btnUsersManagement.Click
        If dropdownUsers.Visible = False Then
            dropdownUsers.Visible = True
        Else
            dropdownUsers.Visible = False
        End If
    End Sub

    Private Sub btnStock_Click(sender As Object, e As EventArgs)
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

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        HideMenu()
        lblTitle.Text = "DASHBOARD"
        FrmDashboard1.BringToFront()
    End Sub

    Private Sub btnInventory_Click_1(sender As Object, e As EventArgs) Handles btnInventoryManagement.Click
        If dropdownInventory.Visible = False Then
            dropdownInventory.Visible = True
        Else
            dropdownInventory.Visible = False
        End If
    End Sub

    Private Sub btnInv_Click(sender As Object, e As EventArgs) Handles btnInv.Click
        HideMenu()
        lblTitle.Text = "INVENTORY MANAGEMENT"
        FrmInventory1.BringToFront()
    End Sub
    Private Sub btnBrand_Click(sender As Object, e As EventArgs) Handles btnBrand.Click
        HideMenu()
        lblTitle.Text = "INVENTORY MANAGEMENT"
        FrmBrand1.BringToFront()
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        HideMenu()
        lblTitle.Text = "INVENTORY MANAGEMENT"
        FrmSupplier1.BringToFront()
    End Sub
End Class
