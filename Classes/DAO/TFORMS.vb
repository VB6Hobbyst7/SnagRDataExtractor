Imports SnagRWeb_Project.SnagRData
Imports System.Data.SqlClient

Public Class TFORMS

   Private [_FormCode] As String
   Public Property [FormCode]() As String
       Get
           Return [_FormCode]
       End Get
       Set(ByVal value As String)
           [_FormCode] = value
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
   Private [_PageCount] As Int32
   Public Property [PageCount]() As Int32
       Get
           Return [_PageCount]
       End Get
       Set(ByVal value As Int32)
           [_PageCount] = value
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
   Private [_ShortDesc] As String
   Public Property [ShortDesc]() As String
       Get
           Return [_ShortDesc]
       End Get
       Set(ByVal value As String)
           [_ShortDesc] = value
       End Set
    End Property
   Private [_Valid4Days] As Int32
   Public Property [Valid4Days]() As Int32
       Get
           Return [_Valid4Days]
       End Get
       Set(ByVal value As Int32)
           [_Valid4Days] = value
       End Set
    End Property
   Private [_hasPassFail] As Boolean
   Public Property [hasPassFail]() As Boolean
       Get
           Return [_hasPassFail]
       End Get
       Set(ByVal value As Boolean)
           [_hasPassFail] = value
       End Set
    End Property

End Class

Public Class TFORMSDAO

   Public Shared Function getUsingFormCode(ByVal FormCode As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0) As TFORMS
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tForms Where FormCode = N'"  & FormCode & "'", connectionString)
       Else
           dt  = SnagRData.GetDataTable("Select * from tForms Where FormCode = N'"  & FormCode & "'", connectionString)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TFORMS, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getUsingFormCode(ByVal FormCode As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0) As TFORMS
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tForms Where FormCode = N'"  & FormCode & "'", conn)
       Else
           dt  = SnagRData.GetDataTable("Select * from tForms Where FormCode = N'"  & FormCode & "'", conn)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TFORMS, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0, Optional sql as String = Nothing) As List(Of TFORMS)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, connectionString)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tForms Where " + where, connectionString)
       Else
           dt = SnagRData.GetDataTable("Select * from tForms Where " + where, connectionString)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TFORMS)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TFORMS, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0, Optional ByVal sql as String = Nothing) As List(Of TFORMS)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, conn)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tForms Where " + where, conn)
       Else
           dt = SnagRData.GetDataTable("Select * from tForms Where " + where, conn)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TFORMS)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TFORMS, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

    Public Shared Function insert(ByVal tForms As TFORMS, ByVal connectionString As String) As Boolean

        Dim sSQL As String = "Insert into tForms (FormCode, [Description], [Current], [PageCount], [DateSync], [ShortDesc], [Valid4Days], [hasPassFail]) Values (" & "N'" & tForms.FormCode & "'" & ", " & "N'" & tForms.Description & "'" & ", " & "'" & tForms.Current & "'" & ", " & tForms.PageCount & ", " & IIf(tForms.DateSync = Nothing, "null", "'" & tForms.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tForms.ShortDesc & "'" & ", " & tForms.Valid4Days & ", " & "'" & tForms.hasPassFail & "'" & ")"
       Return SnagRData.RunSQL(connectionString, sSQL)

   End Function

    Public Shared Function insert(ByVal tForms As TFORMS, ByVal conn As SqlConnection) As Boolean

        Dim sSQL As String = "Insert into tForms ([FormCode], [Description], [Current], [PageCount], [DateSync], [ShortDesc], [Valid4Days], [hasPassFail]) Values (" & "N'" & tForms.FormCode & "'" & ", " & "N'" & tForms.Description & "'" & ", " & "'" & tForms.Current & "'" & ", " & tForms.PageCount & ", " & IIf(tForms.DateSync = Nothing, "null", "'" & tForms.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tForms.ShortDesc & "'" & ", " & tForms.Valid4Days & ", " & "'" & tForms.hasPassFail & "'" & ")"
       Return SnagRData.RunSQL(conn, sSQL)

   End Function

    Public Shared Function update(ByVal tForms As TFORMS, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Update tForms Set [Description] = N'" & tForms.Description & "'" & ", [Current] = " & IIf(tForms.Current = True, "1", "0") & ", [PageCount] = " & tForms.PageCount & ", [DateSync] = " & IIf(tForms.DateSync = Nothing, "null", "'" & tForms.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [ShortDesc] = N'" & tForms.ShortDesc & "'" & ", [Valid4Days] = " & tForms.Valid4Days & ", [hasPassFail] = " & IIf(tForms.hasPassFail = True, "1", "0") & " Where [FormCode] = N'" & tForms.FormCode & "'"
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function update(ByVal tForms As TFORMS, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Update tForms Set [Description] = N'" & tForms.Description & "'" & ", [Current] = " & IIf(tForms.Current = True, "1", "0") & ", [PageCount] = " & tForms.PageCount & ", [DateSync] = " & IIf(tForms.DateSync = Nothing, "null", "'" & tForms.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [ShortDesc] = N'" & tForms.ShortDesc & "'" & ", [Valid4Days] = " & tForms.Valid4Days & ", [hasPassFail] = " & IIf(tForms.hasPassFail = True, "1", "0") & " Where [FormCode] = N'" & tForms.FormCode & "'"
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

    Public Shared Function delete(ByVal tForms As TFORMS, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Delete from tForms Where [FormCode] = N'" & tForms.FormCode & "'"
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function updateBlob(ByVal tForms As TFORMS, ByVal column As String, ByVal b46Str As String, ByVal connectionString As String) As Boolean

        Dim conn As SqlConnection = New SqlConnection(connectionString)
       conn.Open()

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))

       Dim sSQL As String = "UPDATE tForms SET " & column & "=@Image WHERE FormCode = " & tForms.FormCode
       cmd.CommandText = sSQL
        cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
       cmd.ExecuteNonQuery()

       conn.Close()
       conn.Dispose()

   End Function

    Public Shared Function updateBlob(ByVal tForms As TFORMS, ByVal column As String, ByVal b46Str As String, ByVal conn As SqlConnection) As Boolean

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))
Dim sSQL As String = "UPDATE tForms SET " & column & "=@Image WHERE FormCode = " & tForms.FormCode
cmd.CommandText = sSQL
cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
cmd.ExecuteNonQuery()

   End Function

    Public Shared Function delete(ByVal tForms As TFORMS, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Delete from tForms Where [FormCode] = N'" & tForms.FormCode & "'"
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

   Private Shared Function loadFromResultSet(ByVal obj As TFORMS, ByVal resultset As DataRow) As TFORMS
      obj.FormCode = ProcessNull.GetString(resultset.Item("FormCode"))
      obj.Description = ProcessNull.GetString(resultset.Item("Description"))
       obj.Current = ProcessNull.GetBoolean(resultset.Item("Current"))
      obj.PageCount = ProcessNull.GetInt32(resultset.Item("PageCount"))
      obj.DateSync = ProcessNull.GetDateTime(resultset.Item("DateSync"))
      obj.ShortDesc = ProcessNull.GetString(resultset.Item("ShortDesc"))
      obj.Valid4Days = ProcessNull.GetInt32(resultset.Item("Valid4Days"))
       obj.hasPassFail = ProcessNull.GetBoolean(resultset.Item("hasPassFail"))

       Return obj

   End Function

End Class

