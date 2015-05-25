Imports System.Data.SqlClient
Imports System.Data.EntityClient
Module mdHerramientas

    Dim servidor As String = "ANTONIO\SQLEXPRESS"

    Dim baseDatos As String = "academia"
    Dim usuario As String = "sa"
    Dim password As String = "Umg2015"
    Dim dirModelo As String = "Modelo"
    Public modelo As AcademiaEntities
    Public usuarioLogueado As user

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
            modelo = New AcademiaEntities(entityBuilder.ConnectionString)

            conn.Close()
            Return True
        End Using
        Return False
    End Function
    Public Sub actualizarUsuario()
        conexion()
        usuarioLogueado = (From x In modelo.users Where x.id = usuarioLogueado.id).FirstOrDefault
    End Sub

End Module
