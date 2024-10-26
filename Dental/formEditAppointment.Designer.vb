<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEditAppointment
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
        lblName = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        cbOperation = New ComboBox()
        cbDoctor = New ComboBox()
        dateTreatment = New DateTimePicker()
        Panel1 = New Panel()
        Label6 = New Label()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(36, 82)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 21)
        Label1.TabIndex = 0
        Label1.Text = "Patients Name:"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(153, 82)
        lblName.Margin = New Padding(4, 0, 4, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(119, 21)
        lblName.TabIndex = 1
        lblName.Text = "Patients Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(36, 130)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 21)
        Label3.TabIndex = 2
        Label3.Text = "Doctor:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(36, 212)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 21)
        Label4.TabIndex = 3
        Label4.Text = "Operation:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(36, 302)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 21)
        Label5.TabIndex = 4
        Label5.Text = "Date:"
        ' 
        ' cbOperation
        ' 
        cbOperation.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cbOperation.FormattingEnabled = True
        cbOperation.Location = New Point(36, 236)
        cbOperation.Name = "cbOperation"
        cbOperation.Size = New Size(294, 26)
        cbOperation.TabIndex = 38
        ' 
        ' cbDoctor
        ' 
        cbDoctor.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cbDoctor.FormattingEnabled = True
        cbDoctor.Location = New Point(36, 154)
        cbDoctor.Name = "cbDoctor"
        cbDoctor.Size = New Size(294, 28)
        cbDoctor.TabIndex = 37
        ' 
        ' dateTreatment
        ' 
        dateTreatment.CalendarFont = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dateTreatment.CustomFormat = "yyyy/MM/dd"
        dateTreatment.Format = DateTimePickerFormat.Custom
        dateTreatment.Location = New Point(36, 326)
        dateTreatment.Name = "dateTreatment"
        dateTreatment.Size = New Size(294, 29)
        dateTreatment.TabIndex = 39
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(-15, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(394, 61)
        Panel1.TabIndex = 40
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(29, 22)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(170, 25)
        Label6.TabIndex = 41
        Label6.Text = "Edit Appointment"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.MistyRose
        Button1.Location = New Point(241, 375)
        Button1.Name = "Button1"
        Button1.Size = New Size(89, 36)
        Button1.TabIndex = 41
        Button1.Text = "Update"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' formEditAppointment
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Snow
        ClientSize = New Size(371, 443)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(cbOperation)
        Controls.Add(dateTreatment)
        Controls.Add(cbDoctor)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(lblName)
        Controls.Add(Label1)
        Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(4)
        Name = "formEditAppointment"
        StartPosition = FormStartPosition.CenterScreen
        Text = "formEditAppointment"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cbOperation As ComboBox
    Friend WithEvents cbDoctor As ComboBox
    Friend WithEvents dateTreatment As DateTimePicker
End Class
