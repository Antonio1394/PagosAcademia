Imports System
Imports System.Linq
Imports System.Data
Imports System.Data.Objects
Imports System.Messaging
Imports System.Transactions

Public Class FrmPagos

#Region "Variables"
    Dim idPago As Integer
    Dim idTipoPago As Integer
#End Region

#Region "Eventos"
    Private Sub FrmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdHerramientas.conexion()
        mostrarPagos()
    End Sub

#End Region

#Region "Funciones"
    Public Sub mostrarPagos()
        Try
            listadoPagos.Rows.Clear()
            Dim getPayment = (From x In modelo.payments Select x).ToList

            For Each pagos As payment In getPayment
                listadoPagos.Rows.Add(pagos.id, pagos.no_document, pagos.id_type, pagos.created_at, pagos.payment_types.description, pagos.amount, pagos.student.first_name & " " & pagos.student.last_name, pagos.state, pagos.user.employee.first_name & " " & pagos.user.employee.last_name)
            Next
            listadoPagos.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub listadoPagos_CellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles listadoPagos.CellClick
        If Me.listadoPagos.Columns(e.ColumnIndex).Name.Equals("eliminar") And e.RowIndex >= 0 Then
            Dim result As DialogResult
            result = MessageBox.Show("Realmente desea eliminar Pago", "Eliminar Banco", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Try
                    idPago = CInt(listadoPagos.Rows(e.RowIndex).Cells("idPago").Value)
                    idTipoPago = CInt(listadoPagos.Rows(e.RowIndex).Cells("idTipoPago").Value)
                    deshacerPago(idPago, idTipoPago)
                    MessageBox.Show("Pago cancelado exitosamente", "Cancelando Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrarPagos()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Public Sub deshacerPago(ByVal codigoPago As Integer, ByVal tipoPago As Integer)
        MessageBox.Show("El codigo del pago es " & codigoPago)
        MessageBox.Show("El codigo del tipo de pago es  " & tipoPago)
        Try
            Dim getInfo = (From x In modelo.payments Where x.id = codigoPago Select x).FirstOrDefault
            If tipoPago = 1 Then
                'inscripcion
                cancelarIscripcion(codigoPago, getInfo.id_student)

            ElseIf tipoPago = 2 Then
                'mensualidad
                MessageBox.Show("el monto del pago es " & getInfo.amount)
                cancelarMensualidad(codigoPago, getInfo.amount)
            ElseIf tipoPago = 3 Then
                'pagoExtra
                cancelarPagoExtra(codigoPago, getInfo.amount)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub cancelarIscripcion(ByVal idPago As Integer, ByVal idAlumno As Integer)
        Using transaction As New TransactionScope()
            Try
                'eliminar alumno
                Dim getStudent = (From x In modelo.students Where x.id = idAlumno Select x).FirstOrDefault
                getStudent.state = "cancelado"
                getStudent.updated_at = Date.Now
                modelo.SaveChanges()

                'eliminar inscripcion
                Dim getInscripcion = (From x In modelo.inscripcions Where x.id_payment = idPago Select x).FirstOrDefault
                getInscripcion.state = "cancelado"
                getInscripcion.updated_at = Date.Now
                modelo.SaveChanges()

                'eliminar pago
                Dim getPayment = (From x In modelo.payments Where x.id = idPago Select x).FirstOrDefault
                getPayment.state = "cancelado"
                getPayment.updated_at = Date.Now
                modelo.SaveChanges()

                'confirmar transaccion
                transaction.Complete()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub
    Public Sub cancelarMensualidad(ByVal idPago As Integer, ByVal monto As Integer)
        Using Transaction As New TransactionScope
            Try
                'Actualizar el balance del pago
                Dim getShare = (From x In modelo.shares Where x.id_payment = idPago Select x).FirstOrDefault
                getShare.balance = monto
                getShare.updated_at = Date.Now
                modelo.SaveChanges()

                'cancelar el pago
                Dim getPayment = (From x In modelo.payments Where x.id = idPago Select x).FirstOrDefault
                getPayment.state = "cancelado"
                getPayment.updated_at = Date.Now
                modelo.SaveChanges()

                'confirmar transaccion
                Transaction.Complete()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using

    End Sub
    Public Sub cancelarPagoExtra(ByVal idPago As Integer, ByVal monto As Integer)
        Using Transaction As New TransactionScope
            Try
                '

                'obtenemos el id del pago extra
                Dim idExtraPayment = (From x In modelo.detail_Extra_Payments Where x.id_payment = idPago Select x).FirstOrDefault



                'actualizamos el balance
                Dim getExtraPayment = (From x In modelo.extra_payments Where x.id = idExtraPayment.id_extraPayment Select x).FirstOrDefault
                getExtraPayment.balance = getExtraPayment.balance + monto
                getExtraPayment.updated_at = Date.Now
                modelo.SaveChanges()

                'cancelar el pago
                Dim getPayment = (From x In modelo.payments Where x.id = idPago Select x).FirstOrDefault
                getPayment.state = "cancelado"
                getPayment.updated_at = Date.Now
                modelo.SaveChanges()

                'confirmar transaccion
                Transaction.Complete()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

End Class
