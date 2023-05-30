Imports MySql.Data.MySqlClient
Public Class frmEditBrgyOfficial
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        tempResidentID = -1
        tempOfficialID = -1
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            With frmResidentBrowse
                .ShowInTaskbar = False
                .StartPosition = FormStartPosition.CenterParent
                .txtSearch.Clear()
                .ShowDialog()


            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub frmEditBrgyOfficial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procUpdateBrgyOfficial"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", tempOfficialID)
                .Parameters.AddWithValue("@p_resident_id", tempResidentID)
                .Parameters.AddWithValue("@p_status", cmbStatus.Text)
                .Parameters.AddWithValue("@p_term", txtTerm.Text)
                sqlAdapterBrgy.SelectCommand = command
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Record Successfully Updated", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
        procGetBrgyCaptain()
        Me.Close()

    End Sub
End Class