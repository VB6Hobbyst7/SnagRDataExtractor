Imports SnagRWeb_Project.SnagRData
Imports System.Data.SqlClient

Public Class TFORMROLES

   Private [_Role] As Int32
   Public Property [Role]() As Int32
       Get
           Return [_Role]
       End Get
       Set(ByVal value As Int32)
           [_Role] = value
       End Set
    End Property
   Private [_RoleDescrip] As String
   Public Property [RoleDescrip]() As String
       Get
           Return [_RoleDescrip]
       End Get
       Set(ByVal value As String)
           [_RoleDescrip] = value
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

Public Class TFORMROLESDAO

   Public Shared Function getUsingRole(ByVal Role As Int32, ByVal connectionString As String, Optional ByVal Limit As Integer = 0) As TFORMROLES
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormRoles Where Role = "  & Role, connectionString)
       Else
           dt  = SnagRData.GetDataTable("Select * from tFormRoles Where Role = "  & Role, connectionString)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TFORMROLES, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getUsingRole(ByVal Role As Int32, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0) As TFORMROLES
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormRoles Where Role = "  & Role, conn)
       Else
           dt  = SnagRData.GetDataTable("Select * from tFormRoles Where Role = "  & Role, conn)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TFORMROLES, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0, Optional sql as String = Nothing) As List(Of TFORMROLES)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, connectionString)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormRoles Where " + where, connectionString)
       Else
           dt = SnagRData.GetDataTable("Select * from tFormRoles Where " + where, connectionString)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TFORMROLES)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TFORMROLES, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0, Optional ByVal sql as String = Nothing) As List(Of TFORMROLES)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, conn)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormRoles Where " + where, conn)
       Else
           dt = SnagRData.GetDataTable("Select * from tFormRoles Where " + where, conn)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TFORMROLES)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TFORMROLES, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

    Public Shared Function insert(ByVal tFormRoles As TFORMROLES, ByVal connectionString As String) As Boolean

        Dim sSQL As String = "Insert into tFormRoles (Role, [RoleDescrip], [DateSync]) Values (" & tFormRoles.Role & ", " & "N'" & tFormRoles.RoleDescrip & "'" & ", " & IIf(tFormRoles.DateSync = Nothing, "null", "'" & tFormRoles.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ")"
       Return SnagRData.RunSQL(connectionString, sSQL)

   End Function

    Public Shared Function insert(ByVal tFormRoles As TFORMROLES, ByVal conn As SqlConnection) As Boolean

        Dim sSQL As String = "Insert into tFormRoles ([Role], [RoleDescrip], [DateSync]) Values (" & tFormRoles.Role & ", " & "N'" & tFormRoles.RoleDescrip & "'" & ", " & IIf(tFormRoles.DateSync = Nothing, "null", "'" & tFormRoles.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ")"
       Return SnagRData.RunSQL(conn, sSQL)

   End Function

    Public Shared Function update(ByVal tFormRoles As TFORMROLES, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Update tFormRoles Set [RoleDescrip] = N'" & tFormRoles.RoleDescrip & "'" & ", [DateSync] = " & IIf(tFormRoles.DateSync = Nothing, "null", "'" & tFormRoles.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & " Where [Role] = " & tFormRoles.Role
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function update(ByVal tFormRoles As TFORMROLES, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Update tFormRoles Set [RoleDescrip] = N'" & tFormRoles.RoleDescrip & "'" & ", [DateSync] = " & IIf(tFormRoles.DateSync = Nothing, "null", "'" & tFormRoles.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & " Where [Role] = " & tFormRoles.Role
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

    Public Shared Function delete(ByVal tFormRoles As TFORMROLES, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Delete from tFormRoles Where [Role] = " & tFormRoles.Role
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function updateBlob(ByVal tFormRoles As TFORMROLES, ByVal column As String, ByVal b46Str As String, ByVal connectionString As String) As Boolean

        Dim conn As SqlConnection = New SqlConnection(connectionString)
       conn.Open()

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))

       Dim sSQL As String = "UPDATE tFormRoles SET " & column & "=@Image WHERE Role = " & tFormRoles.Role
       cmd.CommandText = sSQL
        cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
       cmd.ExecuteNonQuery()

       conn.Close()
       conn.Dispose()

   End Function

    Public Shared Function updateBlob(ByVal tFormRoles As TFORMROLES, ByVal column As String, ByVal b46Str As String, ByVal conn As SqlConnection) As Boolean

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))
Dim sSQL As String = "UPDATE tFormRoles SET " & column & "=@Image WHERE Role = " & tFormRoles.Role
cmd.CommandText = sSQL
cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
cmd.ExecuteNonQuery()

   End Function

    Public Shared Function delete(ByVal tFormRoles As TFORMROLES, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Delete from tFormRoles Where [Role] = " & tFormRoles.Role
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

   Private Shared Function loadFromResultSet(ByVal obj As TFORMROLES, ByVal resultset As DataRow) As TFORMROLES
      obj.Role = ProcessNull.GetInt32(resultset.Item("Role"))
      obj.RoleDescrip = ProcessNull.GetString(resultset.Item("RoleDescrip"))
      obj.DateSync = ProcessNull.GetDateTime(resultset.Item("DateSync"))

       Return obj

   End Function

End Class

