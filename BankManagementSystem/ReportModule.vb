Imports System.IO
Imports Microsoft.Data.Sqlite

Module ReportModule

    Public Sub ExportCustomerReport()

        Dim savePath As String =
            "CustomerReport.txt"

        Using writer As New StreamWriter(savePath)

            writer.WriteLine("===== BANK CUSTOMER REPORT =====")
            writer.WriteLine("Date: " & DateTime.Now)
            writer.WriteLine("")

            Using connection As New SqliteConnection(connectionString)

                connection.Open()

                Dim query As String =
                    "SELECT * FROM Customers"

                Dim command As New SqliteCommand(query, connection)

                Dim reader = command.ExecuteReader()

                Dim totalBalance As Double = 0

                While reader.Read()

                    writer.WriteLine("Customer Name: " & reader("FullName"))
                    writer.WriteLine("Account Number: " & reader("AccountNumber"))
                    writer.WriteLine("Phone: " & reader("Phone"))
                    writer.WriteLine("Address: " & reader("Address"))
                    writer.WriteLine("Email: " & reader("Email"))
                    writer.WriteLine("Balance: " & reader("Balance"))

                    writer.WriteLine("--------------------------------")

                    totalBalance += Convert.ToDouble(reader("Balance"))

                End While

                writer.WriteLine("")
                writer.WriteLine("TOTAL MONEY IN BANK: " & totalBalance)

            End Using

        End Using

        MessageBox.Show(
            "Report exported successfully." &
            vbNewLine &
            "Saved as CustomerReport.txt"
        )

    End Sub

End Module