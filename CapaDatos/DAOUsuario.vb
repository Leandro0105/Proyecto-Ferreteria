Imports System.Data
Imports System.Data.SqlClient

Public Class DAOUsuario
    Inherits ConexionSQLServer

    Public Function ValidarUsuario(usuario As String, password As String) As Boolean
        Using ConexionSQLServer = GetConnection()
            ConexionSQLServer.Open()
            Using comando = New SqlCommand
                comando.Connection = ConexionSQLServer
                comando.CommandText = "Select estado from Usuarios where Usuario=@usuario and Password=@password "
                comando.Parameters.AddWithValue("@usuario", usuario)
                comando.Parameters.AddWithValue("@password", password)
                comando.CommandType = CommandType.Text
                Dim lector = comando.ExecuteReader
                If lector.HasRows Then
                    lector.Read()
                    If lector.GetString(0) = "ACTIVO" Then
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
