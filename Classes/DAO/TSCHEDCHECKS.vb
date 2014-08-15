Imports SnagRWeb_Project.SnagRData
Imports System.Data.SqlClient

Public Class TSCHEDCHECKS

   Private [_SCID] As Int32
   Public Property [SCID]() As Int32
       Get
           Return [_SCID]
       End Get
       Set(ByVal value As Int32)
           [_SCID] = value
       End Set
    End Property
   Private [_PlotID] As Int32
   Public Property [PlotID]() As Int32
       Get
           Return [_PlotID]
       End Get
       Set(ByVal value As Int32)
           [_PlotID] = value
       End Set
    End Property
   Private [_Code] As String
   Public Property [Code]() As String
       Get
           Return [_Code]
       End Get
       Set(ByVal value As String)
           [_Code] = value
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
   Private [_srt] As String
   Public Property [srt]() As String
       Get
           Return [_srt]
       End Get
       Set(ByVal value As String)
           [_srt] = value
       End Set
    End Property
   Private [_Qty] As Decimal
   Public Property [Qty]() As Decimal
       Get
           Return [_Qty]
       End Get
       Set(ByVal value As Decimal)
           [_Qty] = value
       End Set
    End Property
   Private [_Result] As Int32
   Public Property [Result]() As Int32
       Get
           Return [_Result]
       End Get
       Set(ByVal value As Int32)
           [_Result] = value
       End Set
    End Property
   Private [_Comment] As String
   Public Property [Comment]() As String
       Get
           Return [_Comment]
       End Get
       Set(ByVal value As String)
           [_Comment] = value
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
   Private [_DateStamp] As DateTime
   Public Property [DateStamp]() As DateTime
       Get
           Return [_DateStamp]
       End Get
       Set(ByVal value As DateTime)
           [_DateStamp] = value
       End Set
    End Property
   Private [_DueBy] As DateTime
   Public Property [DueBy]() As DateTime
       Get
           Return [_DueBy]
       End Get
       Set(ByVal value As DateTime)
           [_DueBy] = value
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
   Private [_DateSync] As DateTime
   Public Property [DateSync]() As DateTime
       Get
           Return [_DateSync]
       End Get
       Set(ByVal value As DateTime)
           [_DateSync] = value
       End Set
    End Property
   Private [_CantSkip] As Boolean
   Public Property [CantSkip]() As Boolean
       Get
           Return [_CantSkip]
       End Get
       Set(ByVal value As Boolean)
           [_CantSkip] = value
       End Set
    End Property
   Private [_Cost] As Decimal
   Public Property [Cost]() As Decimal
       Get
           Return [_Cost]
       End Get
       Set(ByVal value As Decimal)
           [_Cost] = value
       End Set
    End Property
   Private [_SCGuid] As String
   Public Property [SCGuid]() As String
       Get
           Return [_SCGuid]
       End Get
       Set(ByVal value As String)
           [_SCGuid] = value
       End Set
    End Property
   Private [_FormCode] As String
   Public Property [FormCode]() As String
       Get
           Return [_FormCode]
       End Get
       Set(ByVal value As String)
           [_FormCode] = value
       End Set
    End Property

End Class

