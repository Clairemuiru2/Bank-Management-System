Imports Microsoft.Data.Sqlite

Module TransactionHelper

    ' SAVE TRANSACTION
    Public Sub SaveTransaction(
        accountNumber As String,
        transactionType As String,
        amount As Double
    )

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            Dim query As String =
                "INSERT INTO Transactions
                (AccountNumber, TransactionType, Amount, TransactionDate)
                VALUES
                (@AccountNumber, @TransactionType, @Amount, @TransactionDate)"

            Dim command As New SqliteCommand(query, connection)

            command.Parameters.AddWithValue("@AccountNumber", accountNumber)
            command.Parameters.AddWithValue("@TransactionType", transactionType)
            command.Parameters.AddWithValue("@Amount", amount)
            command.Parameters.AddWithValue("@TransactionDate", DateTime.Now.ToString())

            command.ExecuteNonQuery()

        End Using

    End Sub

    ' TOTAL DEPOSITS
    Public Function GetTotalDeposits() As Double

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            Dim query As String =
                "SELECT SUM(Amount)
                 FROM Transactions
                 WHERE TransactionType = 'Deposit'"

            Dim command As New SqliteCommand(query, connection)

            Dim result = command.ExecuteScalar()

            If result Is DBNull.Value Then
                Return 0
            Else
                Return Convert.ToDouble(result)
            End If

        End Using

    End Function

    ' TOTAL WITHDRAWALS
    Public Function GetTotalWithdrawals() As Double

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            Dim query As String =
                "SELECT SUM(Amount)
                 FROM Transactions
                 WHERE TransactionType = 'Withdrawal'"

            Dim command As New SqliteCommand(query, connection)

            Dim result = command.ExecuteScalar()

            If result Is DBNull.Value Then
                Return 0
            Else
                Return Convert.ToDouble(result)
            End If

        End Using

    End Function

End Module