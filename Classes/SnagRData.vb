Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.SQLite


Public Class SnagRData
    'Implements IDataReader

#Region "Gets"
    ''' <summary>
    ''' Returns a single item database independent if SELECT statement is successfull
    ''' </summary>
    ''' <param name="sSQL">SQL Querystring</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function getSingleItem(ByVal sSQL As String, ByVal connectionString As String, Optional ByVal sqlExpr As String = "") As Object

        Dim ds As New DataSet

        If sqlExpr <> "" Then
            sSQL = sqlExpr
        End If
        ds = getSqlData(sSQL, connectionString)

        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                If Not IsDBNull(ds.Tables(0).Rows(0).Item(0)) Then
                    Return ds.Tables(0).Rows(0).Item(0)
                Else : Return Nothing
                End If
            Else : Return Nothing
            End If
        Else : Return Nothing
        End If

    End Function

    Public Shared Function getSingleItem(ByVal sSQL As String, ByVal conn As SqlConnection, Optional ByVal sqlExpr As String = "") As Object

        Dim ds As New DataSet

        If sqlExpr <> "" Then
            sSQL = sqlExpr
        End If
        ds = getSqlData(sSQL, conn)

        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                If Not IsDBNull(ds.Tables(0).Rows(0).Item(0)) Then
                    Return ds.Tables(0).Rows(0).Item(0)
                Else : Return Nothing
                End If
            Else : Return Nothing
            End If
        Else : Return Nothing
        End If

    End Function

    'Public Shared Function getSingleItem(ByVal sSQL As String, ByVal conn As SQLiteConnection, Optional ByVal sqlExpr As String = "") As Object

    '    Dim ds As New DataSet

    '    If sqlExpr <> "" Then
    '        sSQL = sqlExpr
    '    End If
    '    ds = getSqliteData(sSQL, conn)

    '    If ds.Tables.Count > 0 Then
    '        If ds.Tables(0).Rows.Count > 0 Then
    '            If Not IsDBNull(ds.Tables(0).Rows(0).Item(0)) Then
    '                Return ds.Tables(0).Rows(0).Item(0)
    '            Else : Return Nothing
    '            End If
    '        Else : Return Nothing
    '        End If
    '    Else : Return Nothing
    '    End If

    'End Function

    Public Shared Function getSingleItemReturnError(ByVal sSQL As String, ByVal connectionString As String, ByRef sError As Exception) As String
        Dim ds As New DataSet


        If InStr(connectionString.ToLower, "jet.oledb") = 0 Then
            ds = getSqlData(sSQL, connectionString, sError)
        Else
            ds = getOLEDBData(sSQL, connectionString, sError)
        End If

        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                If Not IsDBNull(ds.Tables(0).Rows(0).Item(0)) Then
                    Return ds.Tables(0).Rows(0).Item(0)
                Else : Return Nothing
                End If
            Else : Return Nothing
            End If
        Else : Return Nothing
        End If
    End Function

    Public Shared Function getNoOfRecords(ByVal sSQL As String, ByVal connectionString As String) As Integer

        'Dim connStr As String = ConfigurationManager.ConnectionStrings("SnagRConnectionString").ConnectionString
        'marshaller to create a single getData() function to return a dataset depending on database
        Dim ds As New DataSet

        If InStr(connectionString.ToLower, "jet.oledb") = 0 Then
            ds = getSqlData(sSQL, connectionString)
        Else
            ds = getOLEDBData(sSQL, connectionString)
        End If

        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                If Not IsDBNull(ds.Tables(0).Rows(0).Item(0)) Then
                    Return ds.Tables(0).Rows.Count
                Else : Return 0
                End If
            Else : Return 0
            End If
        Else : Return 0
        End If

    End Function

    Public Shared Function getNoOfRecords(ByVal sSQL As String, ByVal sSQLexp As String, ByVal connectionString As String) As Integer

        'Dim connStr As String = ConfigurationManager.ConnectionStrings("SnagRConnectionString").ConnectionString
        'marshaller to create a single getData() function to return a dataset depending on database
        Dim ds As New DataSet

        If InStr(connectionString.ToLower, "jet.oledb") = 0 Then
            If Len(sSQLexp) > 0 Then sSQL = sSQLexp
            ds = getSqlData(sSQL, connectionString)
        Else
            ds = getOLEDBData(sSQL, connectionString)
        End If

        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                If Not IsDBNull(ds.Tables(0).Rows(0).Item(0)) Then
                    Return ds.Tables(0).Rows.Count
                Else : Return 0
                End If
            Else : Return 0
            End If
        Else : Return 0
        End If

    End Function

    Public Shared Function getMax(ByVal table As String, ByVal column As String, ByVal connectionString As String) As Integer
        Return getSingleItem("Select Max(" & column & ") from " & table, connectionString)
    End Function




