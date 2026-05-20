<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Panel7 = New Panel()
        Panel8 = New Panel()
        txtAmount = New TextBox()
        Label5 = New Label()
        btnDeposit = New Button()
        btnWithdraw = New Button()
        lblAccount = New Label()
        lblCustomer = New Label()
        Panel1.SuspendLayout()
        Panel8.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(lblCustomer)
        Panel1.Controls.Add(lblAccount)
        Panel1.Controls.Add(btnWithdraw)
        Panel1.Controls.Add(btnDeposit)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel8)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(222, 70)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(308, 291)
        Panel1.TabIndex = 0
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        Panel7.Location = New Point(62, 158)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(181, 1)
        Panel7.TabIndex = 19
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(txtAmount)
        Panel8.Location = New Point(62, 127)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(179, 40)
        Panel8.TabIndex = 18
        ' 
        ' txtAmount
        ' 
        txtAmount.BorderStyle = BorderStyle.None
        txtAmount.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAmount.Location = New Point(2, 10)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(156, 16)
        txtAmount.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(62, 113)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 15)
        Label5.TabIndex = 17
        Label5.Text = "Enter Amount"
        ' 
        ' btnDeposit
        ' 
        btnDeposit.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        btnDeposit.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDeposit.ForeColor = Color.White
        btnDeposit.Location = New Point(18, 209)
        btnDeposit.Name = "btnDeposit"
        btnDeposit.Size = New Size(120, 23)
        btnDeposit.TabIndex = 20
        btnDeposit.Text = "Deposit"
        btnDeposit.UseVisualStyleBackColor = False
        ' 
        ' btnWithdraw
        ' 
        btnWithdraw.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        btnWithdraw.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnWithdraw.ForeColor = Color.White
        btnWithdraw.Location = New Point(181, 209)
        btnWithdraw.Name = "btnWithdraw"
        btnWithdraw.Size = New Size(120, 23)
        btnWithdraw.TabIndex = 21
        btnWithdraw.Text = "Withdraw"
        btnWithdraw.UseVisualStyleBackColor = False
        ' 
        ' lblAccount
        ' 
        lblAccount.AutoSize = True
        lblAccount.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAccount.Location = New Point(-2, 64)
        lblAccount.Name = "lblAccount"
        lblAccount.Size = New Size(144, 23)
        lblAccount.TabIndex = 22
        lblAccount.Text = "Account Number"
        ' 
        ' lblCustomer
        ' 
        lblCustomer.AutoSize = True
        lblCustomer.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCustomer.Location = New Point(0, 19)
        lblCustomer.Name = "lblCustomer"
        lblCustomer.Size = New Size(138, 23)
        lblCustomer.TabIndex = 23
        lblCustomer.Text = "Customer Name"
        ' 
        ' TransactionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "TransactionForm"
        Text = "TransactionForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents btnDeposit As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCustomer As Label
    Friend WithEvents lblAccount As Label
End Class
