Public Class FrmPrincipal

    'muestra el formulario Programas'
    Private Sub RadButtonElement5_Click(sender As Object, e As EventArgs) Handles RadButtonElement5.Click
        Dim programa As New FrmProgramas
        programa.MdiParent = Me
        programa.Show()
    End Sub

    'muestra el formulario de Laboratorio
    Private Sub RadButtonElement6_Click(sender As Object, e As EventArgs) Handles RadButtonElement6.Click
        Dim laboratorio As New FrmLaboratorios
        laboratorio.MdiParent = Me
        laboratorio.Show()

    End Sub

    
    'Muestra al Formulario Horarios'
    Private Sub RadButtonElement4_Click(sender As Object, e As EventArgs) Handles RadButtonElement4.Click
        Dim horario As New FrmHorarios
        horario.MdiParent = Me
        horario.Show()

    End Sub

    Private Sub RadButtonElement8_Click(sender As Object, e As EventArgs) Handles RadButtonElement8.Click
        Dim tipoEmpleado As New FrmTipoEmpleado
        tipoEmpleado.MdiParent = Me
        tipoEmpleado.Show()

    End Sub

    Private Sub RadButtonElement7_Click(sender As Object, e As EventArgs) Handles RadButtonElement7.Click
        Dim empleado As New FrmEmpleado
        empleado.MdiParent = Me
        empleado.Show()

    End Sub

    Private Sub RadButtonElement11_Click(sender As Object, e As EventArgs) Handles RadButtonElement11.Click
        Dim grupos As New FrmGrupos1
        grupos.MdiParent = Me
        grupos.Show()

    End Sub

    Private Sub RadButtonElement10_Click(sender As Object, e As EventArgs) Handles RadButtonElement10.Click
        Dim usuarios As New FrmUsuarios
        usuarios.MdiParent = Me
        usuarios.Show()

    End Sub
End Class
