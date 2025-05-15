<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrar_Verraco
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
        Dim Codigo_CerdoLabel As System.Windows.Forms.Label
        Dim Fecha_NacimientoLabel As System.Windows.Forms.Label
        Dim PadreLabel As System.Windows.Forms.Label
        Dim MadreLabel As System.Windows.Forms.Label
        Dim GeneticaLabel As System.Windows.Forms.Label
        Dim CostoLabel As System.Windows.Forms.Label
        Dim DepreciacionLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistrar_Verraco))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.btnGuardar = New DevComponents.DotNetBar.ButtonX()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.origenTextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.pesoDoubleInput1 = New DevComponents.Editors.DoubleInput()
        Me.notaTextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.clasificacionComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtDepreciacion = New DevComponents.Editors.IntegerInput()
        Me.txtValorResidual = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtDocumentoNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtFecha = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPadre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtMadre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtGenetica = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCosto = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Codigo_CerdoLabel = New System.Windows.Forms.Label()
        Fecha_NacimientoLabel = New System.Windows.Forms.Label()
        PadreLabel = New System.Windows.Forms.Label()
        MadreLabel = New System.Windows.Forms.Label()
        GeneticaLabel = New System.Windows.Forms.Label()
        CostoLabel = New System.Windows.Forms.Label()
        DepreciacionLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Me.RibbonClientPanel1.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.pesoDoubleInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepreciacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Codigo_CerdoLabel
        '
        Codigo_CerdoLabel.AutoSize = True
        Codigo_CerdoLabel.BackColor = System.Drawing.Color.Transparent
        Codigo_CerdoLabel.Location = New System.Drawing.Point(107, 43)
        Codigo_CerdoLabel.Name = "Codigo_CerdoLabel"
        Codigo_CerdoLabel.Size = New System.Drawing.Size(74, 13)
        Codigo_CerdoLabel.TabIndex = 0
        Codigo_CerdoLabel.Text = "Codigo Cerdo:"
        '
        'Fecha_NacimientoLabel
        '
        Fecha_NacimientoLabel.AutoSize = True
        Fecha_NacimientoLabel.BackColor = System.Drawing.Color.Transparent
        Fecha_NacimientoLabel.Location = New System.Drawing.Point(107, 66)
        Fecha_NacimientoLabel.Name = "Fecha_NacimientoLabel"
        Fecha_NacimientoLabel.Size = New System.Drawing.Size(79, 13)
        Fecha_NacimientoLabel.TabIndex = 2
        Fecha_NacimientoLabel.Text = "Fecha Compra:"
        '
        'PadreLabel
        '
        PadreLabel.AutoSize = True
        PadreLabel.BackColor = System.Drawing.Color.Transparent
        PadreLabel.Location = New System.Drawing.Point(107, 95)
        PadreLabel.Name = "PadreLabel"
        PadreLabel.Size = New System.Drawing.Size(38, 13)
        PadreLabel.TabIndex = 4
        PadreLabel.Text = "Padre:"
        '
        'MadreLabel
        '
        MadreLabel.AutoSize = True
        MadreLabel.BackColor = System.Drawing.Color.Transparent
        MadreLabel.Location = New System.Drawing.Point(107, 121)
        MadreLabel.Name = "MadreLabel"
        MadreLabel.Size = New System.Drawing.Size(40, 13)
        MadreLabel.TabIndex = 6
        MadreLabel.Text = "Madre:"
        '
        'GeneticaLabel
        '
        GeneticaLabel.AutoSize = True
        GeneticaLabel.BackColor = System.Drawing.Color.Transparent
        GeneticaLabel.Location = New System.Drawing.Point(366, 16)
        GeneticaLabel.Name = "GeneticaLabel"
        GeneticaLabel.Size = New System.Drawing.Size(53, 13)
        GeneticaLabel.TabIndex = 8
        GeneticaLabel.Text = "Genetica:"
        '
        'CostoLabel
        '
        CostoLabel.AutoSize = True
        CostoLabel.BackColor = System.Drawing.Color.Transparent
        CostoLabel.Location = New System.Drawing.Point(366, 42)
        CostoLabel.Name = "CostoLabel"
        CostoLabel.Size = New System.Drawing.Size(37, 13)
        CostoLabel.TabIndex = 10
        CostoLabel.Text = "Costo:"
        '
        'DepreciacionLabel
        '
        DepreciacionLabel.AutoSize = True
        DepreciacionLabel.BackColor = System.Drawing.Color.Transparent
        DepreciacionLabel.Location = New System.Drawing.Point(366, 95)
        DepreciacionLabel.Name = "DepreciacionLabel"
        DepreciacionLabel.Size = New System.Drawing.Size(100, 13)
        DepreciacionLabel.TabIndex = 12
        DepreciacionLabel.Text = "Años Depreciacion:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Location = New System.Drawing.Point(107, 15)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(82, 13)
        Label1.TabIndex = 14
        Label1.Text = "Documento No:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Location = New System.Drawing.Point(366, 68)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(78, 13)
        Label2.TabIndex = 15
        Label2.Text = "Valor Residual:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Location = New System.Drawing.Point(107, 148)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(69, 13)
        Label3.TabIndex = 19
        Label3.Text = "Clasificación:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Location = New System.Drawing.Point(366, 121)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(41, 13)
        Label4.TabIndex = 20
        Label4.Text = "Origen:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.Transparent
        Label5.Location = New System.Drawing.Point(366, 147)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(74, 13)
        Label5.TabIndex = 21
        Label5.Text = "Peso Entrada:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.Transparent
        Label6.Location = New System.Drawing.Point(107, 173)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(38, 13)
        Label6.TabIndex = 22
        Label6.Text = "Notas:"
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.GroupPanel3)
        Me.RibbonClientPanel1.Controls.Add(Me.PanelEx2)
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonClientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonClientPanel1.Name = "RibbonClientPanel1"
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(643, 355)
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
        Me.GroupPanel3.Controls.Add(Me.Panel18)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Location = New System.Drawing.Point(1, 317)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(642, 36)
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
        Me.GroupPanel3.TabIndex = 4
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.Transparent
        Me.Panel18.Controls.Add(Me.Panel21)
        Me.Panel18.Controls.Add(Me.Panel20)
        Me.Panel18.Controls.Add(Me.Panel19)
        Me.Panel18.Location = New System.Drawing.Point(305, 0)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(327, 30)
        Me.Panel18.TabIndex = 0
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.btnNuevo)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel21.Location = New System.Drawing.Point(0, 0)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(100, 30)
        Me.Panel21.TabIndex = 2
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNuevo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btnNuevo.Location = New System.Drawing.Point(0, 0)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(100, 30)
        Me.btnNuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "&Nuevo"
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.btnGuardar)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel20.Location = New System.Drawing.Point(100, 0)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(132, 30)
        Me.Panel20.TabIndex = 1
        '
        'btnGuardar
        '
        Me.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btnGuardar.Location = New System.Drawing.Point(0, 0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(132, 30)
        Me.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "&Guardar Registro"
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.btnCerrar)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel19.Location = New System.Drawing.Point(232, 0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(95, 30)
        Me.Panel19.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCerrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btnCerrar.Location = New System.Drawing.Point(0, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(95, 30)
        Me.btnCerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.Text = "&Cerrar"
        '
        'PanelEx2
        '
        Me.PanelEx2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.TabControl1)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(1, 12)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(642, 302)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 1
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
        Me.TabControl1.Size = New System.Drawing.Size(642, 302)
        Me.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.AutoScroll = True
        Me.TabControlPanel1.Controls.Add(Me.origenTextBoxX2)
        Me.TabControlPanel1.Controls.Add(Me.pesoDoubleInput1)
        Me.TabControlPanel1.Controls.Add(Me.notaTextBoxX1)
        Me.TabControlPanel1.Controls.Add(Label6)
        Me.TabControlPanel1.Controls.Add(Label5)
        Me.TabControlPanel1.Controls.Add(Label4)
        Me.TabControlPanel1.Controls.Add(Label3)
        Me.TabControlPanel1.Controls.Add(Me.clasificacionComboBoxEx1)
        Me.TabControlPanel1.Controls.Add(Me.txtDepreciacion)
        Me.TabControlPanel1.Controls.Add(Label2)
        Me.TabControlPanel1.Controls.Add(Me.txtValorResidual)
        Me.TabControlPanel1.Controls.Add(Me.txtDocumentoNo)
        Me.TabControlPanel1.Controls.Add(Label1)
        Me.TabControlPanel1.Controls.Add(Me.txtFecha)
        Me.TabControlPanel1.Controls.Add(Me.PictureBox1)
        Me.TabControlPanel1.Controls.Add(Codigo_CerdoLabel)
        Me.TabControlPanel1.Controls.Add(Me.txtCodigo)
        Me.TabControlPanel1.Controls.Add(Fecha_NacimientoLabel)
        Me.TabControlPanel1.Controls.Add(PadreLabel)
        Me.TabControlPanel1.Controls.Add(Me.txtPadre)
        Me.TabControlPanel1.Controls.Add(MadreLabel)
        Me.TabControlPanel1.Controls.Add(Me.txtMadre)
        Me.TabControlPanel1.Controls.Add(GeneticaLabel)
        Me.TabControlPanel1.Controls.Add(Me.txtGenetica)
        Me.TabControlPanel1.Controls.Add(CostoLabel)
        Me.TabControlPanel1.Controls.Add(Me.txtCosto)
        Me.TabControlPanel1.Controls.Add(DepreciacionLabel)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(642, 280)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'origenTextBoxX2
        '
        '
        '
        '
        Me.origenTextBoxX2.Border.Class = "TextBoxBorder"
        Me.origenTextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.origenTextBoxX2.Enabled = False
        Me.origenTextBoxX2.FocusHighlightEnabled = True
        Me.origenTextBoxX2.Location = New System.Drawing.Point(473, 118)
        Me.origenTextBoxX2.MaxLength = 100
        Me.origenTextBoxX2.Name = "origenTextBoxX2"
        Me.origenTextBoxX2.Size = New System.Drawing.Size(157, 20)
        Me.origenTextBoxX2.TabIndex = 10
        '
        'pesoDoubleInput1
        '
        '
        '
        '
        Me.pesoDoubleInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.pesoDoubleInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pesoDoubleInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.pesoDoubleInput1.Increment = 1.0R
        Me.pesoDoubleInput1.Location = New System.Drawing.Point(473, 146)
        Me.pesoDoubleInput1.Name = "pesoDoubleInput1"
        Me.pesoDoubleInput1.ShowUpDown = True
        Me.pesoDoubleInput1.Size = New System.Drawing.Size(80, 20)
        Me.pesoDoubleInput1.TabIndex = 11
        '
        'notaTextBoxX1
        '
        '
        '
        '
        Me.notaTextBoxX1.Border.Class = "TextBoxBorder"
        Me.notaTextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.notaTextBoxX1.Enabled = False
        Me.notaTextBoxX1.FocusHighlightEnabled = True
        Me.notaTextBoxX1.Location = New System.Drawing.Point(200, 173)
        Me.notaTextBoxX1.MaxLength = 250
        Me.notaTextBoxX1.Multiline = True
        Me.notaTextBoxX1.Name = "notaTextBoxX1"
        Me.notaTextBoxX1.Size = New System.Drawing.Size(430, 71)
        Me.notaTextBoxX1.TabIndex = 25
        '
        'clasificacionComboBoxEx1
        '
        Me.clasificacionComboBoxEx1.DisplayMember = "Text"
        Me.clasificacionComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.clasificacionComboBoxEx1.FormattingEnabled = True
        Me.clasificacionComboBoxEx1.ItemHeight = 14
        Me.clasificacionComboBoxEx1.Location = New System.Drawing.Point(200, 144)
        Me.clasificacionComboBoxEx1.Name = "clasificacionComboBoxEx1"
        Me.clasificacionComboBoxEx1.Size = New System.Drawing.Size(142, 20)
        Me.clasificacionComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.clasificacionComboBoxEx1.TabIndex = 5
        '
        'txtDepreciacion
        '
        '
        '
        '
        Me.txtDepreciacion.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtDepreciacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDepreciacion.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtDepreciacion.Enabled = False
        Me.txtDepreciacion.Location = New System.Drawing.Point(473, 92)
        Me.txtDepreciacion.MaxValue = 5
        Me.txtDepreciacion.MinValue = 1
        Me.txtDepreciacion.Name = "txtDepreciacion"
        Me.txtDepreciacion.ShowUpDown = True
        Me.txtDepreciacion.Size = New System.Drawing.Size(80, 20)
        Me.txtDepreciacion.TabIndex = 9
        Me.txtDepreciacion.Value = 5
        '
        'txtValorResidual
        '
        '
        '
        '
        Me.txtValorResidual.Border.Class = "TextBoxBorder"
        Me.txtValorResidual.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtValorResidual.Enabled = False
        Me.txtValorResidual.FocusHighlightEnabled = True
        Me.txtValorResidual.Location = New System.Drawing.Point(474, 65)
        Me.txtValorResidual.Name = "txtValorResidual"
        Me.txtValorResidual.Size = New System.Drawing.Size(79, 20)
        Me.txtValorResidual.TabIndex = 8
        Me.txtValorResidual.WatermarkText = "$"
        '
        'txtDocumentoNo
        '
        '
        '
        '
        Me.txtDocumentoNo.Border.Class = "TextBoxBorder"
        Me.txtDocumentoNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDocumentoNo.Enabled = False
        Me.txtDocumentoNo.FocusHighlightEnabled = True
        Me.txtDocumentoNo.Location = New System.Drawing.Point(200, 14)
        Me.txtDocumentoNo.Name = "txtDocumentoNo"
        Me.txtDocumentoNo.Size = New System.Drawing.Size(79, 20)
        Me.txtDocumentoNo.TabIndex = 0
        '
        'txtFecha
        '
        '
        '
        '
        Me.txtFecha.Border.Class = "TextBoxBorder"
        Me.txtFecha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFecha.Enabled = False
        Me.txtFecha.FocusHighlightEnabled = True
        Me.txtFecha.Location = New System.Drawing.Point(200, 66)
        Me.txtFecha.MaxLength = 8
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(79, 20)
        Me.txtFecha.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
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
        Me.txtCodigo.Location = New System.Drawing.Point(200, 40)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(79, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'txtPadre
        '
        '
        '
        '
        Me.txtPadre.Border.Class = "TextBoxBorder"
        Me.txtPadre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPadre.Enabled = False
        Me.txtPadre.FocusHighlightEnabled = True
        Me.txtPadre.Location = New System.Drawing.Point(200, 92)
        Me.txtPadre.Name = "txtPadre"
        Me.txtPadre.Size = New System.Drawing.Size(79, 20)
        Me.txtPadre.TabIndex = 3
        '
        'txtMadre
        '
        '
        '
        '
        Me.txtMadre.Border.Class = "TextBoxBorder"
        Me.txtMadre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMadre.Enabled = False
        Me.txtMadre.FocusHighlightEnabled = True
        Me.txtMadre.Location = New System.Drawing.Point(200, 118)
        Me.txtMadre.Name = "txtMadre"
        Me.txtMadre.Size = New System.Drawing.Size(79, 20)
        Me.txtMadre.TabIndex = 4
        '
        'txtGenetica
        '
        '
        '
        '
        Me.txtGenetica.Border.Class = "TextBoxBorder"
        Me.txtGenetica.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtGenetica.Enabled = False
        Me.txtGenetica.FocusHighlightEnabled = True
        Me.txtGenetica.Location = New System.Drawing.Point(474, 13)
        Me.txtGenetica.Name = "txtGenetica"
        Me.txtGenetica.Size = New System.Drawing.Size(79, 20)
        Me.txtGenetica.TabIndex = 6
        '
        'txtCosto
        '
        '
        '
        '
        Me.txtCosto.Border.Class = "TextBoxBorder"
        Me.txtCosto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCosto.Enabled = False
        Me.txtCosto.FocusHighlightEnabled = True
        Me.txtCosto.Location = New System.Drawing.Point(474, 39)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(79, 20)
        Me.txtCosto.TabIndex = 7
        Me.txtCosto.WatermarkText = "$"
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Datos del Verraco"
        '
        'TabItem2
        '
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "Lista de Verracos Actuales"
        '
        'frmRegistrar_Verraco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 355)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.DoubleBuffered = True
        Me.Name = "frmRegistrar_Verraco"
        Me.Text = "Registrar Verraco"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel21.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        CType(Me.pesoDoubleInput1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepreciacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents btnGuardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPadre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtMadre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtGenetica As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCosto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtFecha As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtDocumentoNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtValorResidual As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtDepreciacion As DevComponents.Editors.IntegerInput
    Friend WithEvents clasificacionComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents pesoDoubleInput1 As DevComponents.Editors.DoubleInput
    Friend WithEvents notaTextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents origenTextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
End Class
