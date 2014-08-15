Imports SnagRWeb_Project.SnagRData
Imports System.Data.SqlClient

Public Class TUSERS

   Private [_UserID] As Int32
   Public Property [UserID]() As Int32
       Get
           Return [_UserID]
       End Get
       Set(ByVal value As Int32)
           [_UserID] = value
       End Set
    End Property
   Private [_Username] As String
   Public Property [Username]() As String
       Get
           Return [_Username]
       End Get
       Set(ByVal value As String)
           [_Username] = value
       End Set
    End Property
   Private [_Password] As String
   Public Property [Password]() As String
       Get
           Return [_Password]
       End Get
       Set(ByVal value As String)
           [_Password] = value
       End Set
    End Property
   Private [_Fullname] As String
   Public Property [Fullname]() As String
       Get
           Return [_Fullname]
       End Get
       Set(ByVal value As String)
           [_Fullname] = value
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
   Private [_Role] As Int32
   Public Property [Role]() As Int32
       Get
           Return [_Role]
       End Get
       Set(ByVal value As Int32)
           [_Role] = value
       End Set
    End Property
   Private [_Email] As String
   Public Property [Email]() As String
       Get
           Return [_Email]
       End Get
       Set(ByVal value As String)
           [_Email] = value
       End Set
    End Property
   Private [_LastLogin] As DateTime
   Public Property [LastLogin]() As DateTime
       Get
           Return [_LastLogin]
       End Get
       Set(ByVal value As DateTime)
           [_LastLogin] = value
       End Set
    End Property
   Private [_Culture] As String
   Public Property [Culture]() As String
       Get
           Return [_Culture]
       End Get
       Set(ByVal value As String)
           [_Culture] = value
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
   Private [_IsClient] As Boolean
   Public Property [IsClient]() As Boolean
       Get
           Return [_IsClient]
       End Get
       Set(ByVal value As Boolean)
           [_IsClient] = value
       End Set
    End Property

End Class

