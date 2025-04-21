Imports CapaNegocio
Imports System.Runtime.InteropServices
Imports System.Drawing.Drawing2D


Public Class FormInicioSesion
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

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Dim modeloUsuario As New ModeloUsuario
        Dim validarusario = modeloUsuario.ValidarUsario(txtUsuario.Text.Trim, txtPassword.Text.Trim)
        If validarusario = True Then
            FormMenuPrincipal.Show()
            txtUsuario.Clear()
            txtPassword.Clear()
            Me.Hide()
        Else
            MsgBox("Error en el inicio de sesion, verifique los datos ingresados o consulte con su administrador de base de datos!")
        End If
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
End Class