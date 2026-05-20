Public Class Form1

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim pin As String

        pin = txtPin.Text

        If pin = "" Then

            MessageBox.Show("Please Enter PIN")

            Return

        End If

        If EmployeeLogin(pin) Then

            MessageBox.Show("Login Successful")

            DashboardForm.Show()

            Me.Hide()

        Else

            MessageBox.Show("Invalid PIN")

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRegisterEmployee_Click(sender As Object, e As EventArgs) Handles btnRegisterEmployee.Click

        Dim form As New RegisterEmployeeForm()

        form.ShowDialog()

    End Sub

    Private Sub txtPin_TextChanged(sender As Object, e As EventArgs) Handles txtPin.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class