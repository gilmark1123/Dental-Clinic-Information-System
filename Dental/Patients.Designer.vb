<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patients
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
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        lblCount = New Label()
        Label4 = New Label()
        ComboBox2 = New ComboBox()
        CType(View, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(1054, 66)
        Button3.Name = "Button3"
        Button3.Size = New Size(65, 31)
        Button3.TabIndex = 39
        Button3.Text = "Search"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ComboBox1.AutoCompleteMode = AutoCompleteMode.Suggest
        ComboBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(807, 66)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(240, 29)
        ComboBox1.TabIndex = 38
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
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        View.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        View.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        View.BackgroundColor = Color.Snow
        View.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical
        View.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.LavenderBlush
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.MistyRose
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        View.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        View.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        View.Columns.AddRange(New DataGridViewColumn() {colFirstName, colAddress, colSex, colContactNumber, colPatientID})
        View.EditMode = DataGridViewEditMode.EditOnKeystroke
        View.GridColor = Color.Snow
        View.Location = New Point(58, 156)
        View.Name = "View"
        View.ReadOnly = True
        View.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.LavenderBlush
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        View.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        View.RowHeadersWidth = 51
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        View.RowsDefaultCellStyle = DataGridViewCellStyle4
        View.RowTemplate.Height = 25
        View.RowTemplate.ReadOnly = True
        View.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        View.Size = New Size(1129, 475)
        View.StandardTab = True
        View.TabIndex = 37
        ' 
        ' colFirstName
        ' 
        colFirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colFirstName.HeaderText = "Name"
        colFirstName.MinimumWidth = 330
        colFirstName.Name = "colFirstName"
        colFirstName.ReadOnly = True
        ' 
        ' colAddress
        ' 
        colAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colAddress.HeaderText = "Address"
        colAddress.MinimumWidth = 370
        colAddress.Name = "colAddress"
        colAddress.ReadOnly = True
        ' 
        ' colSex
        ' 
        colSex.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colSex.HeaderText = "Sex"
        colSex.MinimumWidth = 200
        colSex.Name = "colSex"
        colSex.ReadOnly = True
        ' 
        ' colContactNumber
        ' 
        colContactNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colContactNumber.HeaderText = "Contact Number"
        colContactNumber.MinimumWidth = 180
        colContactNumber.Name = "colContactNumber"
        colContactNumber.ReadOnly = True
        ' 
        ' colPatientID
        ' 
        colPatientID.HeaderText = "ID"
        colPatientID.MinimumWidth = 6
        colPatientID.Name = "colPatientID"
        colPatientID.ReadOnly = True
        colPatientID.Width = 6
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.LightPink
        Panel3.Controls.Add(Label7)
        Panel3.Location = New Point(58, 109)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1129, 49)
        Panel3.TabIndex = 36
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(21, 11)
        Label7.Name = "Label7"
        Label7.Size = New Size(103, 25)
        Label7.TabIndex = 22
        Label7.Text = "Patient List"
        ' 
        ' Label1
        ' 
        Label1.AllowDrop = True
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 50)
        Label1.TabIndex = 34
        Label1.Text = "Patients"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = SystemColors.ControlLightLight
        Button1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(1124, 60)
        Button1.Name = "Button1"
        Button1.Size = New Size(44, 37)
        Button1.TabIndex = 35
        Button1.Text = "+"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(30, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 25)
        Label2.TabIndex = 23
        Label2.Text = "Total Patients: "
        ' 
        ' lblCount
        ' 
        lblCount.AutoSize = True
        lblCount.BackColor = Color.White
        lblCount.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblCount.Location = New Point(158, 67)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(32, 25)
        lblCount.TabIndex = 40
        lblCount.Text = "00"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(202, 68)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 22)
        Label4.TabIndex = 41
        Label4.Text = "Sort By:"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Name", "Date"})
        ComboBox2.Location = New Point(281, 66)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(177, 28)
        ComboBox2.TabIndex = 48
        ' 
        ' Patients
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(1213, 663)
        Controls.Add(ComboBox2)
        Controls.Add(Label4)
        Controls.Add(lblCount)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(ComboBox1)
        Controls.Add(View)
        Controls.Add(Panel3)
        Controls.Add(Label1)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Patients"
        CType(View, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents View As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents colFirstName As DataGridViewTextBoxColumn
    Friend WithEvents colAddress As DataGridViewTextBoxColumn
    Friend WithEvents colSex As DataGridViewTextBoxColumn
    Friend WithEvents colContactNumber As DataGridViewTextBoxColumn
    Friend WithEvents colPatientID As DataGridViewTextBoxColumn
End Class
