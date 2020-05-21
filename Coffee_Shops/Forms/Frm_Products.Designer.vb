<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Products
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Products))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Price = New System.Windows.Forms.TextBox()
        Me.Txt_NameEN = New System.Windows.Forms.TextBox()
        Me.Txt_NameKH = New System.Windows.Forms.TextBox()
        Me.Txt_ID = New System.Windows.Forms.TextBox()
        Me.Panel_Title = New System.Windows.Forms.Panel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Btn_Close = New FontAwesome.Sharp.IconButton()
        Me.Panel_Contain = New System.Windows.Forms.Panel()
        Me.DGV_Data = New System.Windows.Forms.DataGridView()
        Me.Txt_total = New System.Windows.Forms.TextBox()
        Me.Txt_Discount = New System.Windows.Forms.TextBox()
        Me.Txt_priceSale = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txt_Description = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Btn_AddMatrial = New FontAwesome.Sharp.IconButton()
        Me.Btn_AddCategory = New FontAwesome.Sharp.IconButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Cmb_Material = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Cmb_Category = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btn_Delete = New FontAwesome.Sharp.IconButton()
        Me.Btn_Edit = New FontAwesome.Sharp.IconButton()
        Me.Btn_Save = New FontAwesome.Sharp.IconButton()
        Me.Btn_Remove = New FontAwesome.Sharp.IconButton()
        Me.Btn_Brows = New FontAwesome.Sharp.IconButton()
        Me.Img_Logo = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel_Title.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Contain.SuspendLayout()
        CType(Me.DGV_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Img_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Khmer OS Muol Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(43, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 37)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "បញ្ចូលផលិតផលថ្មី"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 335)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 29)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "ប្រភេទំនិញ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(354, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 29)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "ឡាតាំង"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 29)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ឈ្មោះផលិតផល"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "លេខសម្គាល់"
        '
        'Txt_Price
        '
        Me.Txt_Price.Location = New System.Drawing.Point(147, 137)
        Me.Txt_Price.Name = "Txt_Price"
        Me.Txt_Price.Size = New System.Drawing.Size(202, 37)
        Me.Txt_Price.TabIndex = 3
        '
        'Txt_NameEN
        '
        Me.Txt_NameEN.Location = New System.Drawing.Point(434, 51)
        Me.Txt_NameEN.Name = "Txt_NameEN"
        Me.Txt_NameEN.Size = New System.Drawing.Size(261, 37)
        Me.Txt_NameEN.TabIndex = 2
        '
        'Txt_NameKH
        '
        Me.Txt_NameKH.Location = New System.Drawing.Point(147, 94)
        Me.Txt_NameKH.Name = "Txt_NameKH"
        Me.Txt_NameKH.Size = New System.Drawing.Size(549, 37)
        Me.Txt_NameKH.TabIndex = 1
        '
        'Txt_ID
        '
        Me.Txt_ID.Location = New System.Drawing.Point(147, 51)
        Me.Txt_ID.Name = "Txt_ID"
        Me.Txt_ID.Size = New System.Drawing.Size(202, 37)
        Me.Txt_ID.TabIndex = 0
        '
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.Color.Pink
        Me.Panel_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Title.Controls.Add(Me.IconPictureBox1)
        Me.Panel_Title.Controls.Add(Me.Btn_Close)
        Me.Panel_Title.Controls.Add(Me.Label5)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(900, 40)
        Me.Panel_Title.TabIndex = 2
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Pink
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.DimGray
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ProductHunt
        Me.IconPictureBox1.IconColor = System.Drawing.Color.DimGray
        Me.IconPictureBox1.Location = New System.Drawing.Point(3, 5)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox1.TabIndex = 27
        Me.IconPictureBox1.TabStop = False
        '
        'Btn_Close
        '
        Me.Btn_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Close.FlatAppearance.BorderSize = 0
        Me.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Close.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Close.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.Btn_Close.IconColor = System.Drawing.Color.DimGray
        Me.Btn_Close.IconSize = 22
        Me.Btn_Close.Location = New System.Drawing.Point(859, 0)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Rotation = 0R
        Me.Btn_Close.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Close.TabIndex = 27
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'Panel_Contain
        '
        Me.Panel_Contain.BackColor = System.Drawing.Color.Pink
        Me.Panel_Contain.Controls.Add(Me.DGV_Data)
        Me.Panel_Contain.Controls.Add(Me.Txt_total)
        Me.Panel_Contain.Controls.Add(Me.Txt_Discount)
        Me.Panel_Contain.Controls.Add(Me.Txt_priceSale)
        Me.Panel_Contain.Controls.Add(Me.Label11)
        Me.Panel_Contain.Controls.Add(Me.Txt_Description)
        Me.Panel_Contain.Controls.Add(Me.Label10)
        Me.Panel_Contain.Controls.Add(Me.Label9)
        Me.Panel_Contain.Controls.Add(Me.Btn_AddMatrial)
        Me.Panel_Contain.Controls.Add(Me.Btn_AddCategory)
        Me.Panel_Contain.Controls.Add(Me.Label8)
        Me.Panel_Contain.Controls.Add(Me.Cmb_Material)
        Me.Panel_Contain.Controls.Add(Me.Label7)
        Me.Panel_Contain.Controls.Add(Me.Cmb_Category)
        Me.Panel_Contain.Controls.Add(Me.Label6)
        Me.Panel_Contain.Controls.Add(Me.Btn_Delete)
        Me.Panel_Contain.Controls.Add(Me.Btn_Edit)
        Me.Panel_Contain.Controls.Add(Me.Btn_Save)
        Me.Panel_Contain.Controls.Add(Me.Label4)
        Me.Panel_Contain.Controls.Add(Me.Label3)
        Me.Panel_Contain.Controls.Add(Me.Label2)
        Me.Panel_Contain.Controls.Add(Me.Label1)
        Me.Panel_Contain.Controls.Add(Me.Txt_Price)
        Me.Panel_Contain.Controls.Add(Me.Txt_NameEN)
        Me.Panel_Contain.Controls.Add(Me.Txt_NameKH)
        Me.Panel_Contain.Controls.Add(Me.Txt_ID)
        Me.Panel_Contain.Controls.Add(Me.Btn_Remove)
        Me.Panel_Contain.Controls.Add(Me.Btn_Brows)
        Me.Panel_Contain.Controls.Add(Me.Img_Logo)
        Me.Panel_Contain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Contain.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Contain.Name = "Panel_Contain"
        Me.Panel_Contain.Size = New System.Drawing.Size(900, 635)
        Me.Panel_Contain.TabIndex = 3
        '
        'DGV_Data
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Data.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_Data.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Data.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Data.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Data.Location = New System.Drawing.Point(3, 376)
        Me.DGV_Data.Name = "DGV_Data"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.RosyBrown
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Data.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Data.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Khmer OS Siemreap", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DGV_Data.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Data.Size = New System.Drawing.Size(894, 256)
        Me.DGV_Data.TabIndex = 39
        '
        'Txt_total
        '
        Me.Txt_total.Location = New System.Drawing.Point(449, 188)
        Me.Txt_total.Name = "Txt_total"
        Me.Txt_total.Size = New System.Drawing.Size(246, 37)
        Me.Txt_total.TabIndex = 38
        '
        'Txt_Discount
        '
        Me.Txt_Discount.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Discount.Location = New System.Drawing.Point(147, 177)
        Me.Txt_Discount.Name = "Txt_Discount"
        Me.Txt_Discount.Size = New System.Drawing.Size(202, 37)
        Me.Txt_Discount.TabIndex = 5
        '
        'Txt_priceSale
        '
        Me.Txt_priceSale.Location = New System.Drawing.Point(449, 137)
        Me.Txt_priceSale.Name = "Txt_priceSale"
        Me.Txt_priceSale.Size = New System.Drawing.Size(246, 37)
        Me.Txt_priceSale.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(69, 253)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 29)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "ពិពណ៌នា"
        '
        'Txt_Description
        '
        Me.Txt_Description.Location = New System.Drawing.Point(147, 250)
        Me.Txt_Description.Name = "Txt_Description"
        Me.Txt_Description.Size = New System.Drawing.Size(549, 76)
        Me.Txt_Description.TabIndex = 6
        Me.Txt_Description.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 29)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "បញ្ចុះតម្លៃ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(376, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 29)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "តម្លៃលក់"
        '
        'Btn_AddMatrial
        '
        Me.Btn_AddMatrial.FlatAppearance.BorderSize = 0
        Me.Btn_AddMatrial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AddMatrial.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_AddMatrial.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AddMatrial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_AddMatrial.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.Btn_AddMatrial.IconColor = System.Drawing.Color.Blue
        Me.Btn_AddMatrial.IconSize = 20
        Me.Btn_AddMatrial.Location = New System.Drawing.Point(660, 329)
        Me.Btn_AddMatrial.Name = "Btn_AddMatrial"
        Me.Btn_AddMatrial.Rotation = 0R
        Me.Btn_AddMatrial.Size = New System.Drawing.Size(36, 37)
        Me.Btn_AddMatrial.TabIndex = 28
        Me.Btn_AddMatrial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_AddMatrial.UseVisualStyleBackColor = True
        '
        'Btn_AddCategory
        '
        Me.Btn_AddCategory.FlatAppearance.BorderSize = 0
        Me.Btn_AddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AddCategory.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_AddCategory.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AddCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_AddCategory.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.Btn_AddCategory.IconColor = System.Drawing.Color.Blue
        Me.Btn_AddCategory.IconSize = 20
        Me.Btn_AddCategory.Location = New System.Drawing.Point(327, 333)
        Me.Btn_AddCategory.Name = "Btn_AddCategory"
        Me.Btn_AddCategory.Rotation = 0R
        Me.Btn_AddCategory.Size = New System.Drawing.Size(36, 37)
        Me.Btn_AddCategory.TabIndex = 27
        Me.Btn_AddCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_AddCategory.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(378, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 29)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "សរុប"
        '
        'Cmb_Material
        '
        Me.Cmb_Material.FormattingEnabled = True
        Me.Cmb_Material.Items.AddRange(New Object() {"RM", "FG", "Other"})
        Me.Cmb_Material.Location = New System.Drawing.Point(474, 329)
        Me.Cmb_Material.Name = "Cmb_Material"
        Me.Cmb_Material.Size = New System.Drawing.Size(180, 37)
        Me.Cmb_Material.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(378, 335)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 29)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "ប្រភពទំនិញ"
        '
        'Cmb_Category
        '
        Me.Cmb_Category.FormattingEnabled = True
        Me.Cmb_Category.Location = New System.Drawing.Point(147, 332)
        Me.Cmb_Category.Name = "Cmb_Category"
        Me.Cmb_Category.Size = New System.Drawing.Size(184, 37)
        Me.Cmb_Category.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 29)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "តម្លៃដើម"
        '
        'Btn_Delete
        '
        Me.Btn_Delete.FlatAppearance.BorderSize = 0
        Me.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Delete.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Delete.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!)
        Me.Btn_Delete.ForeColor = System.Drawing.Color.Red
        Me.Btn_Delete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.Btn_Delete.IconColor = System.Drawing.Color.Red
        Me.Btn_Delete.IconSize = 20
        Me.Btn_Delete.Location = New System.Drawing.Point(812, 331)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Rotation = 0R
        Me.Btn_Delete.Size = New System.Drawing.Size(75, 37)
        Me.Btn_Delete.TabIndex = 11
        Me.Btn_Delete.Text = "លុប"
        Me.Btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Btn_Edit
        '
        Me.Btn_Edit.FlatAppearance.BorderSize = 0
        Me.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Edit.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Edit.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!)
        Me.Btn_Edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Edit.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.Btn_Edit.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Edit.IconSize = 20
        Me.Btn_Edit.Location = New System.Drawing.Point(720, 331)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Rotation = 0R
        Me.Btn_Edit.Size = New System.Drawing.Size(86, 37)
        Me.Btn_Edit.TabIndex = 10
        Me.Btn_Edit.Text = "កែប្រែ"
        Me.Btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Edit.UseVisualStyleBackColor = True
        '
        'Btn_Save
        '
        Me.Btn_Save.FlatAppearance.BorderSize = 0
        Me.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Save.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Save.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!)
        Me.Btn_Save.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Save.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.Btn_Save.IconColor = System.Drawing.Color.Blue
        Me.Btn_Save.IconSize = 20
        Me.Btn_Save.Location = New System.Drawing.Point(764, 298)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Rotation = 0R
        Me.Btn_Save.Size = New System.Drawing.Size(96, 37)
        Me.Btn_Save.TabIndex = 9
        Me.Btn_Save.Text = " រក្សាទុក"
        Me.Btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Btn_Remove
        '
        Me.Btn_Remove.FlatAppearance.BorderSize = 0
        Me.Btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Remove.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Remove.Font = New System.Drawing.Font("Khmer OS Siemreap", 10.0!)
        Me.Btn_Remove.ForeColor = System.Drawing.Color.Red
        Me.Btn_Remove.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Btn_Remove.IconColor = System.Drawing.Color.Red
        Me.Btn_Remove.IconSize = 20
        Me.Btn_Remove.Location = New System.Drawing.Point(812, 215)
        Me.Btn_Remove.Name = "Btn_Remove"
        Me.Btn_Remove.Rotation = 0R
        Me.Btn_Remove.Size = New System.Drawing.Size(58, 30)
        Me.Btn_Remove.TabIndex = 4
        Me.Btn_Remove.Text = "សំអាត"
        Me.Btn_Remove.UseVisualStyleBackColor = True
        '
        'Btn_Brows
        '
        Me.Btn_Brows.FlatAppearance.BorderSize = 0
        Me.Btn_Brows.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Brows.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Brows.Font = New System.Drawing.Font("Khmer OS Siemreap", 10.0!)
        Me.Btn_Brows.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Brows.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Btn_Brows.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Brows.IconSize = 30
        Me.Btn_Brows.Location = New System.Drawing.Point(720, 215)
        Me.Btn_Brows.Name = "Btn_Brows"
        Me.Btn_Brows.Rotation = 0R
        Me.Btn_Brows.Size = New System.Drawing.Size(86, 33)
        Me.Btn_Brows.TabIndex = 3
        Me.Btn_Brows.Text = "ទាញរូបភាព"
        Me.Btn_Brows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Brows.UseVisualStyleBackColor = True
        '
        'Img_Logo
        '
        Me.Img_Logo.BackColor = System.Drawing.Color.Transparent
        Me.Img_Logo.ForeColor = System.Drawing.Color.Silver
        Me.Img_Logo.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag
        Me.Img_Logo.IconColor = System.Drawing.Color.Silver
        Me.Img_Logo.IconSize = 150
        Me.Img_Logo.Location = New System.Drawing.Point(720, 59)
        Me.Img_Logo.Name = "Img_Logo"
        Me.Img_Logo.Size = New System.Drawing.Size(150, 150)
        Me.Img_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Img_Logo.TabIndex = 0
        Me.Img_Logo.TabStop = False
        '
        'Frm_Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 635)
        Me.Controls.Add(Me.Panel_Title)
        Me.Controls.Add(Me.Panel_Contain)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "Frm_Products"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Products"
        Me.Panel_Title.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Contain.ResumeLayout(False)
        Me.Panel_Contain.PerformLayout()
        CType(Me.DGV_Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Img_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Delete As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Edit As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Save As FontAwesome.Sharp.IconButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Price As TextBox
    Friend WithEvents Txt_NameEN As TextBox
    Friend WithEvents Txt_NameKH As TextBox
    Friend WithEvents Txt_ID As TextBox
    Friend WithEvents Btn_Remove As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Brows As FontAwesome.Sharp.IconButton
    Friend WithEvents Img_Logo As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel_Title As Panel
    Friend WithEvents Panel_Contain As Panel
    Friend WithEvents Cmb_Material As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Cmb_Category As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Btn_Close As FontAwesome.Sharp.IconButton
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Btn_AddMatrial As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_AddCategory As FontAwesome.Sharp.IconButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Txt_Description As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_total As TextBox
    Friend WithEvents Txt_Discount As TextBox
    Friend WithEvents Txt_priceSale As TextBox
    Friend WithEvents DGV_Data As DataGridView
End Class
