Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System
Imports System.Linq
Imports System.Data
Imports System.Data.Objects
Imports System.Messaging
Imports System.Transactions
Public Class FrmPagosExtras
#Region "Variables"
    Dim listaPagos As New List(Of Integer)
    Dim codigoAlumno As Integer     'id del alumno
    Dim idTypePayment As Integer    'id del tipo de pago
    Dim saldoPagoInicial As Integer        'saldo del pago
    Dim montoAbono As Integer       'monto del abono
    Dim idPago As Integer           'id del pago realizado
#End Region
#Region "Eventos"
    Private Sub FrmPagosExtras_Load(sender As Object, e As EventArgs) Handles Me.Load
        mdHerramientas.conexion()
        lblResultado.Visible = False
        txtNombreAlumnos.ReadOnly = True
        txtEncargado.ReadOnly = True
        txtMonto.ReadOnly = True
    End Sub
    Private Sub txtCodigoAlumno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoAlumno.KeyDown
        If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue = 8) OrElse (e.KeyValue = 13)) Then
            e.Handled = True
            txtCodigoAlumno.Text = vbNullChar
            Me.ErrorProvider1.SetError(sender, "Solamente numero se aceptar")
        Else
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub
    Private Sub txtCodigoAlumno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoAlumno.KeyPress
        If Asc(e.KeyChar) = 13 Then
            codigoAlumno = Val(txtCodigoAlumno.Text)
            buscarAlumno(codigoAlumno)
        End If
    End Sub
    Private Sub cboPagoExtra_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles cboPagoExtra.SelectedIndexChanged
        idTypePayment = cboPagoExtra.SelectedValue
        obtenerMonto(idTypePayment, codigoAlumno)
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        txtMonto.ReadOnly = False
        txtMonto.Focus()
    End Sub
    Private Sub txtMonto_LostFocus(sender As Object, e As EventArgs) Handles txtMonto.LostFocus
        txtMonto.ReadOnly = True
    End Sub
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If validar() Then
            montoAbono = Val(txtMonto.Text)
            realizarPago(montoAbono, idTypePayment, codigoAlumno)
            limpiarBloquear()
            mostrarReporte(idPago, saldoPagoInicial)
            Me.RadWizard1.SelectedPage = Me.WizardPage1
        Else
            MessageBox.Show("Verificar Campos", "Error en la Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim result As DialogResult = MessageBox.Show("Confirmar cancelacion", "Cancelando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If result = DialogResult.OK Then
            Me.Close()
        End If
    End Sub
#End Region
#Region "Funciones"
    Public Sub buscarAlumno(ByVal codigo As Integer)
        Try
            Dim obtenerAlumno = (From x In modelo.students Where x.state = "arriba" And x.id = codigo Select fullName = (x.first_name + " " + x.last_name), x.in_charge).ToList
            If obtenerAlumno.Count = 0 Then
                txtNombreAlumnos.Text = ""
                txtEncargado.Text = ""
                txtCodigoAlumno.Text = ""
                txtMonto.Text = ""
                cboPagoExtra.DataSource = ""
                txtCodigoAlumno.Focus()
                lblResultado.Visible = True
            Else
                txtNombreAlumnos.Text = obtenerAlumno(0).fullName
                txtEncargado.Text = obtenerAlumno(0).in_charge
                lblResultado.Visible = False
                buscarPagosExtras(codigo)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub buscarPagosExtras(ByVal codigo As Integer)
        Try
            Dim getPayment = (From x In modelo.extra_payments Where x.state = "activo" And x.balance <> 0 And x.id_student = codigo Select x).ToArray
            For x = LBound(getPayment) To UBound(getPayment)
                listaPagos.Add(getPayment(x).id_type_payment)
            Next
            Dim getPayments = (From x In modelo.payment_types Where listaPagos.Contains(x.id) Select x.id, x.description).ToList
            With cboPagoExtra
                .ValueMember = "id"
                .DisplayMember = "description"
                .DataSource = getPayments
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub obtenerMonto(ByVal idTypePayment As Integer, ByVal idEstudiante As Integer)
        If idTypePayment <> 0 Then
            Dim montoPago = (From x In modelo.extra_payments Where x.id_type_payment = idTypePayment And x.id_student = idEstudiante Select x).FirstOrDefault
            saldoPagoInicial = montoPago.balance
            txtMonto.Text = saldoPagoInicial
        End If
    End Sub
    Public Function validar()
        If codigoAlumno = 0 Or cboPagoExtra.SelectedIndex = -1 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub realizarPago(ByVal abono As Integer, ByVal idTipoPago As Integer, ByVal idstudent As Integer)
        Using transaction As New TransactionScope()
            Try
                Dim nuevoPago As New payment
                nuevoPago.no_document = "asd34"
                nuevoPago.description = "PagoExtra"
                nuevoPago.amount = abono
                nuevoPago.state = "aceptado"
                nuevoPago.id_type = idTipoPago
                nuevoPago.id_user = 1
                nuevoPago.id_student = codigoAlumno
                nuevoPago.created_at = Date.Now
                nuevoPago.updated_at = Date.Now
                modelo.payments.Add(nuevoPago)
                modelo.SaveChanges()
                idPago = nuevoPago.id
                Dim getExtraPago = (From x In modelo.extra_payments Where x.id_student = idstudent And x.id_type_payment = idTipoPago).First
                getExtraPago.balance = getExtraPago.balance - abono
                getExtraPago.id_payment = idPago
                getExtraPago.updated_at = Date.Now
                modelo.SaveChanges()
                transaction.Complete()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub
    Public Sub limpiarBloquear()
        txtCodigoAlumno.Clear()
        txtNombreAlumnos.Clear()
        txtEncargado.Clear()
        txtMonto.Clear()
        cboPagoExtra.DataSource = ""
        txtCodigoAlumno.Enabled = False
        btnSiguiente.Enabled = False
        btnCancelar.Enabled = False
        btnAtras.Enabled = False
    End Sub

    Public Sub mostrarReporte(ByVal idPayment As Integer, ByVal saldoAnterior As Integer)
        Dim dato1 As New ParameterValues
        Dim dato2 As New ParameterValues

        Dim pvisualizar As New ParameterDiscreteValue
        Dim pvisualizar2 As New ParameterDiscreteValue
        Dim cr1 As New ReportePagoExtra

        pvisualizar.Value = idPayment
        dato1.Add(pvisualizar)

        pvisualizar2.Value = saldoAnterior
        dato2.Add(pvisualizar2)

        cr1.DataDefinition.ParameterFields("@idPago").ApplyCurrentValues(dato1)
        cr1.DataDefinition.ParameterFields("@saldoAnterior").ApplyCurrentValues(dato2)

        Me.CrystalReportViewer1.ReportSource = cr1
    End Sub


#End Region




End Class
