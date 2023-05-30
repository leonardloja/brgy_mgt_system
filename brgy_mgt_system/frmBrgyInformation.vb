Imports MySql.Data.MySqlClient
Public Class frmBrgyInformation
    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If userType = "Administrator" Or userType = "Captain" Or userType = "Secretary" Then
            btnEdit.Enabled = True
        Else
            btnEdit.Enabled = False
        End If


        procDisplayBrgyInfo()
    End Sub

    Private Sub procDisplayBrgyInfo()
        datBrgy = New DataTable
        sqlAdapterBrgy = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayBrgyInfo"
                .CommandType = CommandType.StoredProcedure
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
            End With
            If datBrgy.Rows.Count > 0 Then
                lblBarangay.Text = datBrgy.Rows(0).Item("barangay").ToString
                lblCity.Text = datBrgy.Rows(0).Item("city").ToString
                lblProvince.Text = datBrgy.Rows(0).Item("province").ToString
                lblPhoneNo.Text = datBrgy.Rows(0).Item("phone_no").ToString
                lblEmailAdd.Text = datBrgy.Rows(0).Item("email_address").ToString
                logoPhotoPath = datBrgy.Rows(0).Item("logo").ToString
                picDisplayedLogo.Image = Image.FromFile(logoPhotoPath)
                picLogo.Image = Image.FromFile(logoPhotoPath)
                txtBarangay.Text = lblBarangay.Text
                txtCity.Text = lblCity.Text
                txtProvince.Text = lblProvince.Text
                txtPhoneNo.Text = lblPhoneNo.Text
                txtEmailAdd.Text = lblEmailAdd.Text
            Else
                MessageBox.Show("NO Record Found", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub btnChangeLogo_Click(sender As Object, e As EventArgs) Handles btnChangeLogo.Click
        Try
            With OpenFileDialog1
                .Title = "Select Logo"
                .FileName = ""
                If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    picLogo.Image = Image.FromFile(.FileName)
                    logoPhotoPath = .FileName
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub lblEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        txtBarangay.Enabled = True
        txtCity.Enabled = True
        txtProvince.Enabled = True
        txtPhoneNo.Enabled = True
        txtEmailAdd.Enabled = True
        btnChangeLogo.Enabled = True
        btnEdit.Visible = False
        btnCancel.Visible = True
        btnSave.Visible = True

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        procDisplayBrgyInfo()
        txtBarangay.Enabled = False
        txtCity.Enabled = False
        txtProvince.Enabled = False
        txtPhoneNo.Enabled = False
        txtEmailAdd.Enabled = False
        btnChangeLogo.Enabled = False
        btnEdit.Visible = True
        btnCancel.Visible = False
        btnSave.Visible = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procUpdateBrgyInfo"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_barangay", txtBarangay.Text)
                .Parameters.AddWithValue("@p_city", txtCity.Text)
                .Parameters.AddWithValue("@p_province", txtProvince.Text)
                .Parameters.AddWithValue("@p_phone_no", txtPhoneNo.Text)
                .Parameters.AddWithValue("@p_email_add", txtEmailAdd.Text)
                .Parameters.AddWithValue("@p_logo", logoPhotoPath)
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Record Successfully Save", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
        btnCancel.PerformClick()

        With frmMain
            .picSideBarLogo.Image = Image.FromFile(logoPhotoPath)
        End With



    End Sub

End Class