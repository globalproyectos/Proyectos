<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTableroInformativo
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim LineAnnotation1 As System.Windows.Forms.DataVisualization.Charting.LineAnnotation = New System.Windows.Forms.DataVisualization.Charting.LineAnnotation()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim LineAnnotation2 As System.Windows.Forms.DataVisualization.Charting.LineAnnotation = New System.Windows.Forms.DataVisualization.Charting.LineAnnotation()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim LineAnnotation3 As System.Windows.Forms.DataVisualization.Charting.LineAnnotation = New System.Windows.Forms.DataVisualization.Charting.LineAnnotation()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim LineAnnotation4 As System.Windows.Forms.DataVisualization.Charting.LineAnnotation = New System.Windows.Forms.DataVisualization.Charting.LineAnnotation()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series11 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTableroInformativo))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.movimientosLoteChart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelNacVivosEngordes = New System.Windows.Forms.Panel()
        Me.nacidosVivosChart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelDefuncioneEngordes = New System.Windows.Forms.Panel()
        Me.defuncionesChart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelDestetadosEngordes = New System.Windows.Forms.Panel()
        Me.tresAñosChart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tomarColorLabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.tomarColorPanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelCerdasPorEtapa = New System.Windows.Forms.Panel()
        Me.etapasCerdasChart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Etapas_CerdasTableAdapter = New Sistema_Granja.dtsTableroInformativoTableAdapters.Etapas_CerdasTableAdapter()
        Me.EtapasCerdasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsTableroInformativo = New Sistema_Granja.dtsTableroInformativo()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.Panel2.SuspendLayout()
        CType(Me.movimientosLoteChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.PanelNacVivosEngordes.SuspendLayout()
        CType(Me.nacidosVivosChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        Me.PanelDefuncioneEngordes.SuspendLayout()
        CType(Me.defuncionesChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.PanelDestetadosEngordes.SuspendLayout()
        CType(Me.tresAñosChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.PanelCerdasPorEtapa.SuspendLayout()
        CType(Me.etapasCerdasChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.EtapasCerdasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsTableroInformativo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.movimientosLoteChart1)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1303, 275)
        Me.Panel2.TabIndex = 0
        '
        'movimientosLoteChart1
        '
        LineAnnotation1.Name = "LineAnnotation1"
        Me.movimientosLoteChart1.Annotations.Add(LineAnnotation1)
        Me.movimientosLoteChart1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.Title = "Año/Mes"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.Title = "# Cerdos"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BackSecondaryColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.movimientosLoteChart1.ChartAreas.Add(ChartArea1)
        Me.movimientosLoteChart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.Name = "Legend1"
        Me.movimientosLoteChart1.Legends.Add(Legend1)
        Me.movimientosLoteChart1.Location = New System.Drawing.Point(0, 31)
        Me.movimientosLoteChart1.Name = "movimientosLoteChart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Series1.IsValueShownAsLabel = True
        Series1.LabelBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Series1.LabelForeColor = System.Drawing.Color.White
        Series1.Legend = "Legend1"
        Series1.Name = "NacidosVivos"
        Series1.YValuesPerPoint = 6
        Series2.ChartArea = "ChartArea1"
        Series2.Color = System.Drawing.Color.Red
        Series2.IsValueShownAsLabel = True
        Series2.LabelBackColor = System.Drawing.Color.Red
        Series2.LabelForeColor = System.Drawing.Color.White
        Series2.Legend = "Legend1"
        Series2.Name = "NacidosMuertos"
        Series2.YValuesPerPoint = 6
        Series3.ChartArea = "ChartArea1"
        Series3.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Series3.IsValueShownAsLabel = True
        Series3.LabelBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Series3.LabelForeColor = System.Drawing.Color.White
        Series3.Legend = "Legend1"
        Series3.Name = "Momias"
        Series3.YValuesPerPoint = 6
        Series4.ChartArea = "ChartArea1"
        Series4.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Series4.IsValueShownAsLabel = True
        Series4.LabelBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Series4.LabelForeColor = System.Drawing.Color.White
        Series4.Legend = "Legend1"
        Series4.Name = "MuertosGestacion"
        Series4.YValuesPerPoint = 6
        Series5.ChartArea = "ChartArea1"
        Series5.Color = System.Drawing.Color.Teal
        Series5.IsValueShownAsLabel = True
        Series5.LabelBackColor = System.Drawing.Color.Teal
        Series5.LabelForeColor = System.Drawing.Color.White
        Series5.Legend = "Legend1"
        Series5.Name = "Donados"
        Series5.YValuesPerPoint = 6
        Series6.ChartArea = "ChartArea1"
        Series6.Color = System.Drawing.Color.Navy
        Series6.IsValueShownAsLabel = True
        Series6.LabelBackColor = System.Drawing.Color.Navy
        Series6.LabelForeColor = System.Drawing.Color.White
        Series6.Legend = "Legend1"
        Series6.Name = "Adoptados"
        Series6.YValuesPerPoint = 6
        Series7.ChartArea = "ChartArea1"
        Series7.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Series7.IsValueShownAsLabel = True
        Series7.LabelBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Series7.LabelForeColor = System.Drawing.Color.White
        Series7.Legend = "Legend1"
        Series7.Name = "Destetados"
        Series7.YValuesPerPoint = 6
        Me.movimientosLoteChart1.Series.Add(Series1)
        Me.movimientosLoteChart1.Series.Add(Series2)
        Me.movimientosLoteChart1.Series.Add(Series3)
        Me.movimientosLoteChart1.Series.Add(Series4)
        Me.movimientosLoteChart1.Series.Add(Series5)
        Me.movimientosLoteChart1.Series.Add(Series6)
        Me.movimientosLoteChart1.Series.Add(Series7)
        Me.movimientosLoteChart1.Size = New System.Drawing.Size(1303, 244)
        Me.movimientosLoteChart1.TabIndex = 0
        Me.movimientosLoteChart1.Text = "Chart1"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Controls.Add(Me.ButtonX1)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1303, 31)
        Me.Panel5.TabIndex = 1
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX1.Location = New System.Drawing.Point(4, 4)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(135, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 1
        Me.ButtonX1.Text = "Actualizar Datos"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1303, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MOVIMIENTOS LOTES ENGORDES ULTIMO 6 MESES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelNacVivosEngordes
        '
        Me.PanelNacVivosEngordes.Controls.Add(Me.nacidosVivosChart1)
        Me.PanelNacVivosEngordes.Controls.Add(Me.Panel12)
        Me.PanelNacVivosEngordes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelNacVivosEngordes.Location = New System.Drawing.Point(0, 0)
        Me.PanelNacVivosEngordes.Name = "PanelNacVivosEngordes"
        Me.PanelNacVivosEngordes.Size = New System.Drawing.Size(335, 272)
        Me.PanelNacVivosEngordes.TabIndex = 4
        '
        'nacidosVivosChart1
        '
        LineAnnotation2.Name = "LineAnnotation1"
        Me.nacidosVivosChart1.Annotations.Add(LineAnnotation2)
        Me.nacidosVivosChart1.BackColor = System.Drawing.Color.Transparent
        ChartArea2.AxisX.Title = "Año"
        ChartArea2.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisY.Title = "# Cerdos"
        ChartArea2.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.BackColor = System.Drawing.Color.Transparent
        ChartArea2.BackSecondaryColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea1"
        Me.nacidosVivosChart1.ChartAreas.Add(ChartArea2)
        Me.nacidosVivosChart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.BackColor = System.Drawing.Color.Transparent
        Legend2.Name = "Legend1"
        Me.nacidosVivosChart1.Legends.Add(Legend2)
        Me.nacidosVivosChart1.Location = New System.Drawing.Point(0, 31)
        Me.nacidosVivosChart1.Name = "nacidosVivosChart1"
        Me.nacidosVivosChart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series8.Color = System.Drawing.Color.DodgerBlue
        Series8.IsValueShownAsLabel = True
        Series8.LabelBackColor = System.Drawing.Color.DodgerBlue
        Series8.LabelForeColor = System.Drawing.Color.White
        Series8.Legend = "Legend1"
        Series8.Name = "NacidosVivos"
        Series8.YValuesPerPoint = 6
        Me.nacidosVivosChart1.Series.Add(Series8)
        Me.nacidosVivosChart1.Size = New System.Drawing.Size(335, 241)
        Me.nacidosVivosChart1.TabIndex = 5
        Me.nacidosVivosChart1.Text = "Chart1"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel12.Controls.Add(Me.Label5)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(335, 31)
        Me.Panel12.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(317, 31)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "COMPARATIVO 3 AÑOS NAC. VIVOS ENGORDES"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelDefuncioneEngordes
        '
        Me.PanelDefuncioneEngordes.Controls.Add(Me.defuncionesChart1)
        Me.PanelDefuncioneEngordes.Controls.Add(Me.Panel10)
        Me.PanelDefuncioneEngordes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDefuncioneEngordes.Location = New System.Drawing.Point(0, 0)
        Me.PanelDefuncioneEngordes.Name = "PanelDefuncioneEngordes"
        Me.PanelDefuncioneEngordes.Size = New System.Drawing.Size(326, 272)
        Me.PanelDefuncioneEngordes.TabIndex = 3
        '
        'defuncionesChart1
        '
        LineAnnotation3.Name = "LineAnnotation1"
        Me.defuncionesChart1.Annotations.Add(LineAnnotation3)
        Me.defuncionesChart1.BackColor = System.Drawing.Color.Transparent
        ChartArea3.AxisX.Title = "Año"
        ChartArea3.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea3.AxisY.Title = "# Cerdos"
        ChartArea3.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea3.BackColor = System.Drawing.Color.Transparent
        ChartArea3.BackSecondaryColor = System.Drawing.Color.Transparent
        ChartArea3.Name = "ChartArea1"
        Me.defuncionesChart1.ChartAreas.Add(ChartArea3)
        Me.defuncionesChart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend3.BackColor = System.Drawing.Color.Transparent
        Legend3.Name = "Legend1"
        Me.defuncionesChart1.Legends.Add(Legend3)
        Me.defuncionesChart1.Location = New System.Drawing.Point(0, 31)
        Me.defuncionesChart1.Name = "defuncionesChart1"
        Me.defuncionesChart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Series9.ChartArea = "ChartArea1"
        Series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series9.Color = System.Drawing.Color.Red
        Series9.IsValueShownAsLabel = True
        Series9.LabelBackColor = System.Drawing.Color.Red
        Series9.LabelForeColor = System.Drawing.Color.White
        Series9.Legend = "Legend1"
        Series9.Name = "Defunciones"
        Series9.YValuesPerPoint = 6
        Me.defuncionesChart1.Series.Add(Series9)
        Me.defuncionesChart1.Size = New System.Drawing.Size(326, 241)
        Me.defuncionesChart1.TabIndex = 5
        Me.defuncionesChart1.Text = "Chart1"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel10.Controls.Add(Me.Label4)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(326, 31)
        Me.Panel10.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(326, 31)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "COMPARATIVO 3 AÑOS DEFUNCIONES ENGORDES"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelDestetadosEngordes
        '
        Me.PanelDestetadosEngordes.Controls.Add(Me.tresAñosChart1)
        Me.PanelDestetadosEngordes.Controls.Add(Me.Panel6)
        Me.PanelDestetadosEngordes.Controls.Add(Me.tomarColorLabelX1)
        Me.PanelDestetadosEngordes.Controls.Add(Me.tomarColorPanelEx1)
        Me.PanelDestetadosEngordes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDestetadosEngordes.Location = New System.Drawing.Point(0, 0)
        Me.PanelDestetadosEngordes.Name = "PanelDestetadosEngordes"
        Me.PanelDestetadosEngordes.Size = New System.Drawing.Size(330, 272)
        Me.PanelDestetadosEngordes.TabIndex = 2
        '
        'tresAñosChart1
        '
        LineAnnotation4.Name = "LineAnnotation1"
        Me.tresAñosChart1.Annotations.Add(LineAnnotation4)
        Me.tresAñosChart1.BackColor = System.Drawing.Color.Transparent
        ChartArea4.AxisX.Title = "Año"
        ChartArea4.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea4.AxisY.Title = "# Cerdos"
        ChartArea4.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea4.BackColor = System.Drawing.Color.Transparent
        ChartArea4.BackSecondaryColor = System.Drawing.Color.Transparent
        ChartArea4.Name = "ChartArea1"
        Me.tresAñosChart1.ChartAreas.Add(ChartArea4)
        Me.tresAñosChart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend4.BackColor = System.Drawing.Color.Transparent
        Legend4.Name = "Legend1"
        Me.tresAñosChart1.Legends.Add(Legend4)
        Me.tresAñosChart1.Location = New System.Drawing.Point(0, 31)
        Me.tresAñosChart1.Name = "tresAñosChart1"
        Me.tresAñosChart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series10.ChartArea = "ChartArea1"
        Series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series10.Color = System.Drawing.Color.Green
        Series10.IsValueShownAsLabel = True
        Series10.LabelBackColor = System.Drawing.Color.Green
        Series10.LabelForeColor = System.Drawing.Color.White
        Series10.Legend = "Legend1"
        Series10.Name = "Destetados"
        Series10.YValuesPerPoint = 6
        Me.tresAñosChart1.Series.Add(Series10)
        Me.tresAñosChart1.Size = New System.Drawing.Size(330, 241)
        Me.tresAñosChart1.TabIndex = 5
        Me.tresAñosChart1.Text = "Chart1"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(330, 31)
        Me.Panel6.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(330, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "COMPARATIVO 3 AÑOS DESTETADOS ENGORDES"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tomarColorLabelX1
        '
        '
        '
        '
        Me.tomarColorLabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tomarColorLabelX1.Location = New System.Drawing.Point(63, 63)
        Me.tomarColorLabelX1.Name = "tomarColorLabelX1"
        Me.tomarColorLabelX1.Size = New System.Drawing.Size(75, 23)
        Me.tomarColorLabelX1.TabIndex = 1
        Me.tomarColorLabelX1.Text = "LabelX1"
        Me.tomarColorLabelX1.Visible = False
        '
        'tomarColorPanelEx1
        '
        Me.tomarColorPanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.tomarColorPanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.tomarColorPanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.tomarColorPanelEx1.Location = New System.Drawing.Point(63, 31)
        Me.tomarColorPanelEx1.Name = "tomarColorPanelEx1"
        Me.tomarColorPanelEx1.Size = New System.Drawing.Size(60, 25)
        Me.tomarColorPanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.tomarColorPanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.tomarColorPanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.tomarColorPanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.tomarColorPanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.tomarColorPanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.tomarColorPanelEx1.Style.GradientAngle = 90
        Me.tomarColorPanelEx1.TabIndex = 0
        Me.tomarColorPanelEx1.Text = "PanelEx1"
        Me.tomarColorPanelEx1.Visible = False
        '
        'PanelCerdasPorEtapa
        '
        Me.PanelCerdasPorEtapa.Controls.Add(Me.etapasCerdasChart1)
        Me.PanelCerdasPorEtapa.Controls.Add(Me.Panel9)
        Me.PanelCerdasPorEtapa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCerdasPorEtapa.Location = New System.Drawing.Point(0, 0)
        Me.PanelCerdasPorEtapa.Name = "PanelCerdasPorEtapa"
        Me.PanelCerdasPorEtapa.Size = New System.Drawing.Size(300, 272)
        Me.PanelCerdasPorEtapa.TabIndex = 0
        '
        'etapasCerdasChart1
        '
        Me.etapasCerdasChart1.BackColor = System.Drawing.Color.Transparent
        ChartArea5.BackColor = System.Drawing.Color.Transparent
        ChartArea5.Name = "ChartArea1"
        Me.etapasCerdasChart1.ChartAreas.Add(ChartArea5)
        Me.etapasCerdasChart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend5.BackColor = System.Drawing.Color.Transparent
        Legend5.Name = "Legend1"
        Legend5.Title = "ETAPAS"
        Me.etapasCerdasChart1.Legends.Add(Legend5)
        Me.etapasCerdasChart1.Location = New System.Drawing.Point(0, 31)
        Me.etapasCerdasChart1.Name = "etapasCerdasChart1"
        Series11.ChartArea = "ChartArea1"
        Series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series11.CustomProperties = "CollectedSliceExploded=True"
        Series11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series11.IsValueShownAsLabel = True
        Series11.LabelForeColor = System.Drawing.Color.White
        Series11.Legend = "Legend1"
        Series11.Name = "Series1"
        Me.etapasCerdasChart1.Series.Add(Series11)
        Me.etapasCerdasChart1.Size = New System.Drawing.Size(300, 241)
        Me.etapasCerdasChart1.TabIndex = 4
        Me.etapasCerdasChart1.Text = "Chart1"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel9.Controls.Add(Me.Label3)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(300, 31)
        Me.Panel9.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(300, 31)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "CERDAS POR ETAPA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Etapas_CerdasTableAdapter
        '
        Me.Etapas_CerdasTableAdapter.ClearBeforeFill = True
        '
        'EtapasCerdasBindingSource
        '
        Me.EtapasCerdasBindingSource.DataMember = "Etapas_Cerdas"
        Me.EtapasCerdasBindingSource.DataSource = Me.DtsTableroInformativo
        '
        'DtsTableroInformativo
        '
        Me.DtsTableroInformativo.DataSetName = "dtsTableroInformativo"
        Me.DtsTableroInformativo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PanelCerdasPorEtapa)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1303, 272)
        Me.SplitContainer1.SplitterDistance = 300
        Me.SplitContainer1.TabIndex = 2
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.PanelDefuncioneEngordes)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(999, 272)
        Me.SplitContainer2.SplitterDistance = 326
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.PanelNacVivosEngordes)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.PanelDestetadosEngordes)
        Me.SplitContainer3.Size = New System.Drawing.Size(669, 272)
        Me.SplitContainer3.SplitterDistance = 335
        Me.SplitContainer3.TabIndex = 0
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer4.Size = New System.Drawing.Size(1303, 551)
        Me.SplitContainer4.SplitterDistance = 275
        Me.SplitContainer4.TabIndex = 3
        '
        'frmTableroInformativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1303, 551)
        Me.Controls.Add(Me.SplitContainer4)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTableroInformativo"
        Me.Text = "Tablero de Información"
        Me.Panel2.ResumeLayout(False)
        CType(Me.movimientosLoteChart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.PanelNacVivosEngordes.ResumeLayout(False)
        CType(Me.nacidosVivosChart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.PanelDefuncioneEngordes.ResumeLayout(False)
        CType(Me.defuncionesChart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.PanelDestetadosEngordes.ResumeLayout(False)
        CType(Me.tresAñosChart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.PanelCerdasPorEtapa.ResumeLayout(False)
        CType(Me.etapasCerdasChart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        CType(Me.EtapasCerdasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsTableroInformativo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Etapas_CerdasTableAdapter As dtsTableroInformativoTableAdapters.Etapas_CerdasTableAdapter
    Friend WithEvents DtsTableroInformativo As dtsTableroInformativo
    Friend WithEvents EtapasCerdasBindingSource As BindingSource
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents movimientosLoteChart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelDestetadosEngordes As Panel
    Friend WithEvents PanelCerdasPorEtapa As Panel
    Friend WithEvents etapasCerdasChart1 As DataVisualization.Charting.Chart
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents tomarColorPanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents tomarColorLabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents tresAñosChart1 As DataVisualization.Charting.Chart
    Friend WithEvents PanelDefuncioneEngordes As Panel
    Friend WithEvents defuncionesChart1 As DataVisualization.Charting.Chart
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelNacVivosEngordes As Panel
    Friend WithEvents nacidosVivosChart1 As DataVisualization.Charting.Chart
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents SplitContainer4 As SplitContainer
End Class
