<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoEmpleado
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
        Dim GridViewCommandColumn5 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewCommandColumn6 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim SortDescriptor3 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.btnGuardar = New Telerik.WinControls.UI.RadButton()
        Me.txtDescripcion = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.tblTipoEmpleados = New Telerik.WinControls.UI.RadGridView()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.tblTipoEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblTipoEmpleados.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Controls.Add(Me.btnGuardar)
        Me.RadGroupBox3.Controls.Add(Me.txtDescripcion)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel5)
        Me.RadGroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadGroupBox3.HeaderText = "Nuevo Tipo de Empleado"
        Me.RadGroupBox3.Location = New System.Drawing.Point(22, 13)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        '
        '
        '
        Me.RadGroupBox3.RootElement.AccessibleDescription = Nothing
        Me.RadGroupBox3.RootElement.AccessibleName = Nothing
        Me.RadGroupBox3.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.RadGroupBox3.RootElement.AngleTransform = 0.0!
        Me.RadGroupBox3.RootElement.FlipText = False
        Me.RadGroupBox3.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.RadGroupBox3.RootElement.Text = Nothing
        Me.RadGroupBox3.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.RadGroupBox3.Size = New System.Drawing.Size(419, 111)
        Me.RadGroupBox3.TabIndex = 6
        Me.RadGroupBox3.Text = "Nuevo Tipo de Empleado"
        Me.RadGroupBox3.ThemeName = "VisualStudio2012Light"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnGuardar.Location = New System.Drawing.Point(287, 70)
        Me.btnGuardar.Name = "btnGuardar"
        '
        '
        '
        Me.btnGuardar.RootElement.AccessibleDescription = Nothing
        Me.btnGuardar.RootElement.AccessibleName = Nothing
        Me.btnGuardar.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.btnGuardar.RootElement.AngleTransform = 0.0!
        Me.btnGuardar.RootElement.FlipText = False
        Me.btnGuardar.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGuardar.RootElement.Text = Nothing
        Me.btnGuardar.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.btnGuardar.Size = New System.Drawing.Size(127, 36)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.ThemeName = "VisualStudio2012Light"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtDescripcion.Location = New System.Drawing.Point(118, 37)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.NullText = "Ingrese una descripcion de empleado"
        '
        '
        '
        Me.txtDescripcion.RootElement.AccessibleDescription = Nothing
        Me.txtDescripcion.RootElement.AccessibleName = Nothing
        Me.txtDescripcion.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.txtDescripcion.RootElement.AngleTransform = 0.0!
        Me.txtDescripcion.RootElement.FlipText = False
        Me.txtDescripcion.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.txtDescripcion.RootElement.Text = Nothing
        Me.txtDescripcion.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.txtDescripcion.Size = New System.Drawing.Size(296, 27)
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel5.Location = New System.Drawing.Point(10, 37)
        Me.RadLabel5.Name = "RadLabel5"
        '
        '
        '
        Me.RadLabel5.RootElement.AccessibleDescription = Nothing
        Me.RadLabel5.RootElement.AccessibleName = Nothing
        Me.RadLabel5.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.RadLabel5.RootElement.AngleTransform = 0.0!
        Me.RadLabel5.RootElement.FlipText = False
        Me.RadLabel5.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel5.RootElement.Text = Nothing
        Me.RadLabel5.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.RadLabel5.Size = New System.Drawing.Size(96, 25)
        Me.RadLabel5.TabIndex = 0
        Me.RadLabel5.Text = "Descripcion:"
        Me.RadLabel5.ThemeName = "VisualStudio2012Light"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Controls.Add(Me.tblTipoEmpleados)
        Me.RadGroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadGroupBox2.HeaderText = ""
        Me.RadGroupBox2.Location = New System.Drawing.Point(22, 130)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        '
        '
        '
        Me.RadGroupBox2.RootElement.AccessibleDescription = Nothing
        Me.RadGroupBox2.RootElement.AccessibleName = Nothing
        Me.RadGroupBox2.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.RadGroupBox2.RootElement.AngleTransform = 0.0!
        Me.RadGroupBox2.RootElement.FlipText = False
        Me.RadGroupBox2.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.RadGroupBox2.RootElement.Text = Nothing
        Me.RadGroupBox2.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.RadGroupBox2.Size = New System.Drawing.Size(419, 254)
        Me.RadGroupBox2.TabIndex = 7
        Me.RadGroupBox2.ThemeName = "VisualStudio2012Light"
        '
        'tblTipoEmpleados
        '
        Me.tblTipoEmpleados.BackColor = System.Drawing.Color.White
        Me.tblTipoEmpleados.Cursor = System.Windows.Forms.Cursors.Default
        Me.tblTipoEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblTipoEmpleados.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tblTipoEmpleados.ForeColor = System.Drawing.Color.Black
        Me.tblTipoEmpleados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tblTipoEmpleados.Location = New System.Drawing.Point(2, 18)
        '
        'tblTipoEmpleados
        '
        Me.tblTipoEmpleados.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom
        Me.tblTipoEmpleados.MasterTemplate.AllowAddNewRow = False
        Me.tblTipoEmpleados.MasterTemplate.AllowColumnReorder = False
        Me.tblTipoEmpleados.MasterTemplate.AllowDragToGroup = False
        Me.tblTipoEmpleados.MasterTemplate.AutoGenerateColumns = False
        GridViewCommandColumn5.AutoEllipsis = False
        GridViewCommandColumn5.DefaultText = "Eliminar"
        GridViewCommandColumn5.EnableExpressionEditor = False
        GridViewCommandColumn5.FieldName = "Eliminar"
        GridViewCommandColumn5.HeaderText = "Eliminar"
        GridViewCommandColumn5.Name = "eliminar"
        GridViewCommandColumn5.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
        GridViewCommandColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn5.UseDefaultText = True
        GridViewCommandColumn5.Width = 59
        GridViewCommandColumn5.WrapText = True
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.HeaderText = "Codigo"
        GridViewTextBoxColumn5.IsPinned = True
        GridViewTextBoxColumn5.Name = "codigo"
        GridViewTextBoxColumn5.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
        GridViewTextBoxColumn5.ReadOnly = True
        GridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn5.Width = 100
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.HeaderText = "Descripción"
        GridViewTextBoxColumn6.IsPinned = True
        GridViewTextBoxColumn6.Name = "descripcion"
        GridViewTextBoxColumn6.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
        GridViewTextBoxColumn6.ReadOnly = True
        GridViewTextBoxColumn6.Width = 150
        GridViewCommandColumn6.DefaultText = "Modificar"
        GridViewCommandColumn6.EnableExpressionEditor = False
        GridViewCommandColumn6.FieldName = "Editar"
        GridViewCommandColumn6.HeaderText = "Modificar"
        GridViewCommandColumn6.Name = "modificar"
        GridViewCommandColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn6.UseDefaultText = True
        GridViewCommandColumn6.Width = 58
        Me.tblTipoEmpleados.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewCommandColumn5, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewCommandColumn6})
        Me.tblTipoEmpleados.MasterTemplate.EnableFiltering = True
        SortDescriptor3.PropertyName = "eliminar"
        Me.tblTipoEmpleados.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor3})
        Me.tblTipoEmpleados.Name = "tblTipoEmpleados"
        Me.tblTipoEmpleados.ReadOnly = True
        Me.tblTipoEmpleados.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        '
        '
        Me.tblTipoEmpleados.RootElement.AccessibleDescription = Nothing
        Me.tblTipoEmpleados.RootElement.AccessibleName = Nothing
        Me.tblTipoEmpleados.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.tblTipoEmpleados.RootElement.AngleTransform = 0.0!
        Me.tblTipoEmpleados.RootElement.FlipText = False
        Me.tblTipoEmpleados.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.tblTipoEmpleados.RootElement.Text = Nothing
        Me.tblTipoEmpleados.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.tblTipoEmpleados.Size = New System.Drawing.Size(415, 234)
        Me.tblTipoEmpleados.TabIndex = 0
        Me.tblTipoEmpleados.Text = "RadGridView1"
        Me.tblTipoEmpleados.ThemeName = "VisualStudio2012Light"
        '
        'FrmTipoEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 420)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox3)
        Me.Name = "FrmTipoEmpleado"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipos de Empleados"
        Me.ThemeName = "TelerikMetro"
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        Me.RadGroupBox3.PerformLayout()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        CType(Me.tblTipoEmpleados.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblTipoEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btnGuardar As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtDescripcion As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents tblTipoEmpleados As Telerik.WinControls.UI.RadGridView
End Class

