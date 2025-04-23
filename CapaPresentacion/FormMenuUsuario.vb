Imports CapaComun
Public Class FormMenuUsuario
    Private Sub FormMenuUsuario_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

    End Sub



    Private Sub IconoHome_Click(sender As Object, e As EventArgs) Handles IconoHome.Click
        MostrarHome = True
        Me.Close()
    End Sub


End Class