<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPesoSubidaEngorde
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPesoSubidaEngorde))
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Lote = New DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn()
        Me.LotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsPesosCerdosProcesos = New Sistema_Granja.dtsPesosCerdosProcesos()
        Me.FechaSubida = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.Peso = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn()
        Me.vacia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotesTableAdapter = New Sistema_Granja.dtsPesosCerdosProcesosTableAdapters.LotesTableAdapter()
        Me.PanelEx2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsPesosCerdosProcesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.ButtonX3)
        Me.PanelEx2.Controls.Add(Me.ButtonX2)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx2.Location = New System.Drawing.Point(0, 526)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(599, 51)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 3
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Image = Global.Sistema_Granja.My.Resources.Resources.ok
        Me.ButtonX3.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.ButtonX3.Location = New System.Drawing.Point(375, 10)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(103, 33)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 1
        Me.ButtonX3.Text = "&Aceptar"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.Sistema_Granja.My.Resources.Resources.DeleteRed
        Me.ButtonX2.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.ButtonX2.Location = New System.Drawing.Point(484, 10)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(103, 33)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 0
        Me.ButtonX2.Text = "&Cancelar"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.DataGridViewX1)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(599, 526)
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
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "Registro de Pesos"
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Lote, Me.FechaSubida, Me.Peso, Me.vacia})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.Size = New System.Drawing.Size(593, 505)
        Me.DataGridViewX1.TabIndex = 0
        '
        'Lote
        '
        Me.Lote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Lote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Lote.DataPropertyName = "Lote"
        Me.Lote.DataSource = Me.LotesBindingSource
        Me.Lote.DisplayMember = "lote_no"
        Me.Lote.DropDownHeight = 106
        Me.Lote.DropDownWidth = 121
        Me.Lote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lote.HeaderText = "Lote No."
        Me.Lote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lote.IntegralHeight = False
        Me.Lote.ItemHeight = 15
        Me.Lote.Name = "Lote"
        Me.Lote.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Lote.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lote.ValueMember = "lote_no"
        '
        'LotesBindingSource
        '
        Me.LotesBindingSource.DataMember = "Lotes"
        Me.LotesBindingSource.DataSource = Me.DtsPesosCerdosProcesos
        '
        'DtsPesosCerdosProcesos
        '
        Me.DtsPesosCerdosProcesos.DataSetName = "dtsPesosCerdosProcesos"
        Me.DtsPesosCerdosProcesos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FechaSubida
        '
        Me.FechaSubida.AutoAdvance = True
        '
        '
        '
        Me.FechaSubida.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.FechaSubida.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.FechaSubida.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FechaSubida.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText
        Me.FechaSubida.DataPropertyName = "FechaSubida"
        Me.FechaSubida.HeaderText = "Fecha Subida"
        Me.FechaSubida.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        Me.FechaSubida.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.FechaSubida.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FechaSubida.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.FechaSubida.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FechaSubida.MonthCalendar.DisplayMonth = New Date(2019, 9, 1, 0, 0, 0, 0)
        Me.FechaSubida.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.FechaSubida.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.FechaSubida.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FechaSubida.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.FechaSubida.Name = "FechaSubida"
        Me.FechaSubida.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Peso
        '
        '
        '
        '
        Me.Peso.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.Peso.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.Peso.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Peso.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText
        Me.Peso.DataPropertyName = "Peso"
        Me.Peso.HeaderText = "Peso Lbs."
        Me.Peso.Increment = 1.0R
        Me.Peso.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        Me.Peso.MinValue = 0.0R
        Me.Peso.Name = "Peso"
        Me.Peso.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'vacia
        '
        Me.vacia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.vacia.HeaderText = ""
        Me.vacia.Name = "vacia"
        Me.vacia.ReadOnly = True
        '
        'LotesTableAdapter
        '
        Me.LotesTableAdapter.ClearBeforeFill = True
        '
        'frmPesoSubidaEngorde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 577)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.PanelEx2)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPesoSubidaEngorde"
        Me.Text = "Peso Subida Engorde"
        Me.PanelEx2.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsPesosCerdosProcesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DtsPesosCerdosProcesos As Sistema_Granja.dtsPesosCerdosProcesos
    Friend WithEvents LotesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LotesTableAdapter As Sistema_Granja.dtsPesosCerdosProcesosTableAdapters.LotesTableAdapter
    Friend WithEvents Lote As DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn
    Friend WithEvents FechaSubida As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents Peso As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents vacia As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
