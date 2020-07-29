<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Sale_Temp
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
        Me.Panel_Title = New System.Windows.Forms.Panel()
        Me.Lb_User = New System.Windows.Forms.Label()
        Me.btn_User = New FontAwesome.Sharp.IconButton()
        Me.Btn_Restore = New FontAwesome.Sharp.IconButton()
        Me.Btn_Minimize = New FontAwesome.Sharp.IconButton()
        Me.Btn_Maximize = New FontAwesome.Sharp.IconButton()
        Me.Btn_Close = New FontAwesome.Sharp.IconButton()
        Me.Panel_Item = New System.Windows.Forms.Panel()
        Me.Btn_Search = New FontAwesome.Sharp.IconButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.Btn_Setting = New FontAwesome.Sharp.IconButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.Txt_Invoice = New System.Windows.Forms.TextBox()
        Me.Btn_Cash = New FontAwesome.Sharp.IconButton()
        Me.DVG_Product = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lb_PayDueRiel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_PayDue = New System.Windows.Forms.TextBox()
        Me.Txt_Payment = New System.Windows.Forms.TextBox()
        Me.Panel_Content = New System.Windows.Forms.Panel()
        Me.Lb_Rate = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Lb_PaymentRiel = New System.Windows.Forms.Label()
        Me.Txt_Discount = New System.Windows.Forms.TextBox()
        Me.Lb_TotalRiel = New System.Windows.Forms.Label()
        Me.Txt_Total = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_SubTotal = New System.Windows.Forms.TextBox()
        Me.Lst_data = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NameKH = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.QTY = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel_Title.SuspendLayout()
        Me.Panel_Item.SuspendLayout()
        CType(Me.DVG_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Content.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.Color.Gray
        Me.Panel_Title.Controls.Add(Me.Lb_User)
        Me.Panel_Title.Controls.Add(Me.btn_User)
        Me.Panel_Title.Controls.Add(Me.Btn_Restore)
        Me.Panel_Title.Controls.Add(Me.Btn_Minimize)
        Me.Panel_Title.Controls.Add(Me.Btn_Maximize)
        Me.Panel_Title.Controls.Add(Me.Btn_Close)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(1063, 35)
        Me.Panel_Title.TabIndex = 26
        '
        'Lb_User
        '
        Me.Lb_User.AutoSize = True
        Me.Lb_User.Font = New System.Drawing.Font("Khmer OS Siemreap", 10.75!)
        Me.Lb_User.ForeColor = System.Drawing.Color.White
        Me.Lb_User.Location = New System.Drawing.Point(125, 5)
        Me.Lb_User.Name = "Lb_User"
        Me.Lb_User.Size = New System.Drawing.Size(62, 27)
        Me.Lb_User.TabIndex = 8
        Me.Lb_User.Text = "Label15"
        '
        'btn_User
        '
        Me.btn_User.FlatAppearance.BorderSize = 0
        Me.btn_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_User.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_User.ForeColor = System.Drawing.Color.White
        Me.btn_User.IconChar = FontAwesome.Sharp.IconChar.User
        Me.btn_User.IconColor = System.Drawing.Color.White
        Me.btn_User.IconSize = 25
        Me.btn_User.Location = New System.Drawing.Point(8, 2)
        Me.btn_User.Name = "btn_User"
        Me.btn_User.Rotation = 0R
        Me.btn_User.Size = New System.Drawing.Size(112, 29)
        Me.btn_User.TabIndex = 7
        Me.btn_User.Text = "អ្នកប្រើប្រាស់:"
        Me.btn_User.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_User.UseVisualStyleBackColor = True
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
        'Panel_Item
        '
        Me.Panel_Item.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_Item.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Item.Controls.Add(Me.Btn_Search)
        Me.Panel_Item.Controls.Add(Me.Label16)
        Me.Panel_Item.Controls.Add(Me.Txt_Search)
        Me.Panel_Item.Controls.Add(Me.Btn_Setting)
        Me.Panel_Item.Controls.Add(Me.Label13)
        Me.Panel_Item.Controls.Add(Me.IconButton2)
        Me.Panel_Item.Controls.Add(Me.Txt_Invoice)
        Me.Panel_Item.Controls.Add(Me.Btn_Cash)
        Me.Panel_Item.Controls.Add(Me.DVG_Product)
        Me.Panel_Item.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Item.Location = New System.Drawing.Point(0, 35)
        Me.Panel_Item.Name = "Panel_Item"
        Me.Panel_Item.Size = New System.Drawing.Size(461, 551)
        Me.Panel_Item.TabIndex = 29
        '
        'Btn_Search
        '
        Me.Btn_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Search.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Search.FlatAppearance.BorderSize = 0
        Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Search.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Search.ForeColor = System.Drawing.Color.Black
        Me.Btn_Search.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.Btn_Search.IconColor = System.Drawing.Color.Black
        Me.Btn_Search.IconSize = 30
        Me.Btn_Search.Location = New System.Drawing.Point(420, 434)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Rotation = 0R
        Me.Btn_Search.Size = New System.Drawing.Size(30, 31)
        Me.Btn_Search.TabIndex = 27
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(-1, 437)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 24)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "ស្វែងរកផលិតផល"
        '
        'Txt_Search
        '
        Me.Txt_Search.Location = New System.Drawing.Point(102, 434)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(316, 31)
        Me.Txt_Search.TabIndex = 26
        '
        'Btn_Setting
        '
        Me.Btn_Setting.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Setting.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Setting.FlatAppearance.BorderSize = 0
        Me.Btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Setting.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Setting.ForeColor = System.Drawing.Color.Black
        Me.Btn_Setting.IconChar = FontAwesome.Sharp.IconChar.Cog
        Me.Btn_Setting.IconColor = System.Drawing.Color.Black
        Me.Btn_Setting.IconSize = 22
        Me.Btn_Setting.Location = New System.Drawing.Point(6, 502)
        Me.Btn_Setting.Name = "Btn_Setting"
        Me.Btn_Setting.Rotation = 0R
        Me.Btn_Setting.Size = New System.Drawing.Size(97, 35)
        Me.Btn_Setting.TabIndex = 24
        Me.Btn_Setting.Text = "អត្រាប្ដូរ"
        Me.Btn_Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Setting.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(9, 474)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 24)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "លេខវិក័យបត្រ"
        '
        'IconButton2
        '
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton2.ForeColor = System.Drawing.Color.Red
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.TrashRestore
        Me.IconButton2.IconColor = System.Drawing.Color.Red
        Me.IconButton2.IconSize = 25
        Me.IconButton2.Location = New System.Drawing.Point(342, 508)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Rotation = 0R
        Me.IconButton2.Size = New System.Drawing.Size(111, 33)
        Me.IconButton2.TabIndex = 19
        Me.IconButton2.Text = "សំអាត"
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'Txt_Invoice
        '
        Me.Txt_Invoice.Enabled = False
        Me.Txt_Invoice.Location = New System.Drawing.Point(100, 471)
        Me.Txt_Invoice.Name = "Txt_Invoice"
        Me.Txt_Invoice.Size = New System.Drawing.Size(340, 31)
        Me.Txt_Invoice.TabIndex = 23
        '
        'Btn_Cash
        '
        Me.Btn_Cash.FlatAppearance.BorderSize = 0
        Me.Btn_Cash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cash.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Cash.ForeColor = System.Drawing.Color.Blue
        Me.Btn_Cash.IconChar = FontAwesome.Sharp.IconChar.CartPlus
        Me.Btn_Cash.IconColor = System.Drawing.Color.Blue
        Me.Btn_Cash.IconSize = 30
        Me.Btn_Cash.Location = New System.Drawing.Point(204, 508)
        Me.Btn_Cash.Name = "Btn_Cash"
        Me.Btn_Cash.Rotation = 0R
        Me.Btn_Cash.Size = New System.Drawing.Size(132, 33)
        Me.Btn_Cash.TabIndex = 18
        Me.Btn_Cash.Text = "ទូទាត់វិក័យបត្រ"
        Me.Btn_Cash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cash.UseVisualStyleBackColor = True
        '
        'DVG_Product
        '
        Me.DVG_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DVG_Product.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DVG_Product.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DVG_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DVG_Product.Location = New System.Drawing.Point(3, 5)
        Me.DVG_Product.MultiSelect = False
        Me.DVG_Product.Name = "DVG_Product"
        Me.DVG_Product.RowHeadersVisible = False
        Me.DVG_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DVG_Product.Size = New System.Drawing.Size(450, 427)
        Me.DVG_Product.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(233, 423)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 24)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "រៀល"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(233, 462)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 24)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "ដុល្លា"
        '
        'Lb_PayDueRiel
        '
        Me.Lb_PayDueRiel.Location = New System.Drawing.Point(92, 457)
        Me.Lb_PayDueRiel.Name = "Lb_PayDueRiel"
        Me.Lb_PayDueRiel.Size = New System.Drawing.Size(135, 24)
        Me.Lb_PayDueRiel.TabIndex = 20
        Me.Lb_PayDueRiel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 423)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 24)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "ប្រាក់អាប់"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 386)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 24)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "ប្រាក់បង់"
        '
        'Txt_PayDue
        '
        Me.Txt_PayDue.Location = New System.Drawing.Point(92, 420)
        Me.Txt_PayDue.Name = "Txt_PayDue"
        Me.Txt_PayDue.ReadOnly = True
        Me.Txt_PayDue.Size = New System.Drawing.Size(135, 31)
        Me.Txt_PayDue.TabIndex = 14
        '
        'Txt_Payment
        '
        Me.Txt_Payment.Location = New System.Drawing.Point(92, 383)
        Me.Txt_Payment.Name = "Txt_Payment"
        Me.Txt_Payment.Size = New System.Drawing.Size(165, 31)
        Me.Txt_Payment.TabIndex = 13
        '
        'Panel_Content
        '
        Me.Panel_Content.BackColor = System.Drawing.Color.Azure
        Me.Panel_Content.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Content.Controls.Add(Me.Lb_Rate)
        Me.Panel_Content.Controls.Add(Me.Label15)
        Me.Panel_Content.Controls.Add(Me.Label14)
        Me.Panel_Content.Controls.Add(Me.Label12)
        Me.Panel_Content.Controls.Add(Me.Label8)
        Me.Panel_Content.Controls.Add(Me.Label9)
        Me.Panel_Content.Controls.Add(Me.Label3)
        Me.Panel_Content.Controls.Add(Me.Txt_Payment)
        Me.Panel_Content.Controls.Add(Me.Label7)
        Me.Panel_Content.Controls.Add(Me.Lb_PayDueRiel)
        Me.Panel_Content.Controls.Add(Me.Label6)
        Me.Panel_Content.Controls.Add(Me.Label4)
        Me.Panel_Content.Controls.Add(Me.Label5)
        Me.Panel_Content.Controls.Add(Me.Label10)
        Me.Panel_Content.Controls.Add(Me.Lb_PaymentRiel)
        Me.Panel_Content.Controls.Add(Me.Txt_Discount)
        Me.Panel_Content.Controls.Add(Me.Txt_PayDue)
        Me.Panel_Content.Controls.Add(Me.Lb_TotalRiel)
        Me.Panel_Content.Controls.Add(Me.Txt_Total)
        Me.Panel_Content.Controls.Add(Me.Label2)
        Me.Panel_Content.Controls.Add(Me.Label1)
        Me.Panel_Content.Controls.Add(Me.Txt_SubTotal)
        Me.Panel_Content.Controls.Add(Me.Lst_data)
        Me.Panel_Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Content.Location = New System.Drawing.Point(461, 35)
        Me.Panel_Content.Name = "Panel_Content"
        Me.Panel_Content.Size = New System.Drawing.Size(602, 551)
        Me.Panel_Content.TabIndex = 30
        '
        'Lb_Rate
        '
        Me.Lb_Rate.AutoSize = True
        Me.Lb_Rate.Location = New System.Drawing.Point(135, 510)
        Me.Lb_Rate.Name = "Lb_Rate"
        Me.Lb_Rate.Size = New System.Drawing.Size(0, 24)
        Me.Lb_Rate.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 510)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(130, 24)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "អត្រាប្ដូរប្រាក់ 1 USD = "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(554, 516)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(22, 24)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(285, 448)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 24)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "ប្រាក់ត្រូវបង់"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(285, 513)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 24)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "បញ្ចុះតម្លៃ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(285, 386)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "សរុប"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(553, 447)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "រៀល"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(552, 478)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ដុល្លា"
        '
        'Lb_PaymentRiel
        '
        Me.Lb_PaymentRiel.AutoEllipsis = True
        Me.Lb_PaymentRiel.Location = New System.Drawing.Point(363, 480)
        Me.Lb_PaymentRiel.Name = "Lb_PaymentRiel"
        Me.Lb_PaymentRiel.Size = New System.Drawing.Size(184, 27)
        Me.Lb_PaymentRiel.TabIndex = 7
        Me.Lb_PaymentRiel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt_Discount
        '
        Me.Txt_Discount.Location = New System.Drawing.Point(358, 510)
        Me.Txt_Discount.Name = "Txt_Discount"
        Me.Txt_Discount.Size = New System.Drawing.Size(189, 31)
        Me.Txt_Discount.TabIndex = 6
        '
        'Lb_TotalRiel
        '
        Me.Lb_TotalRiel.AutoEllipsis = True
        Me.Lb_TotalRiel.Location = New System.Drawing.Point(359, 417)
        Me.Lb_TotalRiel.Name = "Lb_TotalRiel"
        Me.Lb_TotalRiel.Size = New System.Drawing.Size(188, 24)
        Me.Lb_TotalRiel.TabIndex = 5
        Me.Lb_TotalRiel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt_Total
        '
        Me.Txt_Total.Location = New System.Drawing.Point(359, 444)
        Me.Txt_Total.Name = "Txt_Total"
        Me.Txt_Total.ReadOnly = True
        Me.Txt_Total.Size = New System.Drawing.Size(189, 31)
        Me.Txt_Total.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(554, 386)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "រៀល"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(554, 417)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ដុល្លា"
        '
        'Txt_SubTotal
        '
        Me.Txt_SubTotal.Location = New System.Drawing.Point(358, 383)
        Me.Txt_SubTotal.Name = "Txt_SubTotal"
        Me.Txt_SubTotal.ReadOnly = True
        Me.Txt_SubTotal.Size = New System.Drawing.Size(189, 31)
        Me.Txt_SubTotal.TabIndex = 1
        '
        'Lst_data
        '
        Me.Lst_data.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.Code, Me.Description, Me.NameKH, Me.Price, Me.QTY, Me.Total})
        Me.Lst_data.FullRowSelect = True
        Me.Lst_data.HideSelection = False
        Me.Lst_data.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lst_data.Location = New System.Drawing.Point(6, 5)
        Me.Lst_data.MultiSelect = False
        Me.Lst_data.Name = "Lst_data"
        Me.Lst_data.Size = New System.Drawing.Size(587, 373)
        Me.Lst_data.TabIndex = 0
        Me.Lst_data.UseCompatibleStateImageBehavior = False
        Me.Lst_data.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'Code
        '
        Me.Code.Text = "កូដ"
        Me.Code.Width = 94
        '
        'Description
        '
        Me.Description.Text = "រាយនាមផលិតផល"
        Me.Description.Width = 144
        '
        'NameKH
        '
        Me.NameKH.Text = "ឡាតាំង"
        Me.NameKH.Width = 111
        '
        'Price
        '
        Me.Price.Text = "តម្លៃ"
        Me.Price.Width = 77
        '
        'QTY
        '
        Me.QTY.Text = "ចំនួន"
        Me.QTY.Width = 69
        '
        'Total
        '
        Me.Total.Text = "សរុប"
        Me.Total.Width = 88
        '
        'Frm_Sale_Temp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(1063, 586)
        Me.Controls.Add(Me.Panel_Content)
        Me.Controls.Add(Me.Panel_Item)
        Me.Controls.Add(Me.Panel_Title)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "Frm_Sale_Temp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Sale_Temp"
        Me.Panel_Title.ResumeLayout(False)
        Me.Panel_Title.PerformLayout()
        Me.Panel_Item.ResumeLayout(False)
        Me.Panel_Item.PerformLayout()
        CType(Me.DVG_Product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Content.ResumeLayout(False)
        Me.Panel_Content.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Title As Panel
    Friend WithEvents Btn_Restore As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Maximize As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Close As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_Item As Panel
    Friend WithEvents Panel_Content As Panel
    Friend WithEvents Lst_data As ListView
    Friend WithEvents DVG_Product As DataGridView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Code As ColumnHeader
    Friend WithEvents Description As ColumnHeader
    Friend WithEvents NameKH As ColumnHeader
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents QTY As ColumnHeader
    Friend WithEvents Total As ColumnHeader
    Friend WithEvents Txt_SubTotal As TextBox
    Friend WithEvents Lb_TotalRiel As Label
    Friend WithEvents Txt_Total As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Cash As FontAwesome.Sharp.IconButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_PayDue As TextBox
    Friend WithEvents Txt_Payment As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Lb_PaymentRiel As Label
    Friend WithEvents Txt_Discount As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Lb_PayDueRiel As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Txt_Invoice As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Lb_User As Label
    Friend WithEvents btn_User As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Setting As FontAwesome.Sharp.IconButton
    Friend WithEvents Lb_Rate As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Btn_Search As FontAwesome.Sharp.IconButton
    Friend WithEvents Label16 As Label
    Friend WithEvents Txt_Search As TextBox
End Class
