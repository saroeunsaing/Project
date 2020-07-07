<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Payments
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
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.Panel_Title = New System.Windows.Forms.Panel()
        Me.DGV_Data = New System.Windows.Forms.DataGridView()
        Me.Ckb_All = New System.Windows.Forms.CheckBox()
        Me.Ckb_Dialy = New System.Windows.Forms.CheckBox()
        Me.Ckb_Weekly = New System.Windows.Forms.CheckBox()
        Me.Ckb_Monthly = New System.Windows.Forms.CheckBox()
        Me.Ckb_Between = New System.Windows.Forms.CheckBox()
        Me.DTP_Start = New System.Windows.Forms.DateTimePicker()
        Me.DTP_End = New System.Windows.Forms.DateTimePicker()
        Me.Panel_Title.SuspendLayout()
        CType(Me.DGV_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IconButton1
        '
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.ForeColor = System.Drawing.Color.Transparent
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconSize = 22
        Me.IconButton1.Location = New System.Drawing.Point(871, -1)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(31, 28)
        Me.IconButton1.TabIndex = 5
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'IconButton2
        '
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton2.ForeColor = System.Drawing.Color.Transparent
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconSize = 22
        Me.IconButton2.Location = New System.Drawing.Point(903, 0)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Rotation = 0R
        Me.IconButton2.Size = New System.Drawing.Size(31, 28)
        Me.IconButton2.TabIndex = 4
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton3
        '
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton3.ForeColor = System.Drawing.Color.Transparent
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.IconButton3.IconColor = System.Drawing.Color.White
        Me.IconButton3.IconSize = 22
        Me.IconButton3.Location = New System.Drawing.Point(930, 0)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Rotation = 0R
        Me.IconButton3.Size = New System.Drawing.Size(31, 28)
        Me.IconButton3.TabIndex = 3
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.Color.Gray
        Me.Panel_Title.Controls.Add(Me.IconButton1)
        Me.Panel_Title.Controls.Add(Me.IconButton2)
        Me.Panel_Title.Controls.Add(Me.IconButton3)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(969, 31)
        Me.Panel_Title.TabIndex = 21
        '
        'DGV_Data
        '
        Me.DGV_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_Data.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Data.Location = New System.Drawing.Point(12, 116)
        Me.DGV_Data.Name = "DGV_Data"
        Me.DGV_Data.RowHeadersVisible = False
        Me.DGV_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Data.Size = New System.Drawing.Size(945, 383)
        Me.DGV_Data.TabIndex = 22
        '
        'Ckb_All
        '
        Me.Ckb_All.AutoSize = True
        Me.Ckb_All.Location = New System.Drawing.Point(31, 48)
        Me.Ckb_All.Name = "Ckb_All"
        Me.Ckb_All.Size = New System.Drawing.Size(86, 33)
        Me.Ckb_All.TabIndex = 23
        Me.Ckb_All.Text = "ទាំងអស់"
        Me.Ckb_All.UseVisualStyleBackColor = True
        '
        'Ckb_Dialy
        '
        Me.Ckb_Dialy.AutoSize = True
        Me.Ckb_Dialy.Location = New System.Drawing.Point(123, 48)
        Me.Ckb_Dialy.Name = "Ckb_Dialy"
        Me.Ckb_Dialy.Size = New System.Drawing.Size(80, 33)
        Me.Ckb_Dialy.TabIndex = 24
        Me.Ckb_Dialy.Text = "ប្រចាំថ្ងៃ"
        Me.Ckb_Dialy.UseVisualStyleBackColor = True
        '
        'Ckb_Weekly
        '
        Me.Ckb_Weekly.AutoSize = True
        Me.Ckb_Weekly.Location = New System.Drawing.Point(209, 48)
        Me.Ckb_Weekly.Name = "Ckb_Weekly"
        Me.Ckb_Weekly.Size = New System.Drawing.Size(112, 33)
        Me.Ckb_Weekly.TabIndex = 25
        Me.Ckb_Weekly.Text = "ប្រចាំសប្ដាហ៍"
        Me.Ckb_Weekly.UseVisualStyleBackColor = True
        '
        'Ckb_Monthly
        '
        Me.Ckb_Monthly.AutoSize = True
        Me.Ckb_Monthly.Location = New System.Drawing.Point(327, 48)
        Me.Ckb_Monthly.Name = "Ckb_Monthly"
        Me.Ckb_Monthly.Size = New System.Drawing.Size(80, 33)
        Me.Ckb_Monthly.TabIndex = 26
        Me.Ckb_Monthly.Text = "ប្រចាំខែ"
        Me.Ckb_Monthly.UseVisualStyleBackColor = True
        '
        'Ckb_Between
        '
        Me.Ckb_Between.AutoSize = True
        Me.Ckb_Between.Location = New System.Drawing.Point(431, 48)
        Me.Ckb_Between.Name = "Ckb_Between"
        Me.Ckb_Between.Size = New System.Drawing.Size(141, 33)
        Me.Ckb_Between.TabIndex = 27
        Me.Ckb_Between.Text = "ចន្លោះពីថ្ងៃទីខែឆ្នាំ"
        Me.Ckb_Between.UseVisualStyleBackColor = True
        '
        'DTP_Start
        '
        Me.DTP_Start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_Start.Location = New System.Drawing.Point(567, 44)
        Me.DTP_Start.Name = "DTP_Start"
        Me.DTP_Start.Size = New System.Drawing.Size(200, 37)
        Me.DTP_Start.TabIndex = 28
        '
        'DTP_End
        '
        Me.DTP_End.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_End.Location = New System.Drawing.Point(789, 44)
        Me.DTP_End.Name = "DTP_End"
        Me.DTP_End.Size = New System.Drawing.Size(200, 37)
        Me.DTP_End.TabIndex = 29
        '
        'Frm_Payments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(969, 511)
        Me.Controls.Add(Me.DTP_End)
        Me.Controls.Add(Me.DTP_Start)
        Me.Controls.Add(Me.Ckb_Between)
        Me.Controls.Add(Me.Ckb_Monthly)
        Me.Controls.Add(Me.Ckb_Weekly)
        Me.Controls.Add(Me.Ckb_Dialy)
        Me.Controls.Add(Me.Ckb_All)
        Me.Controls.Add(Me.DGV_Data)
        Me.Controls.Add(Me.Panel_Title)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "Frm_Payments"
        Me.Text = "Frm_Payments"
        Me.Panel_Title.ResumeLayout(False)
        CType(Me.DGV_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_Title As Panel
    Friend WithEvents DGV_Data As DataGridView
    Friend WithEvents Ckb_All As CheckBox
    Friend WithEvents Ckb_Dialy As CheckBox
    Friend WithEvents Ckb_Weekly As CheckBox
    Friend WithEvents Ckb_Monthly As CheckBox
    Friend WithEvents Ckb_Between As CheckBox
    Friend WithEvents DTP_Start As DateTimePicker
    Friend WithEvents DTP_End As DateTimePicker
End Class
