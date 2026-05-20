Public Class DashboardForm
    Dim selectedRow As DataGridViewRow

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click

        Dim form As New CreateAccountForm()

        If form.ShowDialog() = DialogResult.OK Then

            dgvCustomers.DataSource = GetCustomers()

        End If

    End Sub



    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvCustomers.DataSource = GetCustomers()

        lblTotalBalance.Text =
                "Total Balance: " & GetTotalBalance()

    End Sub

    Private Sub dgvCustomers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellClick

        If e.RowIndex >= 0 Then
            selectedRow = dgvCustomers.Rows(e.RowIndex)
        End If

    End Sub

    Private Sub dgvCustomers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellContentClick

    End Sub

    Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click

        If selectedRow Is Nothing Then
            MessageBox.Show("Please select a customer first")
            Return
        End If

        Dim detailsForm As New CustomerDetailsForm(
    selectedRow.Cells(1).Value.ToString(),
    selectedRow.Cells(2).Value.ToString(),
    selectedRow.Cells(3).Value.ToString(),
    selectedRow.Cells(4).Value.ToString(),
    selectedRow.Cells(5).Value.ToString(),
    selectedRow.Cells(7).Value.ToString()
)

        detailsForm.ShowDialog()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If dgvCustomers.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a customer first")
            Return
        End If

        Dim accountNumber As String =
        dgvCustomers.CurrentRow.Cells(2).Value.ToString()

        Dim confirm = MessageBox.Show(
        "Are you sure you want to delete this account?",
        "Confirm Delete",
        MessageBoxButtons.YesNo
    )

        If confirm = DialogResult.Yes Then

            Dim result = DeleteCustomer(accountNumber)

            If result Then
                MessageBox.Show("Customer deleted")
                dgvCustomers.DataSource = GetCustomers()
            Else
                MessageBox.Show("Delete failed")
            End If

        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If dgvCustomers.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a customer first")
            Return
        End If

        Dim row = dgvCustomers.CurrentRow

        Dim accountNumber = row.Cells(2).Value.ToString()

        Dim result = UpdateCustomer(
        accountNumber,
        txtFullName.Text,
        txtPhone.Text,
        txtAddress.Text,
        txtEmail.Text,
        txtIdNumber.Text
    )

        If result Then
            MessageBox.Show("Customer updated")
            dgvCustomers.DataSource = GetCustomers()
        Else
            MessageBox.Show("Update failed")
        End If

    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click

        If dgvCustomers.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a customer")
            Return
        End If

        Dim row = dgvCustomers.CurrentRow

        Dim accountNumber =
        row.Cells(2).Value.ToString()

        Dim customerName =
        row.Cells(1).Value.ToString()

        Dim form As New TransactionForm(accountNumber, customerName)

        If form.ShowDialog() = DialogResult.OK Then

            dgvCustomers.DataSource = GetCustomers()

        End If

    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click

        If dgvCustomers.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a customer")
            Return
        End If

        Dim row = dgvCustomers.CurrentRow

        Dim accountNumber =
        row.Cells(2).Value.ToString()

        Dim customerName =
        row.Cells(1).Value.ToString()

        Dim form As New TransactionForm(accountNumber, customerName)

        If form.ShowDialog() = DialogResult.OK Then

            dgvCustomers.DataSource = GetCustomers()

        End If

    End Sub

    Private Sub btnDeposit__Click(sender As Object, e As EventArgs) Handles btnDeposit.Click

    End Sub

    Private Sub btnExportReport_Click(sender As Object, e As EventArgs) Handles btnExportReport.Click

        ExportCustomerReport()

    End Sub

    Private Sub btnRegisterEmployee_Click(sender As Object, e As EventArgs) Handles btnRegisterEmployee.Click

        Dim form As New RegisterEmployeeForm()

        form.ShowDialog()

    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click

        Dim form As New TransferForm()

        form.ShowDialog()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblTotalBalance.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class