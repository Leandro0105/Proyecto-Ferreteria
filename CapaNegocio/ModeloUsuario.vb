Imports CapaDatos

Public Class ModeloUsuario
    Dim daoUsuario As New DAOUsuario
    Public Function ValidarUsario(usuario As String, contraseña As String) As Boolean
        Return daoUsuario.ValidarUsuario(usuario, contraseña)
    End Function

    Public Function ListarPermisos() As DataTable
        Return daoUsuario.CargarComboPermiso
    End Function

    Public Function ObtenerNuevoIdUsuario()
        Return daoUsuario.ObtenerIdUsuario
    End Function

    Public Function VerificarSiExisteUsuario(usuariocreado As String)
        Return daoUsuario.VerificarUsuario(usuariocreado)
    End Function

    Public Sub CambiarPassword(idUsuario As Integer, clave As String, cambiarpassword As Boolean)
        daoUsuario.CambiarPassword(idUsuario, clave, cambiarpassword)
    End Sub

    Public Sub BloquearUsuario(IdUsuario As Integer)
        daoUsuario.BloquearUsuario(IdUsuario)
    End Sub

    Public Sub AgregarUsuario(idususario As Integer, idpermiso As Integer, nombres As String, apellidos As String, usario As String, clave As String, correo As String, estado As String, cambiarpassword As Boolean)
        daoUsuario.AgregarUsuario(idususario, idpermiso, nombres, apellidos, usario, clave, correo, estado, cambiarpassword)
    End Sub

    Public Sub UltimoIdAuditoria()
        daoUsuario.UltimoIdAuditoria()
    End Sub

    Public Sub AgregarIdAuditoria(idauditoria As Integer, idusuario As Integer, accion As String)
        daoUsuario.AgregarRegistroAuditoria(idauditoria, idusuario, accion)
    End Sub

    Public Sub AgregarIdAuditoriaCambiarContraseña(idauditoria As Integer, idusuario As Integer, accion As String)
        daoUsuario.AgregarRegistroAuditoria(idauditoria, idusuario, accion)
    End Sub

    Public Function CargarDatosUsuarios() As DataTable
        Return daoUsuario.CargarListadoUsuarios
    End Function

    Public Sub ContarUsuarios()
        daoUsuario.ContarUsuarios()
    End Sub

End Class
