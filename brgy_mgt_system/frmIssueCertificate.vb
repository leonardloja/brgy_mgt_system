Public Class frmIssueCertificate
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtPurpose.Text = "" Then
            EPPurpose.SetIconPadding(txtPurpose, 3)
            EPPurpose.SetError(txtPurpose, "Purpose is Required!")
            Exit Sub
        Else
            EPPurpose.Clear()
        End If

        If lblHeader.Text = "Barangay Clearance" And txtOR.Text = "" Then
            EPOR.SetIconPadding(txtOR, 3)
            EPOR.SetError(txtOR, "OR No. is Required!")
            Exit Sub
        Else
            EPOR.Clear()
        End If

        '-------------

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procInsertCertificateRecord"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_resident_id", tempResidentID)
                .Parameters.AddWithValue("@p_transaction_type", tempTransactionType)
                .Parameters.AddWithValue("@p_or_number", txtOR.Text)
                .Parameters.AddWithValue("@p_purpose", txtPurpose.Text)
                .ExecuteNonQuery()
            End With

            MessageBox.Show("Record Successfully Save", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information)



            Me.Close()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub frmIssueCertificate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPurpose.Text = ""
        txtOR.Text = ""
    End Sub
End Class