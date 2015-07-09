Imports System.Transactions
Public Class FrmTipoPagos

#Region "Variables"
    Dim operacionTipo As Boolean = False
    Dim descripcion As String
    Dim monto As Integer
    Dim estadoTIpo As Boolean = False
    Dim codigoTipo As Integer
    Dim studentlist As New List(Of Integer)
    Dim paymentExtraList As New List(Of Integer)
    Dim sharesList As New List(Of Integer)
    Dim indice As Integer
    Dim diferencia As Integer
#End Region

#Region "Eventos"
    Private Sub FrmTipoPagos_Load(sender As Object, e As EventArgs) Handles Me.Load
        mdHerramientas.conexion()
        MostrarTiposPagos()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validacionTipo() Then
            If estadoTIpo Then
                modificarTipo()
            Else
                registrarTipoPago()
            End If
            limpiar()
            MostrarTiposPagos()
        Else
            MessageBox.Show("Todos los campos son necesarios", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub tblTipoEmpleados_cellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles tblTipoPagos.CellClick
        If estadoTIpo Then
            MessageBox.Show("Hay una operacion en proceso !! ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If e.ColumnIndex > 0 Then
                If e.ColumnIndex >= 0 And Me.tblTipoPagos.Columns(e.ColumnIndex).Name.Equals("eliminar") And e.RowIndex >= 0 Then
                    estadoTIpo = True
                    Dim resultado As DialogResult
                    resultado = MessageBox.Show("Confirma la eliminacion del Tipo de Pago", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                    If resultado = DialogResult.Yes Then

                        codigoTipo = CInt(tblTipoPagos.Rows(e.RowIndex).Cells("codigo").Value)

                        If codigoTipo = 1 Or codigoTipo = 2 Then
                            MessageBox.Show("Pagos especiales no se pueden eliminar", "Error en la eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else

                            Using transaction As New TransactionScope()
                                Try
                                    'Eliminamos de la tabla tipo de pago 
                                    'Obtenemos el tipo de pago
                                    Dim eliminarTipo As payment_types = (From x In modelo.payment_types Where x.id = codigoTipo Select x).FirstOrDefault
                                    'Comprovamos sus relaciones
                                    If eliminarTipo.payments.Count > 0 Or eliminarTipo.extra_payments.Count > 0 Then
                                        'si tiene relaciones cambiamos su estado 
                                        eliminarTipo.state = "baja"
                                        eliminarTipo.updated_at = Date.Now
                                    Else
                                        'si no tiene relaciones lo eliminamos
                                        modelo.payment_types.Remove(eliminarTipo)
                                    End If
                                    'Guardamos los cambios
                                    modelo.SaveChanges()

                                    'Damos de baja a todos los pagos extras en la tabla extras payments
                                    Dim getExtraPayments = (From x In modelo.extra_payments Where x.id_type_payment = codigoTipo And x.balance <> 0 And x.state = "activo" Select x.id, x.amount).ToArray
                                    paymentExtraList.Clear()

                                    For x = LBound(getExtraPayments) To UBound(getExtraPayments)
                                        paymentExtraList.Add(getExtraPayments(x).id)
                                    Next

                                    Dim total2 As Integer = paymentExtraList.Count

                                    For x = 0 To total2 - 1
                                        indice = paymentExtraList(x)
                                        Dim modificarExtraPayment = (From xx In modelo.extra_payments Where xx.id = indice Select xx).FirstOrDefault
                                        modificarExtraPayment.state = "baja"
                                        modificarExtraPayment.updated_at = Date.Now
                                        modelo.SaveChanges()
                                    Next


                                    transaction.Complete()
                                    MessageBox.Show("Tipo de Pago Eliminado Exitosamente", "Eliminacion Tipo Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message)
                                End Try
                            End Using
                        End If

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
        End If
        MostrarTiposPagos()
    End Sub
#End Region
#Region "Funciones"
    Public Sub MostrarTiposPagos()
        Try
            tblTipoPagos.Rows.Clear()
            Dim tipoPagos = (From x In modelo.payment_types Where x.state = "arriba" Select x).ToList
            For Each tipoPago As payment_types In tipoPagos
                tblTipoPagos.Rows.Add({tipoPago.id, tipoPago.description, tipoPago.amount})
            Next
            tblTipoPagos.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub limpiar()
        txtDescripcion.Clear()
        txtMonto.Value = 0
        txtDescripcion.Focus()
    End Sub
    Public Sub modificarTipo()
        Using Transaction As New TransactionScope
            Try
                'realizamos la modificacion en la tabla tipos de pagos
                Dim modificarTipo As payment_types = (From x In modelo.payment_types Where x.id = codigoTipo Select x).FirstOrDefault
                modificarTipo.description = txtDescripcion.Text.Trim
                modificarTipo.amount = Val(txtMonto.Text)
                modificarTipo.updated_at = Date.Now
                modelo.SaveChanges()


                'Verificamos si es una mensualidad o un pago extra
                If codigoTipo = 2 Then
                    'Mensualidad
                    Dim getShares = (From x In modelo.shares Where x.balance <> 0 Select x.id, x.amount).ToArray
                    sharesList.Clear()

                    For x = LBound(getShares) To UBound(getShares)
                        sharesList.Add(getShares(x).id)
                    Next

                    Dim total3 As Integer = sharesList.Count


                    For x = 0 To total3 - 1
                        indice = sharesList(x)
                        Dim getShare = (From xx In modelo.shares Where xx.id = indice Select xx).FirstOrDefault
                        diferencia = getShare.amount - getShare.balance
                        diferencia = Val(txtMonto.Text) - diferencia
                        If diferencia < 0 Then
                            diferencia = 0
                        End If
                        getShare.amount = Val(txtMonto.Text)
                        getShare.balance = diferencia
                        getShare.updated_at = Date.Now
                        modelo.SaveChanges()
                    Next

                Else
                    'Pago Extra
                    'Actualizamos los cambios en la tabla pagos extras
                    Dim getExtraPayments = (From x In modelo.extra_payments Where x.id_type_payment = modificarTipo.id And x.balance <> 0 And x.state = "activo" Select x.id, x.amount).ToArray
                    paymentExtraList.Clear()

                    For x = LBound(getExtraPayments) To UBound(getExtraPayments)
                        paymentExtraList.Add(getExtraPayments(x).id)
                    Next

                    Dim total2 As Integer = paymentExtraList.Count

                    For x = 0 To total2 - 1
                        indice = paymentExtraList(x)
                        Dim modificarExtraPayment = (From xx In modelo.extra_payments Where xx.id = indice Select xx).FirstOrDefault
                        diferencia = modificarExtraPayment.amount - modificarExtraPayment.balance
                        diferencia = Val(txtMonto.Text) - diferencia

                        If diferencia < 0 Then
                            diferencia = 0
                        End If
                        modificarExtraPayment.balance = diferencia
                        modificarExtraPayment.amount = Val(txtMonto.Text)
                        modificarExtraPayment.updated_at = Date.Now
                        modelo.SaveChanges()
                    Next
                End If

                Transaction.Complete()
                MessageBox.Show("Modificacion Exitosa", "Modificar Tipo Pagos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnGuardar.Text = "Guardar"
                estadoTIpo = False
            Catch ex As Exception
                MessageBox.Show("Error al modificar el tipo de pago", "Eror al modificar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Public Function validacionTipo()
        If txtDescripcion.Text.Trim.Length = 0 Or txtMonto.Text = "0" Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub registrarTipoPago()
        Using transaction As New TransactionScope()
            Try
                'Registrar tipo pago en la tabla payment_types
                estadoTIpo = True
                descripcion = txtDescripcion.Text.Trim
                monto = txtMonto.Value
                Dim nuevoTipo As New payment_types
                nuevoTipo.description = descripcion
                nuevoTipo.amount = monto
                nuevoTipo.state = "arriba"
                nuevoTipo.created_at = Date.Now
                nuevoTipo.updated_at = Date.Now
                modelo.payment_types.Add(nuevoTipo)
                modelo.SaveChanges()


                'agregar el pago a los alumnos en la tabla extras_payments
                studentlist.Clear()

                Dim getStudents = (From alumnos In modelo.students Where alumnos.state = "arriba" Select alumnos.id, alumnos.first_name).ToArray

                For x = LBound(getStudents) To UBound(getStudents)
                    studentlist.Add(getStudents(x).id)
                Next

                Dim total As Integer = studentlist.Count

                For x = 0 To total - 1
                    Dim newShareExtra As New extra_payments
                    newShareExtra.id_student = studentlist(x)
                    newShareExtra.id_payment = Nothing
                    newShareExtra.id_type_payment = nuevoTipo.id
                    newShareExtra.amount = nuevoTipo.amount
                    newShareExtra.balance = nuevoTipo.amount
                    newShareExtra.state = "activo"
                    newShareExtra.created_at = Date.Now
                    newShareExtra.updated_at = Date.Now
                    modelo.extra_payments.Add(newShareExtra)
                    modelo.SaveChanges()
                Next
                'finalizamos comprometiendo la transaccion
                transaction.Complete()
                'mostramos el mensaje de confirmacion 
                MessageBox.Show("Registro Guardado Exitosamente", "Tipos de Pagos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al guardar el tipo de pago", "Eror al modificar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            estadoTIpo = False
        End Using
    End Sub
#End Region

End Class
