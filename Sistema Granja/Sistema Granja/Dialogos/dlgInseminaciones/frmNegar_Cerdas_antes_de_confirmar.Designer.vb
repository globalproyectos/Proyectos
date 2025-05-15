<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNegar_Cerdas_antes_de_confirmar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNegar_Cerdas_antes_de_confirmar))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx
        Me.btnGuardar = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.Lista_Cerdas_Montas_Pendientes_ConfBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsBDGRANJA = New Sistema_Granja.DtsBDGRANJA
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cbxLotesMontas = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.Lista_Cerdas_Montas_Pendientes_ConfTableAdapter = New Sistema_Granja.DtsBDGRANJATableAdapters.Lista_Cerdas_Montas_Pendientes_ConfTableAdapter
        Me.TableAdapterManager = New Sistema_Granja.DtsBDGRANJATableAdapters.TableAdapterManager
        Me.IDIns = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoCerda = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstadoActual = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.RibbonClientPanel1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lista_Cerdas_Montas_Pendientes_ConfBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsBDGRANJA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
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
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(592, 466)
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
        Me.PanelEx3.Controls.Add(Me.btnGuardar)
        Me.PanelEx3.Controls.Add(Me.ButtonX3)
        Me.PanelEx3.Location = New System.Drawing.Point(1, 425)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(588, 40)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 0
        '
        'btnGuardar
        '
        Me.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGuardar.CallBasePaintBackground = True
        Me.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Location = New System.Drawing.Point(363, 5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(132, 30)
        Me.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "&Guardar Cambios"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.CallBasePaintBackground = True
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Image = CType(resources.GetObject("ButtonX3.Image"), System.Drawing.Image)
        Me.ButtonX3.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.ButtonX3.Location = New System.Drawing.Point(498, 5)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(84, 30)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 7
        Me.ButtonX3.Text = "&Cerrar"
        '
        'PanelEx2
        '
        Me.PanelEx2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.GroupPanel2)
        Me.PanelEx2.Location = New System.Drawing.Point(1, 63)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(588, 361)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 1
        '
        'GroupPanel2
        '
        Me.GroupPanel2.AutoScroll = True
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX)
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(588, 361)
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
        Me.GroupPanel2.Text = "Resultados"
        '
        'Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX
        '
        Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.AllowUserToAddRows = False
        Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.AllowUserToDeleteRows = False
        Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.AutoGenerateColumns = False
        Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDIns, Me.CodigoCerda, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.EstadoActual})
        Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.DataSource = Me.Lista_Cerdas_Montas_Pendientes_ConfBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.DefaultCellStyle = DataGridViewCellStyle3
        Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Location = New System.Drawing.Point(0, 0)
        Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Name = "Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX"
        Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.Size = New System.Drawing.Size(582, 340)
        Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX.TabIndex = 0
        '
        'Lista_Cerdas_Montas_Pendientes_ConfBindingSource
        '
        Me.Lista_Cerdas_Montas_Pendientes_ConfBindingSource.DataMember = "Lista_Cerdas_Montas_Pendientes_Conf"
        Me.Lista_Cerdas_Montas_Pendientes_ConfBindingSource.DataSource = Me.DtsBDGRANJA
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
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Location = New System.Drawing.Point(3, 3)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(586, 60)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.cbxLotesMontas)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(586, 60)
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
        Me.GroupPanel1.TabIndex = 1
        Me.GroupPanel1.Text = "Seleccione el Lote"
        '
        'cbxLotesMontas
        '
        Me.cbxLotesMontas.DisplayMember = "Text"
        Me.cbxLotesMontas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxLotesMontas.FormattingEnabled = True
        Me.cbxLotesMontas.ItemHeight = 14
        Me.cbxLotesMontas.Location = New System.Drawing.Point(169, 6)
        Me.cbxLotesMontas.Name = "cbxLotesMontas"
        Me.cbxLotesMontas.Size = New System.Drawing.Size(131, 20)
        Me.cbxLotesMontas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbxLotesMontas.TabIndex = 1
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(120, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(61, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Lote No:"
        '
        'Lista_Cerdas_Montas_Pendientes_ConfTableAdapter
        '
        Me.Lista_Cerdas_Montas_Pendientes_ConfTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.F_Rev_Fechas_Inicio_Engordes_ConsultaTableAdapter = Nothing
        Me.TableAdapterManager.LINEAS_DE_REQUISICIONESTableAdapter = Nothing
        Me.TableAdapterManager.LINEAS_DE_SALIDASTableAdapter = Nothing
        Me.TableAdapterManager.Sl_VerracosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_Granja.DtsBDGRANJATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDIns
        '
        Me.IDIns.DataPropertyName = "Id_Enseminacion"
        Me.IDIns.HeaderText = "ID. Ins."
        Me.IDIns.Name = "IDIns"
        Me.IDIns.ReadOnly = True
        Me.IDIns.Width = 60
        '
        'CodigoCerda
        '
        Me.CodigoCerda.DataPropertyName = "Código_Cerda"
        Me.CodigoCerda.HeaderText = "Código Cerda"
        Me.CodigoCerda.Name = "CodigoCerda"
        Me.CodigoCerda.ReadOnly = True
        Me.CodigoCerda.Width = 90
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "L_Genetica"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn2.HeaderText = "Genética"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Fecha_Nacimiento"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha Nac."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'EstadoActual
        '
        Me.EstadoActual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.NullValue = "INSEMINADA PENDIENTE"
        Me.EstadoActual.DefaultCellStyle = DataGridViewCellStyle2
        Me.EstadoActual.HeaderText = "Estado Actual"
        Me.EstadoActual.Items.AddRange(New Object() {"INSEMINADA PENDIENTE", "NULA"})
        Me.EstadoActual.Name = "EstadoActual"
        Me.EstadoActual.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EstadoActual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'frmNegar_Cerdas_antes_de_confirmar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 466)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.DoubleBuffered = True
        Me.Name = "frmNegar_Cerdas_antes_de_confirmar"
        Me.Text = "Negar Cerdas"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lista_Cerdas_Montas_Pendientes_ConfBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsBDGRANJA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbxLotesMontas As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents DtsBDGRANJA As Sistema_Granja.DtsBDGRANJA
    Friend WithEvents Lista_Cerdas_Montas_Pendientes_ConfBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Lista_Cerdas_Montas_Pendientes_ConfTableAdapter As Sistema_Granja.DtsBDGRANJATableAdapters.Lista_Cerdas_Montas_Pendientes_ConfTableAdapter
    Friend WithEvents TableAdapterManager As Sistema_Granja.DtsBDGRANJATableAdapters.TableAdapterManager
    Friend WithEvents Lista_Cerdas_Montas_Pendientes_ConfDataGridViewX As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnGuardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents IDIns As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoCerda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoActual As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
