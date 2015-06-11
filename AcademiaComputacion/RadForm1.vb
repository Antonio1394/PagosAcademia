Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System
Imports System.Linq
Imports System.Data
Imports System.Data.Objects
Imports System.Messaging
Imports System.Transactions
Public Class RadForm1
#Region "Variables"
    Dim codigoAlumno As Integer
    Dim idInscripcion As Integer
    Dim fecha As String
    Dim numeroMes As String
    Dim mesNmero As Integer
    Dim mes As String
    Dim idMensualidad As Integer
    Dim idPago
#End Region
#Region "Eventos"
    Private Sub RadForm1_Load(sender As Object, e As EventArgs) Handles Me.Load
        mdHerramientas.conexion()
        lblResultado.Visible = False
        lblResultado2.Visible = False
        txtCuota.ReadOnly = True
        txtMes.ReadOnly = True
        txtAlumno.ReadOnly = True
        txtEncargado.ReadOnly = True
    End Sub
    Private Sub txtCodigoAlumno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoAlumno.KeyDown
        If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue = 8) OrElse (e.KeyValue = 13)) Then
            e.Handled = True
            txtCodigoAlumno.Text = vbNullChar
            Me.ErrorProvider1.SetError(sender, "Solamente numeros se aceptan")
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
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If validacion() Then
            btnSiguiente.Enabled = False
            realizarPago(idMensualidad)
            mostrarReporte(idMensualidad, txtMes.Text)
            Me.RadWizard1.SelectedPage = Me.WizardPage1
            btnSiguiente.Enabled = False
            btnCancelar.Enabled = False
        Else
            MessageBox.Show("Verificar datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            limpiarCampos()
        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim result As DialogResult = MessageBox.Show("Confirmar cancelacion", "Cancelando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If result = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim resultado As DialogResult = MessageBox.Show("Desea modificar la cuota?", "Editar Pago", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resultado = DialogResult.OK Then
            Me.txtCuota.ReadOnly = False
            Me.txtCuota.Focus()
        End If
    End Sub

    Private Sub txtCuota_LostFocus(sender As Object, e As EventArgs) Handles txtCuota.LostFocus
        Me.txtCuota.ReadOnly = True
    End Sub
#End Region
#Region "Funciones"
    Public Sub buscarAlumno(ByVal codigo As Integer)
        Try
            MessageBox.Show(codigo)
            Dim obtenerAlumno = (From x In modelo.students Where x.state = "arriba" And x.id = codigo Select fullName = (x.first_name + " " + x.last_name), x.in_charge).ToList
            If obtenerAlumno.Count = 0 Then
                txtAlumno.Text = ""
                txtEncargado.Text = ""
                txtCodigoAlumno.Text = ""
                txtCuota.Text = ""
                txtMes.Text = ""
                txtCodigoAlumno.Focus()
                lblResultado.Visible = True
            Else
                txtAlumno.Text = obtenerAlumno(0).fullName
                txtEncargado.Text = obtenerAlumno(0).in_charge
                lblResultado.Visible = False
                buscarMensualidad(codigo)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub buscarMensualidad(ByVal codigo As Integer)
        Try
            Dim obtenerIdInscripcion = (From x In modelo.inscripcions Where x.payment.id_student = codigo Select x).FirstOrDefault

            idInscripcion = obtenerIdInscripcion.id

            MessageBox.Show("Este es el id de la inscripcion " & idInscripcion)

            Dim obtenerMensualidad = (From x In modelo.shares Where x.id_inscripcion = idInscripcion And x.balance <> 0 Select x).ToList
            If obtenerMensualidad.Count = 0 Then
                txtMes.Clear()
                txtCuota.Clear()
                lblResultado2.Visible = True

            Else
                lblResultado2.Visible = False
                fecha = obtenerMensualidad(0).date_share
                idMensualidad = obtenerMensualidad(0).id
                numeroMes = fecha.Substring(3, 2)
                mesNmero = Convert.ToInt32(numeroMes)
                If mesNmero = 1 Then
                    mes = "enero"
                ElseIf mesNmero = 2 Then
                    mes = "febrero"
                ElseIf mesNmero = 3 Then
                    mes = "marzo"
                ElseIf mesNmero = 4 Then
                    mes = "abril"
                ElseIf mesNmero = 5 Then
                    mes = "mayo"
                ElseIf mesNmero = 6 Then
                    mes = "junio"
                ElseIf mesNmero = 7 Then
                    mes = "julio"
                ElseIf mesNmero = 8 Then
                    mes = "agosto"
                ElseIf mesNmero = 9 Then
                    mes = "septiembre"
                ElseIf mesNmero = 10 Then
                    mes = "octubre"
                ElseIf mesNmero = 11 Then
                    mes = "noviembre"
                ElseIf mesNmero = 12 Then
                    mes = "diciembre"
                End If
                txtMes.Text = mes
                txtCuota.Text = obtenerMensualidad(0).amount
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub limpiarCampos()
        lblResultado.Visible = False
        txtCodigoAlumno.Clear()
        txtAlumno.Clear()
        txtEncargado.Clear()
        txtMes.Clear()
        txtCuota.Clear()
        txtCodigoAlumno.Focus()
    End Sub
    Public Function validacion()
        If txtCodigoAlumno.Text.Trim.Equals("") Or txtAlumno.Text.Trim.Equals("") Or txtEncargado.Text.Trim.Equals("") Or txtMes.Text.Trim.Equals("") Or txtCuota.Text.Trim.Equals("") Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub realizarPago(ByVal idShare As Integer)
        Using transaction As New TransactionScope()
            Try

                Dim nuevopago As New payment
                nuevopago.no_document = "saf44"
                nuevopago.description = "Mensualidad"
                nuevopago.amount = Val(txtCuota.Text)
                nuevopago.state = "aceptado"
                nuevopago.id_type = 2
                nuevopago.id_user = 1
                nuevopago.id_student = codigoAlumno
                nuevopago.created_at = Date.Now
                nuevopago.updated_at = Date.Now
                modelo.payments.Add(nuevopago)
                modelo.SaveChanges()

                idPago = nuevopago.id

                Dim actualizarMensualidad As share = (From x In modelo.shares Where x.id = idShare Select x).FirstOrDefault
                actualizarMensualidad.id_payment = idPago
                actualizarMensualidad.balance = 0
                actualizarMensualidad.updated_at = Date.Now
                modelo.SaveChanges()

                transaction.Complete()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using

    End Sub
    Public Sub mostrarReporte(ByVal dato As Integer, ByVal mes As String)
        Dim dato1 As New ParameterValues
        Dim dato2 As New ParameterValues

        Dim pvisualizar As New ParameterDiscreteValue
        Dim pvisualizar2 As New ParameterDiscreteValue
        Dim cr1 As New ReporteMensualidad

        pvisualizar.Value = dato
        dato1.Add(pvisualizar)

        pvisualizar2.Value = mes
        dato2.Add(pvisualizar2)

        cr1.DataDefinition.ParameterFields("@idShare").ApplyCurrentValues(dato1)
        cr1.DataDefinition.ParameterFields("@mes").ApplyCurrentValues(dato2)

        Me.CrystalReportViewer1.ReportSource = cr1
    End Sub

#End Region

End Class
