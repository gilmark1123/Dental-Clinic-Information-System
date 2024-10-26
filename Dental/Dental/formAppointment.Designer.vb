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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAppointments = New System.Windows.Forms.Label()
        Me.View = New System.Windows.Forms.DataGridView()
        Me.colPatient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDoctor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOperation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblUpcoming = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(858, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 36)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = " Add Appointment"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 27.75!)
        Me.Label1.Location = New System.Drawing.Point(10, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 50)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Appointments"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(19, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 25)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Todays Appointments:"
        '
        'lblAppointments
        '
        Me.lblAppointments.AutoSize = True
        Me.lblAppointments.BackColor = System.Drawing.Color.White
        Me.lblAppointments.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblAppointments.Location = New System.Drawing.Point(183, 55)
        Me.lblAppointments.Name = "lblAppointments"
        Me.lblAppointments.Size = New System.Drawing.Size(32, 25)
        Me.lblAppointments.TabIndex = 25
        Me.lblAppointments.Text = "00"
        '
        'View
        '
        Me.View.AllowDrop = True
        Me.View.AllowUserToAddRows = False
        Me.View.AllowUserToDeleteRows = False
        Me.View.AllowUserToResizeColumns = False
        Me.View.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.View.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.View.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.View.BackgroundColor = System.Drawing.Color.Snow
        Me.View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.View.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPatient, Me.colDoctor, Me.colOperation, Me.colDate, Me.colStatus, Me.colEdit, Me.colDelete, Me.colID})
        Me.View.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.View.Location = New System.Drawing.Point(33, 123)
        Me.View.Name = "View"
        Me.View.ReadOnly = True
        Me.View.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.View.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.View.RowHeadersVisible = False
        Me.View.RowHeadersWidth = 51
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.View.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.View.RowTemplate.Height = 25
        Me.View.RowTemplate.ReadOnly = True
        Me.View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.View.Size = New System.Drawing.Size(956, 427)
        Me.View.StandardTab = True
        Me.View.TabIndex = 32
        '
        'colPatient
        '
        Me.colPatient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPatient.HeaderText = "Patient"
        Me.colPatient.MinimumWidth = 6
        Me.colPatient.Name = "colPatient"
        Me.colPatient.ReadOnly = True
        '
        'colDoctor
        '
        Me.colDoctor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDoctor.HeaderText = "Doctor"
        Me.colDoctor.MinimumWidth = 6
        Me.colDoctor.Name = "colDoctor"
        Me.colDoctor.ReadOnly = True
        '
        'colOperation
        '
        Me.colOperation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colOperation.HeaderText = "Operation"
        Me.colOperation.MinimumWidth = 6
        Me.colOperation.Name = "colOperation"
        Me.colOperation.ReadOnly = True
        '
        'colDate
        '
        Me.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDate.HeaderText = "Date"
        Me.colDate.MinimumWidth = 6
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        Me.colStatus.Width = 159
        '
        'colEdit
        '
        Me.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEdit.HeaderText = "Edit"
        Me.colEdit.Name = "colEdit"
        Me.colEdit.ReadOnly = True
        Me.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colDelete
        '
        Me.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDelete.HeaderText = "Delete"
        Me.colDelete.MinimumWidth = 6
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        Me.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colID
        '
        Me.colID.FillWeight = 5.0!
        Me.colID.HeaderText = "a"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colID.Visible = False
        Me.colID.Width = 5
        '
        'lblUpcoming
        '
        Me.lblUpcoming.AutoSize = True
        Me.lblUpcoming.BackColor = System.Drawing.Color.White
        Me.lblUpcoming.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblUpcoming.Location = New System.Drawing.Point(405, 55)
        Me.lblUpcoming.Name = "lblUpcoming"
        Me.lblUpcoming.Size = New System.Drawing.Size(32, 25)
        Me.lblUpcoming.TabIndex = 35
        Me.lblUpcoming.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(215, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 25)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Upcoming Appointments:"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.LightPink
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(33, 81)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(956, 42)
        Me.Panel3.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(18, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 25)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Appointment List"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(188, 129)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(473, 290)
        Me.Chart1.TabIndex = 38
        Me.Chart1.Text = "Chart1"
        '
        'formAppointments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(1040, 575)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.lblUpcoming)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.View)
        Me.Controls.Add(Me.lblAppointments)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formAppointments"
        Me.Text = "formAppointments"
        CType(Me.View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
