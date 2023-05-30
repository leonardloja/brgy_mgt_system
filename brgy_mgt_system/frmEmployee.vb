Imports MySql.Data.MySqlClient
Public Class frmEmployee
    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If userType = "Administrator" Or userType = "Captain" Or userType = "Secretary" Then
            grdEmployee.Columns("Edit").Visible = True
            grdEmployee.Columns("Delete").Visible = True
            btnAdd.Enabled = True
        Else
            grdEmployee.Columns("Edit").Visible = False
            grdEmployee.Columns("Delete").Visible = False
            btnAdd.Enabled = False
        End If

        procDisplayAllEmployee()
    End Sub

    Private Sub procDisplayAllEmployee()
        datBrgy = New DataTable
        sqlAdapterBrgy = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayAllEmployee"
                .CommandType = CommandType.StoredProcedure
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
                'lblTotal.Text = "Total Records : " & datHotel.Rows.Count
            End With
            If datBrgy.Rows.Count > 0 Then
                grdEmployee.RowCount = datBrgy.Rows.Count
                row = 0
                While Not datBrgy.Rows.Count - 1 < row
                    With grdEmployee
                        .Rows(row).Cells(2).Value = datBrgy.Rows(row).Item("id").ToString
                        .Rows(row).Cells(3).Value = datBrgy.Rows(row).Item("full_name").ToString
                        .Rows(row).Cells(4).Value = datBrgy.Rows(row).Item("age").ToString
                        .Rows(row).Cells(5).Value = datBrgy.Rows(row).Item("gender").ToString
                        .Rows(row).Cells(6).Value = datBrgy.Rows(row).Item("address").ToString
                        .Rows(row).Cells(7).Value = datBrgy.Rows(row).Item("contact_no").ToString
                        .Rows(row).Cells(8).Value = datBrgy.Rows(row).Item("position").ToString

                    End With
                    row += 1
                End While

            Else
                grdEmployee.Rows.Clear()
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
            With frmAddEmployee
                .txtFullName.Clear()
                .txtContactNo.Clear()
                .txtAge.Clear()
                .txtAddress.Clear()
                .cmbPosition.StartIndex = -1
                .cmbGender.StartIndex = -1
                .txtUserName.Clear()
                .txtPassword.Clear()
                .txtConfirmPassword.Clear()

                .btnSave.Visible = True
                .btnUpdate.Visible = False
                .Label1.Text = "Add New Employee"
                .Size = New Size(1094, 554)
                .btnCancel.Location = New Point(989, 13)

                .ShowInTaskbar = False
                .TopMost = False
                .Owner = Me
                .StartPosition = FormStartPosition.CenterParent
                .ShowDialog()
            End With
            frmAddResident.Close()
            frmModal.Dispose()
            procDisplayAllEmployee()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub grdEmployee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdEmployee.CellContentClick
        colName = grdEmployee.Columns(e.ColumnIndex).Name

        '-- EDIT

        If colName = "Edit" Then
            Try
                frmModal.ShowInTaskbar = False
                frmModal.Location = frmMain.Location
                frmModal.Show()
                With frmAddEmployee
                    empID = CInt(grdEmployee.CurrentRow.Cells(2).Value.ToString)
                    .txtFullName.Text = grdEmployee.CurrentRow.Cells(3).Value.ToString
                    .txtAge.Text = grdEmployee.CurrentRow.Cells(4).Value.ToString
                    .cmbGender.Text = grdEmployee.CurrentRow.Cells(5).Value.ToString
                    .txtAddress.Text = grdEmployee.CurrentRow.Cells(6).Value.ToString
                    .txtContactNo.Text = grdEmployee.CurrentRow.Cells(7).Value.ToString
                    .cmbPosition.Text = grdEmployee.CurrentRow.Cells(8).Value.ToString
                    .StartPosition = FormStartPosition.CenterParent
                    .Label1.Text = "Update Employee"
                    .btnSave.Visible = False
                    .btnUpdate.Visible = True
                    .Size = New Size(619, 554)
                    .btnCancel.Location = New Point(515, 13)
                    .ShowDialog()
                End With
                procDisplayAllEmployee()
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
                    .CommandText = "procDeleteEmployee"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_id", CInt(grdEmployee.CurrentRow.Cells(2).Value))
                    .ExecuteNonQuery()
                    MessageBox.Show("Record Successfully Deleted!", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End With
                procDisplayAllEmployee()
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try
        End If

    End Sub
End Class