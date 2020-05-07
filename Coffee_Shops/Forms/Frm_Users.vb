Imports Domain
Public Class Frm_Users
    Private SQL As New SQLControl
    Private FrmDesign As New FormsDesign()

    Private Sub Frm_Users_Load(sender As Object, e As EventArgs) Handles Me.Load
        Placeholder()
        LoadGrid()
        Dvg_Header()
        autoid()
    End Sub
    Sub autoid()
        ''  Txt_ID.Text = SQL.getMaxID("tbl_product", "product_id", "Cat-0000001", 5, 7)
        Txt_UserID.Text = SQL.getMaxID("tbl_product", "product_id", "U-000", 3, 4)
    End Sub
#Region "Save data in form"
    Private Sub InsertUser()
        ' ADD SQL PARAMS & RUN THE COMMAND

        SQL.AddParam("@id", Txt_UserID.Text)
        SQL.AddParam("@name", Txt_Fullname.Text)
        SQL.AddParam("@user", Txt_UserName.Text)
        SQL.AddParam("@pass", Txt_Password.Text)
        SQL.AddParam("@position", Cmb_Position.Text)

        SQL.ExecQuery("INSERT INTO tbl_User (user_id,fullname,username,password,usertype) " &
                      "VALUES (@id,@name,@user,@pass,@position);", True)

        ' REPORT & ABORT ON ERRORS
        If SQL.HasException(True) Then Exit Sub

        'If SQL.dt.Rows.Count > 0 Then
        '    Dim r As DataRow = SQL.dt.Rows(0)
        '    MsgBox(r("LastID").ToString)
        'End If

        MsgBox("គណនីប្រើប្រាស់បង្កើតបានជោគជ័យ")
    End Sub
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        InsertUser()
        ' CLEAR FIELDS
        Txt_Fullname.Clear()
        Txt_UserName.Clear()
        Txt_Password.Clear()
        Placeholder()
        Btn_Save.Enabled = False
        autoid()
    End Sub

#End Region
#Region "sub design in form"
    'block sub procedure
    Private Sub Panel_Title_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_Title.MouseMove
        'call header form moving
        FrmDesign.ReleaseCapture()
        FrmDesign.SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub Placeholder()
        SQL.SetCueText(Txt_UserName, "សូមបញ្ចូលគណនីប្រើប្រាស់")
        SQL.SetCueText(Txt_Password, "សូមបញ្ចូលលេខសម្គាល់")
        SQL.SetCueText(Txt_Fullname, "សូមបញ្ចូលគោត្តនាម នាម")
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
    'block button
    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Me.Close()
    End Sub
#End Region
#Region "Retreive Data in Form"
    Sub Dvg_Header()
        DGV_Data.Columns(0).HeaderText = "លេខសម្គាល់"
        DGV_Data.Columns(1).HeaderText = "គោត្តនាម​ នាម"
        DGV_Data.Columns(2).HeaderText = "គណនីប្រើប្រាស់"
        DGV_Data.Columns(3).HeaderText = "លេខសម្ងាត់"
        DGV_Data.Columns(4).HeaderText = "តួនាទី"
    End Sub
    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT user_id,fullname,username,password,usertype FROM tbl_User;")
        Else
            SQL.ExecQuery(Query)
        End If

        ' ERROR HANDLING
        If SQL.HasException(True) Then Exit Sub

        DGV_Data.DataSource = SQL.dt
    End Sub

    Private Sub LoadCBX(itm As ComboBox)
        ' REFRESH COMBOBOX
        itm.Items.Clear()

        ' RUN QUERY
        SQL.ExecQuery("SELECT usernme FROM members ORDER BY username ASC;")

        If SQL.HasException(True) Then Exit Sub

        ' LOOP ROW & ADD TO COMBOBOX
        For Each r As DataRow In SQL.dt.Rows
            itm.Items.Add(r("username").ToString)
        Next
    End Sub

    Private Sub FindItem()
        ' SQL.AddParam("@item", "%" & txtSearch.Text & "%")
        'LoadGrid("SELECT userid,username,password,usertype FROM tbluser WHERE PartNo LIKE @item;")
        LoadGrid("SELECT userid,username,password,usertype FROM tbluser WHERE PartNo LIKE @item;")
    End Sub

