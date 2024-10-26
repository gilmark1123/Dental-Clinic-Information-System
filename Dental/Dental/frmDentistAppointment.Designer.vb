<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDentistAppointment
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
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label7 = New Label()
        lblUpcoming = New Label()
        Label4 = New Label()
        Panel3 = New Panel()
        View = New DataGridView()
        colPatient = New DataGridViewTextBoxColumn()
        colDoctor = New DataGridViewTextBoxColumn()
        colOperation = New DataGridViewTextBoxColumn()
        colDate = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colEdit = New DataGridViewButtonColumn()
        colDelete = New DataGridViewButtonColumn()
        colID = New DataGridViewTextBoxColumn()
        lblAppointments = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        Panel3.SuspendLayout()
        CType(View, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(21, 11)
        Label7.Name = "Label7"
        Label7.Size = New Size(155, 25)
        Label7.TabIndex = 22
        Label7.Text = "Appointment List"
        ' 
        ' lblUpcoming
        ' 
        lblUpcoming.AutoSize = True
        lblUpcoming.BackColor = Color.MistyRose
        lblUpcoming.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblUpcoming.Location = New Point(476, 65)
        lblUpcoming.Name = "lblUpcoming"
        lblUpcoming.Size = New Size(32, 25)
        lblUpcoming.TabIndex = 44
        lblUpcoming.Text = "00"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(255, 64)
        Label4.Name = "Label4"
        Label4.Size = New Size(226, 25)
        Label4.TabIndex = 43
        Label4.Text = "Upcoming Appointments:"
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.MistyRose
        Panel3.Controls.Add(Label7)
        Panel3.Location = New Point(31, 113)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1024, 49)
        Panel3.TabIndex = 45
        ' 
        ' View
        ' 
        View.AllowDrop = True
        View.AllowUserToAddRows = False
        View.AllowUserToDeleteRows = False
        View.AllowUserToResizeColumns = False
        View.AllowUserToResizeRows = False
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        View.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        View.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        View.BackgroundColor = Color.Snow
        View.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical
        View.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = SystemColors.Control
        DataGridViewCellStyle10.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle10.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = DataGridViewTriState.True
        View.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        View.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        View.Columns.AddRange(New DataGridViewColumn() {colPatient, colDoctor, colOperation, colDate, colStatus, colEdit, colDelete, colID})
        View.EditMode = DataGridViewEditMode.EditOnKeystroke
        View.Location = New Point(31, 162)
        View.Name = "View"
        View.ReadOnly = True
        View.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = SystemColors.Control
        DataGridViewCellStyle11.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle11.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True
        View.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        View.RowHeadersVisible = False
        View.RowHeadersWidth = 51
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point)
        View.RowsDefaultCellStyle = DataGridViewCellStyle12
        View.RowTemplate.Height = 25
        View.RowTemplate.ReadOnly = True
        View.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        View.Size = New Size(1024, 466)
        View.StandardTab = True
        View.TabIndex = 42
        ' 
        ' colPatient
        ' 
        colPatient.HeaderText = "Patient"
        colPatient.MinimumWidth = 6
        colPatient.Name = "colPatient"
        colPatient.ReadOnly = True
        colPatient.Width = 250
        ' 
        ' colDoctor
        ' 
        colDoctor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colDoctor.HeaderText = "Doctor"
        colDoctor.MinimumWidth = 6
        colDoctor.Name = "colDoctor"
        colDoctor.ReadOnly = True
        ' 
        ' colOperation
        ' 
        colOperation.HeaderText = "Operation"
        colOperation.MinimumWidth = 6
        colOperation.Name = "colOperation"
        colOperation.ReadOnly = True
        colOperation.Width = 150
        ' 
        ' colDate
        ' 
        colDate.HeaderText = "Date"
        colDate.MinimumWidth = 6
        colDate.Name = "colDate"
        colDate.ReadOnly = True
        colDate.Width = 150
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' colEdit
        ' 
        colEdit.HeaderText = "Edit"
        colEdit.Name = "colEdit"
        colEdit.ReadOnly = True
        colEdit.Resizable = DataGridViewTriState.True
        colEdit.SortMode = DataGridViewColumnSortMode.Automatic
        colEdit.Width = 80
        ' 
        ' colDelete
        ' 
        colDelete.HeaderText = "Delete"
        colDelete.MinimumWidth = 6
        colDelete.Name = "colDelete"
        colDelete.ReadOnly = True
        colDelete.Resizable = DataGridViewTriState.True
        colDelete.SortMode = DataGridViewColumnSortMode.Automatic
        colDelete.Width = 80
        ' 
        ' colID
        ' 
        colID.FillWeight = 5F
        colID.HeaderText = "a"
        colID.Name = "colID"
        colID.ReadOnly = True
        colID.Resizable = DataGridViewTriState.False
        colID.Visible = False
        colID.Width = 5
        ' 
        ' lblAppointments
        ' 
        lblAppointments.AutoSize = True
        lblAppointments.BackColor = Color.MistyRose
        lblAppointments.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblAppointments.Location = New Point(217, 65)
        lblAppointments.Name = "lblAppointments"
        lblAppointments.Size = New Size(32, 25)
        lblAppointments.TabIndex = 41
        lblAppointments.Text = "00"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(26, 64)
        Label3.Name = "Label3"
        Label3.Size = New Size(196, 25)
        Label3.TabIndex = 40
        Label3.Text = "Todays Appointments:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(256, 50)
        Label1.TabIndex = 38
        Label1.Text = "Appointments"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = SystemColors.ControlLightLight
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(897, 62)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 42)
        Button1.TabIndex = 39
        Button1.Text = "Add Appointment"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' frmDentistAppointment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1076, 649)
        Controls.Add(lblUpcoming)
        Controls.Add(Label4)
        Controls.Add(Panel3)
        Controls.Add(View)
        Controls.Add(lblAppointments)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "frmDentistAppointment"
        Text = "frmDentistAppointment"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(View, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents lblUpcoming As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents View As DataGridView
    Friend WithEvents lblAppointments As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents colPatient As DataGridViewTextBoxColumn
    Friend WithEvents colDoctor As DataGridViewTextBoxColumn
    Friend WithEvents colOperation As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colEdit As DataGridViewButtonColumn
    Friend WithEvents colDelete As DataGridViewButtonColumn
    Friend WithEvents colID As DataGridViewTextBoxColumn
End Class
