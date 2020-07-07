Imports System.Data.SqlClient
Imports Domain
Public Class Frm_Products
    Private SQL As New SQLControl
    Private FrmDesign As New FormsDesign()
    Private Sub Placeholder()

        SQL.SetCueText(Txt_Price, Format("0.00"))
        SQL.SetCueText(Txt_priceSale, Format("0.00"))
        SQL.SetCueText(Txt_Discount, Format("0"))
        SQL.SetCueText(Txt_total, Format("0.00"))

        SQL.SetCueText(Txt_NameKH, Format("សូមបញ្ចូលឈ្មោះផលិផលជាភាសាខ្មែរ"))
        SQL.SetCueText(Txt_NameEN, Format("សូមបញ្ចូលឈ្មោះផលិផលជាឡាតាំង"))

        SQL.SetCueText(Txt_Description, Format("សូមពិពណ៌នាពីផលិតផល"))

        SQL.SetCueText(Cmb_Category, Format("សូមជ្រើសរើសប្រភេទ"))
        SQL.SetCueText(Cmb_Material, Format("ជ្រើសរើសប្រភព"))

    End Sub
    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Btn_AddMatrial_Click(sender As Object, e As EventArgs) Handles Btn_AddMatrial.Click
        Frms_Material.ShowDialog()
    End Sub

    Private Sub Btn_AddCategory_Click(sender As Object, e As EventArgs) Handles Btn_AddCategory.Click
        Frms_Category.ShowDialog()
    End Sub
    Private Sub Panel_Title_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_Title.MouseMove
        'call header form moving
        FrmDesign.ReleaseCapture()
        FrmDesign.SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub Frm_Products_Load(sender As Object, e As EventArgs) Handles Me.Load
        Placeholder()
        LoadGrid()
        SQL.cmbox(Cmb_Material, "SELECT material_id,namekh FROM tbl_Material ORDER BY namekh ASC;", "namekh", "material_id")
        SQL.cmbox(Cmb_Category, "SELECT category_id,namekh FROM tbl_Category ORDER BY namekh ASC;", "namekh", "category_id")

        autoid()
        headdvg()
    End Sub

    Sub headdvg()
        DGV_Data.Columns(0).HeaderText = "លេខសម្គាល់"
        DGV_Data.Columns(1).HeaderText = "ទំនិញ"
        DGV_Data.Columns(2).HeaderText = "ជាឡាតាំង"
        DGV_Data.Columns(3).HeaderText = "តម្លៃដើម"
        DGV_Data.Columns(4).HeaderText = "តម្លៃ"
        DGV_Data.Columns(5).HeaderText = "បញ្ចុះតម្លៃ"
        DGV_Data.Columns(6).HeaderText = "តម្លៃលក់"
        DGV_Data.Columns(7).HeaderText = "ពិពណ៌នា"
        DGV_Data.Columns(9).HeaderText = "ប្រភេទ"
        DGV_Data.Columns(10).HeaderText = "ប្រភព"

        DGV_Data.Columns(8).HeaderText = "រូបភាព"
    End Sub
    Sub autoid()
        ''  Txt_ID.Text = SQL.getMaxID("tbl_product", "product_id", "Cat-0000001", 5, 7)
        Txt_ID.Text = SQL.getMaxID("tbl_product", "product_id", "PR-000000", 4, 7)
    End Sub
#Region "Save data in form"
    Private Sub Insert()
        ' ADD SQL PARAMS & RUN THE COMMAND

        SQL.AddParam("@id", Txt_ID.Text)
        SQL.AddParam("@nameEN", Txt_NameEN.Text)
        SQL.AddParam("@nameKH", Txt_NameKH.Text)
        SQL.AddParam("@price", Txt_Price.Text)
        SQL.AddParam("@salePrice", Txt_total.Text)
        SQL.AddParam("@discount", Txt_Discount.Text)
        SQL.AddParam("@total", Txt_total.Text)
        SQL.AddParam("@desc", Txt_Description.Text)

        SQL.AddParam("@img", "img/logo.png")
        SQL.AddParam("@category", Cmb_Category.SelectedValue)
        SQL.AddParam("@material", Cmb_Material.SelectedValue)

        SQL.ExecQuery("INSERT INTO tbl_Product (product_id,nameKH,nameEN,price,salePrice,discount,total,description,image,material_id,category_id) " &
                      "VALUES (@id,@nameKH,@nameEN,@price,@salePrice,@discount,@total,@desc,@img,@material,@category);", True)

        ' REPORT & ABORT ON ERRORS
        If SQL.HasException(True) Then Exit Sub

        'If SQL.dt.Rows.Count > 0 Then
        '    Dim r As DataRow = SQL.dt.Rows(0)
        '    MsgBox(r("LastID").ToString)
        'End If
        MsgBox("បង្កើតផលិតផលថ្មីបានជោគជ័យ", MessageBoxIcon.Information, "ផលិតផលថ្មី")
        LoadGrid()
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Insert()
        autoid()
    End Sub

    Private Sub Txt_Discount_TextChanged(sender As Object, e As EventArgs) Handles Txt_Discount.TextChanged
        Placeholder()
        If Txt_priceSale.Text <> "" And Txt_Discount.Text <> "" Then
            Txt_total.Text = CDbl(Txt_priceSale.Text) - CDbl(Txt_priceSale.Text) * CDbl(Txt_Discount.Text / 100)
        End If
    End Sub

    Private Sub Txt_priceSale_TextChanged(sender As Object, e As EventArgs) Handles Txt_priceSale.TextChanged
        Placeholder()
        If Txt_priceSale.Text <> "" And Txt_Discount.Text <> "" Then
            Txt_total.Text = CDbl(Txt_priceSale.Text) - CDbl(Txt_priceSale.Text) * CDbl(Txt_Discount.Text / 100)
        End If
    End Sub
