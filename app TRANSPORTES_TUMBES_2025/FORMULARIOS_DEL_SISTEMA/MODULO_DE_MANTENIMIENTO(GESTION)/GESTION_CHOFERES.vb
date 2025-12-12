Public Class GESTION_CHOFERES
    Private Sub CHOFERBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CHOFERBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CHOFERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._TRANSPORTE_TUMBESDataSet)

    End Sub

    Private Sub GESTION_CHOFERES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_TRANSPORTE_TUMBESDataSet.TIPO_DOCUMENTO' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla '_TRANSPORTE_TUMBESDataSet.CHOFER' Puede moverla o quitarla según sea necesario.
        Me.CHOFERTableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.CHOFER)
        Me.TIPO_DOCUMENTOTableAdapter.FillBylistDI(Me._TRANSPORTE_TUMBESDataSet.TIPO_DOCUMENTO)
        'ID_TipoDocumentoComboBox.DataSource = Me._TRANSPORTE_TUMBESDataSet.TIPO_DOCUMENTO
        'ID_TipoDocumentoComboBox.DisplayMember = "Abreviatura"
        'ID_TipoDocumentoComboBox.ValueMember = "ID_TipoDocumento"

    End Sub

    Private Sub TelefonoTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub NumeroDocumentoTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        GroupBox1.Enabled = True
        btnNuevo.Enabled = False
        btnEditar.Enabled = False
        btnGuardar.Enabled = True

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        GroupBox1.Enabled = True
        btnEditar.Enabled = False
        btnNuevo.Enabled = False
        btnActualizar.Enabled = True

    End Sub
    Private Sub TelefonoTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles TelefonoTextBox.TextChanged

    End Sub

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Len(Trim(ID_TipoDocumentoComboBox.Text)) = 0 Then
            MsgBox("Debe seleccionar el Tipo de Documento.", vbCritical, "Validación de Chofer")
            ID_TipoDocumentoComboBox.Focus()
            Return
        End If
        If Len(Trim(NumeroDocumentoTextBox.Text)) = 0 Then
            MsgBox("Debe ingresar el Número de Documento.", vbCritical, "Validación de Chofer")
            NumeroDocumentoTextBox.Focus()
            Return
        End If
        If Len(Trim(NombresTextBox.Text)) = 0 Then
            MsgBox("Debe ingresar los Nombres del Chofer.", vbCritical, "Validación de Chofer")
            NombresTextBox.Focus()
            Return
        End If
        If Len(Trim(ApellidosTextBox.Text)) = 0 Then
            MsgBox("Debe ingresar los Apellidos del Chofer.", vbCritical, "Validación de Chofer")
            ApellidosTextBox.Focus()
            Return
        End If
        If Len(Trim(NumeroLicenciaTextBox.Text)) = 0 Then
            MsgBox("Debe ingresar el Número de Licencia.", vbCritical, "Validación de Chofer")
            NumeroLicenciaTextBox.Focus()
            Return
        End If
        If Len(Trim(TelefonoTextBox.Text)) = 0 Then
            MsgBox("Debe ingresar el Número de Teléfono.", vbCritical, "Validación de Chofer")
            TelefonoTextBox.Focus()
            Return
        End If
        If Len(Trim(EstadoTextBox.Text)) = 0 Then
            MsgBox("Debe ingresar el Número de Teléfono.", vbCritical, "Validación de Chofer")
            EstadoTextBox.Focus()
            Return
        End If
        If MsgBox("¿Desea guardar los cambios?", vbYesNo) = vbYes Then
            Me.CHOFERTableAdapter.GUARDAR_CHOFER(
                ID_TipoDocumentoComboBox.SelectedValue,
                NumeroDocumentoTextBox.Text,
                NombresTextBox.Text,
                ApellidosTextBox.Text,
                NumeroLicenciaTextBox.Text,
                TelefonoTextBox.Text, EstadoTextBox.Text)
            MsgBox("Datos guardados correctamente", vbInformation, "Guardar")
            Me.CHOFERTableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.CHOFER)
            GroupBox1.Enabled = False
            btnNuevo.Enabled = True
            btnEditar.Enabled = True
            btnGuardar.Enabled = False
        End If
    End Sub

    Private Sub btnActualizar_Click_1(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Len(Trim(ID_TipoDocumentoComboBox.Text)) = 0 Then
            MsgBox("Debe seleccionar el Tipo de Documento.", vbCritical, "Validación de Chofer")
            ID_TipoDocumentoComboBox.Focus()
            Return
        End If
        If Len(Trim(NumeroDocumentoTextBox.Text)) = 0 Then
            MsgBox("Debe ingresar el Número de Documento.", vbCritical, "Validación de Chofer")
            NumeroDocumentoTextBox.Focus()
            Return
        End If
        If Len(Trim(NombresTextBox.Text)) = 0 Then
            MsgBox("Debe ingresar los Nombres del Chofer.", vbCritical, "Validación de Chofer")
            NombresTextBox.Focus()
            Return
        End If
        If Len(Trim(ApellidosTextBox.Text)) = 0 Then
            MsgBox("Debe ingresar los Apellidos del Chofer.", vbCritical, "Validación de Chofer")
            ApellidosTextBox.Focus()
            Return
        End If
        If Len(Trim(NumeroLicenciaTextBox.Text)) = 0 Then
            MsgBox("Debe ingresar el Número de Licencia.", vbCritical, "Validación de Chofer")
            NumeroLicenciaTextBox.Focus()
            Return
        End If
        If Len(Trim(TelefonoTextBox.Text)) = 0 Then
            MsgBox("Debe ingresar el Número de Teléfono.", vbCritical, "Validación de Chofer")
            TelefonoTextBox.Focus()
            Return
        End If
        If MsgBox("¿Desea actualizar los cambios?", vbYesNo) = vbYes Then
            Me.CHOFERTableAdapter.ACTUALIZAR_CHOFER(
        ID_TipoDocumentoComboBox.SelectedValue,
        NumeroDocumentoTextBox.Text,
        NombresTextBox.Text,
        ApellidosTextBox.Text,
        NumeroLicenciaTextBox.Text,
        TelefonoTextBox.Text, EstadoTextBox.Text, ID_ChoferTextBox.Text)
            MsgBox("Datos actualizados correctamente", vbInformation, "Guardar")
            Me.CHOFERTableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.CHOFER)
            GroupBox1.Enabled = False
            btnEditar.Enabled = True
            btnNuevo.Enabled = True
            btnActualizar.Enabled = False
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class