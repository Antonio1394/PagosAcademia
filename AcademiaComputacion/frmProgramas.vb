Public Class FrmProgramas

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
    Private Sub FrmProgramas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            If Me.tblListadoProgramas.Columns(e.ColumnIndex).Name.Equals("eliminar") And e.RowIndex >= 0 Then
                estadoPrograma = True
                Dim resultado As DialogResult
                resultado = MessageBox.Show("Confirma la eliminacion del Programa", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                If resultado = DialogResult.OK Then
                    Try
                        codigoPrograma = CInt(tblListadoProgramas.Rows(e.RowIndex).Cells("codigo").Value)
                        Dim eliminarPrograma As program = (From x In modelo.programs Where x.id = codigoPrograma Select x).FirstOrDefault
                        If eliminarPrograma.groups.Count > 0 Then
                            Dim modificarPrograma As program = (From x In modelo.programs Where x.id = codigoPrograma Select x).FirstOrDefault
                            modificarPrograma.state = "baja"
                            modificarPrograma.updated_at = Date.Now
                            modelo.SaveChanges()
                            MessageBox.Show("Programa Eliminado Exitosamente", "Eliminacion Progarma", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            MostrarProgramas()
                        Else
                            modelo.programs.Remove(eliminarPrograma)
                            modelo.SaveChanges()
                            MessageBox.Show("Programa Eliminado Exitosamente", "Eliminacion Progarma", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            MostrarProgramas()
                        End If


                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                End If
                estadoPrograma = False
            End If


            If Me.tblListadoProgramas.Columns(e.ColumnIndex).Name.Equals("modificar") And e.RowIndex >= 0 Then
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
            Dim programa = (From x In modelo.programs Where x.state = "activo" Select x).ToList
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
            modificarPrograma.updated_at = Date.Now
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


   
End Class
