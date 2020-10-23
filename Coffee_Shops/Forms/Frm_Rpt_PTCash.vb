Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports Domain
Public Class Frm_Rpt_PTCash
    Private Sub Frm_Rpt_PTCash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim rpt As New CR_PTCash() 'The report you created.
            Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim cm As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New DataSet_Sale 'The DataSet you created.

            myConnection = New SqlConnection("Data Source=DESKTOP-SG2IIT1;Initial Catalog=Coffee_Shop;Persist Security Info=True;User ID=sa;Password=123")
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "SELECT * FROM  rpt_sales where date = cast(getdate() as date) And seller ='" & Frm_Sale_Temp.Lb_User.Text & "' "

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
            CrystalReportViewer1.ReportSource = rpt

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class