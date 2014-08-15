Imports SnagRWeb_Project.SnagRData
Imports System.Data.SqlClient

Public Class TSNAGRINSPECTIONDATA

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
   Private [_DrwgID] As Int32
   Public Property [DrwgID]() As Int32
       Get
           Return [_DrwgID]
       End Get
       Set(ByVal value As Int32)
           [_DrwgID] = value
       End Set
    End Property
   Private [_InspectionName] As String
   Public Property [InspectionName]() As String
       Get
           Return [_InspectionName]
       End Get
       Set(ByVal value As String)
           [_InspectionName] = value
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
   Private [_PlotID] As Int32
   Public Property [PlotID]() As Int32
       Get
           Return [_PlotID]
       End Get
       Set(ByVal value As Int32)
           [_PlotID] = value
       End Set
    End Property
   Private [_CreatedDate] As DateTime
   Public Property [CreatedDate]() As DateTime
       Get
           Return [_CreatedDate]
       End Get
       Set(ByVal value As DateTime)
           [_CreatedDate] = value
       End Set
    End Property
   Private [_CreatedBy] As String
   Public Property [CreatedBy]() As String
       Get
           Return [_CreatedBy]
       End Get
       Set(ByVal value As String)
           [_CreatedBy] = value
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
   Private [_ClosedDate] As DateTime
   Public Property [ClosedDate]() As DateTime
       Get
           Return [_ClosedDate]
       End Get
       Set(ByVal value As DateTime)
           [_ClosedDate] = value
       End Set
    End Property
   Private [_ClosedBy] As String
   Public Property [ClosedBy]() As String
       Get
           Return [_ClosedBy]
       End Get
       Set(ByVal value As String)
           [_ClosedBy] = value
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
   Private [_CSStart] As DateTime
   Public Property [CSStart]() As DateTime
       Get
           Return [_CSStart]
       End Get
       Set(ByVal value As DateTime)
           [_CSStart] = value
       End Set
    End Property
   Private [_CSFinish] As DateTime
   Public Property [CSFinish]() As DateTime
       Get
           Return [_CSFinish]
       End Get
       Set(ByVal value As DateTime)
           [_CSFinish] = value
       End Set
    End Property
   Private [_RIGUID] As String
   Public Property [RIGUID]() As String
       Get
           Return [_RIGUID]
       End Get
       Set(ByVal value As String)
           [_RIGUID] = value
       End Set
    End Property
   Private [_FormID] As Int32
   Public Property [FormID]() As Int32
       Get
           Return [_FormID]
       End Get
       Set(ByVal value As Int32)
           [_FormID] = value
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
   Private [_FormName] As String
   Public Property [FormName]() As String
       Get
           Return [_FormName]
       End Get
       Set(ByVal value As String)
           [_FormName] = value
       End Set
    End Property
   Private [_FormShortName] As String
   Public Property [FormShortName]() As String
       Get
           Return [_FormShortName]
       End Get
       Set(ByVal value As String)
           [_FormShortName] = value
       End Set
    End Property
   Private [_IssuedDate] As DateTime
   Public Property [IssuedDate]() As DateTime
       Get
           Return [_IssuedDate]
       End Get
       Set(ByVal value As DateTime)
           [_IssuedDate] = value
       End Set
    End Property
   Private [_ValidUntil] As DateTime
   Public Property [ValidUntil]() As DateTime
       Get
           Return [_ValidUntil]
       End Get
       Set(ByVal value As DateTime)
           [_ValidUntil] = value
       End Set
    End Property
   Private [_IssuedTo] As String
   Public Property [IssuedTo]() As String
       Get
           Return [_IssuedTo]
       End Get
       Set(ByVal value As String)
           [_IssuedTo] = value
       End Set
    End Property
   Private [_IssuedBy] As String
   Public Property [IssuedBy]() As String
       Get
           Return [_IssuedBy]
       End Get
       Set(ByVal value As String)
           [_IssuedBy] = value
       End Set
    End Property
   Private [_AcceptedBy] As String
   Public Property [AcceptedBy]() As String
       Get
           Return [_AcceptedBy]
       End Get
       Set(ByVal value As String)
           [_AcceptedBy] = value
       End Set
    End Property
   Private [_Closed] As Boolean
   Public Property [Closed]() As Boolean
       Get
           Return [_Closed]
       End Get
       Set(ByVal value As Boolean)
           [_Closed] = value
       End Set
    End Property
   Private [_Passed] As Boolean
   Public Property [Passed]() As Boolean
       Get
           Return [_Passed]
       End Get
       Set(ByVal value As Boolean)
           [_Passed] = value
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
   Private [_Categ] As String
   Public Property [Categ]() As String
       Get
           Return [_Categ]
       End Get
       Set(ByVal value As String)
           [_Categ] = value
       End Set
    End Property
   Private [_Question] As String
   Public Property [Question]() As String
       Get
           Return [_Question]
       End Get
       Set(ByVal value As String)
           [_Question] = value
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
   Private [_Result] As Boolean
   Public Property [Result]() As Boolean
       Get
           Return [_Result]
       End Get
       Set(ByVal value As Boolean)
           [_Result] = value
       End Set
    End Property
   Private [_ResultText] As String
   Public Property [ResultText]() As String
       Get
           Return [_ResultText]
       End Get
       Set(ByVal value As String)
           [_ResultText] = value
       End Set
    End Property
   Private [_ResultImg] As String
   Public Property [ResultImg]() As String
       Get
           Return [_ResultImg]
       End Get
       Set(ByVal value As String)
           [_ResultImg] = value
       End Set
    End Property
   Private [_FIAID] As Int32
   Public Property [FIAID]() As Int32
       Get
           Return [_FIAID]
       End Get
       Set(ByVal value As Int32)
           [_FIAID] = value
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
   Private [_Datestamp] As DateTime
   Public Property [Datestamp]() As DateTime
       Get
           Return [_Datestamp]
       End Get
       Set(ByVal value As DateTime)
           [_Datestamp] = value
       End Set
    End Property
   Private [_AnswerType] As String
   Public Property [AnswerType]() As String
       Get
           Return [_AnswerType]
       End Get
       Set(ByVal value As String)
           [_AnswerType] = value
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
   Private [_PageNo] As Int32
   Public Property [PageNo]() As Int32
       Get
           Return [_PageNo]
       End Get
       Set(ByVal value As Int32)
           [_PageNo] = value
       End Set
    End Property
   Private [_FCID] As Int32
   Public Property [FCID]() As Int32
       Get
           Return [_FCID]
       End Get
       Set(ByVal value As Int32)
           [_FCID] = value
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
   Private [_FCGUID] As String
   Public Property [FCGUID]() As String
       Get
           Return [_FCGUID]
       End Get
       Set(ByVal value As String)
           [_FCGUID] = value
       End Set
    End Property
   Private [_AutoSnagged] As Boolean
   Public Property [AutoSnagged]() As Boolean
       Get
           Return [_AutoSnagged]
       End Get
       Set(ByVal value As Boolean)
           [_AutoSnagged] = value
       End Set
    End Property

