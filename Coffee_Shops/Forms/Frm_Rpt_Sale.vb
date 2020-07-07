Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Frm_Rpt_Sale
    Private Sub CRV_Sales_Load(sender As Object, e As EventArgs)
        Try

            Dim rpt As New CR_Sales 'The report you created.
            Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim cm As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New DataSet_Sale 'The DataSet you created.

            myConnection = New SqlConnection("Data Source=DESKTOP-SG2IIT1;Initial Catalog=Coffee_Shop;Persist Security Info=True;User ID=sa;Password=123")
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "SELECT * FROM  rpt_sales where invoice_no ='" & Frm_Sale_Temp.Txt_Invoice.Text & "' "


            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand

            myDA.Fill(myDS, "rpt_sales")
            'cm.Connection = myConnection
            'cm.CommandText = "SELECT * FROM  tbl_User Where Username = '" & Form_Sales.Label_Cashier.Text & "'"
            'cm.CommandType = CommandType.Text
            'myDA.SelectCommand = cm

            'myDA.Fill(myDS, "tbl_user")
            ''  myDA.Fill(myDS, "tbl_user")
            ' myDA.Fill(myDS, "tbl_Prosold")

            rpt.SetDataSource(myDS)
            CRV_Sales.ReportSource = rpt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class