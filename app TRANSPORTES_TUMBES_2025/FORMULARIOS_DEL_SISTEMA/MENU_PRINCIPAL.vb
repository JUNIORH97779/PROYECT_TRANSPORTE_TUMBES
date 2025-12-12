Public Class MENU_PRINCIPAL
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub MENU_PRINCIPAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub abrirformenpanel(ByVal forhijo As Object)
        If Me.panel_principal.Controls.Count > 0 Then
            Me.panel_principal.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(forhijo, Form)
        fh.TopLevel = False
        fh.Dock = DockStyle.Fill
        Me.panel_principal.Controls.Add(fh)
        Me.panel_principal.Tag = fh
        fh.Show()

    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_operaciones_Click(sender As Object, e As EventArgs) Handles btn_operaciones.Click
        ContextMenuStrip1.Show(btn_operaciones, 0, btn_operaciones.Height)
    End Sub

    Private Sub OPERACIONESToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CONSULTASToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_mantenimiento_Click(sender As Object, e As EventArgs) Handles btn_mantenimiento.Click
        ContextMenuStrip2.Show(btn_mantenimiento, 0, btn_mantenimiento.Height)
    End Sub

    Private Sub MANIFIESTODEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MANIFIESTODEToolStripMenuItem.Click

    End Sub

    Private Sub btn_reportes_Click(sender As Object, e As EventArgs) Handles btn_reportes.Click
        ContextMenuStrip3.Show(btn_reportes, 0, btn_reportes.Height)
    End Sub

    Private Sub GESTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GESTToolStripMenuItem.Click
        abrirformenpanel(New GESTION_USUARIOS)
    End Sub

    Private Sub CHOFERESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHOFERESToolStripMenuItem.Click
        abrirformenpanel(New GESTION_CHOFERES)
    End Sub

    Private Sub VENDERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VENDERToolStripMenuItem.Click
        abrirformenpanel(New FORMULARIO_VENTAS)
    End Sub

    Private Sub CONSULTARCLIENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARCLIENTEToolStripMenuItem.Click
        abrirformenpanel(New BUSCAR_CLIENTES)
    End Sub

    Private Sub MOVILIDADESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOVILIDADESToolStripMenuItem.Click
        abrirformenpanel(New GESTION_MOVILIDADES)
    End Sub

    Private Sub PROGRAMARVIAJESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PROGRAMARVIAJESToolStripMenuItem.Click
        abrirformenpanel(New PROGRAMAR_VIAJES)
    End Sub

    Private Sub RUTASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RUTASToolStripMenuItem.Click
        abrirformenpanel(New GESTION_RUTAS)
    End Sub
End Class