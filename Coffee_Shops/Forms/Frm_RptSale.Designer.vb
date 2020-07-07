<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RptSale
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
        Me.CRV_Sale = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(647, 35)
        Me.Panel1.TabIndex = 0
        '
        'CRV_Sale
        '
        Me.CRV_Sale.ActiveViewIndex = -1
        Me.CRV_Sale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV_Sale.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV_Sale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV_Sale.Location = New System.Drawing.Point(0, 35)
        Me.CRV_Sale.Name = "CRV_Sale"
        Me.CRV_Sale.Size = New System.Drawing.Size(647, 714)
        Me.CRV_Sale.TabIndex = 1
        '
        'Frm_RptSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(647, 749)
        Me.Controls.Add(Me.CRV_Sale)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "Frm_RptSale"
        Me.Text = "Frm_RptSale"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CRV_Sale As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
