Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports Domain

Public Class Frm_Rpt_Sale
    Private sql As New SQLControl


    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Hide()
        Frm_Sale_Temp.Show()
    End Sub

    Private Sub Frm_Rpt_Sale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim ds As New DataSet_Sale
        'Dim rpt As New CR_Invoice
        'Dim table As String = "tbl_shop"


        'Dim qty As String = "SELECT * FROM tbl_shop"

        ''call sub crystall report from class
        'sql.Crst_Rpt(rpt, ds, qty, CRV_PTCash, table)



        'Dim table1 As String = "rpt_invoice"


        'Dim qty1 As String = "SELECT * FROM rpt_sales where rpt_sales.invoice_no ='CIEDI-0000000003' "

        ''call sub crystall report from class
        'sql.Crst_Rpt(rpt, ds, qty1, CRV_PTCash, table1)


        Try

            Dim rpt As New CR_Invoice() 'The report you created.
            Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim cm As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New DataSet_Sale 'The DataSet you created.

            myConnection = New SqlConnection("Data Source=DESKTOP-SG2IIT1;Initial Catalog=Coffee_Shop;Persist Security Info=True;User ID=sa;Password=123")
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "SELECT * FROM  rpt_sales WHERE rpt_sales.invoice_no = '" & Frm_Sale_Temp.Txt_Invoice.Text & "'"


            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand

            myDA.Fill(myDS, "rpt_sales")
            cm.Connection = myConnection
            cm.CommandText = "SELECT * FROM  tbl_shop"
            cm.CommandType = CommandType.Text
            myDA.SelectCommand = cm

            myDA.Fill(myDS, "tbl_shop")
            '  myDA.Fill(myDS, "tbl_user")
            ' myDA.Fill(myDS, "tbl_Prosold")

            rpt.SetDataSource(myDS)
            CRV_PTCash.ReportSource = rpt

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class