Imports System.Runtime.InteropServices
Imports CapaComun
Public Class FormMenuPrincipal
#Region "Movimientos del Form"
    <DllImport("user32.dll", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.dll", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub


    Private Sub PanelSuperior_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelSuperior.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PanelLateralIzquierdo_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelLateralIzquierdo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PanelContenedor_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelContenedor.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

#End Region


    Private Sub FormMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnRestaurar.Visible = False
        lblNombreUsuario.Text = UsuarioActivo.Apellidos + ", " + UsuarioActivo.Nombres
        If UsuarioActivo.Permiso = "SUPER USUARIO" Then
            lblPermiso.Text = "CEO SISTEMA"
        Else
            lblPermiso.Text = UsuarioActivo.Permiso
        End If
    End Sub


    Private Sub FormMenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Esta seguro que desea cerrar completamente?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
        Else
            FormInicioSesion.Close()
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MsgBox("Esta seguro que desea salir de la aplicación?", MsgBoxStyle.YesNo, "Confirme antes de Salir") = MsgBoxResult.Yes Then
            FormInicioSesion.Close()
        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea
        Me.WindowState = FormWindowState.Maximized
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Dim NuevaSesion As New FormInicioSesion
        If NuevaSesion.ShowDialog = DialogResult.OK Then

        Else
            Call MostrarDatosUsuario()
        End If
    End Sub

    Private Sub MostrarDatosUsuario()
        lblNombreUsuario.Text = UsuarioActivo.Apellidos + ", " + UsuarioActivo.Nombres
        If UsuarioActivo.Permiso = "SUPER USUARIO" Then
            lblPermiso.Text = "CEO SISTEMA"
        Else
            lblPermiso.Text = UsuarioActivo.Permiso
        End If
    End Sub
End Class