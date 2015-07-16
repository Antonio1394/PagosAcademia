Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System
Imports System.Linq
Imports System.Data
Imports System.Data.Objects
Imports System.Messaging
Imports System.Transactions
Public Class FrmIncripcion
#Region "Variables"
    Dim nombre As Boolean = False
    Dim apellido As Boolean = False
    Dim direccion As Boolean = False
    Dim encargado As Boolean = False
    Dim paginaSeleccionada As Integer = 0
    Dim MontoInscripcion As Integer
    Dim fechaInscripcion As String
    Dim diasRestantes As Integer
    Dim primerPago As Integer
    Dim mensualidad As Integer
    Dim fechaPago As DateTime
    Dim mes As String
    Dim pagina2 = 1
    Dim validarMonto = True
    'Variables para reporte
    Dim idInscripcion As Integer
    Dim paymentList As List(Of Integer)
#End Region
#Region "Eventos"
    Private Sub FrmIncripcion_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnAtrasFalso.Visible = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
        mdHerramientas.conexion()
        If recibo Then
            txtRecibo.Visible = False
            lblRecibo.Visible = False
            txtRecibo.Enabled = False
            lblRecibo.Enabled = False
        Else
            txtRecibo.Visible = True
            lblRecibo.Visible = True
            txtRecibo.Enabled = True
            lblRecibo.Enabled = True
        End If
        cargarPromotor()
        cargarGrupos()
        MontoInscripcion = (From x In modelo.payment_types Where x.id = 1 Select x.amount).FirstOrDefault
        mensualidad = (From x In modelo.payment_types Where x.id = 2 Select x.amount).FirstOrDefault
        txtMonto.Text = MontoInscripcion
    End Sub
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        verificarPagina()
        If paginaSeleccionada = 1 Then
            If validacion() Then
                Me.wizarInscripcion.SelectedPage = Me.WizardPage1
            Else
                MessageBox.Show("Verificar Datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf paginaSeleccionada = 2 Then
            If validacionDos() Then
                btnSiguiente.Visible = False
                btnAtras.Visible = False
                btnCancelar.Visible = False
                btnAtrasFalso.Visible = True
                transaccionInscripcion()
                mostrarReporte(idInscripcion)
                Me.wizarInscripcion.SelectedPage = Me.WizardCompletionPage1
            Else
                MessageBox.Show("Verificar Datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub cboTipoPago_SelectedIndexChanged_1(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles cboTipoPago.SelectedIndexChanged
        If cboTipoPago.Text = "Normal" Then
            txtMonto.Text = MontoInscripcion
            txtMonto.Enabled = False
        Else
            txtMonto.Text = ""
            txtMonto.Enabled = True
        End If
    End Sub
    Private Sub txtMonto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMonto.KeyDown
        If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue = 8)) Then
            e.Handled = True
            validarMonto = False
        Else
            validarMonto = True
        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cancelar()
    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If Me.wizarInscripcion.SelectedPage.Name.Equals("WizardWelcomePage1") Then
            pagina2 = 1
        ElseIf Me.wizarInscripcion.SelectedPage.Name.Equals("WizardPage1") Then
            pagina2 = 2
        ElseIf Me.wizarInscripcion.SelectedPage.Name.Equals("WizardCompletionPage1") Then
            pagina2 = 3
        End If
        If pagina2 = 2 Then
            Me.wizarInscripcion.SelectedPage = Me.WizardWelcomePage1
        ElseIf pagina2 = 3 Then
            Me.wizarInscripcion.SelectedPage = Me.WizardPage1
            btnSiguiente.Visible = True
        End If
    End Sub
