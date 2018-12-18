Imports System.Data.SqlClient

Public Class Update_Customer_Details
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
            textBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            TextBox11.Text = ""
            TextBox12.Text = ""
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
            TextBox11.Text = dr("Email_Id").ToString
            TextBox12.Text = dr("Mob_No").ToString


            DateTimePicker2.Text = dr1("Cust_Acc_Created_Date").ToString

            textBox2.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
            TextBox8.Enabled = True
            textBox4.Enabled = True
            TextBox9.Enabled = True
            TextBox10.Enabled = True
            TextBox11.Enabled = True
            TextBox12.Enabled = True
            btnUpdate.Enabled = True
        Else
            MessageBox.Show("Record Not Found...")
            btnFetch.Enabled = False
        End If
        con.Close()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If textBox2.Text <> "" And textBox4.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" And TextBox8.Text <> "" And TextBox9.Text <> "" And TextBox12.Text <> "" Then
            If String.IsNullOrEmpty(TextBox10.Text) And String.IsNullOrEmpty(TextBox11.Text) Then
                db.query_execute("Update Customer_Personal_Details SET First_Name = '" + textBox2.Text + "',Middle_Name = '" + TextBox6.Text + "',Surname = '" + TextBox7.Text + "',Mothers_Name = '" + TextBox8.Text + "',City = '" + textBox4.Text + "',Pin_Code = " + TextBox9.Text + ",Mob_No = " + TextBox12.Text + " WHERE Cust_Acc_No=" + textBox1.Text + "")
            ElseIf String.IsNullOrEmpty(TextBox10.Text) Then
                db.query_execute("Update Customer_Personal_Details SET First_Name = '" + textBox2.Text + "',Middle_Name = '" + TextBox6.Text + "',Surname = '" + TextBox7.Text + "',Mothers_Name = '" + TextBox8.Text + "',City = '" + textBox4.Text + "',Pin_Code = " + TextBox9.Text + ",Mob_No = " + TextBox12.Text + ",Email_Id = '" + TextBox11.Text + "' WHERE Cust_Acc_No=" + textBox1.Text + "")
            ElseIf String.IsNullOrEmpty(TextBox11.Text) Then
                db.query_execute("Update Customer_Personal_Details SET First_Name = '" + textBox2.Text + "',Middle_Name = '" + TextBox6.Text + "',Surname = '" + TextBox7.Text + "',Mothers_Name = '" + TextBox8.Text + "',City = '" + textBox4.Text + "',Pin_Code = " + TextBox9.Text + ",Phone_No = " + TextBox10.Text + ",Mob_No = " + TextBox12.Text + " WHERE Cust_Acc_No=" + textBox1.Text + "")
            Else
                db.query_execute("Update Customer_Personal_Details SET First_Name = '" + textBox2.Text + "',Middle_Name = '" + TextBox6.Text + "',Surname = '" + TextBox7.Text + "',Mothers_Name = '" + TextBox8.Text + "',City = '" + textBox4.Text + "',Pin_Code = " + TextBox9.Text + ",Phone_No = " + TextBox10.Text + ",Mob_No = " + TextBox12.Text + ",Email_Id = '" + TextBox11.Text + "' WHERE Cust_Acc_No=" + textBox1.Text + "")
            End If
            
            MessageBox.Show("DATA UPDATED SUCCESFULLY...")
            CLEAR_CONTROL()

            textBox2.Enabled = False
            TextBox6.Enabled = False
            TextBox7.Enabled = False
            TextBox8.Enabled = False
            textBox4.Enabled = False
            TextBox9.Enabled = False
            TextBox10.Enabled = False
            TextBox11.Enabled = False
            TextBox12.Enabled = False
            btnUpdate.Enabled = False
            btnFetch.Enabled = False
        Else
            MessageBox.Show("FIRST FILL ALL THE FIELDs...")
        End If
    End Sub

    Private Sub textBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textBox1.TextChanged
        btnFetch.Enabled = True
    End Sub
End Class