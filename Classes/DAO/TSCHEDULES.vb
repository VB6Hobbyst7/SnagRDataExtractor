Imports SnagRWeb_Project.SnagRData
Imports System.Data.SqlClient

Public Class TSCHEDULES

   Private [_SchedID] As Int32
   Public Property [SchedID]() As Int32
       Get
           Return [_SchedID]
       End Get
       Set(ByVal value As Int32)
           [_SchedID] = value
       End Set
    End Property
   Private [_Schedname] As String
   Public Property [Schedname]() As String
       Get
           Return [_Schedname]
       End Get
       Set(ByVal value As String)
           [_Schedname] = value
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
   Private [_NoQtyCol] As Boolean
   Public Property [NoQtyCol]() As Boolean
       Get
           Return [_NoQtyCol]
       End Get
       Set(ByVal value As Boolean)
           [_NoQtyCol] = value
       End Set
    End Property
   Private [_NoPassAll] As Boolean
   Public Property [NoPassAll]() As Boolean
       Get
           Return [_NoPassAll]
       End Get
       Set(ByVal value As Boolean)
           [_NoPassAll] = value
       End Set
    End Property
   Private [_RDS] As Boolean
   Public Property [RDS]() As Boolean
       Get
           Return [_RDS]
       End Get
       Set(ByVal value As Boolean)
           [_RDS] = value
       End Set
    End Property
   Private [_Adhoc] As Boolean
   Public Property [Adhoc]() As Boolean
       Get
           Return [_Adhoc]
       End Get
       Set(ByVal value As Boolean)
           [_Adhoc] = value
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
   Private [_RecurDays] As Int32
   Public Property [RecurDays]() As Int32
       Get
           Return [_RecurDays]
       End Get
       Set(ByVal value As Int32)
           [_RecurDays] = value
       End Set
    End Property
   Private [_DueByes] As Boolean
   Public Property [DueByes]() As Boolean
       Get
           Return [_DueByes]
       End Get
       Set(ByVal value As Boolean)
           [_DueByes] = value
       End Set
    End Property
   Private [_KeepOnDevice] As Boolean
   Public Property [KeepOnDevice]() As Boolean
       Get
           Return [_KeepOnDevice]
       End Get
       Set(ByVal value As Boolean)
           [_KeepOnDevice] = value
       End Set
    End Property
   Private [_CantSkip] As Boolean
   Public Property [CantSkip]() As Boolean
       Get
           Return [_CantSkip]
       End Get
       Set(ByVal value As Boolean)
           [_CantSkip] = value
       End Set
    End Property
   Private [_LSO] As Boolean
   Public Property [LSO]() As Boolean
       Get
           Return [_LSO]
       End Get
       Set(ByVal value As Boolean)
           [_LSO] = value
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
   Private [_OnQADashbd] As Boolean
   Public Property [OnQADashbd]() As Boolean
       Get
           Return [_OnQADashbd]
       End Get
       Set(ByVal value As Boolean)
           [_OnQADashbd] = value
       End Set
    End Property
   Private [_isPermit] As Boolean
   Public Property [isPermit]() As Boolean
       Get
           Return [_isPermit]
       End Get
       Set(ByVal value As Boolean)
           [_isPermit] = value
       End Set
    End Property

End Class