#Region "getDataSet"

    Public Shared Function getDataSet(ByVal sSQL As String, ByVal connectionString As String, Optional ByVal sSQLexp As String = "") As DataSet

        'Dim connStr As String = ConfigurationManager.ConnectionStrings("SnagRConnectionString").ConnectionString
        'marshaller to create a single getData() function to return a dataset depending on database

        If InStr(connectionString.ToLower, "jet.oledb") = 0 Then
            If Len(sSQLexp) > 0 Then sSQL = sSQLexp
            Return getSqlData(sSQL, connectionString)
        Else
            Return getOLEDBData(sSQL, connectionString)
        End If

    End Function


    Public Shared Function getDataSetTable(ByVal sSQL As String, ByVal connectionString As String, ByVal sTable As String, Optional ByVal sSQLexp As String = "") As DataSet

        ' Dim connStr As String = ConfigurationManager.ConnectionStrings("SnagRConnectionString").ConnectionString
        'marshaller to create a single getData() function to return a dataset depending on database

        If InStr(connectionString.ToLower, "jet.oledb") = 0 Then
            If Len(sSQLexp) > 0 Then sSQL = sSQLexp
            Return getSqlData(sSQL, connectionString, sTable)
        Else
            Return getOLEDBData(sSQL, connectionString, sTable)
        End If

    End Function

    Public Shared Function getDataSet(ByVal sSQL As String, ByVal connectionString As String, ByVal bCloseConn As Boolean, ByVal OleDBconn As OleDbConnection, ByVal SQLconn As SqlConnection, Optional ByVal sSQLexp As String = "") As DataSet

        'Dim connStr As String = ConfigurationManager.ConnectionStrings("SnagRConnectionString").ConnectionString
        'marshaller to create a single getData() function to return a dataset depending on database

        If InStr(connectionString.ToLower, "jet.oledb") = 0 Then
            If Len(sSQLexp) > 0 Then sSQL = sSQLexp
            Return getSqlData(sSQL, SQLconn, bCloseConn)
        Else
            Return getOLEDBData(sSQL, OleDBconn, bCloseConn)
        End If

    End Function


    ''' <summary>
    ''' Returns a database type independant dataset 
    ''' </summary>
    ''' <param name="sSQL">SQL Querystring</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function getDataSetOld(ByVal sSQL As String, ByVal connectionString As String) As DataSet

        'Dim connStr As String = ConfigurationManager.ConnectionStrings("SnagRConnectionString").ConnectionString
        'marshaller to create a single getData() function to return a dataset depending on database

        If InStr(connectionString.ToLower, "jet.oledb") = 0 Then
            Return getSqlData(sSQL, connectionString)
        Else
            Return getOLEDBData(sSQL, connectionString)
        End If

    End Function



    Public Shared Function getDataSetOld(ByVal sSQL As String, ByVal connectionString As String, ByVal sTable As String) As DataSet

        ' Dim connStr As String = ConfigurationManager.ConnectionStrings("SnagRConnectionString").ConnectionString
        'marshaller to create a single getData() function to return a dataset depending on database

        If InStr(connectionString.ToLower, "jet.oledb") = 0 Then
            Return getSqlData(sSQL, connectionString, sTable)
        Else
            Return getOLEDBData(sSQL, connectionString, sTable)
        End If

    End Function

    Public Shared Function getDataSetOld(ByVal sSQL As String, ByVal connectionString As String, ByVal bCloseConn As Boolean, ByVal OleDBconn As OleDbConnection, ByVal SQLconn As SqlConnection) As DataSet

        'Dim connStr As String = ConfigurationManager.ConnectionStrings("SnagRConnectionString").ConnectionString
        'marshaller to create a single getData() function to return a dataset depending on database

        If InStr(connectionString.ToLower, "jet.oledb") = 0 Then
            Return getSqlData(sSQL, SQLconn, bCloseConn)
        Else
            Return getOLEDBData(sSQL, OleDBconn, bCloseConn)
        End If

    End Function



    Private Shared Function getOLEDBData(ByVal sSQL As String, ByVal connStr As String, Optional ByRef sError As Exception = Nothing) As DataSet
        Dim myDataSet As New DataSet
        Using oleDBConn As New OleDbConnection()
            Using oleDBCmd As New OleDbCommand()

                oleDBConn.ConnectionString = connStr

                Try
                    oleDBConn.Open()

                    Dim dataAdapter As New OleDbDataAdapter(sSQL, oleDBConn)
                    dataAdapter.Fill(myDataSet)

                Catch ex As Exception
                    SnagRError.LogError(ex, sSQL)
                    sError = ex
                Finally
                    oleDBConn.Close()
                End Try

            End Using
        End Using
        Return myDataSet
    End Function

    Private Shared Function getSqlData(ByVal sSQL As String, ByVal connStr As String, Optional ByRef sError As Exception = Nothing) As DataSet
        Dim myDataSet As New DataSet
        Using sqlConn As New SqlConnection
            Using sqlCmd As New SqlCommand
                sqlConn.ConnectionString = connStr

                Try
                    sqlConn.Open()

                    Dim dataAdapter As New SqlDataAdapter(sSQL, sqlConn)
                    dataAdapter.Fill(myDataSet)

                Catch ex As Exception
                    SnagRError.LogError(ex, sSQL)
                    sError = ex
                Finally
                    sqlConn.Close()
                End Try

            End Using
        End Using
        Return myDataSet
    End Function

    'Private Shared Function getSqliteData(ByVal sSQL As String, ByVal connStr As String, Optional ByRef sError As Exception = Nothing) As DataSet
    '    Dim myDataSet As New DataSet
    '    Using sqlConn As New SQLiteConnection
    '        Using sqlCmd As New SqlCommand
    '            sqlConn.ConnectionString = connStr

    '            Try
    '                sqlConn.Open()

    '                Dim dataAdapter As New SQLiteDataAdapter(sSQL, sqlConn)
    '                dataAdapter.Fill(myDataSet)

    '            Catch ex As Exception
    '                SnagRError.LogError(ex, sSQL)
    '                sError = ex
    '            Finally
    '                sqlConn.Close()
    '            End Try

    '        End Using
    '    End Using
    '    Return myDataSet
    'End Function



    Private Shared Function getSqlData(ByVal sSQL As String, ByVal conn As SqlConnection, Optional ByRef sError As Exception = Nothing) As DataSet
        Dim myDataSet As New DataSet
        Using sqlCmd As New SqlCommand

            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                Dim dataAdapter As New SqlDataAdapter(sSQL, conn)
                dataAdapter.Fill(myDataSet)

            Catch ex As Exception
                SnagRError.LogError(ex, sSQL)
                sError = ex
            Finally
                'sqlConn.Close()
            End Try

        End Using
        Return myDataSet
    End Function

    'Private Shared Function getSqliteData(ByVal sSQL As String, ByVal conn As SQLiteConnection, Optional ByRef sError As Exception = Nothing) As DataSet
    '    Dim myDataSet As New DataSet
    '    Using sqlCmd As New SqlCommand

    '        Try
    '            If conn.State = ConnectionState.Closed Then
    '                conn.Open()
    '            End If

    '            Dim dataAdapter As New SQLiteDataAdapter(sSQL, conn)
    '            dataAdapter.Fill(myDataSet)

    '        Catch ex As Exception
    '            SnagRError.LogError(ex, sSQL)
    '            sError = ex
    '        Finally
    '            'sqlConn.Close()
    '        End Try

    '    End Using
    '    Return myDataSet
    'End Function

    Private Shared Function getOLEDBData(ByVal sSQL As String, ByVal connStr As String, ByVal sTable As String) As DataSet
        Dim myDataSet As New DataSet
        Using oleDBConn As New OleDbConnection()
            Using oleDBCmd As New OleDbCommand()

                oleDBConn.ConnectionString = connStr

                Try
                    oleDBConn.Open()

                    Dim dataAdapter As New OleDbDataAdapter(sSQL, oleDBConn)
                    dataAdapter.Fill(myDataSet, sTable)

                    'Dim cmd1 As New OleDbCommand(sSQL, conn)
                    '    sa.SelectCommand = cmd1
                    '    sa.Fill(ds, "qReportSnagsAllDrwgs")

                Catch ex As Exception
                    SnagRError.LogError(ex, sSQL)
                Finally
                    oleDBConn.Close()
                End Try

            End Using
        End Using
        Return myDataSet
    End Function

    Private Shared Function getSqlData(ByVal sSQL As String, ByVal connStr As String, ByVal sTable As String) As DataSet
        Dim myDataSet As New DataSet
        Using sqlConn As New SqlConnection
            Using sqlCmd As New SqlCommand
                sqlConn.ConnectionString = connStr

                Try
                    sqlConn.Open()

                    Dim dataAdapter As New SqlDataAdapter(sSQL, sqlConn)
                    dataAdapter.Fill(myDataSet, sTable)

                Catch ex As Exception
                    SnagRError.LogError(ex, sSQL)
                Finally
                    sqlConn.Close()
                End Try

            End Using
        End Using

        Return myDataSet

    End Function

    Private Shared Function getOLEDBData(ByVal sSQL As String, ByVal oledbConn As OleDbConnection, ByVal bCloseConn As Boolean) As DataSet
        Dim myDataSet As New DataSet
        Using oleDBCmd As New OleDbCommand()

            Try
                If oledbConn.State = ConnectionState.Closed Then
                    oledbConn.Open()
                End If

                Dim dataAdapter As New OleDbDataAdapter(sSQL, oledbConn)
                dataAdapter.Fill(myDataSet)

            Catch ex As Exception
                SnagRError.LogError(ex, sSQL)
            Finally
                If bCloseConn Then
                    oledbConn.Close()
                End If
            End Try

        End Using
        Return myDataSet
    End Function

    Private Shared Function getSqlData(ByVal sSQL As String, ByVal sqlConn As SqlConnection, ByVal bCloseConn As Boolean) As DataSet
        Dim myDataSet As New DataSet
        Using sqlCmd As New SqlCommand

            Try
                If sqlConn.State = ConnectionState.Closed Then
                    sqlConn.Open()
                End If

                Dim dataAdapter As New SqlDataAdapter(sSQL, sqlConn)
                dataAdapter.Fill(myDataSet)

            Catch ex As Exception
                SnagRError.LogError(ex, sSQL)
            Finally
                If bCloseConn Then
                    sqlConn.Close()
                End If
            End Try
        End Using
        Return myDataSet

    End Function

