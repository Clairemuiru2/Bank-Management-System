<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        dgvCustomers = New DataGridView()
        Panel2 = New Panel()
        Label1 = New Label()
        Panel3 = New Panel()
        btnCreateAccount = New Button()
        Panel4 = New Panel()
        btnTransfer = New Button()
        Label2 = New Label()
        btnRegisterEmployee = New Button()
        btnExportReport = New Button()
        btnDelete = New Button()
        btnWithdraw = New Button()
        btnDeposit = New Button()
        btnUpdate = New Button()
        btnViewDetails = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        lblTotalBalance = New Label()
        Panel1.SuspendLayout()
        CType(dgvCustomers, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(dgvCustomers)
        Panel1.Location = New Point(14, 216)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(684, 321)
        Panel1.TabIndex = 1
        ' 
        ' dgvCustomers
        ' 
        dgvCustomers.BackgroundColor = Color.White
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCustomers.Location = New Point(3, 19)
        dgvCustomers.Name = "dgvCustomers"
        dgvCustomers.Size = New Size(678, 291)
        dgvCustomers.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(12, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(906, 40)
        Panel2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        Label1.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(345, 29)
        Label1.TabIndex = 4
        Label1.Text = "Dollar Bank Management System"
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(lblTotalBalance)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(12, 71)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(685, 100)
        Panel3.TabIndex = 3
        ' 
        ' btnCreateAccount
        ' 
        btnCreateAccount.Font = New Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCreateAccount.Location = New Point(19, 38)
        btnCreateAccount.Name = "btnCreateAccount"
        btnCreateAccount.Size = New Size(170, 27)
        btnCreateAccount.TabIndex = 4
        btnCreateAccount.Text = "Create Account"
        btnCreateAccount.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(btnTransfer)
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(btnRegisterEmployee)
        Panel4.Controls.Add(btnExportReport)
        Panel4.Controls.Add(btnDelete)
        Panel4.Controls.Add(btnWithdraw)
        Panel4.Controls.Add(btnDeposit)
        Panel4.Controls.Add(btnUpdate)
        Panel4.Controls.Add(btnViewDetails)
        Panel4.Controls.Add(btnCreateAccount)
        Panel4.Location = New Point(718, 113)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(200, 357)
        Panel4.TabIndex = 4
        ' 
        ' btnTransfer
        ' 
        btnTransfer.Location = New Point(60, 195)
        btnTransfer.Name = "btnTransfer"
        btnTransfer.Size = New Size(75, 23)
        btnTransfer.TabIndex = 12
        btnTransfer.Text = "Transfer"
        btnTransfer.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 18)
        Label2.TabIndex = 5
        Label2.Text = "Actions"
        ' 
        ' btnRegisterEmployee
        ' 
        btnRegisterEmployee.Font = New Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegisterEmployee.Location = New Point(19, 320)
        btnRegisterEmployee.Name = "btnRegisterEmployee"
        btnRegisterEmployee.Size = New Size(170, 27)
        btnRegisterEmployee.TabIndex = 11
        btnRegisterEmployee.Text = "Register Employee"
        btnRegisterEmployee.UseVisualStyleBackColor = True
        ' 
        ' btnExportReport
        ' 
        btnExportReport.Font = New Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExportReport.Location = New Point(19, 267)
        btnExportReport.Name = "btnExportReport"
        btnExportReport.Size = New Size(170, 27)
        btnExportReport.TabIndex = 10
        btnExportReport.Text = "Export Report"
        btnExportReport.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(19, 225)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(170, 27)
        btnDelete.TabIndex = 9
        btnDelete.Text = "Delete Account"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnWithdraw
        ' 
        btnWithdraw.Location = New Point(114, 166)
        btnWithdraw.Name = "btnWithdraw"
        btnWithdraw.Size = New Size(75, 23)
        btnWithdraw.TabIndex = 8
        btnWithdraw.Text = "Withdraw"
        btnWithdraw.UseVisualStyleBackColor = True
        ' 
        ' btnDeposit
        ' 
        btnDeposit.Location = New Point(3, 166)
        btnDeposit.Name = "btnDeposit"
        btnDeposit.Size = New Size(75, 23)
        btnDeposit.TabIndex = 7
        btnDeposit.Text = "Deposit"
        btnDeposit.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(19, 116)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(170, 27)
        btnUpdate.TabIndex = 6
        btnUpdate.Text = "Modify Account"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnViewDetails
        ' 
        btnViewDetails.Font = New Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewDetails.Location = New Point(19, 73)
        btnViewDetails.Name = "btnViewDetails"
        btnViewDetails.Size = New Size(170, 27)
        btnViewDetails.TabIndex = 5
        btnViewDetails.Text = "View Details"
        btnViewDetails.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 187)
        Label3.Name = "Label3"
        Label3.Size = New Size(179, 26)
        Label3.TabIndex = 5
        Label3.Text = "Customer Accounts"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(35, 18)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 33)
        Label4.TabIndex = 0
        Label4.Text = "Admin"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(14, 51)
        Label5.Name = "Label5"
        Label5.Size = New Size(137, 33)
        Label5.TabIndex = 1
        Label5.Text = "Dashboard"
        ' 
        ' lblTotalBalance
        ' 
        lblTotalBalance.AutoSize = True
        lblTotalBalance.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalBalance.Location = New Point(211, 36)
        lblTotalBalance.Name = "lblTotalBalance"
        lblTotalBalance.Size = New Size(237, 33)
        lblTotalBalance.TabIndex = 2
        lblTotalBalance.Text = "Bank Total Balance :"
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuBar
        ClientSize = New Size(1000, 650)
        Controls.Add(Label3)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "DashboardForm"
        Text = "DashboardForm"
        Panel1.ResumeLayout(False)
        CType(dgvCustomers, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnViewDetails As Button
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents btnRegisterEmployee As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtAccountNumber As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtIdNumber As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnExportReport As Button
    Friend WithEvents btnTransfer As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalBalance As Label
End Class