#End Region
#Region "update data in form "
    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        UpdateUser()
        autoid()
    End Sub

    'Private Sub FetchUsers()
    '    '' REFRESH USER LIST
    '    'lbUsers.Items.Clear()

    '    '' ADD PARAMS & RUN QUERY
    '    'SQL.AddParam("@users", "%" & txtFilter.Text & "%")
    '    'SQL.ExecQuery("SELECT username " &
    '    '              "FROM members " &
    '    '              "WHERE username LIKE @users " &
    '    '              "ORDER BY username ASC;")

    '    '' REPORT & ABORT ON ERRORS
    '    'If SQL.HasException(True) Then Exit Sub

    '    '' LOOP ROWS & RETURN USERS TO LIST
    '    'For Each r As DataRow In SQL.DBDT.Rows
    '    '    lbUsers.Items.Add(r("username"))
    '    'Next
    'End Sub
    'Private Sub GetDvg()
    '    SQL.ExecQuery("SELECT TOP 1 * " &
    '                  "FROM tbl_User " &
    '                  "WHERE username = @user;")

    '    If SQL.RecordCount < 1 Then Exit Sub

    'End Sub
    'Private Sub GetUserDetails(Username As String)
    '    'SQL.AddParam("@user", Username)
    '    'SQL.ExecQuery("SELECT TOP 1 * " &
    '    '              "FROM tbl_User " &
    '    '              "WHERE username = @user;")

    '    'If SQL.RecordCount < 1 Then Exit Sub

    '    'For Each r As DataRow In SQL.dt.Rows
    '    '    txtID.Text = r("ID")
    '    '    txtUser.Text = r("username")
    '    '    txtPass.Text = r("password")
    '    '    cbActive.Checked = r("active")
    '    '    cbAdmin.Checked = r("admin")
    '    'Next
    'End Sub
    Private Sub UpdateUser()
        SQL.AddParam("@pass", Txt_Password.Text)
        SQL.AddParam("@name", Txt_Fullname.Text)
        SQL.AddParam("@type", Cmb_Position.Text)
        SQL.AddParam("@id", Txt_UserID.Text)

        SQL.ExecQuery("UPDATE tbl_user " &
                      "SET fullname=@name,​​password=@pass,  usertype=@type " &
                      "WHERE user_id=@id;")

        If SQL.HasException(True) Then Exit Sub

        MsgBox("ទិន្នន័យកែប្រែបានជោគជ័យ.")
        Btn_Save.Enabled = False
    End Sub
    Private Sub DGV_Data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Data.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow

            row = Me.DGV_Data.Rows(e.RowIndex)
            Txt_UserID.Text = row.Cells("user_id").Value.ToString
            Txt_Fullname.Text = row.Cells("fullname").Value.ToString
            Txt_UserName.Text = row.Cells("username").Value.ToString
            Txt_Password.Text = row.Cells("password").Value.ToString
            Cmb_Position.Text = row.Cells("usertype").Value.ToString
        End If
    End Sub

#End Region
#Region "delete data in form"
    Private Sub DeleteUsers()
        If MsgBox("The selected users will be deleted! Are you sure you wish to continue?", MsgBoxStyle.YesNo, "Delete User?") = MsgBoxResult.Yes Then
            ' GENERATE A MASS DELETE COMMAND


            Dim DelString As String = "" ' query string builder


            SQL.AddParam("@user", Txt_UserName.Text)
            DelString += "DELETE FROM tbl_user WHERE username=@user ;"


            SQL.ExecQuery(DelString)

            ' REPORT & ABORT ON ERRORS
            If SQL.HasException(True) Then Exit Sub

            ' REPORT SUCCESS
            MsgBox("The selected users have been deleted successfully.")

            ' REFRESH USER LIST
            '  FetchUsers()
        End If
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        DeleteUsers()
        autoid()
    End Sub

#End Region
End Class
