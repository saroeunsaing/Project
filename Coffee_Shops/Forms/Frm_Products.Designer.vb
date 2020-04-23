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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Delete = New FontAwesome.Sharp.IconButton()
        Me.Btn_Edit = New FontAwesome.Sharp.IconButton()
        Me.Btn_Save = New FontAwesome.Sharp.IconButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Contact2 = New System.Windows.Forms.TextBox()
        Me.Txt_Contact1 = New System.Windows.Forms.TextBox()
        Me.Txt_NameEN = New System.Windows.Forms.TextBox()
        Me.Txt_NameKH = New System.Windows.Forms.TextBox()
        Me.Btn_Remove = New FontAwesome.Sharp.IconButton()
        Me.Btn_Brows = New FontAwesome.Sharp.IconButton()
        Me.Img_Logo = New FontAwesome.Sharp.IconPictureBox()
        Me.Btn_Minimize = New FontAwesome.Sharp.IconButton()
        Me.Btn_Maximize = New FontAwesome.Sharp.IconButton()
        Me.Panel_Title = New System.Windows.Forms.Panel()
        Me.Btn_Exit = New FontAwesome.Sharp.IconButton()
        Me.Panel_Contain = New System.Windows.Forms.Panel()
        Me.DGV_Data = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Cmb_Category = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.Img_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Title.SuspendLayout()
        Me.Panel_Contain.SuspendLayout()
        CType(Me.DGV_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 612)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(748, 26)
        Me.Panel1.TabIndex = 19
        '
        'Btn_Delete
        '
        Me.Btn_Delete.FlatAppearance.BorderSize = 0
        Me.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Delete.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Delete.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Delete.ForeColor = System.Drawing.Color.Red
        Me.Btn_Delete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.Btn_Delete.IconColor = System.Drawing.Color.Red
        Me.Btn_Delete.IconSize = 20
        Me.Btn_Delete.Location = New System.Drawing.Point(619, 321)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Rotation = 0R
        Me.Btn_Delete.Size = New System.Drawing.Size(75, 37)
        Me.Btn_Delete.TabIndex = 18
        Me.Btn_Delete.Text = "លុប"
        Me.Btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Btn_Edit
        '
        Me.Btn_Edit.FlatAppearance.BorderSize = 0
        Me.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Edit.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Edit.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Edit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Edit.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.Btn_Edit.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Edit.IconSize = 20
        Me.Btn_Edit.Location = New System.Drawing.Point(539, 321)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Rotation = 0R
        Me.Btn_Edit.Size = New System.Drawing.Size(74, 37)
        Me.Btn_Edit.TabIndex = 17
        Me.Btn_Edit.Text = "កែប្រែ"
        Me.Btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Edit.UseVisualStyleBackColor = True
        '
        'Btn_Save
        '
        Me.Btn_Save.FlatAppearance.BorderSize = 0
        Me.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Save.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Save.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Save.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Save.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.Btn_Save.IconColor = System.Drawing.Color.Blue
        Me.Btn_Save.IconSize = 20
        Me.Btn_Save.Location = New System.Drawing.Point(463, 321)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Rotation = 0R
        Me.Btn_Save.Size = New System.Drawing.Size(90, 37)
        Me.Btn_Save.TabIndex = 16
        Me.Btn_Save.Text = " រក្សាទុក"
        Me.Btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Khmer OS Muol Light", 16.25!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(43, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(593, 50)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "សូមស្វាគមន៍មកកាន់ហាង"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 29)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "ប្រភេទំនិញ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 29)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "ឡាតាំង"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 29)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ឈ្មោះផលិតផល"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "លេខសម្គាល់"
        '
        'Txt_Contact2
        '
        Me.Txt_Contact2.Location = New System.Drawing.Point(158, 234)
        Me.Txt_Contact2.Name = "Txt_Contact2"
        Me.Txt_Contact2.Size = New System.Drawing.Size(288, 37)
        Me.Txt_Contact2.TabIndex = 8
        '
        'Txt_Contact1
        '
        Me.Txt_Contact1.Location = New System.Drawing.Point(158, 191)
        Me.Txt_Contact1.Name = "Txt_Contact1"
        Me.Txt_Contact1.Size = New System.Drawing.Size(288, 37)
        Me.Txt_Contact1.TabIndex = 7
        '
        'Txt_NameEN
        '
        Me.Txt_NameEN.Location = New System.Drawing.Point(158, 148)
        Me.Txt_NameEN.Name = "Txt_NameEN"
        Me.Txt_NameEN.Size = New System.Drawing.Size(288, 37)
        Me.Txt_NameEN.TabIndex = 6
        '
        'Txt_NameKH
        '
        Me.Txt_NameKH.Location = New System.Drawing.Point(158, 105)
        Me.Txt_NameKH.Name = "Txt_NameKH"
        Me.Txt_NameKH.Size = New System.Drawing.Size(288, 37)
        Me.Txt_NameKH.TabIndex = 5
        '
        'Btn_Remove
        '
        Me.Btn_Remove.FlatAppearance.BorderSize = 0
        Me.Btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Remove.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Remove.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Remove.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.Btn_Remove.IconColor = System.Drawing.Color.Red
        Me.Btn_Remove.IconSize = 20
        Me.Btn_Remove.Location = New System.Drawing.Point(619, 277)
        Me.Btn_Remove.Name = "Btn_Remove"
        Me.Btn_Remove.Rotation = 0R
        Me.Btn_Remove.Size = New System.Drawing.Size(48, 40)
        Me.Btn_Remove.TabIndex = 4
        Me.Btn_Remove.UseVisualStyleBackColor = True
        '
        'Btn_Brows
        '
        Me.Btn_Brows.FlatAppearance.BorderSize = 0
        Me.Btn_Brows.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Brows.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Brows.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Brows.IconChar = FontAwesome.Sharp.IconChar.CloudUploadAlt
        Me.Btn_Brows.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Brows.IconSize = 30
        Me.Btn_Brows.Location = New System.Drawing.Point(474, 274)
        Me.Btn_Brows.Name = "Btn_Brows"
        Me.Btn_Brows.Rotation = 0R
        Me.Btn_Brows.Size = New System.Drawing.Size(49, 46)
        Me.Btn_Brows.TabIndex = 3
        Me.Btn_Brows.UseVisualStyleBackColor = True
        '
        'Img_Logo
        '
        Me.Img_Logo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Img_Logo.ForeColor = System.Drawing.Color.Silver
        Me.Img_Logo.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag
        Me.Img_Logo.IconColor = System.Drawing.Color.Silver
        Me.Img_Logo.IconSize = 177
        Me.Img_Logo.Location = New System.Drawing.Point(474, 88)
        Me.Img_Logo.Name = "Img_Logo"
        Me.Img_Logo.Size = New System.Drawing.Size(177, 178)
        Me.Img_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Img_Logo.TabIndex = 0
        Me.Img_Logo.TabStop = False
        '
        'Btn_Minimize
        '
        Me.Btn_Minimize.FlatAppearance.BorderSize = 0
        Me.Btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Minimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Minimize.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.Btn_Minimize.IconColor = System.Drawing.Color.White
        Me.Btn_Minimize.IconSize = 22
        Me.Btn_Minimize.Location = New System.Drawing.Point(620, -3)
        Me.Btn_Minimize.Name = "Btn_Minimize"
        Me.Btn_Minimize.Rotation = 0R
        Me.Btn_Minimize.Size = New System.Drawing.Size(31, 28)
        Me.Btn_Minimize.TabIndex = 2
        Me.Btn_Minimize.UseVisualStyleBackColor = True
        '
        'Btn_Maximize
        '
        Me.Btn_Maximize.FlatAppearance.BorderSize = 0
        Me.Btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Maximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Maximize.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.Btn_Maximize.IconColor = System.Drawing.Color.White
        Me.Btn_Maximize.IconSize = 22
        Me.Btn_Maximize.Location = New System.Drawing.Point(652, 3)
        Me.Btn_Maximize.Name = "Btn_Maximize"
        Me.Btn_Maximize.Rotation = 0R
        Me.Btn_Maximize.Size = New System.Drawing.Size(31, 28)
        Me.Btn_Maximize.TabIndex = 1
        Me.Btn_Maximize.UseVisualStyleBackColor = True
        '
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.Color.Gray
        Me.Panel_Title.Controls.Add(Me.Btn_Minimize)
        Me.Panel_Title.Controls.Add(Me.Btn_Maximize)
        Me.Panel_Title.Controls.Add(Me.Btn_Exit)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(748, 31)
        Me.Panel_Title.TabIndex = 2
        '
        'Btn_Exit
        '
        Me.Btn_Exit.FlatAppearance.BorderSize = 0
        Me.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Exit.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Exit.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Exit.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.Btn_Exit.IconColor = System.Drawing.Color.White
        Me.Btn_Exit.IconSize = 22
        Me.Btn_Exit.Location = New System.Drawing.Point(679, 3)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Rotation = 0R
        Me.Btn_Exit.Size = New System.Drawing.Size(31, 28)
        Me.Btn_Exit.TabIndex = 0
        Me.Btn_Exit.UseVisualStyleBackColor = True
        '
        'Panel_Contain
        '
        Me.Panel_Contain.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel_Contain.Controls.Add(Me.DGV_Data)
        Me.Panel_Contain.Controls.Add(Me.ComboBox1)
        Me.Panel_Contain.Controls.Add(Me.Label7)
        Me.Panel_Contain.Controls.Add(Me.Cmb_Category)
        Me.Panel_Contain.Controls.Add(Me.Label6)
        Me.Panel_Contain.Controls.Add(Me.Panel1)
        Me.Panel_Contain.Controls.Add(Me.Btn_Delete)
        Me.Panel_Contain.Controls.Add(Me.Btn_Edit)
        Me.Panel_Contain.Controls.Add(Me.Btn_Save)
        Me.Panel_Contain.Controls.Add(Me.Label5)
        Me.Panel_Contain.Controls.Add(Me.Label4)
        Me.Panel_Contain.Controls.Add(Me.Label3)
        Me.Panel_Contain.Controls.Add(Me.Label2)
        Me.Panel_Contain.Controls.Add(Me.Label1)
        Me.Panel_Contain.Controls.Add(Me.Txt_Contact2)
        Me.Panel_Contain.Controls.Add(Me.Txt_Contact1)
        Me.Panel_Contain.Controls.Add(Me.Txt_NameEN)
        Me.Panel_Contain.Controls.Add(Me.Txt_NameKH)
        Me.Panel_Contain.Controls.Add(Me.Btn_Remove)
        Me.Panel_Contain.Controls.Add(Me.Btn_Brows)
        Me.Panel_Contain.Controls.Add(Me.Img_Logo)
        Me.Panel_Contain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Contain.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Contain.Name = "Panel_Contain"
        Me.Panel_Contain.Size = New System.Drawing.Size(748, 638)
        Me.Panel_Contain.TabIndex = 3
        '
        'DGV_Data
        '
        Me.DGV_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_Data.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Data.Location = New System.Drawing.Point(13, 378)
        Me.DGV_Data.Name = "DGV_Data"
        Me.DGV_Data.RowHeadersVisible = False
        Me.DGV_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Data.Size = New System.Drawing.Size(723, 228)
        Me.DGV_Data.TabIndex = 24
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(158, 320)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(288, 37)
        Me.ComboBox1.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 29)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "ប្រភពទំនិញ"
        '
        'Cmb_Category
        '
        Me.Cmb_Category.FormattingEnabled = True
        Me.Cmb_Category.Location = New System.Drawing.Point(158, 277)
        Me.Cmb_Category.Name = "Cmb_Category"
        Me.Cmb_Category.Size = New System.Drawing.Size(288, 37)
        Me.Cmb_Category.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 29)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "តម្លៃដើម"
        '
        'Frm_Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(748, 638)
        Me.Controls.Add(Me.Panel_Title)
        Me.Controls.Add(Me.Panel_Contain)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "Frm_Products"
        Me.Text = "Frm_Products"
        CType(Me.Img_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Title.ResumeLayout(False)
        Me.Panel_Contain.ResumeLayout(False)
        Me.Panel_Contain.PerformLayout()
        CType(Me.DGV_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Delete As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Edit As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Save As FontAwesome.Sharp.IconButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Contact2 As TextBox
    Friend WithEvents Txt_Contact1 As TextBox
    Friend WithEvents Txt_NameEN As TextBox
    Friend WithEvents Txt_NameKH As TextBox
    Friend WithEvents Btn_Remove As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Brows As FontAwesome.Sharp.IconButton
    Friend WithEvents Img_Logo As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Btn_Minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Maximize As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_Title As Panel
    Friend WithEvents Btn_Exit As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_Contain As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Cmb_Category As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DGV_Data As DataGridView
End Class
