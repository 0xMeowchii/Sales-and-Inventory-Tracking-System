Public Class frmInventory

    Public Sub fetchMobileDevices()
        Try
            Connection.Query("SELECT * FROM MobileDevices")

            If Connection.Datacount > 0 Then
                dgvInventory.DataSource = Connection.Data.Tables(0)
            Else
                MsgBox("No data found.")
                dgvInventory.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Public Sub fetchPhoneAccessories()
        Try
            Connection.Query("SELECT * FROM PhoneAccessories")

            If Connection.Datacount > 0 Then
                dgvInventory.DataSource = Connection.Data.Tables(0)
            Else
                MsgBox("No data found.")
                dgvInventory.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Public Sub fetchAudioDevices()
        Try
            Connection.Query("SELECT * FROM AudioDevices")

            If Connection.Datacount > 0 Then
                dgvInventory.DataSource = Connection.Data.Tables(0)
            Else
                MsgBox("No data found.")
                dgvInventory.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Public Sub fetchStorageDevices()
        Try
            Connection.Query("SELECT * FROM StorageDevices")

            If Connection.Datacount > 0 Then
                dgvInventory.DataSource = Connection.Data.Tables(0)
            Else
                MsgBox("No data found.")
                dgvInventory.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Public Sub TotalMobileDevies()
        Connection.Query("SELECT count(*) as TotalMobileDevices FROM MobileDevices")

        If Connection.Datacount > 0 Then
            lblTotal.Text = Connection.Data.Tables(0).Rows(0)("TotalMobileDevices").ToString()
        Else
            lblTotal.Text = "0"
        End If
    End Sub

    Public Sub TotalPhoneAccessories()
        Connection.Query("SELECT count(*) as TotalPhoneAccessories FROM PhoneAccessories")

        If Connection.Datacount > 0 Then
            lblTotal.Text = Connection.Data.Tables(0).Rows(0)("TotalPhoneAccessories").ToString()
        Else
            lblTotal.Text = "0"
        End If
    End Sub

    Public Sub TotalAudioDevices()
        Connection.Query("SELECT count(*) as TotalAudioDevices FROM AudioDevices")

        If Connection.Datacount > 0 Then
            lblTotal.Text = Connection.Data.Tables(0).Rows(0)("TotalAudioDevices").ToString()
        Else
            lblTotal.Text = "0"
        End If
    End Sub

    Public Sub TotalStorageDevices()
        Connection.Query("SELECT count(*) as TotalStorageDevices FROM StorageDevices")

        If Connection.Datacount > 0 Then
            lblTotal.Text = Connection.Data.Tables(0).Rows(0)("TotalStorageDevices").ToString()
        Else
            lblTotal.Text = "0"
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnPhoneAcce.Click
        lblName.Text = "Phone Accessories"
        TotalPhoneAccessories()
        fetchPhoneAccessories()

    End Sub

    Private Sub btnMobileDevices_Click(sender As Object, e As EventArgs) Handles btnMobileDevices.Click
        lblName.Text = "Mobile Devices"
        TotalMobileDevies()
        fetchMobileDevices()
    End Sub

    Private Sub btnAudio_Click(sender As Object, e As EventArgs) Handles btnAudio.Click
        lblName.Text = "Audio Devices"
        TotalAudioDevices()
        fetchAudioDevices()
    End Sub

    Private Sub btnStorageDevices_Click(sender As Object, e As EventArgs) Handles btnStorageDevices.Click
        lblName.Text = "Storage Devices"
        TotalStorageDevices()
        fetchStorageDevices()

    End Sub

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles Me.Load
        TotalMobileDevies()
        fetchMobileDevices()
    End Sub
End Class
