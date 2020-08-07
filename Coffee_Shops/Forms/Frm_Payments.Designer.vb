<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Payments
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
        Me.Btn_Close = New FontAwesome.Sharp.IconButton()
        Me.Panel_Title = New System.Windows.Forms.Panel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTP_End = New System.Windows.Forms.DateTimePicker()
        Me.DTP_Start = New System.Windows.Forms.DateTimePicker()
        Me.Ckb_Between = New System.Windows.Forms.CheckBox()
        Me.Ckb_Monthly = New System.Windows.Forms.CheckBox()
        Me.Ckb_Weekly = New System.Windows.Forms.CheckBox()
        Me.Ckb_Dialy = New System.Windows.Forms.CheckBox()
        Me.Ckb_All = New System.Windows.Forms.CheckBox()
        Me.DGV_Data = New System.Windows.Forms.DataGridView()
        Me.Panel_Title.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Close
        '
        Me.Btn_Close.FlatAppearance.BorderSize = 0
        Me.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Close.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Close.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.Btn_Close.IconColor = System.Drawing.Color.White
        Me.Btn_Close.IconSize = 22
        Me.Btn_Close.Location = New System.Drawing.Point(866, 2)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Rotation = 0R
        Me.Btn_Close.Size = New System.Drawing.Size(31, 28)
        Me.Btn_Close.TabIndex = 3
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.Color.MediumVioletRed
        Me.Panel_Title.Controls.Add(Me.IconPictureBox1)
        Me.Panel_Title.Controls.Add(Me.Label5)
        Me.Panel_Title.Controls.Add(Me.Btn_Close)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(900, 31)
        Me.Panel_Title.TabIndex = 31
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.Linen
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt
        Me.IconPictureBox1.IconColor = System.Drawing.Color.Linen
        Me.IconPictureBox1.IconSize = 30
        Me.IconPictureBox1.Location = New System.Drawing.Point(2, 1)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconPictureBox1.TabIndex = 29
        Me.IconPictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Khmer OS Muol Light", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(36, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 30)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "ចំណូលចំណាយ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(707, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 29)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "ដល់"
        '
        'DTP_End
        '
        Me.DTP_End.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_End.Location = New System.Drawing.Point(753, 62)
        Me.DTP_End.Name = "DTP_End"
        Me.DTP_End.Size = New System.Drawing.Size(124, 37)
        Me.DTP_End.TabIndex = 39
        '
        'DTP_Start
        '
        Me.DTP_Start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_Start.Location = New System.Drawing.Point(586, 63)
        Me.DTP_Start.Name = "DTP_Start"
        Me.DTP_Start.Size = New System.Drawing.Size(115, 37)
        Me.DTP_Start.TabIndex = 38
        '
        'Ckb_Between
        '
        Me.Ckb_Between.AutoSize = True
        Me.Ckb_Between.Enabled = False
        Me.Ckb_Between.Location = New System.Drawing.Point(428, 67)
        Me.Ckb_Between.Name = "Ckb_Between"
        Me.Ckb_Between.Size = New System.Drawing.Size(141, 33)
        Me.Ckb_Between.TabIndex = 37
        Me.Ckb_Between.Text = "ចន្លោះពីថ្ងៃទីខែឆ្នាំ"
        Me.Ckb_Between.UseVisualStyleBackColor = True
        '
        'Ckb_Monthly
        '
        Me.Ckb_Monthly.AutoSize = True
        Me.Ckb_Monthly.Enabled = False
        Me.Ckb_Monthly.Location = New System.Drawing.Point(324, 67)
        Me.Ckb_Monthly.Name = "Ckb_Monthly"
        Me.Ckb_Monthly.Size = New System.Drawing.Size(80, 33)
        Me.Ckb_Monthly.TabIndex = 36
        Me.Ckb_Monthly.Text = "ប្រចាំខែ"
        Me.Ckb_Monthly.UseVisualStyleBackColor = True
        '
        'Ckb_Weekly
        '
        Me.Ckb_Weekly.AutoSize = True
        Me.Ckb_Weekly.Enabled = False
        Me.Ckb_Weekly.Location = New System.Drawing.Point(206, 67)
        Me.Ckb_Weekly.Name = "Ckb_Weekly"
        Me.Ckb_Weekly.Size = New System.Drawing.Size(112, 33)
        Me.Ckb_Weekly.TabIndex = 35
        Me.Ckb_Weekly.Text = "ប្រចាំសប្ដាហ៍"
        Me.Ckb_Weekly.UseVisualStyleBackColor = True
        '
        'Ckb_Dialy
        '
        Me.Ckb_Dialy.AutoSize = True
        Me.Ckb_Dialy.Enabled = False
        Me.Ckb_Dialy.Location = New System.Drawing.Point(120, 67)
        Me.Ckb_Dialy.Name = "Ckb_Dialy"
        Me.Ckb_Dialy.Size = New System.Drawing.Size(80, 33)
        Me.Ckb_Dialy.TabIndex = 34
        Me.Ckb_Dialy.Text = "ប្រចាំថ្ងៃ"
        Me.Ckb_Dialy.UseVisualStyleBackColor = True
        '
        'Ckb_All
        '
        Me.Ckb_All.AutoSize = True
        Me.Ckb_All.Location = New System.Drawing.Point(28, 67)
        Me.Ckb_All.Name = "Ckb_All"
        Me.Ckb_All.Size = New System.Drawing.Size(86, 33)
        Me.Ckb_All.TabIndex = 33
        Me.Ckb_All.Text = "ទាំងអស់"
        Me.Ckb_All.UseVisualStyleBackColor = True
        '
        'DGV_Data
        '
        Me.DGV_Data.AllowUserToAddRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Data.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_Data.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Data.Location = New System.Drawing.Point(9, 123)
        Me.DGV_Data.Name = "DGV_Data"
        Me.DGV_Data.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Data.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Data.Size = New System.Drawing.Size(879, 465)
        Me.DGV_Data.TabIndex = 32
        '
        'Frm_Payments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.Panel_Title)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTP_End)
        Me.Controls.Add(Me.DTP_Start)
        Me.Controls.Add(Me.Ckb_Between)
        Me.Controls.Add(Me.Ckb_Monthly)
        Me.Controls.Add(Me.Ckb_Weekly)
        Me.Controls.Add(Me.Ckb_Dialy)
        Me.Controls.Add(Me.Ckb_All)
        Me.Controls.Add(Me.DGV_Data)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "Frm_Payments"
        Me.Text = "Frm_Payments"
        Me.Panel_Title.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Close As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_Title As Panel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DTP_End As DateTimePicker
    Friend WithEvents DTP_Start As DateTimePicker
    Friend WithEvents Ckb_Between As CheckBox
    Friend WithEvents Ckb_Monthly As CheckBox
    Friend WithEvents Ckb_Weekly As CheckBox
    Friend WithEvents Ckb_Dialy As CheckBox
    Friend WithEvents Ckb_All As CheckBox
    Friend WithEvents DGV_Data As DataGridView
End Class
