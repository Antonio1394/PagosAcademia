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


#End Region

#Region "Eventos"

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdHerramientas.conexion()
        cargarDatos()
        MostrarUsuario()

    End Sub

    'evento del grid'
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

                        If eliminarUsuario.groups.Count > 0 Or eliminarUsuario.payments.Count > 0 Then
                            Dim modificarUsuario As user = (From x In modelo.users Where x.id = codigoUsuario Select x).FirstOrDefault
                            modificarUsuario.state = "baja"
                            modelo.SaveChanges()
                            MessageBox.Show("Laboratorio Eliminado Exitosamente", "Eliminacion Laboratorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            MostrarUsuario()
                        Else
                            modelo.laboratories.Remove(eliminarUsuario)
                            modelo.SaveChanges()
                            MessageBox.Show("Usuario Eliminado Exitosamente", "Eliminacion Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            MostrarLaboratorios()
                        End If

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
                estadoLaboratorio = False
            End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validacionUsario() Then
            If estadoUsuario Then
                ModificarUsuario()
            Else
                GuardarUsuario()

            End If
        Else
            MessageBox.Show("Todos los campos son necesarios", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
#End Region

#Region "Funciones"
    'Funcion que llena el combo de empleados'
    Public Sub cargarDatos()
        Try
            Dim query = (From empleado In modelo.employees Select empleado.id, FullName = empleado.firs_name & " " & empleado.last_name).ToList
            With cboEmpleado
                .ValueMember = "id"
                .DisplayMember = "FullName"
                .DataSource = query
            End With
        Catch ex As Exception
        End Try
    End Sub

    Public Sub MostrarUsuario()
        Try
            'Dim func As New crudController
            'dt = func.mostrarUsuarios
            'DataGridView1.DataSource = dt
            ''tblListadoUsuarios.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

            tblListadoUsuarios.Rows.Clear()
            Dim usuario = (From x In modelo.users Where x.state = "activo" Select x).ToList

            For Each usuarios As user In usuario
                tblListadoUsuarios.Rows.Add({"", "", usuarios.id, usuarios.username, usuarios.type, usuarios.employee.firs_name & " " & usuarios.employee.last_name, usuarios.state})
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

            Else
                MessageBox.Show("Ocurrio un error", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + "sdasd")
        End Try
    End Sub

    ''Modificar Usario-*******-*-*
    Public Sub ModificarUsuario()

    End Sub

    Public Function validacionUsario()
        If txtPassword.Text.Trim.Length = 0 Or txtUser.Text.Trim.Length = 0 Or cboEmpleado.Text.Trim.Length = 0 Or cboTipoUsuario.Text.Trim.Length Then
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
    '*******************************************fin de la region de funciones*********************************************'
#End Region

   

    
    
End Class
