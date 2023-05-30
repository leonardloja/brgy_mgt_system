Imports MySql.Data.MySqlClient
Public Class frmAddResident
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtFirstName.Text = "" Then
            EPFirstName.SetIconPadding(txtFirstName, 3)
            EPFirstName.SetError(txtFirstName, "First Name is Required!")
            Exit Sub
        Else
            EPFirstName.Clear()
        End If

        If txtMiddleName.Text = "" Then
            EPMiddleName.SetIconPadding(txtMiddleName, 3)
            EPMiddleName.SetError(txtMiddleName, "Middle Name is Required!")
            Exit Sub
        Else
            EPMiddleName.Clear()
        End If

        If txtLastName.Text = "" Then
            EPLastName.SetIconPadding(txtLastName, 3)
            EPLastName.SetError(txtLastName, "Last Name is Required!")
            Exit Sub
        Else
            EPLastName.Clear()
        End If

        If txtEmailAddress.Text = "" Then
            EPEmailAddress.SetIconPadding(txtEmailAddress, 3)
            EPEmailAddress.SetError(txtEmailAddress, "Email Address is Required!")
            Exit Sub
        Else
            EPEmailAddress.Clear()
        End If


        If txtPlaceOfBirth.Text = "" Then
            EPPlaceOfBirth.SetIconPadding(txtPlaceOfBirth, 3)
            EPPlaceOfBirth.SetError(txtPlaceOfBirth, "Place of Birth is Required!")
            Exit Sub
        Else
            EPPlaceOfBirth.Clear()
        End If


        If txtCitizenship.Text = "" Then
            EPCitizenship.SetIconPadding(txtCitizenship, 3)
            EPCitizenship.SetError(txtCitizenship, "Citizenship is Required!")
            Exit Sub
        Else
            EPCitizenship.Clear()
        End If


        If txtContactNo.Text = "" Then
            EPContactNo.SetIconPadding(txtContactNo, 3)
            EPContactNo.SetError(txtContactNo, "Contact No. is Required!")
            Exit Sub
        Else
            EPContactNo.Clear()
        End If


        If txtOccupation.Text = "" Then
            EPOccupation.SetIconPadding(txtOccupation, 3)
            EPOccupation.SetError(txtOccupation, "Occupation is Required!")
            Exit Sub
        Else
            EPOccupation.Clear()
        End If


        If txtHouseNo.Text = "" Then
            EPHouseNo.SetIconPadding(txtHouseNo, 3)
            EPHouseNo.SetError(txtHouseNo, "House No. is Required!")
            Exit Sub
        Else
            EPHouseNo.Clear()
        End If


        If txtStreet.Text = "" Then
            EPStreet.SetIconPadding(txtStreet, 3)
            EPStreet.SetError(txtStreet, "Street is Required!")
            Exit Sub
        Else
            EPStreet.Clear()
        End If

        If cmbPurok.Text = "" Then
            EPPurok.SetIconPadding(cmbPurok, 3)
            EPPurok.SetError(cmbPurok, "Street is Required!")
            Exit Sub
        Else
            EPPurok.Clear()
        End If

        If residentPhotoPath = "" Then
            EPImage.SetIconPadding(picResident, 3)
            EPImage.SetError(picResident, "Image is Required!")
            Exit Sub
        Else
            EPImage.Clear()
        End If


        '-----------------------


        Try

            If action = "Insert" Then
                With command
                    .Parameters.Clear()
                    .CommandText = "procInsertResident"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_first_name", txtFirstName.Text)
                    .Parameters.AddWithValue("@p_middle_name", txtMiddleName.Text)
                    .Parameters.AddWithValue("@p_last_name", txtLastName.Text)
                    .Parameters.AddWithValue("@p_gender", cmbGender.Text)
                    .Parameters.AddWithValue("@p_birth_date", Format(dtBirthDate.Value, "yyyy-MM-dd"))
                    .Parameters.AddWithValue("@p_age", CInt(txtAge.Text))
                    .Parameters.AddWithValue("@p_email_address", txtEmailAddress.Text)
                    .Parameters.AddWithValue("@p_contact_no", txtContactNo.Text)
                    .Parameters.AddWithValue("@p_place_of_birth", txtPlaceOfBirth.Text)
                    .Parameters.AddWithValue("@p_civil_status", cmbCivilStatus.Text)
                    .Parameters.AddWithValue("@p_citizenship", txtCitizenship.Text)
                    .Parameters.AddWithValue("@p_occupation", txtOccupation.Text)
                    .Parameters.AddWithValue("@p_purok_name", cmbPurok.Text)
                    .Parameters.AddWithValue("@p_house_no", txtHouseNo.Text)
                    .Parameters.AddWithValue("@p_street", txtStreet.Text)
                    .Parameters.AddWithValue("@p_resident_pic", residentPhotoPath)
                    .ExecuteNonQuery()
                End With
            Else
                With command
                    .Parameters.Clear()
                    .CommandText = "procUpdateResidentByID"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_id", tempResidentID)
                    .Parameters.AddWithValue("@p_first_name", txtFirstName.Text)
                    .Parameters.AddWithValue("@p_middle_name", txtMiddleName.Text)
                    .Parameters.AddWithValue("@p_last_name", txtLastName.Text)
                    .Parameters.AddWithValue("@p_gender", cmbGender.Text)
                    .Parameters.AddWithValue("@p_birth_date", Format(dtBirthDate.Value, "yyyy-MM-dd"))
                    .Parameters.AddWithValue("@p_age", CInt(txtAge.Text))
                    .Parameters.AddWithValue("@p_email_address", txtEmailAddress.Text)
                    .Parameters.AddWithValue("@p_contact_no", txtContactNo.Text)
                    .Parameters.AddWithValue("@p_place_of_birth", txtPlaceOfBirth.Text)
                    .Parameters.AddWithValue("@p_civil_status", cmbCivilStatus.Text)
                    .Parameters.AddWithValue("@p_citizenship", txtCitizenship.Text)
                    .Parameters.AddWithValue("@p_occupation", txtOccupation.Text)
                    .Parameters.AddWithValue("@p_purok_name", cmbPurok.Text)
                    .Parameters.AddWithValue("@p_house_no", txtHouseNo.Text)
                    .Parameters.AddWithValue("@p_street", txtStreet.Text)
                    .Parameters.AddWithValue("@p_resident_pic", residentPhotoPath)
                    .ExecuteNonQuery()
                End With

            End If
            MessageBox.Show("Record Successfully Save", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub picResident_Click(sender As Object, e As EventArgs) Handles picResident.Click
        Try
            With OpenFileDialog1
                .Title = "Select Resident Picture"
                .FileName = ""
                If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    picResident.Image = Image.FromFile(.FileName)
                    residentPhotoPath = .FileName
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub dtBirthDate_ValueChanged(sender As Object, e As EventArgs) Handles dtBirthDate.ValueChanged
        Dim ts As TimeSpan = DateTime.Now.Date - dtBirthDate.Value
        txtAge.Text = String.Format("{0:n0}", (ts.TotalDays / 365))
    End Sub

    Private Sub frmAddResident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPurok.Items.Clear()
        fillDataComboPurok()
        If Label1.Text = "Update Resident" Then
            cmbPurok.SelectedIndex = cmbPurok.Items.IndexOf(purokName)
        End If
    End Sub

    Private Sub fillDataComboPurok()
        sqlAdapterBrgy = New MySqlDataAdapter
        datBrgy = New DataTable

        Try
            With command
                .Parameters.Clear()
                .CommandText = "SELECT * FROM tblpurok"
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
                If datBrgy.Rows.Count > 0 Then
                    row = 0
                    While Not datBrgy.Rows.Count - 1 < row
                        cmbPurok.Items.Add("" & datBrgy.Rows(row).Item("purok").ToString)
                        row = row + 1
                    End While
                End If
            End With

        Catch ex As Exception
            MessageBox.Show("" + ex.Message)
        End Try
    End Sub
End Class