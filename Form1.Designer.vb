<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chkUseDates = New System.Windows.Forms.CheckBox()
        Me.chkSelectDrwg = New System.Windows.Forms.CheckBox()
        Me.chkSelectQuestion = New System.Windows.Forms.CheckBox()
        Me.chkClearTable = New System.Windows.Forms.CheckBox()
        Me.btnOutputToDBTable = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtConnectionString = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvResult = New System.Windows.Forms.DataGridView()
        Me.chkIncludeImages = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDownloadStatus = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ddlDrwgs = New System.Windows.Forms.ComboBox()
        Me.ddlQuestions = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ddlSchedItems = New System.Windows.Forms.ComboBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnOutputToCSV = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ddlSchedules = New System.Windows.Forms.ComboBox()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.chkUseDatesSnags = New System.Windows.Forms.CheckBox()
        Me.chkClearTableSnags = New System.Windows.Forms.CheckBox()
        Me.btnOutputToDBTableSnags = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtConnectionStringSnags = New System.Windows.Forms.TextBox()
        Me.dgvResultSnags = New System.Windows.Forms.DataGridView()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDownloadStatusSnags = New System.Windows.Forms.TextBox()
        Me.dateStampToSnags = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dateStampFromSnags = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnOutputToCSVSnags = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbSDTypes = New System.Windows.Forms.ListBox()
        Me.btnLoginSnags = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ddlSDCategs = New System.Windows.Forms.ComboBox()
        Me.txtURLSnags = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPasswordSnags = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtUsernameSnags = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvResultSnags, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 6)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1292, 1556)
        Me.TabControl1.TabIndex = 42
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage1.Controls.Add(Me.chkUseDates)
        Me.TabPage1.Controls.Add(Me.chkSelectDrwg)
        Me.TabPage1.Controls.Add(Me.chkSelectQuestion)
        Me.TabPage1.Controls.Add(Me.chkClearTable)
        Me.TabPage1.Controls.Add(Me.btnOutputToDBTable)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txtConnectionString)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.dgvResult)
        Me.TabPage1.Controls.Add(Me.chkIncludeImages)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtDownloadStatus)
        Me.TabPage1.Controls.Add(Me.DateTimePicker2)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.ddlDrwgs)
        Me.TabPage1.Controls.Add(Me.ddlQuestions)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.ddlSchedItems)
        Me.TabPage1.Controls.Add(Me.btnLogin)
        Me.TabPage1.Controls.Add(Me.btnOutputToCSV)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.ddlSchedules)
        Me.TabPage1.Controls.Add(Me.txtURL)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtPassword)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtUsername)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TabPage1.Size = New System.Drawing.Size(1284, 1518)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inspection Data"
        '
        'chkUseDates
        '
        Me.chkUseDates.AutoSize = True
        Me.chkUseDates.Location = New System.Drawing.Point(20, 560)
        Me.chkUseDates.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chkUseDates.Name = "chkUseDates"
        Me.chkUseDates.Size = New System.Drawing.Size(205, 30)
        Me.chkUseDates.TabIndex = 71
        Me.chkUseDates.Text = "Use Date Range:"
        Me.chkUseDates.UseVisualStyleBackColor = True
        '
        'chkSelectDrwg
        '
        Me.chkSelectDrwg.AutoSize = True
        Me.chkSelectDrwg.Location = New System.Drawing.Point(20, 448)
        Me.chkSelectDrwg.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chkSelectDrwg.Name = "chkSelectDrwg"
        Me.chkSelectDrwg.Size = New System.Drawing.Size(185, 30)
        Me.chkSelectDrwg.TabIndex = 70
        Me.chkSelectDrwg.Text = "Select Drawing"
        Me.chkSelectDrwg.UseVisualStyleBackColor = True
        '
        'chkSelectQuestion
        '
        Me.chkSelectQuestion.AutoSize = True
        Me.chkSelectQuestion.Location = New System.Drawing.Point(20, 333)
        Me.chkSelectQuestion.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chkSelectQuestion.Name = "chkSelectQuestion"
        Me.chkSelectQuestion.Size = New System.Drawing.Size(192, 30)
        Me.chkSelectQuestion.TabIndex = 69
        Me.chkSelectQuestion.Text = "Select Question"
        Me.chkSelectQuestion.UseVisualStyleBackColor = True
        '
        'chkClearTable
        '
        Me.chkClearTable.AutoSize = True
        Me.chkClearTable.Location = New System.Drawing.Point(20, 831)
        Me.chkClearTable.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chkClearTable.Name = "chkClearTable"
        Me.chkClearTable.Size = New System.Drawing.Size(201, 30)
        Me.chkClearTable.TabIndex = 68
        Me.chkClearTable.Text = "Clear Table Data"
        Me.chkClearTable.UseVisualStyleBackColor = True
        '
        'btnOutputToDBTable
        '
        Me.btnOutputToDBTable.Location = New System.Drawing.Point(286, 823)
        Me.btnOutputToDBTable.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnOutputToDBTable.Name = "btnOutputToDBTable"
        Me.btnOutputToDBTable.Size = New System.Drawing.Size(954, 44)
        Me.btnOutputToDBTable.TabIndex = 67
        Me.btnOutputToDBTable.Text = "Output Forms Data to SQL DB Table"
        Me.btnOutputToDBTable.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(34, 777)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(215, 26)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "SQL DB Connection:"
        '
        'txtConnectionString
        '
        Me.txtConnectionString.Location = New System.Drawing.Point(286, 771)
        Me.txtConnectionString.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtConnectionString.Name = "txtConnectionString"
        Me.txtConnectionString.Size = New System.Drawing.Size(950, 31)
        Me.txtConnectionString.TabIndex = 65
        Me.txtConnectionString.Text = "Data Source=.\sqlexpress;Initial Catalog=SnagRAPIData;Integrated Security=True;Mu" & _
    "ltipleActiveResultSets=True"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SnagRFormsData.My.Resources.Resources.ajax_loader
        Me.PictureBox1.Location = New System.Drawing.Point(1090, 175)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 123)
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'dgvResult
        '
        Me.dgvResult.AllowUserToAddRows = False
        Me.dgvResult.AllowUserToDeleteRows = False
        Me.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResult.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvResult.Location = New System.Drawing.Point(20, 1142)
        Me.dgvResult.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.dgvResult.Name = "dgvResult"
        Me.dgvResult.ReadOnly = True
        Me.dgvResult.Size = New System.Drawing.Size(1220, 350)
        Me.dgvResult.TabIndex = 63
        '
        'chkIncludeImages
        '
        Me.chkIncludeImages.AutoSize = True
        Me.chkIncludeImages.Location = New System.Drawing.Point(20, 692)
        Me.chkIncludeImages.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chkIncludeImages.Name = "chkIncludeImages"
        Me.chkIncludeImages.Size = New System.Drawing.Size(186, 30)
        Me.chkIncludeImages.TabIndex = 62
        Me.chkIncludeImages.Text = "Include Images"
        Me.chkIncludeImages.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 877)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(183, 26)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Download Status:"
        '
        'txtDownloadStatus
        '
        Me.txtDownloadStatus.Location = New System.Drawing.Point(20, 908)
        Me.txtDownloadStatus.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtDownloadStatus.Multiline = True
        Me.txtDownloadStatus.Name = "txtDownloadStatus"
        Me.txtDownloadStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDownloadStatus.Size = New System.Drawing.Size(1216, 196)
        Me.txtDownloadStatus.TabIndex = 60
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(840, 592)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(396, 31)
        Me.DateTimePicker2.TabIndex = 59
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(834, 562)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 26)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "To"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(286, 592)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(396, 31)
        Me.DateTimePicker1.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(280, 562)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 26)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "From"
        '
        'ddlDrwgs
        '
        Me.ddlDrwgs.FormattingEnabled = True
        Me.ddlDrwgs.Location = New System.Drawing.Point(20, 492)
        Me.ddlDrwgs.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ddlDrwgs.Name = "ddlDrwgs"
        Me.ddlDrwgs.Size = New System.Drawing.Size(490, 33)
        Me.ddlDrwgs.TabIndex = 55
        '
        'ddlQuestions
        '
        Me.ddlQuestions.FormattingEnabled = True
        Me.ddlQuestions.Location = New System.Drawing.Point(20, 377)
        Me.ddlQuestions.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ddlQuestions.Name = "ddlQuestions"
        Me.ddlQuestions.Size = New System.Drawing.Size(490, 33)
        Me.ddlQuestions.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 248)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 26)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Select Form"
        '
        'ddlSchedItems
        '
        Me.ddlSchedItems.FormattingEnabled = True
        Me.ddlSchedItems.Location = New System.Drawing.Point(20, 279)
        Me.ddlSchedItems.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ddlSchedItems.Name = "ddlSchedItems"
        Me.ddlSchedItems.Size = New System.Drawing.Size(490, 33)
        Me.ddlSchedItems.TabIndex = 52
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(1090, 94)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(150, 44)
        Me.btnLogin.TabIndex = 51
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnOutputToCSV
        '
        Me.btnOutputToCSV.Location = New System.Drawing.Point(286, 692)
        Me.btnOutputToCSV.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnOutputToCSV.Name = "btnOutputToCSV"
        Me.btnOutputToCSV.Size = New System.Drawing.Size(954, 44)
        Me.btnOutputToCSV.TabIndex = 50
        Me.btnOutputToCSV.Text = "Output Forms Data to CSV"
        Me.btnOutputToCSV.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 144)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 26)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Select Inspection"
        '
        'ddlSchedules
        '
        Me.ddlSchedules.FormattingEnabled = True
        Me.ddlSchedules.Location = New System.Drawing.Point(20, 175)
        Me.ddlSchedules.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ddlSchedules.Name = "ddlSchedules"
        Me.ddlSchedules.Size = New System.Drawing.Size(490, 33)
        Me.ddlSchedules.TabIndex = 48
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(526, 44)
        Me.txtURL.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(710, 31)
        Me.txtURL.TabIndex = 47
        Me.txtURL.Text = "http://rsam.snagrweb.co.uk/trg"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(520, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 26)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "URL"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(286, 44)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(224, 31)
        Me.txtPassword.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(280, 12)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 26)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(20, 44)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(250, 31)
        Me.txtUsername.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(254, 26)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Administrator Username:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage2.Controls.Add(Me.chkUseDatesSnags)
        Me.TabPage2.Controls.Add(Me.chkClearTableSnags)
        Me.TabPage2.Controls.Add(Me.btnOutputToDBTableSnags)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.txtConnectionStringSnags)
        Me.TabPage2.Controls.Add(Me.dgvResultSnags)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.txtDownloadStatusSnags)
        Me.TabPage2.Controls.Add(Me.dateStampToSnags)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.dateStampFromSnags)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.btnOutputToCSVSnags)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.lbSDTypes)
        Me.TabPage2.Controls.Add(Me.btnLoginSnags)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.ddlSDCategs)
        Me.TabPage2.Controls.Add(Me.txtURLSnags)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtPasswordSnags)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txtUsernameSnags)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TabPage2.Size = New System.Drawing.Size(1284, 1518)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Defect Data"
        '
        'chkUseDatesSnags
        '
        Me.chkUseDatesSnags.AutoSize = True
        Me.chkUseDatesSnags.Location = New System.Drawing.Point(36, 529)
        Me.chkUseDatesSnags.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chkUseDatesSnags.Name = "chkUseDatesSnags"
        Me.chkUseDatesSnags.Size = New System.Drawing.Size(205, 30)
        Me.chkUseDatesSnags.TabIndex = 90
        Me.chkUseDatesSnags.Text = "Use Date Range:"
        Me.chkUseDatesSnags.UseVisualStyleBackColor = True
        '
        'chkClearTableSnags
        '
        Me.chkClearTableSnags.AutoSize = True
        Me.chkClearTableSnags.Location = New System.Drawing.Point(32, 798)
        Me.chkClearTableSnags.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chkClearTableSnags.Name = "chkClearTableSnags"
        Me.chkClearTableSnags.Size = New System.Drawing.Size(201, 30)
        Me.chkClearTableSnags.TabIndex = 89
        Me.chkClearTableSnags.Text = "Clear Table Data"
        Me.chkClearTableSnags.UseVisualStyleBackColor = True
        '
        'btnOutputToDBTableSnags
        '
        Me.btnOutputToDBTableSnags.Location = New System.Drawing.Point(298, 790)
        Me.btnOutputToDBTableSnags.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnOutputToDBTableSnags.Name = "btnOutputToDBTableSnags"
        Me.btnOutputToDBTableSnags.Size = New System.Drawing.Size(954, 44)
        Me.btnOutputToDBTableSnags.TabIndex = 88
        Me.btnOutputToDBTableSnags.Text = "Output Forms Data to SQL DB Table"
        Me.btnOutputToDBTableSnags.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(46, 744)
        Me.Label15.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(215, 26)
        Me.Label15.TabIndex = 87
        Me.Label15.Text = "SQL DB Connection:"
        '
        'txtConnectionStringSnags
        '
        Me.txtConnectionStringSnags.Location = New System.Drawing.Point(298, 738)
        Me.txtConnectionStringSnags.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtConnectionStringSnags.Name = "txtConnectionStringSnags"
        Me.txtConnectionStringSnags.Size = New System.Drawing.Size(950, 31)
        Me.txtConnectionStringSnags.TabIndex = 86
        Me.txtConnectionStringSnags.Text = "Data Source=.\sqlexpress;Initial Catalog=SnagRAPIData;Integrated Security=True;Mu" & _
    "ltipleActiveResultSets=True"
        '
        'dgvResultSnags
        '
        Me.dgvResultSnags.AllowUserToAddRows = False
        Me.dgvResultSnags.AllowUserToDeleteRows = False
        Me.dgvResultSnags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultSnags.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvResultSnags.Location = New System.Drawing.Point(32, 1110)
        Me.dgvResultSnags.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.dgvResultSnags.Name = "dgvResultSnags"
        Me.dgvResultSnags.ReadOnly = True
        Me.dgvResultSnags.Size = New System.Drawing.Size(1220, 350)
        Me.dgvResultSnags.TabIndex = 85
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(26, 844)
        Me.Label16.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(183, 26)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = "Download Status:"
        '
        'txtDownloadStatusSnags
        '
        Me.txtDownloadStatusSnags.Location = New System.Drawing.Point(32, 875)
        Me.txtDownloadStatusSnags.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtDownloadStatusSnags.Multiline = True
        Me.txtDownloadStatusSnags.Name = "txtDownloadStatusSnags"
        Me.txtDownloadStatusSnags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDownloadStatusSnags.Size = New System.Drawing.Size(1216, 196)
        Me.txtDownloadStatusSnags.TabIndex = 82
        '
        'dateStampToSnags
        '
        Me.dateStampToSnags.Location = New System.Drawing.Point(852, 560)
        Me.dateStampToSnags.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.dateStampToSnags.Name = "dateStampToSnags"
        Me.dateStampToSnags.Size = New System.Drawing.Size(396, 31)
        Me.dateStampToSnags.TabIndex = 81
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(846, 529)
        Me.Label17.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 26)
        Me.Label17.TabIndex = 80
        Me.Label17.Text = "To"
        '
        'dateStampFromSnags
        '
        Me.dateStampFromSnags.Location = New System.Drawing.Point(298, 560)
        Me.dateStampFromSnags.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.dateStampFromSnags.Name = "dateStampFromSnags"
        Me.dateStampFromSnags.Size = New System.Drawing.Size(396, 31)
        Me.dateStampFromSnags.TabIndex = 79
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(292, 529)
        Me.Label18.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 26)
        Me.Label18.TabIndex = 78
        Me.Label18.Text = "From"
        '
        'btnOutputToCSVSnags
        '
        Me.btnOutputToCSVSnags.Location = New System.Drawing.Point(298, 660)
        Me.btnOutputToCSVSnags.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnOutputToCSVSnags.Name = "btnOutputToCSVSnags"
        Me.btnOutputToCSVSnags.Size = New System.Drawing.Size(954, 44)
        Me.btnOutputToCSVSnags.TabIndex = 77
        Me.btnOutputToCSVSnags.Text = "Output Forms Data to CSV"
        Me.btnOutputToCSVSnags.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 254)
        Me.Label14.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(188, 26)
        Me.Label14.TabIndex = 76
        Me.Label14.Text = "Select SD Type(s)"
        '
        'lbSDTypes
        '
        Me.lbSDTypes.FormattingEnabled = True
        Me.lbSDTypes.ItemHeight = 25
        Me.lbSDTypes.Location = New System.Drawing.Point(18, 285)
        Me.lbSDTypes.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lbSDTypes.Name = "lbSDTypes"
        Me.lbSDTypes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbSDTypes.Size = New System.Drawing.Size(490, 204)
        Me.lbSDTypes.TabIndex = 75
        '
        'btnLoginSnags
        '
        Me.btnLoginSnags.Location = New System.Drawing.Point(1088, 96)
        Me.btnLoginSnags.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnLoginSnags.Name = "btnLoginSnags"
        Me.btnLoginSnags.Size = New System.Drawing.Size(150, 44)
        Me.btnLoginSnags.TabIndex = 73
        Me.btnLoginSnags.Text = "Login"
        Me.btnLoginSnags.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 146)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 26)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Select Category"
        '
        'ddlSDCategs
        '
        Me.ddlSDCategs.FormattingEnabled = True
        Me.ddlSDCategs.Location = New System.Drawing.Point(18, 177)
        Me.ddlSDCategs.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ddlSDCategs.Name = "ddlSDCategs"
        Me.ddlSDCategs.Size = New System.Drawing.Size(490, 33)
        Me.ddlSDCategs.TabIndex = 71
        '
        'txtURLSnags
        '
        Me.txtURLSnags.Location = New System.Drawing.Point(524, 46)
        Me.txtURLSnags.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtURLSnags.Name = "txtURLSnags"
        Me.txtURLSnags.Size = New System.Drawing.Size(710, 31)
        Me.txtURLSnags.TabIndex = 70
        Me.txtURLSnags.Text = "http://rsam.snagrweb.co.uk/echg"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(518, 10)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 26)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "URL"
        '
        'txtPasswordSnags
        '
        Me.txtPasswordSnags.Location = New System.Drawing.Point(284, 46)
        Me.txtPasswordSnags.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtPasswordSnags.Name = "txtPasswordSnags"
        Me.txtPasswordSnags.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordSnags.Size = New System.Drawing.Size(224, 31)
        Me.txtPasswordSnags.TabIndex = 68
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(278, 10)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 26)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "Password"
        '
        'txtUsernameSnags
        '
        Me.txtUsernameSnags.Location = New System.Drawing.Point(18, 46)
        Me.txtUsernameSnags.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtUsernameSnags.Name = "txtUsernameSnags"
        Me.txtUsernameSnags.Size = New System.Drawing.Size(250, 31)
        Me.txtUsernameSnags.TabIndex = 66
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 10)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(254, 26)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "Administrator Username:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SnagRFormsData.My.Resources.Resources.ajax_loader
        Me.PictureBox2.Location = New System.Drawing.Point(1088, 177)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 123)
        Me.PictureBox2.TabIndex = 74
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1302, 1560)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Form1"
        Me.Text = "SnagR - Data Extractor"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvResultSnags, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents chkUseDates As System.Windows.Forms.CheckBox
    Friend WithEvents chkSelectDrwg As System.Windows.Forms.CheckBox
    Friend WithEvents chkSelectQuestion As System.Windows.Forms.CheckBox
    Friend WithEvents chkClearTable As System.Windows.Forms.CheckBox
    Friend WithEvents btnOutputToDBTable As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtConnectionString As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvResult As System.Windows.Forms.DataGridView
    Friend WithEvents chkIncludeImages As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDownloadStatus As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ddlDrwgs As System.Windows.Forms.ComboBox
    Friend WithEvents ddlQuestions As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ddlSchedItems As System.Windows.Forms.ComboBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnOutputToCSV As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ddlSchedules As System.Windows.Forms.ComboBox
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnLoginSnags As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ddlSDCategs As System.Windows.Forms.ComboBox
    Friend WithEvents txtURLSnags As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPasswordSnags As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtUsernameSnags As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chkUseDatesSnags As System.Windows.Forms.CheckBox
    Friend WithEvents chkClearTableSnags As System.Windows.Forms.CheckBox
    Friend WithEvents btnOutputToDBTableSnags As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtConnectionStringSnags As System.Windows.Forms.TextBox
    Friend WithEvents dgvResultSnags As System.Windows.Forms.DataGridView
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtDownloadStatusSnags As System.Windows.Forms.TextBox
    Friend WithEvents dateStampToSnags As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dateStampFromSnags As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnOutputToCSVSnags As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbSDTypes As System.Windows.Forms.ListBox

End Class
