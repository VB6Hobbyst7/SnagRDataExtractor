Imports SnagRWeb_Project.SnagRData
Imports System.Data.SqlClient

Public Class TFORMITEMANS

   Private [_FIAID] As Int32
   Public Property [FIAID]() As Int32
       Get
           Return [_FIAID]
       End Get
       Set(ByVal value As Int32)
           [_FIAID] = value
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
   Private [_AnsType] As String
   Public Property [AnsType]() As String
       Get
           Return [_AnsType]
       End Get
       Set(ByVal value As String)
           [_AnsType] = value
       End Set
    End Property
   Private [_AnsText] As String
   Public Property [AnsText]() As String
       Get
           Return [_AnsText]
       End Get
       Set(ByVal value As String)
           [_AnsText] = value
       End Set
    End Property
   Private [_ImageName] As String
   Public Property [ImageName]() As String
       Get
           Return [_ImageName]
       End Get
       Set(ByVal value As String)
           [_ImageName] = value
       End Set
    End Property
   Private [_x] As Int32
   Public Property [x]() As Int32
       Get
           Return [_x]
       End Get
       Set(ByVal value As Int32)
           [_x] = value
       End Set
    End Property
   Private [_y] As Int32
   Public Property [y]() As Int32
       Get
           Return [_y]
       End Get
       Set(ByVal value As Int32)
           [_y] = value
       End Set
    End Property
   Private [_w] As Int32
   Public Property [w]() As Int32
       Get
           Return [_w]
       End Get
       Set(ByVal value As Int32)
           [_w] = value
       End Set
    End Property
   Private [_h] As Int32
   Public Property [h]() As Int32
       Get
           Return [_h]
       End Get
       Set(ByVal value As Int32)
           [_h] = value
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

End Class

