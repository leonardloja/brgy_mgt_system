Imports MySql.Data.MySqlClient

'========================================'
' 
'========================================'

Public Class frmMain


    Public Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        chkDatabaseConnection()
        picSideBarLogo.Image = Image.FromFile(getLogo())
        procGetBrgyCaptain()

        BunifuPages.SetPage(7)
        btnDashboard.Enabled = False
        btnBrgyOfficial.Enabled = False
        btnResident.Enabled = False
        btnBlotter.Enabled = False
        btnCertificate.Enabled = False
        btnAbout.Enabled = False

        btnUser.Visible = False
        locLogInOut = btnLogInOut.Location
        btnLogInOut.Location = btnUser.Location
        btnLogInOut.Text = "Login"



    End Sub

    '========================================'
    ' DASHBOARD PAGE
    '========================================'
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        BunifuPages.SetPage(0)
        lblTotalResidents.Text = procGetTotalResident()
        lblActiveOfficials.Text = procGetActiveOfficial()
        lblTotalBlotter.Text = procGetTotalBlotter()
        procDisplayActiveBrgyOfficial()
    End Sub


    Private Sub procDisplayActiveBrgyOfficial()
        datBrgy = New DataTable
        sqlAdapterBrgy = New MySqlDataAdapter

        Try
            With command
                .Parameters.Clear()
                .CommandText = "procDisplayActiveBrgyOfficial"
                .CommandType = CommandType.StoredProcedure
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
            End With
            If datBrgy.Rows.Count > 0 Then
                grdActiveOfficial.RowCount = datBrgy.Rows.Count
                row = 0
                While Not datBrgy.Rows.Count - 1 < row
                    With grdActiveOfficial
                        .Rows(row).Cells(1).Value = Image.FromFile(datBrgy.Rows(row).Item("resident_pic").ToString)
                        .Rows(row).Cells(2).Value = datBrgy.Rows(row).Item("full_name").ToString
                        .Rows(row).Cells(3).Value = datBrgy.Rows(row).Item("gender").ToString
                        .Rows(row).Cells(4).Value = datBrgy.Rows(row).Item("position").ToString
                    End With
                    row += 1
                End While

            Else
                grdActiveOfficial.Rows.Clear()
                MessageBox.Show("NO Record Found!", "Recrod Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub


    Public Function procGetTotalResident() As Integer
        datBrgy = New DataTable
        sqlAdapterBrgy = New MySqlDataAdapter
        Try
            With command
                .Parameters.Clear()
                .CommandText = "SELECT COUNT(*) as `Total Resident` FROM tblresident;"
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
            End With
            If datBrgy.Rows.Count > 0 Then
                Return datBrgy.Rows(0).Item("Total Resident").ToString
            Else
                MessageBox.Show("NO Record Found", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
        Return 0
    End Function

    Public Function procGetActiveOfficial() As Integer
        datBrgy = New DataTable
        sqlAdapterBrgy = New MySqlDataAdapter
        Try
            With command
                .Parameters.Clear()
                .CommandText = "SELECT COUNT(*) as `Active Official` FROM tblbrgy_official WHERE status = 'Active';"
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
            End With
            If datBrgy.Rows.Count > 0 Then
                Return datBrgy.Rows(0).Item("Active Official").ToString
            Else
                MessageBox.Show("NO Record Found", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

        Return 0
    End Function

    Public Function procGetTotalBlotter() As Integer
        datBrgy = New DataTable
        sqlAdapterBrgy = New MySqlDataAdapter
        Try
            With command
                .Parameters.Clear()
                .CommandText = "SELECT COUNT(*) as `Total Blotter` FROM tblblotter;"
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
            End With
            If datBrgy.Rows.Count > 0 Then
                Return datBrgy.Rows(0).Item("Total Blotter").ToString
            Else
                MessageBox.Show("NO Record Found", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
        Return 0
    End Function




    '========================================'
    ' BLOTTER PAGE
    '========================================'
    Private Sub btnBlotter_Click(sender As Object, e As EventArgs) Handles btnBlotter.Click
        BunifuPages.SetPage(3)
        With frmBlotter
            .TopLevel = False
            pnlBlotter.Controls.Add(frmBlotter)
            .BringToFront()
            .Show()
        End With
    End Sub

    '========================================'
    ' RESIDENT PAGE
    '========================================'

    Private Sub btnResident_Click(sender As Object, e As EventArgs) Handles btnResident.Click
        BunifuPages.SetPage(2)
        With frmResident
            .TopLevel = False
            pnlResident.Controls.Add(frmResident)
            .BringToFront()
            .Show()
        End With
    End Sub

    '========================================'
    ' BRGY OFFICIAL PAGE
    '========================================'
    Private Sub btnBrgyOfficial_Click(sender As Object, e As EventArgs) Handles btnBrgyOfficial.Click
        BunifuPages.SetPage(1)
        With frmBrgyOfficial
            .TopLevel = False
            pnlBrgyOfficial.Controls.Add(frmBrgyOfficial)
            .BringToFront()
            .Show()
        End With
    End Sub

    '========================================'
    ' CERTIFICATE PAGE
    '========================================'
    Private Sub btnCertificate_Click(sender As Object, e As EventArgs) Handles btnCertificate.Click
        BunifuPages.SetPage(4)
        With frmCertificate
            .TopLevel = False
            pnlCertificate.Controls.Add(frmCertificate)
            .BringToFront()
            .Show()
        End With
    End Sub

    '========================================'
    ' ABOUT PAGE
    '========================================'
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        BunifuPages.SetPage(5)
        btnBrgyInformation.PerformClick()
    End Sub

    '========================================'
    ' USER PAGE
    '========================================'
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        BunifuPages.SetPage(6)
        With frmUser
            .TopLevel = False
            pnlUser.Controls.Add(frmUser)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub panelTop_Paint(sender As Object, e As PaintEventArgs) Handles panelTop.Paint

    End Sub

    Private Sub btnBrgyInformation_Click(sender As Object, e As EventArgs) Handles btnBrgyInformation.Click

        With frmBrgyInformation
            .TopLevel = False
            pnlAbout.Controls.Add(frmBrgyInformation)
            .BringToFront()
            .Show()
        End With
        BunifuPagesAbout.SetPage(0)
    End Sub

    Private Sub btnPurokList_Click(sender As Object, e As EventArgs) Handles btnPurokList.Click
        With frmPurokList
            .TopLevel = False
            pnlPurokList.Controls.Add(frmPurokList)
            .BringToFront()
            .Show()
        End With
        BunifuPagesAbout.SetPage(1)
    End Sub

    Private Sub btnMoreInfoResident_Click(sender As Object, e As EventArgs) Handles btnMoreInfoResident.Click
        btnResident.PerformClick()
    End Sub

    Private Sub btnMoreInfoOfficial_Click(sender As Object, e As EventArgs) Handles btnMoreInfoOfficial.Click
        btnBrgyOfficial.PerformClick()
    End Sub

    Private Sub btnMoreInfoBlotter_Click(sender As Object, e As EventArgs) Handles btnMoreInfoBlotter.Click
        btnBlotter.PerformClick()
    End Sub

    Private Sub btnResident_CheckedChanged(sender As Object, e As EventArgs) Handles btnResident.CheckedChanged
        With frmResident
            .cmbSearchType.StartIndex = 2
            .txtSearch.Text = ""
            .Close()
        End With
    End Sub

    Private Sub btnBrgyOfficial_CheckedChanged(sender As Object, e As EventArgs) Handles btnBrgyOfficial.CheckedChanged
        With frmBrgyOfficial
            .Close()
        End With
    End Sub

    Private Sub btnCertificate_CheckedChanged(sender As Object, e As EventArgs) Handles btnCertificate.CheckedChanged
        With frmCertificate
            '.Close()
            .btnIssueCert.PerformClick()
        End With
    End Sub

    Private Sub btnLogInOut_Click(sender As Object, e As EventArgs) Handles btnLogInOut.Click
        If btnLogInOut.Text = "Login" Then

            frmModal.ShowInTaskbar = False
            frmModal.StartPosition = FormStartPosition.Manual
            frmModal.Location = Me.Location
            frmModal.Size = Me.Size
            frmModal.TopMost = False
            frmModal.Owner = Me
            frmModal.Show()
            With frmLogin
                .txtUserName.PlaceholderText = "Username"
                .txtPassword.PlaceholderText = "Password"
                .ShowInTaskbar = False
                .TopMost = False
                .Owner = Me
                .StartPosition = FormStartPosition.CenterParent
                .ShowDialog()
            End With
            btnUser.Text = StrConv(userName, VbStrConv.ProperCase)
            'frmLogin.Close()
            frmModal.Dispose()

        ElseIf btnLogInOut.Text = "Logout" Then
            btnDashboard.Enabled = False
            btnDashboard.Checked = False
            btnBrgyOfficial.Enabled = False
            btnBrgyOfficial.Checked = False
            btnResident.Enabled = False
            btnResident.Checked = False
            btnBlotter.Enabled = False
            btnResident.Checked = False
            btnCertificate.Enabled = False
            btnCertificate.Checked = False
            btnAbout.Enabled = False
            btnAbout.Checked = False

            frmResident.Close()
            frmBlotter.Close()
            frmCertificate.Close()
            frmBrgyInformation.Close()
            frmPurokList.Close()
            frmEmployee.Close()

            btnUser.Visible = False
            locLogInOut = btnLogInOut.Location
            btnLogInOut.Location = btnUser.Location
            btnLogInOut.Text = "Login"
            BunifuPages.SetPage(7)
        End If
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        With frmEmployee
            .TopLevel = False
            pnlEmployee.Controls.Add(frmEmployee)
            .BringToFront()
            .Show()
        End With
        BunifuPagesAbout.SetPage(2)
    End Sub

    Private Sub btnUser_CheckedChanged(sender As Object, e As EventArgs) Handles btnUser.CheckedChanged
        frmUser.Close()
    End Sub

    Private Sub btnBrgyInformation_CheckedChanged(sender As Object, e As EventArgs) Handles btnBrgyInformation.CheckedChanged
        With frmBrgyInformation
            If .btnCancel.Visible = True Then
                .btnCancel.PerformClick()
            End If
        End With
    End Sub

    Private Sub btnAbout_CheckedChanged(sender As Object, e As EventArgs) Handles btnAbout.CheckedChanged
        With frmBrgyInformation
            If .btnCancel.Visible = True Then
                .btnCancel.PerformClick()
            End If
        End With
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class
