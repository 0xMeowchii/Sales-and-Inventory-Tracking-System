Imports Guna.UI2.WinForms.Suite

Public Class modalAddProducts
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

    Public Sub ClearFields()
        txtProductName.Clear()
        txtNumber.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        cboBrand.SelectedIndex = -1
        cboCondition.SelectedIndex = -1
        cboLocation.SelectedIndex = -1
        cboSupplier.SelectedIndex = -1
        cboType.SelectedIndex = -1
    End Sub

    Private Sub modalAddProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

                ' Display image
                picProduct.Image = Image.FromFile(openFileDialog.FileName)
                picProduct.SizeMode = PictureBoxSizeMode.Zoom

            End If
        Catch ex As Exception
            MsgBox($"Error: {ex.Message}")
        End Try
    End Sub
End Class