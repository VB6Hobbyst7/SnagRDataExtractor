Imports SnagRWeb_Project.SnagRData
Imports System.Data.SqlClient

Public Class TSCHEDPLOTS

    Private [_PlotID] As System.Nullable(Of Int32)
    Public Property [PlotID]() As System.Nullable(Of Int32)
        Get
            Return [_PlotID]
        End Get
        Set(ByVal value As System.Nullable(Of Int32))
            [_PlotID] = value
        End Set
    End Property
    Private [_SchedID] As System.Nullable(Of Int32)
    Public Property [SchedID]() As System.Nullable(Of Int32)
        Get
            Return [_SchedID]
        End Get
        Set(ByVal value As System.Nullable(Of Int32))
            [_SchedID] = value
        End Set
    End Property
    Private [_SchedInits] As String
    Public Property [SchedInits]() As String
        Get
            Return [_SchedInits]
        End Get
        Set(ByVal value As String)
            [_SchedInits] = value
        End Set
    End Property
    Private [_DrwgID] As System.Nullable(Of Int32)
    Public Property [DrwgID]() As System.Nullable(Of Int32)
        Get
            Return [_DrwgID]
        End Get
        Set(ByVal value As System.Nullable(Of Int32))
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
    Private [_DateStamp] As System.Nullable(Of DateTime)
    Public Property [DateStamp]() As System.Nullable(Of DateTime)
        Get
            Return [_DateStamp]
        End Get
        Set(ByVal value As System.Nullable(Of DateTime))
            [_DateStamp] = value
        End Set
    End Property
    Private [_PPCGuid] As String
    Public Property [PPCGuid]() As String
        Get
            Return [_PPCGuid]
        End Get
        Set(ByVal value As String)
            [_PPCGuid] = value
        End Set
    End Property
    Private [_DateSync] As System.Nullable(Of DateTime)
    Public Property [DateSync]() As System.Nullable(Of DateTime)
        Get
            Return [_DateSync]
        End Get
        Set(ByVal value As System.Nullable(Of DateTime))
            [_DateSync] = value
        End Set
    End Property
    Private [_Owner] As System.Nullable(Of Int32)
    Public Property [Owner]() As System.Nullable(Of Int32)
        Get
            Return [_Owner]
        End Get
        Set(ByVal value As System.Nullable(Of Int32))
            [_Owner] = value
        End Set
    End Property
    Private [_ExtRef] As String
    Public Property [ExtRef]() As String
        Get
            Return [_ExtRef]
        End Get
        Set(ByVal value As String)
            [_ExtRef] = value
        End Set
    End Property
    Private [_LocID] As System.Nullable(Of Int32)
    Public Property [LocID]() As System.Nullable(Of Int32)
        Get
            Return [_LocID]
        End Get
        Set(ByVal value As System.Nullable(Of Int32))
            [_LocID] = value
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
    Private [_ClosedDate] As System.Nullable(Of DateTime)
    Public Property [ClosedDate]() As System.Nullable(Of DateTime)
        Get
            Return [_ClosedDate]
        End Get
        Set(ByVal value As System.Nullable(Of DateTime))
            [_ClosedDate] = value
        End Set
    End Property
    Private [_ClosedBy] As System.Nullable(Of Int32)
    Public Property [ClosedBy]() As System.Nullable(Of Int32)
        Get
            Return [_ClosedBy]
        End Get
        Set(ByVal value As System.Nullable(Of Int32))
            [_ClosedBy] = value
        End Set
    End Property
    Private [_CSStart] As System.Nullable(Of DateTime)
    Public Property [CSStart]() As System.Nullable(Of DateTime)
        Get
            Return [_CSStart]
        End Get
        Set(ByVal value As System.Nullable(Of DateTime))
            [_CSStart] = value
        End Set
    End Property
    Private [_CSFinish] As System.Nullable(Of DateTime)
    Public Property [CSFinish]() As System.Nullable(Of DateTime)
        Get
            Return [_CSFinish]
        End Get
        Set(ByVal value As System.Nullable(Of DateTime))
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
    Private [_LastChanged] As System.Nullable(Of DateTime)
    Public Property [LastChanged]() As System.Nullable(Of DateTime)
        Get
            Return [_LastChanged]
        End Get
        Set(ByVal value As System.Nullable(Of DateTime))
            [_LastChanged] = value
        End Set
    End Property

