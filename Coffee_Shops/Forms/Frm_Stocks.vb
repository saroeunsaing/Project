Imports System.Data.SqlClient
Imports Domain
Public Class Frm_Stocks
    Private sql As New SQLControl

    Private Sub Placeholder()

        sql.SetCueText(Txt_Purchase, Format("0.00"))
        sql.SetCueText(Txt_Sale, Format("0.00"))

        sql.SetCueText(Txt_Amount, Format("0"))
        sql.SetCueText(Txt_Total, Format("0.00"))

        'sql.SetCueText(Txt_NameKH, Format("សូមបញ្ចូលឈ្មោះផលិផលជាភាសាខ្មែរ"))
        'sql.SetCueText(Txt_NameEN, Format("សូមបញ្ចូលឈ្មោះផលិផលជាឡាតាំង"))

        'sql.SetCueText(Txt_Description, Format("សូមពិពណ៌នាពីផលិតផល"))

        'sql.SetCueText(Cmb_Category, Format("សូមជ្រើសរើសប្រភេទ"))
        'sql.SetCueText(Cmb_Material, Format("ជ្រើសរើសប្រភព"))

    End Sub

    Private Sub Frm_Stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Txt_SalePrice.Text = sql.getMaxID("tbl_stock", "id", "ST-00000000", 4, 8)
        sql.cmbox(Cmb_ProductName, "SELECT * FROM v_Product", "name", "id")
        Placeholder()
    End Sub
#Region "Save data in form"
    Private Sub Insert()
        ' ADD SQL PARAMS & RUN THE COMMAND


        sql.AddParam("@id", sql.getMaxID("tbl_stock", "id", "ST-00000000", 4, 9))
        sql.AddParam("@pro_id", Txt_ProductCode.Text)
        sql.AddParam("@amount", Txt_Amount.Text)
        sql.AddParam("@purchase", Txt_Purchase.Text)
        sql.AddParam("@sale", Txt_Sale.Text)
        sql.AddParam("@total", Txt_Total.Text)
        sql.AddParam("@date", DTP_Purchase.Value)

        'sql.AddParam("@img", "img/logo.png")
        'sql.AddParam("@category", Cmb_Category.SelectedValue)
        'sql.AddParam("@material", Cmb_Material.SelectedValue)

        sql.ExecQuery("INSERT INTO tbl_Stock (id,pro_code,amount,purchase_price,sale_price,total,date) " &
                      "VALUES (@id,@pro_id,@amount,@purchase,@sale,@total,@date);", True)

        'sql.AddParam("@amount", Txt_Amount.Text)
        'sql.AddParam("@purchase", Txt_ProductCode.Text)
        'sql.AddParam("@sale", Txt_SalePrice.Text)
        'sql.AddParam("@total", Txt_TotalPrice.Text)
        'sql.AddParam("@date", DTP_Purchase.Value)
        'sql.AddParam("@id", Txt_ProductCode.Text)

        'sql.ExecQuery("Update tbl_Stock" &
        '              "SET nameKH = @nameKH,nameEN = @nameEN,price = @price,salePrice = @salePrice,discount = @discount,total = @total,description = @desc,material_id = @material,category_id = @category" &
        '              "WHERE product_id=@id;")
        ' REPORT & ABORT ON ERRORS
        If sql.HasException(True) Then Exit Sub

        'If SQL.dt.Rows.Count > 0 Then
        '    Dim r As DataRow = SQL.dt.Rows(0)
        '    MsgBox(r("LastID").ToString)
        'End If
        MsgBox("បន្ថែមស្ដុកបានជោគជ័យ", MessageBoxIcon.Information, "បន្ថែមស្ដុកថ្មី")
        ' LoadGrid()
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Insert()
    End Sub
    Private Sub Cmb_ProductName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_ProductName.SelectedIndexChanged
        sql.ReadData(Txt_ProductCode, "SELECT * FROM v_Product Where name = N'" & Cmb_ProductName.Text & "'")
    End Sub

    Private Sub Txt_Purchase_TextChanged(sender As Object, e As EventArgs) Handles Txt_Purchase.TextChanged
        Placeholder()
        If Txt_Amount.Text <> "" And Txt_Purchase.Text <> "" Then
            Txt_Total.Text = CDbl(Txt_Purchase.Text) * CDbl(Txt_Amount.Text)
        End If
    End Sub
#End Region
End Class