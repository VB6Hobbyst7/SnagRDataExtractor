Imports SnagRWeb_Project.SnagRData
Imports System.Data.SqlClient

Public Class TFORMCHECKS

   Private [_FCID] As Int32
   Public Property [FCID]() As Int32
       Get
           Return [_FCID]
       End Get
       Set(ByVal value As Int32)
           [_FCID] = value
       End Set
    End Property
   Private [_SCID] As Int32
   Public Property [SCID]() As Int32
       Get
           Return [_SCID]
       End Get
       Set(ByVal value As Int32)
           [_SCID] = value
       End Set
    End Property
   Private [_CheckCode] As String
   Public Property [CheckCode]() As String
       Get
           Return [_CheckCode]
       End Get
       Set(ByVal value As String)
           [_CheckCode] = value
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
   Private [_Result] As Int32
   Public Property [Result]() As Int32
       Get
           Return [_Result]
       End Get
       Set(ByVal value As Int32)
           [_Result] = value
       End Set
    End Property
   Private [_ResultText] As String
   Public Property [ResultText]() As String
       Get
           Return [_ResultText]
       End Get
       Set(ByVal value As String)
           [_ResultText] = value
       End Set
    End Property
   Private [_ResultImg] As String
   Public Property [ResultImg]() As String
       Get
           Return [_ResultImg]
       End Get
       Set(ByVal value As String)
           [_ResultImg] = value
       End Set
    End Property
   Private [_FIAID] As Int32
   Public Property [FIAID]() As Int32
       Get
           Return [_FIAID]
       End Get
       Set(ByVal value As Int32)
           [_FIAID] = value
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
   Private [_EmailUserID] As Int32
   Public Property [EmailUserID]() As Int32
       Get
           Return [_EmailUserID]
       End Get
       Set(ByVal value As Int32)
           [_EmailUserID] = value
       End Set
    End Property
   Private [_AnsType] As String
   Public Property [AnsType]() As String
       Get
           Return [_AnsType]
       End Get
       Set(ByVal value As String)
           [_AnsType] = value
       End Set
    End Property
   Private [_Mandatory] As Boolean
   Public Property [Mandatory]() As Boolean
       Get
           Return [_Mandatory]
       End Get
       Set(ByVal value As Boolean)
           [_Mandatory] = value
       End Set
    End Property
   Private [_EmailUser] As Boolean
   Public Property [EmailUser]() As Boolean
       Get
           Return [_EmailUser]
       End Get
       Set(ByVal value As Boolean)
           [_EmailUser] = value
       End Set
    End Property
   Private [_MultiChoice] As Boolean
   Public Property [MultiChoice]() As Boolean
       Get
           Return [_MultiChoice]
       End Get
       Set(ByVal value As Boolean)
           [_MultiChoice] = value
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
   Private [_PageNo] As Int32
   Public Property [PageNo]() As Int32
       Get
           Return [_PageNo]
       End Get
       Set(ByVal value As Int32)
           [_PageNo] = value
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
   Private [_ListCode] As String
   Public Property [ListCode]() As String
       Get
           Return [_ListCode]
       End Get
       Set(ByVal value As String)
           [_ListCode] = value
       End Set
    End Property
   Private [_LinkCheckCode] As String
   Public Property [LinkCheckCode]() As String
       Get
           Return [_LinkCheckCode]
       End Get
       Set(ByVal value As String)
           [_LinkCheckCode] = value
       End Set
    End Property
   Private [_FCGUID] As String
   Public Property [FCGUID]() As String
       Get
           Return [_FCGUID]
       End Get
       Set(ByVal value As String)
           [_FCGUID] = value
       End Set
    End Property
   Private [_AutoSnagged] As Boolean
   Public Property [AutoSnagged]() As Boolean
       Get
           Return [_AutoSnagged]
       End Get
       Set(ByVal value As Boolean)
           [_AutoSnagged] = value
       End Set
    End Property

End Class

