Public Class TransactionForm

    Private _accountNumber As String
    Private _customerName As String

    Public Sub New(accountNumber As String, customerName As String)

        InitializeComponent()

        _accountNumber = accountNumber
        _customerName = customerName

    End Sub

    Private Sub TransactionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblCustomer.Text = "Customer: " & _customerName
        lblAccount.Text = "Account: " & _accountNumber

    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click

        Dim amount As Double

        If Not Double.TryParse(txtAmount.Text, amount) Then
            MessageBox.Show("Enter valid amount")
            Return
        End If

        If amount <= 0 Then
            MessageBox.Show("Amount must be greater than 0")
            Return
        End If

        If DepositMoney(_accountNumber, amount) Then

            MessageBox.Show("Deposit successful")

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Else

            MessageBox.Show("Deposit failed")

        End If

    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click

        Dim amount As Double

        If Not Double.TryParse(txtAmount.Text, amount) Then
            MessageBox.Show("Enter valid amount")
            Return
        End If

        If amount <= 0 Then
            MessageBox.Show("Amount must be greater than 0")
            Return
        End If

        If WithdrawMoney(_accountNumber, amount) Then

            MessageBox.Show("Withdrawal successful")

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Else

            MessageBox.Show("Insufficient balance or withdrawal failed")

        End If

    End Sub

End Class