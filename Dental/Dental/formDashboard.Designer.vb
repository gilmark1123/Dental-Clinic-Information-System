<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDashboard
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Panel3 = New Panel()
        lblTime = New Label()
        Timer1 = New Timer(components)
        Panel1 = New Panel()
        lblDayType = New Label()
        Label4 = New Label()
        lblDay = New Label()
        Label2 = New Label()
        lblNumbers = New Label()
        Panel4 = New Panel()
        Label5 = New Label()
        lblTotal = New Label()
        Panel5 = New Panel()
        Label8 = New Label()
        Panel6 = New Panel()
        lblUpcoming = New Label()
        Label11 = New Label()
        Panel7 = New Panel()
        Label13 = New Label()
        Label14 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label10 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        PictureBox4 = New PictureBox()
        Label17 = New Label()
        Label19 = New Label()
        PictureBox5 = New PictureBox()
        Label20 = New Label()
        PictureBox6 = New PictureBox()
        lblGreet = New Label()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(237, 50)
        Label1.TabIndex = 1
        Label1.Text = "DASHBOARD"
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(lblTime)
        Panel3.Location = New Point(833, 126)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(347, 82)
        Panel3.TabIndex = 0
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.BackColor = Color.White
        lblTime.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTime.Location = New Point(88, 22)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(178, 47)
        lblTime.TabIndex = 5
        lblTime.Text = "00:00 AM"
        ' 
        ' Timer1
        ' 
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(lblDayType)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(lblDay)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(833, 223)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(347, 150)
        Panel1.TabIndex = 5
        ' 
        ' lblDayType
        ' 
        lblDayType.AutoSize = True
        lblDayType.BackColor = Color.White
        lblDayType.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblDayType.Location = New Point(228, 71)
        lblDayType.Name = "lblDayType"
        lblDayType.Size = New Size(76, 21)
        lblDayType.TabIndex = 9
        lblDayType.Text = "SUNDAY"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Lucida Sans", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(209, 61)
        Label4.Name = "Label4"
        Label4.Size = New Size(26, 39)
        Label4.TabIndex = 8
        Label4.Text = "l"
        ' 
        ' lblDay
        ' 
        lblDay.AutoSize = True
        lblDay.BackColor = Color.White
        lblDay.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblDay.Location = New Point(18, 73)
        lblDay.Name = "lblDay"
        lblDay.Size = New Size(103, 21)
        lblDay.TabIndex = 7
        lblDay.Text = "JULY 7, 2002"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(96, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 30)
        Label2.TabIndex = 6
        Label2.Text = "DATE TODAY"
        ' 
        ' lblNumbers
        ' 
        lblNumbers.AutoSize = True
        lblNumbers.BackColor = Color.LightPink
        lblNumbers.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        lblNumbers.Location = New Point(31, 116)
        lblNumbers.Name = "lblNumbers"
        lblNumbers.Size = New Size(111, 86)
        lblNumbers.TabIndex = 6
        lblNumbers.Text = "10"
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(lblNumbers)
        Panel4.Location = New Point(644, 126)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(170, 247)
        Panel4.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(40, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 60)
        Label5.TabIndex = 8
        Label5.Text = "TODAYS" & vbCrLf & "PATIENT"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.BackColor = Color.LightBlue
        lblTotal.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotal.Location = New Point(34, 114)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(111, 86)
        lblTotal.TabIndex = 8
        lblTotal.Text = "10"
        ' 
        ' Panel5
        ' 
        Panel5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(lblTotal)
        Panel5.Controls.Add(Label8)
        Panel5.Location = New Point(829, 401)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(170, 247)
        Panel5.TabIndex = 10
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(22, 36)
        Label8.Name = "Label8"
        Label8.Size = New Size(135, 46)
        Label8.TabIndex = 8
        Label8.Text = "TOTAL PATIENTS" & vbCrLf & "THIS MONTH"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel6
        ' 
        Panel6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(lblUpcoming)
        Panel6.Controls.Add(Label11)
        Panel6.Location = New Point(1010, 398)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(170, 247)
        Panel6.TabIndex = 11
        ' 
        ' lblUpcoming
        ' 
        lblUpcoming.AutoSize = True
        lblUpcoming.BackColor = Color.PaleGreen
        lblUpcoming.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        lblUpcoming.Location = New Point(32, 117)
        lblUpcoming.Name = "lblUpcoming"
        lblUpcoming.Size = New Size(111, 86)
        lblUpcoming.TabIndex = 8
        lblUpcoming.Text = "10"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(25, 30)
        Label11.Name = "Label11"
        Label11.Size = New Size(122, 60)
        Label11.TabIndex = 8
        Label11.Text = "UPCOMING" & vbCrLf & "PATIENTS"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel7
        ' 
        Panel7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel7.BackColor = Color.White
        Panel7.Controls.Add(Label13)
        Panel7.Controls.Add(Label14)
        Panel7.Location = New Point(644, 401)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(170, 247)
        Panel7.TabIndex = 11
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Thistle
        Label13.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(31, 121)
        Label13.Name = "Label13"
        Label13.Size = New Size(111, 86)
        Label13.TabIndex = 8
        Label13.Text = "10"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(24, 31)
        Label14.Name = "Label14"
        Label14.Size = New Size(128, 60)
        Label14.TabIndex = 8
        Label14.Text = "TREATMENT" & vbCrLf & "AVAILABLE"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(34, 126)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(520, 342)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox2.Image = My.Resources.Resources.next_button
        PictureBox2.Location = New Point(560, 265)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(25, 31)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.next_button___Copy1
        PictureBox3.Location = New Point(3, 265)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(25, 31)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 15
        PictureBox3.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(34, 482)
        Label10.Name = "Label10"
        Label10.Size = New Size(167, 21)
        Label10.TabIndex = 16
        Label10.Text = "CLINIC INFORMATION"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(106, 514)
        Label15.Name = "Label15"
        Label15.Size = New Size(428, 17)
        Label15.TabIndex = 17
        Label15.Text = "05-06 G. Tabios St, Baranggay 05, Malaybalay City, Bukidnon, Philippines"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(45, 514)
        Label16.Name = "Label16"
        Label16.Size = New Size(65, 17)
        Label16.TabIndex = 18
        Label16.Text = "Location:"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = My.Resources.Resources.fb_icon_325x325
        PictureBox4.Location = New Point(45, 575)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(25, 31)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 19
        PictureBox4.TabStop = False
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(76, 583)
        Label17.Name = "Label17"
        Label17.Size = New Size(134, 17)
        Label17.TabIndex = 20
        Label17.Text = "Tooth's Doctors Clinic"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.Transparent
        Label19.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label19.Location = New Point(76, 551)
        Label19.Name = "Label19"
        Label19.Size = New Size(95, 17)
        Label19.TabIndex = 22
        Label19.Text = "0917-791-6809"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = My.Resources.Resources.png_transparent_logo_computer_icons_instagram_logo_instagram_logo_miscellaneous_text_trademark
        PictureBox5.Location = New Point(45, 612)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(25, 31)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 23
        PictureBox5.TabStop = False
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.Transparent
        Label20.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label20.Location = New Point(76, 618)
        Label20.Name = "Label20"
        Label20.Size = New Size(134, 17)
        Label20.TabIndex = 24
        Label20.Text = "Tooth's Doctors Clinic"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.Image = My.Resources.Resources._2055904
        PictureBox6.Location = New Point(45, 541)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(25, 31)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 25
        PictureBox6.TabStop = False
        ' 
        ' lblGreet
        ' 
        lblGreet.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblGreet.AutoSize = True
        lblGreet.BackColor = Color.Transparent
        lblGreet.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblGreet.Location = New Point(19, 70)
        lblGreet.Name = "lblGreet"
        lblGreet.Size = New Size(159, 32)
        lblGreet.TabIndex = 26
        lblGreet.Text = "DASHBOARD"
        ' 
        ' formDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.MistyRose
        ClientSize = New Size(1213, 663)
        Controls.Add(lblGreet)
        Controls.Add(Label10)
        Controls.Add(Label15)
        Controls.Add(PictureBox3)
        Controls.Add(Label16)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox1)
        Controls.Add(Label20)
        Controls.Add(Panel7)
        Controls.Add(PictureBox5)
        Controls.Add(Panel6)
        Controls.Add(Label19)
        Controls.Add(Panel5)
        Controls.Add(Label17)
        Controls.Add(Panel1)
        Controls.Add(PictureBox4)
        Controls.Add(Panel3)
        Controls.Add(Label1)
        Controls.Add(Panel4)
        Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "formDashboard"
        Text = "formDashboard"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDay As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDayType As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNumbers As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblUpcoming As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label20 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents lblGreet As Label
End Class