Public Class TFORMCHECKSDAO

   Public Shared Function getUsingFCID(ByVal FCID As Int32, ByVal connectionString As String, Optional ByVal Limit As Integer = 0) As TFORMCHECKS
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormChecks Where FCID = "  & FCID, connectionString)
       Else
           dt  = SnagRData.GetDataTable("Select * from tFormChecks Where FCID = "  & FCID, connectionString)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TFORMCHECKS, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getUsingFCID(ByVal FCID As Int32, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0) As TFORMCHECKS
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormChecks Where FCID = "  & FCID, conn)
       Else
           dt  = SnagRData.GetDataTable("Select * from tFormChecks Where FCID = "  & FCID, conn)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TFORMCHECKS, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0, Optional sql as String = Nothing) As List(Of TFORMCHECKS)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, connectionString)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormChecks Where " + where, connectionString)
       Else
           dt = SnagRData.GetDataTable("Select * from tFormChecks Where " + where, connectionString)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TFORMCHECKS)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TFORMCHECKS, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0, Optional ByVal sql as String = Nothing) As List(Of TFORMCHECKS)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, conn)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormChecks Where " + where, conn)
       Else
           dt = SnagRData.GetDataTable("Select * from tFormChecks Where " + where, conn)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TFORMCHECKS)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TFORMCHECKS, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

    Public Shared Function insert(ByVal tFormChecks As TFORMCHECKS, ByVal connectionString As String) As Boolean

        Dim sSQL As String = "Insert into tFormChecks (SCID, [CheckCode], [FormCode], [Categ], [Description], [srt], [Result], [ResultText], [ResultImg], [FIAID], [UserID], [DateStamp], [EmailUserID], [AnsType], [Mandatory], [EmailUser], [MultiChoice], [SCGUID], [PageNo], [DateSync], [ListCode], [LinkCheckCode], [FCGUID], [AutoSnagged]) Values (" & tFormChecks.SCID & ", " & "N'" & tFormChecks.CheckCode & "'" & ", " & "N'" & tFormChecks.FormCode & "'" & ", " & "N'" & tFormChecks.Categ & "'" & ", " & "N'" & tFormChecks.Description & "'" & ", " & "N'" & tFormChecks.srt & "'" & ", " & tFormChecks.Result & ", " & "N'" & tFormChecks.ResultText & "'" & ", " & "null" & ", " & tFormChecks.FIAID & ", " & tFormChecks.UserID & ", " & IIf(tFormChecks.DateStamp = Nothing, "null", "'" & tFormChecks.DateStamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & tFormChecks.EmailUserID & ", " & "N'" & tFormChecks.AnsType & "'" & ", " & "'" & tFormChecks.Mandatory & "'" & ", " & "'" & tFormChecks.EmailUser & "'" & ", " & "'" & tFormChecks.MultiChoice & "'" & ", " & "N'" & tFormChecks.SCGUID & "'" & ", " & tFormChecks.PageNo & ", " & IIf(tFormChecks.DateSync = Nothing, "null", "'" & tFormChecks.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tFormChecks.ListCode & "'" & ", " & "N'" & tFormChecks.LinkCheckCode & "'" & ", " & "N'" & tFormChecks.FCGUID & "'" & ", " & "'" & tFormChecks.AutoSnagged & "'" & ")"
       Return SnagRData.RunSQL(connectionString, sSQL)

   End Function

    Public Shared Function insert(ByVal tFormChecks As TFORMCHECKS, ByVal conn As SqlConnection) As Boolean

        Dim sSQL As String = "Insert into tFormChecks ([SCID], [CheckCode], [FormCode], [Categ], [Description], [srt], [Result], [ResultText], [ResultImg], [FIAID], [UserID], [DateStamp], [EmailUserID], [AnsType], [Mandatory], [EmailUser], [MultiChoice], [SCGUID], [PageNo], [DateSync], [ListCode], [LinkCheckCode], [FCGUID], [AutoSnagged]) Values (" & tFormChecks.SCID & ", " & "N'" & tFormChecks.CheckCode & "'" & ", " & "N'" & tFormChecks.FormCode & "'" & ", " & "N'" & tFormChecks.Categ & "'" & ", " & "N'" & tFormChecks.Description & "'" & ", " & "N'" & tFormChecks.srt & "'" & ", " & tFormChecks.Result & ", " & "N'" & tFormChecks.ResultText & "'" & ", " & "null" & ", " & tFormChecks.FIAID & ", " & tFormChecks.UserID & ", " & IIf(tFormChecks.DateStamp = Nothing, "null", "'" & tFormChecks.DateStamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & tFormChecks.EmailUserID & ", " & "N'" & tFormChecks.AnsType & "'" & ", " & "'" & tFormChecks.Mandatory & "'" & ", " & "'" & tFormChecks.EmailUser & "'" & ", " & "'" & tFormChecks.MultiChoice & "'" & ", " & "N'" & tFormChecks.SCGUID & "'" & ", " & tFormChecks.PageNo & ", " & IIf(tFormChecks.DateSync = Nothing, "null", "'" & tFormChecks.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tFormChecks.ListCode & "'" & ", " & "N'" & tFormChecks.LinkCheckCode & "'" & ", " & "N'" & tFormChecks.FCGUID & "'" & ", " & "'" & tFormChecks.AutoSnagged & "'" & ")"
       Return SnagRData.RunSQL(conn, sSQL)

   End Function

    Public Shared Function update(ByVal tFormChecks As TFORMCHECKS, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Update tFormChecks Set [SCID] = " & tFormChecks.SCID & ", [CheckCode] = N'" & tFormChecks.CheckCode & "'" & ", [FormCode] = N'" & tFormChecks.FormCode & "'" & ", [Categ] = N'" & tFormChecks.Categ & "'" & ", [Description] = N'" & tFormChecks.Description & "'" & ", [srt] = N'" & tFormChecks.srt & "'" & ", [Result] = " & tFormChecks.Result & ", [ResultText] = N'" & tFormChecks.ResultText & "'" & ", [FIAID] = " & tFormChecks.FIAID & ", [UserID] = " & tFormChecks.UserID & ", [DateStamp] = " & IIf(tFormChecks.DateStamp = Nothing, "null", "'" & tFormChecks.DateStamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", [EmailUserID] = " & tFormChecks.EmailUserID & ", [AnsType] = N'" & tFormChecks.AnsType & "'" & ", [Mandatory] = " & IIf(tFormChecks.Mandatory = True, "1", "0") & ", [EmailUser] = " & IIf(tFormChecks.EmailUser = True, "1", "0") & ", [MultiChoice] = " & IIf(tFormChecks.MultiChoice = True, "1", "0") & ", [SCGUID] = N'" & tFormChecks.SCGUID & "'" & ", [PageNo] = " & tFormChecks.PageNo & ", [DateSync] = " & IIf(tFormChecks.DateSync = Nothing, "null", "'" & tFormChecks.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [ListCode] = N'" & tFormChecks.ListCode & "'" & ", [LinkCheckCode] = N'" & tFormChecks.LinkCheckCode & "'" & ", [FCGUID] = N'" & tFormChecks.FCGUID & "'" & ", [AutoSnagged] = " & IIf(tFormChecks.AutoSnagged = True, "1", "0") & " Where [FCID] = " & tFormChecks.FCID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function update(ByVal tFormChecks As TFORMCHECKS, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Update tFormChecks Set [SCID] = " & tFormChecks.SCID & ", [CheckCode] = N'" & tFormChecks.CheckCode & "'" & ", [FormCode] = N'" & tFormChecks.FormCode & "'" & ", [Categ] = N'" & tFormChecks.Categ & "'" & ", [Description] = N'" & tFormChecks.Description & "'" & ", [srt] = N'" & tFormChecks.srt & "'" & ", [Result] = " & tFormChecks.Result & ", [ResultText] = N'" & tFormChecks.ResultText & "'" & ", [FIAID] = " & tFormChecks.FIAID & ", [UserID] = " & tFormChecks.UserID & ", [DateStamp] = " & IIf(tFormChecks.DateStamp = Nothing, "null", "'" & tFormChecks.DateStamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", [EmailUserID] = " & tFormChecks.EmailUserID & ", [AnsType] = N'" & tFormChecks.AnsType & "'" & ", [Mandatory] = " & IIf(tFormChecks.Mandatory = True, "1", "0") & ", [EmailUser] = " & IIf(tFormChecks.EmailUser = True, "1", "0") & ", [MultiChoice] = " & IIf(tFormChecks.MultiChoice = True, "1", "0") & ", [SCGUID] = N'" & tFormChecks.SCGUID & "'" & ", [PageNo] = " & tFormChecks.PageNo & ", [DateSync] = " & IIf(tFormChecks.DateSync = Nothing, "null", "'" & tFormChecks.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [ListCode] = N'" & tFormChecks.ListCode & "'" & ", [LinkCheckCode] = N'" & tFormChecks.LinkCheckCode & "'" & ", [FCGUID] = N'" & tFormChecks.FCGUID & "'" & ", [AutoSnagged] = " & IIf(tFormChecks.AutoSnagged = True, "1", "0") & " Where [FCID] = " & tFormChecks.FCID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

    Public Shared Function delete(ByVal tFormChecks As TFORMCHECKS, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Delete from tFormChecks Where [FCID] = " & tFormChecks.FCID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function updateBlob(ByVal tFormChecks As TFORMCHECKS, ByVal column As String, ByVal b46Str As String, ByVal connectionString As String) As Boolean

        Dim conn As SqlConnection = New SqlConnection(connectionString)
       conn.Open()

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))

       Dim sSQL As String = "UPDATE tFormChecks SET " & column & "=@Image WHERE FCID = " & tFormChecks.FCID
       cmd.CommandText = sSQL
        cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
       cmd.ExecuteNonQuery()

       conn.Close()
       conn.Dispose()

   End Function

    Public Shared Function updateBlob(ByVal tFormChecks As TFORMCHECKS, ByVal column As String, ByVal b46Str As String, ByVal conn As SqlConnection) As Boolean

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))
Dim sSQL As String = "UPDATE tFormChecks SET " & column & "=@Image WHERE FCID = " & tFormChecks.FCID
cmd.CommandText = sSQL
cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
cmd.ExecuteNonQuery()

   End Function

    Public Shared Function delete(ByVal tFormChecks As TFORMCHECKS, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Delete from tFormChecks Where [FCID] = " & tFormChecks.FCID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

   Private Shared Function loadFromResultSet(ByVal obj As TFORMCHECKS, ByVal resultset As DataRow) As TFORMCHECKS
      obj.FCID = ProcessNull.GetInt32(resultset.Item("FCID"))
      obj.SCID = ProcessNull.GetInt32(resultset.Item("SCID"))
      obj.CheckCode = ProcessNull.GetString(resultset.Item("CheckCode"))
      obj.FormCode = ProcessNull.GetString(resultset.Item("FormCode"))
      obj.Categ = ProcessNull.GetString(resultset.Item("Categ"))
      obj.Description = ProcessNull.GetString(resultset.Item("Description"))
      obj.srt = ProcessNull.GetString(resultset.Item("srt"))
      obj.Result = ProcessNull.GetInt32(resultset.Item("Result"))
      obj.ResultText = ProcessNull.GetString(resultset.Item("ResultText"))
     If Not IsDBNull(resultset.Item("ResultImg")) Then
         obj.ResultImg = Convert.ToBase64String(resultset.Item("ResultImg"))
      End If
      obj.FIAID = ProcessNull.GetInt32(resultset.Item("FIAID"))
      obj.UserID = ProcessNull.GetInt32(resultset.Item("UserID"))
      obj.DateStamp = ProcessNull.GetDateTime(resultset.Item("DateStamp"))
      obj.EmailUserID = ProcessNull.GetInt32(resultset.Item("EmailUserID"))
      obj.AnsType = ProcessNull.GetString(resultset.Item("AnsType"))
       obj.Mandatory = ProcessNull.GetBoolean(resultset.Item("Mandatory"))
       obj.EmailUser = ProcessNull.GetBoolean(resultset.Item("EmailUser"))
       obj.MultiChoice = ProcessNull.GetBoolean(resultset.Item("MultiChoice"))
      obj.SCGUID = ProcessNull.GetString(resultset.Item("SCGUID"))
      obj.PageNo = ProcessNull.GetInt32(resultset.Item("PageNo"))
      obj.DateSync = ProcessNull.GetDateTime(resultset.Item("DateSync"))
      obj.ListCode = ProcessNull.GetString(resultset.Item("ListCode"))
      obj.LinkCheckCode = ProcessNull.GetString(resultset.Item("LinkCheckCode"))
      obj.FCGUID = ProcessNull.GetString(resultset.Item("FCGUID"))
       obj.AutoSnagged = ProcessNull.GetBoolean(resultset.Item("AutoSnagged"))

       Return obj

   End Function

End Class

