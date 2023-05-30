Public Class frmAddBlotterRecord

    Private Sub frmAddBlotterRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()



    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtIncidentType.Text = "" Then
            EPIncidentType.SetIconPadding(txtIncidentType, 3)
            EPIncidentType.SetError(txtIncidentType, "Incident Type is Required!")
            Exit Sub
        Else
            EPIncidentType.Clear()
        End If


        If txtLocation.Text = "" Then
            EPLocation.SetIconPadding(txtLocation, 3)
            EPLocation.SetError(txtLocation, "Location is Required!")
            Exit Sub
        Else
            EPLocation.Clear()
        End If


        If txtReportingPerson.Text = "" Then
            EPReportingPerson.SetIconPadding(txtReportingPerson, 3)
            EPReportingPerson.SetError(txtReportingPerson, "Reporting Person is Required!")
            Exit Sub
        Else
            EPReportingPerson.Clear()
        End If


        If txtContactNo.Text = "" Then
            EPContactNo.SetIconPadding(txtContactNo, 3)
            EPContactNo.SetError(txtContactNo, "Reporting Person is Required!")
            Exit Sub
        Else
            EPContactNo.Clear()
        End If

        If txtIncidentDetails.Text = "" Then
            EPIncidentDetails.SetIconPadding(txtIncidentDetails, 3)
            EPIncidentDetails.SetError(txtIncidentDetails, "Reporting Person is Required!")
            Exit Sub
        Else
            EPIncidentDetails.Clear()
        End If


        '------------------



        Try
            With command
                .Parameters.Clear()
                .CommandText = "procInsertBlotter"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_incident_type", txtIncidentType.Text)
                .Parameters.AddWithValue("@p_location", txtLocation.Text)
                .Parameters.AddWithValue("@p_date_time_reported", Format(dtReported.Value, "yyyy-MM-dd HH:mm"))
                .Parameters.AddWithValue("@p_date_time_incident", Format(dtIncident.Value, "yyyy-MM-dd HH:mm"))
                .Parameters.AddWithValue("@p_incident_details", txtIncidentDetails.Text)
                .Parameters.AddWithValue("@p_reporting_person", txtReportingPerson.Text)
                .Parameters.AddWithValue("@p_contact_no", txtContactNo.Text)
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
                .CommandText = "procUpdateBlotterRecord"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", blotterID)
                .Parameters.AddWithValue("@p_incident_type", txtIncidentType.Text)
                .Parameters.AddWithValue("@p_location", txtLocation.Text)
                .Parameters.AddWithValue("@p_date_time_reported", Format(dtReported.Value, "yyyy-MM-dd HH:mm"))
                .Parameters.AddWithValue("@p_date_time_incident", Format(dtIncident.Value, "yyyy-MM-dd HH:mm"))
                .Parameters.AddWithValue("@p_incident_details", txtIncidentDetails.Text)
                .Parameters.AddWithValue("@p_reporting_person", txtReportingPerson.Text)
                .Parameters.AddWithValue("@p_contact_no", txtContactNo.Text)
                .ExecuteNonQuery()
            End With

            MessageBox.Show("Record Successfully Updated", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub
End Class