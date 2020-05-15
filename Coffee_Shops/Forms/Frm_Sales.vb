Imports CrystalDecisions.CrystalReports.Engine

Public Class Frm_Sales
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub Frm_Sales_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim cryRpt As New CR_Sales

        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()
    End Sub
End Class