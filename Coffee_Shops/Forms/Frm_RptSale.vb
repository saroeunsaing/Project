Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports Domain
Imports DataAccess
Public Class Frm_RptSale
    Private sql As New SQLControl

    Private Sub CRV_Sale_Load(sender As Object, e As EventArgs) Handles CRV_Sale.Load

        Dim ds As New DataSet_Sale
        Dim rpt As New CR_Sales
        Dim table As String = "rpt_invoice"


        Dim qty As String = "SELECT * FROM rpt_sales where invoice_no ='" & Frm_Sale_Temp.Txt_Invoice.Text & "' "

        'call sub crystall report from class
        sql.Crst_Rpt(rpt, ds, qty, CRV_Sale, table)
        Dim table1 As String = "tbl_shop"

        Dim ds1 As New DataSet_Sale
        Dim rpt1 As New CR_Sales
        Dim qty1 As String = "SELECT * FROM tbl_shop"

        'call sub crystall report from class
        sql.Crst_Rpt(rpt1, ds1, qty1, CRV_Sale, table1)


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class