Imports Domain
Public Class Frm_Scale
    Private sql As New SQLControl
    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            sql.ExecQuery("select id as [កូដ],nameKH  as [ចំណុះ],nameEn as [អក្សរកាត់] from tbl_Scale")
        Else
            sql.ExecQuery(Query)
        End If

        ' ERROR HANDLING
        If sql.HasException(True) Then Exit Sub

        DGV_Data.DataSource = sql.dt

    End Sub
    Private Sub Frm_Scale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click


        sql.AddParam("@namekh", Txt_NameKH.Text)
        sql.AddParam("@nameEn", Txt_NameEN.Text)

        sql.ExecQuery("INSERT INTO tbl_Scale (nameKh,nameEn) " &
                      "VALUES (@namekh,@nameEn);", True)


        ' REPORT & ABORT ON ERRORS
        If sql.HasException(True) Then Exit Sub

        'If SQL.dt.Rows.Count > 0 Then
        '    Dim r As DataRow = SQL.dt.Rows(0)
        '    MsgBox(r("LastID").ToString)
        'End If
        MsgBox("បន្ថែមថ្មីបានជោគជ័យ", MessageBoxIcon.Information, "បន្ថែមថ្មី")
        LoadGrid()
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        If MsgBox("តើអ្នកប្រាកដទេថាចង់លុបទិន្នន័យនេះ ! បើប្រាកដសូមមេត្តចុចបន្ដ ?", MsgBoxStyle.YesNo, "លុបទិនន្នន័យ?") = MsgBoxResult.Yes Then
            ' GENERATE A MASS DELETE COMMAND
            Dim DelString As String = "" ' query string builder
            sql.AddParam("@nameKh", Txt_NameKH.Text)
            DelString += "DELETE FROM tbl_scale WHERE nameKh=@nameKh ;"

            sql.ExecQuery(DelString)

            ' REPORT & ABORT ON ERRORS
            If sql.HasException(True) Then Exit Sub

            ' REPORT SUCCESS
            MsgBox("លុបបានជោគជ័យ!")
            LoadGrid()
            'autoid()
            ' REFRESH USER LIST
            '  FetchUsers()
        End If
    End Sub
End Class