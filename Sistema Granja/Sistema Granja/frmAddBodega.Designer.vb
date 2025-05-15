<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBodega
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddBodega))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.Panel19 = New System.Windows.Forms.Panel
        Me.Panel21 = New System.Windows.Forms.Panel
        Me.btnGrabar = New DevComponents.DotNetBar.ButtonX
        Me.Panel20 = New System.Windows.Forms.Panel
        Me.btnCerrar = New DevComponents.DotNetBar.ButtonX
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtDescripcionGranja = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtCodGranja = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel29 = New System.Windows.Forms.Panel
        Me.Panel30 = New System.Windows.Forms.Panel
        Me.cbxManejaVaporNo = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.cbxManejaVaporSi = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.Panel33 = New System.Windows.Forms.Panel
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.Panel28 = New System.Windows.Forms.Panel
        Me.Panel31 = New System.Windows.Forms.Panel
        Me.txtLiquidador = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Panel32 = New System.Windows.Forms.Panel
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX
        Me.Panel23 = New System.Windows.Forms.Panel
        Me.Panel24 = New System.Windows.Forms.Panel
        Me.cbxNo = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.cbxActivaSi = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.Panel25 = New System.Windows.Forms.Panel
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX
        Me.Panel26 = New System.Windows.Forms.Panel
        Me.txtVendedor = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Panel27 = New System.Windows.Forms.Panel
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.Panel18 = New System.Windows.Forms.Panel
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.txtCtaInventario = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.txtCtaCostos = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Panel17 = New System.Windows.Forms.Panel
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.txtCtaVentas = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.txtFacturar = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.txtDescripción = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtBodega = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter
        Me.RibbonClientPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel29.SuspendLayout()
        Me.Panel30.SuspendLayout()
        Me.Panel33.SuspendLayout()
        Me.Panel28.SuspendLayout()
        Me.Panel31.SuspendLayout()
        Me.Panel32.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.Panel25.SuspendLayout()
        Me.Panel26.SuspendLayout()
        Me.Panel27.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.GroupPanel2)
        Me.RibbonClientPanel1.Controls.Add(Me.GroupPanel1)
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonClientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonClientPanel1.Name = "RibbonClientPanel1"
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(421, 296)
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
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.Panel19)
        Me.GroupPanel2.Location = New System.Drawing.Point(2, 247)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(416, 45)
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
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.Panel21)
        Me.Panel19.Controls.Add(Me.Panel20)
        Me.Panel19.Location = New System.Drawing.Point(145, 1)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(264, 37)
        Me.Panel19.TabIndex = 0
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.btnGrabar)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel21.Location = New System.Drawing.Point(54, 0)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(106, 37)
        Me.Panel21.TabIndex = 1
        '
        'btnGrabar
        '
        Me.btnGrabar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGrabar.CallBasePaintBackground = True
        Me.btnGrabar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGrabar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnGrabar.Location = New System.Drawing.Point(0, 0)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(106, 37)
        Me.btnGrabar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGrabar.TabIndex = 1
        Me.btnGrabar.Text = "&Guardar"
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.btnCerrar)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel20.Location = New System.Drawing.Point(160, 0)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(104, 37)
        Me.Panel20.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCerrar.CallBasePaintBackground = True
        Me.btnCerrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCerrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnCerrar.Location = New System.Drawing.Point(0, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(104, 37)
        Me.btnCerrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.Text = "&Cerrar"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.txtDescripcionGranja)
        Me.GroupPanel1.Controls.Add(Me.txtCodGranja)
        Me.GroupPanel1.Controls.Add(Me.LabelX7)
        Me.GroupPanel1.Controls.Add(Me.Panel1)
        Me.GroupPanel1.Location = New System.Drawing.Point(2, 14)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(416, 232)
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
        Me.GroupPanel1.Text = "Datos de la Bodega"
        '
        'txtDescripcionGranja
        '
        '
        '
        '
        Me.txtDescripcionGranja.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDescripcionGranja.Border.Class = "TextBoxBorder"
        Me.txtDescripcionGranja.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDescripcionGranja.Enabled = False
        Me.txtDescripcionGranja.Location = New System.Drawing.Point(151, 183)
        Me.txtDescripcionGranja.MaxLength = 8
        Me.txtDescripcionGranja.Name = "txtDescripcionGranja"
        Me.txtDescripcionGranja.Size = New System.Drawing.Size(251, 20)
        Me.txtDescripcionGranja.TabIndex = 3
        '
        'txtCodGranja
        '
        '
        '
        '
        Me.txtCodGranja.Border.Class = "TextBoxBorder"
        Me.txtCodGranja.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCodGranja.Enabled = False
        Me.txtCodGranja.Location = New System.Drawing.Point(98, 183)
        Me.txtCodGranja.MaxLength = 8
        Me.txtCodGranja.Name = "txtCodGranja"
        Me.txtCodGranja.Size = New System.Drawing.Size(51, 20)
        Me.txtCodGranja.TabIndex = 2
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.Class = ""
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(21, 182)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(75, 20)
        Me.LabelX7.TabIndex = 1
        Me.LabelX7.Text = "Granja:"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel29)
        Me.Panel1.Controls.Add(Me.Panel28)
        Me.Panel1.Controls.Add(Me.Panel23)
        Me.Panel1.Controls.Add(Me.Panel13)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(404, 173)
        Me.Panel1.TabIndex = 0
        '
        'Panel29
        '
        Me.Panel29.Controls.Add(Me.Panel30)
        Me.Panel29.Controls.Add(Me.Panel33)
        Me.Panel29.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel29.Location = New System.Drawing.Point(0, 144)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(404, 24)
        Me.Panel29.TabIndex = 6
        '
        'Panel30
        '
        Me.Panel30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel30.Controls.Add(Me.cbxManejaVaporNo)
        Me.Panel30.Controls.Add(Me.cbxManejaVaporSi)
        Me.Panel30.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel30.Location = New System.Drawing.Point(284, 0)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(106, 24)
        Me.Panel30.TabIndex = 1
        '
        'cbxManejaVaporNo
        '
        '
        '
        '
        Me.cbxManejaVaporNo.BackgroundStyle.Class = ""
        Me.cbxManejaVaporNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbxManejaVaporNo.Enabled = False
        Me.Highlighter1.SetHighlightOnFocus(Me.cbxManejaVaporNo, True)
        Me.cbxManejaVaporNo.Location = New System.Drawing.Point(57, 0)
        Me.cbxManejaVaporNo.Name = "cbxManejaVaporNo"
        Me.cbxManejaVaporNo.Size = New System.Drawing.Size(39, 23)
        Me.cbxManejaVaporNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbxManejaVaporNo.TabIndex = 1
        Me.cbxManejaVaporNo.Text = "No"
        '
        'cbxManejaVaporSi
        '
        '
        '
        '
        Me.cbxManejaVaporSi.BackgroundStyle.Class = ""
        Me.cbxManejaVaporSi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbxManejaVaporSi.Enabled = False
        Me.Highlighter1.SetHighlightOnFocus(Me.cbxManejaVaporSi, True)
        Me.cbxManejaVaporSi.Location = New System.Drawing.Point(6, -1)
        Me.cbxManejaVaporSi.Name = "cbxManejaVaporSi"
        Me.cbxManejaVaporSi.Size = New System.Drawing.Size(39, 23)
        Me.cbxManejaVaporSi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbxManejaVaporSi.TabIndex = 0
        Me.cbxManejaVaporSi.Text = "Sí"
        '
        'Panel33
        '
        Me.Panel33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel33.Controls.Add(Me.LabelX11)
        Me.Panel33.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel33.Location = New System.Drawing.Point(0, 0)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(284, 24)
        Me.Panel33.TabIndex = 0
        '
        'LabelX11
        '
        '
        '
        '
        Me.LabelX11.BackgroundStyle.Class = ""
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Location = New System.Drawing.Point(176, 1)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(75, 20)
        Me.LabelX11.TabIndex = 0
        Me.LabelX11.Text = "Maneja Vapor:"
        Me.LabelX11.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel28
        '
        Me.Panel28.Controls.Add(Me.Panel31)
        Me.Panel28.Controls.Add(Me.Panel32)
        Me.Panel28.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel28.Location = New System.Drawing.Point(0, 120)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(404, 24)
        Me.Panel28.TabIndex = 5
        '
        'Panel31
        '
        Me.Panel31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel31.Controls.Add(Me.txtLiquidador)
        Me.Panel31.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel31.Location = New System.Drawing.Point(93, 0)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(225, 24)
        Me.Panel31.TabIndex = 1
        '
        'txtLiquidador
        '
        '
        '
        '
        Me.txtLiquidador.Border.Class = "TextBoxBorder"
        Me.txtLiquidador.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtLiquidador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLiquidador.Enabled = False
        Me.Highlighter1.SetHighlightOnFocus(Me.txtLiquidador, True)
        Me.txtLiquidador.Location = New System.Drawing.Point(0, 0)
        Me.txtLiquidador.MaxLength = 20
        Me.txtLiquidador.Name = "txtLiquidador"
        Me.txtLiquidador.Size = New System.Drawing.Size(221, 20)
        Me.txtLiquidador.TabIndex = 1
        '
        'Panel32
        '
        Me.Panel32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel32.Controls.Add(Me.LabelX12)
        Me.Panel32.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel32.Location = New System.Drawing.Point(0, 0)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(93, 24)
        Me.Panel32.TabIndex = 0
        '
        'LabelX12
        '
        '
        '
        '
        Me.LabelX12.BackgroundStyle.Class = ""
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(16, 0)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(75, 20)
        Me.LabelX12.TabIndex = 0
        Me.LabelX12.Text = "Liquidador:"
        Me.LabelX12.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel23
        '
        Me.Panel23.Controls.Add(Me.Panel24)
        Me.Panel23.Controls.Add(Me.Panel25)
        Me.Panel23.Controls.Add(Me.Panel26)
        Me.Panel23.Controls.Add(Me.Panel27)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel23.Location = New System.Drawing.Point(0, 96)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(404, 24)
        Me.Panel23.TabIndex = 4
        '
        'Panel24
        '
        Me.Panel24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel24.Controls.Add(Me.cbxNo)
        Me.Panel24.Controls.Add(Me.cbxActivaSi)
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel24.Location = New System.Drawing.Point(285, 0)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(106, 24)
        Me.Panel24.TabIndex = 3
        '
        'cbxNo
        '
        '
        '
        '
        Me.cbxNo.BackgroundStyle.Class = ""
        Me.cbxNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbxNo.Enabled = False
        Me.Highlighter1.SetHighlightOnFocus(Me.cbxNo, True)
        Me.cbxNo.Location = New System.Drawing.Point(57, -1)
        Me.cbxNo.Name = "cbxNo"
        Me.cbxNo.Size = New System.Drawing.Size(39, 23)
        Me.cbxNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbxNo.TabIndex = 3
        Me.cbxNo.Text = "No"
        '
        'cbxActivaSi
        '
        '
        '
        '
        Me.cbxActivaSi.BackgroundStyle.Class = ""
        Me.cbxActivaSi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbxActivaSi.Enabled = False
        Me.Highlighter1.SetHighlightOnFocus(Me.cbxActivaSi, True)
        Me.cbxActivaSi.Location = New System.Drawing.Point(6, -1)
        Me.cbxActivaSi.Name = "cbxActivaSi"
        Me.cbxActivaSi.Size = New System.Drawing.Size(39, 23)
        Me.cbxActivaSi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbxActivaSi.TabIndex = 2
        Me.cbxActivaSi.Text = "Sí"
        '
        'Panel25
        '
        Me.Panel25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel25.Controls.Add(Me.LabelX9)
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel25.Location = New System.Drawing.Point(146, 0)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(139, 24)
        Me.Panel25.TabIndex = 2
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.Class = ""
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(50, 0)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(48, 20)
        Me.LabelX9.TabIndex = 0
        Me.LabelX9.Text = "Activa:"
        Me.LabelX9.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel26
        '
        Me.Panel26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel26.Controls.Add(Me.txtVendedor)
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel26.Location = New System.Drawing.Point(93, 0)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(53, 24)
        Me.Panel26.TabIndex = 1
        '
        'txtVendedor
        '
        '
        '
        '
        Me.txtVendedor.Border.Class = "TextBoxBorder"
        Me.txtVendedor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtVendedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtVendedor.Enabled = False
        Me.Highlighter1.SetHighlightOnFocus(Me.txtVendedor, True)
        Me.txtVendedor.Location = New System.Drawing.Point(0, 0)
        Me.txtVendedor.MaxLength = 4
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.Size = New System.Drawing.Size(49, 20)
        Me.txtVendedor.TabIndex = 1
        '
        'Panel27
        '
        Me.Panel27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel27.Controls.Add(Me.LabelX10)
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel27.Location = New System.Drawing.Point(0, 0)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(93, 24)
        Me.Panel27.TabIndex = 0
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.Class = ""
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(14, 0)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(75, 20)
        Me.LabelX10.TabIndex = 0
        Me.LabelX10.Text = "Vendedor:"
        Me.LabelX10.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.Panel18)
        Me.Panel13.Controls.Add(Me.Panel14)
        Me.Panel13.Controls.Add(Me.Panel15)
        Me.Panel13.Controls.Add(Me.Panel16)
        Me.Panel13.Controls.Add(Me.Panel17)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 72)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(404, 24)
        Me.Panel13.TabIndex = 3
        '
        'Panel18
        '
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel18.Location = New System.Drawing.Point(401, 0)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(3, 24)
        Me.Panel18.TabIndex = 4
        '
        'Panel14
        '
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel14.Controls.Add(Me.txtCtaInventario)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel14.Location = New System.Drawing.Point(285, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(116, 24)
        Me.Panel14.TabIndex = 3
        '
        'txtCtaInventario
        '
        '
        '
        '
        Me.txtCtaInventario.Border.Class = "TextBoxBorder"
        Me.txtCtaInventario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCtaInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCtaInventario.Enabled = False
        Me.Highlighter1.SetHighlightOnFocus(Me.txtCtaInventario, True)
        Me.txtCtaInventario.Location = New System.Drawing.Point(0, 0)
        Me.txtCtaInventario.MaxLength = 15
        Me.txtCtaInventario.Name = "txtCtaInventario"
        Me.txtCtaInventario.Size = New System.Drawing.Size(112, 20)
        Me.txtCtaInventario.TabIndex = 1
        Me.txtCtaInventario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel15
        '
        Me.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel15.Controls.Add(Me.LabelX5)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel15.Location = New System.Drawing.Point(202, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(83, 24)
        Me.Panel15.TabIndex = 2
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(4, 0)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(76, 20)
        Me.LabelX5.TabIndex = 0
        Me.LabelX5.Text = "Cta. Inventario:"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel16
        '
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel16.Controls.Add(Me.txtCtaCostos)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel16.Location = New System.Drawing.Point(93, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(109, 24)
        Me.Panel16.TabIndex = 1
        '
        'txtCtaCostos
        '
        '
        '
        '
        Me.txtCtaCostos.Border.Class = "TextBoxBorder"
        Me.txtCtaCostos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCtaCostos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCtaCostos.Enabled = False
        Me.Highlighter1.SetHighlightOnFocus(Me.txtCtaCostos, True)
        Me.txtCtaCostos.Location = New System.Drawing.Point(0, 0)
        Me.txtCtaCostos.MaxLength = 15
        Me.txtCtaCostos.Name = "txtCtaCostos"
        Me.txtCtaCostos.Size = New System.Drawing.Size(105, 20)
        Me.txtCtaCostos.TabIndex = 1
        Me.txtCtaCostos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel17
        '
        Me.Panel17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel17.Controls.Add(Me.LabelX6)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel17.Location = New System.Drawing.Point(0, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(93, 24)
        Me.Panel17.TabIndex = 0
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(9, 0)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(75, 20)
        Me.LabelX6.TabIndex = 0
        Me.LabelX6.Text = "Cta. Costos:"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Panel11)
        Me.Panel8.Controls.Add(Me.Panel12)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Controls.Add(Me.Panel10)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 48)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(404, 24)
        Me.Panel8.TabIndex = 2
        '
        'Panel11
        '
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel11.Controls.Add(Me.txtCtaVentas)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(258, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(144, 24)
        Me.Panel11.TabIndex = 3
        '
        'txtCtaVentas
        '
        '
        '
        '
        Me.txtCtaVentas.Border.Class = "TextBoxBorder"
        Me.txtCtaVentas.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCtaVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCtaVentas.Enabled = False
        Me.Highlighter1.SetHighlightOnFocus(Me.txtCtaVentas, True)
        Me.txtCtaVentas.Location = New System.Drawing.Point(0, 0)
        Me.txtCtaVentas.MaxLength = 15
        Me.txtCtaVentas.Name = "txtCtaVentas"
        Me.txtCtaVentas.Size = New System.Drawing.Size(140, 20)
        Me.txtCtaVentas.TabIndex = 1
        Me.txtCtaVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel12
        '
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel12.Controls.Add(Me.LabelX4)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel12.Location = New System.Drawing.Point(125, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(133, 24)
        Me.Panel12.TabIndex = 2
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(51, 1)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(75, 20)
        Me.LabelX4.TabIndex = 0
        Me.LabelX4.Text = "Cta. Ventas:"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel9.Controls.Add(Me.txtFacturar)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(93, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(32, 24)
        Me.Panel9.TabIndex = 1
        '
        'txtFacturar
        '
        '
        '
        '
        Me.txtFacturar.Border.Class = "TextBoxBorder"
        Me.txtFacturar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFacturar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFacturar.Enabled = False
        Me.Highlighter1.SetHighlightOnFocus(Me.txtFacturar, True)
        Me.txtFacturar.Location = New System.Drawing.Point(0, 0)
        Me.txtFacturar.MaxLength = 1
        Me.txtFacturar.Name = "txtFacturar"
        Me.txtFacturar.Size = New System.Drawing.Size(28, 20)
        Me.txtFacturar.TabIndex = 1
        Me.txtFacturar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Controls.Add(Me.LabelX3)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(93, 24)
        Me.Panel10.TabIndex = 0
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(9, 0)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 20)
        Me.LabelX3.TabIndex = 0
        Me.LabelX3.Text = "Facturar:"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 24)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(404, 24)
        Me.Panel5.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.txtDescripción)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(93, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(309, 24)
        Me.Panel6.TabIndex = 1
        '
        'txtDescripción
        '
        '
        '
        '
        Me.txtDescripción.Border.Class = "TextBoxBorder"
        Me.txtDescripción.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDescripción.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripción.Enabled = False
        Me.Highlighter1.SetHighlightOnFocus(Me.txtDescripción, True)
        Me.txtDescripción.Location = New System.Drawing.Point(0, 0)
        Me.txtDescripción.MaxLength = 30
        Me.txtDescripción.Name = "txtDescripción"
        Me.txtDescripción.Size = New System.Drawing.Size(305, 20)
        Me.txtDescripción.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.LabelX2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(93, 24)
        Me.Panel7.TabIndex = 0
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(7, 0)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 20)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Descripción:"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(404, 24)
        Me.Panel2.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.LabelX1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(170, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(135, 24)
        Me.Panel4.TabIndex = 1
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(18, 0)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 20)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Bodega:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtBodega)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(305, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(99, 24)
        Me.Panel3.TabIndex = 0
        '
        'txtBodega
        '
        '
        '
        '
        Me.txtBodega.Border.Class = "TextBoxBorder"
        Me.txtBodega.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBodega.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Highlighter1.SetHighlightOnFocus(Me.txtBodega, True)
        Me.txtBodega.Location = New System.Drawing.Point(0, 0)
        Me.txtBodega.MaxLength = 4
        Me.txtBodega.Name = "txtBodega"
        Me.txtBodega.Size = New System.Drawing.Size(95, 20)
        Me.txtBodega.TabIndex = 0
        Me.txtBodega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'frmAddBodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 296)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddBodega"
        Me.Text = "..::Nueva Bodega::.."
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.Panel21.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel29.ResumeLayout(False)
        Me.Panel30.ResumeLayout(False)
        Me.Panel33.ResumeLayout(False)
        Me.Panel28.ResumeLayout(False)
        Me.Panel31.ResumeLayout(False)
        Me.Panel32.ResumeLayout(False)
        Me.Panel23.ResumeLayout(False)
        Me.Panel24.ResumeLayout(False)
        Me.Panel25.ResumeLayout(False)
        Me.Panel26.ResumeLayout(False)
        Me.Panel27.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents txtCtaVentas As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents txtFacturar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtDescripción As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBodega As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents Panel24 As System.Windows.Forms.Panel
    Friend WithEvents Panel25 As System.Windows.Forms.Panel
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel26 As System.Windows.Forms.Panel
    Friend WithEvents txtVendedor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel27 As System.Windows.Forms.Panel
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents txtCtaInventario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents txtCtaCostos As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel28 As System.Windows.Forms.Panel
    Friend WithEvents Panel31 As System.Windows.Forms.Panel
    Friend WithEvents txtLiquidador As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel32 As System.Windows.Forms.Panel
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel29 As System.Windows.Forms.Panel
    Friend WithEvents Panel30 As System.Windows.Forms.Panel
    Friend WithEvents Panel33 As System.Windows.Forms.Panel
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents btnGrabar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbxManejaVaporNo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbxManejaVaporSi As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbxNo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbxActivaSi As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents txtDescripcionGranja As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCodGranja As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
End Class
