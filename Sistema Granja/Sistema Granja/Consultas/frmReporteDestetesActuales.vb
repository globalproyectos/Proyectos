Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmReporteDestetesActuales
    Dim odtsInformesGranja As New dtsInformesGranja
    Dim rptDestetesActualesTableAdapter As New dtsInformesGranjaTableAdapters.rptDestetesActualesTableAdapter

    Private Sub frmReporteDestetesActuales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_LotesGestacion()
    End Sub
    Sub Mostrar_LotesGestacion()
        Try
            Me.LotesComboBoxEx1.Items.Clear()
            Dim cmd As String = "SELECT l.LoteDestino,L.IdEtapa_Cerdas" _
                           & " FROM LOTES l" _
                           & " LEFT JOIN REG_MADRES RM ON L.Lote_No = RM.Lote_No" _
                           & " LEFT JOIN REG_ABUELAS RA ON L.Lote_No = RA.Lote_No" _
                           & " where L.Estado <>'T' AND ((rm.Estado_Actual ='L' OR RA.Estado_Actual ='L'))" _
                           & " GROUP BY L.LoteDestino,L.IdEtapa_Cerdas" _
                           & " ORDER BY L.IdEtapa_Cerdas"

            sql = New SqlCommand(cmd, con)
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                Me.LotesComboBoxEx1.Items.Add(leer(0))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(CadenaError & ex.Message, "Error mostrando Gestaciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            rptDestetesActualesTableAdapter.Fill(odtsInformesGranja.rptDestetesActuales, Me.LotesComboBoxEx1.Text)
            Dim rptDestetes As New rptDesteteActualPorLote
            rptDestetes.SetDataSource(odtsInformesGranja.Tables("rptDestetesActuales"))
            Me.CrystalReportViewer1.ReportSource = rptDestetes
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar reporte", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class