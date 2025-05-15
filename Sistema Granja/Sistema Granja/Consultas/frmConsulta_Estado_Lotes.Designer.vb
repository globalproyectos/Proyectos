<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsulta_Estado_Lotes
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsulta_Estado_Lotes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.PanelEx4 = New DevComponents.DotNetBar.PanelEx
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtGestacion = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtMonta = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtReemplazos = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtEngorde = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.txtVerracos = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtVacias = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx
        Me.btnExportar = New DevComponents.DotNetBar.ButtonX
        Me.btnGuardar = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx
        Me.Consulta_Estado_LotesDataGridViewX = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.LoteNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Consulta_Estado_LotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsBDGRANJA = New Sistema_Granja.DtsBDGRANJA
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.lbResultados = New DevComponents.DotNetBar.LabelX
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txtLoteNo = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Consulta_Estado_LotesTableAdapter = New Sistema_Granja.DtsBDGRANJATableAdapters.Consulta_Estado_LotesTableAdapter
        Me.TableAdapterManager = New Sistema_Granja.DtsBDGRANJATableAdapters.TableAdapterManager
        Me.Consulta_Estado_LotesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.RibbonClientPanel1.SuspendLayout()
        Me.PanelEx4.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.Consulta_Estado_LotesDataGridViewX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consulta_Estado_LotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsBDGRANJA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.Consulta_Estado_LotesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Consulta_Estado_LotesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.PanelEx4)
        Me.RibbonClientPanel1.Controls.Add(Me.PanelEx3)
        Me.RibbonClientPanel1.Controls.Add(Me.PanelEx2)
        Me.RibbonClientPanel1.Controls.Add(Me.PanelEx1)
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonClientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonClientPanel1.Name = "RibbonClientPanel1"
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(531, 586)
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
        'PanelEx4
        '
        Me.PanelEx4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx4.Controls.Add(Me.GroupPanel2)
        Me.PanelEx4.Location = New System.Drawing.Point(1, 411)
        Me.PanelEx4.Name = "PanelEx4"
        Me.PanelEx4.Size = New System.Drawing.Size(528, 131)
        Me.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        Me.PanelEx4.TabIndex = 5
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.GroupBox2)
        Me.GroupPanel2.Controls.Add(Me.GroupBox1)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(528, 131)
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
        Me.GroupPanel2.Style.Class = ""
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.Class = ""
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.Class = ""
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 1
        Me.GroupPanel2.Text = "Total x Etapa"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxX2)
        Me.GroupBox2.Controls.Add(Me.txtGestacion)
        Me.GroupBox2.Controls.Add(Me.txtMonta)
        Me.GroupBox2.Controls.Add(Me.LabelX8)
        Me.GroupBox2.Controls.Add(Me.LabelX9)
        Me.GroupBox2.Controls.Add(Me.LabelX10)
        Me.GroupBox2.Location = New System.Drawing.Point(262, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 103)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hato Reprod."
        '
        'TextBoxX2
        '
        '
        '
        '
        Me.TextBoxX2.Border.Class = "TextBoxBorder"
        Me.TextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX2.Location = New System.Drawing.Point(110, 79)
        Me.TextBoxX2.Name = "TextBoxX2"
        Me.TextBoxX2.Size = New System.Drawing.Size(141, 20)
        Me.TextBoxX2.TabIndex = 13
        Me.TextBoxX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGestacion
        '
        '
        '
        '
        Me.txtGestacion.Border.Class = "TextBoxBorder"
        Me.txtGestacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtGestacion.Location = New System.Drawing.Point(110, 56)
        Me.txtGestacion.Name = "txtGestacion"
        Me.txtGestacion.Size = New System.Drawing.Size(141, 20)
        Me.txtGestacion.TabIndex = 12
        Me.txtGestacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMonta
        '
        '
        '
        '
        Me.txtMonta.Border.Class = "TextBoxBorder"
        Me.txtMonta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMonta.Location = New System.Drawing.Point(110, 33)
        Me.txtMonta.Name = "txtMonta"
        Me.txtMonta.Size = New System.Drawing.Size(141, 20)
        Me.txtMonta.TabIndex = 11
        Me.txtMonta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.Class = ""
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(6, 83)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(75, 10)
        Me.LabelX8.TabIndex = 10
        Me.LabelX8.Text = "Lactancia:"
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.Class = ""
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(7, 60)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(75, 10)
        Me.LabelX9.TabIndex = 9
        Me.LabelX9.Text = "Gestacion:"
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.Class = ""
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(7, 36)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(75, 11)
        Me.LabelX10.TabIndex = 8
        Me.LabelX10.Text = "Monta:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtReemplazos)
        Me.GroupBox1.Controls.Add(Me.txtEngorde)
        Me.GroupBox1.Controls.Add(Me.LabelX6)
        Me.GroupBox1.Controls.Add(Me.txtVerracos)
        Me.GroupBox1.Controls.Add(Me.txtVacias)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 106)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Engorde,V,VR,R"
        '
        'txtReemplazos
        '
        '
        '
        '
        Me.txtReemplazos.Border.Class = "TextBoxBorder"
        Me.txtReemplazos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtReemplazos.Location = New System.Drawing.Point(109, 36)
        Me.txtReemplazos.Name = "txtReemplazos"
        Me.txtReemplazos.Size = New System.Drawing.Size(141, 20)
        Me.txtReemplazos.TabIndex = 8
        Me.txtReemplazos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEngorde
        '
        '
        '
        '
        Me.txtEngorde.Border.Class = "TextBoxBorder"
        Me.txtEngorde.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEngorde.Location = New System.Drawing.Point(109, 82)
        Me.txtEngorde.Name = "txtEngorde"
        Me.txtEngorde.Size = New System.Drawing.Size(141, 20)
        Me.txtEngorde.TabIndex = 7
        Me.txtEngorde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(6, 87)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(75, 10)
        Me.LabelX6.TabIndex = 6
        Me.LabelX6.Text = "Engorde:"
        '
        'txtVerracos
        '
        '
        '
        '
        Me.txtVerracos.Border.Class = "TextBoxBorder"
        Me.txtVerracos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtVerracos.Location = New System.Drawing.Point(109, 59)
        Me.txtVerracos.Name = "txtVerracos"
        Me.txtVerracos.Size = New System.Drawing.Size(141, 20)
        Me.txtVerracos.TabIndex = 5
        Me.txtVerracos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVacias
        '
        '
        '
        '
        Me.txtVacias.Border.Class = "TextBoxBorder"
        Me.txtVacias.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtVacias.Location = New System.Drawing.Point(109, 13)
        Me.txtVacias.Name = "txtVacias"
        Me.txtVacias.Size = New System.Drawing.Size(141, 20)
        Me.txtVacias.TabIndex = 3
        Me.txtVacias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(5, 63)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(75, 10)
        Me.LabelX5.TabIndex = 2
        Me.LabelX5.Text = "Verracos:"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(6, 40)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(75, 10)
        Me.LabelX4.TabIndex = 1
        Me.LabelX4.Text = "Reemplazos:"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(6, 16)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 11)
        Me.LabelX3.TabIndex = 0
        Me.LabelX3.Text = "Vacias:"
        '
        'PanelEx3
        '
        Me.PanelEx3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.btnExportar)
        Me.PanelEx3.Controls.Add(Me.btnGuardar)
        Me.PanelEx3.Controls.Add(Me.ButtonX3)
        Me.PanelEx3.Location = New System.Drawing.Point(4, 543)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(524, 40)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 4
        '
        'btnExportar
        '
        Me.btnExportar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExportar.CallBasePaintBackground = True
        Me.btnExportar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExportar.Enabled = False
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnExportar.Location = New System.Drawing.Point(180, 5)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(121, 30)
        Me.btnExportar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnExportar.TabIndex = 6
        Me.btnExportar.Text = "&Exportar a Excel"
        '
        'btnGuardar
        '
        Me.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGuardar.CallBasePaintBackground = True
        Me.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Location = New System.Drawing.Point(307, 5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(121, 30)
        Me.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "&Actualizar"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.CallBasePaintBackground = True
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Image = CType(resources.GetObject("ButtonX3.Image"), System.Drawing.Image)
        Me.ButtonX3.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.ButtonX3.Location = New System.Drawing.Point(434, 5)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(84, 30)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 5
        Me.ButtonX3.Text = "&Cancelar"
        '
        'PanelEx2
        '
        Me.PanelEx2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.Consulta_Estado_LotesDataGridViewX)
        Me.PanelEx2.Location = New System.Drawing.Point(3, 98)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(525, 311)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 1
        '
        'Consulta_Estado_LotesDataGridViewX
        '
        Me.Consulta_Estado_LotesDataGridViewX.AllowUserToAddRows = False
        Me.Consulta_Estado_LotesDataGridViewX.AllowUserToDeleteRows = False
        Me.Consulta_Estado_LotesDataGridViewX.AutoGenerateColumns = False
        Me.Consulta_Estado_LotesDataGridViewX.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Consulta_Estado_LotesDataGridViewX.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Consulta_Estado_LotesDataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Consulta_Estado_LotesDataGridViewX.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoteNo, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.Descripcion})
        Me.Consulta_Estado_LotesDataGridViewX.DataSource = Me.Consulta_Estado_LotesBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Consulta_Estado_LotesDataGridViewX.DefaultCellStyle = DataGridViewCellStyle2
        Me.Consulta_Estado_LotesDataGridViewX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Consulta_Estado_LotesDataGridViewX.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Consulta_Estado_LotesDataGridViewX.Location = New System.Drawing.Point(0, 0)
        Me.Consulta_Estado_LotesDataGridViewX.Name = "Consulta_Estado_LotesDataGridViewX"
        Me.Consulta_Estado_LotesDataGridViewX.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Consulta_Estado_LotesDataGridViewX.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Consulta_Estado_LotesDataGridViewX.Size = New System.Drawing.Size(525, 311)
        Me.Consulta_Estado_LotesDataGridViewX.TabIndex = 0
        '
        'LoteNo
        '
        Me.LoteNo.DataPropertyName = "Lote_No"
        Me.LoteNo.HeaderText = "Lote No."
        Me.LoteNo.Name = "LoteNo"
        Me.LoteNo.ReadOnly = True
        Me.LoteNo.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Cerdos Registrados"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cerdos Registrados"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Total Cerdos"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Total Cerdos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Fecha_Creacion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha Creación"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Consulta_Estado_LotesBindingSource
        '
        Me.Consulta_Estado_LotesBindingSource.DataMember = "Consulta_Estado_Lotes"
        Me.Consulta_Estado_LotesBindingSource.DataSource = Me.DtsBDGRANJA
        '
        'DtsBDGRANJA
        '
        Me.DtsBDGRANJA.DataSetName = "DtsBDGRANJA"
        Me.DtsBDGRANJA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Location = New System.Drawing.Point(0, 28)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(528, 68)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.lbResultados)
        Me.GroupPanel1.Controls.Add(Me.ButtonX1)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.txtLoteNo)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(528, 68)
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
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 1
        Me.GroupPanel1.Text = "Localizar lote"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(374, 9)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(57, 23)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "No Lotes:"
        '
        'lbResultados
        '
        '
        '
        '
        Me.lbResultados.BackgroundStyle.Class = ""
        Me.lbResultados.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbResultados.ForeColor = System.Drawing.Color.Green
        Me.lbResultados.Location = New System.Drawing.Point(438, 4)
        Me.lbResultados.Name = "lbResultados"
        Me.lbResultados.Size = New System.Drawing.Size(79, 28)
        Me.lbResultados.TabIndex = 3
        Me.lbResultados.Text = "0"
        Me.lbResultados.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.CallBasePaintBackground = True
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(203, 9)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(76, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 2
        Me.ButtonX1.Text = "Búscar"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(9, 9)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Lote No:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtLoteNo
        '
        '
        '
        '
        Me.txtLoteNo.Border.Class = "TextBoxBorder"
        Me.txtLoteNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtLoteNo.Location = New System.Drawing.Point(97, 12)
        Me.txtLoteNo.Name = "txtLoteNo"
        Me.txtLoteNo.Size = New System.Drawing.Size(100, 20)
        Me.txtLoteNo.TabIndex = 0
        '
        'Consulta_Estado_LotesTableAdapter
        '
        Me.Consulta_Estado_LotesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BODEGASTableAdapter = Nothing
        Me.TableAdapterManager.Buscar_Compra_reversion_x_nodocTableAdapter = Nothing
        Me.TableAdapterManager.Buscar_Requisicion_AnulacionTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.ENCABEZADO_SALIDASTableAdapter = Nothing
        Me.TableAdapterManager.Estados_InseminacionesTableAdapter = Nothing
        Me.TableAdapterManager.LINEAS_DE_REQUISICIONESTableAdapter = Nothing
        Me.TableAdapterManager.LINEAS_DE_SALIDASTableAdapter = Nothing
        Me.TableAdapterManager.Sl_VerracosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_Granja.DtsBDGRANJATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Consulta_Estado_LotesBindingNavigator
        '
        Me.Consulta_Estado_LotesBindingNavigator.AddNewItem = Nothing
        Me.Consulta_Estado_LotesBindingNavigator.BindingSource = Me.Consulta_Estado_LotesBindingSource
        Me.Consulta_Estado_LotesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Consulta_Estado_LotesBindingNavigator.DeleteItem = Nothing
        Me.Consulta_Estado_LotesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.Consulta_Estado_LotesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Consulta_Estado_LotesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Consulta_Estado_LotesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Consulta_Estado_LotesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Consulta_Estado_LotesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Consulta_Estado_LotesBindingNavigator.Name = "Consulta_Estado_LotesBindingNavigator"
        Me.Consulta_Estado_LotesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Consulta_Estado_LotesBindingNavigator.Size = New System.Drawing.Size(531, 25)
        Me.Consulta_Estado_LotesBindingNavigator.TabIndex = 1
        Me.Consulta_Estado_LotesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'frmConsulta_Estado_Lotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 586)
        Me.Controls.Add(Me.Consulta_Estado_LotesBindingNavigator)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.DoubleBuffered = True
        Me.Name = "frmConsulta_Estado_Lotes"
        Me.Text = "Consulta Estado de Lotes"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.PanelEx4.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.Consulta_Estado_LotesDataGridViewX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consulta_Estado_LotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsBDGRANJA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.Consulta_Estado_LotesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Consulta_Estado_LotesBindingNavigator.ResumeLayout(False)
        Me.Consulta_Estado_LotesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtLoteNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbResultados As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnExportar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnGuardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DtsBDGRANJA As Sistema_Granja.DtsBDGRANJA
    Friend WithEvents Consulta_Estado_LotesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Consulta_Estado_LotesTableAdapter As Sistema_Granja.DtsBDGRANJATableAdapters.Consulta_Estado_LotesTableAdapter
    Friend WithEvents TableAdapterManager As Sistema_Granja.DtsBDGRANJATableAdapters.TableAdapterManager
    Friend WithEvents Consulta_Estado_LotesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Consulta_Estado_LotesDataGridViewX As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx4 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEngorde As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtVerracos As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtVacias As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtGestacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtMonta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LoteNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtReemplazos As DevComponents.DotNetBar.Controls.TextBoxX
End Class
