<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotaReingreso
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotaReingreso))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.imprimirButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.JustificacionTextBoxX3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.guardarButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.salidanoIntegerInput1 = New DevComponents.Editors.IntegerInput()
        Me.quitarLinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.añadirLinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lote_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_Salida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso_Real_Lbs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso_Prom_Lbs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso_Canal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioRealVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Motivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ubicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vacia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estadoTextBoxX4 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.usuarioTextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.fechahoranatDateTimeInput2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.fechasistemaDateTimeInput1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.documentoTextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.CorrelativoTextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.salidanoIntegerInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fechahoranatDateTimeInput2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fechasistemaDateTimeInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Controls.Add(Me.salidanoIntegerInput1)
        Me.PanelEx1.Controls.Add(Me.quitarLinkLabel2)
        Me.PanelEx1.Controls.Add(Me.añadirLinkLabel1)
        Me.PanelEx1.Controls.Add(Me.DataGridViewX1)
        Me.PanelEx1.Controls.Add(Me.estadoTextBoxX4)
        Me.PanelEx1.Controls.Add(Me.LabelX8)
        Me.PanelEx1.Controls.Add(Me.usuarioTextBoxX2)
        Me.PanelEx1.Controls.Add(Me.LabelX6)
        Me.PanelEx1.Controls.Add(Me.fechahoranatDateTimeInput2)
        Me.PanelEx1.Controls.Add(Me.LabelX5)
        Me.PanelEx1.Controls.Add(Me.fechasistemaDateTimeInput1)
        Me.PanelEx1.Controls.Add(Me.LabelX4)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.documentoTextBoxX2)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.CorrelativoTextBoxX1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1108, 467)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.ButtonX1)
        Me.PanelEx2.Controls.Add(Me.imprimirButtonX3)
        Me.PanelEx2.Controls.Add(Me.JustificacionTextBoxX3)
        Me.PanelEx2.Controls.Add(Me.LabelX7)
        Me.PanelEx2.Controls.Add(Me.guardarButtonX2)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(6, 361)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1090, 83)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 23
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.Sistema_Granja.My.Resources.Resources.DeleteRed
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.ButtonX1.Location = New System.Drawing.Point(994, 12)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(85, 34)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 19
        Me.ButtonX1.Text = "&Cerrar"
        '
        'imprimirButtonX3
        '
        Me.imprimirButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.imprimirButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.imprimirButtonX3.Image = Global.Sistema_Granja.My.Resources.Resources.printer_icon
        Me.imprimirButtonX3.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.imprimirButtonX3.Location = New System.Drawing.Point(804, 12)
        Me.imprimirButtonX3.Name = "imprimirButtonX3"
        Me.imprimirButtonX3.Size = New System.Drawing.Size(89, 34)
        Me.imprimirButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.imprimirButtonX3.TabIndex = 22
        Me.imprimirButtonX3.Text = "&Imprimir"
        '
        'JustificacionTextBoxX3
        '
        '
        '
        '
        Me.JustificacionTextBoxX3.Border.Class = "TextBoxBorder"
        Me.JustificacionTextBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.JustificacionTextBoxX3.Location = New System.Drawing.Point(76, 12)
        Me.JustificacionTextBoxX3.MaxLength = 200
        Me.JustificacionTextBoxX3.Multiline = True
        Me.JustificacionTextBoxX3.Name = "JustificacionTextBoxX3"
        Me.JustificacionTextBoxX3.PreventEnterBeep = True
        Me.JustificacionTextBoxX3.Size = New System.Drawing.Size(710, 58)
        Me.JustificacionTextBoxX3.TabIndex = 12
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(6, 12)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(64, 23)
        Me.LabelX7.TabIndex = 13
        Me.LabelX7.Text = "Justificación"
        '
        'guardarButtonX2
        '
        Me.guardarButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.guardarButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.guardarButtonX2.Image = Global.Sistema_Granja.My.Resources.Resources.filesave
        Me.guardarButtonX2.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.guardarButtonX2.Location = New System.Drawing.Point(899, 12)
        Me.guardarButtonX2.Name = "guardarButtonX2"
        Me.guardarButtonX2.Size = New System.Drawing.Size(89, 34)
        Me.guardarButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.guardarButtonX2.TabIndex = 20
        Me.guardarButtonX2.Text = "&Guardar"
        '
        'salidanoIntegerInput1
        '
        '
        '
        '
        Me.salidanoIntegerInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.salidanoIntegerInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.salidanoIntegerInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.salidanoIntegerInput1.Location = New System.Drawing.Point(82, 30)
        Me.salidanoIntegerInput1.Name = "salidanoIntegerInput1"
        Me.salidanoIntegerInput1.ShowUpDown = True
        Me.salidanoIntegerInput1.Size = New System.Drawing.Size(100, 20)
        Me.salidanoIntegerInput1.TabIndex = 21
        '
        'quitarLinkLabel2
        '
        Me.quitarLinkLabel2.AutoSize = True
        Me.quitarLinkLabel2.Location = New System.Drawing.Point(1061, 113)
        Me.quitarLinkLabel2.Name = "quitarLinkLabel2"
        Me.quitarLinkLabel2.Size = New System.Drawing.Size(35, 13)
        Me.quitarLinkLabel2.TabIndex = 18
        Me.quitarLinkLabel2.TabStop = True
        Me.quitarLinkLabel2.Text = "Quitar"
        '
        'añadirLinkLabel1
        '
        Me.añadirLinkLabel1.AutoSize = True
        Me.añadirLinkLabel1.Location = New System.Drawing.Point(1018, 113)
        Me.añadirLinkLabel1.Name = "añadirLinkLabel1"
        Me.añadirLinkLabel1.Size = New System.Drawing.Size(37, 13)
        Me.añadirLinkLabel1.TabIndex = 17
        Me.añadirLinkLabel1.TabStop = True
        Me.añadirLinkLabel1.Text = "Añadir"
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Linea, Me.Lote_No, Me.Codigo, Me.Tipo_Salida, Me.Cantidad, Me.Unitario, Me.Importe, Me.Peso_Real_Lbs, Me.Peso_Prom_Lbs, Me.Peso_Canal, Me.PrecioRealVenta, Me.Motivo, Me.Ubicacion, Me.Comentario, Me.vacia})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewX1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridViewX1.EnableHeadersVisualStyles = False
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(13, 129)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewX1.Size = New System.Drawing.Size(1083, 226)
        Me.DataGridViewX1.TabIndex = 16
        '
        'Linea
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Linea.DefaultCellStyle = DataGridViewCellStyle2
        Me.Linea.HeaderText = "# Linea"
        Me.Linea.Name = "Linea"
        Me.Linea.ReadOnly = True
        Me.Linea.Width = 50
        '
        'Lote_No
        '
        Me.Lote_No.HeaderText = "Lote No."
        Me.Lote_No.Name = "Lote_No"
        Me.Lote_No.ReadOnly = True
        Me.Lote_No.Width = 70
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo Cerda(o)"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 70
        '
        'Tipo_Salida
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Tipo_Salida.DefaultCellStyle = DataGridViewCellStyle3
        Me.Tipo_Salida.HeaderText = "Tipo Salida"
        Me.Tipo_Salida.Name = "Tipo_Salida"
        Me.Tipo_Salida.ReadOnly = True
        Me.Tipo_Salida.Width = 70
        '
        'Cantidad
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle4
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 70
        '
        'Unitario
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        Me.Unitario.DefaultCellStyle = DataGridViewCellStyle5
        Me.Unitario.HeaderText = "Unitario"
        Me.Unitario.Name = "Unitario"
        Me.Unitario.ReadOnly = True
        Me.Unitario.Width = 80
        '
        'Importe
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle6
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        Me.Importe.Width = 80
        '
        'Peso_Real_Lbs
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.Peso_Real_Lbs.DefaultCellStyle = DataGridViewCellStyle7
        Me.Peso_Real_Lbs.HeaderText = "Peso Real Lbs."
        Me.Peso_Real_Lbs.Name = "Peso_Real_Lbs"
        Me.Peso_Real_Lbs.ReadOnly = True
        Me.Peso_Real_Lbs.Width = 80
        '
        'Peso_Prom_Lbs
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        Me.Peso_Prom_Lbs.DefaultCellStyle = DataGridViewCellStyle8
        Me.Peso_Prom_Lbs.HeaderText = "Peso Promedio Lbs."
        Me.Peso_Prom_Lbs.Name = "Peso_Prom_Lbs"
        Me.Peso_Prom_Lbs.ReadOnly = True
        Me.Peso_Prom_Lbs.Width = 80
        '
        'Peso_Canal
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        Me.Peso_Canal.DefaultCellStyle = DataGridViewCellStyle9
        Me.Peso_Canal.HeaderText = "Peso en Canal"
        Me.Peso_Canal.Name = "Peso_Canal"
        Me.Peso_Canal.ReadOnly = True
        Me.Peso_Canal.Width = 80
        '
        'PrecioRealVenta
        '
        Me.PrecioRealVenta.HeaderText = "Precio Venta"
        Me.PrecioRealVenta.MinimumWidth = 2
        Me.PrecioRealVenta.Name = "PrecioRealVenta"
        Me.PrecioRealVenta.ReadOnly = True
        Me.PrecioRealVenta.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PrecioRealVenta.Width = 2
        '
        'Motivo
        '
        Me.Motivo.HeaderText = "Motivo"
        Me.Motivo.MinimumWidth = 2
        Me.Motivo.Name = "Motivo"
        Me.Motivo.ReadOnly = True
        Me.Motivo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Motivo.Width = 2
        '
        'Ubicacion
        '
        Me.Ubicacion.HeaderText = "Ubicación"
        Me.Ubicacion.MinimumWidth = 2
        Me.Ubicacion.Name = "Ubicacion"
        Me.Ubicacion.ReadOnly = True
        Me.Ubicacion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Ubicacion.Width = 2
        '
        'Comentario
        '
        Me.Comentario.DataPropertyName = "Comentario"
        Me.Comentario.HeaderText = "Comentario"
        Me.Comentario.MaxInputLength = 250
        Me.Comentario.Name = "Comentario"
        Me.Comentario.Width = 250
        '
        'vacia
        '
        Me.vacia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.vacia.HeaderText = ""
        Me.vacia.Name = "vacia"
        Me.vacia.ReadOnly = True
        '
        'estadoTextBoxX4
        '
        Me.estadoTextBoxX4.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.estadoTextBoxX4.Border.Class = "TextBoxBorder"
        Me.estadoTextBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.estadoTextBoxX4.Location = New System.Drawing.Point(297, 88)
        Me.estadoTextBoxX4.Name = "estadoTextBoxX4"
        Me.estadoTextBoxX4.PreventEnterBeep = True
        Me.estadoTextBoxX4.ReadOnly = True
        Me.estadoTextBoxX4.Size = New System.Drawing.Size(88, 20)
        Me.estadoTextBoxX4.TabIndex = 15
        Me.estadoTextBoxX4.Text = "Pe"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(204, 85)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(64, 23)
        Me.LabelX8.TabIndex = 14
        Me.LabelX8.Text = "Estado"
        '
        'usuarioTextBoxX2
        '
        Me.usuarioTextBoxX2.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.usuarioTextBoxX2.Border.Class = "TextBoxBorder"
        Me.usuarioTextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.usuarioTextBoxX2.Location = New System.Drawing.Point(82, 83)
        Me.usuarioTextBoxX2.Name = "usuarioTextBoxX2"
        Me.usuarioTextBoxX2.PreventEnterBeep = True
        Me.usuarioTextBoxX2.ReadOnly = True
        Me.usuarioTextBoxX2.Size = New System.Drawing.Size(100, 20)
        Me.usuarioTextBoxX2.TabIndex = 11
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(13, 80)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(64, 23)
        Me.LabelX6.TabIndex = 10
        Me.LabelX6.Text = "Usuario"
        '
        'fechahoranatDateTimeInput2
        '
        '
        '
        '
        Me.fechahoranatDateTimeInput2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.fechahoranatDateTimeInput2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechahoranatDateTimeInput2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.fechahoranatDateTimeInput2.ButtonDropDown.Visible = True
        Me.fechahoranatDateTimeInput2.IsInputReadOnly = True
        Me.fechahoranatDateTimeInput2.IsPopupCalendarOpen = False
        Me.fechahoranatDateTimeInput2.Location = New System.Drawing.Point(297, 59)
        '
        '
        '
        Me.fechahoranatDateTimeInput2.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fechahoranatDateTimeInput2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechahoranatDateTimeInput2.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.fechahoranatDateTimeInput2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.fechahoranatDateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.fechahoranatDateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.fechahoranatDateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.fechahoranatDateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.fechahoranatDateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.fechahoranatDateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.fechahoranatDateTimeInput2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechahoranatDateTimeInput2.MonthCalendar.DisplayMonth = New Date(2020, 3, 1, 0, 0, 0, 0)
        Me.fechahoranatDateTimeInput2.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.fechahoranatDateTimeInput2.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fechahoranatDateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.fechahoranatDateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.fechahoranatDateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.fechahoranatDateTimeInput2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechahoranatDateTimeInput2.MonthCalendar.TodayButtonVisible = True
        Me.fechahoranatDateTimeInput2.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.fechahoranatDateTimeInput2.Name = "fechahoranatDateTimeInput2"
        Me.fechahoranatDateTimeInput2.Size = New System.Drawing.Size(88, 20)
        Me.fechahoranatDateTimeInput2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.fechahoranatDateTimeInput2.TabIndex = 9
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(204, 56)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(86, 23)
        Me.LabelX5.TabIndex = 8
        Me.LabelX5.Text = "Fecha Hora Nat."
        '
        'fechasistemaDateTimeInput1
        '
        '
        '
        '
        Me.fechasistemaDateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.fechasistemaDateTimeInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechasistemaDateTimeInput1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.fechasistemaDateTimeInput1.ButtonDropDown.Visible = True
        Me.fechasistemaDateTimeInput1.IsInputReadOnly = True
        Me.fechasistemaDateTimeInput1.IsPopupCalendarOpen = False
        Me.fechasistemaDateTimeInput1.Location = New System.Drawing.Point(297, 31)
        '
        '
        '
        Me.fechasistemaDateTimeInput1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fechasistemaDateTimeInput1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechasistemaDateTimeInput1.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.fechasistemaDateTimeInput1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.fechasistemaDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.fechasistemaDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.fechasistemaDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.fechasistemaDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.fechasistemaDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.fechasistemaDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.fechasistemaDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechasistemaDateTimeInput1.MonthCalendar.DisplayMonth = New Date(2020, 3, 1, 0, 0, 0, 0)
        Me.fechasistemaDateTimeInput1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.fechasistemaDateTimeInput1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fechasistemaDateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.fechasistemaDateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.fechasistemaDateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.fechasistemaDateTimeInput1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechasistemaDateTimeInput1.MonthCalendar.TodayButtonVisible = True
        Me.fechasistemaDateTimeInput1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.fechasistemaDateTimeInput1.Name = "fechasistemaDateTimeInput1"
        Me.fechasistemaDateTimeInput1.Size = New System.Drawing.Size(88, 20)
        Me.fechasistemaDateTimeInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.fechasistemaDateTimeInput1.TabIndex = 7
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(204, 29)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(86, 23)
        Me.LabelX4.TabIndex = 6
        Me.LabelX4.Text = "Fecha Sistema"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(12, 28)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(62, 23)
        Me.LabelX3.TabIndex = 4
        Me.LabelX3.Text = "Salida No."
        '
        'documentoTextBoxX2
        '
        Me.documentoTextBoxX2.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.documentoTextBoxX2.Border.Class = "TextBoxBorder"
        Me.documentoTextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.documentoTextBoxX2.Location = New System.Drawing.Point(82, 56)
        Me.documentoTextBoxX2.Name = "documentoTextBoxX2"
        Me.documentoTextBoxX2.PreventEnterBeep = True
        Me.documentoTextBoxX2.ReadOnly = True
        Me.documentoTextBoxX2.Size = New System.Drawing.Size(100, 20)
        Me.documentoTextBoxX2.TabIndex = 3
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(12, 53)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(64, 23)
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "Documento"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(888, 47)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(62, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Correlativo"
        '
        'CorrelativoTextBoxX1
        '
        Me.CorrelativoTextBoxX1.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.CorrelativoTextBoxX1.Border.Class = "TextBoxBorder"
        Me.CorrelativoTextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.CorrelativoTextBoxX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorrelativoTextBoxX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CorrelativoTextBoxX1.Location = New System.Drawing.Point(956, 42)
        Me.CorrelativoTextBoxX1.Name = "CorrelativoTextBoxX1"
        Me.CorrelativoTextBoxX1.PreventEnterBeep = True
        Me.CorrelativoTextBoxX1.ReadOnly = True
        Me.CorrelativoTextBoxX1.Size = New System.Drawing.Size(140, 37)
        Me.CorrelativoTextBoxX1.TabIndex = 0
        Me.CorrelativoTextBoxX1.Text = "0000000000"
        Me.CorrelativoTextBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmNotaReingreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 467)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNotaReingreso"
        Me.Text = "Nota de Reingreso"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.salidanoIntegerInput1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fechahoranatDateTimeInput2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fechasistemaDateTimeInput1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CorrelativoTextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents estadoTextBoxX4 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents JustificacionTextBoxX3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents usuarioTextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents fechahoranatDateTimeInput2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents fechasistemaDateTimeInput1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents quitarLinkLabel2 As LinkLabel
    Friend WithEvents añadirLinkLabel1 As LinkLabel
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents documentoTextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents guardarButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents salidanoIntegerInput1 As DevComponents.Editors.IntegerInput
    Friend WithEvents imprimirButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Linea As DataGridViewTextBoxColumn
    Friend WithEvents Lote_No As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Tipo_Salida As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Unitario As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents Peso_Real_Lbs As DataGridViewTextBoxColumn
    Friend WithEvents Peso_Prom_Lbs As DataGridViewTextBoxColumn
    Friend WithEvents Peso_Canal As DataGridViewTextBoxColumn
    Friend WithEvents PrecioRealVenta As DataGridViewTextBoxColumn
    Friend WithEvents Motivo As DataGridViewTextBoxColumn
    Friend WithEvents Ubicacion As DataGridViewTextBoxColumn
    Friend WithEvents Comentario As DataGridViewTextBoxColumn
    Friend WithEvents vacia As DataGridViewTextBoxColumn
End Class
