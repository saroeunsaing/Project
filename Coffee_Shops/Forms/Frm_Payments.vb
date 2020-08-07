Imports Domain
Public Class Frm_Payments
    Private sql As New SQLControl

    Sub headdvg()
        DGV_Data.Columns(0).HeaderText = "កាលបរិច្ចេទ"
        DGV_Data.Columns(1).HeaderText = "រាយនាមទំនិញ"
        DGV_Data.Columns(2).HeaderText = "ចំនួន"
        DGV_Data.Columns(3).HeaderText = "សរុប"
        DGV_Data.ColumnHeadersDefaultCellStyle.Font = New Font("Khmer OS Siemreap", 10.0F, FontStyle.Bold)
    End Sub
#Region "Retreive Data in Form"
    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            sql.ExecQuery("SELECT * FROM rpt_Revenue ")
        Else
            sql.ExecQuery(Query)
        End If

        ' ERROR HANDLING
        If sql.HasException(True) Then Exit Sub

        DGV_Data.DataSource = sql.dt

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
        sql.ExecQuery(table)

        If sql.HasException(True) Then Exit Sub

        ' LOOP ROW & ADD TO COMBOBOX
        For Each r As DataRow In sql.dt.Rows
            itm.Items.Add(r(index).ToString)
        Next
    End Sub
#End Region
    Private Sub Frm_Payments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ckb_All.Checked = True

        LoadGrid()
        headdvg()
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

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub
End Class