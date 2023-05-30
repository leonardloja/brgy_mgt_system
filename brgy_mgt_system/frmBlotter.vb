Imports MySql.Data.MySqlClient
Public Class frmBlotter
    Private Sub frmBlotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If userType = "Administrator" Or userType = "Captain" Or userType = "Secretary" Then
            grdBlotter.Columns("Edit").Visible = True
            grdBlotter.Columns("Delete").Visible = True
            btnAdd.Enabled = True
        Else
            grdBlotter.Columns("Edit").Visible = False
            grdBlotter.Columns("Delete").Visible = False
            btnAdd.Enabled = False
        End If

        procDisplayBlotterRecords()
    End Sub

    Private Sub procDisplayBlotterRecords()
        datBrgy = New DataTable
        sqlAdapterBrgy = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayBlotterRecords"
                .CommandType = CommandType.StoredProcedure
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
                'lblTotal.Text = "Total Records : " & datHotel.Rows.Count
            End With
            If datBrgy.Rows.Count > 0 Then
                grdBlotter.RowCount = datBrgy.Rows.Count
                row = 0
                While Not datBrgy.Rows.Count - 1 < row
                    With grdBlotter
                        .Rows(row).Cells(1).Value = datBrgy.Rows(row).Item("id").ToString
                        .Rows(row).Cells(2).Value = datBrgy.Rows(row).Item("incident_type").ToString
                        .Rows(row).Cells(3).Value = datBrgy.Rows(row).Item("location").ToString
                        .Rows(row).Cells(4).Value = datBrgy.Rows(row).Item("date_time_reported").ToString
                        .Rows(row).Cells(5).Value = datBrgy.Rows(row).Item("date_time_incident").ToString
                        .Rows(row).Cells(6).Value = datBrgy.Rows(row).Item("incident_details").ToString
                        .Rows(row).Cells(7).Value = datBrgy.Rows(row).Item("reporting_person").ToString
                        .Rows(row).Cells(8).Value = datBrgy.Rows(row).Item("contact_no").ToString
                    End With
                    row += 1
                End While

            Else
                grdBlotter.Rows.Clear()
                MessageBox.Show("NO Record Found!", "Recrod Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmModal.ShowInTaskbar = False
        frmModal.StartPosition = FormStartPosition.Manual
        frmModal.Location = frmMain.Location
        frmModal.Size = frmMain.Size
        frmModal.TopMost = False
        frmModal.Owner = Me
        frmModal.Show()

        Try
            With frmAddBlotterRecord
                .btnSave.Visible = True
                .btnUpdate.Visible = False

                .txtContactNo.ResetText()
                .txtIncidentDetails.ResetText()
                .txtIncidentType.ResetText()
                .txtLocation.ResetText()
                .txtReportingPerson.ResetText()
                .dtReported.ResetText()
                .dtIncident.ResetText()

                .ShowInTaskbar = False
                .TopMost = False
                .Owner = Me
                .StartPosition = FormStartPosition.CenterParent
                .ShowDialog()
            End With
            frmAddBlotterRecord.Close()
            frmModal.Dispose()
            procDisplayBlotterRecords()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

    Private Sub grdBlotter_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdBlotter.CellContentClick

        colName = grdBlotter.Columns(e.ColumnIndex).Name

        '-- EDIT

        If colName = "Edit" Then
            Try
                frmModal.ShowInTaskbar = False
                frmModal.StartPosition = FormStartPosition.Manual
                frmModal.Location = frmMain.Location
                frmModal.Size = frmMain.Size
                frmModal.TopMost = False
                frmModal.Owner = Me
                frmModal.Show()
                With frmAddBlotterRecord
                    blotterID = grdBlotter.CurrentRow.Cells(1).Value.ToString
                    .txtIncidentType.Text = grdBlotter.CurrentRow.Cells(2).Value.ToString
                    .txtLocation.Text = grdBlotter.CurrentRow.Cells(3).Value.ToString
                    .dtReported.Text = grdBlotter.CurrentRow.Cells(4).Value.ToString
                    .dtIncident.Text = grdBlotter.CurrentRow.Cells(5).Value.ToString
                    .txtReportingPerson.Text = grdBlotter.CurrentRow.Cells(7).Value.ToString
                    .txtContactNo.Text = grdBlotter.CurrentRow.Cells(8).Value.ToString
                    .txtIncidentDetails.Text = grdBlotter.CurrentRow.Cells(6).Value.ToString

                    .ShowInTaskbar = False
                    .TopMost = False
                    .Owner = Me
                    .StartPosition = FormStartPosition.CenterParent
                    .btnSave.Visible = False
                    .btnUpdate.Visible = True
                    .ShowDialog()
                End With
                procDisplayBlotterRecords()
                frmModal.Close()
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try
            'If txtSearch.Text.Length > 0 Then
            '    btnSearch.PerformClick()
            'End If
        End If



        '-- DELETE 

        If colName = "Delete" Then
            Try
                With command
                    .Parameters.Clear()
                    .CommandText = "procDeleteBlotterRecord"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_id", CInt(grdBlotter.CurrentRow.Cells(1).Value))
                    .ExecuteNonQuery()
                    MessageBox.Show("Record Successfully Deleted!", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End With
                procDisplayBlotterRecords()
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
                With frmViewBlotterRecord
                    .lblIncidentType.Text = grdBlotter.CurrentRow.Cells(2).Value.ToString
                    .lblLocation.Text = grdBlotter.CurrentRow.Cells(3).Value.ToString
                    .lblDTReported.Text = grdBlotter.CurrentRow.Cells(4).Value.ToString
                    .lblDTIncident.Text = grdBlotter.CurrentRow.Cells(5).Value.ToString
                    .lblReportingPerson.Text = grdBlotter.CurrentRow.Cells(7).Value.ToString
                    .lblContactNo.Text = grdBlotter.CurrentRow.Cells(8).Value.ToString
                    .txtIncidentDetails.Text = grdBlotter.CurrentRow.Cells(6).Value.ToString

                    .ShowInTaskbar = False
                    .TopMost = False
                    .Owner = Me
                    .StartPosition = FormStartPosition.CenterParent
                    .ShowDialog()
                End With
                procDisplayBlotterRecords()
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try
            frmModal.Close()

            'If txtSearch.Text.Length > 0 Then
            '    btnSearch.PerformClick()
            'End If
        End If

    End Sub



    Private Sub procAutoDisplayBlotterBySearchType(ByVal p_searchType As String, ByVal p_searchtext As String)
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procAutoDisplayBlotterBySearchType"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_search_type", p_searchType)
                .Parameters.AddWithValue("@p_value", p_searchtext)
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
            End With
            If datBrgy.Rows.Count > 0 Then
                grdBlotter.RowCount = datBrgy.Rows.Count
                row = 0
                While Not datBrgy.Rows.Count - 1 < row
                    With grdBlotter

                        .Rows(row).Cells(1).Value = datBrgy.Rows(row).Item("id").ToString
                        .Rows(row).Cells(2).Value = datBrgy.Rows(row).Item("incident_type").ToString
                        .Rows(row).Cells(3).Value = datBrgy.Rows(row).Item("location").ToString
                        .Rows(row).Cells(4).Value = datBrgy.Rows(row).Item("date_time_reported").ToString
                        .Rows(row).Cells(5).Value = datBrgy.Rows(row).Item("date_time_incident").ToString
                        .Rows(row).Cells(6).Value = datBrgy.Rows(row).Item("incident_details").ToString
                        .Rows(row).Cells(7).Value = datBrgy.Rows(row).Item("reporting_person").ToString
                        .Rows(row).Cells(8).Value = datBrgy.Rows(row).Item("contact_no").ToString

                    End With
                    row += 1
                End While
            Else
                grdBlotter.Rows.Clear()
                'MessageBox.Show("NO Record Found", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Length > 0 Then
            procAutoDisplayBlotterBySearchType(cmbSearchType.Text, txtSearch.Text)
        End If
    End Sub

    Private Sub cmbSearchType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchType.SelectedIndexChanged
        If cmbSearchType.Text = "All" Then
            txtSearch.Enabled = False
            txtSearch.Text = ""
            procDisplayBlotterRecords()
        Else
            txtSearch.Enabled = True
        End If
    End Sub
End Class