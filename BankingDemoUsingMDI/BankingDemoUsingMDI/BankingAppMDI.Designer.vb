<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankingAppMDI
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditCustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditAmountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebitAmountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SingleCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCustomerDynamicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlyCustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyCustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Log_Out_Btn = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.ViewMenu, Me.ReportsToolStripMenuItem, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1356, 29)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewCustomerToolStripMenuItem, Me.EditCustomerDetailsToolStripMenuItem, Me.DeleteCustomerToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(93, 25)
        Me.FileMenu.Text = "&Customer"
        '
        'AddNewCustomerToolStripMenuItem
        '
        Me.AddNewCustomerToolStripMenuItem.Name = "AddNewCustomerToolStripMenuItem"
        Me.AddNewCustomerToolStripMenuItem.Size = New System.Drawing.Size(271, 26)
        Me.AddNewCustomerToolStripMenuItem.Text = "Add &New Customer"
        '
        'EditCustomerDetailsToolStripMenuItem
        '
        Me.EditCustomerDetailsToolStripMenuItem.Name = "EditCustomerDetailsToolStripMenuItem"
        Me.EditCustomerDetailsToolStripMenuItem.Size = New System.Drawing.Size(271, 26)
        Me.EditCustomerDetailsToolStripMenuItem.Text = "&Update Customer Details"
        Me.EditCustomerDetailsToolStripMenuItem.Visible = False
        '
        'DeleteCustomerToolStripMenuItem
        '
        Me.DeleteCustomerToolStripMenuItem.Name = "DeleteCustomerToolStripMenuItem"
        Me.DeleteCustomerToolStripMenuItem.Size = New System.Drawing.Size(271, 26)
        Me.DeleteCustomerToolStripMenuItem.Text = "&Delete Customer"
        Me.DeleteCustomerToolStripMenuItem.Visible = False
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreditAmountToolStripMenuItem, Me.DebitAmountToolStripMenuItem})
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(115, 25)
        Me.EditMenu.Text = "&Transaction"
        '
        'CreditAmountToolStripMenuItem
        '
        Me.CreditAmountToolStripMenuItem.Name = "CreditAmountToolStripMenuItem"
        Me.CreditAmountToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.CreditAmountToolStripMenuItem.Text = "&Credit Amount"
        '
        'DebitAmountToolStripMenuItem
        '
        Me.DebitAmountToolStripMenuItem.Name = "DebitAmountToolStripMenuItem"
        Me.DebitAmountToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.DebitAmountToolStripMenuItem.Text = "&Debit Amount"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SingleCustomerToolStripMenuItem, Me.AllCustomersToolStripMenuItem, Me.ViewCustomerDynamicToolStripMenuItem})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(137, 25)
        Me.ViewMenu.Text = "&View Customer"
        '
        'SingleCustomerToolStripMenuItem
        '
        Me.SingleCustomerToolStripMenuItem.Name = "SingleCustomerToolStripMenuItem"
        Me.SingleCustomerToolStripMenuItem.Size = New System.Drawing.Size(265, 26)
        Me.SingleCustomerToolStripMenuItem.Text = "&Single Customer"
        '
        'AllCustomersToolStripMenuItem
        '
        Me.AllCustomersToolStripMenuItem.Name = "AllCustomersToolStripMenuItem"
        Me.AllCustomersToolStripMenuItem.Size = New System.Drawing.Size(265, 26)
        Me.AllCustomersToolStripMenuItem.Text = "&All Customers Details"
        '
        'ViewCustomerDynamicToolStripMenuItem
        '
        Me.ViewCustomerDynamicToolStripMenuItem.Name = "ViewCustomerDynamicToolStripMenuItem"
        Me.ViewCustomerDynamicToolStripMenuItem.Size = New System.Drawing.Size(265, 26)
        Me.ViewCustomerDynamicToolStripMenuItem.Text = "View Customer dynamic"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MonthlyCustomerDetailsToolStripMenuItem, Me.DailyCustomerDetailsToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(81, 25)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'MonthlyCustomerDetailsToolStripMenuItem
        '
        Me.MonthlyCustomerDetailsToolStripMenuItem.Name = "MonthlyCustomerDetailsToolStripMenuItem"
        Me.MonthlyCustomerDetailsToolStripMenuItem.Size = New System.Drawing.Size(302, 26)
        Me.MonthlyCustomerDetailsToolStripMenuItem.Text = "Monthly_Customer_Details"
        '
        'DailyCustomerDetailsToolStripMenuItem
        '
        Me.DailyCustomerDetailsToolStripMenuItem.Name = "DailyCustomerDetailsToolStripMenuItem"
        Me.DailyCustomerDetailsToolStripMenuItem.Size = New System.Drawing.Size(302, 26)
        Me.DailyCustomerDetailsToolStripMenuItem.Text = "Daily_Customer_Details"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(60, 25)
        Me.HelpMenu.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(212, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.AboutToolStripMenuItem.Text = "&About ..."
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 660)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1356, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'Log_Out_Btn
        '
        Me.Log_Out_Btn.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Log_Out_Btn.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Log_Out_Btn.Location = New System.Drawing.Point(850, 0)
        Me.Log_Out_Btn.Name = "Log_Out_Btn"
        Me.Log_Out_Btn.Size = New System.Drawing.Size(104, 29)
        Me.Log_Out_Btn.TabIndex = 11
        Me.Log_Out_Btn.Text = "Log_Out"
        Me.Log_Out_Btn.UseVisualStyleBackColor = True
        '
        'BankingAppMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1356, 682)
        Me.Controls.Add(Me.Log_Out_Btn)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MinimizeBox = False
        Me.Name = "BankingAppMDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BankingAppMDI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditCustomerDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreditAmountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DebitAmountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SingleCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllCustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonthlyCustomerDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DailyCustomerDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Log_Out_Btn As System.Windows.Forms.Button
    Friend WithEvents ViewCustomerDynamicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