#End Region



#Region "getDataTable"

    Public Shared Function GetDataTable(ByVal query As String, ByVal connString As String) As DataTable
        Dim table1 As New DataTable
        Using connection1 As New SqlConnection(connString)
            Using adapter1 As New SqlDataAdapter
                adapter1.SelectCommand = New SqlCommand(query, connection1)

                connection1.Open()
                Try
                    adapter1.Fill(table1)
                Catch ex As Exception
                    SnagRError.LogError(ex, query)
                Finally
                    connection1.Close()
                End Try
            End Using
        End Using
        Return table1

    End Function

    Public Shared Function GetDataTable(ByVal query As String, ByVal conn As SqlConnection) As DataTable
        Dim table1 As New DataTable
        Using adapter1 As New SqlDataAdapter
            adapter1.SelectCommand = New SqlCommand(query, conn)

            Try
                adapter1.Fill(table1)
            Catch ex As Exception
                SnagRError.LogError(ex, query)
            End Try
        End Using
        Return table1

    End Function

#End Region

#Region "getDataAdapter"

    Public Shared Function getDataAdapter(ByVal sSQL As String) As Object


    End Function

    'Public Shared Function SnagRDataAdapter() As Object

    '    Dim connString = ConfigurationManager.ConnectionStrings("SnagRConnectionString").ConnectionString

    '    If InStr(connString.ToLower, "jet.oledb") = 0 Then
    '        Dim myOleDBDataAdapter As New OleDbDataAdapter
    '        Return myOleDBDataAdapter
    '    Else
    '        Dim mySqlDataAdapter As New SqlDataAdapter
    '        Return mySqlDataAdapter
    '    End If

    'End Function


