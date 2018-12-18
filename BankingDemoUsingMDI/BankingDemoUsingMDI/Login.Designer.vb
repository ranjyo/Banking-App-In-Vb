<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'textBox2
        '
        Me.textBox2.Enabled = False
        Me.textBox2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox2.Location = New System.Drawing.Point(483, 206)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textBox2.Size = New System.Drawing.Size(247, 25)
        Me.textBox2.TabIndex = 12
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(483, 131)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(247, 25)
        Me.textBox1.TabIndex = 11
        '
        'btnLogin
        '
        Me.btnLogin.Enabled = False
        Me.btnLogin.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Chocolate
        Me.btnLogin.Location = New System.Drawing.Point(333, 330)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(167, 57)
        Me.btnLogin.TabIndex = 13
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.DarkOrange
        Me.label4.Location = New System.Drawing.Point(283, 271)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(0, 18)
        Me.label4.TabIndex = 17
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(159, 207)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(82, 21)
        Me.label3.TabIndex = 16
        Me.label3.Text = "Password"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(159, 132)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(86, 21)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Username"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Violet
        Me.label1.Location = New System.Drawing.Point(356, 51)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(79, 29)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Login"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 436)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents btnLogin As System.Windows.Forms.Button
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label

End Class
