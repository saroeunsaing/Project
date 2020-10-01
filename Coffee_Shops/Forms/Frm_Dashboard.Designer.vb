<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Dashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Minimize = New FontAwesome.Sharp.IconButton()
        Me.Btn_Maximize = New FontAwesome.Sharp.IconButton()
        Me.Btn_Close = New FontAwesome.Sharp.IconButton()
        Me.Panel_Title = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Restore = New FontAwesome.Sharp.IconButton()
        Me.Label_Login = New System.Windows.Forms.Label()
        Me.Tm_MenuHide = New System.Windows.Forms.Timer(Me.components)
        Me.Tm_MenuShow = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Menu = New System.Windows.Forms.Panel()
        Me.Btn_Twitter = New FontAwesome.Sharp.IconButton()
        Me.Btn_Telegram = New FontAwesome.Sharp.IconButton()
        Me.Btn_Whatapp = New FontAwesome.Sharp.IconButton()
        Me.Btn_Youtube = New FontAwesome.Sharp.IconButton()
        Me.Btn_Facebook = New FontAwesome.Sharp.IconButton()
        Me.Pic_Logo = New System.Windows.Forms.PictureBox()
        Me.Btn_Home = New FontAwesome.Sharp.IconButton()
        Me.Btn_Setting = New FontAwesome.Sharp.IconButton()
        Me.Label_ShopName = New System.Windows.Forms.Label()
        Me.Btn_Logout = New FontAwesome.Sharp.IconButton()
        Me.Btn_About = New FontAwesome.Sharp.IconButton()
        Me.Btn_Payment_OutStanding = New FontAwesome.Sharp.IconButton()
        Me.Btn_Report = New FontAwesome.Sharp.IconButton()
        Me.Btn_Sales = New FontAwesome.Sharp.IconButton()
        Me.Btn_Stock = New FontAwesome.Sharp.IconButton()
        Me.Btn_Product = New FontAwesome.Sharp.IconButton()
        Me.Btn_Menu = New FontAwesome.Sharp.IconButton()
        Me.Panel_Content = New System.Windows.Forms.Panel()
        Me.Tm_Marquee = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel_Title.SuspendLayout()
        Me.Panel_Menu.SuspendLayout()
        CType(Me.Pic_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 670)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 30)
        Me.Panel1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(59, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1000, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " សូមស្វាកមន៍មកកាន់"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Btn_Close.Size = New System.Drawing.Size(40, 35)
        Me.Btn_Close.TabIndex = 3
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.Color.Gray
        Me.Panel_Title.Controls.Add(Me.IconButton1)
        Me.Panel_Title.Controls.Add(Me.Label2)
        Me.Panel_Title.Controls.Add(Me.Btn_Restore)
        Me.Panel_Title.Controls.Add(Me.Btn_Minimize)
        Me.Panel_Title.Controls.Add(Me.Btn_Maximize)
        Me.Panel_Title.Controls.Add(Me.Label_Login)
        Me.Panel_Title.Controls.Add(Me.Btn_Close)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(1100, 35)
        Me.Panel_Title.TabIndex = 21
        '
        'IconButton1
        '
        Me.IconButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!)
        Me.IconButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.IconButton1.IconColor = System.Drawing.Color.WhiteSmoke
        Me.IconButton1.IconSize = 30
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(6, 1)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(44, 36)
        Me.IconButton1.TabIndex = 42
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Siemreap", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(37, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 31)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "អ្នកប្រើប្រាស់ប្រព័ន្ធ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Btn_Restore.Size = New System.Drawing.Size(40, 35)
        Me.Btn_Restore.TabIndex = 6
        Me.Btn_Restore.UseVisualStyleBackColor = True
        Me.Btn_Restore.Visible = False
        '
        'Label_Login
        '
        Me.Label_Login.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Login.ForeColor = System.Drawing.Color.White
        Me.Label_Login.Location = New System.Drawing.Point(180, 1)
        Me.Label_Login.Name = "Label_Login"
        Me.Label_Login.Size = New System.Drawing.Size(147, 35)
        Me.Label_Login.TabIndex = 38
        Me.Label_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tm_MenuHide
        '
        '
        'Tm_MenuShow
        '
        '
        'Panel_Menu
        '
        Me.Panel_Menu.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel_Menu.Controls.Add(Me.Btn_Twitter)
        Me.Panel_Menu.Controls.Add(Me.Btn_Telegram)
        Me.Panel_Menu.Controls.Add(Me.Btn_Whatapp)
        Me.Panel_Menu.Controls.Add(Me.Btn_Youtube)
        Me.Panel_Menu.Controls.Add(Me.Btn_Facebook)
        Me.Panel_Menu.Controls.Add(Me.Pic_Logo)
        Me.Panel_Menu.Controls.Add(Me.Btn_Home)
        Me.Panel_Menu.Controls.Add(Me.Btn_Setting)
        Me.Panel_Menu.Controls.Add(Me.Label_ShopName)
        Me.Panel_Menu.Controls.Add(Me.Btn_Logout)
        Me.Panel_Menu.Controls.Add(Me.Btn_About)
        Me.Panel_Menu.Controls.Add(Me.Btn_Payment_OutStanding)
        Me.Panel_Menu.Controls.Add(Me.Btn_Report)
        Me.Panel_Menu.Controls.Add(Me.Btn_Sales)
        Me.Panel_Menu.Controls.Add(Me.Btn_Stock)
        Me.Panel_Menu.Controls.Add(Me.Btn_Product)
        Me.Panel_Menu.Controls.Add(Me.Btn_Menu)
        Me.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Menu.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_Menu.Location = New System.Drawing.Point(0, 35)
        Me.Panel_Menu.Name = "Panel_Menu"
        Me.Panel_Menu.Size = New System.Drawing.Size(200, 635)
        Me.Panel_Menu.TabIndex = 25
        '
        'Btn_Twitter
        '
        Me.Btn_Twitter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Twitter.FlatAppearance.BorderSize = 0
        Me.Btn_Twitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Twitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Twitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Twitter.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Twitter.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!)
        Me.Btn_Twitter.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Twitter.IconChar = FontAwesome.Sharp.IconChar.Twitter
        Me.Btn_Twitter.IconColor = System.Drawing.Color.PaleTurquoise
        Me.Btn_Twitter.IconSize = 30
        Me.Btn_Twitter.Location = New System.Drawing.Point(147, 602)
        Me.Btn_Twitter.Name = "Btn_Twitter"
        Me.Btn_Twitter.Rotation = 0R
        Me.Btn_Twitter.Size = New System.Drawing.Size(30, 30)
        Me.Btn_Twitter.TabIndex = 46
        Me.Btn_Twitter.UseVisualStyleBackColor = True
        '
        'Btn_Telegram
        '
        Me.Btn_Telegram.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Telegram.FlatAppearance.BorderSize = 0
        Me.Btn_Telegram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Telegram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Telegram.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Telegram.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Telegram.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!)
        Me.Btn_Telegram.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Telegram.IconChar = FontAwesome.Sharp.IconChar.Telegram
        Me.Btn_Telegram.IconColor = System.Drawing.Color.LightBlue
        Me.Btn_Telegram.IconSize = 30
        Me.Btn_Telegram.Location = New System.Drawing.Point(111, 602)
        Me.Btn_Telegram.Name = "Btn_Telegram"
        Me.Btn_Telegram.Rotation = 0R
        Me.Btn_Telegram.Size = New System.Drawing.Size(30, 30)
        Me.Btn_Telegram.TabIndex = 45
        Me.Btn_Telegram.UseVisualStyleBackColor = True
        '
        'Btn_Whatapp
        '
        Me.Btn_Whatapp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Whatapp.FlatAppearance.BorderSize = 0
        Me.Btn_Whatapp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Whatapp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Whatapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Whatapp.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Whatapp.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!)
        Me.Btn_Whatapp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Whatapp.IconChar = FontAwesome.Sharp.IconChar.Whatsapp
        Me.Btn_Whatapp.IconColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Whatapp.IconSize = 30
        Me.Btn_Whatapp.Location = New System.Drawing.Point(75, 602)
        Me.Btn_Whatapp.Name = "Btn_Whatapp"
        Me.Btn_Whatapp.Rotation = 0R
        Me.Btn_Whatapp.Size = New System.Drawing.Size(30, 30)
        Me.Btn_Whatapp.TabIndex = 44
        Me.Btn_Whatapp.UseVisualStyleBackColor = True
        '
        'Btn_Youtube
        '
        Me.Btn_Youtube.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Youtube.FlatAppearance.BorderSize = 0
        Me.Btn_Youtube.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Youtube.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Youtube.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Youtube.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Youtube.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!)
        Me.Btn_Youtube.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Youtube.IconChar = FontAwesome.Sharp.IconChar.Youtube
        Me.Btn_Youtube.IconColor = System.Drawing.Color.Red
        Me.Btn_Youtube.IconSize = 30
        Me.Btn_Youtube.Location = New System.Drawing.Point(39, 602)
        Me.Btn_Youtube.Name = "Btn_Youtube"
        Me.Btn_Youtube.Rotation = 0R
        Me.Btn_Youtube.Size = New System.Drawing.Size(30, 30)
        Me.Btn_Youtube.TabIndex = 43
        Me.Btn_Youtube.UseVisualStyleBackColor = True
        '
        'Btn_Facebook
        '
        Me.Btn_Facebook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Facebook.FlatAppearance.BorderSize = 0
        Me.Btn_Facebook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Facebook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Facebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Facebook.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Facebook.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!)
        Me.Btn_Facebook.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Facebook.IconChar = FontAwesome.Sharp.IconChar.Facebook
        Me.Btn_Facebook.IconColor = System.Drawing.Color.AliceBlue
        Me.Btn_Facebook.IconSize = 30
        Me.Btn_Facebook.Location = New System.Drawing.Point(3, 602)
        Me.Btn_Facebook.Name = "Btn_Facebook"
        Me.Btn_Facebook.Rotation = 0R
        Me.Btn_Facebook.Size = New System.Drawing.Size(30, 30)
        Me.Btn_Facebook.TabIndex = 42
        Me.Btn_Facebook.UseVisualStyleBackColor = True
        '
        'Pic_Logo
        '
        Me.Pic_Logo.Location = New System.Drawing.Point(55, 6)
        Me.Pic_Logo.Name = "Pic_Logo"
        Me.Pic_Logo.Size = New System.Drawing.Size(99, 92)
        Me.Pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Logo.TabIndex = 41
        Me.Pic_Logo.TabStop = False
        '
        'Btn_Home
        '
        Me.Btn_Home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Home.FlatAppearance.BorderSize = 0
        Me.Btn_Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Home.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Home.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Home.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Home.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.Btn_Home.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Home.IconSize = 35
        Me.Btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Home.Location = New System.Drawing.Point(-3, 145)
        Me.Btn_Home.Name = "Btn_Home"
        Me.Btn_Home.Rotation = 0R
        Me.Btn_Home.Size = New System.Drawing.Size(190, 35)
        Me.Btn_Home.TabIndex = 40
        Me.Btn_Home.Text = "ទំព័រដើម"
        Me.Btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Home.UseVisualStyleBackColor = True
        '
        'Btn_Setting
        '
        Me.Btn_Setting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Setting.FlatAppearance.BorderSize = 0
        Me.Btn_Setting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Setting.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Setting.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!)
        Me.Btn_Setting.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Setting.IconChar = FontAwesome.Sharp.IconChar.Cog
        Me.Btn_Setting.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Setting.IconSize = 35
        Me.Btn_Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Setting.Location = New System.Drawing.Point(-3, 432)
        Me.Btn_Setting.Name = "Btn_Setting"
        Me.Btn_Setting.Rotation = 0R
        Me.Btn_Setting.Size = New System.Drawing.Size(190, 35)
        Me.Btn_Setting.TabIndex = 39
        Me.Btn_Setting.Text = "Setting"
        Me.Btn_Setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Setting.UseVisualStyleBackColor = True
        '
        'Label_ShopName
        '
        Me.Label_ShopName.Font = New System.Drawing.Font("Khmer OS Siemreap", 10.25!)
        Me.Label_ShopName.ForeColor = System.Drawing.Color.White
        Me.Label_ShopName.Location = New System.Drawing.Point(15, 101)
        Me.Label_ShopName.Name = "Label_ShopName"
        Me.Label_ShopName.Size = New System.Drawing.Size(185, 31)
        Me.Label_ShopName.TabIndex = 37
        Me.Label_ShopName.Text = "ហាងកាហ្វេ Gurutech"
        Me.Label_ShopName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_Logout
        '
        Me.Btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Logout.FlatAppearance.BorderSize = 0
        Me.Btn_Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Logout.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Logout.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!)
        Me.Btn_Logout.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Logout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.Btn_Logout.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Logout.IconSize = 35
        Me.Btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Logout.Location = New System.Drawing.Point(0, 473)
        Me.Btn_Logout.Name = "Btn_Logout"
        Me.Btn_Logout.Rotation = 0R
        Me.Btn_Logout.Size = New System.Drawing.Size(197, 42)
        Me.Btn_Logout.TabIndex = 35
        Me.Btn_Logout.Text = "ចាកចេញ"
        Me.Btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Logout.UseVisualStyleBackColor = True
        '
        'Btn_About
        '
        Me.Btn_About.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_About.FlatAppearance.BorderSize = 0
        Me.Btn_About.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_About.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_About.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_About.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_About.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_About.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle
        Me.Btn_About.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_About.IconSize = 35
        Me.Btn_About.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_About.Location = New System.Drawing.Point(-3, 391)
        Me.Btn_About.Name = "Btn_About"
        Me.Btn_About.Rotation = 0R
        Me.Btn_About.Size = New System.Drawing.Size(190, 35)
        Me.Btn_About.TabIndex = 34
        Me.Btn_About.Text = "អំពីកម្មវិធី"
        Me.Btn_About.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_About.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_About.UseVisualStyleBackColor = True
        '
        'Btn_Payment_OutStanding
        '
        Me.Btn_Payment_OutStanding.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Payment_OutStanding.FlatAppearance.BorderSize = 0
        Me.Btn_Payment_OutStanding.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Payment_OutStanding.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Payment_OutStanding.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Payment_OutStanding.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Payment_OutStanding.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Payment_OutStanding.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Payment_OutStanding.IconChar = FontAwesome.Sharp.IconChar.CreditCard
        Me.Btn_Payment_OutStanding.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Payment_OutStanding.IconSize = 35
        Me.Btn_Payment_OutStanding.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Payment_OutStanding.Location = New System.Drawing.Point(-3, 309)
        Me.Btn_Payment_OutStanding.Name = "Btn_Payment_OutStanding"
        Me.Btn_Payment_OutStanding.Rotation = 0R
        Me.Btn_Payment_OutStanding.Size = New System.Drawing.Size(190, 35)
        Me.Btn_Payment_OutStanding.TabIndex = 33
        Me.Btn_Payment_OutStanding.Text = "ចំណូលចំណាយ"
        Me.Btn_Payment_OutStanding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Payment_OutStanding.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Payment_OutStanding.UseVisualStyleBackColor = True
        '
        'Btn_Report
        '
        Me.Btn_Report.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Report.FlatAppearance.BorderSize = 0
        Me.Btn_Report.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Report.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Report.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Report.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Report.IconChar = FontAwesome.Sharp.IconChar.ChartBar
        Me.Btn_Report.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Report.IconSize = 35
        Me.Btn_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Report.Location = New System.Drawing.Point(-3, 350)
        Me.Btn_Report.Name = "Btn_Report"
        Me.Btn_Report.Rotation = 0R
        Me.Btn_Report.Size = New System.Drawing.Size(190, 35)
        Me.Btn_Report.TabIndex = 31
        Me.Btn_Report.Text = "របាយការណ៍"
        Me.Btn_Report.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Report.UseVisualStyleBackColor = True
        '
        'Btn_Sales
        '
        Me.Btn_Sales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Sales.FlatAppearance.BorderSize = 0
        Me.Btn_Sales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Sales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Sales.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Sales.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Sales.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Sales.IconChar = FontAwesome.Sharp.IconChar.ProductHunt
        Me.Btn_Sales.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Sales.IconSize = 35
        Me.Btn_Sales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Sales.Location = New System.Drawing.Point(-3, 268)
        Me.Btn_Sales.Name = "Btn_Sales"
        Me.Btn_Sales.Rotation = 0R
        Me.Btn_Sales.Size = New System.Drawing.Size(190, 35)
        Me.Btn_Sales.TabIndex = 29
        Me.Btn_Sales.Text = "គ្រប់គ្រងការលក់"
        Me.Btn_Sales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Sales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Sales.UseVisualStyleBackColor = True
        '
        'Btn_Stock
        '
        Me.Btn_Stock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Stock.FlatAppearance.BorderSize = 0
        Me.Btn_Stock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Stock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Stock.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Stock.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Stock.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Stock.IconChar = FontAwesome.Sharp.IconChar.Industry
        Me.Btn_Stock.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Stock.IconSize = 35
        Me.Btn_Stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Stock.Location = New System.Drawing.Point(-3, 227)
        Me.Btn_Stock.Name = "Btn_Stock"
        Me.Btn_Stock.Rotation = 0R
        Me.Btn_Stock.Size = New System.Drawing.Size(190, 35)
        Me.Btn_Stock.TabIndex = 27
        Me.Btn_Stock.Text = "គ្រប់គ្រងស្ដុក"
        Me.Btn_Stock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Stock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Stock.UseVisualStyleBackColor = True
        '
        'Btn_Product
        '
        Me.Btn_Product.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_Product.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Product.FlatAppearance.BorderSize = 0
        Me.Btn_Product.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Product.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Product.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Product.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Product.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Product.IconChar = FontAwesome.Sharp.IconChar.StoreAlt
        Me.Btn_Product.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Product.IconSize = 35
        Me.Btn_Product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Product.Location = New System.Drawing.Point(-3, 186)
        Me.Btn_Product.Name = "Btn_Product"
        Me.Btn_Product.Rotation = 0R
        Me.Btn_Product.Size = New System.Drawing.Size(190, 35)
        Me.Btn_Product.TabIndex = 25
        Me.Btn_Product.Text = "គ្រប់គ្រងផលិតផល"
        Me.Btn_Product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Product.UseVisualStyleBackColor = False
        '
        'Btn_Menu
        '
        Me.Btn_Menu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Menu.FlatAppearance.BorderSize = 0
        Me.Btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Menu.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Menu.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Menu.IconChar = FontAwesome.Sharp.IconChar.List
        Me.Btn_Menu.IconColor = System.Drawing.Color.White
        Me.Btn_Menu.IconSize = 30
        Me.Btn_Menu.Location = New System.Drawing.Point(160, 0)
        Me.Btn_Menu.Name = "Btn_Menu"
        Me.Btn_Menu.Rotation = 0R
        Me.Btn_Menu.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Menu.TabIndex = 7
        Me.Btn_Menu.UseVisualStyleBackColor = True
        '
        'Panel_Content
        '
        Me.Panel_Content.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel_Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Content.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_Content.Location = New System.Drawing.Point(200, 35)
        Me.Panel_Content.Name = "Panel_Content"
        Me.Panel_Content.Size = New System.Drawing.Size(900, 635)
        Me.Panel_Content.TabIndex = 26
        '
        'Tm_Marquee
        '
        '
        'Frm_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Controls.Add(Me.Panel_Content)
        Me.Controls.Add(Me.Panel_Menu)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel_Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel_Title.ResumeLayout(False)
        Me.Panel_Menu.ResumeLayout(False)
        CType(Me.Pic_Logo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel_Menu As Panel
    Friend WithEvents Btn_Payment_OutStanding As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Report As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Sales As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Stock As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Product As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_Content As Panel
    Friend WithEvents Btn_Logout As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_About As FontAwesome.Sharp.IconButton
    Friend WithEvents Label_ShopName As Label
    Friend WithEvents Btn_Menu As FontAwesome.Sharp.IconButton
    Friend WithEvents Tm_Marquee As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Setting As FontAwesome.Sharp.IconButton
    Friend WithEvents Label_Login As Label
    Friend WithEvents Btn_Home As FontAwesome.Sharp.IconButton
    Friend WithEvents Pic_Logo As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Twitter As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Telegram As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Whatapp As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Youtube As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Facebook As FontAwesome.Sharp.IconButton
End Class
