Imports System.Data.SqlClient
Public Class FnLoguear
#Region "Variables"
    Inherits Conexion
    Dim cmd As New SqlCommand
    Dim resultado As Integer
#End Region
#Region "Funciones"
    Public Function ValidarUsuario(ByVal usuario As String, ByVal password As String)
        Try
            conectado()
            cmd = New SqlCommand("Valida_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@username", usuario)
            cmd.Parameters.AddWithValue("@password", password)
            cmd.Connection = cnn
            resultado = cmd.ExecuteScalar
            Return resultado
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        Finally
            desconectar()
        End Try
    End Function
#End Region

End Class
