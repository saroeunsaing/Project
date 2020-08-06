Imports Domain
Public Class Frm_Home
    Private sql As New sqlcontrol
    Private Sub Frm_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql.CategoryCht(Chrt_Category, "Select * from cht_category")

        Chrt_Period.DataSource = sql.ChrtData("Select * from cht_Period")
        Chrt_Period.Series("តម្លៃលក់សរុប").XValueMember = "P_Date"
        Chrt_Period.Series("តម្លៃលក់សរុប").YValueMembers = "Total"
        Chrt_Period.Series("មុខទំនិញសរុប").XValueMember = "P_Date"
        Chrt_Period.Series("មុខទំនិញសរុប").YValueMembers = "Amount"
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub
End Class