Public Class TUSERSDAO

   Public Shared Function getUsingUserID(ByVal UserID As Int32, ByVal connectionString As String, Optional ByVal Limit As Integer = 0) As TUSERS
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tUsers Where UserID = "  & UserID, connectionString)
       Else
           dt  = SnagRData.GetDataTable("Select * from tUsers Where UserID = "  & UserID, connectionString)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TUSERS, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getUsingUserID(ByVal UserID As Int32, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0) As TUSERS
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tUsers Where UserID = "  & UserID, conn)
       Else
           dt  = SnagRData.GetDataTable("Select * from tUsers Where UserID = "  & UserID, conn)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TUSERS, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0, Optional sql as String = Nothing) As List(Of TUSERS)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, connectionString)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tUsers Where " + where, connectionString)
       Else
           dt = SnagRData.GetDataTable("Select * from tUsers Where " + where, connectionString)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TUSERS)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TUSERS, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0, Optional ByVal sql as String = Nothing) As List(Of TUSERS)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, conn)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tUsers Where " + where, conn)
       Else
           dt = SnagRData.GetDataTable("Select * from tUsers Where " + where, conn)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TUSERS)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TUSERS, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

    Public Shared Function insert(ByVal tUsers As TUSERS, ByVal connectionString As String) As Boolean

        Dim sSQL As String = "Insert into tUsers (UserID, [Username], [Password], [Fullname], [Current], [Role], [Email], [LastLogin], [Culture], [DateSync], [IsClient]) Values (" & tUsers.UserID & ", " & "N'" & tUsers.Username & "'" & ", " & "N'" & tUsers.Password & "'" & ", " & "N'" & tUsers.Fullname & "'" & ", " & "'" & tUsers.Current & "'" & ", " & tUsers.Role & ", " & "N'" & tUsers.Email & "'" & ", " & IIf(tUsers.LastLogin = Nothing, "null", "'" & tUsers.LastLogin.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tUsers.Culture & "'" & ", " & IIf(tUsers.DateSync = Nothing, "null", "'" & tUsers.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "'" & tUsers.IsClient & "'" & ")"
       Return SnagRData.RunSQL(connectionString, sSQL)

   End Function

    Public Shared Function insert(ByVal tUsers As TUSERS, ByVal conn As SqlConnection) As Boolean

        Dim sSQL As String = "Insert into tUsers ([UserID], [Username], [Password], [Fullname], [Current], [Role], [Email], [LastLogin], [Culture], [DateSync], [IsClient]) Values (" & tUsers.UserID & ", " & "N'" & tUsers.Username & "'" & ", " & "N'" & tUsers.Password & "'" & ", " & "N'" & tUsers.Fullname & "'" & ", " & "'" & tUsers.Current & "'" & ", " & tUsers.Role & ", " & "N'" & tUsers.Email & "'" & ", " & IIf(tUsers.LastLogin = Nothing, "null", "'" & tUsers.LastLogin.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tUsers.Culture & "'" & ", " & IIf(tUsers.DateSync = Nothing, "null", "'" & tUsers.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "'" & tUsers.IsClient & "'" & ")"
       Return SnagRData.RunSQL(conn, sSQL)

   End Function

    Public Shared Function update(ByVal tUsers As TUSERS, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Update tUsers Set [Username] = N'" & tUsers.Username & "'" & ", [Password] = N'" & tUsers.Password & "'" & ", [Fullname] = N'" & tUsers.Fullname & "'" & ", [Current] = " & IIf(tUsers.Current = True, "1", "0") & ", [Role] = " & tUsers.Role & ", [Email] = N'" & tUsers.Email & "'" & ", [LastLogin] = " & IIf(tUsers.LastLogin = Nothing, "null", "'" & tUsers.LastLogin.ToString("yyyy-MM-dd HH:mm") & "'") & ", [Culture] = N'" & tUsers.Culture & "'" & ", [DateSync] = " & IIf(tUsers.DateSync = Nothing, "null", "'" & tUsers.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [IsClient] = " & IIf(tUsers.IsClient = True, "1", "0") & " Where [UserID] = " & tUsers.UserID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function update(ByVal tUsers As TUSERS, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Update tUsers Set [Username] = N'" & tUsers.Username & "'" & ", [Password] = N'" & tUsers.Password & "'" & ", [Fullname] = N'" & tUsers.Fullname & "'" & ", [Current] = " & IIf(tUsers.Current = True, "1", "0") & ", [Role] = " & tUsers.Role & ", [Email] = N'" & tUsers.Email & "'" & ", [LastLogin] = " & IIf(tUsers.LastLogin = Nothing, "null", "'" & tUsers.LastLogin.ToString("yyyy-MM-dd HH:mm") & "'") & ", [Culture] = N'" & tUsers.Culture & "'" & ", [DateSync] = " & IIf(tUsers.DateSync = Nothing, "null", "'" & tUsers.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [IsClient] = " & IIf(tUsers.IsClient = True, "1", "0") & " Where [UserID] = " & tUsers.UserID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

    Public Shared Function delete(ByVal tUsers As TUSERS, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Delete from tUsers Where [UserID] = " & tUsers.UserID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function updateBlob(ByVal tUsers As TUSERS, ByVal column As String, ByVal b46Str As String, ByVal connectionString As String) As Boolean

        Dim conn As SqlConnection = New SqlConnection(connectionString)
       conn.Open()

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))

       Dim sSQL As String = "UPDATE tUsers SET " & column & "=@Image WHERE UserID = " & tUsers.UserID
       cmd.CommandText = sSQL
        cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
       cmd.ExecuteNonQuery()

       conn.Close()
       conn.Dispose()

   End Function

    Public Shared Function updateBlob(ByVal tUsers As TUSERS, ByVal column As String, ByVal b46Str As String, ByVal conn As SqlConnection) As Boolean

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))
Dim sSQL As String = "UPDATE tUsers SET " & column & "=@Image WHERE UserID = " & tUsers.UserID
cmd.CommandText = sSQL
cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
cmd.ExecuteNonQuery()

   End Function

    Public Shared Function delete(ByVal tUsers As TUSERS, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Delete from tUsers Where [UserID] = " & tUsers.UserID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

   Private Shared Function loadFromResultSet(ByVal obj As TUSERS, ByVal resultset As DataRow) As TUSERS
      obj.UserID = ProcessNull.GetInt32(resultset.Item("UserID"))
      obj.Username = ProcessNull.GetString(resultset.Item("Username"))
      obj.Password = ProcessNull.GetString(resultset.Item("Password"))
      obj.Fullname = ProcessNull.GetString(resultset.Item("Fullname"))
       obj.Current = ProcessNull.GetBoolean(resultset.Item("Current"))
      obj.Role = ProcessNull.GetInt32(resultset.Item("Role"))
      obj.Email = ProcessNull.GetString(resultset.Item("Email"))
      obj.LastLogin = ProcessNull.GetDateTime(resultset.Item("LastLogin"))
      obj.Culture = ProcessNull.GetString(resultset.Item("Culture"))
      obj.DateSync = ProcessNull.GetDateTime(resultset.Item("DateSync"))
       obj.IsClient = ProcessNull.GetBoolean(resultset.Item("IsClient"))

       Return obj

   End Function

End Class