Public Class TSCHEDULESDAO

   Public Shared Function getUsingSchedID(ByVal SchedID As Int32, ByVal connectionString As String, Optional ByVal Limit As Integer = 0) As TSCHEDULES
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSchedules Where SchedID = "  & SchedID, connectionString)
       Else
           dt  = SnagRData.GetDataTable("Select * from tSchedules Where SchedID = "  & SchedID, connectionString)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TSCHEDULES, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getUsingSchedID(ByVal SchedID As Int32, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0) As TSCHEDULES
       Dim dt As DataTable
       If Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSchedules Where SchedID = "  & SchedID, conn)
       Else
           dt  = SnagRData.GetDataTable("Select * from tSchedules Where SchedID = "  & SchedID, conn)
       End If

       If dt.Rows.Count > 0 Then
           Return loadFromResultSet(New TSCHEDULES, dt.Rows(0))
       Else
           Return Nothing
       End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal connectionString As String, Optional ByVal Limit As Integer = 0, Optional sql as String = Nothing) As List(Of TSCHEDULES)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, connectionString)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSchedules Where " + where, connectionString)
       Else
           dt = SnagRData.GetDataTable("Select * from tSchedules Where " + where, connectionString)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TSCHEDULES)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TSCHEDULES, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

   Public Shared Function getWhere(ByVal where As String, ByVal conn As SqlConnection, Optional ByVal Limit As Integer = 0, Optional ByVal sql as String = Nothing) As List(Of TSCHEDULES)
       Dim dt As DataTable

       If Not sql Is Nothing Then
           dt = SnagRData.GetDataTable(sql, conn)
       ElseIf Limit > 0 Then
           dt = SnagRData.GetDataTable("Select TOP " & Limit & " * from tSchedules Where " + where, conn)
       Else
           dt = SnagRData.GetDataTable("Select * from tSchedules Where " + where, conn)
       End If

      If dt.Rows.Count > 0 Then
         Dim myList As New List(Of TSCHEDULES)
         For i As Integer = 0 To dt.Rows.Count - 1
             myList.Add(loadFromResultSet(New TSCHEDULES, dt.Rows(i)))
         Next
         Return myList
      Else
          Return Nothing
      End If
   End Function

    Public Shared Function insert(ByVal tSchedules As TSCHEDULES, ByVal connectionString As String) As Boolean

        Dim sSQL As String = "Insert into tSchedules (SchedID, [Schedname], [SchedInits], [NoQtyCol], [NoPassAll], [RDS], [Adhoc], [DateSync], [RecurDays], [DueByes], [KeepOnDevice], [CantSkip], [LSO], [Current], [OnQADashbd], [isPermit]) Values (" & tSchedules.SchedID & ", " & "N'" & tSchedules.Schedname & "'" & ", " & "N'" & tSchedules.SchedInits & "'" & ", " & "'" & tSchedules.NoQtyCol & "'" & ", " & "'" & tSchedules.NoPassAll & "'" & ", " & "'" & tSchedules.RDS & "'" & ", " & "'" & tSchedules.Adhoc & "'" & ", " & IIf(tSchedules.DateSync = Nothing, "null", "'" & tSchedules.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & tSchedules.RecurDays & ", " & "'" & tSchedules.DueByes & "'" & ", " & "'" & tSchedules.KeepOnDevice & "'" & ", " & "'" & tSchedules.CantSkip & "'" & ", " & "'" & tSchedules.LSO & "'" & ", " & "'" & tSchedules.Current & "'" & ", " & "'" & tSchedules.OnQADashbd & "'" & ", " & "'" & tSchedules.isPermit & "'" & ")"
       Return SnagRData.RunSQL(connectionString, sSQL)

   End Function

    Public Shared Function insert(ByVal tSchedules As TSCHEDULES, ByVal conn As SqlConnection) As Boolean

        Dim sSQL As String = "Insert into tSchedules ([SchedID], [Schedname], [SchedInits], [NoQtyCol], [NoPassAll], [RDS], [Adhoc], [DateSync], [RecurDays], [DueByes], [KeepOnDevice], [CantSkip], [LSO], [Current], [OnQADashbd], [isPermit]) Values (" & tSchedules.SchedID & ", " & "N'" & tSchedules.Schedname & "'" & ", " & "N'" & tSchedules.SchedInits & "'" & ", " & "'" & tSchedules.NoQtyCol & "'" & ", " & "'" & tSchedules.NoPassAll & "'" & ", " & "'" & tSchedules.RDS & "'" & ", " & "'" & tSchedules.Adhoc & "'" & ", " & IIf(tSchedules.DateSync = Nothing, "null", "'" & tSchedules.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", " & tSchedules.RecurDays & ", " & "'" & tSchedules.DueByes & "'" & ", " & "'" & tSchedules.KeepOnDevice & "'" & ", " & "'" & tSchedules.CantSkip & "'" & ", " & "'" & tSchedules.LSO & "'" & ", " & "'" & tSchedules.Current & "'" & ", " & "'" & tSchedules.OnQADashbd & "'" & ", " & "'" & tSchedules.isPermit & "'" & ")"
       Return SnagRData.RunSQL(conn, sSQL)

   End Function

    Public Shared Function update(ByVal tSchedules As TSCHEDULES, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Update tSchedules Set [Schedname] = N'" & tSchedules.Schedname & "'" & ", [SchedInits] = N'" & tSchedules.SchedInits & "'" & ", [NoQtyCol] = " & IIf(tSchedules.NoQtyCol = True, "1", "0") & ", [NoPassAll] = " & IIf(tSchedules.NoPassAll = True, "1", "0") & ", [RDS] = " & IIf(tSchedules.RDS = True, "1", "0") & ", [Adhoc] = " & IIf(tSchedules.Adhoc = True, "1", "0") & ", [DateSync] = " & IIf(tSchedules.DateSync = Nothing, "null", "'" & tSchedules.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [RecurDays] = " & tSchedules.RecurDays & ", [DueByes] = " & IIf(tSchedules.DueByes = True, "1", "0") & ", [KeepOnDevice] = " & IIf(tSchedules.KeepOnDevice = True, "1", "0") & ", [CantSkip] = " & IIf(tSchedules.CantSkip = True, "1", "0") & ", [LSO] = " & IIf(tSchedules.LSO = True, "1", "0") & ", [Current] = " & IIf(tSchedules.Current = True, "1", "0") & ", [OnQADashbd] = " & IIf(tSchedules.OnQADashbd = True, "1", "0") & ", [isPermit] = " & IIf(tSchedules.isPermit = True, "1", "0") & " Where [SchedID] = " & tSchedules.SchedID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function update(ByVal tSchedules As TSCHEDULES, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Update tSchedules Set [Schedname] = N'" & tSchedules.Schedname & "'" & ", [SchedInits] = N'" & tSchedules.SchedInits & "'" & ", [NoQtyCol] = " & IIf(tSchedules.NoQtyCol = True, "1", "0") & ", [NoPassAll] = " & IIf(tSchedules.NoPassAll = True, "1", "0") & ", [RDS] = " & IIf(tSchedules.RDS = True, "1", "0") & ", [Adhoc] = " & IIf(tSchedules.Adhoc = True, "1", "0") & ", [DateSync] = " & IIf(tSchedules.DateSync = Nothing, "null", "'" & tSchedules.DateSync.ToString("yyyy-MM-dd HH:mm") & "'") & ", [RecurDays] = " & tSchedules.RecurDays & ", [DueByes] = " & IIf(tSchedules.DueByes = True, "1", "0") & ", [KeepOnDevice] = " & IIf(tSchedules.KeepOnDevice = True, "1", "0") & ", [CantSkip] = " & IIf(tSchedules.CantSkip = True, "1", "0") & ", [LSO] = " & IIf(tSchedules.LSO = True, "1", "0") & ", [Current] = " & IIf(tSchedules.Current = True, "1", "0") & ", [OnQADashbd] = " & IIf(tSchedules.OnQADashbd = True, "1", "0") & ", [isPermit] = " & IIf(tSchedules.isPermit = True, "1", "0") & " Where [SchedID] = " & tSchedules.SchedID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

    Public Shared Function delete(ByVal tSchedules As TSCHEDULES, ByVal connectionString As String) As Boolean

       Dim sSQL as string = "Delete from tSchedules Where [SchedID] = " & tSchedules.SchedID
       Return SnagRData.RunSQL(connectionString, sSQL)
   End Function

    Public Shared Function updateBlob(ByVal tSchedules As TSCHEDULES, ByVal column As String, ByVal b46Str As String, ByVal connectionString As String) As Boolean

        Dim conn As SqlConnection = New SqlConnection(connectionString)
       conn.Open()

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))

       Dim sSQL As String = "UPDATE tSchedules SET " & column & "=@Image WHERE SchedID = " & tSchedules.SchedID
       cmd.CommandText = sSQL
        cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
       cmd.ExecuteNonQuery()

       conn.Close()
       conn.Dispose()

   End Function

    Public Shared Function updateBlob(ByVal tSchedules As TSCHEDULES, ByVal column As String, ByVal b46Str As String, ByVal conn As SqlConnection) As Boolean

       Dim cmd As New SqlCommand
       cmd.Connection = conn
       cmd.Parameters.Add(New SqlParameter("@Image", SqlDbType.Image))
Dim sSQL As String = "UPDATE tSchedules SET " & column & "=@Image WHERE SchedID = " & tSchedules.SchedID
cmd.CommandText = sSQL
cmd.Parameters("@Image").Value = Convert.FromBase64String(b46Str)
cmd.ExecuteNonQuery()

   End Function

    Public Shared Function delete(ByVal tSchedules As TSCHEDULES, ByVal conn As SqlConnection) As Boolean

       Dim sSQL as string = "Delete from tSchedules Where [SchedID] = " & tSchedules.SchedID
       Return SnagRData.RunSQL(conn, sSQL)
   End Function

   Private Shared Function loadFromResultSet(ByVal obj As TSCHEDULES, ByVal resultset As DataRow) As TSCHEDULES
      obj.SchedID = ProcessNull.GetInt32(resultset.Item("SchedID"))
      obj.Schedname = ProcessNull.GetString(resultset.Item("Schedname"))
      obj.SchedInits = ProcessNull.GetString(resultset.Item("SchedInits"))
       obj.NoQtyCol = ProcessNull.GetBoolean(resultset.Item("NoQtyCol"))
       obj.NoPassAll = ProcessNull.GetBoolean(resultset.Item("NoPassAll"))
       obj.RDS = ProcessNull.GetBoolean(resultset.Item("RDS"))
       obj.Adhoc = ProcessNull.GetBoolean(resultset.Item("Adhoc"))
      obj.DateSync = ProcessNull.GetDateTime(resultset.Item("DateSync"))
      obj.RecurDays = ProcessNull.GetInt32(resultset.Item("RecurDays"))
       obj.DueByes = ProcessNull.GetBoolean(resultset.Item("DueByes"))
       obj.KeepOnDevice = ProcessNull.GetBoolean(resultset.Item("KeepOnDevice"))
       obj.CantSkip = ProcessNull.GetBoolean(resultset.Item("CantSkip"))
       obj.LSO = ProcessNull.GetBoolean(resultset.Item("LSO"))
       obj.Current = ProcessNull.GetBoolean(resultset.Item("Current"))
       obj.OnQADashbd = ProcessNull.GetBoolean(resultset.Item("OnQADashbd"))
       obj.isPermit = ProcessNull.GetBoolean(resultset.Item("isPermit"))

       Return obj

   End Function

End Class