#End Region
#Region "Update"
    Private Sub Update()

        SQL.AddParam("@nameEN", Txt_NameEN.Text)
        SQL.AddParam("@nameKH", Txt_NameKH.Text)
        SQL.AddParam("@price", Txt_Price.Text)
        SQL.AddParam("@salePrice", Txt_total.Text)
        SQL.AddParam("@discount", Txt_Discount.Text)
        SQL.AddParam("@total", Txt_total.Text)
        SQL.AddParam("@desc", Txt_Description.Text)
        SQL.AddParam("@category", Cmb_Category.SelectedValue)
        SQL.AddParam("@material", Cmb_Material.SelectedValue)
        SQL.AddParam("@id", Txt_ID.Text)

        SQL.ExecQuery("Update tbl_Product" &
                      "SET nameKH = @nameKH,nameEN = @nameEN,price = @price,salePrice = @salePrice,discount = @discount,total = @total,description = @desc,material_id = @material,category_id = @category" &
                      "WHERE product_id=@id;")

        If SQL.HasException(True) Then Exit Sub

        MsgBox("ទិន្នន័យកែប្រែបានជោគជ័យ.")
        LoadGrid()
        autoid()
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        Delete()


    End Sub
#End Region
#Region "delete data in form"
    Private Sub Delete()
        If MsgBox("តើអ្នកប្រាកដទេថាចង់លុបទិន្នន័យនេះ ! បើប្រាកដសូមមេត្តចុចបន្ដ ?", MsgBoxStyle.YesNo, "លុបទិនន្នន័យ?") = MsgBoxResult.Yes Then
            ' GENERATE A MASS DELETE COMMAND
            Dim DelString As String = "" ' query string builder
            SQL.AddParam("@id", Txt_ID.Text)
            DelString += "DELETE FROM tbl_product WHERE product_id=@id ;"

            SQL.ExecQuery(DelString)

            ' REPORT & ABORT ON ERRORS
            If SQL.HasException(True) Then Exit Sub

            ' REPORT SUCCESS
            MsgBox("លុបបានជោគជ័យ!")
            LoadGrid()
            autoid()
            ' REFRESH USER LIST
            '  FetchUsers()
        End If
    End Sub
    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        Update()

    End Sub
#End Region
#Region "Retreive Data in Form"
    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT * FROM tbl_Product where material_id ='M-0002' ")
        Else
            SQL.ExecQuery(Query)
        End If

        ' ERROR HANDLING
        If SQL.HasException(True) Then Exit Sub

        DGV_Data.DataSource = SQL.dt

    End Sub
    'Private Sub loadsession()

    '    Dim str As String = "SELECT material_id,namekh FROM tbl_Material"
    '    Dim da As SqlDataAdapter = New SqlDataAdapter(str, SQL.cn)
    '    Dim dt As New DataTable
    '    da.Fill(dt)
    '    Dim bs As BindingSource = New BindingSource
    '    bs.DataSource = dt
    '    Cmb_Material.DataSource = bs
    '    Cmb_Material.DisplayMember = "namekh"
    '    Cmb_Material.ValueMember = "material_id"
    '    'txtstudentid.Text = ""
    '    Me.Cmb_Material.SelectedValue = -1
    'End Sub
    Private Sub LoadCBX(itm As ComboBox, table As String, index As String)
        ' REFRESH COMBOBOX
        itm.Items.Clear()
        ' RUN QUERY
        SQL.ExecQuery(table)

        If SQL.HasException(True) Then Exit Sub

        ' LOOP ROW & ADD TO COMBOBOX
        For Each r As DataRow In SQL.dt.Rows
            itm.Items.Add(r(index).ToString)
        Next
    End Sub

    Private Sub DGV_Data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Data.CellContentClick
        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow

            row = DGV_Data.Rows(e.RowIndex)

            Me.Txt_ID.Text = row.Cells("product_id").Value.ToString
            Me.Txt_NameEN.Text = row.Cells("nameEn").Value.ToString
            Me.Txt_NameKH.Text = row.Cells("nameKH").Value.ToString
            Me.Txt_Price.Text = row.Cells("Price").Value.ToString
            Me.Txt_total.Text = row.Cells("SalePrice").Value.ToString
            Me.Txt_Discount.Text = row.Cells("discount").Value.ToString
            Me.Txt_total.Text = row.Cells("total").Value.ToString
            Me.Txt_Description.Text = row.Cells("description").Value.ToString
            Me.Cmb_Category.Text = row.Cells("category_id").Value.ToString
            Me.Cmb_Material.Text = row.Cells("material_id").Value.ToString
        End If
    End Sub

    Private Sub Cmb_Category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Category.SelectedIndexChanged

    End Sub



#End Region
End Class