Public Class TFORMITEMANSDAO

   Public Shared Function getUsingFIAID(ByVal FIAID As Int32, ByVal connectionString As String, Optional ByVal Limit As Integer = 0) As TFORMITEMANS
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormItemAns Where FIAID = "  & FIAID, connectionString)
       Else
           dt  = SnagRData.GetDataTable("Select * from tFormItemAns Where FIAID = "  & FIAID, connectionString)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TFORMITEMANS, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getUsingFIAID(ByVal FIAID As Int32, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0) As TFORMITEMANS
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormItemAns Where FIAID = "  & FIAID, conn)
       Else
           dt  = SnagRData.GetDataTable("Select * from tFormItemAns Where FIAID = "  & FIAID, conn)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TFORMITEMANS, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0, Optional sql as String = Nothing) As List(Of TFORMITEMANS)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, connectionString)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormItemAns Where " + where, connectionString)
       Else
           dt = SnagRData.GetDataTable("Select * from tFormItemAns Where " + where, connectionString)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TFORMITEMANS)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TFORMITEMANS, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0, Optional ByVal sql as String = Nothing) As List(Of TFORMITEMANS)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, conn)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormItemAns Where " + where, conn)
       Else
           dt = SnagRData.GetDataTable("Select * from tFormItemAns Where " + where, conn)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TFORMITEMANS)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TFORMITEMANS, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

    Public Shared Function insert(ByVal tFormItemAns As TFORMITEMANS, ByVal connectionString As String) As Boolean

        Dim sSQL As String = "Insert into tFormItemAns (CheckCode, [FormCode], [AnsType], [AnsText], [ImageName], [x], [y], [w], [h], [PageNo], [DateSync], [AddSnag], [SDCode], [SDID]) Values (" & "N'" & tFormItemAns.CheckCode & "'" & ", " & "N'" & tFormItemAns.FormCode & "'" & ", " & "N'" & tFormItemAns.AnsType & "'" & ", " & "N'" & tFormItemAns.AnsText & "'" & ", " & "N'" & tFormItemAns.ImageName & "'" & ", " & tFormItemAns.x & ", " & tFormItemAns.y & ", " & tFormItemAns.w & ", " & tFormItemAns.h & ", " & tFormItemAns.PageNo & ", " & IIf(tFormItemAns.DateSync = Nothing, "null", "'" & tFormItemAns.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "'" & tFormItemAns.AddSnag & "'" & ", " & "N'" & tFormItemAns.SDCode & "'" & ", " & tFormItemAns.SDID & ")"
       Return SnagRData.RunSQL(connectionString, sSQL)

   End Function

    Public Shared Function insert(ByVal tFormItemAns As TFORMITEMANS, ByVal conn As SqlConnection) As Boolean

        Dim sSQL As String = "Insert into tFormItemAns ([CheckCode], [FormCode], [AnsType], [AnsText], [ImageName], [x], [y], [w], [h], [PageNo], [DateSync], [AddSnag], [SDCode], [SDID]) Values (" & "N'" & tFormItemAns.CheckCode & "'" & ", " & "N'" & tFormItemAns.FormCode & "'" & ", " & "N'" & tFormItemAns.AnsType & "'" & ", " & "N'" & tFormItemAns.AnsText & "'" & ", " & "N'" & tFormItemAns.ImageName & "'" & ", " & tFormItemAns.x & ", " & tFormItemAns.y & ", " & tFormItemAns.w & ", " & tFormItemAns.h & ", " & tFormItemAns.PageNo & ", " & IIf(tFormItemAns.DateSync = Nothing, "null", "'" & tFormItemAns.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "'" & tFormItemAns.AddSnag & "'" & ", " & "N'" & tFormItemAns.SDCode & "'" & ", " & tFormItemAns.SDID & ")"
       Return SnagRData.RunSQL(conn, sSQL)

   End Function

    Public Shared Function update(ByVal tFormItemAns As TFORMITEMANS, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Update tFormItemAns Set [CheckCode] = N'" & tFormItemAns.CheckCode & "'" & ", [FormCode] = N'" & tFormItemAns.FormCode & "'" & ", [AnsType] = N'" & tFormItemAns.AnsType & "'" & ", [AnsText] = N'" & tFormItemAns.AnsText & "'" & ", [ImageName] = N'" & tFormItemAns.ImageName & "'" & ", [x] = " & tFormItemAns.x & ", [y] = " & tFormItemAns.y & ", [w] = " & tFormItemAns.w & ", [h] = " & tFormItemAns.h & ", [PageNo] = " & tFormItemAns.PageNo & ", [DateSync] = " & IIf(tFormItemAns.DateSync = Nothing, "null", "'" & tFormItemAns.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [AddSnag] = " & IIf(tFormItemAns.AddSnag = True, "1", "0") & ", [SDCode] = N'" & tFormItemAns.SDCode & "'" & ", [SDID] = " & tFormItemAns.SDID & " Where [FIAID] = " & tFormItemAns.FIAID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function update(ByVal tFormItemAns As TFORMITEMANS, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Update tFormItemAns Set [CheckCode] = N'" & tFormItemAns.CheckCode & "'" & ", [FormCode] = N'" & tFormItemAns.FormCode & "'" & ", [AnsType] = N'" & tFormItemAns.AnsType & "'" & ", [AnsText] = N'" & tFormItemAns.AnsText & "'" & ", [ImageName] = N'" & tFormItemAns.ImageName & "'" & ", [x] = " & tFormItemAns.x & ", [y] = " & tFormItemAns.y & ", [w] = " & tFormItemAns.w & ", [h] = " & tFormItemAns.h & ", [PageNo] = " & tFormItemAns.PageNo & ", [DateSync] = " & IIf(tFormItemAns.DateSync = Nothing, "null", "'" & tFormItemAns.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [AddSnag] = " & IIf(tFormItemAns.AddSnag = True, "1", "0") & ", [SDCode] = N'" & tFormItemAns.SDCode & "'" & ", [SDID] = " & tFormItemAns.SDID & " Where [FIAID] = " & tFormItemAns.FIAID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

    Public Shared Function delete(ByVal tFormItemAns As TFORMITEMANS, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Delete from tFormItemAns Where [FIAID] = " & tFormItemAns.FIAID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function updateBlob(ByVal tFormItemAns As TFORMITEMANS, ByVal column As String, ByVal b46Str As String, ByVal connectionString As String) As Boolean

        Dim conn As SqlConnection = New SqlConnection(connectionString)
       conn.Open()

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))

       Dim sSQL As String = "UPDATE tFormItemAns SET " & column & "=@Image WHERE FIAID = " & tFormItemAns.FIAID
       cmd.CommandText = sSQL
        cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
       cmd.ExecuteNonQuery()

       conn.Close()
       conn.Dispose()

   End Function

    Public Shared Function updateBlob(ByVal tFormItemAns As TFORMITEMANS, ByVal column As String, ByVal b46Str As String, ByVal conn As SqlConnection) As Boolean

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))
Dim sSQL As String = "UPDATE tFormItemAns SET " & column & "=@Image WHERE FIAID = " & tFormItemAns.FIAID
cmd.CommandText = sSQL
cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
cmd.ExecuteNonQuery()

   End Function

    Public Shared Function delete(ByVal tFormItemAns As TFORMITEMANS, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Delete from tFormItemAns Where [FIAID] = " & tFormItemAns.FIAID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

   Private Shared Function loadFromResultSet(ByVal obj As TFORMITEMANS, ByVal resultset As DataRow) As TFORMITEMANS
      obj.FIAID = ProcessNull.GetInt32(resultset.Item("FIAID"))
      obj.CheckCode = ProcessNull.GetString(resultset.Item("CheckCode"))
      obj.FormCode = ProcessNull.GetString(resultset.Item("FormCode"))
      obj.AnsType = ProcessNull.GetString(resultset.Item("AnsType"))
      obj.AnsText = ProcessNull.GetString(resultset.Item("AnsText"))
      obj.ImageName = ProcessNull.GetString(resultset.Item("ImageName"))
      obj.x = ProcessNull.GetInt32(resultset.Item("x"))
      obj.y = ProcessNull.GetInt32(resultset.Item("y"))
      obj.w = ProcessNull.GetInt32(resultset.Item("w"))
      obj.h = ProcessNull.GetInt32(resultset.Item("h"))
      obj.PageNo = ProcessNull.GetInt32(resultset.Item("PageNo"))
      obj.DateSync = ProcessNull.GetDateTime(resultset.Item("DateSync"))
       obj.AddSnag = ProcessNull.GetBoolean(resultset.Item("AddSnag"))
      obj.SDCode = ProcessNull.GetString(resultset.Item("SDCode"))
      obj.SDID = ProcessNull.GetInt32(resultset.Item("SDID"))

       Return obj

   End Function

End Class

