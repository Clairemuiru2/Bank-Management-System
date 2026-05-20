Public Class RegisterEmployeeForm
    Private Sub RegisterEmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtPin.TextChanged

    End Sub

    Private Sub btnRegisterEmployee_Click(sender As Object, e As EventArgs) Handles btnRegisterEmployee.Click

        If txtFullName.Text = "" Or
       txtPin.Text = "" Then

            MessageBox.Show("Please fill required fields")
            Return

        End If

        Dim result = RegisterEmployee(
        txtFullName.Text,
        txtPhone.Text,
        txtEmail.Text,
        txtPin.Text
    )

        If result Then

            MessageBox.Show("Employee Registered Successfully")

            txtFullName.Clear()
            txtPhone.Clear()
            txtEmail.Clear()
            txtPin.Clear()

        Else

            MessageBox.Show("Registration Failed")

        End If

    End Sub
End Class