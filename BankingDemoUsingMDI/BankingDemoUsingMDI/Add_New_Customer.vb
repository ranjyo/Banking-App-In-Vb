Imports System
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes


Public Class Add_New_Customer
    Dim db As New clsdb
    Dim dt As New DataTable
    Dim rownumber As Integer
    Dim dr As SqlDataReader
    Dim cmd As New SqlCommand
    Public con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Banking_ApplicationDB;Integrated Security=True")

    Public Sub connection()
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Banking_ApplicationDB;Integrated Security=True")
        con.Open()
    End Sub

    Function CLEAR_CONTROL()
        Try
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

    Private Sub Add_New_Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        textBox2.Focus()

        Dim a As Integer

        connection()

        cmd = New SqlCommand("select MAX(Cust_Acc_No) from Customer_Account_Details", con)
        a = cmd.ExecuteScalar
        con.Close()

        If a > 0 Then
            a = a + 1
        Else
            a = 1001
        End If

        textBox1.Text = a
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If textBox2.Text <> "" And textBox3.Text <> "" And textBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" And TextBox8.Text <> "" And TextBox9.Text <> "" And TextBox12.Text <> "" And TextBox13.Text <> "" And DateTimePicker1.Text <> "" And DateTimePicker2.Text <> "" Then
            If (String.IsNullOrEmpty(TextBox10.Text)) And (String.IsNullOrEmpty(TextBox11.Text)) Then
                db.query_execute1("INSERT INTO Customer_Personal_Details (Cust_Acc_No,First_Name,Middle_Name,Surname,Mothers_Name,City,Pin_Code,Birth_Date,Pan_No,Addhar_No,Mob_No)VALUES (" + textBox1.Text + ",'" + textBox2.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + textBox4.Text + "'," + TextBox9.Text + ",'" + DateTimePicker1.Text + "','" + textBox3.Text + "'," + TextBox5.Text + "," + TextBox12.Text + ")")
                db.query_execute1("INSERT INTO Customer_Account_Details VALUES (" + textBox1.Text + ",'" + DateTimePicker2.Text + "','" + ComboBox1.Text + "','" + TextBox13.Text + "')")
            ElseIf (String.IsNullOrEmpty(TextBox10.Text)) Then
                db.query_execute1("INSERT INTO Customer_Personal_Details (Cust_Acc_No,First_Name,Middle_Name,Surname,Mothers_Name,City,Pin_Code,Birth_Date,Pan_No,Addhar_No,Mob_No,Email_Id)VALUES (" + textBox1.Text + ",'" + textBox2.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + textBox4.Text + "'," + TextBox9.Text + ",'" + DateTimePicker1.Text + "','" + textBox3.Text + "'," + TextBox5.Text + "," + TextBox12.Text + ",'" + TextBox11.Text + "')")
                db.query_execute1("INSERT INTO Customer_Account_Details VALUES (" + textBox1.Text + ",'" + DateTimePicker2.Text + "','" + ComboBox1.Text + "','" + TextBox13.Text + "')")
            ElseIf (String.IsNullOrEmpty(TextBox11.Text)) Then
                db.query_execute1("INSERT INTO Customer_Personal_Details (Cust_Acc_No,First_Name,Middle_Name,Surname,Mothers_Name,City,Pin_Code,Birth_Date,Pan_No,Addhar_No,Phone_No,Mob_No)VALUES (" + textBox1.Text + ",'" + textBox2.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + textBox4.Text + "'," + TextBox9.Text + ",'" + DateTimePicker1.Text + "','" + textBox3.Text + "'," + TextBox5.Text + "," + TextBox10.Text + "," + TextBox12.Text + ")")
                db.query_execute1("INSERT INTO Customer_Account_Details VALUES (" + textBox1.Text + ",'" + DateTimePicker2.Text + "','" + ComboBox1.Text + "','" + TextBox13.Text + "')")
            Else
                db.query_execute1("INSERT INTO Customer_Personal_Details VALUES (" + textBox1.Text + ",'" + textBox2.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + textBox4.Text + "'," + TextBox9.Text + ",'" + DateTimePicker1.Text + "','" + textBox3.Text + "'," + TextBox5.Text + "," + TextBox10.Text + "," + TextBox12.Text + ",'" + TextBox11.Text + "')")
                db.query_execute1("INSERT INTO Customer_Account_Details VALUES (" + textBox1.Text + ",'" + DateTimePicker2.Text + "','" + ComboBox1.Text + "','" + TextBox13.Text + "')")
            End If

            MessageBox.Show("DATA SAVED SUCCESFULLY.")
            CLEAR_CONTROL()
            btnNew.PerformClick()
        Else
            MessageBox.Show("FIRST FILL ALL THE FIELDs.")
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        textBox2.Focus()

        Dim a As Integer

        connection()

        cmd = New SqlCommand("select MAX(Cust_Acc_No) from Customer_Account_Details", con)
        a = cmd.ExecuteScalar
        con.Close()

        If a > 0 Then
            a = a + 1
        Else
            a = 1001
        End If

        textBox1.Text = a

        CLEAR_CONTROL()
    End Sub
End Class