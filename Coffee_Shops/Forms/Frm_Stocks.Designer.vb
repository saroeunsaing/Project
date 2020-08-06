<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Stocks
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel_Title = New System.Windows.Forms.Panel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Btn_Close = New FontAwesome.Sharp.IconButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel_Stock = New System.Windows.Forms.Panel()
        Me.Cmb_Scale = New System.Windows.Forms.ComboBox()
        Me.Txt_Total = New System.Windows.Forms.TextBox()
        Me.Txt_Purchase = New System.Windows.Forms.TextBox()
        Me.Txt_Sale = New System.Windows.Forms.TextBox()
        Me.Txt_Amount = New System.Windows.Forms.TextBox()
        Me.Btn_Delete = New FontAwesome.Sharp.IconButton()
        Me.Btn_Edit = New FontAwesome.Sharp.IconButton()
        Me.Btn_Save = New FontAwesome.Sharp.IconButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DTP_Purchase = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV_Data = New System.Windows.Forms.DataGridView()
        Me.Cmb_ProductName = New System.Windows.Forms.ComboBox()
        Me.Txt_ProductCode = New System.Windows.Forms.TextBox()
        Me.Panel_Title.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Stock.SuspendLayout()
        CType(Me.DGV_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Title.Controls.Add(Me.IconPictureBox1)
        Me.Panel_Title.Controls.Add(Me.Btn_Close)
        Me.Panel_Title.Controls.Add(Me.Label5)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(900, 40)
        Me.Panel_Title.TabIndex = 23
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.Linen
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ProductHunt
        Me.IconPictureBox1.IconColor = System.Drawing.Color.Linen
        Me.IconPictureBox1.Location = New System.Drawing.Point(3, 3)
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
        Me.Btn_Close.IconColor = System.Drawing.Color.Red
        Me.Btn_Close.IconSize = 22
        Me.Btn_Close.Location = New System.Drawing.Point(859, 0)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Rotation = 0R
        Me.Btn_Close.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Close.TabIndex = 27
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Khmer OS Muol Light", 12.25!)
        Me.Label5.ForeColor = System.Drawing.Color.SeaShell
        Me.Label5.Location = New System.Drawing.Point(43, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(351, 37)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "គ្រប់គ្រងស្ដុកទំនិញ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_Stock
        '
        Me.Panel_Stock.Controls.Add(Me.Cmb_Scale)
        Me.Panel_Stock.Controls.Add(Me.Txt_Total)
        Me.Panel_Stock.Controls.Add(Me.Txt_Purchase)
        Me.Panel_Stock.Controls.Add(Me.Txt_Sale)
        Me.Panel_Stock.Controls.Add(Me.Txt_Amount)
        Me.Panel_Stock.Controls.Add(Me.Btn_Delete)
        Me.Panel_Stock.Controls.Add(Me.Btn_Edit)
        Me.Panel_Stock.Controls.Add(Me.Btn_Save)
        Me.Panel_Stock.Controls.Add(Me.Label7)
        Me.Panel_Stock.Controls.Add(Me.DTP_Purchase)
        Me.Panel_Stock.Controls.Add(Me.Label8)
        Me.Panel_Stock.Controls.Add(Me.Label6)
        Me.Panel_Stock.Controls.Add(Me.Label4)
        Me.Panel_Stock.Controls.Add(Me.Label3)
        Me.Panel_Stock.Controls.Add(Me.Label2)
        Me.Panel_Stock.Controls.Add(Me.Label1)
        Me.Panel_Stock.Controls.Add(Me.DGV_Data)
        Me.Panel_Stock.Controls.Add(Me.Cmb_ProductName)
        Me.Panel_Stock.Controls.Add(Me.Txt_ProductCode)
        Me.Panel_Stock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Stock.Location = New System.Drawing.Point(0, 40)
        Me.Panel_Stock.Name = "Panel_Stock"
        Me.Panel_Stock.Size = New System.Drawing.Size(900, 595)
        Me.Panel_Stock.TabIndex = 24
        '
        'Cmb_Scale
        '
        Me.Cmb_Scale.FormattingEnabled = True
        Me.Cmb_Scale.Items.AddRange(New Object() {"បន្ថែមថ្មី"})
        Me.Cmb_Scale.Location = New System.Drawing.Point(306, 63)
        Me.Cmb_Scale.Name = "Cmb_Scale"
        Me.Cmb_Scale.Size = New System.Drawing.Size(97, 37)
        Me.Cmb_Scale.TabIndex = 67
        '
        'Txt_Total
        '
        Me.Txt_Total.Location = New System.Drawing.Point(647, 117)
        Me.Txt_Total.Name = "Txt_Total"
        Me.Txt_Total.Size = New System.Drawing.Size(226, 37)
        Me.Txt_Total.TabIndex = 66
        '
        'Txt_Purchase
        '
        Me.Txt_Purchase.Location = New System.Drawing.Point(647, 66)
        Me.Txt_Purchase.Name = "Txt_Purchase"
        Me.Txt_Purchase.Size = New System.Drawing.Size(226, 37)
        Me.Txt_Purchase.TabIndex = 65
        Me.Txt_Purchase.Text = "0"
        '
        'Txt_Sale
        '
        Me.Txt_Sale.Location = New System.Drawing.Point(173, 114)
        Me.Txt_Sale.Name = "Txt_Sale"
        Me.Txt_Sale.Size = New System.Drawing.Size(230, 37)
        Me.Txt_Sale.TabIndex = 64
        Me.Txt_Sale.Text = "0"
        '
        'Txt_Amount
        '
        Me.Txt_Amount.Location = New System.Drawing.Point(173, 63)
        Me.Txt_Amount.Name = "Txt_Amount"
        Me.Txt_Amount.Size = New System.Drawing.Size(130, 37)
        Me.Txt_Amount.TabIndex = 60
        '
        'Btn_Delete
        '
        Me.Btn_Delete.FlatAppearance.BorderSize = 0
        Me.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Delete.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Delete.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!)
        Me.Btn_Delete.ForeColor = System.Drawing.Color.White
        Me.Btn_Delete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.Btn_Delete.IconColor = System.Drawing.Color.Red
        Me.Btn_Delete.IconSize = 20
        Me.Btn_Delete.Location = New System.Drawing.Point(813, 165)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Rotation = 0R
        Me.Btn_Delete.Size = New System.Drawing.Size(75, 37)
        Me.Btn_Delete.TabIndex = 59
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
        Me.Btn_Edit.ForeColor = System.Drawing.Color.White
        Me.Btn_Edit.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.Btn_Edit.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Edit.IconSize = 20
        Me.Btn_Edit.Location = New System.Drawing.Point(706, 165)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Rotation = 0R
        Me.Btn_Edit.Size = New System.Drawing.Size(110, 37)
        Me.Btn_Edit.TabIndex = 58
        Me.Btn_Edit.Text = "ដកស្ដុក"
        Me.Btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Edit.UseVisualStyleBackColor = True
        '
        'Btn_Save
        '
        Me.Btn_Save.FlatAppearance.BorderSize = 0
        Me.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Save.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Save.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!)
        Me.Btn_Save.ForeColor = System.Drawing.Color.White
        Me.Btn_Save.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.Btn_Save.IconColor = System.Drawing.Color.Blue
        Me.Btn_Save.IconSize = 20
        Me.Btn_Save.Location = New System.Drawing.Point(604, 165)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Rotation = 0R
        Me.Btn_Save.Size = New System.Drawing.Size(96, 37)
        Me.Btn_Save.TabIndex = 57
        Me.Btn_Save.Text = " រក្សាទុក"
        Me.Btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(15, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 29)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "ថ្ងៃទីខែឆ្នាំ បញ្ចាទិញ"
        '
        'DTP_Purchase
        '
        Me.DTP_Purchase.CustomFormat = "dd-MMMM-yyyy"
        Me.DTP_Purchase.Font = New System.Drawing.Font("Khmer OS Siemreap", 10.0!)
        Me.DTP_Purchase.Location = New System.Drawing.Point(173, 167)
        Me.DTP_Purchase.Name = "DTP_Purchase"
        Me.DTP_Purchase.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DTP_Purchase.Size = New System.Drawing.Size(230, 32)
        Me.DTP_Purchase.TabIndex = 55
        Me.DTP_Purchase.Value = New Date(2020, 5, 15, 21, 36, 41, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(506, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 29)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "តម្លៃបញ្ចាទិញ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 29)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "តម្លៃលក់ចេញ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(506, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 29)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "សរុបតម្លៃបញ្ចាទិញ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(15, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 29)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "បញ្ចាទិញ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(506, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 29)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "ឈ្មោះទំនិញ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 29)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "លេខកូដទំនិញ"
        '
        'DGV_Data
        '
        Me.DGV_Data.AllowUserToAddRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Khmer OS Siemreap", 8.0!)
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
        Me.DGV_Data.Location = New System.Drawing.Point(8, 220)
        Me.DGV_Data.Name = "DGV_Data"
        Me.DGV_Data.RightToLeft = System.Windows.Forms.RightToLeft.No
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
        Me.DGV_Data.Size = New System.Drawing.Size(885, 368)
        Me.DGV_Data.TabIndex = 42
        '
        'Cmb_ProductName
        '
        Me.Cmb_ProductName.FormattingEnabled = True
        Me.Cmb_ProductName.Location = New System.Drawing.Point(647, 20)
        Me.Cmb_ProductName.Name = "Cmb_ProductName"
        Me.Cmb_ProductName.Size = New System.Drawing.Size(226, 37)
        Me.Cmb_ProductName.TabIndex = 41
        '
        'Txt_ProductCode
        '
        Me.Txt_ProductCode.Location = New System.Drawing.Point(173, 17)
        Me.Txt_ProductCode.Name = "Txt_ProductCode"
        Me.Txt_ProductCode.Size = New System.Drawing.Size(230, 37)
        Me.Txt_ProductCode.TabIndex = 40
        '
        'Frm_Stocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(900, 635)
        Me.Controls.Add(Me.Panel_Stock)
        Me.Controls.Add(Me.Panel_Title)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Frm_Stocks"
        Me.Text = "Frm_Stocks"
        Me.Panel_Title.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Stock.ResumeLayout(False)
        Me.Panel_Stock.PerformLayout()
        CType(Me.DGV_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Title As Panel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Btn_Close As FontAwesome.Sharp.IconButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel_Stock As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGV_Data As DataGridView
    Friend WithEvents Cmb_ProductName As ComboBox
    Friend WithEvents Txt_ProductCode As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DTP_Purchase As DateTimePicker
    Friend WithEvents Btn_Delete As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Edit As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Save As FontAwesome.Sharp.IconButton
    Friend WithEvents Txt_Amount As TextBox
    Friend WithEvents Txt_Sale As TextBox
    Friend WithEvents Txt_Total As TextBox
    Friend WithEvents Txt_Purchase As TextBox
    Friend WithEvents Cmb_Scale As ComboBox
End Class
