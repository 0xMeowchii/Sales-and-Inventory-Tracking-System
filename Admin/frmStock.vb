Public Class frmStock

    Public Sub LoadCategoriesToComboBox()
        Try
            ' Add category options to ComboBox
            cboCategory.Items.Clear()
            cboCategory.Items.Add("Mobile Devices")
            cboCategory.Items.Add("Phone Accessories")
            cboCategory.Items.Add("Audio Devices")
            cboCategory.Items.Add("Storage Devices")

            ' Set default selection
            If cboCategory.Items.Count > 0 Then
                cboCategory.SelectedIndex = 0
            End If

        Catch ex As Exception
            MsgBox($"Error: {ex.Message}")
        End Try
    End Sub
    Public Sub fetchMobileDevices()
        Try
            Connection.Query("SELECT * FROM MobileDevices")

            If Connection.Datacount > 0 Then
                dgvStock.DataSource = Connection.Data.Tables(0)
            Else
                MsgBox("No data found.")
                dgvStock.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Public Sub fetchPhoneAccessories()
        Try
            Connection.Query("SELECT * FROM PhoneAccessories")

            If Connection.Datacount > 0 Then
                dgvStock.DataSource = Connection.Data.Tables(0)
            Else
                MsgBox("No data found.")
                dgvStock.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Public Sub fetchAudioDevices()
        Try
            Connection.Query("SELECT * FROM AudioDevices")

            If Connection.Datacount > 0 Then
                dgvStock.DataSource = Connection.Data.Tables(0)
            Else
                MsgBox("No data found.")
                dgvStock.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Public Sub fetchStorageDevices()
        Try
            Connection.Query("SELECT * FROM StorageDevices")

            If Connection.Datacount > 0 Then
                dgvStock.DataSource = Connection.Data.Tables(0)
            Else
                MsgBox("No data found.")
                dgvStock.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
        Select Case cboCategory.SelectedItem.ToString()
            Case "Mobile Devices"
                fetchMobileDevices()
            Case "Phone Accessories"
                fetchPhoneAccessories()
            Case "Audio Devices"
                fetchAudioDevices()
            Case "Storage Devices"
                fetchStorageDevices()
        End Select
    End Sub

    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadCategoriesToComboBox()
        fetchMobileDevices()
    End Sub

End Class
