Imports SnagRWeb_Project.SnagRData
Imports System.Data.SqlClient

Public Class TSNAGS

   Private [_SnagID] As Int32
   Public Property [SnagID]() As Int32
       Get
           Return [_SnagID]
       End Get
       Set(ByVal value As Int32)
           [_SnagID] = value
       End Set
    End Property
   Private [_DrwgID] As Int32
   Public Property [DrwgID]() As Int32
       Get
           Return [_DrwgID]
       End Get
       Set(ByVal value As Int32)
           [_DrwgID] = value
       End Set
    End Property
   Private [_Status] As String
   Public Property [Status]() As String
       Get
           Return [_Status]
       End Get
       Set(ByVal value As String)
           [_Status] = value
       End Set
    End Property
   Private [_ShortDescrip] As String
   Public Property [ShortDescrip]() As String
       Get
           Return [_ShortDescrip]
       End Get
       Set(ByVal value As String)
           [_ShortDescrip] = value
       End Set
    End Property
   Private [_Xcoord] As Int32
   Public Property [Xcoord]() As Int32
       Get
           Return [_Xcoord]
       End Get
       Set(ByVal value As Int32)
           [_Xcoord] = value
       End Set
    End Property
   Private [_YCoord] As Int32
   Public Property [YCoord]() As Int32
       Get
           Return [_YCoord]
       End Get
       Set(ByVal value As Int32)
           [_YCoord] = value
       End Set
    End Property
   Private [_Priority] As Int32
   Public Property [Priority]() As Int32
       Get
           Return [_Priority]
       End Get
       Set(ByVal value As Int32)
           [_Priority] = value
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
   Private [_DrwgLink] As Int32
   Public Property [DrwgLink]() As Int32
       Get
           Return [_DrwgLink]
       End Get
       Set(ByVal value As Int32)
           [_DrwgLink] = value
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
   Private [_DoBy] As DateTime
   Public Property [DoBy]() As DateTime
       Get
           Return [_DoBy]
       End Get
       Set(ByVal value As DateTime)
           [_DoBy] = value
       End Set
    End Property
   Private [_PPCGUID] As String
   Public Property [PPCGUID]() As String
       Get
           Return [_PPCGUID]
       End Get
       Set(ByVal value As String)
           [_PPCGUID] = value
       End Set
    End Property
   Private [_GroupID] As Int32
   Public Property [GroupID]() As Int32
       Get
           Return [_GroupID]
       End Get
       Set(ByVal value As Int32)
           [_GroupID] = value
       End Set
    End Property
   Private [_GroupInits] As String
   Public Property [GroupInits]() As String
       Get
           Return [_GroupInits]
       End Get
       Set(ByVal value As String)
           [_GroupInits] = value
       End Set
    End Property
   Private [_DateClosed] As DateTime
   Public Property [DateClosed]() As DateTime
       Get
           Return [_DateClosed]
       End Get
       Set(ByVal value As DateTime)
           [_DateClosed] = value
       End Set
    End Property
   Private [_BigPhoto] As String
   Public Property [BigPhoto]() As String
       Get
           Return [_BigPhoto]
       End Get
       Set(ByVal value As String)
           [_BigPhoto] = value
       End Set
    End Property
   Private [_Lat] As Double
   Public Property [Lat]() As Double
       Get
           Return [_Lat]
       End Get
       Set(ByVal value As Double)
           [_Lat] = value
       End Set
    End Property
   Private [_Lng] As Double
   Public Property [Lng]() As Double
       Get
           Return [_Lng]
       End Get
       Set(ByVal value As Double)
           [_Lng] = value
       End Set
    End Property
   Private [_Owner] As Int32
   Public Property [Owner]() As Int32
       Get
           Return [_Owner]
       End Get
       Set(ByVal value As Int32)
           [_Owner] = value
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
   Private [_LocID] As Int32
   Public Property [LocID]() As Int32
       Get
           Return [_LocID]
       End Get
       Set(ByVal value As Int32)
           [_LocID] = value
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
   Private [_MPGUID] As String
   Public Property [MPGUID]() As String
       Get
           Return [_MPGUID]
       End Get
       Set(ByVal value As String)
           [_MPGUID] = value
       End Set
    End Property
   Private [_LocGUID] As String
   Public Property [LocGUID]() As String
       Get
           Return [_LocGUID]
       End Get
       Set(ByVal value As String)
           [_LocGUID] = value
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
   Private [_FCGUID] As String
   Public Property [FCGUID]() As String
       Get
           Return [_FCGUID]
       End Get
       Set(ByVal value As String)
           [_FCGUID] = value
       End Set
    End Property
   Private [_LinkFwdGUID] As String
   Public Property [LinkFwdGUID]() As String
       Get
           Return [_LinkFwdGUID]
       End Get
       Set(ByVal value As String)
           [_LinkFwdGUID] = value
       End Set
    End Property
   Private [_LinkBackGUID] As String
   Public Property [LinkBackGUID]() As String
       Get
           Return [_LinkBackGUID]
       End Get
       Set(ByVal value As String)
           [_LinkBackGUID] = value
       End Set
    End Property

