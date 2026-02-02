Imports System.Data.SqlClient

Public Class modalEditProducts

    Public imagePath As String = ""
    Public imageBytes() As Byte
    Public product_id As Integer
    Private imageChanged As Boolean = False

    Private Sub LoadProducts(id As Integer)
        Connection.AddParam("@product_id", id.ToString())
        Connection.Query("SELECT * FROM Products WHERE product_id = @product_id")

        If Connection.Datacount > 0 Then
            Dim row As DataRow = Connection.Data.Tables(0).Rows(0)
            txtProductName.Text = row("ItemName").ToString()
            txtQuantity.Text = row("Quantity").ToString()
            txtNumber.Text = row("SerialNumber").ToString()
            txtPrice.Text = row("UnitPrice").ToString()
            cboBrand.Text = row("Brand").ToString()
            cboCondition.Text = row("Condition").ToString()
            cboLocation.Text = row("LocationDepartment").ToString()
            cboSupplier.Text = row("SupplierName").ToString()
            cboType.Text = row("ProductType").ToString()

            If Not IsDBNull(row("Image")) Then
                imageBytes = CType(row("Image"), Byte())
                LoadImageFromBytes(imageBytes)
            End If
        End If
    End Sub

    Private Sub LoadImageFromBytes(imgBytes() As Byte)
        Try
            If imgBytes IsNot Nothing AndAlso imgBytes.Length > 0 Then
                Using ms As New System.IO.MemoryStream(imgBytes)
                    picProduct.Image = Image.FromStream(ms)
                    picProduct.SizeMode = PictureBoxSizeMode.Zoom
                End Using
            End If
        Catch ex As Exception
            MsgBox($"Error loading image: {ex.Message}")
        End Try
    End Sub

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

    Public Sub ClearFields()
        txtProductName.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        txtNumber.Clear()
        cboBrand.SelectedIndex = -1
        cboType.SelectedIndex = -1
        cboCondition.SelectedIndex = -1
        cboLocation.SelectedIndex = -1
        cboSupplier.SelectedIndex = -1
        picProduct.Image = Nothing
        imagePath = ""
        imageBytes = Nothing
        imageChanged = False
        txtProductName.Focus()
    End Sub

    Private Sub modalEditProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSupplier()
        LoadBrands()
        LoadProducts(product_id)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png"
            openFileDialog.Title = "Select Product Image"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Check file size (max 5MB)
                Dim fileInfo As New System.IO.FileInfo(openFileDialog.FileName)
                Dim fileSizeMB As Double = fileInfo.Length / 1024 / 1024

                If fileSizeMB > 5 Then
                    MsgBox("Image file size must be less than 5MB.", MsgBoxStyle.Exclamation)
                    Return
                End If

                ' Store file path and read bytes
                imagePath = openFileDialog.FileName
                imageBytes = System.IO.File.ReadAllBytes(imagePath)
                imageChanged = True ' Mark that image was changed

                ' Display image
                picProduct.Image = Image.FromFile(imagePath)
                picProduct.SizeMode = PictureBoxSizeMode.Zoom

                MsgBox("Image selected successfully!", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox($"Error selecting image: {ex.Message}")
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            ' Validate all fields
            If Not ValidateAllFields() Then
                Return
            End If

            ' Confirm update
            Dim result As DialogResult = MessageBox.Show(
                "Are you sure you want to update this product?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

            If result = DialogResult.No Then
                Return
            End If

            ' Open connection manually for VARBINARY
            Connection.Open()

            Dim query As String = "UPDATE Products SET " &
                                  "ItemName = @ItemName, " &
                                  "Quantity = @Quantity, " &
                                  "UnitPrice = @UnitPrice, " &
                                  "Brand = @Brand, " &
                                  "Condition = @Condition, " &
                                  "LocationDepartment = @LocationDepartment, " &
                                  "SupplierName = @SupplierName, " &
                                  "ProductType = @ProductType, " &
                                  "Image = @ProductImage " &
                                  "WHERE product_id = @product_id"

            Dim command As New SqlCommand(query, Connection.Connect)

            ' Add parameters
            command.Parameters.AddWithValue("@product_id", product_id)
            command.Parameters.AddWithValue("@ItemName", txtProductName.Text.Trim())
            command.Parameters.AddWithValue("@Quantity", txtQuantity.Text)
            command.Parameters.AddWithValue("@UnitPrice", txtPrice.Text)
            command.Parameters.AddWithValue("@Brand", cboBrand.Text)
            command.Parameters.AddWithValue("@Condition", cboCondition.Text)
            command.Parameters.AddWithValue("@LocationDepartment", cboLocation.Text)
            command.Parameters.AddWithValue("@SupplierName", cboSupplier.Text)
            command.Parameters.AddWithValue("@ProductType", cboType.Text)

            ' Add image as VARBINARY
            command.Parameters.Add("@ProductImage", SqlDbType.VarBinary).Value = imageBytes

            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            Connection.Close()

            If rowsAffected > 0 Then
                MsgBox("Product updated successfully!", MsgBoxStyle.Information, "Success")
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MsgBox("Failed to update product.", MsgBoxStyle.Exclamation, "Error")
            End If

        Catch ex As Exception
            Connection.Close()
            MsgBox($"Error updating product: {ex.Message}", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class