End Class

Public Class TSNAGRINSPECTIONDATADAO

   Public Shared Function getUsingID(ByVal ID As Int32, ByVal connectionString As String, Optional ByVal Limit As Integer = 0) As TSNAGRINSPECTIONDATA
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSnagRInspectionData Where ID = "  & ID, connectionString)
       Else
           dt  = SnagRData.GetDataTable("Select * from tSnagRInspectionData Where ID = "  & ID, connectionString)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TSNAGRINSPECTIONDATA, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getUsingID(ByVal ID As Int32, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0) As TSNAGRINSPECTIONDATA
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSnagRInspectionData Where ID = "  & ID, conn)
       Else
           dt  = SnagRData.GetDataTable("Select * from tSnagRInspectionData Where ID = "  & ID, conn)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TSNAGRINSPECTIONDATA, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0, Optional sql as String = Nothing) As List(Of TSNAGRINSPECTIONDATA)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, connectionString)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSnagRInspectionData Where " + where, connectionString)
       Else
           dt = SnagRData.GetDataTable("Select * from tSnagRInspectionData Where " + where, connectionString)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TSNAGRINSPECTIONDATA)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TSNAGRINSPECTIONDATA, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0, Optional ByVal sql as String = Nothing) As List(Of TSNAGRINSPECTIONDATA)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, conn)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSnagRInspectionData Where " + where, conn)
       Else
           dt = SnagRData.GetDataTable("Select * from tSnagRInspectionData Where " + where, conn)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TSNAGRINSPECTIONDATA)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TSNAGRINSPECTIONDATA, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

    Public Shared Function insert(ByVal tSnagRInspectionData As TSNAGRINSPECTIONDATA, ByVal connectionString As String) As Boolean

        Dim sSQL As String = "Insert into tSnagRInspectionData (ProjectTitle, [ContractNo], [Drawing], [DrwgID], [InspectionName], [Location], [LocID], [LocationExtRef], [PlotID], [CreatedDate], [CreatedBy], [Status], [ClosedDate], [ClosedBy], [PPCGUID], [CSStart], [CSFinish], [RIGUID], [FormID], [FormCode], [FormName], [FormShortName], [IssuedDate], [ValidUntil], [IssuedTo], [IssuedBy], [AcceptedBy], [Closed], [Passed], [CheckCode], [Categ], [Question], [srt], [Result], [ResultText], [ResultImg], [FIAID], [Username], [Datestamp], [AnswerType], [Mandatory], [PageNo], [FCID], [ListCode], [LinkCheckCode], [FCGUID], [AutoSnagged]) Values (" & "N'" & tSnagRInspectionData.ProjectTitle & "'" & ", " & "N'" & tSnagRInspectionData.ContractNo & "'" & ", " & "N'" & tSnagRInspectionData.Drawing & "'" & ", " & tSnagRInspectionData.DrwgID & ", " & "N'" & tSnagRInspectionData.InspectionName & "'" & ", " & "N'" & tSnagRInspectionData.Location & "'" & ", " & tSnagRInspectionData.LocID & ", " & "N'" & tSnagRInspectionData.LocationExtRef & "'" & ", " & tSnagRInspectionData.PlotID & ", " & IIf(tSnagRInspectionData.CreatedDate = Nothing, "null", "'" & tSnagRInspectionData.CreatedDate.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tSnagRInspectionData.CreatedBy & "'" & ", " & "N'" & tSnagRInspectionData.Status & "'" & ", " & IIf(tSnagRInspectionData.ClosedDate = Nothing, "null", "'" & tSnagRInspectionData.ClosedDate.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tSnagRInspectionData.ClosedBy & "'" & ", " & "N'" & tSnagRInspectionData.PPCGUID & "'" & ", " & IIf(tSnagRInspectionData.CSStart = Nothing, "null", "'" & tSnagRInspectionData.CSStart.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & IIf(tSnagRInspectionData.CSFinish = Nothing, "null", "'" & tSnagRInspectionData.CSFinish.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tSnagRInspectionData.RIGUID & "'" & ", " & tSnagRInspectionData.FormID & ", " & "N'" & tSnagRInspectionData.FormCode & "'" & ", " & "N'" & tSnagRInspectionData.FormName & "'" & ", " & "N'" & tSnagRInspectionData.FormShortName & "'" & ", " & IIf(tSnagRInspectionData.IssuedDate = Nothing, "null", "'" & tSnagRInspectionData.IssuedDate.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & IIf(tSnagRInspectionData.ValidUntil = Nothing, "null", "'" & tSnagRInspectionData.ValidUntil.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tSnagRInspectionData.IssuedTo & "'" & ", " & "N'" & tSnagRInspectionData.IssuedBy & "'" & ", " & "N'" & tSnagRInspectionData.AcceptedBy & "'" & ", " & "'" & tSnagRInspectionData.Closed & "'" & ", " & "'" & tSnagRInspectionData.Passed & "'" & ", " & "N'" & tSnagRInspectionData.CheckCode & "'" & ", " & "N'" & tSnagRInspectionData.Categ & "'" & ", " & "N'" & tSnagRInspectionData.Question & "'" & ", " & "N'" & tSnagRInspectionData.srt & "'" & ", " & "'" & tSnagRInspectionData.Result & "'" & ", " & "N'" & tSnagRInspectionData.ResultText & "'" & ", " & "null" & ", " & tSnagRInspectionData.FIAID & ", " & "N'" & tSnagRInspectionData.Username & "'" & ", " & IIf(tSnagRInspectionData.Datestamp = Nothing, "null", "'" & tSnagRInspectionData.Datestamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tSnagRInspectionData.AnswerType & "'" & ", " & "'" & tSnagRInspectionData.Mandatory & "'" & ", " & tSnagRInspectionData.PageNo & ", " & tSnagRInspectionData.FCID & ", " & "N'" & tSnagRInspectionData.ListCode & "'" & ", " & "N'" & tSnagRInspectionData.LinkCheckCode & "'" & ", " & "N'" & tSnagRInspectionData.FCGUID & "'" & ", " & "'" & tSnagRInspectionData.AutoSnagged & "'" & ")"
       Return SnagRData.RunSQL(connectionString, sSQL)

   End Function

    Public Shared Function insert(ByVal tSnagRInspectionData As TSNAGRINSPECTIONDATA, ByVal conn As SqlConnection) As Boolean

        Dim sSQL As String = "Insert into tSnagRInspectionData ([ProjectTitle], [ContractNo], [Drawing], [DrwgID], [InspectionName], [Location], [LocID], [LocationExtRef], [PlotID], [CreatedDate], [CreatedBy], [Status], [ClosedDate], [ClosedBy], [PPCGUID], [CSStart], [CSFinish], [RIGUID], [FormID], [FormCode], [FormName], [FormShortName], [IssuedDate], [ValidUntil], [IssuedTo], [IssuedBy], [AcceptedBy], [Closed], [Passed], [CheckCode], [Categ], [Question], [srt], [Result], [ResultText], [ResultImg], [FIAID], [Username], [Datestamp], [AnswerType], [Mandatory], [PageNo], [FCID], [ListCode], [LinkCheckCode], [FCGUID], [AutoSnagged]) Values (" & "N'" & tSnagRInspectionData.ProjectTitle & "'" & ", " & "N'" & tSnagRInspectionData.ContractNo & "'" & ", " & "N'" & tSnagRInspectionData.Drawing & "'" & ", " & tSnagRInspectionData.DrwgID & ", " & "N'" & tSnagRInspectionData.InspectionName & "'" & ", " & "N'" & tSnagRInspectionData.Location & "'" & ", " & tSnagRInspectionData.LocID & ", " & "N'" & tSnagRInspectionData.LocationExtRef & "'" & ", " & tSnagRInspectionData.PlotID & ", " & IIf(tSnagRInspectionData.CreatedDate = Nothing, "null", "'" & tSnagRInspectionData.CreatedDate.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tSnagRInspectionData.CreatedBy & "'" & ", " & "N'" & tSnagRInspectionData.Status & "'" & ", " & IIf(tSnagRInspectionData.ClosedDate = Nothing, "null", "'" & tSnagRInspectionData.ClosedDate.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tSnagRInspectionData.ClosedBy & "'" & ", " & "N'" & tSnagRInspectionData.PPCGUID & "'" & ", " & IIf(tSnagRInspectionData.CSStart = Nothing, "null", "'" & tSnagRInspectionData.CSStart.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & IIf(tSnagRInspectionData.CSFinish = Nothing, "null", "'" & tSnagRInspectionData.CSFinish.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tSnagRInspectionData.RIGUID & "'" & ", " & tSnagRInspectionData.FormID & ", " & "N'" & tSnagRInspectionData.FormCode & "'" & ", " & "N'" & tSnagRInspectionData.FormName & "'" & ", " & "N'" & tSnagRInspectionData.FormShortName & "'" & ", " & IIf(tSnagRInspectionData.IssuedDate = Nothing, "null", "'" & tSnagRInspectionData.IssuedDate.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & IIf(tSnagRInspectionData.ValidUntil = Nothing, "null", "'" & tSnagRInspectionData.ValidUntil.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tSnagRInspectionData.IssuedTo & "'" & ", " & "N'" & tSnagRInspectionData.IssuedBy & "'" & ", " & "N'" & tSnagRInspectionData.AcceptedBy & "'" & ", " & "'" & tSnagRInspectionData.Closed & "'" & ", " & "'" & tSnagRInspectionData.Passed & "'" & ", " & "N'" & tSnagRInspectionData.CheckCode & "'" & ", " & "N'" & tSnagRInspectionData.Categ & "'" & ", " & "N'" & tSnagRInspectionData.Question & "'" & ", " & "N'" & tSnagRInspectionData.srt & "'" & ", " & "'" & tSnagRInspectionData.Result & "'" & ", " & "N'" & tSnagRInspectionData.ResultText & "'" & ", " & "null" & ", " & tSnagRInspectionData.FIAID & ", " & "N'" & tSnagRInspectionData.Username & "'" & ", " & IIf(tSnagRInspectionData.Datestamp = Nothing, "null", "'" & tSnagRInspectionData.Datestamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tSnagRInspectionData.AnswerType & "'" & ", " & "'" & tSnagRInspectionData.Mandatory & "'" & ", " & tSnagRInspectionData.PageNo & ", " & tSnagRInspectionData.FCID & ", " & "N'" & tSnagRInspectionData.ListCode & "'" & ", " & "N'" & tSnagRInspectionData.LinkCheckCode & "'" & ", " & "N'" & tSnagRInspectionData.FCGUID & "'" & ", " & "'" & tSnagRInspectionData.AutoSnagged & "'" & ")"
       Return SnagRData.RunSQL(conn, sSQL)

   End Function

    Public Shared Function update(ByVal tSnagRInspectionData As TSNAGRINSPECTIONDATA, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Update tSnagRInspectionData Set [ProjectTitle] = N'" & tSnagRInspectionData.ProjectTitle & "'" & ", [ContractNo] = N'" & tSnagRInspectionData.ContractNo & "'" & ", [Drawing] = N'" & tSnagRInspectionData.Drawing & "'" & ", [DrwgID] = " & tSnagRInspectionData.DrwgID & ", [InspectionName] = N'" & tSnagRInspectionData.InspectionName & "'" & ", [Location] = N'" & tSnagRInspectionData.Location & "'" & ", [LocID] = " & tSnagRInspectionData.LocID & ", [LocationExtRef] = N'" & tSnagRInspectionData.LocationExtRef & "'" & ", [PlotID] = " & tSnagRInspectionData.PlotID & ", [CreatedDate] = " & IIf(tSnagRInspectionData.CreatedDate = Nothing, "null", "'" & tSnagRInspectionData.CreatedDate.ToString("yyyy-MM-dd HH:mm") & "'") & ", [CreatedBy] = N'" & tSnagRInspectionData.CreatedBy & "'" & ", [Status] = N'" & tSnagRInspectionData.Status & "'" & ", [ClosedDate] = " & IIf(tSnagRInspectionData.ClosedDate = Nothing, "null", "'" & tSnagRInspectionData.ClosedDate.ToString("yyyy-MM-dd HH:mm") & "'") & ", [ClosedBy] = N'" & tSnagRInspectionData.ClosedBy & "'" & ", [PPCGUID] = N'" & tSnagRInspectionData.PPCGUID & "'" & ", [CSStart] = " & IIf(tSnagRInspectionData.CSStart = Nothing, "null", "'" & tSnagRInspectionData.CSStart.ToString("yyyy-MM-dd HH:mm") & "'") & ", [CSFinish] = " & IIf(tSnagRInspectionData.CSFinish = Nothing, "null", "'" & tSnagRInspectionData.CSFinish.ToString("yyyy-MM-dd HH:mm") & "'") & ", [RIGUID] = N'" & tSnagRInspectionData.RIGUID & "'" & ", [FormID] = " & tSnagRInspectionData.FormID & ", [FormCode] = N'" & tSnagRInspectionData.FormCode & "'" & ", [FormName] = N'" & tSnagRInspectionData.FormName & "'" & ", [FormShortName] = N'" & tSnagRInspectionData.FormShortName & "'" & ", [IssuedDate] = " & IIf(tSnagRInspectionData.IssuedDate = Nothing, "null", "'" & tSnagRInspectionData.IssuedDate.ToString("yyyy-MM-dd HH:mm") & "'") & ", [ValidUntil] = " & IIf(tSnagRInspectionData.ValidUntil = Nothing, "null", "'" & tSnagRInspectionData.ValidUntil.ToString("yyyy-MM-dd HH:mm") & "'") & ", [IssuedTo] = N'" & tSnagRInspectionData.IssuedTo & "'" & ", [IssuedBy] = N'" & tSnagRInspectionData.IssuedBy & "'" & ", [AcceptedBy] = N'" & tSnagRInspectionData.AcceptedBy & "'" & ", [Closed] = " & IIf(tSnagRInspectionData.Closed = True, "1", "0") & ", [Passed] = " & IIf(tSnagRInspectionData.Passed = True, "1", "0") & ", [CheckCode] = N'" & tSnagRInspectionData.CheckCode & "'" & ", [Categ] = N'" & tSnagRInspectionData.Categ & "'" & ", [Question] = N'" & tSnagRInspectionData.Question & "'" & ", [srt] = N'" & tSnagRInspectionData.srt & "'" & ", [Result] = " & IIf(tSnagRInspectionData.Result = True, "1", "0") & ", [ResultText] = N'" & tSnagRInspectionData.ResultText & "'" & ", [FIAID] = " & tSnagRInspectionData.FIAID & ", [Username] = N'" & tSnagRInspectionData.Username & "'" & ", [Datestamp] = " & IIf(tSnagRInspectionData.Datestamp = Nothing, "null", "'" & tSnagRInspectionData.Datestamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", [AnswerType] = N'" & tSnagRInspectionData.AnswerType & "'" & ", [Mandatory] = " & IIf(tSnagRInspectionData.Mandatory = True, "1", "0") & ", [PageNo] = " & tSnagRInspectionData.PageNo & ", [FCID] = " & tSnagRInspectionData.FCID & ", [ListCode] = N'" & tSnagRInspectionData.ListCode & "'" & ", [LinkCheckCode] = N'" & tSnagRInspectionData.LinkCheckCode & "'" & ", [FCGUID] = N'" & tSnagRInspectionData.FCGUID & "'" & ", [AutoSnagged] = " & IIf(tSnagRInspectionData.AutoSnagged = True, "1", "0") & " Where [ID] = " & tSnagRInspectionData.ID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function update(ByVal tSnagRInspectionData As TSNAGRINSPECTIONDATA, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Update tSnagRInspectionData Set [ProjectTitle] = N'" & tSnagRInspectionData.ProjectTitle & "'" & ", [ContractNo] = N'" & tSnagRInspectionData.ContractNo & "'" & ", [Drawing] = N'" & tSnagRInspectionData.Drawing & "'" & ", [DrwgID] = " & tSnagRInspectionData.DrwgID & ", [InspectionName] = N'" & tSnagRInspectionData.InspectionName & "'" & ", [Location] = N'" & tSnagRInspectionData.Location & "'" & ", [LocID] = " & tSnagRInspectionData.LocID & ", [LocationExtRef] = N'" & tSnagRInspectionData.LocationExtRef & "'" & ", [PlotID] = " & tSnagRInspectionData.PlotID & ", [CreatedDate] = " & IIf(tSnagRInspectionData.CreatedDate = Nothing, "null", "'" & tSnagRInspectionData.CreatedDate.ToString("yyyy-MM-dd HH:mm") & "'") & ", [CreatedBy] = N'" & tSnagRInspectionData.CreatedBy & "'" & ", [Status] = N'" & tSnagRInspectionData.Status & "'" & ", [ClosedDate] = " & IIf(tSnagRInspectionData.ClosedDate = Nothing, "null", "'" & tSnagRInspectionData.ClosedDate.ToString("yyyy-MM-dd HH:mm") & "'") & ", [ClosedBy] = N'" & tSnagRInspectionData.ClosedBy & "'" & ", [PPCGUID] = N'" & tSnagRInspectionData.PPCGUID & "'" & ", [CSStart] = " & IIf(tSnagRInspectionData.CSStart = Nothing, "null", "'" & tSnagRInspectionData.CSStart.ToString("yyyy-MM-dd HH:mm") & "'") & ", [CSFinish] = " & IIf(tSnagRInspectionData.CSFinish = Nothing, "null", "'" & tSnagRInspectionData.CSFinish.ToString("yyyy-MM-dd HH:mm") & "'") & ", [RIGUID] = N'" & tSnagRInspectionData.RIGUID & "'" & ", [FormID] = " & tSnagRInspectionData.FormID & ", [FormCode] = N'" & tSnagRInspectionData.FormCode & "'" & ", [FormName] = N'" & tSnagRInspectionData.FormName & "'" & ", [FormShortName] = N'" & tSnagRInspectionData.FormShortName & "'" & ", [IssuedDate] = " & IIf(tSnagRInspectionData.IssuedDate = Nothing, "null", "'" & tSnagRInspectionData.IssuedDate.ToString("yyyy-MM-dd HH:mm") & "'") & ", [ValidUntil] = " & IIf(tSnagRInspectionData.ValidUntil = Nothing, "null", "'" & tSnagRInspectionData.ValidUntil.ToString("yyyy-MM-dd HH:mm") & "'") & ", [IssuedTo] = N'" & tSnagRInspectionData.IssuedTo & "'" & ", [IssuedBy] = N'" & tSnagRInspectionData.IssuedBy & "'" & ", [AcceptedBy] = N'" & tSnagRInspectionData.AcceptedBy & "'" & ", [Closed] = " & IIf(tSnagRInspectionData.Closed = True, "1", "0") & ", [Passed] = " & IIf(tSnagRInspectionData.Passed = True, "1", "0") & ", [CheckCode] = N'" & tSnagRInspectionData.CheckCode & "'" & ", [Categ] = N'" & tSnagRInspectionData.Categ & "'" & ", [Question] = N'" & tSnagRInspectionData.Question & "'" & ", [srt] = N'" & tSnagRInspectionData.srt & "'" & ", [Result] = " & IIf(tSnagRInspectionData.Result = True, "1", "0") & ", [ResultText] = N'" & tSnagRInspectionData.ResultText & "'" & ", [FIAID] = " & tSnagRInspectionData.FIAID & ", [Username] = N'" & tSnagRInspectionData.Username & "'" & ", [Datestamp] = " & IIf(tSnagRInspectionData.Datestamp = Nothing, "null", "'" & tSnagRInspectionData.Datestamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", [AnswerType] = N'" & tSnagRInspectionData.AnswerType & "'" & ", [Mandatory] = " & IIf(tSnagRInspectionData.Mandatory = True, "1", "0") & ", [PageNo] = " & tSnagRInspectionData.PageNo & ", [FCID] = " & tSnagRInspectionData.FCID & ", [ListCode] = N'" & tSnagRInspectionData.ListCode & "'" & ", [LinkCheckCode] = N'" & tSnagRInspectionData.LinkCheckCode & "'" & ", [FCGUID] = N'" & tSnagRInspectionData.FCGUID & "'" & ", [AutoSnagged] = " & IIf(tSnagRInspectionData.AutoSnagged = True, "1", "0") & " Where [ID] = " & tSnagRInspectionData.ID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

    Public Shared Function delete(ByVal tSnagRInspectionData As TSNAGRINSPECTIONDATA, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Delete from tSnagRInspectionData Where [ID] = " & tSnagRInspectionData.ID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function updateBlob(ByVal tSnagRInspectionData As TSNAGRINSPECTIONDATA, ByVal column As String, ByVal b46Str As String, ByVal connectionString As String) As Boolean

        Dim conn As SqlConnection = New SqlConnection(connectionString)
       conn.Open()

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))

       Dim sSQL As String = "UPDATE tSnagRInspectionData SET " & column & "=@Image WHERE ID = " & tSnagRInspectionData.ID
       cmd.CommandText = sSQL
        cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
       cmd.ExecuteNonQuery()

       conn.Close()
       conn.Dispose()

   End Function

    Public Shared Function updateBlob(ByVal tSnagRInspectionData As TSNAGRINSPECTIONDATA, ByVal column As String, ByVal b46Str As String, ByVal conn As SqlConnection) As Boolean

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))
Dim sSQL As String = "UPDATE tSnagRInspectionData SET " & column & "=@Image WHERE ID = " & tSnagRInspectionData.ID
cmd.CommandText = sSQL
cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
cmd.ExecuteNonQuery()

   End Function

    Public Shared Function delete(ByVal tSnagRInspectionData As TSNAGRINSPECTIONDATA, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Delete from tSnagRInspectionData Where [ID] = " & tSnagRInspectionData.ID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

   Private Shared Function loadFromResultSet(ByVal obj As TSNAGRINSPECTIONDATA, ByVal resultset As DataRow) As TSNAGRINSPECTIONDATA
      obj.ID = ProcessNull.GetInt32(resultset.Item("ID"))
      obj.ProjectTitle = ProcessNull.GetString(resultset.Item("ProjectTitle"))
      obj.ContractNo = ProcessNull.GetString(resultset.Item("ContractNo"))
      obj.Drawing = ProcessNull.GetString(resultset.Item("Drawing"))
      obj.DrwgID = ProcessNull.GetInt32(resultset.Item("DrwgID"))
      obj.InspectionName = ProcessNull.GetString(resultset.Item("InspectionName"))
      obj.Location = ProcessNull.GetString(resultset.Item("Location"))
      obj.LocID = ProcessNull.GetInt32(resultset.Item("LocID"))
      obj.LocationExtRef = ProcessNull.GetString(resultset.Item("LocationExtRef"))
      obj.PlotID = ProcessNull.GetInt32(resultset.Item("PlotID"))
      obj.CreatedDate = ProcessNull.GetDateTime(resultset.Item("CreatedDate"))
      obj.CreatedBy = ProcessNull.GetString(resultset.Item("CreatedBy"))
      obj.Status = ProcessNull.GetString(resultset.Item("Status"))
      obj.ClosedDate = ProcessNull.GetDateTime(resultset.Item("ClosedDate"))
      obj.ClosedBy = ProcessNull.GetString(resultset.Item("ClosedBy"))
      obj.PPCGUID = ProcessNull.GetString(resultset.Item("PPCGUID"))
      obj.CSStart = ProcessNull.GetDateTime(resultset.Item("CSStart"))
      obj.CSFinish = ProcessNull.GetDateTime(resultset.Item("CSFinish"))
      obj.RIGUID = ProcessNull.GetString(resultset.Item("RIGUID"))
      obj.FormID = ProcessNull.GetInt32(resultset.Item("FormID"))
      obj.FormCode = ProcessNull.GetString(resultset.Item("FormCode"))
      obj.FormName = ProcessNull.GetString(resultset.Item("FormName"))
      obj.FormShortName = ProcessNull.GetString(resultset.Item("FormShortName"))
      obj.IssuedDate = ProcessNull.GetDateTime(resultset.Item("IssuedDate"))
      obj.ValidUntil = ProcessNull.GetDateTime(resultset.Item("ValidUntil"))
      obj.IssuedTo = ProcessNull.GetString(resultset.Item("IssuedTo"))
      obj.IssuedBy = ProcessNull.GetString(resultset.Item("IssuedBy"))
      obj.AcceptedBy = ProcessNull.GetString(resultset.Item("AcceptedBy"))
       obj.Closed = ProcessNull.GetBoolean(resultset.Item("Closed"))
       obj.Passed = ProcessNull.GetBoolean(resultset.Item("Passed"))
      obj.CheckCode = ProcessNull.GetString(resultset.Item("CheckCode"))
      obj.Categ = ProcessNull.GetString(resultset.Item("Categ"))
      obj.Question = ProcessNull.GetString(resultset.Item("Question"))
      obj.srt = ProcessNull.GetString(resultset.Item("srt"))
       obj.Result = ProcessNull.GetBoolean(resultset.Item("Result"))
      obj.ResultText = ProcessNull.GetString(resultset.Item("ResultText"))
     If Not IsDBNull(resultset.Item("ResultImg")) Then
         obj.ResultImg = Convert.ToBase64String(resultset.Item("ResultImg"))
      End If
      obj.FIAID = ProcessNull.GetInt32(resultset.Item("FIAID"))
      obj.Username = ProcessNull.GetString(resultset.Item("Username"))
      obj.Datestamp = ProcessNull.GetDateTime(resultset.Item("Datestamp"))
      obj.AnswerType = ProcessNull.GetString(resultset.Item("AnswerType"))
       obj.Mandatory = ProcessNull.GetBoolean(resultset.Item("Mandatory"))
      obj.PageNo = ProcessNull.GetInt32(resultset.Item("PageNo"))
      obj.FCID = ProcessNull.GetInt32(resultset.Item("FCID"))
      obj.ListCode = ProcessNull.GetString(resultset.Item("ListCode"))
      obj.LinkCheckCode = ProcessNull.GetString(resultset.Item("LinkCheckCode"))
      obj.FCGUID = ProcessNull.GetString(resultset.Item("FCGUID"))
       obj.AutoSnagged = ProcessNull.GetBoolean(resultset.Item("AutoSnagged"))

       Return obj

   End Function

End Class

