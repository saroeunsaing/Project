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
        Me.Btn_Restore = New FontAwesome.Sharp.IconButton()
        Me.Tm_MenuHide = New System.Windows.Forms.Timer(Me.components)
        Me.Tm_MenuShow = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Menu = New System.Windows.Forms.Panel()
        Me.Btn_Setting = New FontAwesome.Sharp.IconButton()
        Me.Label_Login = New System.Windows.Forms.Label()
        Me.Label_ShopName = New System.Windows.Forms.Label()
        Me.Img_Logo = New FontAwesome.Sharp.IconPictureBox()
        Me.Txt_Login = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Btn_About_Us = New FontAwesome.Sharp.IconButton()
        Me.Btn_Payment = New FontAwesome.Sharp.IconButton()
        Me.Btn_Sales = New FontAwesome.Sharp.IconButton()
        Me.Btn_Stock = New FontAwesome.Sharp.IconButton()
        Me.Btn_Dashboard = New FontAwesome.Sharp.IconButton()
        Me.Btn_Menu = New FontAwesome.Sharp.IconButton()
        Me.Panel_Content = New System.Windows.Forms.Panel()
        Me.Tm_Marquee = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel_Title.SuspendLayout()
        Me.Panel_Menu.SuspendLayout()
        CType(Me.Img_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1190, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
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
        Me.Panel_Title.Controls.Add(Me.Btn_Restore)
        Me.Panel_Title.Controls.Add(Me.Btn_Minimize)
        Me.Panel_Title.Controls.Add(Me.Btn_Maximize)
        Me.Panel_Title.Controls.Add(Me.Btn_Close)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(1100, 35)
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
        Me.Btn_Restore.Size = New System.Drawing.Size(40, 35)
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
        'Panel_Menu
        '
        Me.Panel_Menu.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel_Menu.Controls.Add(Me.Btn_Setting)
        Me.Panel_Menu.Controls.Add(Me.Label_Login)
        Me.Panel_Menu.Controls.Add(Me.Label_ShopName)
        Me.Panel_Menu.Controls.Add(Me.Img_Logo)
        Me.Panel_Menu.Controls.Add(Me.Txt_Login)
        Me.Panel_Menu.Controls.Add(Me.IconButton1)
        Me.Panel_Menu.Controls.Add(Me.Btn_About_Us)
        Me.Panel_Menu.Controls.Add(Me.Btn_Payment)
        Me.Panel_Menu.Controls.Add(Me.Btn_Sales)
        Me.Panel_Menu.Controls.Add(Me.Btn_Stock)
        Me.Panel_Menu.Controls.Add(Me.Btn_Dashboard)
        Me.Panel_Menu.Controls.Add(Me.Btn_Menu)
        Me.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Menu.Location = New System.Drawing.Point(0, 35)
        Me.Panel_Menu.Name = "Panel_Menu"
        Me.Panel_Menu.Size = New System.Drawing.Size(200, 635)
        Me.Panel_Menu.TabIndex = 25
        '
        'Btn_Setting
        '
        Me.Btn_Setting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Setting.FlatAppearance.BorderSize = 0
        Me.Btn_Setting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Setting.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Setting.Font = New System.Drawing.Font("NiDA Bayon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Setting.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Setting.IconChar = FontAwesome.Sharp.IconChar.Cog
        Me.Btn_Setting.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Setting.IconSize = 35
        Me.Btn_Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Setting.Location = New System.Drawing.Point(0, 462)
        Me.Btn_Setting.Name = "Btn_Setting"
        Me.Btn_Setting.Rotation = 0R
        Me.Btn_Setting.Size = New System.Drawing.Size(197, 50)
        Me.Btn_Setting.TabIndex = 39
        Me.Btn_Setting.Text = "Setting"
        Me.Btn_Setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Setting.UseVisualStyleBackColor = True
        '
        'Label_Login
        '
        Me.Label_Login.Font = New System.Drawing.Font("Khmer OS Muol Light", 8.0!)
        Me.Label_Login.ForeColor = System.Drawing.Color.White
        Me.Label_Login.Location = New System.Drawing.Point(12, 515)
        Me.Label_Login.Name = "Label_Login"
        Me.Label_Login.Size = New System.Drawing.Size(147, 40)
        Me.Label_Login.TabIndex = 38
        '
        'Label_ShopName
        '
        Me.Label_ShopName.Font = New System.Drawing.Font("NiDA Bayon", 10.25!)
        Me.Label_ShopName.ForeColor = System.Drawing.Color.White
        Me.Label_ShopName.Location = New System.Drawing.Point(50, 48)
        Me.Label_ShopName.Name = "Label_ShopName"
        Me.Label_ShopName.Size = New System.Drawing.Size(147, 40)
        Me.Label_ShopName.TabIndex = 37
        Me.Label_ShopName.Text = "ហាងកាហ្វេ Gurutech"
        '
        'Img_Logo
        '
        Me.Img_Logo.BackColor = System.Drawing.Color.SteelBlue
        Me.Img_Logo.IconChar = FontAwesome.Sharp.IconChar.User
        Me.Img_Logo.IconColor = System.Drawing.Color.White
        Me.Img_Logo.IconSize = 40
        Me.Img_Logo.Location = New System.Drawing.Point(4, 48)
        Me.Img_Logo.Name = "Img_Logo"
        Me.Img_Logo.Size = New System.Drawing.Size(40, 40)
        Me.Img_Logo.TabIndex = 36
        Me.Img_Logo.TabStop = False
        '
        'Txt_Login
        '
        Me.Txt_Login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_Login.FlatAppearance.BorderSize = 0
        Me.Txt_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Txt_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Txt_Login.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Txt_Login.Font = New System.Drawing.Font("NiDA Bayon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Login.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Txt_Login.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle
        Me.Txt_Login.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Txt_Login.IconSize = 35
        Me.Txt_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Txt_Login.Location = New System.Drawing.Point(0, 590)
        Me.Txt_Login.Name = "Txt_Login"
        Me.Txt_Login.Rotation = 0R
        Me.Txt_Login.Size = New System.Drawing.Size(197, 42)
        Me.Txt_Login.TabIndex = 35
        Me.Txt_Login.Text = "ចាកចេញ"
        Me.Txt_Login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Txt_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Txt_Login.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("NiDA Bayon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle
        Me.IconButton1.IconColor = System.Drawing.Color.WhiteSmoke
        Me.IconButton1.IconSize = 35
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(0, 408)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(197, 50)
        Me.IconButton1.TabIndex = 34
        Me.IconButton1.Text = "អំពីកម្មវិធី"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Btn_About_Us
        '
        Me.Btn_About_Us.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_About_Us.FlatAppearance.BorderSize = 0
        Me.Btn_About_Us.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_About_Us.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_About_Us.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_About_Us.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_About_Us.Font = New System.Drawing.Font("NiDA Bayon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_About_Us.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_About_Us.IconChar = FontAwesome.Sharp.IconChar.CreditCard
        Me.Btn_About_Us.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_About_Us.IconSize = 35
        Me.Btn_About_Us.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_About_Us.Location = New System.Drawing.Point(0, 296)
        Me.Btn_About_Us.Name = "Btn_About_Us"
        Me.Btn_About_Us.Rotation = 0R
        Me.Btn_About_Us.Size = New System.Drawing.Size(197, 50)
        Me.Btn_About_Us.TabIndex = 33
        Me.Btn_About_Us.Text = "ចំណូលចំណាយ"
        Me.Btn_About_Us.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_About_Us.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_About_Us.UseVisualStyleBackColor = True
        '
        'Btn_Payment
        '
        Me.Btn_Payment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Payment.FlatAppearance.BorderSize = 0
        Me.Btn_Payment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Payment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Payment.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Payment.Font = New System.Drawing.Font("NiDA Bayon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Payment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Payment.IconChar = FontAwesome.Sharp.IconChar.ChartBar
        Me.Btn_Payment.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Payment.IconSize = 35
        Me.Btn_Payment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Payment.Location = New System.Drawing.Point(0, 352)
        Me.Btn_Payment.Name = "Btn_Payment"
        Me.Btn_Payment.Rotation = 0R
        Me.Btn_Payment.Size = New System.Drawing.Size(197, 50)
        Me.Btn_Payment.TabIndex = 31
        Me.Btn_Payment.Text = "របាយការណ៍"
        Me.Btn_Payment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Payment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Payment.UseVisualStyleBackColor = True
        '
        'Btn_Sales
        '
        Me.Btn_Sales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Sales.FlatAppearance.BorderSize = 0
        Me.Btn_Sales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Sales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Sales.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Sales.Font = New System.Drawing.Font("NiDA Bayon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Sales.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Sales.IconChar = FontAwesome.Sharp.IconChar.ProductHunt
        Me.Btn_Sales.IconColor = System.Drawing.Color.WhiteSmoke
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
        'Btn_Stock
        '
        Me.Btn_Stock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Stock.FlatAppearance.BorderSize = 0
        Me.Btn_Stock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Stock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Stock.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Stock.Font = New System.Drawing.Font("NiDA Bayon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Stock.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Stock.IconChar = FontAwesome.Sharp.IconChar.Industry
        Me.Btn_Stock.IconColor = System.Drawing.Color.WhiteSmoke
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
        'Btn_Dashboard
        '
        Me.Btn_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Dashboard.FlatAppearance.BorderSize = 0
        Me.Btn_Dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Dashboard.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Dashboard.Font = New System.Drawing.Font("NiDA Bayon", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Dashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Dashboard.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.Btn_Dashboard.IconColor = System.Drawing.Color.WhiteSmoke
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
        CType(Me.Img_Logo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Btn_About_Us As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Payment As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Sales As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Stock As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Dashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_Content As Panel
    Friend WithEvents Txt_Login As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label_ShopName As Label
    Friend WithEvents Img_Logo As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Btn_Menu As FontAwesome.Sharp.IconButton
    Friend WithEvents Tm_Marquee As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Setting As FontAwesome.Sharp.IconButton
    Friend WithEvents Label_Login As Label
End Class
