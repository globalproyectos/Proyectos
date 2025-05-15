<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDXVisorDashboard
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DashboardViewer1 = New DevExpress.DashboardWin.DashboardViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AbrirReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DashboardViewer1
        '
        Me.DashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardViewer1.Location = New System.Drawing.Point(0, 45)
        Me.DashboardViewer1.Name = "DashboardViewer1"
        Me.DashboardViewer1.PrintingOptions.DocumentContentOptions.FilterState = DevExpress.DashboardWin.DashboardPrintingFilterState.None
        Me.DashboardViewer1.PrintingOptions.FontInfo.GdiCharSet = CType(0, Byte)
        Me.DashboardViewer1.PrintingOptions.FontInfo.Name = Nothing
        Me.DashboardViewer1.Size = New System.Drawing.Size(686, 347)
        Me.DashboardViewer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(686, 45)
        Me.Panel1.TabIndex = 1
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirReporteToolStripMenuItem, Me.RecientesToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(686, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AbrirReporteToolStripMenuItem
        '
        Me.AbrirReporteToolStripMenuItem.Name = "AbrirReporteToolStripMenuItem"
        Me.AbrirReporteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AbrirReporteToolStripMenuItem.Text = "Abrir reporte"
        '
        'RecientesToolStripMenuItem
        '
        Me.RecientesToolStripMenuItem.Name = "RecientesToolStripMenuItem"
        Me.RecientesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RecientesToolStripMenuItem.Text = "Recientes"
        '
        'frmDXVisorDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 392)
        Me.Controls.Add(Me.DashboardViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDXVisorDashboard"
        Me.Text = "frmDXVisorDashboard"
        CType(Me.DashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirReporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
