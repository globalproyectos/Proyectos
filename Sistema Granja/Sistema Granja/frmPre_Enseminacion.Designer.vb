<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPre_Enseminacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPre_Enseminacion))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.lbItems = New DevComponents.DotNetBar.LabelX()
        Me.gpAItems = New System.Windows.Forms.GroupBox()
        Me.dgvLotePara = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.gpALote = New System.Windows.Forms.GroupBox()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtPreSeleccionNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cbxLotePara = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtDescLotePara = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtBuscar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.gpDeItems = New System.Windows.Forms.GroupBox()
        Me.dgvLoteDe = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.gpDeLote = New System.Windows.Forms.GroupBox()
        Me.lbCerdasVacias = New System.Windows.Forms.Label()
        Me.rbtMadres = New System.Windows.Forms.RadioButton()
        Me.rbtAbuelas = New System.Windows.Forms.RadioButton()
        Me.txtDescLoteDe = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.CbxLoteDe = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.BW = New System.ComponentModel.BackgroundWorker()
        Me.RibbonClientPanel1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.gpAItems.SuspendLayout()
        CType(Me.dgvLotePara, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpALote.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.gpDeItems.SuspendLayout()
        CType(Me.dgvLoteDe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpDeLote.SuspendLayout()
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
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(661, 475)
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
        Me.PanelEx3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.ButtonX2)
        Me.PanelEx3.Controls.Add(Me.btnAdd)
        Me.PanelEx3.Controls.Add(Me.ButtonX1)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Location = New System.Drawing.Point(3, 434)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(653, 38)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 2
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = CType(resources.GetObject("ButtonX2.Image"), System.Drawing.Image)
        Me.ButtonX2.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.ButtonX2.Location = New System.Drawing.Point(272, 8)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlG)
        Me.ButtonX2.Size = New System.Drawing.Size(137, 30)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 6
        Me.ButtonX2.Text = "&Nueva Pre-Seleccion"
        Me.ButtonX2.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnAdd.Location = New System.Drawing.Point(415, 8)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlG)
        Me.btnAdd.Size = New System.Drawing.Size(137, 30)
        Me.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "&Guardar Movimiento"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = CType(resources.GetObject("ButtonX1.Image"), System.Drawing.Image)
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.ButtonX1.Location = New System.Drawing.Point(556, 8)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(84, 30)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 5
        Me.ButtonX1.Text = "&Cerrar"
        '
        'PanelEx2
        '
        Me.PanelEx2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.lbItems)
        Me.PanelEx2.Controls.Add(Me.gpAItems)
        Me.PanelEx2.Controls.Add(Me.gpALote)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(335, 22)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(321, 411)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 1
        '
        'lbItems
        '
        '
        '
        '
        Me.lbItems.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbItems.Location = New System.Drawing.Point(261, 72)
        Me.lbItems.Name = "lbItems"
        Me.lbItems.Size = New System.Drawing.Size(45, 10)
        Me.lbItems.TabIndex = 2
        Me.lbItems.Text = "0"
        Me.lbItems.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'gpAItems
        '
        Me.gpAItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gpAItems.Controls.Add(Me.dgvLotePara)
        Me.gpAItems.Location = New System.Drawing.Point(6, 78)
        Me.gpAItems.Name = "gpAItems"
        Me.gpAItems.Size = New System.Drawing.Size(302, 330)
        Me.gpAItems.TabIndex = 2
        Me.gpAItems.TabStop = False
        Me.gpAItems.Text = "Items.."
        '
        'dgvLotePara
        '
        Me.dgvLotePara.AllowUserToAddRows = False
        Me.dgvLotePara.AllowUserToDeleteRows = False
        Me.dgvLotePara.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLotePara.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLotePara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLotePara.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLotePara.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLotePara.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgvLotePara.Location = New System.Drawing.Point(3, 16)
        Me.dgvLotePara.Name = "dgvLotePara"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLotePara.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLotePara.Size = New System.Drawing.Size(296, 311)
        Me.dgvLotePara.TabIndex = 1
        '
        'gpALote
        '
        Me.gpALote.Controls.Add(Me.LabelX4)
        Me.gpALote.Controls.Add(Me.txtPreSeleccionNo)
        Me.gpALote.Controls.Add(Me.cbxLotePara)
        Me.gpALote.Controls.Add(Me.txtDescLotePara)
        Me.gpALote.Controls.Add(Me.LabelX2)
        Me.gpALote.Location = New System.Drawing.Point(3, 7)
        Me.gpALote.Name = "gpALote"
        Me.gpALote.Size = New System.Drawing.Size(305, 64)
        Me.gpALote.TabIndex = 0
        Me.gpALote.TabStop = False
        Me.gpALote.Text = "A Lote"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(52, -3)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(122, 23)
        Me.LabelX4.TabIndex = 5
        Me.LabelX4.Text = "PRE-SELECCION NO:"
        '
        'txtPreSeleccionNo
        '
        '
        '
        '
        Me.txtPreSeleccionNo.Border.Class = "TextBoxBorder"
        Me.txtPreSeleccionNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPreSeleccionNo.Enabled = False
        Me.txtPreSeleccionNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreSeleccionNo.Location = New System.Drawing.Point(180, 0)
        Me.txtPreSeleccionNo.Name = "txtPreSeleccionNo"
        Me.txtPreSeleccionNo.Size = New System.Drawing.Size(100, 24)
        Me.txtPreSeleccionNo.TabIndex = 4
        Me.txtPreSeleccionNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxLotePara
        '
        Me.cbxLotePara.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxLotePara.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxLotePara.DisplayMember = "Text"
        Me.cbxLotePara.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxLotePara.FormattingEnabled = True
        Me.cbxLotePara.ItemHeight = 14
        Me.cbxLotePara.Location = New System.Drawing.Point(61, 36)
        Me.cbxLotePara.Name = "cbxLotePara"
        Me.cbxLotePara.Size = New System.Drawing.Size(95, 20)
        Me.cbxLotePara.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbxLotePara.TabIndex = 3
        '
        'txtDescLotePara
        '
        '
        '
        '
        Me.txtDescLotePara.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDescLotePara.Border.Class = "TextBoxBorder"
        Me.txtDescLotePara.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDescLotePara.Enabled = False
        Me.txtDescLotePara.Location = New System.Drawing.Point(162, 36)
        Me.txtDescLotePara.Name = "txtDescLotePara"
        Me.txtDescLotePara.Size = New System.Drawing.Size(118, 20)
        Me.txtDescLotePara.TabIndex = 2
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(7, 35)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(51, 23)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Lote No:"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'PanelEx1
        '
        Me.PanelEx1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.txtBuscar)
        Me.PanelEx1.Controls.Add(Me.gpDeItems)
        Me.PanelEx1.Controls.Add(Me.gpDeLote)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Location = New System.Drawing.Point(3, 22)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(329, 411)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(134, 73)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 16)
        Me.LabelX3.TabIndex = 1
        Me.LabelX3.Text = "Búscar:"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtBuscar
        '
        '
        '
        '
        Me.txtBuscar.Border.Class = "TextBoxBorder"
        Me.txtBuscar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBuscar.Location = New System.Drawing.Point(215, 73)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscar.TabIndex = 1
        '
        'gpDeItems
        '
        Me.gpDeItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gpDeItems.Controls.Add(Me.dgvLoteDe)
        Me.gpDeItems.Location = New System.Drawing.Point(3, 79)
        Me.gpDeItems.Name = "gpDeItems"
        Me.gpDeItems.Size = New System.Drawing.Size(317, 330)
        Me.gpDeItems.TabIndex = 1
        Me.gpDeItems.TabStop = False
        Me.gpDeItems.Text = "Items.."
        '
        'dgvLoteDe
        '
        Me.dgvLoteDe.AllowUserToAddRows = False
        Me.dgvLoteDe.AllowUserToDeleteRows = False
        Me.dgvLoteDe.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLoteDe.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvLoteDe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLoteDe.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvLoteDe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLoteDe.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgvLoteDe.Location = New System.Drawing.Point(3, 16)
        Me.dgvLoteDe.Name = "dgvLoteDe"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLoteDe.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvLoteDe.Size = New System.Drawing.Size(311, 311)
        Me.dgvLoteDe.TabIndex = 0
        '
        'gpDeLote
        '
        Me.gpDeLote.Controls.Add(Me.lbCerdasVacias)
        Me.gpDeLote.Controls.Add(Me.rbtMadres)
        Me.gpDeLote.Controls.Add(Me.rbtAbuelas)
        Me.gpDeLote.Controls.Add(Me.txtDescLoteDe)
        Me.gpDeLote.Controls.Add(Me.CbxLoteDe)
        Me.gpDeLote.Controls.Add(Me.LabelX1)
        Me.gpDeLote.Location = New System.Drawing.Point(3, 7)
        Me.gpDeLote.Name = "gpDeLote"
        Me.gpDeLote.Size = New System.Drawing.Size(317, 66)
        Me.gpDeLote.TabIndex = 0
        Me.gpDeLote.TabStop = False
        Me.gpDeLote.Text = "De Lote:"
        '
        'lbCerdasVacias
        '
        Me.lbCerdasVacias.AutoSize = True
        Me.lbCerdasVacias.Location = New System.Drawing.Point(84, 14)
        Me.lbCerdasVacias.Name = "lbCerdasVacias"
        Me.lbCerdasVacias.Size = New System.Drawing.Size(39, 13)
        Me.lbCerdasVacias.TabIndex = 4
        Me.lbCerdasVacias.Text = "Label1"
        Me.lbCerdasVacias.Visible = False
        '
        'rbtMadres
        '
        Me.rbtMadres.AutoSize = True
        Me.rbtMadres.Checked = True
        Me.rbtMadres.Location = New System.Drawing.Point(218, 14)
        Me.rbtMadres.Name = "rbtMadres"
        Me.rbtMadres.Size = New System.Drawing.Size(60, 17)
        Me.rbtMadres.TabIndex = 3
        Me.rbtMadres.TabStop = True
        Me.rbtMadres.Text = "Madres"
        Me.rbtMadres.UseVisualStyleBackColor = True
        '
        'rbtAbuelas
        '
        Me.rbtAbuelas.AutoSize = True
        Me.rbtAbuelas.Location = New System.Drawing.Point(147, 14)
        Me.rbtAbuelas.Name = "rbtAbuelas"
        Me.rbtAbuelas.Size = New System.Drawing.Size(63, 17)
        Me.rbtAbuelas.TabIndex = 2
        Me.rbtAbuelas.Text = "Abuelas"
        Me.rbtAbuelas.UseVisualStyleBackColor = True
        '
        'txtDescLoteDe
        '
        '
        '
        '
        Me.txtDescLoteDe.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDescLoteDe.Border.Class = "TextBoxBorder"
        Me.txtDescLoteDe.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDescLoteDe.Enabled = False
        Me.txtDescLoteDe.Location = New System.Drawing.Point(147, 37)
        Me.txtDescLoteDe.Name = "txtDescLoteDe"
        Me.txtDescLoteDe.Size = New System.Drawing.Size(131, 20)
        Me.txtDescLoteDe.TabIndex = 1
        '
        'CbxLoteDe
        '
        Me.CbxLoteDe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbxLoteDe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxLoteDe.DisplayMember = "Text"
        Me.CbxLoteDe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbxLoteDe.FormattingEnabled = True
        Me.CbxLoteDe.ItemHeight = 14
        Me.CbxLoteDe.Location = New System.Drawing.Point(87, 37)
        Me.CbxLoteDe.Name = "CbxLoteDe"
        Me.CbxLoteDe.Size = New System.Drawing.Size(56, 20)
        Me.CbxLoteDe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CbxLoteDe.TabIndex = 1
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(6, 37)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Lote No:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'BW
        '
        Me.BW.WorkerReportsProgress = True
        Me.BW.WorkerSupportsCancellation = True
        '
        'frmPre_Enseminacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 475)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.DoubleBuffered = True
        Me.Name = "frmPre_Enseminacion"
        Me.Text = "Selección Pre-Enseminacion"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.gpAItems.ResumeLayout(False)
        CType(Me.dgvLotePara, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpALote.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.gpDeItems.ResumeLayout(False)
        CType(Me.dgvLoteDe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpDeLote.ResumeLayout(False)
        Me.gpDeLote.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents gpDeLote As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents gpALote As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescLotePara As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDescLoteDe As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CbxLoteDe As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbxLotePara As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents gpAItems As System.Windows.Forms.GroupBox
    Friend WithEvents gpDeItems As System.Windows.Forms.GroupBox
    Friend WithEvents dgvLotePara As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents rbtMadres As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAbuelas As System.Windows.Forms.RadioButton
    Friend WithEvents lbCerdasVacias As System.Windows.Forms.Label
    Friend WithEvents BW As System.ComponentModel.BackgroundWorker
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lbItems As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBuscar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dgvLoteDe As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPreSeleccionNo As DevComponents.DotNetBar.Controls.TextBoxX
End Class
