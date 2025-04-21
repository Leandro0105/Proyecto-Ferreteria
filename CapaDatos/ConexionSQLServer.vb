Imports System.Data.Sql
Imports System.Data.SqlClient
Public MustInherit Class ConexionSQLServer
    Private connectionString As String
    Protected Sub New()
        connectionString = "Server = DESKTOP-D5HN4HP\SQLEXPRESS; DataBase =ModeloFerreteria; User=RemoteUser; Password=SISTEMAFERRETERIA; Integrated Security = true"
    End Sub
    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function

End Class
