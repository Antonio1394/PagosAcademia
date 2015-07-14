Public Class FrmEmpleado
#Region "variables"
    Dim operacionEmpleados As Boolean = False
    Dim nombre As String
    Dim apellido As String
    Dim telefono As Integer
    Dim direccion As String
    Dim tipo As Integer
    Dim jornada As String
    Dim estadoEmpleado As Boolean = False
    Dim codigoEmpleado As Integer
    Dim idTipoEmpleado As Integer
#End Region

#Region "Eventos"

    Private Sub FrmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdHerramientas.conexion()
        MostrarEmpleado()
        cargarDatos()



    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validacionEmpleado() Then
            If estadoEmpleado Then
                modificarEmpleado()
            Else
                GuardarEmpleado()
                MostrarEmpleado()
            End If
        Else
            MessageBox.Show("Todos los campos son necesarios", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub tblListadoEmpleados_CellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles tblListadoEmpleados.CellClick
        If operacionEmpleados Then
            MessageBox.Show("Hay una operacion en proceso !! ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Me.tblListadoEmpleados.Columns(e.ColumnIndex).Name.Equals("eliminar") And e.RowIndex >= 0 Then
                operacionEmpleados = True
                Dim resultado As DialogResult
                resultado = MessageBox.Show("Confirma eliminacion del Empleado", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If resultado = DialogResult.Yes Then
                    Try
                        codigoEmpleado = CInt(tblListadoEmpleados.Rows(e.RowIndex).Cells("codigo").Value)
                        Dim eliminarEmpleado As employee = (From x In modelo.employees Where x.id = codigoEmpleado Select x).FirstOrDefault

                        If eliminarEmpleado.groups.Count > 0 Or eliminarEmpleado.users.Count > 0 Then
                            codigoEmpleado = CInt(tblListadoEmpleados.Rows(e.RowIndex).Cells("codigo").Value)
                            Dim modificarempleado As employee = (From x In modelo.employees Where x.id = codigoEmpleado Select x).FirstOrDefault
                            Dim modificarUsuario As user = (From x In modelo.users Where x.id_employee = codigoEmpleado Select x).FirstOrDefault
                            modificarUsuario.state = "baja"
                            modificarempleado.state = "baja"
                            modificarempleado.updated_at = Date.Now
                            modificarUsuario.updated_at = Date.Now
                            modelo.SaveChanges()

                            MessageBox.Show("Empleado Eliminado Exitosamente", "Eliminacion Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            modelo.employees.Remove(eliminarEmpleado)
                            modelo.SaveChanges()

                        End If
                        MessageBox.Show("Empleado Eliminado Exitosamente", "Eliminacion Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        MostrarEmpleado()

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
                operacionEmpleados = False
            End If


            If Me.tblListadoEmpleados.Columns(e.ColumnIndex).Name.Equals("modificar") And e.RowIndex >= 0 Then
                Try
                    cargarDatos()
                    operacionEmpleados = True 'operacion en proceso
                    estadoEmpleado = True 'se esta modificando
                    codigoEmpleado = CInt(tblListadoEmpleados.Rows(e.RowIndex).Cells("codigo").Value)
                    txtApellido.Text = CStr(tblListadoEmpleados.Rows(e.RowIndex).Cells("apellido").Value)
                    txtNombre.Text = CStr(tblListadoEmpleados.Rows(e.RowIndex).Cells("nombre").Value)
                    txtTelefono.Text = CStr(tblListadoEmpleados.Rows(e.RowIndex).Cells("telefono").Value)
                    txtDireccion.Text = CStr(tblListadoEmpleados.Rows(e.RowIndex).Cells("direccion").Value)
                    cboJornada.Text = CStr(tblListadoEmpleados.Rows(e.RowIndex).Cells("jornada").Value)
                    cboTipoEmpleado.Text = CStr(tblListadoEmpleados.Rows(e.RowIndex).Cells("tipo").Value)
                    idTipoEmpleado = CInt(tblListadoEmpleados.Rows(e.RowIndex).Cells("idTipoEmpleado").Value)
                    btnGuardar.Text = "Modificar"

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub



#End Region

#Region "Funciones"
    'llena el combo box de tipo de empleado'
    Public Sub cargarDatos()
        Try
            Dim query = (From tipoEmpleado In modelo.type_employees Select tipoEmpleado.id, tipoEmpleado.description Order By description).ToList
            With cboTipoEmpleado
                .ValueMember = "id"
                .DisplayMember = "description"
                .DataSource = query
            End With
        Catch ex As Exception
        End Try
    End Sub
    Public Sub MostrarEmpleado()
        Try
            tblListadoEmpleados.Rows.Clear()

            Dim empleados = (From x In modelo.employees Where x.state = "activo" Select x).ToList

            For Each empleado As employee In empleados
                tblListadoEmpleados.Rows.Add(empleado.id, empleado.first_name, empleado.last_name, empleado.phone, empleado.addres, empleado.type_employees.description, empleado.working_day, "", "", empleado.id_type_employee)
            Next
            tblListadoEmpleados.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Sub GuardarEmpleado()
        Try

            Dim nuevoEmpleado As New employee
            idTipoEmpleado = cboTipoEmpleado.SelectedValue
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
            MessageBox.Show("Registro Guardado Exitosamente", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiarEmpleados()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub modificarEmpleado()
        If validacionEmpleado() Then
            Dim modificarempleado As employee = (From x In modelo.employees Where x.id = codigoEmpleado Select x).FirstOrDefault
            modificarempleado.first_name = txtNombre.Text.Trim
            modificarempleado.last_name = txtApellido.Text.Trim
            modificarempleado.phone = txtTelefono.Text.Trim
            modificarempleado.addres = txtDireccion.Text.Trim
            modificarempleado.id_type_employee = idTipoEmpleado
            modificarempleado.working_day = cboJornada.Text.Trim
            modificarempleado.updated_at = Date.Now
            modelo.SaveChanges()
            MessageBox.Show("Modificacion Exitosa", "Modificar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiarEmpleados()
            btnGuardar.Text = "Guardar"
            MostrarEmpleado()
            estadoEmpleado = False
            operacionEmpleados = False

        Else
            MessageBox.Show("Todos los campos son necesarios", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Public Sub limpiarEmpleados()
        txtNombre.Focus()
        txtApellido.Clear()
        txtDireccion.Clear()
        txtNombre.Clear()
        txtTelefono.Clear()
        cboJornada.Text = ""
        cboTipoEmpleado.Text = ""
    End Sub

    Public Function validacionEmpleado()
        If txtApellido.Text.Trim.Length = 0 Or txtDireccion.Text.Trim.Length = 0 Or txtNombre.Text.Trim.Length = 0 Or cboJornada.Text.Trim.Length = 0 Or cboTipoEmpleado.Text.Trim.Length = 0 Or txtTelefono.Text.Trim.Length > 8 Then
            Return False
        Else
            Return True
        End If
    End Function
#End Region

   


 
    Private Sub cboTipoEmpleado_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles cboTipoEmpleado.SelectedIndexChanged
      

    End Sub


    Private Sub cboTipoEmpleado_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboTipoEmpleado.SelectedValueChanged
        idTipoEmpleado = cboTipoEmpleado.SelectedValue
        MessageBox.Show(idTipoEmpleado)

    End Sub
End Class
