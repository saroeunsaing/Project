Imports Domain
Public Class Frm_Home
    Private sql As New sqlcontrol
    Private Sub Frm_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql.CategoryCht(Chrt_Category, "Select * from cht_category")
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Panel_Contain_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Contain.Paint

    End Sub
End Class