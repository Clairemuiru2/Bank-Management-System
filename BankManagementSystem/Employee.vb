Imports Microsoft.Data.Sqlite

Module Employee

    ' REGISTER EMPLOYEE
    Public Function RegisterEmployee(
        fullName As String,
        email As String,
        phone As String,
        pin As String
    ) As Boolean

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            Dim query As String =
                "INSERT INTO Employees
                (FullName, Email, Phone, Pin)
                VALUES
                (@FullName, @Email, @Phone, @Pin)"

            Dim command As New SqliteCommand(query, connection)

            command.Parameters.AddWithValue("@FullName", fullName)
            command.Parameters.AddWithValue("@Email", email)
            command.Parameters.AddWithValue("@Phone", phone)
            command.Parameters.AddWithValue("@Pin", pin)

            Try

                command.ExecuteNonQuery()

                Return True

            Catch ex As Exception

                Return False

            End Try

        End Using

    End Function

    ' EMPLOYEE LOGIN
    Public Function EmployeeLogin(pin As String) As Boolean

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            Dim query As String =
                "SELECT * FROM Employees
                 WHERE Pin = @Pin"

            Dim command As New SqliteCommand(query, connection)

            command.Parameters.AddWithValue("@Pin", pin)

            Dim reader = command.ExecuteReader()

            If reader.Read() Then

                Return True

            Else

                Return False

            End If

        End Using

    End Function

End Module