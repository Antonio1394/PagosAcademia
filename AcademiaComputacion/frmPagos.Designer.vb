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
        Dim GridViewTextBoxColumn10 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn11 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn12 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn13 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn14 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn15 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn16 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn17 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn18 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewCommandColumn2 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.listadoPagos = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.listadoPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listadoPagos.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listadoPagos
        '
        Me.listadoPagos.BackColor = System.Drawing.Color.White
        Me.listadoPagos.Cursor = System.Windows.Forms.Cursors.Default
        Me.listadoPagos.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.listadoPagos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.listadoPagos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.listadoPagos.Location = New System.Drawing.Point(20, 48)
        '
        'listadoPagos
        '
        Me.listadoPagos.MasterTemplate.AllowAddNewRow = False
        Me.listadoPagos.MasterTemplate.AllowColumnChooser = False
        Me.listadoPagos.MasterTemplate.AllowColumnReorder = False
        Me.listadoPagos.MasterTemplate.AllowColumnResize = False
        Me.listadoPagos.MasterTemplate.AllowDragToGroup = False
        Me.listadoPagos.MasterTemplate.AllowRowResize = False
        Me.listadoPagos.MasterTemplate.AutoGenerateColumns = False
        GridViewTextBoxColumn10.EnableExpressionEditor = False
        GridViewTextBoxColumn10.FieldName = "idPago"
        GridViewTextBoxColumn10.HeaderText = "idPago"
        GridViewTextBoxColumn10.IsVisible = False
        GridViewTextBoxColumn10.Name = "idPago"
        GridViewTextBoxColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn11.EnableExpressionEditor = False
        GridViewTextBoxColumn11.FieldName = "noDocumento"
        GridViewTextBoxColumn11.HeaderText = "No Documento"
        GridViewTextBoxColumn11.Name = "noDocumento"
        GridViewTextBoxColumn11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn11.Width = 96
        GridViewTextBoxColumn12.EnableExpressionEditor = False
        GridViewTextBoxColumn12.FieldName = "idTipPago"
        GridViewTextBoxColumn12.HeaderText = "tipoPago"
        GridViewTextBoxColumn12.IsVisible = False
        GridViewTextBoxColumn12.Name = "idTipoPago"
        GridViewTextBoxColumn12.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn13.EnableExpressionEditor = False
        GridViewTextBoxColumn13.FieldName = "fecha"
        GridViewTextBoxColumn13.HeaderText = "Fecha"
        GridViewTextBoxColumn13.MinWidth = 140
        GridViewTextBoxColumn13.Name = "fecha"
        GridViewTextBoxColumn13.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn13.Width = 150
        GridViewTextBoxColumn14.EnableExpressionEditor = False
        GridViewTextBoxColumn14.FieldName = "descripcion"
        GridViewTextBoxColumn14.HeaderText = "Descripcion"
        GridViewTextBoxColumn14.Name = "descripcion"
        GridViewTextBoxColumn14.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn14.Width = 161
        GridViewTextBoxColumn15.EnableExpressionEditor = False
        GridViewTextBoxColumn15.FieldName = "monto"
        GridViewTextBoxColumn15.HeaderText = "Monto"
        GridViewTextBoxColumn15.Name = "monto"
        GridViewTextBoxColumn15.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn15.Width = 91
        GridViewTextBoxColumn16.EnableExpressionEditor = False
        GridViewTextBoxColumn16.FieldName = "alumno"
        GridViewTextBoxColumn16.HeaderText = "Alumno"
        GridViewTextBoxColumn16.MinWidth = 200
        GridViewTextBoxColumn16.Name = "alumno"
        GridViewTextBoxColumn16.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn16.Width = 264
        GridViewTextBoxColumn17.EnableExpressionEditor = False
        GridViewTextBoxColumn17.FieldName = "estado"
        GridViewTextBoxColumn17.HeaderText = "Estado"
        GridViewTextBoxColumn17.Name = "estado"
        GridViewTextBoxColumn17.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn17.Width = 149
        GridViewTextBoxColumn18.EnableExpressionEditor = False
        GridViewTextBoxColumn18.FieldName = "usuario"
        GridViewTextBoxColumn18.HeaderText = "Usuario"
        GridViewTextBoxColumn18.MinWidth = 175
        GridViewTextBoxColumn18.Name = "usuario"
        GridViewTextBoxColumn18.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn18.Width = 244
        GridViewCommandColumn2.DefaultText = "Eliminar"
        GridViewCommandColumn2.EnableExpressionEditor = False
        GridViewCommandColumn2.FieldName = "eliminar"
        GridViewCommandColumn2.Name = "eliminar"
        GridViewCommandColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn2.UseDefaultText = True
        GridViewCommandColumn2.Width = 122
        Me.listadoPagos.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn10, GridViewTextBoxColumn11, GridViewTextBoxColumn12, GridViewTextBoxColumn13, GridViewTextBoxColumn14, GridViewTextBoxColumn15, GridViewTextBoxColumn16, GridViewTextBoxColumn17, GridViewTextBoxColumn18, GridViewCommandColumn2})
        Me.listadoPagos.MasterTemplate.EnableFiltering = True
        Me.listadoPagos.MasterTemplate.EnableGrouping = False
        Me.listadoPagos.MasterTemplate.EnableSorting = False
        Me.listadoPagos.Name = "listadoPagos"
        Me.listadoPagos.ReadOnly = True
        Me.listadoPagos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.listadoPagos.Size = New System.Drawing.Size(1031, 492)
        Me.listadoPagos.TabIndex = 0
        Me.listadoPagos.Text = "RadGridView1"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(20, 17)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(209, 25)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "Listado de Pagos realizados"
        '
        'FrmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 556)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.listadoPagos)
        Me.Name = "FrmPagos"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Pagos"
        Me.ThemeName = "TelerikMetro"
        CType(Me.listadoPagos.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listadoPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents listadoPagos As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
End Class

