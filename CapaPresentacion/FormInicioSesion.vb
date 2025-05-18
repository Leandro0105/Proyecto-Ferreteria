Imports CapaNegocio
Imports System.Runtime.InteropServices
Imports System.Drawing.Drawing2D
Imports CapaComun


Public Class FormInicioSesion


#Region "Funcionalidad del Form"
    <DllImport("user32.dll", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.dll", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub
#End Region

#Region "Seccion Eventos de los Elementos del Form"
    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        SeleccionarCasoInicioSesion()
    End Sub

    Private Sub BarraTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub FormInicioSesion_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnIniciarSesion_Paint(sender As Object, e As PaintEventArgs) Handles btnIniciarSesion.Paint
        Dim botonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim rectangulo As Rectangle = btnIniciarSesion.ClientRectangle
        rectangulo.Inflate(0, 30)
        botonPath.AddEllipse(rectangulo)
        btnIniciarSesion.Region = New Region(botonPath)
    End Sub

    Private Sub FormInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region

#Region "Procedimientos y Funciones Para el Form"
    Public Sub SeleccionarCasoInicioSesion()
        Dim modeloUsuario As New ModeloUsuario
        Dim validarusario = modeloUsuario.ValidarUsario(txtUsuario.Text.Trim, txtPassword.Text.Trim)

        If validarusario = True Then
            If UsuarioActivo.CambiarPassword = True Then
                UsuarioActivo.UsuarioEnSesion = txtUsuario.Text.Trim
                FormCambiarPassword.ShowDialog()
            Else
                UsuarioActivo.IntentosRestantes = Nothing
                FormMenuPrincipal.Show()
                txtUsuario.Clear()
                txtPassword.Clear()
                Me.Hide()
            End If


        ElseIf UsuarioActivo.EstadoUsuario = "BLOQUEADO" Then
            MsgBox("El Usuario ingresado se encuentra Bloqueado por cuestiones de seguridad." + vbNewLine + "Comuniquese con el Administrador para volver a Activarlo", MsgBoxStyle.Information, "Usuario Bloqueado")
            UsuarioEnSesion = False
        ElseIf UsuarioActivo.EstadoUsuario = "INACTIVO" Then
            MsgBox("El Usuario ingresado se encuentra Inactivo" + vbNewLine + "Verifiquesu Usuario en el Administrador y vuelva a intentarlo", MsgBoxStyle.Exclamation, "Usuario Inactivo")
            UsuarioEnSesion = False
        ElseIf UsuarioEnSesion = True Then
            If UsuarioActivo.EstadoUsuario = "BLOQUEADO" Then
                MsgBox("El Usuario ingresado se encuentra Bloqueado por cuestiones de seguridad." + vbNewLine + "Comuniquese con el Administrador para volver a Activarlo", MsgBoxStyle.Information, "Usuario Bloqueado")
                UsuarioActivo.UsuarioEnSesion = False
            ElseIf UsuarioActivo.EstadoUsuario = "INACTIVO" Then
                MsgBox("El Usuario ingresado se encuentra Inactivo" + vbNewLine + "Verifiquesu Usuario en el Administrador y vuelva a intentarlo", MsgBoxStyle.Exclamation, "Usuario Inactivo")
                UsuarioEnSesion = False
            ElseIf MsgBox("Error en el inicio de sesion, verifique los datos ingresados o consulte con su administrador de base de datos!") Then
                UsuarioActivo.IntentosRestantes = UsuarioActivo.IntentosRestantes + 1
                If UsuarioActivo.IntentosRestantes = 3 Then
                    modeloUsuario.BloquearUsuario(UsuarioActivo.IdUsuario)
                    UsuarioEnSesion = False
                End If

            End If


        Else
            MsgBox("El Usuario Ingresado NO EXISTE. Veriquelo y Vuelva a Intentarlo", MsgBoxStyle.Critical, "Usuario Inexistente!")

        End If
    End Sub

#End Region


End Class