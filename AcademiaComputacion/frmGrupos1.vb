Public Class FrmGrupos1
#Region "Variables"
    Dim indexJornada As Integer
    Dim vectorDias(7) As String
    Dim dias As String
    Dim obtenerDia As String
    Dim obtenerJornada As String
    Dim listaMaestros As New List(Of Integer)
    Dim listaLaboratorios As New List(Of Integer)
    Dim listaHorarios As New List(Of Integer)
    Dim idLaboratorio As Integer
    Dim guardar As Boolean = False 'indica que se guardara si esta en true se modificara 
    Dim operacion As Boolean = False  'True indica que hay una operacion en proceso
    Dim codigoGrupo As Integer
#End Region
#Region "Eventos"
    Private Sub FrmGrupos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdHerramientas.conexion()
        programasDisponibles()
        mostrarGrupos()
    End Sub
    Private Sub cboJornada_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles cboJornada.SelectedIndexChanged
        'Obtener el indice del combo
        'si es cero "0" esta seleccionado Diario
        'si es uno "1" esta seleccionado fin de semana
        limpiarCombox()
        indexJornada = cboJornada.SelectedIndex
        cargarDias(indexJornada)
    End Sub
    Private Sub cboDia_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles cboDia.SelectedIndexChanged
        'obtenemos la Jornada y el dia para buscar los 
        'maestros disponibles 
        cboHorarioPractica.Text = ""
        obtenerJornada = cboJornada.Text
        obtenerDia = cboDia.Text
        catedraticosDisponibles(obtenerJornada, obtenerDia)
        laboratoriosDisponibles(obtenerDia, 10)
        horariosDisponibles(obtenerJornada, obtenerDia)
    End Sub
    Private Sub cboLaboratorio_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles cboLaboratorio.SelectedIndexChanged
        cboHorarioPractica.Text = ""
        obtenerJornada = cboJornada.Text
        obtenerDia = cboDia.Text
        horariosDisponibles(obtenerJornada, obtenerDia)
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validacion() Then
            If guardar Then
                btnGuardar.Text = "Crear Registro"
                guardar = False
            Else
                guardarRegistro()
            End If
        Else
            MessageBox.Show("Todos los Campos son Necesarios", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    'Evento de eliminaar y modificar'
    Private Sub tblGrupos_CellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles tblGrupos.CommandCellClick
        If operacion Then
            MessageBox.Show("Hay una operacion en proceso !! ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Me.tblGrupos.Columns(e.ColumnIndex).Name.Equals("eliminar") And e.RowIndex >= 0 Then
                operacion = True
                Dim resultado As DialogResult
                resultado = MessageBox.Show("Confirma eliminacion del Grupo", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If resultado = DialogResult.OK Then
                    Try
                        codigoGrupo = CInt(tblGrupos.Rows(e.RowIndex).Cells("codigo").Value)
                        MessageBox.Show(codigoGrupo)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
                operacion = False
            End If
            If Me.tblGrupos.Columns(e.ColumnIndex).Name.Equals("modificar") And e.RowIndex >= 0 Then
                Try
                    operacion = True
                    guardar = True
                    btnGuardar.Text = "Modificar Registro"
                    codigoGrupo = CInt(tblGrupos.Rows(e.RowIndex).Cells("codigo").Value)
                    MessageBox.Show(codigoGrupo)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

#End Region
#Region "Funciones"
    Public Sub limpiarCombox()
        cboDia.DataSource = ""
        cboCatedratico.DataSource = ""
        cboLaboratorio.DataSource = ""
        cboHorarioPractica.DataSource = ""
        txtHorario.Clear()
    End Sub
    Public Sub cargarDias(ByVal tipoJornada As Integer)
        If tipoJornada Then
            dias = "Sabado,Domingo"
            vectorDias = Split(dias, ",")
        Else
            dias = "Lunes,Martes,Miercoles,Jueves,Viernes"
            vectorDias = Split(dias, ",")
        End If
        cboDia.DataSource = vectorDias
    End Sub
    Public Sub catedraticosDisponibles(ByVal tipoJornada As String, ByVal dia As String)
        listaMaestros.Clear()
        Dim getMaestrosGrupos = (From x In modelo.groups Where x.day = dia And x.state = "arriba" Select x.id_employee Group By id_employee Into total = Count(id_employee) Where total > 2).ToArray
        For x = LBound(getMaestrosGrupos) To UBound(getMaestrosGrupos)
            listaMaestros.Add(getMaestrosGrupos(x).id_employee)
        Next
        Dim getMaestros = (From x In modelo.employees Where Not listaMaestros.Contains(x.id) Select x.id, FullName = x.first_name & " " & x.last_name).ToList

        With cboCatedratico
            .ValueMember = "id"
            .DisplayMember = "FullName"
            .DataSource = getMaestros
        End With
    End Sub
    Public Sub laboratoriosDisponibles(ByVal dia As String, ByVal limite As Integer)
        listaLaboratorios.Clear()
        Dim getLaboratoriosGrupos = (From x In modelo.groups Where x.day = dia And x.state = "arriba" Select x.id_laboratorie Group By id_laboratorie Into total = Count(id_laboratorie) Where total > limite).ToArray
        For x = LBound(getLaboratoriosGrupos) To UBound(getLaboratoriosGrupos)
            listaLaboratorios.Add(getLaboratoriosGrupos(x).id_laboratorie)
        Next
        Dim getLaboratorios = (From x In modelo.laboratories Where Not listaLaboratorios.Contains(x.id) Select x.id, x.title).ToList
        With cboLaboratorio
            .ValueMember = "id"
            .DisplayMember = "title"
            .DataSource = getLaboratorios
        End With
    End Sub
    Public Sub horariosDisponibles(ByVal jornada As String, ByVal dia As String)
        idLaboratorio = cboLaboratorio.SelectedValue
        listaHorarios.Clear()
        Dim getHorariosDisponibles = (From x In modelo.groups Where x.id_laboratorie = idLaboratorio And x.day = dia And x.state = "arriba" Select x.time_practice).ToArray
        For x = LBound(getHorariosDisponibles) To UBound(getHorariosDisponibles)
            listaHorarios.Add(getHorariosDisponibles(x))
        Next
        Dim getHorarios = (From x In modelo.schedules_practice Where Not listaHorarios.Contains(x.id) And x.type = jornada And x.state = "arriba" Select x.id, x.time).ToList
        With cboHorarioPractica
            .ValueMember = "id"
            .DisplayMember = "time"
            .DataSource = getHorarios
        End With
    End Sub
    Public Sub programasDisponibles()
        Dim getProgramas = (From x In modelo.programs Where x.state = "arriba" Select x.id, x.description).ToList
        With cboProgramas
            .ValueMember = "id"
            .DisplayMember = "description"
            .DataSource = getProgramas
        End With
    End Sub
    Public Sub mostrarGrupos()
        Dim getGrupos = (From x In modelo.groups Where x.state = "arriba" Select x).ToList

        For Each grupos As group In getGrupos
            tblGrupos.Rows.Add(grupos.id, grupos.day, grupos.schedules_practice.time, grupos.program.description, grupos.employee.first_name)
        Next
        tblGrupos.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
    End Sub
    Public Function validacion()
        If cboJornada.SelectedIndex = -1 Or cboDia.SelectedIndex = -1 Or cboCatedratico.SelectedIndex = -1 Or cboLaboratorio.SelectedIndex = -1 Or cboHorarioPractica.SelectedIndex = -1 Or cboProgramas.SelectedIndex = -1 Or txtHorario.Text.Equals("") Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub guardarRegistro()
        Try
            Dim nuevoGrupo As New group
            nuevoGrupo.id_program = cboProgramas.SelectedValue
            nuevoGrupo.id_laboratorie = cboLaboratorio.SelectedValue
            nuevoGrupo.id_employee = cboCatedratico.SelectedValue
            nuevoGrupo.time_practice = cboHorarioPractica.SelectedValue
            nuevoGrupo.day = cboDia.Text
            nuevoGrupo.schedule = txtHorario.Text
            nuevoGrupo.created_at = Date.Now
            nuevoGrupo.updated_at = Date.Now
            nuevoGrupo.state = "arriba"
            modelo.groups.Add(nuevoGrupo)
            modelo.SaveChanges()
            MessageBox.Show("Registro Guardado Exitosamente ", "Grupos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboJornada.Text = "Seleccione una opcion"
            cboJornada.SelectedIndex = -1
            limpiarCombox()
            mostrarGrupos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "Validar Campos"
    Private Sub cboJornada_Validated(sender As Object, e As EventArgs) Handles cboJornada.Validated
        If cboJornada.SelectedIndex = -1 Then
            Me.AlertaError.SetError(sender, "Seleccione una Jornada")
        Else
            Me.AlertaError.SetError(sender, "")
        End If
    End Sub
    Private Sub cboDia_Validated(sender As Object, e As EventArgs) Handles cboDia.Validated
        If cboDia.SelectedIndex = -1 Then
            Me.AlertaError.SetError(sender, "Seleccione un Dia")
        Else
            Me.AlertaError.SetError(sender, "")
        End If
    End Sub
    Private Sub cboCatedratico_Validated(sender As Object, e As EventArgs) Handles cboCatedratico.Validated
        If cboCatedratico.SelectedIndex = -1 Then
            Me.AlertaError.SetError(sender, "Seleccione un Catedratico")
        Else
            Me.AlertaError.SetError(sender, "")
        End If
    End Sub
    Private Sub cboLaboratorio_Validated(sender As Object, e As EventArgs) Handles cboLaboratorio.Validated
        If cboLaboratorio.SelectedIndex = -1 Then
            Me.AlertaError.SetError(sender, "Seleccione un Laboratorio")
        Else
            Me.AlertaError.SetError(sender, "")
        End If
    End Sub
    Private Sub cboHorarioPractica_Validated(sender As Object, e As EventArgs) Handles cboHorarioPractica.Validated
        If cboHorarioPractica.SelectedIndex = -1 Then
            Me.AlertaError.SetError(sender, "Seleccione un Horario")
        Else
            Me.AlertaError.SetError(sender, "")
        End If
    End Sub
    Private Sub cboProgramas_StyleChanged(sender As Object, e As EventArgs) Handles cboProgramas.StyleChanged
        If cboProgramas.SelectedIndex = -1 Then
            Me.AlertaError.SetError(sender, "Seleccione un Horario")
        Else
            Me.AlertaError.SetError(sender, "")
        End If
    End Sub
    Private Sub txtHorario_Validated(sender As Object, e As EventArgs) Handles txtHorario.Validated
        If txtHorario.Text.Trim.Equals("") Then
            Me.AlertaError.SetError(sender, "Ingrese el horario del grupo")
        Else
            Me.AlertaError.SetError(sender, "")
        End If
    End Sub
#End Region
End Class
