Imports SnagRWeb_Project.SnagRData
Imports System.Data.SqlClient

Public Class TSNAGUPDATES

   Private [_SUID] As Int32
   Public Property [SUID]() As Int32
       Get
           Return [_SUID]
       End Get
       Set(ByVal value As Int32)
           [_SUID] = value
       End Set
    End Property
   Private [_SnagID] As Int32
   Public Property [SnagID]() As Int32
       Get
           Return [_SnagID]
       End Get
       Set(ByVal value As Int32)
           [_SnagID] = value
       End Set
    End Property
   Private [_Status] As String
   Public Property [Status]() As String
       Get
           Return [_Status]
       End Get
       Set(ByVal value As String)
           [_Status] = value
       End Set
    End Property
   Private [_FixDescrip] As String
   Public Property [FixDescrip]() As String
       Get
           Return [_FixDescrip]
       End Get
       Set(ByVal value As String)
           [_FixDescrip] = value
       End Set
    End Property
   Private [_UserID] As Int32
   Public Property [UserID]() As Int32
       Get
           Return [_UserID]
       End Get
       Set(ByVal value As Int32)
           [_UserID] = value
       End Set
    End Property
   Private [_Datestamp] As DateTime
   Public Property [Datestamp]() As DateTime
       Get
           Return [_Datestamp]
       End Get
       Set(ByVal value As DateTime)
           [_Datestamp] = value
       End Set
    End Property
   Private [_Photo] As String
   Public Property [Photo]() As String
       Get
           Return [_Photo]
       End Get
       Set(ByVal value As String)
           [_Photo] = value
       End Set
    End Property
   Private [_BigPhoto] As String
   Public Property [BigPhoto]() As String
       Get
           Return [_BigPhoto]
       End Get
       Set(ByVal value As String)
           [_BigPhoto] = value
       End Set
    End Property
   Private [_SchedID] As Int32
   Public Property [SchedID]() As Int32
       Get
           Return [_SchedID]
       End Get
       Set(ByVal value As Int32)
           [_SchedID] = value
       End Set
    End Property
   Private [_PPCGuid] As String
   Public Property [PPCGuid]() As String
       Get
           Return [_PPCGuid]
       End Get
       Set(ByVal value As String)
           [_PPCGuid] = value
       End Set
    End Property
   Private [_Signature1] As String
   Public Property [Signature1]() As String
       Get
           Return [_Signature1]
       End Get
       Set(ByVal value As String)
           [_Signature1] = value
       End Set
    End Property
   Private [_Signature2] As String
   Public Property [Signature2]() As String
       Get
           Return [_Signature2]
       End Get
       Set(ByVal value As String)
           [_Signature2] = value
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

End Class

