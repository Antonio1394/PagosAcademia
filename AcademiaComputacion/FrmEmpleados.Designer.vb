<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleados
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
        Me.components = New System.ComponentModel.Container()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim GridViewTextBoxColumn17 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn18 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn19 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn20 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn21 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn22 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn23 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn24 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewCommandColumn5 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim GridViewCommandColumn6 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim SortDescriptor3 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Me.cboTipoEmpleados = New Telerik.WinControls.UI.RadDropDownList()
        Me.txtNombre = New Telerik.WinControls.UI.RadTextBox()
        Me.txtApellido = New Telerik.WinControls.UI.RadTextBox()
        Me.txtTelefono = New Telerik.WinControls.UI.RadTextBox()
        Me.txtDireccion = New Telerik.WinControls.UI.RadTextBox()
        Me.cboJornada = New Telerik.WinControls.UI.RadDropDownList()
        Me.btnGuardar = New Telerik.WinControls.UI.RadButton()
        Me.tblEmpleados = New Telerik.WinControls.UI.RadGridView()
        Me.btnModificar = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.cboTipoEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboJornada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblEmpleados.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboTipoEmpleados
        '
        Me.cboTipoEmpleados.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cboTipoEmpleados.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoEmpleados.Location = New System.Drawing.Point(169, 130)
        Me.cboTipoEmpleados.Name = "cboTipoEmpleados"
        Me.cboTipoEmpleados.Size = New System.Drawing.Size(306, 27)
        Me.cboTipoEmpleados.TabIndex = 6
        Me.cboTipoEmpleados.ThemeName = "VisualStudio2012Light"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(167, 34)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(308, 27)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.ThemeName = "VisualStudio2012Light"
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(602, 32)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(313, 27)
        Me.txtApellido.TabIndex = 2
        Me.txtApellido.ThemeName = "VisualStudio2012Light"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(169, 82)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(306, 27)
        Me.txtTelefono.TabIndex = 3
        Me.txtTelefono.ThemeName = "VisualStudio2012Light"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(602, 80)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(313, 27)
        Me.txtDireccion.TabIndex = 4
        Me.txtDireccion.ThemeName = "VisualStudio2012Light"
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
        Me.cboJornada.Location = New System.Drawing.Point(602, 128)
        Me.cboJornada.Name = "cboJornada"
        Me.cboJornada.Size = New System.Drawing.Size(313, 27)
        Me.cboJornada.TabIndex = 5
        Me.cboJornada.ThemeName = "VisualStudio2012Light"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(811, 165)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(104, 28)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.ThemeName = "TelerikMetro"
        '
        'tblEmpleados
        '
        Me.tblEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblEmpleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tblEmpleados.Cursor = System.Windows.Forms.Cursors.Default
        Me.tblEmpleados.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tblEmpleados.ForeColor = System.Drawing.Color.Black
        Me.tblEmpleados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tblEmpleados.Location = New System.Drawing.Point(25, 215)
        '
        'tblEmpleados
        '
        Me.tblEmpleados.MasterTemplate.AllowAddNewRow = False
        Me.tblEmpleados.MasterTemplate.AutoGenerateColumns = False
        GridViewTextBoxColumn17.EnableExpressionEditor = False
        GridViewTextBoxColumn17.HeaderText = "Codigo"
        GridViewTextBoxColumn17.Name = "codigo"
        GridViewTextBoxColumn18.EnableExpressionEditor = False
        GridViewTextBoxColumn18.HeaderText = "Nombre"
        GridViewTextBoxColumn18.Name = "nombre"
        GridViewTextBoxColumn19.EnableExpressionEditor = False
        GridViewTextBoxColumn19.HeaderText = "Apellido"
        GridViewTextBoxColumn19.Name = "apellido"
        GridViewTextBoxColumn20.EnableExpressionEditor = False
        GridViewTextBoxColumn20.HeaderText = "Direccion"
        GridViewTextBoxColumn20.Name = "direccion"
        GridViewTextBoxColumn21.EnableExpressionEditor = False
        GridViewTextBoxColumn21.HeaderText = "Telefono"
        GridViewTextBoxColumn21.Name = "telefono"
        GridViewTextBoxColumn22.EnableExpressionEditor = False
        GridViewTextBoxColumn22.HeaderText = "Puesto"
        GridViewTextBoxColumn22.Name = "tipo_empleado"
        GridViewTextBoxColumn23.EnableExpressionEditor = False
        GridViewTextBoxColumn23.HeaderText = "Jornada"
        GridViewTextBoxColumn23.Name = "jornada"
        GridViewTextBoxColumn24.EnableExpressionEditor = False
        GridViewTextBoxColumn24.HeaderText = "id_tipo_empleado"
        GridViewTextBoxColumn24.IsVisible = False
        GridViewTextBoxColumn24.Name = "id_tipo_empleado"
        GridViewTextBoxColumn24.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending
        GridViewCommandColumn5.DefaultText = "Eliminar"
        GridViewCommandColumn5.EnableExpressionEditor = False
        GridViewCommandColumn5.Name = "eliminar"
        GridViewCommandColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn5.UseDefaultText = True
        GridViewCommandColumn6.DefaultText = "Modificar"
        GridViewCommandColumn6.EnableExpressionEditor = False
        GridViewCommandColumn6.Name = "modificar"
        GridViewCommandColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn6.UseDefaultText = True
        Me.tblEmpleados.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn17, GridViewTextBoxColumn18, GridViewTextBoxColumn19, GridViewTextBoxColumn20, GridViewTextBoxColumn21, GridViewTextBoxColumn22, GridViewTextBoxColumn23, GridViewTextBoxColumn24, GridViewCommandColumn5, GridViewCommandColumn6})
        Me.tblEmpleados.MasterTemplate.ShowGroupedColumns = True
        SortDescriptor3.Direction = System.ComponentModel.ListSortDirection.Descending
        SortDescriptor3.PropertyName = "id_tipo_empleado"
        Me.tblEmpleados.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor3})
        Me.tblEmpleados.Name = "tblEmpleados"
        Me.tblEmpleados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tblEmpleados.ShowGroupPanel = False
        Me.tblEmpleados.Size = New System.Drawing.Size(951, 311)
        Me.tblEmpleados.TabIndex = 8
        Me.tblEmpleados.Text = "RadGridView1"
        Me.tblEmpleados.ThemeName = "TelerikMetro"
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(701, 165)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(104, 28)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.ThemeName = "TelerikMetro"
        Me.btnModificar.Visible = False
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(23, 34)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(68, 25)
        Me.RadLabel1.TabIndex = 10
        Me.RadLabel1.Text = "Nombre"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(507, 34)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(68, 25)
        Me.RadLabel2.TabIndex = 11
        Me.RadLabel2.Text = "Apellido"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(23, 82)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(71, 25)
        Me.RadLabel3.TabIndex = 12
        Me.RadLabel3.Text = "Telefono"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(507, 80)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(76, 25)
        Me.RadLabel4.TabIndex = 13
        Me.RadLabel4.Text = "Direccion"
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.Location = New System.Drawing.Point(23, 132)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(140, 25)
        Me.RadLabel5.TabIndex = 14
        Me.RadLabel5.Text = "Tipo de Empleado"
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(507, 130)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(65, 25)
        Me.RadLabel6.TabIndex = 15
        Me.RadLabel6.Text = "Jornada"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Controls.Add(Me.btnModificar)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel6)
        Me.RadGroupBox1.Controls.Add(Me.cboTipoEmpleados)
        Me.RadGroupBox1.Controls.Add(Me.btnGuardar)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel5)
        Me.RadGroupBox1.Controls.Add(Me.txtNombre)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox1.Controls.Add(Me.txtApellido)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox1.Controls.Add(Me.txtTelefono)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox1.Controls.Add(Me.txtDireccion)
        Me.RadGroupBox1.Controls.Add(Me.cboJornada)
        Me.RadGroupBox1.HeaderText = "Registro de Empleados"
        Me.RadGroupBox1.Location = New System.Drawing.Point(25, 3)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(951, 206)
        Me.RadGroupBox1.TabIndex = 16
        Me.RadGroupBox1.Text = "Registro de Empleados"
        Me.RadGroupBox1.ThemeName = "TelerikMetro"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 547)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.tblEmpleados)
        Me.Name = "FrmEmpleados"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "FrmEmpleados"
        Me.ThemeName = "TelerikMetro"
        CType(Me.cboTipoEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboJornada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblEmpleados.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboTipoEmpleados As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txtNombre As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtApellido As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtTelefono As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtDireccion As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cboJornada As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents btnGuardar As Telerik.WinControls.UI.RadButton
    Friend WithEvents tblEmpleados As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnModificar As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class

