Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Dentist

    Public Sub New(selectedValue As String)
        ' Initialize the form with the selected value
        InitializeComponent()
        Dim id As String = selectedValue
        lblID.Text = id


        Try
            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()

            Dim query As String = "SELECT * FROM dentist WHERE dentist_id = " & id & ""
            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then

                        lblfirst.Text = reader.GetString("first_name")

                        lblGender.Text = reader.GetString("sex")
                        lblEmail.Text = reader.GetString("email")
                        lblPhone.Text = reader.GetString("contact_number")
                        Dim bday As String = reader.GetString("birthday")
                        lblBday.Text = bday.Substring(0, bday.Length - 12)
                        lblAddress.Text = reader.GetString("address")
                        lblDegree.Text = reader.GetString("degree")
                        lblSpecialty.Text = reader.GetString("specialty")
                        rtbNotes.Text = reader.GetString("notes")

                        Dim imageData As Byte() = DirectCast(reader("dentist_pic"), Byte())
                        If imageData IsNot Nothing AndAlso imageData.Length > 0 Then

                            Using ms As New MemoryStream(imageData)
                                pbPic.Image = Image.FromStream(ms)
                            End Using
                        Else
                            pbPic.Image = Nothing
                        End If

                    End If


                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub

    Friend Shared Sub SwitchToDetails(selectedValue As String)
        Throw New NotImplementedException()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim idLabel As String = lblID.Text
            DatabaseManager.OpenConnection()
            Dim notesStore As String = rtbNotes.Text
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()
            Dim insertquery As String = "Update dentist SET notes = @notes WHERE dentist_id= " & idLabel & " "
            Using cmd As New MySqlCommand(insertquery, connection)

                cmd.Parameters.AddWithValue("@notes", notesStore)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)



        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub


End Class