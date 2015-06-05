Imports System.Data.SqlClient

Public Class IngresarUsuario
#Region "Variables"
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public resultadp As String
    Dim dsdata As New DataSet
#End Region

#Region "Funciones"
    Public Function insertar(ByRef usuario As String, ByVal password As String, ByVal tipo As String, empleado As Integer)
        Try
            conectado()
            cmd = New SqlCommand("IngresoUsuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@user", usuario)
            cmd.Parameters.AddWithValue("@password", password)
            cmd.Parameters.AddWithValue("@tipo", tipo)
            cmd.Parameters.AddWithValue("@idEmpleado", empleado)
            cmd.Connection = cnn
            resultadp = cmd.ExecuteNonQuery
            Return resultadp


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        Finally
            desconectar()

        End Try
    End Function


    Public Function MostrarEmpleado()
        Try
            conectado()
            cmd = New SqlCommand("CargarEmpleado")


            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        Finally
            desconectar()

        End Try
    End Function
#End Region
End Class
