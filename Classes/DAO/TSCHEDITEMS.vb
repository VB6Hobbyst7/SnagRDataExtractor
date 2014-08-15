Imports SnagRWeb_Project.SnagRData
Imports System.Data.SqlClient

Public Class TSCHEDITEMS

   Private [_Code] As String
   Public Property [Code]() As String
       Get
           Return [_Code]
       End Get
       Set(ByVal value As String)
           [_Code] = value
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
   Private [_SetRef] As String
   Public Property [SetRef]() As String
       Get
           Return [_SetRef]
       End Get
       Set(ByVal value As String)
           [_SetRef] = value
       End Set
    End Property
   Private [_Categ] As String
   Public Property [Categ]() As String
       Get
           Return [_Categ]
       End Get
       Set(ByVal value As String)
           [_Categ] = value
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
   Private [_Qty] As Int32
   Public Property [Qty]() As Int32
       Get
           Return [_Qty]
       End Get
       Set(ByVal value As Int32)
           [_Qty] = value
       End Set
    End Property
   Private [_AddSnag] As Boolean
   Public Property [AddSnag]() As Boolean
       Get
           Return [_AddSnag]
       End Get
       Set(ByVal value As Boolean)
           [_AddSnag] = value
       End Set
    End Property
   Private [_SDCode] As String
   Public Property [SDCode]() As String
       Get
           Return [_SDCode]
       End Get
       Set(ByVal value As String)
           [_SDCode] = value
       End Set
    End Property
   Private [_SDID] As Int32
   Public Property [SDID]() As Int32
       Get
           Return [_SDID]
       End Get
       Set(ByVal value As Int32)
           [_SDID] = value
       End Set
    End Property
   Private [_DaysAfterStart] As Int32
   Public Property [DaysAfterStart]() As Int32
       Get
           Return [_DaysAfterStart]
       End Get
       Set(ByVal value As Int32)
           [_DaysAfterStart] = value
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
   Private [_EditQty] As Boolean
   Public Property [EditQty]() As Boolean
       Get
           Return [_EditQty]
       End Get
       Set(ByVal value As Boolean)
           [_EditQty] = value
       End Set
    End Property
   Private [_Percent] As Boolean
   Public Property [Percent]() As Boolean
       Get
           Return [_Percent]
       End Get
       Set(ByVal value As Boolean)
           [_Percent] = value
       End Set
    End Property
   Private [_Duration] As Int32
   Public Property [Duration]() As Int32
       Get
           Return [_Duration]
       End Get
       Set(ByVal value As Int32)
           [_Duration] = value
       End Set
    End Property
   Private [_ReadOnly] As Boolean
   Public Property [ReadOnly]() As Boolean
       Get
           Return [_ReadOnly]
       End Get
       Set(ByVal value As Boolean)
           [_ReadOnly] = value
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
   Private [_AllowAdhocChecks] As Boolean
   Public Property [AllowAdhocChecks]() As Boolean
       Get
           Return [_AllowAdhocChecks]
       End Get
       Set(ByVal value As Boolean)
           [_AllowAdhocChecks] = value
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

