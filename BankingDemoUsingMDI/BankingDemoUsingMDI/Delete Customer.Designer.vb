<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delete_Customer
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFetch = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFetch)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.textBox1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1338, 91)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Banking Information"
        '
        'btnFetch
        '
        Me.btnFetch.Enabled = False
        Me.btnFetch.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFetch.ForeColor = System.Drawing.Color.Chocolate
        Me.btnFetch.Location = New System.Drawing.Point(572, 27)
        Me.btnFetch.Name = "btnFetch"
        Me.btnFetch.Size = New System.Drawing.Size(93, 35)
        Me.btnFetch.TabIndex = 2
        Me.btnFetch.Text = "Fetch"
        Me.btnFetch.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(203, 21)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Customer Account Number"
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(288, 36)
        Me.textBox1.MaxLength = 8
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(258, 26)
        Me.textBox1.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(757, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 21)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Account Created Date"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(1034, 39)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(245, 21)
        Me.DateTimePicker2.TabIndex = 53
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Violet
        Me.label1.Location = New System.Drawing.Point(579, 19)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(192, 29)
        Me.label1.TabIndex = 63
        Me.label1.Text = "Delete Customer"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.TextBox13)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Modern No. 20", 9.75!)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 408)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1338, 108)
        Me.GroupBox3.TabIndex = 66
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Account Details"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label19.Location = New System.Drawing.Point(916, 76)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(379, 18)
        Me.Label19.TabIndex = 82
        Me.Label19.Text = "We Can Delete Customer Only If Acc. Balance is ZERO*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Crimson
        Me.Label18.Location = New System.Drawing.Point(814, 74)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 21)
        Me.Label18.TabIndex = 81
        Me.Label18.Text = "**Note : "
        '
        'TextBox13
        '
        Me.TextBox13.Enabled = False
        Me.TextBox13.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(1034, 28)
        Me.TextBox13.MaxLength = 10
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(245, 26)
        Me.TextBox13.TabIndex = 78
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(760, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 21)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Account Balance"
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Current", "Savings"})
        Me.ComboBox1.Location = New System.Drawing.Point(288, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(258, 23)
        Me.ComboBox1.TabIndex = 56
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(179, 21)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Customer Account Type"
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Chocolate
        Me.btnDelete.Location = New System.Drawing.Point(392, 546)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(182, 55)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox12)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.label5)
        Me.GroupBox2.Controls.Add(Me.textBox3)
        Me.GroupBox2.Controls.Add(Me.textBox2)
        Me.GroupBox2.Controls.Add(Me.label3)
        Me.GroupBox2.Controls.Add(Me.label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 173)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1338, 206)
        Me.GroupBox2.TabIndex = 75
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Personal Information"
        '
        'TextBox12
        '
        Me.TextBox12.Enabled = False
        Me.TextBox12.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(1034, 149)
        Me.TextBox12.MaxLength = 10
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(245, 26)
        Me.TextBox12.TabIndex = 73
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(760, 152)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(124, 21)
        Me.Label17.TabIndex = 75
        Me.Label17.Text = "Mobile Number"
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(288, 146)
        Me.TextBox7.MaxLength = 20
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(258, 26)
        Me.TextBox7.TabIndex = 69
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(36, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 21)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Surname"
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(288, 89)
        Me.TextBox6.MaxLength = 20
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(258, 26)
        Me.TextBox6.TabIndex = 67
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 21)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Middle Name"
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(1034, 87)
        Me.TextBox5.MaxLength = 12
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(245, 26)
        Me.TextBox5.TabIndex = 60
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(760, 92)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(128, 21)
        Me.label5.TabIndex = 65
        Me.label5.Text = "Addhar Number"
        '
        'textBox3
        '
        Me.textBox3.Enabled = False
        Me.textBox3.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox3.Location = New System.Drawing.Point(1034, 38)
        Me.textBox3.MaxLength = 10
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(245, 26)
        Me.textBox3.TabIndex = 58
        '
        'textBox2
        '
        Me.textBox2.Enabled = False
        Me.textBox2.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox2.Location = New System.Drawing.Point(288, 38)
        Me.textBox2.MaxLength = 20
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(258, 26)
        Me.textBox2.TabIndex = 57
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(760, 41)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(148, 21)
        Me.label3.TabIndex = 63
        Me.label3.Text = "PAN Card Number"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(36, 41)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(92, 21)
        Me.label2.TabIndex = 62
        Me.label2.Text = "First Name"
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Enabled = False
        Me.btnWithdraw.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdraw.ForeColor = System.Drawing.Color.Chocolate
        Me.btnWithdraw.Location = New System.Drawing.Point(830, 547)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(178, 54)
        Me.btnWithdraw.TabIndex = 76
        Me.btnWithdraw.Text = "Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = True
        '
        'Delete_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 626)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.label1)
        Me.Name = "Delete_Customer"
        Me.Text = "Delete Customer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents btnFetch As System.Windows.Forms.Button
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents TextBox13 As System.Windows.Forms.TextBox
    Private WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents TextBox12 As System.Windows.Forms.TextBox
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents TextBox7 As System.Windows.Forms.TextBox
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents TextBox6 As System.Windows.Forms.TextBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents TextBox5 As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents textBox3 As System.Windows.Forms.TextBox
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents btnWithdraw As System.Windows.Forms.Button
End Class
