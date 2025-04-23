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
        lblIndex.Text = "Principal"
        btnMaximizar.Visible = False
        Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea
        Me.WindowState = FormWindowState.Maximized
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
        If Currentform IsNot Nothing Then
            RemoveHandler Currentform.FormClosed, AddressOf formhijocerrado
            Currentform.Close()
            PictureBoxLogo.Visible = True
            IconIndex.IconChar = FontAwesome.Sharp.IconChar.Home
            lblIndex.Text = "Principal"
        End If
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

    Private Currentform As Form = Nothing


    Private Sub AbrirFomEnPanel(formhijo As Form)
        'PanelContenedor.Controls.Clear()
        If Currentform IsNot Nothing Then
            RemoveHandler Currentform.FormClosed, AddressOf formhijocerrado
            Currentform.Close()
        End If
        PictureBoxLogo.Visible = False


        Currentform = formhijo
        formhijo.TopLevel = False
        formhijo.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(formhijo)
        PanelContenedor.Tag = formhijo

        AddHandler formhijo.FormClosed, AddressOf formhijocerrado
        formhijo.Show()


    End Sub

    Private Sub formhijocerrado(sender As Object, e As FormClosedEventArgs)
        Currentform = Nothing
        If MostrarHome = True Then
            PictureBoxLogo.Visible = True
            IconIndex.IconChar = FontAwesome.Sharp.IconChar.Home
            lblIndex.Text = "Principal"
        End If
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        IconIndex.IconChar = FontAwesome.Sharp.IconChar.User
        lblIndex.Text = "Usuarios"
        AbrirFomEnPanel(New FormMenuUsuario)
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        IconIndex.IconChar = FontAwesome.Sharp.IconChar.Users
        lblIndex.Text = "Clientes"
        AbrirFomEnPanel(New FormMenuClientes)
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        IconIndex.IconChar = FontAwesome.Sharp.IconChar.Truck
        lblIndex.Text = "Proveedores"
        AbrirFomEnPanel(New FormMenuProveedores)
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        IconIndex.IconChar = FontAwesome.Sharp.IconChar.Cubes
        lblIndex.Text = "Productos"
        AbrirFomEnPanel(New FormMenuProductos)
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        IconIndex.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        lblIndex.Text = "Compras"
        AbrirFomEnPanel(New FormMenuCompras)
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        IconIndex.IconChar = FontAwesome.Sharp.IconChar.Tags
        lblIndex.Text = "Ventas"
        AbrirFomEnPanel(New FormMenuVentas)
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        IconIndex.IconChar = FontAwesome.Sharp.IconChar.FilePdfO
        lblIndex.Text = "Reportes"
        AbrirFomEnPanel(New FormMenuReportes)
    End Sub
End Class