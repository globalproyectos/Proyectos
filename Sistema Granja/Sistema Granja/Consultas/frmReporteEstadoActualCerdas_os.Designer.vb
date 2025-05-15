<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteEstadoActualCerdas_os
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteEstadoActualCerdas_os))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.EstadosComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.desdeIntegerInput1 = New DevComponents.Editors.IntegerInput()
        Me.hastaIntegerInput2 = New DevComponents.Editors.IntegerInput()
        Me.hastaLabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.desdeIntegerInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hastaIntegerInput2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 55)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(929, 453)
        Me.CrystalReportViewer1.TabIndex = 5
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.hastaLabelX3)
        Me.GroupPanel1.Controls.Add(Me.hastaIntegerInput2)
        Me.GroupPanel1.Controls.Add(Me.desdeIntegerInput1)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.EstadosComboBoxEx1)
        Me.GroupPanel1.Controls.Add(Me.ButtonX1)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(929, 55)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 4
        Me.GroupPanel1.Text = "Filtros"
        Me.GroupPanel1.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Center
        '
        'EstadosComboBoxEx1
        '
        Me.EstadosComboBoxEx1.DisplayMember = "Text"
        Me.EstadosComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.EstadosComboBoxEx1.FormattingEnabled = True
        Me.EstadosComboBoxEx1.ItemHeight = 14
        Me.EstadosComboBoxEx1.Location = New System.Drawing.Point(61, 3)
        Me.EstadosComboBoxEx1.Name = "EstadosComboBoxEx1"
        Me.EstadosComboBoxEx1.Size = New System.Drawing.Size(114, 20)
        Me.EstadosComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.EstadosComboBoxEx1.TabIndex = 11
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.Sistema_Granja.My.Resources.Resources.file_viewer_plus
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(15, 15)
        Me.ButtonX1.Location = New System.Drawing.Point(437, 3)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(92, 20)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 10
        Me.ButtonX1.Text = "Generar"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(16, 0)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(39, 23)
        Me.LabelX1.TabIndex = 3
        Me.LabelX1.Text = "Estado:"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(181, 0)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(94, 23)
        Me.LabelX2.TabIndex = 12
        Me.LabelX2.Text = "Rango por Parto:"
        '
        'desdeIntegerInput1
        '
        '
        '
        '
        Me.desdeIntegerInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.desdeIntegerInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.desdeIntegerInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.desdeIntegerInput1.Location = New System.Drawing.Point(272, 3)
        Me.desdeIntegerInput1.MaxValue = 90
        Me.desdeIntegerInput1.MinValue = 0
        Me.desdeIntegerInput1.Name = "desdeIntegerInput1"
        Me.desdeIntegerInput1.ShowUpDown = True
        Me.desdeIntegerInput1.Size = New System.Drawing.Size(56, 20)
        Me.desdeIntegerInput1.TabIndex = 13
        '
        'hastaIntegerInput2
        '
        '
        '
        '
        Me.hastaIntegerInput2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.hastaIntegerInput2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.hastaIntegerInput2.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.hastaIntegerInput2.Location = New System.Drawing.Point(374, 3)
        Me.hastaIntegerInput2.MaxValue = 90
        Me.hastaIntegerInput2.MinValue = 0
        Me.hastaIntegerInput2.Name = "hastaIntegerInput2"
        Me.hastaIntegerInput2.ShowUpDown = True
        Me.hastaIntegerInput2.Size = New System.Drawing.Size(57, 20)
        Me.hastaIntegerInput2.TabIndex = 14
        '
        'hastaLabelX3
        '
        Me.hastaLabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.hastaLabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.hastaLabelX3.Location = New System.Drawing.Point(334, 0)
        Me.hastaLabelX3.Name = "hastaLabelX3"
        Me.hastaLabelX3.Size = New System.Drawing.Size(38, 23)
        Me.hastaLabelX3.TabIndex = 15
        Me.hastaLabelX3.Text = "Hasta:"
        '
        'frmReporteEstadoActualCerdas_os
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 508)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReporteEstadoActualCerdas_os"
        Me.Text = "Reporte Estado Actual Cerdas(as)"
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.desdeIntegerInput1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hastaIntegerInput2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents EstadosComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents hastaLabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents hastaIntegerInput2 As DevComponents.Editors.IntegerInput
    Friend WithEvents desdeIntegerInput1 As DevComponents.Editors.IntegerInput
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
End Class
