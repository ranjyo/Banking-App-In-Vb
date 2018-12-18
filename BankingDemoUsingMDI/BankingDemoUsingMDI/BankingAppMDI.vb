Imports System.Windows.Forms

Public Class BankingAppMDI

    Private Sub AddNewCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewCustomerToolStripMenuItem.Click
        Add_New_Customer.MdiParent = Me
        Add_New_Customer.WindowState = FormWindowState.Maximized
        Add_New_Customer.Show()
    End Sub

    Private Sub EditCustomerDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditCustomerDetailsToolStripMenuItem.Click
        Update_Customer_Details.MdiParent = Me
        Update_Customer_Details.WindowState = FormWindowState.Maximized
        Update_Customer_Details.Show()
    End Sub

    Private Sub DeleteCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteCustomerToolStripMenuItem.Click
        Delete_Customer.MdiParent = Me
        Delete_Customer.WindowState = FormWindowState.Maximized
        Delete_Customer.Show()
    End Sub

    Private Sub SingleCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SingleCustomerToolStripMenuItem.Click
        View_Single_Customer_Details.MdiParent = Me
        View_Single_Customer_Details.WindowState = FormWindowState.Maximized
        View_Single_Customer_Details.Show()
    End Sub

    Private Sub AllCustomersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllCustomersToolStripMenuItem.Click
        View_All_Customer_Details.MdiParent = Me
        View_All_Customer_Details.WindowState = FormWindowState.Maximized
        View_All_Customer_Details.Show()
    End Sub

    Private Sub CreditAmountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditAmountToolStripMenuItem.Click
        Credit_Amount.MdiParent = Me
        Credit_Amount.WindowState = FormWindowState.Maximized
        Credit_Amount.Show()
    End Sub

    Private Sub DebitAmountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DebitAmountToolStripMenuItem.Click
        Debit_Amount.MdiParent = Me
        Debit_Amount.WindowState = FormWindowState.Maximized
        Debit_Amount.Show()
    End Sub

    Private Sub ViewCustomerDynamicToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewCustomerDynamicToolStripMenuItem.Click
        View_Customer_Dynamic.MdiParent = Me
        View_Customer_Dynamic.WindowState = FormWindowState.Maximized
        View_Customer_Dynamic.Show()
    End Sub

    Private Sub BankingAppMDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (Common_Constants.Is_Admin) Then
            EditCustomerDetailsToolStripMenuItem.Visible = True
            DeleteCustomerToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Sub BankingAppMDI_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Log_Out_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Log_Out_Btn.Click
        If (Common_Constants.Is_Admin) Then
            EditCustomerDetailsToolStripMenuItem.Visible = False
            DeleteCustomerToolStripMenuItem.Visible = False
            Common_Constants.Is_Admin = False
        End If
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub BankingAppMDI_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If (Common_Constants.Is_Admin) Then
            EditCustomerDetailsToolStripMenuItem.Visible = True
            DeleteCustomerToolStripMenuItem.Visible = True
        End If
    End Sub
End Class
