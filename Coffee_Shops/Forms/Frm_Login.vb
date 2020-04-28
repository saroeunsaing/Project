Imports System.Runtime.InteropServices
Imports Domain


Public Class Frm_Login
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
End Class