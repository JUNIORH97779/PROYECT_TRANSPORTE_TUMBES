Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class PROGRAMAR_VIAJES
    Private Sub VIAJEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VIAJEBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VIAJEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._TRANSPORTE_TUMBESDataSet)

    End Sub

    Private Sub PROGRAMAR_VIAJES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_TRANSPORTE_TUMBESDataSet.CHOFER' Puede moverla o quitarla según sea necesario.
        Me.CHOFERTableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.CHOFER)
        'TODO: esta línea de código carga datos en la tabla '_TRANSPORTE_TUMBESDataSet.MOVILIDAD' Puede moverla o quitarla según sea necesario.
        Me.MOVILIDADTableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.MOVILIDAD)
        'TODO: esta línea de código carga datos en la tabla '_TRANSPORTE_TUMBESDataSet.RUTA' Puede moverla o quitarla según sea necesario.
        Me.RUTATableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.RUTA)
        'TODO: esta línea de código carga datos en la tabla '_TRANSPORTE_TUMBESDataSet.VIAJE' Puede moverla o quitarla según sea necesario.
        Me.VIAJETableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.VIAJE)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        GroupBoxviaje.Enabled = True
        btnEditar.Enabled = False
        btnNuevo.Enabled = False
        btn_guardar.Enabled = True

        ID_ViajeTextBox.Clear()
        EstadoTextBox.Clear()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If Len(Trim(ComboBoxRUTA.Text)) = 0 Then
            MsgBox("seleccione una ruta", vbCritical, "Validar")
            ComboBoxRUTA.Focus()
        End If
        If Len(Trim(ComboBoxMOVILIAD.Text)) = 0 Then
            MsgBox("seleccione una movilidad", vbCritical, "Validar")
            ComboBoxMOVILIAD.Focus()
        End If
        If Len(Trim(ComboBoxCHOFER.Text)) = 0 Then
            MsgBox("seleccione una movilidad", vbCritical, "Validar")
            ComboBoxCHOFER.Focus()
        End If
        If Len(Trim(EstadoTextBox.Text)) = 0 Then
            MsgBox("El campo ESTADO es obligatorio.", vbCritical, "Validación de Viaje")
            EstadoTextBox.Focus()
            Return
        End If
        If MsgBox("¿Desea guardar los cambios del viaje?", vbYesNo, "Confirmar Guardado") = vbYes Then
            Try
                Me.VIAJETableAdapter.GUARDAR_VIAJE(
                    Convert.ToInt32(ComboBoxRUTA.SelectedValue),
                    Convert.ToInt32(ComboBoxMOVILIAD.SelectedValue),
                    Convert.ToInt32(ComboBoxCHOFER.SelectedValue),
                    FechaHoraSalidaDateTimePicker.Value,
                    EstadoTextBox.Text)

                MsgBox("Datos de Viaje guardados correctamente", vbInformation, "Guardar")
                Me.VIAJETableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.VIAJE)
                GroupBoxviaje.Enabled = False
                btnEditar.Enabled = True
                btnNuevo.Enabled = True
                btn_guardar.Enabled = False
            Catch ex As Exception
                MsgBox("Ocurrió un error al guardar los datos del viaje: " & ex.Message, vbCritical, "Error de Base de Datos")
            End Try
        End If

    End Sub


    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        GroupBoxviaje.Enabled = True
        btnEditar.Enabled = False
        btnNuevo.Enabled = False
        btn_actualizar.Enabled = True
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        If Len(Trim(ComboBoxRUTA.Text)) = 0 Then
            MsgBox("seleccione una ruta", vbCritical, "Validar")
            ComboBoxRUTA.Focus()
        End If
        If Len(Trim(ComboBoxMOVILIAD.Text)) = 0 Then
            MsgBox("seleccione una movilidad", vbCritical, "Validar")
            ComboBoxMOVILIAD.Focus()
        End If
        If Len(Trim(ComboBoxCHOFER.Text)) = 0 Then
            MsgBox("seleccione una movilidad", vbCritical, "Validar")
            ComboBoxCHOFER.Focus()
        End If
        If Len(Trim(EstadoTextBox.Text)) = 0 Then
            MsgBox("El campo ESTADO es obligatorio.", vbCritical, "Validación de Viaje")
            EstadoTextBox.Focus()
            Return
        End If
        If MsgBox("¿Desea ACTUALIZAR los cambios del viaje?", vbYesNo, "Confirmar ACTUALIZACIÓN") = vbYes Then
            Try
                Me.VIAJETableAdapter.ACTUALIZAR_VIAJE(
                    Convert.ToInt32(ComboBoxRUTA.SelectedValue),
                    Convert.ToInt32(ComboBoxMOVILIAD.SelectedValue),
                    Convert.ToInt32(ComboBoxCHOFER.SelectedValue),
                    FechaHoraSalidaDateTimePicker.Value,
                    EstadoTextBox.Text,
                    Convert.ToInt32(ID_ViajeTextBox.Text) ' <--- ID_Viaje va al final para la cláusula WHERE
                )
                MsgBox("Datos de Viaje ACTUALIZADOS correctamente", vbInformation, "Guardar")
                ' Recargar los datos después de la operación
                Me.VIAJETableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.VIAJE)
                GroupBoxviaje.Enabled = False
                btnEditar.Enabled = True
                btnNuevo.Enabled = True
                btn_actualizar.Enabled = False
            Catch ex As Exception
                MsgBox("Ocurrió un error al ACTUALIZAR los datos del viaje: " & ex.Message, vbCritical, "Error de Base de Datos")
            End Try
        End If
    End Sub
End Class