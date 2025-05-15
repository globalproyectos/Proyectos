<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecalcular_x_FechaInicio
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
        Me.BW = New System.ComponentModel.BackgroundWorker
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.lbEstatus = New DevComponents.DotNetBar.LabelX
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.MaskedTextBoxAdv1 = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BW
        '
        Me.BW.WorkerReportsProgress = True
        Me.BW.WorkerSupportsCancellation = True
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.lbEstatus)
        Me.PanelEx1.Controls.Add(Me.ProgressBar1)
        Me.PanelEx1.Controls.Add(Me.ButtonX1)
        Me.PanelEx1.Controls.Add(Me.MaskedTextBoxAdv1)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(309, 59)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'lbEstatus
        '
        '
        '
        '
        Me.lbEstatus.BackgroundStyle.Class = ""
        Me.lbEstatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbEstatus.Location = New System.Drawing.Point(12, 53)
        Me.lbEstatus.Name = "lbEstatus"
        Me.lbEstatus.Size = New System.Drawing.Size(285, 23)
        Me.lbEstatus.TabIndex = 4
        Me.lbEstatus.Text = "Iniciando..."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 82)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(285, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.CallBasePaintBackground = True
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(164, 22)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(125, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 2
        Me.ButtonX1.Text = "&Iniciar"
        '
        'MaskedTextBoxAdv1
        '
        '
        '
        '
        Me.MaskedTextBoxAdv1.BackgroundStyle.Class = "TextBoxBorder"
        Me.MaskedTextBoxAdv1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MaskedTextBoxAdv1.ButtonClear.Visible = True
        Me.MaskedTextBoxAdv1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.MaskedTextBoxAdv1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.MaskedTextBoxAdv1.Location = New System.Drawing.Point(80, 25)
        Me.MaskedTextBoxAdv1.Mask = "00/00/00"
        Me.MaskedTextBoxAdv1.Name = "MaskedTextBoxAdv1"
        Me.MaskedTextBoxAdv1.Size = New System.Drawing.Size(78, 20)
        Me.MaskedTextBoxAdv1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MaskedTextBoxAdv1.TabIndex = 1
        Me.MaskedTextBoxAdv1.Text = ""
        Me.MaskedTextBoxAdv1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaskedTextBoxAdv1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 22)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Fecha Inicio:"
        '
        'frmRecalcular_x_FechaInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 59)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(325, 152)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(325, 97)
        Me.Name = "frmRecalcular_x_FechaInicio"
        Me.Text = "Recalcular x Fecha Inicio"
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BW As System.ComponentModel.BackgroundWorker
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents MaskedTextBoxAdv1 As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lbEstatus As DevComponents.DotNetBar.LabelX
End Class
