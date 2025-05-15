<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRevertirCompra
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
        Dim No_DocumentoLabel As System.Windows.Forms.Label
        Dim IdCompraLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim ImporteLabel As System.Windows.Forms.Label
        Dim LineasLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRevertirCompra))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx
        Me.btnRevertir = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.No_DocumentoTextBoxX = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Buscar_Compra_reversion_x_nodocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsBDGRANJA = New Sistema_Granja.DtsBDGRANJA
        Me.IdCompraTextBoxX = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.ImporteTextBoxX = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LineasTextBoxX = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txtNoDoc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Buscar_Compra_reversion_x_nodocTableAdapter = New Sistema_Granja.DtsBDGRANJATableAdapters.Buscar_Compra_reversion_x_nodocTableAdapter
        Me.TableAdapterManager = New Sistema_Granja.DtsBDGRANJATableAdapters.TableAdapterManager
        Me.Buscar_Compra_reversion_x_nodocBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        No_DocumentoLabel = New System.Windows.Forms.Label
        IdCompraLabel = New System.Windows.Forms.Label
        FechaLabel = New System.Windows.Forms.Label
        ImporteLabel = New System.Windows.Forms.Label
        LineasLabel = New System.Windows.Forms.Label
        Me.RibbonClientPanel1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Buscar_Compra_reversion_x_nodocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsBDGRANJA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Buscar_Compra_reversion_x_nodocBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Buscar_Compra_reversion_x_nodocBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'No_DocumentoLabel
        '
        No_DocumentoLabel.AutoSize = True
        No_DocumentoLabel.Location = New System.Drawing.Point(28, 22)
        No_DocumentoLabel.Name = "No_DocumentoLabel"
        No_DocumentoLabel.Size = New System.Drawing.Size(82, 13)
        No_DocumentoLabel.TabIndex = 0
        No_DocumentoLabel.Text = "No Documento:"
        '
        'IdCompraLabel
        '
        IdCompraLabel.AutoSize = True
        IdCompraLabel.Location = New System.Drawing.Point(28, 48)
        IdCompraLabel.Name = "IdCompraLabel"
        IdCompraLabel.Size = New System.Drawing.Size(58, 13)
        IdCompraLabel.TabIndex = 2
        IdCompraLabel.Text = "Id Compra:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(28, 75)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 4
        FechaLabel.Text = "Fecha:"
        '
        'ImporteLabel
        '
        ImporteLabel.AutoSize = True
        ImporteLabel.Location = New System.Drawing.Point(28, 100)
        ImporteLabel.Name = "ImporteLabel"
        ImporteLabel.Size = New System.Drawing.Size(45, 13)
        ImporteLabel.TabIndex = 6
        ImporteLabel.Text = "Importe:"
        '
        'LineasLabel
        '
        LineasLabel.AutoSize = True
        LineasLabel.Location = New System.Drawing.Point(28, 126)
        LineasLabel.Name = "LineasLabel"
        LineasLabel.Size = New System.Drawing.Size(41, 13)
        LineasLabel.TabIndex = 8
        LineasLabel.Text = "Lineas:"
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
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(329, 305)
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
        Me.PanelEx3.Location = New System.Drawing.Point(0, 272)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(329, 31)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 2
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
        Me.btnRevertir.Text = "&Revertir"
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
        Me.PanelEx2.Location = New System.Drawing.Point(0, 85)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(329, 186)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(No_DocumentoLabel)
        Me.GroupBox2.Controls.Add(Me.No_DocumentoTextBoxX)
        Me.GroupBox2.Controls.Add(IdCompraLabel)
        Me.GroupBox2.Controls.Add(Me.IdCompraTextBoxX)
        Me.GroupBox2.Controls.Add(FechaLabel)
        Me.GroupBox2.Controls.Add(Me.FechaDateTimePicker)
        Me.GroupBox2.Controls.Add(ImporteLabel)
        Me.GroupBox2.Controls.Add(Me.ImporteTextBoxX)
        Me.GroupBox2.Controls.Add(LineasLabel)
        Me.GroupBox2.Controls.Add(Me.LineasTextBoxX)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 165)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles..."
        '
        'No_DocumentoTextBoxX
        '
        '
        '
        '
        Me.No_DocumentoTextBoxX.Border.Class = "TextBoxBorder"
        Me.No_DocumentoTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.No_DocumentoTextBoxX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Buscar_Compra_reversion_x_nodocBindingSource, "No_Documento", True))
        Me.No_DocumentoTextBoxX.Location = New System.Drawing.Point(116, 19)
        Me.No_DocumentoTextBoxX.Name = "No_DocumentoTextBoxX"
        Me.No_DocumentoTextBoxX.Size = New System.Drawing.Size(92, 20)
        Me.No_DocumentoTextBoxX.TabIndex = 1
        '
        'Buscar_Compra_reversion_x_nodocBindingSource
        '
        Me.Buscar_Compra_reversion_x_nodocBindingSource.DataMember = "Buscar_Compra_reversion_x_nodoc"
        Me.Buscar_Compra_reversion_x_nodocBindingSource.DataSource = Me.DtsBDGRANJA
        '
        'DtsBDGRANJA
        '
        Me.DtsBDGRANJA.DataSetName = "DtsBDGRANJA"
        Me.DtsBDGRANJA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdCompraTextBoxX
        '
        '
        '
        '
        Me.IdCompraTextBoxX.Border.Class = "TextBoxBorder"
        Me.IdCompraTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IdCompraTextBoxX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Buscar_Compra_reversion_x_nodocBindingSource, "IdCompra", True))
        Me.IdCompraTextBoxX.Location = New System.Drawing.Point(116, 45)
        Me.IdCompraTextBoxX.Name = "IdCompraTextBoxX"
        Me.IdCompraTextBoxX.Size = New System.Drawing.Size(57, 20)
        Me.IdCompraTextBoxX.TabIndex = 3
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Buscar_Compra_reversion_x_nodocBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(116, 71)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(195, 20)
        Me.FechaDateTimePicker.TabIndex = 5
        '
        'ImporteTextBoxX
        '
        '
        '
        '
        Me.ImporteTextBoxX.Border.Class = "TextBoxBorder"
        Me.ImporteTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ImporteTextBoxX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Buscar_Compra_reversion_x_nodocBindingSource, "Importe", True))
        Me.ImporteTextBoxX.Location = New System.Drawing.Point(116, 97)
        Me.ImporteTextBoxX.Name = "ImporteTextBoxX"
        Me.ImporteTextBoxX.Size = New System.Drawing.Size(92, 20)
        Me.ImporteTextBoxX.TabIndex = 7
        '
        'LineasTextBoxX
        '
        '
        '
        '
        Me.LineasTextBoxX.Border.Class = "TextBoxBorder"
        Me.LineasTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LineasTextBoxX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Buscar_Compra_reversion_x_nodocBindingSource, "Lineas", True))
        Me.LineasTextBoxX.Location = New System.Drawing.Point(116, 123)
        Me.LineasTextBoxX.Name = "LineasTextBoxX"
        Me.LineasTextBoxX.Size = New System.Drawing.Size(57, 20)
        Me.LineasTextBoxX.TabIndex = 9
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.GroupBox1)
        Me.PanelEx1.Location = New System.Drawing.Point(0, 27)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(329, 57)
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
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.txtNoDoc)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 53)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la compra"
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
        Me.LabelX1.Text = "No Doc."
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'txtNoDoc
        '
        '
        '
        '
        Me.txtNoDoc.Border.Class = "TextBoxBorder"
        Me.txtNoDoc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNoDoc.Location = New System.Drawing.Point(153, 19)
        Me.txtNoDoc.Name = "txtNoDoc"
        Me.txtNoDoc.Size = New System.Drawing.Size(97, 20)
        Me.txtNoDoc.TabIndex = 0
        Me.txtNoDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Buscar_Compra_reversion_x_nodocTableAdapter
        '
        Me.Buscar_Compra_reversion_x_nodocTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BODEGASTableAdapter = Nothing
        Me.TableAdapterManager.Buscar_Compra_reversion_x_nodocTableAdapter = Me.Buscar_Compra_reversion_x_nodocTableAdapter
        Me.TableAdapterManager.ENCABEZADO_SALIDASTableAdapter = Nothing
        Me.TableAdapterManager.Estados_InseminacionesTableAdapter = Nothing
        Me.TableAdapterManager.LINEAS_DE_REQUISICIONESTableAdapter = Nothing
        Me.TableAdapterManager.LINEAS_DE_SALIDASTableAdapter = Nothing
        Me.TableAdapterManager.Sl_VerracosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_Granja.DtsBDGRANJATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Buscar_Compra_reversion_x_nodocBindingNavigator
        '
        Me.Buscar_Compra_reversion_x_nodocBindingNavigator.AddNewItem = Nothing
        Me.Buscar_Compra_reversion_x_nodocBindingNavigator.BindingSource = Me.Buscar_Compra_reversion_x_nodocBindingSource
        Me.Buscar_Compra_reversion_x_nodocBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Buscar_Compra_reversion_x_nodocBindingNavigator.DeleteItem = Nothing
        Me.Buscar_Compra_reversion_x_nodocBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.Buscar_Compra_reversion_x_nodocBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Buscar_Compra_reversion_x_nodocBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Buscar_Compra_reversion_x_nodocBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Buscar_Compra_reversion_x_nodocBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Buscar_Compra_reversion_x_nodocBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Buscar_Compra_reversion_x_nodocBindingNavigator.Name = "Buscar_Compra_reversion_x_nodocBindingNavigator"
        Me.Buscar_Compra_reversion_x_nodocBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Buscar_Compra_reversion_x_nodocBindingNavigator.Size = New System.Drawing.Size(329, 25)
        Me.Buscar_Compra_reversion_x_nodocBindingNavigator.TabIndex = 1
        Me.Buscar_Compra_reversion_x_nodocBindingNavigator.Text = "BindingNavigator1"
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
        'frmRevertirCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 305)
        Me.ControlBox = False
        Me.Controls.Add(Me.Buscar_Compra_reversion_x_nodocBindingNavigator)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRevertirCompra"
        Me.Text = "Reversión de compras"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Buscar_Compra_reversion_x_nodocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsBDGRANJA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Buscar_Compra_reversion_x_nodocBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Buscar_Compra_reversion_x_nodocBindingNavigator.ResumeLayout(False)
        Me.Buscar_Compra_reversion_x_nodocBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnRevertir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNoDoc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents DtsBDGRANJA As Sistema_Granja.DtsBDGRANJA
    Friend WithEvents Buscar_Compra_reversion_x_nodocBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Buscar_Compra_reversion_x_nodocTableAdapter As Sistema_Granja.DtsBDGRANJATableAdapters.Buscar_Compra_reversion_x_nodocTableAdapter
    Friend WithEvents TableAdapterManager As Sistema_Granja.DtsBDGRANJATableAdapters.TableAdapterManager
    Friend WithEvents Buscar_Compra_reversion_x_nodocBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents No_DocumentoTextBoxX As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents IdCompraTextBoxX As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ImporteTextBoxX As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LineasTextBoxX As DevComponents.DotNetBar.Controls.TextBoxX
End Class
