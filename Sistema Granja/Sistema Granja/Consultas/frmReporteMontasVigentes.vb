Imports System.Data.SqlClient


Public Class frmReporteMontasVigentes
    Dim odtsInformesGranja As New dtsInformesGranja
    Dim rptMontasConfirmadasTableAdapter As New dtsInformesGranjaTableAdapters.rptMontasConfirmadasTableAdapter
    Private Sub frmReporteMontasVigentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_LotesGestacion()
    End Sub
    Sub Mostrar_LotesGestacion()
        Try
            Me.LotesComboBoxEx1.Items.Clear()
            Dim cmd As String = "SELECT l.Lote_No,L.IdEtapa_Cerdas" _
                           & " FROM LOTES l" _
                           & " LEFT JOIN REG_MADRES RM ON L.Lote_No = RM.Lote_No" _
                           & " LEFT JOIN REG_ABUELAS RA ON L.Lote_No = RA.Lote_No" _
                           & " where L.Estado <>'T' AND ((rm.Estado_Actual ='G' OR RA.Estado_Actual ='G'))" _
                           & " GROUP BY L.Lote_No,L.IdEtapa_Cerdas" _
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
            rptMontasConfirmadasTableAdapter.Fill(odtsInformesGranja.rptMontasConfirmadas, Me.LotesComboBoxEx1.Text)
            Dim rptMontasVigentes As New rptMontasVigentes
            rptMontasVigentes.SetDataSource(odtsInformesGranja.Tables("rptMontasConfirmadas"))

            Me.CrystalReportViewer1.ReportSource = rptMontasVigentes

            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar reporte", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class