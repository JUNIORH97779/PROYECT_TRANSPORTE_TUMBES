Public Class GESTION_RUTAS
    Private Sub RUTABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RUTABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RUTABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._TRANSPORTE_TUMBESDataSet)

    End Sub

    Private Sub GESTION_RUTAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_TRANSPORTE_TUMBESDataSet.RUTA' Puede moverla o quitarla según sea necesario.
        Me.RUTATableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.RUTA)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        GroupBox1.Enabled = True
        btnEditar.Enabled = False
        btnDarDeBaja.Enabled = False
        btnNuevo.Enabled = False
        btn_guardar.Enabled = True

        ID_RutaTextBox.Clear()
        OrigenTextBox.Clear()
        DestinoTextBox.Clear()
        PrecioBaseTextBox.Clear()
        DuracionAprox_MinTextBox.Clear()

        OrigenTextBox.Focus()

    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        If Len(Trim(OrigenTextBox.Text)) = 0 Then
            MsgBox("Falta el origen", vbCritical)
            OrigenTextBox.Focus()
            Return
        End If

        If Len(Trim(DestinoTextBox.Text)) = 0 Then
            MsgBox("Falta el destino", vbCritical)
            DestinoTextBox.Focus()
            Return
        End If
        Dim precioFinal As Decimal
        If Not Decimal.TryParse(PrecioBaseTextBox.Text, precioFinal) Then
            MsgBox("El precio no es válido", vbCritical)
            Return
        End If
        Dim duracionFinal As Integer
        If Len(Trim(DuracionAprox_MinTextBox.Text)) = 0 Or Not Integer.TryParse(DuracionAprox_MinTextBox.Text, duracionFinal) Then
            MsgBox("La duración debe ser un número entero", vbCritical)
            Return
        End If
        Dim idRuta As Integer
        If Len(Trim(ID_RutaTextBox.Text)) = 0 Or Not Integer.TryParse(ID_RutaTextBox.Text, idRuta) Then
            MsgBox("No se ha seleccionado ninguna ruta para editar (Falta ID)", vbCritical)
            Return
        End If
        If MsgBox("¿Desea modificar el registro seleccionado?", vbYesNo + vbQuestion, "Confirmar Edición") = vbYes Then
            Try
                Me.RUTATableAdapter.ACTUALIZAR_RUTA(
                OrigenTextBox.Text,      ' 1. Origen
                DestinoTextBox.Text,     ' 2. Destino
                precioFinal,             ' 3. Precio (Decimal)
                duracionFinal,           ' 4. Duración (Entero)
                True,                    ' 5. Estado (Bit/Boolean)
                idRuta                   ' 6. ID (WHERE ID = @ID) -> AL FINAL
            )
                MsgBox("Datos actualizados correctamente", vbInformation, "Editar")
                Me.RUTATableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.RUTA)
                GroupBox1.Enabled = False
                btnEditar.Enabled = True
                btnDarDeBaja.Enabled = True
                btnNuevo.Enabled = True
                btn_guardar.Enabled = False
                btn_actualizar.Enabled = False
            Catch ex As Exception
                MsgBox("Error al actualizar: " & ex.Message, vbCritical)
            End Try
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        GroupBox1.Enabled = True
        btnEditar.Enabled = False
        btnDarDeBaja.Enabled = True
        btnNuevo.Enabled = False
        btn_actualizar.Enabled = True
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

        If Len(Trim(OrigenTextBox.Text)) = 0 Then
            MsgBox("Escriba un origen", vbCritical, "Validar")
            OrigenTextBox.Focus()
            Return
        End If
        If Len(Trim(DestinoTextBox.Text)) = 0 Then
            MsgBox("Escriba un destino", vbCritical, "Validar")
            DestinoTextBox.Focus()
            Return
        End If
        Dim precioFinal As Decimal
        If Not Decimal.TryParse(PrecioBaseTextBox.Text, precioFinal) Then
            MsgBox("Por favor, ingrese un monto válido en el precio.", vbCritical, "Validar")
            PrecioBaseTextBox.Focus()
            Return
        End If
        Dim duracionFinal As Integer
        ' Usamos Integer.TryParse para asegurar que sea un número entero válido
        If Len(Trim(DuracionAprox_MinTextBox.Text)) = 0 Or Not Integer.TryParse(DuracionAprox_MinTextBox.Text, duracionFinal) Then
            MsgBox("Ingrese una duración válida en minutos (solo números enteros)", vbCritical, "Validar")
            DuracionAprox_MinTextBox.Focus()
            Return
        End If
        If MsgBox("¿Desea guardar los cambios?", vbYesNo + vbQuestion, "Confirmar") = vbYes Then
            Try
                ' Enviamos los parámetros en el orden de tu tabla SQL:
                ' 1. Origen (varchar)
                ' 2. Destino (varchar)
                ' 3. PrecioBase (decimal) -> variable precioFinal
                ' 4. DuracionAprox (int)  -> variable duracionFinal
                ' 5. Estado (bit)         -> True
                Me.RUTATableAdapter.GUARDAR_RUTA(OrigenTextBox.Text, DestinoTextBox.Text, precioFinal, duracionFinal, True)
                MsgBox("Datos guardados correctamente", vbInformation, "Guardar")
                Me.RUTATableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.RUTA)
                GroupBox1.Enabled = False
                btnEditar.Enabled = True
                btnDarDeBaja.Enabled = False
                btnNuevo.Enabled = True
                btn_guardar.Enabled = False
            Catch ex As Exception
                MsgBox("Error al guardar en la base de datos: " & ex.Message, vbCritical)
            End Try
        End If
    End Sub

    Private Sub ID_RutaLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDarDeBaja_Click(sender As Object, e As EventArgs) Handles btnDarDeBaja.Click
        Dim idParaBorrar As String = ID_RutaTextBox.Text
        If String.IsNullOrEmpty(idParaBorrar) Then
            MsgBox("Por favor, selecciona una ruta de la lista primero.", vbExclamation, "Atención")
            Exit Sub
        End If
        If MsgBox("¿Está seguro de dar de baja la ruta con ID " & idParaBorrar & "?", vbYesNo + vbExclamation, "Confirmar Baja") = vbYes Then
            Try
                Dim idNumerico As Integer = CInt(idParaBorrar)
                Me.RUTATableAdapter.DAR_DE_BAJA_RUTA(idNumerico)
                MsgBox("Ruta dada de baja correctamente.", vbInformation, "Éxito")
                Me.RUTATableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.RUTA)
                ID_RutaTextBox.Clear()
                OrigenTextBox.Clear()
                DestinoTextBox.Clear()
                PrecioBaseTextBox.Clear()
                DuracionAprox_MinTextBox.Clear()
                GroupBox1.Enabled = False
                btnEditar.Enabled = True
                btnDarDeBaja.Enabled = False
                btnNuevo.Enabled = True
                btn_actualizar.Enabled = False
            Catch ex As Exception
                MsgBox("Error al eliminar: " & ex.Message, vbCritical)
            End Try
        End If
    End Sub
End Class