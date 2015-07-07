Public Class FrmEstudiantes

    Private Sub FrmEstudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdHerramientas.conexion()
        mostarAlumnos()

    End Sub
    Public Sub mostarAlumnos()
        Dim getStudents = (From x In modelo.students Where x.state = "arriba" Select x).ToList



        For Each estudiante As student In getStudents
            listadoAlumnos.Rows.Add(estudiante.id, estudiante.first_name, estudiante.last_name, estudiante.phone, estudiante.addres, estudiante.in_charge, estudiante.state)
        Next
        listadoAlumnos.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

    End Sub
End Class
