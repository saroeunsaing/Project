<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel_Header = New System.Windows.Forms.Panel()
        Me.Panel_Content = New System.Windows.Forms.Panel()
        Me.Panel_Footer = New System.Windows.Forms.Panel()
        Me.Btn_Login = New FontAwesome.Sharp.IconButton()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.Txt_Username = New System.Windows.Forms.TextBox()
        Me.Txt_Password = New System.Windows.Forms.TextBox()
        Me.Panel_Content.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Header
        '
        Me.Panel_Header.BackColor = System.Drawing.Color.SlateGray
        Me.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Header.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(400, 32)
        Me.Panel_Header.TabIndex = 0
        '
        'Panel_Content
        '
        Me.Panel_Content.Controls.Add(Me.Txt_Password)
        Me.Panel_Content.Controls.Add(Me.Txt_Username)
        Me.Panel_Content.Controls.Add(Me.IconButton2)
        Me.Panel_Content.Controls.Add(Me.IconPictureBox1)
        Me.Panel_Content.Controls.Add(Me.Btn_Login)
        Me.Panel_Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Content.Location = New System.Drawing.Point(0, 32)
        Me.Panel_Content.Name = "Panel_Content"
        Me.Panel_Content.Size = New System.Drawing.Size(400, 433)
        Me.Panel_Content.TabIndex = 1
        '
        'Panel_Footer
        '
        Me.Panel_Footer.BackColor = System.Drawing.Color.Navy
        Me.Panel_Footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Footer.Location = New System.Drawing.Point(0, 439)
        Me.Panel_Footer.Name = "Panel_Footer"
        Me.Panel_Footer.Size = New System.Drawing.Size(400, 26)
        Me.Panel_Footer.TabIndex = 2
        '
        'Btn_Login
        '
        Me.Btn_Login.FlatAppearance.BorderSize = 0
        Me.Btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PapayaWhip
        Me.Btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite
        Me.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Login.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Login.IconChar = FontAwesome.Sharp.IconChar.SignInAlt
        Me.Btn_Login.IconColor = System.Drawing.Color.White
        Me.Btn_Login.IconSize = 30
        Me.Btn_Login.Location = New System.Drawing.Point(53, 308)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Rotation = 0R
        Me.Btn_Login.Size = New System.Drawing.Size(116, 42)
        Me.Btn_Login.TabIndex = 0
        Me.Btn_Login.Text = "ចូលប្រើ"
        Me.Btn_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Login.UseVisualStyleBackColor = True
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.DarkViolet
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconSize = 119
        Me.IconPictureBox1.Location = New System.Drawing.Point(117, 27)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(127, 119)
        Me.IconPictureBox1.TabIndex = 1
        Me.IconPictureBox1.TabStop = False
        '
        'IconButton2
        '
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PapayaWhip
        Me.IconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.SignInAlt
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconSize = 30
        Me.IconButton2.Location = New System.Drawing.Point(175, 308)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Rotation = 0R
        Me.IconButton2.Size = New System.Drawing.Size(116, 42)
        Me.IconButton2.TabIndex = 2
        Me.IconButton2.Text = "ចាកចេញ"
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'Txt_Username
        '
        Me.Txt_Username.Location = New System.Drawing.Point(83, 175)
        Me.Txt_Username.Name = "Txt_Username"
        Me.Txt_Username.Size = New System.Drawing.Size(222, 37)
        Me.Txt_Username.TabIndex = 3
        '
        'Txt_Password
        '
        Me.Txt_Password.Location = New System.Drawing.Point(83, 218)
        Me.Txt_Password.Name = "Txt_Password"
        Me.Txt_Password.Size = New System.Drawing.Size(222, 37)
        Me.Txt_Password.TabIndex = 4
        Me.Txt_Password.UseSystemPasswordChar = True
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(400, 465)
        Me.Controls.Add(Me.Panel_Footer)
        Me.Controls.Add(Me.Panel_Content)
        Me.Controls.Add(Me.Panel_Header)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "Frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Login"
        Me.Panel_Content.ResumeLayout(False)
        Me.Panel_Content.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Header As Panel
    Friend WithEvents Panel_Content As Panel
    Friend WithEvents Txt_Password As TextBox
    Friend WithEvents Txt_Username As TextBox
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Btn_Login As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_Footer As Panel
End Class
