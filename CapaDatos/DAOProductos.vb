Imports CapaComun
Imports System.Data.SqlClient
Public Class DAOProductos
    Inherits ConexionSQLServer

    Public Sub ContarProductos()
        Using ConexionSQLServer = GetConnection()
            ConexionSQLServer.Open()
            Using cmd, cmd1, cmd2 As New SqlCommand
                cmd.Connection = ConexionSQLServer
                cmd.CommandText = "Select Count (*) from Productos"
                cmd.CommandType = CommandType.Text
                Dim dr, dr1, dr2 As SqlDataReader
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    Producto.CantidadProductos = dr(0)
                End If
                dr.Close()

                cmd1.Connection = ConexionSQLServer
                cmd1.CommandText = "Select Count (*) from Productos where estado=@estado"
                cmd1.Parameters.AddWithValue("@estado", "INACTIVO")
                cmd1.CommandType = CommandType.Text
                dr1 = cmd1.ExecuteReader
                If dr1.HasRows Then
                    dr1.Read()
                    CantidaProductosInactivos = dr1(0)
                Else
                    CantidaProductosInactivos = 0
                End If
                dr1.Close()

                cmd2.Connection = ConexionSQLServer
                cmd2.CommandText = "Select Top 1 p.descripcion , SUM(CAST(dv.cantidad AS INT)) as cantidadtotalVendida from DetalleVentas dv inner join Productos p on dv.idproducto=p.idproducto group by p.descripcion order by cantidadtotalVendida desc"
                cmd2.CommandType = CommandType.Text
                dr2 = cmd2.ExecuteReader
                If dr2.HasRows Then
                    dr2.Read()
                    ProductoMasVendido = dr2(0)
                End If
            End Using
        End Using
    End Sub


    Public Function CargarListadoProductos() As DataTable
        Dim dt As New DataTable
        Dim consulta As String = "select IdProducto, Descripcion, PrecioCosto, PrecioVenta from Productos order by idProducto desc"
        Try
            Using Conexion As SqlConnection = GetConnection()
                Conexion.Open()
                Using adaptador As New SqlDataAdapter(consulta, Conexion)
                    adaptador.Fill(dt)
                End Using

            End Using

        Catch ex As Exception
            Throw New Exception("Error al obtener los Productos", ex)
        End Try
        Return dt
    End Function

    Public Function ObtenerNuevoIdProducto()
        Using ConexionSQLServer = GetConnection()
            ConexionSQLServer.Open()
            Using cmd As New SqlCommand
                cmd.Connection = ConexionSQLServer
                cmd.CommandText = "select idProducto from Productos order by idProducto desc"
                cmd.CommandType = CommandType.Text
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    Producto.IdProducto = dr.GetInt32(0) + 1
                    Return IdProducto
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Public Function CargarCombos(query As String) As DataTable
        Dim dt As New DataTable
        Dim consulta As String = query
        Try
            Using Conexion As SqlConnection = GetConnection()
                Conexion.Open()
                Using adaptador As New SqlDataAdapter(consulta, Conexion)
                    adaptador.Fill(dt)
                End Using

            End Using

        Catch ex As Exception
            Throw New Exception("Error al cargar los ComboBoxes", ex)
        End Try
        Return dt
    End Function

    Public Sub AgregarProducto(idproducto As Integer, idproveedor As Integer, idmarca As Integer, idrubro As Integer, idsubrubro As Integer, codproveedor As String, codbarras As String, descripcion As String, preciocosto As Double, precioventa As Double, stock As Integer, estado As String)
        Using ConexionSQLServer = GetConnection()
            ConexionSQLServer.Open()
            Using comando As New SqlCommand
                comando.Connection = ConexionSQLServer
                comando.CommandText = "SP_InsertarProducto"
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@IdProducto", idproducto)
                comando.Parameters.AddWithValue("@IdProveedor", idproveedor)
                comando.Parameters.AddWithValue("@IdMarca", idmarca)
                comando.Parameters.AddWithValue("@IdRubro", idrubro)
                comando.Parameters.AddWithValue("@IdSubrubro", idsubrubro)
                comando.Parameters.AddWithValue("@CodigoProveedor", codproveedor)
                comando.Parameters.AddWithValue("@CodigoBarras", codbarras)
                comando.Parameters.AddWithValue("@Descripcion", descripcion)
                comando.Parameters.AddWithValue("@PrecioCosto", preciocosto)
                comando.Parameters.AddWithValue("@PrecioVenta", precioventa)
                comando.Parameters.AddWithValue("@Stock", stock)
                comando.Parameters.AddWithValue("@Estado", estado)
                Try
                    comando.ExecuteNonQuery()
                    MsgBox("El Producto se ingreso correctamente" & idproducto & ", " & descripcion & ".", MsgBoxStyle.Information, "Carga Exitosa")
                Catch ex As Exception
                    MsgBox("Ocurrio un error inesperado." + ex.ToString)
                End Try

            End Using
        End Using
    End Sub

End Class
