Public Class FORMULARIO_VENTAS
    Private Sub PanelAños_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub VENTABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VENTABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VENTABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._TRANSPORTE_TUMBESDataSet)

    End Sub

    Private Sub FORMULARIO_VENTAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_TRANSPORTE_TUMBESDataSet.VIAJE' Puede moverla o quitarla según sea necesario.
        Me.VIAJETableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.VIAJE)
        'TODO: esta línea de código carga datos en la tabla '_TRANSPORTE_TUMBESDataSet.USUARIO' Puede moverla o quitarla según sea necesario.
        Me.USUARIOTableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.USUARIO)
        'TODO: esta línea de código carga datos en la tabla '_TRANSPORTE_TUMBESDataSet.CLIENTE' Puede moverla o quitarla según sea necesario.
        Me.CLIENTETableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.CLIENTE)
        'TODO: esta línea de código carga datos en la tabla '_TRANSPORTE_TUMBESDataSet.VENTA' Puede moverla o quitarla según sea necesario.
        Me.VENTATableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.VENTA)

    End Sub

    Private Sub VIAJEDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VIAJEDataGridView.CellContentClick

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub CLIENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLIENTEToolStripMenuItem.Click
        Dim frmCliente As New BUSCAR_CLIENTES()
        BUSCAR_CLIENTES.Show()
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class