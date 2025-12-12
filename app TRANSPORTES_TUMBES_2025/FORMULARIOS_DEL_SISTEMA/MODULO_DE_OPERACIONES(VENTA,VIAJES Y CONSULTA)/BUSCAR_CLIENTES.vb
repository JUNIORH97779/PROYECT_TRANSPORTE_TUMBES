Public Class BUSCAR_CLIENTES
    Private filtrar_clientes As New DataView
    Private Sub CLIENTEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CLIENTEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._TRANSPORTE_TUMBESDataSet)

    End Sub

    Private Sub BUSCAR_CLIENTES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_TRANSPORTE_TUMBESDataSet.TIPO_DOCUMENTO' Puede moverla o quitarla según sea necesario.
        Me.TIPO_DOCUMENTOTableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.TIPO_DOCUMENTO)
        'TODO: esta línea de código carga datos en la tabla '_TRANSPORTE_TUMBESDataSet.CLIENTE' Puede moverla o quitarla según sea necesario.
        Me.CLIENTETableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.CLIENTE)
        filtrar_clientes = Me._TRANSPORTE_TUMBESDataSet.CLIENTE.DefaultView
        CLIENTEDataGridView.DataSource = filtrar_clientes
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Btn_agregar.Enabled = True
        Btn_editar.Enabled = True
        'Btn_seleccionar.Enabled = True
        Searche_cliente.Enabled = True
        Group_clienteAGG.Visible = False
    End Sub
    Private Sub Btn_agregar_Click(sender As Object, e As EventArgs) Handles Btn_agregar.Click
        Btn_agregar.Enabled = False
        Btn_editar.Enabled = False
        'Btn_seleccionar.Enabled = False
        Searche_cliente.Enabled = False
        Group_clienteAGG.Visible = True

        TextBoxIDclie.Clear()
        ComboBox1.SelectedIndex = -1
        TextBoxNROdoc.Clear()
        TextBoxNOM.Clear()
        TextBoxAPE.Clear()
        TextBoxTEL.Clear()
        TextBoxEMAIL.Clear()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una opción de la lista", vbCritical, "Validar")
            ComboBox1.DroppedDown = True
            ComboBox1.Focus()
            Return
        End If
        If Len(Trim(TextBoxNROdoc.Text)) = 0 Then
            MsgBox("Coloque un numero de documento", vbCritical, "Validar")
            TextBoxNROdoc.Focus()
            Return
        End If
        If Len(Trim(TextBoxNOM.Text)) = 0 Then
            MsgBox("Coloque un nombre", vbCritical, "Validar")
            TextBoxNOM.Focus()
            Return
        End If
        If Len(Trim(TextBoxAPE.Text)) = 0 Then
            MsgBox("Coloque un apellido", vbCritical, "Validar")
            TextBoxAPE.Focus()
            Return
        End If

        If Len(Trim(TextBoxTEL.Text)) = 0 Then
            MsgBox("Coloque un numero de teléfono", vbCritical, "Validar")
            TextBoxTEL.Focus()
            Return
        End If
        If Len(Trim(TextBoxEMAIL.Text)) = 0 Then
            MsgBox("Coloque un email", vbCritical, "Validar")
            TextBoxEMAIL.Focus()
        End If

        If MsgBox("¿Desea guardar los cambios?", vbYesNo) = vbYes Then
            Me.CLIENTETableAdapter.AGREGAR_CLIENTE(ComboBox1.SelectedValue, TextBoxNROdoc.Text, TextBoxNOM.Text, TextBoxAPE.Text, TextBoxTEL.Text, TextBoxEMAIL.Text)
            MsgBox("Datos guardados correctamente", vbInformation, "Guardar")
            Me.CLIENTETableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.CLIENTE)
            Btn_agregar.Enabled = True
            Btn_editar.Enabled = True
            'Btn_seleccionar.Enabled = True
            Searche_cliente.Enabled = True
            Group_clienteAGG.Visible = False
        End If

    End Sub
    Private Sub Btn_editar_Click(sender As Object, e As EventArgs) Handles Btn_editar.Click
        Btn_editar.Enabled = False
        Btn_agregar.Enabled = False
        'Btn_seleccionar.Enabled = False
        Group_editarCLI.Visible = True
        Searche_cliente.Enabled = False
    End Sub
    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click

        If MsgBox("¿Desea actualizar los cambios?", vbYesNo) = vbYes Then
            Me.CLIENTETableAdapter.ACTUALIZAR_CLIENNTE(ID_TipoDocumentoComboBox.SelectedValue, NumeroDocumentoTextBox.Text, NombresTextBox.Text, ApellidosTextBox.Text, TelefonoTextBox.Text, EmailTextBox.Text, ID_ClienteTextBox.Text)
            MsgBox("Datos actualizados correctamente", vbInformation, "Guardar")
            Me.CLIENTETableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.CLIENTE)
            Btn_editar.Enabled = True
            Btn_agregar.Enabled = True
            'Btn_seleccionar.Enabled = True
            Group_editarCLI.Visible = False
            Searche_cliente.Enabled = True
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Btn_editar.Enabled = True
        Btn_agregar.Enabled = True
        'Btn_seleccionar.Enabled = True
        Group_editarCLI.Visible = False
        Searche_cliente.Enabled = True
    End Sub
    Private Sub Searche_cliente_TextChanged(sender As Object, e As EventArgs) Handles Searche_cliente.TextChanged
        filtrar_clientes.RowFilter = String.Format("NumeroDocumento LIKE '%{0}%'", Searche_cliente.Text)
    End Sub
End Class