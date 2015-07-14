Public Class FrmUsuarios
#Region "Variables"

    Dim operacionUsuario As Boolean = False
    Dim usuario As String
    Dim password As String
    Dim passwordIncriptada As String
    Dim tipo As String
    Dim empleado As Integer
    Dim estadoUsuario As Boolean = False
    Dim codigoUsuario As Integer
    Dim dt As New DataTable
    Dim incriptar As New Incriptacion '' instancio la clase de incriptar
    Dim Modificar As Boolean = False
    Dim funcion As New Incriptacion
    Dim miValor As String
    Dim listadoEmpleados As New List(Of Integer)

#End Region

#Region "Eventos"

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdHerramientas.conexion()
        cargarDatos()
        MostrarUsuario()


    End Sub

    Private Sub tblListadoUsuarios_CellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles tblListadoUsuarios.CellClick
        If estadoUsuario Then
            MessageBox.Show("Hay una operacion en proceso !! ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            If Me.tblListadoUsuarios.Columns(e.ColumnIndex).Name.Equals("eliminar") And e.RowIndex >= 0 Then
                estadoUsuario = True
                Dim resultado As DialogResult
                resultado = MessageBox.Show("Confirma eliminacion de el usuario", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If resultado = DialogResult.OK Then
                    Try
                        codigoUsuario = CInt(tblListadoUsuarios.Rows(e.RowIndex).Cells("codigo").Value)
                        Dim eliminarUsuario As user = (From x In modelo.users Where x.id = codigoUsuario Select x).FirstOrDefault

                        If eliminarUsuario.payments.Count > 0 Then
                            Dim modificarUsuario As user = (From x In modelo.users Where x.id = codigoUsuario Select x).FirstOrDefault
                            modificarUsuario.state = "baja"
                            modificarUsuario.updated_at = Date.Now
                            modelo.SaveChanges()
                            MessageBox.Show("Usuario Eliminado Exitosamente", "Eliminacion Laboratorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            MostrarUsuario()
                            cargarDatos()
                        Else
                            modelo.users.Remove(eliminarUsuario)
                            modelo.SaveChanges()
                            MessageBox.Show("Usuario Eliminado Exitosamente", "Eliminacion Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            MostrarUsuario()
                            cargarDatos()
                        End If

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
                estadoUsuario = False
            End If
        End If


        If Me.tblListadoUsuarios.Columns(e.ColumnIndex).Name.Equals("modificar") And e.RowIndex >= 0 Then
            Try
                Modificar = True
                estadoUsuario = True
                codigoUsuario = CInt(tblListadoUsuarios.Rows(e.RowIndex).Cells("codigo").Value)
                txtUser.Text = CStr(tblListadoUsuarios.Rows(e.RowIndex).Cells("usuario").Value)
                cboTipoUsuario.Text = CStr(tblListadoUsuarios.Rows(e.RowIndex).Cells("permisos").Value)
                txtPassword.Enabled = False
                txtPassword.NullText = "Solo el Usuario puede cambiar la contraseña"
                cboEmpleado.Enabled = False
                btnGuardar.Text = "Modificar"
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        If Me.tblListadoUsuarios.Columns(e.ColumnIndex).Name.Equals("restablecer") And e.RowIndex >= 0 Then
            estadoUsuario = True
            Dim UsuarioRestablecer As String = CStr(tblListadoUsuarios.Rows(e.RowIndex).Cells("usuario").Value)
            codigoUsuario = CInt(tblListadoUsuarios.Rows(e.RowIndex).Cells("codigo").Value)
            Dim resultado As DialogResult
            resultado = MessageBox.Show("Comfirma Restablecer la Contraseña de: " & UsuarioRestablecer, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resultado = DialogResult.Yes Then
                miValor = InputBox("Escriba la nueva Contrase;a", "Restablecer")
                Dim modificarUsuario As user = (From x In modelo.users Where x.id = codigoUsuario Select x).FirstOrDefault
                modificarUsuario.password = funcion.Encriptar(miValor)
                modificarUsuario.updated_at = Date.Now
                modelo.SaveChanges()
                MessageBox.Show("Contraseña Restablecida Correctamente", "Laboratorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Dijo no")
            End If
            estadoUsuario = False
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

       
            If Modificar Then
                ModificarUsuario()
        Else

            If UsuarioDisponible() Then
                MessageBox.Show("Este Usuario no esta Disponible", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                If validacionUsario() Then
                    GuardarUsuario()
                Else
                    MessageBox.Show("Todos los campos son necesarios", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        End If

    End Sub


    Private Sub txtUser_Leave(sender As Object, e As EventArgs) Handles txtUser.Leave
        If UsuarioDisponible() Then
            MessageBox.Show("Este Usuario no esta Disponible", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
#End Region

#Region "Funciones"
    Public Sub cargarDatos()
        Try
            listadoEmpleados.Clear()
            Dim extraerEmpleados = (From x In modelo.users Where x.state = "activo" Select x.id_employee Group By id_employee Into total = Count(id_employee)).ToArray

            For x = LBound(extraerEmpleados) To UBound(extraerEmpleados)
                listadoEmpleados.Add(extraerEmpleados(x).id_employee)
            Next
            Dim extraerEmpleadosDos = (From x In modelo.employees Where Not listadoEmpleados.Contains(x.id) And x.state = "activo" Select x.id, FullName = x.first_name & " " & x.last_name).ToList
            With cboEmpleado
                .ValueMember = "id"
                .DisplayMember = "FullName"
                .DataSource = extraerEmpleadosDos
            End With
        Catch ex As Exception
        End Try
    End Sub

    Public Sub MostrarUsuario()
        Try
            tblListadoUsuarios.Rows.Clear()
            Dim usuario = (From x In modelo.users Where x.state = "activo" Select x).ToList

            For Each usuarios As user In usuario
                tblListadoUsuarios.Rows.Add({"", "", usuarios.id, usuarios.username, usuarios.type, usuarios.employee.first_name & " " & usuarios.employee.last_name, usuarios.state})
            Next
            tblListadoUsuarios.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub GuardarUsuario()
        Try

            usuario = txtUser.Text.Trim
            password = txtPassword.Text.Trim
            tipo = cboTipoUsuario.Text
            empleado = cboEmpleado.SelectedValue
            passwordIncriptada = incriptar.Encriptar(password)

           
            Dim funcion As New IngresarUsuario
            funcion.insertar(usuario, passwordIncriptada, tipo, empleado)
            If funcion.resultadp > 0 Then
                MessageBox.Show("Registro Guardado Exitosamente", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarUsuario()
                limpiarUsuario()
                cargarDatos()

            Else
                MessageBox.Show("Ocurrio un error", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + "sdasd")
        End Try
    End Sub


    Public Sub ModificarUsuario()

        Dim modificarUsuario As user = (From x In modelo.users Where x.id = codigoUsuario Select x).FirstOrDefault
        modificarUsuario.username = txtUser.Text.Trim
        modificarUsuario.type = cboTipoUsuario.Text
        modificarUsuario.updated_at = Date.Now
        modelo.SaveChanges()
        MessageBox.Show("Modificacion Exitosa", "Modificar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Modificar = False
        limpiarUsuario()
        btnGuardar.Text = "Guardar"
        txtPassword.Enabled = True
        cboEmpleado.Enabled = True
        txtPassword.NullText = "Contraseña para el Usuario"
        MostrarUsuario()
        estadoUsuario = False
       
    End Sub

    Public Function validacionUsario()
        If txtPassword.Text.Trim.Length = 0 Or txtUser.Text.Trim.Length = 0 Or cboEmpleado.Text.Trim.Length = 0 Or cboTipoUsuario.Text.Trim.Length = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub limpiarUsuario()
        txtPassword.Clear()
        txtUser.Clear()
        cboEmpleado.Text = ""

    End Sub

    Public Function UsuarioDisponible()
        Try
            Dim UsuarioTexto As String = txtUser.Text.Trim
            Dim usuario = (From x In modelo.users Where x.state = "activo" Select x).ToList

            For Each Usuarios As user In usuario
                If Usuarios.username.Equals(UsuarioTexto) Then
                    Return True
                    Exit For
                Else
                    Return False
                    Exit For

                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function




#End Region

   

End Class
