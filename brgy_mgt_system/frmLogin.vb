Imports MySql.Data.MySqlClient
Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkDatabaseConnection()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        datBrgy = New DataTable
        sqlAdapterBrgy = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procSearchUser"
                .Parameters.AddWithValue("@p_user_name", Trim(txtUserName.Text))
                .Parameters.AddWithValue("@p_user_password", Trim(txtPassword.Text))
                .CommandType = CommandType.StoredProcedure
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
                If datBrgy.Rows.Count > 0 Then
                    userName = txtUserName.Text
                    userType = datBrgy.Rows(0).Item("position").ToString
                    Me.Close()

                    With frmMain
                        .btnLogInOut.Text = "Logout"
                        .btnLogInOut.Location = locLogInOut
                        .btnUser.Visible = True

                        .btnDashboard.Enabled = True
                        .btnBrgyOfficial.Enabled = True
                        .btnResident.Enabled = True
                        .btnBlotter.Enabled = True
                        .btnCertificate.Enabled = True
                        .btnAbout.Enabled = True
                        txtUserName.Clear()
                        txtPassword.Clear()
                        .btnDashboard.PerformClick()

                    End With


                Else
                    MessageBox.Show("User not found/Invalid Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtUserName.Clear()

                    txtPassword.Clear()


                End If

            End With
            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" + ex.Message)
        End Try

    End Sub

    Private Sub Guna2ControlBoxClose_Click(sender As Object, e As EventArgs) Handles Guna2ControlBoxClose.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class