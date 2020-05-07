﻿Imports Domain
Public Class Frms_Material
    Private SQL As New SQLControl

    Public str As String
    Private Sub Frms_Material_Load(sender As Object, e As EventArgs) Handles Me.Load
        str = SQL.getMaxID("tbl_material", "material_id", "M-000", 3, 4)
    End Sub
    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub
#Region "Save data in form"
    Private Sub Insert()
        ' ADD SQL PARAMS & RUN THE COMMAND

        SQL.AddParam("@id", str)
        SQL.AddParam("@nameKH", Txt_TitleKh.Text)
        Sql.AddParam("@nameEN", Txt_TitleEN.Text)

        SQL.ExecQuery("INSERT INTO tbl_Material (material_id,nameKH,nameEN) " &
                      "VALUES (@id,@namekh,@nameen);", True)

        ' REPORT & ABORT ON ERRORS
        If Sql.HasException(True) Then Exit Sub

        'If SQL.dt.Rows.Count > 0 Then
        '    Dim r As DataRow = SQL.dt.Rows(0)
        '    MsgBox(r("LastID").ToString)
        'End If

        MsgBox("បង្កើតបានជោគជ័យ")

    End Sub
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Insert()
    End Sub
#End Region
#Region "delete data in form"
    Private Sub Delete()
        If MsgBox("តើអ្នកប្រកដថាចង់លុបទិន្នន័យនេះឬ ! បើអ្នកប្រាកដសូមមេត្តចុចបន្ដ?", MsgBoxStyle.YesNo, "Delete User?") = MsgBoxResult.Yes Then
            ' GENERATE A MASS DELETE COMMAND

            Dim DelString As String = "" ' query string builder

            SQL.AddParam("@name", Txt_TitleKh.Text)
            DelString += "DELETE FROM tbl_user WHERE namekh=@name ;"

            SQL.ExecQuery(DelString)

            ' REPORT & ABORT ON ERRORS
            If SQL.HasException(True) Then Exit Sub

            ' REPORT SUCCESS
            MsgBox("លុបទិន្នន័យបានជោគជ័យ")

            ' REFRESH USER LIST
            '  FetchUsers()
        End If
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        Delete()
    End Sub

#End Region






End Class