Imports CapaComun
Imports CapaDatos
Public Class ModeloProducto
    Dim daoProdcuto As New DAOProductos

    Public Sub InformacionMenuProductos()
        daoProdcuto.ContarProductos()
    End Sub

    Public Function CargarListadoProductos()
        Return daoProdcuto.CargarListadoProductos
    End Function

    Public Function NuevoIdProducto()
        Return daoProdcuto.ObtenerNuevoIdProducto
    End Function

    Public Function CargarCombo(query As String) As DataTable
        Return daoProdcuto.CargarCombos(query)
    End Function

    Public Sub AgragarProducto(idproducto As Integer, idproveedor As Integer, idmarca As Integer, idrubro As Integer, idsubrubro As Integer, codproveedor As String, codbarras As String, descripcion As String, preciocosto As Double, precioventa As Double, stock As Integer, estado As String)
        daoProdcuto.AgregarProducto(idproducto, idproveedor, idmarca, idrubro, idsubrubro, codproveedor, codbarras, descripcion, preciocosto, precioventa, stock, estado)
    End Sub

End Class
