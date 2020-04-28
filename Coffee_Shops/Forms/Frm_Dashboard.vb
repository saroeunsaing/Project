﻿Imports System.Runtime.InteropServices
Imports Common



Public Class Frm_Dashboard
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub


    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Btn_Maximize_Click(sender As Object, e As EventArgs) Handles Btn_Maximize.Click
        Btn_Restore.Visible = True
        Btn_Maximize.Visible = False

        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Btn_Minimize_Click(sender As Object, e As EventArgs) Handles Btn_Minimize.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Btn_Restore_Click(sender As Object, e As EventArgs) Handles Btn_Restore.Click
        Btn_Restore.Visible = False
        Btn_Maximize.Visible = True
        Me.WindowState = FormWindowState.Normal

    End Sub


    Private Sub Tm_MenuHide_Tick(sender As Object, e As EventArgs) Handles Tm_MenuHide.Tick
        If Panel_Menu.Width <= 40 Then
            Me.Tm_MenuHide.Enabled = False
        Else
            Me.Panel_Menu.Width = Panel_Menu.Width - 20

        End If
    End Sub

    Private Sub Tm_MenuShow_Tick(sender As Object, e As EventArgs) Handles Tm_MenuShow.Tick
        If Panel_Menu.Width >= 200 Then
            Me.Tm_MenuShow.Enabled = False
        Else
            Me.Panel_Menu.Width = Panel_Menu.Width + 20

        End If
    End Sub


    Private Sub Panel_Title_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_Title.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


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
        If Panel_Menu.Width = 200 Then
            Tm_MenuHide.Enabled = True
        ElseIf Panel_Menu.Width = 40 Then
            Tm_MenuShow.Enabled = True

        End If
    End Sub

    Private Sub Btn_Dashboard_Click_1(sender As Object, e As EventArgs) Handles Btn_Dashboard.Click
        AbrirFormEnPanel(New Frm_Products)
    End Sub

    Private Sub Tm_Marquee_Tick(sender As Object, e As EventArgs) Handles Tm_Marquee.Tick
        'Tm_Marquee.Interval = 500
        'Label1.Left = Label1.Left - 10
        'If Label1.Left < 0 - Label1.Width Then
        '    Label1.Left = Me.Width
        'End If

        Label1.Text = MaqueeText(Label1.Text)

    End Sub

    Private Sub Frm_Dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Tm_Marquee.Enabled = True
        Tm_Marquee.Start()
        Label_Login.Text = ActiveUser.fullname
    End Sub
    Private Function MaqueeText(ByVal data As String)

        Dim s1 As String = data.Remove(0, 1)
        Dim s2 As String = data(0)
        Return s1 & s2
    End Function
    Private Sub Txt_Login_Click(sender As Object, e As EventArgs) Handles Txt_Login.Click

        If MessageBox.Show("តើអ្នកចង់ចាកចេញពី កម្មវិធី ឬ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class