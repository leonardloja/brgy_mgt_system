Imports MySql.Data.MySqlClient
Public Class frmResidentBrowse
    Private Sub frmResidentBrowse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        procDisplayAllResident()
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
                        .Rows(row).Cells(16).Value = datBrgy.Rows(row).Item("resident_pic").ToString

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
                MessageBox.Show("NO Record Found", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        procDisplayCustomerBySearchType(cmbSearchType.Text, txtSearch.Text)
    End Sub

    Private Sub cmbSearchType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchType.SelectedIndexChanged
        If cmbSearchType.Text = "All" Then
            btnSearch.PerformClick()
            txtSearch.Text = ""
            txtSearch.Enabled = False
            btnSearch.Enabled = False
        Else
            txtSearch.Enabled = True
            btnSearch.Enabled = True
        End If
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        residentPhotoPath = grdResident.CurrentRow.Cells(16).Value.ToString
        tempResidentID = CInt(grdResident.CurrentRow.Cells(2).Value.ToString)
        tempFullName = grdResident.CurrentRow.Cells(3).Value.ToString
        With frmEditBrgyOfficial
            .picOfficial.Image = Image.FromFile(residentPhotoPath)
            .txtFullName.Text = tempFullName
        End With
        Me.Close()
    End Sub
End Class