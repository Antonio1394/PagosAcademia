<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleado
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
        Dim GridViewCommandColumn1 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim GridViewCommandColumn2 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.tblListadoEmpleados = New Telerik.WinControls.UI.RadGridView()
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.RadGroupBox6 = New Telerik.WinControls.UI.RadGroupBox()
        Me.cboJornada = New Telerik.WinControls.UI.RadDropDownList()
        Me.cboTipoEmpleado = New Telerik.WinControls.UI.RadDropDownList()
        Me.btnGuardar = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtDireccion = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel10 = New Telerik.WinControls.UI.RadLabel()
        Me.txtApellido = New Telerik.WinControls.UI.RadTextBox()
        Me.txtNombre = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.RadGroupBox5 = New Telerik.WinControls.UI.RadGroupBox()
        Me.txtTelefono = New Telerik.WinControls.UI.RadTextBox()
        Me.VisualStudio2012DarkTheme1 = New Telerik.WinControls.Themes.VisualStudio2012DarkTheme()
        CType(Me.tblListadoEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblListadoEmpleados.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox6.SuspendLayout()
        CType(Me.cboJornada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox5.SuspendLayout()
        CType(Me.txtTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblListadoEmpleados
        '
        Me.tblListadoEmpleados.BackColor = System.Drawing.Color.White
        Me.tblListadoEmpleados.Cursor = System.Windows.Forms.Cursors.Default
        Me.tblListadoEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblListadoEmpleados.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.tblListadoEmpleados.ForeColor = System.Drawing.Color.Black
        Me.tblListadoEmpleados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tblListadoEmpleados.Location = New System.Drawing.Point(2, 18)
        '
        'tblListadoEmpleados
        '
        Me.tblListadoEmpleados.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom
        Me.tblListadoEmpleados.MasterTemplate.AllowAddNewRow = False
        Me.tblListadoEmpleados.MasterTemplate.AllowColumnReorder = False
        Me.tblListadoEmpleados.MasterTemplate.AllowDragToGroup = False
        Me.tblListadoEmpleados.MasterTemplate.AutoGenerateColumns = False
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.HeaderText = "Codigo"
        GridViewTextBoxColumn1.IsPinned = True
        GridViewTextBoxColumn1.Name = "codigo"
        GridViewTextBoxColumn1.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
        GridViewTextBoxColumn1.ReadOnly = True
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.HeaderText = "Nombres"
        GridViewTextBoxColumn2.IsPinned = True
        GridViewTextBoxColumn2.Name = "nombre"
        GridViewTextBoxColumn2.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
        GridViewTextBoxColumn2.ReadOnly = True
        GridViewTextBoxColumn2.Width = 100
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.HeaderText = "Apellido"
        GridViewTextBoxColumn3.IsPinned = True
        GridViewTextBoxColumn3.Name = "apellido"
        GridViewTextBoxColumn3.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
        GridViewTextBoxColumn3.ReadOnly = True
        GridViewTextBoxColumn3.Width = 100
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.HeaderText = "Telefono"
        GridViewTextBoxColumn4.IsPinned = True
        GridViewTextBoxColumn4.Name = "telefono"
        GridViewTextBoxColumn4.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
        GridViewTextBoxColumn4.ReadOnly = True
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.HeaderText = "Direccion"
        GridViewTextBoxColumn5.IsPinned = True
        GridViewTextBoxColumn5.Name = "direccion"
        GridViewTextBoxColumn5.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
        GridViewTextBoxColumn5.ReadOnly = True
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.HeaderText = "Tipo Empleado"
        GridViewTextBoxColumn6.IsPinned = True
        GridViewTextBoxColumn6.Name = "tipo"
        GridViewTextBoxColumn6.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
        GridViewTextBoxColumn6.ReadOnly = True
        GridViewTextBoxColumn7.EnableExpressionEditor = False
        GridViewTextBoxColumn7.HeaderText = "Jornada"
        GridViewTextBoxColumn7.IsPinned = True
        GridViewTextBoxColumn7.Name = "jornada"
        GridViewTextBoxColumn7.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
        GridViewTextBoxColumn7.ReadOnly = True
        GridViewCommandColumn1.DefaultText = "Emilimar"
        GridViewCommandColumn1.EnableExpressionEditor = False
        GridViewCommandColumn1.FieldName = "eliminar"
        GridViewCommandColumn1.HeaderText = "Eliminar"
        GridViewCommandColumn1.Name = "eliminar"
        GridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn1.UseDefaultText = True
        GridViewCommandColumn2.DefaultText = "Modificar"
        GridViewCommandColumn2.EnableExpressionEditor = False
        GridViewCommandColumn2.FieldName = "modificar"
        GridViewCommandColumn2.HeaderText = "Modificar"
        GridViewCommandColumn2.Name = "modificar"
        GridViewCommandColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn2.UseDefaultText = True
        GridViewTextBoxColumn8.EnableExpressionEditor = False
        GridViewTextBoxColumn8.HeaderText = "column1"
        GridViewTextBoxColumn8.IsVisible = False
        GridViewTextBoxColumn8.Name = "idTipoEmpleado"
        Me.tblListadoEmpleados.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewCommandColumn1, GridViewCommandColumn2, GridViewTextBoxColumn8})
        Me.tblListadoEmpleados.MasterTemplate.EnableFiltering = True
        SortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending
        SortDescriptor1.PropertyName = "column1"
        Me.tblListadoEmpleados.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.tblListadoEmpleados.Name = "tblListadoEmpleados"
        Me.tblListadoEmpleados.ReadOnly = True
        Me.tblListadoEmpleados.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        '
        '
        Me.tblListadoEmpleados.RootElement.AccessibleDescription = Nothing
        Me.tblListadoEmpleados.RootElement.AccessibleName = Nothing
        Me.tblListadoEmpleados.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.tblListadoEmpleados.RootElement.AngleTransform = 0.0!
        Me.tblListadoEmpleados.RootElement.FlipText = False
        Me.tblListadoEmpleados.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.tblListadoEmpleados.RootElement.Text = Nothing
        Me.tblListadoEmpleados.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.tblListadoEmpleados.Size = New System.Drawing.Size(1017, 245)
        Me.tblListadoEmpleados.TabIndex = 0
        Me.tblListadoEmpleados.Text = "RadGridView1"
        Me.tblListadoEmpleados.ThemeName = "VisualStudio2012Light"
        '
        'RadGroupBox6
        '
        Me.RadGroupBox6.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox6.Controls.Add(Me.tblListadoEmpleados)
        Me.RadGroupBox6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadGroupBox6.HeaderText = ""
        Me.RadGroupBox6.Location = New System.Drawing.Point(19, 275)
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
        Me.RadGroupBox6.Size = New System.Drawing.Size(1021, 265)
        Me.RadGroupBox6.TabIndex = 11
        Me.RadGroupBox6.ThemeName = "VisualStudio2012Light"
        '
        'cboJornada
        '
        Me.cboJornada.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cboJornada.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadListDataItem1.Text = "Diario"
        RadListDataItem1.TextWrap = True
        RadListDataItem2.Text = "Fin de Semana"
        RadListDataItem2.TextWrap = True
        Me.cboJornada.Items.Add(RadListDataItem1)
        Me.cboJornada.Items.Add(RadListDataItem2)
        Me.cboJornada.Location = New System.Drawing.Point(590, 192)
        Me.cboJornada.Name = "cboJornada"
        Me.cboJornada.NullText = "Seleccione una opcion"
        Me.cboJornada.Size = New System.Drawing.Size(389, 27)
        Me.cboJornada.TabIndex = 5
        Me.cboJornada.ThemeName = "VisualStudio2012Light"
        '
        'cboTipoEmpleado
        '
        Me.cboTipoEmpleado.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cboTipoEmpleado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoEmpleado.Location = New System.Drawing.Point(40, 192)
        Me.cboTipoEmpleado.Name = "cboTipoEmpleado"
        Me.cboTipoEmpleado.NullText = "Seleccione una opcion"
        Me.cboTipoEmpleado.Size = New System.Drawing.Size(443, 27)
        Me.cboTipoEmpleado.TabIndex = 4
        Me.cboTipoEmpleado.ThemeName = "VisualStudio2012Light"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnGuardar.Location = New System.Drawing.Point(858, 236)
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
        Me.btnGuardar.Size = New System.Drawing.Size(121, 31)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel3.Location = New System.Drawing.Point(590, 161)
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
        Me.RadLabel3.Size = New System.Drawing.Size(123, 25)
        Me.RadLabel3.TabIndex = 14
        Me.RadLabel3.Text = "Jornada Laboral"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel2.Location = New System.Drawing.Point(40, 161)
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
        Me.RadLabel2.Size = New System.Drawing.Size(120, 25)
        Me.RadLabel2.TabIndex = 12
        Me.RadLabel2.Text = "Tipo Empleado:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtDireccion.Location = New System.Drawing.Point(590, 128)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.NullText = "Direccion del Empleado"
        '
        '
        '
        Me.txtDireccion.RootElement.AccessibleDescription = Nothing
        Me.txtDireccion.RootElement.AccessibleName = Nothing
        Me.txtDireccion.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.txtDireccion.RootElement.AngleTransform = 0.0!
        Me.txtDireccion.RootElement.FlipText = False
        Me.txtDireccion.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.txtDireccion.RootElement.Text = Nothing
        Me.txtDireccion.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.txtDireccion.Size = New System.Drawing.Size(389, 27)
        Me.txtDireccion.TabIndex = 3
        Me.txtDireccion.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel1.Location = New System.Drawing.Point(590, 97)
        Me.RadLabel1.Name = "RadLabel1"
        '
        '
        '
        Me.RadLabel1.RootElement.AccessibleDescription = Nothing
        Me.RadLabel1.RootElement.AccessibleName = Nothing
        Me.RadLabel1.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.RadLabel1.RootElement.AngleTransform = 0.0!
        Me.RadLabel1.RootElement.FlipText = False
        Me.RadLabel1.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel1.RootElement.Text = Nothing
        Me.RadLabel1.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.RadLabel1.Size = New System.Drawing.Size(79, 25)
        Me.RadLabel1.TabIndex = 10
        Me.RadLabel1.Text = "Direccion:"
        '
        'RadLabel10
        '
        Me.RadLabel10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel10.Location = New System.Drawing.Point(37, 97)
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
        Me.RadLabel10.Size = New System.Drawing.Size(75, 25)
        Me.RadLabel10.TabIndex = 6
        Me.RadLabel10.Text = "Telefono:"
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtApellido.Location = New System.Drawing.Point(590, 64)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.NullText = "Apellidos del Empleado"
        '
        '
        '
        Me.txtApellido.RootElement.AccessibleDescription = Nothing
        Me.txtApellido.RootElement.AccessibleName = Nothing
        Me.txtApellido.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.txtApellido.RootElement.AngleTransform = 0.0!
        Me.txtApellido.RootElement.FlipText = False
        Me.txtApellido.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.txtApellido.RootElement.Text = Nothing
        Me.txtApellido.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.txtApellido.Size = New System.Drawing.Size(389, 27)
        Me.txtApellido.TabIndex = 1
        Me.txtApellido.ThemeName = "VisualStudio2012Light"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtNombre.Location = New System.Drawing.Point(40, 64)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.NullText = "Nombres del Empledado"
        '
        '
        '
        Me.txtNombre.RootElement.AccessibleDescription = Nothing
        Me.txtNombre.RootElement.AccessibleName = Nothing
        Me.txtNombre.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.txtNombre.RootElement.AngleTransform = 0.0!
        Me.txtNombre.RootElement.FlipText = False
        Me.txtNombre.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.txtNombre.RootElement.Text = Nothing
        Me.txtNombre.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.txtNombre.Size = New System.Drawing.Size(443, 27)
        Me.txtNombre.TabIndex = 0
        Me.txtNombre.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel8
        '
        Me.RadLabel8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel8.Location = New System.Drawing.Point(590, 33)
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
        Me.RadLabel8.Size = New System.Drawing.Size(72, 25)
        Me.RadLabel8.TabIndex = 1
        Me.RadLabel8.Text = "Apellido:"
        Me.RadLabel8.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel9
        '
        Me.RadLabel9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel9.Location = New System.Drawing.Point(40, 33)
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
        'RadGroupBox5
        '
        Me.RadGroupBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox5.Controls.Add(Me.txtTelefono)
        Me.RadGroupBox5.Controls.Add(Me.cboJornada)
        Me.RadGroupBox5.Controls.Add(Me.cboTipoEmpleado)
        Me.RadGroupBox5.Controls.Add(Me.btnGuardar)
        Me.RadGroupBox5.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox5.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox5.Controls.Add(Me.txtDireccion)
        Me.RadGroupBox5.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox5.Controls.Add(Me.RadLabel10)
        Me.RadGroupBox5.Controls.Add(Me.txtApellido)
        Me.RadGroupBox5.Controls.Add(Me.txtNombre)
        Me.RadGroupBox5.Controls.Add(Me.RadLabel8)
        Me.RadGroupBox5.Controls.Add(Me.RadLabel9)
        Me.RadGroupBox5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadGroupBox5.HeaderText = "Nuevo Empledo"
        Me.RadGroupBox5.Location = New System.Drawing.Point(19, 3)
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
        Me.RadGroupBox5.Size = New System.Drawing.Size(1021, 275)
        Me.RadGroupBox5.TabIndex = 10
        Me.RadGroupBox5.Text = "Nuevo Empledo"
        Me.RadGroupBox5.ThemeName = "VisualStudio2012Light"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(40, 128)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(443, 27)
        Me.txtTelefono.TabIndex = 2
        Me.txtTelefono.ThemeName = "VisualStudio2012Light"
        '
        'FrmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 582)
        Me.Controls.Add(Me.RadGroupBox6)
        Me.Controls.Add(Me.RadGroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmEmpleado"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Empleado"
        Me.ThemeName = "TelerikMetro"
        CType(Me.tblListadoEmpleados.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblListadoEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox6.ResumeLayout(False)
        CType(Me.cboJornada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox5.ResumeLayout(False)
        Me.RadGroupBox5.PerformLayout()
        CType(Me.txtTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblListadoEmpleados As Telerik.WinControls.UI.RadGridView
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents RadGroupBox6 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents cboJornada As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents cboTipoEmpleado As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents btnGuardar As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtDireccion As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel10 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtApellido As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtNombre As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents RadGroupBox5 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents VisualStudio2012DarkTheme1 As Telerik.WinControls.Themes.VisualStudio2012DarkTheme
    Friend WithEvents txtTelefono As Telerik.WinControls.UI.RadTextBox
End Class

