Imports MySql.Data.MySqlClient

Public Class formEmployee
    Private Sub formEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ComboBox1.AutoCompleteMode = AutoCompleteMode.Suggest
        ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
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
        Try
            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()
            Dim query As String = "SELECT first FROM account WHERE doctorMode IS NULL ORDER BY first;"
            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read
                        Dim fName = reader.GetString("first")
                        ComboBox1.Items.Add(fName)
                    End While
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        View.Rows.Clear()
        Dim searched As String = ComboBox1.Text
        Try
            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()
            Dim query As String = "SELECT * FROM account WHERE doctorMode IS NULL;"
            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ' Populate the pre-made columns in your DataGridView
                        Dim rowIndex As Integer = View.Rows.Add()
                        Dim firstName As String = reader("first").ToString()
                        Dim lastname As String = reader("last")

                        Dim capitalizedFirstName As String = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1).ToLower()
                        Dim capitalizedLastName As String = lastname.Substring(0, 1).ToUpper() + lastname.Substring(1).ToLower()
                        View.Rows(rowIndex).Cells("colPatientID").Value = reader("idaccount")
                        View.Rows(rowIndex).Cells("colFirstName").Value = "" & capitalizedFirstName & " " & capitalizedLastName & ""
                        Dim province As String = reader("province").ToString()
                        Dim city As String = reader("city").ToString()
                        Dim baranggay As String = reader("baranggay").ToString()
                        Dim houseNumber As String = reader("house").ToString()
                        Dim address As String = $"{houseNumber}, {baranggay}, {city}, {province}"
                        View.Rows(rowIndex).Cells("colAddress").Value = address
                        View.Rows(rowIndex).Cells("colSex").Value = reader("sex")
                        View.Rows(rowIndex).Cells("colContactNumber").Value = reader("number")
                    End While
                End Using
            End Using

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        View.Rows.Clear()
        Dim searched As String = ComboBox1.Text
        Try
            DatabaseManager.OpenConnection()
            Dim connection As MySqlConnection = DatabaseManager.GetConnection()
            Dim query As String = "SELECT * FROM account WHERE first = '" & searched & "' AND doctorMode IS NULL;"
            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ' Populate the pre-made columns in your DataGridView
                        Dim rowIndex As Integer = View.Rows.Add()
                        Dim firstName As String = reader("first").ToString()
                        Dim lastname As String = reader("last")

                        Dim capitalizedFirstName As String = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1).ToLower()
                        Dim capitalizedLastName As String = lastname.Substring(0, 1).ToUpper() + lastname.Substring(1).ToLower()
                        View.Rows(rowIndex).Cells("colPatientID").Value = reader("idaccount")
                        View.Rows(rowIndex).Cells("colFirstName").Value = "" & capitalizedFirstName & " " & capitalizedLastName & ""
                        Dim province As String = reader("province").ToString()
                        Dim city As String = reader("city").ToString()
                        Dim baranggay As String = reader("baranggay").ToString()
                        Dim houseNumber As String = reader("house").ToString()
                        Dim address As String = $"{houseNumber}, {baranggay}, {city}, {province}"
                        View.Rows(rowIndex).Cells("colAddress").Value = address
                        View.Rows(rowIndex).Cells("colSex").Value = reader("sex")
                        View.Rows(rowIndex).Cells("colContactNumber").Value = reader("number")
                    End While
                End Using
            End Using

        Catch ex As Exception

        End Try
    End Sub
End Class