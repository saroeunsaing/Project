Imports System.Runtime.InteropServices
Imports Domain


Public Class Frm_Login
    Dim sql As New SQLControl

    Private Sub Placeholder()

        'sql.SetCueText(Txt_Price, Format("0.00"))
        'sql.SetCueText(Txt_priceSale, Format("0.00"))
        'sql.SetCueText(Txt_Discount, Format("0"))
        'sql.SetCueText(Txt_total, Format("0.00"))
        Txt_Password.PasswordChar = CChar("*")
        sql.SetCueText(Txt_Username, Format("សូមបញ្ចូលលេខគណនីរបស់លោកអ្នក"))
        sql.SetCueText(Txt_Password, Format("សូមបញ្ចូលលេខសម្ថាត់របស់លោកអ្នក"))

        'sql.SetCueText(Txt_Description, Format("សូមពិពណ៌នាពីផលិតផល"))

        'sql.SetCueText(Cmb_Category, Format("សូមជ្រើសរើសប្រភេទ"))
        'sql.SetCueText(Cmb_Material, Format("ជ្រើសរើសប្រភព"))

    End Sub
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
        Placeholder()
        sql.labelS(Label_ShopName, "select * from tbl_shop")
        sql.Image(Pic_Logo, "Select Logo from tbl_Shop")

    End Sub


    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Btn_Setting_Click(sender As Object, e As EventArgs) Handles Btn_Setting.Click
        Me.Hide()
        Frm_Shop.Show()
    End Sub

End Class