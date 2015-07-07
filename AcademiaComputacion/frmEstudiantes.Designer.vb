<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstudiantes
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
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.listadoAlumnos = New Telerik.WinControls.UI.RadGridView()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listadoAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listadoAlumnos.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(19, 3)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(300, 33)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Listado general de Estudiantes"
        Me.RadLabel1.ThemeName = "VisualStudio2012Light"
        '
        'listadoAlumnos
        '
        Me.listadoAlumnos.BackColor = System.Drawing.Color.White
        Me.listadoAlumnos.Cursor = System.Windows.Forms.Cursors.Default
        Me.listadoAlumnos.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.listadoAlumnos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.listadoAlumnos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.listadoAlumnos.Location = New System.Drawing.Point(19, 63)
        '
        'listadoAlumnos
        '
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "id"
        GridViewTextBoxColumn1.HeaderText = "Codigo"
        GridViewTextBoxColumn1.Name = "id"
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "first_name"
        GridViewTextBoxColumn2.HeaderText = "Nombre"
        GridViewTextBoxColumn2.Name = "first_name"
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "last_name"
        GridViewTextBoxColumn3.HeaderText = "Apellido"
        GridViewTextBoxColumn3.Name = "last_name"
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "phone"
        GridViewTextBoxColumn4.HeaderText = "Telefono"
        GridViewTextBoxColumn4.Name = "phone"
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "addres"
        GridViewTextBoxColumn5.HeaderText = "Direccion"
        GridViewTextBoxColumn5.Name = "addres"
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.FieldName = "in_charge"
        GridViewTextBoxColumn6.HeaderText = "Encargado"
        GridViewTextBoxColumn6.Name = "in_charge"
        GridViewTextBoxColumn7.EnableExpressionEditor = False
        GridViewTextBoxColumn7.FieldName = "state"
        GridViewTextBoxColumn7.HeaderText = "Estado"
        GridViewTextBoxColumn7.Name = "state"
        GridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.listadoAlumnos.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7})
        Me.listadoAlumnos.Name = "listadoAlumnos"
        Me.listadoAlumnos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.listadoAlumnos.Size = New System.Drawing.Size(1024, 470)
        Me.listadoAlumnos.TabIndex = 1
        Me.listadoAlumnos.Text = "RadGridView1"
        '
        'FrmEstudiantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 556)
        Me.Controls.Add(Me.listadoAlumnos)
        Me.Controls.Add(Me.RadLabel1)
        Me.Name = "FrmEstudiantes"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "FrmEstudiantes"
        Me.ThemeName = "TelerikMetro"
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listadoAlumnos.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listadoAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents listadoAlumnos As Telerik.WinControls.UI.RadGridView
End Class

