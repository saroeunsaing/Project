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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel_Title = New System.Windows.Forms.Panel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Btn_Exit = New FontAwesome.Sharp.IconButton()
        Me.Panel_Contain = New System.Windows.Forms.Panel()
        Me.Btn_Remove = New FontAwesome.Sharp.IconButton()
        Me.Btn_Brows = New FontAwesome.Sharp.IconButton()
        Me.Img_Logo = New System.Windows.Forms.PictureBox()
        Me.Btn_Save = New FontAwesome.Sharp.IconButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Address = New System.Windows.Forms.RichTextBox()
        Me.Txt_Contact2 = New System.Windows.Forms.TextBox()
        Me.Txt_Contact1 = New System.Windows.Forms.TextBox()
        Me.Txt_NameEN = New System.Windows.Forms.TextBox()
        Me.Txt_NameKH = New System.Windows.Forms.TextBox()
        Me.Panel_Title.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Contain.SuspendLayout()
        CType(Me.Img_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Khmer OS Siemreap", 10.25!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(44, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(246, 24)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "ព័ត៌មានហាង"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Title.Controls.Add(Me.IconPictureBox1)
        Me.Panel_Title.Controls.Add(Me.Btn_Exit)
        Me.Panel_Title.Controls.Add(Me.Label5)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(614, 31)
        Me.Panel_Title.TabIndex = 2
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.YellowGreen
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Hotel
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconSize = 31
        Me.IconPictureBox1.Location = New System.Drawing.Point(3, -1)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(35, 31)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconPictureBox1.TabIndex = 20
        Me.IconPictureBox1.TabStop = False
        '
        'Btn_Exit
        '
        Me.Btn_Exit.FlatAppearance.BorderSize = 0
        Me.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Exit.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Exit.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Exit.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.Btn_Exit.IconColor = System.Drawing.Color.White
        Me.Btn_Exit.IconSize = 30
        Me.Btn_Exit.Location = New System.Drawing.Point(570, 3)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Rotation = 0R
        Me.Btn_Exit.Size = New System.Drawing.Size(39, 25)
        Me.Btn_Exit.TabIndex = 0
        Me.Btn_Exit.UseVisualStyleBackColor = True
        '
        'Panel_Contain
        '
        Me.Panel_Contain.BackColor = System.Drawing.Color.Lavender
        Me.Panel_Contain.Controls.Add(Me.Btn_Remove)
        Me.Panel_Contain.Controls.Add(Me.Btn_Brows)
        Me.Panel_Contain.Controls.Add(Me.Img_Logo)
        Me.Panel_Contain.Controls.Add(Me.Btn_Save)
        Me.Panel_Contain.Controls.Add(Me.Label4)
        Me.Panel_Contain.Controls.Add(Me.Label3)
        Me.Panel_Contain.Controls.Add(Me.Label2)
        Me.Panel_Contain.Controls.Add(Me.Label1)
        Me.Panel_Contain.Controls.Add(Me.Txt_Address)
        Me.Panel_Contain.Controls.Add(Me.Txt_Contact2)
        Me.Panel_Contain.Controls.Add(Me.Txt_Contact1)
        Me.Panel_Contain.Controls.Add(Me.Txt_NameEN)
        Me.Panel_Contain.Controls.Add(Me.Txt_NameKH)
        Me.Panel_Contain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Contain.Location = New System.Drawing.Point(0, 31)
        Me.Panel_Contain.Name = "Panel_Contain"
        Me.Panel_Contain.Size = New System.Drawing.Size(614, 318)
        Me.Panel_Contain.TabIndex = 7
        '
        'Btn_Remove
        '
        Me.Btn_Remove.AutoSize = True
        Me.Btn_Remove.FlatAppearance.BorderSize = 0
        Me.Btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Remove.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Remove.Font = New System.Drawing.Font("Khmer OS Siemreap", 10.0!)
        Me.Btn_Remove.ForeColor = System.Drawing.Color.Red
        Me.Btn_Remove.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Btn_Remove.IconColor = System.Drawing.Color.Black
        Me.Btn_Remove.IconSize = 16
        Me.Btn_Remove.Location = New System.Drawing.Point(566, 114)
        Me.Btn_Remove.Name = "Btn_Remove"
        Me.Btn_Remove.Rotation = 0R
        Me.Btn_Remove.Size = New System.Drawing.Size(46, 35)
        Me.Btn_Remove.TabIndex = 21
        Me.Btn_Remove.Text = "លុប"
        Me.Btn_Remove.UseVisualStyleBackColor = True
        '
        'Btn_Brows
        '
        Me.Btn_Brows.AutoSize = True
        Me.Btn_Brows.FlatAppearance.BorderSize = 0
        Me.Btn_Brows.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Brows.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Brows.Font = New System.Drawing.Font("Khmer OS Siemreap", 10.0!)
        Me.Btn_Brows.ForeColor = System.Drawing.Color.Blue
        Me.Btn_Brows.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Btn_Brows.IconColor = System.Drawing.Color.Black
        Me.Btn_Brows.IconSize = 16
        Me.Btn_Brows.Location = New System.Drawing.Point(476, 115)
        Me.Btn_Brows.Name = "Btn_Brows"
        Me.Btn_Brows.Rotation = 0R
        Me.Btn_Brows.Size = New System.Drawing.Size(89, 35)
        Me.Btn_Brows.TabIndex = 20
        Me.Btn_Brows.Text = "ទាញរូបភាព"
        Me.Btn_Brows.UseVisualStyleBackColor = True
        '
        'Img_Logo
        '
        Me.Img_Logo.Location = New System.Drawing.Point(492, 4)
        Me.Img_Logo.Name = "Img_Logo"
        Me.Img_Logo.Size = New System.Drawing.Size(108, 107)
        Me.Img_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Img_Logo.TabIndex = 19
        Me.Img_Logo.TabStop = False
        '
        'Btn_Save
        '
        Me.Btn_Save.AutoSize = True
        Me.Btn_Save.FlatAppearance.BorderSize = 0
        Me.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Save.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Save.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.75!)
        Me.Btn_Save.ForeColor = System.Drawing.Color.Blue
        Me.Btn_Save.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.Btn_Save.IconColor = System.Drawing.Color.Blue
        Me.Btn_Save.IconSize = 25
        Me.Btn_Save.Location = New System.Drawing.Point(485, 160)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Rotation = 0R
        Me.Btn_Save.Size = New System.Drawing.Size(108, 39)
        Me.Btn_Save.TabIndex = 16
        Me.Btn_Save.Text = " រក្សាទុក"
        Me.Btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 29)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "អាសយដ្ឋាន"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 29)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "លេខទំនាក់ទំនង"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 29)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ឡាតាំង"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ឈ្មោះហាង"
        '
        'Txt_Address
        '
        Me.Txt_Address.Location = New System.Drawing.Point(125, 201)
        Me.Txt_Address.Name = "Txt_Address"
        Me.Txt_Address.Size = New System.Drawing.Size(478, 96)
        Me.Txt_Address.TabIndex = 10
        Me.Txt_Address.Text = ""
        '
        'Txt_Contact2
        '
        Me.Txt_Contact2.Location = New System.Drawing.Point(125, 158)
        Me.Txt_Contact2.Name = "Txt_Contact2"
        Me.Txt_Contact2.Size = New System.Drawing.Size(352, 37)
        Me.Txt_Contact2.TabIndex = 8
        '
        'Txt_Contact1
        '
        Me.Txt_Contact1.Location = New System.Drawing.Point(125, 111)
        Me.Txt_Contact1.Name = "Txt_Contact1"
        Me.Txt_Contact1.Size = New System.Drawing.Size(352, 37)
        Me.Txt_Contact1.TabIndex = 7
        '
        'Txt_NameEN
        '
        Me.Txt_NameEN.Location = New System.Drawing.Point(125, 65)
        Me.Txt_NameEN.Name = "Txt_NameEN"
        Me.Txt_NameEN.Size = New System.Drawing.Size(352, 37)
        Me.Txt_NameEN.TabIndex = 6
        '
        'Txt_NameKH
        '
        Me.Txt_NameKH.Location = New System.Drawing.Point(125, 16)
        Me.Txt_NameKH.Name = "Txt_NameKH"
        Me.Txt_NameKH.Size = New System.Drawing.Size(352, 37)
        Me.Txt_NameKH.TabIndex = 5
        '
        'Frm_Shop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(614, 349)
        Me.Controls.Add(Me.Panel_Contain)
        Me.Controls.Add(Me.Panel_Title)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "Frm_Shop"
        Me.Text = "Frm_Shop"
        Me.Panel_Title.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Contain.ResumeLayout(False)
        Me.Panel_Contain.PerformLayout()
        CType(Me.Img_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel_Title As Panel
    Friend WithEvents Btn_Exit As FontAwesome.Sharp.IconButton
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel_Contain As Panel
    Friend WithEvents Btn_Remove As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Brows As FontAwesome.Sharp.IconButton
    Friend WithEvents Img_Logo As PictureBox
    Friend WithEvents Btn_Save As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Address As RichTextBox
    Friend WithEvents Txt_Contact2 As TextBox
    Friend WithEvents Txt_Contact1 As TextBox
    Friend WithEvents Txt_NameEN As TextBox
    Friend WithEvents Txt_NameKH As TextBox
End Class
