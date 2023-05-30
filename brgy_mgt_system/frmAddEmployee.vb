Public Class frmAddEmployee
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If txtFullName.Text = "" Then
                EPFullName.SetIconPadding(txtFullName, 3)
                EPFullName.SetError(txtFullName, "Full Name is Required!")
                Exit Sub
            Else
                EPFullName.Clear()
            End If

            If txtContactNo.Text = "" Then
                EPContactNo.SetIconPadding(txtContactNo, 3)
                EPContactNo.SetError(txtContactNo, "Contact No. is Required")
                Exit Sub
            Else
                EPContactNo.Clear()
            End If

            If txtAge.Text = "" Then
                EPAge.SetIconPadding(txtAge, 3)
                EPAge.SetError(txtAge, "Age is Required")
                Exit Sub
            Else
                EPAge.Clear()
            End If


            If cmbGender.Text = "" Then
                EPGender.SetIconPadding(cmbGender, 3)
                EPGender.SetError(cmbGender, "Gender is Required")
                Exit Sub
            Else
                EPGender.Clear()
            End If


            If cmbPosition.Text = "" Then
                EPPosition.SetIconPadding(cmbPosition, 3)
                EPPosition.SetError(cmbPosition, "Position is Required")
                Exit Sub
            Else
                EPPosition.Clear()
            End If

            If txtAddress.Text = "" Then
                EPAddress.SetIconPadding(txtAddress, 3)
                EPAddress.SetError(txtAddress, "Address is Required")
                Exit Sub
            Else
                EPAddress.Clear()
            End If

            If txtUserName.Text = "" Then
                EPUserName.SetIconPadding(txtUserName, 3)
                EPUserName.SetError(txtUserName, "User Name is Required")
                Exit Sub
            Else
                EPUserName.Clear()
            End If


            If txtPassword.Text = "" Then
                EPPassword.SetIconPadding(txtPassword, 3)
                EPPassword.SetError(txtPassword, "Password is Required")
                Exit Sub
            Else
                EPPassword.Clear()
            End If

            If txtPassword.Text <> txtConfirmPassword.Text Then
                EPConfirmPass.SetIconPadding(txtConfirmPassword, 3)
                EPConfirmPass.SetError(txtConfirmPassword, "Passwords do not match!")
                Exit Sub
            Else
                EPConfirmPass.Clear()
            End If


            ' -------

            If checkUserNameAvailability() = False Then
                MessageBox.Show("Username Already Registered", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            procInsertEmployee()


            procGetNewEmployeeID()

            procInsertUser()

            MessageBox.Show("Record Successfully Save", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub


    Public Function checkUserNameAvailability() As Boolean
        Try

            With command
                .Parameters.Clear()
                .CommandText = "procCheckEmployeeUserName"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_user_name", txtUserName.Text)
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
            End With
            If datBrgy.Rows.Count > 0 Then
                Return False
            End If

            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

        Return True
    End Function

    Private Sub procGetNewEmployeeID()
        Try

            With command
                .Parameters.Clear()
                .CommandText = "procGetEmployeeID"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_full_name", txtFullName.Text)
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
            End With
            If datBrgy.Rows.Count > 0 Then
                empID = CInt(datBrgy.Rows(0).Item("id").ToString)
            End If

            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

    Private Sub procInsertEmployee()
        Try

            With command
                .Parameters.Clear()
                .CommandText = "procInsertEmployee"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_full_name", txtFullName.Text)
                .Parameters.AddWithValue("@p_contact_no", txtContactNo.Text)
                .Parameters.AddWithValue("@p_age", CInt(txtAge.Text))
                .Parameters.AddWithValue("@p_gender", cmbGender.Text)
                .Parameters.AddWithValue("@p_position", cmbPosition.Text)
                .Parameters.AddWithValue("@p_address", txtAddress.Text)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub


    Private Sub procInsertUser()
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procInsertUser"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_emp_id", empID)
                .Parameters.AddWithValue("@p_user_name", txtUserName.Text)
                .Parameters.AddWithValue("@p_user_password", txtPassword.Text)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procUpdateEmployee"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", empID)
                .Parameters.AddWithValue("@p_full_name", txtFullName.Text)
                .Parameters.AddWithValue("@p_contact_no", txtContactNo.Text)
                .Parameters.AddWithValue("@p_age", CInt(txtAge.Text))
                .Parameters.AddWithValue("@p_gender", cmbGender.Text)
                .Parameters.AddWithValue("@p_position", cmbPosition.Text)
                .Parameters.AddWithValue("@p_address", txtAddress.Text)
                .ExecuteNonQuery()
            End With

            MessageBox.Show("Record Successfully Updated", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub
End Class