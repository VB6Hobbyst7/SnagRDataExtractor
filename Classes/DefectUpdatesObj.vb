Public Class DefectUpdates


    Public Shared Function getUsingSnagID(ByVal SnagID As Integer, ByVal connectionString As String) As List(Of DefectUpdate)
        getUsingSnagID = New List(Of DefectUpdate)

        Dim updates As List(Of TSNAGUPDATES) = TSNAGUPDATESDAO.getWhere("SnagID = " & SnagID, connectionString)
        If Not updates Is Nothing Then
            For Each update As TSNAGUPDATES In updates
                Dim u As New DefectUpdate()
                u.fillUsingTSnagUpdateObj(update, connectionString)
                getUsingSnagID.Add(u)
            Next
        End If
    End Function


End Class




Public Class DefectUpdate

    Public ID As Integer
    Public DefectID As Integer
    Public Status As String

    Public UserDescription As String

    Public Username As String
    Public UserFullName As String
    Public UserID As Integer

    Public DateStamp As DateTime 'capitalisation

    Public Photo As String 'client needs to base64Decode
    Public BigPhoto As String 'client needs to base64Decode

    Public UpdateGUID As String

    Public Signature1 As String
    Public Signature2 As String

    Public DateSync As DateTime

    Public Sub New()

    End Sub


    Public Sub getUsingSUID(ByVal SUID As Integer, ByVal connectionString As String)
        Dim update As TSNAGUPDATES = TSNAGUPDATESDAO.getUsingSUID(SUID, connectionString)
        fillUsingTSnagUpdateObj(update, connectionString)
    End Sub

    Public Sub fillUsingTSnagUpdateObj(ByVal update As TSNAGUPDATES, ByVal connectionString As String)
        ID = update.SUID
        DefectID = update.SnagID
        Status = update.Status
        UserDescription = update.FixDescrip

        Dim user As TUSERS = TUSERSDAO.getUsingUserID(update.UserID, connectionString)
        Username = user.Username
        UserFullName = user.Fullname
        UserID = user.UserID

        DateStamp = update.Datestamp
        Photo = update.Photo
        BigPhoto = update.BigPhoto
        UpdateGUID = update.PPCGuid
        Signature1 = update.Signature1
        Signature2 = update.Signature2
        DateSync = update.DateSync

    End Sub

End Class
