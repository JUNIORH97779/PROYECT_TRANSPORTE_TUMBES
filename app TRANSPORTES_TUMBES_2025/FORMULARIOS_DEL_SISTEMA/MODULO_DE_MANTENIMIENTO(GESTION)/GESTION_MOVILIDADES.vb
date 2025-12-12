Public Class GESTION_MOVILIDADES
    Private Sub MOVILIDADBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MOVILIDADBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MOVILIDADBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._TRANSPORTE_TUMBESDataSet)

    End Sub

    Private Sub GESTION_MOVILIDADES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_TRANSPORTE_TUMBESDataSet.MOVILIDAD' Puede moverla o quitarla según sea necesario.
        Me.MOVILIDADTableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.MOVILIDAD)

    End Sub

    Private Sub TipoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ID_MovilidadLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupMovilidad_Enter(sender As Object, e As EventArgs) Handles GroupMovilidad.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnNuevo.Enabled = False
        btn_guardar.Enabled = True
        btnEliminar.Enabled = False
        btnEditar.Enabled = False
        GroupMovilidad.Enabled = True

        ID_MovilidadTextBox.Clear()
        PlacaTextBox.Clear()
        TipoTextBox.Clear()
        CapacidadTextBox.Clear()
        MarcaTextBox.Clear()

        PlacaTextBox.Focus()


    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If Len(Trim(PlacaTextBox.Text)) = 0 Then
            MsgBox("Ingrese placa de la movilidad", vbCritical, "Validar")
            PlacaTextBox.Focus()
            Return
        End If
        If Len(Trim(TipoTextBox.Text)) = 0 Then
            MsgBox("Ingrese el tipo de la movilidad", vbCritical, "Validar")
            TipoTextBox.Focus()
            Return
        End If
        If Len(Trim(CapacidadTextBox.Text)) = 0 Or Not IsNumeric(CapacidadTextBox.Text) Then
            MsgBox("Ingrese una capacidad válida (solo números)", vbCritical, "Validar")
            CapacidadTextBox.Focus()
            Return
        End If
        If Len(Trim(MarcaTextBox.Text)) = 0 Then
            MsgBox("Ingrese la marca de la movilidad", vbCritical, "Validar")
            MarcaTextBox.Focus()
            Return
        End If
        If MsgBox("¿Desea guardar los cambios?", vbYesNo + vbQuestion, "Confirmar") = vbYes Then
            Try
                Dim capacidadInt As Integer = CInt(CapacidadTextBox.Text)
                Me.MOVILIDADTableAdapter.GUARDAR_MOVILIDAD(PlacaTextBox.Text, TipoTextBox.Text, capacidadInt, MarcaTextBox.Text, True)
                MsgBox("Datos guardados correctamente", vbInformation, "Guardar")
                Me.MOVILIDADTableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.MOVILIDAD)
                btnNuevo.Enabled = True
                btn_guardar.Enabled = False
                btnEliminar.Enabled = True
                btnEditar.Enabled = True
                GroupMovilidad.Enabled = False
            Catch ex As Exception
                MsgBox("Ocurrió un error al guardar: " & ex.Message, vbCritical)
            End Try
        End If
    End Sub

    Private Sub MarcaTextBox_TextChanged(sender As Object, e As EventArgs) Handles MarcaTextBox.TextChanged

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        btnEditar.Enabled = False
        btnDardebaja.Enabled = True
        btnNuevo.Enabled = False
        btnEliminar.Enabled = False
        btn_actualizar.Enabled = True
        GroupMovilidad.Enabled = True

        PlacaTextBox.Focus()
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        If Len(Trim(PlacaTextBox.Text)) = 0 Then
            MsgBox("Ingrese placa", vbCritical)
            PlacaTextBox.Focus()
            Return
        End If
        If Len(Trim(TipoTextBox.Text)) = 0 Then
            MsgBox("Ingrese el tipo de la movilidad", vbCritical, "Validar")
            TipoTextBox.Focus()
            Return
        End If
        If Len(Trim(CapacidadTextBox.Text)) = 0 Or Not IsNumeric(CapacidadTextBox.Text) Then
            MsgBox("Ingrese capacidad válida", vbCritical)
            CapacidadTextBox.Focus()
            Return
        End If
        If Len(Trim(MarcaTextBox.Text)) = 0 Then
            MsgBox("Ingrese la marca de la movilidad", vbCritical, "Validar")
            MarcaTextBox.Focus()
            Return
        End If
        If MsgBox("¿Desea modificar el registro seleccionado?", vbYesNo + vbQuestion, "Editar") = vbYes Then
            Try
                Dim idParaEditar As Integer = CInt(ID_MovilidadTextBox.Text)
                Dim capacidadInt As Integer = CInt(CapacidadTextBox.Text)
                Me.MOVILIDADTableAdapter.ACTUALIZAR_MOVILIDAD(PlacaTextBox.Text, TipoTextBox.Text, capacidadInt, MarcaTextBox.Text, True, idParaEditar)
                MsgBox("Registro actualizado correctamente", vbInformation, "Editar")
                Me.MOVILIDADTableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.MOVILIDAD)
                btnEditar.Enabled = True
                btnDardebaja.Enabled = False
                btnNuevo.Enabled = True
                btnEliminar.Enabled = True
                btn_actualizar.Enabled = False
                GroupMovilidad.Enabled = False
            Catch ex As Exception
                MsgBox("Error al actualizar: " & ex.Message, vbCritical)
            End Try
        End If
    End Sub

    Private Sub btnDardebaja_Click(sender As Object, e As EventArgs) Handles btnDardebaja.Click

    End Sub
End Class