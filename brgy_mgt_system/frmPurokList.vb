Imports MySql.Data.MySqlClient
Public Class frmPurokList
    Private Sub frmPurokList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If userType = "Administrator" Or userType = "Captain" Or userType = "Secretary" Then
            grdPurok.Columns("Edit").Visible = True
            grdPurok.Columns("Delete").Visible = True
            btnAdd.Enabled = True
        Else
            grdPurok.Columns("Edit").Visible = False
            grdPurok.Columns("Delete").Visible = False
            btnAdd.Enabled = False
        End If

        procDisplayAllPurok()
    End Sub


    Private Sub procDisplayAllPurok()
        datBrgy = New DataTable
        sqlAdapterBrgy = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayAllPurok"
                .CommandType = CommandType.StoredProcedure
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
                'lblTotal.Text = "Total Records : " & datHotel.Rows.Count
            End With
            If datBrgy.Rows.Count > 0 Then
                grdPurok.RowCount = datBrgy.Rows.Count
                row = 0
                While Not datBrgy.Rows.Count - 1 < row
                    With grdPurok
                        .Rows(row).Cells(1).Value = datBrgy.Rows(row).Item("id").ToString
                        .Rows(row).Cells(2).Value = datBrgy.Rows(row).Item("purok").ToString
                    End With
                    row += 1
                End While

            Else
                grdPurok.Rows.Clear()
                MessageBox.Show("NO Record Found!", "Recrod Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
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
            With frmAddPurok
                .Label7.Text = "Add New Purok"
                .btnSave.Visible = True
                .btnUpdate.Visible = False
                .txtPurok.Text = ""

                .ShowInTaskbar = False
                .TopMost = False
                .Owner = Me
                .StartPosition = FormStartPosition.CenterParent
                .ShowDialog()
            End With
            procDisplayAllPurok()
            frmModal.Close()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub grdPurok_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdPurok.CellContentClick
        colName = grdPurok.Columns(e.ColumnIndex).Name

        '-- EDIT

        If colName = "Edit" Then

            Try
                frmModal.ShowInTaskbar = False
                frmModal.Location = frmMain.Location
                frmModal.Show()
                With frmAddPurok
                    .Label7.Text = "Edit Purok"
                    purokID = grdPurok.CurrentRow.Cells(1).Value.ToString()
                    .txtPurok.Text = grdPurok.CurrentRow.Cells(2).Value.ToString

                    .btnSave.Visible = False
                    .btnUpdate.Visible = True

                    .StartPosition = FormStartPosition.CenterParent
                    .ShowDialog()
                End With
                procDisplayAllPurok()
                frmModal.Close()
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try
        End If


        '-- DELETE 

        If colName = "Delete" Then
            Try
                With command
                    .Parameters.Clear()
                    .CommandText = "procDeletePurok"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_id", CInt(grdPurok.CurrentRow.Cells(1).Value))
                    .ExecuteNonQuery()
                    MessageBox.Show("Recorde Successfully Deleted!", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End With
                procDisplayAllPurok()
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try
        End If
    End Sub


End Class