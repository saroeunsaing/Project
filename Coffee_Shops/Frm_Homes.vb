Imports Domain
Public Class Frm_Homes


    Private sql As New SQLControl

    Private Sub Panel_Stock_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Stock.Paint
        sql.CategoryCht(Chrt_Category, "Select * from cht_category")
    End Sub


End Class