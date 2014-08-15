Imports SnagRWeb_Project.SnagRData
Imports System.Data.SqlClient

Public Class TSNAGRFORMSDATACONTROL

   Private [_ID] As Int32
   Public Property [ID]() As Int32
       Get
           Return [_ID]
       End Get
       Set(ByVal value As Int32)
           [_ID] = value
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
   Private [_fromURL] As String
   Public Property [fromURL]() As String
       Get
           Return [_fromURL]
       End Get
       Set(ByVal value As String)
           [_fromURL] = value
       End Set
    End Property

End Class

Public Class TSNAGRFORMSDATACONTROLDAO

   Public Shared Function getUsingID(ByVal ID As Int32, ByVal connectionString As String, Optional ByVal Limit As Integer = 0) As TSNAGRFORMSDATACONTROL
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSnagRFormsDataControl Where ID = "  & ID, connectionString)
       Else
           dt  = SnagRData.GetDataTable("Select * from tSnagRFormsDataControl Where ID = "  & ID, connectionString)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TSNAGRFORMSDATACONTROL, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getUsingID(ByVal ID As Int32, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0) As TSNAGRFORMSDATACONTROL
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSnagRFormsDataControl Where ID = "  & ID, conn)
       Else
           dt  = SnagRData.GetDataTable("Select * from tSnagRFormsDataControl Where ID = "  & ID, conn)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TSNAGRFORMSDATACONTROL, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0, Optional sql as String = Nothing) As List(Of TSNAGRFORMSDATACONTROL)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, connectionString)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSnagRFormsDataControl Where " + where, connectionString)
       Else
           dt = SnagRData.GetDataTable("Select * from tSnagRFormsDataControl Where " + where, connectionString)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TSNAGRFORMSDATACONTROL)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TSNAGRFORMSDATACONTROL, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0, Optional ByVal sql as String = Nothing) As List(Of TSNAGRFORMSDATACONTROL)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, conn)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSnagRFormsDataControl Where " + where, conn)
       Else
           dt = SnagRData.GetDataTable("Select * from tSnagRFormsDataControl Where " + where, conn)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TSNAGRFORMSDATACONTROL)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TSNAGRFORMSDATACONTROL, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

    Public Shared Function insert(ByVal tSnagRFormsDataControl As TSNAGRFORMSDATACONTROL, ByVal connectionString As String) As Boolean

        Dim sSQL As String = "Insert into tSnagRFormsDataControl (Datestamp, [fromURL]) Values (" & IIf(tSnagRFormsDataControl.Datestamp = Nothing, "null", "'" & tSnagRFormsDataControl.Datestamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tSnagRFormsDataControl.fromURL & "'" & ")"
       Return SnagRData.RunSQL(connectionString, sSQL)

   End Function

    Public Shared Function insert(ByVal tSnagRFormsDataControl As TSNAGRFORMSDATACONTROL, ByVal conn As SqlConnection) As Boolean

        Dim sSQL As String = "Insert into tSnagRFormsDataControl ([Datestamp], [fromURL]) Values (" & IIf(tSnagRFormsDataControl.Datestamp = Nothing, "null", "'" & tSnagRFormsDataControl.Datestamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tSnagRFormsDataControl.fromURL & "'" & ")"
       Return SnagRData.RunSQL(conn, sSQL)

   End Function

    Public Shared Function update(ByVal tSnagRFormsDataControl As TSNAGRFORMSDATACONTROL, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Update tSnagRFormsDataControl Set [Datestamp] = " & IIf(tSnagRFormsDataControl.Datestamp = Nothing, "null", "'" & tSnagRFormsDataControl.Datestamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", [fromURL] = N'" & tSnagRFormsDataControl.fromURL & "'" & " Where [ID] = " & tSnagRFormsDataControl.ID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function update(ByVal tSnagRFormsDataControl As TSNAGRFORMSDATACONTROL, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Update tSnagRFormsDataControl Set [Datestamp] = " & IIf(tSnagRFormsDataControl.Datestamp = Nothing, "null", "'" & tSnagRFormsDataControl.Datestamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", [fromURL] = N'" & tSnagRFormsDataControl.fromURL & "'" & " Where [ID] = " & tSnagRFormsDataControl.ID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

    Public Shared Function delete(ByVal tSnagRFormsDataControl As TSNAGRFORMSDATACONTROL, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Delete from tSnagRFormsDataControl Where [ID] = " & tSnagRFormsDataControl.ID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function updateBlob(ByVal tSnagRFormsDataControl As TSNAGRFORMSDATACONTROL, ByVal column As String, ByVal b46Str As String, ByVal connectionString As String) As Boolean

        Dim conn As SqlConnection = New SqlConnection(connectionString)
       conn.Open()

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))

       Dim sSQL As String = "UPDATE tSnagRFormsDataControl SET " & column & "=@Image WHERE ID = " & tSnagRFormsDataControl.ID
       cmd.CommandText = sSQL
        cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
       cmd.ExecuteNonQuery()

       conn.Close()
       conn.Dispose()

   End Function

    Public Shared Function updateBlob(ByVal tSnagRFormsDataControl As TSNAGRFORMSDATACONTROL, ByVal column As String, ByVal b46Str As String, ByVal conn As SqlConnection) As Boolean

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))
Dim sSQL As String = "UPDATE tSnagRFormsDataControl SET " & column & "=@Image WHERE ID = " & tSnagRFormsDataControl.ID
cmd.CommandText = sSQL
cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
cmd.ExecuteNonQuery()

   End Function

    Public Shared Function delete(ByVal tSnagRFormsDataControl As TSNAGRFORMSDATACONTROL, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Delete from tSnagRFormsDataControl Where [ID] = " & tSnagRFormsDataControl.ID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

   Private Shared Function loadFromResultSet(ByVal obj As TSNAGRFORMSDATACONTROL, ByVal resultset As DataRow) As TSNAGRFORMSDATACONTROL
      obj.ID = ProcessNull.GetInt32(resultset.Item("ID"))
      obj.Datestamp = ProcessNull.GetDateTime(resultset.Item("Datestamp"))
      obj.fromURL = ProcessNull.GetString(resultset.Item("fromURL"))

       Return obj

   End Function

End Class

