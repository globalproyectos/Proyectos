<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRastro))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.btnGuardar = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.txtCorrelativo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.txtJustificacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.cbxDestino = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.txtPeso = New Sistema_Granja.CajaDinero()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txtFechaRastro = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.txtNoDocumento = New Sistema_Granja.CajaEnteros()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtCantidadRastro = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.cbxTipoDocumento = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ListaLotes = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.RibbonClientPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel27.SuspendLayout()
        Me.Panel29.SuspendLayout()
        Me.Panel28.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.Panel26.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.Panel25.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
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
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(587, 247)
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
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.Panel15)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(3, 196)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(580, 46)
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
        Me.GroupPanel2.TabIndex = 7
        '
        'Panel15
        '
        Me.Panel15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel15.Controls.Add(Me.Panel16)
        Me.Panel15.Controls.Add(Me.Panel17)
        Me.Panel15.Location = New System.Drawing.Point(371, 3)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(200, 34)
        Me.Panel15.TabIndex = 5
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.ButtonX1)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel16.Location = New System.Drawing.Point(99, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(99, 34)
        Me.Panel16.TabIndex = 1
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonX1.Image = CType(resources.GetObject("ButtonX1.Image"), System.Drawing.Image)
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.ButtonX1.Location = New System.Drawing.Point(0, 0)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(99, 34)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 4
        Me.ButtonX1.Text = "&Cerrar"
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.btnGuardar)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel17.Location = New System.Drawing.Point(0, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(99, 34)
        Me.Panel17.TabIndex = 0
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
        Me.btnGuardar.Size = New System.Drawing.Size(99, 34)
        Me.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "&Guardar"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.GroupBox1)
        Me.GroupPanel1.Controls.Add(Me.Panel11)
        Me.GroupPanel1.Controls.Add(Me.Panel1)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(3, 10)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(580, 184)
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
        Me.GroupPanel1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel27)
        Me.GroupBox1.Location = New System.Drawing.Point(115, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 49)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Internos Granja"
        '
        'Panel27
        '
        Me.Panel27.Controls.Add(Me.Panel29)
        Me.Panel27.Controls.Add(Me.Panel28)
        Me.Panel27.Location = New System.Drawing.Point(183, 10)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(273, 34)
        Me.Panel27.TabIndex = 0
        '
        'Panel29
        '
        Me.Panel29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel29.Controls.Add(Me.txtCorrelativo)
        Me.Panel29.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel29.Location = New System.Drawing.Point(135, 0)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(134, 34)
        Me.Panel29.TabIndex = 1
        '
        'txtCorrelativo
        '
        Me.txtCorrelativo.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCorrelativo.Border.Class = "TextBoxBorder"
        Me.txtCorrelativo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCorrelativo.DisabledBackColor = System.Drawing.Color.White
        Me.txtCorrelativo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCorrelativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorrelativo.ForeColor = System.Drawing.Color.Black
        Me.txtCorrelativo.Location = New System.Drawing.Point(0, 0)
        Me.txtCorrelativo.MaxLength = 10
        Me.txtCorrelativo.Name = "txtCorrelativo"
        Me.txtCorrelativo.Size = New System.Drawing.Size(130, 30)
        Me.txtCorrelativo.TabIndex = 0
        Me.txtCorrelativo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel28
        '
        Me.Panel28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel28.Controls.Add(Me.LabelX10)
        Me.Panel28.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel28.Location = New System.Drawing.Point(0, 0)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(135, 34)
        Me.Panel28.TabIndex = 0
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.ForeColor = System.Drawing.Color.Red
        Me.LabelX10.Location = New System.Drawing.Point(19, 4)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(113, 23)
        Me.LabelX10.TabIndex = 1
        Me.LabelX10.Text = "NO. CORRELATIVO:"
        Me.LabelX10.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel11.Controls.Add(Me.PictureBox1)
        Me.Panel11.Location = New System.Drawing.Point(4, 1)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(108, 78)
        Me.Panel11.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel22)
        Me.Panel1.Controls.Add(Me.Panel21)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(116, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(454, 122)
        Me.Panel1.TabIndex = 4
        '
        'Panel22
        '
        Me.Panel22.Controls.Add(Me.Panel23)
        Me.Panel22.Controls.Add(Me.Panel26)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel22.Location = New System.Drawing.Point(0, 96)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(454, 24)
        Me.Panel22.TabIndex = 4
        '
        'Panel23
        '
        Me.Panel23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel23.Controls.Add(Me.txtJustificacion)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel23.Location = New System.Drawing.Point(111, 0)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(338, 24)
        Me.Panel23.TabIndex = 1
        '
        'txtJustificacion
        '
        Me.txtJustificacion.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtJustificacion.Border.Class = "TextBoxBorder"
        Me.txtJustificacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtJustificacion.DisabledBackColor = System.Drawing.Color.White
        Me.txtJustificacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtJustificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJustificacion.ForeColor = System.Drawing.Color.Black
        Me.txtJustificacion.Location = New System.Drawing.Point(0, 0)
        Me.txtJustificacion.Name = "txtJustificacion"
        Me.txtJustificacion.Size = New System.Drawing.Size(334, 21)
        Me.txtJustificacion.TabIndex = 2
        '
        'Panel26
        '
        Me.Panel26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel26.Controls.Add(Me.LabelX7)
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel26.Location = New System.Drawing.Point(0, 0)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(111, 24)
        Me.Panel26.TabIndex = 0
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(21, 0)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(83, 23)
        Me.LabelX7.TabIndex = 0
        Me.LabelX7.Text = "Justificación:"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.Panel24)
        Me.Panel21.Controls.Add(Me.Panel25)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel21.Location = New System.Drawing.Point(0, 72)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(454, 24)
        Me.Panel21.TabIndex = 3
        '
        'Panel24
        '
        Me.Panel24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel24.Controls.Add(Me.cbxDestino)
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel24.Location = New System.Drawing.Point(111, 0)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(338, 24)
        Me.Panel24.TabIndex = 1
        '
        'cbxDestino
        '
        Me.cbxDestino.DisplayMember = "Text"
        Me.cbxDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDestino.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxDestino.FormattingEnabled = True
        Me.cbxDestino.ItemHeight = 14
        Me.cbxDestino.Items.AddRange(New Object() {Me.ComboItem3, Me.ComboItem4})
        Me.cbxDestino.Location = New System.Drawing.Point(0, 0)
        Me.cbxDestino.Name = "cbxDestino"
        Me.cbxDestino.Size = New System.Drawing.Size(334, 20)
        Me.cbxDestino.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbxDestino.TabIndex = 1
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Fáctura"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Crédito Fiscal"
        '
        'Panel25
        '
        Me.Panel25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel25.Controls.Add(Me.LabelX8)
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel25.Location = New System.Drawing.Point(0, 0)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(111, 24)
        Me.Panel25.TabIndex = 0
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(21, 0)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(83, 23)
        Me.LabelX8.TabIndex = 0
        Me.LabelX8.Text = "Destino:"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.LabelX9)
        Me.Panel8.Controls.Add(Me.Panel19)
        Me.Panel8.Controls.Add(Me.Panel20)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Controls.Add(Me.Panel10)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 48)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(454, 24)
        Me.Panel8.TabIndex = 2
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(415, 1)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(25, 23)
        Me.LabelX9.TabIndex = 6
        Me.LabelX9.Text = "Lbs."
        Me.LabelX9.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel19
        '
        Me.Panel19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel19.Controls.Add(Me.txtPeso)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel19.Location = New System.Drawing.Point(318, 0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(96, 24)
        Me.Panel19.TabIndex = 3
        '
        'txtPeso
        '
        Me.txtPeso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPeso.Location = New System.Drawing.Point(0, 0)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(92, 20)
        Me.txtPeso.TabIndex = 0
        '
        'Panel20
        '
        Me.Panel20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel20.Controls.Add(Me.LabelX6)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel20.Location = New System.Drawing.Point(207, 0)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(111, 24)
        Me.Panel20.TabIndex = 2
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(21, 0)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(83, 23)
        Me.LabelX6.TabIndex = 0
        Me.LabelX6.Text = "Peso:"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel9.Controls.Add(Me.txtFechaRastro)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(111, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(96, 24)
        Me.Panel9.TabIndex = 1
        '
        'txtFechaRastro
        '
        Me.txtFechaRastro.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtFechaRastro.Border.Class = "TextBoxBorder"
        Me.txtFechaRastro.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFechaRastro.DisabledBackColor = System.Drawing.Color.White
        Me.txtFechaRastro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFechaRastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaRastro.ForeColor = System.Drawing.Color.Black
        Me.txtFechaRastro.Location = New System.Drawing.Point(0, 0)
        Me.txtFechaRastro.MaxLength = 8
        Me.txtFechaRastro.Name = "txtFechaRastro"
        Me.txtFechaRastro.Size = New System.Drawing.Size(92, 21)
        Me.txtFechaRastro.TabIndex = 3
        Me.txtFechaRastro.Text = "dd/mm/aa"
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Controls.Add(Me.LabelX3)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(111, 24)
        Me.Panel10.TabIndex = 0
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(21, 0)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(83, 23)
        Me.LabelX3.TabIndex = 0
        Me.LabelX3.Text = "Fecha Rastro."
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel14)
        Me.Panel5.Controls.Add(Me.Panel18)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 24)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(454, 24)
        Me.Panel5.TabIndex = 1
        '
        'Panel14
        '
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel14.Controls.Add(Me.txtNoDocumento)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel14.Location = New System.Drawing.Point(318, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(96, 24)
        Me.Panel14.TabIndex = 3
        '
        'txtNoDocumento
        '
        Me.txtNoDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNoDocumento.Location = New System.Drawing.Point(0, 0)
        Me.txtNoDocumento.Name = "txtNoDocumento"
        Me.txtNoDocumento.Size = New System.Drawing.Size(92, 20)
        Me.txtNoDocumento.TabIndex = 0
        '
        'Panel18
        '
        Me.Panel18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel18.Controls.Add(Me.LabelX2)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel18.Location = New System.Drawing.Point(207, 0)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(111, 24)
        Me.Panel18.TabIndex = 2
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(7, -1)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(101, 23)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "No. Documento:"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.txtCantidadRastro)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(111, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(96, 24)
        Me.Panel6.TabIndex = 1
        '
        'txtCantidadRastro
        '
        Me.txtCantidadRastro.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCantidadRastro.Border.Class = "TextBoxBorder"
        Me.txtCantidadRastro.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCantidadRastro.DisabledBackColor = System.Drawing.Color.White
        Me.txtCantidadRastro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCantidadRastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadRastro.ForeColor = System.Drawing.Color.Black
        Me.txtCantidadRastro.Location = New System.Drawing.Point(0, 0)
        Me.txtCantidadRastro.Name = "txtCantidadRastro"
        Me.txtCantidadRastro.Size = New System.Drawing.Size(92, 21)
        Me.txtCantidadRastro.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.LabelX4)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(111, 24)
        Me.Panel7.TabIndex = 0
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(-2, 4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(110, 13)
        Me.LabelX4.TabIndex = 1
        Me.LabelX4.Text = "Cantidad de Rastro."
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel12)
        Me.Panel2.Controls.Add(Me.Panel13)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(454, 24)
        Me.Panel2.TabIndex = 0
        '
        'Panel12
        '
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel12.Controls.Add(Me.cbxTipoDocumento)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel12.Location = New System.Drawing.Point(318, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(133, 24)
        Me.Panel12.TabIndex = 3
        '
        'cbxTipoDocumento
        '
        Me.cbxTipoDocumento.DisplayMember = "Text"
        Me.cbxTipoDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxTipoDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoDocumento.FormattingEnabled = True
        Me.cbxTipoDocumento.ItemHeight = 14
        Me.cbxTipoDocumento.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2})
        Me.cbxTipoDocumento.Location = New System.Drawing.Point(0, 0)
        Me.cbxTipoDocumento.Name = "cbxTipoDocumento"
        Me.cbxTipoDocumento.Size = New System.Drawing.Size(129, 20)
        Me.cbxTipoDocumento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbxTipoDocumento.TabIndex = 0
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Fáctura"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Crédito Fiscal"
        '
        'Panel13
        '
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel13.Controls.Add(Me.LabelX1)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel13.Location = New System.Drawing.Point(207, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(111, 24)
        Me.Panel13.TabIndex = 2
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(2, -1)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(102, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Tipo Documento:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.ListaLotes)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(111, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(96, 24)
        Me.Panel4.TabIndex = 1
        '
        'ListaLotes
        '
        Me.ListaLotes.DisplayMember = "Text"
        Me.ListaLotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListaLotes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ListaLotes.FormattingEnabled = True
        Me.ListaLotes.ItemHeight = 14
        Me.ListaLotes.Location = New System.Drawing.Point(0, 0)
        Me.ListaLotes.Name = "ListaLotes"
        Me.ListaLotes.Size = New System.Drawing.Size(92, 20)
        Me.ListaLotes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ListaLotes.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.LabelX5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(111, 24)
        Me.Panel3.TabIndex = 0
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(7, -1)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(101, 23)
        Me.LabelX5.TabIndex = 0
        Me.LabelX5.Text = "Seleccione el Lote."
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'FrmRastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 247)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRastro"
        Me.Text = "..::Registro de Rastro::.."
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel27.ResumeLayout(False)
        Me.Panel29.ResumeLayout(False)
        Me.Panel28.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.Panel23.ResumeLayout(False)
        Me.Panel26.ResumeLayout(False)
        Me.Panel21.ResumeLayout(False)
        Me.Panel24.ResumeLayout(False)
        Me.Panel25.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents btnGuardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtCantidadRastro As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ListaLotes As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents txtFechaRastro As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents cbxTipoDocumento As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNoDocumento As Sistema_Granja.CajaEnteros
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents txtPeso As Sistema_Granja.CajaDinero
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents Panel24 As System.Windows.Forms.Panel
    Friend WithEvents Panel25 As System.Windows.Forms.Panel
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbxDestino As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents txtJustificacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel26 As System.Windows.Forms.Panel
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel27 As System.Windows.Forms.Panel
    Friend WithEvents Panel29 As System.Windows.Forms.Panel
    Friend WithEvents txtCorrelativo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel28 As System.Windows.Forms.Panel
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
End Class
