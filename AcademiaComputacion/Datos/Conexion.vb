Imports System.Data.SqlClient
Public Class Conexion

    'variable de conexion 
    Protected cnn As New SqlConnection
    'Funcion para conectarse a la BD
    Protected Function conectado()
        Try
            'cadena de conexion
            cnn = New SqlConnection("data source = LAPTOPJULIAN\SERVER; initial catalog = academia; integrated security = true")
            'abrimos la conexion
            cnn.Open()
            'retornamos true si la cadena de conexion se abrio correctamente
            Return True
        Catch ex As Exception
            'mostrar el mensaje de error
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
    'funcion para desconectarte de la DB
    Protected Function desconectar()
        Try
            'verificamos si la conexion esta previamente abierta
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function




    Public Function EQToDataTable(ByVal parIList As System.Collections.IEnumerable) As System.Data.DataTable
        Dim ret As New System.Data.DataTable()
        Try
            Dim ppi As System.Reflection.PropertyInfo() = Nothing
            If parIList Is Nothing Then Return ret
            For Each itm In parIList
                If ppi Is Nothing Then
                    ppi = DirectCast(itm.[GetType](), System.Type).GetProperties()
                    For Each pi As System.Reflection.PropertyInfo In ppi
                        Dim colType As System.Type = pi.PropertyType
                        If (colType.IsGenericType) AndAlso
                           (colType.GetGenericTypeDefinition() Is GetType(System.Nullable(Of ))) Then colType = colType.GetGenericArguments()(0)
                        ret.Columns.Add(New System.Data.DataColumn(pi.Name, colType))
                    Next
                End If
                Dim dr As System.Data.DataRow = ret.NewRow
                For Each pi As System.Reflection.PropertyInfo In ppi
                    dr(pi.Name) = If(pi.GetValue(itm, Nothing) Is Nothing, DBNull.Value, pi.GetValue(itm, Nothing))
                Next
                ret.Rows.Add(dr)
            Next
            For Each c As System.Data.DataColumn In ret.Columns
                c.ColumnName = c.ColumnName.Replace("_", " ")
            Next
        Catch ex As Exception
            ret = New System.Data.DataTable()
        End Try
        Return ret
    End Function

End Class
