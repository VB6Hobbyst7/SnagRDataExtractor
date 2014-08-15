Imports SnagRWeb_Project.SnagRData
Imports System.Data.SqlClient

Public Class TFORMPLOTS

   Private [_SCID] As Int32
   Public Property [SCID]() As Int32
       Get
           Return [_SCID]
       End Get
       Set(ByVal value As Int32)
           [_SCID] = value
       End Set
    End Property
   Private [_SCGUID] As String
   Public Property [SCGUID]() As String
       Get
           Return [_SCGUID]
       End Get
       Set(ByVal value As String)
           [_SCGUID] = value
       End Set
    End Property
   Private [_DateStamp] As DateTime
   Public Property [DateStamp]() As DateTime
       Get
           Return [_DateStamp]
       End Get
       Set(ByVal value As DateTime)
           [_DateStamp] = value
       End Set
    End Property
   Private [_IssuedDate] As DateTime
   Public Property [IssuedDate]() As DateTime
       Get
           Return [_IssuedDate]
       End Get
       Set(ByVal value As DateTime)
           [_IssuedDate] = value
       End Set
    End Property
   Private [_ValidUntil] As DateTime
   Public Property [ValidUntil]() As DateTime
       Get
           Return [_ValidUntil]
       End Get
       Set(ByVal value As DateTime)
           [_ValidUntil] = value
       End Set
    End Property
   Private [_IssuedTo] As String
   Public Property [IssuedTo]() As String
       Get
           Return [_IssuedTo]
       End Get
       Set(ByVal value As String)
           [_IssuedTo] = value
       End Set
    End Property
   Private [_IssuedBy] As String
   Public Property [IssuedBy]() As String
       Get
           Return [_IssuedBy]
       End Get
       Set(ByVal value As String)
           [_IssuedBy] = value
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
   Private [_AcceptedBy] As String
   Public Property [AcceptedBy]() As String
       Get
           Return [_AcceptedBy]
       End Get
       Set(ByVal value As String)
           [_AcceptedBy] = value
       End Set
    End Property
   Private [_isPassed] As Boolean
   Public Property [isPassed]() As Boolean
       Get
           Return [_isPassed]
       End Get
       Set(ByVal value As Boolean)
           [_isPassed] = value
       End Set
    End Property
   Private [_IsClosed] As Boolean
   Public Property [IsClosed]() As Boolean
       Get
           Return [_IsClosed]
       End Get
       Set(ByVal value As Boolean)
           [_IsClosed] = value
       End Set
    End Property

End Class

