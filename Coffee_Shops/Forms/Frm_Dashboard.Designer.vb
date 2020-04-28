<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Minimize = New FontAwesome.Sharp.IconButton()
        Me.Btn_Maximize = New FontAwesome.Sharp.IconButton()
        Me.Btn_Close = New FontAwesome.Sharp.IconButton()
        Me.Panel_Title = New System.Windows.Forms.Panel()
        Me.Btn_Restore = New FontAwesome.Sharp.IconButton()
        Me.Tm_MenuHide = New System.Windows.Forms.Timer(Me.components)
        Me.Tm_MenuShow = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Content = New System.Windows.Forms.Panel()
        Me.Panel_Menu = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Btn_About_Us = New FontAwesome.Sharp.IconButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Btn_Payment = New FontAwesome.Sharp.IconButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Btn_Sales = New FontAwesome.Sharp.IconButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Btn_Stock = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_Dashboard = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_Menu = New FontAwesome.Sharp.IconButton()
        Me.Panel_Title.SuspendLayout()
        Me.Panel_Content.SuspendLayout()
        Me.Panel_Menu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 539)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 41)
        Me.Panel1.TabIndex = 22
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
        Me.Btn_Minimize.Location = New System.Drawing.Point(965, 0)
        Me.Btn_Minimize.Name = "Btn_Minimize"
        Me.Btn_Minimize.Rotation = 0R
        Me.Btn_Minimize.Size = New System.Drawing.Size(40, 40)
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
        Me.Btn_Maximize.Location = New System.Drawing.Point(1011, 0)
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
        Me.Btn_Close.Location = New System.Drawing.Point(1057, 0)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Rotation = 0R
        Me.Btn_Close.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Close.TabIndex = 3
        Me.Btn_Close.UseVisualStyleBackColor = True
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
        Me.Panel_Title.Size = New System.Drawing.Size(1100, 40)
        Me.Panel_Title.TabIndex = 21
        '
        'Btn_Restore
        '
        Me.Btn_Restore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Restore.FlatAppearance.BorderSize = 0
        Me.Btn_Restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Restore.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Restore.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Restore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        Me.Btn_Restore.IconColor = System.Drawing.Color.White
        Me.Btn_Restore.IconSize = 22
        Me.Btn_Restore.Location = New System.Drawing.Point(1011, 0)
        Me.Btn_Restore.Name = "Btn_Restore"
        Me.Btn_Restore.Rotation = 0R
        Me.Btn_Restore.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Restore.TabIndex = 6
        Me.Btn_Restore.UseVisualStyleBackColor = True
        Me.Btn_Restore.Visible = False
        '
        'Tm_MenuHide
        '
        '
        'Tm_MenuShow
        '
        '
        'Panel_Content
        '
        Me.Panel_Content.Controls.Add(Me.Panel_Menu)
        Me.Panel_Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Content.Location = New System.Drawing.Point(0, 40)
        Me.Panel_Content.Name = "Panel_Content"
        Me.Panel_Content.Size = New System.Drawing.Size(1100, 499)
        Me.Panel_Content.TabIndex = 24
        '
        'Panel_Menu
        '
        Me.Panel_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel_Menu.Controls.Add(Me.Panel6)
        Me.Panel_Menu.Controls.Add(Me.Btn_About_Us)
        Me.Panel_Menu.Controls.Add(Me.Panel5)
        Me.Panel_Menu.Controls.Add(Me.Btn_Payment)
        Me.Panel_Menu.Controls.Add(Me.Panel4)
        Me.Panel_Menu.Controls.Add(Me.Btn_Sales)
        Me.Panel_Menu.Controls.Add(Me.Panel3)
        Me.Panel_Menu.Controls.Add(Me.Btn_Stock)
        Me.Panel_Menu.Controls.Add(Me.Panel2)
        Me.Panel_Menu.Controls.Add(Me.Btn_Dashboard)
        Me.Panel_Menu.Controls.Add(Me.PictureBox1)
        Me.Panel_Menu.Controls.Add(Me.Btn_Menu)
        Me.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Menu.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Menu.Name = "Panel_Menu"
        Me.Panel_Menu.Size = New System.Drawing.Size(200, 499)
        Me.Panel_Menu.TabIndex = 24
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(0, 352)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 50)
        Me.Panel6.TabIndex = 32
        '
        'Btn_About_Us
        '
        Me.Btn_About_Us.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_About_Us.FlatAppearance.BorderSize = 0
        Me.Btn_About_Us.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_About_Us.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_About_Us.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_About_Us.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_About_Us.Font = New System.Drawing.Font("Khmer OS Siemreap", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_About_Us.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.Btn_About_Us.IconColor = System.Drawing.Color.Black
        Me.Btn_About_Us.IconSize = 35
        Me.Btn_About_Us.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_About_Us.Location = New System.Drawing.Point(0, 352)
        Me.Btn_About_Us.Name = "Btn_About_Us"
        Me.Btn_About_Us.Rotation = 0R
        Me.Btn_About_Us.Size = New System.Drawing.Size(197, 50)
        Me.Btn_About_Us.TabIndex = 33
        Me.Btn_About_Us.Text = "អំពីកម្មវិធី"
        Me.Btn_About_Us.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_About_Us.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_About_Us.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(0, 296)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 50)
        Me.Panel5.TabIndex = 30
        '
        'Btn_Payment
        '
        Me.Btn_Payment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Payment.FlatAppearance.BorderSize = 0
        Me.Btn_Payment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Payment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Payment.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Payment.Font = New System.Drawing.Font("Khmer OS Siemreap", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Payment.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.Btn_Payment.IconColor = System.Drawing.Color.Black
        Me.Btn_Payment.IconSize = 35
        Me.Btn_Payment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Payment.Location = New System.Drawing.Point(0, 296)
        Me.Btn_Payment.Name = "Btn_Payment"
        Me.Btn_Payment.Rotation = 0R
        Me.Btn_Payment.Size = New System.Drawing.Size(197, 50)
        Me.Btn_Payment.TabIndex = 31
        Me.Btn_Payment.Text = "ចំណូលចំណាយ"
        Me.Btn_Payment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Payment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Payment.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 240)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 50)
        Me.Panel4.TabIndex = 28
        '
        'Btn_Sales
        '
        Me.Btn_Sales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Sales.FlatAppearance.BorderSize = 0
        Me.Btn_Sales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Sales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Sales.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Sales.Font = New System.Drawing.Font("Khmer OS Siemreap", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Sales.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.Btn_Sales.IconColor = System.Drawing.Color.Black
        Me.Btn_Sales.IconSize = 35
        Me.Btn_Sales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Sales.Location = New System.Drawing.Point(0, 240)
        Me.Btn_Sales.Name = "Btn_Sales"
        Me.Btn_Sales.Rotation = 0R
        Me.Btn_Sales.Size = New System.Drawing.Size(197, 50)
        Me.Btn_Sales.TabIndex = 29
        Me.Btn_Sales.Text = "គ្រប់គ្រងការលក់"
        Me.Btn_Sales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Sales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Sales.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 184)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 50)
        Me.Panel3.TabIndex = 26
        '
        'Btn_Stock
        '
        Me.Btn_Stock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Stock.FlatAppearance.BorderSize = 0
        Me.Btn_Stock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Stock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Stock.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Stock.Font = New System.Drawing.Font("Khmer OS Siemreap", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Stock.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.Btn_Stock.IconColor = System.Drawing.Color.Black
        Me.Btn_Stock.IconSize = 35
        Me.Btn_Stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Stock.Location = New System.Drawing.Point(0, 184)
        Me.Btn_Stock.Name = "Btn_Stock"
        Me.Btn_Stock.Rotation = 0R
        Me.Btn_Stock.Size = New System.Drawing.Size(197, 50)
        Me.Btn_Stock.TabIndex = 27
        Me.Btn_Stock.Text = "គ្រប់គ្រងស្ដុក"
        Me.Btn_Stock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Stock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Stock.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 128)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 50)
        Me.Panel2.TabIndex = 24
        '
        'Btn_Dashboard
        '
        Me.Btn_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Dashboard.FlatAppearance.BorderSize = 0
        Me.Btn_Dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Dashboard.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Dashboard.Font = New System.Drawing.Font("Khmer OS Siemreap", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Dashboard.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.Btn_Dashboard.IconColor = System.Drawing.Color.Black
        Me.Btn_Dashboard.IconSize = 35
        Me.Btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Dashboard.Location = New System.Drawing.Point(0, 128)
        Me.Btn_Dashboard.Name = "Btn_Dashboard"
        Me.Btn_Dashboard.Rotation = 0R
        Me.Btn_Dashboard.Size = New System.Drawing.Size(197, 50)
        Me.Btn_Dashboard.TabIndex = 25
        Me.Btn_Dashboard.Text = "ទំព័រដើម"
        Me.Btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Dashboard.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Coffee_Shops.My.Resources.Resources.ស្លឹករឹត1
        Me.PictureBox1.Location = New System.Drawing.Point(3, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Btn_Menu
        '
        Me.Btn_Menu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Menu.FlatAppearance.BorderSize = 0
        Me.Btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Menu.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Menu.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Menu.IconChar = FontAwesome.Sharp.IconChar.List
        Me.Btn_Menu.IconColor = System.Drawing.Color.Gray
        Me.Btn_Menu.IconSize = 30
        Me.Btn_Menu.Location = New System.Drawing.Point(160, 0)
        Me.Btn_Menu.Name = "Btn_Menu"
        Me.Btn_Menu.Rotation = 0R
        Me.Btn_Menu.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Menu.TabIndex = 7
        Me.Btn_Menu.UseVisualStyleBackColor = True
        '
        'Frm_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 580)
        Me.Controls.Add(Me.Panel_Content)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel_Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Dashboard"
        Me.Panel_Title.ResumeLayout(False)
        Me.Panel_Content.ResumeLayout(False)
        Me.Panel_Menu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Maximize As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Close As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_Title As Panel
    Friend WithEvents Btn_Restore As FontAwesome.Sharp.IconButton
    Friend WithEvents Tm_MenuHide As Timer
    Friend WithEvents Tm_MenuShow As Timer
    Friend WithEvents Panel_Content As Panel
    Friend WithEvents Panel_Menu As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Btn_About_Us As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Btn_Payment As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Btn_Sales As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Btn_Stock As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Btn_Dashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_Menu As FontAwesome.Sharp.IconButton
End Class
