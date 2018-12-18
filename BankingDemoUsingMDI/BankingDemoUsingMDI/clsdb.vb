Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.Common

Public Class clsdb
    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Banking_ApplicationDB;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dt As New DataTable
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Public Sub cnopen()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
    End Sub

    Public Sub query_execute(ByVal q As String)
        cnopen()
        cmd = New SqlCommand(q, cn)
        cmd.ExecuteScalar()
    End Sub

    Public Sub query_execute1(ByVal q As String)
        cnopen()
        cmd = New SqlCommand(q, cn)
        cmd.ExecuteNonQuery()
    End Sub

    Public Function loaddata(ByVal q As String) As DataTable
        cnopen()
        dt.Clear()
        cmd = New SqlCommand(q, cn)
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function
End Class