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
                        lector.Dispose()
                        Return True
                    Else
                        Return False
                    End If

                Else
                    Return False
                End If

            End Using
        End Using
    End Function



End Class
