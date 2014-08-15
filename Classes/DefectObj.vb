Public Class DefectObj

    Public ProjectTitle As String
    Public ContractNo As String

    Public Property ID As Integer
    Public Property GUID As String
    Public Property ProjectLinkID As Integer '?

    Public Property DrawingID As Integer
    Public Property DrawingTitle As String

    Public Property Status As String
    Public Property CurrentStatus As String

    Public Property UserDescription As String

    Public Property LocationID As Integer
    Public Property Location As String
    Public Property LocationExtRef As String
    Public Property LocationGUID As String

    Public Property XCoord As Integer 'notice the capitalisation!!!
    Public Property YCoord As Integer

    Public Property PriorityID As Integer
    Public Property Priority As String

    Public Property CreatedDate As DateTime 'notice the capitalisation!!!

    'really wish this didn't need to be here! We could filter these always have Where DrwgLink = 0 and then have a separate API for links.
    'Public Property DrwgLink As Integer

    Public Property Photo As String 'needs to be converted by client to Byte()

    Public Property DueBy As DateTime 'spell change
    Public Property DaysLeft As Integer

    Public Property GroupID As Integer
    Public Property GroupName As String
    Public Property GroupInitials As String

    Public Property DateClosed As DateTime

    Public Property BigPhoto As String 'needs to be converted by client to Byte()

    Public Property Lattitude As Decimal 'spelling
    Public Property Longitude As Decimal 'spelling

    Public Property CreatedByID As Integer 'owner more descriptive
    Public Property CreatedBy As String

    Public Property SDCode As String
    Public Property SDID As Integer
    Public Property SDCategory As String
    Public Property SDCategoryID As Integer

    Public Property SDDescription As String

    Public Property DateSync As DateTime

    Public Property MPGUID As String
    Public Property FCGUID As String

    'Public Property Purge As Boolean 'notice datatype change

    Public Property Updates As List(Of DefectUpdate)
    Public Property FutureDefectGUIDs As List(Of String)
    Public Property PreviousDefectGUID As String 'LinkBackGUID

    Public Sub New()
        CreatedDate = Now
        DateSync = Now
        DueBy = Now.Date.AddDays(7)

    End Sub

  

End Class