#End Region

#Region "getDataReader"

    'Public Shared Function getDataReader(ByVal sSQL As String) As IDataReader

    '    Dim connStr As String = ConfigurationManager.ConnectionStrings("SnagRConnectionString").ConnectionString
    '    'marshaller to create a single getData() function to return a dataset depending on database

    '    If InStr(connStr.ToLower, "jet.oledb") = 0 Then
    '        Return getSqlDataReader(sSQL, connStr)
    '    Else
    '        Return getOLEDBDataReader(sSQL, connStr)
    '    End If

    'End Function

    Private Shared Function getSqlDataReader(ByVal sSQL As String, ByVal connStr As String) As SqlDataReader
        Dim rd As SqlDataReader
        Using conn As New SqlConnection(connStr)
            Using cmd As New SqlCommand(sSQL, conn)

                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    rd = cmd.ExecuteReader()

                    'Dim iCntr As Integer = 0
                    'While rd.Read
                    '    DrwgID = CInt(rd("drwgID"))
                    '    iCntr += 1
                    'End While
                Catch ex As Exception
                    SnagRError.LogError(ex, sSQL)
                    Return Nothing
                Finally
                    conn.Close()
                End Try

            End Using
        End Using
        Return rd

    End Function

    Private Shared Function getOLEDBDataReader(ByVal sSQL As String, ByVal connStr As String) As OleDbDataReader
        Dim rd As OleDbDataReader
        Using conn As New OleDbConnection(connStr)
            Using cmd As New OleDbCommand(sSQL, conn)


                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    rd = cmd.ExecuteReader()

                    'Dim iCntr As Integer = 0
                    'While rd.Read
                    '    DrwgID = CInt(rd("drwgID"))
                    '    iCntr += 1
                    'End While
                Catch ex As Exception
                    SnagRError.LogError(ex, sSQL)
                    Return Nothing
                Finally
                    'conn.Close()
                End Try
            End Using
        End Using
        Return rd

    End Function

