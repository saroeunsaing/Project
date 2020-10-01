<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Home
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.Btn_Close = New FontAwesome.Sharp.IconButton()
        Me.Panel_Title = New System.Windows.Forms.Panel()
        Me.Panel_Stock = New System.Windows.Forms.Panel()
        Me.Chrt_Period = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chrt_Category = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel_Title.SuspendLayout()
        Me.Panel_Stock.SuspendLayout()
        CType(Me.Chrt_Period, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chrt_Category, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Title.Controls.Add(Me.Btn_Close)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(900, 40)
        Me.Panel_Title.TabIndex = 25
        '
        'Panel_Stock
        '
        Me.Panel_Stock.Controls.Add(Me.Chrt_Period)
        Me.Panel_Stock.Controls.Add(Me.Chrt_Category)
        Me.Panel_Stock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Stock.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Stock.Name = "Panel_Stock"
        Me.Panel_Stock.Size = New System.Drawing.Size(900, 600)
        Me.Panel_Stock.TabIndex = 26
        '
        'Chrt_Period
        '
        ChartArea1.AxisX.MaximumAutoSize = 50.0!
        ChartArea1.Name = "ChartArea1"
        Me.Chrt_Period.ChartAreas.Add(ChartArea1)
        Legend1.DockedToChartArea = "ChartArea1"
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left
        Legend1.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Legend1.TitleFont = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chrt_Period.Legends.Add(Legend1)
        Me.Chrt_Period.Location = New System.Drawing.Point(463, 47)
        Me.Chrt_Period.Name = "Chrt_Period"
        Series1.ChartArea = "ChartArea1"
        Series1.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!)
        Series1.IsValueShownAsLabel = True
        Series1.IsXValueIndexed = True
        Series1.Legend = "Legend1"
        Series1.Name = "តម្លៃលក់សរុប"
        Series2.ChartArea = "ChartArea1"
        Series2.IsValueShownAsLabel = True
        Series2.IsXValueIndexed = True
        Series2.Legend = "Legend1"
        Series2.Name = "មុខទំនិញសរុប"
        Me.Chrt_Period.Series.Add(Series1)
        Me.Chrt_Period.Series.Add(Series2)
        Me.Chrt_Period.Size = New System.Drawing.Size(434, 327)
        Me.Chrt_Period.TabIndex = 1
        Me.Chrt_Period.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.75!)
        Title1.Name = "Title1"
        Title1.Text = "ស្ថិតិការលក់ប្រចាំថ្ងៃក្នុងសប្ដាហ៍"
        Me.Chrt_Period.Titles.Add(Title1)
        '
        'Chrt_Category
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chrt_Category.ChartAreas.Add(ChartArea2)
        Legend2.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Me.Chrt_Category.Legends.Add(Legend2)
        Me.Chrt_Category.Location = New System.Drawing.Point(15, 46)
        Me.Chrt_Category.Name = "Chrt_Category"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series3.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!)
        Series3.IsValueShownAsLabel = True
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chrt_Category.Series.Add(Series3)
        Me.Chrt_Category.Size = New System.Drawing.Size(434, 327)
        Me.Chrt_Category.TabIndex = 0
        Me.Chrt_Category.Text = "Chart1"
        Title2.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.75!)
        Title2.Name = "Title1"
        Title2.Text = "ស្ថិតិមុខទំនិញតាមប្រភេទនីមួយៗ"
        Me.Chrt_Category.Titles.Add(Title2)
        '
        'Frm_Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.Panel_Title)
        Me.Controls.Add(Me.Panel_Stock)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "Frm_Home"
        Me.Text = "Frm_Home"
        Me.Panel_Title.ResumeLayout(False)
        Me.Panel_Stock.ResumeLayout(False)
        CType(Me.Chrt_Period, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chrt_Category, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Close As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_Title As Panel
    Friend WithEvents Panel_Stock As Panel
    Friend WithEvents Chrt_Category As DataVisualization.Charting.Chart
    Friend WithEvents Chrt_Period As DataVisualization.Charting.Chart
End Class
