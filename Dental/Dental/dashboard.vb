Imports MySql.Data.MySqlClient
Imports System.IO

Public Class dashboard
    Private imageDirectory As String
    Private imageFiles As String()
    Private currentImageIndex As Integer
    Dim idUserCurrent As Integer
    Private dentistModeInstance As DentistMode
    Public Sub New(idUser As Integer, dentistInstance As DentistMode)
        idUserCurrent = idUser
        InitializeComponent()
        dentistModeInstance = dentistInstance

    End Sub
    Private Sub formDashboard_Load(sender As Object, e As EventArgs)
        Me.HorizontalScroll.Maximum = 0
        Me.AutoScroll = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update the label text with the current time in 12-hour format with AM/PM
        lblTime.Text = DateTime.Now.ToString("hh:mm tt")
        ' Update any other real-time data or calculations
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the interval for the timer in milliseconds (e.g., 1000 ms = 1 second)
        Timer1.Interval = 1000
        ' Start the timer
        Timer1.Start()
        ' Get the current date
        Dim currentDate As Date = Date.Now

        ' Format the date as "MMMM d, yyyy" (e.g., "JULY 7, 2022")
        Dim formattedDate As String = currentDate.ToString("MMMM d, yyyy")

        ' Set the formatted date in the lblDay Label
        lblDay.Text = formattedDate
        ' Get the current date
        Dim currentDate1 As Date = Date.Now

        ' Get the day of the week (0 = Sunday, 1 = Monday, ..., 6 = Saturday)
        Dim dayOfWeek As DayOfWeek = currentDate1.DayOfWeek

        ' Convert the day of the week to a string format (e.g., "SUNDAY")
        Dim formattedDayOfWeek As String = dayOfWeek.ToString().ToUpper()

        ' Set the formatted day of the week in the lblDayType Label
        lblDayType.Text = formattedDayOfWeek
        Try
            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()

            ' Your database query code here
            ' Example: Insert data into the database

            Dim query As String = "SELECT COUNT(DISTINCT patients) AS unique_patient_count FROM appointment WHERE DATE(appointment_date) = CURDATE();"
            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Read the result and display the count with at most two digits in the lblNumbers Label
                        Dim count As Integer = CInt(reader("unique_patient_count"))
                        lblNumbers.Text = If(count < 10, $"0{count}", count.ToString())
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            DatabaseManager.CloseConnection()
        End Try
        UpdatePatientCountLabel()
        UpdateUpcomingAppointmentsLabel()
        imageDirectory = "C:\Users\gilma\Desktop\Dental\Dental\dentist"

        ' Get a list of image files in the directory
        imageFiles = Directory.GetFiles(imageDirectory, "*.jpg")

        ' Initialize the image index
        currentImageIndex = 0

        ' Display the first image
        DisplayImage()
        Try
            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()

            Dim query As String = "SELECT * FROM account WHERE idaccount =" & idUserCurrent & ""
            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim firstName As String = reader("first").ToString()
                        Dim lastname As String = reader("last")

                        Dim capitalizedFirstName As String = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1).ToLower()
                        Dim capitalizedLastName As String = lastname.Substring(0, 1).ToUpper() + lastname.Substring(1).ToLower()
                        lblGreet.Text = "Hello " & capitalizedFirstName & " " & capitalizedLastName & "!"


                    End If


                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub UpdatePatientCountLabel()
        Try
            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()

            ' Your database query code here
            ' Example: Insert data into the database

            ' Modified query to count all idpatients based on the month and year
            Dim query As String = "SELECT COUNT(DISTINCT idpatients) AS unique_patient_count FROM patients WHERE DATE_FORMAT(date_registered, '%Y-%m') = DATE_FORMAT(CURDATE(), '%Y-%m');"
            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Read the result and display the count with at most two digits in the lblTotal Label
                        Dim count As Integer = CInt(reader("unique_patient_count"))
                        lblTotal.Text = If(count < 10, $"0{count}", count.ToString())
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            DatabaseManager.CloseConnection()
        End Try
    End Sub
    Private Sub UpdateUpcomingAppointmentsLabel()
        Try
            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()

            ' Your database query code here
            ' Example: Insert data into the database

            ' Query to count all appointment_id rows where appointment_date is within the current week
            Dim query As String = "SELECT COUNT(appointment_id) AS appointment_count FROM appointment WHERE WEEK(appointment_date, 1) = WEEK(CURDATE(), 1);"
            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Read the result and display the count with at most two digits in the lblUpcoming Label
                        Dim count As Integer = CInt(reader("appointment_count"))
                        lblUpcoming.Text = If(count < 10, $"0{count}", count.ToString())
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            DatabaseManager.CloseConnection()
        End Try
    End Sub
    Private Sub DisplayImage()
        ' Check if there are any images to display
        If imageFiles.Length > 0 Then
            ' Load and display the current image
            PictureBox1.Image = Image.FromFile(imageFiles(currentImageIndex))
        Else
            MessageBox.Show("No images found in the specified directory.")
        End If
    End Sub






    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ' Increment the image index and display the next image
        currentImageIndex += 1

        ' Wrap around to the first image if at the end
        If currentImageIndex >= imageFiles.Length Then
            currentImageIndex = 0
        End If

        DisplayImage()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ' Decrement the image index and display the previous image
        currentImageIndex -= 1

        ' Wrap around to the last image if at the beginning
        If currentImageIndex < 0 Then
            currentImageIndex = imageFiles.Length - 1
        End If

        DisplayImage()
    End Sub




    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        dentistModeInstance.btnAppointment_Click(Nothing, EventArgs.Empty)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        dentistModeInstance.btnAppointment_Click(Nothing, EventArgs.Empty)
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        dentistModeInstance.btnAppointment_Click(Nothing, EventArgs.Empty)
    End Sub

    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click
        dentistModeInstance.btnAppointment_Click(Nothing, EventArgs.Empty)
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        dentistModeInstance.btnAppointment_Click(Nothing, EventArgs.Empty)
    End Sub

    Private Sub lblUpcoming_Click(sender As Object, e As EventArgs) Handles lblUpcoming.Click
        dentistModeInstance.btnAppointment_Click(Nothing, EventArgs.Empty)
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        dentistModeInstance.btnPatients_Click(Nothing, EventArgs.Empty)
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        dentistModeInstance.btnPatients_Click(Nothing, EventArgs.Empty)
    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click
        dentistModeInstance.btnPatients_Click(Nothing, EventArgs.Empty)
    End Sub

    Private Sub lblNumbers_Click(sender As Object, e As EventArgs) Handles lblNumbers.Click
        dentistModeInstance.btnAppointment_Click(Nothing, EventArgs.Empty)
    End Sub

End Class