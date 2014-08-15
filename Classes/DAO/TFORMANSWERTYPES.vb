Imports SnagRWeb_Project.SnagRData
Imports System.Data.SqlClient

Public Class TFORMANSWERTYPES

   Private [_AnswerType] As String
   Public Property [AnswerType]() As String
       Get
           Return [_AnswerType]
       End Get
       Set(ByVal value As String)
           [_AnswerType] = value
       End Set
    End Property
   Private [_FromProject] As Boolean
   Public Property [FromProject]() As Boolean
       Get
           Return [_FromProject]
       End Get
       Set(ByVal value As Boolean)
           [_FromProject] = value
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

Public Class TFORMANSWERTYPESDAO

   Public Shared Function getUsingAnswerType(ByVal AnswerType As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0) As TFORMANSWERTYPES
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormAnswerTypes Where AnswerType = N'"  & AnswerType & "'", connectionString)
       Else
           dt  = SnagRData.GetDataTable("Select * from tFormAnswerTypes Where AnswerType = N'"  & AnswerType & "'", connectionString)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TFORMANSWERTYPES, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getUsingAnswerType(ByVal AnswerType As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0) As TFORMANSWERTYPES
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormAnswerTypes Where AnswerType = N'"  & AnswerType & "'", conn)
       Else
           dt  = SnagRData.GetDataTable("Select * from tFormAnswerTypes Where AnswerType = N'"  & AnswerType & "'", conn)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TFORMANSWERTYPES, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0, Optional sql as String = Nothing) As List(Of TFORMANSWERTYPES)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, connectionString)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormAnswerTypes Where " + where, connectionString)
       Else
           dt = SnagRData.GetDataTable("Select * from tFormAnswerTypes Where " + where, connectionString)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TFORMANSWERTYPES)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TFORMANSWERTYPES, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0, Optional ByVal sql as String = Nothing) As List(Of TFORMANSWERTYPES)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, conn)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormAnswerTypes Where " + where, conn)
       Else
           dt = SnagRData.GetDataTable("Select * from tFormAnswerTypes Where " + where, conn)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TFORMANSWERTYPES)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TFORMANSWERTYPES, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

    Public Shared Function insert(ByVal tFormAnswerTypes As TFORMANSWERTYPES, ByVal connectionString As String) As Boolean

        Dim sSQL As String = "Insert into tFormAnswerTypes (AnswerType, [FromProject], [srt], [DateSync]) Values (" & "N'" & tFormAnswerTypes.AnswerType & "'" & ", " & "'" & tFormAnswerTypes.FromProject & "'" & ", " & "N'" & tFormAnswerTypes.srt & "'" & ", " & IIf(tFormAnswerTypes.DateSync = Nothing, "null", "'" & tFormAnswerTypes.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ")"
       Return SnagRData.RunSQL(connectionString, sSQL)

   End Function

    Public Shared Function insert(ByVal tFormAnswerTypes As TFORMANSWERTYPES, ByVal conn As SqlConnection) As Boolean

        Dim sSQL As String = "Insert into tFormAnswerTypes ([AnswerType], [FromProject], [srt], [DateSync]) Values (" & "N'" & tFormAnswerTypes.AnswerType & "'" & ", " & "'" & tFormAnswerTypes.FromProject & "'" & ", " & "N'" & tFormAnswerTypes.srt & "'" & ", " & IIf(tFormAnswerTypes.DateSync = Nothing, "null", "'" & tFormAnswerTypes.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ")"
       Return SnagRData.RunSQL(conn, sSQL)

   End Function

    Public Shared Function update(ByVal tFormAnswerTypes As TFORMANSWERTYPES, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Update tFormAnswerTypes Set [FromProject] = " & IIf(tFormAnswerTypes.FromProject = True, "1", "0") & ", [srt] = N'" & tFormAnswerTypes.srt & "'" & ", [DateSync] = " & IIf(tFormAnswerTypes.DateSync = Nothing, "null", "'" & tFormAnswerTypes.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & " Where [AnswerType] = N'" & tFormAnswerTypes.AnswerType & "'"
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function update(ByVal tFormAnswerTypes As TFORMANSWERTYPES, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Update tFormAnswerTypes Set [FromProject] = " & IIf(tFormAnswerTypes.FromProject = True, "1", "0") & ", [srt] = N'" & tFormAnswerTypes.srt & "'" & ", [DateSync] = " & IIf(tFormAnswerTypes.DateSync = Nothing, "null", "'" & tFormAnswerTypes.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & " Where [AnswerType] = N'" & tFormAnswerTypes.AnswerType & "'"
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

    Public Shared Function delete(ByVal tFormAnswerTypes As TFORMANSWERTYPES, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Delete from tFormAnswerTypes Where [AnswerType] = N'" & tFormAnswerTypes.AnswerType & "'"
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function updateBlob(ByVal tFormAnswerTypes As TFORMANSWERTYPES, ByVal column As String, ByVal b46Str As String, ByVal connectionString As String) As Boolean

        Dim conn As SqlConnection = New SqlConnection(connectionString)
       conn.Open()

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))

       Dim sSQL As String = "UPDATE tFormAnswerTypes SET " & column & "=@Image WHERE AnswerType = " & tFormAnswerTypes.AnswerType
       cmd.CommandText = sSQL
        cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
       cmd.ExecuteNonQuery()

       conn.Close()
       conn.Dispose()

   End Function

    Public Shared Function updateBlob(ByVal tFormAnswerTypes As TFORMANSWERTYPES, ByVal column As String, ByVal b46Str As String, ByVal conn As SqlConnection) As Boolean

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))
Dim sSQL As String = "UPDATE tFormAnswerTypes SET " & column & "=@Image WHERE AnswerType = " & tFormAnswerTypes.AnswerType
cmd.CommandText = sSQL
cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
cmd.ExecuteNonQuery()

   End Function

    Public Shared Function delete(ByVal tFormAnswerTypes As TFORMANSWERTYPES, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Delete from tFormAnswerTypes Where [AnswerType] = N'" & tFormAnswerTypes.AnswerType & "'"
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

   Private Shared Function loadFromResultSet(ByVal obj As TFORMANSWERTYPES, ByVal resultset As DataRow) As TFORMANSWERTYPES
      obj.AnswerType = ProcessNull.GetString(resultset.Item("AnswerType"))
       obj.FromProject = ProcessNull.GetBoolean(resultset.Item("FromProject"))
      obj.srt = ProcessNull.GetString(resultset.Item("srt"))
      obj.DateSync = ProcessNull.GetDateTime(resultset.Item("DateSync"))

       Return obj

   End Function

End Class

