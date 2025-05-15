Imports System.Data.SqlClient
Imports System.Data
Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmReporteRapido_x_Cerda
    Public CodigoCerda As Integer
    Private Sub frmReporteRapido_x_Cerda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim cadenaConsulta As String = "Declare @FechaUltimaE datetime" _
                                          & " Set @FechaUltimaE= (select Max(Fecha_Enseminacion) from Reg_Enseminaciones_x_cerda where C�digo_Cerda='" & Me.CodigoCerda & "')" _
                                          & " select m.C�digo_Cerda, m.Fecha_Nacimiento, l.Descripcion, e.Fecha_Enseminacion, e.Estado" _
                                          & " from REG_MADRES as m" _
                                          & " JOIN LOTES as l on m.Lote_No=l.Lote_No" _
                                          & " JOIN Reg_Enseminaciones_x_cerda as e on m.C�digo_Cerda=e.C�digo_Cerda" _
                                          & " WHERE m.C�digo_Cerda='" & Me.CodigoCerda & "' and e.Fecha_Enseminacion= @FechaUltimaE" _
                                          & " GROUP BY m.C�digo_Cerda, m.Fecha_Nacimiento, l.Descripcion ,e.Fecha_Enseminacion, e.Estado"
            sql = New SqlCommand(cadenaConsulta, con)
            dt = New DataTable
            With dt.Columns
                .Add(New DataColumn("C�digo Cerda"))
                .Add(New DataColumn("Fecha Nacimiento"))
                .Add(New DataColumn("Estado Actual"))
                .Add(New DataColumn("Fecha Ultima Enseminaci�n"))
                .Add(New DataColumn("Estado Enseminaci�n"))
            End With
            con.Open()
            leer = sql.ExecuteReader
            While leer.Read
                dr = dt.NewRow
                dr(0) = leer(0)
                dr(1) = leer(1)
                dr(2) = leer(2)
                dr(3) = leer(3)
                dr(4) = leer(4)
                dt.Rows.Add(dr)
            End While
            con.Close()
            dv = New DataView(dt)
            Me.DataGridViewX1.DataSource = dv
            EstiloDatagrid(Me.DataGridViewX1, 9, 8, FontStyle.Regular)
        Catch ex As Exception
            MessageBoxEx.Show(CadenaError & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
End Class