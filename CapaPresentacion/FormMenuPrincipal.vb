Public Class FormMenuPrincipal
    Private Sub FormMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub FormMenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Esta seguro que desea cerrar completamente?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
        Else
            FormInicioSesion.Close()
        End If
    End Sub
End Class