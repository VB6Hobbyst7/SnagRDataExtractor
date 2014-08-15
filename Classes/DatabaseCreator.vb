Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic
Imports System


Public Class DatabaseCreator

    Private DBServer As String = ""
    Private DBName As String = ""
    Private DBCreateDataFile As String = ""
    Private SQL_CONNECTION_STRING As String = _
        "Server=" & DBServer & ";" & _
        "DataBase=;" & _
        "Integrated Security=True;" 'was SSPI
    Protected bolDidPreviouslyConnect As Boolean = False
    Protected connectionString As String = SQL_CONNECTION_STRING
    Private fileUrl As String = ""
    Private timeout As Integer = 1600


    Private Function CreateInstanceDb(ByVal strUname As String, ByVal strPassword As String) As Boolean

        Dim strSQL As String = "IF EXISTS (SELECT [name] FROM Master..sysdatabases WHERE [name] = N'" & DBName & "')" & vbCrLf & _
                                "BEGIN" & vbCrLf & _
                                "DROP DATABASE " & DBName & "" & vbCrLf & _
                                "END" & vbCrLf & _
                                "CREATE DATABASE " & DBName & " collate Latin1_General_CI_AS " 'UK English 'US English (SQL_Latin1_General_CP1_CI) or Latin1_General_CI_AS UK english


        Dim bolIsConnecting As Boolean = True
        While bolIsConnecting
            Try
                ' The SqlConnection class allows you to communicate with SQL Server.
                ' The constructor accepts a connection string as an argument.  This
                ' connection string uses Integrated Security, which means that you 
                ' must have a login in SQL Server, or be part of the Administrators
                ' group for this to work.
                Dim northwindConnection As New SqlConnection(SQL_CONNECTION_STRING)

                ' A SqlCommand object is used to execute the SQL commands.
                Dim cmd As New SqlCommand(strSQL, northwindConnection)

                ' Open the connection, execute the command, and close the 
                ' connection. It is more efficient to ExecuteNonQuery when data is 
                ' not being returned.
                northwindConnection.Open()
                cmd.ExecuteNonQuery()
                northwindConnection.Close()

                ' Data has been successfully submitted, so break out of the loop
                ' and close the status form.
                bolIsConnecting = False
                bolDidPreviouslyConnect = True
                'bolDidCreateTable = True
                Return True
            Catch sqlExc As SqlException
                Return False
                Exit While
            Catch exc As Exception
                If connectionString = SQL_CONNECTION_STRING Then
                Else
                    Return False
                End If
            End Try
        End While
        Return True
    End Function

    Public Function CreateSQLDb(ByVal strServerName As String, ByVal strDBName As String, Optional ByVal strUserName As String = "", Optional ByVal strPass As String = "") As Boolean
        DBName = strDBName
        DBServer = strServerName
        If strUserName.Trim.Length > 0 Then
            SQL_CONNECTION_STRING = "User ID=" & strUserName & ";Pwd=" & strPass & ";Data Source=" & strServerName & ";database=;Persist Security Info=False;"
        Else
            SQL_CONNECTION_STRING = _
            "Server=" & DBServer & ";" & _
            "DataBase=" & ";" & _
            "Integrated Security=True;"
        End If
        connectionString = SQL_CONNECTION_STRING
        If CreateInstanceDb(strUserName, strPass) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Property ConnString() As String
        Get
            Return connectionString
        End Get
        Set(ByVal value As String)
            connectionString = value
            SQL_CONNECTION_STRING = value
        End Set
    End Property


    Public Function ExecuteSQLScript(ByVal SQlFilePath As String, ByVal ConStr As String, Optional ByVal CompanyDBname As String = "") As Boolean
        Dim conn As SqlConnection = Nothing
        'company db name to inject into script tp create views to Company tables
        'Dim CompanyDBname As String = Replace(Right(ConStr.ToLower, InStr(ConStr.ToLower, ";database=") + 10), ";", "")
        Try
            ' read file 
            fileUrl = SQlFilePath
            Dim request As Net.WebRequest = Net.WebRequest.Create(fileUrl)
            Using sr As New StreamReader(request.GetResponse().GetResponseStream())


                ' Create new connection to database 
                conn = New SqlConnection(ConStr)

                conn.Open()

                While Not sr.EndOfStream
                    Dim sb As New Text.StringBuilder()
                    Dim cmd As SqlCommand = conn.CreateCommand()

                    While Not sr.EndOfStream
                        Dim s As String = sr.ReadLine()
                        'company db name to inject into script tp create views to Company tables
                        If Len(CompanyDBname) > 0 Then
                            If InStr(s, "company.dbo.") > 0 Then
                                s = Replace(s, "company.dbo.", CompanyDBname & ".dbo.")
                            Else
                                If InStr(s, "Company.dbo.") > 0 Then
                                    s = Replace(s, "Company.dbo.", CompanyDBname & ".dbo.")
                                End If
                            End If
                        End If

                        If s IsNot Nothing AndAlso s.ToUpper().Trim().Equals("GO") Then
                            Exit While
                        End If

                        sb.AppendLine(s)
                    End While

                    ' Execute T-SQL against the target database 
                    cmd.CommandText = sb.ToString()
                    cmd.CommandTimeout = timeout

                    If Len(cmd.CommandText) > 0 Then
                        Try
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception

                        End Try
                    End If

                End While
            End Using
            '' Done
            Return True
        Catch ex As Exception
            ' Error    
            SnagRError.LogError(ex)
            Return False
        Finally
        End Try
    End Function

    Public Function ExecuteSQLScriptViews(ByVal SQlFilePath As String, ByVal ConStr As String, ByVal newCompanyDBname As String) As Boolean
        Dim conn As SqlConnection = Nothing
        'company db name to inject into script tp create views to Company tables
        'Dim CompanyDBname As String = Replace(Right(ConStr.ToLower, InStr(ConStr.ToLower, ";database=") + 10), ";", "")
        Try
            ' read file 
            fileUrl = SQlFilePath
            Dim request As Net.WebRequest = Net.WebRequest.Create(fileUrl)
            Using sr As New StreamReader(request.GetResponse().GetResponseStream())


                ' Create new connection to database 
                conn = New SqlConnection(ConStr)

                conn.Open()

                While Not sr.EndOfStream
                    Dim sb As New Text.StringBuilder()
                    Dim cmd As SqlCommand = conn.CreateCommand()

                    While Not sr.EndOfStream
                        Dim s As String = sr.ReadLine()
                        'company db name to inject into script tp create views to Company tables

                        'you are running a script with "company.dbo." in it and DROP then CREATE on the views so Old Company name does not matter!!!
                        'If InStr(s, oldCompanyDBname.ToLower & ".dbo.") > 0 Then
                        '    s = Replace(s, oldCompanyDBname.ToLower & ".dbo.", newCompanyDBname.ToLower & ".dbo.")
                        'End If

                        If InStr(s, "company.dbo.") > 0 Then
                            s = Replace(s, "company.dbo.", newCompanyDBname & ".dbo.")
                        Else
                            If InStr(s, "Company.dbo.") > 0 Then
                                s = Replace(s, "Company.dbo.", newCompanyDBname & ".dbo.")
                            End If
                        End If


                        If s IsNot Nothing AndAlso s.ToUpper().Trim().Equals("GO") Then
                            Exit While
                        End If

                        sb.AppendLine(s)
                    End While

                    ' Execute T-SQL against the target database 
                    cmd.CommandText = sb.ToString()
                    cmd.CommandTimeout = timeout

                    If Len(cmd.CommandText) > 0 Then
                        Try
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception

                        End Try
                    End If

                End While
            End Using
            '' Done
            Return True
        Catch ex As Exception
            ' Error      
            SnagRError.LogError(ex)
            Return False
        Finally
        End Try
    End Function
End Class
