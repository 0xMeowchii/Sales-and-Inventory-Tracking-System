Imports System.Text.RegularExpressions

Public Class modalEdit

    Public AdminID As Integer

    Private Sub LoadAdminData(id As Integer)
        Connection.AddParam("@AdminID", id.ToString())
        Connection.Query("SELECT * FROM AdminAccount WHERE AdminAccountID = @AdminID")

        If Connection.Datacount > 0 Then
            Dim row As DataRow = Connection.Data.Tables(0).Rows(0)
            txtFirstName.Text = row("FirstName").ToString()
            txtLastName.Text = row("LastName").ToString()
            txtMiddleName.Text = row("MiddleName").ToString()
            cboGender.Text = row("Gender").ToString()
            txtContactNum.Text = row("ContactNumber").ToString()
            txtUsername.Text = row("Username").ToString()
            txtPassword.Text = row("Password").ToString()
            txtEmail.Text = row("Email").ToString()
        End If
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        If String.IsNullOrWhiteSpace(email) Then
            Return False
        End If

        Try
            ' More comprehensive email pattern
            Dim emailPattern As String = "^[\w\.-]+@[\w\.-]+\.\w{2,}$"
            Return Regex.IsMatch(email, emailPattern)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function ValidateAllFields() As Boolean
        ' Validate First Name
        If String.IsNullOrWhiteSpace(txtFirstName.Text) Then
            MsgBox("Please enter first name.", MsgBoxStyle.Exclamation)
            txtFirstName.Focus()
            Return False
        End If

        ' Validate Last Name
        If String.IsNullOrWhiteSpace(txtLastName.Text) Then
            MsgBox("Please enter last name.", MsgBoxStyle.Exclamation)
            txtLastName.Focus()
            Return False
        End If

        ' Validate Gender
        If cboGender.SelectedIndex = -1 Then
            MsgBox("Please select gender.", MsgBoxStyle.Exclamation)
            cboGender.Focus()
            Return False
        End If

        ' Validate Contact Number
        If String.IsNullOrWhiteSpace(txtContactNum.Text) Then
            MsgBox("Please enter contact number.", MsgBoxStyle.Exclamation)
            txtContactNum.Focus()
            Return False
        End If

        If txtContactNum.Text.Length <> 11 Then
            MsgBox("Contact number must be exactly 11 digits.", MsgBoxStyle.Exclamation)
            txtContactNum.Focus()
            Return False
        End If

        ' Validate Username
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MsgBox("Please enter username.", MsgBoxStyle.Exclamation)
            txtUsername.Focus()
            Return False
        End If

        ' Validate Password
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MsgBox("Please enter password.", MsgBoxStyle.Exclamation)
            txtPassword.Focus()
            Return False
        End If

        If txtPassword.Text.Length < 8 Then
            MsgBox("Password must be at least 8 characters.", MsgBoxStyle.Exclamation)
            txtPassword.Focus()
            Return False
        End If

        ' Validate Email
        If Not IsValidEmail(txtEmail.Text) Then
            MsgBox("Please enter a valid email address." & vbNewLine & "Example: user@example.com", MsgBoxStyle.Exclamation)
            txtEmail.Focus()
            Return False
        End If

        Return True
    End Function

    Public Sub UpdateAdminAccount(adminID As Integer)
        Try
            ' Validate all fields first
            If Not ValidateAllFields() Then
                Return
            End If

            ' Add parameters
            Connection.AddParam("@AdminID", adminID.ToString())
            Connection.AddParam("@FirstName", txtFirstName.Text)
            Connection.AddParam("@LastName", txtLastName.Text)
            Connection.AddParam("@MiddleName", txtMiddleName.Text)
            Connection.AddParam("@Gender", cboGender.Text)
            Connection.AddParam("@ContactNum", txtContactNum.Text)
            Connection.AddParam("@Username", txtUsername.Text)
            Connection.AddParam("@Password", txtPassword.Text)
            Connection.AddParam("@Email", txtEmail.Text)

            Dim query As String = "UPDATE AdminAccount SET " &
                              "FirstName = @FirstName, " &
                              "LastName = @LastName, " &
                              "MiddleName = @MiddleName, " &
                              "Gender = @Gender, " &
                              "ContactNumber = @ContactNum, " &
                              "Username = @Username, " &
                              "Password = @Password, " &
                              "Email = @Email " &
                              "WHERE AdminAccountID = @AdminID"

            If Connection.Update(query) Then
                MsgBox("Admin updated successfully!", MsgBoxStyle.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MsgBox("Failed to update admin account.", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MsgBox($"Error: {ex.Message}")
        End Try
    End Sub

    Public Sub ClearFields()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtMiddleName.Clear()
        cboGender.SelectedIndex = -1
        txtContactNum.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtEmail.Clear()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub modalEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        LoadAdminData(AdminID)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        UpdateAdminAccount(AdminID)
    End Sub

    Private Sub txtContactNum_TextChanged(sender As Object, e As EventArgs) Handles txtContactNum.TextChanged
        ' Allow only numbers
        If Not String.IsNullOrEmpty(txtContactNum.Text) Then
            If Not IsNumeric(txtContactNum.Text) Then
                ' Remove non-numeric characters
                txtContactNum.Text = Regex.Replace(txtContactNum.Text, "[^\d]", "")
                txtContactNum.SelectionStart = txtContactNum.Text.Length
            End If

            ' Limit to 11 digits
            If txtContactNum.Text.Length > 11 Then
                txtContactNum.Text = txtContactNum.Text.Substring(0, 11)
                txtContactNum.SelectionStart = txtContactNum.Text.Length
            End If
        End If
    End Sub
End Class