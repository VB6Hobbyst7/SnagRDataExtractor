

Public Class Inspection

    Public ProjectTitle As String
    Public ContractNo As String

    Public Drawing As String
    Public DrwgID As Integer

    Public InspectionName As String 'ExtRef
    Public InspectionInits As String

    Public Location As String
    Public LocID As Integer
    Public LocationExtRef As String

    Public PlotID As Integer

    Public CreatedDate As DateTime
    Public CreatedBy As String 'Owner
    Public CreatedByID As Integer

    Public Status As String
    Public ClosedDate As DateTime
    Public ClosedBy As String
    Public ClosedByID As Integer

    Public InspectionForms As New List(Of InspectionForm)
    Public InspectionChecks As New List(Of InspectionCheck)


    Public PPCGuid As String

    Public CSStart As DateTime
    Public CSFinish As DateTime

    Public RIGUID As String

End Class

Public Structure InspectionForm

    Dim FormName As String
    Dim FormShortName As String
    Dim FormID As Integer 'SCID
    Dim FormCode As String

    Dim IssuedDate As DateTime
    Dim ValudUntil As DateTime

    Dim IssuedTo As String
    Dim IssuedBy As String
    Dim AcceptedBy As String

    Dim Closed As Boolean
    Dim Passed As Boolean

    Dim FormChecks As List(Of FormCheck)

End Structure

Public Structure InspectionCheck
    Dim SCID As Integer
    Dim Code As String
    Dim Question As String

    Dim srt As String

    Dim Qty As Integer
    Dim Result As Integer
    Dim Comment As String

    Dim Username As String
    Dim UserID As Integer

    Dim DateStamp As DateTime

    Dim DueBy As DateTime

    Dim Cost As Decimal


End Structure

Public Structure FormCheck
    Dim SCID As Integer
    Dim CheckCode As String
    Dim Categ As String
    Dim Question As String

    Dim srt As String

    Dim Result As Integer
    Dim ResultText As String
    Dim ResultImg As String 'needs to be converted by client to Byte()

    Dim FIAID As Integer

    Dim Username As String
    Dim UserID As Integer
    Dim DateStamp As DateTime

    Dim AnswerType As String

    Dim Mandatory As Boolean

    Dim PageNo As Integer

    Dim FCID As Integer
    Dim ListCode As String
    Dim LinkCheckCode As String
    Dim FCGUID As String

    Dim AutoSnagged As Boolean



End Structure

