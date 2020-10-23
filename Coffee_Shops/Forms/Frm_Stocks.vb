Imports System.Data.SqlClient
Imports Domain
Public Class Frm_Stocks
    Private sql As New SQLControl
#Region "Retreive Data in Form"
    Sub headdvg()
        DGV_Data.Columns(0).HeaderText = "កូដផលិតផល"
        DGV_Data.Columns(1).HeaderText = "ផលិតផល"
        DGV_Data.Columns(2).HeaderText = "ជាឡាតាំង"
        DGV_Data.Columns(3).HeaderText = "ចំនួន"
        DGV_Data.Columns(4).HeaderText = "តម្លៃ"
        'DGV_Data.Columns(5).HeaderText = "សរុបទឹកប្រាក់"
        'DGV_Data.Columns(6).HeaderText = "តម្លៃលក់"
        'DGV_Data.Columns(7).HeaderText = "ពិពណ៌នា"
        'DGV_Data.Columns(9).HeaderText = "ប្រភព"
        'DGV_Data.Columns(10).HeaderText = "ប្រភេទ"
        DGV_Data.ColumnHeadersDefaultCellStyle.Font = New Font("Khmer OS Siemreap", 9.75F, FontStyle.Bold)
    End Sub
    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            sql.ExecQuery("SELECT product_id,namekh,nameen,amount,total FROM stock ")
        Else
            sql.ExecQuery(Query)
        End If

        ' ERROR HANDLING
        If sql.HasException(True) Then Exit Sub

        DGV_Data.DataSource = sql.dt

    End Sub
    Public Sub cmbSearch(Optional Query As String = "")
        If Query = "" Then
            sql.ExecQuery("SELECT * FROM stock where namekh = N'" & Cmb_ProductName.Text & "' ")
        Else
            sql.ExecQuery(Query)
        End If

        ' ERROR HANDLING
        If sql.HasException(True) Then Exit Sub

        DGV_Data.DataSource = sql.dt

    End Sub
#End Region
    Private Sub Placeholder()

        sql.SetCueText(Txt_Purchase, Format("0.00"))
        sql.SetCueText(Txt_Sale, Format("0.00"))

        sql.SetCueText(Txt_Amount, Format("0"))
        sql.SetCueText(Txt_Total, Format("0.00"))


        Txt_Amount.Text = CInt(0)
        Txt_Purchase.Text = CInt(0)
        Txt_Sale.Text = CInt(0)

        'sql.SetCueText(Txt_NameKH, Format("សូមបញ្ចូលឈ្មោះផលិផលជាភាសាខ្មែរ"))
        'sql.SetCueText(Txt_NameEN, Format("សូមបញ្ចូលឈ្មោះផលិផលជាឡាតាំង"))

        'sql.SetCueText(Txt_Description, Format("សូមពិពណ៌នាពីផលិតផល"))

        'sql.SetCueText(Cmb_Category, Format("សូមជ្រើសរើសប្រភេទ"))
        'sql.SetCueText(Cmb_Material, Format("ជ្រើសរើសប្រភព"))

    End Sub

    Private Sub Frm_Stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Txt_SalePrice.Text = sql.getMaxID("tbl_stock", "id", "ST-00000000", 4, 8)
        sql.cmbox(Cmb_ProductName, "SELECT * FROM rpt_cmbProduct", "name", "id")

        sql.cmbox(Cmb_Scale, "SELECT * FROM tbl_Scale", "nameKh", "id")
        Placeholder()
        LoadGrid()
        headdvg()
        DTP_Purchase.Value = Now()
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
        sql.AddParam("@scale", Cmb_Scale.Text)

        'sql.AddParam("@img", "img/logo.png")
        'sql.AddParam("@category", Cmb_Category.SelectedValue)
        'sql.AddParam("@material", Cmb_Material.SelectedValue)

        sql.ExecQuery("INSERT INTO tbl_Stock (id,pro_code,amount,purchase_price,sale_price,total,date,scale) " &
                      "VALUES (@id,@pro_id,@amount,@purchase,@sale,@total,@date,@scale);", True)

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
        LoadGrid()
        Txt_Amount.Text = CInt(0)
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Insert()

    End Sub
    Private Sub Cmb_ProductName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_ProductName.SelectedIndexChanged
        sql.ReadData(Txt_ProductCode, "SELECT * FROM rpt_cmbProduct Where name = N'" & Cmb_ProductName.Text & "'")
        sql.ReadData(Txt_Purchase, "select min(purchase_price),pro_code from tbl_Stock where pro_code = N'" & Txt_ProductCode.Text & "' Group By pro_code")
        cmbSearch()
    End Sub

    Private Sub Txt_Purchase_TextChanged(sender As Object, e As EventArgs) Handles Txt_Purchase.TextChanged

        If Txt_Amount.Text <> "" And Txt_Purchase.Text <> "" Then
            Txt_Total.Text = CDbl(Txt_Purchase.Text) * CDbl(Txt_Amount.Text)
        End If
    End Sub
#End Region
    Private Sub update()
        ' ADD SQL PARAMS & RUN THE COMMAND

        sql.AddParam("@id", sql.getMaxID("tbl_stock", "id", "ST-00000000", 4, 9))
        sql.AddParam("@pro_id", Txt_ProductCode.Text)
        sql.AddParam("@amount", -(Txt_Amount.Text))
        sql.AddParam("@purchase", Txt_Purchase.Text)
        sql.AddParam("@sale", Txt_Sale.Text)
        sql.AddParam("@total", -(Txt_Total.Text))
        sql.AddParam("@date", DTP_Purchase.Value)
        sql.AddParam("@scale", Cmb_Scale.Text)


        sql.ExecQuery("INSERT INTO tbl_Stock (id,pro_code,amount,purchase_price,sale_price,total,date,scale) " &
                      "VALUES (@id,@pro_id,@amount,@purchase,@sale,@total,@date,@scale);", True)


        If sql.HasException(True) Then Exit Sub


        MsgBox("បន្ថែមស្ដុកបានជោគជ័យ", MessageBoxIcon.Information, "បន្ថែមស្ដុកថ្មី")
        LoadGrid()
        Txt_Amount.Text = CInt(0)
    End Sub

    Private Sub Txt_Amount_TextChanged(sender As Object, e As EventArgs) Handles Txt_Amount.TextChanged

        If Txt_Amount.Text <> "" And Txt_Purchase.Text <> "" Then
            Txt_Total.Text = CDbl(Txt_Purchase.Text) * CDbl(Txt_Amount.Text)
        End If
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        update()
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Panel_Stock_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Stock.Paint

    End Sub
End Class