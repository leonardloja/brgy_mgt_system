Imports MySql.Data.MySqlClient
Public Class frmCertificate

    Private Sub frmCertificate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If userType = "Administrator" Or userType = "Captain" Or userType = "Secretary" Then
            grdIssueCertificate.Columns("Clearance").Visible = True
            grdIssueCertificate.Columns("Indigency").Visible = True
            grdIssueCertificate.Columns("Residency").Visible = True
            grdClearance.Columns("Print1").Visible = True
            grdIndigency.Columns("Print2").Visible = True
            grdResidency.Columns("Print3").Visible = True
        Else
            grdIssueCertificate.Columns("Clearance").Visible = False
            grdIssueCertificate.Columns("Indigency").Visible = False
            grdIssueCertificate.Columns("Residency").Visible = False
            grdClearance.Columns("Print1").Visible = False
            grdIndigency.Columns("Print2").Visible = False
            grdResidency.Columns("Print3").Visible = False
        End If

        btnIssueCert.PerformClick()
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
            End With
            If datBrgy.Rows.Count > 0 Then
                grdIssueCertificate.RowCount = datBrgy.Rows.Count
                row = 0
                While Not datBrgy.Rows.Count - 1 < row
                    With grdIssueCertificate
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
                grdIssueCertificate.Rows.Clear()
                MessageBox.Show("NO Record Found!", "Recrod Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub


    Private Sub btnIssueCert_Click(sender As Object, e As EventArgs) Handles btnIssueCert.Click
        BunifuPages.SetPage(0)
        procDisplayAllResident()

    End Sub
    Private Sub btnClearance_Click(sender As Object, e As EventArgs) Handles btnClearance.Click
        BunifuPages.SetPage(1)
        procDeleteExpiredCertificate()
        procDisplayCertificateClearance()
    End Sub

    Private Sub btnIndigency_Click(sender As Object, e As EventArgs) Handles btnIndigency.Click
        BunifuPages.SetPage(2)
        procDeleteExpiredCertificate()
        procDisplayCertificateIndigency()
    End Sub

    Private Sub btnResidency_Click(sender As Object, e As EventArgs) Handles btnResidency.Click
        BunifuPages.SetPage(3)
        procDeleteExpiredCertificate()
        procDisplayCertificateResidency()
    End Sub


    Private Sub procDeleteExpiredCertificate()

        Try
            With command
                .Parameters.Clear()
                .CommandText = "DELETE FROM tblcertificate WHERE date_expired = DATE(NOW());"
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub



    '========= CLEARANCE

    Private Sub procDisplayCertificateClearance()
        datBrgy = New DataTable
        sqlAdapterBrgy = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayCertificateClearance"
                .CommandType = CommandType.StoredProcedure
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
            End With

            If datBrgy.Rows.Count > 0 Then
                grdClearance.RowCount = datBrgy.Rows.Count
                row = 0
                While Not datBrgy.Rows.Count - 1 < row

                    With grdClearance
                        .Rows(row).Cells(1).Value = Image.FromFile(datBrgy.Rows(row).Item("resident_pic").ToString)
                        .Rows(row).Cells(2).Value = datBrgy.Rows(row).Item("id").ToString
                        .Rows(row).Cells(3).Value = datBrgy.Rows(row).Item("full_name").ToString
                        .Rows(row).Cells(4).Value = datBrgy.Rows(row).Item("gender").ToString
                        .Rows(row).Cells(6).Value = datBrgy.Rows(row).Item("age").ToString
                        .Rows(row).Cells(16).Value = datBrgy.Rows(row).Item("resident_id").ToString
                        .Rows(row).Cells(17).Value = datBrgy.Rows(row).Item("transaction_type").ToString
                        .Rows(row).Cells(18).Value = datBrgy.Rows(row).Item("date_issued").ToString
                        .Rows(row).Cells(19).Value = datBrgy.Rows(row).Item("date_expired").ToString
                        .Rows(row).Cells(20).Value = datBrgy.Rows(row).Item("or_number").ToString
                        .Rows(row).Cells(21).Value = datBrgy.Rows(row).Item("purpose").ToString
                    End With

                    row += 1
                End While

            Else
                grdClearance.Rows.Clear()
                MessageBox.Show("NO Record Found!", "Recrod Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    '========= INDIGENCY
    Private Sub procDisplayCertificateIndigency()
        datBrgy = New DataTable
        sqlAdapterBrgy = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayCertificateIndigency"
                .CommandType = CommandType.StoredProcedure
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
            End With

            If datBrgy.Rows.Count > 0 Then
                grdIndigency.RowCount = datBrgy.Rows.Count
                row = 0
                While Not datBrgy.Rows.Count - 1 < row

                    With grdIndigency
                        .Rows(row).Cells(1).Value = Image.FromFile(datBrgy.Rows(row).Item("resident_pic").ToString)
                        .Rows(row).Cells(2).Value = datBrgy.Rows(row).Item("id").ToString
                        .Rows(row).Cells(3).Value = datBrgy.Rows(row).Item("full_name").ToString
                        .Rows(row).Cells(4).Value = datBrgy.Rows(row).Item("gender").ToString
                        .Rows(row).Cells(6).Value = datBrgy.Rows(row).Item("age").ToString
                        .Rows(row).Cells(16).Value = datBrgy.Rows(row).Item("resident_id").ToString
                        .Rows(row).Cells(17).Value = datBrgy.Rows(row).Item("transaction_type").ToString
                        .Rows(row).Cells(18).Value = datBrgy.Rows(row).Item("date_issued").ToString
                        .Rows(row).Cells(19).Value = datBrgy.Rows(row).Item("date_expired").ToString
                        .Rows(row).Cells(20).Value = ""
                        .Rows(row).Cells(21).Value = datBrgy.Rows(row).Item("purpose").ToString
                    End With

                    row += 1
                End While

            Else
                grdIndigency.Rows.Clear()
                MessageBox.Show("NO Record Found!", "Recrod Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    '========= RESIDENCY

    Private Sub procDisplayCertificateResidency()
        datBrgy = New DataTable
        sqlAdapterBrgy = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayCertificateResidency"
                .CommandType = CommandType.StoredProcedure
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
            End With

            If datBrgy.Rows.Count > 0 Then
                grdResidency.RowCount = datBrgy.Rows.Count
                row = 0
                While Not datBrgy.Rows.Count - 1 < row
                    With grdResidency
                        .Rows(row).Cells(1).Value = Image.FromFile(datBrgy.Rows(row).Item("resident_pic").ToString)
                        .Rows(row).Cells(2).Value = datBrgy.Rows(row).Item("id").ToString
                        .Rows(row).Cells(3).Value = datBrgy.Rows(row).Item("full_name").ToString
                        .Rows(row).Cells(4).Value = datBrgy.Rows(row).Item("gender").ToString
                        .Rows(row).Cells(6).Value = datBrgy.Rows(row).Item("age").ToString
                        .Rows(row).Cells(16).Value = datBrgy.Rows(row).Item("resident_id").ToString
                        .Rows(row).Cells(17).Value = datBrgy.Rows(row).Item("transaction_type").ToString
                        .Rows(row).Cells(18).Value = datBrgy.Rows(row).Item("date_issued").ToString
                        .Rows(row).Cells(19).Value = datBrgy.Rows(row).Item("date_expired").ToString
                        .Rows(row).Cells(20).Value = ""
                        .Rows(row).Cells(21).Value = datBrgy.Rows(row).Item("purpose").ToString
                    End With

                    row += 1
                End While

            Else
                grdResidency.Rows.Clear()
                MessageBox.Show("NO Record Found!", "Recrod Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub




    Private Sub grdIssueCertificate_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdIssueCertificate.CellContentClick
        colName = grdIssueCertificate.Columns(e.ColumnIndex).Name



        Try
            '-- Clearance
            If colName = "Clearance" Then
                frmModal.ShowInTaskbar = False
                frmModal.StartPosition = FormStartPosition.Manual
                frmModal.Location = frmMain.Location
                frmModal.Size = frmMain.Size
                frmModal.TopMost = False
                frmModal.Owner = Me
                frmModal.Show()

                tempResidentID = CInt(grdIssueCertificate.CurrentRow.Cells(2).Value.ToString())
                tempTransactionType = "Clearance"

                With frmIssueCertificate
                    .lblHeader.Text = "Barangay Clearance"
                    .lblOR.Visible = True
                    .txtOR.Visible = True
                    .txtPurpose.Height = 110

                    .ShowInTaskbar = False
                    .TopMost = False
                    .Owner = Me
                    .StartPosition = FormStartPosition.CenterParent
                    .ShowDialog()
                End With
                frmModal.Close()
            End If


            '-- Indigency
            If colName = "Indigency" Then
                Try
                    frmModal.ShowInTaskbar = False
                    frmModal.StartPosition = FormStartPosition.Manual
                    frmModal.Location = frmMain.Location
                    frmModal.Size = frmMain.Size
                    frmModal.TopMost = False
                    frmModal.Owner = Me
                    frmModal.Show()

                    tempResidentID = CInt(grdIssueCertificate.CurrentRow.Cells(2).Value.ToString())
                    tempTransactionType = "Indigency"

                    With frmIssueCertificate
                        .lblHeader.Text = "Indigency"
                        .lblOR.Visible = False
                        .txtOR.Visible = False
                        .txtPurpose.Height = 200

                        .ShowInTaskbar = False
                        .TopMost = False
                        .Owner = Me
                        .StartPosition = FormStartPosition.CenterParent
                        .ShowDialog()
                    End With
                    frmModal.Close()
                Catch ex As Exception
                    MessageBox.Show("" & ex.Message)
                End Try
            End If



            '-- Residency
            If colName = "Residency" Then
                Try
                    frmModal.ShowInTaskbar = False
                    frmModal.StartPosition = FormStartPosition.Manual
                    frmModal.Location = frmMain.Location
                    frmModal.Size = frmMain.Size
                    frmModal.TopMost = False
                    frmModal.Owner = Me
                    frmModal.Show()

                    tempResidentID = CInt(grdIssueCertificate.CurrentRow.Cells(2).Value.ToString())
                    tempTransactionType = "Residency"

                    With frmIssueCertificate
                        .lblHeader.Text = "Residency"
                        .lblOR.Visible = False
                        .txtOR.Visible = False
                        .txtPurpose.Height = 200

                        .ShowInTaskbar = False
                        .TopMost = False
                        .Owner = Me
                        .StartPosition = FormStartPosition.CenterParent
                        .ShowDialog()
                    End With
                    frmModal.Close()
                Catch ex As Exception
                    MessageBox.Show("" & ex.Message)
                End Try
            End If


        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try



    End Sub

    '========= PRINT

    Private Sub grdClearance_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdClearance.CellContentClick
        colName = grdClearance.Columns(e.ColumnIndex).Name


        ' Clearance Form
        Try
            If colName = "Print1" Then
                procDeleteTempData()
                procLoadTempData(grdClearance)
                frmClearancePrint.Show()
            End If

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub


    Private Sub grdIndigency_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdIndigency.CellContentClick
        colName = grdIndigency.Columns(e.ColumnIndex).Name


        ' Indigency
        Try
            If colName = "Print2" Then
                procDeleteTempData()
                procLoadTempData(grdIndigency)
                frmIndigencyPrint.Show()
            End If

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub grdResidency_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdResidency.CellContentClick
        colName = grdResidency.Columns(e.ColumnIndex).Name


        ' Residency
        Try
            If colName = "Print3" Then
                procDeleteTempData()
                procLoadTempData(grdResidency)
                frmResidencyPrint.Show()
            End If

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub procSaveTempData(str1 As String, str2 As String, str3 As String,
                               str4 As String, str5 As String, str6 As String, str7 As String, str8 As String) ' Save data from datagridview to tblprint
        Try
            With command
                .Parameters.Clear()
                .CommandText = "Insert into tblprintdata(tempData1, tempData2, tempData3, tempData4, tempData5, tempData6, tempData7, tempData8) values('" & str1 & "','" & str2 & "','" & str3 & "','" & str4 & "','" & str5 & "', '" & str6 & "', '" & str7 & "', '" & str8 & "') "
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

    Private Sub procLoadTempData(grd As DataGridView)

        ' Format Date

        With grd
            procSaveTempData(.CurrentRow.Cells(3).Value.ToString, 'Full name
                             .CurrentRow.Cells(6).Value.ToString, 'Age
                             .CurrentRow.Cells(4).Value.ToString, 'Gender
                             GetOrdinal(CInt(Format(CDate(.CurrentRow.Cells(18).Value.ToString), "dd"))), ' Ex. 8th
                             Format(CDate(.CurrentRow.Cells(18).Value.ToString), "MMMMM"), ' Ex. July
                             .CurrentRow.Cells(20).Value.ToString, ' OR. No
                             .CurrentRow.Cells(18).Value.ToString, ' Date Issued
                             brgyCaptain) ' Brgy captain Full name

        End With

    End Sub

    '========= SEARCH

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
                grdIssueCertificate.RowCount = datBrgy.Rows.Count
                row = 0
                While Not datBrgy.Rows.Count - 1 < row
                    With grdIssueCertificate
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
                grdIssueCertificate.Rows.Clear()
                'MessageBox.Show("NO Record Found", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

    Private Sub txtSearchIC_TextChanged(sender As Object, e As EventArgs) Handles txtSearchIC.TextChanged
        procAutoDisplayCustomerBySearchType(cmbSearchTypeIC.Text, txtSearchIC.Text)
    End Sub



    '========= SEARCH Clearance

    Private Sub procAutoDisplayClearanceBySearchType(ByVal p_searchType As String, ByVal p_searchtext As String)
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procAutoDisplayClearanceBySearchType"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_search_type", p_searchType)
                .Parameters.AddWithValue("@p_value", p_searchtext)
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
            End With
            If datBrgy.Rows.Count > 0 Then
                grdClearance.RowCount = datBrgy.Rows.Count
                row = 0
                While Not datBrgy.Rows.Count - 1 < row
                    With grdClearance
                        .Rows(row).Cells(1).Value = Image.FromFile(datBrgy.Rows(row).Item("resident_pic").ToString)
                        .Rows(row).Cells(2).Value = datBrgy.Rows(row).Item("id").ToString
                        .Rows(row).Cells(3).Value = datBrgy.Rows(row).Item("full_name").ToString
                        .Rows(row).Cells(4).Value = datBrgy.Rows(row).Item("gender").ToString
                        .Rows(row).Cells(6).Value = datBrgy.Rows(row).Item("age").ToString
                        .Rows(row).Cells(16).Value = datBrgy.Rows(row).Item("resident_id").ToString
                        .Rows(row).Cells(17).Value = datBrgy.Rows(row).Item("transaction_type").ToString
                        .Rows(row).Cells(18).Value = datBrgy.Rows(row).Item("date_issued").ToString
                        .Rows(row).Cells(19).Value = datBrgy.Rows(row).Item("date_expired").ToString
                        .Rows(row).Cells(20).Value = datBrgy.Rows(row).Item("or_number").ToString
                        .Rows(row).Cells(21).Value = datBrgy.Rows(row).Item("purpose").ToString
                    End With
                    row += 1
                End While
            Else
                grdClearance.Rows.Clear()
                'MessageBox.Show("NO Record Found", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub


    Private Sub txtSearchC_TextChanged(sender As Object, e As EventArgs) Handles txtSearchC.TextChanged
        procAutoDisplayClearanceBySearchType(cmbSearchTypeIC.Text, txtSearchC.Text)
    End Sub


    '========= SEARCH Indigency

    Private Sub procAutoDisplayIndigencyBySearchType(ByVal p_searchType As String, ByVal p_searchtext As String)
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procAutoDisplayIndigencyBySearchType"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_search_type", p_searchType)
                .Parameters.AddWithValue("@p_value", p_searchtext)
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
            End With
            If datBrgy.Rows.Count > 0 Then
                grdIndigency.RowCount = datBrgy.Rows.Count
                row = 0
                While Not datBrgy.Rows.Count - 1 < row
                    With grdIndigency
                        .Rows(row).Cells(1).Value = Image.FromFile(datBrgy.Rows(row).Item("resident_pic").ToString)
                        .Rows(row).Cells(2).Value = datBrgy.Rows(row).Item("id").ToString
                        .Rows(row).Cells(3).Value = datBrgy.Rows(row).Item("full_name").ToString
                        .Rows(row).Cells(4).Value = datBrgy.Rows(row).Item("gender").ToString
                        .Rows(row).Cells(6).Value = datBrgy.Rows(row).Item("age").ToString
                        .Rows(row).Cells(16).Value = datBrgy.Rows(row).Item("resident_id").ToString
                        .Rows(row).Cells(17).Value = datBrgy.Rows(row).Item("transaction_type").ToString
                        .Rows(row).Cells(18).Value = datBrgy.Rows(row).Item("date_issued").ToString
                        .Rows(row).Cells(19).Value = datBrgy.Rows(row).Item("date_expired").ToString
                        .Rows(row).Cells(20).Value = datBrgy.Rows(row).Item("or_number").ToString
                        .Rows(row).Cells(21).Value = datBrgy.Rows(row).Item("purpose").ToString
                    End With
                    row += 1
                End While
            Else
                grdIndigency.Rows.Clear()
                'MessageBox.Show("NO Record Found", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub txtSearchI_TextChanged(sender As Object, e As EventArgs) Handles txtSearchI.TextChanged
        procAutoDisplayIndigencyBySearchType(cmbSearchTypeI.Text, txtSearchI.Text)
    End Sub

    '========= SEARCH Residency

    Private Sub procAutoDisplayResidencyBySearchType(ByVal p_searchType As String, ByVal p_searchtext As String)
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procAutoDisplayResidencyBySearchType"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_search_type", p_searchType)
                .Parameters.AddWithValue("@p_value", p_searchtext)
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
            End With
            If datBrgy.Rows.Count > 0 Then
                grdResidency.RowCount = datBrgy.Rows.Count
                row = 0
                While Not datBrgy.Rows.Count - 1 < row
                    With grdResidency
                        .Rows(row).Cells(1).Value = Image.FromFile(datBrgy.Rows(row).Item("resident_pic").ToString)
                        .Rows(row).Cells(2).Value = datBrgy.Rows(row).Item("id").ToString
                        .Rows(row).Cells(3).Value = datBrgy.Rows(row).Item("full_name").ToString
                        .Rows(row).Cells(4).Value = datBrgy.Rows(row).Item("gender").ToString
                        .Rows(row).Cells(6).Value = datBrgy.Rows(row).Item("age").ToString
                        .Rows(row).Cells(16).Value = datBrgy.Rows(row).Item("resident_id").ToString
                        .Rows(row).Cells(17).Value = datBrgy.Rows(row).Item("transaction_type").ToString
                        .Rows(row).Cells(18).Value = datBrgy.Rows(row).Item("date_issued").ToString
                        .Rows(row).Cells(19).Value = datBrgy.Rows(row).Item("date_expired").ToString
                        .Rows(row).Cells(20).Value = datBrgy.Rows(row).Item("or_number").ToString
                        .Rows(row).Cells(21).Value = datBrgy.Rows(row).Item("purpose").ToString
                    End With
                    row += 1
                End While
            Else
                grdResidency.Rows.Clear()
                'MessageBox.Show("NO Record Found", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
    Private Sub txtSearchR_TextChanged(sender As Object, e As EventArgs) Handles txtSearchR.TextChanged
        procAutoDisplayResidencyBySearchType(cmbSearchTypeR.Text, txtSearchR.Text)
    End Sub

    Private Sub cmbSearchTypeC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchTypeC.SelectedIndexChanged
        If cmbSearchTypeC.Text = "All" Then
            txtSearchC.Enabled = False
            txtSearchC.Text = ""
            procDisplayCertificateClearance()
        Else
            txtSearchC.Enabled = True
        End If
    End Sub

    Private Sub cmbSearchTypeIC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchTypeIC.SelectedIndexChanged
        If cmbSearchTypeIC.Text = "All" Then
            txtSearchIC.Enabled = False
            txtSearchIC.Text = ""
            procDisplayAllResident()
        Else
            txtSearchIC.Enabled = True
        End If
    End Sub

    Private Sub cmbSearchTypeI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchTypeI.SelectedIndexChanged
        If cmbSearchTypeI.Text = "All" Then
            txtSearchI.Enabled = False
            txtSearchI.Text = ""
            procDisplayCertificateIndigency()
        Else
            txtSearchI.Enabled = True
        End If
    End Sub

    Private Sub cmbSearchTypeR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchTypeR.SelectedIndexChanged
        If cmbSearchTypeR.Text = "All" Then
            txtSearchR.Enabled = False
            txtSearchR.Text = ""
            procDisplayCertificateResidency()
        Else
            txtSearchR.Enabled = True
        End If
    End Sub
End Class