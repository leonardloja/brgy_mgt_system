Public Class frmAddPurok
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtPurok.Text = "" Then
            EPPurok.SetIconPadding(txtPurok, 3)
            EPPurok.SetError(txtPurok, "Purok Name is Required!")
            Exit Sub
        Else
            EPPurok.Clear()
        End If


        Try
            With command
                .Parameters.Clear()
                .CommandText = "procInsertPurok"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_purok", txtPurok.Text)
                .ExecuteNonQuery()
            End With

            MessageBox.Show("Record Successfully Save", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procUpdatePurok"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", purokID)
                .Parameters.AddWithValue("@p_purok", txtPurok.Text)
                .ExecuteNonQuery()
            End With

            MessageBox.Show("Record Successfully Updated", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
End Class