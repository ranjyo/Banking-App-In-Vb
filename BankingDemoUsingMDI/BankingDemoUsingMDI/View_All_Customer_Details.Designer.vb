<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_All_Customer_Details
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
        Me.components = New System.ComponentModel.Container()
        Me.label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustAccNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MothersNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PinCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddharNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerPersonalDetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Banking_ApplicationDBDataSet1 = New BankingDemoUsingMDI.Banking_ApplicationDBDataSet1()
        Me.Customer_Personal_DetailsTableAdapter1 = New BankingDemoUsingMDI.Banking_ApplicationDBDataSet1TableAdapters.Customer_Personal_DetailsTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerPersonalDetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Banking_ApplicationDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Violet
        Me.label1.Location = New System.Drawing.Point(466, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(310, 29)
        Me.label1.TabIndex = 64
        Me.label1.Text = "View All Customer Details"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(12, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1338, 550)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustAccNoDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleNameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.MothersNameDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.PinCodeDataGridViewTextBoxColumn, Me.BirthDateDataGridViewTextBoxColumn, Me.PanNoDataGridViewTextBoxColumn, Me.AddharNoDataGridViewTextBoxColumn, Me.PhoneNoDataGridViewTextBoxColumn, Me.MobNoDataGridViewTextBoxColumn, Me.EmailIdDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerPersonalDetailsBindingSource1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1332, 531)
        Me.DataGridView1.TabIndex = 66
        '
        'CustAccNoDataGridViewTextBoxColumn
        '
        Me.CustAccNoDataGridViewTextBoxColumn.DataPropertyName = "Cust_Acc_No"
        Me.CustAccNoDataGridViewTextBoxColumn.HeaderText = "Cust_Acc_No"
        Me.CustAccNoDataGridViewTextBoxColumn.Name = "CustAccNoDataGridViewTextBoxColumn"
        Me.CustAccNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MiddleNameDataGridViewTextBoxColumn
        '
        Me.MiddleNameDataGridViewTextBoxColumn.DataPropertyName = "Middle_Name"
        Me.MiddleNameDataGridViewTextBoxColumn.HeaderText = "Middle_Name"
        Me.MiddleNameDataGridViewTextBoxColumn.Name = "MiddleNameDataGridViewTextBoxColumn"
        Me.MiddleNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        Me.SurnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MothersNameDataGridViewTextBoxColumn
        '
        Me.MothersNameDataGridViewTextBoxColumn.DataPropertyName = "Mothers_Name"
        Me.MothersNameDataGridViewTextBoxColumn.HeaderText = "Mothers_Name"
        Me.MothersNameDataGridViewTextBoxColumn.Name = "MothersNameDataGridViewTextBoxColumn"
        Me.MothersNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PinCodeDataGridViewTextBoxColumn
        '
        Me.PinCodeDataGridViewTextBoxColumn.DataPropertyName = "Pin_Code"
        Me.PinCodeDataGridViewTextBoxColumn.HeaderText = "Pin_Code"
        Me.PinCodeDataGridViewTextBoxColumn.Name = "PinCodeDataGridViewTextBoxColumn"
        Me.PinCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BirthDateDataGridViewTextBoxColumn
        '
        Me.BirthDateDataGridViewTextBoxColumn.DataPropertyName = "Birth_Date"
        Me.BirthDateDataGridViewTextBoxColumn.HeaderText = "Birth_Date"
        Me.BirthDateDataGridViewTextBoxColumn.Name = "BirthDateDataGridViewTextBoxColumn"
        Me.BirthDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PanNoDataGridViewTextBoxColumn
        '
        Me.PanNoDataGridViewTextBoxColumn.DataPropertyName = "Pan_No"
        Me.PanNoDataGridViewTextBoxColumn.HeaderText = "Pan_No"
        Me.PanNoDataGridViewTextBoxColumn.Name = "PanNoDataGridViewTextBoxColumn"
        Me.PanNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddharNoDataGridViewTextBoxColumn
        '
        Me.AddharNoDataGridViewTextBoxColumn.DataPropertyName = "Addhar_No"
        Me.AddharNoDataGridViewTextBoxColumn.HeaderText = "Addhar_No"
        Me.AddharNoDataGridViewTextBoxColumn.Name = "AddharNoDataGridViewTextBoxColumn"
        Me.AddharNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhoneNoDataGridViewTextBoxColumn
        '
        Me.PhoneNoDataGridViewTextBoxColumn.DataPropertyName = "Phone_No"
        Me.PhoneNoDataGridViewTextBoxColumn.HeaderText = "Phone_No"
        Me.PhoneNoDataGridViewTextBoxColumn.Name = "PhoneNoDataGridViewTextBoxColumn"
        Me.PhoneNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MobNoDataGridViewTextBoxColumn
        '
        Me.MobNoDataGridViewTextBoxColumn.DataPropertyName = "Mob_No"
        Me.MobNoDataGridViewTextBoxColumn.HeaderText = "Mob_No"
        Me.MobNoDataGridViewTextBoxColumn.Name = "MobNoDataGridViewTextBoxColumn"
        Me.MobNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailIdDataGridViewTextBoxColumn
        '
        Me.EmailIdDataGridViewTextBoxColumn.DataPropertyName = "Email_Id"
        Me.EmailIdDataGridViewTextBoxColumn.HeaderText = "Email_Id"
        Me.EmailIdDataGridViewTextBoxColumn.Name = "EmailIdDataGridViewTextBoxColumn"
        Me.EmailIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerPersonalDetailsBindingSource1
        '
        Me.CustomerPersonalDetailsBindingSource1.DataMember = "Customer_Personal_Details"
        Me.CustomerPersonalDetailsBindingSource1.DataSource = Me.Banking_ApplicationDBDataSet1
        '
        'Banking_ApplicationDBDataSet1
        '
        Me.Banking_ApplicationDBDataSet1.DataSetName = "Banking_ApplicationDBDataSet1"
        Me.Banking_ApplicationDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Customer_Personal_DetailsTableAdapter1
        '
        Me.Customer_Personal_DetailsTableAdapter1.ClearBeforeFill = True
        '
        'View_All_Customer_Details
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1356, 626)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.label1)
        Me.Name = "View_All_Customer_Details"
        Me.Text = "View All Customer Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerPersonalDetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Banking_ApplicationDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Banking_ApplicationDBDataSet1 As BankingDemoUsingMDI.Banking_ApplicationDBDataSet1
    Friend WithEvents CustomerPersonalDetailsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Customer_Personal_DetailsTableAdapter1 As BankingDemoUsingMDI.Banking_ApplicationDBDataSet1TableAdapters.Customer_Personal_DetailsTableAdapter
    Friend WithEvents CustAccNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MothersNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PinCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BirthDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PanNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddharNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
