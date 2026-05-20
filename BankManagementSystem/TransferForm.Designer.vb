<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransferForm
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
        Label3 = New Label()
        Panel8 = New Panel()
        Panel9 = New Panel()
        txtAmount = New TextBox()
        Panel6 = New Panel()
        Panel7 = New Panel()
        txtReceiver = New TextBox()
        Panel2 = New Panel()
        Panel5 = New Panel()
        txtSender = New TextBox()
        Label1 = New Label()
        Panel3 = New Panel()
        Label2 = New Label()
        Label4 = New Label()
        btnTransfer = New Button()
        Panel1.SuspendLayout()
        Panel9.SuspendLayout()
        Panel7.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        Panel1.Controls.Add(Label3)
        Panel1.ForeColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(475, 29)
        Panel1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        Label3.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(12, 3)
        Label3.Name = "Label3"
        Label3.Size = New Size(153, 26)
        Label3.TabIndex = 0
        Label3.Text = "Transfer Money "
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        Panel8.Location = New Point(122, 261)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(181, 1)
        Panel8.TabIndex = 31
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(txtAmount)
        Panel9.Location = New Point(122, 230)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(179, 40)
        Panel9.TabIndex = 30
        ' 
        ' txtAmount
        ' 
        txtAmount.BorderStyle = BorderStyle.None
        txtAmount.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAmount.Location = New Point(1, 10)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(156, 16)
        txtAmount.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        Panel6.Location = New Point(123, 189)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(181, 1)
        Panel6.TabIndex = 29
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(txtReceiver)
        Panel7.Location = New Point(123, 158)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(179, 40)
        Panel7.TabIndex = 28
        ' 
        ' txtReceiver
        ' 
        txtReceiver.BorderStyle = BorderStyle.None
        txtReceiver.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtReceiver.Location = New Point(1, 10)
        txtReceiver.Name = "txtReceiver"
        txtReceiver.Size = New Size(156, 16)
        txtReceiver.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        Panel2.Location = New Point(122, 117)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(181, 1)
        Panel2.TabIndex = 27
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(txtSender)
        Panel5.Location = New Point(122, 86)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(179, 40)
        Panel5.TabIndex = 26
        ' 
        ' txtSender
        ' 
        txtSender.BorderStyle = BorderStyle.None
        txtSender.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSender.Location = New Point(1, 10)
        txtSender.Name = "txtSender"
        txtSender.Size = New Size(156, 16)
        txtSender.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(122, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 25
        Label1.Text = "Sender"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        Panel3.Location = New Point(122, 106)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(181, 1)
        Panel3.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(124, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 15)
        Label2.TabIndex = 32
        Label2.Text = "Receiver"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(124, 212)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 15)
        Label4.TabIndex = 34
        Label4.Text = "Amount"
        ' 
        ' btnTransfer
        ' 
        btnTransfer.BackColor = Color.FromArgb(CByte(0), CByte(214), CByte(50))
        btnTransfer.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTransfer.Location = New Point(132, 297)
        btnTransfer.Name = "btnTransfer"
        btnTransfer.Size = New Size(169, 33)
        btnTransfer.TabIndex = 35
        btnTransfer.Text = "Transfer"
        btnTransfer.UseVisualStyleBackColor = False
        ' 
        ' TransferForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(508, 356)
        Controls.Add(btnTransfer)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Panel8)
        Controls.Add(Panel9)
        Controls.Add(Panel6)
        Controls.Add(Panel7)
        Controls.Add(Panel2)
        Controls.Add(Panel5)
        Controls.Add(Label1)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        ForeColor = Color.White
        Name = "TransferForm"
        Text = "TransferForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtReceiver As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtSender As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnTransfer As Button
    Friend WithEvents Label3 As Label
End Class
