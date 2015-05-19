Public Class FrmGrupos
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
        obtenerJornada = cboJornada.Text
        If obtenerJornada = "Fin de semana" Then
            obtenerJornada = "fin_de_semana"
        End If
        obtenerDia = cboDia.Text
        catedraticosDisponibles(obtenerJornada, obtenerDia)
        laboratoriosDisponibles(obtenerDia, 10)
        horariosDisponibles(obtenerJornada, obtenerDia)
    End Sub
    Private Sub cboLaboratorio_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles cboLaboratorio.SelectedIndexChanged
        obtenerJornada = cboJornada.Text
        If obtenerJornada = "Fin de semana" Then
            obtenerJornada = "fin_de_semana"
        End If
        obtenerDia = cboDia.Text
        horariosDisponibles(obtenerJornada, obtenerDia)
    End Sub
#End Region
#Region "Funciones"
    Public Sub limpiarCombox()
        cboDia.DataSource = ""
        cboCatedratico.DataSource = ""
        cboLaboratorio.DataSource = ""
        cboHorarioPractica.DataSource = ""
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
        Dim getMaestrosGrupos = (From x In modelo.groups Where x.day = dia And x.state = "activo" Select x.id_employee Group By id_employee Into total = Count(id_employee) Where total > 2).ToArray
        For x = LBound(getMaestrosGrupos) To UBound(getMaestrosGrupos)
            listaMaestros.Add(getMaestrosGrupos(x).id_employee)
        Next
        Dim getMaestros = (From x In modelo.employees Where Not listaMaestros.Contains(x.id) Select x.id, FullName = x.firs_name & " " & x.last_name).ToList

        With cboCatedratico
            .ValueMember = "id"
            .DisplayMember = "FullName"
            .DataSource = getMaestros
        End With
    End Sub
    Public Sub laboratoriosDisponibles(ByVal dia As String, ByVal limite As Integer)
        listaLaboratorios.Clear()
        Dim getLaboratoriosGrupos = (From x In modelo.groups Where x.day = dia And x.state = "activo" Select x.id_laboratorie Group By id_laboratorie Into total = Count(id_laboratorie) Where total > limite).ToArray
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
        Dim getHorariosDisponibles = (From x In modelo.groups Where x.id_laboratorie = idLaboratorio And x.day = dia And x.state = "activo" Select x.time_practice).ToArray
        For x = LBound(getHorariosDisponibles) To UBound(getHorariosDisponibles)
            listaHorarios.Add(getHorariosDisponibles(x))
        Next
        Dim getHorarios = (From x In modelo.schedules_practice Where Not listaHorarios.Contains(x.id) And x.type = jornada And x.state = "activo" Select x.id, x.time).ToList
        With cboHorarioPractica
            .ValueMember = "id"
            .DisplayMember = "time"
            .DataSource = getHorarios
        End With
    End Sub
    Public Sub programasDisponibles()
        Dim getProgramas = (From x In modelo.programs Where x.state = "activo" Select x.id, x.description).ToList
        With cboProgramas
            .ValueMember = "id"
            .DisplayMember = "description"
            .DataSource = getProgramas
        End With
    End Sub
    Public Sub mostrarGrupos()
        Dim getGrupos = (From x In modelo.groups Where x.state = "activo" Select x).ToList

        For Each grupos As group In getGrupos
            tblGrupos.Rows.Add(grupos.day, grupos.schedules_practice.time, grupos.program.description, grupos.employee.firs_name, grupos.user.employee.firs_name)
        Next
        tblGrupos.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
    End Sub
#End Region
End Class
