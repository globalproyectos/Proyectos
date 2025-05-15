<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgLista_Verracos
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
        Dim CostoLabel As System.Windows.Forms.Label
        Dim Valor_DepreciableLabel As System.Windows.Forms.Label
        Dim Fecha_CompraLabel As System.Windows.Forms.Label
        Dim MadreLabel As System.Windows.Forms.Label
        Dim PadreLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgLista_Verracos))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.PadreTextBoxX = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Lista_Verracos_Buscar_x_CodigoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsBDGRANJA = New Sistema_Granja.DtsBDGRANJA
        Me.MadreTextBoxX = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Fecha_CompraTextBoxX = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Valor_DepreciableTextBoxX = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.CostoTextBoxX = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.CodVerraco = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txtCodigoVerraco = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Lista_Verracos_Buscar_x_CodigoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Lista_Verracos_Buscar_x_CodigoTableAdapter = New Sistema_Granja.DtsBDGRANJATableAdapters.Lista_Verracos_Buscar_x_CodigoTableAdapter
        Me.TableAdapterManager = New Sistema_Granja.DtsBDGRANJATableAdapters.TableAdapterManager
        CostoLabel = New System.Windows.Forms.Label
        Valor_DepreciableLabel = New System.Windows.Forms.Label
        Fecha_CompraLabel = New System.Windows.Forms.Label
        MadreLabel = New System.Windows.Forms.Label
        PadreLabel = New System.Windows.Forms.Label
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        CType(Me.Lista_Verracos_Buscar_x_CodigoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsBDGRANJA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.Lista_Verracos_Buscar_x_CodigoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Lista_Verracos_Buscar_x_CodigoBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CostoLabel
        '
        CostoLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CostoLabel.AutoSize = True
        CostoLabel.Location = New System.Drawing.Point(150, 7)
        CostoLabel.Name = "CostoLabel"
        CostoLabel.Size = New System.Drawing.Size(37, 13)
        CostoLabel.TabIndex = 0
        CostoLabel.Text = "Costo:"
        '
        'Valor_DepreciableLabel
        '
        Valor_DepreciableLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Valor_DepreciableLabel.AutoSize = True
        Valor_DepreciableLabel.Location = New System.Drawing.Point(93, 33)
        Valor_DepreciableLabel.Name = "Valor_DepreciableLabel"
        Valor_DepreciableLabel.Size = New System.Drawing.Size(94, 13)
        Valor_DepreciableLabel.TabIndex = 2
        Valor_DepreciableLabel.Text = "Valor Depreciable:"
        '
        'Fecha_CompraLabel
        '
        Fecha_CompraLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Fecha_CompraLabel.AutoSize = True
        Fecha_CompraLabel.Location = New System.Drawing.Point(108, 59)
        Fecha_CompraLabel.Name = "Fecha_CompraLabel"
        Fecha_CompraLabel.Size = New System.Drawing.Size(79, 13)
        Fecha_CompraLabel.TabIndex = 4
        Fecha_CompraLabel.Text = "Fecha Compra:"
        '
        'MadreLabel
        '
        MadreLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        MadreLabel.AutoSize = True
        MadreLabel.Location = New System.Drawing.Point(318, 7)
        MadreLabel.Name = "MadreLabel"
        MadreLabel.Size = New System.Drawing.Size(40, 13)
        MadreLabel.TabIndex = 6
        MadreLabel.Text = "Madre:"
        '
        'PadreLabel
        '
        PadreLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        PadreLabel.AutoSize = True
        PadreLabel.Location = New System.Drawing.Point(320, 33)
        PadreLabel.Name = "PadreLabel"
        PadreLabel.Size = New System.Drawing.Size(38, 13)
        PadreLabel.TabIndex = 8
        PadreLabel.Text = "Padre:"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.ButtonX2)
        Me.PanelEx1.Controls.Add(Me.ButtonX1)
        Me.PanelEx1.Controls.Add(Me.GroupPanel3)
        Me.PanelEx1.Controls.Add(Me.GroupPanel2)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(487, 463)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX2.CallBasePaintBackground = True
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = CType(resources.GetObject("ButtonX2.Image"), System.Drawing.Image)
        Me.ButtonX2.ImageFixedSize = New System.Drawing.Size(22, 22)
        Me.ButtonX2.Location = New System.Drawing.Point(279, 424)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(99, 32)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 4
        Me.ButtonX2.Text = "&Seleccionar"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX1.CallBasePaintBackground = True
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.Sistema_Granja.My.Resources.Resources.button_cancel
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(22, 22)
        Me.ButtonX1.Location = New System.Drawing.Point(381, 424)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(99, 32)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 3
        Me.ButtonX1.Text = "&Cancelar"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(PadreLabel)
        Me.GroupPanel3.Controls.Add(Me.PadreTextBoxX)
        Me.GroupPanel3.Controls.Add(MadreLabel)
        Me.GroupPanel3.Controls.Add(Me.MadreTextBoxX)
        Me.GroupPanel3.Controls.Add(Fecha_CompraLabel)
        Me.GroupPanel3.Controls.Add(Me.Fecha_CompraTextBoxX)
        Me.GroupPanel3.Controls.Add(Valor_DepreciableLabel)
        Me.GroupPanel3.Controls.Add(Me.Valor_DepreciableTextBoxX)
        Me.GroupPanel3.Controls.Add(CostoLabel)
        Me.GroupPanel3.Controls.Add(Me.CostoTextBoxX)
        Me.GroupPanel3.Location = New System.Drawing.Point(5, 317)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(475, 102)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.Class = ""
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.Class = ""
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.Class = ""
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 2
        Me.GroupPanel3.Text = "Otros Datos"
        '
        'PadreTextBoxX
        '
        Me.PadreTextBoxX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.PadreTextBoxX.Border.Class = "TextBoxBorder"
        Me.PadreTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PadreTextBoxX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_Verracos_Buscar_x_CodigoBindingSource, "Padre", True))
        Me.PadreTextBoxX.Location = New System.Drawing.Point(364, 30)
        Me.PadreTextBoxX.Name = "PadreTextBoxX"
        Me.PadreTextBoxX.Size = New System.Drawing.Size(100, 20)
        Me.PadreTextBoxX.TabIndex = 9
        Me.PadreTextBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lista_Verracos_Buscar_x_CodigoBindingSource
        '
        Me.Lista_Verracos_Buscar_x_CodigoBindingSource.DataMember = "Lista_Verracos_Buscar_x_Codigo"
        Me.Lista_Verracos_Buscar_x_CodigoBindingSource.DataSource = Me.DtsBDGRANJA
        '
        'DtsBDGRANJA
        '
        Me.DtsBDGRANJA.DataSetName = "DtsBDGRANJA"
        Me.DtsBDGRANJA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MadreTextBoxX
        '
        Me.MadreTextBoxX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.MadreTextBoxX.Border.Class = "TextBoxBorder"
        Me.MadreTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MadreTextBoxX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_Verracos_Buscar_x_CodigoBindingSource, "Madre", True))
        Me.MadreTextBoxX.Location = New System.Drawing.Point(364, 4)
        Me.MadreTextBoxX.Name = "MadreTextBoxX"
        Me.MadreTextBoxX.Size = New System.Drawing.Size(100, 20)
        Me.MadreTextBoxX.TabIndex = 7
        Me.MadreTextBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Fecha_CompraTextBoxX
        '
        Me.Fecha_CompraTextBoxX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Fecha_CompraTextBoxX.Border.Class = "TextBoxBorder"
        Me.Fecha_CompraTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Fecha_CompraTextBoxX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_Verracos_Buscar_x_CodigoBindingSource, "Fecha_Compra", True))
        Me.Fecha_CompraTextBoxX.Location = New System.Drawing.Point(193, 56)
        Me.Fecha_CompraTextBoxX.Name = "Fecha_CompraTextBoxX"
        Me.Fecha_CompraTextBoxX.Size = New System.Drawing.Size(100, 20)
        Me.Fecha_CompraTextBoxX.TabIndex = 5
        Me.Fecha_CompraTextBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Valor_DepreciableTextBoxX
        '
        Me.Valor_DepreciableTextBoxX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Valor_DepreciableTextBoxX.Border.Class = "TextBoxBorder"
        Me.Valor_DepreciableTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Valor_DepreciableTextBoxX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_Verracos_Buscar_x_CodigoBindingSource, "Valor Depreciable", True))
        Me.Valor_DepreciableTextBoxX.Location = New System.Drawing.Point(193, 30)
        Me.Valor_DepreciableTextBoxX.Name = "Valor_DepreciableTextBoxX"
        Me.Valor_DepreciableTextBoxX.Size = New System.Drawing.Size(100, 20)
        Me.Valor_DepreciableTextBoxX.TabIndex = 3
        Me.Valor_DepreciableTextBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CostoTextBoxX
        '
        Me.CostoTextBoxX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.CostoTextBoxX.Border.Class = "TextBoxBorder"
        Me.CostoTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CostoTextBoxX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lista_Verracos_Buscar_x_CodigoBindingSource, "Costo", True))
        Me.CostoTextBoxX.Location = New System.Drawing.Point(193, 4)
        Me.CostoTextBoxX.Name = "CostoTextBoxX"
        Me.CostoTextBoxX.Size = New System.Drawing.Size(100, 20)
        Me.CostoTextBoxX.TabIndex = 1
        Me.CostoTextBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupPanel2
        '
        Me.GroupPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX)
        Me.GroupPanel2.Location = New System.Drawing.Point(5, 92)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(477, 221)
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
        Me.GroupPanel2.Text = "Resultados"
        '
        'Lista_Verracos_Buscar_x_CodigoDataGridViewX
        '
        Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX.AllowUserToAddRows = False
        Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX.AllowUserToDeleteRows = False
        Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX.AutoGenerateColumns = False
        Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodVerraco, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9})
        Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX.DataSource = Me.Lista_Verracos_Buscar_x_CodigoBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX.DefaultCellStyle = DataGridViewCellStyle5
        Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX.Location = New System.Drawing.Point(0, 0)
        Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX.Name = "Lista_Verracos_Buscar_x_CodigoDataGridViewX"
        Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX.ReadOnly = True
        Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX.Size = New System.Drawing.Size(471, 200)
        Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX.TabIndex = 0
        '
        'CodVerraco
        '
        Me.CodVerraco.DataPropertyName = "Codigo_Cerdo"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.CodVerraco.DefaultCellStyle = DataGridViewCellStyle1
        Me.CodVerraco.HeaderText = "Código Verraco"
        Me.CodVerraco.Name = "CodVerraco"
        Me.CodVerraco.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Genetica"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn8.HeaderText = "Genetica"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Fecha_Registro"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fecha de Registro"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Lote_No"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn9.HeaderText = "Lote No"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.txtCodigoVerraco)
        Me.GroupPanel1.Location = New System.Drawing.Point(7, 29)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(477, 58)
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
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "Búsqueda Rápida"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(3, 7)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(89, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Código Verraco:"
        '
        'txtCodigoVerraco
        '
        Me.txtCodigoVerraco.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtCodigoVerraco.Border.Class = "TextBoxBorder"
        Me.txtCodigoVerraco.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCodigoVerraco.Location = New System.Drawing.Point(93, 10)
        Me.txtCodigoVerraco.Name = "txtCodigoVerraco"
        Me.txtCodigoVerraco.Size = New System.Drawing.Size(372, 20)
        Me.txtCodigoVerraco.TabIndex = 0
        Me.txtCodigoVerraco.WatermarkText = "Busque el Verraco con solo ingresar el Código aqui"
        '
        'Lista_Verracos_Buscar_x_CodigoBindingNavigator
        '
        Me.Lista_Verracos_Buscar_x_CodigoBindingNavigator.AddNewItem = Nothing
        Me.Lista_Verracos_Buscar_x_CodigoBindingNavigator.BindingSource = Me.Lista_Verracos_Buscar_x_CodigoBindingSource
        Me.Lista_Verracos_Buscar_x_CodigoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Lista_Verracos_Buscar_x_CodigoBindingNavigator.DeleteItem = Nothing
        Me.Lista_Verracos_Buscar_x_CodigoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.Lista_Verracos_Buscar_x_CodigoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Lista_Verracos_Buscar_x_CodigoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Lista_Verracos_Buscar_x_CodigoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Lista_Verracos_Buscar_x_CodigoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Lista_Verracos_Buscar_x_CodigoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Lista_Verracos_Buscar_x_CodigoBindingNavigator.Name = "Lista_Verracos_Buscar_x_CodigoBindingNavigator"
        Me.Lista_Verracos_Buscar_x_CodigoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Lista_Verracos_Buscar_x_CodigoBindingNavigator.Size = New System.Drawing.Size(487, 25)
        Me.Lista_Verracos_Buscar_x_CodigoBindingNavigator.TabIndex = 1
        Me.Lista_Verracos_Buscar_x_CodigoBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
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
        'Lista_Verracos_Buscar_x_CodigoTableAdapter
        '
        Me.Lista_Verracos_Buscar_x_CodigoTableAdapter.ClearBeforeFill = True
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
        'dlgLista_Verracos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 463)
        Me.ControlBox = False
        Me.Controls.Add(Me.Lista_Verracos_Buscar_x_CodigoBindingNavigator)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "dlgLista_Verracos"
        Me.Text = "Inventario Verracos"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel3.PerformLayout()
        CType(Me.Lista_Verracos_Buscar_x_CodigoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsBDGRANJA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.Lista_Verracos_Buscar_x_CodigoDataGridViewX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.Lista_Verracos_Buscar_x_CodigoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Lista_Verracos_Buscar_x_CodigoBindingNavigator.ResumeLayout(False)
        Me.Lista_Verracos_Buscar_x_CodigoBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents DtsBDGRANJA As Sistema_Granja.DtsBDGRANJA
    Friend WithEvents Lista_Verracos_Buscar_x_CodigoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Lista_Verracos_Buscar_x_CodigoTableAdapter As Sistema_Granja.DtsBDGRANJATableAdapters.Lista_Verracos_Buscar_x_CodigoTableAdapter
    Friend WithEvents TableAdapterManager As Sistema_Granja.DtsBDGRANJATableAdapters.TableAdapterManager
    Friend WithEvents Lista_Verracos_Buscar_x_CodigoBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Lista_Verracos_Buscar_x_CodigoDataGridViewX As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCodigoVerraco As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CostoTextBoxX As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PadreTextBoxX As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents MadreTextBoxX As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Fecha_CompraTextBoxX As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Valor_DepreciableTextBoxX As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CodVerraco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