#End Region
#Region "Funciones"
    Public Sub verificarPagina()
        If Me.wizarInscripcion.SelectedPage.Name.Equals("WizardWelcomePage1") Then
            paginaSeleccionada = 1
        ElseIf Me.wizarInscripcion.SelectedPage.Name.Equals("WizardPage1") Then
            paginaSeleccionada = 2
        End If
    End Sub
    Public Function validacion()
        If nombre And apellido And direccion And encargado Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function validacionDos()
        Dim indexGrupo = cboGrupo.SelectedIndex
        Dim indexTipoInscripcion = cboTipoInscripcion.SelectedIndex
        Dim indexPromotor = cboPromotor.SelectedIndex
        Dim indexTipoPago = cboTipoPago.SelectedIndex

        If indexGrupo = -1 Or indexTipoInscripcion = -1 Or indexTipoPago = -1 Or validarMonto = False Then
            Return False
        Else
            If indexTipoInscripcion = 1 Then
                If indexPromotor = -1 Then
                    Return False
                Else
                    Return True
                End If
            End If
            Return True
        End If


        Return False
    End Function
    Public Sub cargarPromotor()
        Dim promotores = (From x In modelo.employees Where x.id_type_employee = 4 And x.state = "activo" Select x.id, FullName = x.first_name & " " & x.last_name).ToList
        With cboPromotor
            .ValueMember = "id"
            .DisplayMember = "FullName"
            .DataSource = promotores
        End With
    End Sub
    Public Sub cargarGrupos()
        Dim grupos = (From x In modelo.groups Where x.state = "arriba" Select x.id, FullName = x.day & " " & x.schedule).ToList
        With cboGrupo
            .ValueMember = "id"
            .DisplayMember = "FullName"
            .DataSource = grupos
        End With
    End Sub
    Public Sub transaccionInscripcion()
        Using transaction As New TransactionScope()
            Try
                Dim nuevoAlumno As New student
                nuevoAlumno.first_name = txtNombre.Text
                nuevoAlumno.last_name = txtapellido.Text
                nuevoAlumno.phone = txtTelefono.Text
                nuevoAlumno.addres = txtDireccion.Text
                nuevoAlumno.date_of_birth = FechaNacimiento.Text
                nuevoAlumno.in_charge = txtEncargado.Text
                nuevoAlumno.state = "arriba"
                nuevoAlumno.created_at = Date.Now
                nuevoAlumno.updated_at = Date.Now
                modelo.students.Add(nuevoAlumno)
                modelo.SaveChanges()

                Dim idAlumno = nuevoAlumno.id

                Dim nuevoPago As New payment
                nuevoPago.no_document = "a56df"
                nuevoPago.description = "Inscripcion"
                nuevoPago.amount = txtMonto.Text
                nuevoPago.state = "aceptado"
                nuevoPago.id_type = 1
                nuevoPago.id_user = 1
                nuevoPago.id_student = idAlumno
                nuevoPago.created_at = Date.Now
                nuevoPago.updated_at = Date.Now
                modelo.payments.Add(nuevoPago)
                modelo.SaveChanges()
                Dim idPago = nuevoPago.id

                Dim nuevaInscripcion As New inscripcion

                If cboTipoInscripcion.SelectedIndex = 1 Then
                    nuevaInscripcion.id_employee = cboPromotor.SelectedValue
                Else
                    nuevaInscripcion.id_employee = Nothing
                End If
                nuevaInscripcion.id_payment = idPago
                nuevaInscripcion.id_group = cboGrupo.SelectedValue
                nuevaInscripcion.type = cboTipoInscripcion.Text
                nuevaInscripcion.state = "aceptado"
                nuevaInscripcion.created_at = Date.Now
                nuevaInscripcion.updated_at = Date.Now
                modelo.inscripcions.Add(nuevaInscripcion)
                modelo.SaveChanges()
                idInscripcion = nuevaInscripcion.id
                Dim mensualidades As New share

                For x = 1 To 24
                    mensualidades.id_inscripcion = idInscripcion
                    mensualidades.id_payment = Nothing
                    'exepcion
                    mensualidades.date_share = fechaDePago(Date.Now.AddMonths(x))
                    If x = 1 Then
                        mensualidades.amount = calcularDiasRestantes()
                        mensualidades.balance = calcularDiasRestantes()
                    Else
                        mensualidades.amount = mensualidad
                        mensualidades.balance = mensualidad
                    End If
                    mensualidades.mora = 0
                    mensualidades.created_at = Date.Now
                    mensualidades.updated_at = Date.Now
                    modelo.shares.Add(mensualidades)
                    modelo.SaveChanges()
                Next

                'asignale los pagos extras
                Dim getExtraPayments = (From x In modelo.payment_types Where x.state = "arriba" Select x.id, x.amount).ToArray

                For x = LBound(getExtraPayments) To UBound(getExtraPayments)
                    paymentList.Add(getExtraPayments(x).id)
                Next

                Dim totalPayments As Integer


                totalPayments = getExtraPayments.Count

                For x = 0 To totalPayments - 1

                    Dim newPaymentExtra As New extra_payments
                    newPaymentExtra.id_student = idAlumno
                    newPaymentExtra.id_payment = Nothing
                    'newPaymentExtra.id_type_payment = 


                Next






                transaction.Complete()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using

    End Sub
    Public Function calcularDiasRestantes()
        fechaInscripcion = (Date.Now.ToString).Substring(0, 2)
        mes = (Date.Now.ToString).Substring(3, 2)
        If fechaInscripcion = 31 Or fechaInscripcion = 30 Or (fechaInscripcion = 28 Or fechaInscripcion = 29 And mes = "02") Then
            diasRestantes = 0
        Else
            diasRestantes = (30) - (Convert.ToInt32(fechaInscripcion))
        End If
        Return obtenerPrimerPago(diasRestantes)
    End Function
    Public Function obtenerPrimerPago(ByVal dias As Integer)
        If dias = 0 Then
            primerPago = 0
        Else
            primerPago = (dias * mensualidad) / 30
        End If
        Return primerPago
    End Function
    Public Function fechaDePago(ByVal fecha As Date)
        fechaPago = DateTime.Parse("01" & fecha.ToString.Substring(2, 8))
        Return fechaPago
    End Function
    Public Sub mostrarReporte(ByVal dato As Integer)
        Dim dato1 As New ParameterValues
        Dim pvisualizar As New ParameterDiscreteValue
        Dim cr1 As New ReporteInscripcion
        pvisualizar.Value = dato
        dato1.Add(pvisualizar)
        cr1.DataDefinition.ParameterFields("@idInscripcion").ApplyCurrentValues(dato1)
        Me.visorInscripcion.ReportSource = cr1
        Me.visorInscripcion.Zoom(75)
    End Sub
    Public Sub cancelar()
        Dim result As DialogResult = MessageBox.Show("Confirmar cancelacion", "Cancelando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If result = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

#End Region
#Region "Validacion Estudiante"
    Private Sub txtNombre_Validated(sender As Object, e As EventArgs) Handles txtNombre.Validated
        If txtNombre.Text.Trim.Equals("") Then
            Me.alertaError.SetError(sender, "Campo Requerido")
            nombre = False
        Else
            Me.alertaError.SetError(sender, "")
            nombre = True
        End If
    End Sub
    Private Sub txtapellido_Validated(sender As Object, e As EventArgs) Handles txtapellido.Validated
        If txtapellido.Text.Trim.Equals("") Then
            apellido = False
            Me.alertaError.SetError(sender, "Campo Requerido")
        Else
            apellido = True
            Me.alertaError.SetError(sender, "")
        End If
    End Sub
    Private Sub txtEncargado_Validated(sender As Object, e As EventArgs) Handles txtEncargado.Validated
        If txtEncargado.Text.Trim.Equals("") Then
            encargado = False
            Me.alertaError.SetError(sender, "Campo Requerido")
        Else
            encargado = True
            Me.alertaError.SetError(sender, "")
        End If
    End Sub
    Private Sub txtDireccion_Validated(sender As Object, e As EventArgs) Handles txtDireccion.Validated
        If txtDireccion.Text.Trim.Equals("") Then
            direccion = False
            Me.alertaError.SetError(sender, "Campo Requerido")
        Else
            direccion = True
            Me.alertaError.SetError(sender, "")
        End If
    End Sub
#End Region

End Class
