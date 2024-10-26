<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAppointments
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Button1 = New Button()
        Label1 = New Label()
        Label3 = New Label()
        lblAppointments = New Label()
        View = New DataGridView()
        colPatient = New DataGridViewTextBoxColumn()
        colDoctor = New DataGridViewTextBoxColumn()
        colOperation = New DataGridViewTextBoxColumn()
        colDate = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colEdit = New DataGridViewButtonColumn()
        colDelete = New DataGridViewButtonColumn()
        colID = New DataGridViewTextBoxColumn()
        lblUpcoming = New Label()
        Label4 = New Label()
        Panel3 = New Panel()
        Label7 = New Label()
        CType(View, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = SystemColors.ControlLightLight
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(1001, 46)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 42)
        Button1.TabIndex = 19
        Button1.Text = " Add Appointment"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(256, 50)
        Label1.TabIndex = 16
        Label1.Text = "Appointments"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(22, 62)
        Label3.Name = "Label3"
        Label3.Size = New Size(196, 25)
        Label3.TabIndex = 23
        Label3.Text = "Todays Appointments:"
        ' 
        ' lblAppointments
        ' 
        lblAppointments.AutoSize = True
        lblAppointments.BackColor = Color.White
        lblAppointments.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblAppointments.Location = New Point(213, 63)
        lblAppointments.Name = "lblAppointments"
        lblAppointments.Size = New Size(32, 25)
        lblAppointments.TabIndex = 25
        lblAppointments.Text = "00"
        ' 
        ' View
        ' 
        View.AllowDrop = True
        View.AllowUserToAddRows = False
        View.AllowUserToDeleteRows = False
        View.AllowUserToResizeColumns = False
        View.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        View.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        View.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        View.BackgroundColor = Color.Snow
        View.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical
        View.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        View.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        View.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        View.Columns.AddRange(New DataGridViewColumn() {colPatient, colDoctor, colOperation, colDate, colStatus, colEdit, colDelete, colID})
        View.EditMode = DataGridViewEditMode.EditOnKeystroke
        View.Location = New Point(39, 142)
        View.Name = "View"
        View.ReadOnly = True
        View.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        View.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        View.RowHeadersVisible = False
        View.RowHeadersWidth = 51
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point)
        View.RowsDefaultCellStyle = DataGridViewCellStyle4
        View.RowTemplate.Height = 25
        View.RowTemplate.ReadOnly = True
        View.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        View.Size = New Size(1115, 493)
        View.StandardTab = True
        View.TabIndex = 32
        ' 
        ' colPatient
        ' 
        colPatient.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colPatient.HeaderText = "Patient"
        colPatient.MinimumWidth = 6
        colPatient.Name = "colPatient"
        colPatient.ReadOnly = True
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
        colOperation.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colOperation.HeaderText = "Operation"
        colOperation.MinimumWidth = 6
        colOperation.Name = "colOperation"
        colOperation.ReadOnly = True
        ' 
        ' colDate
        ' 
        colDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colDate.HeaderText = "Date"
        colDate.MinimumWidth = 6
        colDate.Name = "colDate"
        colDate.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        colStatus.Width = 159
        ' 
        ' colEdit
        ' 
        colEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colEdit.HeaderText = "Edit"
        colEdit.Name = "colEdit"
        colEdit.ReadOnly = True
        colEdit.Resizable = DataGridViewTriState.True
        colEdit.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' colDelete
        ' 
        colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colDelete.HeaderText = "Delete"
        colDelete.MinimumWidth = 6
        colDelete.Name = "colDelete"
        colDelete.ReadOnly = True
        colDelete.Resizable = DataGridViewTriState.True
        colDelete.SortMode = DataGridViewColumnSortMode.Automatic
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
        ' lblUpcoming
        ' 
        lblUpcoming.AutoSize = True
        lblUpcoming.BackColor = Color.White
        lblUpcoming.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblUpcoming.Location = New Point(472, 63)
        lblUpcoming.Name = "lblUpcoming"
        lblUpcoming.Size = New Size(32, 25)
        lblUpcoming.TabIndex = 35
        lblUpcoming.Text = "00"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(251, 62)
        Label4.Name = "Label4"
        Label4.Size = New Size(226, 25)
        Label4.TabIndex = 34
        Label4.Text = "Upcoming Appointments:"
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.LightPink
        Panel3.Controls.Add(Label7)
        Panel3.Location = New Point(39, 94)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1115, 49)
        Panel3.TabIndex = 37
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
        ' formAppointments
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(1213, 663)
        Controls.Add(lblUpcoming)
        Controls.Add(Label4)
        Controls.Add(View)
        Controls.Add(lblAppointments)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.None
        Name = "formAppointments"
        Text = "formAppointments"
        CType(View, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAppointments As Label
    Friend WithEvents View As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents lblUpcoming As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents colPatient As DataGridViewTextBoxColumn
    Friend WithEvents colDoctor As DataGridViewTextBoxColumn
    Friend WithEvents colOperation As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colEdit As DataGridViewButtonColumn
    Friend WithEvents colDelete As DataGridViewButtonColumn
    Friend WithEvents colID As DataGridViewTextBoxColumn
End Class
