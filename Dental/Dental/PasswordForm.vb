Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Public Class PasswordForm
    Private _formHomeInstance As formHome
    Dim idValueHome As Integer
    ' Constructor to accept formHome instance
    Public Sub New(formHomeInstance As formHome)
        InitializeComponent()
        _formHomeInstance = formHomeInstance
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If _formHomeInstance IsNot Nothing Then
            idValueHome = _formHomeInstance.IDValueFromHomeForm

        End If

        Try
            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()

            ' Get the value from txtPassword
            Dim enteredPassword As String = txtPassword.Text.Trim()

            ' Hash the entered password for comparison
            Dim hashedEnteredPassword As String = HashPassword(enteredPassword)

            ' Secure way to avoid SQL injection - use parameters
            Dim query As String = "SELECT idaccount FROM account WHERE doctorMode = @DoctorModePassword;"

            Using cmd As New MySqlCommand(query, connection)
                ' Use parameterized query to avoid SQL injection
                cmd.Parameters.AddWithValue("@DoctorModePassword", hashedEnteredPassword)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' If the hashed password was found in the doctorMode column
                        Dim idAccount As Integer = reader.GetInt32("idaccount")
                        Dim DentistMode As New DentistMode(idAccount, idValueHome)
                        DentistMode.Show()
                        formHome.CloseCurrentInstance()

                    Else
                        ' If the password was not found
                        MessageBox.Show("Password Incorrect", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DatabaseManager.CloseConnection()
            Me.Close()
        End Try
    End Sub
    Private Function HashPassword(ByVal password As String) As String
        Using sha256 As SHA256 = sha256.Create()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()

            For Each b As Byte In hashedBytes
                builder.Append(b.ToString("x2"))
            Next

            Return builder.ToString()
        End Using
    End Function
End Class