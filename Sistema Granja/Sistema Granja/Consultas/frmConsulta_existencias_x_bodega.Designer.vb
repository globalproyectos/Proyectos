<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsulta_existencias_x_bodega
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsulta_existencias_x_bodega))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.btnGuardar = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx
        Me.Consulta_Existencias_bodegaDataGridViewX = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Consulta_Existencias_bodegaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsBDGRANJA = New Sistema_Granja.DtsBDGRANJA
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtDescripcionBodega = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtBodega = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Consulta_Existencias_bodegaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Consulta_Existencias_bodegaTableAdapter = New Sistema_Granja.DtsBDGRANJATableAdapters.Consulta_Existencias_bodegaTableAdapter
        Me.TableAdapterManager = New Sistema_Granja.DtsBDGRANJATableAdapters.TableAdapterManager
        Me.RibbonClientPanel1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.Consulta_Existencias_bodegaDataGridViewX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consulta_Existencias_bodegaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsBDGRANJA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Consulta_Existencias_bodegaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Consulta_Existencias_bodegaBindingNavigator.SuspendLayout()
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
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(719, 518)
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
        'PanelEx3
        '
        Me.PanelEx3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.ButtonX2)
        Me.PanelEx3.Controls.Add(Me.btnGuardar)
        Me.PanelEx3.Controls.Add(Me.ButtonX3)
        Me.PanelEx3.Location = New System.Drawing.Point(2, 477)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(714, 40)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 4
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.CallBasePaintBackground = True
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = CType(resources.GetObject("ButtonX2.Image"), System.Drawing.Image)
        Me.ButtonX2.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.ButtonX2.Location = New System.Drawing.Point(370, 5)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(121, 30)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 6
        Me.ButtonX2.Text = "&Exportar a Excel"
        '
        'btnGuardar
        '
        Me.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGuardar.CallBasePaintBackground = True
        Me.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Location = New System.Drawing.Point(497, 5)
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
        Me.ButtonX3.Location = New System.Drawing.Point(624, 5)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(84, 30)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 5
        Me.ButtonX3.Text = "&Cerrar"
        '
        'PanelEx2
        '
        Me.PanelEx2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.Consulta_Existencias_bodegaDataGridViewX)
        Me.PanelEx2.Location = New System.Drawing.Point(1, 97)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(715, 379)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 1
        '
        'Consulta_Existencias_bodegaDataGridViewX
        '
        Me.Consulta_Existencias_bodegaDataGridViewX.AllowUserToAddRows = False
        Me.Consulta_Existencias_bodegaDataGridViewX.AllowUserToDeleteRows = False
        Me.Consulta_Existencias_bodegaDataGridViewX.AutoGenerateColumns = False
        Me.Consulta_Existencias_bodegaDataGridViewX.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Consulta_Existencias_bodegaDataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Consulta_Existencias_bodegaDataGridViewX.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Consulta_Existencias_bodegaDataGridViewX.DataSource = Me.Consulta_Existencias_bodegaBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Consulta_Existencias_bodegaDataGridViewX.DefaultCellStyle = DataGridViewCellStyle4
        Me.Consulta_Existencias_bodegaDataGridViewX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Consulta_Existencias_bodegaDataGridViewX.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Consulta_Existencias_bodegaDataGridViewX.Location = New System.Drawing.Point(0, 0)
        Me.Consulta_Existencias_bodegaDataGridViewX.Name = "Consulta_Existencias_bodegaDataGridViewX"
        Me.Consulta_Existencias_bodegaDataGridViewX.ReadOnly = True
        Me.Consulta_Existencias_bodegaDataGridViewX.Size = New System.Drawing.Size(715, 379)
        Me.Consulta_Existencias_bodegaDataGridViewX.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Bodega"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Bodega"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 55
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Ingresos"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ingresos"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 90
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Egresos"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "Egresos"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 90
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Existencia_Actual"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn6.HeaderText = "Existencia Actual"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Consulta_Existencias_bodegaBindingSource
        '
        Me.Consulta_Existencias_bodegaBindingSource.DataMember = "Consulta_Existencias_bodega"
        Me.Consulta_Existencias_bodegaBindingSource.DataSource = Me.DtsBDGRANJA
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
        Me.PanelEx1.Location = New System.Drawing.Point(3, 34)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(713, 61)
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
        Me.GroupBox1.Controls.Add(Me.txtBodega)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Location = New System.Drawing.Point(73, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(637, 55)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la bodega"
        '
        'txtDescripcionBodega
        '
        '
        '
        '
        Me.txtDescripcionBodega.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDescripcionBodega.Border.Class = "TextBoxBorder"
        Me.txtDescripcionBodega.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDescripcionBodega.Enabled = False
        Me.txtDescripcionBodega.Location = New System.Drawing.Point(126, 28)
        Me.txtDescripcionBodega.MaxLength = 4
        Me.txtDescripcionBodega.Name = "txtDescripcionBodega"
        Me.txtDescripcionBodega.Size = New System.Drawing.Size(314, 20)
        Me.txtDescripcionBodega.TabIndex = 2
        '
        'txtBodega
        '
        '
        '
        '
        Me.txtBodega.Border.Class = "TextBoxBorder"
        Me.txtBodega.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBodega.ForeColor = System.Drawing.Color.Green
        Me.txtBodega.Location = New System.Drawing.Point(60, 28)
        Me.txtBodega.MaxLength = 4
        Me.txtBodega.Name = "txtBodega"
        Me.txtBodega.Size = New System.Drawing.Size(64, 20)
        Me.txtBodega.TabIndex = 1
        Me.txtBodega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(6, 25)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(48, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Bodega:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Consulta_Existencias_bodegaBindingNavigator
        '
        Me.Consulta_Existencias_bodegaBindingNavigator.AddNewItem = Nothing
        Me.Consulta_Existencias_bodegaBindingNavigator.BindingSource = Me.Consulta_Existencias_bodegaBindingSource
        Me.Consulta_Existencias_bodegaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Consulta_Existencias_bodegaBindingNavigator.DeleteItem = Nothing
        Me.Consulta_Existencias_bodegaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.Consulta_Existencias_bodegaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Consulta_Existencias_bodegaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Consulta_Existencias_bodegaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Consulta_Existencias_bodegaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Consulta_Existencias_bodegaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Consulta_Existencias_bodegaBindingNavigator.Name = "Consulta_Existencias_bodegaBindingNavigator"
        Me.Consulta_Existencias_bodegaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Consulta_Existencias_bodegaBindingNavigator.Size = New System.Drawing.Size(719, 25)
        Me.Consulta_Existencias_bodegaBindingNavigator.TabIndex = 1
        Me.Consulta_Existencias_bodegaBindingNavigator.Text = "BindingNavigator1"
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
        'Consulta_Existencias_bodegaTableAdapter
        '
        Me.Consulta_Existencias_bodegaTableAdapter.ClearBeforeFill = True
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
        'frmConsulta_existencias_x_bodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 518)
        Me.Controls.Add(Me.Consulta_Existencias_bodegaBindingNavigator)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.DoubleBuffered = True
        Me.Name = "frmConsulta_existencias_x_bodega"
        Me.Text = "Existencias x Bodegas"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.Consulta_Existencias_bodegaDataGridViewX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consulta_Existencias_bodegaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsBDGRANJA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Consulta_Existencias_bodegaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Consulta_Existencias_bodegaBindingNavigator.ResumeLayout(False)
        Me.Consulta_Existencias_bodegaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcionBodega As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtBodega As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents DtsBDGRANJA As Sistema_Granja.DtsBDGRANJA
    Friend WithEvents Consulta_Existencias_bodegaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Consulta_Existencias_bodegaTableAdapter As Sistema_Granja.DtsBDGRANJATableAdapters.Consulta_Existencias_bodegaTableAdapter
    Friend WithEvents TableAdapterManager As Sistema_Granja.DtsBDGRANJATableAdapters.TableAdapterManager
    Friend WithEvents Consulta_Existencias_bodegaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Consulta_Existencias_bodegaDataGridViewX As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnGuardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
