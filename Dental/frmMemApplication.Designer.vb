<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemApplication
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
        btnSubmit = New Button()
        btnCancel = New Button()
        tabCntrlMemApplication = New TabControl()
        TabPage4 = New TabPage()
        Button1 = New Button()
        btnTake = New Button()
        btnStart = New Button()
        Panel3 = New Panel()
        PreviewPictureBox = New PictureBox()
        Panel2 = New Panel()
        pbIcon = New PictureBox()
        picPreviewClientID = New PictureBox()
        picCaptureClientID = New PictureBox()
        btnRetake = New Button()
        TabPage1 = New TabPage()
        Panel7 = New Panel()
        Label12 = New Label()
        Panel16 = New Panel()
        cmbHouse = New ComboBox()
        Label11 = New Label()
        Panel15 = New Panel()
        cmbBaranggay = New ComboBox()
        Label10 = New Label()
        Panel14 = New Panel()
        cmbCity = New ComboBox()
        Label9 = New Label()
        Panel13 = New Panel()
        cmbProvince = New ComboBox()
        Label8 = New Label()
        Panel1 = New Panel()
        Label13 = New Label()
        Panel12 = New Panel()
        txtEmail = New TextBox()
        Label4 = New Label()
        Panel11 = New Panel()
        txtExtension = New TextBox()
        Label3 = New Label()
        Panel10 = New Panel()
        txtLast = New TextBox()
        Label1 = New Label()
        Panel9 = New Panel()
        txtMiddle = New TextBox()
        Label2 = New Label()
        Panel8 = New Panel()
        txtFirst = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Panel4 = New Panel()
        cbSex = New ComboBox()
        Panel5 = New Panel()
        dtpBday = New DateTimePicker()
        Panel6 = New Panel()
        txtNumber = New TextBox()
        tabCntrlMemApplication.SuspendLayout()
        TabPage4.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PreviewPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(pbIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPreviewClientID, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCaptureClientID, ComponentModel.ISupportInitialize).BeginInit()
        TabPage1.SuspendLayout()
        Panel7.SuspendLayout()
        Panel16.SuspendLayout()
        Panel15.SuspendLayout()
        Panel14.SuspendLayout()
        Panel13.SuspendLayout()
        Panel1.SuspendLayout()
        Panel12.SuspendLayout()
        Panel11.SuspendLayout()
        Panel10.SuspendLayout()
        Panel9.SuspendLayout()
        Panel8.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.MistyRose
        btnSubmit.Location = New Point(907, 412)
        btnSubmit.Margin = New Padding(4, 3, 4, 3)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(88, 38)
        btnSubmit.TabIndex = 13
        btnSubmit.Text = "&Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(811, 412)
        btnCancel.Margin = New Padding(4, 3, 4, 3)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(88, 38)
        btnCancel.TabIndex = 14
        btnCancel.Text = "&Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' tabCntrlMemApplication
        ' 
        tabCntrlMemApplication.Controls.Add(TabPage4)
        tabCntrlMemApplication.Controls.Add(TabPage1)
        tabCntrlMemApplication.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tabCntrlMemApplication.Location = New Point(14, 14)
        tabCntrlMemApplication.Margin = New Padding(4, 3, 4, 3)
        tabCntrlMemApplication.Name = "tabCntrlMemApplication"
        tabCntrlMemApplication.SelectedIndex = 0
        tabCntrlMemApplication.Size = New Size(1017, 497)
        tabCntrlMemApplication.TabIndex = 3
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(Button1)
        TabPage4.Controls.Add(btnTake)
        TabPage4.Controls.Add(btnStart)
        TabPage4.Controls.Add(Panel3)
        TabPage4.Controls.Add(Panel2)
        TabPage4.Controls.Add(btnRetake)
        TabPage4.Location = New Point(4, 25)
        TabPage4.Margin = New Padding(4, 3, 4, 3)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(1009, 468)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Patients ID"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Enabled = False
        Button1.Image = My.Resources.Resources.noun_camera_retake_5835959
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(818, 143)
        Button1.Margin = New Padding(4, 3, 4, 3)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(4, 0, 0, 0)
        Button1.Size = New Size(153, 43)
        Button1.TabIndex = 15
        Button1.Text = "  RETAKE"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnTake
        ' 
        btnTake.Enabled = False
        btnTake.Image = My.Resources.Resources.cams1
        btnTake.ImageAlign = ContentAlignment.MiddleLeft
        btnTake.Location = New Point(660, 90)
        btnTake.Margin = New Padding(4, 3, 4, 3)
        btnTake.Name = "btnTake"
        btnTake.Size = New Size(150, 47)
        btnTake.TabIndex = 17
        btnTake.Text = "    TAKE"
        btnTake.TextAlign = ContentAlignment.MiddleLeft
        btnTake.TextImageRelation = TextImageRelation.ImageBeforeText
        btnTake.UseVisualStyleBackColor = True
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = Color.White
        btnStart.BackgroundImageLayout = ImageLayout.Zoom
        btnStart.Image = My.Resources.Resources.start
        btnStart.ImageAlign = ContentAlignment.MiddleLeft
        btnStart.Location = New Point(660, 38)
        btnStart.Margin = New Padding(4, 3, 4, 3)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(150, 46)
        btnStart.TabIndex = 16
        btnStart.Text = "   START"
        btnStart.TextAlign = ContentAlignment.MiddleRight
        btnStart.TextImageRelation = TextImageRelation.ImageBeforeText
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightGray
        Panel3.Controls.Add(PreviewPictureBox)
        Panel3.Location = New Point(658, 205)
        Panel3.Margin = New Padding(4, 3, 4, 3)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(2)
        Panel3.Size = New Size(274, 234)
        Panel3.TabIndex = 15
        ' 
        ' PreviewPictureBox
        ' 
        PreviewPictureBox.BackColor = Color.White
        PreviewPictureBox.Dock = DockStyle.Fill
        PreviewPictureBox.Image = My.Resources.Resources.No_Preview_Available
        PreviewPictureBox.Location = New Point(2, 2)
        PreviewPictureBox.Name = "PreviewPictureBox"
        PreviewPictureBox.Size = New Size(270, 230)
        PreviewPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        PreviewPictureBox.TabIndex = 0
        PreviewPictureBox.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.None
        Panel2.BackColor = Color.LightGray
        Panel2.Controls.Add(pbIcon)
        Panel2.Controls.Add(picPreviewClientID)
        Panel2.Controls.Add(picCaptureClientID)
        Panel2.Location = New Point(65, 24)
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(4, 3, 4, 3)
        Panel2.Size = New Size(529, 400)
        Panel2.TabIndex = 14
        ' 
        ' pbIcon
        ' 
        pbIcon.Image = My.Resources.Resources.user_10770631
        pbIcon.Location = New Point(-69, 345)
        pbIcon.Name = "pbIcon"
        pbIcon.Size = New Size(192, 142)
        pbIcon.SizeMode = PictureBoxSizeMode.Zoom
        pbIcon.TabIndex = 15
        pbIcon.TabStop = False
        pbIcon.Visible = False
        ' 
        ' picPreviewClientID
        ' 
        picPreviewClientID.BackColor = Color.White
        picPreviewClientID.Dock = DockStyle.Fill
        picPreviewClientID.Image = My.Resources.Resources._90c81e3560efefd0819e1c71feecf3be_camera_off_button_flat_icon2
        picPreviewClientID.Location = New Point(4, 3)
        picPreviewClientID.Name = "picPreviewClientID"
        picPreviewClientID.Size = New Size(521, 394)
        picPreviewClientID.SizeMode = PictureBoxSizeMode.Zoom
        picPreviewClientID.TabIndex = 2
        picPreviewClientID.TabStop = False
        ' 
        ' picCaptureClientID
        ' 
        picCaptureClientID.BackColor = Color.Black
        picCaptureClientID.Dock = DockStyle.Fill
        picCaptureClientID.Location = New Point(4, 3)
        picCaptureClientID.Margin = New Padding(4, 3, 4, 3)
        picCaptureClientID.Name = "picCaptureClientID"
        picCaptureClientID.Size = New Size(521, 394)
        picCaptureClientID.TabIndex = 1
        picCaptureClientID.TabStop = False
        picCaptureClientID.Visible = False
        ' 
        ' btnRetake
        ' 
        btnRetake.Enabled = False
        btnRetake.Image = My.Resources.Resources.noun_camera_retake_5835959
        btnRetake.ImageAlign = ContentAlignment.MiddleLeft
        btnRetake.Location = New Point(660, 143)
        btnRetake.Margin = New Padding(4, 3, 4, 3)
        btnRetake.Name = "btnRetake"
        btnRetake.Padding = New Padding(4, 0, 0, 0)
        btnRetake.Size = New Size(150, 43)
        btnRetake.TabIndex = 13
        btnRetake.Text = "  RETAKE"
        btnRetake.TextImageRelation = TextImageRelation.ImageBeforeText
        btnRetake.UseVisualStyleBackColor = True
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Panel7)
        TabPage1.Controls.Add(btnCancel)
        TabPage1.Controls.Add(Panel1)
        TabPage1.Controls.Add(btnSubmit)
        TabPage1.Location = New Point(4, 25)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1009, 468)
        TabPage1.TabIndex = 4
        TabPage1.Text = "Patients Information"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Panel7
        ' 
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Controls.Add(Label12)
        Panel7.Controls.Add(Panel16)
        Panel7.Controls.Add(Label11)
        Panel7.Controls.Add(Panel15)
        Panel7.Controls.Add(Label10)
        Panel7.Controls.Add(Panel14)
        Panel7.Controls.Add(Label9)
        Panel7.Controls.Add(Panel13)
        Panel7.Controls.Add(Label8)
        Panel7.Location = New Point(12, 280)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(983, 126)
        Panel7.TabIndex = 25
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(759, 24)
        Label12.Name = "Label12"
        Label12.Size = New Size(150, 20)
        Label12.TabIndex = 31
        Label12.Text = "House #, Block Street"
        ' 
        ' Panel16
        ' 
        Panel16.BorderStyle = BorderStyle.FixedSingle
        Panel16.Controls.Add(cmbHouse)
        Panel16.Location = New Point(750, 36)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(215, 67)
        Panel16.TabIndex = 36
        ' 
        ' cmbHouse
        ' 
        cmbHouse.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cmbHouse.FormattingEnabled = True
        cmbHouse.Location = New Point(15, 18)
        cmbHouse.Name = "cmbHouse"
        cmbHouse.Size = New Size(184, 28)
        cmbHouse.TabIndex = 32
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(524, 24)
        Label11.Name = "Label11"
        Label11.Size = New Size(80, 20)
        Label11.TabIndex = 29
        Label11.Text = "Baranggay"
        ' 
        ' Panel15
        ' 
        Panel15.BorderStyle = BorderStyle.FixedSingle
        Panel15.Controls.Add(cmbBaranggay)
        Panel15.Location = New Point(505, 36)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(215, 67)
        Panel15.TabIndex = 35
        ' 
        ' cmbBaranggay
        ' 
        cmbBaranggay.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cmbBaranggay.FormattingEnabled = True
        cmbBaranggay.Location = New Point(15, 19)
        cmbBaranggay.Name = "cmbBaranggay"
        cmbBaranggay.Size = New Size(184, 28)
        cmbBaranggay.TabIndex = 30
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(273, 26)
        Label10.Name = "Label10"
        Label10.Size = New Size(129, 20)
        Label10.TabIndex = 27
        Label10.Text = "City / Municipality"
        ' 
        ' Panel14
        ' 
        Panel14.BorderStyle = BorderStyle.FixedSingle
        Panel14.Controls.Add(cmbCity)
        Panel14.Location = New Point(260, 36)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(215, 67)
        Panel14.TabIndex = 34
        ' 
        ' cmbCity
        ' 
        cmbCity.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cmbCity.FormattingEnabled = True
        cmbCity.Location = New Point(12, 16)
        cmbCity.Name = "cmbCity"
        cmbCity.Size = New Size(184, 28)
        cmbCity.TabIndex = 28
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(26, 26)
        Label9.Name = "Label9"
        Label9.Size = New Size(65, 20)
        Label9.TabIndex = 26
        Label9.Text = "Province"
        ' 
        ' Panel13
        ' 
        Panel13.BorderStyle = BorderStyle.FixedSingle
        Panel13.Controls.Add(cmbProvince)
        Panel13.Location = New Point(13, 36)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(215, 67)
        Panel13.TabIndex = 33
        ' 
        ' cmbProvince
        ' 
        cmbProvince.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cmbProvince.FormattingEnabled = True
        cmbProvince.Items.AddRange(New Object() {"Baungon", "Cabanglasan", "Damulog", "Dangcagan", "Don Carlos", "Impasug-Ong", "Kadingilan", "Kalilangan", "Kibawe", "Kitaotao", "Lantapan", "Libona", "Malaybalay", "Malitbog (BK)", "Manolo Fortich", "Maramag", "Pangantucan", "Quezon (BK)", "San Fernando (BK)", "Sumilao", "Talakag", "Valencia (BK)"})
        cmbProvince.Location = New Point(14, 16)
        cmbProvince.Name = "cmbProvince"
        cmbProvince.Size = New Size(183, 28)
        cmbProvince.TabIndex = 27
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(3, 1)
        Label8.Name = "Label8"
        Label8.Size = New Size(107, 20)
        Label8.TabIndex = 19
        Label8.Text = "Home Address"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Panel12)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Panel11)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Panel10)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel9)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Panel8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel6)
        Panel1.Location = New Point(12, 38)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(983, 217)
        Panel1.TabIndex = 15
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(764, 114)
        Label13.Name = "Label13"
        Label13.Size = New Size(46, 20)
        Label13.TabIndex = 31
        Label13.Text = "Email"
        ' 
        ' Panel12
        ' 
        Panel12.BorderStyle = BorderStyle.FixedSingle
        Panel12.Controls.Add(txtEmail)
        Panel12.Location = New Point(750, 124)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(215, 67)
        Panel12.TabIndex = 32
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmail.Location = New Point(15, 18)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(184, 27)
        txtEmail.TabIndex = 23
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(761, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(170, 20)
        Label4.TabIndex = 17
        Label4.Text = "Extension Name (e.g. Jr.)"
        ' 
        ' Panel11
        ' 
        Panel11.BorderStyle = BorderStyle.FixedSingle
        Panel11.Controls.Add(txtExtension)
        Panel11.Location = New Point(750, 19)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(215, 69)
        Panel11.TabIndex = 30
        ' 
        ' txtExtension
        ' 
        txtExtension.BorderStyle = BorderStyle.FixedSingle
        txtExtension.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtExtension.Location = New Point(15, 18)
        txtExtension.Name = "txtExtension"
        txtExtension.Size = New Size(184, 27)
        txtExtension.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(516, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 20)
        Label3.TabIndex = 15
        Label3.Text = "Lastname"
        ' 
        ' Panel10
        ' 
        Panel10.BorderStyle = BorderStyle.FixedSingle
        Panel10.Controls.Add(txtLast)
        Panel10.Location = New Point(505, 19)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(215, 69)
        Panel10.TabIndex = 8
        ' 
        ' txtLast
        ' 
        txtLast.BorderStyle = BorderStyle.FixedSingle
        txtLast.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtLast.Location = New Point(15, 18)
        txtLast.Name = "txtLast"
        txtLast.Size = New Size(184, 27)
        txtLast.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(269, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 20)
        Label1.TabIndex = 6
        Label1.Text = "Middle Name"
        ' 
        ' Panel9
        ' 
        Panel9.BorderStyle = BorderStyle.FixedSingle
        Panel9.Controls.Add(txtMiddle)
        Panel9.Location = New Point(259, 19)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(215, 69)
        Panel9.TabIndex = 29
        ' 
        ' txtMiddle
        ' 
        txtMiddle.BorderStyle = BorderStyle.FixedSingle
        txtMiddle.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtMiddle.Location = New Point(13, 17)
        txtMiddle.Name = "txtMiddle"
        txtMiddle.Size = New Size(184, 27)
        txtMiddle.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(28, 8)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 20)
        Label2.TabIndex = 4
        Label2.Text = "Firstname"
        ' 
        ' Panel8
        ' 
        Panel8.BorderStyle = BorderStyle.FixedSingle
        Panel8.Controls.Add(txtFirst)
        Panel8.Location = New Point(13, 19)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(215, 69)
        Panel8.TabIndex = 28
        ' 
        ' txtFirst
        ' 
        txtFirst.BorderStyle = BorderStyle.FixedSingle
        txtFirst.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtFirst.Location = New Point(13, 19)
        txtFirst.Name = "txtFirst"
        txtFirst.Size = New Size(184, 27)
        txtFirst.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(519, 114)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 20)
        Label7.TabIndex = 24
        Label7.Text = "Contact Number"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(264, 114)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 20)
        Label6.TabIndex = 23
        Label6.Text = "Birthday"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(26, 114)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 20)
        Label5.TabIndex = 19
        Label5.Text = "Gender"
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(cbSex)
        Panel4.Location = New Point(13, 124)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(215, 67)
        Panel4.TabIndex = 25
        ' 
        ' cbSex
        ' 
        cbSex.DropDownStyle = ComboBoxStyle.DropDownList
        cbSex.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cbSex.FormattingEnabled = True
        cbSex.Items.AddRange(New Object() {"Male", "Female"})
        cbSex.Location = New Point(12, 17)
        cbSex.Name = "cbSex"
        cbSex.Size = New Size(184, 28)
        cbSex.TabIndex = 29
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(dtpBday)
        Panel5.Location = New Point(260, 124)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(215, 67)
        Panel5.TabIndex = 26
        ' 
        ' dtpBday
        ' 
        dtpBday.CalendarFont = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dtpBday.CustomFormat = "MM/dd/yyyy"
        dtpBday.Format = DateTimePickerFormat.Custom
        dtpBday.Location = New Point(12, 23)
        dtpBday.Name = "dtpBday"
        dtpBday.Size = New Size(184, 22)
        dtpBday.TabIndex = 21
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(txtNumber)
        Panel6.Location = New Point(505, 124)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(215, 67)
        Panel6.TabIndex = 27
        ' 
        ' txtNumber
        ' 
        txtNumber.BorderStyle = BorderStyle.FixedSingle
        txtNumber.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtNumber.Location = New Point(15, 18)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(184, 27)
        txtNumber.TabIndex = 23
        ' 
        ' frmMemApplication
        ' 
        AcceptButton = btnSubmit
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(1054, 553)
        Controls.Add(tabCntrlMemApplication)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(4, 3, 4, 3)
        Name = "frmMemApplication"
        StartPosition = FormStartPosition.CenterScreen
        tabCntrlMemApplication.ResumeLayout(False)
        TabPage4.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(PreviewPictureBox, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(pbIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(picPreviewClientID, ComponentModel.ISupportInitialize).EndInit()
        CType(picCaptureClientID, ComponentModel.ISupportInitialize).EndInit()
        TabPage1.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel16.ResumeLayout(False)
        Panel15.ResumeLayout(False)
        Panel14.ResumeLayout(False)
        Panel13.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents tabCntrlMemApplication As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents btnTake As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents picCaptureClientID As PictureBox
    Friend WithEvents btnRetake As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtMiddle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtExtension As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtpBday As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents PreviewPictureBox As PictureBox
    Friend WithEvents picPreviewClientID As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents cmbProvince As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbBaranggay As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbCity As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbHouse As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents pbIcon As PictureBox
    Friend WithEvents cbSex As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel13 As Panel
End Class