#End Region

#Region "getRecordCount"

    Public Shared Function getRecordCount(ByVal sSQL As String, ByVal connectionString As String) As Integer

        'Dim connStr As String = ConfigurationManager.ConnectionStrings("SnagRConnectionString").ConnectionString
        'marshaller to create a single getData() function to return a dataset depending ordCounton database

        Dim pos As Integer = InStr(sSQL.ToLower, " from ")
        sSQL = "select count(*) " & Right(sSQL, Len(sSQL) - pos)

        If InStr(connectionString.ToLower, "jet.oledb") = 0 Then
            Return getSQLRecCnt(sSQL, connectionString)
        Else
            Return getOLEDBRecCnt(sSQL, connectionString)
        End If

    End Function

    Private Shared Function getOLEDBRecCnt(ByVal sSQL As String, ByVal connStr As String) As Integer
        Dim recCnt As Integer = 0
        Using oleDBConn As New OleDbConnection()
            Using oleDBCmd As New OleDbCommand()

                oleDBConn.ConnectionString = connStr

                Try
                    oleDBConn.Open()

                    Dim cmd As New OleDbCommand(sSQL, oleDBConn)
                    recCnt = cmd.ExecuteScalar
                    cmd.Dispose()
                Catch ex As Exception
                    SnagRError.LogError(ex, sSQL)
                    recCnt = 0

                Finally
                    oleDBConn.Close()
                End Try
            End Using
        End Using

        Return recCnt

    End Function

    Private Shared Function getSQLRecCnt(ByVal sSQL As String, ByVal connStr As String) As Integer
        Dim recCnt As Integer = 0
        Using sqlConn As New SqlConnection()
            Using sqlCmd As New SqlCommand()

                sqlConn.ConnectionString = connStr

                Try
                    sqlConn.Open()

                    Dim cmd As New SqlCommand(sSQL, sqlConn)
                    recCnt = cmd.ExecuteScalar
                    cmd.Dispose()
                Catch ex As Exception
                    SnagRError.LogError(ex, sSQL)
                    recCnt = 0

                Finally
                    sqlConn.Close()
                End Try
            End Using
        End Using

        Return recCnt

    End Function

