Imports Domain
Public Class Frm_Payments
    Private sql As New sqlcontrol

    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            sql.ExecQuery("SELECT * FROM tbl_Sale  ")
        Else
            sql.ExecQuery(Query)
        End If

        ' ERROR HANDLING
        If sql.HasException(True) Then Exit Sub

        DGV_Data.DataSource = sql.dt

    End Sub
    Private Sub Frm_Payments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ckb_All.Checked = True
        LoadGrid()
    End Sub

    Private Sub Ckb_Dialy_CheckedChanged(sender As Object, e As EventArgs) Handles Ckb_Dialy.CheckedChanged
        Ckb_Between.Enabled = False
        Ckb_All.Enabled = False
        Ckb_Weekly.Enabled = False
        Ckb_Monthly.Enabled = False
        If Ckb_Dialy.Checked = False Then
            Ckb_Between.Enabled = True
            Ckb_All.Enabled = True
            Ckb_Weekly.Enabled = True
            Ckb_Monthly.Enabled = True
        End If
    End Sub

    Private Sub Ckb_All_CheckedChanged(sender As Object, e As EventArgs) Handles Ckb_All.CheckedChanged
        Ckb_Between.Enabled = False
        Ckb_Dialy.Enabled = False
        Ckb_Weekly.Enabled = False
        Ckb_Monthly.Enabled = False
        If Ckb_All.Checked = False Then
            Ckb_Between.Enabled = True
            Ckb_Dialy.Enabled = True
            Ckb_Weekly.Enabled = True
            Ckb_Monthly.Enabled = True
        End If
    End Sub

    Private Sub Ckb_Weekly_CheckedChanged(sender As Object, e As EventArgs) Handles Ckb_Weekly.CheckedChanged
        Ckb_Between.Enabled = False
        Ckb_All.Enabled = False
        Ckb_Dialy.Enabled = False
        Ckb_Monthly.Enabled = False
        If Ckb_Weekly.Checked = False Then
            Ckb_Between.Enabled = True
            Ckb_All.Enabled = True
            Ckb_Dialy.Enabled = True
            Ckb_Monthly.Enabled = True
        End If
    End Sub

    Private Sub Ckb_Monthly_CheckedChanged(sender As Object, e As EventArgs) Handles Ckb_Monthly.CheckedChanged
        Ckb_Between.Enabled = False
        Ckb_All.Enabled = False
        Ckb_Dialy.Enabled = False
        Ckb_Weekly.Enabled = False
        If Ckb_Monthly.Checked = False Then
            Ckb_Between.Enabled = True
            Ckb_All.Enabled = True
            Ckb_Dialy.Enabled = True
            Ckb_Weekly.Enabled = True
        End If
    End Sub

    Private Sub Ckb_Between_CheckedChanged(sender As Object, e As EventArgs) Handles Ckb_Between.CheckedChanged
        Ckb_Monthly.Enabled = False
        Ckb_All.Enabled = False
        Ckb_Dialy.Enabled = False
        Ckb_Weekly.Enabled = False
        If Ckb_Between.Checked = False Then
            Ckb_Monthly.Enabled = True
            Ckb_All.Enabled = True
            Ckb_Dialy.Enabled = True
            Ckb_Weekly.Enabled = True
        End If
    End Sub
End Class