Imports Microsoft.Data.Sqlite
Imports System.Data

Module Customer

    ' ADD CUSTOMER
    Public Function AddCustomer(
        fullName As String,
        accountNumber As String,
        phone As String,
        address As String,
        email As String,
        idNumber As String
    ) As Boolean

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            Dim query As String =
                "INSERT INTO Customers
                (FullName, AccountNumber, Phone, Address, Email, IdNumber)
                VALUES
                (@FullName, @AccountNumber, @Phone, @Address, @Email, @IdNumber)"

            Dim command As New SqliteCommand(query, connection)

            command.Parameters.AddWithValue("@FullName", fullName)
            command.Parameters.AddWithValue("@AccountNumber", accountNumber)
            command.Parameters.AddWithValue("@Phone", phone)
            command.Parameters.AddWithValue("@Address", address)
            command.Parameters.AddWithValue("@Email", email)
            command.Parameters.AddWithValue("@IdNumber", idNumber)

            Try

                command.ExecuteNonQuery()

                Return True

            Catch ex As Exception

                Return False

            End Try

        End Using

    End Function

    ' DEPOSIT MONEY
    Public Function DepositMoney(
        accountNumber As String,
        amount As Double
    ) As Boolean

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            Dim query As String =
                "UPDATE Customers
                 SET Balance = Balance + @Amount
                 WHERE AccountNumber = @AccountNumber"

            Dim command As New SqliteCommand(query, connection)

            command.Parameters.AddWithValue("@Amount", amount)
            command.Parameters.AddWithValue("@AccountNumber", accountNumber)

            Dim rowsAffected As Integer =
                command.ExecuteNonQuery()

            If rowsAffected > 0 Then

                SaveTransaction(accountNumber, "Deposit", amount)

                Return True

            Else

                Return False

            End If

        End Using

    End Function

    ' WITHDRAW MONEY
    Public Function WithdrawMoney(
        accountNumber As String,
        amount As Double
    ) As Boolean

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            ' CHECK BALANCE
            Dim balanceQuery As String =
                "SELECT Balance
                 FROM Customers
                 WHERE AccountNumber = @AccountNumber"

            Dim balanceCommand As New SqliteCommand(balanceQuery, connection)

            balanceCommand.Parameters.AddWithValue("@AccountNumber", accountNumber)

            Dim result = balanceCommand.ExecuteScalar()

            If result Is Nothing Then

                Return False

            End If

            Dim currentBalance As Double =
                Convert.ToDouble(result)

            If amount > currentBalance Then

                Return False

            End If

            ' WITHDRAW
            Dim withdrawQuery As String =
                "UPDATE Customers
                 SET Balance = Balance - @Amount
                 WHERE AccountNumber = @AccountNumber"

            Dim withdrawCommand As New SqliteCommand(withdrawQuery, connection)

            withdrawCommand.Parameters.AddWithValue("@Amount", amount)
            withdrawCommand.Parameters.AddWithValue("@AccountNumber", accountNumber)

            withdrawCommand.ExecuteNonQuery()

            SaveTransaction(accountNumber, "Withdrawal", amount)

            Return True

        End Using

    End Function

    Public Function GetCustomers() As DataTable

        Dim table As New DataTable()

        table.Columns.Add("ID")
        table.Columns.Add("Full Name")
        table.Columns.Add("Account Number")
        table.Columns.Add("Phone")
        table.Columns.Add("Address")
        table.Columns.Add("Email")
        table.Columns.Add("ID Number")
        table.Columns.Add("Balance")

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            Dim query As String =
                "SELECT * FROM Customers"

            Dim command As New SqliteCommand(query, connection)

            Dim reader = command.ExecuteReader()

            While reader.Read()

                table.Rows.Add(
                    reader("Id"),
                    reader("FullName"),
                    reader("AccountNumber"),
                    reader("Phone"),
                    reader("Address"),
                    reader("Email"),
                    reader("IdNumber"),
                    reader("Balance")
                )

            End While

        End Using

        Return table

    End Function

    Public Function GetCustomerByAccount(
    accountNumber As String
) As DataTable

        Dim table As New DataTable()

        table.Columns.Add("ID")
        table.Columns.Add("Full Name")
        table.Columns.Add("Account Number")
        table.Columns.Add("Phone")
        table.Columns.Add("Address")
        table.Columns.Add("Email")
        table.Columns.Add("ID Number")
        table.Columns.Add("Balance")

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            Dim query As String =
                "SELECT * FROM Customers
             WHERE AccountNumber = @AccountNumber"

            Dim command As New SqliteCommand(query, connection)

            command.Parameters.AddWithValue("@AccountNumber", accountNumber)

            Dim reader = command.ExecuteReader()

            While reader.Read()

                table.Rows.Add(
                    reader("Id"),
                    reader("FullName"),
                    reader("AccountNumber"),
                    reader("Phone"),
                    reader("Address"),
                    reader("Email"),
                    reader("IdNumber"),
                    reader("Balance")
                )

            End While

        End Using

        Return table

    End Function

    Public Function UpdateCustomer(
    accountNumber As String,
    fullName As String,
    phone As String,
    address As String,
    email As String,
    idNumber As String
) As Boolean

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            Dim query As String =
                "UPDATE Customers 
             SET FullName = @FullName,
                 Phone = @Phone,
                 Address = @Address,
                 Email = @Email,
                 IdNumber = @IdNumber
             WHERE AccountNumber = @AccountNumber"

            Dim command As New SqliteCommand(query, connection)

            command.Parameters.AddWithValue("@FullName", fullName)
            command.Parameters.AddWithValue("@Phone", phone)
            command.Parameters.AddWithValue("@Address", address)
            command.Parameters.AddWithValue("@Email", email)
            command.Parameters.AddWithValue("@IdNumber", idNumber)
            command.Parameters.AddWithValue("@AccountNumber", accountNumber)

            Dim rows = command.ExecuteNonQuery()

            Return rows > 0

        End Using

    End Function

    Public Function DeleteCustomer(accountNumber As String) As Boolean

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            Dim query As String =
                "DELETE FROM Customers WHERE AccountNumber = @AccountNumber"

            Dim command As New SqliteCommand(query, connection)

            command.Parameters.AddWithValue("@AccountNumber", accountNumber)

            Dim rows = command.ExecuteNonQuery()

            Return rows > 0

        End Using

    End Function

    Public Function TransferMoney(
    senderAccount As String,
    receiverAccount As String,
    amount As Double
) As Boolean

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            Dim transaction = connection.BeginTransaction()

            Try

                ' CHECK BALANCE
                Dim balanceQuery As String =
                    "SELECT Balance FROM Customers
                 WHERE AccountNumber = @AccountNumber"

                Dim balanceCommand As New SqliteCommand(balanceQuery, connection)

                balanceCommand.Parameters.AddWithValue(
                    "@AccountNumber",
                    senderAccount
                )

                Dim balance =
                    Convert.ToDouble(balanceCommand.ExecuteScalar())

                If balance < amount Then
                    Return False
                End If

                ' REMOVE FROM SENDER
                Dim withdrawQuery As String =
                    "UPDATE Customers
                 SET Balance = Balance - @Amount
                 WHERE AccountNumber = @Sender"

                Dim withdrawCommand As New SqliteCommand(withdrawQuery, connection)

                withdrawCommand.Parameters.AddWithValue("@Amount", amount)
                withdrawCommand.Parameters.AddWithValue("@Sender", senderAccount)

                withdrawCommand.ExecuteNonQuery()

                ' ADD TO RECEIVER
                Dim depositQuery As String =
                    "UPDATE Customers
                 SET Balance = Balance + @Amount
                 WHERE AccountNumber = @Receiver"

                Dim depositCommand As New SqliteCommand(depositQuery, connection)

                depositCommand.Parameters.AddWithValue("@Amount", amount)
                depositCommand.Parameters.AddWithValue("@Receiver", receiverAccount)

                depositCommand.ExecuteNonQuery()

                transaction.Commit()

                Return True

            Catch ex As Exception

                transaction.Rollback()

                Return False

            End Try

        End Using

    End Function

    Public Function GetTotalBalance() As Double

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            Dim query As String =
                "SELECT SUM(Balance) FROM Customers"

            Dim command As New SqliteCommand(query, connection)

            Dim result = command.ExecuteScalar()

            If IsDBNull(result) Then
                Return 0
            End If

            Return Convert.ToDouble(result)

        End Using

    End Function

End Module

