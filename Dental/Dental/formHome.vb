Imports System.Diagnostics.Tracing
Imports System.Media
Imports System.Threading
Imports MySql.Data.MySqlClient

Public Class formHome
    Private Shared _currentInstance As formHome = Nothing
    Dim idValue

    Public Sub New(selectedValue As Integer)
        ' Initialize the form with the selected value.
        idValue = selectedValue
        InitializeComponent()
        _currentInstance = Me
    End Sub
    Public Shared Sub CloseCurrentInstance()
        If _currentInstance IsNot Nothing AndAlso Not _currentInstance.IsDisposed Then
            _currentInstance.Close()
        End If
    End Sub
    Public ReadOnly Property IDValueFromHomeForm As Integer
        Get
            Return idValue
        End Get
    End Property
    Private Sub HighlightButton(button As Button)
        ' Reset the appearance of all buttons
        Dim myColor As Color = Color.FromArgb(252, 197, 192)
        'Dim highlight As Color = Color.FromArgb(248, 163, 144)
        btnDashboard.BackColor = Color.MistyRose

        btnAppointments.BackColor = Color.MistyRose
        btnPatients.BackColor = Color.MistyRose

        btnDashboard.SendToBack()
        btnAppointments.SendToBack()
        btnPatients.SendToBack()



        ' Highlight the selected button
        button.BackColor = myColor


    End Sub


    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Automatically click the btnHome button on form load
        HighlightButton(btnDashboard)
        Dim formDashboard As New formDashboard(Me)

        ShowFormInContainer(formDashboard)
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

    Private Sub ShowFormInContainer(form As Form)
        ' Clear the PanelContainer
        panelView.Controls.Clear()
        ' Dock the selected form in the PanelContainer
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        panelView.Controls.Add(form)

        form.Show()
    End Sub

    Public Sub BtnPatients_Click(sender As Object, e As EventArgs) Handles btnPatients.Click
        Dim Patients As New Patients()
        HighlightButton(btnPatients)

        ShowFormInContainer(Patients)
    End Sub
    Public Shared Sub CallBtnPatientsClick()
        If _currentInstance IsNot Nothing Then
            _currentInstance.BtnPatients_Click(Nothing, EventArgs.Empty)
        End If
    End Sub
    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim formDashboard As New formDashboard(Me)
        HighlightButton(btnDashboard)

        ShowFormInContainer(formDashboard)
    End Sub




    Public Sub BtnAppointments_Click(sender As Object, e As EventArgs) Handles btnAppointments.Click
        Dim formAppointments As New formAppointments()
        HighlightButton(btnAppointments)


        ShowFormInContainer(formAppointments)
    End Sub
    Public Shared Sub CallBtnAppointmentsClick()
        If _currentInstance IsNot Nothing Then
            _currentInstance.BtnAppointments_Click(Nothing, EventArgs.Empty)
        End If
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim PasswordForm As New PasswordForm(Me)
        PasswordForm.Show()
    End Sub



    Private Sub panelView_Paint(sender As Object, e As PaintEventArgs) Handles panelView.Paint

    End Sub
    Public Shared Sub DisableFormHome()
        If _currentInstance IsNot Nothing Then
            _currentInstance.Enabled = False
        End If
    End Sub
    Public Shared Sub EnableFormHome()
        If _currentInstance IsNot Nothing Then
            _currentInstance.Enabled = True
        End If
    End Sub

    Private Function GetPanelVisible() As Panel
        Return panelVisible
    End Function

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



    Private Sub btnLogoutAccount_Click(sender As Object, e As EventArgs) Handles btnLogoutAccount.Click
        Me.Close()
        Dim Form1 As New Form1
        Form1.Show()

    End Sub
End Class