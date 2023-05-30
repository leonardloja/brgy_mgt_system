Imports MySql.Data.MySqlClient
Public Class frmUser
    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserName.Text = userName
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        txtCurrentPass.Enabled = True
        txtNewPass.Enabled = True
        txtConfirmNewPass.Enabled = True

        btnEdit.Visible = False
        btnCancel.Visible = True
        btnUpdate.Visible = True

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        EPNewPass.Clear()

        txtCurrentPass.Enabled = False
        txtNewPass.Enabled = False
        txtConfirmNewPass.Enabled = False

        btnEdit.Visible = True
        btnCancel.Visible = False
        btnUpdate.Visible = False
        lblPassErr.Visible = False

        txtCurrentPass.Text = ""
        txtNewPass.Text = ""
        txtConfirmNewPass.Text = ""
    End Sub

    Private Sub txtConfirmNewPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmNewPass.TextChanged
        If txtNewPass.Text <> txtConfirmNewPass.Text Then
            txtConfirmNewPass.FocusedState.BorderColor = Color.Red
            lblPassErr.Visible = True
            btnUpdate.Enabled = False

        Else
            lblPassErr.Visible = False
            txtConfirmNewPass.FocusedState.BorderColor = Color.Green
            btnUpdate.Enabled = True
            txtConfirmNewPass.BorderColor = Color.Green


        End If
    End Sub

    Private Sub txtConfirmNewPass_Leave(sender As Object, e As EventArgs) Handles txtConfirmNewPass.Leave
        If txtNewPass.Text <> txtConfirmNewPass.Text Then
            txtConfirmNewPass.BorderColor = Color.Red
            lblPassErr.Visible = True
        Else
            txtConfirmNewPass.BorderColor = Color.Green
            lblPassErr.Visible = False
        End If
    End Sub

    Private Sub txtNewPass_TextChanged(sender As Object, e As EventArgs) Handles txtNewPass.TextChanged
        If txtNewPass.Text <> txtConfirmNewPass.Text Then
            txtConfirmNewPass.FocusedState.BorderColor = Color.Red
            lblPassErr.Visible = True
            txtConfirmNewPass.BorderColor = Color.Red
            btnUpdate.Enabled = False
        ElseIf txtNewPass.Text = txtConfirmNewPass.Text Then
            lblPassErr.Visible = False
            txtConfirmNewPass.FocusedState.BorderColor = Color.Green
            txtConfirmNewPass.BorderColor = Color.Green
            btnUpdate.Enabled = True
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click


        If txtNewPass.Text = "" Then
            EPNewPass.SetIconPadding(txtNewPass, 3)
            EPNewPass.SetError(txtNewPass, "New Password is Required")
            Exit Sub
        Else
            EPNewPass.Clear()
        End If

        procUpdateUserPassword()

    End Sub

    Private Sub procUpdateUserPassword()
        sqlAdapterBrgy = New MySqlDataAdapter
        datBrgy = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "procSelectUserLogin"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@P_user_name", txtUserName.Text)
                .Parameters.AddWithValue("@p_user_password", txtCurrentPass.Text)
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
                If datBrgy.Rows.Count > 0 Then
                    updatePassword(txtUserName.Text, txtNewPass.Text)
                    MessageBox.Show("Password Successfully Updated", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnCancel.PerformClick()
                Else
                    MessageBox.Show("Username and Current password doesn't Match!", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With

            sqlAdapterBrgy.Dispose()
            datBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub


    Private Sub updatePassword(ByVal userName As String, ByVal newPassword As String)
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procUpdateUserPassword"
                .Parameters.AddWithValue("@p_user_name", userName)
                .Parameters.AddWithValue("@p_user_password", newPassword)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show("" + ex.Message)
        End Try
    End Sub

End Class