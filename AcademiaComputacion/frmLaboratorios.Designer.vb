<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLaboratorios
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
        Dim GridViewCommandColumn1 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewCommandColumn2 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.RadGroupBox6 = New Telerik.WinControls.UI.RadGroupBox()
        Me.tblListadoLaboratorios = New Telerik.WinControls.UI.RadGridView()
        Me.RadGroupBox5 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadLabel10 = New Telerik.WinControls.UI.RadLabel()
        Me.txtComputadoras = New Telerik.WinControls.UI.RadSpinEditor()
        Me.txtDescripcionLaboratorio = New Telerik.WinControls.UI.RadTextBox()
        Me.btnGuardarLaboratorios = New Telerik.WinControls.UI.RadButton()
        Me.txtNombreLaboratorio = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox6.SuspendLayout()
        CType(Me.tblListadoLaboratorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblListadoLaboratorios.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox5.SuspendLayout()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComputadoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionLaboratorio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGuardarLaboratorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreLaboratorio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox6
        '
        Me.RadGroupBox6.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox6.Controls.Add(Me.tblListadoLaboratorios)
        Me.RadGroupBox6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadGroupBox6.HeaderText = ""
        Me.RadGroupBox6.Location = New System.Drawing.Point(18, 207)
        Me.RadGroupBox6.Name = "RadGroupBox6"
        '
        '
        '
        Me.RadGroupBox6.RootElement.AccessibleDescription = Nothing
        Me.RadGroupBox6.RootElement.AccessibleName = Nothing
        Me.RadGroupBox6.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.RadGroupBox6.RootElement.AngleTransform = 0.0!
        Me.RadGroupBox6.RootElement.FlipText = False
        Me.RadGroupBox6.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.RadGroupBox6.RootElement.Text = Nothing
        Me.RadGroupBox6.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.RadGroupBox6.Size = New System.Drawing.Size(772, 243)
        Me.RadGroupBox6.TabIndex = 8
        Me.RadGroupBox6.ThemeName = "VisualStudio2012Light"
        '
        'tblListadoLaboratorios
        '
        Me.tblListadoLaboratorios.BackColor = System.Drawing.Color.White
        Me.tblListadoLaboratorios.Cursor = System.Windows.Forms.Cursors.Default
        Me.tblListadoLaboratorios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblListadoLaboratorios.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.tblListadoLaboratorios.ForeColor = System.Drawing.Color.Black
        Me.tblListadoLaboratorios.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tblListadoLaboratorios.Location = New System.Drawing.Point(2, 18)
        '
        'tblListadoLaboratorios
        '
        Me.tblListadoLaboratorios.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom
        Me.tblListadoLaboratorios.MasterTemplate.AllowAddNewRow = False
        Me.tblListadoLaboratorios.MasterTemplate.AllowColumnReorder = False
        Me.tblListadoLaboratorios.MasterTemplate.AllowDragToGroup = False
        Me.tblListadoLaboratorios.MasterTemplate.AutoGenerateColumns = False
        GridViewCommandColumn1.AutoEllipsis = False
        GridViewCommandColumn1.DefaultText = "Eliminar"
        GridViewCommandColumn1.EnableExpressionEditor = False
        GridViewCommandColumn1.FieldName = "Eliminar"
        GridViewCommandColumn1.HeaderText = "Eliminar"
        GridViewCommandColumn1.Name = "eliminar"
        GridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn1.UseDefaultText = True
        GridViewCommandColumn1.Width = 100
        GridViewCommandColumn1.WrapText = True
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.HeaderText = "Codigo"
        GridViewTextBoxColumn1.IsPinned = True
        GridViewTextBoxColumn1.Name = "codigo"
        GridViewTextBoxColumn1.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
        GridViewTextBoxColumn1.ReadOnly = True
        GridViewTextBoxColumn1.Width = 116
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.HeaderText = "Nombre"
        GridViewTextBoxColumn2.IsPinned = True
        GridViewTextBoxColumn2.Name = "nombre"
        GridViewTextBoxColumn2.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
        GridViewTextBoxColumn2.ReadOnly = True
        GridViewTextBoxColumn2.Width = 112
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.HeaderText = "Descripcion"
        GridViewTextBoxColumn3.IsPinned = True
        GridViewTextBoxColumn3.Name = "descripcion"
        GridViewTextBoxColumn3.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
        GridViewTextBoxColumn3.ReadOnly = True
        GridViewTextBoxColumn3.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
        GridViewTextBoxColumn3.Width = 133
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.HeaderText = "Computadoras"
        GridViewTextBoxColumn4.IsPinned = True
        GridViewTextBoxColumn4.Name = "computadoras"
        GridViewTextBoxColumn4.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
        GridViewTextBoxColumn4.ReadOnly = True
        GridViewTextBoxColumn4.Width = 93
        GridViewCommandColumn2.DefaultText = "Modificar"
        GridViewCommandColumn2.EnableExpressionEditor = False
        GridViewCommandColumn2.FieldName = "Modfificar"
        GridViewCommandColumn2.HeaderText = "Modificar"
        GridViewCommandColumn2.Name = "modificar"
        GridViewCommandColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn2.UseDefaultText = True
        GridViewCommandColumn2.Width = 100
        Me.tblListadoLaboratorios.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewCommandColumn1, GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewCommandColumn2})
        Me.tblListadoLaboratorios.MasterTemplate.EnableFiltering = True
        SortDescriptor1.PropertyName = "descripcion"
        Me.tblListadoLaboratorios.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.tblListadoLaboratorios.Name = "tblListadoLaboratorios"
        Me.tblListadoLaboratorios.ReadOnly = True
        Me.tblListadoLaboratorios.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        '
        '
        Me.tblListadoLaboratorios.RootElement.AccessibleDescription = Nothing
        Me.tblListadoLaboratorios.RootElement.AccessibleName = Nothing
        Me.tblListadoLaboratorios.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.tblListadoLaboratorios.RootElement.AngleTransform = 0.0!
        Me.tblListadoLaboratorios.RootElement.FlipText = False
        Me.tblListadoLaboratorios.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.tblListadoLaboratorios.RootElement.Text = Nothing
        Me.tblListadoLaboratorios.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.tblListadoLaboratorios.Size = New System.Drawing.Size(768, 223)
        Me.tblListadoLaboratorios.TabIndex = 4
        Me.tblListadoLaboratorios.Text = "RadGridView1"
        Me.tblListadoLaboratorios.ThemeName = "VisualStudio2012Light"
        '
        'RadGroupBox5
        '
        Me.RadGroupBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox5.Controls.Add(Me.RadLabel10)
        Me.RadGroupBox5.Controls.Add(Me.txtComputadoras)
        Me.RadGroupBox5.Controls.Add(Me.txtDescripcionLaboratorio)
        Me.RadGroupBox5.Controls.Add(Me.btnGuardarLaboratorios)
        Me.RadGroupBox5.Controls.Add(Me.txtNombreLaboratorio)
        Me.RadGroupBox5.Controls.Add(Me.RadLabel8)
        Me.RadGroupBox5.Controls.Add(Me.RadLabel9)
        Me.RadGroupBox5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadGroupBox5.HeaderText = "Nuevo Laboratorio"
        Me.RadGroupBox5.Location = New System.Drawing.Point(18, 12)
        Me.RadGroupBox5.Name = "RadGroupBox5"
        '
        '
        '
        Me.RadGroupBox5.RootElement.AccessibleDescription = Nothing
        Me.RadGroupBox5.RootElement.AccessibleName = Nothing
        Me.RadGroupBox5.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.RadGroupBox5.RootElement.AngleTransform = 0.0!
        Me.RadGroupBox5.RootElement.FlipText = False
        Me.RadGroupBox5.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.RadGroupBox5.RootElement.Text = Nothing
        Me.RadGroupBox5.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.RadGroupBox5.Size = New System.Drawing.Size(772, 176)
        Me.RadGroupBox5.TabIndex = 7
        Me.RadGroupBox5.Text = "Nuevo Laboratorio"
        Me.RadGroupBox5.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel10
        '
        Me.RadLabel10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel10.Location = New System.Drawing.Point(25, 123)
        Me.RadLabel10.Name = "RadLabel10"
        '
        '
        '
        Me.RadLabel10.RootElement.AccessibleDescription = Nothing
        Me.RadLabel10.RootElement.AccessibleName = Nothing
        Me.RadLabel10.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.RadLabel10.RootElement.AngleTransform = 0.0!
        Me.RadLabel10.RootElement.FlipText = False
        Me.RadLabel10.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel10.RootElement.Text = Nothing
        Me.RadLabel10.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.RadLabel10.Size = New System.Drawing.Size(119, 25)
        Me.RadLabel10.TabIndex = 6
        Me.RadLabel10.Text = "Computadoras:"
        '
        'txtComputadoras
        '
        Me.txtComputadoras.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtComputadoras.Location = New System.Drawing.Point(157, 123)
        Me.txtComputadoras.Name = "txtComputadoras"
        '
        '
        '
        Me.txtComputadoras.RootElement.AccessibleDescription = Nothing
        Me.txtComputadoras.RootElement.AccessibleName = Nothing
        Me.txtComputadoras.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.txtComputadoras.RootElement.AngleTransform = 0.0!
        Me.txtComputadoras.RootElement.FlipText = False
        Me.txtComputadoras.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.txtComputadoras.RootElement.Text = Nothing
        Me.txtComputadoras.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.txtComputadoras.Size = New System.Drawing.Size(354, 27)
        Me.txtComputadoras.TabIndex = 2
        Me.txtComputadoras.TabStop = False
        Me.txtComputadoras.ThemeName = "VisualStudio2012Light"
        '
        'txtDescripcionLaboratorio
        '
        Me.txtDescripcionLaboratorio.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtDescripcionLaboratorio.Location = New System.Drawing.Point(157, 73)
        Me.txtDescripcionLaboratorio.Name = "txtDescripcionLaboratorio"
        Me.txtDescripcionLaboratorio.NullText = "Ingrese una descripcion"
        '
        '
        '
        Me.txtDescripcionLaboratorio.RootElement.AccessibleDescription = Nothing
        Me.txtDescripcionLaboratorio.RootElement.AccessibleName = Nothing
        Me.txtDescripcionLaboratorio.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.txtDescripcionLaboratorio.RootElement.AngleTransform = 0.0!
        Me.txtDescripcionLaboratorio.RootElement.FlipText = False
        Me.txtDescripcionLaboratorio.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.txtDescripcionLaboratorio.RootElement.Text = Nothing
        Me.txtDescripcionLaboratorio.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.txtDescripcionLaboratorio.Size = New System.Drawing.Size(354, 27)
        Me.txtDescripcionLaboratorio.TabIndex = 1
        Me.txtDescripcionLaboratorio.ThemeName = "VisualStudio2012Light"
        '
        'btnGuardarLaboratorios
        '
        Me.btnGuardarLaboratorios.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnGuardarLaboratorios.Location = New System.Drawing.Point(566, 33)
        Me.btnGuardarLaboratorios.Name = "btnGuardarLaboratorios"
        '
        '
        '
        Me.btnGuardarLaboratorios.RootElement.AccessibleDescription = Nothing
        Me.btnGuardarLaboratorios.RootElement.AccessibleName = Nothing
        Me.btnGuardarLaboratorios.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.btnGuardarLaboratorios.RootElement.AngleTransform = 0.0!
        Me.btnGuardarLaboratorios.RootElement.FlipText = False
        Me.btnGuardarLaboratorios.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGuardarLaboratorios.RootElement.Text = Nothing
        Me.btnGuardarLaboratorios.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.btnGuardarLaboratorios.Size = New System.Drawing.Size(136, 44)
        Me.btnGuardarLaboratorios.TabIndex = 3
        Me.btnGuardarLaboratorios.Text = "Guardar"
        Me.btnGuardarLaboratorios.ThemeName = "VisualStudio2012Light"
        '
        'txtNombreLaboratorio
        '
        Me.txtNombreLaboratorio.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtNombreLaboratorio.Location = New System.Drawing.Point(157, 31)
        Me.txtNombreLaboratorio.Name = "txtNombreLaboratorio"
        Me.txtNombreLaboratorio.NullText = "Ingrese un horario valido"
        '
        '
        '
        Me.txtNombreLaboratorio.RootElement.AccessibleDescription = Nothing
        Me.txtNombreLaboratorio.RootElement.AccessibleName = Nothing
        Me.txtNombreLaboratorio.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.txtNombreLaboratorio.RootElement.AngleTransform = 0.0!
        Me.txtNombreLaboratorio.RootElement.FlipText = False
        Me.txtNombreLaboratorio.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.txtNombreLaboratorio.RootElement.Text = Nothing
        Me.txtNombreLaboratorio.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.txtNombreLaboratorio.Size = New System.Drawing.Size(354, 27)
        Me.txtNombreLaboratorio.TabIndex = 0
        Me.txtNombreLaboratorio.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel8
        '
        Me.RadLabel8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel8.Location = New System.Drawing.Point(51, 75)
        Me.RadLabel8.Name = "RadLabel8"
        '
        '
        '
        Me.RadLabel8.RootElement.AccessibleDescription = Nothing
        Me.RadLabel8.RootElement.AccessibleName = Nothing
        Me.RadLabel8.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.RadLabel8.RootElement.AngleTransform = 0.0!
        Me.RadLabel8.RootElement.FlipText = False
        Me.RadLabel8.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel8.RootElement.Text = Nothing
        Me.RadLabel8.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.RadLabel8.Size = New System.Drawing.Size(96, 25)
        Me.RadLabel8.TabIndex = 1
        Me.RadLabel8.Text = "Descripcion:"
        Me.RadLabel8.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel9
        '
        Me.RadLabel9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel9.Location = New System.Drawing.Point(72, 33)
        Me.RadLabel9.Name = "RadLabel9"
        '
        '
        '
        Me.RadLabel9.RootElement.AccessibleDescription = Nothing
        Me.RadLabel9.RootElement.AccessibleName = Nothing
        Me.RadLabel9.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.RadLabel9.RootElement.AngleTransform = 0.0!
        Me.RadLabel9.RootElement.FlipText = False
        Me.RadLabel9.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel9.RootElement.Text = Nothing
        Me.RadLabel9.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.RadLabel9.Size = New System.Drawing.Size(72, 25)
        Me.RadLabel9.TabIndex = 0
        Me.RadLabel9.Text = "Nombre:"
        Me.RadLabel9.ThemeName = "VisualStudio2012Light"
        '
        'FrmLaboratorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 468)
        Me.Controls.Add(Me.RadGroupBox6)
        Me.Controls.Add(Me.RadGroupBox5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLaboratorios"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLaboratorios"
        Me.ThemeName = "TelerikMetro"
        CType(Me.RadGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox6.ResumeLayout(False)
        CType(Me.tblListadoLaboratorios.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblListadoLaboratorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox5.ResumeLayout(False)
        Me.RadGroupBox5.PerformLayout()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComputadoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionLaboratorio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGuardarLaboratorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreLaboratorio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents RadGroupBox6 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents tblListadoLaboratorios As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGroupBox5 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel10 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtComputadoras As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents txtDescripcionLaboratorio As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnGuardarLaboratorios As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtNombreLaboratorio As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
End Class

