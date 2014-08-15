Imports SnagRWeb_Project.SnagRData
Imports System.Data.SqlClient

Public Class TPROJECTSNAGS

   Private [_ID] As Int32
   Public Property [ID]() As Int32
       Get
           Return [_ID]
       End Get
       Set(ByVal value As Int32)
           [_ID] = value
       End Set
    End Property
   Private [_ProjectTitle] As String
   Public Property [ProjectTitle]() As String
       Get
           Return [_ProjectTitle]
       End Get
       Set(ByVal value As String)
           [_ProjectTitle] = value
       End Set
    End Property
   Private [_ContractNo] As String
   Public Property [ContractNo]() As String
       Get
           Return [_ContractNo]
       End Get
       Set(ByVal value As String)
           [_ContractNo] = value
       End Set
    End Property
   Private [_Drawing] As String
   Public Property [Drawing]() As String
       Get
           Return [_Drawing]
       End Get
       Set(ByVal value As String)
           [_Drawing] = value
       End Set
    End Property
   Private [_SnagID] As Int32
   Public Property [SnagID]() As Int32
       Get
           Return [_SnagID]
       End Get
       Set(ByVal value As Int32)
           [_SnagID] = value
       End Set
    End Property
   Private [_ProjectLinkID] As Int32
   Public Property [ProjectLinkID]() As Int32
       Get
           Return [_ProjectLinkID]
       End Get
       Set(ByVal value As Int32)
           [_ProjectLinkID] = value
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
   Private [_LocID] As Int32
   Public Property [LocID]() As Int32
       Get
           Return [_LocID]
       End Get
       Set(ByVal value As Int32)
           [_LocID] = value
       End Set
    End Property
   Private [_LocationExtRef] As String
   Public Property [LocationExtRef]() As String
       Get
           Return [_LocationExtRef]
       End Get
       Set(ByVal value As String)
           [_LocationExtRef] = value
       End Set
    End Property
   Private [_Location] As String
   Public Property [Location]() As String
       Get
           Return [_Location]
       End Get
       Set(ByVal value As String)
           [_Location] = value
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
   Private [_DateSync] As DateTime
   Public Property [DateSync]() As DateTime
       Get
           Return [_DateSync]
       End Get
       Set(ByVal value As DateTime)
           [_DateSync] = value
       End Set
    End Property
   Private [_FixStatus] As String
   Public Property [FixStatus]() As String
       Get
           Return [_FixStatus]
       End Get
       Set(ByVal value As String)
           [_FixStatus] = value
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
   Private [_Purge] As Int32
   Public Property [Purge]() As Int32
       Get
           Return [_Purge]
       End Get
       Set(ByVal value As Int32)
           [_Purge] = value
       End Set
    End Property
   Private [_DaysLeft] As Int32
   Public Property [DaysLeft]() As Int32
       Get
           Return [_DaysLeft]
       End Get
       Set(ByVal value As Int32)
           [_DaysLeft] = value
       End Set
    End Property
   Private [_DrwgSrt] As Int32
   Public Property [DrwgSrt]() As Int32
       Get
           Return [_DrwgSrt]
       End Get
       Set(ByVal value As Int32)
           [_DrwgSrt] = value
       End Set
    End Property
   Private [_DrwgTitle] As String
   Public Property [DrwgTitle]() As String
       Get
           Return [_DrwgTitle]
       End Get
       Set(ByVal value As String)
           [_DrwgTitle] = value
       End Set
    End Property
   Private [_FixDescrip] As String
   Public Property [FixDescrip]() As String
       Get
           Return [_FixDescrip]
       End Get
       Set(ByVal value As String)
           [_FixDescrip] = value
       End Set
    End Property
   Private [_By] As Int32
   Public Property [By]() As Int32
       Get
           Return [_By]
       End Get
       Set(ByVal value As Int32)
           [_By] = value
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
   Private [_Fullname] As String
   Public Property [Fullname]() As String
       Get
           Return [_Fullname]
       End Get
       Set(ByVal value As String)
           [_Fullname] = value
       End Set
    End Property
   Private [_CanBeEmailed] As Boolean
   Public Property [CanBeEmailed]() As Boolean
       Get
           Return [_CanBeEmailed]
       End Get
       Set(ByVal value As Boolean)
           [_CanBeEmailed] = value
       End Set
    End Property
   Private [_srt] As Int32
   Public Property [srt]() As Int32
       Get
           Return [_srt]
       End Get
       Set(ByVal value As Int32)
           [_srt] = value
       End Set
    End Property
   Private [_LastChanged] As DateTime
   Public Property [LastChanged]() As DateTime
       Get
           Return [_LastChanged]
       End Get
       Set(ByVal value As DateTime)
           [_LastChanged] = value
       End Set
    End Property
   Private [_Groupname] As String
   Public Property [Groupname]() As String
       Get
           Return [_Groupname]
       End Get
       Set(ByVal value As String)
           [_Groupname] = value
       End Set
    End Property
   Private [_CoGroupID] As Int32
   Public Property [CoGroupID]() As Int32
       Get
           Return [_CoGroupID]
       End Get
       Set(ByVal value As Int32)
           [_CoGroupID] = value
       End Set
    End Property

