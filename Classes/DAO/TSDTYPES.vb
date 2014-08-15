Imports SnagRWeb_Project.SnagRData
Imports System.Data.SqlClient

Public Class TSDTYPES

   Private [_SDCode] As String
   Public Property [SDCode]() As String
       Get
           Return [_SDCode]
       End Get
       Set(ByVal value As String)
           [_SDCode] = value
       End Set
    End Property
   Private [_Description] As String
   Public Property [Description]() As String
       Get
           Return [_Description]
       End Get
       Set(ByVal value As String)
           [_Description] = value
       End Set
    End Property
   Private [_Current] As Boolean
   Public Property [Current]() As Boolean
       Get
           Return [_Current]
       End Get
       Set(ByVal value As Boolean)
           [_Current] = value
       End Set
    End Property
   Private [_DateSync] As DateTime
   Public Property [DateSync]() As DateTime
       Get
           Return [_DateSync]
       End Get
       Set(ByVal value As DateTime)
           [_DateSync] = value
       End Set
    End Property
   Private [_STID] As Int32
   Public Property [STID]() As Int32
       Get
           Return [_STID]
       End Get
       Set(ByVal value As Int32)
           [_STID] = value
       End Set
    End Property
   Private [_SDCatID] As Int32
   Public Property [SDCatID]() As Int32
       Get
           Return [_SDCatID]
       End Get
       Set(ByVal value As Int32)
           [_SDCatID] = value
       End Set
    End Property

End Class

Public Class TSDTYPESDAO

   Public Shared Function getUsingSTID(ByVal STID As Int32, ByVal connectionString As String, Optional ByVal Limit As Integer = 0) As TSDTYPES
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSDTypes Where STID = "  & STID, connectionString)
       Else
           dt  = SnagRData.GetDataTable("Select * from tSDTypes Where STID = "  & STID, connectionString)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TSDTYPES, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getUsingSTID(ByVal STID As Int32, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0) As TSDTYPES
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSDTypes Where STID = "  & STID, conn)
       Else
           dt  = SnagRData.GetDataTable("Select * from tSDTypes Where STID = "  & STID, conn)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TSDTYPES, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0, Optional sql as String = Nothing) As List(Of TSDTYPES)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, connectionString)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSDTypes Where " + where, connectionString)
       Else
           dt = SnagRData.GetDataTable("Select * from tSDTypes Where " + where, connectionString)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TSDTYPES)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TSDTYPES, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0, Optional ByVal sql as String = Nothing) As List(Of TSDTYPES)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, conn)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSDTypes Where " + where, conn)
       Else
           dt = SnagRData.GetDataTable("Select * from tSDTypes Where " + where, conn)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TSDTYPES)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TSDTYPES, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

    Public Shared Function insert(ByVal tSDTypes As TSDTYPES, ByVal connectionString As String) As Boolean

        Dim sSQL As String = "Insert into tSDTypes (SDCode, [Description], [Current], [DateSync], [SDCatID]) Values (" & "N'" & tSDTypes.SDCode & "'" & ", " & "N'" & tSDTypes.Description & "'" & ", " & "'" & tSDTypes.Current & "'" & ", " & IIf(tSDTypes.DateSync = Nothing, "null", "'" & tSDTypes.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & tSDTypes.SDCatID & ")"
       Return SnagRData.RunSQL(connectionString, sSQL)

   End Function

    Public Shared Function insert(ByVal tSDTypes As TSDTYPES, ByVal conn As SqlConnection) As Boolean

        Dim sSQL As String = "Insert into tSDTypes ([SDCode], [Description], [Current], [DateSync], [SDCatID]) Values (" & "N'" & tSDTypes.SDCode & "'" & ", " & "N'" & tSDTypes.Description & "'" & ", " & "'" & tSDTypes.Current & "'" & ", " & IIf(tSDTypes.DateSync = Nothing, "null", "'" & tSDTypes.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & tSDTypes.SDCatID & ")"
       Return SnagRData.RunSQL(conn, sSQL)

   End Function

    Public Shared Function update(ByVal tSDTypes As TSDTYPES, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Update tSDTypes Set [SDCode] = N'" & tSDTypes.SDCode & "'" & ", [Description] = N'" & tSDTypes.Description & "'" & ", [Current] = " & IIf(tSDTypes.Current = True, "1", "0") & ", [DateSync] = " & IIf(tSDTypes.DateSync = Nothing, "null", "'" & tSDTypes.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [SDCatID] = " & tSDTypes.SDCatID & " Where [STID] = N'" & tSDTypes.STID & "'"
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function update(ByVal tSDTypes As TSDTYPES, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Update tSDTypes Set [SDCode] = N'" & tSDTypes.SDCode & "'" & ", [Description] = N'" & tSDTypes.Description & "'" & ", [Current] = " & IIf(tSDTypes.Current = True, "1", "0") & ", [DateSync] = " & IIf(tSDTypes.DateSync = Nothing, "null", "'" & tSDTypes.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [SDCatID] = " & tSDTypes.SDCatID & " Where [STID] = N'" & tSDTypes.STID & "'"
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

    Public Shared Function delete(ByVal tSDTypes As TSDTYPES, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Delete from tSDTypes Where [STID] = N'" & tSDTypes.STID & "'"
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function updateBlob(ByVal tSDTypes As TSDTYPES, ByVal column As String, ByVal b46Str As String, ByVal connectionString As String) As Boolean

        Dim conn As SqlConnection = New SqlConnection(connectionString)
       conn.Open()

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))

       Dim sSQL As String = "UPDATE tSDTypes SET " & column & "=@Image WHERE SDCode = " & tSDTypes.SDCode
       cmd.CommandText = sSQL
        cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
       cmd.ExecuteNonQuery()

       conn.Close()
       conn.Dispose()

   End Function

    Public Shared Function updateBlob(ByVal tSDTypes As TSDTYPES, ByVal column As String, ByVal b46Str As String, ByVal conn As SqlConnection) As Boolean

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))
Dim sSQL As String = "UPDATE tSDTypes SET " & column & "=@Image WHERE SDCode = " & tSDTypes.SDCode
cmd.CommandText = sSQL
cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
cmd.ExecuteNonQuery()

   End Function

    Public Shared Function delete(ByVal tSDTypes As TSDTYPES, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Delete from tSDTypes Where [STID] = N'" & tSDTypes.STID & "'"
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

   Private Shared Function loadFromResultSet(ByVal obj As TSDTYPES, ByVal resultset As DataRow) As TSDTYPES
      obj.SDCode = ProcessNull.GetString(resultset.Item("SDCode"))
      obj.Description = ProcessNull.GetString(resultset.Item("Description"))
       obj.Current = ProcessNull.GetBoolean(resultset.Item("Current"))
      obj.DateSync = ProcessNull.GetDateTime(resultset.Item("DateSync"))
      obj.STID = ProcessNull.GetInt32(resultset.Item("STID"))
      obj.SDCatID = ProcessNull.GetInt32(resultset.Item("SDCatID"))

       Return obj

   End Function

End Class

