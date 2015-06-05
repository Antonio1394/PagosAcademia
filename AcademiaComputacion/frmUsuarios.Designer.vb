<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
        Dim GridViewCommandColumn2 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewCommandColumn3 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.RadGroupBox6 = New Telerik.WinControls.UI.RadGroupBox()
        Me.tblListadoUsuarios = New Telerik.WinControls.UI.RadGridView()
        Me.RadGroupBox5 = New Telerik.WinControls.UI.RadGroupBox()
        Me.cboEmpleado = New Telerik.WinControls.UI.RadDropDownList()
        Me.cboTipoUsuario = New Telerik.WinControls.UI.RadDropDownList()
        Me.btnGuardar = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtPassword = New Telerik.WinControls.UI.RadTextBox()
        Me.txtUser = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox6.SuspendLayout()
        CType(Me.tblListadoUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblListadoUsuarios.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox5.SuspendLayout()
        CType(Me.cboEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox6
        '
        Me.RadGroupBox6.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox6.Controls.Add(Me.tblListadoUsuarios)
        Me.RadGroupBox6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadGroupBox6.HeaderText = ""
        Me.RadGroupBox6.Location = New System.Drawing.Point(31, 244)
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
        Me.RadGroupBox6.Size = New System.Drawing.Size(766, 212)
        Me.RadGroupBox6.TabIndex = 12
        Me.RadGroupBox6.ThemeName = "VisualStudio2012Light"
        '
        'tblListadoUsuarios
        '
        Me.tblListadoUsuarios.BackColor = System.Drawing.Color.White
        Me.tblListadoUsuarios.Cursor = System.Windows.Forms.Cursors.Default
        Me.tblListadoUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblListadoUsuarios.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.tblListadoUsuarios.ForeColor = System.Drawing.Color.Black
        Me.tblListadoUsuarios.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tblListadoUsuarios.Location = New System.Drawing.Point(2, 18)
        '
        'tblListadoUsuarios
        '
        Me.tblListadoUsuarios.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom
        Me.tblListadoUsuarios.MasterTemplate.AllowAddNewRow = False
        Me.tblListadoUsuarios.MasterTemplate.AllowColumnReorder = False
        Me.tblListadoUsuarios.MasterTemplate.AllowDragToGroup = False
        Me.tblListadoUsuarios.MasterTemplate.AutoGenerateColumns = False
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
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.HeaderText = "Codigo"
        GridViewTextBoxColumn1.Name = "codigo"
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.HeaderText = "Usuario"
        GridViewTextBoxColumn2.Name = "usuario"
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.HeaderText = "Permisos"
        GridViewTextBoxColumn3.Name = "permisos"
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.HeaderText = "Empleado"
        GridViewTextBoxColumn4.Name = "empleado"
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.HeaderText = "Estado"
        GridViewTextBoxColumn5.Name = "estado"
        GridViewCommandColumn3.DefaultText = "Restablecer"
        GridViewCommandColumn3.EnableExpressionEditor = False
        GridViewCommandColumn3.HeaderText = "Restablecer "
        GridViewCommandColumn3.Name = "restablecer"
        GridViewCommandColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn3.UseDefaultText = True
        Me.tblListadoUsuarios.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewCommandColumn1, GridViewCommandColumn2, GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewCommandColumn3})
        Me.tblListadoUsuarios.MasterTemplate.EnableFiltering = True
        Me.tblListadoUsuarios.Name = "tblListadoUsuarios"
        Me.tblListadoUsuarios.ReadOnly = True
        Me.tblListadoUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        '
        '
        Me.tblListadoUsuarios.RootElement.AccessibleDescription = Nothing
        Me.tblListadoUsuarios.RootElement.AccessibleName = Nothing
        Me.tblListadoUsuarios.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.tblListadoUsuarios.RootElement.AngleTransform = 0.0!
        Me.tblListadoUsuarios.RootElement.FlipText = False
        Me.tblListadoUsuarios.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.tblListadoUsuarios.RootElement.Text = Nothing
        Me.tblListadoUsuarios.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.tblListadoUsuarios.Size = New System.Drawing.Size(762, 192)
        Me.tblListadoUsuarios.TabIndex = 0
        Me.tblListadoUsuarios.Text = "RadGridView1"
        Me.tblListadoUsuarios.ThemeName = "VisualStudio2012Light"
        '
        'RadGroupBox5
        '
        Me.RadGroupBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox5.Controls.Add(Me.cboEmpleado)
        Me.RadGroupBox5.Controls.Add(Me.cboTipoUsuario)
        Me.RadGroupBox5.Controls.Add(Me.btnGuardar)
        Me.RadGroupBox5.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox5.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox5.Controls.Add(Me.txtPassword)
        Me.RadGroupBox5.Controls.Add(Me.txtUser)
        Me.RadGroupBox5.Controls.Add(Me.RadLabel8)
        Me.RadGroupBox5.Controls.Add(Me.RadLabel9)
        Me.RadGroupBox5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadGroupBox5.HeaderText = "Nuevo Usario"
        Me.RadGroupBox5.Location = New System.Drawing.Point(31, 16)
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
        Me.RadGroupBox5.Size = New System.Drawing.Size(766, 222)
        Me.RadGroupBox5.TabIndex = 11
        Me.RadGroupBox5.Text = "Nuevo Usario"
        Me.RadGroupBox5.ThemeName = "VisualStudio2012Light"
        '
        'cboEmpleado
        '
        Me.cboEmpleado.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cboEmpleado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmpleado.Location = New System.Drawing.Point(437, 127)
        Me.cboEmpleado.Name = "cboEmpleado"
        Me.cboEmpleado.NullText = "Seleccione una opcion"
        Me.cboEmpleado.Size = New System.Drawing.Size(311, 27)
        Me.cboEmpleado.TabIndex = 15
        Me.cboEmpleado.ThemeName = "VisualStudio2012Light"
        '
        'cboTipoUsuario
        '
        Me.cboTipoUsuario.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cboTipoUsuario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadListDataItem1.Text = "Administrador"
        RadListDataItem1.TextWrap = True
        RadListDataItem2.Text = "Secretaria"
        RadListDataItem2.TextWrap = True
        RadListDataItem3.Text = "Catedrático"
        RadListDataItem3.TextWrap = True
        Me.cboTipoUsuario.Items.Add(RadListDataItem1)
        Me.cboTipoUsuario.Items.Add(RadListDataItem2)
        Me.cboTipoUsuario.Items.Add(RadListDataItem3)
        Me.cboTipoUsuario.Location = New System.Drawing.Point(22, 127)
        Me.cboTipoUsuario.Name = "cboTipoUsuario"
        Me.cboTipoUsuario.NullText = "Seleccione una opcion"
        Me.cboTipoUsuario.Size = New System.Drawing.Size(331, 27)
        Me.cboTipoUsuario.TabIndex = 13
        Me.cboTipoUsuario.ThemeName = "VisualStudio2012Light"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnGuardar.Location = New System.Drawing.Point(627, 174)
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
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel3.Location = New System.Drawing.Point(437, 96)
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
        Me.RadLabel3.Size = New System.Drawing.Size(80, 25)
        Me.RadLabel3.TabIndex = 14
        Me.RadLabel3.Text = "Empleado"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel2.Location = New System.Drawing.Point(22, 96)
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
        Me.RadLabel2.Size = New System.Drawing.Size(123, 25)
        Me.RadLabel2.TabIndex = 12
        Me.RadLabel2.Text = "Tipo de Usuario"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtPassword.Location = New System.Drawing.Point(437, 63)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.NullText = "Contraseña para el Usuario"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        '
        '
        '
        Me.txtPassword.RootElement.AccessibleDescription = Nothing
        Me.txtPassword.RootElement.AccessibleName = Nothing
        Me.txtPassword.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.txtPassword.RootElement.AngleTransform = 0.0!
        Me.txtPassword.RootElement.FlipText = False
        Me.txtPassword.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.txtPassword.RootElement.Text = Nothing
        Me.txtPassword.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.txtPassword.Size = New System.Drawing.Size(311, 27)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.ThemeName = "VisualStudio2012Light"
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtUser.Location = New System.Drawing.Point(22, 63)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.NullText = "Usuario ejemplo: jGarcia2015"
        '
        '
        '
        Me.txtUser.RootElement.AccessibleDescription = Nothing
        Me.txtUser.RootElement.AccessibleName = Nothing
        Me.txtUser.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.txtUser.RootElement.AngleTransform = 0.0!
        Me.txtUser.RootElement.FlipText = False
        Me.txtUser.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.txtUser.RootElement.Text = Nothing
        Me.txtUser.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.txtUser.Size = New System.Drawing.Size(331, 27)
        Me.txtUser.TabIndex = 2
        Me.txtUser.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel8
        '
        Me.RadLabel8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel8.Location = New System.Drawing.Point(437, 32)
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
        Me.RadLabel8.Size = New System.Drawing.Size(76, 25)
        Me.RadLabel8.TabIndex = 1
        Me.RadLabel8.Text = "Password"
        Me.RadLabel8.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel9
        '
        Me.RadLabel9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel9.Location = New System.Drawing.Point(22, 32)
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
        Me.RadLabel9.Size = New System.Drawing.Size(63, 25)
        Me.RadLabel9.TabIndex = 0
        Me.RadLabel9.Text = "Usuario"
        Me.RadLabel9.ThemeName = "VisualStudio2012Light"
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 480)
        Me.Controls.Add(Me.RadGroupBox6)
        Me.Controls.Add(Me.RadGroupBox5)
        Me.Name = "FrmUsuarios"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "FrmUsuarios"
        Me.ThemeName = "TelerikMetro"
        CType(Me.RadGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox6.ResumeLayout(False)
        CType(Me.tblListadoUsuarios.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblListadoUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox5.ResumeLayout(False)
        Me.RadGroupBox5.PerformLayout()
        CType(Me.cboEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents RadGroupBox6 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents tblListadoUsuarios As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGroupBox5 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents cboEmpleado As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents cboTipoUsuario As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents btnGuardar As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPassword As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtUser As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
End Class

