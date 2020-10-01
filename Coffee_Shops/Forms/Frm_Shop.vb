Imports Domain

Public Class Frm_Shop
    Private sql As New SQlcontrol
    Private Sub Frm_Shop_Load(sender As Object, e As EventArgs) Handles Me.Load
        sql.Shop(Txt_NameKH, Txt_NameEN, Txt_Contact1, Txt_Contact2, Txt_Address, Img_Logo, "Select * from tbl_shop")
        'sql.Image(Img_Logo, "Select Logo from tbl_Shop")
    End Sub




    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Me.Hide()
        Frm_Login.Show()
        sql.Image(Frm_Login.Pic_Logo, "Select Logo from tbl_Shop")
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Update()
    End Sub
#Region "Update"
    Private Sub Update()

        ' ADD SQL PARAMS & RUN THE COMMAND


        sql.AddParam("@nameEN", Txt_NameEN.Text)
        sql.AddParam("@nameKH", Txt_NameKH.Text)
        sql.AddParam("@tel", Txt_Contact1.Text)
        sql.AddParam("@contact", Txt_Contact2.Text)
        sql.AddParam("@add", Txt_Address.Text)

        Dim fname As String = Txt_NameEN.Text & ".jpg"
        Dim folder As String = "D:\Files\Logo"

        Dim pathstring As String = System.IO.Path.Combine(folder, fname)

        sql.AddParam("@img", pathstring)

        sql.ExecQuery("Update tbl_shop​​​ SET nameKH = @nameKH,nameEN = @nameEN,tel = @tel,contact = @contact,address = @add,logo = @img")

        Dim a As Image = Img_Logo.Image
        a.Save(pathstring)

        ' REPORT & ABORT ON ERRORS
        If sql.HasException(True) Then Exit Sub

        'If SQL.dt.Rows.Count > 0 Then
        '    Dim r As DataRow = SQL.dt.Rows(0)
        '    MsgBox(r("LastID").ToString)
        'End If
        MsgBox("កែប្រែបានជោគជ័យ", MessageBoxIcon.Information, "ហាង")

    End Sub


    Private Sub Btn_Remove_Click(sender As Object, e As EventArgs) Handles Btn_Remove.Click
        Img_Logo.Image = Nothing



    End Sub

    Private Sub Btn_Brows_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_Brows.MouseMove

    End Sub

    Private Sub Btn_Brows_Click(sender As Object, e As EventArgs) Handles Btn_Brows.Click
        sql.browsImg(Img_Logo)
    End Sub






#End Region
End Class