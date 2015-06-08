Public Class FrmTipoPagos

#Region "Variables"
    Dim operacionTipo As Boolean = False
    Dim descripcion As String
    Dim monto As Integer
    Dim estadoTIpo As Boolean = False
    Dim codigoTipo As Integer

#End Region

#Region "Eventos"
    Private Sub FrmTipoPagos_Load(sender As Object, e As EventArgs) Handles Me.Load
        mdHerramientas.conexion()
        MostrarTiposPagos()
    End Sub
  

    'clic en el boton guardar'

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validacionTipo() Then
            If estadoTIpo Then
                modificarTipo()
            Else
                guardarTipoPago()
            End If
        Else
            MessageBox.Show("Todos los campos son necesarios", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    Private Sub tblTipoEmpleados_cellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles tblTipoPagos.CellClick
        If estadoTIpo Then
            MessageBox.Show("Hay una operacion en proceso !! ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Me.tblTipoPagos.Columns(e.ColumnIndex).Name.Equals("eliminar") And e.RowIndex >= 0 Then
                estadoTIpo = True
                Dim resultado As DialogResult
                resultado = MessageBox.Show("Confirma la eliminacion del Tipo Empleado", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                If resultado = DialogResult.OK Then
                    Try
                        codigoTipo = CInt(tblTipoPagos.Rows(e.RowIndex).Cells("codigo").Value)
                        Dim eliminarTipo As payment_types = (From x In modelo.payment_types Where x.id = codigoTipo Select x).FirstOrDefault
                        If eliminarTipo.payments.Count > 0 Then
                            eliminarTipo.state = "baja"
                        Else
                            modelo.payment_types.Remove(eliminarTipo)
                        End If
                        modelo.SaveChanges()
                        MessageBox.Show("Pago Eliminado Exitosamente", "Eliminacion Tipo Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        MostrarTiposPagos()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
                estadoTIpo = False
            End If
            If Me.tblTipoPagos.Columns(e.ColumnIndex).Name.Equals("modificar") And e.RowIndex >= 0 Then
                Try
                    estadoTIpo = True
                    codigoTipo = CInt(tblTipoPagos.Rows(e.RowIndex).Cells("codigo").Value)
                    txtDescripcion.Text = CStr(tblTipoPagos.Rows(e.RowIndex).Cells("descripcion").Value)
                    txtMonto.Value = CStr(tblTipoPagos.Rows(e.RowIndex).Cells("monto").Value)
                    btnGuardar.Text = "Modificar"
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub
#End Region
#Region "Funciones"
    Public Sub MostrarTiposPagos()
        Try
            tblTipoPagos.Rows.Clear()
            Dim tipoPagos = (From x In modelo.payment_types Where x.state = "activo" Select x).ToList
            For Each tipoPago As payment_types In tipoPagos
                tblTipoPagos.Rows.Add({tipoPago.id, tipoPago.description, tipoPago.amount})
            Next
            tblTipoPagos.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub guardarTipoPago()
        Try
            estadoTIpo = True
            descripcion = txtDescripcion.Text.Trim
            monto = txtMonto.Value
            Dim nuevoTipo As New payment_types
            nuevoTipo.description = descripcion
            nuevoTipo.amount = monto
            nuevoTipo.state = "activo"
            nuevoTipo.created_at = Date.Now
            nuevoTipo.updated_at = Date.Now
            modelo.payment_types.Add(nuevoTipo)
            modelo.SaveChanges()
            MessageBox.Show("Registro Guardado Exitosamente", "Tipos de Pagos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
            MostrarTiposPagos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        estadoTIpo = False
    End Sub
    Public Sub limpiar()
        txtDescripcion.Clear()
        txtMonto.Value = 0
        txtDescripcion.Focus()
    End Sub
    Public Sub modificarTipo()
        If validacionTipo() Then
            Dim modificarTipo As payment_types = (From x In modelo.payment_types Where x.id = codigoTipo Select x).FirstOrDefault
            modificarTipo.description = txtDescripcion.Text.Trim
            modificarTipo.amount = Val(txtMonto.Text)
            modelo.SaveChanges()
            MessageBox.Show("Modificacion Exitosa", "Modificar Tipo Pagos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
            btnGuardar.Text = "Guardar"
            MostrarTiposPagos()
            estadoTIpo = False
        Else
            MessageBox.Show("Todos los campos son necesarios", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Public Function validacionTipo()
        If txtDescripcion.Text.Trim.Length = 0 Or txtMonto.Text = "0" Then
            Return False
        Else
            Return True

        End If
    End Function
#End Region





End Class
