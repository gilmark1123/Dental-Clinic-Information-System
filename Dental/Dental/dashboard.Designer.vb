<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel7 = New Panel()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Panel6 = New Panel()
        lblUpcoming = New Label()
        Label11 = New Label()
        Panel5 = New Panel()
        lblTotal = New Label()
        Label8 = New Label()
        Panel1 = New Panel()
        lblDayType = New Label()
        Label4 = New Label()
        lblDay = New Label()
        Label2 = New Label()
        Panel3 = New Panel()
        lblTime = New Label()
        Label1 = New Label()
        Panel4 = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        lblNumbers = New Label()
        Label10 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        PictureBox6 = New PictureBox()
        Label20 = New Label()
        PictureBox5 = New PictureBox()
        Label19 = New Label()
        Label17 = New Label()
        PictureBox4 = New PictureBox()
        Timer1 = New Timer(components)
        lblGreet = New Label()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.next_button___Copy1
        PictureBox3.Location = New Point(10, 286)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(25, 31)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 36
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox2.Image = My.Resources.Resources.next_button
        PictureBox2.Location = New Point(547, 299)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(25, 31)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 35
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(40, 119)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(501, 344)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        ' 
        ' Panel7
        ' 
        Panel7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel7.BackColor = Color.LavenderBlush
        Panel7.Controls.Add(Label12)
        Panel7.Controls.Add(Label13)
        Panel7.Controls.Add(Label14)
        Panel7.Location = New Point(590, 399)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(152, 247)
        Panel7.TabIndex = 33
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(18, 68)
        Label12.Name = "Label12"
        Label12.Size = New Size(116, 30)
        Label12.TabIndex = 9
        Label12.Text = "AVAILABLE"
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label13.AutoSize = True
        Label13.BackColor = Color.Thistle
        Label13.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(23, 132)
        Label13.Name = "Label13"
        Label13.Size = New Size(111, 86)
        Label13.TabIndex = 8
        Label13.Text = "10"
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(12, 35)
        Label14.Name = "Label14"
        Label14.Size = New Size(128, 30)
        Label14.TabIndex = 8
        Label14.Text = "TREATMENT"
        ' 
        ' Panel6
        ' 
        Panel6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel6.BackColor = Color.LavenderBlush
        Panel6.Controls.Add(lblUpcoming)
        Panel6.Controls.Add(Label11)
        Panel6.Location = New Point(914, 399)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(151, 247)
        Panel6.TabIndex = 34
        ' 
        ' lblUpcoming
        ' 
        lblUpcoming.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblUpcoming.AutoSize = True
        lblUpcoming.BackColor = Color.PaleGreen
        lblUpcoming.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        lblUpcoming.Location = New Point(19, 131)
        lblUpcoming.Name = "lblUpcoming"
        lblUpcoming.Size = New Size(111, 86)
        lblUpcoming.TabIndex = 8
        lblUpcoming.Text = "10"
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(14, 35)
        Label11.Name = "Label11"
        Label11.Size = New Size(122, 60)
        Label11.TabIndex = 8
        Label11.Text = "UPCOMING" & vbCrLf & "PATIENTS"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel5
        ' 
        Panel5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel5.BackColor = Color.LavenderBlush
        Panel5.Controls.Add(lblTotal)
        Panel5.Controls.Add(Label8)
        Panel5.Location = New Point(753, 399)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(151, 247)
        Panel5.TabIndex = 32
        ' 
        ' lblTotal
        ' 
        lblTotal.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTotal.AutoSize = True
        lblTotal.BackColor = Color.LightBlue
        lblTotal.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotal.Location = New Point(21, 131)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(111, 86)
        lblTotal.TabIndex = 8
        lblTotal.Text = "10"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(8, 37)
        Label8.Name = "Label8"
        Label8.Size = New Size(135, 46)
        Label8.TabIndex = 8
        Label8.Text = "TOTAL PATIENTS" & vbCrLf & "TTHIS MONTH"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel1.BackColor = Color.LavenderBlush
        Panel1.Controls.Add(lblDayType)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(lblDay)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(770, 221)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(294, 150)
        Panel1.TabIndex = 29
        ' 
        ' lblDayType
        ' 
        lblDayType.Anchor = AnchorStyles.Top
        lblDayType.AutoSize = True
        lblDayType.BackColor = Color.Transparent
        lblDayType.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblDayType.Location = New Point(176, 69)
        lblDayType.Name = "lblDayType"
        lblDayType.Size = New Size(76, 21)
        lblDayType.TabIndex = 9
        lblDayType.Text = "SUNDAY"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Lucida Sans", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(152, 61)
        Label4.Name = "Label4"
        Label4.Size = New Size(26, 39)
        Label4.TabIndex = 8
        Label4.Text = "l"
        ' 
        ' lblDay
        ' 
        lblDay.Anchor = AnchorStyles.Top
        lblDay.AutoSize = True
        lblDay.BackColor = Color.Transparent
        lblDay.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblDay.Location = New Point(7, 69)
        lblDay.Name = "lblDay"
        lblDay.Size = New Size(103, 21)
        lblDay.TabIndex = 7
        lblDay.Text = "JULY 7, 2002"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(84, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 30)
        Label2.TabIndex = 6
        Label2.Text = "DATE TODAY"
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel3.BackColor = Color.LavenderBlush
        Panel3.Controls.Add(lblTime)
        Panel3.Location = New Point(768, 133)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(296, 82)
        Panel3.TabIndex = 26
        ' 
        ' lblTime
        ' 
        lblTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTime.AutoSize = True
        lblTime.BackColor = Color.Transparent
        lblTime.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTime.Location = New Point(65, 16)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(178, 47)
        lblTime.TabIndex = 5
        lblTime.Text = "00:00 AM"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 50)
        Label1.TabIndex = 27
        Label1.Text = "Dashboard"
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel4.BackColor = Color.LavenderBlush
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(lblNumbers)
        Panel4.Location = New Point(590, 136)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(152, 235)
        Panel4.TabIndex = 30
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(32, 57)
        Label6.Name = "Label6"
        Label6.Size = New Size(102, 30)
        Label6.TabIndex = 9
        Label6.Text = "PATIENTS"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(35, 27)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 30)
        Label5.TabIndex = 8
        Label5.Text = "TODAYS"
        ' 
        ' lblNumbers
        ' 
        lblNumbers.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblNumbers.AutoSize = True
        lblNumbers.BackColor = Color.LightPink
        lblNumbers.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        lblNumbers.Location = New Point(23, 119)
        lblNumbers.Name = "lblNumbers"
        lblNumbers.Size = New Size(111, 86)
        lblNumbers.TabIndex = 6
        lblNumbers.Text = "10"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.ControlLightLight
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(30, 497)
        Label10.Name = "Label10"
        Label10.Size = New Size(167, 21)
        Label10.TabIndex = 16
        Label10.Text = "CLINIC INFORMATION"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = SystemColors.ControlLightLight
        Label15.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(101, 524)
        Label15.Name = "Label15"
        Label15.Size = New Size(428, 17)
        Label15.TabIndex = 17
        Label15.Text = "05-06 G. Tabios St, Baranggay 05, Malaybalay City, Bukidnon, Philippines"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = SystemColors.ControlLightLight
        Label16.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(40, 524)
        Label16.Name = "Label16"
        Label16.Size = New Size(65, 17)
        Label16.TabIndex = 18
        Label16.Text = "Location:"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = SystemColors.ControlLightLight
        PictureBox6.Image = My.Resources.Resources._2055904
        PictureBox6.Location = New Point(43, 542)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(25, 31)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 25
        PictureBox6.TabStop = False
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = SystemColors.ControlLightLight
        Label20.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label20.Location = New Point(74, 621)
        Label20.Name = "Label20"
        Label20.Size = New Size(134, 17)
        Label20.TabIndex = 24
        Label20.Text = "Tooth's Doctors Clinic"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = SystemColors.ControlLightLight
        PictureBox5.Image = My.Resources.Resources.png_transparent_logo_computer_icons_instagram_logo_instagram_logo_miscellaneous_text_trademark
        PictureBox5.Location = New Point(43, 613)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(25, 31)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 23
        PictureBox5.TabStop = False
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = SystemColors.ControlLightLight
        Label19.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label19.Location = New Point(74, 552)
        Label19.Name = "Label19"
        Label19.Size = New Size(95, 17)
        Label19.TabIndex = 22
        Label19.Text = "0917-791-6809"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = SystemColors.ControlLightLight
        Label17.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(74, 584)
        Label17.Name = "Label17"
        Label17.Size = New Size(134, 17)
        Label17.TabIndex = 20
        Label17.Text = "Tooth's Doctors Clinic"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = SystemColors.ControlLightLight
        PictureBox4.Image = My.Resources.Resources.fb_icon_325x325
        PictureBox4.Location = New Point(43, 576)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(25, 31)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 19
        PictureBox4.TabStop = False
        ' 
        ' Timer1
        ' 
        ' 
        ' lblGreet
        ' 
        lblGreet.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblGreet.AutoSize = True
        lblGreet.BackColor = Color.Transparent
        lblGreet.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblGreet.Location = New Point(19, 59)
        lblGreet.Name = "lblGreet"
        lblGreet.Size = New Size(159, 32)
        lblGreet.TabIndex = 37
        lblGreet.Text = "DASHBOARD"
        ' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1092, 688)
        Controls.Add(lblGreet)
        Controls.Add(Label10)
        Controls.Add(Label15)
        Controls.Add(PictureBox3)
        Controls.Add(Label16)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox1)
        Controls.Add(Label20)
        Controls.Add(Panel6)
        Controls.Add(PictureBox5)
        Controls.Add(Panel5)
        Controls.Add(Label19)
        Controls.Add(Panel7)
        Controls.Add(Label17)
        Controls.Add(Panel1)
        Controls.Add(PictureBox4)
        Controls.Add(Panel3)
        Controls.Add(Label1)
        Controls.Add(Panel4)
        FormBorderStyle = FormBorderStyle.None
        Name = "dashboard"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents lblUpcoming As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDayType As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNumbers As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label20 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblGreet As Label
End Class
