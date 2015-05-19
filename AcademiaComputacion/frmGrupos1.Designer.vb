<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGrupos1
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
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewCommandColumn1 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim GridViewCommandColumn2 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.tblGrupos = New Telerik.WinControls.UI.RadGridView()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.btnGuardar = New Telerik.WinControls.UI.RadButton()
        Me.txtHorario = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.cboProgramas = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.cboHorarioPractica = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.cboLaboratorio = New Telerik.WinControls.UI.RadDropDownList()
        Me.cboCatedratico = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.cboDia = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.cboJornada = New Telerik.WinControls.UI.RadDropDownList()
        Me.AlertaError = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.tblGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblGrupos.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHorario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProgramas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboHorarioPractica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLaboratorio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCatedratico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboJornada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlertaError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Controls.Add(Me.tblGrupos)
        Me.RadGroupBox2.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Center
        Me.RadGroupBox2.HeaderText = "Listado de Grupos"
        Me.RadGroupBox2.Location = New System.Drawing.Point(27, 185)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(891, 219)
        Me.RadGroupBox2.TabIndex = 3
        Me.RadGroupBox2.Text = "Listado de Grupos"
        Me.RadGroupBox2.ThemeName = "VisualStudio2012Light"
        '
        'tblGrupos
        '
        Me.tblGrupos.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.tblGrupos.Cursor = System.Windows.Forms.Cursors.Default
        Me.tblGrupos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblGrupos.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tblGrupos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tblGrupos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tblGrupos.Location = New System.Drawing.Point(2, 18)
        '
        'tblGrupos
        '
        Me.tblGrupos.MasterTemplate.AllowAddNewRow = False
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "codigo"
        GridViewTextBoxColumn1.HeaderText = "codigo"
        GridViewTextBoxColumn1.Name = "codigo"
        GridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "horario"
        GridViewTextBoxColumn2.HeaderText = "Dia"
        GridViewTextBoxColumn2.Name = "dia"
        GridViewTextBoxColumn2.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "dia"
        GridViewTextBoxColumn3.HeaderText = "Horario"
        GridViewTextBoxColumn3.Name = "horario"
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "programa"
        GridViewTextBoxColumn4.HeaderText = "Programa Actual"
        GridViewTextBoxColumn4.Name = "programa"
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "maestro"
        GridViewTextBoxColumn5.HeaderText = "Catedratico"
        GridViewTextBoxColumn5.Name = "maestro"
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.FieldName = "usuario"
        GridViewTextBoxColumn6.HeaderText = "Usuario"
        GridViewTextBoxColumn6.Name = "usuario"
        GridViewCommandColumn1.DefaultText = "Eliminar"
        GridViewCommandColumn1.EnableExpressionEditor = False
        GridViewCommandColumn1.FieldName = "eliminar"
        GridViewCommandColumn1.HeaderText = "Eliminar"
        GridViewCommandColumn1.Name = "eliminar"
        GridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn1.UseDefaultText = True
        GridViewCommandColumn2.DefaultText = "Modificar"
        GridViewCommandColumn2.EnableExpressionEditor = False
        GridViewCommandColumn2.FieldName = "modificar"
        GridViewCommandColumn2.HeaderText = "modoficar"
        GridViewCommandColumn2.Name = "modificar"
        GridViewCommandColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn2.UseDefaultText = True
        Me.tblGrupos.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewCommandColumn1, GridViewCommandColumn2})
        SortDescriptor1.PropertyName = "dia"
        Me.tblGrupos.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.tblGrupos.Name = "tblGrupos"
        Me.tblGrupos.ReadOnly = True
        Me.tblGrupos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tblGrupos.Size = New System.Drawing.Size(887, 199)
        Me.tblGrupos.TabIndex = 0
        Me.tblGrupos.Text = "RadGridView1"
        Me.tblGrupos.ThemeName = "VisualStudio2012Light"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.btnGuardar)
        Me.RadGroupBox1.Controls.Add(Me.txtHorario)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel7)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel6)
        Me.RadGroupBox1.Controls.Add(Me.cboProgramas)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel5)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox1.Controls.Add(Me.cboHorarioPractica)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox1.Controls.Add(Me.cboLaboratorio)
        Me.RadGroupBox1.Controls.Add(Me.cboCatedratico)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox1.Controls.Add(Me.cboDia)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Controls.Add(Me.cboJornada)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBox1.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Center
        Me.RadGroupBox1.HeaderText = "Crear Grupo"
        Me.RadGroupBox1.Location = New System.Drawing.Point(27, 5)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(891, 174)
        Me.RadGroupBox1.TabIndex = 2
        Me.RadGroupBox1.Text = "Crear Grupo"
        Me.RadGroupBox1.ThemeName = "VisualStudio2012Light"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(754, 134)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(132, 35)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Crear Registro"
        Me.btnGuardar.ThemeName = "VisualStudio2012Light"
        '
        'txtHorario
        '
        Me.txtHorario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHorario.Location = New System.Drawing.Point(587, 98)
        Me.txtHorario.Name = "txtHorario"
        Me.txtHorario.NullText = "Ej. 07:30 A 10:30"
        Me.txtHorario.Size = New System.Drawing.Size(299, 27)
        Me.txtHorario.TabIndex = 13
        Me.txtHorario.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel7
        '
        Me.RadLabel7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel7.Location = New System.Drawing.Point(515, 100)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(66, 25)
        Me.RadLabel7.TabIndex = 12
        Me.RadLabel7.Text = "Horario:"
        Me.RadLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel7.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(499, 65)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(82, 25)
        Me.RadLabel6.TabIndex = 11
        Me.RadLabel6.Text = "Programa:"
        Me.RadLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadLabel6.ThemeName = "VisualStudio2012Light"
        '
        'cboProgramas
        '
        Me.cboProgramas.AccessibleDescription = ""
        Me.cboProgramas.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cboProgramas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProgramas.Location = New System.Drawing.Point(587, 65)
        Me.cboProgramas.Name = "cboProgramas"
        Me.cboProgramas.Size = New System.Drawing.Size(299, 27)
        Me.cboProgramas.TabIndex = 10
        Me.cboProgramas.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.Location = New System.Drawing.Point(454, 34)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(127, 25)
        Me.RadLabel5.TabIndex = 9
        Me.RadLabel5.Text = "Horario Practica:"
        Me.RadLabel5.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(8, 133)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(96, 25)
        Me.RadLabel4.TabIndex = 7
        Me.RadLabel4.Text = "Laboratorio:"
        Me.RadLabel4.ThemeName = "VisualStudio2012Light"
        '
        'cboHorarioPractica
        '
        Me.cboHorarioPractica.AccessibleDescription = ""
        Me.cboHorarioPractica.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cboHorarioPractica.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHorarioPractica.Location = New System.Drawing.Point(587, 32)
        Me.cboHorarioPractica.Name = "cboHorarioPractica"
        Me.cboHorarioPractica.Size = New System.Drawing.Size(299, 27)
        Me.cboHorarioPractica.TabIndex = 8
        Me.cboHorarioPractica.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(8, 100)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(95, 25)
        Me.RadLabel3.TabIndex = 5
        Me.RadLabel3.Text = "Catedratico:"
        Me.RadLabel3.ThemeName = "VisualStudio2012Light"
        '
        'cboLaboratorio
        '
        Me.cboLaboratorio.AccessibleDescription = ""
        Me.cboLaboratorio.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cboLaboratorio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLaboratorio.Location = New System.Drawing.Point(105, 131)
        Me.cboLaboratorio.Name = "cboLaboratorio"
        Me.cboLaboratorio.Size = New System.Drawing.Size(299, 27)
        Me.cboLaboratorio.TabIndex = 6
        Me.cboLaboratorio.ThemeName = "VisualStudio2012Light"
        '
        'cboCatedratico
        '
        Me.cboCatedratico.AccessibleDescription = ""
        Me.cboCatedratico.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cboCatedratico.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCatedratico.Location = New System.Drawing.Point(105, 98)
        Me.cboCatedratico.Name = "cboCatedratico"
        Me.cboCatedratico.Size = New System.Drawing.Size(299, 27)
        Me.cboCatedratico.TabIndex = 4
        Me.cboCatedratico.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(67, 65)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(35, 25)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "Dia:"
        Me.RadLabel2.ThemeName = "VisualStudio2012Light"
        '
        'cboDia
        '
        Me.cboDia.AccessibleDescription = ""
        Me.cboDia.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cboDia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDia.Location = New System.Drawing.Point(105, 65)
        Me.cboDia.Name = "cboDia"
        Me.cboDia.Size = New System.Drawing.Size(299, 27)
        Me.cboDia.TabIndex = 2
        Me.cboDia.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(34, 34)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(68, 25)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "Jornada:"
        Me.RadLabel1.ThemeName = "VisualStudio2012Light"
        '
        'cboJornada
        '
        Me.cboJornada.AccessibleDescription = ""
        Me.cboJornada.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cboJornada.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadListDataItem1.Text = "Diario"
        RadListDataItem1.TextWrap = True
        RadListDataItem2.Text = "Fin de semana"
        RadListDataItem2.TextWrap = True
        Me.cboJornada.Items.Add(RadListDataItem1)
        Me.cboJornada.Items.Add(RadListDataItem2)
        Me.cboJornada.Location = New System.Drawing.Point(105, 32)
        Me.cboJornada.Name = "cboJornada"
        Me.cboJornada.Size = New System.Drawing.Size(299, 27)
        Me.cboJornada.TabIndex = 0
        Me.cboJornada.Text = "Seleccione una opcion"
        Me.cboJornada.ThemeName = "VisualStudio2012Light"
        '
        'AlertaError
        '
        Me.AlertaError.ContainerControl = Me
        '
        'FrmGrupos1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 473)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Name = "FrmGrupos1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grupos"
        Me.ThemeName = "TelerikMetro"
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        CType(Me.tblGrupos.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHorario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProgramas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboHorarioPractica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLaboratorio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCatedratico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboJornada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlertaError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents tblGrupos As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents txtHorario As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents cboProgramas As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents cboHorarioPractica As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents cboLaboratorio As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents cboCatedratico As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents cboDia As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents cboJornada As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents btnGuardar As Telerik.WinControls.UI.RadButton
    Friend WithEvents AlertaError As System.Windows.Forms.ErrorProvider
End Class

