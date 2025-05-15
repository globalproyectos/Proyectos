<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarMedicamentos
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
        Dim Codigo_ProductoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim IdEtapaLabel As System.Windows.Forms.Label
        Dim Fecha_CreacionLabel As System.Windows.Forms.Label
        Dim PesoLabel As System.Windows.Forms.Label
        Dim Unidad_MedidaLabel As System.Windows.Forms.Label
        Dim UxPLabel As System.Windows.Forms.Label
        Dim Fecha_VencimientoLabel As System.Windows.Forms.Label
        Dim Usuario_CreadorLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistrarMedicamentos))
        Dim Label2 As System.Windows.Forms.Label
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX()
        Me.btnCerrar = New DevComponents.DotNetBar.ButtonX()
        Me.btnGuardar = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.costoTextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.bodegasCheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.ImagenVacia = New System.Windows.Forms.PictureBox()
        Me.txtFechaVencimiento = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtFechaCreacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cbxUnidadMedida = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.cbxTipo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtDescripcionEtapa = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtDescripcionTipo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.txtDescripcionMaterail = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtMarca = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtUsuarioCreador = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtIdEtapa = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPeso = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtUnidad_x_Presentacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.imgMedicamento = New System.Windows.Forms.PictureBox()
        Me.Costo_UnitarioTextBoxX = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabItem3 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ordenalimentacionIntegerInput1 = New DevComponents.Editors.IntegerInput()
        Codigo_ProductoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        IdEtapaLabel = New System.Windows.Forms.Label()
        Fecha_CreacionLabel = New System.Windows.Forms.Label()
        PesoLabel = New System.Windows.Forms.Label()
        Unidad_MedidaLabel = New System.Windows.Forms.Label()
        UxPLabel = New System.Windows.Forms.Label()
        Fecha_VencimientoLabel = New System.Windows.Forms.Label()
        Usuario_CreadorLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.RibbonClientPanel1.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.ImagenVacia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgMedicamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordenalimentacionIntegerInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Codigo_ProductoLabel
        '
        Codigo_ProductoLabel.AutoSize = True
        Codigo_ProductoLabel.BackColor = System.Drawing.Color.Transparent
        Codigo_ProductoLabel.Location = New System.Drawing.Point(28, 12)
        Codigo_ProductoLabel.Name = "Codigo_ProductoLabel"
        Codigo_ProductoLabel.Size = New System.Drawing.Size(89, 13)
        Codigo_ProductoLabel.TabIndex = 0
        Codigo_ProductoLabel.Text = "Codigo Producto:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.BackColor = System.Drawing.Color.Transparent
        DescripcionLabel.Location = New System.Drawing.Point(28, 38)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 2
        DescripcionLabel.Text = "Descripcion:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.BackColor = System.Drawing.Color.Transparent
        MarcaLabel.Location = New System.Drawing.Point(28, 63)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(40, 13)
        MarcaLabel.TabIndex = 4
        MarcaLabel.Text = "Marca:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.BackColor = System.Drawing.Color.Transparent
        TipoLabel.Location = New System.Drawing.Point(28, 89)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(31, 13)
        TipoLabel.TabIndex = 6
        TipoLabel.Text = "Tipo:"
        '
        'IdEtapaLabel
        '
        IdEtapaLabel.AutoSize = True
        IdEtapaLabel.BackColor = System.Drawing.Color.Transparent
        IdEtapaLabel.Location = New System.Drawing.Point(28, 115)
        IdEtapaLabel.Name = "IdEtapaLabel"
        IdEtapaLabel.Size = New System.Drawing.Size(50, 13)
        IdEtapaLabel.TabIndex = 8
        IdEtapaLabel.Text = "Id Etapa:"
        '
        'Fecha_CreacionLabel
        '
        Fecha_CreacionLabel.AutoSize = True
        Fecha_CreacionLabel.BackColor = System.Drawing.Color.Transparent
        Fecha_CreacionLabel.Location = New System.Drawing.Point(28, 142)
        Fecha_CreacionLabel.Name = "Fecha_CreacionLabel"
        Fecha_CreacionLabel.Size = New System.Drawing.Size(85, 13)
        Fecha_CreacionLabel.TabIndex = 10
        Fecha_CreacionLabel.Text = "Fecha Creacion:"
        '
        'PesoLabel
        '
        PesoLabel.AutoSize = True
        PesoLabel.BackColor = System.Drawing.Color.Transparent
        PesoLabel.Location = New System.Drawing.Point(28, 167)
        PesoLabel.Name = "PesoLabel"
        PesoLabel.Size = New System.Drawing.Size(34, 13)
        PesoLabel.TabIndex = 12
        PesoLabel.Text = "Peso:"
        '
        'Unidad_MedidaLabel
        '
        Unidad_MedidaLabel.AutoSize = True
        Unidad_MedidaLabel.BackColor = System.Drawing.Color.Transparent
        Unidad_MedidaLabel.Location = New System.Drawing.Point(28, 193)
        Unidad_MedidaLabel.Name = "Unidad_MedidaLabel"
        Unidad_MedidaLabel.Size = New System.Drawing.Size(82, 13)
        Unidad_MedidaLabel.TabIndex = 14
        Unidad_MedidaLabel.Text = "Unidad Medida:"
        '
        'UxPLabel
        '
        UxPLabel.AutoSize = True
        UxPLabel.BackColor = System.Drawing.Color.Transparent
        UxPLabel.Location = New System.Drawing.Point(28, 219)
        UxPLabel.Name = "UxPLabel"
        UxPLabel.Size = New System.Drawing.Size(33, 13)
        UxPLabel.TabIndex = 16
        UxPLabel.Text = "Ux P:"
        '
        'Fecha_VencimientoLabel
        '
        Fecha_VencimientoLabel.AutoSize = True
        Fecha_VencimientoLabel.BackColor = System.Drawing.Color.Transparent
        Fecha_VencimientoLabel.Location = New System.Drawing.Point(28, 246)
        Fecha_VencimientoLabel.Name = "Fecha_VencimientoLabel"
        Fecha_VencimientoLabel.Size = New System.Drawing.Size(101, 13)
        Fecha_VencimientoLabel.TabIndex = 22
        Fecha_VencimientoLabel.Text = "Fecha Vencimiento:"
        '
        'Usuario_CreadorLabel
        '
        Usuario_CreadorLabel.AutoSize = True
        Usuario_CreadorLabel.BackColor = System.Drawing.Color.Transparent
        Usuario_CreadorLabel.Location = New System.Drawing.Point(28, 271)
        Usuario_CreadorLabel.Name = "Usuario_CreadorLabel"
        Usuario_CreadorLabel.Size = New System.Drawing.Size(86, 13)
        Usuario_CreadorLabel.TabIndex = 24
        Usuario_CreadorLabel.Text = "Usuario Creador:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Location = New System.Drawing.Point(249, 12)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(59, 13)
        Label1.TabIndex = 35
        Label1.Text = "C. Unitario:"
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.GroupPanel3)
        Me.RibbonClientPanel1.Controls.Add(Me.PanelEx2)
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonClientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonClientPanel1.Name = "RibbonClientPanel1"
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(704, 393)
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
        'GroupPanel3
        '
        Me.GroupPanel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.btnNuevo)
        Me.GroupPanel3.Controls.Add(Me.btnCerrar)
        Me.GroupPanel3.Controls.Add(Me.btnGuardar)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Location = New System.Drawing.Point(3, 354)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(698, 36)
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
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 1
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btnNuevo.Location = New System.Drawing.Point(352, 0)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(100, 30)
        Me.btnNuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "&Nuevo"
        '
        'btnCerrar
        '
        Me.btnCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btnCerrar.Location = New System.Drawing.Point(594, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(95, 30)
        Me.btnCerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.Text = "&Cerrar"
        '
        'btnGuardar
        '
        Me.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btnGuardar.Location = New System.Drawing.Point(457, 0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(132, 30)
        Me.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "&Guardar Producto"
        '
        'PanelEx2
        '
        Me.PanelEx2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.TabControl1)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(3, 3)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(698, 349)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.Transparent
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(698, 349)
        Me.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock
        Me.TabControl1.TabIndex = 26
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Text = "Datos del Nuevo Registro"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.AutoScroll = True
        Me.TabControlPanel1.Controls.Add(Me.ordenalimentacionIntegerInput1)
        Me.TabControlPanel1.Controls.Add(Label2)
        Me.TabControlPanel1.Controls.Add(Me.costoTextBox1)
        Me.TabControlPanel1.Controls.Add(Label1)
        Me.TabControlPanel1.Controls.Add(Me.LabelX1)
        Me.TabControlPanel1.Controls.Add(Me.bodegasCheckedListBox1)
        Me.TabControlPanel1.Controls.Add(Me.ImagenVacia)
        Me.TabControlPanel1.Controls.Add(Me.txtFechaVencimiento)
        Me.TabControlPanel1.Controls.Add(Me.txtFechaCreacion)
        Me.TabControlPanel1.Controls.Add(Me.cbxUnidadMedida)
        Me.TabControlPanel1.Controls.Add(Me.cbxTipo)
        Me.TabControlPanel1.Controls.Add(Me.txtDescripcionEtapa)
        Me.TabControlPanel1.Controls.Add(Me.txtDescripcionTipo)
        Me.TabControlPanel1.Controls.Add(Me.ButtonX1)
        Me.TabControlPanel1.Controls.Add(Me.txtDescripcionMaterail)
        Me.TabControlPanel1.Controls.Add(MarcaLabel)
        Me.TabControlPanel1.Controls.Add(Codigo_ProductoLabel)
        Me.TabControlPanel1.Controls.Add(Me.txtMarca)
        Me.TabControlPanel1.Controls.Add(DescripcionLabel)
        Me.TabControlPanel1.Controls.Add(TipoLabel)
        Me.TabControlPanel1.Controls.Add(Me.txtCodigo)
        Me.TabControlPanel1.Controls.Add(Me.txtUsuarioCreador)
        Me.TabControlPanel1.Controls.Add(IdEtapaLabel)
        Me.TabControlPanel1.Controls.Add(Usuario_CreadorLabel)
        Me.TabControlPanel1.Controls.Add(Me.txtIdEtapa)
        Me.TabControlPanel1.Controls.Add(Fecha_CreacionLabel)
        Me.TabControlPanel1.Controls.Add(Fecha_VencimientoLabel)
        Me.TabControlPanel1.Controls.Add(PesoLabel)
        Me.TabControlPanel1.Controls.Add(Me.txtPeso)
        Me.TabControlPanel1.Controls.Add(Unidad_MedidaLabel)
        Me.TabControlPanel1.Controls.Add(Me.txtUnidad_x_Presentacion)
        Me.TabControlPanel1.Controls.Add(UxPLabel)
        Me.TabControlPanel1.Controls.Add(Me.imgMedicamento)
        Me.TabControlPanel1.Controls.Add(Me.Costo_UnitarioTextBoxX)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(698, 327)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'costoTextBox1
        '
        Me.costoTextBox1.Location = New System.Drawing.Point(314, 9)
        Me.costoTextBox1.Name = "costoTextBox1"
        Me.costoTextBox1.Size = New System.Drawing.Size(86, 20)
        Me.costoTextBox1.TabIndex = 36
        Me.costoTextBox1.Text = "0.00"
        Me.costoTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(311, 139)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(120, 13)
        Me.LabelX1.TabIndex = 34
        Me.LabelX1.Text = "Activar en Bodegas"
        '
        'bodegasCheckedListBox1
        '
        Me.bodegasCheckedListBox1.CheckOnClick = True
        Me.bodegasCheckedListBox1.FormattingEnabled = True
        Me.bodegasCheckedListBox1.Location = New System.Drawing.Point(311, 157)
        Me.bodegasCheckedListBox1.Name = "bodegasCheckedListBox1"
        Me.bodegasCheckedListBox1.Size = New System.Drawing.Size(120, 124)
        Me.bodegasCheckedListBox1.TabIndex = 33
        '
        'ImagenVacia
        '
        Me.ImagenVacia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ImagenVacia.Image = CType(resources.GetObject("ImagenVacia.Image"), System.Drawing.Image)
        Me.ImagenVacia.Location = New System.Drawing.Point(468, 4)
        Me.ImagenVacia.Name = "ImagenVacia"
        Me.ImagenVacia.Size = New System.Drawing.Size(15, 17)
        Me.ImagenVacia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagenVacia.TabIndex = 32
        Me.ImagenVacia.TabStop = False
        Me.ImagenVacia.Visible = False
        '
        'txtFechaVencimiento
        '
        '
        '
        '
        Me.txtFechaVencimiento.Border.Class = "TextBoxBorder"
        Me.txtFechaVencimiento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFechaVencimiento.Enabled = False
        Me.txtFechaVencimiento.Location = New System.Drawing.Point(135, 244)
        Me.txtFechaVencimiento.Name = "txtFechaVencimiento"
        Me.txtFechaVencimiento.Size = New System.Drawing.Size(93, 20)
        Me.txtFechaVencimiento.TabIndex = 13
        '
        'txtFechaCreacion
        '
        '
        '
        '
        Me.txtFechaCreacion.Border.Class = "TextBoxBorder"
        Me.txtFechaCreacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFechaCreacion.Enabled = False
        Me.txtFechaCreacion.Location = New System.Drawing.Point(135, 139)
        Me.txtFechaCreacion.Name = "txtFechaCreacion"
        Me.txtFechaCreacion.Size = New System.Drawing.Size(93, 20)
        Me.txtFechaCreacion.TabIndex = 8
        '
        'cbxUnidadMedida
        '
        Me.cbxUnidadMedida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxUnidadMedida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxUnidadMedida.DisplayMember = "Text"
        Me.cbxUnidadMedida.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxUnidadMedida.Enabled = False
        Me.cbxUnidadMedida.FormattingEnabled = True
        Me.cbxUnidadMedida.ItemHeight = 14
        Me.cbxUnidadMedida.Items.AddRange(New Object() {Me.ComboItem3, Me.ComboItem4, Me.ComboItem5, Me.ComboItem6, Me.ComboItem7})
        Me.cbxUnidadMedida.Location = New System.Drawing.Point(135, 190)
        Me.cbxUnidadMedida.Name = "cbxUnidadMedida"
        Me.cbxUnidadMedida.Size = New System.Drawing.Size(95, 20)
        Me.cbxUnidadMedida.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbxUnidadMedida.TabIndex = 10
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "QQ,"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "LBS."
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "KG."
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "ML"
        '
        'cbxTipo
        '
        Me.cbxTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxTipo.DisplayMember = "Text"
        Me.cbxTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxTipo.Enabled = False
        Me.cbxTipo.FocusHighlightEnabled = True
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.ItemHeight = 14
        Me.cbxTipo.Location = New System.Drawing.Point(135, 87)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(53, 20)
        Me.cbxTipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbxTipo.TabIndex = 6
        '
        'txtDescripcionEtapa
        '
        '
        '
        '
        Me.txtDescripcionEtapa.Border.BorderBottomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDescripcionEtapa.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDescripcionEtapa.Border.Class = "TextBoxBorder"
        Me.txtDescripcionEtapa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDescripcionEtapa.Enabled = False
        Me.txtDescripcionEtapa.Location = New System.Drawing.Point(194, 112)
        Me.txtDescripcionEtapa.Name = "txtDescripcionEtapa"
        Me.txtDescripcionEtapa.Size = New System.Drawing.Size(206, 20)
        Me.txtDescripcionEtapa.TabIndex = 28
        '
        'txtDescripcionTipo
        '
        '
        '
        '
        Me.txtDescripcionTipo.Border.BorderBottomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDescripcionTipo.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDescripcionTipo.Border.Class = "TextBoxBorder"
        Me.txtDescripcionTipo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDescripcionTipo.Enabled = False
        Me.txtDescripcionTipo.Location = New System.Drawing.Point(194, 87)
        Me.txtDescripcionTipo.Name = "txtDescripcionTipo"
        Me.txtDescripcionTipo.Size = New System.Drawing.Size(206, 20)
        Me.txtDescripcionTipo.TabIndex = 27
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Enabled = False
        Me.ButtonX1.Location = New System.Drawing.Point(489, 230)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(200, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 14
        Me.ButtonX1.Text = "Cargar Imagen..."
        '
        'txtDescripcionMaterail
        '
        '
        '
        '
        Me.txtDescripcionMaterail.Border.Class = "TextBoxBorder"
        Me.txtDescripcionMaterail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDescripcionMaterail.Enabled = False
        Me.txtDescripcionMaterail.FocusHighlightEnabled = True
        Me.txtDescripcionMaterail.Location = New System.Drawing.Point(135, 35)
        Me.txtDescripcionMaterail.MaxLength = 50
        Me.txtDescripcionMaterail.Name = "txtDescripcionMaterail"
        Me.txtDescripcionMaterail.Size = New System.Drawing.Size(265, 20)
        Me.txtDescripcionMaterail.TabIndex = 3
        '
        'txtMarca
        '
        '
        '
        '
        Me.txtMarca.Border.Class = "TextBoxBorder"
        Me.txtMarca.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMarca.Enabled = False
        Me.txtMarca.FocusHighlightEnabled = True
        Me.txtMarca.Location = New System.Drawing.Point(135, 60)
        Me.txtMarca.MaxLength = 50
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(265, 20)
        Me.txtMarca.TabIndex = 5
        '
        'txtCodigo
        '
        '
        '
        '
        Me.txtCodigo.Border.Class = "TextBoxBorder"
        Me.txtCodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.FocusHighlightEnabled = True
        Me.txtCodigo.Location = New System.Drawing.Point(135, 9)
        Me.txtCodigo.MaxLength = 12
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(93, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'txtUsuarioCreador
        '
        '
        '
        '
        Me.txtUsuarioCreador.Border.Class = "TextBoxBorder"
        Me.txtUsuarioCreador.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUsuarioCreador.Enabled = False
        Me.txtUsuarioCreador.Location = New System.Drawing.Point(135, 268)
        Me.txtUsuarioCreador.Name = "txtUsuarioCreador"
        Me.txtUsuarioCreador.Size = New System.Drawing.Size(140, 20)
        Me.txtUsuarioCreador.TabIndex = 25
        '
        'txtIdEtapa
        '
        '
        '
        '
        Me.txtIdEtapa.Border.Class = "TextBoxBorder"
        Me.txtIdEtapa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdEtapa.Enabled = False
        Me.txtIdEtapa.FocusHighlightEnabled = True
        Me.txtIdEtapa.Location = New System.Drawing.Point(135, 112)
        Me.txtIdEtapa.MaxLength = 3
        Me.txtIdEtapa.Name = "txtIdEtapa"
        Me.txtIdEtapa.Size = New System.Drawing.Size(53, 20)
        Me.txtIdEtapa.TabIndex = 7
        '
        'txtPeso
        '
        '
        '
        '
        Me.txtPeso.Border.Class = "TextBoxBorder"
        Me.txtPeso.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPeso.Enabled = False
        Me.txtPeso.FocusHighlightEnabled = True
        Me.txtPeso.Location = New System.Drawing.Point(135, 164)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(93, 20)
        Me.txtPeso.TabIndex = 9
        '
        'txtUnidad_x_Presentacion
        '
        '
        '
        '
        Me.txtUnidad_x_Presentacion.Border.Class = "TextBoxBorder"
        Me.txtUnidad_x_Presentacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUnidad_x_Presentacion.Enabled = False
        Me.txtUnidad_x_Presentacion.FocusHighlightEnabled = True
        Me.txtUnidad_x_Presentacion.Location = New System.Drawing.Point(135, 216)
        Me.txtUnidad_x_Presentacion.Name = "txtUnidad_x_Presentacion"
        Me.txtUnidad_x_Presentacion.Size = New System.Drawing.Size(93, 20)
        Me.txtUnidad_x_Presentacion.TabIndex = 11
        '
        'imgMedicamento
        '
        Me.imgMedicamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imgMedicamento.Location = New System.Drawing.Point(489, 4)
        Me.imgMedicamento.Name = "imgMedicamento"
        Me.imgMedicamento.Size = New System.Drawing.Size(200, 220)
        Me.imgMedicamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgMedicamento.TabIndex = 19
        Me.imgMedicamento.TabStop = False
        '
        'Costo_UnitarioTextBoxX
        '
        '
        '
        '
        Me.Costo_UnitarioTextBoxX.Border.Class = "TextBoxBorder"
        Me.Costo_UnitarioTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Costo_UnitarioTextBoxX.Enabled = False
        Me.Costo_UnitarioTextBoxX.Location = New System.Drawing.Point(494, 135)
        Me.Costo_UnitarioTextBoxX.Name = "Costo_UnitarioTextBoxX"
        Me.Costo_UnitarioTextBoxX.Size = New System.Drawing.Size(33, 20)
        Me.Costo_UnitarioTextBoxX.TabIndex = 21
        Me.Costo_UnitarioTextBoxX.Text = "0.00"
        Me.Costo_UnitarioTextBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Datos del Nuevo Registro"
        '
        'TabItem3
        '
        Me.TabItem3.Name = "TabItem3"
        Me.TabItem3.Text = "TabItem3"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Codigo_Producto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo_Producto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Marca"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IdEtapa"
        Me.DataGridViewTextBoxColumn5.HeaderText = "IdEtapa"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Fecha_Creacion"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fecha_Creacion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Peso"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Unidad_Medida"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Unidad_Medida"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "UxP"
        Me.DataGridViewTextBoxColumn9.HeaderText = "UxP"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "Image"
        Me.DataGridViewImageColumn1.HeaderText = "Image"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Costo_Unitario"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Costo_Unitario"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Fecha_Vencimiento"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Fecha_Vencimiento"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Usuario_Creador"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Usuario_Creador"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Location = New System.Drawing.Point(28, 300)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(102, 13)
        Label2.TabIndex = 37
        Label2.Text = "Orden Alimentación:"
        '
        'ordenalimentacionIntegerInput1
        '
        '
        '
        '
        Me.ordenalimentacionIntegerInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.ordenalimentacionIntegerInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ordenalimentacionIntegerInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.ordenalimentacionIntegerInput1.Location = New System.Drawing.Point(135, 295)
        Me.ordenalimentacionIntegerInput1.MinValue = 0
        Me.ordenalimentacionIntegerInput1.Name = "ordenalimentacionIntegerInput1"
        Me.ordenalimentacionIntegerInput1.ShowUpDown = True
        Me.ordenalimentacionIntegerInput1.Size = New System.Drawing.Size(70, 20)
        Me.ordenalimentacionIntegerInput1.TabIndex = 38
        '
        'frmRegistrarMedicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 393)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.DoubleBuffered = True
        Me.Name = "frmRegistrarMedicamentos"
        Me.Text = "Ingreso de códigos nuevos"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        CType(Me.ImagenVacia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgMedicamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordenalimentacionIntegerInput1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtDescripcionMaterail As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtMarca As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtIdEtapa As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPeso As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtUnidad_x_Presentacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents imgMedicamento As System.Windows.Forms.PictureBox
    Friend WithEvents Costo_UnitarioTextBoxX As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtUsuarioCreador As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnGuardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtDescripcionTipo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtDescripcionEtapa As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents cbxTipo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbxUnidadMedida As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents TabItem3 As DevComponents.DotNetBar.TabItem
    Friend WithEvents txtFechaCreacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtFechaVencimiento As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImagenVacia As System.Windows.Forms.PictureBox
    Friend WithEvents bodegasCheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents costoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ordenalimentacionIntegerInput1 As DevComponents.Editors.IntegerInput
End Class
