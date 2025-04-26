Imports CapaComun
Imports System.Runtime.InteropServices
Public Class FormMenuUsuario

#Region "Personalizacion del FormUsuarios"
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
    Private Sub FormMenuUsuario_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        AjustarPaneles()
        AplicarBordesRedondeados()
    End Sub



    Private Sub IconoHome_Click(sender As Object, e As EventArgs) Handles IconoHome.Click
        MostrarHome = True
        Me.Close()
    End Sub

    Private Sub FormMenuUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class