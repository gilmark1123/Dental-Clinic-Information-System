Imports MySql.Data.MySqlClient

Module Module2


    Public Class DatabaseManager
        Private Shared connectionString As String = "Server=127.0.0.1;Port=3307;Database=clinic_tooth;User=root;Password=password123"
        Private Shared connection As MySqlConnection

        Public Shared Sub OpenConnection()
            connection = New MySqlConnection(connectionString)
            connection.Open()
        End Sub

        Public Shared Sub CloseConnection()
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Sub

        Public Shared Function GetConnection() As MySqlConnection
            Return connection
        End Function
    End Class

End Module
