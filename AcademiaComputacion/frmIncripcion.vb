Public Class FrmIncripcion
#Region "Variables"
    Dim nombre As Boolean = False
    Dim apellido As Boolean = False
    Dim direccion As Boolean = False
    Dim encargado As Boolean = False
    Dim paginaSeleccionada As Integer = 0
#End Region


#Region "Eventos"
    Private Sub FrmIncripcion_Load(sender As Object, e As EventArgs) Handles Me.Load
        mdHerramientas.conexion()
        cargarPromotor()
        cargarGrupos()
    End Sub
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        verificarPagina()
        If paginaSeleccionada = 1 Then
            If validacion() Then
                Me.wizarInscripcion.SelectedPage = Me.WizardPage1
            Else
                MessageBox.Show("Verificar Datos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
#End Region

#Region "Funciones"
    Public Sub verificarPagina()
        If Me.wizarInscripcion.SelectedPage.Name.Equals("WizardWelcomePage1") Then
            paginaSeleccionada = 1
        End If
    End Sub
    Public Function validacion()
        If nombre And apellido And direccion And encargado Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub cargarPromotor()
        Dim promotores = (From x In modelo.employees Where x.id_type_employee = 4 And x.state = "activo" Select x.id, FullName = x.firs_name & " " & x.last_name).ToList
        With cboPromotor
            .ValueMember = "id"
            .DisplayMember = "FullName"
            .DataSource = promotores
        End With
    End Sub
    Public Sub cargarGrupos()
        Dim grupos = (From x In modelo.groups Where x.state = "activo" Select x.id, FullName = x.day & " " & x.schedule).ToList
        With cboGrupo
            .ValueMember = "id"
            .DisplayMember = "FullName"
            .DataSource = grupos
        End With
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
