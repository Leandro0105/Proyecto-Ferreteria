Imports CapaComun
Imports CapaNegocio

Public Class FormCambiarPassword
    Dim modeloUsuario As New ModeloUsuario
    Private Sub FormCambiarPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = UsuarioActivo.UsuarioEnSesion
        TextBox1.Enabled = False
        Accion = "MODIFICACION"

    End Sub

    Public Sub New()
        InitializeComponent()
        AddHandlerTextBoxes()
        VerificarTextBoxes()
    End Sub

    Private Sub VerificarTextBoxes()
        Dim todosLlenos As Boolean = Me.Controls.OfType(Of TextBox)().All(Function(tb) Not String.IsNullOrWhiteSpace(tb.Text))
        If VerificarSiCoincidenLasContraseñas() Then
            btnGuardar.Enabled = todosLlenos

        Else
            btnGuardar.Enabled = False

        End If

    End Sub


    Private Sub AddHandlerTextBoxes()
        For Each txt As TextBox In Me.Controls.OfType(Of TextBox)()
            AddHandler txt.TextChanged, AddressOf VerificarTextBoxes
        Next
    End Sub

    Private Function VerificarSiCoincidenLasContraseñas() As Boolean
        If txtPassword.Text.Trim = txtConfirmarPassword.Text.Trim Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If VerificarSiCoincidenLasContraseñas() Then
            modeloUsuario.UltimoIdAuditoria()
            modeloUsuario.AgregarIdAuditoria(IdAuditoria, IdUsuario, Accion)
            modeloUsuario.CambiarPassword(UsuarioActivo.IdUsuario, txtConfirmarPassword.Text.Trim, False)
            Me.Close()
            txtPassword.Text = ""
            txtConfirmarPassword.Text = ""
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class