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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewCommandColumn1 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim GridViewCommandColumn2 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Me.cboTipoEmpleados = New Telerik.WinControls.UI.RadDropDownList()
        Me.txtNombre = New Telerik.WinControls.UI.RadTextBox()
        Me.txtApellido = New Telerik.WinControls.UI.RadTextBox()
        Me.txtTelefono = New Telerik.WinControls.UI.RadTextBox()
        Me.txtDireccion = New Telerik.WinControls.UI.RadTextBox()
        Me.cboJornada = New Telerik.WinControls.UI.RadDropDownList()
        Me.btnGuardar = New Telerik.WinControls.UI.RadButton()
        Me.tblEmpleados = New Telerik.WinControls.UI.RadGridView()
        Me.btnModificar = New Telerik.WinControls.UI.RadButton()
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
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboTipoEmpleados
        '
        Me.cboTipoEmpleados.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cboTipoEmpleados.Location = New System.Drawing.Point(30, 128)
        Me.cboTipoEmpleados.Name = "cboTipoEmpleados"
        Me.cboTipoEmpleados.Size = New System.Drawing.Size(180, 20)
        Me.cboTipoEmpleados.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(28, 26)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(182, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(336, 29)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(190, 20)
        Me.txtApellido.TabIndex = 2
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(30, 77)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(180, 20)
        Me.txtTelefono.TabIndex = 3
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(336, 77)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(190, 20)
        Me.txtDireccion.TabIndex = 4
        '
        'cboJornada
        '
        Me.cboJornada.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "Diario"
        RadListDataItem1.TextWrap = True
        RadListDataItem2.Text = "Fin de Semana"
        RadListDataItem2.TextWrap = True
        Me.cboJornada.Items.Add(RadListDataItem1)
        Me.cboJornada.Items.Add(RadListDataItem2)
        Me.cboJornada.Location = New System.Drawing.Point(336, 128)
        Me.cboJornada.Name = "cboJornada"
        Me.cboJornada.Size = New System.Drawing.Size(190, 20)
        Me.cboJornada.TabIndex = 5
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(229, 62)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(80, 66)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
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
        Me.tblEmpleados.Location = New System.Drawing.Point(30, 204)
        '
        'tblEmpleados
        '
        Me.tblEmpleados.MasterTemplate.AutoGenerateColumns = False
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.HeaderText = "Codigo"
        GridViewTextBoxColumn1.Name = "codigo"
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.HeaderText = "Nombre"
        GridViewTextBoxColumn2.Name = "nombre"
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.HeaderText = "Apellido"
        GridViewTextBoxColumn3.Name = "apellido"
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.HeaderText = "Direccion"
        GridViewTextBoxColumn4.Name = "direccion"
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.HeaderText = "Telefono"
        GridViewTextBoxColumn5.Name = "telefono"
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.HeaderText = "Puesto"
        GridViewTextBoxColumn6.Name = "tipo_empleado"
        GridViewTextBoxColumn7.EnableExpressionEditor = False
        GridViewTextBoxColumn7.HeaderText = "Jornada"
        GridViewTextBoxColumn7.Name = "jornada"
        GridViewTextBoxColumn8.EnableExpressionEditor = False
        GridViewTextBoxColumn8.HeaderText = "id_tipo_empleado"
        GridViewTextBoxColumn8.Name = "id_tipo_empleado"
        GridViewTextBoxColumn8.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending
        GridViewCommandColumn1.EnableExpressionEditor = False
        GridViewCommandColumn1.Name = "eliminar"
        GridViewCommandColumn2.EnableExpressionEditor = False
        GridViewCommandColumn2.Name = "modificar"
        Me.tblEmpleados.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewTextBoxColumn8, GridViewCommandColumn1, GridViewCommandColumn2})
        Me.tblEmpleados.MasterTemplate.ShowGroupedColumns = True
        SortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending
        SortDescriptor1.PropertyName = "id_tipo_empleado"
        Me.tblEmpleados.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.tblEmpleados.Name = "tblEmpleados"
        Me.tblEmpleados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tblEmpleados.Size = New System.Drawing.Size(710, 232)
        Me.tblEmpleados.TabIndex = 8
        Me.tblEmpleados.Text = "RadGridView1"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(620, 69)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(109, 59)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.Text = "Modificar"
        '
        'FrmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 439)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.tblEmpleados)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.cboJornada)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.cboTipoEmpleados)
        Me.Name = "FrmEmpleados"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "FrmEmpleados"
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
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class

