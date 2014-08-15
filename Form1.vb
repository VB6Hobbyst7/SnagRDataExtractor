Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports System.Threading
Imports System.IO
Imports System.Data.SqlClient






Public Class Form1

    Private Shared init_dir As String = Application.StartupPath

    Private key As String = ""
    Private url As String = ""

    Private drwgID As Integer
    Private schedID As Integer
    Private formCode As String

    Private dateStampFrom As DateTime = Date.MinValue
    Private dateStampTo As DateTime = Date.MinValue
    Private checkCode As String = Nothing

    Private dateStampFromSnagsVal As DateTime = Date.MinValue
    Private dateStampToSnagsVal As DateTime = Date.MinValue

    Private inspections As New List(Of Inspection)
    Private defects As New List(Of DefectObj)

    Private schedules As New List(Of SchedulesObj)
    Private schedItems As New List(Of TSCHEDITEMS)
    Private formItems As New List(Of TFORMITEMS)

    Private drwgs As New List(Of DrwgsObj)

    Private downloadStatusOutput As String = ""

    Dim dicFormItemAnswers As New Dictionary(Of Integer, TFORMITEMANS)

    Dim objDBCreate As DatabaseCreator

    'Snags section
    Private sdcategs As New List(Of SDCategsObj)
    Private sdcatID As Integer
    Private sdCode As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateStampFrom = DateTimePicker1.Value
        dateStampTo = DateTimePicker2.Value
        dateStampFromSnagsVal = dateStampFromSnags.Value
        dateStampToSnagsVal = dateStampToSnags.Value
    End Sub

    Public Shared ReadOnly Property AppPath() As String
        Get
            'Dim s As String = Replace(Path.GetDirectoryName(GetType(Assembly.GetName.CodeBase), "\bin\Debug", ""))
            Dim s1 As String = Replace(My.Application.Info.DirectoryPath, "\bin\Debug", "")

            'Dim init_dir As String = Application.StartupPath
            If init_dir.EndsWith("\bin") Then init_dir = init_dir.Substring(0, init_dir.Length - 4)
            If init_dir.ToLower.EndsWith("\bin\debug") Then init_dir = init_dir.Substring(0, init_dir.Length - 10)
            If init_dir.ToLower.EndsWith("\bin\x86\debug") Then init_dir = init_dir.Substring(0, init_dir.Length - 14) '64 bit processor?
            Return init_dir
        End Get
    End Property

    Private Sub CreateDataTable(ByRef dt As DataTable)

        dt.Columns.Add("ProjectTitle")
        dt.Columns.Add("ContractNo")
        dt.Columns.Add("Drawing")
        dt.Columns.Add("DrwgID")
        dt.Columns.Add("InspectionName") 'ExtRef
        dt.Columns.Add("Location")
        dt.Columns.Add("LocID")
        dt.Columns.Add("LocationExtRef")
        dt.Columns.Add("PlotID")
        dt.Columns.Add("CreatedDate")
        dt.Columns.Add("CreatedBy")
        dt.Columns.Add("Status")
        dt.Columns.Add("ClosedDate")
        dt.Columns.Add("ClosedBy")
        dt.Columns.Add("PPCGuid")
        dt.Columns.Add("CSStart")
        dt.Columns.Add("CSFinish")
        dt.Columns.Add("RIGUID")

        'inspectionform
        dt.Columns.Add("FormID")
        dt.Columns.Add("FormCode")
        dt.Columns.Add("FormName")
        dt.Columns.Add("FormShortName")
        dt.Columns.Add("IssuedDate")
        dt.Columns.Add("ValudUntil")
        dt.Columns.Add("IssuedTo")
        dt.Columns.Add("IssuedBy")
        dt.Columns.Add("AcceptedBy")
        dt.Columns.Add("Closed")
        dt.Columns.Add("Passed")

        'formchecks
        'dt.Columns.Add("SCID")
        dt.Columns.Add("CheckCode")
        dt.Columns.Add("Categ")
        dt.Columns.Add("Question")
        dt.Columns.Add("srt")
        dt.Columns.Add("Result")
        dt.Columns.Add("ResultText")
        dt.Columns.Add("ResultImg")
        dt.Columns.Add("FIAID")
        dt.Columns.Add("Username")
        dt.Columns.Add("DateStamp")
        dt.Columns.Add("AnswerType")
        dt.Columns.Add("Mandatory")
        dt.Columns.Add("PageNo")
        dt.Columns.Add("FCID")
        dt.Columns.Add("ListCode")
        dt.Columns.Add("LinkCheckCode")
        dt.Columns.Add("FCGUID")
        dt.Columns.Add("AutoSnagged")
    End Sub

    Private Sub CreateDataTableSnags(ByRef dt As DataTable)
        dt.Columns.Add("ID")
        dt.Columns.Add("ProjectTitle")
        dt.Columns.Add("ContractNo")
        dt.Columns.Add("Drawing")
        dt.Columns.Add("SnagID")
        dt.Columns.Add("ProjectLinkID")
        dt.Columns.Add("DrwgID")
        dt.Columns.Add("Status")
        dt.Columns.Add("ShortDescrip")
        dt.Columns.Add("LocID")
        dt.Columns.Add("LocationExtRef")
        dt.Columns.Add("Location")
        dt.Columns.Add("Xcoord")
        dt.Columns.Add("YCoord")
        dt.Columns.Add("Priority")
        dt.Columns.Add("Datestamp")
        dt.Columns.Add("DrwgLink")
        dt.Columns.Add("Photo")
        dt.Columns.Add("DoBy")
        dt.Columns.Add("GroupID")
        dt.Columns.Add("GroupInits")
        dt.Columns.Add("DateClosed")
        dt.Columns.Add("BigPhoto")
        dt.Columns.Add("Lat")
        dt.Columns.Add("Lng")
        dt.Columns.Add("Owner")
        dt.Columns.Add("SDCode")
        dt.Columns.Add("SDID")
        dt.Columns.Add("DateSync")
        dt.Columns.Add("FixStatus")
        dt.Columns.Add("MPGUID")
        dt.Columns.Add("Purge")
        dt.Columns.Add("DaysLeft")
        dt.Columns.Add("DrwgSrt")
        dt.Columns.Add("DrwgTitle")
        dt.Columns.Add("FixDescrip")
        dt.Columns.Add("By")
        dt.Columns.Add("UserID")
        dt.Columns.Add("Fullname")
        dt.Columns.Add("CanBeEmailed")
        dt.Columns.Add("srt")
        dt.Columns.Add("LastChanged")
        dt.Columns.Add("Groupname")
        dt.Columns.Add("CoGroupID")


    End Sub

    Private Sub CreateViewTable(ByRef viewDT As DataTable)
        viewDT.Columns.Add("CheckCode")
        viewDT.Columns.Add("Question")
        viewDT.Columns.Add("Result")
        viewDT.Columns.Add("ResultText")
    End Sub

    Private Sub CreateViewTableSnags(ByRef viewDT As DataTable)
        viewDT.Columns.Add("ID")
        viewDT.Columns.Add("GroupName")
        viewDT.Columns.Add("Description")
        viewDT.Columns.Add("CreatedBy")
        viewDT.Columns.Add("Location")
    End Sub

    Private Sub FillTables(ByRef dt As DataTable, ByRef viewDT As DataTable, ByVal toCSV As Boolean)

        ' Dim FormChecks As List(Of FormCheck)

        'used to update the winforms UI
        Dim output As String = ""
        Dim bOK As Boolean = False

        url = txtURL.Text.Trim()
        If Not url.EndsWith("/") Then
            url = url & "/"
        End If

        Dim baseURL As String = url

        url += "api/SchedPlots?key=" & key

        If Not schedID = 0 Then
            url += "&SchedID=" & schedID
        End If

        If Not drwgID = 0 Then
            url += "&DrwgID=" & drwgID
        End If

        If chkUseDates.Checked Then
            If Not dateStampFrom = Date.MinValue And Not dateStampTo = Date.MinValue Then

                url += "&DateStampFrom=" & dateStampFrom.Date.ToString("s") & "&DateStampTo=" & dateStampTo.Date.AddDays(1).ToString("s")
            End If
        End If

        Dim client As New HttpClient()
        client.BaseAddress = New Uri(url)
        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

        Dim schedPlotsResponse As HttpResponseMessage = client.GetAsync(url).Result

        'check for http:200 response (success)
        If schedPlotsResponse.IsSuccessStatusCode Then

            'read the key from the api response
            Dim schedPlots As List(Of TSCHEDPLOTS) = schedPlotsResponse.Content.ReadAsAsync(Of List(Of TSCHEDPLOTS))().Result
            If Not schedPlots Is Nothing Then

                updateDownloadStatus("Inspections to download: " & schedPlots.Count)

                Dim i As Integer = 1

                For Each p As TSCHEDPLOTS In schedPlots
                    Dim formChecksResponse As HttpResponseMessage = client.GetAsync(baseURL & "api/Inspections?key=" & key & "&ID=" & p.PlotID & "&IncludeImages=" & chkIncludeImages.Checked).Result

                    If formChecksResponse.IsSuccessStatusCode Then

                        updateDownloadStatus("Inspection: " & i & " of " & schedPlots.Count & " received!")

                        'read the key from the api response
                        Dim ins As Inspection = formChecksResponse.Content.ReadAsAsync(Of Inspection)().Result
                        inspections.Add(ins)
                    Else
                        updateDownloadStatus("Inspection: " & i & " of " & schedPlots.Count & " Failed!")
                    End If

                    i += 1
                Next
            Else
                updateDownloadStatus("No Inspections to download!")
            End If
        End If


        If inspections.Count > 0 Then

            Dim i As Integer = 1

            For Each ins As Inspection In inspections
                'ins.InspectionForms(0).
                updateDownloadStatus("Processing Inspection: " & i & " of " & inspections.Count)

                If Not ins.InspectionForms.Count = 0 Then

                    For Each Form As InspectionForm In ins.InspectionForms
                        If Not formCode Is Nothing Then
                            If Form.FormCode = formCode Then

                                For Each check As FormCheck In Form.FormChecks

                                    bOK = False
                                    If chkSelectQuestion.Checked And check.CheckCode = checkCode Then
                                        bOK = True
                                    Else
                                        'include all formchecks
                                        bOK = True
                                    End If

                                    If bOK Then
                                        If toCSV Then
                                            Dim r As DataRow = dt.NewRow()
                                            Dim viewR As DataRow = viewDT.NewRow()
                                            AddRow(r, viewR, ins, Form, check)
                                            dt.Rows.Add(r)
                                            viewDT.Rows.Add(viewR)
                                        Else
                                            'to SQL table
                                            Dim viewR As DataRow = viewDT.NewRow()
                                            AddRecord(viewR, ins, Form, check)
                                            viewDT.Rows.Add(viewR)
                                        End If
                                    End If
                                Next
                            End If
                        End If
                    Next
                End If

                i += 1

            Next
        End If
    End Sub

    Private Sub FillTablesSnags(ByRef dt As DataTable, ByRef viewDT As DataTable, ByVal selectedItems As List(Of TSDTYPES), ByVal toCSV As Boolean)

        ' Dim FormChecks As List(Of FormCheck)

        'used to update the winforms UI
        Dim output As String = ""
        Dim bOK As Boolean = False

        url = txtURLSnags.Text.Trim()
        If Not url.EndsWith("/") Then
            url = url & "/"
        End If

        Dim baseURL As String = url

        url += "api/Defects?key=" & key


        If chkUseDatesSnags.Checked Then
            If Not dateStampFromSnagsVal = Date.MinValue And Not dateStampToSnagsVal = Date.MinValue Then
                url += "&CreatedDateFrom=" & dateStampFromSnagsVal.Date.ToString("s") & "&CreatedDateTo=" & dateStampToSnagsVal.Date.AddDays(1).ToString("s")
            End If
        End If

        If selectedItems.Count > 0 Then
            For Each selectedItem As TSDTYPES In selectedItems
                Dim newUrl As String = url & "&SDCode=" & selectedItem.SDCode
                fillDefectsObjFromWebService(newUrl, baseURL, selectedItem) 'may include date range too which is desired..
            Next
        ElseIf chkUseDatesSnags.Checked Then
            fillDefectsObjFromWebService(url, baseURL)
        End If



        If defects.Count > 0 Then
            For Each defect As DefectObj In defects
                If toCSV Then
                    Dim r As DataRow = dt.NewRow()
                    Dim viewR As DataRow = viewDT.NewRow()
                    AddRowSnags(r, viewR, defect)
                    dt.Rows.Add(r)
                    viewDT.Rows.Add(viewR)
                Else
                    'to SQL table
                    Dim viewR As DataRow = viewDT.NewRow()
                    AddRecordSnags(viewR, defect)
                    viewDT.Rows.Add(viewR)
                End If


            Next
        End If
    End Sub

    Private Sub fillDefectsObjFromWebService(ByVal newURL As String, ByVal baseURL As String, Optional ByVal selectedItem As TSDTYPES = Nothing)


        Dim client As New HttpClient()
        client.BaseAddress = New Uri(newURL)
        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

        Dim defectsResponse As HttpResponseMessage = client.GetAsync(newURL).Result

        'check for http:200 response (success)
        If defectsResponse.IsSuccessStatusCode Then

            'read the key from the api response
            defects = defectsResponse.Content.ReadAsAsync(Of List(Of DefectObj))().Result
        End If

    End Sub

    Private Sub btnOutputToCSV_Click(sender As Object, e As EventArgs) Handles btnOutputToCSV.Click

        Dim saveFileDialog1 As New SaveFileDialog()
        Dim fileToSave As String = ""

        saveFileDialog1.Filter = "CSV files (*.csv)|*csv" '|All files (*.*)|*.*"

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            fileToSave = saveFileDialog1.FileName
            If saveFileDialog1.CheckFileExists Then
                If File.Exists(fileToSave) Then
                    File.Delete(fileToSave)
                End If
            End If
        Else
            Return
        End If

        toggleControl(btnOutputToDBTable)
        toggleControl(btnOutputToCSV)

        Task.Factory.StartNew(Sub()

                                  'create Data Table
                                  Dim dt As New DataTable()
                                  CreateDataTable(dt)

                                  'used to create the .csv file
                                  Dim viewDT As New DataTable()
                                  CreateViewTable(viewDT)

                                  FillTables(dt, viewDT, True)

                                  'output to csv
                                  ExportDatasetToCSV(dt, fileToSave)

                                  updateDownloadStatus("CSV File Created! " & fileToSave)

                                  Dim action As MethodInvoker = Sub()
                                                                    dgvResult.DataSource = viewDT
                                                                End Sub

                                  dgvResult.BeginInvoke(action)

                                  toggleControl(btnOutputToDBTable)
                                  toggleControl(btnOutputToCSV)
                              End Sub)

    End Sub

    Private Sub btnOutputToCSVSnags_Click(sender As Object, e As EventArgs) Handles btnOutputToCSVSnags.Click

        Dim saveFileDialog1 As New SaveFileDialog()
        Dim fileToSave As String = ""

        saveFileDialog1.Filter = "CSV files (*.csv)|*csv" '|All files (*.*)|*.*"

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            fileToSave = saveFileDialog1.FileName
            If saveFileDialog1.CheckFileExists Then
                If File.Exists(fileToSave) Then
                    File.Delete(fileToSave)
                End If
            End If
        Else
            Return
        End If

        Dim selectedItems As New List(Of TSDTYPES)
        For Each item As TSDTYPES In lbSDTypes.SelectedItems
            selectedItems.Add(item)
        Next

        toggleControl(btnOutputToDBTableSnags)
        toggleControl(btnOutputToCSVSnags)

        Task.Factory.StartNew(Sub()

                                  'create Data Table
                                  Dim dt As New DataTable()
                                  CreateDataTableSnags(dt)

                                  'used to create the .csv file
                                  Dim viewDT As New DataTable()
                                  CreateViewTableSnags(viewDT)

                                  FillTablesSnags(dt, viewDT, selectedItems, True)

                                  'output to csv
                                  ExportDatasetToCSV(dt, fileToSave)

                                  updateDownloadStatus("CSV File Created! " & fileToSave)

                                  Dim action As MethodInvoker = Sub()
                                                                    dgvResult.DataSource = viewDT
                                                                End Sub

                                  dgvResult.BeginInvoke(action)

                                  toggleControl(btnOutputToDBTableSnags)
                                  toggleControl(btnOutputToCSVSnags)
                              End Sub)

    End Sub



    Private Sub AddRecord(ByRef viewR As DataRow, ByVal ins As Inspection, ByVal Form As InspectionForm, ByVal check As FormCheck)

        Dim myInsItem As New TSNAGRINSPECTIONDATA
        myInsItem.ProjectTitle = ins.ProjectTitle
        myInsItem.ContractNo = ins.ContractNo
        myInsItem.Drawing = ins.Drawing
        myInsItem.DrwgID = ins.DrwgID
        myInsItem.InspectionName = ins.InspectionName 'ExtRef
        myInsItem.Location = ins.Location
        myInsItem.LocID = ins.LocID
        myInsItem.LocationExtRef = ins.LocationExtRef
        myInsItem.PlotID = ins.PlotID
        myInsItem.CreatedDate = ins.CreatedDate
        myInsItem.CreatedBy = ins.CreatedBy
        myInsItem.Status = ins.Status
        myInsItem.ClosedDate = ins.ClosedDate
        myInsItem.ClosedBy = ins.ClosedBy
        myInsItem.PPCGUID = ins.PPCGuid
        myInsItem.CSStart = ins.CSStart
        myInsItem.CSFinish = ins.CSFinish
        myInsItem.RIGUID = ins.RIGUID

        'inspectionform
        myInsItem.FormID = Form.FormID
        myInsItem.FormCode = Form.FormCode
        myInsItem.FormName = Form.FormName
        myInsItem.FormShortName = Form.FormShortName
        myInsItem.IssuedDate = Form.IssuedDate
        myInsItem.ValidUntil = Form.ValudUntil
        myInsItem.IssuedTo = Form.IssuedTo
        myInsItem.IssuedBy = Form.IssuedBy
        myInsItem.AcceptedBy = Form.AcceptedBy
        myInsItem.Closed = Form.Closed
        myInsItem.Passed = Form.Passed

        'formchecks
        'myInsItem.scid = check.SCID
        myInsItem.CheckCode = check.CheckCode
        myInsItem.Categ = check.Categ
        myInsItem.Question = check.Question
        myInsItem.srt = check.srt
        myInsItem.Result = check.Result
        myInsItem.ResultText = check.ResultText
        'myInsItem.ResultImg = check.ResultImg
        myInsItem.FIAID = check.FIAID
        myInsItem.Username = check.Username
        myInsItem.Datestamp = check.DateStamp
        myInsItem.AnswerType = check.AnswerType
        myInsItem.Mandatory = check.Mandatory
        myInsItem.PageNo = check.PageNo
        myInsItem.FCID = check.FCID
        myInsItem.ListCode = check.ListCode
        myInsItem.LinkCheckCode = check.LinkCheckCode
        myInsItem.FCGUID = check.FCGUID
        myInsItem.AutoSnagged = check.AutoSnagged

        TSNAGRINSPECTIONDATADAO.insert(myInsItem, txtConnectionString.Text)
        Dim newSnagRInspectionData As List(Of TSNAGRINSPECTIONDATA) = TSNAGRINSPECTIONDATADAO.getWhere("FCGUID = '" & check.FCGUID & "'", txtConnectionStringSnags.Text)
        If Not newSnagRInspectionData Is Nothing Then
            If Not check.ResultImg Is Nothing Then
                If check.ResultImg.Length > 3 Then
                    TSNAGRINSPECTIONDATADAO.updateBlob(newSnagRInspectionData(0), "ResultImg", check.ResultImg, txtConnectionStringSnags.Text)
                End If
            End If
        End If

        '
        viewR.Item("CheckCode") = check.CheckCode
        viewR.Item("Question") = check.Question
        viewR.Item("Result") = check.Result
        viewR.Item("ResultText") = check.ResultText

    End Sub


    Private Sub AddRecordSnags(ByRef viewR As DataRow, ByVal d As DefectObj)

        Dim s As New TPROJECTSNAGS
        s.ProjectTitle = d.ProjectTitle
        s.ContractNo = d.ContractNo
        s.BigPhoto = d.BigPhoto
        s.By = d.CreatedByID
        s.CanBeEmailed = Nothing
        s.CoGroupID = Nothing
        s.DateClosed = d.DateClosed
        s.Datestamp = d.CreatedDate
        s.DateSync = d.DateSync
        s.DaysLeft = d.DaysLeft
        s.DoBy = d.DueBy
        s.DrwgID = d.DrawingID
        s.Drawing = d.DrawingTitle
        s.DrwgLink = Nothing
        s.DrwgSrt = Nothing
        s.DrwgTitle = d.DrawingTitle
        s.FixDescrip = Nothing 'what is this used for?
        s.FixStatus = d.CurrentStatus
        s.Fullname = d.CreatedBy
        s.GroupID = d.GroupID
        s.GroupInits = d.GroupInitials
        s.Groupname = d.GroupName
        s.ID = d.ID
        s.LastChanged = d.DateSync
        s.Lat = d.Lattitude
        s.Lng = d.Longitude
        s.Location = d.Location
        s.LocationExtRef = d.LocationExtRef
        s.LocID = d.LocationID
        s.MPGUID = d.MPGUID
        s.Owner = d.CreatedByID
        's.Photo = d.Photo - done with update blob below
        s.Priority = d.PriorityID
        s.ProjectLinkID = d.ProjectLinkID
        s.Purge = Nothing
        s.SDCode = d.SDCode
        s.SDID = d.SDID
        s.ShortDescrip = d.UserDescription
        s.SnagID = d.ID
        s.srt = Nothing
        s.Status = d.Status
        s.UserID = Nothing 'what is this used for?
        s.Xcoord = d.XCoord
        s.YCoord = d.YCoord


        TPROJECTSNAGSDAO.insert(s, txtConnectionStringSnags.Text)

        Dim newProjectSnag As List(Of TPROJECTSNAGS) = TPROJECTSNAGSDAO.getWhere("SnagID = " & s.SnagID, txtConnectionStringSnags.Text)
        If Not newProjectSnag Is Nothing Then
            If Not d.Photo Is Nothing Then
                If d.Photo.Length > 3 Then
                    TPROJECTSNAGSDAO.updateBlob(newProjectSnag(0), "Photo", d.Photo, txtConnectionStringSnags.Text)
                End If
            End If
        End If


        viewR.Item("ID") = d.ID
        viewR.Item("GroupName") = d.GroupName
        viewR.Item("Description") = d.SDCategory & " - " & d.SDDescription & " - " & d.UserDescription
        viewR.Item("CreatedBy") = d.CreatedBy
        viewR.Item("Location") = d.Location

    End Sub

    Private Sub AddRowSnags(ByRef r As DataRow, ByRef viewR As DataRow, ByVal d As DefectObj)


        r.Item("ProjectTitle") = d.ProjectTitle
        r.Item("ContractNo") = d.ContractNo
        r.Item("BigPhoto") = d.BigPhoto
        r.Item("By") = d.CreatedBy
        r.Item("CanBeEmailed") = Nothing
        r.Item("CoGroupID") = Nothing
        r.Item("DateClosed") = d.DateClosed
        r.Item("Datestamp") = d.CreatedDate
        r.Item("DateSync") = d.DateSync
        r.Item("DaysLeft") = d.DaysLeft
        r.Item("DoBy") = d.DueBy
        r.Item("DrwgID") = d.DrawingID
        r.Item("Drawing") = d.DrawingTitle
        r.Item("DrwgLink") = Nothing
        r.Item("DrwgSrt") = Nothing
        r.Item("DrwgTitle") = d.DrawingTitle
        r.Item("FixDescrip") = Nothing 'what is this used for?
        r.Item("FixStatus") = d.CurrentStatus
        r.Item("Fullname") = d.CreatedBy
        r.Item("GroupID") = d.GroupID
        r.Item("GroupInits") = d.GroupInitials
        r.Item("Groupname") = d.GroupName
        r.Item("ID") = d.ID
        r.Item("LastChanged") = d.DateSync
        r.Item("Lat") = d.Lattitude
        r.Item("Lng") = d.Longitude
        r.Item("Location") = d.Location
        r.Item("LocationExtRef") = d.LocationExtRef
        r.Item("LocID") = d.LocationID
        r.Item("MPGUID") = d.MPGUID
        r.Item("Owner") = d.CreatedByID
        ' r.Item("Photo") = d.Photo 'csv doesn't like blobs
        r.Item("Priority") = d.PriorityID
        r.Item("ProjectLinkID") = d.ProjectLinkID
        r.Item("Purge") = Nothing
        r.Item("SDCode") = d.SDCode
        r.Item("SDID") = d.SDID
        r.Item("ShortDescrip") = d.UserDescription
        r.Item("SnagID") = d.ID
        r.Item("srt") = Nothing
        r.Item("Status") = d.Status
        r.Item("UserID") = Nothing 'what is this used for?
        r.Item("Xcoord") = d.XCoord
        r.Item("YCoord") = d.YCoord


        For Each item As Object In r.ItemArray
            ' If TypeOf (item) Is System.String Then
            If Not IsDBNull(item) Then
                item = Replace(item, ",", " ")
            End If
            'End If
        Next


        viewR.Item("ID") = d.ID
        viewR.Item("GroupName") = d.GroupName
        viewR.Item("Description") = d.SDCategory & " - " & d.SDDescription & " - " & d.UserDescription
        viewR.Item("CreatedBy") = d.CreatedBy
        viewR.Item("Location") = d.Location

    End Sub

    Private Sub AddRow(ByRef r As DataRow, ByRef viewR As DataRow, ByVal ins As Inspection, ByVal Form As InspectionForm, ByVal check As FormCheck)


        r.Item("ProjectTitle") = Replace(ins.ProjectTitle, ",", " ")
        r.Item("ContractNo") = Replace(ins.ContractNo, ",", " ")
        r.Item("Drawing") = Replace(ins.Drawing, ",", " ")
        r.Item("DrwgID") = Replace(ins.DrwgID, ",", " ")
        r.Item("InspectionName") = Replace(ins.InspectionName, ",", " ") 'ExtRef
        r.Item("Location") = Replace(ins.Location, ",", " ")
        r.Item("LocID") = Replace(ins.LocID, ",", " ")
        r.Item("LocationExtRef") = Replace(ins.LocationExtRef, ",", " ")
        r.Item("PlotID") = Replace(ins.PlotID, ",", " ")
        r.Item("CreatedDate") = Replace(ins.CreatedDate, ",", " ")
        r.Item("CreatedBy") = Replace(ins.CreatedBy, ",", " ")
        r.Item("Status") = Replace(ins.Status, ",", " ")
        r.Item("ClosedDate") = Replace(ins.ClosedDate, ",", " ")
        r.Item("ClosedBy") = Replace(ins.ClosedBy, ",", " ")
        r.Item("PPCGuid") = Replace(ins.PPCGuid, ",", " ")
        r.Item("CSStart") = Replace(ins.CSStart, ",", " ")
        r.Item("CSFinish") = Replace(ins.CSFinish, ",", " ")
        r.Item("RIGUID") = Replace(ins.RIGUID, ",", " ")

        'inspectionform
        r.Item("FormID") = Replace(Form.FormID, ",", " ")
        r.Item("FormCode") = Replace(Form.FormCode, ",", " ")
        r.Item("FormName") = Replace(Form.FormName, ",", " ")
        r.Item("FormShortName") = Replace(Form.FormShortName, ",", " ")
        r.Item("IssuedDate") = Replace(Form.IssuedDate, ",", " ")
        r.Item("ValudUntil") = Replace(Form.ValudUntil, ",", " ")
        r.Item("IssuedTo") = Replace(Form.IssuedTo, ",", " ")
        r.Item("IssuedBy") = Replace(Form.IssuedBy, ",", " ")
        r.Item("AcceptedBy") = Replace(Form.AcceptedBy, ",", " ")
        r.Item("Closed") = Replace(Form.Closed, ",", " ")
        r.Item("Passed") = Replace(Form.Passed, ",", " ")

        'formchecks
        'r.Item("SCID") = replace(check.SCID
        r.Item("CheckCode") = Replace(check.CheckCode, ",", " ")
        r.Item("Categ") = Replace(check.Categ, ",", " ")
        r.Item("Question") = Replace(check.Question, ",", " ")
        r.Item("srt") = Replace(check.srt, ",", " ")
        r.Item("Result") = Replace(check.Result, ",", " ")
        r.Item("ResultText") = Replace(check.ResultText, ",", " ")
        r.Item("ResultImg") = Replace(check.ResultImg, ",", " ")
        r.Item("FIAID") = Replace(check.FIAID, ",", " ")
        r.Item("Username") = Replace(check.Username, ",", " ")
        r.Item("DateStamp") = Replace(check.DateStamp, ",", " ")
        r.Item("AnswerType") = Replace(check.AnswerType, ",", " ")
        r.Item("Mandatory") = Replace(check.Mandatory, ",", " ")
        r.Item("PageNo") = Replace(check.PageNo, ",", " ")
        r.Item("FCID") = Replace(check.FCID, ",", " ")
        r.Item("ListCode") = Replace(check.ListCode, ",", " ")
        r.Item("LinkCheckCode") = Replace(check.LinkCheckCode, ",", " ")
        r.Item("FCGUID") = Replace(check.FCGUID, ",", " ")
        r.Item("AutoSnagged") = Replace(check.AutoSnagged, ",", " ")

        viewR.Item("CheckCode") = check.CheckCode
        viewR.Item("Question") = check.Question
        viewR.Item("Result") = check.Result
        viewR.Item("ResultText") = check.ResultText
    End Sub




    Function getData() As Boolean

        toggleControl(btnLogin)

        downloadStatusOutput = ""
        txtDownloadStatus.Text = ""
        dgvResult.DataSource = Nothing


        Try
            'need to process each url on a background thread, otherwise the UI is locked

            url = txtURL.Text.Trim()
            If Not url.EndsWith("/") Then
                url = url & "/"
            End If

           Dim client As New HttpClient()
            client.BaseAddress = New Uri(url)
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            'we are using HTTP Basic Authentication header to pass the username & password to the API
            Dim isoEncoding = Encoding.GetEncoding("iso-8859-1")
            Dim authBytes As Byte() = isoEncoding.GetBytes((txtUsername.Text & ":" & txtPassword.Text).ToCharArray())
            client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", Convert.ToBase64String(authBytes))
            Dim companyloginResponse As HttpResponseMessage = client.GetAsync("api/Login").Result

            'check for http:200 response (success)
            If companyloginResponse.IsSuccessStatusCode Then

                'read the key from the api response
                key = companyloginResponse.Content.ReadAsAsync(Of String)().Result

                'now we have a valid key we can hit the rest of the API - the key must be appended to the querystring for every api call
                Dim projectsResponse As HttpResponseMessage = client.GetAsync("api/Schedules?key=" & key & "&Fields=SchedID,Schedname").Result
                If projectsResponse.IsSuccessStatusCode Then

                    'get a list of projects
                    schedules = projectsResponse.Content.ReadAsAsync(Of List(Of SchedulesObj))().Result
                    If Not schedules Is Nothing Then

                        'this action updates the status textbox value and scrolls it to the bottom
                        Dim action As MethodInvoker = Sub()

                                                          For Each s As SchedulesObj In schedules
                                                              Me.ddlSchedules.Items.Add(s.Schedname.ToString())
                                                          Next

                                                      End Sub

                        ddlSchedules.BeginInvoke(action)


                    Else

                    End If
                End If

                Dim drwgsResponse As HttpResponseMessage = client.GetAsync("api/Drawings?key=" & key & "&Fields=DrwgID,DrwgTitle").Result
                If drwgsResponse.IsSuccessStatusCode Then

                    'get a list of projects
                    drwgs = drwgsResponse.Content.ReadAsAsync(Of List(Of DrwgsObj))().Result
                    If Not drwgs Is Nothing Then

                        'this action updates the status textbox value and scrolls it to the bottom
                        Dim action As MethodInvoker = Sub()

                                                          For Each d As DrwgsObj In drwgs
                                                              Me.ddlDrwgs.Items.Add(d.DrwgTitle.ToString())
                                                          Next

                                                      End Sub

                        ddlDrwgs.BeginInvoke(action)


                    Else

                    End If
                End If

            End If

        Catch ex As Exception
        Finally
            toggleControl(btnLogin)
        End Try

        Return True

    End Function

    Public Shared Sub ExportDatasetToCSV(table As DataTable, ByVal FileToSave As String)

        Dim result = New StringBuilder()
        For i As Integer = 0 To table.Columns.Count - 1
            result.Append(table.Columns(i).ColumnName)
            result.Append(IIf(i = table.Columns.Count - 1, vbLf, ","))
        Next

        For Each row As DataRow In table.Rows
            For i As Integer = 0 To table.Columns.Count - 1
                result.Append(row(i).ToString())
                result.Append(IIf(i = table.Columns.Count - 1, vbLf, ","))
            Next
        Next

        Using outfile As New StreamWriter(FileToSave)
            outfile.Write(result)
        End Using

    End Sub

    Public Structure SchedulesObj
        Public Schedname As String
        Public SchedID As Integer
    End Structure

    Public Structure DrwgsObj
        Public DrwgTitle As String
        Public DrwgID As Integer
    End Structure



    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'reset
        schedules = New List(Of SchedulesObj)
        Me.ddlSchedules.Items.Clear()
        Me.ddlSchedItems.Items.Clear()
        Me.ddlQuestions.Items.Clear()
        Me.ddlDrwgs.Items.Clear()


        downloadStatusOutput = ""
        Me.txtDownloadStatus.Text = ""
        dgvResult.DataSource = Nothing

        If (txtURL.Text.Length > 0) Then

            Task.Factory.StartNew(Sub()
                                      getData()
                                  End Sub)

        End If

    End Sub


    Private Sub ddlSchedules_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlSchedules.SelectedIndexChanged

        schedID = schedules(ddlSchedules.SelectedIndex).SchedID

        Me.ddlSchedItems.Items.Clear()
        Me.ddlQuestions.Items.Clear()

        toggleControl(ddlSchedules)


        'get list of schedChecks
        Task.Factory.StartNew(Sub()

                                  Dim client As New HttpClient()
                                  client.BaseAddress = New Uri(url)
                                  client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))
                                  Dim schedItemsResponse As HttpResponseMessage = client.GetAsync("api/SchedItems/?key=" & key & "&SchedID=" & schedID).Result

                                  'check for http:200 response (success)
                                  If schedItemsResponse.IsSuccessStatusCode Then

                                      'read the key from the api response
                                      Dim mySchedItems As List(Of TSCHEDITEMS) = schedItemsResponse.Content.ReadAsAsync(Of List(Of TSCHEDITEMS))().Result


                                      If Not mySchedItems Is Nothing Then
                                          For Each schedItem As TSCHEDITEMS In mySchedItems
                                              If Not schedItem.FormCode Is Nothing Then
                                                  If schedItem.FormCode.Length > 0 Then
                                                      schedItems.Add(schedItem)
                                                  End If
                                              End If
                                          Next
                                      End If

                                      If schedItems.Count > 0 Then
                                          Dim action As MethodInvoker = Sub()

                                                                            For Each s As TSCHEDITEMS In schedItems
                                                                                Me.ddlSchedItems.Items.Add(s.Description.ToString())
                                                                            Next

                                                                        End Sub

                                          ddlSchedItems.BeginInvoke(action)
                                      End If
                                  End If

                                  toggleControl(ddlSchedules)

                              End Sub)


    End Sub


    Private Sub updateDownloadStatus(ByVal message As String, Optional ByVal fromSnagsTab As Boolean = False)

        downloadStatusOutput += message & Environment.NewLine()

        If Not fromSnagsTab Then
            Dim action As MethodInvoker = Sub()
                                              txtDownloadStatus.Text = downloadStatusOutput
                                              txtDownloadStatus.SelectionStart = txtDownloadStatus.Text.Length
                                              txtDownloadStatus.ScrollToCaret()
                                          End Sub

            txtDownloadStatus.BeginInvoke(action)
        Else
            Dim action As MethodInvoker = Sub()
                                              txtDownloadStatusSnags.Text = downloadStatusOutput
                                              txtDownloadStatusSnags.SelectionStart = txtDownloadStatusSnags.Text.Length
                                              txtDownloadStatusSnags.ScrollToCaret()
                                          End Sub

            txtDownloadStatusSnags.BeginInvoke(action)
        End If
       


    End Sub

    Private Sub toggleControl(ByVal control As System.Windows.Forms.Control)

        Dim action As MethodInvoker = Sub()
                                          If control.Enabled Then
                                              control.Enabled = False
                                          Else
                                              control.Enabled = True
                                          End If
                                      End Sub

        control.BeginInvoke(action)

        Dim action1 As MethodInvoker = Sub()
                                           If PictureBox1.Visible Then
                                               PictureBox1.Visible = False
                                           Else
                                               PictureBox1.Visible = True
                                           End If

                                           If PictureBox2.Visible Then
                                               PictureBox2.Visible = False
                                           Else
                                               PictureBox2.Visible = True
                                           End If
                                       End Sub

        control.BeginInvoke(action1)

    End Sub


    Private Function getAnsTextFromFormItemAnswersAndPushToAPI(ByVal formCheck As TFORMCHECKS, ByVal FIAID As Integer) As String
        'not used yet

        'we already know formCheck.ResultTxt is nothing or len(0)
        'get AnsText
        Dim ans As TFORMITEMANS
        dicFormItemAnswers.TryGetValue(FIAID, ans)

        If Not ans Is Nothing Then
            formCheck.ResultText = ans.AnsText

            Dim client As New HttpClient()
            client.BaseAddress = New Uri(url)
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            Dim jsonFormatter As System.Net.Http.Formatting.MediaTypeFormatter = New System.Net.Http.Formatting.JsonMediaTypeFormatter()
            Dim formChecksResponse As HttpResponseMessage = client.PutAsync("api/FormChecks/" & formCheck.FCID & "/?key=" & key, New ObjectContent(Of TFORMCHECKS)(formCheck, jsonFormatter)).Result

            If formChecksResponse.IsSuccessStatusCode Then

                'read the key from the api response
                Dim updatedFormCheck As List(Of TFORMCHECKS) = formChecksResponse.Content.ReadAsAsync(Of List(Of TFORMCHECKS))().Result

                Dim test As String = ""
            End If

        End If


    End Function


    Private Sub ddlSchedItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlSchedItems.SelectedIndexChanged
        'fill ddlQuestions
        formCode = schedItems(ddlSchedItems.SelectedIndex).FormCode

        ddlQuestions.Items.Clear()

        toggleControl(ddlSchedItems)

        'get list of Questions - formItems
        Task.Factory.StartNew(Sub()

                                  Dim client As New HttpClient()
                                  client.BaseAddress = New Uri(url)
                                  client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

                                  Dim formItemsResponse As HttpResponseMessage = client.GetAsync("api/FormItems/?key=" & key & "&FormCode=" & formCode).Result

                                  'check for http:200 response (success)
                                  If formItemsResponse.IsSuccessStatusCode Then

                                      'read the key from the api response
                                      Dim myFormItems As List(Of TFORMITEMS) = formItemsResponse.Content.ReadAsAsync(Of List(Of TFORMITEMS))().Result


                                      If Not myFormItems Is Nothing Then
                                          For Each FormItem As TFORMITEMS In myFormItems
                                              If Not FormItem.FormCode Is Nothing Then
                                                  If FormItem.FormCode.Length > 0 Then
                                                      formItems.Add(FormItem)
                                                  End If
                                              End If
                                          Next
                                      End If

                                      If formItems.Count > 0 Then
                                          Dim action As MethodInvoker = Sub()

                                                                            For Each s As TFORMITEMS In formItems
                                                                                Me.ddlQuestions.Items.Add(s.Description.ToString())
                                                                            Next

                                                                        End Sub

                                          ddlQuestions.BeginInvoke(action)
                                      End If
                                  End If

                                  toggleControl(ddlSchedItems)

                              End Sub)



    End Sub

    Private Sub ddlQuestions_SelectedIndexChanged(sender As Object, e As EventArgs)



        ''Dim checks As List(Of TFORMITEMS) = TFORMITEMSDAO.getWhere("FormCode = N'" & ddlSchedItems.SelectedValue & "' And PageNo =" & ddlPagesList1.SelectedValue & " order by srt", SnagRPage.connectionString)
        'Dim checks As List(Of TFORMITEMS) = TFORMITEMSDAO.getWhere("FormCode = N'" & ddlSchedItems.SelectedValue & "' order by pageno, srt", SnagRPage.connectionString)
        'If Not checks Is Nothing Then
        '    For Each check As TFORMITEMS In checks
        '        If InStr(AnswerTypes, check.AnsType.ToLower) > 0 Then
        '            Dim Item As New ListItem
        '            Item.Text = check.Categ & " - " & check.Description
        '            Item.Value = check.CheckCode
        '            ddlQuestions.Items.Add(Item)
        '        End If
        '    Next
        'End If
        'ddlQuestions_SelectedIndexChanged(Nothing, Nothing)

        checkCode = formItems(ddlQuestions.SelectedIndex).CheckCode


    End Sub

    Private Sub btnOutputToDBTable_Click(sender As Object, e As EventArgs) Handles btnOutputToDBTable.Click

        'test open db
        Dim bOK As Boolean = testSQLConnection()

        If Not bOK Then
            Return
        End If

        If chkClearTable.Checked Then
            Dim sSQL As String = "truncate table TSNAGRINSPECTIONDATA"
            SnagRData.RunSQL(txtConnectionString.Text, sSQL)
        End If

        toggleControl(btnOutputToDBTable)
        toggleControl(btnOutputToCSV)

        Task.Factory.StartNew(Sub()

                                  'create Data Table
                                  Dim dt As New DataTable()
                                  CreateDataTable(dt)

                                  'used to create the .csv file
                                  Dim viewDT As New DataTable()
                                  CreateViewTable(viewDT)

                                  'output to table
                                  FillTables(dt, viewDT, False)

                                  updateDownloadStatus("Data added to SnagRAPIData.dbo.tSnagRInspectionData ")

                                  Dim action As MethodInvoker = Sub()
                                                                    dgvResult.DataSource = viewDT
                                                                End Sub

                                  dgvResult.BeginInvoke(action)

                                  toggleControl(btnOutputToDBTable)
                                  toggleControl(btnOutputToCSV)
                              End Sub)

    End Sub


    Private Function testSQLConnection(Optional ByVal isSnagsMode As Boolean = False) As Boolean
        'check if logged in

        If isSnagsMode Then
            If Me.ddlSDCategs.Items.Count = 0 Then
                MessageBox.Show("You must Login first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Else
            If Me.ddlSchedules.Items.Count = 0 Then
                MessageBox.Show("You must Login first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        End If
        

        If txtConnectionString.Text.Length > 0 Then
            Dim sError As Exception
            Try
                'test if database exists - SnagRAPIData
                Dim sSQL As String = "SELECT COUNT(*) FROM Master..sysdatabases WHERE [name] = N'SnagRAPIData'"
                Dim connStr As String = Replace(txtConnectionString.Text, "SnagRAPIData", "Master")

                Dim iCnt As Integer = SnagRData.getSingleItem(sSQL, connStr)
                If iCnt = 0 Then
                    'create database and all tables
                    If CreateInstanceDb() Then
                        Dim sqlpath As String = AppPath & "/Assets/SQLfile.sql"
                        objDBCreate = New DatabaseCreator
                        Try
                            objDBCreate.ExecuteSQLScript(sqlpath, txtConnectionString.Text, "")
                            Return True
                        Catch ex1 As Exception
                            MessageBox.Show("Cannot create Table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End Try
                    End If
                Else
                    'see if table exists
                    Try
                        sSQL = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_CATALOG = 'SnagRAPIData' AND  TABLE_NAME = 'tSnagRFormsDataControl'"
                    Catch ex As Exception
                        'create table tSnagRFormsDataControl
                        Dim sqlpath As String = AppPath & "/Assets/CreatetSnagRFormsDataControl.sql"
                        objDBCreate = New DatabaseCreator
                        Try
                            objDBCreate.ExecuteSQLScript(sqlpath, txtConnectionString.Text, "")
                        Catch ex1 As Exception
                            MessageBox.Show("Cannot create Table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End Try
                    End Try
                    Try
                        sSQL = SnagRData.getSingleItemReturnError("Select Count(*) from tSnagRFormsDataControl", txtConnectionString.Text, sError)
                        If sError Is Nothing Then
                            'success!
                            'data read from db, try writing
                            sSQL = "Insert into tSnagRFormsDataControl (fromURL) values ('" & txtURL.Text & "')"
                            Dim writeError As String = SnagRData.RunSQLErrMsg(txtConnectionString.Text, sSQL)
                            If writeError = "" Then
                                'success!
                                Return True
                            Else
                                MessageBox.Show("You do not have Write access to SQL Server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return False
                            End If
                        Else
                            MessageBox.Show("You do not have Read access to SQL Server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                    Catch ex As Exception
                        Return False
                    End Try
                End If
            Catch ex As Exception
                MessageBox.Show("SQL Server cannot connect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        Else
            MessageBox.Show("You must specify a Database Connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function

    Private Function CreateInstanceDb() As Boolean

        Dim strSQL As String = "IF EXISTS (SELECT [name] FROM Master..sysdatabases WHERE [name] = N'SnagRAPIData')" & vbCrLf & _
                                "BEGIN" & vbCrLf & _
                                "DROP DATABASE  SnagRAPIData " & vbCrLf & _
                                "END" & vbCrLf & _
                                "CREATE DATABASE SnagRAPIData collate Latin1_General_CI_AS " 'UK English 'US English (SQL_Latin1_General_CP1_CI) or Latin1_General_CI_AS UK english


        Dim bolIsConnecting As Boolean = True
        While bolIsConnecting
            Try
                ' The SqlConnection class allows you to communicate with SQL Server.
                ' The constructor accepts a connection string as an argument.  This
                ' connection string uses Integrated Security, which means that you 
                ' must have a login in SQL Server, or be part of the Administrators
                ' group for this to work.

                Dim connStr As String = Replace(txtConnectionString.Text, "SnagRAPIData", "Master")
                Dim SnagRAPIDataConnection As New SqlConnection(connStr)

                ' A SqlCommand object is used to execute the SQL commands.
                Dim cmd As New SqlCommand(strSQL, SnagRAPIDataConnection)

                ' Open the connection, execute the command, and close the 
                ' connection. It is more efficient to ExecuteNonQuery when data is 
                ' not being returned.
                SnagRAPIDataConnection.Open()
                cmd.ExecuteNonQuery()
                SnagRAPIDataConnection.Close()

                ' Data has been successfully submitted, so break out of the loop
                ' and close the status form.
                bolIsConnecting = False

                Return True
            Catch sqlExc As SqlException
                Return False
                Exit While
            Catch exc As Exception
                Return False
            End Try
        End While
        Return True
    End Function

    Private Sub ddlDrwgs_SelectedIndexChanged(sender As Object, e As EventArgs)
        'checkCode = formItems(ddlQuestions.SelectedIndex).CheckCode

    End Sub

    'Snags section
    Public Structure SDCategsObj
        Public SDCategory As String
        Public SDCatID As Integer
    End Structure

    Public Structure SDTypesObj
        Public Description As String
        Public SDCode As String
    End Structure

    Private Sub btnLoginSnags_Click(sender As Object, e As EventArgs) Handles btnLoginSnags.Click

        'reset
        sdcategs = New List(Of SDCategsObj)
        Me.ddlSDCategs.Items.Clear()
        'Me.lbSDTypes.Items.Clear()

        downloadStatusOutput = ""
        Me.txtDownloadStatus.Text = ""
        dgvResult.DataSource = Nothing

        If (txtURL.Text.Length > 0) Then

            Task.Factory.StartNew(Sub()
                                      getDataSnags()
                                  End Sub)

        End If
    End Sub

    Function getDataSnags() As Boolean

        toggleControl(btnLoginSnags)

        downloadStatusOutput = ""
        txtDownloadStatus.Text = ""
        dgvResultSnags.DataSource = Nothing


        Try
            'need to process each url on a background thread, otherwise the UI is locked

            url = txtURLSnags.Text.Trim()
            If Not url.EndsWith("/") Then
                url = url & "/"
            End If

            Dim client As New HttpClient()
            client.BaseAddress = New Uri(url)
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            'we are using HTTP Basic Authentication header to pass the username & password to the API
            Dim isoEncoding = Encoding.GetEncoding("iso-8859-1")
            Dim authBytes As Byte() = isoEncoding.GetBytes((txtUsernameSnags.Text & ":" & txtPasswordSnags.Text).ToCharArray())
            client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", Convert.ToBase64String(authBytes))
            Dim companyloginResponse As HttpResponseMessage = client.GetAsync("api/Login").Result

            'check for http:200 response (success)
            If companyloginResponse.IsSuccessStatusCode Then

                'read the key from the api response
                key = companyloginResponse.Content.ReadAsAsync(Of String)().Result

                'now we have a valid key we can hit the rest of the API - the key must be appended to the querystring for every api call
                Dim projectsResponse As HttpResponseMessage = client.GetAsync("api/SDCategories?key=" & key & "&Fields=SDCatID,SDCategory").Result
                If projectsResponse.IsSuccessStatusCode Then

                    'get a list of projects
                    sdcategs = projectsResponse.Content.ReadAsAsync(Of List(Of SDCategsObj))().Result
                    If Not sdcategs Is Nothing Then

                        'this action updates the status textbox value and scrolls it to the bottom
                        Dim action As MethodInvoker = Sub()

                                                          For Each s As SDCategsObj In sdcategs
                                                              Me.ddlSDCategs.Items.Add(s.SDCategory.ToString())
                                                          Next

                                                      End Sub

                        ddlSDCategs.BeginInvoke(action)


                    Else

                    End If
                End If

            End If

        Catch ex As Exception
        Finally
            toggleControl(btnLoginSnags)
        End Try

        Return True

    End Function


    Private Sub ddlSDCategs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlSDCategs.SelectedIndexChanged
        sdcatID = sdcategs(ddlSDCategs.SelectedIndex).SDCatID

        Me.lbSDTypes.DataSource = Nothing

        toggleControl(ddlSDCategs)


        'get list of schedChecks
        Task.Factory.StartNew(Sub()

                                  Dim client As New HttpClient()
                                  client.BaseAddress = New Uri(url)
                                  client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

                                  Dim sdTypesResponse As HttpResponseMessage = client.GetAsync("api/SDTypes/?key=" & key & "&SDCatID=" & sdcatID).Result

                                  'check for http:200 response (success)
                                  If sdTypesResponse.IsSuccessStatusCode Then

                                      'read the key from the api response
                                      Dim mysdTypes As List(Of TSDTYPES) = sdTypesResponse.Content.ReadAsAsync(Of List(Of TSDTYPES))().Result

                                      If mysdTypes.Count > 0 Then
                                          Dim action As MethodInvoker = Sub()

                                                                            lbSDTypes.DataSource = mysdTypes
                                                                            lbSDTypes.DisplayMember = "Description"
                                                                            lbSDTypes.ValueMember = "SDCode"

                                                                            'For Each s As TSDTYPES In mysdTypes
                                                                            '   Me.lbSDTypes.Items.Add(s.Description.ToString())
                                                                            'Next

                                                                        End Sub

                                          lbSDTypes.BeginInvoke(action)
                                      End If
                                  End If

                                  toggleControl(ddlSDCategs)

                              End Sub)

    End Sub


    Private Sub btnOutputToDBTableSnags_Click(sender As Object, e As EventArgs) Handles btnOutputToDBTableSnags.Click
        'test open db
        Dim bOK As Boolean = testSQLConnection(True)

        If Not bOK Then
            Return
        End If

        If chkClearTableSnags.Checked Then
            Dim sSQL As String = "truncate table TPROJECTSNAGS"
            SnagRData.RunSQL(txtConnectionString.Text, sSQL)
        End If

        Dim selectedItems As New List(Of TSDTYPES)
        For Each item As TSDTYPES In lbSDTypes.SelectedItems
            selectedItems.Add(item)
        Next

        toggleControl(btnOutputToDBTableSnags)
        toggleControl(btnOutputToCSVSnags)

        Task.Factory.StartNew(Sub()

                                  'create Data Table
                                  Dim dt As New DataTable()
                                  CreateDataTable(dt)

                                  'used to create the .csv file
                                  Dim viewDT As New DataTable()
                                  CreateViewTableSnags(viewDT)


                                  'output to table
                                  FillTablesSnags(dt, viewDT, selectedItems, False)

                                  updateDownloadStatus("Data added to SnagRAPIData.dbo.tProjectSnags ")

                                  Dim action As MethodInvoker = Sub()
                                                                    dgvResultSnags.DataSource = viewDT
                                                                End Sub

                                  dgvResultSnags.BeginInvoke(action)

                                  toggleControl(btnOutputToDBTableSnags)
                                  toggleControl(btnOutputToCSVSnags)
                              End Sub)
    End Sub


    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        dateStampFrom = DateTimePicker1.Value
    End Sub
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        dateStampTo = DateTimePicker2.Value
    End Sub
   

    Private Sub dateStampFromSnags_ValueChanged(sender As Object, e As EventArgs) Handles dateStampFromSnags.ValueChanged
        dateStampFromSnagsVal = dateStampFromSnags.Value
    End Sub

    Private Sub dateStampToSnags_ValueChanged(sender As Object, e As EventArgs) Handles dateStampToSnags.ValueChanged
        dateStampToSnagsVal = dateStampToSnags.Value
    End Sub


End Class
