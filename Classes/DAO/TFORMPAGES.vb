Imports SnagRWeb_Project.SnagRData
Imports System.Data.SqlClient

Public Class TFORMPAGES

   Private [_FPID] As Int32
   Public Property [FPID]() As Int32
       Get
           Return [_FPID]
       End Get
       Set(ByVal value As Int32)
           [_FPID] = value
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
   Private [_PageNo] As Int32
   Public Property [PageNo]() As Int32
       Get
           Return [_PageNo]
       End Get
       Set(ByVal value As Int32)
           [_PageNo] = value
       End Set
    End Property
   Private [_Photo] As String
   Public Property [Photo]() As String
       Get
           Return [_Photo]
       End Get
       Set(ByVal value As String)
           [_Photo] = value
       End Set
    End Property
   Private [_ImageFilename] As String
   Public Property [ImageFilename]() As String
       Get
           Return [_ImageFilename]
       End Get
       Set(ByVal value As String)
           [_ImageFilename] = value
       End Set
    End Property
   Private [_Width] As Int32
   Public Property [Width]() As Int32
       Get
           Return [_Width]
       End Get
       Set(ByVal value As Int32)
           [_Width] = value
       End Set
    End Property
   Private [_Height] As Int32
   Public Property [Height]() As Int32
       Get
           Return [_Height]
       End Get
       Set(ByVal value As Int32)
           [_Height] = value
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

Public Class TFORMPAGESDAO

   Public Shared Function getUsingFPID(ByVal FPID As Int32, ByVal connectionString As String, Optional ByVal Limit As Integer = 0) As TFORMPAGES
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormPages Where FPID = "  & FPID, connectionString)
       Else
           dt  = SnagRData.GetDataTable("Select * from tFormPages Where FPID = "  & FPID, connectionString)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TFORMPAGES, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getUsingFPID(ByVal FPID As Int32, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0) As TFORMPAGES
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormPages Where FPID = "  & FPID, conn)
       Else
           dt  = SnagRData.GetDataTable("Select * from tFormPages Where FPID = "  & FPID, conn)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TFORMPAGES, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0, Optional sql as String = Nothing) As List(Of TFORMPAGES)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, connectionString)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormPages Where " + where, connectionString)
       Else
           dt = SnagRData.GetDataTable("Select * from tFormPages Where " + where, connectionString)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TFORMPAGES)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TFORMPAGES, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0, Optional ByVal sql as String = Nothing) As List(Of TFORMPAGES)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, conn)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tFormPages Where " + where, conn)
       Else
           dt = SnagRData.GetDataTable("Select * from tFormPages Where " + where, conn)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TFORMPAGES)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TFORMPAGES, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

    Public Shared Function insert(ByVal tFormPages As TFORMPAGES, ByVal connectionString As String) As Boolean

        Dim sSQL As String = "Insert into tFormPages (FormCode, [PageNo], [Photo], [ImageFilename], [Width], [Height], [DateSync]) Values (" & "N'" & tFormPages.FormCode & "'" & ", " & tFormPages.PageNo & ", " & "null" & ", " & "N'" & tFormPages.ImageFilename & "'" & ", " & tFormPages.Width & ", " & tFormPages.Height & ", " & IIf(tFormPages.DateSync = Nothing, "null", "'" & tFormPages.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ")"
       Return SnagRData.RunSQL(connectionString, sSQL)

   End Function

    Public Shared Function insert(ByVal tFormPages As TFORMPAGES, ByVal conn As SqlConnection) As Boolean

        Dim sSQL As String = "Insert into tFormPages ([FormCode], [PageNo], [Photo], [ImageFilename], [Width], [Height], [DateSync]) Values (" & "N'" & tFormPages.FormCode & "'" & ", " & tFormPages.PageNo & ", " & "null" & ", " & "N'" & tFormPages.ImageFilename & "'" & ", " & tFormPages.Width & ", " & tFormPages.Height & ", " & IIf(tFormPages.DateSync = Nothing, "null", "'" & tFormPages.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ")"
       Return SnagRData.RunSQL(conn, sSQL)

   End Function

    Public Shared Function update(ByVal tFormPages As TFORMPAGES, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Update tFormPages Set [FormCode] = N'" & tFormPages.FormCode & "'" & ", [PageNo] = " & tFormPages.PageNo & ", [ImageFilename] = N'" & tFormPages.ImageFilename & "'" & ", [Width] = " & tFormPages.Width & ", [Height] = " & tFormPages.Height & ", [DateSync] = " & IIf(tFormPages.DateSync = Nothing, "null", "'" & tFormPages.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & " Where [FPID] = " & tFormPages.FPID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function update(ByVal tFormPages As TFORMPAGES, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Update tFormPages Set [FormCode] = N'" & tFormPages.FormCode & "'" & ", [PageNo] = " & tFormPages.PageNo & ", [ImageFilename] = N'" & tFormPages.ImageFilename & "'" & ", [Width] = " & tFormPages.Width & ", [Height] = " & tFormPages.Height & ", [DateSync] = " & IIf(tFormPages.DateSync = Nothing, "null", "'" & tFormPages.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & " Where [FPID] = " & tFormPages.FPID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

    Public Shared Function delete(ByVal tFormPages As TFORMPAGES, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Delete from tFormPages Where [FPID] = " & tFormPages.FPID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function updateBlob(ByVal tFormPages As TFORMPAGES, ByVal column As String, ByVal b46Str As String, ByVal connectionString As String) As Boolean

        Dim conn As SqlConnection = New SqlConnection(connectionString)
       conn.Open()

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))

       Dim sSQL As String = "UPDATE tFormPages SET " & column & "=@Image WHERE FPID = " & tFormPages.FPID
       cmd.CommandText = sSQL
        cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
       cmd.ExecuteNonQuery()

       conn.Close()
       conn.Dispose()

   End Function

    Public Shared Function updateBlob(ByVal tFormPages As TFORMPAGES, ByVal column As String, ByVal b46Str As String, ByVal conn As SqlConnection) As Boolean

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))
Dim sSQL As String = "UPDATE tFormPages SET " & column & "=@Image WHERE FPID = " & tFormPages.FPID
cmd.CommandText = sSQL
cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
cmd.ExecuteNonQuery()

   End Function

    Public Shared Function delete(ByVal tFormPages As TFORMPAGES, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Delete from tFormPages Where [FPID] = " & tFormPages.FPID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

   Private Shared Function loadFromResultSet(ByVal obj As TFORMPAGES, ByVal resultset As DataRow) As TFORMPAGES
      obj.FPID = ProcessNull.GetInt32(resultset.Item("FPID"))
      obj.FormCode = ProcessNull.GetString(resultset.Item("FormCode"))
      obj.PageNo = ProcessNull.GetInt32(resultset.Item("PageNo"))
     If Not IsDBNull(resultset.Item("Photo")) Then
         obj.Photo = Convert.ToBase64String(resultset.Item("Photo"))
      End If
      obj.ImageFilename = ProcessNull.GetString(resultset.Item("ImageFilename"))
      obj.Width = ProcessNull.GetInt32(resultset.Item("Width"))
      obj.Height = ProcessNull.GetInt32(resultset.Item("Height"))
      obj.DateSync = ProcessNull.GetDateTime(resultset.Item("DateSync"))

       Return obj

   End Function

End Class

