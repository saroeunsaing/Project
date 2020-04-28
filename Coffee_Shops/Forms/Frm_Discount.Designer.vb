<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Discount
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
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel_Title = New System.Windows.Forms.Panel()
        Me.Panel_Title.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 167)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(413, 26)
        Me.Panel1.TabIndex = 20
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
        Me.IconButton3.Location = New System.Drawing.Point(380, 3)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Rotation = 0R
        Me.IconButton3.Size = New System.Drawing.Size(31, 28)
        Me.IconButton3.TabIndex = 3
        Me.IconButton3.UseVisualStyleBackColor = True
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
        Me.IconButton2.Location = New System.Drawing.Point(353, 3)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Rotation = 0R
        Me.IconButton2.Size = New System.Drawing.Size(31, 28)
        Me.IconButton2.TabIndex = 4
        Me.IconButton2.UseVisualStyleBackColor = True
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
        Me.IconButton1.Location = New System.Drawing.Point(321, -3)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(31, 28)
        Me.IconButton1.TabIndex = 5
        Me.IconButton1.UseVisualStyleBackColor = True
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
        Me.Panel_Title.Size = New System.Drawing.Size(413, 31)
        Me.Panel_Title.TabIndex = 3
        '
        'Frm_Discount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(413, 193)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel_Title)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "Frm_Discount"
        Me.Text = "Frm_Discount"
        Me.Panel_Title.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_Title As Panel
End Class
