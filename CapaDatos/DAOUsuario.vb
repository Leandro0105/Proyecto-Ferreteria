Imports System.Data
Imports System.Data.SqlClient
Imports CapaComun

Public Class DAOUsuario
    Inherits ConexionSQLServer

    Public Function ValidarUsuario(usuario As String, password As String) As Boolean
        Using ConexionSQLServer = GetConnection()
            ConexionSQLServer.Open()
            Using comando = New SqlCommand
                comando.Connection = ConexionSQLServer
                comando.CommandText = "SP_ValidarUsuario"
                comando.Parameters.AddWithValue("@usuario", usuario)
                comando.Parameters.AddWithValue("@password", password)
                comando.CommandType = CommandType.StoredProcedure
                Dim lector = comando.ExecuteReader
                If lector.HasRows Then
                    lector.Read()
                    If lector.GetString(0) = "ACTIVO" Then
                        UsuarioActivo.Permiso = lector.GetString(3)
                        UsuarioActivo.Nombres = lector.GetString(1)
                        UsuarioActivo.Apellidos = lector.GetString(2)
                        UsuarioActivo.CambiarPassword = lector.GetBoolean(4)
                        UsuarioActivo.IdUsuario = lector.GetInt32(5)
                        lector.Dispose()
                        Return True
                    Else
                        UsuarioActivo.EstadoUsuario = lector.GetString(0)

                        Return False
                    End If

                Else
                    If VerificarUsuario(usuario) Then
                        UsuarioActivo.UsuarioEnSesion = True
                    Else
                        UsuarioActivo.EstadoUsuario = Nothing

                    End If
                    Return False

                End If

            End Using
        End Using
    End Function

    Public Function ObtenerIdUsuario()
        Using ConexionSQLServer = GetConnection()
            ConexionSQLServer.Open()
            Using cmd As New SqlCommand
                cmd.Connection = ConexionSQLServer
                cmd.CommandText = "select idUsuario from Usuarios order by idUsuario desc"
                cmd.CommandType = CommandType.Text
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    UsuarioActivo.NuevoIdUsuario = dr.GetInt32(0) + 1
                    Return NuevoIdUsuario
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Public Function CargarComboPermiso() As DataTable
        Dim dt As New DataTable
        Dim consulta As String = "select * from permisos"
        Try
            Using Conexion As SqlConnection = GetConnection()
                Conexion.Open()
                Using adaptador As New SqlDataAdapter(consulta, Conexion)
                    adaptador.Fill(dt)
                End Using

            End Using

        Catch ex As Exception
            Throw New Exception("Error al obtener los Permisos", ex)
        End Try
        Return dt
    End Function

    Public Function VerificarUsuario(nuevousuario As String)
        Using ConexionSQLServer = GetConnection()
            ConexionSQLServer.Open()

            Using cmd As New SqlCommand
                cmd.Connection = ConexionSQLServer
                cmd.CommandText = "select idusuario, estado,usuario from Usuarios where usuario = @usuario "
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@usuario", nuevousuario)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    UsuarioActivo.IdUsuario = dr.GetInt32(0)
                    UsuarioActivo.EstadoUsuario = dr.GetString(1)
                    Return True
                Else
                    Return False
                End If

            End Using
        End Using
    End Function

    Public Sub CambiarPassword(IdUsuario As Integer, clave As String, cambiarpassword As Boolean)
        Using ConexionSQLServer = GetConnection()
            ConexionSQLServer.Open()
            Using cmd As New SqlCommand
                cmd.Connection = ConexionSQLServer
                cmd.CommandText = "SP_CambiarPassword"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario)
                cmd.Parameters.AddWithValue("@Password", clave)
                cmd.Parameters.AddWithValue("@CambiarPassword", cambiarpassword)
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("El cambio de Password se realizo exitosamente", MsgBoxStyle.Information, "Cambio de Password Exitoso")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            End Using
        End Using
    End Sub

    Public Sub BloquearUsuario(idUsuario As Integer)
        Using ConexionSQLServer = GetConnection()
            ConexionSQLServer.Open()
            Using cmd As New SqlCommand
                cmd.Connection = ConexionSQLServer
                cmd.CommandText = "SP_BloquearUsuario"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario)
                cmd.Parameters.AddWithValue("@Estado", "BLOQUEADO")
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Ha realizado 3 intentos!" + vbNewLine + "Su Usuario ha sido Bloqueado por cuestión de seguridad." + vbNewLine + "Comuniquese con el Administrador de Usuarios para Volver a Activar su Usuario", MsgBoxStyle.Critical, "Ha realizado 3 intentos Fallidos!")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Public Sub AgregarUsuario(idusuario As Integer, idpermiso As Integer, nombres As String, apellidos As String, usario As String, clave As String, correo As String, estado As String, cambiarclave As Boolean)
        Using ConexionSQLServer = GetConnection()
            ConexionSQLServer.Open()
            Using cmd As New SqlCommand
                cmd.Connection = ConexionSQLServer
                cmd.CommandText = "SP_InsertarUsuario"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IdUsuario", idusuario)
                cmd.Parameters.AddWithValue("@IdPermiso", idpermiso)
                cmd.Parameters.AddWithValue("@Nombres", nombres)
                cmd.Parameters.AddWithValue("@Apellidos", apellidos)
                cmd.Parameters.AddWithValue("@Usuario", usario)
                cmd.Parameters.AddWithValue("@Password", clave)
                cmd.Parameters.AddWithValue("@Correo", correo)
                cmd.Parameters.AddWithValue("@Estado", estado)
                cmd.Parameters.AddWithValue("@CambiarPassword", cambiarclave)
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Se ha ingresado con exito el usuario: " & NuevoIdUsuario & ", " & NuevoApellidoUsuario & " " & NuevoNombreUsuario, MsgBoxStyle.Information, "Alta Usuario Exitosa")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using

    End Sub

    Public Sub UltimoIdAuditoria()
        Using ConexionSQLServer = GetConnection()
            ConexionSQLServer.Open()
            Using comando As New SqlCommand
                comando.Connection = ConexionSQLServer
                comando.CommandText = "Select IdAuditoria from Auditorias order by IdAuditoria desc"
                comando.CommandType = CommandType.Text
                Dim dr As SqlDataReader
                dr = comando.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    UsuarioActivo.IdAuditoria = dr.GetInt32(0) + 1
                End If
            End Using
        End Using
    End Sub

    Public Sub AgregarRegistroAuditoria(idauditoria As Integer, idusuario As Integer, accion As String)
        Using ConexionSQLServer = GetConnection()
            ConexionSQLServer.Open()
            Using cmd As New SqlCommand
                cmd.Connection = ConexionSQLServer
                cmd.CommandText = "SP_AgregarIdAuditoria"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IdAuditoria", idauditoria)
                cmd.Parameters.AddWithValue("@IdUsuario", idusuario)
                cmd.Parameters.AddWithValue("@Accion", accion)
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try


            End Using
        End Using

    End Sub

    Public Sub AgregarRegistroAuditoriaCambiarContraseña(idauditoria As Integer, idusuario As Integer, accion As String)
        Using ConexionSQLServer = GetConnection()
            ConexionSQLServer.Open()
            Using cmd As New SqlCommand
                cmd.Connection = ConexionSQLServer
                cmd.CommandText = "SP_AgregarIdAuditoria"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IdAuditoria", idauditoria)
                cmd.Parameters.AddWithValue("@IdUsuario", idusuario)
                cmd.Parameters.AddWithValue("@Accion", accion)
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try


            End Using
        End Using

    End Sub

    Public Function CargarListadoUsuarios() As DataTable
        Dim dt As New DataTable
        Dim consulta As String = "select apellidos, nombres from Usuarios order by idusuario desc"
        Try
            Using Conexion As SqlConnection = GetConnection()
                Conexion.Open()
                Using adaptador As New SqlDataAdapter(consulta, Conexion)
                    adaptador.Fill(dt)
                End Using

            End Using

        Catch ex As Exception
            Throw New Exception("Error al obtener los Usuarios", ex)
        End Try
        Return dt
    End Function

    Public Sub ContarUsuarios()
        Using ConexionSQLServer = GetConnection()
            ConexionSQLServer.Open()
            Using cmd, cmd1, cmd2 As New SqlCommand
                cmd.Connection = ConexionSQLServer
                cmd.CommandText = "Select count (*) from usuarios"
                cmd.CommandType = CommandType.Text

                cmd1.Connection = ConexionSQLServer
                cmd1.CommandText = "Select count (*) from usuarios where estado=@estado"
                cmd1.Parameters.AddWithValue("@estado", "BLOQUEADO")
                cmd1.CommandType = CommandType.Text

                cmd2.Connection = ConexionSQLServer
                cmd2.CommandText = "Select count (*) from usuarios WHERE estado=@estado1"
                cmd2.Parameters.AddWithValue("@estado1", "INACTIVO")
                cmd2.CommandType = CommandType.Text

                Dim dr, DR1, DR2 As SqlDataReader
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    CantidadUsuarios = dr(0)
                End If
                dr.Close()
                DR1 = cmd1.ExecuteReader
                If DR1.HasRows Then
                    DR1.Read()
                    CantidadUsuariosBloqueados = DR1(0)
                Else
                    CantidadUsuariosBloqueados = 0
                End If
                DR1.Close()
                DR2 = cmd2.ExecuteReader
                If DR2.HasRows Then
                    DR2.Read()
                    CantidadUsuariosInactivos = DR2(0)
                Else
                    CantidadUsuariosInactivos = 0
                End If
                DR2.Close()

            End Using
        End Using
    End Sub

End Class