#End Region

#End Region

#Region "Updates"

    Public Shared Function RunSQL(ByVal connStr As String, ByVal sSQL As String, Optional ByVal sSQLexp As String = "") As Boolean
        RunSQL = True

        Using conn As New SqlConnection(connStr)
            If Len(sSQLexp) > 0 Then
                sSQL = sSQLexp
            End If
            Dim cmd As New SqlCommand(sSQL, conn)
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                'SnagRError.LogError("RunSQLCommand", ex, HttpContext.Current.Request.Url.AbsoluteUri, sSQL)
                Return False
            Finally
                cmd.Dispose()
                conn.Close()
            End Try
        End Using
    End Function

    Public Shared Function RunSQL(ByVal conn As SqlConnection, ByVal sSQL As String) As Boolean
        RunSQL = True

        Using cmd As New SqlCommand(sSQL, conn)
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                'SnagRError.LogError("RunSQLCommand", ex, HttpContext.Current.Request.Url.AbsoluteUri, sSQL)
                Return False
            Finally
                ' cmd.Dispose()
                ''conn.Close()
            End Try
        End Using
    End Function

    Public Shared Function RunSQL(ByVal conn As SqlConnection, ByVal sSQL As String, ByVal Trans As SqlTransaction) As Boolean
        RunSQL = True

        Using cmd As New SqlCommand(sSQL, conn)
            cmd.Transaction = Trans
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                'SnagRError.LogError("RunSQLCommand", ex, HttpContext.Current.Request.Url.AbsoluteUri, sSQL)
                Return False
            Finally
                ' cmd.Dispose()
                ''conn.Close()
            End Try
        End Using

    End Function

    Public Shared Function RunSQLErrMsg(ByVal connStr As String, ByVal sSQL As String, Optional ByVal sSQLexp As String = "") As String
        RunSQLErrMsg = "" 'success

        Using conn As New SqlConnection(connStr)
            If Len(sSQLexp) > 0 Then
                sSQL = sSQLexp
            End If
            Using cmd As New SqlCommand(sSQL, conn)
                Try
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    'SnagRError.LogError("RunSQLCommand", ex, HttpContext.Current.Request.Url.AbsoluteUri, sSQL)
                    RunSQLErrMsg &= "  " & ex.Message.ToString
                Finally
                    ' cmd.Dispose()
                    'conn.Close()
                End Try
            End Using
        End Using

    End Function

#End Region

    Public Shared Sub SetDataTable_To_CSV(ByVal dtable As DataTable, ByVal path_filename As String, ByVal sep_char As String)
        Dim writer As System.IO.StreamWriter
        Try
            writer = New System.IO.StreamWriter(path_filename)

            Dim _sep As String = ""
            Dim builder As New System.Text.StringBuilder
            For Each col As DataColumn In dtable.Columns
                builder.Append(_sep).Append(col.ColumnName)
                _sep = sep_char
            Next
            writer.WriteLine(builder.ToString())

            For Each row As DataRow In dtable.Rows
                _sep = ""
                builder = New System.Text.StringBuilder

                For Each col As DataColumn In dtable.Columns
                    builder.Append(_sep).Append(row(col.ColumnName))
                    _sep = sep_char
                Next
                writer.WriteLine(builder.ToString())
            Next
        Catch ex As Exception

        Finally
            If Not writer Is Nothing Then writer.Close()
        End Try
    End Sub
End Class
