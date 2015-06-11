Public Class FrmTipoEmpleado

#Region "Variables"
    Dim operacionTipo As Boolean = False
    Dim descripcion As String
    Dim estadoTIpo As Boolean = False
    Dim codigoTipo As Integer

#End Region

#Region "Eventos"
    'carga el formulario'
    Private Sub FrmTipoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdHerramientas.conexion()
        MostrarTiposEmpleados()
    End Sub

    'clic en el boton guardar'

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validacionTipo() Then
            If estadoTIpo Then
                modificarTipo()
            Else
                guardarTipoEmpleado()
            End If
        Else
            MessageBox.Show("Todos los campos son necesarios", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    Private Sub tblTipoEmpleados_cellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles tblTipoEmpleados.CellClick
        If estadoTIpo Then
            MessageBox.Show("Hay una operacion en proceso !! ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Me.tblTipoEmpleados.Columns(e.ColumnIndex).Name.Equals("eliminar") And e.RowIndex >= 0 Then
                estadoTIpo = True
                Dim resultado As DialogResult
                resultado = MessageBox.Show("Confirma la eliminacion del Tipo Empleado", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                If resultado = DialogResult.OK Then
                    Try
                        codigoTipo = CInt(tblTipoEmpleados.Rows(e.RowIndex).Cells("codigo").Value)
                        Dim eliminarTipo As type_employees = (From x In modelo.type_employees Where x.id = codigoTipo Select x).FirstOrDefault
                        If eliminarTipo.employees.Count > 0 Then
                            eliminarTipo.state = "abajo"
                            eliminarTipo.updated_at = Date.Now
                            modelo.SaveChanges()
                        Else
                            modelo.type_employees.Remove(eliminarTipo)
                            modelo.SaveChanges()
                            MessageBox.Show("Tipo Empleado Eliminado Exitosamente", "Eliminacion Tipo Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            MostrarTiposEmpleados()
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
                estadoTIpo = False
            End If
            If Me.tblTipoEmpleados.Columns(e.ColumnIndex).Name.Equals("modificar") And e.RowIndex >= 0 Then
                Try
                    estadoTIpo = True
                    codigoTipo = CInt(tblTipoEmpleados.Rows(e.RowIndex).Cells("codigo").Value)
                    txtDescripcion.Text = CStr(tblTipoEmpleados.Rows(e.RowIndex).Cells("descripcion").Value)
                    btnGuardar.Text = "Modificar"
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub
#End Region


#Region "Funciones"

    Public Sub MostrarTiposEmpleados()
        Try
            tblTipoEmpleados.Rows.Clear()
            Dim tipoEmpleado = (From x In modelo.type_employees Where x.state = "arriba" Select x).ToList
            For Each tipoEmpleados As type_employees In tipoEmpleado
                tblTipoEmpleados.Rows.Add({"", tipoEmpleados.id, tipoEmpleados.description})
            Next
            tblTipoEmpleados.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub guardarTipoEmpleado()
        Try
            estadoTIpo = True
            descripcion = txtDescripcion.Text.Trim
            Dim nuevoTipo As New type_employees
            nuevoTipo.description = descripcion
            nuevoTipo.created_at = Date.Now
            nuevoTipo.updated_at = Date.Now
            nuevoTipo.state = "arriba"
            modelo.type_employees.Add(nuevoTipo)
            modelo.SaveChanges()
            MessageBox.Show("Registro Guardado Exitosamente", "Tipos de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
            MostrarTiposEmpleados()

        Catch ex As Exception

        End Try
        estadoTIpo = False
    End Sub

    Public Sub limpiar()
        txtDescripcion.Clear()
    End Sub

    Public Sub modificarTipo()
        If validacionTipo() Then
            Dim modificarTipo As type_employees = (From x In modelo.type_employees Where x.id = codigoTipo Select x).FirstOrDefault
            modificarTipo.description = txtDescripcion.Text.Trim
            modificarTipo.updated_at = Date.Now
            modelo.SaveChanges()
            MessageBox.Show("Modificacion Exitosa", "Modificar Tipo Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
            btnGuardar.Text = "Guardar"
            MostrarTiposEmpleados()
            estadoTIpo = False
        Else
            MessageBox.Show("Todos los campos son necesarios", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Public Function validacionTipo()
        If txtDescripcion.Text.Trim.Length = 0 Then
            Return False
        Else
            Return True

        End If
    End Function

#End Region



 
   
End Class
