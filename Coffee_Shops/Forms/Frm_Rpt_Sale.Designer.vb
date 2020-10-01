<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Rpt_Sale
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
        Me.Btn_Close = New FontAwesome.Sharp.IconButton()
        Me.CRV_PTCash = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Btn_Close)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 30)
        Me.Panel1.TabIndex = 0
        '
        'Btn_Close
        '
        Me.Btn_Close.FlatAppearance.BorderSize = 0
        Me.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Close.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Btn_Close.ForeColor = System.Drawing.Color.White
        Me.Btn_Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.Btn_Close.IconColor = System.Drawing.Color.White
        Me.Btn_Close.IconSize = 30
        Me.Btn_Close.Location = New System.Drawing.Point(863, -2)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Rotation = 0R
        Me.Btn_Close.Size = New System.Drawing.Size(30, 30)
        Me.Btn_Close.TabIndex = 0
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'CRV_PTCash
        '
        Me.CRV_PTCash.ActiveViewIndex = -1
        Me.CRV_PTCash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CRV_PTCash.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV_PTCash.DisplayStatusBar = False
        Me.CRV_PTCash.DisplayToolbar = False
        Me.CRV_PTCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV_PTCash.Location = New System.Drawing.Point(0, 30)
        Me.CRV_PTCash.Name = "CRV_PTCash"
        Me.CRV_PTCash.Size = New System.Drawing.Size(900, 570)
        Me.CRV_PTCash.TabIndex = 2
        Me.CRV_PTCash.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Frm_Rpt_Sale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.CRV_PTCash)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "Frm_Rpt_Sale"
        Me.Text = "Frm_Rpt_Sale"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Close As FontAwesome.Sharp.IconButton
    Friend WithEvents CRV_PTCash As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
