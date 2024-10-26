Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Ocsp

Public Class formEditAppointment
    Dim id As String

    Public Sub New(idAppointment As String)

        ' This call is required by the designer.
        InitializeComponent()
        Try
            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()

            ' Your database query code here
            ' Example: Insert data into the database

            Dim query As String = "SELECT * FROM appointment WHERE appointment_id =" & idAppointment & ";"
            id = idAppointment
            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        lblName.Text = reader("patients")
                        cbDoctor.Text = reader("doctor")
                        cbOperation.Text = reader("operation")
                        dateTreatment.Text = reader("appointment_date")
                    End While
                End Using
            End Using
        Catch


        End Try
        Try
            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()
            Dim query As String = "SELECT first_name FROM dentist ORDER BY first_name;"
            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read
                        Dim fNameDentist = reader.GetString("first_name")
                        cbDoctor.Items.Add(fNameDentist)
                    End While
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If cbDoctor.Text.Trim() = "" Or cbOperation.Text.Trim() = "" Or dateTreatment.Text.Trim() = "" Then
                MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return ' Exit the method or handle the missing values as needed.
            End If

            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()

            ' Updated query with corrected parameter names and removed single quotes around parameters
            Dim insertQuery As String = "UPDATE appointment SET doctor = @dentist_id, operation = @operation, appointment_date = @date WHERE appointment_id = " & id & ";"

            Using cmd As New MySqlCommand(insertQuery, connection)
                cmd.Parameters.AddWithValue("@dentist_id", cbDoctor.Text)
                cmd.Parameters.AddWithValue("@operation", cbOperation.Text)
                cmd.Parameters.AddWithValue("@date", dateTreatment.Text)

                cmd.ExecuteNonQuery()
                Me.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub formEditAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class