Imports System.Runtime.InteropServices
Imports Domain


Public Class Frm_Login
    Dim sql As New SQLControl
    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        Dim userModel As New UserModel()
        Dim ValidLogin = userModel.Login(Txt_Username.Text, Txt_Password.Text)
        If ValidLogin = True Then
            Dim frm As New Frm_Dashboard
            frm.Show()
            Me.Hide()
        Else
            MessageBox.Show("គណនី ឬលេខសំងាត់មិនត្រឹមត្រូវ" + vbNewLine + "ព្យាយាម្ដងទៀត")
            Txt_Password.Clear()
            Txt_Password.Focus()

        End If
    End Sub

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles Me.Load

        sql.labelS(Label_ShopName, "select * from tbl_shop")
    End Sub
End Class