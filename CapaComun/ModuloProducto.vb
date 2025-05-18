Public Module Producto
    Public IdProducto
    Public IdProveedor
    Public IdMarca
    Public IdRubro
    Public IdSubrubro
    Public CodProveedor
    Public Descripcion
    Public PCosto
    Public PVenta
    Public Stock
    Public PEstado
    Public CantidadProductos
    Public CantidaProductosInactivos
    Public ProductoMasVendido
    Public querycboProv As String = "Select idproveedor, razonsocial from proveedores"
    Public querycboMarca As String = "Select idmarca, nombremarca from marcas"
    Public querycboRubro As String = "Select idrubro, nombrerubro from Rubros"
    Public querycboSubrubro As String = "Select idsubrubro, nombresubrubro from subrubros"


End Module
