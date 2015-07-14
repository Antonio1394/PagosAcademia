Public Class FrmLaboratorios

#Region "Laboratorios"
#Region "Variables"

    Dim operacionHorarios As Boolean = False
    Dim nombreLaboratorio As String
    Dim descripcionLaboratorio As String
    Dim numeroComputadoras As Integer
    Dim estadoLaboratorio As Boolean = False
    Dim codigoLaboratorio As Integer
#End Region

#Region "Eventos"
    'Mostrar Laboratorios'
    Private Sub FrmLaboratorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            If Me.tblListadoLaboratorios.Columns(e.ColumnIndex).Name.Equals("eliminar") And e.RowIndex >= 0 Then
                estadoLaboratorio = True
                Dim resultado As DialogResult
                resultado = MessageBox.Show("Confirma eliminacion de el Laboratorio", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If resultado = DialogResult.Yes Then
                    Try
                        codigoLaboratorio = CInt(tblListadoLaboratorios.Rows(e.RowIndex).Cells("codigo").Value)
                        Dim eliminarLaboratorio As laboratory = (From x In modelo.laboratories Where x.id = codigoLaboratorio Select x).FirstOrDefault
                        If eliminarLaboratorio.groups.Count > 0 Then
                            Dim modificarLaboratorio As laboratory = (From x In modelo.laboratories Where x.id = codigoLaboratorio Select x).FirstOrDefault
                            modificarLaboratorio.state = "baja"
                            modificarLaboratorio.updated_at = Date.Now
                            modelo.SaveChanges()
                            MessageBox.Show("Laboratorio Eliminado Exitosamente", "Eliminacion Laboratorio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            MostrarLaboratorios()
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


            If Me.tblListadoLaboratorios.Columns(e.ColumnIndex).Name.Equals("modificar") And e.RowIndex >= 0 Then
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
            Dim Laboratorio = (From x In modelo.laboratories Where x.state = "activo" Select x).ToList
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
            modificarLaboratorio.updated_at = Date.Now
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
