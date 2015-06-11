Public Class FrmPagos

    Private Sub FrmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdHerramientas.conexion()
        mostrarPagos()
    End Sub

    Public Sub mostrarPagos()
        Try
            listadoPagos.Rows.Clear()
            Dim getPayment = (From x In modelo.payments Select x).ToList

            For Each pagos As payment In getPayment
                listadoPagos.Rows.Add(pagos.id, pagos.created_at, pagos.description, pagos.amount, " ", pagos.payment_types.description, pagos.no_document, pagos.state, pagos.user.employee.first_name)
            Next

            listadoPagos.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try






    End Sub
End Class