Public Class TSCHEDCHECKSDAO

   Public Shared Function getUsingSCID(ByVal SCID As Int32, ByVal connectionString As String, Optional ByVal Limit As Integer = 0) As TSCHEDCHECKS
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSchedChecks Where SCID = "  & SCID, connectionString)
       Else
           dt  = SnagRData.GetDataTable("Select * from tSchedChecks Where SCID = "  & SCID, connectionString)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TSCHEDCHECKS, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getUsingSCID(ByVal SCID As Int32, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0) As TSCHEDCHECKS
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSchedChecks Where SCID = "  & SCID, conn)
       Else
           dt  = SnagRData.GetDataTable("Select * from tSchedChecks Where SCID = "  & SCID, conn)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TSCHEDCHECKS, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0, Optional sql as String = Nothing) As List(Of TSCHEDCHECKS)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, connectionString)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSchedChecks Where " + where, connectionString)
       Else
           dt = SnagRData.GetDataTable("Select * from tSchedChecks Where " + where, connectionString)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TSCHEDCHECKS)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TSCHEDCHECKS, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0, Optional ByVal sql as String = Nothing) As List(Of TSCHEDCHECKS)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, conn)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSchedChecks Where " + where, conn)
       Else
           dt = SnagRData.GetDataTable("Select * from tSchedChecks Where " + where, conn)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TSCHEDCHECKS)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TSCHEDCHECKS, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

    Public Shared Function insert(ByVal tSchedChecks As TSCHEDCHECKS, ByVal connectionString As String) As Boolean

        Dim sSQL As String = "Insert into tSchedChecks (PlotID, [Code], [Description], [srt], [Qty], [Result], [Comment], [UserID], [DateStamp], [DueBy], [PPCGuid], [DateSync], [CantSkip], [Cost], [SCGuid], [FormCode]) Values (" & tSchedChecks.PlotID & ", " & "N'" & tSchedChecks.Code & "'" & ", " & "N'" & tSchedChecks.Description & "'" & ", " & "N'" & tSchedChecks.srt & "'" & ", " & tSchedChecks.Qty & ", " & tSchedChecks.Result & ", " & "N'" & tSchedChecks.Comment & "'" & ", " & tSchedChecks.UserID & ", " & IIf(tSchedChecks.DateStamp = Nothing, "null", "'" & tSchedChecks.DateStamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & IIf(tSchedChecks.DueBy = Nothing, "null", "'" & tSchedChecks.DueBy.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tSchedChecks.PPCGuid & "'" & ", " & IIf(tSchedChecks.DateSync = Nothing, "null", "'" & tSchedChecks.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "'" & tSchedChecks.CantSkip & "'" & ", " & tSchedChecks.Cost & ", " & "N'" & tSchedChecks.SCGuid & "'" & ", " & "N'" & tSchedChecks.FormCode & "'" & ")"
       Return SnagRData.RunSQL(connectionString, sSQL)

   End Function

    Public Shared Function insert(ByVal tSchedChecks As TSCHEDCHECKS, ByVal conn As SqlConnection) As Boolean

        Dim sSQL As String = "Insert into tSchedChecks ([PlotID], [Code], [Description], [srt], [Qty], [Result], [Comment], [UserID], [DateStamp], [DueBy], [PPCGuid], [DateSync], [CantSkip], [Cost], [SCGuid], [FormCode]) Values (" & tSchedChecks.PlotID & ", " & "N'" & tSchedChecks.Code & "'" & ", " & "N'" & tSchedChecks.Description & "'" & ", " & "N'" & tSchedChecks.srt & "'" & ", " & tSchedChecks.Qty & ", " & tSchedChecks.Result & ", " & "N'" & tSchedChecks.Comment & "'" & ", " & tSchedChecks.UserID & ", " & IIf(tSchedChecks.DateStamp = Nothing, "null", "'" & tSchedChecks.DateStamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & IIf(tSchedChecks.DueBy = Nothing, "null", "'" & tSchedChecks.DueBy.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tSchedChecks.PPCGuid & "'" & ", " & IIf(tSchedChecks.DateSync = Nothing, "null", "'" & tSchedChecks.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "'" & tSchedChecks.CantSkip & "'" & ", " & tSchedChecks.Cost & ", " & "N'" & tSchedChecks.SCGuid & "'" & ", " & "N'" & tSchedChecks.FormCode & "'" & ")"
       Return SnagRData.RunSQL(conn, sSQL)

   End Function

    Public Shared Function update(ByVal tSchedChecks As TSCHEDCHECKS, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Update tSchedChecks Set [PlotID] = " & tSchedChecks.PlotID & ", [Code] = N'" & tSchedChecks.Code & "'" & ", [Description] = N'" & tSchedChecks.Description & "'" & ", [srt] = N'" & tSchedChecks.srt & "'" & ", [Qty] = " & tSchedChecks.Qty & ", [Result] = " & tSchedChecks.Result & ", [Comment] = N'" & tSchedChecks.Comment & "'" & ", [UserID] = " & tSchedChecks.UserID & ", [DateStamp] = " & IIf(tSchedChecks.DateStamp = Nothing, "null", "'" & tSchedChecks.DateStamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", [DueBy] = " & IIf(tSchedChecks.DueBy = Nothing, "null", "'" & tSchedChecks.DueBy.ToString("yyyy-MM-dd HH:mm") & "'") & ", [PPCGuid] = N'" & tSchedChecks.PPCGuid & "'" & ", [DateSync] = " & IIf(tSchedChecks.DateSync = Nothing, "null", "'" & tSchedChecks.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [CantSkip] = " & IIf(tSchedChecks.CantSkip = True, "1", "0") & ", [Cost] = " & tSchedChecks.Cost & ", [SCGuid] = N'" & tSchedChecks.SCGuid & "'" & ", [FormCode] = N'" & tSchedChecks.FormCode & "'" & " Where [SCID] = " & tSchedChecks.SCID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function update(ByVal tSchedChecks As TSCHEDCHECKS, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Update tSchedChecks Set [PlotID] = " & tSchedChecks.PlotID & ", [Code] = N'" & tSchedChecks.Code & "'" & ", [Description] = N'" & tSchedChecks.Description & "'" & ", [srt] = N'" & tSchedChecks.srt & "'" & ", [Qty] = " & tSchedChecks.Qty & ", [Result] = " & tSchedChecks.Result & ", [Comment] = N'" & tSchedChecks.Comment & "'" & ", [UserID] = " & tSchedChecks.UserID & ", [DateStamp] = " & IIf(tSchedChecks.DateStamp = Nothing, "null", "'" & tSchedChecks.DateStamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", [DueBy] = " & IIf(tSchedChecks.DueBy = Nothing, "null", "'" & tSchedChecks.DueBy.ToString("yyyy-MM-dd HH:mm") & "'") & ", [PPCGuid] = N'" & tSchedChecks.PPCGuid & "'" & ", [DateSync] = " & IIf(tSchedChecks.DateSync = Nothing, "null", "'" & tSchedChecks.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [CantSkip] = " & IIf(tSchedChecks.CantSkip = True, "1", "0") & ", [Cost] = " & tSchedChecks.Cost & ", [SCGuid] = N'" & tSchedChecks.SCGuid & "'" & ", [FormCode] = N'" & tSchedChecks.FormCode & "'" & " Where [SCID] = " & tSchedChecks.SCID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

    Public Shared Function delete(ByVal tSchedChecks As TSCHEDCHECKS, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Delete from tSchedChecks Where [SCID] = " & tSchedChecks.SCID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function updateBlob(ByVal tSchedChecks As TSCHEDCHECKS, ByVal column As String, ByVal b46Str As String, ByVal connectionString As String) As Boolean

        Dim conn As SqlConnection = New SqlConnection(connectionString)
       conn.Open()

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))

       Dim sSQL As String = "UPDATE tSchedChecks SET " & column & "=@Image WHERE SCID = " & tSchedChecks.SCID
       cmd.CommandText = sSQL
        cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
       cmd.ExecuteNonQuery()

       conn.Close()
       conn.Dispose()

   End Function

    Public Shared Function updateBlob(ByVal tSchedChecks As TSCHEDCHECKS, ByVal column As String, ByVal b46Str As String, ByVal conn As SqlConnection) As Boolean

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))
Dim sSQL As String = "UPDATE tSchedChecks SET " & column & "=@Image WHERE SCID = " & tSchedChecks.SCID
cmd.CommandText = sSQL
cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
cmd.ExecuteNonQuery()

   End Function

    Public Shared Function delete(ByVal tSchedChecks As TSCHEDCHECKS, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Delete from tSchedChecks Where [SCID] = " & tSchedChecks.SCID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

   Private Shared Function loadFromResultSet(ByVal obj As TSCHEDCHECKS, ByVal resultset As DataRow) As TSCHEDCHECKS
      obj.SCID = ProcessNull.GetInt32(resultset.Item("SCID"))
      obj.PlotID = ProcessNull.GetInt32(resultset.Item("PlotID"))
      obj.Code = ProcessNull.GetString(resultset.Item("Code"))
      obj.Description = ProcessNull.GetString(resultset.Item("Description"))
      obj.srt = ProcessNull.GetString(resultset.Item("srt"))
      obj.Qty = ProcessNull.GetDouble(resultset.Item("Qty"))
      obj.Result = ProcessNull.GetInt32(resultset.Item("Result"))
      obj.Comment = ProcessNull.GetString(resultset.Item("Comment"))
      obj.UserID = ProcessNull.GetInt32(resultset.Item("UserID"))
      obj.DateStamp = ProcessNull.GetDateTime(resultset.Item("DateStamp"))
      obj.DueBy = ProcessNull.GetDateTime(resultset.Item("DueBy"))
      obj.PPCGuid = ProcessNull.GetString(resultset.Item("PPCGuid"))
      obj.DateSync = ProcessNull.GetDateTime(resultset.Item("DateSync"))
       obj.CantSkip = ProcessNull.GetBoolean(resultset.Item("CantSkip"))
      obj.Cost = ProcessNull.GetDouble(resultset.Item("Cost"))
      obj.SCGuid = ProcessNull.GetString(resultset.Item("SCGuid"))
      obj.FormCode = ProcessNull.GetString(resultset.Item("FormCode"))

       Return obj

   End Function

End Class

