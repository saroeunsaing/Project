Imports Domain
Public Class Frm_Rate
    Private sql As New SQLControl
    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        sql.AddParam("@rate", txt_Rate.Text)

        sql.ExecQuery("Update tbl_Rate SET rate = @rate")

        If Sql.HasException(True) Then Exit Sub

        MsgBox("ទិន្នន័យកែប្រែបានជោគជ័យ")

    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub
End Class