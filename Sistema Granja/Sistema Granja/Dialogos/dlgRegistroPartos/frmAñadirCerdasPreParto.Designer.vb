<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAñadirCerdasPreParto
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAñadirCerdasPreParto))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.lotegestacionComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.subidanoLabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.codigocerdaTextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.btnGuardar = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PanelEx4 = New DevComponents.DotNetBar.PanelEx()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ID_Inseminacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoCerda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoteGestacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accion = New DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn()
        Me.DiasGestacion1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vacio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelEx5 = New DevComponents.DotNetBar.PanelEx()
        Me.DataGridViewX2 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.errorLabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.IDInseminacion2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoCerda2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoteGestacion2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSubida = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.Peso = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn()
        Me.DiasGestacion = New DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn()
        Me.NoCuna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accion2 = New DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn()
        Me.EstadoCerda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vacio2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.PanelEx4.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx5.SuspendLayout()
        CType(Me.DataGridViewX2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.lotegestacionComboBoxEx1)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.subidanoLabelX3)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.codigocerdaTextBoxX1)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1298, 73)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'lotegestacionComboBoxEx1
        '
        Me.lotegestacionComboBoxEx1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.lotegestacionComboBoxEx1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.lotegestacionComboBoxEx1.DisplayMember = "Text"
        Me.lotegestacionComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lotegestacionComboBoxEx1.FormattingEnabled = True
        Me.lotegestacionComboBoxEx1.ItemHeight = 14
        Me.lotegestacionComboBoxEx1.Location = New System.Drawing.Point(213, 36)
        Me.lotegestacionComboBoxEx1.Name = "lotegestacionComboBoxEx1"
        Me.lotegestacionComboBoxEx1.Size = New System.Drawing.Size(121, 20)
        Me.lotegestacionComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.lotegestacionComboBoxEx1.TabIndex = 7
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(132, 33)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(85, 23)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "Lote Gestación:"
        '
        'subidanoLabelX3
        '
        '
        '
        '
        Me.subidanoLabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.subidanoLabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subidanoLabelX3.Location = New System.Drawing.Point(74, 33)
        Me.subidanoLabelX3.Name = "subidanoLabelX3"
        Me.subidanoLabelX3.Size = New System.Drawing.Size(52, 23)
        Me.subidanoLabelX3.TabIndex = 4
        Me.subidanoLabelX3.Text = "0"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(5, 33)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(63, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Subida No: "
        '
        'codigocerdaTextBoxX1
        '
        '
        '
        '
        Me.codigocerdaTextBoxX1.Border.Class = "TextBoxBorder"
        Me.codigocerdaTextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.codigocerdaTextBoxX1.Location = New System.Drawing.Point(444, 36)
        Me.codigocerdaTextBoxX1.Name = "codigocerdaTextBoxX1"
        Me.codigocerdaTextBoxX1.PreventEnterBeep = True
        Me.codigocerdaTextBoxX1.Size = New System.Drawing.Size(84, 20)
        Me.codigocerdaTextBoxX1.TabIndex = 2
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(350, 33)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(88, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Código de Cerda:"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1298, 27)
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 0
        Me.PanelEx2.Text = "  Filtro"
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.btnGuardar)
        Me.PanelEx3.Controls.Add(Me.ButtonX1)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx3.Location = New System.Drawing.Point(0, 536)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(1298, 40)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 5
        '
        'btnGuardar
        '
        Me.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGuardar.Image = Global.Sistema_Granja.My.Resources.Resources.ok
        Me.btnGuardar.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Location = New System.Drawing.Point(1083, 5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlG)
        Me.btnGuardar.Size = New System.Drawing.Size(121, 30)
        Me.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "&Aceptar"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = CType(resources.GetObject("ButtonX1.Image"), System.Drawing.Image)
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.ButtonX1.Location = New System.Drawing.Point(1210, 5)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(84, 30)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 5
        Me.ButtonX1.Text = "&Cancelar"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 73)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PanelEx4)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PanelEx5)
        Me.SplitContainer1.Size = New System.Drawing.Size(1298, 463)
        Me.SplitContainer1.SplitterDistance = 569
        Me.SplitContainer1.TabIndex = 6
        '
        'PanelEx4
        '
        Me.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx4.Controls.Add(Me.DataGridViewX1)
        Me.PanelEx4.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx4.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx4.Name = "PanelEx4"
        Me.PanelEx4.Size = New System.Drawing.Size(569, 463)
        Me.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        Me.PanelEx4.TabIndex = 0
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Inseminacion, Me.CodigoCerda, Me.EstadoActual, Me.LoteGestacion, Me.Accion, Me.DiasGestacion1, Me.vacio})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.Size = New System.Drawing.Size(569, 463)
        Me.DataGridViewX1.TabIndex = 0
        '
        'ID_Inseminacion
        '
        Me.ID_Inseminacion.DataPropertyName = "Id_Enseminacion"
        Me.ID_Inseminacion.HeaderText = "ID Inseminación"
        Me.ID_Inseminacion.Name = "ID_Inseminacion"
        Me.ID_Inseminacion.Width = 80
        '
        'CodigoCerda
        '
        Me.CodigoCerda.DataPropertyName = "CodigoCerda"
        Me.CodigoCerda.HeaderText = "Código Cerda"
        Me.CodigoCerda.Name = "CodigoCerda"
        Me.CodigoCerda.Width = 80
        '
        'EstadoActual
        '
        Me.EstadoActual.DataPropertyName = "EstadoActual"
        Me.EstadoActual.HeaderText = "Estado Actual"
        Me.EstadoActual.Name = "EstadoActual"
        Me.EstadoActual.Width = 120
        '
        'LoteGestacion
        '
        Me.LoteGestacion.DataPropertyName = "LoteGestacion"
        Me.LoteGestacion.HeaderText = "Lote Gestación"
        Me.LoteGestacion.Name = "LoteGestacion"
        Me.LoteGestacion.Width = 80
        '
        'Accion
        '
        Me.Accion.HeaderText = "Acción"
        Me.Accion.Name = "Accion"
        Me.Accion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Accion.Text = Nothing
        Me.Accion.Width = 70
        '
        'DiasGestacion1
        '
        Me.DiasGestacion1.DataPropertyName = "DiasGestacion"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DiasGestacion1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DiasGestacion1.HeaderText = "Dias Gestación"
        Me.DiasGestacion1.Name = "DiasGestacion1"
        Me.DiasGestacion1.ReadOnly = True
        Me.DiasGestacion1.Width = 70
        '
        'vacio
        '
        Me.vacio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.vacio.HeaderText = ""
        Me.vacio.Name = "vacio"
        Me.vacio.ReadOnly = True
        '
        'PanelEx5
        '
        Me.PanelEx5.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx5.Controls.Add(Me.DataGridViewX2)
        Me.PanelEx5.Controls.Add(Me.errorLabelX3)
        Me.PanelEx5.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx5.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx5.Name = "PanelEx5"
        Me.PanelEx5.Size = New System.Drawing.Size(725, 463)
        Me.PanelEx5.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx5.Style.GradientAngle = 90
        Me.PanelEx5.TabIndex = 1
        '
        'DataGridViewX2
        '
        Me.DataGridViewX2.AllowUserToAddRows = False
        Me.DataGridViewX2.AllowUserToDeleteRows = False
        Me.DataGridViewX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDInseminacion2, Me.CodigoCerda2, Me.LoteGestacion2, Me.FechaSubida, Me.Peso, Me.DiasGestacion, Me.NoCuna, Me.Nota, Me.Accion2, Me.EstadoCerda, Me.vacio2})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewX2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX2.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DataGridViewX2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewX2.Name = "DataGridViewX2"
        Me.DataGridViewX2.Size = New System.Drawing.Size(725, 440)
        Me.DataGridViewX2.TabIndex = 1
        '
        'errorLabelX3
        '
        '
        '
        '
        Me.errorLabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.errorLabelX3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.errorLabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorLabelX3.ForeColor = System.Drawing.Color.Red
        Me.errorLabelX3.Location = New System.Drawing.Point(0, 440)
        Me.errorLabelX3.Name = "errorLabelX3"
        Me.errorLabelX3.Size = New System.Drawing.Size(725, 23)
        Me.errorLabelX3.TabIndex = 5
        Me.errorLabelX3.Text = "LabelX3"
        Me.errorLabelX3.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'IDInseminacion2
        '
        Me.IDInseminacion2.HeaderText = "ID Inseminación"
        Me.IDInseminacion2.Name = "IDInseminacion2"
        Me.IDInseminacion2.ReadOnly = True
        Me.IDInseminacion2.Width = 80
        '
        'CodigoCerda2
        '
        Me.CodigoCerda2.HeaderText = "Código Cerda"
        Me.CodigoCerda2.Name = "CodigoCerda2"
        Me.CodigoCerda2.ReadOnly = True
        Me.CodigoCerda2.Width = 80
        '
        'LoteGestacion2
        '
        Me.LoteGestacion2.HeaderText = "Lote Gestación"
        Me.LoteGestacion2.Name = "LoteGestacion2"
        Me.LoteGestacion2.ReadOnly = True
        Me.LoteGestacion2.Width = 80
        '
        'FechaSubida
        '
        Me.FechaSubida.AutoAdvance = True
        '
        '
        '
        Me.FechaSubida.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.FechaSubida.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.FechaSubida.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FechaSubida.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText
        Me.FechaSubida.HeaderText = "Fecha Subida"
        Me.FechaSubida.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        Me.FechaSubida.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.FechaSubida.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FechaSubida.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.FechaSubida.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FechaSubida.MonthCalendar.DisplayMonth = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.FechaSubida.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.FechaSubida.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.FechaSubida.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FechaSubida.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.FechaSubida.Name = "FechaSubida"
        Me.FechaSubida.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FechaSubida.Width = 80
        '
        'Peso
        '
        '
        '
        '
        Me.Peso.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.Peso.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.Peso.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Peso.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText
        Me.Peso.HeaderText = "Peso Lbs."
        Me.Peso.Increment = 1.0R
        Me.Peso.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        Me.Peso.Name = "Peso"
        Me.Peso.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Peso.Width = 70
        '
        'DiasGestacion
        '
        '
        '
        '
        Me.DiasGestacion.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.DiasGestacion.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.DiasGestacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DiasGestacion.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DiasGestacion.DefaultCellStyle = DataGridViewCellStyle3
        Me.DiasGestacion.HeaderText = "Dias Gestación"
        Me.DiasGestacion.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        Me.DiasGestacion.Name = "DiasGestacion"
        Me.DiasGestacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DiasGestacion.Width = 80
        '
        'NoCuna
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NoCuna.DefaultCellStyle = DataGridViewCellStyle4
        Me.NoCuna.HeaderText = "# Cuna"
        Me.NoCuna.Name = "NoCuna"
        Me.NoCuna.Width = 70
        '
        'Nota
        '
        Me.Nota.HeaderText = "Nota"
        Me.Nota.Name = "Nota"
        Me.Nota.Width = 150
        '
        'Accion2
        '
        Me.Accion2.HeaderText = "Acción"
        Me.Accion2.Name = "Accion2"
        Me.Accion2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Accion2.Text = Nothing
        Me.Accion2.Width = 70
        '
        'EstadoCerda
        '
        Me.EstadoCerda.HeaderText = "Estado Cerda"
        Me.EstadoCerda.Name = "EstadoCerda"
        Me.EstadoCerda.ReadOnly = True
        Me.EstadoCerda.Width = 70
        '
        'vacio2
        '
        Me.vacio2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.vacio2.HeaderText = ""
        Me.vacio2.Name = "vacio2"
        Me.vacio2.ReadOnly = True
        '
        'frmAñadirCerdasPreParto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1298, 576)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.PanelEx3)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAñadirCerdasPreParto"
        Me.Text = "Añadir Cerdas Pre Partos"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.PanelEx4.ResumeLayout(False)
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx5.ResumeLayout(False)
        CType(Me.DataGridViewX2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents codigocerdaTextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnGuardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PanelEx4 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx5 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DataGridViewX2 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents subidanoLabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents errorLabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lotegestacionComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ID_Inseminacion As DataGridViewTextBoxColumn
    Friend WithEvents CodigoCerda As DataGridViewTextBoxColumn
    Friend WithEvents EstadoActual As DataGridViewTextBoxColumn
    Friend WithEvents LoteGestacion As DataGridViewTextBoxColumn
    Friend WithEvents Accion As DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
    Friend WithEvents DiasGestacion1 As DataGridViewTextBoxColumn
    Friend WithEvents vacio As DataGridViewTextBoxColumn
    Friend WithEvents IDInseminacion2 As DataGridViewTextBoxColumn
    Friend WithEvents CodigoCerda2 As DataGridViewTextBoxColumn
    Friend WithEvents LoteGestacion2 As DataGridViewTextBoxColumn
    Friend WithEvents FechaSubida As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents Peso As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents DiasGestacion As DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn
    Friend WithEvents NoCuna As DataGridViewTextBoxColumn
    Friend WithEvents Nota As DataGridViewTextBoxColumn
    Friend WithEvents Accion2 As DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
    Friend WithEvents EstadoCerda As DataGridViewTextBoxColumn
    Friend WithEvents vacio2 As DataGridViewTextBoxColumn
End Class
