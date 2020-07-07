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
        Me.CRV_Sales = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(609, 32)
        Me.Panel1.TabIndex = 0
        '
        'CRV_Sales
        '
        Me.CRV_Sales.ActiveViewIndex = -1
        Me.CRV_Sales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CRV_Sales.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV_Sales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV_Sales.Location = New System.Drawing.Point(0, 32)
        Me.CRV_Sales.Name = "CRV_Sales"
        Me.CRV_Sales.Size = New System.Drawing.Size(609, 531)
        Me.CRV_Sales.TabIndex = 1
        '
        'Frm_Rpt_Sale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.ClientSize = New System.Drawing.Size(609, 563)
        Me.Controls.Add(Me.CRV_Sales)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "Frm_Rpt_Sale"
        Me.Text = "Frm_Rpt_Sale"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CRV_Sales As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
