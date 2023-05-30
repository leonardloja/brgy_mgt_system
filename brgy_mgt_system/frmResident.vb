Imports MySql.Data.MySqlClient
Public Class frmResident

    Dim resident_pic As String
    Dim first_name As String
    Dim middle_name As String
    Dim last_name As String
    Dim gender As String
    Dim birth_date As String
    Dim age As String
    Dim email_address As String
    Dim contact_no As String
    Dim place_of_birth As String
    Dim civil_status As String
    Dim citizenship As String
    Dim occupation As String
    Dim purok_name As String
    Dim house_no As String
    Dim street As String

    Private Sub frmResident_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If userType = "Administrator" Or userType = "Captain" Or userType = "Secretary" Then
            grdResident.Columns("Edit").Visible = True
            grdResident.Columns("Delete").Visible = True
            btnAdd.Enabled = True
        Else
            grdResident.Columns("Edit").Visible = False
            grdResident.Columns("Delete").Visible = False
            btnAdd.Enabled = False
        End If

        chkDatabaseConnection()
        procDisplayAllResident()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            frmModal.ShowInTaskbar = False
            frmModal.StartPosition = FormStartPosition.Manual
            frmModal.Location = frmMain.Location
            frmModal.Size = frmMain.Size
            frmModal.TopMost = False
            frmModal.Owner = Me
            frmModal.Show()
            With frmAddResident
                action = "Insert"
                .Label1.Text = "Add Resident"
                residentPhotoPath = Nothing
                .picResident.Image = .picResident.InitialImage
                .txtFirstName.Clear()
                .txtMiddleName.Clear()
                .txtLastName.Clear()
                .dtBirthDate.Text = ""
                .txtEmailAddress.Clear()
                .cmbGender.StartIndex = 0
                .txtPlaceOfBirth.Clear()
                .txtCitizenship.Clear()
                .cmbCivilStatus.StartIndex = 0
                .txtContactNo.Clear()
                .txtOccupation.Clear()
                .txtHouseNo.Clear()
                .txtStreet.Clear()
                .cmbPurok.StartIndex = -1

                .ShowInTaskbar = False
                .TopMost = False
                .Owner = Me
                .StartPosition = FormStartPosition.CenterParent
                .ShowDialog()
            End With
            frmAddResident.Close()
            frmModal.Dispose()
            procDisplayAllResident()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub procDisplayAllResident()
        datBrgy = New DataTable
        sqlAdapterBrgy = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayAllResident"
                .CommandType = CommandType.StoredProcedure
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
                'lblTotal.Text = "Total Records : " & datHotel.Rows.Count
            End With
            If datBrgy.Rows.Count > 0 Then
                grdResident.RowCount = datBrgy.Rows.Count
                row = 0
                While Not datBrgy.Rows.Count - 1 < row
                    With grdResident
                        .Rows(row).Cells(1).Value = Image.FromFile(datBrgy.Rows(row).Item("resident_pic").ToString)
                        .Rows(row).Cells(2).Value = datBrgy.Rows(row).Item("id").ToString
                        .Rows(row).Cells(3).Value = datBrgy.Rows(row).Item("full_name").ToString
                        .Rows(row).Cells(4).Value = datBrgy.Rows(row).Item("gender").ToString
                        .Rows(row).Cells(5).Value = datBrgy.Rows(row).Item("birth_date").ToString
                        .Rows(row).Cells(6).Value = datBrgy.Rows(row).Item("age").ToString
                        .Rows(row).Cells(7).Value = datBrgy.Rows(row).Item("email_address").ToString
                        .Rows(row).Cells(8).Value = datBrgy.Rows(row).Item("contact_no").ToString
                        .Rows(row).Cells(9).Value = datBrgy.Rows(row).Item("place_of_birth").ToString
                        .Rows(row).Cells(10).Value = datBrgy.Rows(row).Item("civil_status").ToString
                        .Rows(row).Cells(11).Value = datBrgy.Rows(row).Item("citizenship").ToString
                        .Rows(row).Cells(12).Value = datBrgy.Rows(row).Item("occupation").ToString
                        .Rows(row).Cells(13).Value = datBrgy.Rows(row).Item("purok_name").ToString
                        .Rows(row).Cells(14).Value = datBrgy.Rows(row).Item("house_no").ToString
                        .Rows(row).Cells(15).Value = datBrgy.Rows(row).Item("street").ToString
                    End With
                    row += 1
                End While

            Else
                grdResident.Rows.Clear()
                MessageBox.Show("NO Record Found!", "Recrod Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub


    Private Sub procGetSelectedResident()
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayRecordByID"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", CInt(grdResident.CurrentRow.Cells(2).Value))
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
            End With
            If datBrgy.Rows.Count > 0 Then
                resident_pic = datBrgy.Rows(0).Item("resident_pic").ToString
                tempResidentID = CInt(datBrgy.Rows(0).Item("id").ToString)
                first_name = datBrgy.Rows(0).Item("first_name").ToString
                middle_name = datBrgy.Rows(0).Item("middle_name").ToString
                last_name = datBrgy.Rows(0).Item("last_name").ToString
                gender = datBrgy.Rows(0).Item("gender").ToString
                birth_date = datBrgy.Rows(0).Item("birth_date").ToString
                age = datBrgy.Rows(0).Item("age").ToString
                email_address = datBrgy.Rows(0).Item("email_address").ToString
                contact_no = datBrgy.Rows(0).Item("contact_no").ToString
                place_of_birth = datBrgy.Rows(0).Item("place_of_birth").ToString
                civil_status = datBrgy.Rows(0).Item("civil_status").ToString
                citizenship = datBrgy.Rows(0).Item("citizenship").ToString
                occupation = datBrgy.Rows(0).Item("occupation").ToString
                purok_name = datBrgy.Rows(0).Item("purok_name").ToString
                house_no = datBrgy.Rows(0).Item("house_no").ToString
                street = datBrgy.Rows(0).Item("street").ToString
            Else
                MessageBox.Show("NO Record Found", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        procDisplayCustomerBySearchType(cmbSearchType.Text, txtSearch.Text)
    End Sub

    Private Sub procDisplayCustomerBySearchType(ByVal p_searchType As String, ByVal p_searchtext As String)
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayRecordBySearchType"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_search_type", p_searchType)
                .Parameters.AddWithValue("@p_value", p_searchtext)
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
            End With
            If datBrgy.Rows.Count > 0 Then
                grdResident.RowCount = datBrgy.Rows.Count
                row = 0
                While Not datBrgy.Rows.Count - 1 < row
                    With grdResident
                        .Rows(row).Cells(1).Value = Image.FromFile(datBrgy.Rows(row).Item("resident_pic").ToString)
                        .Rows(row).Cells(2).Value = datBrgy.Rows(row).Item("id").ToString
                        .Rows(row).Cells(3).Value = datBrgy.Rows(row).Item("full_name").ToString
                        .Rows(row).Cells(4).Value = datBrgy.Rows(row).Item("gender").ToString
                        .Rows(row).Cells(5).Value = datBrgy.Rows(row).Item("birth_date").ToString
                        .Rows(row).Cells(6).Value = datBrgy.Rows(row).Item("age").ToString
                        .Rows(row).Cells(7).Value = datBrgy.Rows(row).Item("email_address").ToString
                        .Rows(row).Cells(8).Value = datBrgy.Rows(row).Item("contact_no").ToString
                        .Rows(row).Cells(9).Value = datBrgy.Rows(row).Item("place_of_birth").ToString
                        .Rows(row).Cells(10).Value = datBrgy.Rows(row).Item("civil_status").ToString
                        .Rows(row).Cells(11).Value = datBrgy.Rows(row).Item("citizenship").ToString
                        .Rows(row).Cells(12).Value = datBrgy.Rows(row).Item("occupation").ToString
                        .Rows(row).Cells(13).Value = datBrgy.Rows(row).Item("purok_name").ToString
                        .Rows(row).Cells(14).Value = datBrgy.Rows(row).Item("house_no").ToString
                        .Rows(row).Cells(15).Value = datBrgy.Rows(row).Item("street").ToString
                    End With
                    row += 1
                End While
            Else
                grdResident.Rows.Clear()
                MessageBox.Show("NO Record Found", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub


    Private Sub procAutoDisplayCustomerBySearchType(ByVal p_searchType As String, ByVal p_searchtext As String)
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procAutoDisplayRecordBySearchType"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_search_type", p_searchType)
                .Parameters.AddWithValue("@p_value", p_searchtext)
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
            End With
            If datBrgy.Rows.Count > 0 Then
                grdResident.RowCount = datBrgy.Rows.Count
                row = 0
                While Not datBrgy.Rows.Count - 1 < row
                    With grdResident
                        .Rows(row).Cells(1).Value = Image.FromFile(datBrgy.Rows(row).Item("resident_pic").ToString)
                        .Rows(row).Cells(2).Value = datBrgy.Rows(row).Item("id").ToString
                        .Rows(row).Cells(3).Value = datBrgy.Rows(row).Item("full_name").ToString
                        .Rows(row).Cells(4).Value = datBrgy.Rows(row).Item("gender").ToString
                        .Rows(row).Cells(5).Value = datBrgy.Rows(row).Item("birth_date").ToString
                        .Rows(row).Cells(6).Value = datBrgy.Rows(row).Item("age").ToString
                        .Rows(row).Cells(7).Value = datBrgy.Rows(row).Item("email_address").ToString
                        .Rows(row).Cells(8).Value = datBrgy.Rows(row).Item("contact_no").ToString
                        .Rows(row).Cells(9).Value = datBrgy.Rows(row).Item("place_of_birth").ToString
                        .Rows(row).Cells(10).Value = datBrgy.Rows(row).Item("civil_status").ToString
                        .Rows(row).Cells(11).Value = datBrgy.Rows(row).Item("citizenship").ToString
                        .Rows(row).Cells(12).Value = datBrgy.Rows(row).Item("occupation").ToString
                        .Rows(row).Cells(13).Value = datBrgy.Rows(row).Item("purok_name").ToString
                        .Rows(row).Cells(14).Value = datBrgy.Rows(row).Item("house_no").ToString
                        .Rows(row).Cells(15).Value = datBrgy.Rows(row).Item("street").ToString
                    End With
                    row += 1
                End While
            Else
                grdResident.Rows.Clear()
                'MessageBox.Show("NO Record Found", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub


    Private Sub grdResident_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdResident.CellContentClick
        colName = grdResident.Columns(e.ColumnIndex).Name

        '-- EDIT

        If colName = "Edit" Then
            action = "Edit"
            Try
                frmModal.ShowInTaskbar = False
                frmModal.StartPosition = FormStartPosition.Manual
                frmModal.Location = frmMain.Location
                frmModal.Size = frmMain.Size
                frmModal.TopMost = False
                frmModal.Owner = Me
                frmModal.Show()
                procGetSelectedResident()
                With frmAddResident
                    .Label1.Text = "Update Resident"
                    residentPhotoPath = resident_pic
                    .picResident.Image = Image.FromFile(resident_pic)
                    .txtFirstName.Text = first_name
                    .txtMiddleName.Text = middle_name
                    .txtLastName.Text = last_name
                    .dtBirthDate.Text = birth_date
                    .txtAge.Text = age
                    .txtEmailAddress.Text = email_address
                    .cmbGender.Text = gender
                    .txtPlaceOfBirth.Text = place_of_birth
                    .txtCitizenship.Text = citizenship
                    .cmbCivilStatus.Text = civil_status
                    .txtContactNo.Text = contact_no
                    .txtOccupation.Text = occupation
                    .txtHouseNo.Text = house_no
                    .txtStreet.Text = street
                    purokName = purok_name

                    .ShowInTaskbar = False
                    .TopMost = False
                    .Owner = Me
                    .StartPosition = FormStartPosition.CenterParent
                    .ShowDialog()

                End With
                procDisplayAllResident()
                frmModal.Close()
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try
            If txtSearch.Text.Length > 0 And chkAuto.Checked = False Then
                btnSearch.PerformClick()
            End If
        End If



        '-- DELETE 

        If colName = "Delete" Then
            Try
                With command
                    .Parameters.Clear()
                    .CommandText = "procDeleteResident"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_id", CInt(grdResident.CurrentRow.Cells(2).Value))
                    .ExecuteNonQuery()
                    MessageBox.Show("Recorde Successfully Deleted!", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End With
                ' refresh/reload customer records in data grid view
                procDisplayAllResident()
                txtSearch.Text = ""
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try
        End If

        '-- VIEW

        If colName = "View" Then
            Try
                frmModal.ShowInTaskbar = False
                frmModal.StartPosition = FormStartPosition.Manual
                frmModal.Location = frmMain.Location
                frmModal.Size = frmMain.Size
                frmModal.TopMost = False
                frmModal.Owner = Me
                frmModal.Show()
                procGetSelectedResident()
                With frmViewResident
                    .lblHeader.Text = "Resident Information"
                    .picResident.Image = Image.FromFile(resident_pic)
                    .lblFullName.Text = grdResident.CurrentRow.Cells(3).Value.ToString
                    .lblGender.Text = grdResident.CurrentRow.Cells(4).Value.ToString
                    .lblBirthDate.Text = grdResident.CurrentRow.Cells(5).Value.ToString
                    .lblAge.Text = grdResident.CurrentRow.Cells(6).Value.ToString
                    .lblEmailAdd.Text = grdResident.CurrentRow.Cells(7).Value.ToString
                    .lblContactNo.Text = grdResident.CurrentRow.Cells(8).Value.ToString
                    .lblPlaceOfBirth.Text = grdResident.CurrentRow.Cells(9).Value.ToString
                    .lblCivilStatus.Text = grdResident.CurrentRow.Cells(10).Value.ToString
                    .lblCitizenship.Text = grdResident.CurrentRow.Cells(11).Value.ToString
                    .lblOccupation.Text = grdResident.CurrentRow.Cells(12).Value.ToString
                    .lblPurok.Text = grdResident.CurrentRow.Cells(13).Value.ToString
                    .lblHouseNo.Text = grdResident.CurrentRow.Cells(14).Value.ToString
                    .lblStreet.Text = grdResident.CurrentRow.Cells(15).Value.ToString

                    .ShowInTaskbar = False
                    .TopMost = False
                    .Owner = Me
                    .StartPosition = FormStartPosition.CenterParent
                    .ShowDialog()
                End With
                procDisplayAllResident()
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try
            frmModal.Close()

            If txtSearch.Text.Length > 0 And chkAuto.Checked = False And colName <> "Delete" Then
                btnSearch.PerformClick()
            End If
        End If
    End Sub

    Private Sub cmbSearchType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchType.SelectedIndexChanged
        If cmbSearchType.Text = "All" Then
            btnSearch.PerformClick()
            txtSearch.Text = ""
            chkAuto.Checked = False
            chkAuto.Enabled = False
            txtSearch.Enabled = False
            btnSearch.Enabled = False
        ElseIf chkAuto.Checked = True Then
            btnSearch.Enabled = False
        Else
            txtSearch.Enabled = True
            chkAuto.Enabled = True
            btnSearch.Enabled = True
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        procDeleteTempData()
        procLoadTempData()
        frmResidentPrint.Show()
    End Sub

    Private Sub procSaveTempData(str1 As String, str2 As String, str3 As String,
                                str4 As String, str5 As String) ' Save data from datagridview to tblprint
        Try
            With command
                .Parameters.Clear()
                .CommandText = "Insert into tblprintdata(tempData1, tempData2, tempData3, tempData4, tempData5) values('" & str1 & "','" & str2 & "','" & str3 & "','" & str4 & "','" & str5 & "')"
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
    Private Sub procDeleteTempData()  ' DELETE TABLE TBLPRINT DATA BEFORE USING IT
        Try
            With command
                .Parameters.Clear()
                .CommandText = "DELETE FROM tblprintdata"
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub procLoadTempData()
        Dim row As Integer
        row = 0
        While row < grdResident.RowCount
            With grdResident
                procSaveTempData(.Rows(row).Cells(3).Value.ToString,
                                .Rows(row).Cells(4).Value.ToString,
                                .Rows(row).Cells(6).Value.ToString,
                                .Rows(row).Cells(8).Value.ToString,
                                .Rows(row).Cells(13).Value.ToString)
                row = row + 1
            End With
        End While
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        If chkAuto.Checked = True Then
            'kung naka check ang checkbox
            procAutoDisplayCustomerBySearchType(cmbSearchType.Text, txtSearch.Text)
        End If
    End Sub

    Private Sub chkAuto_CheckedChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs) Handles chkAuto.CheckedChanged
        If chkAuto.Checked = True Then
            btnSearch.Enabled = False
        Else
            btnSearch.Enabled = True
        End If
    End Sub
End Class