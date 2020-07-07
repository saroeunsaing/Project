Imports System.Data.Sql
Imports DataAccess
Imports Common
Imports Domain

Public Class Frm_Sale_Temp
    Private sql As New SQLControl

    Sub autoid()
        ''  Txt_ID.Text = SQL.getMaxID("tbl_product", "product_id", "Cat-0000001", 5, 7)
        Txt_Invoice.Text = sql.getMaxID("tbl_invoice", "invoice_no", "CIEDI-000000000", 7, 10)
    End Sub
    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
        Frm_Dashboard.Show()
    End Sub

    Private Sub DVG_Product_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DVG_Product.CellContentClick
        Try
            Frm_Amount.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Frm_Sale_Temp_Load(sender As Object, e As EventArgs) Handles Me.Load
        DVG_Product.DataSource = sql.GetData()
        autoid()
        Lb_User.Text = ActiveUser.fullname
        Txt_Discount.Text = 0
        sql.ReadData(Lb_Rate, "Select * from tbl_Rate")
    End Sub

    Private Sub Txt_SubTotal_TextChanged(sender As Object, e As EventArgs) Handles Txt_SubTotal.TextChanged
        Lb_Riel.Text = Val(Txt_SubTotal.Text) / Val(Lb_Rate.Text)
        Me.Txt_Total.Text = Me.Txt_SubTotal.Text
    End Sub

    Private Sub Txt_Discount_TextChanged(sender As Object, e As EventArgs) Handles Txt_Discount.TextChanged


    End Sub

    Private Sub Txt_Total_TextChanged(sender As Object, e As EventArgs) Handles Txt_Total.TextChanged
        Lb_Riels.Text = Val(Txt_Total.Text) / Val(Lb_Rate.Text)
    End Sub

    Private Sub Txt_Payment_TextChanged(sender As Object, e As EventArgs) Handles Txt_Payment.TextChanged
        Txt_PayDue.Text = Val(Txt_Payment.Text) - Val(Txt_Total.Text)
    End Sub

    Private Sub Btn_Maximize_Click(sender As Object, e As EventArgs) Handles Btn_Maximize.Click
        Btn_Restore.Visible = True
        Btn_Maximize.Visible = False

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Btn_Restore_Click(sender As Object, e As EventArgs) Handles Btn_Restore.Click
        Btn_Restore.Visible = False
        Btn_Maximize.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Btn_Cash_Click(sender As Object, e As EventArgs) Handles Btn_Cash.Click
        Insert()
        Me.Hide()
        Frm_RptSale.Show()
    End Sub
    Private Sub Insert()
        ' ADD SQL PARAMS & RUN THE COMMAND
        sql.AddParam("@invoiceno", Txt_Invoice.Text)
        sql.AddParam("@subtotal", Txt_SubTotal.Text)

        sql.AddParam("@discount", Txt_Discount.Text)
        sql.AddParam("@total", Txt_Total.Text)
        sql.AddParam("@payment", Txt_Payment.Text)
        sql.AddParam("@paydue", Txt_PayDue.Text)




        sql.ExecQuery("INSERT INTO tbl_Invoice (invoice_no,subtotal,discount,total,payment,payDue) " &
                      "VALUES (@invoiceno,@subtotal,@discount,@total,@payment,@paydue);", True)





        For i = 0 To Lst_data.Items.Count - 1

            sql.AddParam("@invoiceno", Txt_Invoice.Text)



            sql.AddParam("@productcode", Lst_data.Items(i).SubItems(1).Text)
            sql.AddParam("@qty", Lst_data.Items(i).SubItems(5).Text)
            sql.AddParam("@price", Lst_data.Items(i).SubItems(4).Text)

            sql.AddParam("@date", Format(Now(), "dd/MM/yyyy hh:mm tt"))
            sql.AddParam("@seller", Lb_User.Text)


            sql.ExecQuery("INSERT INTO tbl_Sale (invoice_no,product_code,qty,price,date,seller) " &
                          "VALUES (@invoiceno,@productcode,@qty,@price,@date,@seller);", True)


        Next



        ' REPORT & ABORT ON ERRORS
        If sql.HasException(True) Then Exit Sub

        'If SQL.dt.Rows.Count > 0 Then
        '    Dim r As DataRow = SQL.dt.Rows(0)
        '    MsgBox(r("LastID").ToString)
        'End If
        MsgBox("បង្កើតផលិតផលថ្មីបានជោគជ័យ", MessageBoxIcon.Information, "ផលិតផលថ្មី")
        ' LoadGrid()
    End Sub

    Private Sub Btn_Setting_Click(sender As Object, e As EventArgs) Handles Btn_Setting.Click
        Frm_Rate.ShowDialog()
    End Sub

    Private Sub Txt_Discount_Leave(sender As Object, e As EventArgs) Handles Txt_Discount.Leave
        Txt_Total.Text = Val(Txt_SubTotal.Text) - Val((Txt_SubTotal.Text) * (Txt_Discount.Text) / 100)

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Lb_Rate_Click(sender As Object, e As EventArgs) Handles Lb_Rate.Click

    End Sub

    Private Sub Panel_Content_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Content.Paint

    End Sub
End Class