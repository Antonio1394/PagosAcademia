Public Class FrmHorarios

#Region "Variables"
    'si operacion horario es true hay una operacion en proceso
    Dim operacionHorarios As Boolean = False
    'si esta en true es por que estamos modificando
    Dim estadoHorario As Boolean = False
    Dim horario As String
    Dim tipo As Object
    Dim codigoHorario As Integer

#End Region

#Region "Eventos"

    'Evento de eliminaar y modificar'
    Private Sub tbListadoHorarios_CellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles tbListadoHorarios.CommandCellClick
        If operacionHorarios Then
            MessageBox.Show("Hay una operacion en proceso !! ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Me.tbListadoHorarios.Columns(e.ColumnIndex).Name.Equals("eliminar") And e.RowIndex >= 0 Then
                operacionHorarios = True
                Dim resultado As DialogResult
                resultado = MessageBox.Show("Confirma eliminacion del Horario", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If resultado = DialogResult.Yes Then
                    Try
                        codigoHorario = CInt(tbListadoHorarios.Rows(e.RowIndex).Cells("codigo").Value)
                        Dim eliminarHorario As schedules_practice = (From x In modelo.schedules_practice Where x.id = codigoHorario Select x).FirstOrDefault
                        If eliminarHorario.groups.Count > 0 Then

                            Dim modificarHorario As schedules_practice = (From x In modelo.schedules_practice Where x.id = codigoHorario Select x).FirstOrDefault
                            modificarHorario.state = "baja"
                            modificarHorario.updated_at = Date.Now
                            modelo.SaveChanges()
                        Else
                            modelo.schedules_practice.Remove(eliminarHorario)
                            modelo.SaveChanges()
                        End If
                        MessageBox.Show("Horario Eliminado Exitosamente", "Eliminacion Laboratorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        MostrarHorarios()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
                operacionHorarios = False
            End If


            If Me.tbListadoHorarios.Columns(e.ColumnIndex).Name.Equals("modificar") And e.RowIndex >= 0 Then
                Try
                    operacionHorarios = True
                    estadoHorario = True
                    codigoHorario = CInt(tbListadoHorarios.Rows(e.RowIndex).Cells("codigo").Value)
                    txtHorario.Text = CStr(tbListadoHorarios.Rows(e.RowIndex).Cells("horario").Value)
                    cboTipo.Text = CStr(tbListadoHorarios.Rows(e.RowIndex).Cells("jornada").Value)
                    btnGuardar.Text = "Modificar"

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub
    

    'clic en el boton de guardar'
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validacionHorario() Then
            If estadoHorario Then
                modificarHorario()
            Else
                GuardarHorario()
            End If
        Else
            MessageBox.Show("Todos los campos son necesarios", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    'cuando carga el formulario'
    Private Sub FrmHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdHerramientas.conexion()
        MostrarHorarios()
    End Sub
#End Region
#Region "Funciones"
    'Funcion Mostrar Horarios'
    Public Sub MostrarHorarios()
        Try
            tbListadoHorarios.Rows.Clear()
            Dim horario = (From x In modelo.schedules_practice Where x.state = "activo" Select x).ToList
            For Each horarios As schedules_practice In horario
                tbListadoHorarios.Rows.Add({"", horarios.id, horarios.time, horarios.type})
            Next
            tbListadoHorarios.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Funcion para Guardar Un registro'
    Public Sub GuardarHorario()
        horario = txtHorario.Text
        tipo = cboTipo.Text
        Dim nuevoHorario As New schedules_practice
        nuevoHorario.time = horario
        nuevoHorario.type = tipo
        nuevoHorario.state = "activo"
        nuevoHorario.created_at = Date.Now
        nuevoHorario.updated_at = Date.Now
        modelo.schedules_practice.Add(nuevoHorario)
        modelo.SaveChanges()
        MessageBox.Show("Registro Guardado Exitosamente ", "Horarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        limpiarHorarios()
        MostrarHorarios()
    End Sub
    Public Sub modificarHorario()
        If validacionHorario() Then
            Dim modificarHorario As schedules_practice = (From x In modelo.schedules_practice Where x.id = codigoHorario Select x).FirstOrDefault
            modificarHorario.time = txtHorario.Text.Trim
            modificarHorario.type = cboTipo.Text.Trim
            modificarHorario.updated_at = Date.Now
            modelo.SaveChanges()
            MessageBox.Show("Modificacion Exitosa", "Modificar Horario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiarHorarios()
            btnGuardar.Text = "Guardar"
            MostrarHorarios()
            estadoHorario = False
            operacionHorarios = False
        Else
            MessageBox.Show("Todos los campos son necesarios", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Public Function validacionHorario()
        If txtHorario.Text.Trim.Length = 0 Or cboTipo.Text.Trim.Length = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub limpiarHorarios()
        txtHorario.Clear()
        cboTipo.Text = ""

    End Sub
#End Region

   

    
   

  
End Class
