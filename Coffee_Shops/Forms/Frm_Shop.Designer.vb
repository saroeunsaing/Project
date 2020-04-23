<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Shop
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
        Me.Txt_Address = New System.Windows.Forms.RichTextBox()
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
        CType(Me.Img_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Title.SuspendLayout()
        Me.Panel_Contain.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 541)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(739, 26)
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
        Me.Btn_Delete.Location = New System.Drawing.Point(613, 266)
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
        Me.Btn_Edit.Location = New System.Drawing.Point(533, 266)
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
        Me.Btn_Save.Location = New System.Drawing.Point(457, 266)
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
        Me.Label5.Location = New System.Drawing.Point(63, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(593, 50)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "សូមស្វាគមន៍មកកាន់ហាង"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 29)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "អាសយដ្ឋាន"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 29)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "លេខទំនាក់ទំនង"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 29)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ឡាតាំង"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ឈ្មោះហាង"
        '
        'Txt_Address
        '
        Me.Txt_Address.Location = New System.Drawing.Point(163, 309)
        Me.Txt_Address.Name = "Txt_Address"
        Me.Txt_Address.Size = New System.Drawing.Size(478, 96)
        Me.Txt_Address.TabIndex = 10
        Me.Txt_Address.Text = ""
        '
        'Txt_Contact2
        '
        Me.Txt_Contact2.Location = New System.Drawing.Point(163, 266)
        Me.Txt_Contact2.Name = "Txt_Contact2"
        Me.Txt_Contact2.Size = New System.Drawing.Size(288, 37)
        Me.Txt_Contact2.TabIndex = 8
        '
        'Txt_Contact1
        '
        Me.Txt_Contact1.Location = New System.Drawing.Point(163, 223)
        Me.Txt_Contact1.Name = "Txt_Contact1"
        Me.Txt_Contact1.Size = New System.Drawing.Size(288, 37)
        Me.Txt_Contact1.TabIndex = 7
        '
        'Txt_NameEN
        '
        Me.Txt_NameEN.Location = New System.Drawing.Point(163, 180)
        Me.Txt_NameEN.Name = "Txt_NameEN"
        Me.Txt_NameEN.Size = New System.Drawing.Size(288, 37)
        Me.Txt_NameEN.TabIndex = 6
        '
        'Txt_NameKH
        '
        Me.Txt_NameKH.Location = New System.Drawing.Point(163, 137)
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
        Me.Btn_Remove.Location = New System.Drawing.Point(593, 214)
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
        Me.Btn_Brows.Location = New System.Drawing.Point(533, 214)
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
        Me.Img_Logo.IconChar = FontAwesome.Sharp.IconChar.Drupal
        Me.Img_Logo.IconColor = System.Drawing.Color.Silver
        Me.Img_Logo.IconSize = 92
        Me.Img_Logo.Location = New System.Drawing.Point(538, 120)
        Me.Img_Logo.Name = "Img_Logo"
        Me.Img_Logo.Size = New System.Drawing.Size(103, 92)
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
        Me.Panel_Title.Size = New System.Drawing.Size(739, 31)
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
        Me.Panel_Contain.Controls.Add(Me.Panel1)
        Me.Panel_Contain.Controls.Add(Me.Btn_Delete)
        Me.Panel_Contain.Controls.Add(Me.Btn_Edit)
        Me.Panel_Contain.Controls.Add(Me.Btn_Save)
        Me.Panel_Contain.Controls.Add(Me.Label5)
        Me.Panel_Contain.Controls.Add(Me.Label4)
        Me.Panel_Contain.Controls.Add(Me.Label3)
        Me.Panel_Contain.Controls.Add(Me.Label2)
        Me.Panel_Contain.Controls.Add(Me.Label1)
        Me.Panel_Contain.Controls.Add(Me.Txt_Address)
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
        Me.Panel_Contain.Size = New System.Drawing.Size(739, 567)
        Me.Panel_Contain.TabIndex = 3
        '
        'Frm_Shop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(739, 567)
        Me.Controls.Add(Me.Panel_Title)
        Me.Controls.Add(Me.Panel_Contain)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "Frm_Shop"
        Me.Text = "Frm_Shop"
        CType(Me.Img_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Title.ResumeLayout(False)
        Me.Panel_Contain.ResumeLayout(False)
        Me.Panel_Contain.PerformLayout()
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
    Friend WithEvents Txt_Address As RichTextBox
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
End Class
