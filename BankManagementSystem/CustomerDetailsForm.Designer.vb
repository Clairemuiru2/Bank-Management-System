<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerDetailsForm
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
        txtFullName = New TextBox()
        txtAccountNumber = New TextBox()
        txtPhone = New TextBox()
        txtAddress = New TextBox()
        txtEmail = New TextBox()
        txtBalance = New TextBox()
        SuspendLayout()
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(50, 12)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(293, 23)
        txtFullName.TabIndex = 0
        ' 
        ' txtAccountNumber
        ' 
        txtAccountNumber.Location = New Point(50, 51)
        txtAccountNumber.Name = "txtAccountNumber"
        txtAccountNumber.Size = New Size(293, 23)
        txtAccountNumber.TabIndex = 1
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(50, 89)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(293, 23)
        txtPhone.TabIndex = 2
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(50, 134)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(293, 23)
        txtAddress.TabIndex = 3
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(50, 178)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(293, 23)
        txtEmail.TabIndex = 4
        ' 
        ' txtBalance
        ' 
        txtBalance.Location = New Point(50, 217)
        txtBalance.Name = "txtBalance"
        txtBalance.Size = New Size(293, 23)
        txtBalance.TabIndex = 5
        ' 
        ' CustomerDetailsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(430, 450)
        Controls.Add(txtBalance)
        Controls.Add(txtEmail)
        Controls.Add(txtAddress)
        Controls.Add(txtPhone)
        Controls.Add(txtAccountNumber)
        Controls.Add(txtFullName)
        Name = "CustomerDetailsForm"
        Text = "CustomerDetailsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtAccountNumber As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtBalance As TextBox
End Class
