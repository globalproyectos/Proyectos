<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFechayHora
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFechayHora))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.MonthCalendarAdv1 = New DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
        Me.RibbonClientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.ButtonX2)
        Me.RibbonClientPanel1.Controls.Add(Me.ButtonX1)
        Me.RibbonClientPanel1.Controls.Add(Me.MonthCalendarAdv1)
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonClientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonClientPanel1.Name = "RibbonClientPanel1"
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(176, 152)
        '
        '
        '
        Me.RibbonClientPanel1.Style.Class = "RibbonClientPanel"
        Me.RibbonClientPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonClientPanel1.StyleMouseDown.Class = ""
        Me.RibbonClientPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonClientPanel1.StyleMouseOver.Class = ""
        Me.RibbonClientPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonClientPanel1.TabIndex = 0
        Me.RibbonClientPanel1.Text = "RibbonClientPanel1"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.CallBasePaintBackground = True
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(101, 131)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 2
        Me.ButtonX2.Text = "C&errar"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.CallBasePaintBackground = True
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(6, 131)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 1
        Me.ButtonX1.Text = "&Cambiar"
        '
        'MonthCalendarAdv1
        '
        Me.MonthCalendarAdv1.AnnuallyMarkedDates = New Date(-1) {}
        Me.MonthCalendarAdv1.AutoSize = True
        '
        '
        '
        Me.MonthCalendarAdv1.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.MonthCalendarAdv1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MonthCalendarAdv1.BackgroundStyle.BorderBottomWidth = 1
        Me.MonthCalendarAdv1.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MonthCalendarAdv1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MonthCalendarAdv1.BackgroundStyle.BorderLeftWidth = 1
        Me.MonthCalendarAdv1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MonthCalendarAdv1.BackgroundStyle.BorderRightWidth = 1
        Me.MonthCalendarAdv1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MonthCalendarAdv1.BackgroundStyle.BorderTopWidth = 1
        Me.MonthCalendarAdv1.BackgroundStyle.Class = ""
        Me.MonthCalendarAdv1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MonthCalendarAdv1.CommandsBackgroundStyle.Class = ""
        Me.MonthCalendarAdv1.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MonthCalendarAdv1.ContainerControlProcessDialogKey = True
        Me.MonthCalendarAdv1.DisplayMonth = New Date(2011, 1, 1, 0, 0, 0, 0)
        Me.MonthCalendarAdv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendarAdv1.Location = New System.Drawing.Point(6, 3)
        Me.MonthCalendarAdv1.MarkedDates = New Date(-1) {}
        Me.MonthCalendarAdv1.MonthlyMarkedDates = New Date(-1) {}
        Me.MonthCalendarAdv1.Name = "MonthCalendarAdv1"
        '
        '
        '
        Me.MonthCalendarAdv1.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.MonthCalendarAdv1.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.MonthCalendarAdv1.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.MonthCalendarAdv1.NavigationBackgroundStyle.Class = ""
        Me.MonthCalendarAdv1.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MonthCalendarAdv1.Size = New System.Drawing.Size(170, 128)
        Me.MonthCalendarAdv1.TabIndex = 0
        Me.MonthCalendarAdv1.Text = "MonthCalendarAdv1"
        Me.MonthCalendarAdv1.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        '
        'frmFechayHora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(176, 152)
        Me.ControlBox = False
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(192, 191)
        Me.MinimumSize = New System.Drawing.Size(192, 191)
        Me.Name = "frmFechayHora"
        Me.Text = "..::Fecha y Hora::.."
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.RibbonClientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents MonthCalendarAdv1 As DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
End Class
