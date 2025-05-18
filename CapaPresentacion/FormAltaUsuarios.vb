Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports CapaNegocio
Imports CapaComun
Public Class FormAltaUsuarios
    Dim modeloNegocioUsuario As New ModeloUsuario
#Region "Personalizacion del Form"

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

    Private Sub FormAltaUsuarios_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CrearRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidhtEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr

    End Function

#End Region
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkUsuarioActivo.CheckedChanged

    End Sub

    Private Sub FormAltaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCorreoValido.Visible = False
        lblUsuarioValido.Visible = False
        Call CargarPermisos()
        If modeloNegocioUsuario.ObtenerNuevoIdUsuario Then
            lblIdUsuario.Text = UsuarioActivo.NuevoIdUsuario
        Else
            MsgBox("Ocurrio un error inesperado. Por favor verifique la consulta SQL", MsgBoxStyle.Exclamation, "Error al obtener el nuevo IdUsuario")
        End If
        chkCambiarContraseña.Checked = True
        chkUsuarioActivo.Checked = True
    End Sub

    Private Sub CargarPermisos()
        Try
            Dim dt As DataTable = modeloNegocioUsuario.ListarPermisos
            Dim fila As DataRow = dt.NewRow
            fila("IdPermisos") = 0
            fila("NombrePermiso") = "-Seleccione una Categoria-"
            dt.Rows.InsertAt(fila, 0)
            cboPermiso.DataSource = dt
            cboPermiso.DisplayMember = "nombrepermiso"
            cboPermiso.ValueMember = "idpermisos"
            cboPermiso.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Error al cargar los Permisos" & ex.Message)
        End Try
    End Sub
    Private Sub btnCerrarr_Click(sender As Object, e As EventArgs) Handles btnCerrarr.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub txtCorreo_TextChanged(sender As Object, e As EventArgs) Handles txtNuevoCorreoU.TextChanged
        If txtNuevoCorreoU.Text <> "" Then
            lblCorreoValido.Visible = True
            If ValidarCorreo(txtNuevoCorreoU.Text.Trim) Then
                lblCorreoValido.ForeColor = Color.Green
                lblCorreoValido.Text = "El Correo ingresado es Valido."
            Else
                lblCorreoValido.ForeColor = Color.Red
                lblCorreoValido.Text = "Verifique la dirección de Correo ingresado. Corrreo No Valido"
            End If
        Else
            lblCorreoValido.Visible = False
        End If

    End Sub

    Private Function ValidarCorreo(correo As String) As Boolean

        Dim patron As String = "^[\w\.-]+@([\w\.-]+\.\w{2,})$"
        Dim match As Match = Regex.Match(correo, patron)

        If match.Success Then
            Dim dominio As String = correo.Split("@"c)(1).ToLower
            Dim DominiosPermitidos() As String = {"gmail.com", "hotmail.com", "outlook.com"}
            Return DominiosPermitidos.Contains(dominio)
        End If

        Return False

    End Function


    Public Sub New()
        InitializeComponent()
        AddHandlerTextBoxes()
        AddHandler cboPermiso.SelectedIndexChanged, AddressOf VerificarCondiciones
        VerificarCondiciones()
    End Sub

        Private Sub AddHandlerTextBoxes()
            For Each txt As TextBox In Me.Controls.OfType(Of TextBox)()
                AddHandler txt.TextChanged, AddressOf VerificarCondiciones
            Next
        End Sub

    Private Sub VerificarCondiciones()
        Dim todosLlenos As Boolean = Me.Controls.OfType(Of TextBox)().All(Function(txt) Not String.IsNullOrWhiteSpace(txt.Text))
        Dim condicionEspecial As Boolean
        Dim comboSeleccionado As Boolean = cboPermiso.SelectedIndex <> 0
        If lblCorreoValido.Text = "El Correo ingresado es Valido." Then
            condicionEspecial = True
        End If

        btnAceptar.Enabled = todosLlenos And condicionEspecial And comboSeleccionado
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If chkCambiarContraseña.Checked = True Then
            UsuarioActivo.CambiarPassword = True
        Else
            UsuarioActivo.CambiarPassword = False
        End If
        If chkUsuarioActivo.Checked = True Then
            UsuarioActivo.NuevoEstado = "ACTIVO"
        Else
            UsuarioActivo.NuevoEstado = "INACTIVO"
        End If
        Accion = "ALTA"
        ProcesarAltaUsuario()
    End Sub

    Public Sub ProcesarAltaUsuario()
        modeloNegocioUsuario.UltimoIdAuditoria()
        modeloNegocioUsuario.AgregarIdAuditoria(IdAuditoria, IdUsuario, Accion)
        modeloNegocioUsuario.AgregarUsuario(CInt(lblIdUsuario.Text), cboPermiso.SelectedValue, txtNuevoNombreU.Text.Trim, txtNuevoApellidoU.Text.Trim, txtNuevoUsuarioU.Text.Trim, txtNuevoPasswordU.Text.Trim, txtNuevoCorreoU.Text.Trim, UsuarioActivo.NuevoEstado, UsuarioActivo.CambiarPassword)
        Call LimpiarTextBoxes(Me)
        modeloNegocioUsuario.ObtenerNuevoIdUsuario()
        lblIdUsuario.Text = UsuarioActivo.NuevoIdUsuario
        cboPermiso.SelectedIndex = 0
    End Sub

    Private Sub txtNuevoUsuarioU_TextChanged(sender As Object, e As EventArgs) Handles txtNuevoUsuarioU.TextChanged
        If txtNuevoUsuarioU.Text <> "" Then
            lblUsuarioValido.Visible = True
            If modeloNegocioUsuario.VerificarSiExisteUsuario(txtNuevoUsuarioU.Text.Trim) Then
                lblUsuarioValido.ForeColor = Color.Red
                lblUsuarioValido.Text = "Verifique el Usuario ingresado. El Usuario ya esta Registrado en su Base de Datos"
            Else
                lblUsuarioValido.ForeColor = Color.Green
                lblUsuarioValido.Text = "El Usuario ingresado es Valido."
            End If
        Else
            lblUsuarioValido.Visible = False
        End If
    End Sub

    Sub LimpiarTextBoxes(ByVal formulario As Form)
        For Each control As Control In formulario.Controls
            If TypeOf control Is TextBox Then
                CType(control, TextBox).Clear()
            End If
        Next
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Call LimpiarTextBoxes(Me)
        cboPermiso.SelectedIndex = 0
        chkCambiarContraseña.Checked = False
        chkUsuarioActivo.Checked = False
    End Sub
End Class