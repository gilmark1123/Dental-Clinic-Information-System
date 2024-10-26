<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formHome
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(formHome))
        Panel1 = New Panel()
        btnLogout = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        btnPatients = New Button()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        panelView = New Panel()
        btnDashboard = New Button()
        btnAppointments = New Button()
        Button1 = New Button()
        Timer1 = New Timer(components)
        btnAccount = New Button()
        panelVisible = New Panel()
        btnLogoutAccount = New Button()
        timerTransition = New Timer(components)
        panelTransitionTimer = New Timer(components)
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        panelVisible.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MistyRose
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1264, 68)
        Panel1.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLogout.BackColor = Color.LavenderBlush
        btnLogout.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogout.Image = My.Resources.Resources.person_icon
        btnLogout.Location = New Point(1108, 12)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(132, 41)
        btnLogout.TabIndex = 12
        btnLogout.Text = "Gilmark Estabas"
        btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(102, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(212, 30)
        Label1.TabIndex = 4
        Label1.Text = "Tooth Doctors Clinic"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = My.Resources.Resources._372579870_300909525963027_3926675335435449185_n__1__modified
        PictureBox1.Location = New Point(12, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(84, 62)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' btnPatients
        ' 
        btnPatients.BackColor = Color.MistyRose
        btnPatients.FlatAppearance.BorderColor = Color.Black
        btnPatients.FlatAppearance.BorderSize = 0
        btnPatients.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(252), CByte(197), CByte(192))
        btnPatients.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(252), CByte(197), CByte(192))
        btnPatients.FlatStyle = FlatStyle.Flat
        btnPatients.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnPatients.ForeColor = SystemColors.ActiveCaptionText
        btnPatients.Image = My.Resources.Resources.patient1
        btnPatients.Location = New Point(290, 78)
        btnPatients.Name = "btnPatients"
        btnPatients.Size = New Size(218, 44)
        btnPatients.TabIndex = 4
        btnPatients.Text = "Patients"
        btnPatients.TextImageRelation = TextImageRelation.ImageBeforeText
        btnPatients.UseVisualStyleBackColor = False
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' panelView
        ' 
        panelView.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        panelView.BackColor = Color.White
        panelView.Location = New Point(27, 133)
        panelView.Name = "panelView"
        panelView.Size = New Size(1213, 663)
        panelView.TabIndex = 3
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.MistyRose
        btnDashboard.BackgroundImageLayout = ImageLayout.None
        btnDashboard.FlatAppearance.BorderColor = Color.Black
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(252), CByte(197), CByte(192))
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(252), CByte(197), CByte(192))
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnDashboard.ForeColor = SystemColors.ActiveCaptionText
        btnDashboard.Image = My.Resources.Resources.denthome1
        btnDashboard.Location = New Point(44, 78)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(218, 44)
        btnDashboard.TabIndex = 0
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.UseMnemonic = False
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' btnAppointments
        ' 
        btnAppointments.BackColor = Color.MistyRose
        btnAppointments.FlatAppearance.BorderColor = Color.Black
        btnAppointments.FlatAppearance.BorderSize = 0
        btnAppointments.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(252), CByte(197), CByte(192))
        btnAppointments.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(252), CByte(197), CByte(192))
        btnAppointments.FlatStyle = FlatStyle.Flat
        btnAppointments.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnAppointments.ForeColor = SystemColors.ActiveCaptionText
        btnAppointments.Image = My.Resources.Resources.medical1
        btnAppointments.Location = New Point(538, 78)
        btnAppointments.Name = "btnAppointments"
        btnAppointments.Size = New Size(218, 44)
        btnAppointments.TabIndex = 10
        btnAppointments.Text = "Appointments"
        btnAppointments.TextAlign = ContentAlignment.MiddleLeft
        btnAppointments.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAppointments.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.MistyRose
        Button1.FlatAppearance.BorderColor = Color.Black
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(252), CByte(197), CByte(192))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(252), CByte(197), CByte(192))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Image = My.Resources.Resources.dentist1
        Button1.Location = New Point(781, 78)
        Button1.Name = "Button1"
        Button1.Size = New Size(218, 44)
        Button1.TabIndex = 4
        Button1.Text = "Dentist Mode"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnAccount
        ' 
        btnAccount.BackColor = Color.MistyRose
        btnAccount.FlatAppearance.BorderColor = Color.Black
        btnAccount.FlatAppearance.BorderSize = 0
        btnAccount.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(252), CByte(197), CByte(192))
        btnAccount.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(252), CByte(197), CByte(192))
        btnAccount.FlatStyle = FlatStyle.Flat
        btnAccount.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnAccount.Image = My.Resources.Resources.profile
        btnAccount.Location = New Point(1022, 78)
        btnAccount.Name = "btnAccount"
        btnAccount.Size = New Size(218, 44)
        btnAccount.TabIndex = 11
        btnAccount.Text = "Account"
        btnAccount.TextAlign = ContentAlignment.MiddleLeft
        btnAccount.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAccount.UseVisualStyleBackColor = False
        ' 
        ' panelVisible
        ' 
        panelVisible.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        panelVisible.BackColor = Color.Snow
        panelVisible.Controls.Add(btnLogoutAccount)
        panelVisible.Location = New Point(1108, 52)
        panelVisible.Name = "panelVisible"
        panelVisible.Size = New Size(132, 47)
        panelVisible.TabIndex = 13
        panelVisible.Visible = False
        ' 
        ' btnLogoutAccount
        ' 
        btnLogoutAccount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLogoutAccount.BackColor = Color.Snow
        btnLogoutAccount.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogoutAccount.Image = My.Resources.Resources.power
        btnLogoutAccount.Location = New Point(0, 9)
        btnLogoutAccount.Name = "btnLogoutAccount"
        btnLogoutAccount.Size = New Size(132, 35)
        btnLogoutAccount.TabIndex = 13
        btnLogoutAccount.Text = "Logout"
        btnLogoutAccount.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogoutAccount.UseVisualStyleBackColor = False
        ' 
        ' panelTransitionTimer
        ' 
        panelTransitionTimer.Interval = 50
        ' 
        ' formHome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.White
        ClientSize = New Size(1264, 824)
        Controls.Add(panelVisible)
        Controls.Add(btnAccount)
        Controls.Add(panelView)
        Controls.Add(Button1)
        Controls.Add(btnPatients)
        Controls.Add(Panel1)
        Controls.Add(btnDashboard)
        Controls.Add(btnAppointments)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MdiChildrenMinimizedAnchorBottom = False
        Name = "formHome"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        panelVisible.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents picHome As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents panelView As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAppointments As Button
    Friend WithEvents btnPatients As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnAccount As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents panelVisible As Panel
    Friend WithEvents btnLogoutAccount As Button
    Friend WithEvents timerTransition As Timer
    Friend WithEvents panelTransitionTimer As Timer
End Class
