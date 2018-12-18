Imports System.Data.SqlClient

Public Class View_Single_Customer_Details
    Dim con, con1 As New SqlConnection
    Dim cmd, cmd1 As New SqlCommand
    Dim dr, dr1 As SqlDataReader

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
            textBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            TextBox11.Text = ""
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
            TextBox8.Text = dr("Mothers_Name").ToString
            textBox4.Text = dr("City").ToString
            TextBox9.Text = dr("Pin_Code").ToString
            DateTimePicker1.Text = dr("Birth_Date").ToString
            textBox3.Text = dr("Pan_No").ToString
            TextBox5.Text = dr("Addhar_No").ToString
            TextBox10.Text = dr("Phone_No").ToString
            TextBox12.Text = dr("Mob_No").ToString
            TextBox11.Text = dr("Email_Id").ToString

            ComboBox1.Text = dr1("Cust_Acc_Type").ToString
            DateTimePicker2.Text = dr1("Cust_Acc_Created_Date").ToString
            TextBox13.Text = dr1("Cust_Acc_Balance").ToString

            btn_Clr_Dtails.Enabled = True
        Else
            MessageBox.Show("Record Not Found...")
            btn_Clr_Dtails.Enabled = False
            btnFetch.Enabled = False
        End If
        con.Close()
    End Sub

    Private Sub View_Single_Customer_Details_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        CLEAR_CONTROL()
        btn_Clr_Dtails.Enabled = False
        btnFetch.Enabled = False
    End Sub

    Private Sub btn_Clr_Dtails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clr_Dtails.Click
        CLEAR_CONTROL()
        btn_Clr_Dtails.Enabled = False
        btnFetch.Enabled = False
    End Sub

    Private Sub textBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textBox1.TextChanged
        btnFetch.Enabled = True
    End Sub
End Class