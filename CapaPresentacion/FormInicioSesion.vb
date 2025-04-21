Imports CapaNegocio

Public Class FormInicioSesion
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Dim modeloUsuario As New ModeloUsuario
        Dim validarusario = modeloUsuario.ValidarUsario(txtUsuario.Text.Trim, txtPassword.Text.Trim)
        If validarusario = True Then
            FormMenuPrincipal.Show()
            Me.Hide()
        Else
            MsgBox("Error en el inicio de sesion, verifique los datos ingresados o consulte con su administrador de base de datos!")
        End If
    End Sub
End Class