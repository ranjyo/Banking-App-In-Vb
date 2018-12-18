Imports System.Data.SqlClient


Public Class Login
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim User As String = Nothing

    Public Sub connection()
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Banking_ApplicationDB;Integrated Security=True")
        con.Open()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If con.State = ConnectionState.Closed Then
            connection()
        End If
        'Dim cmd As New SqlCommand("Select * from User_Login where Username = '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "'", con)
        cmd.CommandText = "Select * from User_Login where Username = '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "'"
        cmd.Connection = con

        User = cmd.ExecuteScalar

        If User = textBox1.Text Then
            MessageBox.Show("Login Successfully!!!")
            If (textBox1.Text = "admin") Then
                Common_Constants.Is_Admin = True
            End If

            'If (textBox1.Text = "admin") Then
            '    Common_Constant.validate_login = 3
            'ElseIf (textBox1.Text = "manager") Then
            '    Common_Constant.validate_login = 2
            'ElseIf (textBox1.Text = "CEO") Then
            '    Common_Constant.validate_login = 1
            'End If
            Me.Hide()
            BankingAppMDI.Show()
            label4.Text = ""
        Else
            label4.Text = "Login Failed... Please Enter Valid Username & Password... "
        End If
        textBox1.Text = ""
        textBox2.Text = ""
        btnLogin.Enabled = False
        textBox2.Enabled = False
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        textBox1.Focus()
        label4.Text = " Please Enter Your Username & Password for Login"
    End Sub

    Private Sub textBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textBox1.TextChanged
        textBox2.Enabled = True
    End Sub

    Private Sub textBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textBox2.TextChanged
        btnLogin.Enabled = True
    End Sub
End Class
