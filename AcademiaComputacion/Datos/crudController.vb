Imports System.Data.SqlClient
Public Class crudController
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function mostrarUsuarios() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_usuarios")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
