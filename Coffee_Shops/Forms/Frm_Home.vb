Imports Domain

Public Class Frm_Home
    Private sql As New SQLControl


    Private Sub Frm_Home_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim query As String = "select * from categoryChart "
        sql.CategoryCht(Cht_Category, query)
    End Sub
End Class