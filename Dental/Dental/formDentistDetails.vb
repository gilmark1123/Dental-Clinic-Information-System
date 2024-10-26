Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.X509
Imports System.IO
Imports System.Web

Public Class formDentistDetails
    Public Sub New(selectedValue As String)
        ' Initialize the form with the selected value
        InitializeComponent()
        Dim id As String = selectedValue
        lblID.Text = id

        For Each ctrl As Control In Me.Controls
            ' Check if the control is a TextBox or RichTextBox
            If TypeOf ctrl Is TextBox Then
                ' Set the ReadOnly property to True for TextBox
                Dim txtBox As TextBox = DirectCast(ctrl, TextBox)
                txtBox.ReadOnly = True
            ElseIf TypeOf ctrl Is RichTextBox Then
                ' Set the ReadOnly property to True for RichTextBox
                Dim rchTextBox As RichTextBox = DirectCast(ctrl, RichTextBox)
                rchTextBox.ReadOnly = True
            End If
            dateBDay.Enabled = False
            rtbNotes.ReadOnly = False
        Next
        Try
            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()

            Dim query As String = "SELECT * FROM dentist WHERE dentist_id = " & id & ""
            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then

                        rtcfirst.Text = reader.GetString("first_name")
                        rtcLastname.Text = reader.GetString("last_name")
                        txtGender.Text = reader.GetString("sex")
                        txtEmail.Text = reader.GetString("email")
                        txtPhone.Text = reader.GetString("contact_number")
                        Dim bday As String = reader.GetString("birthday")
                        dateBDay.Text = bday.Substring(0, bday.Length - 12)
                        rtbAddress.Text = reader.GetString("address")
                        rtbDegree.Text = reader.GetString("degree")
                        rtbSpecialty.Text = reader.GetString("specialty")
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
        InitializeComponent()
    End Sub





    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click


    End Sub

    Private Sub rtbDegree_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub formDentistDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
    End Sub

    Private Sub rtbNotes_TextChanged(sender As Object, e As EventArgs) Handles rtbNotes.TextChanged
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint
    End Sub
End Class