Public Class FrmEmpleados

    Dim idTipoEmpleado As Integer = Nothing
    Dim idEmpleado As Integer


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
        guardarEmpleado()
        limpiar()
        cargarEmpleados()

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
            modelo.employees.Remove(empleadoBuscado)
            modelo.SaveChanges()
            MessageBox.Show("Empleado eliminado exitosamente", "Eliminacion de empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub tblEmpleados_CellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles tblEmpleados.CellClick
        If tblEmpleados.Columns(e.ColumnIndex).Name.Equals("eliminar") And e.RowIndex >= 0 Then
            Try
                Dim idEmpleado = CInt(tblEmpleados.Rows(e.RowIndex).Cells("codigo").Value)
                eliminarEmpleado(idEmpleado)
                cargarEmpleados()
                txtNombre.Focus()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        If tblEmpleados.Columns(e.ColumnIndex).Name.Equals("modificar") And e.RowIndex >= 0 Then
            Try
                idTipoEmpleado = CInt(tblEmpleados.Rows(e.RowIndex).Cells("id_tipo_empleado").Value)
                MessageBox.Show(idTipoEmpleado)
                idEmpleado = CInt(tblEmpleados.Rows(e.RowIndex).Cells("codigo").Value)
                txtNombre.Text = CStr(tblEmpleados.Rows(e.RowIndex).Cells("nombre").Value)
                txtApellido.Text = CStr(tblEmpleados.Rows(e.RowIndex).Cells("apellido").Value)
                txtDireccion.Text = CStr(tblEmpleados.Rows(e.RowIndex).Cells("direccion").Value)
                txtTelefono.Text = CStr(tblEmpleados.Rows(e.RowIndex).Cells("telefono").Value)
                cboJornada.Text = CStr(tblEmpleados.Rows(e.RowIndex).Cells("jornada").Value)
                cboTipoEmpleados.Text = CStr(tblEmpleados.Rows(e.RowIndex).Cells("tipo_empleado").Value)
                txtNombre.Focus()
               
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
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
End Class
