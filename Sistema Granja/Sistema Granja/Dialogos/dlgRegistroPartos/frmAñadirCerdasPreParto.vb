Public Class frmAñadirCerdasPreParto
    Dim odtsProcesosCerdas As New dtsProcesosCerdas
    Dim SubidasPrePartosDetalleTableAdapter As New dtsProcesosCerdasTableAdapters.SubidasPrePartosDetalleTableAdapter
    Dim Proc_SubidaPrePartoDetalle_x_SubidaNoTableAdapter As New dtsProcesosCerdasTableAdapters.Proc_SubidaPrePartoDetalle_x_SubidaNoTableAdapter
    Dim lotesAdapter As New dtsProcesosCerdasTableAdapters.LotesTableAdapter
    Dim bsSubidas_ As New BindingSource
    Dim Proc_SubidaPrePartoDetalle_x_SubidaNo_LotesTableAdapter As New dtsProcesosCerdasTableAdapters.Proc_SubidaPrePartoDetalle_x_SubidaNo_LotesTableAdapter
    Public p_fechasubida As Date
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub
    Private Sub frmAñadirCerdasPreParto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarlotesgestacion()
        cargarlista(Me.codigocerdaTextBoxX1.Text, Me.lotegestacionComboBoxEx1.Text)
    End Sub
    Sub cargarlista(ByVal codigocerda As String, ByVal loteno As String)
        Try
            Proc_SubidaPrePartoDetalle_x_SubidaNoTableAdapter.Fill(odtsProcesosCerdas.Proc_SubidaPrePartoDetalle_x_SubidaNo, 0, codigocerda, loteno, FechaSistema)
            bsSubidas_.DataSource = odtsProcesosCerdas.Proc_SubidaPrePartoDetalle_x_SubidaNo
            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = bsSubidas_

            For i As Integer = 0 To Me.DataGridViewX1.RowCount - 1
                Me.DataGridViewX1.Rows(i).Cells("Accion").Value = "Trasladar"
            Next
            revisarmovidas()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargarlotesgestacion()
        Try
            Me.lotegestacionComboBoxEx1.DataSource = Proc_SubidaPrePartoDetalle_x_SubidaNo_LotesTableAdapter.GetData(0)
            lotegestacionComboBoxEx1.ValueMember = "loteno"
            lotegestacionComboBoxEx1.DisplayMember = "loteno"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub codigocerdaTextBoxX1_KeyDown(sender As Object, e As KeyEventArgs) Handles codigocerdaTextBoxX1.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargarlista(Me.codigocerdaTextBoxX1.Text, Me.lotegestacionComboBoxEx1.Text)
        End If
    End Sub
    Sub revisarmovidas()
        For i As Integer = 0 To Me.DataGridViewX1.RowCount - 1
            Me.DataGridViewX1.Rows(i).DefaultCellStyle.BackColor = Nothing
            Me.DataGridViewX1.Rows(i).DefaultCellStyle.ForeColor = Nothing
        Next
        For i As Integer = 0 To Me.DataGridViewX2.Rows.Count - 1
            For y As Integer = 0 To Me.DataGridViewX1.Rows.Count - 1
                If Me.DataGridViewX1.Rows(y).Cells("ID_Inseminacion").Value = Me.DataGridViewX2.Rows(i).Cells("IDInseminacion2").Value Then
                    Me.DataGridViewX1.Rows(y).DefaultCellStyle.BackColor = Color.Red
                    Me.DataGridViewX1.Rows(y).DefaultCellStyle.ForeColor = Color.White
                End If
            Next
        Next
    End Sub
    Private Sub DataGridViewX1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick
        If Me.DataGridViewX1.CurrentCell.ColumnIndex = 4 Then
            If Me.DataGridViewX1.Rows(Me.DataGridViewX1.CurrentCell.RowIndex).DefaultCellStyle.BackColor = Color.Red Then
                Me.errorLabelX3.Visible = True
                Me.errorLabelX3.Text = "El código de la cerda: " & Me.DataGridViewX1.CurrentRow.Cells("CodigoCerda").Value & " ya fue trasladada"
                Me.Timer1.Enabled = True
            Else
                Me.DataGridViewX2.Rows.Add(Me.DataGridViewX1.Rows(e.RowIndex).Cells("ID_Inseminacion").Value, Me.DataGridViewX1.Rows(e.RowIndex).Cells("CodigoCerda").Value, Me.DataGridViewX1.Rows(e.RowIndex).Cells("LoteGestacion").Value, p_fechasubida, 0, bsSubidas_.Current("DiasGestacion"), "", "", "Remover", bsSubidas_.Current("EstadoCerda"))
                revisarmovidas()
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static seg As Integer
        seg += 1
        If seg = 3 Then
            seg = 0
            Me.errorLabelX3.Visible = False
            Me.Timer1.Enabled = False
        End If
    End Sub
    Private Sub DataGridViewX2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX2.CellContentClick
        If Me.DataGridViewX2.CurrentCell.ColumnIndex = 7 Then
            Dim resp As MsgBoxResult = MessageBox.Show("¿Confirma que desea remover la cerda: " & Me.DataGridViewX2.CurrentRow.Cells("CodigoCerda2").Value, "Remover Cerdas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then
                Me.DataGridViewX2.Rows.RemoveAt(Me.DataGridViewX2.CurrentCell.RowIndex)
                revisarmovidas()
            End If
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            For i As Integer = 0 To Me.DataGridViewX2.RowCount - 1
                frmRegistrarSubidas_a_Partos.bsSubidasDetalles.AddNew()
                frmRegistrarSubidas_a_Partos.bsSubidasDetalles.Current("SubidaNo") = Me.subidanoLabelX3.Text
                frmRegistrarSubidas_a_Partos.bsSubidasDetalles.Current("ID_Inseminacion") = Me.DataGridViewX2.Rows(i).Cells("IDInseminacion2").Value
                frmRegistrarSubidas_a_Partos.bsSubidasDetalles.Current("CodigoCerda") = Me.DataGridViewX2.Rows(i).Cells("CodigoCerda2").Value
                frmRegistrarSubidas_a_Partos.bsSubidasDetalles.Current("FechaSubidaPreParto") = Me.DataGridViewX2.Rows(i).Cells("FechaSubida").Value
                frmRegistrarSubidas_a_Partos.bsSubidasDetalles.Current("FechaSubPrePartoNat") = Today & " " & TimeOfDay
                frmRegistrarSubidas_a_Partos.bsSubidasDetalles.Current("Nota") = Me.DataGridViewX2.Rows(i).Cells("Nota").Value
                frmRegistrarSubidas_a_Partos.bsSubidasDetalles.Current("Peso") = Me.DataGridViewX2.Rows(i).Cells("Peso").Value
                frmRegistrarSubidas_a_Partos.bsSubidasDetalles.Current("Usuario") = UsuarioSistema
                frmRegistrarSubidas_a_Partos.bsSubidasDetalles.Current("LoteGestacion") = Me.DataGridViewX2.Rows(i).Cells("LoteGestacion2").Value
                frmRegistrarSubidas_a_Partos.bsSubidasDetalles.Current("DiasGestacion") = Me.DataGridViewX2.Rows(i).Cells("DiasGestacion").Value
                frmRegistrarSubidas_a_Partos.bsSubidasDetalles.Current("FechaSistema") = FechaSistema
                frmRegistrarSubidas_a_Partos.bsSubidasDetalles.Current("EstadoCerda") = Me.DataGridViewX2.Rows(i).Cells("EstadoCerda").Value
                frmRegistrarSubidas_a_Partos.bsSubidasDetalles.Current("NoCuna") = Me.DataGridViewX2.Rows(i).Cells("NoCuna").Value
            Next
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub lotegestacionComboBoxEx1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lotegestacionComboBoxEx1.SelectedIndexChanged
        cargarlista(codigocerdaTextBoxX1.Text, Me.lotegestacionComboBoxEx1.Text)
    End Sub
End Class