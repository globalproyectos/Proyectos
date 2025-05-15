<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaGranjas
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CbxGranjas = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.SuspendLayout()
        '
        'CbxGranjas
        '
        Me.CbxGranjas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbxGranjas.DisplayMember = "Text"
        Me.CbxGranjas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbxGranjas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxGranjas.FormattingEnabled = True
        Me.CbxGranjas.ItemHeight = 14
        Me.CbxGranjas.Location = New System.Drawing.Point(1, 1)
        Me.CbxGranjas.Name = "CbxGranjas"
        Me.CbxGranjas.Size = New System.Drawing.Size(106, 20)
        Me.CbxGranjas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CbxGranjas.TabIndex = 0
        '
        'ListaGranjas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CbxGranjas)
        Me.Name = "ListaGranjas"
        Me.Size = New System.Drawing.Size(107, 22)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CbxGranjas As DevComponents.DotNetBar.Controls.ComboBoxEx

End Class
