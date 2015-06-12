Imports System.Data.SqlClient
Imports System.Data.EntityClient
Module mdHerramientas

    Dim servidor As String = "WIN-UGPBN4AEOBC\SQLEXPRESS"
    Dim baseDatos As String = "academia"
    Dim usuario As String = "sa"
    Dim password As String = "Umg2015"
    Dim dirModelo As String = "Modelo"
    Public modelo As AcademiaEntities4
    Public usuarioLogueado As user
    Public mora As Boolean = False
    Public recibo As Boolean = True


    Public Function conexion() As Boolean
        Dim providerName As String = "System.Data.SqlClient"
        Dim serverName As String = servidor
        Dim databaseName As String = baseDatos

        ' Initialize the connection string builder for the 
        ' underlying provider. 
        Dim sqlBuilder As New SqlConnectionStringBuilder()

        ' Set the properties for the data source. 
        sqlBuilder.DataSource = serverName
        sqlBuilder.InitialCatalog = databaseName
        sqlBuilder.IntegratedSecurity = True
        sqlBuilder.UserID = usuario
        sqlBuilder.Password = password
        sqlBuilder.IntegratedSecurity = False
        sqlBuilder.MultipleActiveResultSets = True

        ' Build the SqlConnection connection string. 
        Dim providerString As String = sqlBuilder.ToString()

        ' Initialize the EntityConnectionStringBuilder. 
        Dim entityBuilder As New EntityConnectionStringBuilder()

        'Set the provider name. 
        entityBuilder.Provider = providerName

        ' Set the provider-specific connection string. 
        entityBuilder.ProviderConnectionString = providerString

        ' Set the Metadata location. 
        entityBuilder.Metadata = "res://*/" & dirModelo & ".csdl|res://*/" & dirModelo & ".ssdl|res://*/" & dirModelo & ".msl"
        Console.WriteLine(entityBuilder.ToString())

        Using conn As New EntityConnection(entityBuilder.ToString())
            conn.Open()
            Console.WriteLine("Just testing the connection.")
            modelo = New AcademiaEntities4(entityBuilder.ConnectionString)

            conn.Close()
            Return True
        End Using
        Return False
    End Function
    Public Sub actualizarUsuario()
        conexion()
        usuarioLogueado = (From x In modelo.users Where x.id = usuarioLogueado.id).FirstOrDefault
    End Sub

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


End Module
