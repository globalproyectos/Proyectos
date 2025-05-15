<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCerdaALista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddCerdaALista))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.buscarTextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.aceptarButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.CancelarButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo_Cerda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lote_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado_Actual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vacia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelEx1.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.DataGridViewX1)
        Me.PanelEx1.Controls.Add(Me.buscarTextBoxX1)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.GroupBox1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(507, 410)
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
        Me.DataGridViewX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewX1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tipo, Me.Codigo_Cerda, Me.Lote_No, Me.Estado_Actual, Me.vacia})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(12, 50)
        Me.DataGridViewX1.MultiSelect = False
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewX1.Size = New System.Drawing.Size(483, 294)
        Me.DataGridViewX1.TabIndex = 6
        '
        'buscarTextBoxX1
        '
        Me.buscarTextBoxX1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.buscarTextBoxX1.Border.Class = "TextBoxBorder"
        Me.buscarTextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.buscarTextBoxX1.Location = New System.Drawing.Point(77, 23)
        Me.buscarTextBoxX1.Name = "buscarTextBoxX1"
        Me.buscarTextBoxX1.PreventEnterBeep = True
        Me.buscarTextBoxX1.Size = New System.Drawing.Size(418, 20)
        Me.buscarTextBoxX1.TabIndex = 0
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(12, 21)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(67, 23)
        Me.LabelX2.TabIndex = 20
        Me.LabelX2.Text = "Búscar:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.aceptarButtonX2)
        Me.GroupBox1.Controls.Add(Me.CancelarButtonX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 354)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(507, 56)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones"
        '
        'aceptarButtonX2
        '
        Me.aceptarButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.aceptarButtonX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aceptarButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.aceptarButtonX2.Image = Global.Sistema_Granja.My.Resources.Resources.ok
        Me.aceptarButtonX2.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.aceptarButtonX2.Location = New System.Drawing.Point(304, 18)
        Me.aceptarButtonX2.Name = "aceptarButtonX2"
        Me.aceptarButtonX2.Size = New System.Drawing.Size(91, 30)
        Me.aceptarButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.aceptarButtonX2.TabIndex = 1
        Me.aceptarButtonX2.Text = "&Aceptar"
        '
        'CancelarButtonX1
        '
        Me.CancelarButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.CancelarButtonX1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelarButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.CancelarButtonX1.Image = Global.Sistema_Granja.My.Resources.Resources.DeleteRed
        Me.CancelarButtonX1.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.CancelarButtonX1.Location = New System.Drawing.Point(401, 18)
        Me.CancelarButtonX1.Name = "CancelarButtonX1"
        Me.CancelarButtonX1.Size = New System.Drawing.Size(94, 30)
        Me.CancelarButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CancelarButtonX1.TabIndex = 2
        Me.CancelarButtonX1.Text = "&Cancelar"
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        '
        'Codigo_Cerda
        '
        Me.Codigo_Cerda.DataPropertyName = "Codigo_Cerda"
        Me.Codigo_Cerda.HeaderText = "Código"
        Me.Codigo_Cerda.Name = "Codigo_Cerda"
        '
        'Lote_No
        '
        Me.Lote_No.DataPropertyName = "Lote_No"
        Me.Lote_No.HeaderText = "Lote No."
        Me.Lote_No.Name = "Lote_No"
        '
        'Estado_Actual
        '
        Me.Estado_Actual.DataPropertyName = "Estado_Actual"
        Me.Estado_Actual.HeaderText = "Estado Actual"
        Me.Estado_Actual.Name = "Estado_Actual"
        '
        'vacia
        '
        Me.vacia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.vacia.HeaderText = ""
        Me.vacia.Name = "vacia"
        '
        'frmAddCerdaALista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 410)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddCerdaALista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar Cerda a la Lista"
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents aceptarButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CancelarButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents buscarTextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Codigo_Cerda As DataGridViewTextBoxColumn
    Friend WithEvents Lote_No As DataGridViewTextBoxColumn
    Friend WithEvents Estado_Actual As DataGridViewTextBoxColumn
    Friend WithEvents vacia As DataGridViewTextBoxColumn
End Class
