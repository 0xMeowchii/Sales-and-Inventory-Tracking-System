Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Guna.UI2.WinForms.Suite

Public Class modalAddProducts

    Public imagePath As String = ""
    Public imageBytes() As Byte


    Private Function ValidateAllFields() As Boolean

        ' Validate image selection
        If imageBytes Is Nothing OrElse imageBytes.Length = 0 Then
            MsgBox("Please select a product image.", MsgBoxStyle.Exclamation)
            btnSelect.Focus()
            Return False
        End If

        ' Validate other fields
        If String.IsNullOrWhiteSpace(txtProductName.Text) Then
            MsgBox("Please enter product name.", MsgBoxStyle.Exclamation)
            txtProductName.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtQuantity.Text) Then
            MsgBox("Please enter product quantity.", MsgBoxStyle.Exclamation)
            txtProductName.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPrice.Text) Then
            MsgBox("Please enter product price.", MsgBoxStyle.Exclamation)
            txtProductName.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(cboType.Text) Then
            MsgBox("Please select product type.", MsgBoxStyle.Exclamation)
            txtProductName.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(cboBrand.Text) Then
            MsgBox("Please select product brand.", MsgBoxStyle.Exclamation)
            txtProductName.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(cboCondition.Text) Then
            MsgBox("Please select product condition.", MsgBoxStyle.Exclamation)
            txtProductName.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(cboLocation.Text) Then
            MsgBox("Please select product location.", MsgBoxStyle.Exclamation)
            txtProductName.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(cboSupplier.Text) Then
            MsgBox("Please select product supplier.", MsgBoxStyle.Exclamation)
            txtProductName.Focus()
            Return False
        End If

        Return True
    End Function
    Public Sub LoadBrands()
        Try
            Connection.Query("SELECT * FROM Brand ORDER BY Name")

            If Connection.Datacount > 0 Then
                cboBrand.Items.Clear()

                For Each row As DataRow In Connection.Data.Tables(0).Rows
                    cboBrand.Items.Add(row("Name").ToString())
                Next

            Else
                cboBrand.Items.Clear()
                MsgBox("No brands found.")
            End If

        Catch ex As Exception
            MsgBox($"Error loading brands: {ex.Message}")
        End Try
    End Sub

    Public Sub GenerateSerialNumber()
        Try
            ' Get the count of records
            Connection.Query("SELECT COUNT(*) AS TotalCount FROM Products")

            If Connection.Datacount > 0 Then
                Dim count As Integer = Convert.ToInt32(Connection.Data.Tables(0).Rows(0)("TotalCount"))
                Dim nextNumber As Integer = count + 1

                ' Format: PROD-00001
                txtNumber.Text = $"PROD-{nextNumber:D5}"
            Else
                txtNumber.Text = "PROD-00001"
            End If

        Catch ex As Exception
            MsgBox($"Error: {ex.Message}")
        End Try
    End Sub

    Public Sub LoadSupplier()
        Try
            Connection.Query("SELECT * FROM SupplierName ORDER BY Name")

            If Connection.Datacount > 0 Then
                cboSupplier.Items.Clear()

                For Each row As DataRow In Connection.Data.Tables(0).Rows
                    cboSupplier.Items.Add(row("Name").ToString())
                Next

            Else
                cboBrand.Items.Clear()
                MsgBox("No Supplier found.")
            End If

        Catch ex As Exception
            MsgBox($"Error loading supplier: {ex.Message}")
        End Try
    End Sub

    Public Sub ClearFields()
        txtProductName.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        cboBrand.SelectedIndex = -1
        cboType.SelectedIndex = -1
        picProduct.Image = Nothing
        imagePath = ""
        imageBytes = Nothing
        txtProductName.Focus()
    End Sub

    Private Sub modalAddProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateSerialNumber()
        LoadSupplier()
        LoadBrands()
        Guna2ShadowForm1.SetShadowForm(Me)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            If Not ValidateAllFields() Then
                Return
            End If

            ' Open connection and insert with binary image
            Connection.Open()

            Dim query As String = "INSERT INTO Products (ItemName, ProductType, Brand, SerialNumber, Quantity, UnitPrice, SupplierName, Condition, LocationDepartment, Image, DateAdded) " &
                              "VALUES (@ItemName, @ProductType, @Brand, @SerialNumber, @Quantity, @UnitPrice, @SupplierName, @Condition, @LocationDepartment ,@Image, GETDATE())"

            Dim command As New SqlCommand(query, Connection.Connect)

            command.Parameters.AddWithValue("@ItemName", txtProductName.Text)
            command.Parameters.AddWithValue("@ProductType", cboType.Text)
            command.Parameters.AddWithValue("@Brand", cboBrand.Text)
            command.Parameters.AddWithValue("@SerialNumber", txtNumber.Text)
            command.Parameters.AddWithValue("@Quantity", txtQuantity.Text)
            command.Parameters.AddWithValue("@UnitPrice", txtPrice.Text)
            command.Parameters.AddWithValue("@SupplierName", cboSupplier.Text)
            command.Parameters.AddWithValue("@Condition", cboCondition.Text)
            command.Parameters.AddWithValue("@LocationDepartment", cboLocation.Text)
            command.Parameters.Add("@Image", SqlDbType.VarBinary).Value = imageBytes

            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            Connection.Close()

            If rowsAffected > 0 Then
                MsgBox("Product added successfully!", MsgBoxStyle.Information)
                ClearFields()
            Else
                MsgBox("Failed to add product.", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            Connection.Close()
            MsgBox($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png"
            openFileDialog.Title = "Select an Image"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Check file size (e.g., max 5MB)
                Dim fileInfo As New System.IO.FileInfo(openFileDialog.FileName)
                Dim fileSizeMB As Double = fileInfo.Length / 1024 / 1024

                If fileSizeMB > 5 Then
                    MsgBox("Image file size must be less than 5MB.", MsgBoxStyle.Exclamation)
                    Return
                End If

                ' Store the file path and read bytes
                imagePath = openFileDialog.FileName
                imageBytes = System.IO.File.ReadAllBytes(imagePath)

                ' Display image
                picProduct.Image = Image.FromFile(imagePath)
                picProduct.SizeMode = PictureBoxSizeMode.Zoom

            End If

        Catch ex As Exception
            MsgBox($"Error: {ex.Message}")
        End Try
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        ' Allow only numbers
        If Not String.IsNullOrEmpty(txtQuantity.Text) Then
            If Not IsNumeric(txtQuantity.Text) Then
                ' Remove non-numeric characters
                txtQuantity.Text = Regex.Replace(txtQuantity.Text, "[^\d]", "")
                txtQuantity.SelectionStart = txtQuantity.Text.Length
            End If

            ' Limit to 11 digits
            If txtQuantity.Text.Length > 11 Then
                txtQuantity.Text = txtQuantity.Text.Substring(0, 11)
                txtQuantity.SelectionStart = txtQuantity.Text.Length
            End If
        End If
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        ' Allow only numbers
        If Not String.IsNullOrEmpty(txtPrice.Text) Then
            If Not IsNumeric(txtPrice.Text) Then
                ' Remove non-numeric characters
                txtPrice.Text = Regex.Replace(txtPrice.Text, "[^\d]", "")
                txtPrice.SelectionStart = txtPrice.Text.Length
            End If

            ' Limit to 11 digits
            If txtPrice.Text.Length > 11 Then
                txtPrice.Text = txtPrice.Text.Substring(0, 11)
                txtPrice.SelectionStart = txtPrice.Text.Length
            End If
        End If
    End Sub
End Class