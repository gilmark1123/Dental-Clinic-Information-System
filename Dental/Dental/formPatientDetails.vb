Imports System.Diagnostics.Eventing
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Security.Cryptography.Pkcs
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Org.BouncyCastle.Asn1.X509

Public Class formPatientDetails
    Dim g, mg As Graphics
    Dim bmp As Bitmap
    Dim value As String
    Private dentistModeInstance As DentistMode
    Private uploadedImage As Image

    Public Sub New(selectedValue As String, dentistInstance As DentistMode)
        InitializeComponent()
        dentistModeInstance = dentistInstance
        Label1.Text = selectedValue.ToString()
        Dim id As Integer = Label1.Text
        cbTeethType.SelectedItem = "Adult Teeth Records"






    End Sub








    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If My.Application.OpenForms.OfType(Of formTreatment).Any() Or My.Application.OpenForms.OfType(Of TeethCollection).Any() Or My.Application.OpenForms.OfType(Of formTeethChild).Any() Then
            Button2.BackColor = Color.LightPink

        Else
            Button2.BackColor = Color.MistyRose
        End If
        If Button2.BackColor = Color.LightPink Then
            MessageBox.Show("Treatment is Already Running")
        ElseIf Button2.BackColor = Color.MistyRose Then
            Dim idToTreatment As Integer = Label1.Text
            Dim Name As String = lblName1.Text
            Dim formTreatment As New formTreatment(idToTreatment, Name)
            Button2.BackColor = Color.MistyRose
            formTreatment.Show()
        End If


    End Sub


    Private Sub SaveImageButton_Click(sender As Object, e As EventArgs) Handles PrintPreviewButton.Click
        ' Create a PrintDocument
        Dim printDocument As New Printing.PrintDocument()

        ' Set the PrintPage event handler
        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage

        ' Set the print document's size to match the Panel4 size
        Dim panelSize As Size = Panel4.Size ' Assuming Panel4 is the name of your panel
        printDocument.DefaultPageSettings.PaperSize = New Printing.PaperSize("Custom", panelSize.Width, panelSize.Height)

        ' Create a PrintPreviewDialog
        Dim printPreviewDialog As New PrintPreviewDialog()
        printPreviewDialog.Document = printDocument

        ' Show the print preview dialog
        printPreviewDialog.ShowDialog()
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        ' Capture the contents of Panel4 to print
        Dim panelBitmap As New Bitmap(Panel4.Width, Panel4.Height)
        Panel4.DrawToBitmap(panelBitmap, New Rectangle(0, 0, Panel4.Width, Panel4.Height))

        ' Draw the captured panel image on the print document
        e.Graphics.DrawImage(panelBitmap, 0, 0, Panel4.Width, Panel4.Height)

        ' Dispose of the bitmap
        panelBitmap.Dispose()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTeethType.SelectedIndexChanged
        If cbTeethType.SelectedItem IsNot Nothing Then
            Dim selectedValue As String = cbTeethType.SelectedItem.ToString()

            Select Case selectedValue
                Case "Adult Teeth Records"
                    ' Perform your action here when "Adult Teeth Records" is selected
                    lblWork1.Text = ""
                    lblWork2.Text = ""
                    lblWork3.Text = ""
                    lblDateTreat.Text = ""
                    lblDoctor.Text = ""
                    lblPrice.Text = ""
                    rtbPrescription.Text = ""
                    lbl18.Text = ""
                    lbl17.Text = ""
                    lbl16.Text = ""
                    lbl15.Text = ""
                    lbl14.Text = ""
                    lbl13.Text = ""
                    lbl12.Text = ""
                    lbl11.Text = ""
                    lbl48.Text = ""
                    lbl47.Text = ""
                    lbl46.Text = ""
                    lbl45.Text = ""
                    lbl44.Text = ""
                    lbl43.Text = ""
                    lbl42.Text = ""
                    lbl41.Text = ""
                    lbl28.Text = ""
                    lbl27.Text = ""
                    lbl26.Text = ""
                    lbl25.Text = ""
                    lbl24.Text = ""
                    lbl23.Text = ""
                    lbl22.Text = ""
                    lbl21.Text = ""
                    lbl38.Text = ""
                    lbl37.Text = ""
                    lbl36.Text = ""
                    lbl35.Text = ""
                    lbl34.Text = ""
                    lbl33.Text = ""
                    lbl32.Text = ""
                    lbl31.Text = ""
                    Try
                        Dim type As String = "adult" ' Use a constant for "adult" to avoid redundancy
                        Dim idPatient As String = Label1.Text
                        DatabaseManager.OpenConnection()
                        Dim connection As MySqlConnection = DatabaseManager.GetConnection()

                        ' Get the total number of records
                        Dim countQuery As String = "SELECT COUNT(*) AS row_count FROM treatment WHERE teeth_type = @teethType AND idpatients = @id;"
                        Using cmdCount As New MySqlCommand(countQuery, connection)
                            cmdCount.Parameters.AddWithValue("@teethType", type)
                            cmdCount.Parameters.AddWithValue("@id", idPatient)
                            Dim rowCount As Integer = Convert.ToInt32(cmdCount.ExecuteScalar()) ' ExecuteScalar to get a single value
                            lblPrev.Text = rowCount.ToString()
                        End Using

                        Dim over1 As Integer = Integer.Parse(lblPrev.Text)
                        Dim current1 As Integer = Integer.Parse(lblCurr.Text)
                        If current1 > over1 Then
                            current1 = 1
                            lblCurr.Text = current1.ToString()
                        End If
                        ' Extract the offset from lblCurrent and convert it to an integer
                        Dim offset As Integer = Integer.Parse(lblCurr.Text) - 1

                        ' Use a parameterized query for fetching data
                        Dim query As String = "SELECT * FROM treatment WHERE teeth_type = @teethType AND idpatients = @id ORDER BY date_of_treatment DESC LIMIT 1 OFFSET @offset;"
                        Using cmdData As New MySqlCommand(query, connection)
                            cmdData.Parameters.AddWithValue("@teethType", type)
                            cmdData.Parameters.AddWithValue("@offset", offset)
                            cmdData.Parameters.AddWithValue("@id", idPatient)

                            Using reader As MySqlDataReader = cmdData.ExecuteReader()
                                If reader.Read() Then

                                    Dim dateTreat As String = reader.GetString("date_of_treatment")
                                    Dim dateFinalTreat As String = dateTreat.Substring(0, dateTreat.Length - 12)

                                    lblWork1.Text = reader.GetString("workdone1")
                                    lblWork2.Text = reader.GetString("workdone2")
                                    lblWork3.Text = reader.GetString("workdone3")
                                    lblDateTreat.Text = dateFinalTreat
                                    lblDoctor.Text = reader.GetString("doctor")
                                    lblPrice.Text = reader.GetString("price")
                                    rtbPrescription.Text = reader.GetString("prescriptions")
                                    lbl18.Text = "18: " & reader.GetString("teeth18_label")
                                    lbl17.Text = "17: " & reader.GetString("teeth17_label")
                                    lbl16.Text = "16: " & reader.GetString("teeth16_label")
                                    lbl15.Text = "15: " & reader.GetString("teeth15_label")
                                    lbl14.Text = "14: " & reader.GetString("teeth14_label")
                                    lbl13.Text = "13: " & reader.GetString("teeth13_label")
                                    lbl12.Text = "12: " & reader.GetString("teeth12_label")
                                    lbl11.Text = "11: " & reader.GetString("teeth11_label")
                                    lbl48.Text = "48: " & reader.GetString("teeth48_label")
                                    lbl47.Text = "47: " & reader.GetString("teeth47_label")
                                    lbl46.Text = "46: " & reader.GetString("teeth46_label")
                                    lbl45.Text = "45: " & reader.GetString("teeth45_label")
                                    lbl44.Text = "44: " & reader.GetString("teeth44_label")
                                    lbl43.Text = "43: " & reader.GetString("teeth43_label")
                                    lbl42.Text = "42: " & reader.GetString("teeth42_label")
                                    lbl41.Text = "41: " & reader.GetString("teeth41_label")
                                    lbl28.Text = "28: " & reader.GetString("teeth28_label")
                                    lbl27.Text = "27: " & reader.GetString("teeth27_label")
                                    lbl26.Text = "26: " & reader.GetString("teeth26_label")
                                    lbl25.Text = "25: " & reader.GetString("teeth25_label")
                                    lbl24.Text = "24: " & reader.GetString("teeth24_label")
                                    lbl23.Text = "23: " & reader.GetString("teeth23_label")
                                    lbl22.Text = "22: " & reader.GetString("teeth22_label")
                                    lbl21.Text = "21: " & reader.GetString("teeth21_label")
                                    lbl38.Text = "38: " & reader.GetString("teeth38_label")
                                    lbl37.Text = "37: " & reader.GetString("teeth37_label")
                                    lbl36.Text = "36: " & reader.GetString("teeth36_label")
                                    lbl35.Text = "35: " & reader.GetString("teeth35_label")
                                    lbl34.Text = "34: " & reader.GetString("teeth34_label")
                                    lbl33.Text = "33: " & reader.GetString("teeth33_label")
                                    lbl32.Text = "32: " & reader.GetString("teeth32_label")
                                    lbl31.Text = "31: " & reader.GetString("teeth31_label")


                                Else
                                    lblWork1.Text = "No records found." ' Handle the case when no records are found
                                End If
                            End Using
                        End Using

                        DatabaseManager.CloseConnection()


                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                Case "Child Teeth Records"
                    ' Perform your action here when "Child Teeth Records" is selected
                    lblWork1.Text = ""
                    lblWork2.Text = ""
                    lblWork3.Text = ""
                    lblDateTreat.Text = ""
                    lblDoctor.Text = ""
                    lblPrice.Text = ""
                    rtbPrescription.Text = ""
                    lbl18.Text = ""
                    lbl17.Text = ""
                    lbl16.Text = ""
                    lbl15.Text = ""
                    lbl14.Text = ""
                    lbl13.Text = ""
                    lbl12.Text = ""
                    lbl11.Text = ""
                    lbl48.Text = ""
                    lbl47.Text = ""
                    lbl46.Text = ""
                    lbl45.Text = ""
                    lbl44.Text = ""
                    lbl43.Text = ""
                    lbl42.Text = ""
                    lbl41.Text = ""
                    lbl28.Text = ""
                    lbl27.Text = ""
                    lbl26.Text = ""
                    lbl25.Text = ""
                    lbl24.Text = ""
                    lbl23.Text = ""
                    lbl22.Text = ""
                    lbl21.Text = ""
                    lbl38.Text = ""
                    lbl37.Text = ""
                    lbl36.Text = ""
                    lbl35.Text = ""
                    lbl34.Text = ""
                    lbl33.Text = ""
                    lbl32.Text = ""
                    lbl31.Text = ""
                    Try
                        Dim type As String = "child" ' Use a constant for "child" to avoid redundancy
                        Dim idPatient As String = Label1.Text
                        DatabaseManager.OpenConnection()
                        Dim connection As MySqlConnection = DatabaseManager.GetConnection()

                        ' Get the total number of records
                        Dim countQuery As String = "SELECT COUNT(*) AS row_count FROM treatment WHERE teeth_type = @teethType AND idpatients = @id;"
                        Using cmdCount As New MySqlCommand(countQuery, connection)
                            cmdCount.Parameters.AddWithValue("@teethType", type)
                            cmdCount.Parameters.AddWithValue("@id", idPatient)
                            Dim rowCount As Integer = Convert.ToInt32(cmdCount.ExecuteScalar()) ' ExecuteScalar to get a single value
                            lblPrev.Text = rowCount.ToString()
                        End Using

                        Dim over1 As Integer = Integer.Parse(lblPrev.Text)
                        Dim current1 As Integer = Integer.Parse(lblCurr.Text)
                        If current1 > over1 Then
                            current1 = 1
                            lblCurr.Text = current1.ToString()
                        End If
                        ' Extract the offset from lblCurrent and convert it to an integer
                        Dim offset As Integer = Integer.Parse(lblCurr.Text) - 1

                        ' Use a parameterized query for fetching data
                        Dim query As String = "SELECT * FROM treatment WHERE teeth_type = @teethType AND idpatients = @id ORDER BY date_of_treatment DESC LIMIT 1 OFFSET @offset;"
                        Using cmdData As New MySqlCommand(query, connection)
                            cmdData.Parameters.AddWithValue("@teethType", type)
                            cmdData.Parameters.AddWithValue("@offset", offset)
                            cmdData.Parameters.AddWithValue("@id", idPatient)

                            Using reader As MySqlDataReader = cmdData.ExecuteReader()
                                If reader.Read() Then

                                    Dim dateTreat As String = reader.GetString("date_of_treatment")
                                    Dim dateFinalTreat As String = dateTreat.Substring(0, dateTreat.Length - 12)

                                    lblWork1.Text = reader.GetString("workdone1")
                                    lblWork2.Text = reader.GetString("workdone2")
                                    lblWork3.Text = reader.GetString("workdone3")
                                    lblDateTreat.Text = dateFinalTreat
                                    lblDoctor.Text = reader.GetString("doctor")
                                    lblPrice.Text = reader.GetString("price")
                                    rtbPrescription.Text = reader.GetString("prescriptions")
                                    lbl18.Text = "A: " & reader.GetString("teeth18_label")
                                    lbl17.Text = "B: " & reader.GetString("teeth17_label")
                                    lbl16.Text = "C: " & reader.GetString("teeth16_label")
                                    lbl15.Text = "D: " & reader.GetString("teeth15_label")
                                    lbl14.Text = "E: " & reader.GetString("teeth14_label")
                                    lbl13.Text = ""
                                    lbl12.Text = ""
                                    lbl11.Text = ""
                                    lbl48.Text = "T: " & reader.GetString("teeth48_label")
                                    lbl47.Text = "S: " & reader.GetString("teeth47_label")
                                    lbl46.Text = "R: " & reader.GetString("teeth46_label")
                                    lbl45.Text = "Q: " & reader.GetString("teeth45_label")
                                    lbl44.Text = "P: " & reader.GetString("teeth44_label")
                                    lbl43.Text = " "
                                    lbl42.Text = " "
                                    lbl41.Text = " "
                                    lbl28.Text = "J: " & reader.GetString("teeth28_label")
                                    lbl27.Text = "I: " & reader.GetString("teeth27_label")
                                    lbl26.Text = "H: " & reader.GetString("teeth26_label")
                                    lbl25.Text = "G: " & reader.GetString("teeth25_label")
                                    lbl24.Text = "F: " & reader.GetString("teeth24_label")
                                    lbl23.Text = " "
                                    lbl22.Text = " "
                                    lbl21.Text = " "
                                    lbl38.Text = "K: " & reader.GetString("teeth38_label")
                                    lbl37.Text = "L: " & reader.GetString("teeth37_label")
                                    lbl36.Text = "M: " & reader.GetString("teeth36_label")
                                    lbl35.Text = "N: " & reader.GetString("teeth35_label")
                                    lbl34.Text = "O: " & reader.GetString("teeth34_label")
                                    lbl33.Text = " "
                                    lbl32.Text = " "
                                    lbl31.Text = " "


                                Else
                                    lblWork1.Text = "No records found." ' Handle the case when no records are found
                                End If
                            End Using
                        End Using

                        DatabaseManager.CloseConnection()


                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                Case Else
                    ' Handle other cases if needed
            End Select
        End If
    End Sub



    Private Sub Next_Click_1(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim over As Integer = Integer.Parse(lblPrev.Text)
        Dim current As Integer = Integer.Parse(lblCurr.Text)
        If current < over Then
            current = current + 1
            lblCurr.Text = current.ToString()

            Dim selectedValue As String = cbTeethType.SelectedItem.ToString()
            If selectedValue = "Adult Teeth Records" Then
                ComboBox1_SelectedIndexChanged(cbTeethType, EventArgs.Empty)
            ElseIf selectedValue = "Child Teeth Records" Then
                ComboBox1_SelectedIndexChanged(cbTeethType, EventArgs.Empty)
            End If
        End If
    End Sub

    Private Sub btnPrev_Click_1(sender As Object, e As EventArgs) Handles btnPrev.Click
        Dim over As Integer = Integer.Parse(lblPrev.Text)
        Dim current As Integer = Integer.Parse(lblCurr.Text)
        If current > 1 And current <= over Then
            current = current - 1
            lblCurr.Text = current.ToString()

            Dim selectedValue As String = cbTeethType.SelectedItem.ToString()
            If selectedValue = "Adult Teeth Records" Then
                ComboBox1_SelectedIndexChanged(cbTeethType, EventArgs.Empty)
            ElseIf selectedValue = "Child Teeth Records" Then
                ComboBox1_SelectedIndexChanged(cbTeethType, EventArgs.Empty)
            End If
        End If
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Panel11_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Public Class CustomRichTextBox
        Inherits RichTextBox

        Public Sub New()
            Me.BorderStyle = Windows.Forms.BorderStyle.None ' Set border style to None
        End Sub

        Protected Overrides Sub WndProc(ByRef m As Message)
            MyBase.WndProc(m)

            Const WM_NCPAINT As Integer = &H85

            If m.Msg = WM_NCPAINT Then
                Using g As Graphics = Graphics.FromHwnd(Handle)
                    Using pen As New Pen(Color.White, 2) ' Change the thickness of the border and color as needed
                        g.DrawRectangle(pen, New Rectangle(0, 0, Width - 1, Height - 1))
                    End Using
                End Using
            End If
        End Sub
    End Class

    Private Sub formPatientDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim red As Integer = 248
        Dim green As Integer = 163
        Dim blue As Integer = 144

        ' Convert RGB values to a Color object
        Dim customColor As Color = Color.FromArgb(red, green, blue)

        ' Set the BackColor of a control (for example, a form)
        lblName1.Location = New Point((Panel7.Width - lblName1.Width) \ 2, (Panel7.Height - lblName1.Height) \ 2)


        dtpBday.Enabled = False ' Disables the control

        ' Set BackColor to MistyRose
        dtpBday.BackColor = Color.MistyRose
        btnSave.Visible = False
        ReloadFormWithSelectedValue()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dentistModeInstance.btnPatients_Click(Nothing, EventArgs.Empty)
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If btnSave.Visible Then
            txtLast.ReadOnly = True
            txtFirst.ReadOnly = True
            txtExtension.ReadOnly = True
            txtmiddle.ReadOnly = True
            dtpBday.Enabled = False
            txtGender.ReadOnly = True
            txtNumber.ReadOnly = True
            txtEmail.ReadOnly = True
            txtProvince.ReadOnly = True
            txtCity.ReadOnly = True
            txtBaranggay.ReadOnly = True
            txtHouse.ReadOnly = True
            btnSave.Visible = False
            btnUpload.Visible = False
            Button1.Text = "Edit"
            ReloadFormWithSelectedValue()
        Else
            ' Situation when btnSave is not visible
            txtLast.ReadOnly = False
            txtFirst.ReadOnly = False
            txtExtension.ReadOnly = False
            txtmiddle.ReadOnly = False
            dtpBday.Enabled = True
            txtGender.ReadOnly = False
            txtNumber.ReadOnly = False
            txtEmail.ReadOnly = False
            txtProvince.ReadOnly = False
            txtCity.ReadOnly = False
            txtBaranggay.ReadOnly = False
            txtHouse.ReadOnly = False
            btnSave.Visible = True
            btnUpload.Visible = True
            Button1.Text = "Cancel"
        End If
    End Sub

    Private Sub ReloadFormWithSelectedValue()
        Try
            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()
            Dim Ids As String = Label1.Text
            Dim query As String = "SELECT * FROM patients WHERE idpatients =" & Ids & ""
            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim fname As String = reader.GetString("first_name_patients")

                        Dim bday As String = reader.GetString("birthdate_patients")

                        Dim province As String = reader("province").ToString()
                        Dim city As String = reader("city").ToString()
                        Dim baranggay As String = reader("baranggay").ToString()
                        Dim houseNumber As String = reader("house_number").ToString()
                        txtLast.Text = reader("last_name_patients").ToString()
                        txtFirst.Text = reader("first_name_patients").ToString()
                        txtExtension.Text = reader("extension").ToString()
                        txtmiddle.Text = reader("middle_name_patients").ToString()
                        dtpBday.Value = reader("birthdate_patients")
                        txtGender.Text = reader("sex_patients")
                        txtNumber.Text = reader("contact_number_patients")
                        txtEmail.Text = reader("email")
                        txtGender.Text = reader("sex_patients")
                        txtProvince.Text = reader("province")
                        txtCity.Text = reader("city")
                        txtBaranggay.Text = reader("baranggay")
                        txtHouse.Text = reader("house_number")
                        ' Combine values into an address format
                        Dim address As String = $"{houseNumber}, {baranggay}, {city}, {province}"




                        Dim dateMade As String = reader.GetString("date_registered")
                        Dim strippedDateRegister As String = dateMade.Substring(0, dateMade.Length - 12)
                        lblDate.Text = strippedDateRegister

                        lblName1.Text = fname
                        rtbPrescription.ReadOnly = True


                        Dim imageData As Byte() = DirectCast(reader("patients_image"), Byte())
                        If imageData IsNot Nothing AndAlso imageData.Length > 0 Then

                            Using ms As New MemoryStream(imageData)
                                PictureBox1.Image = Image.FromStream(ms)
                            End Using
                        Else
                            PictureBox1.Image = Nothing
                        End If

                    End If


                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()
            Dim idPatient As String = Label1.Text
            Dim query12 As String = "UPDATE patients SET first_name_patients = @first, middle_name_patients = @middle, last_name_patients = @last, extension = @extension, sex_patients = @sex, birthdate_patients = @bday, contact_number_patients = @number, province = @province, city = @city, baranggay = @baranggay, house_number = @house, email = @email"

            ' Check if an image is uploaded
            If uploadedImage IsNot Nothing Then
                query12 &= ", patients_image = @image"
            End If

            query12 &= " WHERE idpatients = @id;"

            Using cmd As New MySqlCommand(query12, connection)
                cmd.Parameters.AddWithValue("@first", txtFirst.Text)
                cmd.Parameters.AddWithValue("@middle", txtmiddle.Text)
                cmd.Parameters.AddWithValue("@last", txtLast.Text)
                cmd.Parameters.AddWithValue("@extension", txtExtension.Text)
                cmd.Parameters.AddWithValue("@sex", txtGender.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                Dim selectedDate As DateTime = dtpBday.Value.Date
                Dim formattedDate As String = selectedDate.ToString("yyyy-MM-dd")
                cmd.Parameters.AddWithValue("@bday", formattedDate)
                cmd.Parameters.AddWithValue("@number", txtNumber.Text)
                cmd.Parameters.AddWithValue("@province", txtProvince.Text)
                cmd.Parameters.AddWithValue("@city", txtCity.Text)
                cmd.Parameters.AddWithValue("@baranggay", txtBaranggay.Text)
                cmd.Parameters.AddWithValue("@house", txtHouse.Text)
                cmd.Parameters.AddWithValue("@id", idPatient)

                ' Add image parameter if an image is uploaded
                If uploadedImage IsNot Nothing Then
                    Dim ms As New MemoryStream()
                    uploadedImage.Save(ms, Imaging.ImageFormat.Jpeg) ' Assuming JPEG format, change if needed
                    Dim imageBytes As Byte() = ms.ToArray()
                    cmd.Parameters.AddWithValue("@image", imageBytes)
                End If

                cmd.ExecuteNonQuery()
            End Using

            Button1.Text = "Edit"
            ReloadFormWithSelectedValue()
            txtLast.ReadOnly = True
            txtFirst.ReadOnly = True
            txtExtension.ReadOnly = True
            txtmiddle.ReadOnly = True
            dtpBday.Enabled = False
            txtGender.ReadOnly = True
            txtNumber.ReadOnly = True
            txtEmail.ReadOnly = True
            txtProvince.ReadOnly = True
            txtCity.ReadOnly = True
            txtBaranggay.ReadOnly = True
            txtHouse.ReadOnly = True
            btnSave.Visible = False
            btnUpload.Visible = False
            lblName1.Location = New Point((Panel7.Width - lblName1.Width) \ 2, (Panel7.Height - lblName1.Height) \ 2)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim openFileDialog As New OpenFileDialog()

        ' Set the file filter
        openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*"

        ' Allow selection of only one file
        openFileDialog.Multiselect = False

        ' Show OpenFileDialog
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file name and display it in PictureBox1
            Dim selectedImage As Image = Image.FromFile(openFileDialog.FileName)
            PictureBox1.Image = selectedImage

            ' Store the image in the variable
            uploadedImage = selectedImage
        End If
    End Sub
End Class