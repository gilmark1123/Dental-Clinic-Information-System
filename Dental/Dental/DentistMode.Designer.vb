<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DentistMode
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
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        Panel2 = New Panel()
        btnLogout = New Button()
        panelVisible = New Panel()
        btnLogoutAccount = New Button()
        Panel4 = New Panel()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        lblCurrentPlace = New Label()
        PictureBox2 = New PictureBox()
        panelTransitionTimer = New Timer(components)
        btnDashboard = New Button()
        btnPatients = New Button()
        btnDentist = New Button()
        Panel1 = New Panel()
        PictureBox4 = New PictureBox()
        btnAppointment = New Button()
        btnEmployee = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        panelVisible.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(119, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(232, 32)
        Label1.TabIndex = 6
        Label1.Text = "Tooth Doctors Clinic"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = My.Resources.Resources._372579870_300909525963027_3926675335435449185_n__1__modified
        PictureBox1.Location = New Point(36, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(77, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = SystemColors.ControlLightLight
        Panel3.Location = New Point(250, 124)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1092, 688)
        Panel3.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.Snow
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(btnLogout)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(-9, -1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1367, 72)
        Panel2.TabIndex = 2
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLogout.BackColor = Color.LavenderBlush
        btnLogout.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogout.Image = My.Resources.Resources.person_icon
        btnLogout.Location = New Point(1197, 14)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(132, 41)
        btnLogout.TabIndex = 14
        btnLogout.Text = "Gilmark Estabas"
        btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' panelVisible
        ' 
        panelVisible.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        panelVisible.BackColor = Color.Pink
        panelVisible.Controls.Add(btnLogoutAccount)
        panelVisible.Location = New Point(1188, 53)
        panelVisible.Name = "panelVisible"
        panelVisible.Size = New Size(132, 47)
        panelVisible.TabIndex = 15
        panelVisible.Visible = False
        ' 
        ' btnLogoutAccount
        ' 
        btnLogoutAccount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLogoutAccount.BackColor = Color.LavenderBlush
        btnLogoutAccount.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogoutAccount.Image = My.Resources.Resources.power
        btnLogoutAccount.Location = New Point(0, 12)
        btnLogoutAccount.Name = "btnLogoutAccount"
        btnLogoutAccount.Size = New Size(132, 35)
        btnLogoutAccount.TabIndex = 13
        btnLogoutAccount.Text = "Logout"
        btnLogoutAccount.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogoutAccount.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel4.BackColor = SystemColors.ControlLightLight
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(PictureBox3)
        Panel4.Controls.Add(lblCurrentPlace)
        Panel4.Controls.Add(PictureBox2)
        Panel4.Location = New Point(250, 81)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1092, 33)
        Panel4.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(23, 8)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 17)
        Label2.TabIndex = 7
        Label2.Text = "Dentist Mode"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImageLayout = ImageLayout.None
        PictureBox3.Image = My.Resources.Resources.home
        PictureBox3.Location = New Point(3, 8)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(24, 16)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 12
        PictureBox3.TabStop = False
        ' 
        ' lblCurrentPlace
        ' 
        lblCurrentPlace.AutoSize = True
        lblCurrentPlace.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblCurrentPlace.Location = New Point(135, 8)
        lblCurrentPlace.Name = "lblCurrentPlace"
        lblCurrentPlace.Size = New Size(87, 17)
        lblCurrentPlace.TabIndex = 8
        lblCurrentPlace.Text = "Dentist Mode"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources._next
        PictureBox2.Location = New Point(117, 9)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(28, 17)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' panelTransitionTimer
        ' 
        panelTransitionTimer.Interval = 50
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.MistyRose
        btnDashboard.FlatAppearance.BorderColor = Color.BurlyWood
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatAppearance.MouseDownBackColor = Color.LightPink
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.LightPink
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnDashboard.ForeColor = SystemColors.ActiveCaptionText
        btnDashboard.Image = My.Resources.Resources._123home
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.Location = New Point(1, 303)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(227, 44)
        btnDashboard.TabIndex = 7
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' btnPatients
        ' 
        btnPatients.BackColor = Color.MistyRose
        btnPatients.FlatAppearance.BorderColor = Color.BurlyWood
        btnPatients.FlatAppearance.BorderSize = 0
        btnPatients.FlatAppearance.MouseDownBackColor = Color.LightPink
        btnPatients.FlatAppearance.MouseOverBackColor = Color.LightPink
        btnPatients.FlatStyle = FlatStyle.Flat
        btnPatients.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnPatients.ForeColor = SystemColors.ActiveCaptionText
        btnPatients.Image = My.Resources.Resources.patientD
        btnPatients.ImageAlign = ContentAlignment.MiddleLeft
        btnPatients.Location = New Point(1, 347)
        btnPatients.Name = "btnPatients"
        btnPatients.Size = New Size(227, 44)
        btnPatients.TabIndex = 9
        btnPatients.Text = "Patients"
        btnPatients.TextImageRelation = TextImageRelation.ImageBeforeText
        btnPatients.UseVisualStyleBackColor = False
        ' 
        ' btnDentist
        ' 
        btnDentist.BackColor = Color.MistyRose
        btnDentist.FlatAppearance.BorderColor = Color.BurlyWood
        btnDentist.FlatAppearance.BorderSize = 0
        btnDentist.FlatAppearance.MouseDownBackColor = Color.LightPink
        btnDentist.FlatAppearance.MouseOverBackColor = Color.LightPink
        btnDentist.FlatStyle = FlatStyle.Flat
        btnDentist.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnDentist.ForeColor = SystemColors.ActiveCaptionText
        btnDentist.Image = My.Resources.Resources.dentistD
        btnDentist.ImageAlign = ContentAlignment.MiddleLeft
        btnDentist.Location = New Point(0, 442)
        btnDentist.Name = "btnDentist"
        btnDentist.Size = New Size(227, 44)
        btnDentist.TabIndex = 11
        btnDentist.Text = "Dentist"
        btnDentist.TextAlign = ContentAlignment.MiddleLeft
        btnDentist.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDentist.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Panel1.BackColor = Color.MistyRose
        Panel1.Controls.Add(btnEmployee)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(btnAppointment)
        Panel1.Controls.Add(btnDentist)
        Panel1.Controls.Add(btnPatients)
        Panel1.Controls.Add(btnDashboard)
        Panel1.Location = New Point(2, 70)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(228, 755)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.BackgroundImageLayout = ImageLayout.None
        PictureBox4.Image = My.Resources.Resources.dentist_tools_avatar_profile_isolated_vector_illustration_graphic_design_146876763
        PictureBox4.Location = New Point(16, 54)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(195, 200)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 13
        PictureBox4.TabStop = False
        ' 
        ' btnAppointment
        ' 
        btnAppointment.BackColor = Color.MistyRose
        btnAppointment.FlatAppearance.BorderColor = Color.BurlyWood
        btnAppointment.FlatAppearance.BorderSize = 0
        btnAppointment.FlatAppearance.MouseDownBackColor = Color.LightPink
        btnAppointment.FlatAppearance.MouseOverBackColor = Color.LightPink
        btnAppointment.FlatStyle = FlatStyle.Flat
        btnAppointment.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnAppointment.ForeColor = SystemColors.ActiveCaptionText
        btnAppointment.Image = My.Resources.Resources.calendar11
        btnAppointment.ImageAlign = ContentAlignment.MiddleLeft
        btnAppointment.Location = New Point(1, 395)
        btnAppointment.Name = "btnAppointment"
        btnAppointment.Size = New Size(226, 44)
        btnAppointment.TabIndex = 12
        btnAppointment.Text = "Appointments"
        btnAppointment.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAppointment.UseVisualStyleBackColor = False
        ' 
        ' btnEmployee
        ' 
        btnEmployee.BackColor = Color.MistyRose
        btnEmployee.FlatAppearance.BorderColor = Color.BurlyWood
        btnEmployee.FlatAppearance.BorderSize = 0
        btnEmployee.FlatAppearance.MouseDownBackColor = Color.LightPink
        btnEmployee.FlatAppearance.MouseOverBackColor = Color.LightPink
        btnEmployee.FlatStyle = FlatStyle.Flat
        btnEmployee.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnEmployee.ForeColor = SystemColors.ActiveCaptionText
        btnEmployee.Image = My.Resources.Resources.employee__4_
        btnEmployee.ImageAlign = ContentAlignment.MiddleLeft
        btnEmployee.Location = New Point(0, 489)
        btnEmployee.Name = "btnEmployee"
        btnEmployee.Size = New Size(226, 44)
        btnEmployee.TabIndex = 12
        btnEmployee.Text = "Employee"
        btnEmployee.TextAlign = ContentAlignment.MiddleLeft
        btnEmployee.TextImageRelation = TextImageRelation.ImageBeforeText
        btnEmployee.UseVisualStyleBackColor = False
        ' 
        ' DentistMode
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(1356, 824)
        Controls.Add(panelVisible)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "DentistMode"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DentistMode"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        panelVisible.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblCurrentPlace As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents panelVisible As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnLogoutAccount As Button
    Friend WithEvents panelTransitionTimer As Timer
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnPatients As Button
    Friend WithEvents btnDentist As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAppointment As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnEmployee As Button
End Class
