<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        txtUser = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        Label1 = New Label()
        Label3 = New Label()
        CheckBox1 = New CheckBox()
        Panel1 = New Panel()
        Label2 = New Label()
        LinkLabel1 = New LinkLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Snow
        PictureBox1.Image = My.Resources.Resources.pink1
        PictureBox1.Location = New Point(1, 633)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(675, 217)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Snow
        PictureBox2.Image = My.Resources.Resources.pink_nasab2
        PictureBox2.Location = New Point(-70, -54)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(716, 342)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' txtUser
        ' 
        txtUser.BackColor = Color.Snow
        txtUser.BorderStyle = BorderStyle.FixedSingle
        txtUser.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        txtUser.Location = New Point(123, 331)
        txtUser.Name = "txtUser"
        txtUser.PlaceholderText = "Username"
        txtUser.Size = New Size(395, 39)
        txtUser.TabIndex = 0
        txtUser.Tag = ""
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.Snow
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(123, 397)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Password"
        txtPassword.Size = New Size(395, 39)
        txtPassword.TabIndex = 1
        txtPassword.Tag = ""
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.MistyRose
        btnLogin.FlatAppearance.MouseDownBackColor = Color.Pink
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogin.Location = New Point(123, 498)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(395, 48)
        btnLogin.TabIndex = 2
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Snow
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(250, 230)
        Label1.Name = "Label1"
        Label1.Size = New Size(293, 50)
        Label1.TabIndex = 3
        Label1.Text = "YOUR ACCOUNT"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Snow
        Label3.Font = New Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.LightCoral
        Label3.Location = New Point(74, 217)
        Label3.Name = "Label3"
        Label3.Size = New Size(193, 71)
        Label3.TabIndex = 4
        Label3.Text = "LOGIN"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(123, 442)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(108, 19)
        CheckBox1.TabIndex = 11
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Location = New Point(1, 279)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(610, 362)
        Panel1.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(218, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 17)
        Label2.TabIndex = 14
        Label2.Text = "Are you Register?"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.LightPink
        LinkLabel1.AutoSize = True
        LinkLabel1.DisabledLinkColor = Color.Pink
        LinkLabel1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LinkLabel1.LinkColor = Color.HotPink
        LinkLabel1.Location = New Point(332, 196)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(88, 17)
        LinkLabel1.TabIndex = 13
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Sign Up Here"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.Snow
        BackgroundImage = My.Resources.Resources.bg
        ClientSize = New Size(611, 815)
        Controls.Add(Label1)
        Controls.Add(CheckBox1)
        Controls.Add(Label3)
        Controls.Add(PictureBox2)
        Controls.Add(btnLogin)
        Controls.Add(PictureBox1)
        Controls.Add(txtPassword)
        Controls.Add(txtUser)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
End Class
