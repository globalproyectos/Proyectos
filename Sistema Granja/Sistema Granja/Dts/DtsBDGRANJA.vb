

Partial Public Class DtsBDGRANJA
    Partial Public Class ResumenAlertasDataTable
    End Class

    Partial Class Alerta_CerdasVaciasDataTable

        Private Sub Alerta_CerdasVaciasDataTable_Alerta_CerdasVaciasRowChanging(sender As Object, e As Alerta_CerdasVaciasRowChangeEvent) Handles Me.Alerta_CerdasVaciasRowChanging

        End Sub

    End Class

    Partial Class RepInventarioDiarioEngorgeDataTable

        Private Sub RepInventarioDiarioEngorgeDataTable_RepInventarioDiarioEngorgeRowChanging(sender As Object, e As RepInventarioDiarioEngorgeRowChangeEvent) Handles Me.RepInventarioDiarioEngorgeRowChanging

        End Sub



    End Class

    Partial Class Historico_Resumen_cerdasDataTable

        Private Sub Historico_Resumen_cerdasDataTable_Historico_Resumen_cerdasRowChanging(sender As Object, e As Historico_Resumen_cerdasRowChangeEvent) Handles Me.Historico_Resumen_cerdasRowChanging

        End Sub

    End Class

    Partial Class ENCABEZADOS_SALIDASDataTable

        'Private Sub ENCABEZADOS_SALIDASDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
        '    If (e.Column.ColumnName = Me.DataColumn1Column.ColumnName) Then
        '        Agregar código de usuario aquí
        '    End If

        'End Sub

    End Class

    Partial Class Lista_Abuelas_DesteteDataTable

        Private Sub Lista_Abuelas_DesteteDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Fecha_Real_DesteteColumn.ColumnName) Then
                Me.Fecha_Real_DesteteColumn.DefaultValue = FechaSistema
            End If

        End Sub

    End Class

End Class

Namespace DtsBDGRANJATableAdapters
    
    Partial Public Class RepInventarioDiarioEngorgeTableAdapter
        Public WriteOnly Property CommandTimeout() As Integer
            Set(ByVal value As Integer)
                Dim i As Integer = 0
                While (i < Me.CommandCollection.Length)
                    If (Me.CommandCollection(i) IsNot Nothing) Then
                        Me.CommandCollection(i).CommandTimeout = value
                    End If
                    i = (i + 1)
                End While
            End Set
        End Property
    End Class
End Namespace
