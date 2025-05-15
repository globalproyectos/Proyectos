Public Class frmUbicacionesAñadir
    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub

    Private Sub aceptarButtonX3_Click(sender As Object, e As EventArgs) Handles aceptarButtonX3.Click
        If Me.ubicacionTextBoxX1.Text.Trim = "" Or Me.descripcionTextBoxX2.Text.Trim = "" Then
            MessageBox.Show("Faltan datos que complementar los campos con (*) son requeridos", "Datos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            odtsBDGRANJA.UbicacionesEditable.UbicacionColumn.DefaultValue = Me.ubicacionTextBoxX1.Text
            odtsBDGRANJA.UbicacionesEditable.DescripcionColumn.DefaultValue = Me.descripcionTextBoxX2.Text
            odtsBDGRANJA.UbicacionesEditable.ActivaColumn.DefaultValue = If(Me.activaCheckBoxX1.CheckState = CheckState.Checked, True, False)
            frmUbicaciones.bsUbicaciones.AddNew()
            frmUbicaciones.guardarcambios()
            frmUbicaciones.cargar()
            Me.ubicacionTextBoxX1.Text = ""
            Me.descripcionTextBoxX2.Text = ""
            Me.activaCheckBoxX1.CheckState = CheckState.Checked
            Me.Close()
        End If
    End Sub
End Class