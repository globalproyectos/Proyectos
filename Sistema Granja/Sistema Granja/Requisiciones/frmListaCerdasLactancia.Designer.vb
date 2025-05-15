<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaCerdasLactancia
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaCerdasLactancia))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.existenciaMsjLabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.totalexcluidasLabel5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.totalcerdasLabel3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.totalcantidadLabel2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.infoLabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.aceptarButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.CancelarButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Codigo_Cerda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lote_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Excluir = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.Cantidad = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn()
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
        Me.PanelEx1.Controls.Add(Me.existenciaMsjLabelX1)
        Me.PanelEx1.Controls.Add(Me.totalexcluidasLabel5)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.totalcerdasLabel3)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.totalcantidadLabel2)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.LinkLabel1)
        Me.PanelEx1.Controls.Add(Me.DataGridViewX1)
        Me.PanelEx1.Controls.Add(Me.infoLabelX1)
        Me.PanelEx1.Controls.Add(Me.GroupBox1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(487, 470)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'existenciaMsjLabelX1
        '
        '
        '
        '
        Me.existenciaMsjLabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.existenciaMsjLabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.existenciaMsjLabelX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.existenciaMsjLabelX1.Location = New System.Drawing.Point(15, 36)
        Me.existenciaMsjLabelX1.Name = "existenciaMsjLabelX1"
        Me.existenciaMsjLabelX1.Size = New System.Drawing.Size(370, 23)
        Me.existenciaMsjLabelX1.TabIndex = 10
        '
        'totalexcluidasLabel5
        '
        Me.totalexcluidasLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.totalexcluidasLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalexcluidasLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalexcluidasLabel5.Location = New System.Drawing.Point(205, 386)
        Me.totalexcluidasLabel5.Name = "totalexcluidasLabel5"
        Me.totalexcluidasLabel5.Size = New System.Drawing.Size(41, 25)
        Me.totalexcluidasLabel5.TabIndex = 9
        Me.totalexcluidasLabel5.Text = "0.00"
        Me.totalexcluidasLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(139, 393)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Excluidas"
        '
        'totalcerdasLabel3
        '
        Me.totalcerdasLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.totalcerdasLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalcerdasLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalcerdasLabel3.Location = New System.Drawing.Point(92, 386)
        Me.totalcerdasLabel3.Name = "totalcerdasLabel3"
        Me.totalcerdasLabel3.Size = New System.Drawing.Size(41, 25)
        Me.totalcerdasLabel3.TabIndex = 7
        Me.totalcerdasLabel3.Text = "0.00"
        Me.totalcerdasLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 393)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Total Cerdas"
        '
        'totalcantidadLabel2
        '
        Me.totalcantidadLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.totalcantidadLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalcantidadLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalcantidadLabel2.Location = New System.Drawing.Point(356, 386)
        Me.totalcantidadLabel2.Name = "totalcantidadLabel2"
        Me.totalcantidadLabel2.Size = New System.Drawing.Size(119, 25)
        Me.totalcantidadLabel2.TabIndex = 5
        Me.totalcantidadLabel2.Text = "0.00"
        Me.totalcantidadLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(263, 393)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total Cantidad"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(391, 47)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(84, 13)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "&Añadir Resgistro"
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
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo_Cerda, Me.Lote_No, Me.Excluir, Me.Cantidad, Me.vacia})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(13, 63)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.Size = New System.Drawing.Size(462, 322)
        Me.DataGridViewX1.TabIndex = 2
        '
        'infoLabelX1
        '
        '
        '
        '
        Me.infoLabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.infoLabelX1.Location = New System.Drawing.Point(13, 13)
        Me.infoLabelX1.Name = "infoLabelX1"
        Me.infoLabelX1.Size = New System.Drawing.Size(462, 23)
        Me.infoLabelX1.TabIndex = 1
        Me.infoLabelX1.Text = "info"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.aceptarButtonX2)
        Me.GroupBox1.Controls.Add(Me.CancelarButtonX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 414)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 56)
        Me.GroupBox1.TabIndex = 0
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
        Me.aceptarButtonX2.Location = New System.Drawing.Point(284, 18)
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
        Me.CancelarButtonX1.Location = New System.Drawing.Point(381, 18)
        Me.CancelarButtonX1.Name = "CancelarButtonX1"
        Me.CancelarButtonX1.Size = New System.Drawing.Size(94, 30)
        Me.CancelarButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CancelarButtonX1.TabIndex = 0
        Me.CancelarButtonX1.Text = "&Cancelar"
        '
        'Codigo_Cerda
        '
        Me.Codigo_Cerda.DataPropertyName = "Codigo_Cerdo"
        Me.Codigo_Cerda.HeaderText = "Código de Cerda"
        Me.Codigo_Cerda.Name = "Codigo_Cerda"
        Me.Codigo_Cerda.ReadOnly = True
        '
        'Lote_No
        '
        Me.Lote_No.DataPropertyName = "Lote_No"
        Me.Lote_No.HeaderText = "Lote No."
        Me.Lote_No.Name = "Lote_No"
        Me.Lote_No.ReadOnly = True
        '
        'Excluir
        '
        Me.Excluir.Checked = True
        Me.Excluir.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.Excluir.CheckValue = Nothing
        Me.Excluir.DataPropertyName = "Excluir"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Excluir.DefaultCellStyle = DataGridViewCellStyle1
        Me.Excluir.HeaderText = "Excluida"
        Me.Excluir.Name = "Excluir"
        Me.Excluir.ReadOnly = True
        Me.Excluir.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Excluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Cantidad
        '
        '
        '
        '
        Me.Cantidad.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.Cantidad.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.Cantidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Cantidad.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText
        Me.Cantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Increment = 1.0R
        Me.Cantidad.Name = "Cantidad"
        '
        'vacia
        '
        Me.vacia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.vacia.HeaderText = ""
        Me.vacia.Name = "vacia"
        Me.vacia.ReadOnly = True
        '
        'frmListaCerdasLactancia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 470)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListaCerdasLactancia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Cerdas Lactancia"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents aceptarButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CancelarButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents infoLabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents totalcantidadLabel2 As Label
    Friend WithEvents totalcerdasLabel3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents totalexcluidasLabel5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents existenciaMsjLabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Codigo_Cerda As DataGridViewTextBoxColumn
    Friend WithEvents Lote_No As DataGridViewTextBoxColumn
    Friend WithEvents Excluir As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents Cantidad As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents vacia As DataGridViewTextBoxColumn
End Class
