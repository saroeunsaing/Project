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
        Dim table As String = "rpt_sales"
        Dim qty As String = "SELECT * FROM rpt_sales where invoice_no ='" & Frm_Sale_Temp.Txt_Invoice.Text & "' "

        'call sub crystall report from class
        sql.Crst_Rpt(rpt, ds, qty, CRV_Sale, table)

    End Sub




End Class