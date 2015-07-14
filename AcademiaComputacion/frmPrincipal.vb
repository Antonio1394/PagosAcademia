Public Class FrmPrincipal

    'muestra el formulario Programas'
    Private Sub RadButtonElement5_Click(sender As Object, e As EventArgs) Handles RadButtonElement5.Click

        FrmProgramas.MdiParent = Me
        FrmProgramas.Show()
    End Sub

    'muestra el formulario de Laboratorio
    Private Sub RadButtonElement6_Click(sender As Object, e As EventArgs) Handles RadButtonElement6.Click

        FrmLaboratorios.MdiParent = Me
        FrmLaboratorios.Show()

    End Sub

    
    'Muestra al Formulario Horarios'
    Private Sub RadButtonElement4_Click(sender As Object, e As EventArgs) Handles RadButtonElement4.Click

        FrmHorarios.MdiParent = Me
        FrmHorarios.Show()

    End Sub

    Private Sub RadButtonElement8_Click(sender As Object, e As EventArgs) Handles RadButtonElement8.Click

        FrmTipoEmpleado.MdiParent = Me
        FrmTipoEmpleado.Show()

    End Sub

    Private Sub RadButtonElement7_Click(sender As Object, e As EventArgs) Handles RadButtonElement7.Click

        FrmEmpleado.MdiParent = Me
        FrmEmpleado.Show()

    End Sub

    Private Sub RadButtonElement11_Click(sender As Object, e As EventArgs) Handles RadButtonElement11.Click

        FrmGrupos1.MdiParent = Me
        FrmGrupos1.Show()

    End Sub

    Private Sub RadButtonElement10_Click(ByVal sender As Object, e As EventArgs) Handles RadButtonElement10.Click

        FrmUsuarios.MdiParent = Me
        FrmUsuarios.Show()

       
    End Sub




   
    Private Sub RadMenuItem2_Click(sender As Object, e As EventArgs) Handles RadMenuItem2.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("Desea cerrar Sesion??", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If resultado = DialogResult.Yes Then
            Me.Close()
            FrmLogin.Show()

        Else
            MessageBox.Show("Noooo")
        End If
    End Sub
End Class
