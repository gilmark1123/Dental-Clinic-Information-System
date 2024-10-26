<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEmployee
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
        Label1 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        PictureBox2 = New PictureBox()
        TableLayoutPanel5 = New TableLayoutPanel()
        Button3 = New Button()
        ComboBox1 = New ComboBox()
        View = New DataGridView()
        colFirstName = New DataGridViewTextBoxColumn()
        colAddress = New DataGridViewTextBoxColumn()
        colSex = New DataGridViewTextBoxColumn()
        colContactNumber = New DataGridViewTextBoxColumn()
        colPatientID = New DataGridViewTextBoxColumn()
        Panel3 = New Panel()
        Label7 = New Label()
        Label2 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(View, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(10, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 50)
        Label1.TabIndex = 40
        Label1.Text = "Dentist"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.Snow
        TableLayoutPanel2.ColumnCount = 5
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 17.48634F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 82.5136642F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 233F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 219F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 211F))
        TableLayoutPanel2.Location = New Point(-2, -9)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(200, 100)
        TableLayoutPanel2.TabIndex = 36
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.profile_user_64572
        PictureBox2.Location = New Point(1, -6)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1, 52)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 38
        PictureBox2.TabStop = False
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.BackColor = Color.Snow
        TableLayoutPanel5.ColumnCount = 5
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 17.48634F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 82.5136642F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 233F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 219F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel5.Location = New Point(0, 0)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel5.Size = New Size(200, 100)
        TableLayoutPanel5.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(975, 52)
        Button3.Name = "Button3"
        Button3.Size = New Size(77, 30)
        Button3.TabIndex = 40
        Button3.Text = "Search"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ComboBox1.AutoCompleteMode = AutoCompleteMode.Suggest
        ComboBox1.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(729, 54)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(240, 26)
        ComboBox1.TabIndex = 39
        ComboBox1.Tag = ""
        ' 
        ' View
        ' 
        View.AllowDrop = True
        View.AllowUserToAddRows = False
        View.AllowUserToDeleteRows = False
        View.AllowUserToResizeColumns = False
        View.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point)
        View.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        View.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        View.BackgroundColor = Color.Snow
        View.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical
        View.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        View.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        View.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        View.Columns.AddRange(New DataGridViewColumn() {colFirstName, colAddress, colSex, colContactNumber, colPatientID})
        View.EditMode = DataGridViewEditMode.EditOnKeystroke
        View.Location = New Point(25, 139)
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
        View.RowHeadersWidth = 51
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point)
        View.RowsDefaultCellStyle = DataGridViewCellStyle4
        View.RowTemplate.Height = 25
        View.RowTemplate.ReadOnly = True
        View.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        View.Size = New Size(1027, 480)
        View.StandardTab = True
        View.TabIndex = 38
        ' 
        ' colFirstName
        ' 
        colFirstName.HeaderText = "Name"
        colFirstName.MinimumWidth = 6
        colFirstName.Name = "colFirstName"
        colFirstName.ReadOnly = True
        colFirstName.Width = 250
        ' 
        ' colAddress
        ' 
        colAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colAddress.HeaderText = "Address"
        colAddress.MinimumWidth = 6
        colAddress.Name = "colAddress"
        colAddress.ReadOnly = True
        ' 
        ' colSex
        ' 
        colSex.HeaderText = "Sex"
        colSex.MinimumWidth = 6
        colSex.Name = "colSex"
        colSex.ReadOnly = True
        ' 
        ' colContactNumber
        ' 
        colContactNumber.HeaderText = "Contact Number"
        colContactNumber.MinimumWidth = 6
        colContactNumber.Name = "colContactNumber"
        colContactNumber.ReadOnly = True
        colContactNumber.Width = 230
        ' 
        ' colPatientID
        ' 
        colPatientID.HeaderText = "ID"
        colPatientID.MinimumWidth = 6
        colPatientID.Name = "colPatientID"
        colPatientID.ReadOnly = True
        colPatientID.Visible = False
        colPatientID.Width = 6
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.MistyRose
        Panel3.Controls.Add(Label7)
        Panel3.Location = New Point(25, 90)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1027, 49)
        Panel3.TabIndex = 37
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(8, 14)
        Label7.Name = "Label7"
        Label7.Size = New Size(127, 25)
        Label7.TabIndex = 22
        Label7.Text = "Employee List"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(182, 50)
        Label2.TabIndex = 36
        Label2.Text = "Employee"
        ' 
        ' formEmployee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1076, 649)
        Controls.Add(Button3)
        Controls.Add(ComboBox1)
        Controls.Add(View)
        Controls.Add(Panel3)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.None
        Name = "formEmployee"
        Text = "formEmployee"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(View, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents View As DataGridView
    Friend WithEvents colFirstName As DataGridViewTextBoxColumn
    Friend WithEvents colAddress As DataGridViewTextBoxColumn
    Friend WithEvents colSex As DataGridViewTextBoxColumn
    Friend WithEvents colContactNumber As DataGridViewTextBoxColumn
    Friend WithEvents colPatientID As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
End Class
