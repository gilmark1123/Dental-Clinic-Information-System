Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class Patients

    Private WithEvents capture As frmMemApplication



    ' Constructor to initialize the reference

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formHome.DisableFormHome()
        ' Initialize the new form
        capture = New frmMemApplication()
        AddHandler capture.FormClosed, AddressOf capture_FormClosed
        ' Show the new form
        capture.Show()
    End Sub

    Private Sub capture_FormClosed(sender As Object, e As FormClosedEventArgs)
        formHome.EnableFormHome()
        Me.Refresh()
        ' Clean up the event handler
        RemoveHandler capture.FormClosed, AddressOf capture_FormClosed
        capture.Dispose()
        formHome.CallBtnPatientsClick()
    End Sub


    Public Sub Patients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox2.SelectedIndex = ComboBox2.FindStringExact("Name")
        ComboBox1.Items.Clear()
        ComboBox1.AutoCompleteMode = AutoCompleteMode.Suggest
        ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
        View.CellBorderStyle = DataGridViewCellBorderStyle.None

        ' Set the font and style for the headers
        Dim headerStyle As New DataGridViewCellStyle()
        headerStyle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        View.ColumnHeadersDefaultCellStyle = headerStyle

        ' Set various cell styling attributes
        View.DefaultCellStyle.WrapMode = DataGridViewTriState.True ' Optional: Wrap text if needed
        View.DefaultCellStyle.BackColor = Color.White ' Set the background color for cells
        View.DefaultCellStyle.ForeColor = Color.Black ' Set the text color for cells
        View.DefaultCellStyle.SelectionBackColor = Color.LightPink ' Set the background color for selected cells
        View.DefaultCellStyle.SelectionForeColor = Color.White ' Set the text color for selected cells

        ' Hide row headers
        View.RowHeadersVisible = False
        Try
            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()
            Dim query As String = "SELECT first_name_patients FROM patients ORDER BY first_name_patients;"
            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read
                        Dim fName = reader.GetString("first_name_patients")
                        ComboBox1.Items.Add(fName)
                    End While
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        View.Rows.Clear()
        Dim searched As String = ComboBox1.Text

        Try
            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()
            Dim query As String = "SELECT * FROM patients WHERE first_name_patients='" & searched & "';"
            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim province As String = reader("province").ToString()
                        Dim city As String = reader("city").ToString()
                        Dim baranggay As String = reader("baranggay").ToString()
                        Dim houseNumber As String = reader("house_number").ToString()

                        ' Combine values into an address format
                        Dim address As String = $"{houseNumber}, {baranggay}, {city}, {province}"
                        Dim rowIndex As Integer = View.Rows.Add()
                        View.Rows(rowIndex).Cells("colPatientID").Value = reader("idpatients")
                        View.Rows(rowIndex).Cells("colFirstName").Value = reader("first_name_patients")
                        View.Rows(rowIndex).Cells("colAddress").Value = address
                        View.Rows(rowIndex).Cells("colSex").Value = reader("sex_patients")
                        View.Rows(rowIndex).Cells("colContactNumber").Value = reader("contact_number_patients")
                    End While
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem IsNot Nothing AndAlso ComboBox2.SelectedItem.ToString() = "Name" Then
            View.Rows.Clear()

            Try
                DatabaseManager.OpenConnection()
                Dim connection As MySqlConnection = DatabaseManager.GetConnection()

                ' Your database query code here
                ' Example: Insert data into the database

                Dim query As String = "SELECT * FROM patients ORDER BY first_name_patients;"

                Using cmd As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim province As String = reader("province").ToString()
                            Dim city As String = reader("city").ToString()
                            Dim baranggay As String = reader("baranggay").ToString()
                            Dim houseNumber As String = reader("house_number").ToString()

                            ' Combine values into an address format
                            Dim address As String = $"{houseNumber}, {baranggay}, {city}, {province}"
                            Dim rowIndex As Integer = View.Rows.Add()
                            View.Rows(rowIndex).Cells("colPatientID").Value = reader("idpatients")
                            View.Rows(rowIndex).Cells("colFirstName").Value = reader("first_name_patients")
                            View.Rows(rowIndex).Cells("colAddress").Value = address
                            View.Rows(rowIndex).Cells("colSex").Value = reader("sex_patients")
                            View.Rows(rowIndex).Cells("colContactNumber").Value = reader("contact_number_patients")
                        End While
                    End Using
                End Using


            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If ComboBox2.SelectedItem IsNot Nothing AndAlso ComboBox2.SelectedItem.ToString() = "Date" Then
            View.Rows.Clear()
            Try
                DatabaseManager.OpenConnection()
                Dim connection As MySqlConnection = DatabaseManager.GetConnection()

                ' Your database query code here
                ' Example: Insert data into the database

                Dim query As String = "SELECT * FROM patients ORDER BY date_registered DESC;"

                Using cmd As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim province As String = reader("province").ToString()
                            Dim city As String = reader("city").ToString()
                            Dim baranggay As String = reader("baranggay").ToString()
                            Dim houseNumber As String = reader("house_number").ToString()

                            ' Combine values into an address format
                            Dim address As String = $"{houseNumber}, {baranggay}, {city}, {province}"
                            Dim rowIndex As Integer = View.Rows.Add()
                            View.Rows(rowIndex).Cells("colPatientID").Value = reader("idpatients")
                            View.Rows(rowIndex).Cells("colFirstName").Value = reader("first_name_patients")
                            View.Rows(rowIndex).Cells("colAddress").Value = address
                            View.Rows(rowIndex).Cells("colSex").Value = reader("sex_patients")
                            View.Rows(rowIndex).Cells("colContactNumber").Value = reader("contact_number_patients")
                        End While
                    End Using
                End Using



            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        Dim rowCount As Integer = 0

        For Each row As DataGridViewRow In View.Rows
            ' Check if the cell in the specified column is not null or empty
            If Not row.Cells("colPatientID").Value Is Nothing AndAlso Not String.IsNullOrEmpty(row.Cells("colPatientID").Value.ToString()) Then
                rowCount += 1
            End If
        Next

        ' Set the value of lblCount to the count
        lblCount.Text = rowCount.ToString()
    End Sub

    Private Sub View_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles View.CellContentClick

    End Sub
End Class