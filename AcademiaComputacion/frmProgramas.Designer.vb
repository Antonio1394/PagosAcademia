<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProgramas
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
        Dim GridViewCommandColumn2 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.tblListadoProgramas = New Telerik.WinControls.UI.RadGridView()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.btnGuardarPagina1 = New Telerik.WinControls.UI.RadButton()
        Me.txtTiempoPagina1 = New Telerik.WinControls.UI.RadTextBox()
        Me.txtDescripcionPagina1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.VisualStudio2012DarkTheme1 = New Telerik.WinControls.Themes.VisualStudio2012DarkTheme()
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.tblListadoProgramas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblListadoProgramas.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.btnGuardarPagina1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTiempoPagina1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionPagina1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Controls.Add(Me.tblListadoProgramas)
        Me.RadGroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadGroupBox2.HeaderText = ""
        Me.RadGroupBox2.Location = New System.Drawing.Point(26, 147)
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
        Me.RadGroupBox2.Size = New System.Drawing.Size(738, 244)
        Me.RadGroupBox2.TabIndex = 5
        Me.RadGroupBox2.ThemeName = "VisualStudio2012Light"
        '
        'tblListadoProgramas
        '
        Me.tblListadoProgramas.BackColor = System.Drawing.Color.White
        Me.tblListadoProgramas.Cursor = System.Windows.Forms.Cursors.Default
        Me.tblListadoProgramas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblListadoProgramas.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tblListadoProgramas.ForeColor = System.Drawing.Color.Black
        Me.tblListadoProgramas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tblListadoProgramas.Location = New System.Drawing.Point(2, 18)
        '
        'tblListadoProgramas
        '
        Me.tblListadoProgramas.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom
        Me.tblListadoProgramas.MasterTemplate.AllowAddNewRow = False
        Me.tblListadoProgramas.MasterTemplate.AllowColumnReorder = False
        Me.tblListadoProgramas.MasterTemplate.AllowDragToGroup = False
        Me.tblListadoProgramas.MasterTemplate.AutoGenerateColumns = False
        GridViewCommandColumn1.AutoEllipsis = False
        GridViewCommandColumn1.DefaultText = "Eliminar"
        GridViewCommandColumn1.EnableExpressionEditor = False
        GridViewCommandColumn1.FieldName = "Eliminar"
        GridViewCommandColumn1.HeaderText = "Eliminar"
        GridViewCommandColumn1.Name = "eliminar"
        GridViewCommandColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
        GridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn1.UseDefaultText = True
        GridViewCommandColumn1.Width = 59
        GridViewCommandColumn1.WrapText = True
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.HeaderText = "Codigo"
        GridViewTextBoxColumn1.IsPinned = True
        GridViewTextBoxColumn1.Name = "codigo"
        GridViewTextBoxColumn1.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
        GridViewTextBoxColumn1.ReadOnly = True
        GridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn1.Width = 116
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.HeaderText = "Descripción"
        GridViewTextBoxColumn2.IsPinned = True
        GridViewTextBoxColumn2.Name = "descripcion"
        GridViewTextBoxColumn2.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
        GridViewTextBoxColumn2.ReadOnly = True
        GridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn2.Width = 112
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.HeaderText = "Duración"
        GridViewTextBoxColumn3.IsPinned = True
        GridViewTextBoxColumn3.Name = "duracion"
        GridViewTextBoxColumn3.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
        GridViewTextBoxColumn3.ReadOnly = True
        GridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn3.Width = 133
        GridViewCommandColumn2.DefaultText = "Modificar"
        GridViewCommandColumn2.EnableExpressionEditor = False
        GridViewCommandColumn2.FieldName = "Editar"
        GridViewCommandColumn2.HeaderText = "Modificar"
        GridViewCommandColumn2.Name = "modificar"
        GridViewCommandColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn2.UseDefaultText = True
        GridViewCommandColumn2.Width = 58
        Me.tblListadoProgramas.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewCommandColumn1, GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewCommandColumn2})
        Me.tblListadoProgramas.MasterTemplate.EnableFiltering = True
        SortDescriptor1.PropertyName = "eliminar"
        Me.tblListadoProgramas.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.tblListadoProgramas.Name = "tblListadoProgramas"
        Me.tblListadoProgramas.ReadOnly = True
        Me.tblListadoProgramas.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        '
        '
        Me.tblListadoProgramas.RootElement.AccessibleDescription = Nothing
        Me.tblListadoProgramas.RootElement.AccessibleName = Nothing
        Me.tblListadoProgramas.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.tblListadoProgramas.RootElement.AngleTransform = 0.0!
        Me.tblListadoProgramas.RootElement.FlipText = False
        Me.tblListadoProgramas.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.tblListadoProgramas.RootElement.Text = Nothing
        Me.tblListadoProgramas.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.tblListadoProgramas.Size = New System.Drawing.Size(734, 224)
        Me.tblListadoProgramas.TabIndex = 0
        Me.tblListadoProgramas.Text = "RadGridView1"
        Me.tblListadoProgramas.ThemeName = "VisualStudio2012Light"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.btnGuardarPagina1)
        Me.RadGroupBox1.Controls.Add(Me.txtTiempoPagina1)
        Me.RadGroupBox1.Controls.Add(Me.txtDescripcionPagina1)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadGroupBox1.HeaderText = "Nuevo Programa"
        Me.RadGroupBox1.Location = New System.Drawing.Point(28, 3)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        '
        '
        '
        Me.RadGroupBox1.RootElement.AccessibleDescription = Nothing
        Me.RadGroupBox1.RootElement.AccessibleName = Nothing
        Me.RadGroupBox1.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.RadGroupBox1.RootElement.AngleTransform = 0.0!
        Me.RadGroupBox1.RootElement.FlipText = False
        Me.RadGroupBox1.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.RadGroupBox1.RootElement.Text = Nothing
        Me.RadGroupBox1.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.RadGroupBox1.Size = New System.Drawing.Size(736, 116)
        Me.RadGroupBox1.TabIndex = 4
        Me.RadGroupBox1.Text = "Nuevo Programa"
        Me.RadGroupBox1.ThemeName = "VisualStudio2012Light"
        '
        'btnGuardarPagina1
        '
        Me.btnGuardarPagina1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnGuardarPagina1.Location = New System.Drawing.Point(581, 50)
        Me.btnGuardarPagina1.Name = "btnGuardarPagina1"
        '
        '
        '
        Me.btnGuardarPagina1.RootElement.AccessibleDescription = Nothing
        Me.btnGuardarPagina1.RootElement.AccessibleName = Nothing
        Me.btnGuardarPagina1.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.btnGuardarPagina1.RootElement.AngleTransform = 0.0!
        Me.btnGuardarPagina1.RootElement.FlipText = False
        Me.btnGuardarPagina1.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGuardarPagina1.RootElement.Text = Nothing
        Me.btnGuardarPagina1.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.btnGuardarPagina1.Size = New System.Drawing.Size(136, 44)
        Me.btnGuardarPagina1.TabIndex = 4
        Me.btnGuardarPagina1.Text = "Guardar"
        Me.btnGuardarPagina1.ThemeName = "VisualStudio2012Light"
        '
        'txtTiempoPagina1
        '
        Me.txtTiempoPagina1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtTiempoPagina1.Location = New System.Drawing.Point(171, 79)
        Me.txtTiempoPagina1.Name = "txtTiempoPagina1"
        Me.txtTiempoPagina1.NullText = "duracion en semanas"
        '
        '
        '
        Me.txtTiempoPagina1.RootElement.AccessibleDescription = Nothing
        Me.txtTiempoPagina1.RootElement.AccessibleName = Nothing
        Me.txtTiempoPagina1.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.txtTiempoPagina1.RootElement.AngleTransform = 0.0!
        Me.txtTiempoPagina1.RootElement.FlipText = False
        Me.txtTiempoPagina1.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.txtTiempoPagina1.RootElement.Text = Nothing
        Me.txtTiempoPagina1.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.txtTiempoPagina1.Size = New System.Drawing.Size(354, 27)
        Me.txtTiempoPagina1.TabIndex = 3
        Me.txtTiempoPagina1.ThemeName = "VisualStudio2012Light"
        '
        'txtDescripcionPagina1
        '
        Me.txtDescripcionPagina1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtDescripcionPagina1.Location = New System.Drawing.Point(171, 39)
        Me.txtDescripcionPagina1.Name = "txtDescripcionPagina1"
        Me.txtDescripcionPagina1.NullText = "nombre del programa"
        '
        '
        '
        Me.txtDescripcionPagina1.RootElement.AccessibleDescription = Nothing
        Me.txtDescripcionPagina1.RootElement.AccessibleName = Nothing
        Me.txtDescripcionPagina1.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.txtDescripcionPagina1.RootElement.AngleTransform = 0.0!
        Me.txtDescripcionPagina1.RootElement.FlipText = False
        Me.txtDescripcionPagina1.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.txtDescripcionPagina1.RootElement.Text = Nothing
        Me.txtDescripcionPagina1.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.txtDescripcionPagina1.Size = New System.Drawing.Size(354, 27)
        Me.txtDescripcionPagina1.TabIndex = 2
        Me.txtDescripcionPagina1.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel3.Location = New System.Drawing.Point(72, 79)
        Me.RadLabel3.Name = "RadLabel3"
        '
        '
        '
        Me.RadLabel3.RootElement.AccessibleDescription = Nothing
        Me.RadLabel3.RootElement.AccessibleName = Nothing
        Me.RadLabel3.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.RadLabel3.RootElement.AngleTransform = 0.0!
        Me.RadLabel3.RootElement.FlipText = False
        Me.RadLabel3.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel3.RootElement.Text = Nothing
        Me.RadLabel3.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.RadLabel3.Size = New System.Drawing.Size(66, 25)
        Me.RadLabel3.TabIndex = 1
        Me.RadLabel3.Text = "Tiempo:"
        Me.RadLabel3.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel2.Location = New System.Drawing.Point(42, 39)
        Me.RadLabel2.Name = "RadLabel2"
        '
        '
        '
        Me.RadLabel2.RootElement.AccessibleDescription = Nothing
        Me.RadLabel2.RootElement.AccessibleName = Nothing
        Me.RadLabel2.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.RadLabel2.RootElement.AngleTransform = 0.0!
        Me.RadLabel2.RootElement.FlipText = False
        Me.RadLabel2.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel2.RootElement.Text = Nothing
        Me.RadLabel2.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.RadLabel2.Size = New System.Drawing.Size(96, 25)
        Me.RadLabel2.TabIndex = 0
        Me.RadLabel2.Text = "Descripcion:"
        Me.RadLabel2.ThemeName = "VisualStudio2012Light"
        '
        'FrmProgramas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 411)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmProgramas"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programas"
        Me.ThemeName = "TelerikMetro"
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        CType(Me.tblListadoProgramas.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblListadoProgramas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.btnGuardarPagina1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTiempoPagina1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionPagina1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents tblListadoProgramas As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btnGuardarPagina1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtTiempoPagina1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtDescripcionPagina1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents VisualStudio2012DarkTheme1 As Telerik.WinControls.Themes.VisualStudio2012DarkTheme
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
End Class

