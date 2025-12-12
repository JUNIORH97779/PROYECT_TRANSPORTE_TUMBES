Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Text
Module VALIDACION_ROL
    Public Class Conexion
        ' Cambia este nombre por el que tengas en tu app.config
        Private Const ConnectionName As String = "app_TRANSPORTES_TUMBES_2025.My.MySettings.TRANSPORTE_TUMBESConnectionString"

        Private ReadOnly _connectionString As String

        'Public Sub New()
        'Dim cs = ConfigurationManager.ConnectionStrings(ConnectionName)
        'If cs Is Nothing Then
        'Throw New InvalidOperationException("No se encontró la cadena de conexión en app.config: " & ConnectionName)
        'End If
        '_connectionString = cs.ConnectionString
        'End Sub

        Public Function CrearConexion() As SqlConnection
            Return New SqlConnection(_connectionString)
        End Function

        ' Ejecuta consulta y devuelve DataTable (para combos, grillas, etc.)
        Public Function EjecutarTabla(query As String, parametros As List(Of SqlParameter)) As DataTable
            Dim dt As New DataTable()
            Using cn = CrearConexion(), cmd As New SqlCommand(query, cn)
                If parametros IsNot Nothing Then cmd.Parameters.AddRange(parametros.ToArray())
                cn.Open()
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
            Return dt
        End Function
        ' Autenticar usuario: devuelve NombreRol y datos básicos si coincide Usuario + Password + Estado=1
        Public Function AutenticarUsuario(nombreUsuario As String, passwordTextoPlano As String) As (Exito As Boolean, NombreRol As String, NombreCompleto As String)
            ' Nota: Si luego guardas hash, reemplaza passwordTextoPlano por el hash que corresponda
            Dim sql As String =
            "SELECT r.NombreRol, u.NombreCompleto " &
            "FROM USUARIO u " &
            "INNER JOIN ROL r ON u.ID_Rol = r.ID_Rol " &
            "WHERE u.NombreUsuario = @usuario AND u.PasswordHash = @pass AND u.Estado = 1"

            Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@usuario", SqlDbType.VarChar, 50) With {.Value = nombreUsuario},
            New SqlParameter("@pass", SqlDbType.VarChar, 255) With {.Value = passwordTextoPlano}
        }

            Using cn = CrearConexion(), cmd As New SqlCommand(sql, cn)
                cmd.Parameters.AddRange(parametros.ToArray())
                cn.Open()
                Using rd = cmd.ExecuteReader()
                    If rd.Read() Then
                        Dim rol = rd("NombreRol").ToString()
                        Dim nombre = rd("NombreCompleto").ToString()
                        Return (True, rol, nombre)
                    End If
                End Using
            End Using

            Return (False, Nothing, Nothing)
        End Function
        ' Cargar roles: devuelve DataTable con ID_Rol y NombreRol para enlazar al ComboBox
        Public Function ObtenerRoles() As DataTable
            Dim sql As String = "SELECT ID_Rol, NombreRol FROM ROL ORDER BY NombreRol"
            Return EjecutarTabla(sql, Nothing)
        End Function
    End Class
End Module
