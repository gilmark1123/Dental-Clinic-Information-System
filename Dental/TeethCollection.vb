Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Ocsp

Public Class TeethCollection
    Public Sub New(id As String, name As String, doctor As String, dateTreat As DateTime, work1 As String, work2 As String, work3 As String, prescription As String)




        ' This call is required by the designer.
        InitializeComponent()
        cmbDoctor.Text = doctor
        cmbWork1.Text = work1
        cmbWork2.Text = work2
        cmbWork3.Text = work3
        lblName.Text = name
        dateTreatment.Value = dateTreat
        lblId.Text = id
        rtbprescription.Text = prescription

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub TeethCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each control As Control In Me.Controls
            If TypeOf control Is RichTextBox Or TypeOf control Is Panel Then
                control.Visible = False
            End If
        Next
        rtbprescription.Visible = True
        pnlLine.Visible = True
        rtbPrice.Visible = True

    End Sub
    Private Sub HideandShow(rtb As RichTextBox, pnl As Panel)
        If pnl.Visible = False Then
            pnl.Visible = True
            rtb.Visible = True
        ElseIf pnl.Visible = True Then
            pnl.Visible = False
            rtb.Visible = False


        End If
    End Sub
    Private Sub btn18_Click(sender As Object, e As EventArgs) Handles btn18.Click
        HideandShow(rtb18, pnl18)
    End Sub

    Private Sub btn17_Click(sender As Object, e As EventArgs) Handles btn17.Click
        HideandShow(rtb17, pnl17)
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn16.Click
        HideandShow(rtb16, pnl16)
    End Sub

    Private Sub btn15_Click(sender As Object, e As EventArgs) Handles btn15.Click
        HideandShow(rtb15, pnl15)
    End Sub

    Private Sub btn14_Click(sender As Object, e As EventArgs) Handles btn14.Click
        HideandShow(rtb14, pnl14)
    End Sub

    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click
        HideandShow(rtb13, pnl13)
    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        HideandShow(rtb12, pnl12)
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        HideandShow(rtb11, pnl11)
    End Sub

    Private Sub btn21_Click(sender As Object, e As EventArgs) Handles btn21.Click
        HideandShow(rtb21, pnl21)
    End Sub

    Private Sub btn22_Click(sender As Object, e As EventArgs) Handles btn22.Click
        HideandShow(rtb22, pnl22)
    End Sub

    Private Sub btn23_Click(sender As Object, e As EventArgs) Handles btn23.Click
        HideandShow(rtb23, pnl23)
    End Sub

    Private Sub btn24_Click(sender As Object, e As EventArgs) Handles btn24.Click
        HideandShow(rtb24, pnl24)
    End Sub

    Private Sub btn25_Click(sender As Object, e As EventArgs) Handles btn25.Click
        HideandShow(rtb25, pnl25)
    End Sub

    Private Sub btn26_Click(sender As Object, e As EventArgs) Handles btn26.Click
        HideandShow(rtb26, pnl26)
    End Sub

    Private Sub btn27_Click(sender As Object, e As EventArgs) Handles btn27.Click
        HideandShow(rtb27, pnl27)
    End Sub

    Private Sub btn28_Click(sender As Object, e As EventArgs) Handles btn28.Click
        HideandShow(rtb28, pnl28)
    End Sub

    Private Sub btn38_Click(sender As Object, e As EventArgs) Handles btn38.Click
        HideandShow(rtb38, pnl38)
    End Sub

    Private Sub btn37_Click(sender As Object, e As EventArgs) Handles btn37.Click
        HideandShow(rtb37, pnl37)
    End Sub

    Private Sub btn36_Click(sender As Object, e As EventArgs) Handles btn36.Click
        HideandShow(rtb36, pnl36)
    End Sub

    Private Sub btn35_Click(sender As Object, e As EventArgs) Handles btn35.Click
        HideandShow(rtb35, pnl35)
    End Sub

    Private Sub btn34_Click(sender As Object, e As EventArgs) Handles btn34.Click
        HideandShow(rtb34, pnl34)
    End Sub

    Private Sub btn33_Click(sender As Object, e As EventArgs) Handles btn33.Click
        HideandShow(rtb33, pnl33)
    End Sub

    Private Sub btn32_Click(sender As Object, e As EventArgs) Handles btn32.Click
        HideandShow(rtb32, pnl32)
    End Sub

    Private Sub btn31_Click(sender As Object, e As EventArgs) Handles btn31.Click
        HideandShow(rtb31, pnl31)
    End Sub

    Private Sub btn41_Click(sender As Object, e As EventArgs) Handles btn41.Click
        HideandShow(rtb41, pnl41)
    End Sub

    Private Sub btn42_Click(sender As Object, e As EventArgs) Handles btn42.Click
        HideandShow(rtb42, pnl42)
    End Sub

    Private Sub btn43_Click(sender As Object, e As EventArgs) Handles btn43.Click
        HideandShow(rtb43, pnl43)
    End Sub

    Private Sub btn44_Click(sender As Object, e As EventArgs) Handles btn44.Click
        HideandShow(rtb44, pnl44)
    End Sub

    Private Sub btn45_Click(sender As Object, e As EventArgs) Handles btn45.Click
        HideandShow(rtb45, pnl45)
    End Sub

    Private Sub btn46_Click(sender As Object, e As EventArgs) Handles btn46.Click
        HideandShow(rtb46, pnl46)
    End Sub

    Private Sub btn47_Click(sender As Object, e As EventArgs) Handles btn47.Click
        HideandShow(rtb47, pnl47)
    End Sub

    Private Sub btn48_Click(sender As Object, e As EventArgs) Handles btn48.Click
        HideandShow(rtb48, pnl48)
    End Sub

    Private Sub RichTextBox1_Keypress(sender As Object, e As KeyPressEventArgs) Handles rtbPrice.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ControlChars.Back AndAlso Not e.KeyChar = "." Then
            ' If not a valid character, mark the event as handled to prevent input.
            e.Handled = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to save the details?", "Confirmation", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Try
                DatabaseManager.OpenConnection()
                Dim connection As MySqlConnection = DatabaseManager.GetConnection()
                Dim query As String = "INSERT INTO treatment (idpatients, workdone1, workdone2, workdone3, doctor, date_of_treatment, prescriptions, price, teeth_type, teeth11_label, teeth12_label, teeth13_label, teeth14_label, teeth15_label, teeth16_label, teeth17_label, teeth18_label, teeth21_label, teeth22_label, teeth23_label, teeth24_label, teeth25_label, teeth26_label, teeth27_label, teeth28_label, teeth31_label, teeth32_label, teeth33_label, teeth34_label, teeth35_label, teeth36_label, teeth37_label, teeth38_label, teeth41_label, teeth42_label, teeth43_label, teeth44_label, teeth45_label, teeth46_label, teeth47_label, teeth48_label) VALUES (@idpatient, @work1, @work2, @work3, @doctor, @date_treat, @prescription, @price, @teeth_type, @11, @12, @13, @14, @15, @16, @17, @18, @21, @22, @23, @24, @25, @26, @27, @28, @31, @32, @33, @34, @35, @36, @37, @38, @41, @42, @43, @44, @45, @46, @47, @48)"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@idpatient", lblId.Text)
                    cmd.Parameters.AddWithValue("@work1", cmbWork1.Text)
                    cmd.Parameters.AddWithValue("@work2", cmbWork2.Text)
                    cmd.Parameters.AddWithValue("@work3", cmbWork3.Text)
                    cmd.Parameters.AddWithValue("@doctor", cmbDoctor.Text)
                    cmd.Parameters.AddWithValue("@date_treat", dateTreatment.Text)
                    cmd.Parameters.AddWithValue("@prescription", rtbprescription.Text)
                    cmd.Parameters.AddWithValue("@price", rtbPrice.Text)
                    Dim teeth_type1 As String = "adult"
                    cmd.Parameters.AddWithValue("@teeth_type", teeth_type1)
                    cmd.Parameters.AddWithValue("@11", rtb11.Text)
                    cmd.Parameters.AddWithValue("@12", rtb12.Text)
                    cmd.Parameters.AddWithValue("@13", rtb13.Text)
                    cmd.Parameters.AddWithValue("@14", rtb14.Text)
                    cmd.Parameters.AddWithValue("@15", rtb15.Text)
                    cmd.Parameters.AddWithValue("@16", rtb16.Text)
                    cmd.Parameters.AddWithValue("@17", rtb17.Text)
                    cmd.Parameters.AddWithValue("@18", rtb18.Text)
                    cmd.Parameters.AddWithValue("@21", rtb21.Text)
                    cmd.Parameters.AddWithValue("@22", rtb22.Text)
                    cmd.Parameters.AddWithValue("@23", rtb23.Text)
                    cmd.Parameters.AddWithValue("@24", rtb24.Text)
                    cmd.Parameters.AddWithValue("@25", rtb25.Text)
                    cmd.Parameters.AddWithValue("@26", rtb26.Text)
                    cmd.Parameters.AddWithValue("@27", rtb27.Text)
                    cmd.Parameters.AddWithValue("@28", rtb28.Text)
                    cmd.Parameters.AddWithValue("@31", rtb31.Text)
                    cmd.Parameters.AddWithValue("@32", rtb32.Text)
                    cmd.Parameters.AddWithValue("@33", rtb33.Text)
                    cmd.Parameters.AddWithValue("@34", rtb34.Text)
                    cmd.Parameters.AddWithValue("@35", rtb35.Text)
                    cmd.Parameters.AddWithValue("@36", rtb36.Text)
                    cmd.Parameters.AddWithValue("@37", rtb37.Text)
                    cmd.Parameters.AddWithValue("@38", rtb38.Text)
                    cmd.Parameters.AddWithValue("@41", rtb41.Text)
                    cmd.Parameters.AddWithValue("@42", rtb42.Text)
                    cmd.Parameters.AddWithValue("@43", rtb43.Text)
                    cmd.Parameters.AddWithValue("@44", rtb44.Text)
                    cmd.Parameters.AddWithValue("@45", rtb45.Text)
                    cmd.Parameters.AddWithValue("@46", rtb46.Text)
                    cmd.Parameters.AddWithValue("@47", rtb47.Text)
                    cmd.Parameters.AddWithValue("@48", rtb48.Text)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                DatabaseManager.CloseConnection()
                Me.Close()
            End Try
        End If
    End Sub


End Class