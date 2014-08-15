Public Class SnagObj

    Public Class Snag

        Public SnagID As Integer
        Public ProjectLinkID As Integer
        Public DrwgID As Integer
        Public Status As String
        Public ShortDescrip As String
        Public LocID As Integer
        Public LocationExtRef As String
        Public Location As String
        Public Xcoord As Integer
        Public YCoord As Integer
        Public Priority As Integer
        Public Datestamp As DateTime
        Public DrwgLink As Integer

        Public Photo As String 'needs to be converted by client to Byte()

        Public DoBy As DateTime
        Public GroupID As Integer
        Public GroupInits As String
        Public DateClosed As String

        Public BigPhoto As String 'needs to be converted by client to Byte()

        Public Lat As Decimal
        Public Lng As Decimal
        Public Owner As Integer
        Public SDCode As String
        Public SDID As Integer
        Public DateSync As DateTime
        Public FixStatus As String
        Public MPGUID As String
        Public Purge As Integer
        Public DaysLeft As Integer
        Public DrwgSrt As Integer
        Public DrwgTitle As String
        Public FixDescrip As String
        Public By As Integer
        Public UserID As Integer
        Public Fullname As String
        Public CanBeEmailed As Boolean
        Public srt As Integer
        Public LastChanged As DateTime
        Public Groupname As String
        Public CoGroupID As Integer

    End Class

End Class
