<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresoTraslados
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngresoTraslados))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel7 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GuardarButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.NuevoButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.NavegacionGroupPanel6 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.panelnavTextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LastButtonX6 = New DevComponents.DotNetBar.ButtonX()
        Me.NextButtonX7 = New DevComponents.DotNetBar.ButtonX()
        Me.PreviousButtonX5 = New DevComponents.DotNetBar.ButtonX()
        Me.FirstButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel5 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.totalTextBoxX8 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.justificacionTextBoxX9 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.fechanaturalTextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.abodegaDescTextBoxX7 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.abodegaTextBoxX6 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.debodegaDescTextBoxX5 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.debodegaTextBoxX4 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.fechaTextBoxX3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.documentoTextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.trasladonoTextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.SuperValidator1 = New DevComponents.DotNetBar.Validator.SuperValidator()
        Me.RequiredFieldValidator4 = New DevComponents.DotNetBar.Validator.RequiredFieldValidator("debe ingresar la justificación")
        Me.RequiredFieldValidator3 = New DevComponents.DotNetBar.Validator.RequiredFieldValidator("debe ingresar la bodega")
        Me.RequiredFieldValidator2 = New DevComponents.DotNetBar.Validator.RequiredFieldValidator("No ha ingresado la bodega")
        Me.RequiredFieldValidator1 = New DevComponents.DotNetBar.Validator.RequiredFieldValidator("Debe ingresar el documento")
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel7.SuspendLayout()
        Me.NavegacionGroupPanel6.SuspendLayout()
        Me.GroupPanel5.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.GroupPanel7)
        Me.PanelEx1.Controls.Add(Me.NavegacionGroupPanel6)
        Me.PanelEx1.Controls.Add(Me.GroupPanel5)
        Me.PanelEx1.Controls.Add(Me.GroupPanel4)
        Me.PanelEx1.Controls.Add(Me.GroupPanel3)
        Me.PanelEx1.Controls.Add(Me.GroupPanel2)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(658, 427)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'GroupPanel7
        '
        Me.GroupPanel7.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel7.Controls.Add(Me.GuardarButtonX2)
        Me.GroupPanel7.Controls.Add(Me.NuevoButtonX4)
        Me.GroupPanel7.Controls.Add(Me.ButtonX1)
        Me.GroupPanel7.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel7.Location = New System.Drawing.Point(380, 1)
        Me.GroupPanel7.Name = "GroupPanel7"
        Me.GroupPanel7.Size = New System.Drawing.Size(272, 51)
        '
        '
        '
        Me.GroupPanel7.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel7.Style.BackColorGradientAngle = 90
        Me.GroupPanel7.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel7.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderBottomWidth = 1
        Me.GroupPanel7.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel7.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderLeftWidth = 1
        Me.GroupPanel7.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderRightWidth = 1
        Me.GroupPanel7.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel7.Style.BorderTopWidth = 1
        Me.GroupPanel7.Style.CornerDiameter = 4
        Me.GroupPanel7.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel7.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel7.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel7.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel7.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel7.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel7.TabIndex = 13
        Me.GroupPanel7.Text = "Opciones"
        '
        'GuardarButtonX2
        '
        Me.GuardarButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.GuardarButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.GuardarButtonX2.Enabled = False
        Me.GuardarButtonX2.Image = Global.Sistema_Granja.My.Resources.Resources.filesave
        Me.GuardarButtonX2.ImageFixedSize = New System.Drawing.Size(18, 18)
        Me.GuardarButtonX2.Location = New System.Drawing.Point(89, 1)
        Me.GuardarButtonX2.Name = "GuardarButtonX2"
        Me.GuardarButtonX2.Size = New System.Drawing.Size(88, 25)
        Me.GuardarButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.GuardarButtonX2.TabIndex = 11
        Me.GuardarButtonX2.Text = "&Guardar"
        '
        'NuevoButtonX4
        '
        Me.NuevoButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.NuevoButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.NuevoButtonX4.Image = Global.Sistema_Granja.My.Resources.Resources.tab_new_raised
        Me.NuevoButtonX4.ImageFixedSize = New System.Drawing.Size(18, 18)
        Me.NuevoButtonX4.Location = New System.Drawing.Point(6, 1)
        Me.NuevoButtonX4.Name = "NuevoButtonX4"
        Me.NuevoButtonX4.Size = New System.Drawing.Size(78, 25)
        Me.NuevoButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.NuevoButtonX4.TabIndex = 0
        Me.NuevoButtonX4.Text = "&Nuevo"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.FocusCuesEnabled = False
        Me.ButtonX1.Image = Global.Sistema_Granja.My.Resources.Resources.cerrar
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(18, 18)
        Me.ButtonX1.Location = New System.Drawing.Point(181, 1)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(81, 25)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 10
        Me.ButtonX1.Text = "&Salir"
        '
        'NavegacionGroupPanel6
        '
        Me.NavegacionGroupPanel6.CanvasColor = System.Drawing.SystemColors.Control
        Me.NavegacionGroupPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.NavegacionGroupPanel6.Controls.Add(Me.panelnavTextBoxX1)
        Me.NavegacionGroupPanel6.Controls.Add(Me.LastButtonX6)
        Me.NavegacionGroupPanel6.Controls.Add(Me.NextButtonX7)
        Me.NavegacionGroupPanel6.Controls.Add(Me.PreviousButtonX5)
        Me.NavegacionGroupPanel6.Controls.Add(Me.FirstButtonX3)
        Me.NavegacionGroupPanel6.DisabledBackColor = System.Drawing.Color.Empty
        Me.NavegacionGroupPanel6.Location = New System.Drawing.Point(12, 1)
        Me.NavegacionGroupPanel6.Name = "NavegacionGroupPanel6"
        Me.NavegacionGroupPanel6.Size = New System.Drawing.Size(362, 51)
        '
        '
        '
        Me.NavegacionGroupPanel6.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.NavegacionGroupPanel6.Style.BackColorGradientAngle = 90
        Me.NavegacionGroupPanel6.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.NavegacionGroupPanel6.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.NavegacionGroupPanel6.Style.BorderBottomWidth = 1
        Me.NavegacionGroupPanel6.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.NavegacionGroupPanel6.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.NavegacionGroupPanel6.Style.BorderLeftWidth = 1
        Me.NavegacionGroupPanel6.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.NavegacionGroupPanel6.Style.BorderRightWidth = 1
        Me.NavegacionGroupPanel6.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.NavegacionGroupPanel6.Style.BorderTopWidth = 1
        Me.NavegacionGroupPanel6.Style.CornerDiameter = 4
        Me.NavegacionGroupPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.NavegacionGroupPanel6.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.NavegacionGroupPanel6.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.NavegacionGroupPanel6.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.NavegacionGroupPanel6.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.NavegacionGroupPanel6.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NavegacionGroupPanel6.TabIndex = 12
        Me.NavegacionGroupPanel6.Text = "Navegación"
        '
        'panelnavTextBoxX1
        '
        '
        '
        '
        Me.panelnavTextBoxX1.Border.Class = "TextBoxBorder"
        Me.panelnavTextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.panelnavTextBoxX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelnavTextBoxX1.ForeColor = System.Drawing.Color.Green
        Me.panelnavTextBoxX1.Location = New System.Drawing.Point(132, 3)
        Me.panelnavTextBoxX1.Name = "panelnavTextBoxX1"
        Me.panelnavTextBoxX1.Size = New System.Drawing.Size(94, 24)
        Me.panelnavTextBoxX1.TabIndex = 4
        Me.panelnavTextBoxX1.Text = "0 de 0"
        Me.panelnavTextBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LastButtonX6
        '
        Me.LastButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.LastButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.LastButtonX6.Image = Global.Sistema_Granja.My.Resources.Resources.BindingNavigatorMoveLastItem_Image
        Me.LastButtonX6.Location = New System.Drawing.Point(290, 2)
        Me.LastButtonX6.Name = "LastButtonX6"
        Me.LastButtonX6.Size = New System.Drawing.Size(55, 25)
        Me.LastButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LastButtonX6.TabIndex = 3
        '
        'NextButtonX7
        '
        Me.NextButtonX7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.NextButtonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.NextButtonX7.Image = Global.Sistema_Granja.My.Resources.Resources.BindingNavigatorMoveNextItem_Image
        Me.NextButtonX7.Location = New System.Drawing.Point(231, 2)
        Me.NextButtonX7.Name = "NextButtonX7"
        Me.NextButtonX7.Size = New System.Drawing.Size(55, 25)
        Me.NextButtonX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.NextButtonX7.TabIndex = 2
        '
        'PreviousButtonX5
        '
        Me.PreviousButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.PreviousButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.PreviousButtonX5.Image = Global.Sistema_Granja.My.Resources.Resources.BindingNavigatorMovePreviousItem_Image
        Me.PreviousButtonX5.Location = New System.Drawing.Point(70, 2)
        Me.PreviousButtonX5.Name = "PreviousButtonX5"
        Me.PreviousButtonX5.Size = New System.Drawing.Size(55, 25)
        Me.PreviousButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PreviousButtonX5.TabIndex = 1
        '
        'FirstButtonX3
        '
        Me.FirstButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.FirstButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.FirstButtonX3.Image = Global.Sistema_Granja.My.Resources.Resources.BindingNavigatorMoveFirstItem_Image
        Me.FirstButtonX3.Location = New System.Drawing.Point(11, 2)
        Me.FirstButtonX3.Name = "FirstButtonX3"
        Me.FirstButtonX3.Size = New System.Drawing.Size(55, 25)
        Me.FirstButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.FirstButtonX3.TabIndex = 0
        '
        'GroupPanel5
        '
        Me.GroupPanel5.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel5.Controls.Add(Me.totalTextBoxX8)
        Me.GroupPanel5.Controls.Add(Me.LabelX6)
        Me.GroupPanel5.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel5.Location = New System.Drawing.Point(512, 349)
        Me.GroupPanel5.Name = "GroupPanel5"
        Me.GroupPanel5.Size = New System.Drawing.Size(140, 73)
        '
        '
        '
        Me.GroupPanel5.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel5.Style.BackColorGradientAngle = 90
        Me.GroupPanel5.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel5.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderBottomWidth = 1
        Me.GroupPanel5.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel5.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderLeftWidth = 1
        Me.GroupPanel5.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderRightWidth = 1
        Me.GroupPanel5.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderTopWidth = 1
        Me.GroupPanel5.Style.CornerDiameter = 4
        Me.GroupPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel5.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel5.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel5.TabIndex = 4
        '
        'totalTextBoxX8
        '
        '
        '
        '
        Me.totalTextBoxX8.Border.Class = "TextBoxBorder"
        Me.totalTextBoxX8.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.totalTextBoxX8.Enabled = False
        Me.totalTextBoxX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalTextBoxX8.Location = New System.Drawing.Point(6, 24)
        Me.totalTextBoxX8.Name = "totalTextBoxX8"
        Me.totalTextBoxX8.Size = New System.Drawing.Size(124, 39)
        Me.totalTextBoxX8.TabIndex = 4
        Me.totalTextBoxX8.Text = "0.00"
        Me.totalTextBoxX8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(6, 2)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(75, 23)
        Me.LabelX6.TabIndex = 1
        Me.LabelX6.Text = "TOTAL:"
        '
        'GroupPanel4
        '
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.LabelX9)
        Me.GroupPanel4.Controls.Add(Me.justificacionTextBoxX9)
        Me.GroupPanel4.Controls.Add(Me.LabelX7)
        Me.GroupPanel4.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel4.Enabled = False
        Me.GroupPanel4.Location = New System.Drawing.Point(12, 350)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(494, 72)
        '
        '
        '
        Me.GroupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel4.Style.BackColorGradientAngle = 90
        Me.GroupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderBottomWidth = 1
        Me.GroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderLeftWidth = 1
        Me.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderRightWidth = 1
        Me.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderTopWidth = 1
        Me.GroupPanel4.Style.CornerDiameter = 4
        Me.GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel4.TabIndex = 2
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(12, 33)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(32, 23)
        Me.LabelX9.TabIndex = 2
        Me.LabelX9.Text = "0"
        Me.LabelX9.Visible = False
        '
        'justificacionTextBoxX9
        '
        '
        '
        '
        Me.justificacionTextBoxX9.Border.Class = "TextBoxBorder"
        Me.justificacionTextBoxX9.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.justificacionTextBoxX9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.justificacionTextBoxX9.Location = New System.Drawing.Point(72, 6)
        Me.justificacionTextBoxX9.MaxLength = 100
        Me.justificacionTextBoxX9.Multiline = True
        Me.justificacionTextBoxX9.Name = "justificacionTextBoxX9"
        Me.justificacionTextBoxX9.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.justificacionTextBoxX9.Size = New System.Drawing.Size(402, 56)
        Me.justificacionTextBoxX9.TabIndex = 0
        Me.SuperValidator1.SetValidator1(Me.justificacionTextBoxX9, Me.RequiredFieldValidator4)
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(3, 3)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(75, 23)
        Me.LabelX7.TabIndex = 1
        Me.LabelX7.Text = "Justificación:"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.DataGridViewX1)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Location = New System.Drawing.Point(12, 149)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(640, 194)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 3
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewX1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewX1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.DataGridViewX1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.codigo, Me.descripcion, Me.unitario, Me.cantidad, Me.importe})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX1.Enabled = False
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.RowHeadersWidth = 5
        Me.DataGridViewX1.Size = New System.Drawing.Size(634, 188)
        Me.DataGridViewX1.TabIndex = 0
        '
        'no
        '
        Me.no.DataPropertyName = "item"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.no.DefaultCellStyle = DataGridViewCellStyle2
        Me.no.HeaderText = "Item #"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 60
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.codigo.DefaultCellStyle = DataGridViewCellStyle3
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.Width = 80
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 230
        '
        'unitario
        '
        Me.unitario.DataPropertyName = "unitario"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.unitario.DefaultCellStyle = DataGridViewCellStyle4
        Me.unitario.HeaderText = "Costo Unitario"
        Me.unitario.Name = "unitario"
        Me.unitario.ReadOnly = True
        Me.unitario.Width = 80
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "cantidad"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.cantidad.DefaultCellStyle = DataGridViewCellStyle5
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Width = 80
        '
        'importe
        '
        Me.importe.DataPropertyName = "importe"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0.00"
        Me.importe.DefaultCellStyle = DataGridViewCellStyle6
        Me.importe.HeaderText = "Importe"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        Me.importe.Width = 80
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.fechanaturalTextBoxX1)
        Me.GroupPanel2.Controls.Add(Me.LabelX8)
        Me.GroupPanel2.Controls.Add(Me.abodegaDescTextBoxX7)
        Me.GroupPanel2.Controls.Add(Me.abodegaTextBoxX6)
        Me.GroupPanel2.Controls.Add(Me.debodegaDescTextBoxX5)
        Me.GroupPanel2.Controls.Add(Me.debodegaTextBoxX4)
        Me.GroupPanel2.Controls.Add(Me.LabelX5)
        Me.GroupPanel2.Controls.Add(Me.LabelX4)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Enabled = False
        Me.GroupPanel2.Location = New System.Drawing.Point(253, 54)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(399, 89)
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
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 1
        '
        'fechanaturalTextBoxX1
        '
        '
        '
        '
        Me.fechanaturalTextBoxX1.Border.Class = "TextBoxBorder"
        Me.fechanaturalTextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechanaturalTextBoxX1.Enabled = False
        Me.fechanaturalTextBoxX1.Location = New System.Drawing.Point(68, 56)
        Me.fechanaturalTextBoxX1.Name = "fechanaturalTextBoxX1"
        Me.fechanaturalTextBoxX1.Size = New System.Drawing.Size(121, 20)
        Me.fechanaturalTextBoxX1.TabIndex = 13
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(3, 55)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(59, 23)
        Me.LabelX8.TabIndex = 12
        Me.LabelX8.Text = "F. Natural:"
        '
        'abodegaDescTextBoxX7
        '
        '
        '
        '
        Me.abodegaDescTextBoxX7.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.abodegaDescTextBoxX7.Border.Class = "TextBoxBorder"
        Me.abodegaDescTextBoxX7.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.abodegaDescTextBoxX7.Enabled = False
        Me.abodegaDescTextBoxX7.Location = New System.Drawing.Point(124, 30)
        Me.abodegaDescTextBoxX7.Name = "abodegaDescTextBoxX7"
        Me.abodegaDescTextBoxX7.Size = New System.Drawing.Size(266, 20)
        Me.abodegaDescTextBoxX7.TabIndex = 9
        '
        'abodegaTextBoxX6
        '
        '
        '
        '
        Me.abodegaTextBoxX6.Border.Class = "TextBoxBorder"
        Me.abodegaTextBoxX6.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.abodegaTextBoxX6.Location = New System.Drawing.Point(68, 29)
        Me.abodegaTextBoxX6.MaxLength = 4
        Me.abodegaTextBoxX6.Name = "abodegaTextBoxX6"
        Me.abodegaTextBoxX6.Size = New System.Drawing.Size(53, 20)
        Me.abodegaTextBoxX6.TabIndex = 1
        Me.SuperValidator1.SetValidator1(Me.abodegaTextBoxX6, Me.RequiredFieldValidator3)
        '
        'debodegaDescTextBoxX5
        '
        '
        '
        '
        Me.debodegaDescTextBoxX5.Border.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.debodegaDescTextBoxX5.Border.BorderColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.debodegaDescTextBoxX5.Border.Class = "TextBoxBorder"
        Me.debodegaDescTextBoxX5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.debodegaDescTextBoxX5.Enabled = False
        Me.debodegaDescTextBoxX5.Location = New System.Drawing.Point(124, 3)
        Me.debodegaDescTextBoxX5.Name = "debodegaDescTextBoxX5"
        Me.debodegaDescTextBoxX5.Size = New System.Drawing.Size(266, 20)
        Me.debodegaDescTextBoxX5.TabIndex = 7
        '
        'debodegaTextBoxX4
        '
        '
        '
        '
        Me.debodegaTextBoxX4.Border.Class = "TextBoxBorder"
        Me.debodegaTextBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.debodegaTextBoxX4.Location = New System.Drawing.Point(68, 3)
        Me.debodegaTextBoxX4.MaxLength = 4
        Me.debodegaTextBoxX4.Name = "debodegaTextBoxX4"
        Me.debodegaTextBoxX4.Size = New System.Drawing.Size(53, 20)
        Me.debodegaTextBoxX4.TabIndex = 0
        Me.SuperValidator1.SetValidator1(Me.debodegaTextBoxX4, Me.RequiredFieldValidator2)
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(3, 29)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(75, 23)
        Me.LabelX5.TabIndex = 2
        Me.LabelX5.Text = "A Bodega:"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(3, 1)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.TabIndex = 1
        Me.LabelX4.Text = "De Bodega:"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.fechaTextBoxX3)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.documentoTextBoxX2)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.trasladonoTextBoxX1)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Enabled = False
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 54)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(235, 89)
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
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 0
        '
        'fechaTextBoxX3
        '
        '
        '
        '
        Me.fechaTextBoxX3.Border.Class = "TextBoxBorder"
        Me.fechaTextBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaTextBoxX3.Enabled = False
        Me.fechaTextBoxX3.Location = New System.Drawing.Point(101, 55)
        Me.fechaTextBoxX3.Name = "fechaTextBoxX3"
        Me.fechaTextBoxX3.Size = New System.Drawing.Size(112, 20)
        Me.fechaTextBoxX3.TabIndex = 5
        Me.fechaTextBoxX3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(12, 53)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 4
        Me.LabelX3.Text = "Fecha:"
        '
        'documentoTextBoxX2
        '
        '
        '
        '
        Me.documentoTextBoxX2.Border.Class = "TextBoxBorder"
        Me.documentoTextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.documentoTextBoxX2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.documentoTextBoxX2.Location = New System.Drawing.Point(101, 29)
        Me.documentoTextBoxX2.MaxLength = 12
        Me.documentoTextBoxX2.Name = "documentoTextBoxX2"
        Me.documentoTextBoxX2.Size = New System.Drawing.Size(112, 20)
        Me.documentoTextBoxX2.TabIndex = 0
        Me.documentoTextBoxX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SuperValidator1.SetValidator1(Me.documentoTextBoxX2, Me.RequiredFieldValidator1)
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(12, 27)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "Documento:"
        '
        'trasladonoTextBoxX1
        '
        '
        '
        '
        Me.trasladonoTextBoxX1.Border.Class = "TextBoxBorder"
        Me.trasladonoTextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.trasladonoTextBoxX1.Enabled = False
        Me.trasladonoTextBoxX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trasladonoTextBoxX1.Location = New System.Drawing.Point(101, 3)
        Me.trasladonoTextBoxX1.Name = "trasladonoTextBoxX1"
        Me.trasladonoTextBoxX1.ReadOnly = True
        Me.trasladonoTextBoxX1.Size = New System.Drawing.Size(112, 20)
        Me.trasladonoTextBoxX1.TabIndex = 1
        Me.trasladonoTextBoxX1.Text = "00000000"
        Me.trasladonoTextBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Traslado No:"
        '
        'SuperValidator1
        '
        Me.SuperValidator1.CancelValidatingOnControl = False
        Me.SuperValidator1.ContainerControl = Me
        Me.SuperValidator1.Enabled = False
        Me.SuperValidator1.ErrorProvider = Me.ErrorProvider1
        Me.SuperValidator1.Highlighter = Me.Highlighter1
        Me.SuperValidator1.SteppedValidation = True
        Me.SuperValidator1.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl
        '
        'RequiredFieldValidator4
        '
        Me.RequiredFieldValidator4.ErrorMessage = "debe ingresar la justificación"
        Me.RequiredFieldValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'RequiredFieldValidator3
        '
        Me.RequiredFieldValidator3.ErrorMessage = "debe ingresar la bodega"
        Me.RequiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'RequiredFieldValidator2
        '
        Me.RequiredFieldValidator2.ErrorMessage = "No ha ingresado la bodega"
        Me.RequiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'RequiredFieldValidator1
        '
        Me.RequiredFieldValidator1.ErrorMessage = "Debe ingresar el documento"
        Me.RequiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'frmIngresoTraslados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 427)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmIngresoTraslados"
        Me.Text = "Ingreso Traslados"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel7.ResumeLayout(False)
        Me.NavegacionGroupPanel6.ResumeLayout(False)
        Me.GroupPanel5.ResumeLayout(False)
        Me.GroupPanel4.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents fechaTextBoxX3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents documentoTextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents trasladonoTextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents abodegaDescTextBoxX7 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents abodegaTextBoxX6 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents debodegaDescTextBoxX5 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents debodegaTextBoxX4 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupPanel5 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents totalTextBoxX8 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents justificacionTextBoxX9 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents fechanaturalTextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SuperValidator1 As DevComponents.DotNetBar.Validator.SuperValidator
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents RequiredFieldValidator4 As DevComponents.DotNetBar.Validator.RequiredFieldValidator
    Friend WithEvents RequiredFieldValidator3 As DevComponents.DotNetBar.Validator.RequiredFieldValidator
    Friend WithEvents RequiredFieldValidator2 As DevComponents.DotNetBar.Validator.RequiredFieldValidator
    Friend WithEvents RequiredFieldValidator1 As DevComponents.DotNetBar.Validator.RequiredFieldValidator
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NavegacionGroupPanel6 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents FirstButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel7 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents NuevoButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents panelnavTextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LastButtonX6 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents NextButtonX7 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PreviousButtonX5 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GuardarButtonX2 As DevComponents.DotNetBar.ButtonX
End Class