End Class

Public Class TSCHEDPLOTSDAO

    Public Shared Function getUsingPlotID(ByVal PlotID As System.Nullable(Of Int32), ByVal connectionString As String, Optional ByVal Limit As Integer = 0) As TSCHEDPLOTS
        Dim dt As DataTable
        If Limit > 0 Then
            dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSchedPlots Where PlotID = " & PlotID, connectionString)
        Else
            dt = SnagRData.GetDataTable("Select * from tSchedPlots Where PlotID = " & PlotID, connectionString)
        End If

        If dt.Rows.Count > 0 Then
            Return loadFromResultSet(New TSCHEDPLOTS, dt.Rows(0))
        Else
            Return Nothing
        End If
    End Function

    Public Shared Function getUsingPlotID(ByVal PlotID As System.Nullable(Of Int32), ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0) As TSCHEDPLOTS
        Dim dt As DataTable
        If Limit > 0 Then
            dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSchedPlots Where PlotID = " & PlotID, conn)
        Else
            dt = SnagRData.GetDataTable("Select * from tSchedPlots Where PlotID = " & PlotID, conn)
        End If

        If dt.Rows.Count > 0 Then
            Return loadFromResultSet(New TSCHEDPLOTS, dt.Rows(0))
        Else
            Return Nothing
        End If
    End Function

    Public Shared Function getWhere(ByVal where As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0, Optional sql As String = Nothing) As List(Of TSCHEDPLOTS)
        Dim dt As DataTable

        If Not sql Is Nothing Then
            dt = SnagRData.GetDataTable(sql, connectionString)
        ElseIf Limit > 0 Then
            dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSchedPlots Where " + where, connectionString)
        Else
            dt = SnagRData.GetDataTable("Select * from tSchedPlots Where " + where, connectionString)
        End If

        If dt.Rows.Count > 0 Then
            Dim myList As New List(Of TSCHEDPLOTS)
            For i As Integer = 0 To dt.Rows.Count - 1
                myList.Add(loadFromResultSet(New TSCHEDPLOTS, dt.Rows(i)))
            Next
            Return myList
        Else
            Return Nothing
        End If
    End Function

    Public Shared Function getWhere(ByVal where As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0, Optional ByVal sql As String = Nothing) As List(Of TSCHEDPLOTS)
        Dim dt As DataTable

        If Not sql Is Nothing Then
            dt = SnagRData.GetDataTable(sql, conn)
        ElseIf Limit > 0 Then
            dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSchedPlots Where " + where, conn)
        Else
            dt = SnagRData.GetDataTable("Select * from tSchedPlots Where " + where, conn)
        End If

        If dt.Rows.Count > 0 Then
            Dim myList As New List(Of TSCHEDPLOTS)
            For i As Integer = 0 To dt.Rows.Count - 1
                myList.Add(loadFromResultSet(New TSCHEDPLOTS, dt.Rows(i)))
            Next
            Return myList
        Else
            Return Nothing
        End If
    End Function

    Public Shared Function insert(ByVal tSchedPlots As TSCHEDPLOTS, ByVal connectionString As String) As Boolean

        Dim sSQL As String = "Insert into tSchedPlots (SchedID, [SchedInits], [DrwgID], [Status], [ShortDescrip], [DateStamp], [PPCGuid], [DateSync], [Owner], [ExtRef], [LocID], [LocGUID], [ClosedDate], [ClosedBy], [CSStart], [CSFinish], [RIGUID], [LastChanged]) Values (" & tSchedPlots.SchedID & ", " & "N'" & tSchedPlots.SchedInits & "'" & ", " & tSchedPlots.DrwgID & ", " & "N'" & tSchedPlots.Status & "'" & ", " & "N'" & tSchedPlots.ShortDescrip & "'" & ", " & IIf(tSchedPlots.DateStamp = Nothing, "null", "'" & tSchedPlots.DateStamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tSchedPlots.PPCGuid & "'" & ", " & IIf(tSchedPlots.DateSync = Nothing, "null", "'" & tSchedPlots.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & tSchedPlots.Owner & ", " & "N'" & tSchedPlots.ExtRef & "'" & ", " & tSchedPlots.LocID & ", " & "N'" & tSchedPlots.LocGUID & "'" & ", " & IIf(tSchedPlots.ClosedDate = Nothing, "null", "'" & tSchedPlots.ClosedDate.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & tSchedPlots.ClosedBy & ", " & IIf(tSchedPlots.CSStart = Nothing, "null", "'" & tSchedPlots.CSStart.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & IIf(tSchedPlots.CSFinish = Nothing, "null", "'" & tSchedPlots.CSFinish.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tSchedPlots.RIGUID & "'" & ", " & IIf(tSchedPlots.LastChanged = Nothing, "null", "'" & tSchedPlots.LastChanged.ToString("yyyy-MM-dd HH:mm") & "'") & ")"
        Return SnagRData.RunSQL(connectionString, sSQL)

    End Function

    Public Shared Function insert(ByVal tSchedPlots As TSCHEDPLOTS, ByVal conn As SqlConnection) As Boolean

        Dim sSQL As String = "Insert into tSchedPlots ([SchedID], [SchedInits], [DrwgID], [Status], [ShortDescrip], [DateStamp], [PPCGuid], [DateSync], [Owner], [ExtRef], [LocID], [LocGUID], [ClosedDate], [ClosedBy], [CSStart], [CSFinish], [RIGUID], [LastChanged]) Values (" & tSchedPlots.SchedID & ", " & "N'" & tSchedPlots.SchedInits & "'" & ", " & tSchedPlots.DrwgID & ", " & "N'" & tSchedPlots.Status & "'" & ", " & "N'" & tSchedPlots.ShortDescrip & "'" & ", " & IIf(tSchedPlots.DateStamp = Nothing, "null", "'" & tSchedPlots.DateStamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tSchedPlots.PPCGuid & "'" & ", " & IIf(tSchedPlots.DateSync = Nothing, "null", "'" & tSchedPlots.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & tSchedPlots.Owner & ", " & "N'" & tSchedPlots.ExtRef & "'" & ", " & tSchedPlots.LocID & ", " & "N'" & tSchedPlots.LocGUID & "'" & ", " & IIf(tSchedPlots.ClosedDate = Nothing, "null", "'" & tSchedPlots.ClosedDate.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & tSchedPlots.ClosedBy & ", " & IIf(tSchedPlots.CSStart = Nothing, "null", "'" & tSchedPlots.CSStart.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & IIf(tSchedPlots.CSFinish = Nothing, "null", "'" & tSchedPlots.CSFinish.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & "N'" & tSchedPlots.RIGUID & "'" & ", " & IIf(tSchedPlots.LastChanged = Nothing, "null", "'" & tSchedPlots.LastChanged.ToString("yyyy-MM-dd HH:mm") & "'") & ")"
        Return SnagRData.RunSQL(conn, sSQL)

    End Function

    Public Shared Function update(ByVal tSchedPlots As TSCHEDPLOTS, ByVal connectionString As String) As Boolean

        Dim sSQL As String = "Update tSchedPlots Set [SchedID] = " & tSchedPlots.SchedID & ", [SchedInits] = N'" & tSchedPlots.SchedInits & "'" & ", [DrwgID] = " & tSchedPlots.DrwgID & ", [Status] = N'" & tSchedPlots.Status & "'" & ", [ShortDescrip] = N'" & tSchedPlots.ShortDescrip & "'" & ", [DateStamp] = " & IIf(tSchedPlots.DateStamp = Nothing, "null", "'" & tSchedPlots.DateStamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", [PPCGuid] = N'" & tSchedPlots.PPCGuid & "'" & ", [DateSync] = " & IIf(tSchedPlots.DateSync = Nothing, "null", "'" & tSchedPlots.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [Owner] = " & tSchedPlots.Owner & ", [ExtRef] = N'" & tSchedPlots.ExtRef & "'" & ", [LocID] = " & tSchedPlots.LocID & ", [LocGUID] = N'" & tSchedPlots.LocGUID & "'" & ", [ClosedDate] = " & IIf(tSchedPlots.ClosedDate = Nothing, "null", "'" & tSchedPlots.ClosedDate.ToString("yyyy-MM-dd HH:mm") & "'") & ", [ClosedBy] = " & tSchedPlots.ClosedBy & ", [CSStart] = " & IIf(tSchedPlots.CSStart = Nothing, "null", "'" & tSchedPlots.CSStart.ToString("yyyy-MM-dd HH:mm") & "'") & ", [CSFinish] = " & IIf(tSchedPlots.CSFinish = Nothing, "null", "'" & tSchedPlots.CSFinish.ToString("yyyy-MM-dd HH:mm") & "'") & ", [RIGUID] = N'" & tSchedPlots.RIGUID & "'" & ", [LastChanged] = " & IIf(tSchedPlots.LastChanged = Nothing, "null", "'" & tSchedPlots.LastChanged.ToString("yyyy-MM-dd HH:mm") & "'") & " Where [PlotID] = " & tSchedPlots.PlotID
        Return SnagRData.RunSQL(connectionString, sSQL)
    End Function

    Public Shared Function update(ByVal tSchedPlots As TSCHEDPLOTS, ByVal conn As SqlConnection) As Boolean

        Dim sSQL As String = "Update tSchedPlots Set [SchedID] = " & tSchedPlots.SchedID & ", [SchedInits] = N'" & tSchedPlots.SchedInits & "'" & ", [DrwgID] = " & tSchedPlots.DrwgID & ", [Status] = N'" & tSchedPlots.Status & "'" & ", [ShortDescrip] = N'" & tSchedPlots.ShortDescrip & "'" & ", [DateStamp] = " & IIf(tSchedPlots.DateStamp = Nothing, "null", "'" & tSchedPlots.DateStamp.ToString("yyyy-MM-dd HH:mm") & "'") & ", [PPCGuid] = N'" & tSchedPlots.PPCGuid & "'" & ", [DateSync] = " & IIf(tSchedPlots.DateSync = Nothing, "null", "'" & tSchedPlots.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [Owner] = " & tSchedPlots.Owner & ", [ExtRef] = N'" & tSchedPlots.ExtRef & "'" & ", [LocID] = " & tSchedPlots.LocID & ", [LocGUID] = N'" & tSchedPlots.LocGUID & "'" & ", [ClosedDate] = " & IIf(tSchedPlots.ClosedDate = Nothing, "null", "'" & tSchedPlots.ClosedDate.ToString("yyyy-MM-dd HH:mm") & "'") & ", [ClosedBy] = " & tSchedPlots.ClosedBy & ", [CSStart] = " & IIf(tSchedPlots.CSStart = Nothing, "null", "'" & tSchedPlots.CSStart.ToString("yyyy-MM-dd HH:mm") & "'") & ", [CSFinish] = " & IIf(tSchedPlots.CSFinish = Nothing, "null", "'" & tSchedPlots.CSFinish.ToString("yyyy-MM-dd HH:mm") & "'") & ", [RIGUID] = N'" & tSchedPlots.RIGUID & "'" & ", [LastChanged] = " & IIf(tSchedPlots.LastChanged = Nothing, "null", "'" & tSchedPlots.LastChanged.ToString("yyyy-MM-dd HH:mm") & "'") & " Where [PlotID] = " & tSchedPlots.PlotID
        Return SnagRData.RunSQL(conn, sSQL)
    End Function

    Public Shared Function delete(ByVal tSchedPlots As TSCHEDPLOTS, ByVal connectionString As String) As Boolean

        Dim sSQL As String = "Delete from tSchedPlots Where [PlotID] = " & tSchedPlots.PlotID
        Return SnagRData.RunSQL(connectionString, sSQL)
    End Function

    Public Shared Function updateBlob(ByVal tSchedPlots As TSCHEDPLOTS, ByVal column As String, ByVal b46Str As String, ByVal connectionString As String) As Boolean

        Dim conn As SqlConnection = New SqlConnection(connectionString)
        conn.Open()

        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))

        Dim sSQL As String = "UPDATE tSchedPlots SET " & column & "=@Image WHERE PlotID = " & tSchedPlots.PlotID
        cmd.CommandText = sSQL
        cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
        cmd.ExecuteNonQuery()

        conn.Close()
        conn.Dispose()

    End Function

    Public Shared Function updateBlob(ByVal tSchedPlots As TSCHEDPLOTS, ByVal column As String, ByVal b46Str As String, ByVal conn As SqlConnection) As Boolean

        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))
        Dim sSQL As String = "UPDATE tSchedPlots SET " & column & "=@Image WHERE PlotID = " & tSchedPlots.PlotID
        cmd.CommandText = sSQL
        cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
        cmd.ExecuteNonQuery()

    End Function

    Public Shared Function delete(ByVal tSchedPlots As TSCHEDPLOTS, ByVal conn As SqlConnection) As Boolean

        Dim sSQL As String = "Delete from tSchedPlots Where [PlotID] = " & tSchedPlots.PlotID
        Return SnagRData.RunSQL(conn, sSQL)
    End Function

    Private Shared Function loadFromResultSet(ByVal obj As TSCHEDPLOTS, ByVal resultset As DataRow) As TSCHEDPLOTS
        obj.PlotID = ProcessNull.GetInt32(resultset.Item("PlotID"))
        obj.SchedID = ProcessNull.GetInt32(resultset.Item("SchedID"))
        obj.SchedInits = ProcessNull.GetString(resultset.Item("SchedInits"))
        obj.DrwgID = ProcessNull.GetInt32(resultset.Item("DrwgID"))
        obj.Status = ProcessNull.GetString(resultset.Item("Status"))
        obj.ShortDescrip = ProcessNull.GetString(resultset.Item("ShortDescrip"))
        obj.DateStamp = ProcessNull.GetDateTime(resultset.Item("DateStamp"))
        obj.PPCGuid = ProcessNull.GetString(resultset.Item("PPCGuid"))
        obj.DateSync = ProcessNull.GetDateTime(resultset.Item("DateSync"))
        obj.Owner = ProcessNull.GetInt32(resultset.Item("Owner"))
        obj.ExtRef = ProcessNull.GetString(resultset.Item("ExtRef"))
        obj.LocID = ProcessNull.GetInt32(resultset.Item("LocID"))
        obj.LocGUID = ProcessNull.GetString(resultset.Item("LocGUID"))
        obj.ClosedDate = ProcessNull.GetDateTime(resultset.Item("ClosedDate"))
        obj.ClosedBy = ProcessNull.GetInt32(resultset.Item("ClosedBy"))
        obj.CSStart = ProcessNull.GetDateTime(resultset.Item("CSStart"))
        obj.CSFinish = ProcessNull.GetDateTime(resultset.Item("CSFinish"))
        obj.RIGUID = ProcessNull.GetString(resultset.Item("RIGUID"))
        obj.LastChanged = ProcessNull.GetDateTime(resultset.Item("LastChanged"))

        Return obj

    End Function

End Class

