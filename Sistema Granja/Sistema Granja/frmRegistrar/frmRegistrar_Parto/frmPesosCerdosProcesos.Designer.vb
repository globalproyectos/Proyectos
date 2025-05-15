<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPesosCerdosProcesos
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPesosCerdosProcesos))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.CollapsibleSplitContainer1 = New DevComponents.DotNetBar.Controls.CollapsibleSplitContainer()
        Me.listaDataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Id_Inseminacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.correlativoparto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaParto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoVivos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPeso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boton = New DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn()
        Me.Completado = New DevComponents.DotNetBar.Controls.DataGridViewProgressBarXColumn()
        Me.vacio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pesosDataGridViewX2 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Id_Inseminacion_pesos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LineaNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn()
        Me.Sexo = New DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn()
        Me.SexoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsPesosCerdosProcesosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsPesosCerdosProcesos = New Sistema_Granja.dtsPesosCerdosProcesos()
        Me.vacio2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.totalsexoTextBoxX3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.totalpesoTextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.totallineasTextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.procesoComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.criterioSwitchButton1 = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.hastaDateTimeInput2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.desdeDateTimeInput1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.SexoTableAdapter = New Sistema_Granja.dtsPesosCerdosProcesosTableAdapters.SexoTableAdapter()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.CollapsibleSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CollapsibleSplitContainer1.Panel1.SuspendLayout()
        Me.CollapsibleSplitContainer1.Panel2.SuspendLayout()
        Me.CollapsibleSplitContainer1.SuspendLayout()
        CType(Me.listaDataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pesosDataGridViewX2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SexoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsPesosCerdosProcesosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsPesosCerdosProcesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx3.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.hastaDateTimeInput2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.desdeDateTimeInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.GroupPanel2)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1082, 597)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.CollapsibleSplitContainer1)
        Me.GroupPanel2.Controls.Add(Me.ShapeContainer2)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 100)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(1082, 446)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 1
        Me.GroupPanel2.Text = "Lista de Cerdos"
        '
        'CollapsibleSplitContainer1
        '
        Me.CollapsibleSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CollapsibleSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.CollapsibleSplitContainer1.Name = "CollapsibleSplitContainer1"
        '
        'CollapsibleSplitContainer1.Panel1
        '
        Me.CollapsibleSplitContainer1.Panel1.Controls.Add(Me.listaDataGridViewX1)
        '
        'CollapsibleSplitContainer1.Panel2
        '
        Me.CollapsibleSplitContainer1.Panel2.Controls.Add(Me.pesosDataGridViewX2)
        Me.CollapsibleSplitContainer1.Panel2.Controls.Add(Me.PanelEx3)
        Me.CollapsibleSplitContainer1.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.CollapsibleSplitContainer1.Size = New System.Drawing.Size(1076, 425)
        Me.CollapsibleSplitContainer1.SplitterDistance = 705
        Me.CollapsibleSplitContainer1.SplitterWidth = 20
        Me.CollapsibleSplitContainer1.TabIndex = 0
        '
        'listaDataGridViewX1
        '
        Me.listaDataGridViewX1.AllowUserToAddRows = False
        Me.listaDataGridViewX1.AllowUserToDeleteRows = False
        Me.listaDataGridViewX1.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.listaDataGridViewX1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.listaDataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listaDataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Inseminacion, Me.correlativoparto, Me.Codigo, Me.FechaParto, Me.NoVivos, Me.TotalPeso, Me.boton, Me.Completado, Me.vacio})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.listaDataGridViewX1.DefaultCellStyle = DataGridViewCellStyle5
        Me.listaDataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listaDataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.listaDataGridViewX1.Location = New System.Drawing.Point(0, 0)
        Me.listaDataGridViewX1.Name = "listaDataGridViewX1"
        Me.listaDataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.listaDataGridViewX1.Size = New System.Drawing.Size(705, 425)
        Me.listaDataGridViewX1.TabIndex = 0
        '
        'Id_Inseminacion
        '
        Me.Id_Inseminacion.DataPropertyName = "Id_Inseminacion"
        Me.Id_Inseminacion.HeaderText = "ID Inseminacion"
        Me.Id_Inseminacion.Name = "Id_Inseminacion"
        Me.Id_Inseminacion.ReadOnly = True
        Me.Id_Inseminacion.Width = 80
        '
        'correlativoparto
        '
        Me.correlativoparto.DataPropertyName = "CorrelativoParto"
        Me.correlativoparto.HeaderText = "Corr. Parto"
        Me.correlativoparto.Name = "correlativoparto"
        Me.correlativoparto.ReadOnly = True
        Me.correlativoparto.Width = 70
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 80
        '
        'FechaParto
        '
        Me.FechaParto.DataPropertyName = "FechaRealParto"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FechaParto.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaParto.HeaderText = "Fecha Parto/Destete"
        Me.FechaParto.Name = "FechaParto"
        Me.FechaParto.ReadOnly = True
        Me.FechaParto.Width = 80
        '
        'NoVivos
        '
        Me.NoVivos.DataPropertyName = "NoVivos"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NoVivos.DefaultCellStyle = DataGridViewCellStyle3
        Me.NoVivos.HeaderText = "No. Cerdos(as)"
        Me.NoVivos.Name = "NoVivos"
        Me.NoVivos.ReadOnly = True
        Me.NoVivos.Width = 60
        '
        'TotalPeso
        '
        Me.TotalPeso.DataPropertyName = "TotalPeso"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.TotalPeso.DefaultCellStyle = DataGridViewCellStyle4
        Me.TotalPeso.HeaderText = "Total Peso"
        Me.TotalPeso.Name = "TotalPeso"
        Me.TotalPeso.ReadOnly = True
        Me.TotalPeso.Width = 80
        '
        'boton
        '
        Me.boton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.boton.DataPropertyName = "Accion"
        Me.boton.HeaderText = "Acción"
        Me.boton.Image = CType(resources.GetObject("boton.Image"), System.Drawing.Image)
        Me.boton.Name = "boton"
        Me.boton.SplitButton = True
        Me.boton.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.boton.Text = "Reg, Pesos"
        Me.boton.Width = 90
        '
        'Completado
        '
        Me.Completado.DataPropertyName = "porcentaje"
        Me.Completado.HeaderText = "% Completado"
        Me.Completado.Name = "Completado"
        Me.Completado.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.Completado.Text = Nothing
        '
        'vacio
        '
        Me.vacio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.vacio.HeaderText = ""
        Me.vacio.Name = "vacio"
        Me.vacio.ReadOnly = True
        '
        'pesosDataGridViewX2
        '
        Me.pesosDataGridViewX2.AllowUserToAddRows = False
        Me.pesosDataGridViewX2.AllowUserToDeleteRows = False
        Me.pesosDataGridViewX2.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.pesosDataGridViewX2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.pesosDataGridViewX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pesosDataGridViewX2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Inseminacion_pesos, Me.LineaNo, Me.Peso, Me.Sexo, Me.vacio2})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.pesosDataGridViewX2.DefaultCellStyle = DataGridViewCellStyle9
        Me.pesosDataGridViewX2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pesosDataGridViewX2.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.pesosDataGridViewX2.Location = New System.Drawing.Point(0, 0)
        Me.pesosDataGridViewX2.Name = "pesosDataGridViewX2"
        Me.pesosDataGridViewX2.Size = New System.Drawing.Size(351, 384)
        Me.pesosDataGridViewX2.TabIndex = 1
        '
        'Id_Inseminacion_pesos
        '
        Me.Id_Inseminacion_pesos.DataPropertyName = "Id_Inseminacion"
        Me.Id_Inseminacion_pesos.HeaderText = "ID Inseminación"
        Me.Id_Inseminacion_pesos.Name = "Id_Inseminacion_pesos"
        Me.Id_Inseminacion_pesos.ReadOnly = True
        Me.Id_Inseminacion_pesos.Width = 80
        '
        'LineaNo
        '
        Me.LineaNo.DataPropertyName = "LineaNo"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.LineaNo.DefaultCellStyle = DataGridViewCellStyle7
        Me.LineaNo.HeaderText = "Linea No."
        Me.LineaNo.Name = "LineaNo"
        Me.LineaNo.ReadOnly = True
        Me.LineaNo.Width = 60
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
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Peso.DefaultCellStyle = DataGridViewCellStyle8
        Me.Peso.HeaderText = "Peso Lbs."
        Me.Peso.Increment = 1.0R
        Me.Peso.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        Me.Peso.Name = "Peso"
        Me.Peso.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Peso.Width = 70
        '
        'Sexo
        '
        Me.Sexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Sexo.DataPropertyName = "Sexo"
        Me.Sexo.DataSource = Me.SexoBindingSource
        Me.Sexo.DisplayMember = "Descripcion"
        Me.Sexo.DropDownHeight = 106
        Me.Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sexo.DropDownWidth = 121
        Me.Sexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Sexo.IntegralHeight = False
        Me.Sexo.ItemHeight = 15
        Me.Sexo.Name = "Sexo"
        Me.Sexo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Sexo.ValueMember = "Sexo"
        Me.Sexo.Width = 80
        '
        'SexoBindingSource
        '
        Me.SexoBindingSource.DataMember = "Sexo"
        Me.SexoBindingSource.DataSource = Me.DtsPesosCerdosProcesosBindingSource
        '
        'DtsPesosCerdosProcesosBindingSource
        '
        Me.DtsPesosCerdosProcesosBindingSource.DataSource = Me.DtsPesosCerdosProcesos
        Me.DtsPesosCerdosProcesosBindingSource.Position = 0
        '
        'DtsPesosCerdosProcesos
        '
        Me.DtsPesosCerdosProcesos.DataSetName = "dtsPesosCerdosProcesos"
        Me.DtsPesosCerdosProcesos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vacio2
        '
        Me.vacio2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.vacio2.HeaderText = ""
        Me.vacio2.Name = "vacio2"
        Me.vacio2.ReadOnly = True
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.totalsexoTextBoxX3)
        Me.PanelEx3.Controls.Add(Me.totalpesoTextBoxX2)
        Me.PanelEx3.Controls.Add(Me.totallineasTextBoxX1)
        Me.PanelEx3.Controls.Add(Me.LabelX4)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx3.Location = New System.Drawing.Point(0, 384)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(351, 41)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 2
        '
        'totalsexoTextBoxX3
        '
        '
        '
        '
        Me.totalsexoTextBoxX3.Border.Class = "TextBoxBorder"
        Me.totalsexoTextBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.totalsexoTextBoxX3.Location = New System.Drawing.Point(266, 10)
        Me.totalsexoTextBoxX3.Name = "totalsexoTextBoxX3"
        Me.totalsexoTextBoxX3.PreventEnterBeep = True
        Me.totalsexoTextBoxX3.ReadOnly = True
        Me.totalsexoTextBoxX3.Size = New System.Drawing.Size(77, 20)
        Me.totalsexoTextBoxX3.TabIndex = 3
        '
        'totalpesoTextBoxX2
        '
        '
        '
        '
        Me.totalpesoTextBoxX2.Border.Class = "TextBoxBorder"
        Me.totalpesoTextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.totalpesoTextBoxX2.Location = New System.Drawing.Point(205, 10)
        Me.totalpesoTextBoxX2.Name = "totalpesoTextBoxX2"
        Me.totalpesoTextBoxX2.PreventEnterBeep = True
        Me.totalpesoTextBoxX2.ReadOnly = True
        Me.totalpesoTextBoxX2.Size = New System.Drawing.Size(58, 20)
        Me.totalpesoTextBoxX2.TabIndex = 2
        Me.totalpesoTextBoxX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'totallineasTextBoxX1
        '
        '
        '
        '
        Me.totallineasTextBoxX1.Border.Class = "TextBoxBorder"
        Me.totallineasTextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.totallineasTextBoxX1.Location = New System.Drawing.Point(137, 10)
        Me.totallineasTextBoxX1.Name = "totallineasTextBoxX1"
        Me.totallineasTextBoxX1.PreventEnterBeep = True
        Me.totallineasTextBoxX1.ReadOnly = True
        Me.totallineasTextBoxX1.Size = New System.Drawing.Size(66, 20)
        Me.totallineasTextBoxX1.TabIndex = 1
        Me.totallineasTextBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(30, 7)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(68, 23)
        Me.LabelX4.TabIndex = 0
        Me.LabelX4.Text = "TOTALES"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(351, 425)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 256
        Me.LineShape1.X2 = 331
        Me.LineShape1.Y1 = 24
        Me.LineShape1.Y2 = 47
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1076, 425)
        Me.ShapeContainer2.TabIndex = 1
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 906
        Me.LineShape2.X2 = 914
        Me.LineShape2.Y1 = -1
        Me.LineShape2.Y2 = 413
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.procesoComboBoxEx1)
        Me.GroupPanel1.Controls.Add(Me.criterioSwitchButton1)
        Me.GroupPanel1.Controls.Add(Me.ButtonX1)
        Me.GroupPanel1.Controls.Add(Me.hastaDateTimeInput2)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.desdeDateTimeInput1)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1082, 100)
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
        Me.GroupPanel1.Text = "Filtros"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(21, 1)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(49, 23)
        Me.LabelX3.TabIndex = 9
        Me.LabelX3.Text = "Proceso:"
        '
        'procesoComboBoxEx1
        '
        Me.procesoComboBoxEx1.DisplayMember = "Text"
        Me.procesoComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.procesoComboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.procesoComboBoxEx1.FormattingEnabled = True
        Me.procesoComboBoxEx1.ItemHeight = 14
        Me.procesoComboBoxEx1.Items.AddRange(New Object() {Me.ComboItem1})
        Me.procesoComboBoxEx1.Location = New System.Drawing.Point(71, 4)
        Me.procesoComboBoxEx1.Name = "procesoComboBoxEx1"
        Me.procesoComboBoxEx1.Size = New System.Drawing.Size(258, 20)
        Me.procesoComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.procesoComboBoxEx1.TabIndex = 8
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Partos"
        '
        'criterioSwitchButton1
        '
        Me.criterioSwitchButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.criterioSwitchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.criterioSwitchButton1.Location = New System.Drawing.Point(973, 3)
        Me.criterioSwitchButton1.Name = "criterioSwitchButton1"
        Me.criterioSwitchButton1.OffText = "TODOS"
        Me.criterioSwitchButton1.OnText = "SIN PESO"
        Me.criterioSwitchButton1.Size = New System.Drawing.Size(94, 22)
        Me.criterioSwitchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.criterioSwitchButton1.TabIndex = 7
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(335, 33)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 6
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
        Me.hastaDateTimeInput2.Location = New System.Drawing.Point(229, 36)
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
        Me.hastaDateTimeInput2.MonthCalendar.DisplayMonth = New Date(2019, 8, 1, 0, 0, 0, 0)
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
        Me.hastaDateTimeInput2.Size = New System.Drawing.Size(100, 20)
        Me.hastaDateTimeInput2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.hastaDateTimeInput2.TabIndex = 4
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(192, 33)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(49, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Hasta:"
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
        Me.desdeDateTimeInput1.Location = New System.Drawing.Point(71, 35)
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
        Me.desdeDateTimeInput1.MonthCalendar.DisplayMonth = New Date(2019, 8, 1, 0, 0, 0, 0)
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
        Me.desdeDateTimeInput1.Size = New System.Drawing.Size(100, 20)
        Me.desdeDateTimeInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.desdeDateTimeInput1.TabIndex = 2
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(21, 33)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(49, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Desde:"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.ButtonX3)
        Me.PanelEx2.Controls.Add(Me.ButtonX2)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx2.Location = New System.Drawing.Point(0, 546)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1082, 51)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 2
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Image = Global.Sistema_Granja.My.Resources.Resources.ok
        Me.ButtonX3.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.ButtonX3.Location = New System.Drawing.Point(858, 10)
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
        Me.ButtonX2.Location = New System.Drawing.Point(967, 10)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(103, 33)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 0
        Me.ButtonX2.Text = "&Cancelar"
        '
        'SexoTableAdapter
        '
        Me.SexoTableAdapter.ClearBeforeFill = True
        '
        'frmPesosCerdosProcesos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 597)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPesosCerdosProcesos"
        Me.Text = "Pesos x Cerdo Proceso(Partos, Destetes)"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.CollapsibleSplitContainer1.Panel1.ResumeLayout(False)
        Me.CollapsibleSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.CollapsibleSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CollapsibleSplitContainer1.ResumeLayout(False)
        CType(Me.listaDataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pesosDataGridViewX2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SexoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsPesosCerdosProcesosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsPesosCerdosProcesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx3.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.hastaDateTimeInput2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.desdeDateTimeInput1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents desdeDateTimeInput1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents hastaDateTimeInput2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents CollapsibleSplitContainer1 As DevComponents.DotNetBar.Controls.CollapsibleSplitContainer
    Friend WithEvents listaDataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents pesosDataGridViewX2 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents criterioSwitchButton1 As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents procesoComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents DtsPesosCerdosProcesos As Sistema_Granja.dtsPesosCerdosProcesos
    Friend WithEvents DtsPesosCerdosProcesosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SexoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SexoTableAdapter As Sistema_Granja.dtsPesosCerdosProcesosTableAdapters.SexoTableAdapter
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents totalpesoTextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents totallineasTextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents totalsexoTextBoxX3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Id_Inseminacion_pesos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LineaNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Peso As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents Sexo As DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn
    Friend WithEvents vacio2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Inseminacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents correlativoparto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaParto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoVivos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPeso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents boton As DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
    Friend WithEvents Completado As DevComponents.DotNetBar.Controls.DataGridViewProgressBarXColumn
    Friend WithEvents vacio As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Private WithEvents LineShape1 As PowerPacks.LineShape
    Private WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Private WithEvents LineShape2 As PowerPacks.LineShape
End Class
