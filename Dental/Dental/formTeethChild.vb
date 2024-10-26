Imports MySql.Data.MySqlClient

Public Class formTeethChild
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
    Private Sub HideandShow(rtb As RichTextBox, pnl As Panel)
        If pnl.Visible = False Then
            pnl.Visible = True
            rtb.Visible = True
        ElseIf pnl.Visible = True Then
            pnl.Visible = False
            rtb.Visible = False
        End If
    End Sub

    Private Sub formTeethChild_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each control As Control In Me.Controls
            If TypeOf control Is RichTextBox Or TypeOf control Is Panel Then
                control.Visible = False
            End If
        Next
        rtbprescription.Visible = True
        pnlLine.Visible = True
        rtbPrice.Visible = True
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        HideandShow(rtbA, pnlA)
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        HideandShow(rtbB, pnlB)
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        HideandShow(rtbC, pnlC)
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        HideandShow(rtbD, pnlD)
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        HideandShow(rtbE, pnlE)
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        HideandShow(rtbF, pnlF)
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        HideandShow(rtbG, pnlG)
    End Sub

    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        HideandShow(rtbH, pnlH)
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        HideandShow(rtbI, pnlI)
    End Sub

    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        HideandShow(rtbJ, pnlJ)
    End Sub

    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        HideandShow(rtbK, pnlK)
    End Sub

    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        HideandShow(rtbL, pnlL)
    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        HideandShow(rtbM, pnlM)
    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        HideandShow(rtbN, pnlN)
    End Sub

    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        HideandShow(rtbO, pnlO)
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        HideandShow(rtbP, pnlP)
    End Sub

    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        HideandShow(rtbQ, pnlQ)
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        HideandShow(rtbR, pnlR)
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        HideandShow(rtbS, pnlS)
    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        HideandShow(rtbT, pnlT)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to save the details?", "Confirmation", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Try
                DatabaseManager.OpenConnection()
                Dim connection As MySqlConnection = DatabaseManager.GetConnection()
                Dim query As String = "INSERT INTO treatment (idpatients, workdone1, workdone2, workdone3, doctor, date_of_treatment, prescriptions, price, teeth_type,teeth18_label, teeth17_label, teeth16_label, teeth15_label , teeth14_label, teeth24_label, teeth25_label , teeth26_label, teeth27_label, teeth28_label, teeth48_label, teeth47_label, teeth46_label, teeth45_label, teeth44_label,teeth34_label,teeth35_label, teeth36_label, teeth37_label, teeth38_label) VALUES (@idpatient, @work1, @work2, @work3, @doctor, @date_treat, @prescription, @price, @teeth_type,@A, @B, @C, @D, @E, @F, @G, @H, @I, @J, @T, @S, @R , @Q, @P, @O, @N, @M, @L, @K)"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@idpatient", lblId.Text)
                    cmd.Parameters.AddWithValue("@work1", cmbWork1.Text)
                    cmd.Parameters.AddWithValue("@work2", cmbWork2.Text)
                    cmd.Parameters.AddWithValue("@work3", cmbWork3.Text)
                    cmd.Parameters.AddWithValue("@doctor", cmbDoctor.Text)
                    cmd.Parameters.AddWithValue("@date_treat", dateTreatment.Text)
                    cmd.Parameters.AddWithValue("@prescription", rtbprescription.Text)
                    cmd.Parameters.AddWithValue("@price", rtbPrice.Text)
                    Dim teeth_type1 As String = "child"
                    cmd.Parameters.AddWithValue("@teeth_type", teeth_type1)
                    cmd.Parameters.AddWithValue("@A", rtbA.Text)
                    cmd.Parameters.AddWithValue("@B", rtbB.Text)
                    cmd.Parameters.AddWithValue("@C", rtbC.Text)
                    cmd.Parameters.AddWithValue("@D", rtbD.Text)
                    cmd.Parameters.AddWithValue("@E", rtbE.Text)
                    cmd.Parameters.AddWithValue("@F", rtbF.Text)
                    cmd.Parameters.AddWithValue("@G", rtbG.Text)
                    cmd.Parameters.AddWithValue("@H", rtbH.Text)
                    cmd.Parameters.AddWithValue("I", rtbI.Text)
                    cmd.Parameters.AddWithValue("@J", rtbJ.Text)
                    cmd.Parameters.AddWithValue("@K", rtbK.Text)
                    cmd.Parameters.AddWithValue("@L", rtbL.Text)
                    cmd.Parameters.AddWithValue("@M", rtbM.Text)
                    cmd.Parameters.AddWithValue("@N", rtbN.Text)
                    cmd.Parameters.AddWithValue("@O", rtbO.Text)
                    cmd.Parameters.AddWithValue("@P", rtbF.Text)
                    cmd.Parameters.AddWithValue("@Q", rtbQ.Text)
                    cmd.Parameters.AddWithValue("@R", rtbR.Text)
                    cmd.Parameters.AddWithValue("@S", rtbS.Text)
                    cmd.Parameters.AddWithValue("@T", rtbT.Text)
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

    Private Sub rtbPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtbPrice.KeyPress
        ' Check if the pressed key is a digit or a control character (e.g., Backspace or Delete).
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If it's not a digit or a control character, suppress the keypress.
            e.Handled = True
        End If
    End Sub

End Class