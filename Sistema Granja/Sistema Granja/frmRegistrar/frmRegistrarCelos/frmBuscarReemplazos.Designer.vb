<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarReemplazos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarReemplazos))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.seleccionarButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ID_Cerda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_Cerda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Padre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Madre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Etapa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genetica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdadDias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clasificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vacio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelEx1.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.DataGridViewX1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 41)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(946, 487)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Cerda, Me.Tipo_Cerda, Me.Fecha_Nac, Me.Padre, Me.Madre, Me.Etapa, Me.Genetica, Me.EdadDias, Me.Clasificacion, Me.vacio})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        Me.DataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewX1.Size = New System.Drawing.Size(946, 487)
        Me.DataGridViewX1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBoxX1)
        Me.Panel1.Controls.Add(Me.LabelX1)
        Me.Panel1.Controls.Add(Me.ButtonX2)
        Me.Panel1.Controls.Add(Me.seleccionarButtonX1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(946, 41)
        Me.Panel1.TabIndex = 2
        '
        'TextBoxX1
        '
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.Location = New System.Drawing.Point(62, 12)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.PreventEnterBeep = True
        Me.TextBoxX1.Size = New System.Drawing.Size(381, 20)
        Me.TextBoxX1.TabIndex = 4
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(13, 9)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 3
        Me.LabelX1.Text = "Búscar"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.Sistema_Granja.My.Resources.Resources.DeleteRed
        Me.ButtonX2.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.ButtonX2.Location = New System.Drawing.Point(863, 10)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 2
        Me.ButtonX2.Text = "&Cerrar"
        '
        'seleccionarButtonX1
        '
        Me.seleccionarButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.seleccionarButtonX1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.seleccionarButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.seleccionarButtonX1.Image = Global.Sistema_Granja.My.Resources.Resources.ok
        Me.seleccionarButtonX1.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.seleccionarButtonX1.Location = New System.Drawing.Point(752, 10)
        Me.seleccionarButtonX1.Name = "seleccionarButtonX1"
        Me.seleccionarButtonX1.Size = New System.Drawing.Size(105, 23)
        Me.seleccionarButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.seleccionarButtonX1.TabIndex = 1
        Me.seleccionarButtonX1.Text = "&Seleccionar"
        '
        'ID_Cerda
        '
        Me.ID_Cerda.DataPropertyName = "IdCerda"
        Me.ID_Cerda.HeaderText = "ID Cerda"
        Me.ID_Cerda.Name = "ID_Cerda"
        Me.ID_Cerda.ReadOnly = True
        '
        'Tipo_Cerda
        '
        Me.Tipo_Cerda.DataPropertyName = "Tipo"
        Me.Tipo_Cerda.HeaderText = "Tipo Cerda"
        Me.Tipo_Cerda.Name = "Tipo_Cerda"
        Me.Tipo_Cerda.ReadOnly = True
        '
        'Fecha_Nac
        '
        Me.Fecha_Nac.DataPropertyName = "Fecha_Nacimiento"
        Me.Fecha_Nac.HeaderText = "Fecha Nacimiento"
        Me.Fecha_Nac.Name = "Fecha_Nac"
        Me.Fecha_Nac.ReadOnly = True
        '
        'Padre
        '
        Me.Padre.DataPropertyName = "Padre"
        Me.Padre.HeaderText = "Padre"
        Me.Padre.Name = "Padre"
        Me.Padre.ReadOnly = True
        '
        'Madre
        '
        Me.Madre.DataPropertyName = "Madre"
        Me.Madre.HeaderText = "Madre"
        Me.Madre.Name = "Madre"
        Me.Madre.ReadOnly = True
        '
        'Etapa
        '
        Me.Etapa.DataPropertyName = "etapa"
        Me.Etapa.HeaderText = "Etapa"
        Me.Etapa.Name = "Etapa"
        Me.Etapa.ReadOnly = True
        '
        'Genetica
        '
        Me.Genetica.DataPropertyName = "L_Genetica"
        Me.Genetica.HeaderText = "Genetica"
        Me.Genetica.Name = "Genetica"
        Me.Genetica.ReadOnly = True
        '
        'EdadDias
        '
        Me.EdadDias.DataPropertyName = "edaddias"
        Me.EdadDias.HeaderText = "Edad Días"
        Me.EdadDias.Name = "EdadDias"
        Me.EdadDias.ReadOnly = True
        '
        'Clasificacion
        '
        Me.Clasificacion.DataPropertyName = "IdClase"
        Me.Clasificacion.HeaderText = "Clasificación"
        Me.Clasificacion.Name = "Clasificacion"
        Me.Clasificacion.ReadOnly = True
        '
        'vacio
        '
        Me.vacio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.vacio.HeaderText = ""
        Me.vacio.Name = "vacio"
        Me.vacio.ReadOnly = True
        '
        'frmBuscarReemplazos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 528)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBuscarReemplazos"
        Me.Text = "Búsqueda de reemplazos"
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents seleccionarButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ID_Cerda As DataGridViewTextBoxColumn
    Friend WithEvents Tipo_Cerda As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Nac As DataGridViewTextBoxColumn
    Friend WithEvents Padre As DataGridViewTextBoxColumn
    Friend WithEvents Madre As DataGridViewTextBoxColumn
    Friend WithEvents Etapa As DataGridViewTextBoxColumn
    Friend WithEvents Genetica As DataGridViewTextBoxColumn
    Friend WithEvents EdadDias As DataGridViewTextBoxColumn
    Friend WithEvents Clasificacion As DataGridViewTextBoxColumn
    Friend WithEvents vacio As DataGridViewTextBoxColumn
End Class
