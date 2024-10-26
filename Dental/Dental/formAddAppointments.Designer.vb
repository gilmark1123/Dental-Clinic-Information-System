<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAddAppointments
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
        Button3 = New Button()
        Button2 = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        dateAppointment = New DateTimePicker()
        TabControl1 = New TabControl()
        Appointment = New TabPage()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        TabPage2 = New TabPage()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        Appointment.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.LightPink
        Button3.Location = New Point(273, 337)
        Button3.Name = "Button3"
        Button3.Size = New Size(115, 35)
        Button3.TabIndex = 17
        Button3.Text = "Save"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.AppWorkspace
        Button2.DialogResult = DialogResult.No
        Button2.Location = New Point(152, 337)
        Button2.Name = "Button2"
        Button2.Size = New Size(115, 35)
        Button2.TabIndex = 17
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-20, -12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(505, 88)
        Panel1.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(31, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(281, 45)
        Label1.TabIndex = 0
        Label1.Text = "Add Appointment"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(20, 64)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(368, 29)
        ComboBox1.TabIndex = 31
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(20, 147)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(368, 29)
        ComboBox2.TabIndex = 34
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(21, 290)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(368, 26)
        ComboBox3.TabIndex = 35
        ' 
        ' dateAppointment
        ' 
        dateAppointment.CalendarFont = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dateAppointment.CustomFormat = "yyyy/MM/dd"
        dateAppointment.Format = DateTimePickerFormat.Custom
        dateAppointment.Location = New Point(20, 225)
        dateAppointment.Name = "dateAppointment"
        dateAppointment.Size = New Size(368, 23)
        dateAppointment.TabIndex = 36
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(Appointment)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(22, 91)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(432, 432)
        TabControl1.TabIndex = 37
        ' 
        ' Appointment
        ' 
        Appointment.Controls.Add(Label5)
        Appointment.Controls.Add(Label4)
        Appointment.Controls.Add(Label3)
        Appointment.Controls.Add(Label2)
        Appointment.Controls.Add(Button3)
        Appointment.Controls.Add(ComboBox1)
        Appointment.Controls.Add(ComboBox3)
        Appointment.Controls.Add(Button2)
        Appointment.Controls.Add(dateAppointment)
        Appointment.Controls.Add(ComboBox2)
        Appointment.Location = New Point(4, 24)
        Appointment.Name = "Appointment"
        Appointment.Padding = New Padding(3)
        Appointment.Size = New Size(424, 404)
        Appointment.TabIndex = 0
        Appointment.Text = "Normal Appointment"
        Appointment.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(21, 262)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 25)
        Label5.TabIndex = 41
        Label5.Text = "Treatment"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(21, 197)
        Label4.Name = "Label4"
        Label4.Size = New Size(136, 25)
        Label4.TabIndex = 40
        Label4.Text = "Doctors Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(20, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 25)
        Label3.TabIndex = 39
        Label3.Text = "Doctors Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(20, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 25)
        Label2.TabIndex = 38
        Label2.Text = "Patients Name"
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(424, 404)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' formAddAppointments
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Snow
        ClientSize = New Size(479, 535)
        Controls.Add(TabControl1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "formAddAppointments"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabControl1.ResumeLayout(False)
        Appointment.ResumeLayout(False)
        Appointment.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents dateAppointment As DateTimePicker
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Appointment As TabPage
End Class
