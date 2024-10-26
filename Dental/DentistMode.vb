Imports System.Drawing.Drawing2D
Imports System.Threading
Imports MySql.Data.MySqlClient

Public Class DentistMode
    Private formPatients As formPatients
    Private Shared _currentInstance As DentistMode = Nothing
    Dim idValue As Integer
    Dim prevId As Integer
    Public Sub New(selectedValue As Integer, previousUser As Integer)
        ' Initialize the form with the selected value.
        idValue = selectedValue

        prevId = previousUser
        InitializeComponent()
        _currentInstance = Me
        Try
            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()

            Dim query As String = "SELECT * FROM account WHERE idaccount =" & idValue & ""
            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim firstName As String = reader("first").ToString()
                        Dim lastname As String = reader("last")

                        Dim capitalizedFirstName As String = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1).ToLower()
                        Dim capitalizedLastName As String = lastname.Substring(0, 1).ToUpper() + lastname.Substring(1).ToLower()
                        btnLogout.Text = capitalizedFirstName & " " & capitalizedLastName


                    End If


                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Public Shared Sub DisableFormDentist()
        If _currentInstance IsNot Nothing Then
            _currentInstance.Enabled = False
        End If
    End Sub
    Public Shared Sub EnableFormDentist()
        If _currentInstance IsNot Nothing Then
            _currentInstance.Enabled = True
        End If
    End Sub
    Public Shared Sub CloseCurrentInstance()
        If _currentInstance IsNot Nothing AndAlso Not _currentInstance.IsDisposed Then
            _currentInstance.Close()
        End If
    End Sub


    ' Method to display formPatientDetails in Panel3 in DentistMode
    Public Sub DisplayFormPatientDetails(selectedValue)
        Dim formPatientDetailsInstance As New formPatientDetails(selectedValue, Me)
        formPatientDetailsInstance.TopLevel = False
        formPatientDetailsInstance.FormBorderStyle = FormBorderStyle.None
        formPatientDetailsInstance.Dock = DockStyle.Fill

        ' Clear Panel3 in DentistMode if there's anything in it
        Panel3.Controls.Clear()

        ' Add formPatientDetails to DentistMode's Panel3
        Panel3.Controls.Add(formPatientDetailsInstance)

        formPatientDetailsInstance.Show()
    End Sub

    Public Sub btnPatients_Click(sender As Object, e As EventArgs) Handles btnPatients.Click
        Dim formPatients As New formPatients(Me)
        ShowFormInContainer(formPatients)
        HighlightButton(btnPatients)
        lblCurrentPlace.Text = "Patients"
    End Sub

    Private Sub HighlightButton(button As Button)
        btnPatients.BackColor = Color.MistyRose

        btnDashboard.BackColor = Color.MistyRose
        btnAppointment.BackColor = Color.MistyRose
        btnDentist.BackColor = Color.MistyRose
        btnEmployee.BackColor = Color.MistyRose
        Dim mediumPink As Color = Color.FromArgb(255, 255, 192, 203)
        ' Highlight the selected button
        button.BackColor = mediumPink

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim formDashboard As New dashboard(idValue, Me)
        ShowFormInContainer(formDashboard)
        HighlightButton(btnDashboard)
        lblCurrentPlace.Text = "Dashboard"
    End Sub
    Private Sub ShowFormInContainer(form As Form)
        ' Clear the PanelContainer
        Panel3.Controls.Clear()
        ' Dock the selected form in the PanelContainer
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill

        Panel3.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub DentistMode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPatients_Click(sender, e)
        MakeCircularPictureBox(PictureBox4)
    End Sub
    Private Sub MakeCircularPictureBox(pictureBox As PictureBox)
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, pictureBox.Width - 1, pictureBox.Height - 1)
        pictureBox.Region = New Region(path)
    End Sub
    Private Sub btnDentist_Click(sender As Object, e As EventArgs) Handles btnDentist.Click
        Dim formDentist As New formDentist
        ShowFormInContainer(formDentist)
        HighlightButton(btnDentist)
        lblCurrentPlace.Text = "Dentist"
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If panelVisible.Visible = True Then
            FadeOutPanel(panelVisible)
        Else
            FadeInPanel(panelVisible)
        End If
    End Sub
    Private Sub FadeOutPanel(panel As Panel)
        If panel.Visible = True Then
            If panel.Tag Is Nothing Then
                panel.Tag = 1.0 ' Initial opacity value
            End If

            Dim opacity As Double = CDbl(panel.Tag)
            opacity -= 0.05 ' Adjust the increment to control the speed of fade-out

            If opacity <= 0 Then
                panel.Visible = False
                panel.Tag = Nothing
                panelTransitionTimer.Stop()
            Else
                panel.Tag = opacity
                panel.BackColor = Color.FromArgb(CInt(opacity * 255), panel.BackColor.R, panel.BackColor.G, panel.BackColor.B)
                panelTransitionTimer.Start()
            End If
        End If
    End Sub

    Private Sub FadeInPanel(panel As Panel)
        If panel.Visible = False Then
            panel.Visible = True
            If panel.Tag Is Nothing Then
                panel.Tag = 0.0 ' Initial opacity value
            End If

            Dim opacity As Double = CDbl(panel.Tag)
            opacity += 0.05 ' Adjust the increment to control the speed of fade-in

            If opacity >= 1 Then
                panel.Tag = Nothing
                panelTransitionTimer.Stop()
            Else
                panel.Tag = opacity
                panel.BackColor = Color.FromArgb(CInt(opacity * 255), panel.BackColor.R, panel.BackColor.G, panel.BackColor.B)
                panelTransitionTimer.Start()
            End If
        End If
    End Sub

    Public Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click
        Dim formDentist As New formDentist
        ShowFormInContainer(frmDentistAppointment)
        HighlightButton(btnAppointment)
        lblCurrentPlace.Text = "Appointments"
    End Sub
    Public Shared Sub CallBtnAppointmentsClick()
        If _currentInstance IsNot Nothing Then
            _currentInstance.btnAppointment_Click(Nothing, EventArgs.Empty)
        End If
    End Sub

    Private Sub btnLogoutAccount_Click(sender As Object, e As EventArgs) Handles btnLogoutAccount.Click
        If prevId = 0 Then
            Me.Close()
            Form1.Show()
        Else
            Dim formHome As New formHome(prevId)
            formHome.Show()
            Me.Close()

        End If
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        Dim formEmployee As New formEmployee
        ShowFormInContainer(formEmployee)
        HighlightButton(btnEmployee)
        lblCurrentPlace.Text = "Employee"
    End Sub
End Class