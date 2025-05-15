<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnular_Requisicion
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
        Dim Req_NoLabel As System.Windows.Forms.Label
        Dim Ultima_LineaLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim Total_RequisicionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnular_Requisicion))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx
        Me.btnRevertir = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Req_NoTextBoxX = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Buscar_Requisicion_AnulacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsBDGRANJA = New Sistema_Granja.DtsBDGRANJA
        Me.Ultima_LineaTextBoxX = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.FechaTextBox = New System.Windows.Forms.TextBox
        Me.Total_RequisicionTextBoxX = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txtNoReq = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Buscar_Requisicion_AnulacionTableAdapter = New Sistema_Granja.DtsBDGRANJATableAdapters.Buscar_Requisicion_AnulacionTableAdapter
        Me.TableAdapterManager = New Sistema_Granja.DtsBDGRANJATableAdapters.TableAdapterManager
        Me.Buscar_Requisicion_AnulacionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Req_NoLabel = New System.Windows.Forms.Label
        Ultima_LineaLabel = New System.Windows.Forms.Label
        FechaLabel = New System.Windows.Forms.Label
        Total_RequisicionLabel = New System.Windows.Forms.Label
        Me.RibbonClientPanel1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Buscar_Requisicion_AnulacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsBDGRANJA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Buscar_Requisicion_AnulacionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Buscar_Requisicion_AnulacionBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Req_NoLabel
        '
        Req_NoLabel.AutoSize = True
        Req_NoLabel.Location = New System.Drawing.Point(22, 31)
        Req_NoLabel.Name = "Req_NoLabel"
        Req_NoLabel.Size = New System.Drawing.Size(47, 13)
        Req_NoLabel.TabIndex = 0
        Req_NoLabel.Text = "Req No:"
        '
        'Ultima_LineaLabel
        '
        Ultima_LineaLabel.AutoSize = True
        Ultima_LineaLabel.Location = New System.Drawing.Point(22, 57)
        Ultima_LineaLabel.Name = "Ultima_LineaLabel"
        Ultima_LineaLabel.Size = New System.Drawing.Size(68, 13)
        Ultima_LineaLabel.TabIndex = 2
        Ultima_LineaLabel.Text = "Ultima Linea:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(22, 83)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 4
        FechaLabel.Text = "Fecha:"
        '
        'Total_RequisicionLabel
        '
        Total_RequisicionLabel.AutoSize = True
        Total_RequisicionLabel.Location = New System.Drawing.Point(22, 109)
        Total_RequisicionLabel.Name = "Total_RequisicionLabel"
        Total_RequisicionLabel.Size = New System.Drawing.Size(92, 13)
        Total_RequisicionLabel.TabIndex = 6
        Total_RequisicionLabel.Text = "Total Requisicion:"
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
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(336, 306)
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
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.btnRevertir)
        Me.PanelEx3.Controls.Add(Me.ButtonX1)
        Me.PanelEx3.Location = New System.Drawing.Point(3, 273)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(331, 31)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 3
        '
        'btnRevertir
        '
        Me.btnRevertir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRevertir.CallBasePaintBackground = True
        Me.btnRevertir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRevertir.Enabled = False
        Me.btnRevertir.Image = CType(resources.GetObject("btnRevertir.Image"), System.Drawing.Image)
        Me.btnRevertir.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnRevertir.Location = New System.Drawing.Point(133, 4)
        Me.btnRevertir.Name = "btnRevertir"
        Me.btnRevertir.Size = New System.Drawing.Size(93, 23)
        Me.btnRevertir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRevertir.TabIndex = 1
        Me.btnRevertir.Text = "&Anular"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.CallBasePaintBackground = True
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = CType(resources.GetObject("ButtonX1.Image"), System.Drawing.Image)
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(15, 15)
        Me.ButtonX1.Location = New System.Drawing.Point(232, 4)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(93, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 0
        Me.ButtonX1.Text = "&Cancelar"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.GroupBox2)
        Me.PanelEx2.Location = New System.Drawing.Point(4, 85)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(329, 186)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Req_NoLabel)
        Me.GroupBox2.Controls.Add(Me.Req_NoTextBoxX)
        Me.GroupBox2.Controls.Add(Ultima_LineaLabel)
        Me.GroupBox2.Controls.Add(Me.Ultima_LineaTextBoxX)
        Me.GroupBox2.Controls.Add(FechaLabel)
        Me.GroupBox2.Controls.Add(Me.FechaTextBox)
        Me.GroupBox2.Controls.Add(Total_RequisicionLabel)
        Me.GroupBox2.Controls.Add(Me.Total_RequisicionTextBoxX)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 140)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles..."
        '
        'Req_NoTextBoxX
        '
        '
        '
        '
        Me.Req_NoTextBoxX.Border.Class = "TextBoxBorder"
        Me.Req_NoTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Req_NoTextBoxX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Buscar_Requisicion_AnulacionBindingSource, "Req_No", True))
        Me.Req_NoTextBoxX.Enabled = False
        Me.Req_NoTextBoxX.Location = New System.Drawing.Point(120, 28)
        Me.Req_NoTextBoxX.Name = "Req_NoTextBoxX"
        Me.Req_NoTextBoxX.Size = New System.Drawing.Size(73, 20)
        Me.Req_NoTextBoxX.TabIndex = 1
        '
        'Buscar_Requisicion_AnulacionBindingSource
        '
        Me.Buscar_Requisicion_AnulacionBindingSource.DataMember = "Buscar_Requisicion_Anulacion"
        Me.Buscar_Requisicion_AnulacionBindingSource.DataSource = Me.DtsBDGRANJA
        '
        'DtsBDGRANJA
        '
        Me.DtsBDGRANJA.DataSetName = "DtsBDGRANJA"
        Me.DtsBDGRANJA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ultima_LineaTextBoxX
        '
        '
        '
        '
        Me.Ultima_LineaTextBoxX.Border.Class = "TextBoxBorder"
        Me.Ultima_LineaTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Ultima_LineaTextBoxX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Buscar_Requisicion_AnulacionBindingSource, "Ultima_Linea", True))
        Me.Ultima_LineaTextBoxX.Enabled = False
        Me.Ultima_LineaTextBoxX.Location = New System.Drawing.Point(120, 54)
        Me.Ultima_LineaTextBoxX.Name = "Ultima_LineaTextBoxX"
        Me.Ultima_LineaTextBoxX.Size = New System.Drawing.Size(100, 20)
        Me.Ultima_LineaTextBoxX.TabIndex = 3
        '
        'FechaTextBox
        '
        Me.FechaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Buscar_Requisicion_AnulacionBindingSource, "Fecha", True))
        Me.FechaTextBox.Enabled = False
        Me.FechaTextBox.Location = New System.Drawing.Point(120, 80)
        Me.FechaTextBox.Name = "FechaTextBox"
        Me.FechaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FechaTextBox.TabIndex = 5
        '
        'Total_RequisicionTextBoxX
        '
        '
        '
        '
        Me.Total_RequisicionTextBoxX.Border.Class = "TextBoxBorder"
        Me.Total_RequisicionTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Total_RequisicionTextBoxX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Buscar_Requisicion_AnulacionBindingSource, "Total_Requisicion", True))
        Me.Total_RequisicionTextBoxX.Enabled = False
        Me.Total_RequisicionTextBoxX.Location = New System.Drawing.Point(120, 106)
        Me.Total_RequisicionTextBoxX.Name = "Total_RequisicionTextBoxX"
        Me.Total_RequisicionTextBoxX.Size = New System.Drawing.Size(100, 20)
        Me.Total_RequisicionTextBoxX.TabIndex = 7
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.GroupBox1)
        Me.PanelEx1.Location = New System.Drawing.Point(4, 27)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(329, 57)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.txtNoReq)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 53)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Requisición"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(50, 19)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 20)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Req No."
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtNoReq
        '
        '
        '
        '
        Me.txtNoReq.Border.Class = "TextBoxBorder"
        Me.txtNoReq.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNoReq.Location = New System.Drawing.Point(153, 19)
        Me.txtNoReq.Name = "txtNoReq"
        Me.txtNoReq.Size = New System.Drawing.Size(97, 20)
        Me.txtNoReq.TabIndex = 0
        Me.txtNoReq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Buscar_Requisicion_AnulacionTableAdapter
        '
        Me.Buscar_Requisicion_AnulacionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BODEGASTableAdapter = Nothing
        Me.TableAdapterManager.Buscar_Compra_reversion_x_nodocTableAdapter = Nothing
        Me.TableAdapterManager.Buscar_Requisicion_AnulacionTableAdapter = Me.Buscar_Requisicion_AnulacionTableAdapter
        Me.TableAdapterManager.ENCABEZADO_SALIDASTableAdapter = Nothing
        Me.TableAdapterManager.Estados_InseminacionesTableAdapter = Nothing
        Me.TableAdapterManager.LINEAS_DE_REQUISICIONESTableAdapter = Nothing
        Me.TableAdapterManager.LINEAS_DE_SALIDASTableAdapter = Nothing
        Me.TableAdapterManager.Sl_VerracosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_Granja.DtsBDGRANJATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Buscar_Requisicion_AnulacionBindingNavigator
        '
        Me.Buscar_Requisicion_AnulacionBindingNavigator.AddNewItem = Nothing
        Me.Buscar_Requisicion_AnulacionBindingNavigator.BindingSource = Me.Buscar_Requisicion_AnulacionBindingSource
        Me.Buscar_Requisicion_AnulacionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Buscar_Requisicion_AnulacionBindingNavigator.DeleteItem = Nothing
        Me.Buscar_Requisicion_AnulacionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.Buscar_Requisicion_AnulacionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Buscar_Requisicion_AnulacionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Buscar_Requisicion_AnulacionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Buscar_Requisicion_AnulacionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Buscar_Requisicion_AnulacionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Buscar_Requisicion_AnulacionBindingNavigator.Name = "Buscar_Requisicion_AnulacionBindingNavigator"
        Me.Buscar_Requisicion_AnulacionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Buscar_Requisicion_AnulacionBindingNavigator.Size = New System.Drawing.Size(336, 25)
        Me.Buscar_Requisicion_AnulacionBindingNavigator.TabIndex = 1
        Me.Buscar_Requisicion_AnulacionBindingNavigator.Text = "BindingNavigator1"
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
        'frmAnular_Requisicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 306)
        Me.Controls.Add(Me.Buscar_Requisicion_AnulacionBindingNavigator)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.DoubleBuffered = True
        Me.Name = "frmAnular_Requisicion"
        Me.Text = "Anular Requisición"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Buscar_Requisicion_AnulacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsBDGRANJA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Buscar_Requisicion_AnulacionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Buscar_Requisicion_AnulacionBindingNavigator.ResumeLayout(False)
        Me.Buscar_Requisicion_AnulacionBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNoReq As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnRevertir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DtsBDGRANJA As Sistema_Granja.DtsBDGRANJA
    Friend WithEvents Buscar_Requisicion_AnulacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Buscar_Requisicion_AnulacionTableAdapter As Sistema_Granja.DtsBDGRANJATableAdapters.Buscar_Requisicion_AnulacionTableAdapter
    Friend WithEvents TableAdapterManager As Sistema_Granja.DtsBDGRANJATableAdapters.TableAdapterManager
    Friend WithEvents Buscar_Requisicion_AnulacionBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Req_NoTextBoxX As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Ultima_LineaTextBoxX As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents FechaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_RequisicionTextBoxX As DevComponents.DotNetBar.Controls.TextBoxX
End Class