End Class

Public Class TPROJECTSNAGSDAO

   Public Shared Function getUsingID(ByVal ID As Int32, ByVal connectionString As String, Optional ByVal Limit As Integer = 0) As TPROJECTSNAGS
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tProjectSnags Where ID = "  & ID, connectionString)
       Else
           dt  = SnagRData.GetDataTable("Select * from tProjectSnags Where ID = "  & ID, connectionString)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TPROJECTSNAGS, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getUsingID(ByVal ID As Int32, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0) As TPROJECTSNAGS
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tProjectSnags Where ID = "  & ID, conn)
       Else
           dt  = SnagRData.GetDataTable("Select * from tProjectSnags Where ID = "  & ID, conn)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TPROJECTSNAGS, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0, Optional sql as String = Nothing) As List(Of TPROJECTSNAGS)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, connectionString)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tProjectSnags Where " + where, connectionString)
       Else
           dt = SnagRData.GetDataTable("Select * from tProjectSnags Where " + where, connectionString)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TPROJECTSNAGS)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TPROJECTSNAGS, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0, Optional ByVal sql as String = Nothing) As List(Of TPROJECTSNAGS)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, conn)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tProjectSnags Where " + where, conn)
       Else
           dt = SnagRData.GetDataTable("Select * from tProjectSnags Where " + where, conn)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TPROJECTSNAGS)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TPROJECTSNAGS, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

    Public Shared Function insert(ByVal tProjectSnags As TPROJECTSNAGS, ByVal connectionString As String) As Boolean

        Dim sSQL As String = "Insert into tProjectSnags (ProjectTitle, [ContractNo], [Drawing], [SnagID], [ProjectLinkID], [DrwgID], [Status], [ShortDescrip], [LocID], [LocationExtRef], [Location], [Xcoord], [YCoord], [Priority], [Datestamp], [DrwgLink], [Photo], [DoBy], [GroupID], [GroupInits], [DateClosed], [BigPhoto], [Lat], [Lng], [Owner], [SDCode], [SDID], [DateSync], [FixStatus], [MPGUID], [Purge], [DaysLeft], [DrwgSrt], [DrwgTitle], [FixDescrip], [By], [UserID], [Fullname], [CanBeEmailed], [srt], [LastChanged], [Groupname], [CoGroupID]) Values (" & "N'" & tProjectSnags.ProjectTitle & "'" & ", " & "N'" & tProjectSnags.ContractNo & "'" & ", " & "N'" & tProjectSnags.Drawing & "'" & ", " & tProjectSnags.SnagID & ", " & tProjectSnags.ProjectLinkID & ", " & tProjectSnags.DrwgID & ", " & "N'" & tProjectSnags.Status & "'" & ", " & "N'" & tProjectSnags.ShortDescrip & "'" & ", " & tProjectSnags.LocID & ", " & "N'" & tProjectSnags.LocationExtRef & "'" & ", " & "N'" & tProjectSnags.Location & "'" & ", " & tProjectSnags.Xcoord & ", " & tProjectSnags.YCoord & ", " & tProjectSnags.Priority & ", " & IIf(tProjectSnags.Datestamp = Nothing, "null", "'" & tProjectSnags.Datestamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & tProjectSnags.DrwgLink & ", " & "null" & ", " & IIf(tProjectSnags.DoBy = Nothing, "null", "'" & tProjectSnags.DoBy.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & tProjectSnags.GroupID & ", " & "N'" & tProjectSnags.GroupInits & "'" & ", " & IIf(tProjectSnags.DateClosed = Nothing, "null", "'" & tProjectSnags.DateClosed.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "null" & ", " & tProjectSnags.Lat & ", " & tProjectSnags.Lng & ", " & tProjectSnags.Owner & ", " & "N'" & tProjectSnags.SDCode & "'" & ", " & tProjectSnags.SDID & ", " & IIf(tProjectSnags.DateSync = Nothing, "null", "'" & tProjectSnags.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tProjectSnags.FixStatus & "'" & ", " & "N'" & tProjectSnags.MPGUID & "'" & ", " & tProjectSnags.Purge & ", " & tProjectSnags.DaysLeft & ", " & tProjectSnags.DrwgSrt & ", " & "N'" & tProjectSnags.DrwgTitle & "'" & ", " & "N'" & tProjectSnags.FixDescrip & "'" & ", " & tProjectSnags.By & ", " & tProjectSnags.UserID & ", " & "N'" & tProjectSnags.Fullname & "'" & ", " & "'" & tProjectSnags.CanBeEmailed & "'" & ", " & tProjectSnags.srt & ", " & IIf(tProjectSnags.LastChanged = Nothing, "null", "'" & tProjectSnags.LastChanged.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tProjectSnags.Groupname & "'" & ", " & tProjectSnags.CoGroupID & ")"
       Return SnagRData.RunSQL(connectionString, sSQL)

   End Function

    Public Shared Function insert(ByVal tProjectSnags As TPROJECTSNAGS, ByVal conn As SqlConnection) As Boolean

        Dim sSQL As String = "Insert into tProjectSnags ([ProjectTitle], [ContractNo], [Drawing], [SnagID], [ProjectLinkID], [DrwgID], [Status], [ShortDescrip], [LocID], [LocationExtRef], [Location], [Xcoord], [YCoord], [Priority], [Datestamp], [DrwgLink], [Photo], [DoBy], [GroupID], [GroupInits], [DateClosed], [BigPhoto], [Lat], [Lng], [Owner], [SDCode], [SDID], [DateSync], [FixStatus], [MPGUID], [Purge], [DaysLeft], [DrwgSrt], [DrwgTitle], [FixDescrip], [By], [UserID], [Fullname], [CanBeEmailed], [srt], [LastChanged], [Groupname], [CoGroupID]) Values (" & "N'" & tProjectSnags.ProjectTitle & "'" & ", " & "N'" & tProjectSnags.ContractNo & "'" & ", " & "N'" & tProjectSnags.Drawing & "'" & ", " & tProjectSnags.SnagID & ", " & tProjectSnags.ProjectLinkID & ", " & tProjectSnags.DrwgID & ", " & "N'" & tProjectSnags.Status & "'" & ", " & "N'" & tProjectSnags.ShortDescrip & "'" & ", " & tProjectSnags.LocID & ", " & "N'" & tProjectSnags.LocationExtRef & "'" & ", " & "N'" & tProjectSnags.Location & "'" & ", " & tProjectSnags.Xcoord & ", " & tProjectSnags.YCoord & ", " & tProjectSnags.Priority & ", " & IIf(tProjectSnags.Datestamp = Nothing, "null", "'" & tProjectSnags.Datestamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & tProjectSnags.DrwgLink & ", " & "null" & ", " & IIf(tProjectSnags.DoBy = Nothing, "null", "'" & tProjectSnags.DoBy.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & tProjectSnags.GroupID & ", " & "N'" & tProjectSnags.GroupInits & "'" & ", " & IIf(tProjectSnags.DateClosed = Nothing, "null", "'" & tProjectSnags.DateClosed.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "null" & ", " & tProjectSnags.Lat & ", " & tProjectSnags.Lng & ", " & tProjectSnags.Owner & ", " & "N'" & tProjectSnags.SDCode & "'" & ", " & tProjectSnags.SDID & ", " & IIf(tProjectSnags.DateSync = Nothing, "null", "'" & tProjectSnags.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tProjectSnags.FixStatus & "'" & ", " & "N'" & tProjectSnags.MPGUID & "'" & ", " & tProjectSnags.Purge & ", " & tProjectSnags.DaysLeft & ", " & tProjectSnags.DrwgSrt & ", " & "N'" & tProjectSnags.DrwgTitle & "'" & ", " & "N'" & tProjectSnags.FixDescrip & "'" & ", " & tProjectSnags.By & ", " & tProjectSnags.UserID & ", " & "N'" & tProjectSnags.Fullname & "'" & ", " & "'" & tProjectSnags.CanBeEmailed & "'" & ", " & tProjectSnags.srt & ", " & IIf(tProjectSnags.LastChanged = Nothing, "null", "'" & tProjectSnags.LastChanged.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tProjectSnags.Groupname & "'" & ", " & tProjectSnags.CoGroupID & ")"
       Return SnagRData.RunSQL(conn, sSQL)

   End Function

    Public Shared Function update(ByVal tProjectSnags As TPROJECTSNAGS, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Update tProjectSnags Set [ProjectTitle] = N'" & tProjectSnags.ProjectTitle & "'" & ", [ContractNo] = N'" & tProjectSnags.ContractNo & "'" & ", [Drawing] = N'" & tProjectSnags.Drawing & "'" & ", [SnagID] = " & tProjectSnags.SnagID & ", [ProjectLinkID] = " & tProjectSnags.ProjectLinkID & ", [DrwgID] = " & tProjectSnags.DrwgID & ", [Status] = N'" & tProjectSnags.Status & "'" & ", [ShortDescrip] = N'" & tProjectSnags.ShortDescrip & "'" & ", [LocID] = " & tProjectSnags.LocID & ", [LocationExtRef] = N'" & tProjectSnags.LocationExtRef & "'" & ", [Location] = N'" & tProjectSnags.Location & "'" & ", [Xcoord] = " & tProjectSnags.Xcoord & ", [YCoord] = " & tProjectSnags.YCoord & ", [Priority] = " & tProjectSnags.Priority & ", [Datestamp] = " & IIf(tProjectSnags.Datestamp = Nothing, "null", "'" & tProjectSnags.Datestamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", [DrwgLink] = " & tProjectSnags.DrwgLink & ", [DoBy] = " & IIf(tProjectSnags.DoBy = Nothing, "null", "'" & tProjectSnags.DoBy.ToString("yyyy-MM-dd HH:mm") & "'") & ", [GroupID] = " & tProjectSnags.GroupID & ", [GroupInits] = N'" & tProjectSnags.GroupInits & "'" & ", [DateClosed] = " & IIf(tProjectSnags.DateClosed = Nothing, "null", "'" & tProjectSnags.DateClosed.ToString("yyyy-MM-dd HH:mm") & "'") & ", [Lat] = " & tProjectSnags.Lat & ", [Lng] = " & tProjectSnags.Lng & ", [Owner] = " & tProjectSnags.Owner & ", [SDCode] = N'" & tProjectSnags.SDCode & "'" & ", [SDID] = " & tProjectSnags.SDID & ", [DateSync] = " & IIf(tProjectSnags.DateSync = Nothing, "null", "'" & tProjectSnags.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [FixStatus] = N'" & tProjectSnags.FixStatus & "'" & ", [MPGUID] = N'" & tProjectSnags.MPGUID & "'" & ", [Purge] = " & tProjectSnags.Purge & ", [DaysLeft] = " & tProjectSnags.DaysLeft & ", [DrwgSrt] = " & tProjectSnags.DrwgSrt & ", [DrwgTitle] = N'" & tProjectSnags.DrwgTitle & "'" & ", [FixDescrip] = N'" & tProjectSnags.FixDescrip & "'" & ", [By] = " & tProjectSnags.By & ", [UserID] = " & tProjectSnags.UserID & ", [Fullname] = N'" & tProjectSnags.Fullname & "'" & ", [CanBeEmailed] = " & IIf(tProjectSnags.CanBeEmailed = True, "1", "0") & ", [srt] = " & tProjectSnags.srt & ", [LastChanged] = " & IIf(tProjectSnags.LastChanged = Nothing, "null", "'" & tProjectSnags.LastChanged.ToString("yyyy-MM-dd HH:mm") & "'") & ", [Groupname] = N'" & tProjectSnags.Groupname & "'" & ", [CoGroupID] = " & tProjectSnags.CoGroupID & " Where [ID] = " & tProjectSnags.ID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function update(ByVal tProjectSnags As TPROJECTSNAGS, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Update tProjectSnags Set [ProjectTitle] = N'" & tProjectSnags.ProjectTitle & "'" & ", [ContractNo] = N'" & tProjectSnags.ContractNo & "'" & ", [Drawing] = N'" & tProjectSnags.Drawing & "'" & ", [SnagID] = " & tProjectSnags.SnagID & ", [ProjectLinkID] = " & tProjectSnags.ProjectLinkID & ", [DrwgID] = " & tProjectSnags.DrwgID & ", [Status] = N'" & tProjectSnags.Status & "'" & ", [ShortDescrip] = N'" & tProjectSnags.ShortDescrip & "'" & ", [LocID] = " & tProjectSnags.LocID & ", [LocationExtRef] = N'" & tProjectSnags.LocationExtRef & "'" & ", [Location] = N'" & tProjectSnags.Location & "'" & ", [Xcoord] = " & tProjectSnags.Xcoord & ", [YCoord] = " & tProjectSnags.YCoord & ", [Priority] = " & tProjectSnags.Priority & ", [Datestamp] = " & IIf(tProjectSnags.Datestamp = Nothing, "null", "'" & tProjectSnags.Datestamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", [DrwgLink] = " & tProjectSnags.DrwgLink & ", [DoBy] = " & IIf(tProjectSnags.DoBy = Nothing, "null", "'" & tProjectSnags.DoBy.ToString("yyyy-MM-dd HH:mm") & "'") & ", [GroupID] = " & tProjectSnags.GroupID & ", [GroupInits] = N'" & tProjectSnags.GroupInits & "'" & ", [DateClosed] = " & IIf(tProjectSnags.DateClosed = Nothing, "null", "'" & tProjectSnags.DateClosed.ToString("yyyy-MM-dd HH:mm") & "'") & ", [Lat] = " & tProjectSnags.Lat & ", [Lng] = " & tProjectSnags.Lng & ", [Owner] = " & tProjectSnags.Owner & ", [SDCode] = N'" & tProjectSnags.SDCode & "'" & ", [SDID] = " & tProjectSnags.SDID & ", [DateSync] = " & IIf(tProjectSnags.DateSync = Nothing, "null", "'" & tProjectSnags.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [FixStatus] = N'" & tProjectSnags.FixStatus & "'" & ", [MPGUID] = N'" & tProjectSnags.MPGUID & "'" & ", [Purge] = " & tProjectSnags.Purge & ", [DaysLeft] = " & tProjectSnags.DaysLeft & ", [DrwgSrt] = " & tProjectSnags.DrwgSrt & ", [DrwgTitle] = N'" & tProjectSnags.DrwgTitle & "'" & ", [FixDescrip] = N'" & tProjectSnags.FixDescrip & "'" & ", [By] = " & tProjectSnags.By & ", [UserID] = " & tProjectSnags.UserID & ", [Fullname] = N'" & tProjectSnags.Fullname & "'" & ", [CanBeEmailed] = " & IIf(tProjectSnags.CanBeEmailed = True, "1", "0") & ", [srt] = " & tProjectSnags.srt & ", [LastChanged] = " & IIf(tProjectSnags.LastChanged = Nothing, "null", "'" & tProjectSnags.LastChanged.ToString("yyyy-MM-dd HH:mm") & "'") & ", [Groupname] = N'" & tProjectSnags.Groupname & "'" & ", [CoGroupID] = " & tProjectSnags.CoGroupID & " Where [ID] = " & tProjectSnags.ID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

    Public Shared Function delete(ByVal tProjectSnags As TPROJECTSNAGS, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Delete from tProjectSnags Where [ID] = " & tProjectSnags.ID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function updateBlob(ByVal tProjectSnags As TPROJECTSNAGS, ByVal column As String, ByVal b46Str As String, ByVal connectionString As String) As Boolean

        Dim conn As SqlConnection = New SqlConnection(connectionString)
       conn.Open()

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))

       Dim sSQL As String = "UPDATE tProjectSnags SET " & column & "=@Image WHERE ID = " & tProjectSnags.ID
       cmd.CommandText = sSQL
        cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
       cmd.ExecuteNonQuery()

       conn.Close()
       conn.Dispose()

   End Function

    Public Shared Function updateBlob(ByVal tProjectSnags As TPROJECTSNAGS, ByVal column As String, ByVal b46Str As String, ByVal conn As SqlConnection) As Boolean

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))
Dim sSQL As String = "UPDATE tProjectSnags SET " & column & "=@Image WHERE ID = " & tProjectSnags.ID
cmd.CommandText = sSQL
cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
cmd.ExecuteNonQuery()

   End Function

    Public Shared Function delete(ByVal tProjectSnags As TPROJECTSNAGS, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Delete from tProjectSnags Where [ID] = " & tProjectSnags.ID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

   Private Shared Function loadFromResultSet(ByVal obj As TPROJECTSNAGS, ByVal resultset As DataRow) As TPROJECTSNAGS
      obj.ID = ProcessNull.GetInt32(resultset.Item("ID"))
      obj.ProjectTitle = ProcessNull.GetString(resultset.Item("ProjectTitle"))
      obj.ContractNo = ProcessNull.GetString(resultset.Item("ContractNo"))
      obj.Drawing = ProcessNull.GetString(resultset.Item("Drawing"))
      obj.SnagID = ProcessNull.GetInt32(resultset.Item("SnagID"))
      obj.ProjectLinkID = ProcessNull.GetInt32(resultset.Item("ProjectLinkID"))
      obj.DrwgID = ProcessNull.GetInt32(resultset.Item("DrwgID"))
      obj.Status = ProcessNull.GetString(resultset.Item("Status"))
      obj.ShortDescrip = ProcessNull.GetString(resultset.Item("ShortDescrip"))
      obj.LocID = ProcessNull.GetInt32(resultset.Item("LocID"))
      obj.LocationExtRef = ProcessNull.GetString(resultset.Item("LocationExtRef"))
      obj.Location = ProcessNull.GetString(resultset.Item("Location"))
      obj.Xcoord = ProcessNull.GetInt32(resultset.Item("Xcoord"))
      obj.YCoord = ProcessNull.GetInt32(resultset.Item("YCoord"))
      obj.Priority = ProcessNull.GetInt32(resultset.Item("Priority"))
      obj.Datestamp = ProcessNull.GetDateTime(resultset.Item("Datestamp"))
      obj.DrwgLink = ProcessNull.GetInt32(resultset.Item("DrwgLink"))
     If Not IsDBNull(resultset.Item("Photo")) Then
         obj.Photo = Convert.ToBase64String(resultset.Item("Photo"))
      End If
      obj.DoBy = ProcessNull.GetDateTime(resultset.Item("DoBy"))
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
      obj.DateSync = ProcessNull.GetDateTime(resultset.Item("DateSync"))
      obj.FixStatus = ProcessNull.GetString(resultset.Item("FixStatus"))
      obj.MPGUID = ProcessNull.GetString(resultset.Item("MPGUID"))
      obj.Purge = ProcessNull.GetInt32(resultset.Item("Purge"))
      obj.DaysLeft = ProcessNull.GetInt32(resultset.Item("DaysLeft"))
      obj.DrwgSrt = ProcessNull.GetInt32(resultset.Item("DrwgSrt"))
      obj.DrwgTitle = ProcessNull.GetString(resultset.Item("DrwgTitle"))
      obj.FixDescrip = ProcessNull.GetString(resultset.Item("FixDescrip"))
      obj.By = ProcessNull.GetInt32(resultset.Item("By"))
      obj.UserID = ProcessNull.GetInt32(resultset.Item("UserID"))
      obj.Fullname = ProcessNull.GetString(resultset.Item("Fullname"))
       obj.CanBeEmailed = ProcessNull.GetBoolean(resultset.Item("CanBeEmailed"))
      obj.srt = ProcessNull.GetInt32(resultset.Item("srt"))
      obj.LastChanged = ProcessNull.GetDateTime(resultset.Item("LastChanged"))
      obj.Groupname = ProcessNull.GetString(resultset.Item("Groupname"))
      obj.CoGroupID = ProcessNull.GetInt32(resultset.Item("CoGroupID"))

       Return obj

   End Function

End Class