Public Class TFORMPLOTSDAO

   Public Shared Function getUsingSCID(ByVal SCID As Int32, ByVal connectionString As String, Optional ByVal Limit As Integer = 0) As TFORMPLOTS
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormPlots Where SCID = "  & SCID, connectionString)
       Else
           dt  = SnagRData.GetDataTable("Select * from tFormPlots Where SCID = "  & SCID, connectionString)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TFORMPLOTS, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getUsingSCID(ByVal SCID As Int32, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0) As TFORMPLOTS
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormPlots Where SCID = "  & SCID, conn)
       Else
           dt  = SnagRData.GetDataTable("Select * from tFormPlots Where SCID = "  & SCID, conn)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TFORMPLOTS, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0, Optional sql as String = Nothing) As List(Of TFORMPLOTS)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, connectionString)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormPlots Where " + where, connectionString)
       Else
           dt = SnagRData.GetDataTable("Select * from tFormPlots Where " + where, connectionString)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TFORMPLOTS)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TFORMPLOTS, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0, Optional ByVal sql as String = Nothing) As List(Of TFORMPLOTS)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, conn)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormPlots Where " + where, conn)
       Else
           dt = SnagRData.GetDataTable("Select * from tFormPlots Where " + where, conn)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TFORMPLOTS)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TFORMPLOTS, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

    Public Shared Function insert(ByVal tFormPlots As TFORMPLOTS, ByVal connectionString As String) As Boolean

        Dim sSQL As String = "Insert into tFormPlots (SCID, [SCGUID], [DateStamp], [IssuedDate], [ValidUntil], [IssuedTo], [IssuedBy], [DateSync], [AcceptedBy], [isPassed], [IsClosed]) Values (" & tFormPlots.SCID & ", " & "N'" & tFormPlots.SCGUID & "'" & ", " & IIf(tFormPlots.DateStamp = Nothing, "null", "'" & tFormPlots.DateStamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & IIf(tFormPlots.IssuedDate = Nothing, "null", "'" & tFormPlots.IssuedDate.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & IIf(tFormPlots.ValidUntil = Nothing, "null", "'" & tFormPlots.ValidUntil.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tFormPlots.IssuedTo & "'" & ", " & "N'" & tFormPlots.IssuedBy & "'" & ", " & IIf(tFormPlots.DateSync = Nothing, "null", "'" & tFormPlots.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tFormPlots.AcceptedBy & "'" & ", " & "'" & tFormPlots.isPassed & "'" & ", " & "'" & tFormPlots.IsClosed & "'" & ")"
       Return SnagRData.RunSQL(connectionString, sSQL)

   End Function

    Public Shared Function insert(ByVal tFormPlots As TFORMPLOTS, ByVal conn As SqlConnection) As Boolean

        Dim sSQL As String = "Insert into tFormPlots ([SCID], [SCGUID], [DateStamp], [IssuedDate], [ValidUntil], [IssuedTo], [IssuedBy], [DateSync], [AcceptedBy], [isPassed], [IsClosed]) Values (" & tFormPlots.SCID & ", " & "N'" & tFormPlots.SCGUID & "'" & ", " & IIf(tFormPlots.DateStamp = Nothing, "null", "'" & tFormPlots.DateStamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & IIf(tFormPlots.IssuedDate = Nothing, "null", "'" & tFormPlots.IssuedDate.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & IIf(tFormPlots.ValidUntil = Nothing, "null", "'" & tFormPlots.ValidUntil.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tFormPlots.IssuedTo & "'" & ", " & "N'" & tFormPlots.IssuedBy & "'" & ", " & IIf(tFormPlots.DateSync = Nothing, "null", "'" & tFormPlots.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tFormPlots.AcceptedBy & "'" & ", " & "'" & tFormPlots.isPassed & "'" & ", " & "'" & tFormPlots.IsClosed & "'" & ")"
       Return SnagRData.RunSQL(conn, sSQL)

   End Function

    Public Shared Function update(ByVal tFormPlots As TFORMPLOTS, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Update tFormPlots Set [SCGUID] = N'" & tFormPlots.SCGUID & "'" & ", [DateStamp] = " & IIf(tFormPlots.DateStamp = Nothing, "null", "'" & tFormPlots.DateStamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", [IssuedDate] = " & IIf(tFormPlots.IssuedDate = Nothing, "null", "'" & tFormPlots.IssuedDate.ToString("yyyy-MM-dd HH:mm") & "'") & ", [ValidUntil] = " & IIf(tFormPlots.ValidUntil = Nothing, "null", "'" & tFormPlots.ValidUntil.ToString("yyyy-MM-dd HH:mm") & "'") & ", [IssuedTo] = N'" & tFormPlots.IssuedTo & "'" & ", [IssuedBy] = N'" & tFormPlots.IssuedBy & "'" & ", [DateSync] = " & IIf(tFormPlots.DateSync = Nothing, "null", "'" & tFormPlots.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [AcceptedBy] = N'" & tFormPlots.AcceptedBy & "'" & ", [isPassed] = " & IIf(tFormPlots.isPassed = True, "1", "0") & ", [IsClosed] = " & IIf(tFormPlots.IsClosed = True, "1", "0") & " Where [SCID] = " & tFormPlots.SCID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function update(ByVal tFormPlots As TFORMPLOTS, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Update tFormPlots Set [SCGUID] = N'" & tFormPlots.SCGUID & "'" & ", [DateStamp] = " & IIf(tFormPlots.DateStamp = Nothing, "null", "'" & tFormPlots.DateStamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", [IssuedDate] = " & IIf(tFormPlots.IssuedDate = Nothing, "null", "'" & tFormPlots.IssuedDate.ToString("yyyy-MM-dd HH:mm") & "'") & ", [ValidUntil] = " & IIf(tFormPlots.ValidUntil = Nothing, "null", "'" & tFormPlots.ValidUntil.ToString("yyyy-MM-dd HH:mm") & "'") & ", [IssuedTo] = N'" & tFormPlots.IssuedTo & "'" & ", [IssuedBy] = N'" & tFormPlots.IssuedBy & "'" & ", [DateSync] = " & IIf(tFormPlots.DateSync = Nothing, "null", "'" & tFormPlots.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [AcceptedBy] = N'" & tFormPlots.AcceptedBy & "'" & ", [isPassed] = " & IIf(tFormPlots.isPassed = True, "1", "0") & ", [IsClosed] = " & IIf(tFormPlots.IsClosed = True, "1", "0") & " Where [SCID] = " & tFormPlots.SCID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

    Public Shared Function delete(ByVal tFormPlots As TFORMPLOTS, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Delete from tFormPlots Where [SCID] = " & tFormPlots.SCID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function updateBlob(ByVal tFormPlots As TFORMPLOTS, ByVal column As String, ByVal b46Str As String, ByVal connectionString As String) As Boolean

        Dim conn As SqlConnection = New SqlConnection(connectionString)
       conn.Open()

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))

       Dim sSQL As String = "UPDATE tFormPlots SET " & column & "=@Image WHERE SCID = " & tFormPlots.SCID
       cmd.CommandText = sSQL
        cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
       cmd.ExecuteNonQuery()

       conn.Close()
       conn.Dispose()

   End Function

    Public Shared Function updateBlob(ByVal tFormPlots As TFORMPLOTS, ByVal column As String, ByVal b46Str As String, ByVal conn As SqlConnection) As Boolean

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))
Dim sSQL As String = "UPDATE tFormPlots SET " & column & "=@Image WHERE SCID = " & tFormPlots.SCID
cmd.CommandText = sSQL
cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
cmd.ExecuteNonQuery()

   End Function

    Public Shared Function delete(ByVal tFormPlots As TFORMPLOTS, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Delete from tFormPlots Where [SCID] = " & tFormPlots.SCID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

   Private Shared Function loadFromResultSet(ByVal obj As TFORMPLOTS, ByVal resultset As DataRow) As TFORMPLOTS
      obj.SCID = ProcessNull.GetInt32(resultset.Item("SCID"))
      obj.SCGUID = ProcessNull.GetString(resultset.Item("SCGUID"))
      obj.DateStamp = ProcessNull.GetDateTime(resultset.Item("DateStamp"))
      obj.IssuedDate = ProcessNull.GetDateTime(resultset.Item("IssuedDate"))
      obj.ValidUntil = ProcessNull.GetDateTime(resultset.Item("ValidUntil"))
      obj.IssuedTo = ProcessNull.GetString(resultset.Item("IssuedTo"))
      obj.IssuedBy = ProcessNull.GetString(resultset.Item("IssuedBy"))
      obj.DateSync = ProcessNull.GetDateTime(resultset.Item("DateSync"))
      obj.AcceptedBy = ProcessNull.GetString(resultset.Item("AcceptedBy"))
       obj.isPassed = ProcessNull.GetBoolean(resultset.Item("isPassed"))
       obj.IsClosed = ProcessNull.GetBoolean(resultset.Item("IsClosed"))

       Return obj

   End Function

End Class

