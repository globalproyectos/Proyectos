<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgBodegas_existencias
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgBodegas_existencias))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.btnSeleccionar = New DevComponents.DotNetBar.ButtonX()
        Me.btnActualizar = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.Consulta_Bodegas_x_descripcionDataGridViewX = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Bodega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Consulta_Bodegas_x_descripcionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsBDGRANJA = New Sistema_Granja.DtsBDGRANJA()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDescripcionBodega = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Consulta_Bodegas_x_descripcionTableAdapter = New Sistema_Granja.DtsBDGRANJATableAdapters.Consulta_Bodegas_x_descripcionTableAdapter()
        Me.TableAdapterManager = New Sistema_Granja.DtsBDGRANJATableAdapters.TableAdapterManager()
        Me.Consulta_Bodegas_x_descripcionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RibbonClientPanel1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.Consulta_Bodegas_x_descripcionDataGridViewX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consulta_Bodegas_x_descripcionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsBDGRANJA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consulta_Bodegas_x_descripcionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Consulta_Bodegas_x_descripcionBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.PanelEx3)
        Me.RibbonClientPanel1.Controls.Add(Me.PanelEx2)
        Me.RibbonClientPanel1.Controls.Add(Me.PanelEx1)
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonClientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonClientPanel1.Name = "RibbonClientPanel1"
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(517, 498)
        '
        '
        '
        Me.RibbonClientPanel1.Style.Class = "RibbonClientPanel"
        Me.RibbonClientPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonClientPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonClientPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonClientPanel1.TabIndex = 0
        Me.RibbonClientPanel1.Text = "RibbonClientPanel1"
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.btnSeleccionar)
        Me.PanelEx3.Controls.Add(Me.btnActualizar)
        Me.PanelEx3.Controls.Add(Me.ButtonX1)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Location = New System.Drawing.Point(3, 452)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(514, 44)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 2
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSeleccionar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSeleccionar.Image = CType(resources.GetObject("btnSeleccionar.Image"), System.Drawing.Image)
        Me.btnSeleccionar.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btnSeleccionar.Location = New System.Drawing.Point(190, 2)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(98, 39)
        Me.btnSeleccionar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSeleccionar.TabIndex = 6
        Me.btnSeleccionar.Text = "&Seleccionar"
        '
        'btnActualizar
        '
        Me.btnActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnActualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btnActualizar.Location = New System.Drawing.Point(294, 2)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(94, 39)
        Me.btnActualizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnActualizar.TabIndex = 5
        Me.btnActualizar.Text = "&Actualizar"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = CType(resources.GetObject("ButtonX1.Image"), System.Drawing.Image)
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.ButtonX1.Location = New System.Drawing.Point(394, 2)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(117, 39)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 4
        Me.ButtonX1.Text = "&Cerrar Ventana"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.Consulta_Bodegas_x_descripcionDataGridViewX)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(3, 88)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(511, 363)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 1
        '
        'Consulta_Bodegas_x_descripcionDataGridViewX
        '
        Me.Consulta_Bodegas_x_descripcionDataGridViewX.AllowUserToAddRows = False
        Me.Consulta_Bodegas_x_descripcionDataGridViewX.AutoGenerateColumns = False
        Me.Consulta_Bodegas_x_descripcionDataGridViewX.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Consulta_Bodegas_x_descripcionDataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Consulta_Bodegas_x_descripcionDataGridViewX.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Bodega, Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn3})
        Me.Consulta_Bodegas_x_descripcionDataGridViewX.DataSource = Me.Consulta_Bodegas_x_descripcionBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Consulta_Bodegas_x_descripcionDataGridViewX.DefaultCellStyle = DataGridViewCellStyle1
        Me.Consulta_Bodegas_x_descripcionDataGridViewX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Consulta_Bodegas_x_descripcionDataGridViewX.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Consulta_Bodegas_x_descripcionDataGridViewX.Location = New System.Drawing.Point(0, 0)
        Me.Consulta_Bodegas_x_descripcionDataGridViewX.Name = "Consulta_Bodegas_x_descripcionDataGridViewX"
        Me.Consulta_Bodegas_x_descripcionDataGridViewX.ReadOnly = True
        Me.Consulta_Bodegas_x_descripcionDataGridViewX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Consulta_Bodegas_x_descripcionDataGridViewX.Size = New System.Drawing.Size(511, 363)
        Me.Consulta_Bodegas_x_descripcionDataGridViewX.TabIndex = 0
        '
        'Bodega
        '
        Me.Bodega.DataPropertyName = "Bodega"
        Me.Bodega.HeaderText = "Bodega"
        Me.Bodega.Name = "Bodega"
        Me.Bodega.ReadOnly = True
        Me.Bodega.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Activa"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Activa"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Liquidador"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Liquidador"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Consulta_Bodegas_x_descripcionBindingSource
        '
        Me.Consulta_Bodegas_x_descripcionBindingSource.DataMember = "Consulta_Bodegas_x_descripcion"
        Me.Consulta_Bodegas_x_descripcionBindingSource.DataSource = Me.DtsBDGRANJA
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
        Me.PanelEx1.Controls.Add(Me.GroupBox1)
        Me.PanelEx1.Controls.Add(Me.PictureBox1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Location = New System.Drawing.Point(3, 26)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(511, 58)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDescripcionBodega)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Location = New System.Drawing.Point(69, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 55)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la bodega"
        '
        'txtDescripcionBodega
        '
        '
        '
        '
        Me.txtDescripcionBodega.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescripcionBodega.Border.Class = "TextBoxBorder"
        Me.txtDescripcionBodega.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDescripcionBodega.Location = New System.Drawing.Point(76, 28)
        Me.txtDescripcionBodega.MaxLength = 4
        Me.txtDescripcionBodega.Name = "txtDescripcionBodega"
        Me.txtDescripcionBodega.Size = New System.Drawing.Size(357, 20)
        Me.txtDescripcionBodega.TabIndex = 2
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(-2, 25)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(74, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Descripción:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Consulta_Bodegas_x_descripcionTableAdapter
        '
        Me.Consulta_Bodegas_x_descripcionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BODEGASTableAdapter = Nothing
        Me.TableAdapterManager.BodegasTableAdapter1 = Nothing
        Me.TableAdapterManager.Buscar_Compra_reversion_x_nodocTableAdapter = Nothing
        Me.TableAdapterManager.Buscar_Requisicion_AnulacionTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.Costos_Concentrados_x_MesTableAdapter = Nothing
        Me.TableAdapterManager.ENCABEZADO_SALIDASTableAdapter = Nothing
        Me.TableAdapterManager.Estados_InseminacionesTableAdapter = Nothing
        Me.TableAdapterManager.F_Rev_Fechas_Inicio_Engordes_ConsultaTableAdapter = Nothing
        Me.TableAdapterManager.Inventario_MaterialesTableAdapter = Nothing
        Me.TableAdapterManager.LINEAS_DE_REQUISICIONESTableAdapter = Nothing
        Me.TableAdapterManager.LINEAS_DE_SALIDASTableAdapter = Nothing
        Me.TableAdapterManager.Sl_VerracosTableAdapter = Nothing
        Me.TableAdapterManager.traslados_detallesTableAdapter = Nothing
        Me.TableAdapterManager.traslados_encabezadosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_Granja.DtsBDGRANJATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Consulta_Bodegas_x_descripcionBindingNavigator
        '
        Me.Consulta_Bodegas_x_descripcionBindingNavigator.AddNewItem = Nothing
        Me.Consulta_Bodegas_x_descripcionBindingNavigator.BindingSource = Me.Consulta_Bodegas_x_descripcionBindingSource
        Me.Consulta_Bodegas_x_descripcionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Consulta_Bodegas_x_descripcionBindingNavigator.DeleteItem = Nothing
        Me.Consulta_Bodegas_x_descripcionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.Consulta_Bodegas_x_descripcionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Consulta_Bodegas_x_descripcionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Consulta_Bodegas_x_descripcionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Consulta_Bodegas_x_descripcionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Consulta_Bodegas_x_descripcionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Consulta_Bodegas_x_descripcionBindingNavigator.Name = "Consulta_Bodegas_x_descripcionBindingNavigator"
        Me.Consulta_Bodegas_x_descripcionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Consulta_Bodegas_x_descripcionBindingNavigator.Size = New System.Drawing.Size(517, 25)
        Me.Consulta_Bodegas_x_descripcionBindingNavigator.TabIndex = 1
        Me.Consulta_Bodegas_x_descripcionBindingNavigator.Text = "BindingNavigator1"
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
        'dlgBodegas_existencias
        '
        Me.ClientSize = New System.Drawing.Size(517, 498)
        Me.ControlBox = False
        Me.Controls.Add(Me.Consulta_Bodegas_x_descripcionBindingNavigator)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.DoubleBuffered = True
        Me.Name = "dlgBodegas_existencias"
        Me.Text = "Bodegas"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.Consulta_Bodegas_x_descripcionDataGridViewX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consulta_Bodegas_x_descripcionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsBDGRANJA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consulta_Bodegas_x_descripcionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Consulta_Bodegas_x_descripcionBindingNavigator.ResumeLayout(False)
        Me.Consulta_Bodegas_x_descripcionBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcionBodega As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnSeleccionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnActualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DtsBDGRANJA As Sistema_Granja.DtsBDGRANJA
    Friend WithEvents Consulta_Bodegas_x_descripcionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Consulta_Bodegas_x_descripcionTableAdapter As Sistema_Granja.DtsBDGRANJATableAdapters.Consulta_Bodegas_x_descripcionTableAdapter
    Friend WithEvents TableAdapterManager As Sistema_Granja.DtsBDGRANJATableAdapters.TableAdapterManager
    Friend WithEvents Consulta_Bodegas_x_descripcionBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Consulta_Bodegas_x_descripcionDataGridViewX As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Bodega As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