End Class

Public Class TSNAGSDAO

   Public Shared Function getUsingSnagID(ByVal SnagID As Int32, ByVal connectionString As String, Optional ByVal Limit As Integer = 0) As TSNAGS
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSnags Where SnagID = "  & SnagID, connectionString)
       Else
           dt  = SnagRData.GetDataTable("Select * from tSnags Where SnagID = "  & SnagID, connectionString)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TSNAGS, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getUsingSnagID(ByVal SnagID As Int32, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0) As TSNAGS
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSnags Where SnagID = "  & SnagID, conn)
       Else
           dt  = SnagRData.GetDataTable("Select * from tSnags Where SnagID = "  & SnagID, conn)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TSNAGS, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0, Optional sql as String = Nothing) As List(Of TSNAGS)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, connectionString)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSnags Where " + where, connectionString)
       Else
           dt = SnagRData.GetDataTable("Select * from tSnags Where " + where, connectionString)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TSNAGS)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TSNAGS, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0, Optional ByVal sql as String = Nothing) As List(Of TSNAGS)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, conn)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSnags Where " + where, conn)
       Else
           dt = SnagRData.GetDataTable("Select * from tSnags Where " + where, conn)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TSNAGS)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TSNAGS, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

    Public Shared Function insert(ByVal tSnags As TSNAGS, ByVal connectionString As String) As Boolean

        Dim sSQL As String = "Insert into tSnags (DrwgID, [Status], [ShortDescrip], [Xcoord], [YCoord], [Priority], [Datestamp], [DrwgLink], [Photo], [DoBy], [PPCGUID], [GroupID], [GroupInits], [DateClosed], [BigPhoto], [Lat], [Lng], [Owner], [SDCode], [SDID], [LocID], [DateSync], [MPGUID], [LocGUID], [SCGUID], [FCGUID], [LinkFwdGUID], [LinkBackGUID]) Values (" & tSnags.DrwgID & ", " & "N'" & tSnags.Status & "'" & ", " & "N'" & tSnags.ShortDescrip & "'" & ", " & tSnags.Xcoord & ", " & tSnags.YCoord & ", " & tSnags.Priority & ", " & IIf(tSnags.Datestamp = Nothing, "null", "'" & tSnags.Datestamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & tSnags.DrwgLink & ", " & "null" & ", " & IIf(tSnags.DoBy = Nothing, "null", "'" & tSnags.DoBy.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tSnags.PPCGUID & "'" & ", " & tSnags.GroupID & ", " & "N'" & tSnags.GroupInits & "'" & ", " & IIf(tSnags.DateClosed = Nothing, "null", "'" & tSnags.DateClosed.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "null" & ", " & tSnags.Lat & ", " & tSnags.Lng & ", " & tSnags.Owner & ", " & "N'" & tSnags.SDCode & "'" & ", " & tSnags.SDID & ", " & tSnags.LocID & ", " & IIf(tSnags.DateSync = Nothing, "null", "'" & tSnags.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tSnags.MPGUID & "'" & ", " & "N'" & tSnags.LocGUID & "'" & ", " & "N'" & tSnags.SCGUID & "'" & ", " & "N'" & tSnags.FCGUID & "'" & ", " & "N'" & tSnags.LinkFwdGUID & "'" & ", " & "N'" & tSnags.LinkBackGUID & "'" & ")"
       Return SnagRData.RunSQL(connectionString, sSQL)

   End Function

    Public Shared Function insert(ByVal tSnags As TSNAGS, ByVal conn As SqlConnection) As Boolean

        Dim sSQL As String = "Insert into tSnags ([DrwgID], [Status], [ShortDescrip], [Xcoord], [YCoord], [Priority], [Datestamp], [DrwgLink], [Photo], [DoBy], [PPCGUID], [GroupID], [GroupInits], [DateClosed], [BigPhoto], [Lat], [Lng], [Owner], [SDCode], [SDID], [LocID], [DateSync], [MPGUID], [LocGUID], [SCGUID], [FCGUID], [LinkFwdGUID], [LinkBackGUID]) Values (" & tSnags.DrwgID & ", " & "N'" & tSnags.Status & "'" & ", " & "N'" & tSnags.ShortDescrip & "'" & ", " & tSnags.Xcoord & ", " & tSnags.YCoord & ", " & tSnags.Priority & ", " & IIf(tSnags.Datestamp = Nothing, "null", "'" & tSnags.Datestamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & tSnags.DrwgLink & ", " & "null" & ", " & IIf(tSnags.DoBy = Nothing, "null", "'" & tSnags.DoBy.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tSnags.PPCGUID & "'" & ", " & tSnags.GroupID & ", " & "N'" & tSnags.GroupInits & "'" & ", " & IIf(tSnags.DateClosed = Nothing, "null", "'" & tSnags.DateClosed.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "null" & ", " & tSnags.Lat & ", " & tSnags.Lng & ", " & tSnags.Owner & ", " & "N'" & tSnags.SDCode & "'" & ", " & tSnags.SDID & ", " & tSnags.LocID & ", " & IIf(tSnags.DateSync = Nothing, "null", "'" & tSnags.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tSnags.MPGUID & "'" & ", " & "N'" & tSnags.LocGUID & "'" & ", " & "N'" & tSnags.SCGUID & "'" & ", " & "N'" & tSnags.FCGUID & "'" & ", " & "N'" & tSnags.LinkFwdGUID & "'" & ", " & "N'" & tSnags.LinkBackGUID & "'" & ")"

        Return SnagRData.RunSQL(conn, sSQL)

   End Function

    Public Shared Function update(ByVal tSnags As TSNAGS, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Update tSnags Set [DrwgID] = " & tSnags.DrwgID & ", [Status] = N'" & tSnags.Status & "'" & ", [ShortDescrip] = N'" & tSnags.ShortDescrip & "'" & ", [Xcoord] = " & tSnags.Xcoord & ", [YCoord] = " & tSnags.YCoord & ", [Priority] = " & tSnags.Priority & ", [Datestamp] = " & IIf(tSnags.Datestamp = Nothing, "null", "'" & tSnags.Datestamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", [DrwgLink] = " & tSnags.DrwgLink & ", [DoBy] = " & IIf(tSnags.DoBy = Nothing, "null", "'" & tSnags.DoBy.ToString("yyyy-MM-dd HH:mm") & "'") & ", [PPCGUID] = N'" & tSnags.PPCGUID & "'" & ", [GroupID] = " & tSnags.GroupID & ", [GroupInits] = N'" & tSnags.GroupInits & "'" & ", [DateClosed] = " & IIf(tSnags.DateClosed = Nothing, "null", "'" & tSnags.DateClosed.ToString("yyyy-MM-dd HH:mm") & "'") & ", [Lat] = " & tSnags.Lat & ", [Lng] = " & tSnags.Lng & ", [Owner] = " & tSnags.Owner & ", [SDCode] = N'" & tSnags.SDCode & "'" & ", [SDID] = " & tSnags.SDID & ", [LocID] = " & tSnags.LocID & ", [DateSync] = " & IIf(tSnags.DateSync = Nothing, "null", "'" & tSnags.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [MPGUID] = N'" & tSnags.MPGUID & "'" & ", [LocGUID] = N'" & tSnags.LocGUID & "'" & ", [SCGUID] = N'" & tSnags.SCGUID & "'" & ", [FCGUID] = N'" & tSnags.FCGUID & "'" & ", [LinkFwdGUID] = N'" & tSnags.LinkFwdGUID & "'" & ", [LinkBackGUID] = N'" & tSnags.LinkBackGUID & "'" & " Where [SnagID] = " & tSnags.SnagID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function update(ByVal tSnags As TSNAGS, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Update tSnags Set [DrwgID] = " & tSnags.DrwgID & ", [Status] = N'" & tSnags.Status & "'" & ", [ShortDescrip] = N'" & tSnags.ShortDescrip & "'" & ", [Xcoord] = " & tSnags.Xcoord & ", [YCoord] = " & tSnags.YCoord & ", [Priority] = " & tSnags.Priority & ", [Datestamp] = " & IIf(tSnags.Datestamp = Nothing, "null", "'" & tSnags.Datestamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", [DrwgLink] = " & tSnags.DrwgLink & ", [DoBy] = " & IIf(tSnags.DoBy = Nothing, "null", "'" & tSnags.DoBy.ToString("yyyy-MM-dd HH:mm") & "'") & ", [PPCGUID] = N'" & tSnags.PPCGUID & "'" & ", [GroupID] = " & tSnags.GroupID & ", [GroupInits] = N'" & tSnags.GroupInits & "'" & ", [DateClosed] = " & IIf(tSnags.DateClosed = Nothing, "null", "'" & tSnags.DateClosed.ToString("yyyy-MM-dd HH:mm") & "'") & ", [Lat] = " & tSnags.Lat & ", [Lng] = " & tSnags.Lng & ", [Owner] = " & tSnags.Owner & ", [SDCode] = N'" & tSnags.SDCode & "'" & ", [SDID] = " & tSnags.SDID & ", [LocID] = " & tSnags.LocID & ", [DateSync] = " & IIf(tSnags.DateSync = Nothing, "null", "'" & tSnags.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [MPGUID] = N'" & tSnags.MPGUID & "'" & ", [LocGUID] = N'" & tSnags.LocGUID & "'" & ", [SCGUID] = N'" & tSnags.SCGUID & "'" & ", [FCGUID] = N'" & tSnags.FCGUID & "'" & ", [LinkFwdGUID] = N'" & tSnags.LinkFwdGUID & "'" & ", [LinkBackGUID] = N'" & tSnags.LinkBackGUID & "'" & " Where [SnagID] = " & tSnags.SnagID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

    Public Shared Function delete(ByVal tSnags As TSNAGS, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Delete from tSnags Where [SnagID] = " & tSnags.SnagID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function updateBlob(ByVal tSnags As TSNAGS, ByVal column As String, ByVal b46Str As String, ByVal connectionString As String) As Boolean

        Dim conn As SqlConnection = New SqlConnection(connectionString)
       conn.Open()

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))

       Dim sSQL As String = "UPDATE tSnags SET " & column & "=@Image WHERE SnagID = " & tSnags.SnagID
       cmd.CommandText = sSQL
        cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
       cmd.ExecuteNonQuery()

       conn.Close()
       conn.Dispose()

   End Function

    Public Shared Function updateBlob(ByVal tSnags As TSNAGS, ByVal column As String, ByVal b46Str As String, ByVal conn As SqlConnection) As Boolean

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))
Dim sSQL As String = "UPDATE tSnags SET " & column & "=@Image WHERE SnagID = " & tSnags.SnagID
cmd.CommandText = sSQL
cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
cmd.ExecuteNonQuery()

   End Function

    Public Shared Function delete(ByVal tSnags As TSNAGS, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Delete from tSnags Where [SnagID] = " & tSnags.SnagID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

    Public Shared Function loadFromResultSet(ByVal obj As TSNAGS, ByVal resultset As DataRow) As TSNAGS
        obj.SnagID = ProcessNull.GetInt32(resultset.Item("SnagID"))
        obj.DrwgID = ProcessNull.GetInt32(resultset.Item("DrwgID"))
        obj.Status = ProcessNull.GetString(resultset.Item("Status"))
        obj.ShortDescrip = ProcessNull.GetString(resultset.Item("ShortDescrip"))
        obj.Xcoord = ProcessNull.GetInt32(resultset.Item("Xcoord"))
        obj.YCoord = ProcessNull.GetInt32(resultset.Item("YCoord"))
        obj.Priority = ProcessNull.GetInt32(resultset.Item("Priority"))
        obj.Datestamp = ProcessNull.GetDateTime(resultset.Item("Datestamp"))
        obj.DrwgLink = ProcessNull.GetInt32(resultset.Item("DrwgLink"))
        If Not IsDBNull(resultset.Item("Photo")) Then
            obj.Photo = Convert.ToBase64String(resultset.Item("Photo"))
        End If
        obj.DoBy = ProcessNull.GetDateTime(resultset.Item("DoBy"))
        obj.PPCGUID = ProcessNull.GetString(resultset.Item("PPCGUID"))
        obj.GroupID = ProcessNull.GetInt32(resultset.Item("GroupID"))
        obj.GroupInits = ProcessNull.GetString(resultset.Item("GroupInits"))
        obj.DateClosed = ProcessNull.GetDateTime(resultset.Item("DateClosed"))
        If Not IsDBNull(resultset.Item("BigPhoto")) Then
            obj.BigPhoto = Convert.ToBase64String(resultset.Item("BigPhoto"))
        End If
        obj.Lat = ProcessNull.GetDouble(resultset.Item("Lat"))
        obj.Lng = ProcessNull.GetDouble(resultset.Item("Lng"))
        obj.Owner = ProcessNull.GetInt32(resultset.Item("Owner"))
        obj.SDCode = ProcessNull.GetString(resultset.Item("SDCode"))
        obj.SDID = ProcessNull.GetInt32(resultset.Item("SDID"))
        obj.LocID = ProcessNull.GetInt32(resultset.Item("LocID"))
        obj.DateSync = ProcessNull.GetDateTime(resultset.Item("DateSync"))
        obj.MPGUID = ProcessNull.GetString(resultset.Item("MPGUID"))
        obj.LocGUID = ProcessNull.GetString(resultset.Item("LocGUID"))
        obj.SCGUID = ProcessNull.GetString(resultset.Item("SCGUID"))
        obj.FCGUID = ProcessNull.GetString(resultset.Item("FCGUID"))
        obj.LinkFwdGUID = ProcessNull.GetString(resultset.Item("LinkFwdGUID"))
        obj.LinkBackGUID = ProcessNull.GetString(resultset.Item("LinkBackGUID"))

        Return obj

    End Function

End Class

