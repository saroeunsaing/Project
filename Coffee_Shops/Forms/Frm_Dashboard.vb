Imports System.Runtime.InteropServices
Imports Common
Imports Domain
Imports System.Data.SqlClient



Public Class Frm_Dashboard
    Dim FrmDesign As New FormsDesign()
    Dim SQLControl As New SQLControl

    'close buttong on responsive form
    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub
    'maximize buttong on responsive form
    Private Sub Btn_Maximize_Click(sender As Object, e As EventArgs) Handles Btn_Maximize.Click
        Btn_Restore.Visible = True
        Btn_Maximize.Visible = False

        Me.WindowState = FormWindowState.Maximized

    End Sub
    'minimize buttong on responsive form
    Private Sub Btn_Minimize_Click(sender As Object, e As EventArgs) Handles Btn_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'restore buttong on responsive form
    Private Sub Btn_Restore_Click(sender As Object, e As EventArgs) Handles Btn_Restore.Click
        Btn_Restore.Visible = False
        Btn_Maximize.Visible = True
        Me.WindowState = FormWindowState.Normal

    End Sub

    'timer for hide menu forms
    Private Sub Tm_MenuHide_Tick(sender As Object, e As EventArgs) Handles Tm_MenuHide.Tick
        If Panel_Menu.Width <= 40 Then
            Me.Tm_MenuHide.Enabled = False
        Else
            Me.Panel_Menu.Width = Panel_Menu.Width - 20

        End If
    End Sub
    'timer for show form
    Private Sub Tm_MenuShow_Tick(sender As Object, e As EventArgs) Handles Tm_MenuShow.Tick
        If Panel_Menu.Width >= 200 Then
            Me.Tm_MenuShow.Enabled = False
        Else
            Me.Panel_Menu.Width = Panel_Menu.Width + 20

        End If
    End Sub


    Private Sub Panel_Title_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_Title.MouseMove
        'call header form moving
        FrmDesign.ReleaseCapture()
        FrmDesign.SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    'sub make new sub form on dashboard
    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)
        If Me.Panel_Content.Controls.Count > 0 Then
            Me.Panel_Content.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.Panel_Content.Controls.Add(fh)
        Me.Panel_Content.Tag = fh
        fh.Show()

    End Sub


    Private Sub Btn_Menu_Click(sender As Object, e As EventArgs) Handles Btn_Menu.Click
        'hide and show navigation menu form
        If Panel_Menu.Width = 200 Then
            Tm_MenuHide.Enabled = True
        ElseIf Panel_Menu.Width = 40 Then
            Tm_MenuShow.Enabled = True

        End If
    End Sub

    'marquee text random
    Private Sub Tm_Marquee_Tick(sender As Object, e As EventArgs) Handles Tm_Marquee.Tick
        'Tm_Marquee.Interval = 500
        'Label1.Left = Label1.Left - 10
        'If Label1.Left < 0 - Label1.Width Then
        '    Label1.Left = Me.Width
        'End If


        Label1.Text = MaqueeText(Label1.Width)


    End Sub

    Private Sub Frm_Dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Tm_Marquee.Enabled = True
        Tm_Marquee.Start()
        managePermissions()
        loadUser()

        SQLControl.labelS(Label_ShopName, "select * from tbl_shop")
        SQLControl.Image(Pic_Logo, "Select Logo from tbl_Shop")
        security()

    End Sub
    'load user name put on label
    Sub loadUser()
        Label_Login.Text = ActiveUser.fullname
    End Sub
    'check security with existing login
    Private Sub security()
        Dim user As New UserModel()
        If ActiveUser.idUser = Nothing OrElse ActiveUser.idUser = 0 Then
            'codes
            MsgBox("សូមមេតាប្រើប្រាស់គណនីរបស់អ្នកដើម្បីដើំណើរការប្រព័ន្ធ", MessageBoxIcon.Information, "Error")

            Frm_Login.Show()
            Me.Hide()
        End If
    End Sub
    'check permission with usertype
    Private Sub managePermissions()
        If ActiveUser.position = Positions.receptionist Then
            Btn_Product.Enabled = False
            Btn_Payment_OutStanding.Enabled = False
            Btn_Stock.Enabled = False
            Btn_Product.Enabled = False
            Btn_Setting.Enabled = False


        End If
        If ActiveUser.position = Positions.accounting Then
            Btn_Product.Enabled = False
            Btn_Payment_OutStanding.Enabled = False
            Btn_Stock.Enabled = False
            Btn_Product.Enabled = False
            Btn_Setting.Enabled = False
        End If


    End Sub
    Private Function MaqueeText(ByVal data As String)
        Dim s1 As String = data.Remove(0, 1)
        Dim s2 As String = data(0)
        Return s1 & s2
    End Function
    Private Sub Txt_Login_Click(sender As Object, e As EventArgs) Handles Btn_Logout.Click

        If MessageBox.Show("តើអ្នកចង់ចាកចេញពី កម្មវិធី ឬ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Btn_Setting_Click(sender As Object, e As EventArgs) Handles Btn_Setting.Click
        AbrirFormEnPanel(New Frm_Users)
    End Sub
    Private Sub Btn_Stock_Click(sender As Object, e As EventArgs) Handles Btn_Stock.Click
        AbrirFormEnPanel(New Frm_Stocks)
    End Sub



    Private Sub Btn_Sales_Click(sender As Object, e As EventArgs) Handles Btn_Sales.Click
        Me.Hide()
        Frm_Sale_Temp.Show()
    End Sub




    Private Sub Btn_Home_Click(sender As Object, e As EventArgs) Handles Btn_Home.Click
        AbrirFormEnPanel(New Frm_Home)
    End Sub

    Private Sub Btn_Product_Click(sender As Object, e As EventArgs) Handles Btn_Product.Click
        AbrirFormEnPanel(New Frm_Products)
    End Sub

    Private Sub Btn_Payment_OutStanding_Click(sender As Object, e As EventArgs) Handles Btn_Payment_OutStanding.Click
        AbrirFormEnPanel(New Frm_Payments)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class