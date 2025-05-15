<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRepConsolidadoExistencias
    Inherits DevComponents.DotNetBar.OfficeForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepConsolidadoExistencias))
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.descripionTextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.codigoTextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.bodegasComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.hastaDateTimeInput2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.desdeDateTimeInput1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.PivotGridField7 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.RepConsumoSemEngordeTableAdapter = New Sistema_Granja.dtsInventarioTableAdapters.RepConsumoSemEngordeTableAdapter()
        Me.RepConsumoSemEngordeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsInventario = New Sistema_Granja.dtsInventario()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.hastaDateTimeInput2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.desdeDateTimeInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx3.SuspendLayout()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepConsumoSemEngordeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.Caption = "Bodega Desc"
        Me.PivotGridField1.FieldName = "bodegaDescripcion"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.descripionTextBoxX2)
        Me.GroupPanel1.Controls.Add(Me.codigoTextBoxX1)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.bodegasComboBoxEx1)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.ButtonX1)
        Me.GroupPanel1.Controls.Add(Me.hastaDateTimeInput2)
        Me.GroupPanel1.Controls.Add(Me.desdeDateTimeInput1)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(921, 133)
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
        Me.GroupPanel1.TabIndex = 2
        Me.GroupPanel1.Text = "Filtros"
        '
        'descripionTextBoxX2
        '
        Me.descripionTextBoxX2.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.descripionTextBoxX2.Border.Class = "TextBoxBorder"
        Me.descripionTextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.descripionTextBoxX2.Enabled = False
        Me.descripionTextBoxX2.Location = New System.Drawing.Point(186, 75)
        Me.descripionTextBoxX2.Name = "descripionTextBoxX2"
        Me.descripionTextBoxX2.PreventEnterBeep = True
        Me.descripionTextBoxX2.Size = New System.Drawing.Size(270, 20)
        Me.descripionTextBoxX2.TabIndex = 9
        '
        'codigoTextBoxX1
        '
        '
        '
        '
        Me.codigoTextBoxX1.Border.Class = "TextBoxBorder"
        Me.codigoTextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.codigoTextBoxX1.Location = New System.Drawing.Point(88, 75)
        Me.codigoTextBoxX1.Name = "codigoTextBoxX1"
        Me.codigoTextBoxX1.PreventEnterBeep = True
        Me.codigoTextBoxX1.Size = New System.Drawing.Size(95, 20)
        Me.codigoTextBoxX1.TabIndex = 8
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(36, 75)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(50, 23)
        Me.LabelX4.TabIndex = 7
        Me.LabelX4.Text = "Código:"
        '
        'bodegasComboBoxEx1
        '
        Me.bodegasComboBoxEx1.DisplayMember = "Text"
        Me.bodegasComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.bodegasComboBoxEx1.FormattingEnabled = True
        Me.bodegasComboBoxEx1.ItemHeight = 14
        Me.bodegasComboBoxEx1.Location = New System.Drawing.Point(88, 47)
        Me.bodegasComboBoxEx1.Name = "bodegasComboBoxEx1"
        Me.bodegasComboBoxEx1.Size = New System.Drawing.Size(282, 20)
        Me.bodegasComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.bodegasComboBoxEx1.TabIndex = 6
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(36, 46)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(50, 23)
        Me.LabelX3.TabIndex = 5
        Me.LabelX3.Text = "Bodega:"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(381, 17)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 50)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 4
        Me.ButtonX1.Text = "&Mostrar"
        '
        'hastaDateTimeInput2
        '
        Me.hastaDateTimeInput2.AutoAdvance = True
        '
        '
        '
        Me.hastaDateTimeInput2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.hastaDateTimeInput2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.hastaDateTimeInput2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.hastaDateTimeInput2.ButtonDropDown.Visible = True
        Me.hastaDateTimeInput2.IsPopupCalendarOpen = False
        Me.hastaDateTimeInput2.Location = New System.Drawing.Point(275, 17)
        '
        '
        '
        '
        '
        '
        Me.hastaDateTimeInput2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.hastaDateTimeInput2.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.hastaDateTimeInput2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.hastaDateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.hastaDateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.hastaDateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.hastaDateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.hastaDateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.hastaDateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.hastaDateTimeInput2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.hastaDateTimeInput2.MonthCalendar.DisplayMonth = New Date(2019, 10, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.hastaDateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.hastaDateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.hastaDateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.hastaDateTimeInput2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.hastaDateTimeInput2.MonthCalendar.TodayButtonVisible = True
        Me.hastaDateTimeInput2.Name = "hastaDateTimeInput2"
        Me.hastaDateTimeInput2.Size = New System.Drawing.Size(95, 20)
        Me.hastaDateTimeInput2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.hastaDateTimeInput2.TabIndex = 3
        '
        'desdeDateTimeInput1
        '
        Me.desdeDateTimeInput1.AutoAdvance = True
        '
        '
        '
        Me.desdeDateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.desdeDateTimeInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.desdeDateTimeInput1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.desdeDateTimeInput1.ButtonDropDown.Visible = True
        Me.desdeDateTimeInput1.IsPopupCalendarOpen = False
        Me.desdeDateTimeInput1.Location = New System.Drawing.Point(88, 17)
        '
        '
        '
        '
        '
        '
        Me.desdeDateTimeInput1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.desdeDateTimeInput1.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.desdeDateTimeInput1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.desdeDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.desdeDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.desdeDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.desdeDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.desdeDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.desdeDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.desdeDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.desdeDateTimeInput1.MonthCalendar.DisplayMonth = New Date(2019, 10, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.desdeDateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.desdeDateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.desdeDateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.desdeDateTimeInput1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.desdeDateTimeInput1.MonthCalendar.TodayButtonVisible = True
        Me.desdeDateTimeInput1.Name = "desdeDateTimeInput1"
        Me.desdeDateTimeInput1.Size = New System.Drawing.Size(95, 20)
        Me.desdeDateTimeInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.desdeDateTimeInput1.TabIndex = 2
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(219, 17)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(50, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Hasta:"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(36, 17)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(50, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Desde:"
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.ButtonX2)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx3.Location = New System.Drawing.Point(0, 133)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(921, 36)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 5
        Me.PanelEx3.Text = "REPORTE CONSOLIDADO EXISTENCIAS"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(811, 6)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(98, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 5
        Me.ButtonX2.Text = "&Exportar informe"
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField7, Me.PivotGridField6, Me.PivotGridField5, Me.PivotGridField4, Me.PivotGridField3, Me.PivotGridField2, Me.PivotGridField1})
        PivotGridGroup1.Fields.Add(Me.PivotGridField1)
        PivotGridGroup1.Hierarchy = Nothing
        PivotGridGroup1.ShowNewValues = True
        Me.PivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {PivotGridGroup1})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 169)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(921, 389)
        Me.PivotGridControl1.TabIndex = 6
        '
        'PivotGridField7
        '
        Me.PivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField7.AreaIndex = 3
        Me.PivotGridField7.Caption = "Exisencia"
        Me.PivotGridField7.CellFormat.FormatString = "N2"
        Me.PivotGridField7.FieldName = "Saldo"
        Me.PivotGridField7.Name = "PivotGridField7"
        Me.PivotGridField7.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'PivotGridField6
        '
        Me.PivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField6.AreaIndex = 2
        Me.PivotGridField6.Caption = "Egresos"
        Me.PivotGridField6.CellFormat.FormatString = "N2"
        Me.PivotGridField6.FieldName = "Egresos"
        Me.PivotGridField6.Name = "PivotGridField6"
        Me.PivotGridField6.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'PivotGridField5
        '
        Me.PivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField5.AreaIndex = 1
        Me.PivotGridField5.Caption = "Ingresos"
        Me.PivotGridField5.CellFormat.FormatString = "N2"
        Me.PivotGridField5.FieldName = "Ingresos"
        Me.PivotGridField5.Name = "PivotGridField5"
        Me.PivotGridField5.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'PivotGridField4
        '
        Me.PivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField4.AreaIndex = 0
        Me.PivotGridField4.Caption = "Saldo Inicial"
        Me.PivotGridField4.CellFormat.FormatString = "N2"
        Me.PivotGridField4.FieldName = "SaldoInicial"
        Me.PivotGridField4.Name = "PivotGridField4"
        Me.PivotGridField4.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'PivotGridField3
        '
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField3.AreaIndex = 2
        Me.PivotGridField3.Caption = "Descripción"
        Me.PivotGridField3.FieldName = "descripcion"
        Me.PivotGridField3.Name = "PivotGridField3"
        Me.PivotGridField3.Width = 250
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField2.AreaIndex = 1
        Me.PivotGridField2.Caption = "Código"
        Me.PivotGridField2.FieldName = "codigo"
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'RepConsumoSemEngordeTableAdapter
        '
        Me.RepConsumoSemEngordeTableAdapter.ClearBeforeFill = True
        '
        'RepConsumoSemEngordeBindingSource
        '
        Me.RepConsumoSemEngordeBindingSource.DataMember = "RepConsumoSemEngorde"
        Me.RepConsumoSemEngordeBindingSource.DataSource = Me.DtsInventario
        '
        'DtsInventario
        '
        Me.DtsInventario.DataSetName = "dtsInventario"
        Me.DtsInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmRepConsolidadoExistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 558)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Controls.Add(Me.PanelEx3)
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRepConsolidadoExistencias"
        Me.Text = "Reporte Consolidado Existencias"
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.hastaDateTimeInput2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.desdeDateTimeInput1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx3.ResumeLayout(False)
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepConsumoSemEngordeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents hastaDateTimeInput2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents desdeDateTimeInput1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents bodegasComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents descripionTextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents codigoTextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents RepConsumoSemEngordeTableAdapter As dtsInventarioTableAdapters.RepConsumoSemEngordeTableAdapter
    Friend WithEvents RepConsumoSemEngordeBindingSource As BindingSource
    Friend WithEvents DtsInventario As dtsInventario
    Private WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents SFD As SaveFileDialog
    Private WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Private WithEvents PivotGridField7 As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents PivotGridField6 As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Private WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
End Class
