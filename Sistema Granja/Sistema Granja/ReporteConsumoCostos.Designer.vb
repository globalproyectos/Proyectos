<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteConsumoCostos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteConsumoCostos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.panelEspere = New DevComponents.DotNetBar.PanelEx
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.ProgressBarX1 = New DevComponents.DotNetBar.Controls.ProgressBarX
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.lbHasta = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.lbHoras = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.lbSemanas = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.lbMeses = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lbAños = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.lbDesde = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.DgvCantidadCostos = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.Panel22 = New System.Windows.Forms.Panel
        Me.Panel25 = New System.Windows.Forms.Panel
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX
        Me.Panel24 = New System.Windows.Forms.Panel
        Me.btnExportar = New DevComponents.DotNetBar.ButtonX
        Me.Panel23 = New System.Windows.Forms.Panel
        Me.btnImprimir = New DevComponents.DotNetBar.ButtonX
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.Panel21 = New System.Windows.Forms.Panel
        Me.btnMostrar = New DevComponents.DotNetBar.ButtonX
        Me.Panel20 = New System.Windows.Forms.Panel
        Me.Panel19 = New System.Windows.Forms.Panel
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.Panel18 = New System.Windows.Forms.Panel
        Me.Panel17 = New System.Windows.Forms.Panel
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem
        Me.CajaFecha2 = New Sistema_Granja.CajaFecha
        Me.CajaFecha1 = New Sistema_Granja.CajaFecha
        Me.RibbonClientPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.panelEspere.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DgvCantidadCostos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel25.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.AutoScroll = True
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.GroupPanel2)
        Me.RibbonClientPanel1.Controls.Add(Me.GroupPanel1)
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonClientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonClientPanel1.Name = "RibbonClientPanel1"
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(1322, 481)
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
        Me.GroupPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.panelEspere)
        Me.GroupPanel2.Controls.Add(Me.Panel6)
        Me.GroupPanel2.Controls.Add(Me.Panel3)
        Me.GroupPanel2.Controls.Add(Me.Panel1)
        Me.GroupPanel2.Controls.Add(Me.DgvCantidadCostos)
        Me.GroupPanel2.Location = New System.Drawing.Point(3, 60)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(1316, 418)
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
        Me.GroupPanel2.TabIndex = 4
        '
        'panelEspere
        '
        Me.panelEspere.CanvasColor = System.Drawing.SystemColors.Control
        Me.panelEspere.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panelEspere.Controls.Add(Me.ReflectionLabel1)
        Me.panelEspere.Controls.Add(Me.PictureBox2)
        Me.panelEspere.Controls.Add(Me.ProgressBarX1)
        Me.panelEspere.Location = New System.Drawing.Point(495, 156)
        Me.panelEspere.Name = "panelEspere"
        Me.panelEspere.Size = New System.Drawing.Size(321, 100)
        Me.panelEspere.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEspere.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panelEspere.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panelEspere.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelEspere.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelEspere.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelEspere.Style.GradientAngle = 90
        Me.panelEspere.TabIndex = 21
        Me.panelEspere.UseWaitCursor = True
        Me.panelEspere.Visible = False
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.Class = ""
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Location = New System.Drawing.Point(90, 3)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(175, 50)
        Me.ReflectionLabel1.TabIndex = 18
        Me.ReflectionLabel1.Text = "<b><font size=""+6""><i>Porfavor </i><font color=""#B02B2C""> Espere...</font></font>" & _
            "</b>"
        Me.ReflectionLabel1.UseWaitCursor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(13, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(67, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.UseWaitCursor = True
        '
        'ProgressBarX1
        '
        '
        '
        '
        Me.ProgressBarX1.BackgroundStyle.Class = ""
        Me.ProgressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBarX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressBarX1.Location = New System.Drawing.Point(13, 54)
        Me.ProgressBarX1.Name = "ProgressBarX1"
        Me.ProgressBarX1.Size = New System.Drawing.Size(295, 30)
        Me.ProgressBarX1.TabIndex = 16
        Me.ProgressBarX1.Text = "0"
        Me.ProgressBarX1.TextVisible = True
        Me.ProgressBarX1.UseWaitCursor = True
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Location = New System.Drawing.Point(0, 56)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(180, 50)
        Me.Panel6.TabIndex = 20
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.lbHasta)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 24)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(178, 24)
        Me.Panel7.TabIndex = 6
        '
        'lbHasta
        '
        '
        '
        '
        Me.lbHasta.Border.Class = "TextBoxBorder"
        Me.lbHasta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbHasta.Location = New System.Drawing.Point(2, 0)
        Me.lbHasta.Name = "lbHasta"
        Me.lbHasta.Size = New System.Drawing.Size(171, 20)
        Me.lbHasta.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.LabelX3)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(178, 24)
        Me.Panel8.TabIndex = 5
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(4, -2)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(42, 23)
        Me.LabelX3.TabIndex = 5
        Me.LabelX3.Text = "Hasta:"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Panel14)
        Me.Panel3.Controls.Add(Me.Panel12)
        Me.Panel3.Controls.Add(Me.Panel10)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Location = New System.Drawing.Point(1, 114)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(179, 197)
        Me.Panel3.TabIndex = 19
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 108)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Panel14
        '
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel14.Controls.Add(Me.lbHoras)
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 78)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(177, 26)
        Me.Panel14.TabIndex = 17
        '
        'lbHoras
        '
        '
        '
        '
        Me.lbHoras.Border.Class = "TextBoxBorder"
        Me.lbHoras.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbHoras.Location = New System.Drawing.Point(98, 1)
        Me.lbHoras.Name = "lbHoras"
        Me.lbHoras.Size = New System.Drawing.Size(74, 20)
        Me.lbHoras.TabIndex = 1
        '
        'Panel15
        '
        Me.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel15.Controls.Add(Me.LabelX11)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(96, 22)
        Me.Panel15.TabIndex = 0
        '
        'LabelX11
        '
        '
        '
        '
        Me.LabelX11.BackgroundStyle.Class = ""
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.Location = New System.Drawing.Point(3, -2)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(92, 23)
        Me.LabelX11.TabIndex = 8
        Me.LabelX11.Text = "Horas:  "
        Me.LabelX11.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel12
        '
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel12.Controls.Add(Me.lbSemanas)
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 52)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(177, 26)
        Me.Panel12.TabIndex = 16
        '
        'lbSemanas
        '
        '
        '
        '
        Me.lbSemanas.Border.Class = "TextBoxBorder"
        Me.lbSemanas.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbSemanas.Location = New System.Drawing.Point(98, 1)
        Me.lbSemanas.Name = "lbSemanas"
        Me.lbSemanas.Size = New System.Drawing.Size(74, 20)
        Me.lbSemanas.TabIndex = 1
        '
        'Panel13
        '
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.LabelX10)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(96, 22)
        Me.Panel13.TabIndex = 0
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.Class = ""
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.Location = New System.Drawing.Point(3, -2)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(92, 23)
        Me.LabelX10.TabIndex = 8
        Me.LabelX10.Text = "Semanas:  "
        Me.LabelX10.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Controls.Add(Me.lbMeses)
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 26)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(177, 26)
        Me.Panel10.TabIndex = 15
        '
        'lbMeses
        '
        '
        '
        '
        Me.lbMeses.Border.Class = "TextBoxBorder"
        Me.lbMeses.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbMeses.Location = New System.Drawing.Point(98, 1)
        Me.lbMeses.Name = "lbMeses"
        Me.lbMeses.Size = New System.Drawing.Size(74, 20)
        Me.lbMeses.TabIndex = 1
        '
        'Panel11
        '
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.LabelX9)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(96, 22)
        Me.Panel11.TabIndex = 0
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.Class = ""
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.Location = New System.Drawing.Point(3, -2)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(92, 23)
        Me.LabelX9.TabIndex = 8
        Me.LabelX9.Text = "Meses:  "
        Me.LabelX9.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lbAños)
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(177, 26)
        Me.Panel2.TabIndex = 14
        '
        'lbAños
        '
        '
        '
        '
        Me.lbAños.Border.Class = "TextBoxBorder"
        Me.lbAños.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbAños.Location = New System.Drawing.Point(98, 1)
        Me.lbAños.Name = "lbAños"
        Me.lbAños.Size = New System.Drawing.Size(74, 20)
        Me.lbAños.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.LabelX5)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(96, 22)
        Me.Panel9.TabIndex = 0
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(3, -2)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(92, 23)
        Me.LabelX5.TabIndex = 8
        Me.LabelX5.Text = "Años:  "
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Location = New System.Drawing.Point(1, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(180, 50)
        Me.Panel1.TabIndex = 18
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.lbDesde)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 24)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(178, 24)
        Me.Panel5.TabIndex = 6
        '
        'lbDesde
        '
        '
        '
        '
        Me.lbDesde.Border.Class = "TextBoxBorder"
        Me.lbDesde.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbDesde.Location = New System.Drawing.Point(2, 0)
        Me.lbDesde.Name = "lbDesde"
        Me.lbDesde.Size = New System.Drawing.Size(174, 20)
        Me.lbDesde.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.LabelX4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(178, 24)
        Me.Panel4.TabIndex = 5
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(3, -2)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(42, 23)
        Me.LabelX4.TabIndex = 4
        Me.LabelX4.Text = "Desde:"
        '
        'DgvCantidadCostos
        '
        Me.DgvCantidadCostos.AllowUserToAddRows = False
        Me.DgvCantidadCostos.AllowUserToDeleteRows = False
        Me.DgvCantidadCostos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvCantidadCostos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DgvCantidadCostos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvCantidadCostos.DefaultCellStyle = DataGridViewCellStyle1
        Me.DgvCantidadCostos.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DgvCantidadCostos.Location = New System.Drawing.Point(183, 0)
        Me.DgvCantidadCostos.Name = "DgvCantidadCostos"
        Me.DgvCantidadCostos.Size = New System.Drawing.Size(1124, 411)
        Me.DgvCantidadCostos.TabIndex = 3
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Panel22)
        Me.GroupPanel1.Controls.Add(Me.Panel16)
        Me.GroupPanel1.Location = New System.Drawing.Point(4, 19)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1315, 39)
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
        '
        'Panel22
        '
        Me.Panel22.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Panel22.Controls.Add(Me.Panel25)
        Me.Panel22.Controls.Add(Me.Panel24)
        Me.Panel22.Controls.Add(Me.Panel23)
        Me.Panel22.Location = New System.Drawing.Point(422, 0)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(356, 32)
        Me.Panel22.TabIndex = 5
        '
        'Panel25
        '
        Me.Panel25.Controls.Add(Me.ButtonX4)
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel25.Location = New System.Drawing.Point(236, 0)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(118, 32)
        Me.Panel25.TabIndex = 2
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.CallBasePaintBackground = True
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonX4.Image = CType(resources.GetObject("ButtonX4.Image"), System.Drawing.Image)
        Me.ButtonX4.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.ButtonX4.Location = New System.Drawing.Point(0, 0)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(118, 32)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX4.TabIndex = 4
        Me.ButtonX4.Text = "Cerrar Ventana"
        '
        'Panel24
        '
        Me.Panel24.Controls.Add(Me.btnExportar)
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel24.Location = New System.Drawing.Point(118, 0)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(118, 32)
        Me.Panel24.TabIndex = 1
        '
        'btnExportar
        '
        Me.btnExportar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExportar.CallBasePaintBackground = True
        Me.btnExportar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExportar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnExportar.Location = New System.Drawing.Point(0, 0)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(118, 32)
        Me.btnExportar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnExportar.TabIndex = 4
        Me.btnExportar.Text = "Exportar a Excel"
        '
        'Panel23
        '
        Me.Panel23.Controls.Add(Me.btnImprimir)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel23.Location = New System.Drawing.Point(0, 0)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(118, 32)
        Me.Panel23.TabIndex = 0
        '
        'btnImprimir
        '
        Me.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImprimir.CallBasePaintBackground = True
        Me.btnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnImprimir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnImprimir.Location = New System.Drawing.Point(0, 0)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(118, 32)
        Me.btnImprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.Text = "Imprimir"
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.Panel21)
        Me.Panel16.Controls.Add(Me.Panel20)
        Me.Panel16.Controls.Add(Me.Panel19)
        Me.Panel16.Controls.Add(Me.Panel18)
        Me.Panel16.Controls.Add(Me.Panel17)
        Me.Panel16.Location = New System.Drawing.Point(4, 4)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(406, 24)
        Me.Panel16.TabIndex = 4
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.btnMostrar)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel21.Location = New System.Drawing.Point(313, 0)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(89, 24)
        Me.Panel21.TabIndex = 4
        '
        'btnMostrar
        '
        Me.btnMostrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnMostrar.CallBasePaintBackground = True
        Me.btnMostrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnMostrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMostrar.Image = CType(resources.GetObject("btnMostrar.Image"), System.Drawing.Image)
        Me.btnMostrar.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnMostrar.Location = New System.Drawing.Point(0, 0)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(89, 24)
        Me.btnMostrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnMostrar.TabIndex = 2
        Me.btnMostrar.Text = "Mostrar"
        '
        'Panel20
        '
        Me.Panel20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel20.Controls.Add(Me.CajaFecha2)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel20.Location = New System.Drawing.Point(224, 0)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(89, 24)
        Me.Panel20.TabIndex = 3
        '
        'Panel19
        '
        Me.Panel19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel19.Controls.Add(Me.LabelX7)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel19.Location = New System.Drawing.Point(159, 0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(65, 24)
        Me.Panel19.TabIndex = 2
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.Class = ""
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(15, -1)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(42, 23)
        Me.LabelX7.TabIndex = 2
        Me.LabelX7.Text = "Hasta:"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel18
        '
        Me.Panel18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel18.Controls.Add(Me.CajaFecha1)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel18.Location = New System.Drawing.Point(74, 0)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(85, 24)
        Me.Panel18.TabIndex = 1
        '
        'Panel17
        '
        Me.Panel17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel17.Controls.Add(Me.LabelX8)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel17.Location = New System.Drawing.Point(0, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(74, 24)
        Me.Panel17.TabIndex = 0
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.Class = ""
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(3, -1)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(61, 23)
        Me.LabelX8.TabIndex = 0
        Me.LabelX8.Text = "Desde:"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'ItemContainer1
        '
        '
        '
        '
        Me.ItemContainer1.BackgroundStyle.Class = ""
        Me.ItemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer1.MinimumSize = New System.Drawing.Size(0, 80)
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem1})
        '
        'LabelItem1
        '
        Me.LabelItem1.Name = "LabelItem1"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem2.Image = CType(resources.GetObject("ButtonItem2.Image"), System.Drawing.Image)
        Me.ButtonItem2.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.ButtonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlP)
        Me.ButtonItem2.SubItemsExpandWidth = 14
        Me.ButtonItem2.Text = "Imprimir Reporte[Ctrl+P]"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem3.Image = CType(resources.GetObject("ButtonItem3.Image"), System.Drawing.Image)
        Me.ButtonItem3.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.ButtonItem3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC)
        Me.ButtonItem3.SubItemsExpandWidth = 14
        Me.ButtonItem3.Text = "Cerrar[Ctrl+C]"
        '
        'CajaFecha2
        '
        Me.CajaFecha2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CajaFecha2.Location = New System.Drawing.Point(0, 0)
        Me.CajaFecha2.Name = "CajaFecha2"
        Me.CajaFecha2.Size = New System.Drawing.Size(85, 20)
        Me.CajaFecha2.TabIndex = 7
        '
        'CajaFecha1
        '
        Me.CajaFecha1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CajaFecha1.Location = New System.Drawing.Point(0, 0)
        Me.CajaFecha1.Name = "CajaFecha1"
        Me.CajaFecha1.Size = New System.Drawing.Size(81, 20)
        Me.CajaFecha1.TabIndex = 6
        '
        'ReporteConsumoCostos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1322, 481)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReporteConsumoCostos"
        Me.Text = "..::Reporte Consumo Costos::.."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.panelEspere.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DgvCantidadCostos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.Panel25.ResumeLayout(False)
        Me.Panel24.ResumeLayout(False)
        Me.Panel23.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel21.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents DgvCantidadCostos As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnMostrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lbHasta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents lbHoras As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents lbSemanas As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents lbMeses As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbAños As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lbDesde As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents Panel25 As System.Windows.Forms.Panel
    Friend WithEvents Panel24 As System.Windows.Forms.Panel
    Friend WithEvents btnExportar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents btnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CajaFecha2 As Sistema_Granja.CajaFecha
    Friend WithEvents CajaFecha1 As Sistema_Granja.CajaFecha
    Friend WithEvents panelEspere As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBarX1 As DevComponents.DotNetBar.Controls.ProgressBarX
End Class
