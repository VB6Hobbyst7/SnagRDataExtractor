Imports System.IO
Imports System.Text

Public Class SnagRError

    Public Shared Sub LogError(ByVal currentUser As String, ByVal ex As System.Exception, Optional ByVal requestPath As String = "Path Not Sent", Optional ByVal sSQL As String = Nothing)

        Try

            'Dim logPath As String = Web.HttpContext.Current.Server.MapPath("/Config/") + Web.HttpContext.Current.Request.ServerVariables("SERVER_NAME") + "/Projects/" + Web.HttpContext.Current.Items("project") + "/logs/"
            'If Directory.Exists(logPath) Then
            '    logPath += currentUser + "-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt"
            'Else
            '    logPath = HttpContext.Current.Server.MapPath("/Build/Admin/logs/") + currentUser + "-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt"
            'End If

            'Dim sErr As String = Nothing
            'Dim exMessage As String = ""
            'Dim innerException As String = ""
            'Dim StackTrace As String = ""

            'If Not ex.Message Is Nothing Then
            '    exMessage = ex.Message.ToString()
            'Else
            '    exMessage = "No Message"
            'End If

            'If Not ex.InnerException Is Nothing Then
            '    innerException = ex.InnerException.Message.ToString()
            'Else
            '    innerException = "No InnerException"

            'End If

            'If Not ex.StackTrace Is Nothing Then
            '    StackTrace = ex.StackTrace
            'Else
            '    StackTrace = "No StackTrace Sent"
            'End If


            'Dim sContents As String = ""
            'If File.Exists(logPath) Then
            '    sContents = GetFileContents(logPath)
            'End If

            'sContents += "---------------------------- " + DateTime.Now.ToString() + " --------------------------------" + Environment.NewLine() + Environment.NewLine()
            'sContents += "Full URL Request " + HttpContext.Current.Request.Url.AbsoluteUri + Environment.NewLine()
            'sContents += "Path: " + requestPath + Environment.NewLine()
            'sContents += "SQL: " + sSQL + Environment.NewLine()
            'sContents += "Exception Message: " + ex.ToString() + Environment.NewLine() + Environment.NewLine()
            'sContents += "Inner Exception: " + innerException + Environment.NewLine() + Environment.NewLine()
            'sContents += "StackTrace: " + Environment.NewLine() + StackTrace + Environment.NewLine() + Environment.NewLine()
            'sContents += "User IP Address (Could be proxy): " + HttpContext.Current.Request.ServerVariables("REMOTE_ADDR") + Environment.NewLine()
            'sContents += "Server Name: " + HttpContext.Current.Server.MachineName + Environment.NewLine()
            'sContents += "---------------------------------------------------------------------------------" + Environment.NewLine() + Environment.NewLine()


            ''Possible to put stack trace in here with: trace.GetFrame(0).ToString

            'If sErr = "" Then
            '    Dim bAns As Boolean = False
            '    bAns = SaveTextToFile(sContents, logPath, sErr)
            '    If bAns Then
            '        Debug.WriteLine("File Saved!")
            '    Else
            '        Debug.WriteLine("Error Saving File: " & sErr)
            '    End If

            'Else
            '    Debug.WriteLine("Error retrieving file: " & sErr)
            'End If
        Catch ex2 As Exception

        End Try


    End Sub
    Public Shared Sub LogError(ByVal ex As String)
        'Try

        '    Dim logPath As String = Web.HttpContext.Current.Server.MapPath("/Config/")
        '    If Directory.Exists(logPath) Then
        '        logPath += DateTime.Now.ToString("dd-MM-yyyy") + ".txt"
        '    Else
        '        logPath = HttpContext.Current.Server.MapPath("/Config") + "-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt"
        '    End If

        '    Dim sErr As String = Nothing
        '    Dim exMessage As String = ex
        '    Dim innerException As String = ""
        '    Dim StackTrace As String = ""
        '    Dim sContents As String = ""
        '    If File.Exists(logPath) Then
        '        sContents = GetFileContents(logPath)
        '    End If

        '    sContents += Environment.NewLine() + DateTime.Now.ToString() + " - " + "Path: " + " - " + exMessage + "  -  " + innerException + " - " + StackTrace + Environment.NewLine() + Environment.NewLine()
        '    If sErr = "" Then
        '        Dim bAns As Boolean = False
        '        bAns = SaveTextToFile(sContents, logPath, sErr)
        '        If bAns Then
        '            Debug.WriteLine("File Saved!")
        '        Else
        '            Debug.WriteLine("Error Saving File: " & sErr)
        '        End If

        '    Else
        '        Debug.WriteLine("Error retrieving file: " & sErr)
        '    End If

        'Catch ex2 As Exception

        'End Try


    End Sub
    Public Shared Sub LogError(ByVal ex As System.Exception)
        'Try


        '    Dim currentUser As String = "user"
        '    Dim requestPath As String = ""
        '    If Not HttpContext.Current Is Nothing Then
        '        If Not HttpContext.Current.Session("Username") Is Nothing Then
        '            currentUser = HttpContext.Current.Session("Username")
        '        End If
        '        requestPath = HttpContext.Current.Request.Url.AbsoluteUri
        '    End If


        '    Dim logPath As String = Web.HttpContext.Current.Server.MapPath("/Config/") + Web.HttpContext.Current.Request.ServerVariables("SERVER_NAME") + "/Projects/" + Web.HttpContext.Current.Items("project") + "/logs/"
        '    If Directory.Exists(logPath) Then
        '        logPath += currentUser + "-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt"
        '    Else
        '        logPath = HttpContext.Current.Server.MapPath("/Build/Admin/logs/") + currentUser + "-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt"
        '    End If

        '    Dim sErr As String = Nothing
        '    Dim exMessage As String = ""
        '    Dim innerException As String = ""
        '    Dim StackTrace As String = ""

        '    If Not ex.Message Is Nothing Then
        '        exMessage = ex.Message.ToString()
        '    Else
        '        exMessage = "No Message"
        '    End If

        '    If Not ex.InnerException Is Nothing Then
        '        innerException = ex.InnerException.Message.ToString()
        '    Else
        '        innerException = "No InnerException"
        '    End If

        '    If Not ex.StackTrace Is Nothing Then
        '        StackTrace = ex.StackTrace
        '    Else
        '        StackTrace = "No StackTrace Sent"
        '    End If


        '    Dim sContents As String = ""
        '    If File.Exists(logPath) Then
        '        sContents = GetFileContents(logPath)
        '    End If

        '    sContents += "---------------------------- " + DateTime.Now.ToString() + " --------------------------------" + Environment.NewLine() + Environment.NewLine()
        '    sContents += "Full URL Request " + HttpContext.Current.Request.Url.AbsoluteUri + Environment.NewLine()
        '    sContents += "Path: " + requestPath + Environment.NewLine()
        '    sContents += "Exception Message: " + ex.ToString() + Environment.NewLine()
        '    sContents += "Inner Exception: " + innerException + Environment.NewLine() + Environment.NewLine()
        '    sContents += "StackTrace: " + Environment.NewLine() + StackTrace + Environment.NewLine() + Environment.NewLine()
        '    sContents += "User IP Address (Could be proxy): " + HttpContext.Current.Request.ServerVariables("REMOTE_ADDR") + Environment.NewLine()
        '    sContents += "Server Name: " + HttpContext.Current.Server.MachineName + Environment.NewLine()
        '    sContents += "---------------------------------------------------------------------------------" + Environment.NewLine() + Environment.NewLine()


        '    If sErr = "" Then
        '        Dim bAns As Boolean = False
        '        bAns = SaveTextToFile(sContents, logPath, sErr)
        '        If bAns Then
        '            Debug.WriteLine("File Saved!")
        '        Else
        '            Debug.WriteLine("Error Saving File: " & sErr)
        '        End If

        '    Else
        '        Debug.WriteLine("Error retrieving file: " & sErr)
        '    End If

        'Catch ex2 As Exception

        'End Try


    End Sub

    Public Shared Sub LogError(ByVal ex As System.Exception, ByVal sSQL As String)
        Try


            'Dim currentUser As String = "user"
            'If Not HttpContext.Current.Session("Username") Is Nothing Then
            '    currentUser = HttpContext.Current.Session("Username")
            'End If
            'Dim requestPath As String = HttpContext.Current.Request.Url.AbsoluteUri

            'Dim logPath As String = Web.HttpContext.Current.Server.MapPath("/Config/") + Web.HttpContext.Current.Request.ServerVariables("SERVER_NAME") + "/Projects/" + Web.HttpContext.Current.Items("project") + "/logs/"
            'If Directory.Exists(logPath) Then
            '    logPath += currentUser + "-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt"
            'Else
            '    logPath = HttpContext.Current.Server.MapPath("/Build/Admin/logs/") + currentUser + "-" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt"
            'End If

            'Dim sErr As String = Nothing
            'Dim exMessage As String = ""
            'Dim innerException As String = ""
            'Dim StackTrace As String = ""

            'If Not ex.Message Is Nothing Then
            '    exMessage = ex.Message.ToString()
            'Else
            '    exMessage = "No Message"
            'End If

            'If Not ex.InnerException Is Nothing Then
            '    innerException = ex.InnerException.Message.ToString()
            'Else
            '    innerException = "No InnerException"
            'End If

            'If Not ex.StackTrace Is Nothing Then
            '    StackTrace = ex.StackTrace
            'Else
            '    StackTrace = "No StackTrace Sent"
            'End If


            'Dim sContents As String = ""
            'If File.Exists(logPath) Then
            '    sContents = GetFileContents(logPath)
            'End If

            'sContents += Environment.NewLine() + DateTime.Now.ToString() + " - " + "Path: " + requestPath + " - " + exMessage + "  -  " + innerException + " - " + StackTrace + Environment.NewLine() + Environment.NewLine()
            'sContents += "Full URL Request " + HttpContext.Current.Request.Url.AbsoluteUri + Environment.NewLine()
            'sContents += "User IP Address (Could be proxy): " + HttpContext.Current.Request.ServerVariables("REMOTE_ADDR") + Environment.NewLine()
            'sContents += "Server Name: " + HttpContext.Current.Server.MachineName + Environment.NewLine()
            'sContents += "SQL: " + sSQL + Environment.NewLine()

            'If sErr = "" Then
            '    Dim bAns As Boolean = False
            '    bAns = SaveTextToFile(sContents, logPath, sErr)
            '    If bAns Then
            '        Debug.WriteLine("File Saved!")
            '    Else
            '        Debug.WriteLine("Error Saving File: " & sErr)
            '    End If

            'Else
            '    Debug.WriteLine("Error retrieving file: " & sErr)
            'End If

        Catch ex2 As Exception

        End Try


    End Sub


    Public Shared Function GetFileContents(ByVal FullPath As String, Optional ByRef ErrInfo As String = "") As String

        Dim strContents As String
        Dim objReader As StreamReader
        Try

            objReader = New StreamReader(FullPath)
            strContents = objReader.ReadToEnd()
            objReader.Close()
            Return strContents
        Catch Ex As Exception
            ErrInfo = Ex.Message
        End Try

    End Function

    Public Shared Function SaveTextToFile(ByVal strData As String, ByVal FullPath As String, Optional ByVal ErrInfo As String = "") As Boolean

        Dim Contents As String
        Dim bAns As Boolean = False
        Dim objReader As StreamWriter
        Try
            objReader = New StreamWriter(FullPath, False, Encoding.UTF8)
            objReader.Write(strData)
            objReader.Close()
            bAns = True
        Catch Ex As Exception
            ErrInfo = Ex.Message

        End Try
        Return bAns
    End Function

End Class
