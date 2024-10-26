<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPatients
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
        Panel3 = New Panel()
        Label7 = New Label()
        Button1 = New Button()
        Label1 = New Label()
        View = New DataGridView()
        colFirstName = New DataGridViewTextBoxColumn()
        colAddress = New DataGridViewTextBoxColumn()
        colSex = New DataGridViewTextBoxColumn()
        colContactNumber = New DataGridViewTextBoxColumn()
        colPatientID = New DataGridViewTextBoxColumn()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        ComboBox1 = New ComboBox()
        Button3 = New Button()
        Label4 = New Label()
        lblCount = New Label()
        Label2 = New Label()
        ComboBox2 = New ComboBox()
        Panel3.SuspendLayout()
        CType(View, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.MistyRose
        Panel3.Controls.Add(Label7)
        Panel3.Location = New Point(38, 127)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1019, 49)
        Panel3.TabIndex = 30
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(8, 11)
        Label7.Name = "Label7"
        Label7.Size = New Size(103, 25)
        Label7.TabIndex = 22
        Label7.Text = "Patient List"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = SystemColors.ControlLightLight
        Button1.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(1015, 68)
        Button1.Name = "Button1"
        Button1.Size = New Size(37, 39)
        Button1.TabIndex = 26
        Button1.Text = "+"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AllowDrop = True
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 50)
        Label1.TabIndex = 25
        Label1.Text = "Patients"
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
        View.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        View.BackgroundColor = Color.Snow
        View.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical
        View.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        View.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        View.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        View.Columns.AddRange(New DataGridViewColumn() {colFirstName, colAddress, colSex, colContactNumber, colPatientID})
        View.EditMode = DataGridViewEditMode.EditOnKeystroke
        View.Location = New Point(38, 169)
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
        View.Size = New Size(1019, 493)
        View.StandardTab = True
        View.TabIndex = 31
        ' 
        ' colFirstName
        ' 
        colFirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colFirstName.FillWeight = 12.1827393F
        colFirstName.HeaderText = "Name"
        colFirstName.MinimumWidth = 6
        colFirstName.Name = "colFirstName"
        colFirstName.ReadOnly = True
        ' 
        ' colAddress
        ' 
        colAddress.FillWeight = 363.451782F
        colAddress.HeaderText = "Address"
        colAddress.MinimumWidth = 6
        colAddress.Name = "colAddress"
        colAddress.ReadOnly = True
        colAddress.Width = 380
        ' 
        ' colSex
        ' 
        colSex.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colSex.FillWeight = 12.1827393F
        colSex.HeaderText = "Sex"
        colSex.MinimumWidth = 6
        colSex.Name = "colSex"
        colSex.ReadOnly = True
        ' 
        ' colContactNumber
        ' 
        colContactNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colContactNumber.FillWeight = 12.1827393F
        colContactNumber.HeaderText = "Contact Number"
        colContactNumber.MinimumWidth = 6
        colContactNumber.Name = "colContactNumber"
        colContactNumber.ReadOnly = True
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
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ComboBox1.AutoCompleteMode = AutoCompleteMode.Suggest
        ComboBox1.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(688, 73)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(240, 26)
        ComboBox1.TabIndex = 32
        ComboBox1.Tag = ""
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(934, 76)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 33
        Button3.Text = "Search"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(196, 71)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 22)
        Label4.TabIndex = 45
        Label4.Text = "Sort By:"
        ' 
        ' lblCount
        ' 
        lblCount.AutoSize = True
        lblCount.BackColor = Color.MistyRose
        lblCount.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblCount.Location = New Point(158, 71)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(32, 25)
        lblCount.TabIndex = 44
        lblCount.Text = "00"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(31, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 25)
        Label2.TabIndex = 43
        Label2.Text = "Total Patients: "
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Name", "Date"})
        ComboBox2.Location = New Point(281, 69)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(177, 28)
        ComboBox2.TabIndex = 47
        ' 
        ' formPatients
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1092, 688)
        Controls.Add(ComboBox2)
        Controls.Add(Label4)
        Controls.Add(lblCount)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(ComboBox1)
        Controls.Add(View)
        Controls.Add(Panel3)
        Controls.Add(Button1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "formPatients"
        ShowInTaskbar = False
        Text = "formPatients"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(View, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents View As DataGridView
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents TextBox1 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents colFirstName As DataGridViewTextBoxColumn
    Friend WithEvents colAddress As DataGridViewTextBoxColumn
    Friend WithEvents colSex As DataGridViewTextBoxColumn
    Friend WithEvents colContactNumber As DataGridViewTextBoxColumn
    Friend WithEvents colPatientID As DataGridViewTextBoxColumn
End Class