Public Class TSCHEDITEMSDAO

   Public Shared Function getUsingCode(ByVal Code As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0) As TSCHEDITEMS
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSchedItems Where Code = N'"  & Code & "'", connectionString)
       Else
           dt  = SnagRData.GetDataTable("Select * from tSchedItems Where Code = N'"  & Code & "'", connectionString)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TSCHEDITEMS, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getUsingCode(ByVal Code As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0) As TSCHEDITEMS
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSchedItems Where Code = N'"  & Code & "'", conn)
       Else
           dt  = SnagRData.GetDataTable("Select * from tSchedItems Where Code = N'"  & Code & "'", conn)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TSCHEDITEMS, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0, Optional sql as String = Nothing) As List(Of TSCHEDITEMS)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, connectionString)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSchedItems Where " + where, connectionString)
       Else
           dt = SnagRData.GetDataTable("Select * from tSchedItems Where " + where, connectionString)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TSCHEDITEMS)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TSCHEDITEMS, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0, Optional ByVal sql as String = Nothing) As List(Of TSCHEDITEMS)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, conn)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSchedItems Where " + where, conn)
       Else
           dt = SnagRData.GetDataTable("Select * from tSchedItems Where " + where, conn)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TSCHEDITEMS)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TSCHEDITEMS, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

    Public Shared Function insert(ByVal tSchedItems As TSCHEDITEMS, ByVal connectionString As String) As Boolean

        Dim sSQL As String = "Insert into tSchedItems (Code, [SchedID], [SetRef], [Categ], [Description], [srt], [Qty], [AddSnag], [SDCode], [SDID], [DaysAfterStart], [DateSync], [EditQty], [Percent], [Duration], [ReadOnly], [CantSkip], [AllowAdhocChecks], [Cost], [FormCode]) Values (" & "N'" & tSchedItems.Code & "'" & ", " & tSchedItems.SchedID & ", " & "N'" & tSchedItems.SetRef & "'" & ", " & "N'" & tSchedItems.Categ & "'" & ", " & "N'" & tSchedItems.Description & "'" & ", " & "N'" & tSchedItems.srt & "'" & ", " & tSchedItems.Qty & ", " & "'" & tSchedItems.AddSnag & "'" & ", " & "N'" & tSchedItems.SDCode & "'" & ", " & tSchedItems.SDID & ", " & tSchedItems.DaysAfterStart & ", " & IIf(tSchedItems.DateSync = Nothing, "null", "'" & tSchedItems.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "'" & tSchedItems.EditQty & "'" & ", " & "'" & tSchedItems.Percent & "'" & ", " & tSchedItems.Duration & ", " & "'" & tSchedItems.ReadOnly & "'" & ", " & "'" & tSchedItems.CantSkip & "'" & ", " & "'" & tSchedItems.AllowAdhocChecks & "'" & ", " & tSchedItems.Cost & ", " & "N'" & tSchedItems.FormCode & "'" & ")"
       Return SnagRData.RunSQL(connectionString, sSQL)

   End Function

    Public Shared Function insert(ByVal tSchedItems As TSCHEDITEMS, ByVal conn As SqlConnection) As Boolean

        Dim sSQL As String = "Insert into tSchedItems ([Code], [SchedID], [SetRef], [Categ], [Description], [srt], [Qty], [AddSnag], [SDCode], [SDID], [DaysAfterStart], [DateSync], [EditQty], [Percent], [Duration], [ReadOnly], [CantSkip], [AllowAdhocChecks], [Cost], [FormCode]) Values (" & "N'" & tSchedItems.Code & "'" & ", " & tSchedItems.SchedID & ", " & "N'" & tSchedItems.SetRef & "'" & ", " & "N'" & tSchedItems.Categ & "'" & ", " & "N'" & tSchedItems.Description & "'" & ", " & "N'" & tSchedItems.srt & "'" & ", " & tSchedItems.Qty & ", " & "'" & tSchedItems.AddSnag & "'" & ", " & "N'" & tSchedItems.SDCode & "'" & ", " & tSchedItems.SDID & ", " & tSchedItems.DaysAfterStart & ", " & IIf(tSchedItems.DateSync = Nothing, "null", "'" & tSchedItems.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "'" & tSchedItems.EditQty & "'" & ", " & "'" & tSchedItems.Percent & "'" & ", " & tSchedItems.Duration & ", " & "'" & tSchedItems.ReadOnly & "'" & ", " & "'" & tSchedItems.CantSkip & "'" & ", " & "'" & tSchedItems.AllowAdhocChecks & "'" & ", " & tSchedItems.Cost & ", " & "N'" & tSchedItems.FormCode & "'" & ")"
       Return SnagRData.RunSQL(conn, sSQL)

   End Function

    Public Shared Function update(ByVal tSchedItems As TSCHEDITEMS, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Update tSchedItems Set [SchedID] = " & tSchedItems.SchedID & ", [SetRef] = N'" & tSchedItems.SetRef & "'" & ", [Categ] = N'" & tSchedItems.Categ & "'" & ", [Description] = N'" & tSchedItems.Description & "'" & ", [srt] = N'" & tSchedItems.srt & "'" & ", [Qty] = " & tSchedItems.Qty & ", [AddSnag] = " & IIf(tSchedItems.AddSnag = True, "1", "0") & ", [SDCode] = N'" & tSchedItems.SDCode & "'" & ", [SDID] = " & tSchedItems.SDID & ", [DaysAfterStart] = " & tSchedItems.DaysAfterStart & ", [DateSync] = " & IIf(tSchedItems.DateSync = Nothing, "null", "'" & tSchedItems.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [EditQty] = " & IIf(tSchedItems.EditQty = True, "1", "0") & ", [Percent] = " & IIf(tSchedItems.Percent = True, "1", "0") & ", [Duration] = " & tSchedItems.Duration & ", [ReadOnly] = " & IIf(tSchedItems.ReadOnly = True, "1", "0") & ", [CantSkip] = " & IIf(tSchedItems.CantSkip = True, "1", "0") & ", [AllowAdhocChecks] = " & IIf(tSchedItems.AllowAdhocChecks = True, "1", "0") & ", [Cost] = " & tSchedItems.Cost & ", [FormCode] = N'" & tSchedItems.FormCode & "'" & " Where [Code] = N'" & tSchedItems.Code & "'"
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function update(ByVal tSchedItems As TSCHEDITEMS, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Update tSchedItems Set [SchedID] = " & tSchedItems.SchedID & ", [SetRef] = N'" & tSchedItems.SetRef & "'" & ", [Categ] = N'" & tSchedItems.Categ & "'" & ", [Description] = N'" & tSchedItems.Description & "'" & ", [srt] = N'" & tSchedItems.srt & "'" & ", [Qty] = " & tSchedItems.Qty & ", [AddSnag] = " & IIf(tSchedItems.AddSnag = True, "1", "0") & ", [SDCode] = N'" & tSchedItems.SDCode & "'" & ", [SDID] = " & tSchedItems.SDID & ", [DaysAfterStart] = " & tSchedItems.DaysAfterStart & ", [DateSync] = " & IIf(tSchedItems.DateSync = Nothing, "null", "'" & tSchedItems.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [EditQty] = " & IIf(tSchedItems.EditQty = True, "1", "0") & ", [Percent] = " & IIf(tSchedItems.Percent = True, "1", "0") & ", [Duration] = " & tSchedItems.Duration & ", [ReadOnly] = " & IIf(tSchedItems.ReadOnly = True, "1", "0") & ", [CantSkip] = " & IIf(tSchedItems.CantSkip = True, "1", "0") & ", [AllowAdhocChecks] = " & IIf(tSchedItems.AllowAdhocChecks = True, "1", "0") & ", [Cost] = " & tSchedItems.Cost & ", [FormCode] = N'" & tSchedItems.FormCode & "'" & " Where [Code] = N'" & tSchedItems.Code & "'"
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

    Public Shared Function delete(ByVal tSchedItems As TSCHEDITEMS, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Delete from tSchedItems Where [Code] = N'" & tSchedItems.Code & "'"
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function updateBlob(ByVal tSchedItems As TSCHEDITEMS, ByVal column As String, ByVal b46Str As String, ByVal connectionString As String) As Boolean

        Dim conn As SqlConnection = New SqlConnection(connectionString)
       conn.Open()

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))

       Dim sSQL As String = "UPDATE tSchedItems SET " & column & "=@Image WHERE Code = " & tSchedItems.Code
       cmd.CommandText = sSQL
        cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
       cmd.ExecuteNonQuery()

       conn.Close()
       conn.Dispose()

   End Function

    Public Shared Function updateBlob(ByVal tSchedItems As TSCHEDITEMS, ByVal column As String, ByVal b46Str As String, ByVal conn As SqlConnection) As Boolean

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))
Dim sSQL As String = "UPDATE tSchedItems SET " & column & "=@Image WHERE Code = " & tSchedItems.Code
cmd.CommandText = sSQL
cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
cmd.ExecuteNonQuery()

   End Function

    Public Shared Function delete(ByVal tSchedItems As TSCHEDITEMS, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Delete from tSchedItems Where [Code] = N'" & tSchedItems.Code & "'"
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

   Private Shared Function loadFromResultSet(ByVal obj As TSCHEDITEMS, ByVal resultset As DataRow) As TSCHEDITEMS
      obj.Code = ProcessNull.GetString(resultset.Item("Code"))
      obj.SchedID = ProcessNull.GetInt32(resultset.Item("SchedID"))
      obj.SetRef = ProcessNull.GetString(resultset.Item("SetRef"))
      obj.Categ = ProcessNull.GetString(resultset.Item("Categ"))
      obj.Description = ProcessNull.GetString(resultset.Item("Description"))
      obj.srt = ProcessNull.GetString(resultset.Item("srt"))
      obj.Qty = ProcessNull.GetInt32(resultset.Item("Qty"))
       obj.AddSnag = ProcessNull.GetBoolean(resultset.Item("AddSnag"))
      obj.SDCode = ProcessNull.GetString(resultset.Item("SDCode"))
      obj.SDID = ProcessNull.GetInt32(resultset.Item("SDID"))
      obj.DaysAfterStart = ProcessNull.GetInt32(resultset.Item("DaysAfterStart"))
      obj.DateSync = ProcessNull.GetDateTime(resultset.Item("DateSync"))
       obj.EditQty = ProcessNull.GetBoolean(resultset.Item("EditQty"))
       obj.Percent = ProcessNull.GetBoolean(resultset.Item("Percent"))
      obj.Duration = ProcessNull.GetInt32(resultset.Item("Duration"))
       obj.ReadOnly = ProcessNull.GetBoolean(resultset.Item("ReadOnly"))
       obj.CantSkip = ProcessNull.GetBoolean(resultset.Item("CantSkip"))
       obj.AllowAdhocChecks = ProcessNull.GetBoolean(resultset.Item("AllowAdhocChecks"))
      obj.Cost = ProcessNull.GetDouble(resultset.Item("Cost"))
      obj.FormCode = ProcessNull.GetString(resultset.Item("FormCode"))

       Return obj

   End Function

End Class

