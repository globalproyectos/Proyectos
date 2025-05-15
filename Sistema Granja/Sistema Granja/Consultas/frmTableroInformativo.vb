Public Class frmTableroInformativo
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim odtsTablero As New dtsTableroInformativo
    Dim Etapas_CerdasAdapter As New dtsTableroInformativoTableAdapters.Etapas_CerdasTableAdapter
    Dim DestetadosPorMesAdapter As New dtsTableroInformativoTableAdapters.DestetadosPorMesTableAdapter
    Dim Proc_TableroInformativo_Engodes_6_mesesAdapter As New dtsTableroInformativoTableAdapters.Proc_TableroInformativo_Engodes_6_mesesTableAdapter
    Dim Proc_TableroInformativo_Engodes_3_añosAdapter As New dtsTableroInformativoTableAdapters.Proc_TableroInformativo_Engodes_3_añosTableAdapter
    Private Sub frmTableroInformativo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DtsTableroInformativo.Etapas_Cerdas' Puede moverla o quitarla según sea necesario.

        Me.Etapas_CerdasTableAdapter.Fill(Me.DtsTableroInformativo.Etapas_Cerdas)
        'FechaSistema = "05/10/2019"
        coloresPaneles()

        cargaretapascerdas_pastel()
        destetesengordes_barras()
        cargar_TableroInformativo_Engodes_6_meses()
        cargar_Proc_TableroInformativo_Engodes_3_años()
    End Sub
    Public Sub coloresPaneles()
        Me.Panel5.BackColor = tomarColorPanelEx1.ColorScheme.BarBackground
        Me.Label1.ForeColor = Me.tomarColorLabelX1.ForeColor

        Me.Panel9.BackColor = tomarColorPanelEx1.ColorScheme.BarBackground
        Me.Label3.ForeColor = Me.tomarColorLabelX1.ForeColor

        Me.Panel6.BackColor = tomarColorPanelEx1.ColorScheme.BarBackground
        Me.Label2.ForeColor = Me.tomarColorLabelX1.ForeColor


        Me.Panel10.BackColor = tomarColorPanelEx1.ColorScheme.BarBackground
        Me.Label4.ForeColor = Me.tomarColorLabelX1.ForeColor

        Me.Panel12.BackColor = tomarColorPanelEx1.ColorScheme.BarBackground
        Me.Label5.ForeColor = Me.tomarColorLabelX1.ForeColor
    End Sub
    Sub cargaretapascerdas_pastel()
        Etapas_CerdasTableAdapter.Fill(odtsTablero.Etapas_Cerdas)

        Dim etapas As New ArrayList()
        Dim numero As New ArrayList()

        For i As Integer = 0 To Me.odtsTablero.Etapas_Cerdas.Rows.Count - 1
            etapas.Add(Me.odtsTablero.Etapas_Cerdas.Rows(i).Item("Etapa"))
            numero.Add(Me.odtsTablero.Etapas_Cerdas.Rows(i).Item("Num"))
        Next

        etapasCerdasChart1.Series(0).Points.DataBindXY(etapas, numero)


    End Sub
    Sub destetesengordes_barras()
        DestetadosPorMesAdapter.Fill(odtsTablero.DestetadosPorMes)

        Dim año As New ArrayList()
        Dim mes As New ArrayList()
        Dim totaldestetados As New ArrayList()

        For i As Integer = 0 To Me.odtsTablero.DestetadosPorMes.Rows.Count - 1
            año.Add(Me.odtsTablero.DestetadosPorMes.Rows(i).Item("Año"))
            mes.Add(Me.odtsTablero.DestetadosPorMes.Rows(i).Item("Mes"))
            totaldestetados.Add(Me.odtsTablero.DestetadosPorMes.Rows(i).Item("TotalDestetados"))
        Next

        'DestetesChart1.Series(0).Points.DataBindXY(mes, totaldestetados)

    End Sub
    Sub cargar_TableroInformativo_Engodes_6_meses()
        Proc_TableroInformativo_Engodes_6_mesesAdapter.Fill(odtsTablero.Proc_TableroInformativo_Engodes_6_meses, FechaSistema)

        Dim mes, nacidosvios, nacidosmuertos, momias, muertosgestacion, donados, adoptados, destetados As New ArrayList()
        For i As Integer = 0 To odtsTablero.Proc_TableroInformativo_Engodes_6_meses.Rows.Count - 1
            mes.Add(odtsTablero.Proc_TableroInformativo_Engodes_6_meses.Rows(i).Item("mes"))
            nacidosvios.Add(odtsTablero.Proc_TableroInformativo_Engodes_6_meses.Rows(i).Item("nacidovivos"))
            nacidosmuertos.Add(odtsTablero.Proc_TableroInformativo_Engodes_6_meses.Rows(i).Item("nacidosmuertos"))
            momias.Add(odtsTablero.Proc_TableroInformativo_Engodes_6_meses.Rows(i).Item("momias"))
            muertosgestacion.Add(odtsTablero.Proc_TableroInformativo_Engodes_6_meses.Rows(i).Item("muertosgestacion"))
            donados.Add(odtsTablero.Proc_TableroInformativo_Engodes_6_meses.Rows(i).Item("donados"))
            adoptados.Add(odtsTablero.Proc_TableroInformativo_Engodes_6_meses.Rows(i).Item("adoptados"))
            destetados.Add(odtsTablero.Proc_TableroInformativo_Engodes_6_meses.Rows(i).Item("destetados"))

        Next

        Me.movimientosLoteChart1.Series("NacidosVivos").Points.DataBindXY(mes, nacidosvios)
        Me.movimientosLoteChart1.Series("NacidosMuertos").Points.DataBindXY(mes, nacidosmuertos)
        Me.movimientosLoteChart1.Series("Momias").Points.DataBindXY(mes, momias)
        Me.movimientosLoteChart1.Series("MuertosGestacion").Points.DataBindXY(mes, muertosgestacion)
        Me.movimientosLoteChart1.Series("Donados").Points.DataBindXY(mes, donados)
        Me.movimientosLoteChart1.Series("Adoptados").Points.DataBindXY(mes, adoptados)
        Me.movimientosLoteChart1.Series("Destetados").Points.DataBindXY(mes, destetados)
    End Sub

    Sub cargar_Proc_TableroInformativo_Engodes_3_años()
        Dim año, nacidosvios, muertos, momias, muertosgestacion, donados, adoptados, destetados As New ArrayList()
        Proc_TableroInformativo_Engodes_3_añosAdapter.Fill(odtsTablero.Proc_TableroInformativo_Engodes_3_años, FechaSistema)
        For i As Integer = 0 To odtsTablero.Proc_TableroInformativo_Engodes_3_años.Rows.Count - 1
            año.Add(odtsTablero.Proc_TableroInformativo_Engodes_3_años.Rows(i).Item("año"))
            nacidosvios.Add(odtsTablero.Proc_TableroInformativo_Engodes_3_años.Rows(i).Item("nacidosvivos"))
            muertos.Add(odtsTablero.Proc_TableroInformativo_Engodes_3_años.Rows(i).Item("nacidosmuertos") + odtsTablero.Proc_TableroInformativo_Engodes_3_años.Rows(i).Item("muertosgestacion"))
            momias.Add(odtsTablero.Proc_TableroInformativo_Engodes_3_años.Rows(i).Item("momias"))

            donados.Add(odtsTablero.Proc_TableroInformativo_Engodes_3_años.Rows(i).Item("donados"))
            adoptados.Add(odtsTablero.Proc_TableroInformativo_Engodes_3_años.Rows(i).Item("adoptados"))
            destetados.Add(odtsTablero.Proc_TableroInformativo_Engodes_3_años.Rows(i).Item("destetados"))
        Next

        'Me.tresAñosChart1.Series("NacidosVivos").Points.DataBindXY(año, nacidosvios)
        'Me.tresAñosChart1.Series("NacidosMuertos").Points.DataBindXY(año, nacidosmuertos)
        'Me.tresAñosChart1.Series("Momias").Points.DataBindXY(año, momias)
        'Me.tresAñosChart1.Series("MuertosGestacion").Points.DataBindXY(año, muertosgestacion)
        'Me.tresAñosChart1.Series("Donados").Points.DataBindXY(año, donados)
        'Me.tresAñosChart1.Series("Adoptados").Points.DataBindXY(año, adoptados)
        Me.tresAñosChart1.Series("Destetados").Points.DataBindXY(año, destetados)
        Me.defuncionesChart1.Series("Defunciones").Points.DataBindXY(año, muertos)
        Me.nacidosVivosChart1.Series("NacidosVivos").Points.DataBindXY(año, nacidosvios)
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Cursor = Cursors.WaitCursor
        cargaretapascerdas_pastel()
        destetesengordes_barras()
        cargar_TableroInformativo_Engodes_6_meses()
        cargar_Proc_TableroInformativo_Engodes_3_años()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub frmTableroInformativo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmPrincipal.mostrapanelRapido(True)
    End Sub
End Class