Imports MySql.Data.MySqlClient
Module modGlobalProcedure

    Public Function fncConnectToDatabse() As Boolean

        Try
            serverName = "localhost"
            dbName = "barangay_mgt_system"
            dbUserName = "root"
            dbPassword = "filio"
            port = "3306"

            If conBrgyMgtSys.State = ConnectionState.Closed Then
                conBrgyMgtSys = New MySqlConnection
                strConnectionString = "SERVER=" & serverName & ";" _
                                      & "DATABASE=" & dbName & ";" _
                                      & "USERNAME=" & dbUserName & ";" _
                                      & "PASSWORD=" & dbPassword & ";" _
                                      & "PORT=" & port

                conBrgyMgtSys.ConnectionString = strConnectionString
                conBrgyMgtSys.Open()
                command.Connection = conBrgyMgtSys
                Return True
            Else
                conBrgyMgtSys.Close()
                Return False

            End If

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
        Return False
    End Function

    Public Sub chkDatabaseConnection()
        If fncConnectToDatabse() = True Then
        Else
            conBrgyMgtSys.Open()
        End If

    End Sub



    Public Function getLogo() As String
        Try
            With command
                .Parameters.Clear()
                .CommandText = "procGetLogo"
                .CommandType = CommandType.StoredProcedure
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
            End With
            If datBrgy.Rows.Count > 0 Then
                logoPhotoPath = datBrgy.Rows(0).Item("logo").ToString
            Else
                MessageBox.Show("NO Record Found", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

        Return logoPhotoPath

    End Function


    Public Sub procGetBrgyCaptain() ' Save data from datagridview to tblprint
        datBrgy = New DataTable
        sqlAdapterBrgy = New MySqlDataAdapter
        Try
            With command
                .Parameters.Clear()
                .CommandText = "SELECT UPPER(CONCAT(b.first_name, ' ', LEFT(b.middle_name, 1), '. ', b.last_name)) as `brgy_captain`
                                FROM tblbrgy_official a, tblresident b
                                WHERE a.resident_id = b.id
                                      AND position = 'Brgy. Captain'; "
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
                sqlAdapterBrgy.SelectCommand = command
                datBrgy.Clear()
                sqlAdapterBrgy.Fill(datBrgy)
            End With
            If datBrgy.Rows.Count > 0 Then
                brgyCaptain = datBrgy.Rows(0).Item("brgy_captain").ToString
            Else
                MessageBox.Show("NO Record Found", "Record Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            datBrgy.Dispose()
            sqlAdapterBrgy.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub


    Public Function GetOrdinal(num As Integer) As String

        Select Case (num Mod 100)
            Case 11, 12, 13
                Return num & "th"
        End Select

        Select Case (num Mod 10)
            Case 1
                Return num & "st"
            Case 2
                Return num & "nd"
            Case 3
                Return num & "rd"
            Case Else
                Return num & "th"
        End Select

    End Function




End Module
