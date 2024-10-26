Imports System.Media
Imports System.Security.Principal
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Public Class Form1
    Dim accountId As Integer


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then

            txtPassword.UseSystemPasswordChar = False
        ElseIf CheckBox1.Checked = False Then

            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub



    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim registration As New registration
        registration.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()

            ' Secure way to avoid SQL injection - use parameters
            Dim query As String = "SELECT idaccount, doctorMode, password FROM account WHERE username = @username;"

            Using cmd As New MySqlCommand(query, connection)
                ' Set parameter for username
                cmd.Parameters.AddWithValue("@username", txtUser.Text)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim hashedPasswordFromDB As String = reader.GetString("password")

                        ' Validate the entered password by hashing it and comparing it with the stored hashed password
                        Dim enteredPassword As String = txtPassword.Text
                        Dim enteredPasswordHashed As String = HashPassword(enteredPassword)

                        If hashedPasswordFromDB = enteredPasswordHashed Then
                            ' Passwords match - login successful
                            accountId = reader.GetInt32("idaccount")
                            Dim accountPrev = "0"
                            ' Check if doctorMode column is not null
                            If Not reader.IsDBNull(reader.GetOrdinal("doctorMode")) Then
                                ' If doctorMode is not null, display another form (doctor form)
                                Dim formDoctor As New DentistMode(accountId, accountPrev)
                                txtUser.Text = ""
                                txtPassword.Text = ""
                                formDoctor.Show()
                                Me.Hide()
                            Else
                                ' Login successful but not a doctor
                                Dim formHome As New formHome(accountId)
                                txtUser.Text = ""
                                txtPassword.Text = ""
                                formHome.Show()
                                Me.Hide()
                            End If
                        Else
                            ' Passwords don't match
                            MessageBox.Show("Username or password incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        ' Username not found
                        MessageBox.Show("Username or password incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DatabaseManager.CloseConnection()
        End Try

    End Sub
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            ' Call the function you want to execute on Enter press
            btnLogin_Click(Nothing, Nothing) ' Assuming btnLogin_Click is the function you want to execute
        End If
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Text = ""
        txtPassword.Text = ""
    End Sub




End Class