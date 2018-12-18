Imports System.Data.SqlClient

Public Class Credit_Amount
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
            textBox4.Text = ""
            TextBox7.Text = ""
            TextBox12.Text = ""
            TextBox3.Text = ""
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
            TextBox7.Text = dr("Surname").ToString
            textBox4.Text = dr("City").ToString
            TextBox12.Text = dr("Mob_No").ToString
            ComboBox1.Text = dr1("Cust_Acc_Type").ToString
            TextBox3.Text = dr1("Cust_Acc_Balance").ToString
            TextBox13.Enabled = True
        Else
            MessageBox.Show("Record Not Found...")
            btnFetch.Enabled = False
        End If
        con.Close()
    End Sub

    Private Sub btnCredit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCredit.Click
        Dim a, b As Integer

        If textBox2.Text <> "" And TextBox13.Text <> "" Then
            btnFetch.PerformClick()

            a = TextBox3.Text
            b = TextBox13.Text

            TextBox3.Text = a + b

            db.query_execute("Update Customer_Account_Details SET Cust_Acc_Balance = " + TextBox3.Text + " WHERE Cust_Acc_No=" + textBox1.Text + "")

            MessageBox.Show("Account UPDATED SUCCESFULLY...")
            CLEAR_CONTROL()
            btnFetch.Enabled = False
            TextBox13.Enabled = False
            btnCredit.Enabled = False
        Else
            MessageBox.Show("1st Enter Account Number of Customer and Amount to Credit...")
        End If
    End Sub

    Private Sub textBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textBox1.TextChanged
        btnFetch.Enabled = True
    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox13.TextChanged
        btnCredit.Enabled = True
    End Sub
End Class