Imports MySql.Data.MySqlClient

Public Class frmDentistAppointment
    Private WithEvents formAppointments1 As formAddAppointments
    Private WithEvents formEditAppointment1 As formEditAppointment
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DentistMode.DisableFormDentist()
        ' Initialize the new form
        formAppointments1 = New formAddAppointments()
        AddHandler formAppointments1.FormClosed, AddressOf formAppointments1_FormClosed
        ' Show the new form
        formAppointments1.Show()


    End Sub
    Private Sub formAppointments1_FormClosed(sender As Object, e As FormClosedEventArgs)
        DentistMode.EnableFormDentist()
        Me.Refresh()
        ' Clean up the event handler
        RemoveHandler formAppointments1.FormClosed, AddressOf formAppointments1_FormClosed
        formAppointments1.Dispose()
        LoadAppointments()
    End Sub

    Public Sub formAppointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        View.CellBorderStyle = DataGridViewCellBorderStyle.None

        ' Set the font and style for the headers
        Dim headerStyle As New DataGridViewCellStyle()
        headerStyle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        View.ColumnHeadersDefaultCellStyle = headerStyle

        ' Set various cell styling attributes
        View.DefaultCellStyle.WrapMode = DataGridViewTriState.True ' Optional: Wrap text if needed
        View.DefaultCellStyle.BackColor = Color.White ' Set the background color for cells
        View.DefaultCellStyle.ForeColor = Color.Black ' Set the text color for cells
        View.DefaultCellStyle.SelectionBackColor = Color.LightPink ' Set the background color for selected cells
        View.DefaultCellStyle.SelectionForeColor = Color.White ' Set the text color for selected cells

        ' Hide row headers
        View.RowHeadersVisible = False
        Dim columnStyle As New DataGridViewCellStyle()
        columnStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold) ' Set font to Segoe UI and bold
        View.Columns(0).DefaultCellStyle = columnStyle
        LoadAppointments()



    End Sub


    Private Sub View_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles View.CellContentClick
        ' Check if the clicked column is the button column (colRemarks) and the clicked row is valid
        If e.ColumnIndex = View.Columns("colDelete").Index AndAlso e.RowIndex >= 0 Then
            ' Get the value of the colID column for the clicked row
            Dim colIDValue As String = View.Rows(e.RowIndex).Cells("colID").Value.ToString()
            Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmation = DialogResult.Yes Then
                Try
                    DatabaseManager.OpenConnection()
                    Dim connection As MySqlConnection = DatabaseManager.GetConnection()




                    ' Your database deletion query code here
                    ' Example: Delete the row based on the appointment ID
                    Dim query As String = $"UPDATE appointment SET active = 0 WHERE appointment_id = @id;"
                    Using cmd As New MySqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@id", colIDValue)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Remove the row from the DataGridView
                    View.Rows.RemoveAt(e.RowIndex)

                    MessageBox.Show("Appointment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    LoadAppointments()
                    DatabaseManager.CloseConnection()
                End Try
            End If
        End If
        If e.ColumnIndex = View.Columns("colEdit").Index AndAlso e.RowIndex >= 0 Then

            Dim colIDValue As String = View.Rows(e.RowIndex).Cells("colID").Value.ToString()
            Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to edit this appointment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmation = DialogResult.Yes Then
                DentistMode.DisableFormDentist()
                formEditAppointment1 = New formEditAppointment(colIDValue)
                AddHandler formEditAppointment1.FormClosed, AddressOf formEditAppointment1_FormClosed
                ' Show the new form
                formEditAppointment1.Show()

            End If
        End If
    End Sub
    Private Sub formEditAppointment1_FormClosed(sender As Object, e As FormClosedEventArgs)
        DentistMode.EnableFormDentist()
        Me.Refresh()
        ' Clean up the event handler
        RemoveHandler formEditAppointment1.FormClosed, AddressOf formEditAppointment1_FormClosed
        formEditAppointment1.Dispose()
        LoadAppointments()
    End Sub
    Private Sub LoadAppointments()
        View.Rows.Clear()

        Try
            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()

            ' Your database query code here
            ' Example: Insert data into the database

            Dim query As String = "SELECT * FROM appointment WHERE active = 1 ORDER BY appointment_date;"

            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ' Populate the pre-made columns in your DataGridView
                        Dim rowIndex As Integer = View.Rows.Add()
                        View.Rows(rowIndex).Cells("colPatient").Value = reader("patients")
                        View.Rows(rowIndex).Cells("colDoctor").Value = reader("doctor")
                        View.Rows(rowIndex).Cells("colOperation").Value = reader("operation")
                        Dim dateMade As String = reader.GetString("appointment_date")
                        Dim timeSet As Date = reader.GetString("appointment_date")
                        Dim currentDate As String = DateTime.Now.ToString("dd/MM/yyyy")

                        If currentDate > timeSet Then
                            View.Rows(rowIndex).Cells("colStatus").Value = "Overdue"
                            View.Rows(rowIndex).Cells("colStatus").Style.ForeColor = Color.Red
                        Else
                            View.Rows(rowIndex).Cells("colStatus").Value = reader("status")
                            View.Rows(rowIndex).Cells("colStatus").Style.ForeColor = Color.Green
                        End If

                        Dim strippedDateRegister As String = dateMade.Substring(0, dateMade.Length - 12)
                        View.Rows(rowIndex).Cells("colDate").Value = strippedDateRegister

                        View.Rows(rowIndex).Cells("colId").Value = reader("appointment_id")
                        Dim delete As String = reader("appointment_id")
                        If Not String.IsNullOrEmpty(delete) Then
                            ' Create a button cell
                            Dim btnCell As New DataGridViewButtonCell()
                            Dim btnCell1 As New DataGridViewButtonCell()
                            ' Set button text to "Delete"
                            btnCell.Value = "Delete"
                            btnCell1.Value = "Edit"
                            ' Customize button appearance

                            btnCell.Style.ForeColor = Color.Black ' Change the text color to Black
                            btnCell.Style.Font = New Font("Arial", 10, FontStyle.Bold)

                            ' Set the button size
                            btnCell.Style.Padding = New Padding(10, 0, 10, 0) ' Adjust padding for a 71x29 size


                            btnCell1.Style.ForeColor = Color.Black ' Change the text color to Black
                            btnCell1.Style.Font = New Font("Arial", 10, FontStyle.Bold)

                            ' Set the button size
                            btnCell1.Style.Padding = New Padding(10, 0, 10, 0)
                            ' Add button cell to the DataGridView
                            View.Rows(rowIndex).Cells("colDelete") = btnCell
                            View.Rows(rowIndex).Cells("colEdit") = btnCell1
                        End If
                    End While
                End Using
            End Using


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Dim targetValue As String = DateTime.Now.ToString("dd/MM/yyyy") ' Replace with the specific value you're looking for
        Dim rowCount As Integer = 0

        For Each row As DataGridViewRow In View.Rows
            If row.Cells("colDate").Value IsNot Nothing AndAlso row.Cells("colDate").Value.ToString() = targetValue Then
                rowCount += 1
            End If
        Next
        lblAppointments.Text = rowCount.ToString()
        Dim countPending As Integer = 0
        Dim value As String = "Pending"
        For Each row As DataGridViewRow In View.Rows
            If row.Cells("colStatus").Value IsNot Nothing AndAlso row.Cells("colStatus").Value.ToString() = value Then
                countPending += 1
            End If
        Next
        lblUpcoming.Text = countPending.ToString()
    End Sub
End Class