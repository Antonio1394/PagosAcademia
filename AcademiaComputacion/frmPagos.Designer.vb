<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagos
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn9 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.listadoPagos = New Telerik.WinControls.UI.RadGridView()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.listadoPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listadoPagos.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.listadoPagos)
        Me.RadPanel1.Location = New System.Drawing.Point(28, 12)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(941, 432)
        Me.RadPanel1.TabIndex = 0
        Me.RadPanel1.ThemeName = "VisualStudio2012Light"
        '
        'listadoPagos
        '
        Me.listadoPagos.BackColor = System.Drawing.Color.White
        Me.listadoPagos.Cursor = System.Windows.Forms.Cursors.Default
        Me.listadoPagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listadoPagos.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.listadoPagos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.listadoPagos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.listadoPagos.Location = New System.Drawing.Point(0, 0)
        '
        'listadoPagos
        '
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "idPago"
        GridViewTextBoxColumn1.HeaderText = "Id Pago"
        GridViewTextBoxColumn1.Name = "idPago"
        GridViewTextBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
        GridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn1.Width = 67
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "fecha_creacion"
        GridViewTextBoxColumn2.HeaderText = "Fecha"
        GridViewTextBoxColumn2.Name = "fecha_creacion"
        GridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        GridViewTextBoxColumn2.Width = 82
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "tipoPago"
        GridViewTextBoxColumn3.HeaderText = "Tipo de pago"
        GridViewTextBoxColumn3.Name = "tipoPago"
        GridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn3.Width = 119
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "monto"
        GridViewTextBoxColumn4.HeaderText = "Cantidad"
        GridViewTextBoxColumn4.Name = "monto"
        GridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn4.Width = 119
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "alumno"
        GridViewTextBoxColumn5.HeaderText = "Alumno"
        GridViewTextBoxColumn5.Name = "alumno"
        GridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn5.Width = 136
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.FieldName = "descripcion"
        GridViewTextBoxColumn6.HeaderText = "Descripcion"
        GridViewTextBoxColumn6.Name = "descripcion"
        GridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn6.Width = 121
        GridViewTextBoxColumn7.EnableExpressionEditor = False
        GridViewTextBoxColumn7.FieldName = "noDoc"
        GridViewTextBoxColumn7.HeaderText = "No. documento"
        GridViewTextBoxColumn7.Name = "noDoc"
        GridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn7.Width = 107
        GridViewTextBoxColumn8.EnableExpressionEditor = False
        GridViewTextBoxColumn8.FieldName = "estado"
        GridViewTextBoxColumn8.HeaderText = "Estado"
        GridViewTextBoxColumn8.Name = "estado"
        GridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn9.EnableExpressionEditor = False
        GridViewTextBoxColumn9.FieldName = "usuario"
        GridViewTextBoxColumn9.HeaderText = "Usuario"
        GridViewTextBoxColumn9.Name = "usuario"
        GridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.listadoPagos.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewTextBoxColumn8, GridViewTextBoxColumn9})
        SortDescriptor1.PropertyName = "idPago"
        Me.listadoPagos.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.listadoPagos.Name = "listadoPagos"
        Me.listadoPagos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.listadoPagos.Size = New System.Drawing.Size(941, 432)
        Me.listadoPagos.TabIndex = 0
        Me.listadoPagos.Text = "RadGridView1"
        Me.listadoPagos.ThemeName = "VisualStudio2012Light"
        '
        'FrmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 473)
        Me.Controls.Add(Me.RadPanel1)
        Me.Name = "FrmPagos"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Pagos"
        Me.ThemeName = "TelerikMetro"
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        CType(Me.listadoPagos.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listadoPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents listadoPagos As Telerik.WinControls.UI.RadGridView
End Class

