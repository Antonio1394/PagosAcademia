﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoPagos
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
        Dim GridViewCommandColumn1 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim GridViewCommandColumn2 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.txtMonto = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.btnGuardar = New Telerik.WinControls.UI.RadButton()
        Me.txtDescripcion = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.tblTipoPagos = New Telerik.WinControls.UI.RadGridView()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblTipoPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblTipoPagos.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Controls.Add(Me.txtMonto)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox3.Controls.Add(Me.btnGuardar)
        Me.RadGroupBox3.Controls.Add(Me.txtDescripcion)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel5)
        Me.RadGroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RadGroupBox3.HeaderText = "Nuevo Tipo de Pagos"
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
        Me.RadGroupBox3.Size = New System.Drawing.Size(864, 115)
        Me.RadGroupBox3.TabIndex = 6
        Me.RadGroupBox3.Text = "Nuevo Tipo de Pagos"
        Me.RadGroupBox3.ThemeName = "TelerikMetro"
        '
        'txtMonto
        '
        Me.txtMonto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Location = New System.Drawing.Point(112, 72)
        Me.txtMonto.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(460, 27)
        Me.txtMonto.TabIndex = 2
        Me.txtMonto.TabStop = False
        Me.txtMonto.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(46, 72)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(60, 25)
        Me.RadLabel1.TabIndex = 7
        Me.RadLabel1.Text = "Monto:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnGuardar.Location = New System.Drawing.Point(667, 37)
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
        Me.btnGuardar.Size = New System.Drawing.Size(151, 60)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.ThemeName = "TelerikMetro"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtDescripcion.Location = New System.Drawing.Point(112, 37)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.NullText = "Ingrese un tipo de pago"
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
        Me.txtDescripcion.Size = New System.Drawing.Size(460, 27)
        Me.txtDescripcion.TabIndex = 1
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
        Me.RadLabel5.TabIndex = 5
        Me.RadLabel5.Text = "Descripcion:"
        Me.RadLabel5.ThemeName = "VisualStudio2012Light"
        '
        'tblTipoPagos
        '
        Me.tblTipoPagos.BackColor = System.Drawing.Color.White
        Me.tblTipoPagos.Cursor = System.Windows.Forms.Cursors.Default
        Me.tblTipoPagos.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblTipoPagos.ForeColor = System.Drawing.Color.Black
        Me.tblTipoPagos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tblTipoPagos.Location = New System.Drawing.Point(22, 134)
        '
        'tblTipoPagos
        '
        Me.tblTipoPagos.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom
        Me.tblTipoPagos.MasterTemplate.AllowAddNewRow = False
        Me.tblTipoPagos.MasterTemplate.AllowColumnReorder = False
        Me.tblTipoPagos.MasterTemplate.AllowDragToGroup = False
        Me.tblTipoPagos.MasterTemplate.AutoGenerateColumns = False
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.HeaderText = "Codigo"
        GridViewTextBoxColumn1.IsVisible = False
        GridViewTextBoxColumn1.Name = "codigo"
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.HeaderText = "Descripcion"
        GridViewTextBoxColumn2.Name = "descripcion"
        GridViewTextBoxColumn2.Width = 150
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.HeaderText = "Monto"
        GridViewTextBoxColumn3.Name = "monto"
        GridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn3.Width = 100
        GridViewCommandColumn1.DefaultText = "Modificar"
        GridViewCommandColumn1.EnableExpressionEditor = False
        GridViewCommandColumn1.HeaderText = "Modificar"
        GridViewCommandColumn1.Name = "modificar"
        GridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn1.UseDefaultText = True
        GridViewCommandColumn2.DefaultText = "Eliminar"
        GridViewCommandColumn2.EnableExpressionEditor = False
        GridViewCommandColumn2.HeaderText = "Eliminar"
        GridViewCommandColumn2.Name = "eliminar"
        GridViewCommandColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn2.UseDefaultText = True
        Me.tblTipoPagos.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewCommandColumn1, GridViewCommandColumn2})
        Me.tblTipoPagos.MasterTemplate.EnableFiltering = True
        Me.tblTipoPagos.Name = "tblTipoPagos"
        Me.tblTipoPagos.ReadOnly = True
        Me.tblTipoPagos.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        '
        '
        Me.tblTipoPagos.RootElement.AccessibleDescription = Nothing
        Me.tblTipoPagos.RootElement.AccessibleName = Nothing
        Me.tblTipoPagos.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.tblTipoPagos.RootElement.AngleTransform = 0.0!
        Me.tblTipoPagos.RootElement.FlipText = False
        Me.tblTipoPagos.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.tblTipoPagos.RootElement.Text = Nothing
        Me.tblTipoPagos.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.tblTipoPagos.ShowGroupPanel = False
        Me.tblTipoPagos.Size = New System.Drawing.Size(864, 416)
        Me.tblTipoPagos.TabIndex = 4
        Me.tblTipoPagos.Text = "RadGridView1"
        Me.tblTipoPagos.ThemeName = "TelerikMetro"
        '
        'FrmTipoPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 565)
        Me.Controls.Add(Me.tblTipoPagos)
        Me.Controls.Add(Me.RadGroupBox3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTipoPagos"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipos de Pagos"
        Me.ThemeName = "TelerikMetro"
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        Me.RadGroupBox3.PerformLayout()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblTipoPagos.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblTipoPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btnGuardar As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtDescripcion As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tblTipoPagos As Telerik.WinControls.UI.RadGridView
    Friend WithEvents txtMonto As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
End Class

