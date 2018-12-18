<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Debit_Amount
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFetch = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Violet
        Me.label1.Location = New System.Drawing.Point(538, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(171, 29)
        Me.label1.TabIndex = 65
        Me.label1.Text = "Debit Amount"
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Enabled = False
        Me.btnWithdraw.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdraw.ForeColor = System.Drawing.Color.Chocolate
        Me.btnWithdraw.Location = New System.Drawing.Point(532, 576)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(154, 54)
        Me.btnWithdraw.TabIndex = 3
        Me.btnWithdraw.Text = "Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFetch)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.textBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1260, 85)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Number"
        '
        'btnFetch
        '
        Me.btnFetch.Enabled = False
        Me.btnFetch.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFetch.ForeColor = System.Drawing.Color.Chocolate
        Me.btnFetch.Location = New System.Drawing.Point(955, 28)
        Me.btnFetch.Name = "btnFetch"
        Me.btnFetch.Size = New System.Drawing.Size(83, 29)
        Me.btnFetch.TabIndex = 98
        Me.btnFetch.Text = "Fetch"
        Me.btnFetch.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(222, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(247, 24)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Customer Account Number"
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(570, 27)
        Me.textBox1.MaxLength = 8
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(326, 30)
        Me.textBox1.TabIndex = 96
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox12)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.textBox4)
        Me.GroupBox2.Controls.Add(Me.textBox2)
        Me.GroupBox2.Controls.Add(Me.label4)
        Me.GroupBox2.Controls.Add(Me.label2)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1260, 279)
        Me.GroupBox2.TabIndex = 100
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Details"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(863, 201)
        Me.TextBox3.MaxLength = 10
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(264, 26)
        Me.TextBox3.TabIndex = 112
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(657, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 21)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "Account Balance"
        '
        'TextBox12
        '
        Me.TextBox12.Enabled = False
        Me.TextBox12.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(863, 121)
        Me.TextBox12.MaxLength = 10
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(268, 26)
        Me.TextBox12.TabIndex = 104
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(657, 126)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(124, 21)
        Me.Label17.TabIndex = 110
        Me.Label17.Text = "Mobile Number"
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(863, 51)
        Me.TextBox7.MaxLength = 20
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(268, 26)
        Me.TextBox7.TabIndex = 102
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(657, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 21)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "Surname"
        '
        'textBox4
        '
        Me.textBox4.Enabled = False
        Me.textBox4.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox4.Location = New System.Drawing.Point(307, 126)
        Me.textBox4.MaxLength = 15
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(264, 26)
        Me.textBox4.TabIndex = 103
        '
        'textBox2
        '
        Me.textBox2.Enabled = False
        Me.textBox2.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox2.Location = New System.Drawing.Point(307, 54)
        Me.textBox2.MaxLength = 20
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(264, 26)
        Me.textBox2.TabIndex = 101
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(86, 126)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(40, 21)
        Me.label4.TabIndex = 108
        Me.label4.Text = "City"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(86, 54)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(92, 21)
        Me.label2.TabIndex = 107
        Me.label2.Text = "First Name"
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Current", "Savings"})
        Me.ComboBox1.Location = New System.Drawing.Point(307, 203)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(264, 21)
        Me.ComboBox1.TabIndex = 105
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(86, 201)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 21)
        Me.Label12.TabIndex = 106
        Me.Label12.Text = "Account Type"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.TextBox13)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 446)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1259, 100)
        Me.GroupBox3.TabIndex = 101
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Withdraw"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(839, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(386, 18)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Minimum 1000 Balance should be maintained in account*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label19.Location = New System.Drawing.Point(839, 39)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(241, 18)
        Me.Label19.TabIndex = 102
        Me.Label19.Text = "You Can Debit Max 40000 AtTime*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Crimson
        Me.Label18.Location = New System.Drawing.Point(734, 37)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 21)
        Me.Label18.TabIndex = 101
        Me.Label18.Text = "**Note : "
        '
        'TextBox13
        '
        Me.TextBox13.Enabled = False
        Me.TextBox13.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(356, 32)
        Me.TextBox13.MaxLength = 6
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(326, 30)
        Me.TextBox13.TabIndex = 99
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(38, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(178, 24)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "Withdraw Amount"
        '
        'Debit_Amount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 642)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.label1)
        Me.Name = "Debit_Amount"
        Me.Text = "Debit_Amount"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btnWithdraw As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents btnFetch As System.Windows.Forms.Button
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents TextBox3 As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents TextBox12 As System.Windows.Forms.TextBox
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents TextBox7 As System.Windows.Forms.TextBox
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents textBox4 As System.Windows.Forms.TextBox
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents TextBox13 As System.Windows.Forms.TextBox
    Private WithEvents Label13 As System.Windows.Forms.Label
End Class
