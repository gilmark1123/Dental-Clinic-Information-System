<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTreatment
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
        Label1 = New Label()
        cmbWork1 = New ComboBox()
        cmbDoctor = New ComboBox()
        Label4 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label2 = New Label()
        Label6 = New Label()
        rtbPrescriptions = New RichTextBox()
        Button2 = New Button()
        lblname = New Label()
        cmbWork2 = New ComboBox()
        cmbWork3 = New ComboBox()
        Button1 = New Button()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        lblid = New Label()
        Label7 = New Label()
        dateTreatment = New DateTimePicker()
        btnChild = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Lucida Sans", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(3, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(205, 42)
        Label1.TabIndex = 20
        Label1.Text = "Treatment"
        ' 
        ' cmbWork1
        ' 
        cmbWork1.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmbWork1.FormattingEnabled = True
        cmbWork1.Location = New Point(24, 334)
        cmbWork1.Name = "cmbWork1"
        cmbWork1.Size = New Size(338, 26)
        cmbWork1.TabIndex = 43
        ' 
        ' cmbDoctor
        ' 
        cmbDoctor.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmbDoctor.FormattingEnabled = True
        cmbDoctor.Location = New Point(21, 181)
        cmbDoctor.Name = "cmbDoctor"
        cmbDoctor.Size = New Size(338, 26)
        cmbDoctor.TabIndex = 42
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(26, 306)
        Label4.Name = "Label4"
        Label4.Size = New Size(171, 22)
        Label4.TabIndex = 41
        Label4.Text = "Work Performed"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(24, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(156, 22)
        Label3.TabIndex = 39
        Label3.Text = "Doctor's Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(21, 231)
        Label5.Name = "Label5"
        Label5.Size = New Size(187, 22)
        Label5.TabIndex = 37
        Label5.Text = "Treatment's Date "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(21, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 22)
        Label2.TabIndex = 36
        Label2.Text = "Patient's Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(391, 61)
        Label6.Name = "Label6"
        Label6.Size = New Size(133, 22)
        Label6.TabIndex = 44
        Label6.Text = "Presciptions"
        ' 
        ' rtbPrescriptions
        ' 
        rtbPrescriptions.Location = New Point(391, 95)
        rtbPrescriptions.Name = "rtbPrescriptions"
        rtbPrescriptions.Size = New Size(260, 219)
        rtbPrescriptions.TabIndex = 46
        rtbPrescriptions.Text = ""
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightPink
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Location = New Point(110, 459)
        Button2.Name = "Button2"
        Button2.Size = New Size(167, 45)
        Button2.TabIndex = 48
        Button2.Text = "Proceed Adult Treatment"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.Font = New Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblname.Location = New Point(186, 118)
        lblname.Name = "lblname"
        lblname.Size = New Size(56, 17)
        lblname.TabIndex = 49
        lblname.Text = "Label7"
        ' 
        ' cmbWork2
        ' 
        cmbWork2.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmbWork2.FormattingEnabled = True
        cmbWork2.Location = New Point(24, 366)
        cmbWork2.Name = "cmbWork2"
        cmbWork2.Size = New Size(338, 26)
        cmbWork2.TabIndex = 51
        ' 
        ' cmbWork3
        ' 
        cmbWork3.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmbWork3.FormattingEnabled = True
        cmbWork3.Location = New Point(24, 398)
        cmbWork3.Name = "cmbWork3"
        cmbWork3.Size = New Size(338, 26)
        cmbWork3.TabIndex = 52
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(203, 298)
        Button1.Name = "Button1"
        Button1.Size = New Size(74, 30)
        Button1.TabIndex = 56
        Button1.Text = "Add Work"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' lblid
        ' 
        lblid.AutoSize = True
        lblid.Font = New Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblid.Location = New Point(151, 72)
        lblid.Name = "lblid"
        lblid.Size = New Size(56, 17)
        lblid.TabIndex = 57
        lblid.Text = "Label7"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(21, 68)
        Label7.Name = "Label7"
        Label7.Size = New Size(124, 22)
        Label7.TabIndex = 58
        Label7.Text = "Patient's ID"
        ' 
        ' dateTreatment
        ' 
        dateTreatment.CalendarFont = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dateTreatment.CustomFormat = "yyyy/MM/dd"
        dateTreatment.Format = DateTimePickerFormat.Custom
        dateTreatment.Location = New Point(24, 256)
        dateTreatment.Name = "dateTreatment"
        dateTreatment.Size = New Size(338, 23)
        dateTreatment.TabIndex = 59
        ' 
        ' btnChild
        ' 
        btnChild.BackColor = Color.LightPink
        btnChild.FlatStyle = FlatStyle.Popup
        btnChild.Location = New Point(391, 459)
        btnChild.Name = "btnChild"
        btnChild.Size = New Size(167, 45)
        btnChild.TabIndex = 60
        btnChild.Text = "Proceed Child Treatment"
        btnChild.UseVisualStyleBackColor = False
        ' 
        ' formTreatment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Snow
        ClientSize = New Size(711, 535)
        Controls.Add(btnChild)
        Controls.Add(dateTreatment)
        Controls.Add(Label7)
        Controls.Add(lblid)
        Controls.Add(Button1)
        Controls.Add(cmbWork3)
        Controls.Add(cmbWork2)
        Controls.Add(lblname)
        Controls.Add(Button2)
        Controls.Add(rtbPrescriptions)
        Controls.Add(Label6)
        Controls.Add(cmbWork1)
        Controls.Add(cmbDoctor)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "formTreatment"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbWork1 As ComboBox
    Friend WithEvents cmbDoctor As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents lblname As Label
    Friend WithEvents cmbWork2 As ComboBox
    Friend WithEvents cmbWork3 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents id As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblid As Label
    Friend WithEvents rtbPrescriptions As RichTextBox
    Friend WithEvents dateTreatment As DateTimePicker
    Friend WithEvents btnChild As Button
End Class
