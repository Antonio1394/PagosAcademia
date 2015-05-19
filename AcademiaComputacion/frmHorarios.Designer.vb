<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHorarios
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
        Dim GridViewCommandColumn1 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewCommandColumn2 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.cboTipo = New Telerik.WinControls.UI.RadDropDownList()
        Me.btnGuardar = New Telerik.WinControls.UI.RadButton()
        Me.txtHorario = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
        Me.tbListadoHorarios = New Telerik.WinControls.UI.RadGridView()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.cboTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHorario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox4.SuspendLayout()
        CType(Me.tbListadoHorarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbListadoHorarios.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Controls.Add(Me.cboTipo)
        Me.RadGroupBox3.Controls.Add(Me.btnGuardar)
        Me.RadGroupBox3.Controls.Add(Me.txtHorario)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel5)
        Me.RadGroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadGroupBox3.HeaderText = "Nuevo Horario"
        Me.RadGroupBox3.Location = New System.Drawing.Point(35, 22)
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
        Me.RadGroupBox3.Size = New System.Drawing.Size(741, 116)
        Me.RadGroupBox3.TabIndex = 5
        Me.RadGroupBox3.Text = "Nuevo Horario"
        Me.RadGroupBox3.ThemeName = "VisualStudio2012Light"
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cboTipo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        RadListDataItem1.Text = "Diario"
        RadListDataItem1.TextWrap = True
        RadListDataItem2.Text = "Fin de semana"
        RadListDataItem2.TextWrap = True
        Me.cboTipo.Items.Add(RadListDataItem1)
        Me.cboTipo.Items.Add(RadListDataItem2)
        Me.cboTipo.Location = New System.Drawing.Point(166, 78)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.NullText = "Escoja una opcion"
        '
        '
        '
        Me.cboTipo.RootElement.AccessibleDescription = Nothing
        Me.cboTipo.RootElement.AccessibleName = Nothing
        Me.cboTipo.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.cboTipo.RootElement.AngleTransform = 0.0!
        Me.cboTipo.RootElement.FlipText = False
        Me.cboTipo.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.cboTipo.RootElement.Text = Nothing
        Me.cboTipo.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.cboTipo.Size = New System.Drawing.Size(354, 27)
        Me.cboTipo.TabIndex = 5
        Me.cboTipo.ThemeName = "VisualStudio2012Light"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnGuardar.Location = New System.Drawing.Point(583, 35)
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
        Me.btnGuardar.Size = New System.Drawing.Size(136, 44)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.ThemeName = "VisualStudio2012Light"
        '
        'txtHorario
        '
        Me.txtHorario.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtHorario.Location = New System.Drawing.Point(166, 33)
        Me.txtHorario.Name = "txtHorario"
        Me.txtHorario.NullText = "Ingrese un horario valido"
        '
        '
        '
        Me.txtHorario.RootElement.AccessibleDescription = Nothing
        Me.txtHorario.RootElement.AccessibleName = Nothing
        Me.txtHorario.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.txtHorario.RootElement.AngleTransform = 0.0!
        Me.txtHorario.RootElement.FlipText = False
        Me.txtHorario.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.txtHorario.RootElement.Text = Nothing
        Me.txtHorario.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.txtHorario.Size = New System.Drawing.Size(354, 27)
        Me.txtHorario.TabIndex = 2
        Me.txtHorario.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel4.Location = New System.Drawing.Point(97, 78)
        Me.RadLabel4.Name = "RadLabel4"
        '
        '
        '
        Me.RadLabel4.RootElement.AccessibleDescription = Nothing
        Me.RadLabel4.RootElement.AccessibleName = Nothing
        Me.RadLabel4.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.RadLabel4.RootElement.AngleTransform = 0.0!
        Me.RadLabel4.RootElement.FlipText = False
        Me.RadLabel4.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.RadLabel4.RootElement.Text = Nothing
        Me.RadLabel4.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.RadLabel4.Size = New System.Drawing.Size(43, 25)
        Me.RadLabel4.TabIndex = 1
        Me.RadLabel4.Text = "Tipo:"
        Me.RadLabel4.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadLabel5.Location = New System.Drawing.Point(74, 35)
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
        Me.RadLabel5.Size = New System.Drawing.Size(66, 25)
        Me.RadLabel5.TabIndex = 0
        Me.RadLabel5.Text = "Horario:"
        Me.RadLabel5.ThemeName = "VisualStudio2012Light"
        '
        'RadGroupBox4
        '
        Me.RadGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox4.Controls.Add(Me.tbListadoHorarios)
        Me.RadGroupBox4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadGroupBox4.HeaderText = ""
        Me.RadGroupBox4.Location = New System.Drawing.Point(35, 160)
        Me.RadGroupBox4.Name = "RadGroupBox4"
        '
        '
        '
        Me.RadGroupBox4.RootElement.AccessibleDescription = Nothing
        Me.RadGroupBox4.RootElement.AccessibleName = Nothing
        Me.RadGroupBox4.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.RadGroupBox4.RootElement.AngleTransform = 0.0!
        Me.RadGroupBox4.RootElement.FlipText = False
        Me.RadGroupBox4.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.RadGroupBox4.RootElement.Text = Nothing
        Me.RadGroupBox4.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.RadGroupBox4.Size = New System.Drawing.Size(741, 261)
        Me.RadGroupBox4.TabIndex = 6
        Me.RadGroupBox4.ThemeName = "VisualStudio2012Light"
        '
        'tbListadoHorarios
        '
        Me.tbListadoHorarios.BackColor = System.Drawing.Color.White
        Me.tbListadoHorarios.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbListadoHorarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbListadoHorarios.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.tbListadoHorarios.ForeColor = System.Drawing.Color.Black
        Me.tbListadoHorarios.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tbListadoHorarios.Location = New System.Drawing.Point(2, 18)
        '
        'tbListadoHorarios
        '
        Me.tbListadoHorarios.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom
        Me.tbListadoHorarios.MasterTemplate.AllowAddNewRow = False
        Me.tbListadoHorarios.MasterTemplate.AllowColumnReorder = False
        Me.tbListadoHorarios.MasterTemplate.AllowDragToGroup = False
        Me.tbListadoHorarios.MasterTemplate.AutoGenerateColumns = False
        GridViewCommandColumn1.AutoEllipsis = False
        GridViewCommandColumn1.DefaultText = "Eliminar"
        GridViewCommandColumn1.EnableExpressionEditor = False
        GridViewCommandColumn1.FieldName = "Eliminar"
        GridViewCommandColumn1.HeaderText = "Eliminar"
        GridViewCommandColumn1.Name = "eliminar"
        GridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn1.UseDefaultText = True
        GridViewCommandColumn1.Width = 66
        GridViewCommandColumn1.WrapText = True
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.HeaderText = "Codigo"
        GridViewTextBoxColumn1.IsPinned = True
        GridViewTextBoxColumn1.Name = "codigo"
        GridViewTextBoxColumn1.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
        GridViewTextBoxColumn1.ReadOnly = True
        GridViewTextBoxColumn1.Width = 116
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.HeaderText = "Horario"
        GridViewTextBoxColumn2.IsPinned = True
        GridViewTextBoxColumn2.Name = "horario"
        GridViewTextBoxColumn2.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
        GridViewTextBoxColumn2.ReadOnly = True
        GridViewTextBoxColumn2.Width = 112
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.HeaderText = "Jornada"
        GridViewTextBoxColumn3.IsPinned = True
        GridViewTextBoxColumn3.Name = "jornada"
        GridViewTextBoxColumn3.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
        GridViewTextBoxColumn3.ReadOnly = True
        GridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        GridViewTextBoxColumn3.Width = 133
        GridViewCommandColumn2.DefaultText = "Modificar"
        GridViewCommandColumn2.EnableExpressionEditor = False
        GridViewCommandColumn2.FieldName = "modificar"
        GridViewCommandColumn2.HeaderText = "Modificar"
        GridViewCommandColumn2.Name = "modificar"
        GridViewCommandColumn2.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
        GridViewCommandColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn2.UseDefaultText = True
        GridViewCommandColumn2.Width = 66
        Me.tbListadoHorarios.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewCommandColumn1, GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewCommandColumn2})
        Me.tbListadoHorarios.MasterTemplate.EnableFiltering = True
        SortDescriptor1.PropertyName = "modificar"
        Me.tbListadoHorarios.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.tbListadoHorarios.Name = "tbListadoHorarios"
        Me.tbListadoHorarios.ReadOnly = True
        Me.tbListadoHorarios.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        '
        '
        Me.tbListadoHorarios.RootElement.AccessibleDescription = Nothing
        Me.tbListadoHorarios.RootElement.AccessibleName = Nothing
        Me.tbListadoHorarios.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.tbListadoHorarios.RootElement.AngleTransform = 0.0!
        Me.tbListadoHorarios.RootElement.FlipText = False
        Me.tbListadoHorarios.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.tbListadoHorarios.RootElement.Text = Nothing
        Me.tbListadoHorarios.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.tbListadoHorarios.Size = New System.Drawing.Size(737, 241)
        Me.tbListadoHorarios.TabIndex = 0
        Me.tbListadoHorarios.Text = "RadGridView1"
        Me.tbListadoHorarios.ThemeName = "VisualStudio2012Light"
        '
        'FrmHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 406)
        Me.Controls.Add(Me.RadGroupBox3)
        Me.Controls.Add(Me.RadGroupBox4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmHorarios"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Horarios"
        Me.ThemeName = "TelerikMetro"
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        Me.RadGroupBox3.PerformLayout()
        CType(Me.cboTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHorario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox4.ResumeLayout(False)
        CType(Me.tbListadoHorarios.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbListadoHorarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents cboTipo As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents btnGuardar As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtHorario As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGroupBox4 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents tbListadoHorarios As Telerik.WinControls.UI.RadGridView
End Class

