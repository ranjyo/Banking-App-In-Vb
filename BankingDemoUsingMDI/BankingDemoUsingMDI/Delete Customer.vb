Imports System.Data.SqlClient

Public Class Delete_Customer
    Dim con, con1 As New SqlConnection
    Dim cmd, cmd1 As New SqlCommand
    Dim dr, dr1 As SqlDataReader
    Dim db As New clsdb

    Public Sub connection()
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Banking_ApplicationDB;Integrated Security=True")
        con.Open()
        con1 = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Banking_ApplicationDB;Integrated Security=True")
        con1.Open()
    End Sub

    Function CLEAR_CONTROL()
        Try
            textBox1.Text = ""
            textBox2.Text = ""
            textBox3.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox12.Text = ""
            TextBox13.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return 0
    End Function

    Private Sub btnFetch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFetch.Click
        If con.State = ConnectionState.Closed Then
            connection()
        End If

        cmd.Connection = con
        cmd.CommandText = "select * from Customer_Personal_Details where Cust_Acc_No = " + textBox1.Text + ""
        dr = cmd.ExecuteReader

        cmd1.Connection = con1
        cmd1.CommandText = "select * from Customer_Account_Details where Cust_Acc_No = " + textBox1.Text + ""
        dr1 = cmd1.ExecuteReader

        If dr.Read() And dr1.Read() Then
            textBox2.Text = dr("First_Name").ToString
            TextBox6.Text = dr("Middle_Name").ToString
            TextBox7.Text = dr("Surname").ToString

            textBox3.Text = dr("Pan_No").ToString
            TextBox5.Text = dr("Addhar_No").ToString

            TextBox12.Text = dr("Mob_No").ToString

            ComboBox1.Text = dr1("Cust_Acc_Type").ToString
            DateTimePicker2.Text = dr1("Cust_Acc_Created_Date").ToString
            TextBox13.Text = dr1("Cust_Acc_Balance").ToString

            If (TextBox13.Text = 0) Then
                btnDelete.Enabled = True
            Else
                btnWithdraw.Enabled = True
            End If
        Else
            MessageBox.Show("Record Not Found...")
            btnFetch.Enabled = False
            TextBox13.Enabled = False
            btnWithdraw.Enabled = False
        End If
        con.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        btnFetch.PerformClick()
        If (TextBox13.Text > 0) Then
            MessageBox.Show("Customers Account Balance Must Be Zero Then Only Account Can Be Deleted...")
            btnFetch.Enabled = False
            TextBox13.Enabled = False
            btnWithdraw.Enabled = False
        Else
            Try
                If textBox1.Text <> "" Then
                    btnFetch.PerformClick()
                    db.query_execute("DELETE FROM Customer_Account_Details WHERE Cust_Acc_No=" + textBox1.Text + "")
                    db.query_execute("DELETE FROM Customer_Personal_Details WHERE Cust_Acc_No=" + textBox1.Text + "")
                    MessageBox.Show("DATA DELETED SUCCESFULLY")
                    CLEAR_CONTROL()
                    btnDelete.Enabled = False
                Else
                    MessageBox.Show("1st Enter Customers Account Number")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub Delete_Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CLEAR_CONTROL()
    End Sub

    Private Sub Delete_Customer_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        CLEAR_CONTROL()
    End Sub

    Private Sub btnWithdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithdraw.Click
        Debit_Amount.MdiParent = BankingAppMDI
        Debit_Amount.WindowState = FormWindowState.Maximized
        Debit_Amount.Show()
    End Sub

    Private Sub textBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textBox1.TextChanged
        btnFetch.Enabled = True
        btnWithdraw.Enabled = False
        btnDelete.Enabled = False
    End Sub
End Class