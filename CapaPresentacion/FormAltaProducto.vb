Imports CapaComun
Imports CapaNegocio
Imports System.Runtime.InteropServices
Public Class FormAltaProducto
#Region "Movimientos del form"
    <DllImport("user32.dll", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.dll", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
#End Region


    Dim modeloProducto As New ModeloProducto
    Dim modelousuario As New ModeloUsuario

    Public Event ProductoAgregado As EventHandler
    Public Sub New()
        InitializeComponent()
        AddHandlerTextBoxes()
        AddHandler cboProveedor.SelectedIndexChanged, AddressOf VerificarCondiciones
        AddHandler cboMarca.SelectedIndexChanged, AddressOf VerificarCondiciones
        AddHandler cboRubro.SelectedIndexChanged, AddressOf VerificarCondiciones
        AddHandler cboSubrubro.SelectedIndexChanged, AddressOf VerificarCondiciones
        VerificarCondiciones()
    End Sub

    Private Sub AddHandlerTextBoxes()
        For Each txt As TextBox In Me.Controls.OfType(Of TextBox)()
            AddHandler txt.TextChanged, AddressOf VerificarCondiciones
        Next
    End Sub

    Private Sub VerificarCondiciones()
        Dim todosLlenos As Boolean = Me.Controls.OfType(Of TextBox)().All(Function(txt) Not String.IsNullOrWhiteSpace(txt.Text))
        Dim comboSeleccionado As Boolean = cboProveedor.SelectedIndex <> 0 And cboMarca.SelectedIndex <> 0 And cboRubro.SelectedIndex <> 0 And cboSubrubro.SelectedIndex <> 0
        btnGuardar.Enabled = todosLlenos And comboSeleccionado
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrarr_Click(sender As Object, e As EventArgs) Handles btnCerrarr.Click
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub FormAltaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnGuardar.Enabled = False
        If modeloProducto.NuevoIdProducto Then
            lblIdProducto.Text = IdProducto
        Else
            lblIdProducto.Visible = False
        End If
        chkProductoActivo.Checked = True
        Call CargarCombos()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub CargarCombos()
        Try
            Dim dt As DataTable = modeloProducto.CargarCombo(querycboProv)
            Dim fila As DataRow = dt.NewRow
            fila("IdProveedor") = 0
            fila("RazonSocial") = "-Seleccione un Proveedor-"
            dt.Rows.InsertAt(fila, 0)
            cboProveedor.DataSource = dt
            cboProveedor.DisplayMember = "razonsocial"
            cboProveedor.ValueMember = "idproveedor"
            cboProveedor.SelectedIndex = 0

            Dim dt1 As DataTable = modeloProducto.CargarCombo(querycboMarca)
            Dim fila1 As DataRow = dt1.NewRow
            fila1("IdMarca") = 0
            fila1("NombreMarca") = "-Seleccione una Marca-"
            dt1.Rows.InsertAt(fila1, 0)
            cboMarca.DataSource = dt1
            cboMarca.DisplayMember = "nombremarca"
            cboMarca.ValueMember = "idmarca"
            cboMarca.SelectedIndex = 0

            Dim dt2 As DataTable = modeloProducto.CargarCombo(querycboRubro)
            Dim fila2 As DataRow = dt2.NewRow
            fila2("IdRubro") = 0
            fila2("NombreRubro") = "-Seleccione un Rubro-"
            dt2.Rows.InsertAt(fila2, 0)
            cboRubro.DataSource = dt2
            cboRubro.DisplayMember = "nombrerubro"
            cboRubro.ValueMember = "idrubro"
            cboRubro.SelectedIndex = 0

            Dim dt3 As DataTable = modeloProducto.CargarCombo(querycboSubrubro)
            Dim fila3 As DataRow = dt3.NewRow
            fila3("IdSubrubro") = 0
            fila3("NombreSubrubro") = "-Seleccione un Subrubro-"
            dt3.Rows.InsertAt(fila3, 0)
            cboSubrubro.DataSource = dt3
            cboSubrubro.DisplayMember = "nombresubrubro"
            cboSubrubro.ValueMember = "idsubrubro"
            cboSubrubro.SelectedIndex = 0


        Catch ex As Exception
            MessageBox.Show("Error al cargar los Combos" & ex.Message)
        End Try
    End Sub

    Sub LimpiarTextBoxes(ByVal formulario As Form)
        For Each control As Control In formulario.Controls
            If TypeOf control Is TextBox Then
                CType(control, TextBox).Clear()
            End If
        Next


    End Sub

    Public Sub ProcesarAltaUsuario()
        If chkProductoActivo.Checked = True Then
            PEstado = "ACTIVO"
        Else
            PEstado = "INACTIVO"
        End If
        Accion = "ALTA"
        modelousuario.UltimoIdAuditoria()
        modelousuario.AgregarIdAuditoria(IdAuditoria, IdUsuario, Accion)
        modeloProducto.AgragarProducto(CInt(lblIdProducto.Text), cboProveedor.SelectedValue, cboMarca.SelectedValue, cboRubro.SelectedValue, cboSubrubro.SelectedValue, txtCodigoProveedor.Text.Trim, txtCodigoBarras.Text.Trim, txtDescripcion.Text.Trim, txtPrecioCosto.Text.Trim, txtPrecioVenta.Text.Trim, CInt(txtStock.Text.Trim), Producto.PEstado)
        Call LimpiarTextBoxes(Me)
        modeloProducto.NuevoIdProducto()
        lblIdProducto.Text = Producto.IdProducto
        cboProveedor.SelectedIndex = 0
        cboMarca.SelectedIndex = 0
        cboRubro.SelectedIndex = 0
        cboSubrubro.SelectedIndex = 0
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call ProcesarAltaUsuario()
        RaiseEvent ProductoAgregado(Me, EventArgs.Empty)
        For Each F As Form In Application.OpenForms
            If TypeOf F Is FormMenuProductos Then
                CType(F, FormMenuProductos).CargarProductos()
                CType(F, FormMenuProductos).MostrarInfo()
            End If
        Next
    End Sub

    Private Sub txtPrecioCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioCosto.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        If e.KeyChar = "," AndAlso CType(sender, TextBox).Text.Contains(",") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecioVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioVenta.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        If e.KeyChar = "," AndAlso CType(sender, TextBox).Text.Contains(",") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStock.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cboRubro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRubro.SelectedIndexChanged
        If cboRubro.SelectedIndex <> 0 Then
            querycboSubrubro = "Select idsubrubro, nombresubrubro from subrubros where idrubro=" & cboRubro.SelectedValue
            Try
                Dim dt As DataTable = modeloProducto.CargarCombo(querycboSubrubro)
                Dim fila As DataRow = dt.NewRow
                fila("IdSubrubro") = 0
                fila("NombreSubrubro") = "-Seleccione un SubRubro-"
                dt.Rows.InsertAt(fila, 0)
                cboSubrubro.DataSource = dt
                cboSubrubro.DisplayMember = "nombresubrubro"
                cboSubrubro.ValueMember = "idsubrubro"
                cboSubrubro.SelectedIndex = 0
            Catch

                cboSubrubro.Items.Add("El Rubro NO contiene Subrubro")

            End Try
        End If
    End Sub

    Private Sub PanelSuperior_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelSuperior.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub FormAltaProducto_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub txtPrecioCosto_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioCosto.TextChanged

    End Sub
End Class