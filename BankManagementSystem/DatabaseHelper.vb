Imports Microsoft.Data.Sqlite

Module DatabaseHelper

    Public connectionString As String =
        "Data Source=bank.db"

    Public Sub InitializeDatabase()

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            ' Employees Table
            Dim employeeQuery As String =
                "CREATE TABLE IF NOT EXISTS Employees (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    FullName TEXT NOT NULL,
                    Email TEXT NOT NULL,
                    Phone TEXT NOT NULL,
                    Pin TEXT NOT NULL UNIQUE
                )"

            Dim employeeCommand As New SqliteCommand(employeeQuery, connection)
            employeeCommand.ExecuteNonQuery()

            ' Customers Table
            Dim customerQuery As String =
                "CREATE TABLE IF NOT EXISTS Customers (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    FullName TEXT NOT NULL,
                    AccountNumber TEXT NOT NULL UNIQUE,
                    Phone TEXT NOT NULL,
                    Address TEXT NOT NULL,
                    Email TEXT NOT NULL,
                    IdNumber TEXT NOT NULL,
                    Balance REAL DEFAULT 0
                )"

            Dim customerCommand As New SqliteCommand(customerQuery, connection)
            customerCommand.ExecuteNonQuery()

            ' Transactions Table
            Dim transactionQuery As String =
                "CREATE TABLE IF NOT EXISTS Transactions (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    AccountNumber TEXT NOT NULL,
                    TransactionType TEXT NOT NULL,
                    Amount REAL NOT NULL,
                    TransactionDate TEXT NOT NULL
                )"

            Dim transactionCommand As New SqliteCommand(transactionQuery, connection)
            transactionCommand.ExecuteNonQuery()

        End Using

    End Sub

End Module