<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteSalidasPorFecha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteSalidasPorFecha))
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.destinoComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.tiposalidasComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.hastaDateTimeInput2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.desdeDateTimeInput1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LoteNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Fecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CorrInterno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Documento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EdadDias = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TipoSalida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PesoUnitarioReal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PesoTotalReal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrecioVenta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Destino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Cliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DireccionCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelEx3.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.hastaDateTimeInput2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.desdeDateTimeInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.ButtonX3)
        Me.PanelEx3.Controls.Add(Me.ButtonX2)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx3.Location = New System.Drawing.Point(0, 75)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(1012, 36)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 10
        Me.PanelEx3.Text = "REPORTE DE SALIDAS"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(775, 6)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(121, 23)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 6
        Me.ButtonX3.Text = "Formato Impresión"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(902, 6)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(98, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 5
        Me.ButtonX2.Text = "&Exportar informe"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.destinoComboBox1)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.tiposalidasComboBox1)
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
        Me.GroupPanel1.Size = New System.Drawing.Size(1012, 75)
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
        Me.GroupPanel1.TabIndex = 9
        Me.GroupPanel1.Text = "Filtros"
        '
        'destinoComboBox1
        '
        Me.destinoComboBox1.FormattingEnabled = True
        Me.destinoComboBox1.Location = New System.Drawing.Point(633, 19)
        Me.destinoComboBox1.Name = "destinoComboBox1"
        Me.destinoComboBox1.Size = New System.Drawing.Size(124, 21)
        Me.destinoComboBox1.TabIndex = 9
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(580, 17)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(47, 23)
        Me.LabelX4.TabIndex = 8
        Me.LabelX4.Text = "Destino:"
        '
        'tiposalidasComboBox1
        '
        Me.tiposalidasComboBox1.FormattingEnabled = True
        Me.tiposalidasComboBox1.Location = New System.Drawing.Point(439, 19)
        Me.tiposalidasComboBox1.Name = "tiposalidasComboBox1"
        Me.tiposalidasComboBox1.Size = New System.Drawing.Size(124, 21)
        Me.tiposalidasComboBox1.TabIndex = 7
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(376, 17)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(67, 23)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "Tipo Salida:"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(772, 17)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
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
        Me.hastaDateTimeInput2.Location = New System.Drawing.Point(261, 17)
        '
        '
        '
        Me.hastaDateTimeInput2.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
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
        Me.hastaDateTimeInput2.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.hastaDateTimeInput2.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.hastaDateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.hastaDateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.hastaDateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.hastaDateTimeInput2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.hastaDateTimeInput2.MonthCalendar.TodayButtonVisible = True
        Me.hastaDateTimeInput2.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
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
        Me.desdeDateTimeInput1.Location = New System.Drawing.Point(93, 17)
        '
        '
        '
        Me.desdeDateTimeInput1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
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
        Me.desdeDateTimeInput1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.desdeDateTimeInput1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.desdeDateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.desdeDateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.desdeDateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.desdeDateTimeInput1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.desdeDateTimeInput1.MonthCalendar.TodayButtonVisible = True
        Me.desdeDateTimeInput1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
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
        Me.LabelX2.Location = New System.Drawing.Point(215, 17)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(40, 23)
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
        Me.LabelX1.Location = New System.Drawing.Point(48, 17)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(39, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Desde:"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 111)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1012, 480)
        Me.GridControl1.TabIndex = 11
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.LoteNo, Me.Fecha, Me.CorrInterno, Me.Documento, Me.EdadDias, Me.TipoSalida, Me.Cantidad, Me.PesoUnitarioReal, Me.PesoTotalReal, Me.PrecioVenta, Me.Destino, Me.Cliente, Me.DireccionCliente})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Peso_Real_Lbs", Me.PesoTotalReal, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Precio_Venta", Me.PrecioVenta, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "Peso_Unitario", Me.PesoUnitarioReal, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cantidad", Me.Cantidad, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.LoteNo, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'LoteNo
        '
        Me.LoteNo.Caption = "Lote No."
        Me.LoteNo.FieldName = "Lote_NO"
        Me.LoteNo.Name = "LoteNo"
        Me.LoteNo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cantidad", "")})
        Me.LoteNo.Visible = True
        Me.LoteNo.VisibleIndex = 0
        Me.LoteNo.Width = 80
        '
        'Fecha
        '
        Me.Fecha.Caption = "Fecha"
        Me.Fecha.FieldName = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Visible = True
        Me.Fecha.VisibleIndex = 0
        Me.Fecha.Width = 80
        '
        'CorrInterno
        '
        Me.CorrInterno.Caption = "Corr. Interno"
        Me.CorrInterno.FieldName = "CorrInterno"
        Me.CorrInterno.Name = "CorrInterno"
        Me.CorrInterno.Visible = True
        Me.CorrInterno.VisibleIndex = 1
        Me.CorrInterno.Width = 80
        '
        'Documento
        '
        Me.Documento.Caption = "Documento"
        Me.Documento.FieldName = "Documento"
        Me.Documento.Name = "Documento"
        Me.Documento.Visible = True
        Me.Documento.VisibleIndex = 2
        '
        'EdadDias
        '
        Me.EdadDias.Caption = "Edad Dias"
        Me.EdadDias.FieldName = "Edad_Dias"
        Me.EdadDias.Name = "EdadDias"
        Me.EdadDias.Visible = True
        Me.EdadDias.VisibleIndex = 3
        Me.EdadDias.Width = 82
        '
        'TipoSalida
        '
        Me.TipoSalida.Caption = "Tipo Sálida"
        Me.TipoSalida.FieldName = "Tipo_Salida"
        Me.TipoSalida.Name = "TipoSalida"
        Me.TipoSalida.Visible = True
        Me.TipoSalida.VisibleIndex = 4
        Me.TipoSalida.Width = 82
        '
        'Cantidad
        '
        Me.Cantidad.Caption = "Cantidad"
        Me.Cantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Cantidad.FieldName = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Visible = True
        Me.Cantidad.VisibleIndex = 5
        Me.Cantidad.Width = 82
        '
        'PesoUnitarioReal
        '
        Me.PesoUnitarioReal.Caption = "Peso Unitario Real Lbs."
        Me.PesoUnitarioReal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PesoUnitarioReal.FieldName = "Peso_Unitario"
        Me.PesoUnitarioReal.Name = "PesoUnitarioReal"
        Me.PesoUnitarioReal.Visible = True
        Me.PesoUnitarioReal.VisibleIndex = 6
        Me.PesoUnitarioReal.Width = 82
        '
        'PesoTotalReal
        '
        Me.PesoTotalReal.Caption = "Peso Total Real Lbs."
        Me.PesoTotalReal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PesoTotalReal.FieldName = "Peso_Real_Lbs"
        Me.PesoTotalReal.Name = "PesoTotalReal"
        Me.PesoTotalReal.Visible = True
        Me.PesoTotalReal.VisibleIndex = 7
        Me.PesoTotalReal.Width = 82
        '
        'PrecioVenta
        '
        Me.PrecioVenta.Caption = "Precio Venta"
        Me.PrecioVenta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PrecioVenta.FieldName = "Precio_Venta"
        Me.PrecioVenta.Name = "PrecioVenta"
        Me.PrecioVenta.Visible = True
        Me.PrecioVenta.VisibleIndex = 8
        Me.PrecioVenta.Width = 82
        '
        'Destino
        '
        Me.Destino.Caption = "Destino"
        Me.Destino.FieldName = "Tipo"
        Me.Destino.Name = "Destino"
        Me.Destino.Visible = True
        Me.Destino.VisibleIndex = 9
        Me.Destino.Width = 82
        '
        'Cliente
        '
        Me.Cliente.Caption = "Cliente"
        Me.Cliente.FieldName = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Visible = True
        Me.Cliente.VisibleIndex = 10
        Me.Cliente.Width = 120
        '
        'DireccionCliente
        '
        Me.DireccionCliente.Caption = "Direccion Cliente"
        Me.DireccionCliente.FieldName = "Dirección Cliente"
        Me.DireccionCliente.Name = "DireccionCliente"
        Me.DireccionCliente.Visible = True
        Me.DireccionCliente.VisibleIndex = 11
        Me.DireccionCliente.Width = 150
        '
        'frmReporteSalidasPorFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 591)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelEx3)
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReporteSalidasPorFecha"
        Me.Text = "Reporte de Salidas por Fecha"
        Me.PanelEx3.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.hastaDateTimeInput2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.desdeDateTimeInput1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents hastaDateTimeInput2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents desdeDateTimeInput1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SFD As SaveFileDialog
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LoteNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CorrInterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EdadDias As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TipoSalida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PesoUnitarioReal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PesoTotalReal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrecioVenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Destino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DireccionCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tiposalidasComboBox1 As ComboBox
    Friend WithEvents destinoComboBox1 As ComboBox
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Documento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
End Class