Public Class TSNAGUPDATESDAO

   Public Shared Function getUsingSUID(ByVal SUID As Int32, ByVal connectionString As String, Optional ByVal Limit As Integer = 0) As TSNAGUPDATES
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSnagUpdates Where SUID = "  & SUID, connectionString)
       Else
           dt  = SnagRData.GetDataTable("Select * from tSnagUpdates Where SUID = "  & SUID, connectionString)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TSNAGUPDATES, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getUsingSUID(ByVal SUID As Int32, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0) As TSNAGUPDATES
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSnagUpdates Where SUID = "  & SUID, conn)
       Else
           dt  = SnagRData.GetDataTable("Select * from tSnagUpdates Where SUID = "  & SUID, conn)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TSNAGUPDATES, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0, Optional sql as String = Nothing) As List(Of TSNAGUPDATES)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, connectionString)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSnagUpdates Where " + where, connectionString)
       Else
           dt = SnagRData.GetDataTable("Select * from tSnagUpdates Where " + where, connectionString)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TSNAGUPDATES)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TSNAGUPDATES, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0, Optional ByVal sql as String = Nothing) As List(Of TSNAGUPDATES)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, conn)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSnagUpdates Where " + where, conn)
       Else
           dt = SnagRData.GetDataTable("Select * from tSnagUpdates Where " + where, conn)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TSNAGUPDATES)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TSNAGUPDATES, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

    Public Shared Function insert(ByVal tSnagUpdates As TSNAGUPDATES, ByVal connectionString As String) As Boolean

        Dim sSQL As String = "Insert into tSnagUpdates (SnagID, [Status], [FixDescrip], [UserID], [Datestamp], [Photo], [BigPhoto], [SchedID], [PPCGuid], [Signature1], [Signature2], [DateSync]) Values (" & tSnagUpdates.SnagID & ", " & "N'" & tSnagUpdates.Status & "'" & ", " & "N'" & tSnagUpdates.FixDescrip & "'" & ", " & tSnagUpdates.UserID & ", " & IIf(tSnagUpdates.Datestamp = Nothing, "null", "'" & tSnagUpdates.Datestamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "null" & ", " & "null" & ", " & tSnagUpdates.SchedID & ", " & "N'" & tSnagUpdates.PPCGuid & "'" & ", " & "null" & ", " & "null" & ", " & IIf(tSnagUpdates.DateSync = Nothing, "null", "'" & tSnagUpdates.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ")"
       Return SnagRData.RunSQL(connectionString, sSQL)

   End Function

    Public Shared Function insert(ByVal tSnagUpdates As TSNAGUPDATES, ByVal conn As SqlConnection) As Boolean

        Dim sSQL As String = "Insert into tSnagUpdates ([SnagID], [Status], [FixDescrip], [UserID], [Datestamp], [Photo], [BigPhoto], [SchedID], [PPCGuid], [Signature1], [Signature2], [DateSync]) Values (" & tSnagUpdates.SnagID & ", " & "N'" & tSnagUpdates.Status & "'" & ", " & "N'" & tSnagUpdates.FixDescrip & "'" & ", " & tSnagUpdates.UserID & ", " & IIf(tSnagUpdates.Datestamp = Nothing, "null", "'" & tSnagUpdates.Datestamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "null" & ", " & "null" & ", " & tSnagUpdates.SchedID & ", " & "N'" & tSnagUpdates.PPCGuid & "'" & ", " & "null" & ", " & "null" & ", " & IIf(tSnagUpdates.DateSync = Nothing, "null", "'" & tSnagUpdates.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ")"
       Return SnagRData.RunSQL(conn, sSQL)

   End Function

    Public Shared Function update(ByVal tSnagUpdates As TSNAGUPDATES, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Update tSnagUpdates Set [SnagID] = " & tSnagUpdates.SnagID & ", [Status] = N'" & tSnagUpdates.Status & "'" & ", [FixDescrip] = N'" & tSnagUpdates.FixDescrip & "'" & ", [UserID] = " & tSnagUpdates.UserID & ", [Datestamp] = " & IIf(tSnagUpdates.Datestamp = Nothing, "null", "'" & tSnagUpdates.Datestamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", [SchedID] = " & tSnagUpdates.SchedID & ", [PPCGuid] = N'" & tSnagUpdates.PPCGuid & "'" & ", [DateSync] = " & IIf(tSnagUpdates.DateSync = Nothing, "null", "'" & tSnagUpdates.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & " Where [SUID] = " & tSnagUpdates.SUID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function update(ByVal tSnagUpdates As TSNAGUPDATES, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Update tSnagUpdates Set [SnagID] = " & tSnagUpdates.SnagID & ", [Status] = N'" & tSnagUpdates.Status & "'" & ", [FixDescrip] = N'" & tSnagUpdates.FixDescrip & "'" & ", [UserID] = " & tSnagUpdates.UserID & ", [Datestamp] = " & IIf(tSnagUpdates.Datestamp = Nothing, "null", "'" & tSnagUpdates.Datestamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", [SchedID] = " & tSnagUpdates.SchedID & ", [PPCGuid] = N'" & tSnagUpdates.PPCGuid & "'" & ", [DateSync] = " & IIf(tSnagUpdates.DateSync = Nothing, "null", "'" & tSnagUpdates.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & " Where [SUID] = " & tSnagUpdates.SUID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

    Public Shared Function delete(ByVal tSnagUpdates As TSNAGUPDATES, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Delete from tSnagUpdates Where [SUID] = " & tSnagUpdates.SUID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function updateBlob(ByVal tSnagUpdates As TSNAGUPDATES, ByVal column As String, ByVal b46Str As String, ByVal connectionString As String) As Boolean

        Dim conn As SqlConnection = New SqlConnection(connectionString)
       conn.Open()

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))

       Dim sSQL As String = "UPDATE tSnagUpdates SET " & column & "=@Image WHERE SUID = " & tSnagUpdates.SUID
       cmd.CommandText = sSQL
        cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
       cmd.ExecuteNonQuery()

       conn.Close()
       conn.Dispose()

   End Function

    Public Shared Function updateBlob(ByVal tSnagUpdates As TSNAGUPDATES, ByVal column As String, ByVal b46Str As String, ByVal conn As SqlConnection) As Boolean

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))
Dim sSQL As String = "UPDATE tSnagUpdates SET " & column & "=@Image WHERE SUID = " & tSnagUpdates.SUID
cmd.CommandText = sSQL
cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
cmd.ExecuteNonQuery()

   End Function

    Public Shared Function delete(ByVal tSnagUpdates As TSNAGUPDATES, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Delete from tSnagUpdates Where [SUID] = " & tSnagUpdates.SUID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

   Private Shared Function loadFromResultSet(ByVal obj As TSNAGUPDATES, ByVal resultset As DataRow) As TSNAGUPDATES
      obj.SUID = ProcessNull.GetInt32(resultset.Item("SUID"))
      obj.SnagID = ProcessNull.GetInt32(resultset.Item("SnagID"))
      obj.Status = ProcessNull.GetString(resultset.Item("Status"))
      obj.FixDescrip = ProcessNull.GetString(resultset.Item("FixDescrip"))
      obj.UserID = ProcessNull.GetInt32(resultset.Item("UserID"))
      obj.Datestamp = ProcessNull.GetDateTime(resultset.Item("Datestamp"))
     If Not IsDBNull(resultset.Item("Photo")) Then
         obj.Photo = Convert.ToBase64String(resultset.Item("Photo"))
      End If
     If Not IsDBNull(resultset.Item("BigPhoto")) Then
         obj.BigPhoto = Convert.ToBase64String(resultset.Item("BigPhoto"))
      End If
      obj.SchedID = ProcessNull.GetInt32(resultset.Item("SchedID"))
      obj.PPCGuid = ProcessNull.GetString(resultset.Item("PPCGuid"))
     If Not IsDBNull(resultset.Item("Signature1")) Then
         obj.Signature1 = Convert.ToBase64String(resultset.Item("Signature1"))
      End If
     If Not IsDBNull(resultset.Item("Signature2")) Then
         obj.Signature2 = Convert.ToBase64String(resultset.Item("Signature2"))
      End If
      obj.DateSync = ProcessNull.GetDateTime(resultset.Item("DateSync"))

       Return obj

   End Function

End Class

