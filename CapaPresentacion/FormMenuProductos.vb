Imports CapaComun
Imports System.Runtime.InteropServices
Imports System.Drawing.Drawing2D
Imports CapaNegocio
Public Class FormMenuProductos

#Region "Personalizacion del FormProductos"
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CrearRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidhtEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr

    End Function

    Private Sub AjustarPaneles()
        Dim margenLateral As Integer = 20
        Dim espacioDisponible As Integer = PanelSuperior.Width - (margenLateral * 2)
        Dim espacioEntrePaneles As Integer = 35
        Dim anchoTotalEspacio As Integer = espacioEntrePaneles * 2
        Dim anchoPanel As Integer = (espacioDisponible - anchoTotalEspacio) / 3

        PanelInfo1.Width = anchoPanel
        PanelInfo2.Width = anchoPanel
        PanelInfo3.Width = anchoPanel

        PanelInfo1.Left = margenLateral
        PanelInfo2.Left = PanelInfo1.Right + espacioEntrePaneles
        PanelInfo3.Left = PanelInfo2.Right + espacioEntrePaneles
        Panel1.Width = PanelInfo1.Width
        Panel4.Width = PanelInfo2.Width
        Panel3.Width = PanelInfo3.Width
        CentrarLabelsEncabezados(Panel1)
        CentrarLabelsEncabezados(Panel3)
        CentrarLabelsEncabezados(Panel4)
        CentrarLabelsInfo(PanelInfo1)
        CentrarLabelsInfo(PanelInfo2)
        CentrarLabelsInfo(PanelInfo3)
        CentrarLabelDataGridView(PanelContenedor)


    End Sub

    Private Sub RedondearBoton(ByVal btn As Button)
        Dim radio As Integer = 35
        Dim path As New GraphicsPath
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, radio, radio), 180, 90)
        path.AddArc(New Rectangle(btn.Width - radio, 0, radio, radio), 270, 90)
        path.AddArc(New Rectangle(btn.Width - radio, btn.Height - radio, radio, radio), 0, 90)
        path.AddArc(New Rectangle(0, btn.Height - radio, radio, radio), 90, 90)
        path.CloseFigure()
        btn.Region = New Region(path)
    End Sub

    Private Sub AjustarAnchoColumnas()
        Dim anchoTotal As Integer = dgvListadoProductos.ClientSize.Width
        dgvListadoProductos.Columns(0).Width = CInt(anchoTotal * 0.1)
        dgvListadoProductos.Columns(1).Width = CInt(anchoTotal * 0.7)
        dgvListadoProductos.Columns(2).Width = CInt(anchoTotal * 0.1)
        dgvListadoProductos.Columns(3).Width = CInt(anchoTotal * 0.1)
        dgvListadoProductos.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvListadoProductos.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvListadoProductos.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvListadoProductos.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvListadoProductos.Columns(2).DefaultCellStyle.Format = "C2"
        dgvListadoProductos.Columns(3).DefaultCellStyle.Format = "C2"

    End Sub

    Private Sub CentrarLabelDataGridView(pnl As Panel)
        If pnl.Controls.Count > 0 Then
            Dim lbl As Label = TryCast(pnl.Controls(0), Label)
            If lbl IsNot Nothing Then
                lbl.Left = (pnl.Width - lbl.Width) / 2
            End If
        End If
    End Sub


    Private Sub CentrarLabelsEncabezados(pnl As Panel)
        If pnl.Controls.Count > 0 Then
            Dim lbl As Label = TryCast(pnl.Controls(0), Label)
            If lbl IsNot Nothing Then
                lbl.Left = (pnl.Width - lbl.Width) / 2
                lbl.Top = (pnl.Height - lbl.Height) / 2
            End If
        End If
    End Sub

    Private Sub CentrarLabelsInfo(pnl As Panel)
        If pnl.Controls.Count > 0 Then
            Dim lbl As Label = TryCast(pnl.Controls(0), Label)
            If lbl IsNot Nothing Then
                lbl.Left = (pnl.Width - lbl.Width) / 2
                lbl.Top = ((pnl.Height + Panel1.Height) - lbl.Height) / 2
            End If
        End If
    End Sub

    Private Sub AplicarBordesRedondeados()
        Dim radio As Integer = 20
        PanelInfo1.Region = Region.FromHrgn(CrearRoundRectRgn(0, 0, PanelInfo1.Width, PanelInfo1.Height, radio, radio))
        PanelInfo2.Region = Region.FromHrgn(CrearRoundRectRgn(0, 0, PanelInfo2.Width, PanelInfo2.Height, radio, radio))
        PanelInfo3.Region = Region.FromHrgn(CrearRoundRectRgn(0, 0, PanelInfo3.Width, PanelInfo3.Height, radio, radio))
    End Sub

#End Region

    Dim modeloProducto As New ModeloProducto
    Private Sub IconoHome_Click(sender As Object, e As EventArgs) Handles IconoHome.Click
        MostrarHome = True
        Me.Close()
    End Sub

    Private Sub FormMenuProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RedondearBoton(btnAgregarProducto)
        RedondearBoton(btnActualizarProducto)
        RedondearBoton(btnEliminarProducto)
        RedondearBoton(btnActualizarListaPrecios)
        RedondearBoton(btnInventario)
        Call MostrarInfo()
        Call CargarProductos()
    End Sub

    Private Sub FormMenuProductos_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        AjustarPaneles()
        AplicarBordesRedondeados()
        AjustarAnchoColumnas()
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim f As New FormAltaProducto
        AddHandler FormAltaProducto.ProductoAgregado, AddressOf ActualizarGridProducto
        f.ShowDialog()

    End Sub

    Public Sub MostrarInfo()
        modeloProducto.InformacionMenuProductos()
        lblTotalProductos.Text = Producto.CantidadProductos
        lblProductosInactivos.Text = Producto.CantidaProductosInactivos
        lblProductoMasVendido.Text = Producto.ProductoMasVendido
    End Sub

    Public Sub CargarProductos()
        dgvListadoProductos.Columns(0).DataPropertyName = "IdProducto"
        dgvListadoProductos.Columns(1).DataPropertyName = "Descripcion"
        dgvListadoProductos.Columns(2).DataPropertyName = "PrecioCosto"
        dgvListadoProductos.Columns(3).DataPropertyName = "PrecioVenta"
        dgvListadoProductos.DataSource = modeloProducto.CargarListadoProductos
    End Sub

    Private Sub ActualizarGridProducto(sender As Object, e As EventArgs)
        CargarProductos()
    End Sub
End Class