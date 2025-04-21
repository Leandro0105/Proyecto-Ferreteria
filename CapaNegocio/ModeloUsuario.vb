Imports CapaDatos

Public Class ModeloUsuario
    Dim daoUsuario As New DAOUsuario
    Public Function ValidarUsario(usuario As String, contraseña As String) As Boolean
        Return daoUsuario.ValidarUsuario(usuario, contraseña)
    End Function
End Class
