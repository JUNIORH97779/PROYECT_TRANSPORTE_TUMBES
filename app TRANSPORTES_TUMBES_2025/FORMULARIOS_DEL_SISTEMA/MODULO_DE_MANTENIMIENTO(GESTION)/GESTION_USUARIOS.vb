Public Class GESTION_USUARIOS
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub USUARIOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles USUARIOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.USUARIOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._TRANSPORTE_TUMBESDataSet)

    End Sub

    Private Sub GESTION_USUARIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_TRANSPORTE_TUMBESDataSet.ROL' Puede moverla o quitarla según sea necesario.
        Me.ROLTableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.ROL)
        'TODO: esta línea de código carga datos en la tabla '_TRANSPORTE_TUMBESDataSet.USUARIO' Puede moverla o quitarla según sea necesario.

        Me.USUARIOTableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.USUARIO)
        Me.ROLTableAdapter.FillByListaRoles(Me._TRANSPORTE_TUMBESDataSet.ROL)
        ' 1. Origen de los datos (Tu tabla ROL que acabamos de llenar)
        ID_RolComboBox.DataSource = Me._TRANSPORTE_TUMBESDataSet.ROL
        ID_RolComboBox.DisplayMember = "NombreRol"
        ID_RolComboBox.ValueMember = "ID_Rol"
        ID_RolComboBox.SelectedIndex = -1

        ID_RolComboBox1.DataSource = Me._TRANSPORTE_TUMBESDataSet.ROL
        ID_RolComboBox1.DisplayMember = "NombreRol"
        ID_RolComboBox1.ValueMember = "ID_Rol"


    End Sub

    Private Sub btn_añadirRol_Click(sender As Object, e As EventArgs) Handles btn_añadirRol.Click

        Group_rol.Visible = True
        NombreRolTextBox.Clear()
        DescripcionTextBox.Clear()


    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Group_usuario.Visible = True
        btnNuevo.Enabled = False
        ID_UsuarioTextBox.Clear()
        NombreUsuarioTextBox.Clear()
        NombreCompletoTextBox.Clear()
        PasswordHashTextBox.Clear()
        ID_RolComboBox.SelectedIndex = -1

        NombreUsuarioTextBox.Focus()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Len(Trim(ID_RolComboBox.Text)) = 0 Then
            MsgBox("seleccione un rol", vbCritical, "Validar")
            ID_RolComboBox.Focus()
        End If
        If Len(Trim(NombreUsuarioTextBox.Text)) = 0 Then
            MsgBox("rellene este campo", vbCritical, "Validar")
            NombreUsuarioTextBox.Focus()
        End If
        If Len(Trim(PasswordHashTextBox.Text)) = 0 Then
            MsgBox("ponga una contraseña", vbCritical, "Validar")
            PasswordHashTextBox.Focus()
        End If

        If Len(Trim(NombreCompletoTextBox.Text)) = 0 Then
            MsgBox("rellene este campo", vbCritical, "Validar")
            NombreCompletoTextBox.Focus()
        End If

        ID_RolComboBox.Focus()


        If MsgBox("¿Desea guardar los cambios?", vbYesNo) = vbYes Then
            Me.USUARIOTableAdapter.GUARDAR_USUARIO(ID_RolComboBox.SelectedValue, NombreUsuarioTextBox.Text, PasswordHashTextBox.Text, NombreCompletoTextBox.Text, True)
            MsgBox("Datos guardados correctamente", vbInformation, "Guardar")
            Me.USUARIOTableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.USUARIO)
            Group_usuario.Visible = False
            btnNuevo.Enabled = True
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnNuevo.Enabled = True
        Group_usuario.Visible = False
    End Sub

    Private Sub btn_aceptarRol_Click(sender As Object, e As EventArgs) Handles btn_aceptarRol.Click
        If Len(Trim(NombreRolTextBox.Text)) = 0 Then
            MsgBox("rellene este campo", vbCritical, "Validar")
            NombreRolTextBox.Focus()
        End If
        If Len(Trim(DescripcionTextBox.Text)) = 0 Then
            MsgBox("rellene este campo", vbCritical, "Validar")
            DescripcionTextBox.Focus()
        End If

        NombreRolTextBox.Focus()

        If MsgBox("¿Desea guardar los cambios?", vbYesNo) = vbYes Then
            Me.ROLTableAdapter.GUARDAR_ROL(NombreRolTextBox.Text, DescripcionTextBox.Text)
            MsgBox("Datos guardados correctamente", vbInformation, "Guardar")
            Me.ROLTableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.ROL)
            Group_rol.Visible = False
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        btnEditar.Enabled = False
        Group_editarUSU.Visible = True
        NombreUsuarioTextBox.Focus()

    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        If Len(Trim(NombreUsuarioTextBox1.Text)) = 0 Then
            MsgBox("rellene el nombre de usuario", vbCritical, "Validar")
            NombreUsuarioTextBox1.Focus()
            Exit Sub
        End If
        If Len(Trim(PasswordHashTextBox1.Text)) = 0 Then
            MsgBox("rellene la contraseña", vbCritical, "Validar")
            PasswordHashTextBox1.Focus()
            Exit Sub
        End If
        If Len(Trim(NombreCompletoTextBox1.Text)) = 0 Then
            MsgBox("rellene el nombre completo", vbCritical, "Validar")
            NombreCompletoTextBox1.Focus()
            Exit Sub
        End If


        Dim idParaActualizar As String = ID_UsuarioTextBox1.Text
        If String.IsNullOrEmpty(idParaActualizar) Then
            MsgBox("Error: No se ha seleccionado ningún usuario.", vbExclamation)
            Exit Sub
        End If

        If MsgBox("¿Desea GUARDAR los cambios de este usuario?", vbYesNo + vbQuestion) = vbYes Then
            Try
                Dim idNumerico As Integer = CInt(idParaActualizar)
                Dim valorRol As Object = ID_RolComboBox1.SelectedValue

                If valorRol Is Nothing Then
                    MsgBox("¡ALERTA! El ComboBox del Rol está enviando NADA (Nothing).", vbCritical)
                    Exit Sub
                Else
                    MsgBox("El ComboBox va a enviar el Rol ID: " & valorRol.ToString(), vbInformation)
                End If
                Me.USUARIOTableAdapter.ACTUALIZAR_USUARIO(ID_RolComboBox1.SelectedValue, NombreUsuarioTextBox1.Text, PasswordHashTextBox1.Text, NombreCompletoTextBox1.Text, True, idNumerico)
                MsgBox("Datos actualizados correctamente.", vbInformation)
                Me.USUARIOTableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.USUARIO)
                Group_editarUSU.Visible = False
                btnEditar.Enabled = True
            Catch ex As Exception
                MsgBox("El error exacto es: " & ex.Message)
            End Try

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim idParaBorrar As String = ID_UsuarioTextBox1.Text
        If String.IsNullOrEmpty(idParaBorrar) Then
            MsgBox("Por favor, selecciona un usuario de la lista primero.", vbExclamation)
            Exit Sub
        End If
        If MsgBox("¿Está seguro de dar de baja al usuario con ID " & idParaBorrar & "?", vbYesNo + vbExclamation) = vbYes Then
            Try
                Dim idNumerico As Integer = CInt(idParaBorrar)
                Me.USUARIOTableAdapter.DAR_DE_BAJA_USUARIO(idNumerico)
                MsgBox("Usuario dado de baja correctamente.", vbInformation)
                Me.USUARIOTableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.USUARIO)
                ID_UsuarioTextBox1.Clear()
            Catch ex As Exception
                MsgBox("Error al eliminar: " & ex.Message, vbCritical)
            End Try

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        btnEditar.Enabled = True
        Group_editarUSU.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Group_rol.Visible = False
    End Sub

    Private Sub Group_rol_Enter(sender As Object, e As EventArgs) Handles Group_rol.Enter

    End Sub

    Private Sub Group_usuario_Enter(sender As Object, e As EventArgs) Handles Group_usuario.Enter

    End Sub
End Class