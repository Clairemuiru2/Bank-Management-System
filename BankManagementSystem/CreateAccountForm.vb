Public Class CreateAccountForm
    Private Sub btnSaveCustomer_Click(sender As Object, e As EventArgs) Handles btnSaveCustomer.Click

        Dim result As Boolean

        result = AddCustomer(
        txtFullName.Text,
        txtAccountNumber.Text,
        txtPhone.Text,
        txtAddress.Text,
        txtEmail.Text,
        txtIdNumber.Text
    )

        If result Then

            MessageBox.Show("Customer Account Created Successfully")

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Else

            MessageBox.Show("Failed To Create Account")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtFullName.TextChanged

    End Sub

    Private Sub txtFullName_TextChanged(sender As Object, e As EventArgs) Handles txtFullName.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSaveCustomer.Click

    End Sub
End Class