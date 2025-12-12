Imports System.Data.SqlClient
Imports app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSet

Public Class INICIO_SESION

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Textcorreo.TextChanged
        'If String.IsNullOrWhiteSpace(Textcontraseña.Text) Then
        'sageBox.Show("El campo de usuario esta vacio")
        'End If
    End Sub

    Private Sub txtCorreo_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged
        'If String.IsNullOrWhiteSpace(Textcontraseña.Text) Then
        'MessageBox.Show("El campo de contraseña esta vacio")
        'End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cn As New SqlConnection("Data Source=ANDREMV\SQLEXPRESS;Initial Catalog=TRANSPORTE-TUMBES;Integrated Security=True;TrustServerCertificate=True")
        Dim Sql As String
        Sql = "select * from usuario where NombreUsuario = '" & Textcorreo.Text & "' and PasswordHash = '" & txtContraseña.Text & "' "
        Dim cmd As New SqlCommand(Sql, cn)
        Dim dr As SqlDataReader
        cn.Open()
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            MsgBox("Bienvenido al sistema")
            MENU_PRINCIPAL.Show()
        Else
            MsgBox("datos incorrectos")
        End If
    End Sub

    Private Sub INICIO_SESION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_TRANSPORTE_TUMBESDataSet.ROL' Puede moverla o quitarla según sea necesario.
        Me.ROLTableAdapter.Fill(Me._TRANSPORTE_TUMBESDataSet.ROL)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles ojo_abierto.Click
        ojo_cerrado.Visible = True
        ojo_abierto.Visible = False
        txtContraseña.PasswordChar = ""
    End Sub

    Private Sub ojo_cerrado_Click(sender As Object, e As EventArgs) Handles ojo_cerrado.Click
        ojo_cerrado.Visible = False
        ojo_abierto.Visible = True
        txtContraseña.PasswordChar = "*"
    End Sub
End Class