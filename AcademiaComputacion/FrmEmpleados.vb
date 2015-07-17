Public Class FrmEmpleados

    Dim idTipoEmpleado As Integer = Nothing
    Dim idEmpleado As Integer
    Dim operacionEnProceso As Boolean = False


    Private Sub FrmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdHerramientas.conexion()
        cargarTipoEmpleados()
        cargarEmpleados()
    End Sub
    Public Sub cargarTipoEmpleados()
        Try
            Dim obtenerTipoEmpleados = (From x In modelo.type_employees Where x.state = "activo" Select x.id, x.description).ToList
            With cboTipoEmpleados
                .ValueMember = "id"
                .DisplayMember = "description"
                .DataSource = obtenerTipoEmpleados
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cboTipoEmpleados_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles cboTipoEmpleados.SelectedIndexChanged
        idTipoEmpleado = cboTipoEmpleados.SelectedValue
        MessageBox.Show(idTipoEmpleado)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validarCampos() Then
            guardarEmpleado()
            limpiar()
            cargarEmpleados()
        End If
    End Sub

    Public Sub guardarEmpleado()
        Try
            Dim nuevoEmpleado As New employee
            nuevoEmpleado.first_name = txtNombre.Text.Trim
            nuevoEmpleado.last_name = txtApellido.Text.Trim
            nuevoEmpleado.phone = txtTelefono.Text.Trim
            nuevoEmpleado.addres = txtDireccion.Text.Trim
            nuevoEmpleado.id_type_employee = idTipoEmpleado
            nuevoEmpleado.working_day = cboJornada.Text
            nuevoEmpleado.state = "activo"
            nuevoEmpleado.created_at = Date.Now
            nuevoEmpleado.updated_at = Date.Now
            modelo.employees.Add(nuevoEmpleado)
            modelo.SaveChanges()
            MessageBox.Show("Empleado registrado exitosamente", "Registro de empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub limpiar()
        txtApellido.Clear()
        txtTelefono.Clear()
        txtNombre.Clear()
        txtDireccion.Clear()
        txtNombre.Focus()
    End Sub
    Public Sub cargarEmpleados()
        Try
            tblEmpleados.Rows.Clear()
            Dim obtnerEmpleados = (From x In modelo.employees Where x.state = "activo" Select x).ToList

            For Each empleado As employee In obtnerEmpleados
                tblEmpleados.Rows.Add({empleado.id, empleado.first_name, empleado.last_name, empleado.addres, empleado.phone, empleado.type_employees.description, empleado.working_day, empleado.id_type_employee})
            Next
            tblEmpleados.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub eliminarEmpleado(ByVal idEmpleado As Integer)
        Try
            Dim empleadoBuscado = (From x In modelo.employees Where x.id = idEmpleado Select x).FirstOrDefault

            If empleadoBuscado.groups.Count > 0 Or empleadoBuscado.inscripcions.Count > 0 Or empleadoBuscado.users.Count > 0 Then
                empleadoBuscado.state = "baja"
                empleadoBuscado.updated_at = Date.Now
            Else
                modelo.employees.Remove(empleadoBuscado)
            End If
            modelo.SaveChanges()
            MessageBox.Show("Empleado eliminado exitosamente", "Eliminacion de empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub tblEmpleados_CellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles tblEmpleados.CellClick

        If operacionEnProceso Then
            MessageBox.Show("Hay una operacion en proceso !! ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If e.ColumnIndex > 0 Then
                If e.ColumnIndex >= 0 And Me.tblEmpleados.Columns(e.ColumnIndex).Name.Equals("eliminar") And e.RowIndex >= 0 Then
                    operacionEnProceso = True
                    Dim resultado As DialogResult
                    resultado = MessageBox.Show("Confirma la eliminacion del empleado", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                    If resultado = DialogResult.Yes Then

                        Dim idEmpleado = CInt(tblEmpleados.Rows(e.RowIndex).Cells("codigo").Value)

                        If idEmpleado = 1 Then
                            MessageBox.Show("No se puede eliminar al administrador del sistema", "Error en la eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            eliminarEmpleado(idEmpleado)
                            cargarEmpleados()
                            txtNombre.Focus()
                        End If
                    End If
                    operacionEnProceso = False
                End If
                If tblEmpleados.Columns(e.ColumnIndex).Name.Equals("modificar") And e.RowIndex >= 0 Then
                    Try
                        operacionEnProceso = True
                        idTipoEmpleado = CInt(tblEmpleados.Rows(e.RowIndex).Cells("id_tipo_empleado").Value)
                        MessageBox.Show(idTipoEmpleado)
                        idEmpleado = CInt(tblEmpleados.Rows(e.RowIndex).Cells("codigo").Value)
                        txtNombre.Text = CStr(tblEmpleados.Rows(e.RowIndex).Cells("nombre").Value)
                        txtApellido.Text = CStr(tblEmpleados.Rows(e.RowIndex).Cells("apellido").Value)
                        txtDireccion.Text = CStr(tblEmpleados.Rows(e.RowIndex).Cells("direccion").Value)
                        txtTelefono.Text = CStr(tblEmpleados.Rows(e.RowIndex).Cells("telefono").Value)
                        cboJornada.Text = CStr(tblEmpleados.Rows(e.RowIndex).Cells("jornada").Value)
                        cboTipoEmpleados.Text = CStr(tblEmpleados.Rows(e.RowIndex).Cells("tipo_empleado").Value)
                        btnGuardar.Visible = False
                        btnModificar.Visible = True
                        txtNombre.Focus()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try
            modificarEmpleado(idEmpleado)
            limpiar()
            cargarEmpleados()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub modificarEmpleado(ByVal idEmpleado As Integer)
        Try
            Dim empleadoBuscado = (From x In modelo.employees Where x.id = idEmpleado Select x).FirstOrDefault
            empleadoBuscado.first_name = txtNombre.Text.Trim
            empleadoBuscado.last_name = txtApellido.Text.Trim
            empleadoBuscado.phone = txtTelefono.Text.Trim
            empleadoBuscado.addres = txtTelefono.Text.Trim
            empleadoBuscado.working_day = cboJornada.Text
            MessageBox.Show(idTipoEmpleado)
            empleadoBuscado.id_type_employee = idTipoEmpleado
            empleadoBuscado.updated_at = Date.Now

            modelo.SaveChanges()
            MessageBox.Show("Empleado modificado exitosamente", "Modificacion de empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                Me.ErrorProvider1.SetError(sender, "Solamente numeros se aceptan")
            Else
                Me.ErrorProvider1.SetError(sender, "")
            End If
        End If
    End Sub


    Public Function validarCampos()
        If txtNombre.Text.Trim.Length.Equals("") Or txtApellido.Text.Trim.Length.Equals("") Or txtDireccion.Text.Trim.Length.Equals("") Or cboJornada.Text.Trim.Length = 0 Or cboTipoEmpleados.Text.Trim.Length = 0 Then
            MessageBox.Show("Hay campos vacios", "Validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            If txtTelefono.Text.Trim.Length > 8 Then
                MessageBox.Show("Su numero de telefono es incorrecto", "Validacion de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            Else
                Return True
            End If
        End If
    End Function

End Class
