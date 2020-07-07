<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Sales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel_Title = New System.Windows.Forms.Panel()
        Me.Btn_Restore = New FontAwesome.Sharp.IconButton()
        Me.Btn_Minimize = New FontAwesome.Sharp.IconButton()
        Me.Btn_Maximize = New FontAwesome.Sharp.IconButton()
        Me.Btn_Close = New FontAwesome.Sharp.IconButton()
        Me.Panel_Menu = New System.Windows.Forms.Panel()
        Me.Btn_New = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel_Footer = New System.Windows.Forms.Panel()
        Me.Panel_Item = New System.Windows.Forms.Panel()
        Me.Panel_Content = New System.Windows.Forms.Panel()
        Me.Lst_data = New System.Windows.Forms.ListView()
        Me.Panel_Title.SuspendLayout()
        Me.Panel_Menu.SuspendLayout()
        Me.Panel_Content.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.Color.Gray
        Me.Panel_Title.Controls.Add(Me.Btn_Restore)
        Me.Panel_Title.Controls.Add(Me.Btn_Minimize)
        Me.Panel_Title.Controls.Add(Me.Btn_Maximize)
        Me.Panel_Title.Controls.Add(Me.Btn_Close)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(1063, 35)
        Me.Panel_Title.TabIndex = 25
        '
        'Btn_Restore
        '
        Me.Btn_Restore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Restore.FlatAppearance.BorderSize = 0
        Me.Btn_Restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Restore.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Restore.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Restore.IconChar = FontAwesome.Sharp.IconChar.Bookmark
        Me.Btn_Restore.IconColor = System.Drawing.Color.White
        Me.Btn_Restore.IconSize = 22
        Me.Btn_Restore.Location = New System.Drawing.Point(974, 0)
        Me.Btn_Restore.Name = "Btn_Restore"
        Me.Btn_Restore.Rotation = 0R
        Me.Btn_Restore.Size = New System.Drawing.Size(40, 35)
        Me.Btn_Restore.TabIndex = 6
        Me.Btn_Restore.UseVisualStyleBackColor = True
        Me.Btn_Restore.Visible = False
        '
        'Btn_Minimize
        '
        Me.Btn_Minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Minimize.FlatAppearance.BorderSize = 0
        Me.Btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Minimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Minimize.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.Btn_Minimize.IconColor = System.Drawing.Color.White
        Me.Btn_Minimize.IconSize = 22
        Me.Btn_Minimize.Location = New System.Drawing.Point(928, 0)
        Me.Btn_Minimize.Name = "Btn_Minimize"
        Me.Btn_Minimize.Rotation = 0R
        Me.Btn_Minimize.Size = New System.Drawing.Size(40, 35)
        Me.Btn_Minimize.TabIndex = 5
        Me.Btn_Minimize.UseVisualStyleBackColor = True
        '
        'Btn_Maximize
        '
        Me.Btn_Maximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Maximize.FlatAppearance.BorderSize = 0
        Me.Btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Maximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Maximize.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.Btn_Maximize.IconColor = System.Drawing.Color.White
        Me.Btn_Maximize.IconSize = 22
        Me.Btn_Maximize.Location = New System.Drawing.Point(974, 0)
        Me.Btn_Maximize.Name = "Btn_Maximize"
        Me.Btn_Maximize.Rotation = 0R
        Me.Btn_Maximize.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Maximize.TabIndex = 4
        Me.Btn_Maximize.UseVisualStyleBackColor = True
        '
        'Btn_Close
        '
        Me.Btn_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Close.FlatAppearance.BorderSize = 0
        Me.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Close.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Close.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.Btn_Close.IconColor = System.Drawing.Color.White
        Me.Btn_Close.IconSize = 22
        Me.Btn_Close.Location = New System.Drawing.Point(1020, 0)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Rotation = 0R
        Me.Btn_Close.Size = New System.Drawing.Size(40, 35)
        Me.Btn_Close.TabIndex = 3
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'Panel_Menu
        '
        Me.Panel_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel_Menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Menu.Controls.Add(Me.Btn_New)
        Me.Panel_Menu.Controls.Add(Me.Button1)
        Me.Panel_Menu.Controls.Add(Me.IconButton1)
        Me.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Menu.Location = New System.Drawing.Point(0, 35)
        Me.Panel_Menu.Name = "Panel_Menu"
        Me.Panel_Menu.Size = New System.Drawing.Size(1063, 47)
        Me.Panel_Menu.TabIndex = 26
        '
        'Btn_New
        '
        Me.Btn_New.Location = New System.Drawing.Point(474, 4)
        Me.Btn_New.Name = "Btn_New"
        Me.Btn_New.Size = New System.Drawing.Size(75, 35)
        Me.Btn_New.TabIndex = 2
        Me.Btn_New.Text = "Button2"
        Me.Btn_New.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(205, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconSize = 16
        Me.IconButton1.Location = New System.Drawing.Point(337, 4)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(111, 36)
        Me.IconButton1.TabIndex = 0
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Panel_Footer
        '
        Me.Panel_Footer.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel_Footer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Footer.Location = New System.Drawing.Point(0, 451)
        Me.Panel_Footer.Name = "Panel_Footer"
        Me.Panel_Footer.Size = New System.Drawing.Size(1063, 135)
        Me.Panel_Footer.TabIndex = 27
        '
        'Panel_Item
        '
        Me.Panel_Item.AutoScroll = True
        Me.Panel_Item.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Item.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Item.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Item.Location = New System.Drawing.Point(0, 82)
        Me.Panel_Item.Name = "Panel_Item"
        Me.Panel_Item.Size = New System.Drawing.Size(450, 369)
        Me.Panel_Item.TabIndex = 28
        '
        'Panel_Content
        '
        Me.Panel_Content.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Content.Controls.Add(Me.Lst_data)
        Me.Panel_Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Content.Location = New System.Drawing.Point(450, 82)
        Me.Panel_Content.Name = "Panel_Content"
        Me.Panel_Content.Size = New System.Drawing.Size(613, 369)
        Me.Panel_Content.TabIndex = 29
        '
        'Lst_data
        '
        Me.Lst_data.GridLines = True
        Me.Lst_data.HideSelection = False
        Me.Lst_data.Location = New System.Drawing.Point(15, 5)
        Me.Lst_data.Name = "Lst_data"
        Me.Lst_data.Size = New System.Drawing.Size(591, 356)
        Me.Lst_data.TabIndex = 0
        Me.Lst_data.UseCompatibleStateImageBehavior = False
        Me.Lst_data.View = System.Windows.Forms.View.Details
        '
        'Frm_Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1063, 586)
        Me.Controls.Add(Me.Panel_Content)
        Me.Controls.Add(Me.Panel_Item)
        Me.Controls.Add(Me.Panel_Footer)
        Me.Controls.Add(Me.Panel_Menu)
        Me.Controls.Add(Me.Panel_Title)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "Frm_Sales"
        Me.Text = "Frm_Sales"
        Me.Panel_Title.ResumeLayout(False)
        Me.Panel_Menu.ResumeLayout(False)
        Me.Panel_Content.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Title As Panel
    Friend WithEvents Btn_Restore As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Maximize As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Close As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_Menu As Panel
    Friend WithEvents Panel_Footer As Panel
    Friend WithEvents Panel_Item As Panel
    Friend WithEvents Panel_Content As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Lst_data As ListView
    Friend WithEvents Btn_New As Button
End Class
