<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Customer_Dynamic
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
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Btn_Refresh_Grid = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Search
        '
        Me.Btn_Search.Enabled = False
        Me.Btn_Search.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.ForeColor = System.Drawing.Color.Chocolate
        Me.Btn_Search.Location = New System.Drawing.Point(960, 82)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(137, 41)
        Me.Btn_Search.TabIndex = 3
        Me.Btn_Search.Text = "Search"
        Me.Btn_Search.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(628, 92)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(290, 25)
        Me.TextBox1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 158)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1332, 472)
        Me.DataGridView1.TabIndex = 2
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Violet
        Me.label1.Location = New System.Drawing.Point(548, 28)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(306, 29)
        Me.label1.TabIndex = 104
        Me.label1.Text = "Search Customer Dynamic"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Modern No. 20", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(66, 94)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(154, 21)
        Me.label2.TabIndex = 108
        Me.label2.Text = "Search Customer By"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Cust_Acc_No", "First_Name", "Surname", "Mob_No", "City"})
        Me.ComboBox1.Location = New System.Drawing.Point(264, 92)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(258, 26)
        Me.ComboBox1.TabIndex = 1
        '
        'Btn_Refresh_Grid
        '
        Me.Btn_Refresh_Grid.Enabled = False
        Me.Btn_Refresh_Grid.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Refresh_Grid.ForeColor = System.Drawing.Color.Chocolate
        Me.Btn_Refresh_Grid.Location = New System.Drawing.Point(1156, 82)
        Me.Btn_Refresh_Grid.Name = "Btn_Refresh_Grid"
        Me.Btn_Refresh_Grid.Size = New System.Drawing.Size(149, 41)
        Me.Btn_Refresh_Grid.TabIndex = 4
        Me.Btn_Refresh_Grid.Text = "Refresh Grid"
        Me.Btn_Refresh_Grid.UseVisualStyleBackColor = True
        '
        'View_Customer_Dynamic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 642)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_Refresh_Grid)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Btn_Search)
        Me.Name = "View_Customer_Dynamic"
        Me.Text = "View_Customer_Dynamic"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Search As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_Refresh_Grid As System.Windows.Forms.Button
End Class
