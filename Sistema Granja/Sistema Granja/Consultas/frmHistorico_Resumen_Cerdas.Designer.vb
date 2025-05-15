<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistorico_Resumen_Cerdas
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistorico_Resumen_Cerdas))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Historico_Resumen_cerdasDataGridViewX = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Historico_Resumen_cerdasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsBDGRANJA = New Sistema_Granja.DtsBDGRANJA()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.btnExportar = New DevComponents.DotNetBar.ButtonX()
        Me.btnGuardar = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Historico_Resumen_cerdasTableAdapter = New Sistema_Granja.DtsBDGRANJATableAdapters.Historico_Resumen_cerdasTableAdapter()
        Me.TableAdapterManager = New Sistema_Granja.DtsBDGRANJATableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No_Servicios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No_Ins_Nulas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No_Abortos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No_Partos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDescarte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDefuncion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelEx1.SuspendLayout()
        CType(Me.Historico_Resumen_cerdasDataGridViewX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Historico_Resumen_cerdasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsBDGRANJA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Historico_Resumen_cerdasDataGridViewX)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.btnExportar)
        Me.PanelEx1.Controls.Add(Me.btnGuardar)
        Me.PanelEx1.Controls.Add(Me.ButtonX3)
        Me.PanelEx1.Controls.Add(Me.Panel1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1001, 377)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'Historico_Resumen_cerdasDataGridViewX
        '
        Me.Historico_Resumen_cerdasDataGridViewX.AllowUserToAddRows = False
        Me.Historico_Resumen_cerdasDataGridViewX.AllowUserToDeleteRows = False
        Me.Historico_Resumen_cerdasDataGridViewX.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Historico_Resumen_cerdasDataGridViewX.AutoGenerateColumns = False
        Me.Historico_Resumen_cerdasDataGridViewX.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Historico_Resumen_cerdasDataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Historico_Resumen_cerdasDataGridViewX.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.No_Servicios, Me.No_Ins_Nulas, Me.No_Abortos, Me.No_Partos, Me.DataGridViewTextBoxColumn6, Me.FechaDescarte, Me.FechaDefuncion})
        Me.Historico_Resumen_cerdasDataGridViewX.DataSource = Me.Historico_Resumen_cerdasBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Historico_Resumen_cerdasDataGridViewX.DefaultCellStyle = DataGridViewCellStyle1
        Me.Historico_Resumen_cerdasDataGridViewX.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Historico_Resumen_cerdasDataGridViewX.Location = New System.Drawing.Point(9, 68)
        Me.Historico_Resumen_cerdasDataGridViewX.Name = "Historico_Resumen_cerdasDataGridViewX"
        Me.Historico_Resumen_cerdasDataGridViewX.ReadOnly = True
        Me.Historico_Resumen_cerdasDataGridViewX.Size = New System.Drawing.Size(982, 252)
        Me.Historico_Resumen_cerdasDataGridViewX.TabIndex = 10
        '
        'Historico_Resumen_cerdasBindingSource
        '
        Me.Historico_Resumen_cerdasBindingSource.DataMember = "Historico_Resumen_cerdas"
        Me.Historico_Resumen_cerdasBindingSource.DataSource = Me.DtsBDGRANJA
        '
        'DtsBDGRANJA
        '
        Me.DtsBDGRANJA.DataSetName = "DtsBDGRANJA"
        Me.DtsBDGRANJA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.txtCodigo)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 3)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(982, 59)
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
        Me.GroupPanel1.TabIndex = 10
        Me.GroupPanel1.Text = "Localizar"
        '
        'txtCodigo
        '
        '
        '
        '
        Me.txtCodigo.Border.Class = "TextBoxBorder"
        Me.txtCodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCodigo.Location = New System.Drawing.Point(138, 6)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 11
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(91, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 11
        Me.LabelX1.Text = "Codigo:"
        '
        'btnExportar
        '
        Me.btnExportar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.CallBasePaintBackground = True
        Me.btnExportar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnExportar.Location = New System.Drawing.Point(656, 339)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(121, 30)
        Me.btnExportar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnExportar.TabIndex = 9
        Me.btnExportar.Text = "&Exportar a Excel"
        '
        'btnGuardar
        '
        Me.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.CallBasePaintBackground = True
        Me.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Location = New System.Drawing.Point(783, 339)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(121, 30)
        Me.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "&Actualizar"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX3.CallBasePaintBackground = True
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Image = CType(resources.GetObject("ButtonX3.Image"), System.Drawing.Image)
        Me.ButtonX3.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.ButtonX3.Location = New System.Drawing.Point(910, 339)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(84, 30)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 8
        Me.ButtonX3.Text = "&Cancelar"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Location = New System.Drawing.Point(-2, 326)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 4)
        Me.Panel1.TabIndex = 0
        '
        'Historico_Resumen_cerdasTableAdapter
        '
        Me.Historico_Resumen_cerdasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BODEGASTableAdapter = Nothing
        Me.TableAdapterManager.BodegasTableAdapter1 = Nothing
        Me.TableAdapterManager.Buscar_Compra_reversion_x_nodocTableAdapter = Nothing
        Me.TableAdapterManager.Buscar_Requisicion_AnulacionTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.Costos_Concentrados_x_MesTableAdapter = Nothing
        Me.TableAdapterManager.ENCABEZADO_SALIDASTableAdapter = Nothing
        Me.TableAdapterManager.Estados_InseminacionesTableAdapter = Nothing
        Me.TableAdapterManager.F_Rev_Fechas_Inicio_Engordes_ConsultaTableAdapter = Nothing
        Me.TableAdapterManager.Inventario_MaterialesTableAdapter = Nothing
        Me.TableAdapterManager.LINEAS_DE_REQUISICIONESTableAdapter = Nothing
        Me.TableAdapterManager.LINEAS_DE_SALIDASTableAdapter = Nothing
        Me.TableAdapterManager.Sl_VerracosTableAdapter = Nothing
        Me.TableAdapterManager.traslados_detallesTableAdapter = Nothing
        Me.TableAdapterManager.traslados_encabezadosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_Granja.DtsBDGRANJATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Código_Cerda"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código Cerda"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'No_Servicios
        '
        Me.No_Servicios.DataPropertyName = "No_Servicios"
        Me.No_Servicios.HeaderText = "No_Servicios"
        Me.No_Servicios.Name = "No_Servicios"
        Me.No_Servicios.ReadOnly = True
        '
        'No_Ins_Nulas
        '
        Me.No_Ins_Nulas.DataPropertyName = "No_Ins_Nulas"
        Me.No_Ins_Nulas.HeaderText = "No_Ins_Nulas"
        Me.No_Ins_Nulas.Name = "No_Ins_Nulas"
        Me.No_Ins_Nulas.ReadOnly = True
        '
        'No_Abortos
        '
        Me.No_Abortos.DataPropertyName = "No_Abortos"
        Me.No_Abortos.HeaderText = "No_Abortos"
        Me.No_Abortos.Name = "No_Abortos"
        Me.No_Abortos.ReadOnly = True
        '
        'No_Partos
        '
        Me.No_Partos.DataPropertyName = "No_Partos"
        Me.No_Partos.HeaderText = "No_Partos"
        Me.No_Partos.Name = "No_Partos"
        Me.No_Partos.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Estado Actual"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Estado Actual"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 235
        '
        'FechaDescarte
        '
        Me.FechaDescarte.DataPropertyName = "FechaDescarte"
        Me.FechaDescarte.HeaderText = "FechaDescarte"
        Me.FechaDescarte.Name = "FechaDescarte"
        Me.FechaDescarte.ReadOnly = True
        '
        'FechaDefuncion
        '
        Me.FechaDefuncion.DataPropertyName = "FechaDefuncion"
        Me.FechaDefuncion.HeaderText = "FechaDefuncion"
        Me.FechaDefuncion.Name = "FechaDefuncion"
        Me.FechaDefuncion.ReadOnly = True
        '
        'frmHistorico_Resumen_Cerdas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 377)
        Me.Controls.Add(Me.PanelEx1)
        Me.Name = "frmHistorico_Resumen_Cerdas"
        Me.Text = "..::Historico Cerdas::.."
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.Historico_Resumen_cerdasDataGridViewX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Historico_Resumen_cerdasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsBDGRANJA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnExportar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnGuardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DtsBDGRANJA As Sistema_Granja.DtsBDGRANJA
    Friend WithEvents Historico_Resumen_cerdasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Historico_Resumen_cerdasTableAdapter As Sistema_Granja.DtsBDGRANJATableAdapters.Historico_Resumen_cerdasTableAdapter
    Friend WithEvents TableAdapterManager As Sistema_Granja.DtsBDGRANJATableAdapters.TableAdapterManager
    Friend WithEvents Historico_Resumen_cerdasDataGridViewX As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents No_Servicios As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents No_Ins_Nulas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents No_Abortos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents No_Partos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDescarte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDefuncion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
