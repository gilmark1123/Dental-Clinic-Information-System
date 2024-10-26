<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dentist
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
        Panel3 = New Panel()
        lblAddress = New Label()
        lblBday = New Label()
        lblPhone = New Label()
        lblSpecialty = New Label()
        lblDegree = New Label()
        lblEmail = New Label()
        lblGender = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Label11 = New Label()
        rtbNotes = New RichTextBox()
        Panel4 = New Panel()
        Panel1 = New Panel()
        Panel2 = New Panel()
        lblfirst = New Label()
        lblID = New Label()
        pbPic = New PictureBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel6 = New Panel()
        Label10 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(pbPic, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(lblAddress)
        Panel3.Controls.Add(lblBday)
        Panel3.Controls.Add(lblPhone)
        Panel3.Controls.Add(lblSpecialty)
        Panel3.Controls.Add(lblDegree)
        Panel3.Controls.Add(lblEmail)
        Panel3.Controls.Add(lblGender)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(309, 8)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(560, 279)
        Panel3.TabIndex = 7
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblAddress.Location = New Point(80, 226)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(64, 17)
        lblAddress.TabIndex = 178
        lblAddress.Text = "Gender:"
        ' 
        ' lblBday
        ' 
        lblBday.AutoSize = True
        lblBday.Font = New Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblBday.Location = New Point(347, 29)
        lblBday.Name = "lblBday"
        lblBday.Size = New Size(64, 17)
        lblBday.TabIndex = 177
        lblBday.Text = "Gender:"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblPhone.Location = New Point(132, 165)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(64, 17)
        lblPhone.TabIndex = 176
        lblPhone.Text = "Gender:"
        ' 
        ' lblSpecialty
        ' 
        lblSpecialty.AutoSize = True
        lblSpecialty.Font = New Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblSpecialty.Location = New Point(347, 165)
        lblSpecialty.Name = "lblSpecialty"
        lblSpecialty.Size = New Size(64, 17)
        lblSpecialty.TabIndex = 175
        lblSpecialty.Text = "Gender:"
        ' 
        ' lblDegree
        ' 
        lblDegree.AutoSize = True
        lblDegree.Font = New Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblDegree.Location = New Point(335, 92)
        lblDegree.Name = "lblDegree"
        lblDegree.Size = New Size(64, 17)
        lblDegree.TabIndex = 174
        lblDegree.Text = "Gender:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmail.Location = New Point(62, 100)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(64, 17)
        lblEmail.TabIndex = 170
        lblEmail.Text = "Gender:"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblGender.Location = New Point(76, 26)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(64, 17)
        lblGender.TabIndex = 23
        lblGender.Text = "Gender:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(278, 161)
        Label9.Name = "Label9"
        Label9.Size = New Size(74, 20)
        Label9.TabIndex = 9
        Label9.Text = "Specialty:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(278, 89)
        Label8.Name = "Label8"
        Label8.Size = New Size(63, 20)
        Label8.TabIndex = 8
        Label8.Text = "Degree:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(16, 96)
        Label7.Name = "Label7"
        Label7.Size = New Size(50, 20)
        Label7.TabIndex = 7
        Label7.Text = "Email:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(16, 161)
        Label6.Name = "Label6"
        Label6.Size = New Size(119, 20)
        Label6.TabIndex = 6
        Label6.Text = "Phone Number:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(16, 223)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 20)
        Label5.TabIndex = 5
        Label5.Text = "Address:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(278, 26)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 20)
        Label4.TabIndex = 4
        Label4.Text = "Birthday:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(16, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 20)
        Label3.TabIndex = 3
        Label3.Text = "Gender:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.MistyRose
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(218, 249)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(4, 16)
        Label11.Name = "Label11"
        Label11.Size = New Size(53, 20)
        Label11.TabIndex = 11
        Label11.Text = "Notes:"
        ' 
        ' rtbNotes
        ' 
        rtbNotes.Location = New Point(18, 39)
        rtbNotes.Name = "rtbNotes"
        rtbNotes.Size = New Size(289, 204)
        rtbNotes.TabIndex = 4
        rtbNotes.Text = ""
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Button1)
        Panel4.Controls.Add(rtbNotes)
        Panel4.Controls.Add(Label11)
        Panel4.Location = New Point(894, 8)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(324, 279)
        Panel4.TabIndex = 8
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(21, 8)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(245, 279)
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(lblfirst)
        Panel2.Controls.Add(lblID)
        Panel2.Controls.Add(pbPic)
        Panel2.Location = New Point(-15, -1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(267, 279)
        Panel2.TabIndex = 2
        ' 
        ' lblfirst
        ' 
        lblfirst.AutoSize = True
        lblfirst.Font = New Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblfirst.Location = New Point(63, 207)
        lblfirst.Name = "lblfirst"
        lblfirst.Size = New Size(64, 17)
        lblfirst.TabIndex = 21
        lblfirst.Text = "Gender:"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblID.Location = New Point(97, 246)
        lblID.Name = "lblID"
        lblID.Size = New Size(64, 20)
        lblID.TabIndex = 19
        lblID.Text = "Gender:"
        ' 
        ' pbPic
        ' 
        pbPic.BackgroundImageLayout = ImageLayout.Center
        pbPic.Location = New Point(51, 37)
        pbPic.Name = "pbPic"
        pbPic.Size = New Size(157, 166)
        pbPic.SizeMode = PictureBoxSizeMode.Zoom
        pbPic.TabIndex = 0
        pbPic.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(32, 224)
        Label1.Name = "Label1"
        Label1.Size = New Size(173, 22)
        Label1.TabIndex = 1
        Label1.Text = "Gilmark Estabas"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(36, 37)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(157, 166)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(Label10)
        Panel6.Location = New Point(21, 305)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1197, 434)
        Panel6.TabIndex = 10
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(19, 28)
        Label10.Name = "Label10"
        Label10.Size = New Size(175, 20)
        Label10.TabIndex = 21
        Label10.Text = "Upcoming Appoinments"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Dentist
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Snow
        ClientSize = New Size(1267, 774)
        Controls.Add(Panel3)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        Controls.Add(Panel6)
        Name = "Dentist"
        Text = "Dentist"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(pbPic, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents textboxNote As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents lblDate As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lblNumber As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblBday As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblEmail As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblSex As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblName1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents rtbSpecialty As Label
    Friend WithEvents rtbDegree As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents rtbNotes As RichTextBox
    Friend WithEvents lblfirst As Label
    Friend WithEvents lblID As Label
    Friend WithEvents pbPic As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblSpecialty As Label
    Friend WithEvents lblDegree As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
