Public Class CustomerDetailsForm

    Private _fullName As String
    Private _accountNumber As String
    Private _phone As String
    Private _address As String
    Private _email As String
    Private _balance As String

    ' Constructor (this receives data)
    Public Sub New(fullName As String, accountNumber As String, phone As String, address As String, email As String, balance As String)

        InitializeComponent()

        _fullName = fullName
        _accountNumber = accountNumber
        _phone = phone
        _address = address
        _email = email
        _balance = balance

    End Sub

    Private Sub CustomerDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtFullName.Text = _fullName
        txtAccountNumber.Text = _accountNumber
        txtPhone.Text = _phone
        txtAddress.Text = _address
        txtEmail.Text = _email
        txtBalance.Text = _balance

    End Sub

End Class