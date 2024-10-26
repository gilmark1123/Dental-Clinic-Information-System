Imports System.Runtime.InteropServices.JavaScript.JSType
Imports MySql.Data.MySqlClient

Public Class formAddAppointments
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub formAddAppointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ComboBox1.AutoCompleteMode = AutoCompleteMode.Suggest
        ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
        Try
            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()
            Dim query As String = "SELECT first FROM account ORDER BY first ;"
            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read
                        Dim fName = reader.GetString("first")
                        ComboBox1.Items.Add(fName)
                    End While
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ComboBox2.Items.Clear()
        ComboBox2.AutoCompleteMode = AutoCompleteMode.Suggest
        ComboBox2.AutoCompleteSource = AutoCompleteSource.ListItems
        Try
            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()
            Dim query As String = "SELECT first FROM account WHERE doctorMode IS NOT NULL ORDER BY first;"
            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read
                        Dim fNameDentist = reader.GetString("first")
                        ComboBox2.Items.Add(fNameDentist)
                    End While
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            If Not ComboBox1.Items.Contains(ComboBox1.SelectedItem) Or
                Not ComboBox2.Items.Contains(ComboBox2.SelectedItem) Then

                MessageBox.Show("Please select valid values from the drop-downs.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Return
            End If
            If ComboBox1.Text.Trim() = "" Or ComboBox2.Text.Trim() = "" Or ComboBox3.Text.Trim() = "" Then
                MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return ' Exit the method or handle the missing values as needed.
            End If
            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()

            Dim insertQuery As String = "INSERT INTO appointment (patients,doctor,operation,appointment_date, status) VALUES (@patient_id,@dentist_id,@operation,@date, @status)"

            Using cmd As New MySqlCommand(insertQuery, connection)
                cmd.Parameters.AddWithValue("@patient_id", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@dentist_id", ComboBox2.Text)
                cmd.Parameters.AddWithValue("@operation", ComboBox3.Text)
                cmd.Parameters.AddWithValue("@date", dateAppointment.Text)

                cmd.Parameters.AddWithValue("@status", "Pending")
                cmd.ExecuteNonQuery()
                Me.Close()
            End Using
        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class