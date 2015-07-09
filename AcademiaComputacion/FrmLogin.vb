Imports System.Data.SqlClient
Public Class FrmLogin
#Region "Variables"
    Dim user As String = ""
    Dim password As String = ""
    Dim passObtenida As String
    Dim passDesincriptada As String
    Public codigoLogeado As Integer

#End Region
#Region "Eventos"
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdHerramientas.conexion()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        verificar()
    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPass.Focus()
        End If
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If Asc(e.KeyChar) = 13 Then
            verificar()
        End If
    End Sub

#End Region
#Region "Funciones"
    Public Sub verificar()
        Try
            'obtengo los valores de los cuadros de texto'
            Dim funcion As New Incriptacion

            user = txtUser.Text.Trim
            password = txtPass.Text.Trim
    
            Dim obtenerUsuario = (From x In modelo.users Where x.state = "arriba" Select x).ToList

            For Each usuarios As user In obtenerUsuario
                If usuarios.username.Equals(user) Then
                    passObtenida = usuarios.password
                    passDesincriptada = funcion.Desencriptar(passObtenida)

                    If (passDesincriptada.Equals(password)) Then
                        usuarioLogueado = (From x In modelo.users Where x.username = user).FirstOrDefault
                        Me.Hide()
                        FrmPrincipal.Show()
                    Else
                        MessageBox.Show("Datos Incorrectos, Intente de Nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        limpiar()
                    End If

                    Exit For
                Else
                    MessageBox.Show("El Usuario No existe intente de Nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtUser.Clear()
                    txtUser.Focus()
                    Exit For
                End If
            Next

            
           
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub limpiar()
        txtUser.Clear()
        txtPass.Clear()
        txtUser.Focus()
    End Sub
#End Region


End Class
