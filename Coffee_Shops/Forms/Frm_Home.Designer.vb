<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Home
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel_Title = New System.Windows.Forms.Panel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Btn_Close = New FontAwesome.Sharp.IconButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel_Contain = New System.Windows.Forms.Panel()
        Me.Chrt_Category = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel_Title.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Contain.SuspendLayout()
        CType(Me.Chrt_Category, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel_Title.Size = New System.Drawing.Size(884, 40)
        Me.Panel_Title.TabIndex = 24
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
        Me.Btn_Close.Location = New System.Drawing.Point(843, 0)
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
        'Panel_Contain
        '
        Me.Panel_Contain.Controls.Add(Me.Chrt_Category)
        Me.Panel_Contain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Contain.Location = New System.Drawing.Point(0, 40)
        Me.Panel_Contain.Name = "Panel_Contain"
        Me.Panel_Contain.Size = New System.Drawing.Size(884, 556)
        Me.Panel_Contain.TabIndex = 25
        '
        'Chrt_Category
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chrt_Category.ChartAreas.Add(ChartArea1)
        Legend1.Font = New System.Drawing.Font("Khmer OS Siemreap", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.Chrt_Category.Legends.Add(Legend1)
        Me.Chrt_Category.Location = New System.Drawing.Point(12, 6)
        Me.Chrt_Category.Name = "Chrt_Category"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Font = New System.Drawing.Font("Khmer OS Siemreap", 8.75!)
        Series1.IsValueShownAsLabel = True
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chrt_Category.Series.Add(Series1)
        Me.Chrt_Category.Size = New System.Drawing.Size(357, 286)
        Me.Chrt_Category.TabIndex = 26
        Me.Chrt_Category.Text = "ផលិតផលតាមប្រភេទ"
        '
        'Frm_Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(884, 596)
        Me.Controls.Add(Me.Panel_Contain)
        Me.Controls.Add(Me.Panel_Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Home"
        Me.Text = "Frm_Home"
        Me.Panel_Title.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Contain.ResumeLayout(False)
        CType(Me.Chrt_Category, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Title As Panel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Btn_Close As FontAwesome.Sharp.IconButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel_Contain As Panel
    Friend WithEvents Chrt_Category As DataVisualization.Charting.Chart
End Class
