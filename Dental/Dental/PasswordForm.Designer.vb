<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordForm
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
        txtPassword = New TextBox()
        Label1 = New Label()
        btnSubmit = New Button()
        SuspendLayout()
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(14, 76)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(253, 25)
        txtPassword.TabIndex = 0
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(42, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 17)
        Label1.TabIndex = 1
        Label1.Text = "Enter Dentist Mode Password:"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnSubmit.Location = New Point(69, 117)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(138, 34)
        btnSubmit.TabIndex = 2
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' PasswordForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Snow
        ClientSize = New Size(282, 260)
        Controls.Add(btnSubmit)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "PasswordForm"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmit As Button
End Class
