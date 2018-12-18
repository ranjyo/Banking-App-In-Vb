Imports System.Data.SqlClient

Public Class View_Customer_Dynamic
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand


    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Banking_ApplicationDB;Integrated Security=True")
            con.Open()
        End If
    End Sub


    Private Sub View_Customer_Dynamic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Text = "SELECT For Search"
        ComboBox1.Focus()
        connection()

        cmd.Connection = con
        cmd.CommandText = "select * from Customer_Personal_Details"

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()

        da.Fill(dt)

        DataGridView1.DataSource = dt
        con.Close()
    End Sub

    Private Sub Btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search.Click
        connection()
        cmd.Connection = con
        cmd.CommandText = "select * from Customer_Personal_Details where " + ComboBox1.Text + " like '%" + TextBox1.Text + "%'"

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()

        da.Fill(dt)

        DataGridView1.DataSource = dt
        con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Enabled = True
    End Sub

    Private Sub Btn_Refresh_Grid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Refresh_Grid.Click
        connection()

        cmd.Connection = con
        cmd.CommandText = "select * from Customer_Personal_Details"

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()

        da.Fill(dt)

        DataGridView1.DataSource = dt
        con.Close()
        ComboBox1.Focus()
        ComboBox1.Text = "SELECT For Search"
        TextBox1.Text = ""
        TextBox1.Enabled = False
        Btn_Search.Enabled = False
        Btn_Refresh_Grid.Enabled = False
    End Sub

    Private Sub ComboBox1_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.DropDown
        TextBox1.Enabled = True
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Btn_Search.Enabled = True
        Btn_Refresh_Grid.Enabled = True
    End Sub
End Class