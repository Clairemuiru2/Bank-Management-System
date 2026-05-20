<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        TextBox1 = New TextBox()
        btnLogin = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        btnRegisterEmployee = New Button()
        Panel4 = New Panel()
        Panel5 = New Panel()
        PictureBox3 = New PictureBox()
        txtPin = New TextBox()
        Label5 = New Label()
        Panel3 = New Panel()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(2, 10)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(289, 16)
        TextBox1.TabIndex = 0
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(52, 400)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(329, 30)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Franklin Gothic Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(169, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 34)
        Label1.TabIndex = 3
        Label1.Text = "DollarBank"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(btnRegisterEmployee)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(btnLogin)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.ForeColor = Color.Black
        Panel1.Location = New Point(264, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(431, 652)
        Panel1.TabIndex = 5
        ' 
        ' btnRegisterEmployee
        ' 
        btnRegisterEmployee.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        btnRegisterEmployee.FlatStyle = FlatStyle.Flat
        btnRegisterEmployee.ForeColor = Color.White
        btnRegisterEmployee.Location = New Point(54, 453)
        btnRegisterEmployee.Name = "btnRegisterEmployee"
        btnRegisterEmployee.Size = New Size(329, 30)
        btnRegisterEmployee.TabIndex = 11
        btnRegisterEmployee.Text = "Register Employee"
        btnRegisterEmployee.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        Panel4.Location = New Point(52, 378)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(329, 1)
        Panel4.TabIndex = 10
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(PictureBox3)
        Panel5.Controls.Add(txtPin)
        Panel5.Location = New Point(52, 342)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(329, 36)
        Panel5.TabIndex = 9
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(297, 10)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(20, 20)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' txtPin
        ' 
        txtPin.BorderStyle = BorderStyle.None
        txtPin.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPin.Location = New Point(2, 10)
        txtPin.Name = "txtPin"
        txtPin.Size = New Size(289, 16)
        txtPin.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(52, 324)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 15)
        Label5.TabIndex = 8
        Label5.Text = "password"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        Panel3.Location = New Point(52, 305)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(329, 1)
        Panel3.TabIndex = 7
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Location = New Point(52, 269)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(329, 36)
        Panel2.TabIndex = 6
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(297, 10)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(20, 20)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(52, 251)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 15)
        Label4.TabIndex = 5
        Label4.Text = "userrname"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(130, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 24)
        Label3.TabIndex = 4
        Label3.Text = "Welcome back!"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(96, 37)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(76, 76)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(934, 611)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtPin As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents btnRegisterEmployee As Button

End Class
