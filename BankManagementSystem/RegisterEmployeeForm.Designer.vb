<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterEmployeeForm
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
        Panel3 = New Panel()
        Panel4 = New Panel()
        txtFullName = New TextBox()
        Label4 = New Label()
        Panel2 = New Panel()
        Panel5 = New Panel()
        txtPhone = New TextBox()
        Label1 = New Label()
        Panel6 = New Panel()
        Panel7 = New Panel()
        txtEmail = New TextBox()
        Label2 = New Label()
        Panel8 = New Panel()
        Panel9 = New Panel()
        txtPin = New TextBox()
        Label3 = New Label()
        btnRegisterEmployee = New Button()
        Label5 = New Label()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel7.SuspendLayout()
        Panel9.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(503, 32)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        Panel3.Location = New Point(130, 105)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(181, 1)
        Panel3.TabIndex = 13
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(txtFullName)
        Panel4.Location = New Point(130, 74)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(179, 40)
        Panel4.TabIndex = 12
        ' 
        ' txtFullName
        ' 
        txtFullName.BorderStyle = BorderStyle.None
        txtFullName.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFullName.Location = New Point(1, 10)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(156, 16)
        txtFullName.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(130, 60)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 15)
        Label4.TabIndex = 11
        Label4.Text = "Full Name"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        Panel2.Location = New Point(130, 183)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(181, 1)
        Panel2.TabIndex = 16
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(txtPhone)
        Panel5.Location = New Point(130, 152)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(179, 40)
        Panel5.TabIndex = 15
        ' 
        ' txtPhone
        ' 
        txtPhone.BorderStyle = BorderStyle.None
        txtPhone.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPhone.Location = New Point(1, 10)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(156, 16)
        txtPhone.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(130, 138)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 15)
        Label1.TabIndex = 14
        Label1.Text = "Phone Number"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        Panel6.Location = New Point(131, 255)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(181, 1)
        Panel6.TabIndex = 19
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(txtEmail)
        Panel7.Location = New Point(131, 224)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(179, 40)
        Panel7.TabIndex = 18
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(1, 10)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(156, 16)
        txtEmail.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(131, 210)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 15)
        Label2.TabIndex = 17
        Label2.Text = "Email"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        Panel8.Location = New Point(130, 327)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(181, 1)
        Panel8.TabIndex = 22
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(txtPin)
        Panel9.Location = New Point(130, 296)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(179, 40)
        Panel9.TabIndex = 21
        ' 
        ' txtPin
        ' 
        txtPin.BorderStyle = BorderStyle.None
        txtPin.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPin.Location = New Point(1, 10)
        txtPin.Name = "txtPin"
        txtPin.Size = New Size(156, 16)
        txtPin.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(130, 282)
        Label3.Name = "Label3"
        Label3.Size = New Size(25, 15)
        Label3.TabIndex = 20
        Label3.Text = "Pin"
        ' 
        ' btnRegisterEmployee
        ' 
        btnRegisterEmployee.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        btnRegisterEmployee.Font = New Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegisterEmployee.Location = New Point(154, 370)
        btnRegisterEmployee.Name = "btnRegisterEmployee"
        btnRegisterEmployee.Size = New Size(75, 29)
        btnRegisterEmployee.TabIndex = 23
        btnRegisterEmployee.Text = "Create"
        btnRegisterEmployee.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        Label5.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(206, 26)
        Label5.TabIndex = 0
        Label5.Text = "Create New Employee"
        ' 
        ' RegisterEmployeeForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(527, 450)
        Controls.Add(btnRegisterEmployee)
        Controls.Add(Panel8)
        Controls.Add(Panel9)
        Controls.Add(Label3)
        Controls.Add(Panel6)
        Controls.Add(Panel7)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(Panel5)
        Controls.Add(Label1)
        Controls.Add(Panel3)
        Controls.Add(Panel4)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        Name = "RegisterEmployeeForm"
        Text = "RegisterEmployeeForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtPin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRegisterEmployee As Button
End Class
