Public Class FrmInicio


#Region "Programas"

#Region "Variables"
    Dim operacionPrograma As Boolean = False
    Dim descripcionPrograma As String
    Dim duracionPrograma As Integer
    Dim estadoPrograma As Boolean = False
    Dim codigoPrograma As Integer

#End Region

#Region "Eventos"
    'cuando carga la pagina
    Private Sub PaginaProgramas_Paint(sender As Object, e As PaintEventArgs) Handles PaginaProgramas.Paint
        mdHerramientas.conexion()
        MostrarProgramas()
    End Sub
    'Evento click del boton guardar
    Private Sub btnGuardarPagina1_Click(sender As Object, e As EventArgs) Handles btnGuardarPagina1.Click
        If validacionPrograma() Then
            If estadoPrograma Then
                modificarPrograma()
            Else
                GuardarProgramas()
            End If

        Else
            MessageBox.Show("Todos los campos son necesarios", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    'Evento de eliminar y modificar
    Private Sub tblListadoProgramas_CellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles tblListadoProgramas.CellClick
        If estadoPrograma Then
            MessageBox.Show("Hay una operacion en proceso !! ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Me.tblListadoProgramas.Columns(e.ColumnIndex).Name.Equals("eliminar") Then
                estadoPrograma = True
                codigoPrograma = CInt(tblListadoProgramas.Rows(e.RowIndex).Cells("codigo").Value)
                estadoPrograma = False
            End If


            If Me.tblListadoProgramas.Columns(e.ColumnIndex).Name.Equals("modificar") Then
                Try
                    estadoPrograma = True
                    codigoPrograma = CInt(tblListadoProgramas.Rows(e.RowIndex).Cells("codigo").Value)
                    txtDescripcionPagina1.Text = CStr(tblListadoProgramas.Rows(e.RowIndex).Cells("descripcion").Value)
                    txtTiempoPagina1.Text = CStr(tblListadoProgramas.Rows(e.RowIndex).Cells("duracion").Value)
                    btnGuardarPagina1.Text = "Modificar"
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub
#End Region

#Region "Funciones"
    'Mostrar programas
    Public Sub MostrarProgramas()
        Try
            tblListadoProgramas.Rows.Clear()
            Dim programa = (From x In modelo.programs Select x).ToList
            For Each programas As program In programa
                tblListadoProgramas.Rows.Add({"", programas.id, programas.description, programas.shelf_life})
            Next
            tblListadoProgramas.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Guardar Registro
    Public Sub GuardarProgramas()
        Try
            estadoPrograma = True
            descripcionPrograma = txtDescripcionPagina1.Text.Trim
            duracionPrograma = Val(txtTiempoPagina1.Text.Trim)
            Dim nuevoPrograma As New program
            nuevoPrograma.description = descripcionPrograma
            nuevoPrograma.shelf_life = duracionPrograma
            nuevoPrograma.state = "activo"
            nuevoPrograma.created_at = Date.Now
            nuevoPrograma.updated_at = Date.Now
            modelo.programs.Add(nuevoPrograma)
            modelo.SaveChanges()
            MessageBox.Show("Registro Guardado Exitosamente", "Programas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiarProgramas()
            MostrarProgramas()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        estadoPrograma = False

    End Sub
    'Modificar Programa
    Public Sub modificarPrograma()
        If validacionPrograma() Then

            Dim modificarPrograma As program = (From x In modelo.programs Where x.id = codigoPrograma Select x).FirstOrDefault


            modificarPrograma.description = txtDescripcionPagina1.Text.Trim
            modificarPrograma.shelf_life = txtTiempoPagina1.Text.Trim
            modelo.SaveChanges()
            MessageBox.Show("Modificacion Exitosa", "Modificar Programa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiarProgramas()
            btnGuardarPagina1.Text = "Guardar"
            MostrarProgramas()
            estadoPrograma = False
        Else
            MessageBox.Show("Todos los campos son necesarios", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    'validar el formulario programas
    Public Function validacionPrograma()
        If txtDescripcionPagina1.Text.Trim.Length = 0 Or txtTiempoPagina1.Text.Trim.Length = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    'Liimpiar los cuadros de texto
    Public Sub limpiarProgramas()
        txtDescripcionPagina1.Text = ""
        txtTiempoPagina1.Text = ""
        txtDescripcionPagina1.Focus()
    End Sub
#End Region

#End Region


#Region "Horarios"
#Region "Variables"
    Dim operacionHorarios As Boolean = False
    Dim nombreLaboratorio As String
    Dim descripcionLaboratorio As String
    Dim numeroComputadoras As Integer
    Dim estadoLaboratorio As Boolean = False
    Dim codigoLaboratorio As Integer


#End Region

#Region "Eventos"
    Private Sub RadPageViewPage2_Paint(sender As Object, e As PaintEventArgs) Handles PaginaHorarios.Paint
        mdHerramientas.conexion()
        MostrarHorarios()


    End Sub
#End Region

#Region "Funciones"

    'Funcion que llena el grid de horarios'
    Public Sub MostrarHorarios()
        Try
            tbListadoHorarios.Rows.Clear()
            Dim horario = (From x In modelo.schedules_practice Select x).ToList
            For Each horarios As schedules_practice In horario
                tbListadoHorarios.Rows.Add({"", horarios.id, horarios.time, horarios.type})
            Next
            tbListadoHorarios.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
#End Region


#Region "Laboratorios"
#Region "Variables"

#End Region

#Region "Eventos"
    'Mostrar Laboratorios'
    Private Sub PaginaLaboratorios_Paint(sender As Object, e As PaintEventArgs) Handles PaginaLaboratorios.Paint
        mdHerramientas.conexion()
        MostrarLaboratorios()
    End Sub

    'guardar Laboratorios'
    Private Sub btnGuardarLaboratorios_Click(sender As Object, e As EventArgs) Handles btnGuardarLaboratorios.Click
        If validacionLaboratorio() Then
            If estadoLaboratorio Then
                modificarLaboratorio()
            Else
                GuardarLaboratorio()
            End If

        Else
            MessageBox.Show("Todos los campos son necesarios", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub




    Private Sub tblListadoLaboratorios_CellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles tblListadoLaboratorios.CellClick
        If estadoLaboratorio Then
            MessageBox.Show("Hay una operacion en proceso !! ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Me.tblListadoLaboratorios.Columns(e.ColumnIndex).Name.Equals("eliminar") Then
                estadoLaboratorio = True
                Dim resultado As DialogResult
                resultado = MessageBox.Show("Confirma eliminacion de el Laboratorio", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If resultado = DialogResult.OK Then
                    Try
                        codigoLaboratorio = CInt(tblListadoLaboratorios.Rows(e.RowIndex).Cells("codigo").Value)
                        Dim eliminarLaboratorio As laboratory = (From x In modelo.laboratories Where x.id = codigoLaboratorio Select x).FirstOrDefault
                        If eliminarLaboratorio.groups.Count > 0 Then
                            MessageBox.Show("Error al eliminar el Laboratorio", "Eliminacion Laboratorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            modelo.laboratories.Remove(eliminarLaboratorio)
                            modelo.SaveChanges()

                            MessageBox.Show("Laboratorio Eliminado Exitosamente", "Eliminacion Laboratorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            MostrarLaboratorios()
                        End If

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
                estadoLaboratorio = False
            End If


            If Me.tblListadoLaboratorios.Columns(e.ColumnIndex).Name.Equals("modificar") Then
                Try
                    estadoLaboratorio = True
                    codigoLaboratorio = CInt(tblListadoLaboratorios.Rows(e.RowIndex).Cells("codigo").Value)
                    txtNombreLaboratorio.Text = CStr(tblListadoLaboratorios.Rows(e.RowIndex).Cells("nombre").Value)
                    txtDescripcionLaboratorio.Text = CStr(tblListadoLaboratorios.Rows(e.RowIndex).Cells("descripcion").Value)
                    txtComputadoras.Value = CStr(tblListadoLaboratorios.Rows(e.RowIndex).Cells("computadoras").Value)

                    btnGuardarLaboratorios.Text = "Modificar"
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub




#End Region

#Region "Funciones"
    Public Sub MostrarLaboratorios()
        Try
            tblListadoLaboratorios.Rows.Clear()
            Dim Laboratorio = (From x In modelo.laboratories Select x).ToList
            For Each Laboratorios As laboratory In Laboratorio
                tblListadoLaboratorios.Rows.Add({"", Laboratorios.id, Laboratorios.title, Laboratorios.description, Laboratorios.computers})
            Next
            tblListadoLaboratorios.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    'Guardar Laboratorio'
    Public Sub GuardarLaboratorio()
        Try
            estadoLaboratorio = True
            nombreLaboratorio = txtNombreLaboratorio.Text.Trim
            descripcionLaboratorio = txtDescripcionLaboratorio.Text.Trim
            numeroComputadoras = txtComputadoras.Value
            Dim nuevoLaboratorio As New laboratory 'inicia'
            nuevoLaboratorio.title = nombreLaboratorio
            nuevoLaboratorio.description = descripcionLaboratorio
            nuevoLaboratorio.computers = numeroComputadoras
            nuevoLaboratorio.state = "activo"
            nuevoLaboratorio.created_at = Date.Now
            nuevoLaboratorio.updated_at = Date.Now
            modelo.laboratories.Add(nuevoLaboratorio)
            modelo.SaveChanges()
            MessageBox.Show("Registro Guardado Exitosamente", "Laboratorios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiarLaboratorios() 'limpia los cuadros de texto'
            MostrarLaboratorios() ' llena de nuevo el grid'

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        estadoLaboratorio = False

    End Sub

    'limpiar cuadros de Laboratorios'
    Public Sub limpiarLaboratorios()
        txtNombreLaboratorio.Text = ""
        txtDescripcionLaboratorio.Text = ""
        txtComputadoras.Value = 0
        txtNombreLaboratorio.Focus()

    End Sub


    'modificar Laboratorio'
    Public Sub modificarLaboratorio()
        If validacionLaboratorio() Then

            Dim modificarLaboratorio As laboratory = (From x In modelo.laboratories Where x.id = codigoLaboratorio Select x).FirstOrDefault


            modificarLaboratorio.title = txtNombreLaboratorio.Text.Trim
            modificarLaboratorio.description = txtDescripcionLaboratorio.Text.Trim
            modificarLaboratorio.computers = txtComputadoras.Value
            modelo.SaveChanges()
            MessageBox.Show("Modificacion Exitosa", "Modificar Laboratorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiarLaboratorios()
            btnGuardarLaboratorios.Text = "Guardar"
            MostrarLaboratorios()
            estadoLaboratorio = False
        Else
            MessageBox.Show("Todos los campos son necesarios", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub


    Public Function validacionLaboratorio()
        If txtNombreLaboratorio.Text.Trim.Length = 0 Or txtDescripcionLaboratorio.Text.Trim.Length = 0 Or txtComputadoras.Value = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

#End Region
#End Region

End Class
