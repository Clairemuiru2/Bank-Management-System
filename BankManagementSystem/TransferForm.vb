Public Class TransferForm
    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click

        Dim amount As Double

        If Not Double.TryParse(txtAmount.Text, amount) Then

            MessageBox.Show("Enter valid amount")
            Return

        End If

        Dim result = TransferMoney(
        txtSender.Text,
        txtReceiver.Text,
        amount
    )

        If result Then

            MessageBox.Show("Transfer Successful")
            Me.Close()

        Else

            MessageBox.Show("Transfer Failed")

        End If

    End Sub
    Private Sub TransferForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class