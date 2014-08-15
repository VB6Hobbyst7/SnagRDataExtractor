Imports SnagRWeb_Project.SnagRData
Imports System.Data.SqlClient

Public Class TFORMITEMS

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
   Private [_ExtRef] As String
   Public Property [ExtRef]() As String
       Get
           Return [_ExtRef]
       End Get
       Set(ByVal value As String)
           [_ExtRef] = value
       End Set
    End Property
   Private [_AddYtot] As Boolean
   Public Property [AddYtot]() As Boolean
       Get
           Return [_AddYtot]
       End Get
       Set(ByVal value As Boolean)
           [_AddYtot] = value
       End Set
    End Property
   Private [_AddNtot] As Boolean
   Public Property [AddNtot]() As Boolean
       Get
           Return [_AddNtot]
       End Get
       Set(ByVal value As Boolean)
           [_AddNtot] = value
       End Set
    End Property
   Private [_MinRole] As Int32
   Public Property [MinRole]() As Int32
       Get
           Return [_MinRole]
       End Get
       Set(ByVal value As Int32)
           [_MinRole] = value
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

End Class

Public Class TFORMITEMSDAO

   Public Shared Function getUsingCheckCode(ByVal CheckCode As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0) As TFORMITEMS
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormItems Where CheckCode = N'"  & CheckCode & "'", connectionString)
       Else
           dt  = SnagRData.GetDataTable("Select * from tFormItems Where CheckCode = N'"  & CheckCode & "'", connectionString)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TFORMITEMS, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getUsingCheckCode(ByVal CheckCode As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0) As TFORMITEMS
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormItems Where CheckCode = N'"  & CheckCode & "'", conn)
       Else
           dt  = SnagRData.GetDataTable("Select * from tFormItems Where CheckCode = N'"  & CheckCode & "'", conn)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TFORMITEMS, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0, Optional sql as String = Nothing) As List(Of TFORMITEMS)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, connectionString)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormItems Where " + where, connectionString)
       Else
           dt = SnagRData.GetDataTable("Select * from tFormItems Where " + where, connectionString)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TFORMITEMS)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TFORMITEMS, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0, Optional ByVal sql as String = Nothing) As List(Of TFORMITEMS)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, conn)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormItems Where " + where, conn)
       Else
           dt = SnagRData.GetDataTable("Select * from tFormItems Where " + where, conn)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TFORMITEMS)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TFORMITEMS, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

    Public Shared Function insert(ByVal tFormItems As TFORMITEMS, ByVal connectionString As String) As Boolean

        Dim sSQL As String = "Insert into tFormItems (CheckCode, [FormCode], [Categ], [Description], [srt], [AnsType], [Mandatory], [EmailUser], [MultiChoice], [ExtRef], [AddYtot], [AddNtot], [MinRole], [PageNo], [DateSync], [ListCode], [LinkCheckCode]) Values (" & "N'" & tFormItems.CheckCode & "'" & ", " & "N'" & tFormItems.FormCode & "'" & ", " & "N'" & tFormItems.Categ & "'" & ", " & "N'" & tFormItems.Description & "'" & ", " & "N'" & tFormItems.srt & "'" & ", " & "N'" & tFormItems.AnsType & "'" & ", " & "'" & tFormItems.Mandatory & "'" & ", " & "'" & tFormItems.EmailUser & "'" & ", " & "'" & tFormItems.MultiChoice & "'" & ", " & "N'" & tFormItems.ExtRef & "'" & ", " & "'" & tFormItems.AddYtot & "'" & ", " & "'" & tFormItems.AddNtot & "'" & ", " & tFormItems.MinRole & ", " & tFormItems.PageNo & ", " & IIf(tFormItems.DateSync = Nothing, "null", "'" & tFormItems.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tFormItems.ListCode & "'" & ", " & "N'" & tFormItems.LinkCheckCode & "'" & ")"
       Return SnagRData.RunSQL(connectionString, sSQL)

   End Function

    Public Shared Function insert(ByVal tFormItems As TFORMITEMS, ByVal conn As SqlConnection) As Boolean

        Dim sSQL As String = "Insert into tFormItems ([CheckCode], [FormCode], [Categ], [Description], [srt], [AnsType], [Mandatory], [EmailUser], [MultiChoice], [ExtRef], [AddYtot], [AddNtot], [MinRole], [PageNo], [DateSync], [ListCode], [LinkCheckCode]) Values (" & "N'" & tFormItems.CheckCode & "'" & ", " & "N'" & tFormItems.FormCode & "'" & ", " & "N'" & tFormItems.Categ & "'" & ", " & "N'" & tFormItems.Description & "'" & ", " & "N'" & tFormItems.srt & "'" & ", " & "N'" & tFormItems.AnsType & "'" & ", " & "'" & tFormItems.Mandatory & "'" & ", " & "'" & tFormItems.EmailUser & "'" & ", " & "'" & tFormItems.MultiChoice & "'" & ", " & "N'" & tFormItems.ExtRef & "'" & ", " & "'" & tFormItems.AddYtot & "'" & ", " & "'" & tFormItems.AddNtot & "'" & ", " & tFormItems.MinRole & ", " & tFormItems.PageNo & ", " & IIf(tFormItems.DateSync = Nothing, "null", "'" & tFormItems.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tFormItems.ListCode & "'" & ", " & "N'" & tFormItems.LinkCheckCode & "'" & ")"
       Return SnagRData.RunSQL(conn, sSQL)

   End Function

    Public Shared Function update(ByVal tFormItems As TFORMITEMS, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Update tFormItems Set [FormCode] = N'" & tFormItems.FormCode & "'" & ", [Categ] = N'" & tFormItems.Categ & "'" & ", [Description] = N'" & tFormItems.Description & "'" & ", [srt] = N'" & tFormItems.srt & "'" & ", [AnsType] = N'" & tFormItems.AnsType & "'" & ", [Mandatory] = " & IIf(tFormItems.Mandatory = True, "1", "0") & ", [EmailUser] = " & IIf(tFormItems.EmailUser = True, "1", "0") & ", [MultiChoice] = " & IIf(tFormItems.MultiChoice = True, "1", "0") & ", [ExtRef] = N'" & tFormItems.ExtRef & "'" & ", [AddYtot] = " & IIf(tFormItems.AddYtot = True, "1", "0") & ", [AddNtot] = " & IIf(tFormItems.AddNtot = True, "1", "0") & ", [MinRole] = " & tFormItems.MinRole & ", [PageNo] = " & tFormItems.PageNo & ", [DateSync] = " & IIf(tFormItems.DateSync = Nothing, "null", "'" & tFormItems.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [ListCode] = N'" & tFormItems.ListCode & "'" & ", [LinkCheckCode] = N'" & tFormItems.LinkCheckCode & "'" & " Where [CheckCode] = N'" & tFormItems.CheckCode & "'"
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function update(ByVal tFormItems As TFORMITEMS, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Update tFormItems Set [FormCode] = N'" & tFormItems.FormCode & "'" & ", [Categ] = N'" & tFormItems.Categ & "'" & ", [Description] = N'" & tFormItems.Description & "'" & ", [srt] = N'" & tFormItems.srt & "'" & ", [AnsType] = N'" & tFormItems.AnsType & "'" & ", [Mandatory] = " & IIf(tFormItems.Mandatory = True, "1", "0") & ", [EmailUser] = " & IIf(tFormItems.EmailUser = True, "1", "0") & ", [MultiChoice] = " & IIf(tFormItems.MultiChoice = True, "1", "0") & ", [ExtRef] = N'" & tFormItems.ExtRef & "'" & ", [AddYtot] = " & IIf(tFormItems.AddYtot = True, "1", "0") & ", [AddNtot] = " & IIf(tFormItems.AddNtot = True, "1", "0") & ", [MinRole] = " & tFormItems.MinRole & ", [PageNo] = " & tFormItems.PageNo & ", [DateSync] = " & IIf(tFormItems.DateSync = Nothing, "null", "'" & tFormItems.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [ListCode] = N'" & tFormItems.ListCode & "'" & ", [LinkCheckCode] = N'" & tFormItems.LinkCheckCode & "'" & " Where [CheckCode] = N'" & tFormItems.CheckCode & "'"
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

    Public Shared Function delete(ByVal tFormItems As TFORMITEMS, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Delete from tFormItems Where [CheckCode] = N'" & tFormItems.CheckCode & "'"
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function updateBlob(ByVal tFormItems As TFORMITEMS, ByVal column As String, ByVal b46Str As String, ByVal connectionString As String) As Boolean

        Dim conn As SqlConnection = New SqlConnection(connectionString)
       conn.Open()

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))

       Dim sSQL As String = "UPDATE tFormItems SET " & column & "=@Image WHERE CheckCode = " & tFormItems.CheckCode
       cmd.CommandText = sSQL
        cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
       cmd.ExecuteNonQuery()

       conn.Close()
       conn.Dispose()

   End Function

    Public Shared Function updateBlob(ByVal tFormItems As TFORMITEMS, ByVal column As String, ByVal b46Str As String, ByVal conn As SqlConnection) As Boolean

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))
Dim sSQL As String = "UPDATE tFormItems SET " & column & "=@Image WHERE CheckCode = " & tFormItems.CheckCode
cmd.CommandText = sSQL
cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
cmd.ExecuteNonQuery()

   End Function

    Public Shared Function delete(ByVal tFormItems As TFORMITEMS, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Delete from tFormItems Where [CheckCode] = N'" & tFormItems.CheckCode & "'"
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

   Private Shared Function loadFromResultSet(ByVal obj As TFORMITEMS, ByVal resultset As DataRow) As TFORMITEMS
      obj.CheckCode = ProcessNull.GetString(resultset.Item("CheckCode"))
      obj.FormCode = ProcessNull.GetString(resultset.Item("FormCode"))
      obj.Categ = ProcessNull.GetString(resultset.Item("Categ"))
      obj.Description = ProcessNull.GetString(resultset.Item("Description"))
      obj.srt = ProcessNull.GetString(resultset.Item("srt"))
      obj.AnsType = ProcessNull.GetString(resultset.Item("AnsType"))
       obj.Mandatory = ProcessNull.GetBoolean(resultset.Item("Mandatory"))
       obj.EmailUser = ProcessNull.GetBoolean(resultset.Item("EmailUser"))
       obj.MultiChoice = ProcessNull.GetBoolean(resultset.Item("MultiChoice"))
      obj.ExtRef = ProcessNull.GetString(resultset.Item("ExtRef"))
       obj.AddYtot = ProcessNull.GetBoolean(resultset.Item("AddYtot"))
       obj.AddNtot = ProcessNull.GetBoolean(resultset.Item("AddNtot"))
      obj.MinRole = ProcessNull.GetInt32(resultset.Item("MinRole"))
      obj.PageNo = ProcessNull.GetInt32(resultset.Item("PageNo"))
      obj.DateSync = ProcessNull.GetDateTime(resultset.Item("DateSync"))
      obj.ListCode = ProcessNull.GetString(resultset.Item("ListCode"))
      obj.LinkCheckCode = ProcessNull.GetString(resultset.Item("LinkCheckCode"))

       Return obj

   End Function

End Class

