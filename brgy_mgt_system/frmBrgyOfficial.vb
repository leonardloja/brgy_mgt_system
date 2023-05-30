Imports MySql.Data.MySqlClient
Public Class frmBrgyOfficial

    Dim resident_pic As String
    Dim full_name As String
    Dim position As String
    Dim term As String
    Dim status As String
    Private Sub frmBrgyOfficial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If userType = "Administrator" Or userType = "Captain" Or userType = "Secretary" Then
            grdBrgyOfficial.Columns("Edit").Visible = True
        Else
            grdBrgyOfficial.Columns("Edit").Visible = False
        End If

        procDisplayAllBrgyOfficial()
    End Sub

    Private Sub procDisplayAllBrgyOfficial()
        datBrgy = New DataTable
        sqlAdapterBrgy = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayAllBrgyOfficial"
                .CommandType = CommandType.StoredProcedure
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
                'lblTotal.Text = "Total Records : " & datHotel.Rows.Count
            End With
            If datBrgy.Rows.Count > 0 Then
                grdBrgyOfficial.RowCount = datBrgy.Rows.Count
                row = 0
                While Not datBrgy.Rows.Count - 1 < row
                    With grdBrgyOfficial
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
                        .Rows(row).Cells(16).Value = datBrgy.Rows(row).Item("position").ToString
                        .Rows(row).Cells(17).Value = datBrgy.Rows(row).Item("term").ToString
                        .Rows(row).Cells(18).Value = datBrgy.Rows(row).Item("status").ToString
                        .Rows(row).Cells(19).Value = datBrgy.Rows(row).Item("resident_id").ToString
                    End With
                    row += 1
                End While

            Else
                grdBrgyOfficial.Rows.Clear()
                MessageBox.Show("NO Record Found!", "Recrod Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub


    Private Sub procGetSelectedBrgyOfficial()
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayBrgyOfficialByID"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", CInt(grdBrgyOfficial.CurrentRow.Cells(2).Value))
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
            End With
            If datBrgy.Rows.Count > 0 Then
                resident_pic = datBrgy.Rows(0).Item("resident_pic").ToString
                tempOfficialID = CInt(datBrgy.Rows(0).Item("id").ToString)
                tempResidentID = CInt(datBrgy.Rows(0).Item("resident_id").ToString)
                full_name = datBrgy.Rows(0).Item("full_name").ToString
                position = datBrgy.Rows(0).Item("position").ToString
                term = datBrgy.Rows(0).Item("term").ToString
                status = datBrgy.Rows(0).Item("status").ToString
            Else
                MessageBox.Show("NO Record Found", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub


    Private Sub grdBrgyOfficial_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdBrgyOfficial.CellContentClick
        colName = grdBrgyOfficial.Columns(e.ColumnIndex).Name

        '-- EDIT

        If colName = "Edit" Then
            'action = "Edit"
            Try
                frmModal.ShowInTaskbar = False
                frmModal.StartPosition = FormStartPosition.Manual
                frmModal.Location = frmMain.Location
                frmModal.Size = frmMain.Size
                frmModal.TopMost = False
                frmModal.Owner = Me
                frmModal.Show()
                procGetSelectedBrgyOfficial()
                With frmEditBrgyOfficial
                    .picOfficial.Image = Image.FromFile(resident_pic)
                    .txtFullName.Text = full_name
                    .txtPosition.Text = position
                    .txtTerm.Text = term
                    .cmbStatus.Text = status


                    .ShowInTaskbar = False
                    .TopMost = False
                    .Owner = Me
                    .StartPosition = FormStartPosition.CenterParent
                    .ShowDialog()
                End With
                procDisplayAllBrgyOfficial()
                frmModal.Dispose()
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
                procGetSelectedBrgyOfficial()
                With frmViewResident
                    .lblHeader.Text = "Brgy. Official Information"
                    .picResident.Image = Image.FromFile(resident_pic)
                    .lblFullName.Text = grdBrgyOfficial.CurrentRow.Cells(3).Value.ToString
                    .lblGender.Text = grdBrgyOfficial.CurrentRow.Cells(4).Value.ToString
                    .lblBirthDate.Text = grdBrgyOfficial.CurrentRow.Cells(5).Value.ToString
                    .lblAge.Text = grdBrgyOfficial.CurrentRow.Cells(6).Value.ToString
                    .lblEmailAdd.Text = grdBrgyOfficial.CurrentRow.Cells(7).Value.ToString
                    .lblContactNo.Text = grdBrgyOfficial.CurrentRow.Cells(8).Value.ToString
                    .lblPlaceOfBirth.Text = grdBrgyOfficial.CurrentRow.Cells(9).Value.ToString
                    .lblCivilStatus.Text = grdBrgyOfficial.CurrentRow.Cells(10).Value.ToString
                    .lblCitizenship.Text = grdBrgyOfficial.CurrentRow.Cells(11).Value.ToString
                    .lblOccupation.Text = grdBrgyOfficial.CurrentRow.Cells(12).Value.ToString
                    .lblPurok.Text = grdBrgyOfficial.CurrentRow.Cells(13).Value.ToString
                    .lblHouseNo.Text = grdBrgyOfficial.CurrentRow.Cells(14).Value.ToString
                    .lblStreet.Text = grdBrgyOfficial.CurrentRow.Cells(15).Value.ToString

                    .ShowInTaskbar = False
                    .TopMost = False
                    .Owner = Me
                    .StartPosition = FormStartPosition.CenterParent
                    .ShowDialog()
                End With
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try
            frmModal.Dispose()
        End If
    End Sub



    '=============
    '   Print
    '=============
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        procDeleteTempData()
        procLoadTempData()
        frmBrgyOfficialPrint.Show()
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
        While row < grdBrgyOfficial.RowCount
            With grdBrgyOfficial
                procSaveTempData(.Rows(row).Cells(3).Value.ToString,
                                .Rows(row).Cells(6).Value.ToString,
                                .Rows(row).Cells(4).Value.ToString,
                                .Rows(row).Cells(16).Value.ToString,
                                .Rows(row).Cells(18).Value.ToString)
                row = row + 1
            End With
        End While
    End Sub


End Class