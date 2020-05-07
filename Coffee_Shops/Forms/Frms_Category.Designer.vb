<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frms_Category
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
        Me.Btn_Delete = New FontAwesome.Sharp.IconButton()
        Me.Btn_Save = New FontAwesome.Sharp.IconButton()
        Me.Btn_Close = New FontAwesome.Sharp.IconButton()
        Me.Txt_TitleEN = New System.Windows.Forms.TextBox()
        Me.Txt_TitleKh = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.ForeColor = System.Drawing.Color.Transparent
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.IconButton1.IconColor = System.Drawing.Color.DimGray
        Me.IconButton1.IconSize = 22
        Me.IconButton1.Location = New System.Drawing.Point(264, -254)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(40, 40)
        Me.IconButton1.TabIndex = 39
        Me.IconButton1.UseVisualStyleBackColor = True
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
        Me.Btn_Delete.Location = New System.Drawing.Point(322, 75)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Rotation = 0R
        Me.Btn_Delete.Size = New System.Drawing.Size(28, 37)
        Me.Btn_Delete.TabIndex = 38
        Me.Btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Btn_Save
        '
        Me.Btn_Save.FlatAppearance.BorderSize = 0
        Me.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Save.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Save.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Save.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Save.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.Btn_Save.IconColor = System.Drawing.Color.Blue
        Me.Btn_Save.IconSize = 20
        Me.Btn_Save.Location = New System.Drawing.Point(291, 75)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Rotation = 0R
        Me.Btn_Save.Size = New System.Drawing.Size(27, 37)
        Me.Btn_Save.TabIndex = 37
        Me.Btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Btn_Close
        '
        Me.Btn_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Close.FlatAppearance.BorderSize = 0
        Me.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Close.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Close.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.Btn_Close.IconColor = System.Drawing.Color.DimGray
        Me.Btn_Close.IconSize = 22
        Me.Btn_Close.Location = New System.Drawing.Point(321, 0)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Rotation = 0R
        Me.Btn_Close.Size = New System.Drawing.Size(28, 31)
        Me.Btn_Close.TabIndex = 36
        Me.Btn_Close.UseVisualStyleBackColor = False
        '
        'Txt_TitleEN
        '
        Me.Txt_TitleEN.Location = New System.Drawing.Point(69, 74)
        Me.Txt_TitleEN.Name = "Txt_TitleEN"
        Me.Txt_TitleEN.Size = New System.Drawing.Size(216, 37)
        Me.Txt_TitleEN.TabIndex = 35
        '
        'Txt_TitleKh
        '
        Me.Txt_TitleKh.Location = New System.Drawing.Point(69, 31)
        Me.Txt_TitleKh.Name = "Txt_TitleKh"
        Me.Txt_TitleKh.Size = New System.Drawing.Size(281, 37)
        Me.Txt_TitleKh.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 29)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "ឡាតាំង"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 29)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "ប្រភេទ"
        '
        'Frms_Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(358, 123)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.Btn_Delete)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Txt_TitleEN)
        Me.Controls.Add(Me.Txt_TitleKh)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "Frms_Category"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frms_Category"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Delete As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Save As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Close As FontAwesome.Sharp.IconButton
    Friend WithEvents Txt_TitleEN As TextBox
    Friend WithEvents Txt_TitleKh As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
