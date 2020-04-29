Imports Domain
Public Class Frm_Users
    Private SQL As New SQLControl

    Private Sub InsertUser()
        ' ADD SQL PARAMS & RUN THE COMMAND

        SQL.AddParam("@id", Txt_UserID.Text)
        SQL.AddParam("@name", Txt_Fullname.Text)
        SQL.AddParam("@user", Txt_UserName.Text)
        SQL.AddParam("@pass", Txt_Password.Text)
        SQL.AddParam("@position", Cmb_Position.Text)

        SQL.ExecQuery("INSERT INTO tbl_User (userid,fullname,username,password,usertype) " &
                      "VALUES (@id,@name,@user,@pass,@position);", True)

        ' REPORT & ABORT ON ERRORS
        If SQL.HasException(True) Then Exit Sub

        'If SQL.dt.Rows.Count > 0 Then
        '    Dim r As DataRow = SQL.dt.Rows(0)
        '    MsgBox(r("LastID").ToString)
        'End If

        MsgBox("User created successfully!")
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        InsertUser()

        ' CLEAR FIELDS
        Txt_Fullname.Clear()
        Txt_UserName.Clear()
        Txt_Password.Clear()
        SQL.SetCueText(Txt_UserName, "បញ្ចូលគណនីប្រើប្រាស់")
        SQL.SetCueText(Txt_Password, "បញ្ចូលលេខសម្គាល់")
        Btn_Save.Enabled = False
    End Sub

    Private Sub txtFields_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_UserName.TextChanged, Txt_Password.TextChanged
        ' BASIC VALIDATION
        If Not String.IsNullOrWhiteSpace(Txt_UserName.Text) AndAlso Not String.IsNullOrWhiteSpace(Txt_Password.Text) Then
            Btn_Save.Enabled = True
        Else
            Btn_Save.Enabled = False
            Placeholder()
        End If
    End Sub

    Private Sub Frm_Users_Load(sender As Object, e As EventArgs) Handles Me.Load
        Placeholder()
    End Sub
    Private Sub Placeholder()
        SQL.SetCueText(Txt_UserName, "សូមបញ្ចូលគណនីប្រើប្រាស់")
        SQL.SetCueText(Txt_Password, "សូមបញ្ចូលលេខសម្គាល់")
        SQL.SetCueText(Txt_Fullname, "សូមបញ្ចូលគោត្តនាម នាម")
    End Sub
End Class