Imports System.Runtime.InteropServices
Imports Domain


Public Class Frm_Login
    Dim sql As New SQLControl

#Region "Placehoder"
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal hWnd1 As IntPtr, ByVal hWnd2 As IntPtr, ByVal lpsz1 As String, ByVal lpsz2 As String) As IntPtr
    Private Const EM_SETCUEBANNER As Integer = &H1501
    Public Sub SetCueText(ByVal control As Control, ByVal text As String)
        If TypeOf control Is ComboBox Then
            Dim Edit_hWnd As IntPtr = FindWindowEx(control.Handle, IntPtr.Zero, "Edit", Nothing)
            If Not Edit_hWnd = IntPtr.Zero Then
                SendMessage(Edit_hWnd, EM_SETCUEBANNER, 0, text)
            End If
        ElseIf TypeOf control Is TextBox Then
            SendMessage(control.Handle, EM_SETCUEBANNER, 0, text)
        ElseIf TypeOf control Is RichTextBox Then
            SendMessage(control.Handle, EM_SETCUEBANNER, 0, text)
        End If
    End Sub
#End Region
    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        Dim userModel As New UserModel()
        Dim ValidLogin = userModel.Login(Txt_Username.Text, Txt_Password.Text)
        If ValidLogin = True Then
            Dim frm As New Frm_Dashboard
            frm.Show()
            Me.Hide()
        Else
            MessageBox.Show("គណនី ឬលេខសំងាត់មិនត្រឹមត្រូវ" + vbNewLine + "ព្យាយាម្ដងទៀត")
            Txt_Password.Clear()
            Txt_Password.Focus()

        End If
    End Sub

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Placeholder()
        sql.labelS(Label_ShopName, "select * from tbl_shop")
        sql.Image(Pic_Logo, "Select Logo from tbl_Shop")
        Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)

        SetCueText(Txt_Username, "គណនីប្រើប្រាស់ / USERNAME")
        SetCueText(Txt_Password, "លេខសម្ងាត់ / PASSWORD")

    End Sub


    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Btn_Setting_Click(sender As Object, e As EventArgs) Handles Btn_Setting.Click
        Me.Hide()
        Frm_Shop.Show()
    End Sub


End Class