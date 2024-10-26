Imports DirectShowLib.BDA
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Security.Cryptography
Imports System.Text

Public Class registration
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then

            txtEpassword.UseSystemPasswordChar = False
            txtEpasswordconfirm.UseSystemPasswordChar = False
        ElseIf CheckBox1.Checked = False Then
            txtEpassword.UseSystemPasswordChar = True
            txtEpasswordconfirm.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then

            txtEPasscode.UseSystemPasswordChar = False

        ElseIf CheckBox2.Checked = False Then
            txtEPasscode.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not (IsNothing(txtEfirst.Text) OrElse
                IsNothing(txtEmiddle.Text) OrElse
                IsNothing(txtElast.Text) OrElse
                IsNothing(txtEnumber.Text) OrElse
                IsNothing(txtEprovince.Text) OrElse
                IsNothing(txtEcity.Text) OrElse
                IsNothing(txtEBaranggay.Text) OrElse
                IsNothing(txtEUsername.Text) OrElse
                IsNothing(txtEpassword.Text) OrElse
                IsNothing(txtEpasswordconfirm.Text) OrElse
                IsNothing(txtEPasscode.Text) OrElse
                IsNothing(txtEsex.Text) OrElse
                IsNothing(txtEsex.SelectedItem)) Then
            If txtEpassword.Text <> txtEpasswordconfirm.Text Then
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return


                ' Check if txtEPasscode has the text "Employee"
            ElseIf txtEPasscode.Text.Trim() <> "Employee" Then
                MessageBox.Show("Employee passcode is incorrect.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return

            Else
                Try
                    DatabaseManager.OpenConnection()
                    Dim connection As MySqlConnection = DatabaseManager.GetConnection()




                    Dim insertQuery As String = "INSERT INTO account (first,middle,last,extension,sex,email,number,bday,province,city,baranggay,house,username,password) VALUES (@first,@middle,@last,@extension,@sex,@email,@number,@bday,@province,@city,@baranggay,@house,@username,@password)"

                    Using cmd As New MySqlCommand(insertQuery, connection)
                        cmd.Parameters.AddWithValue("@first", txtEfirst.Text)
                        cmd.Parameters.AddWithValue("@middle", txtEmiddle.Text)
                        cmd.Parameters.AddWithValue("@last", txtElast.Text)
                        cmd.Parameters.AddWithValue("@extension", txtEextension.Text) ' Fixed typo here
                        cmd.Parameters.AddWithValue("@sex", txtEsex.Text)
                        cmd.Parameters.AddWithValue("@email", txtEemail.Text)
                        cmd.Parameters.AddWithValue("@number", txtEnumber.Text)

                        Dim selectedDate As DateTime = dtpEBday.Value.Date
                        Dim formattedDate As String = selectedDate.ToString("yyyy-MM-dd")
                        cmd.Parameters.AddWithValue("@bday", formattedDate)
                        cmd.Parameters.AddWithValue("@province", txtEprovince.Text)
                        cmd.Parameters.AddWithValue("@city", txtEcity.Text)
                        cmd.Parameters.AddWithValue("@baranggay", txtEBaranggay.Text)
                        cmd.Parameters.AddWithValue("@house", txtEHouse.Text)
                        cmd.Parameters.AddWithValue("@username", txtEUsername.Text)
                        Dim encryptedPassword As String = HashPassword(txtEpasswordconfirm.Text)
                        cmd.Parameters.AddWithValue("@password", encryptedPassword)
                        cmd.ExecuteNonQuery()

                    End Using


                    MessageBox.Show("Account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    DatabaseManager.CloseConnection()
                    Me.Close()
                    Dim Form1 As New Form1
                    Form1.Show()
                Catch ex As Exception
                    MessageBox.Show("Error: The Username has already been taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


                Finally



                End Try
            End If
        Else
            MessageBox.Show("Please fill in all required fields and ensure password fields match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Function HashPassword(ByVal password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()

            For Each b As Byte In hashedBytes
                builder.Append(b.ToString("x2"))
            Next

            Return builder.ToString()
        End Using
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not (IsNothing(txtDfirst.Text) OrElse
                IsNothing(txtDmiddle.Text) OrElse
                IsNothing(txtDlast.Text) OrElse
                IsNothing(txtDnumber.Text) OrElse
                IsNothing(txtDprovince.Text) OrElse
                IsNothing(txtDcity.Text) OrElse
                IsNothing(txtDbaranggay.Text) OrElse
                IsNothing(txtDusername.Text) OrElse
                IsNothing(txtDpassword.Text) OrElse
                IsNothing(txtDpasswordconfirm.Text) OrElse
                IsNothing(txtDpasscode.Text) OrElse
                IsNothing(txtDsex.Text) OrElse
                IsNothing(txtDsex.SelectedItem)) OrElse
                IsNothing(txtDpass.Text) OrElse
                IsNothing(txtDpassconfirm.Text) Then
            If txtDpassword.Text <> txtDpasswordconfirm.Text Then
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return


                ' Check if txtEPasscode has the text "Employee"
            ElseIf txtDpasscode.Text.Trim() <> "Dentist" Then
                MessageBox.Show("Employee passcode is incorrect.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            ElseIf txtDpassword.Text <> txtDpasswordconfirm.Text Then
                MessageBox.Show("Dentist Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return

            Else
                Try
                    DatabaseManager.OpenConnection()
                    Dim connection As MySqlConnection = DatabaseManager.GetConnection()




                    Dim insertQuery As String = "INSERT INTO account (first,middle,last,extension,sex,email,number,bday,province,city,baranggay,house,username,password,doctorMode) VALUES (@first,@middle,@last,@extension,@sex,@email,@number,@bday,@province,@city,@baranggay,@house,@username,@password,@doctorMode)"

                    Using cmd As New MySqlCommand(insertQuery, connection)
                        cmd.Parameters.AddWithValue("@first", txtDfirst.Text)
                        cmd.Parameters.AddWithValue("@middle", txtDmiddle.Text)
                        cmd.Parameters.AddWithValue("@last", txtDlast.Text)
                        cmd.Parameters.AddWithValue("@extension", txtDextension.Text) ' Fixed typo here
                        cmd.Parameters.AddWithValue("@sex", txtDsex.Text)
                        cmd.Parameters.AddWithValue("@email", txtDemail.Text)
                        cmd.Parameters.AddWithValue("@number", txtDnumber.Text)

                        Dim selectedDate1 As DateTime = dtpDbday.Value.Date
                        Dim formattedDate1 As String = selectedDate1.ToString("yyyy-MM-dd")
                        cmd.Parameters.AddWithValue("@bday", formattedDate1)
                        cmd.Parameters.AddWithValue("@province", txtDprovince.Text)
                        cmd.Parameters.AddWithValue("@city", txtDcity.Text)
                        cmd.Parameters.AddWithValue("@baranggay", txtDbaranggay.Text)
                        cmd.Parameters.AddWithValue("@house", txtDhouse.Text)
                        cmd.Parameters.AddWithValue("@username", txtDusername.Text)
                        Dim encryptedPassword As String = HashPassword(txtDpasswordconfirm.Text)
                        cmd.Parameters.AddWithValue("@password", encryptedPassword)
                        Dim encryptedPasswordCode As String = HashPassword(txtDpassconfirm.Text)
                        cmd.Parameters.AddWithValue("@doctorMode", encryptedPasswordCode)
                        cmd.ExecuteNonQuery()

                    End Using


                    MessageBox.Show("Account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    DatabaseManager.CloseConnection()
                    Me.Close()
                    Dim Form1 As New Form1
                    Form1.Show()
                Catch ex As Exception
                    MessageBox.Show("Error: The Username has already been taken or Dentist Passcode has been taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


                Finally



                End Try
            End If
        Else
            MessageBox.Show("Please fill in all required fields and ensure password fields match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class