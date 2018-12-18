Public Class View_All_Customer_Details

    Private Sub View_All_Customer_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Banking_ApplicationDBDataSet1.Customer_Personal_Details' table. You can move, or remove it, as needed.
        Me.Customer_Personal_DetailsTableAdapter1.Fill(Me.Banking_ApplicationDBDataSet1.Customer_Personal_Details)
    End Sub

    Private Sub View_All_Customer_Details_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'TODO: This line of code loads data into the 'Banking_ApplicationDBDataSet1.Customer_Personal_Details' table. You can move, or remove it, as needed.
        Me.Customer_Personal_DetailsTableAdapter1.Fill(Me.Banking_ApplicationDBDataSet1.Customer_Personal_Details)
    End Sub
End Class