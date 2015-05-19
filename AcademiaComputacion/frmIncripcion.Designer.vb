<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIncripcion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIncripcion))
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.wizarInscripcion = New Telerik.WinControls.UI.RadWizard()
        Me.WizardCompletionPage1 = New Telerik.WinControls.UI.WizardCompletionPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAtras = New Telerik.WinControls.UI.RadButton()
        Me.btnSiguiente = New Telerik.WinControls.UI.RadButton()
        Me.panelEstudiante = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtEncargado = New Telerik.WinControls.UI.RadTextBox()
        Me.cboSexo = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txtTelefono = New Telerik.WinControls.UI.RadTextBox()
        Me.txtDireccion = New Telerik.WinControls.UI.RadTextBox()
        Me.txtapellido = New Telerik.WinControls.UI.RadTextBox()
        Me.txtNombre = New Telerik.WinControls.UI.RadTextBox()
        Me.panelGrupo = New System.Windows.Forms.Panel()
        Me.cboGrupo = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel10 = New Telerik.WinControls.UI.RadLabel()
        Me.cboPromotor = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.WizardWelcomePage1 = New Telerik.WinControls.UI.WizardWelcomePage()
        Me.WizardPage1 = New Telerik.WinControls.UI.WizardPage()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.alertaError = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.wizarInscripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.wizarInscripcion.SuspendLayout()
        CType(Me.btnAtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSiguiente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelEstudiante.SuspendLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEncargado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSexo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtapellido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelGrupo.SuspendLayout()
        CType(Me.cboGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPromotor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alertaError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wizarInscripcion
        '
        Me.wizarInscripcion.CompletionPage = Me.WizardCompletionPage1
        Me.wizarInscripcion.Controls.Add(Me.btnAtras)
        Me.wizarInscripcion.Controls.Add(Me.btnSiguiente)
        Me.wizarInscripcion.Controls.Add(Me.panelEstudiante)
        Me.wizarInscripcion.Controls.Add(Me.panelGrupo)
        Me.wizarInscripcion.Controls.Add(Me.Panel3)
        Me.wizarInscripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wizarInscripcion.Location = New System.Drawing.Point(0, 0)
        Me.wizarInscripcion.Name = "wizarInscripcion"
        Me.wizarInscripcion.PageHeaderIcon = CType(resources.GetObject("wizarInscripcion.PageHeaderIcon"), System.Drawing.Image)
        Me.wizarInscripcion.Pages.Add(Me.WizardWelcomePage1)
        Me.wizarInscripcion.Pages.Add(Me.WizardPage1)
        Me.wizarInscripcion.Pages.Add(Me.WizardCompletionPage1)
        Me.wizarInscripcion.Size = New System.Drawing.Size(667, 428)
        Me.wizarInscripcion.TabIndex = 0
        Me.wizarInscripcion.Text = "RadWizard1"
        Me.wizarInscripcion.ThemeName = "TelerikMetro"
        Me.wizarInscripcion.WelcomePage = Me.WizardWelcomePage1
        '
        'WizardCompletionPage1
        '
        Me.WizardCompletionPage1.ContentArea = Me.Panel3
        Me.WizardCompletionPage1.Name = "WizardCompletionPage1"
        Me.WizardCompletionPage1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(150, 69)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(517, 311)
        Me.Panel3.TabIndex = 2
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(119, 392)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(101, 24)
        Me.btnAtras.TabIndex = 52
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.ThemeName = "TelerikMetro"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(226, 392)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(100, 24)
        Me.btnSiguiente.TabIndex = 52
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.ThemeName = "TelerikMetro"
        '
        'panelEstudiante
        '
        Me.panelEstudiante.BackColor = System.Drawing.Color.White
        Me.panelEstudiante.Controls.Add(Me.DateTimePicker1)
        Me.panelEstudiante.Controls.Add(Me.RadLabel1)
        Me.panelEstudiante.Controls.Add(Me.txtEncargado)
        Me.panelEstudiante.Controls.Add(Me.cboSexo)
        Me.panelEstudiante.Controls.Add(Me.RadLabel9)
        Me.panelEstudiante.Controls.Add(Me.RadLabel7)
        Me.panelEstudiante.Controls.Add(Me.RadLabel6)
        Me.panelEstudiante.Controls.Add(Me.RadLabel5)
        Me.panelEstudiante.Controls.Add(Me.RadLabel4)
        Me.panelEstudiante.Controls.Add(Me.RadLabel3)
        Me.panelEstudiante.Controls.Add(Me.txtTelefono)
        Me.panelEstudiante.Controls.Add(Me.txtDireccion)
        Me.panelEstudiante.Controls.Add(Me.txtapellido)
        Me.panelEstudiante.Controls.Add(Me.txtNombre)
        Me.panelEstudiante.Location = New System.Drawing.Point(150, 69)
        Me.panelEstudiante.Name = "panelEstudiante"
        Me.panelEstudiante.Size = New System.Drawing.Size(517, 311)
        Me.panelEstudiante.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(173, 264)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(290, 22)
        Me.DateTimePicker1.TabIndex = 52
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(62, 143)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(92, 22)
        Me.RadLabel1.TabIndex = 45
        Me.RadLabel1.Text = "Encargado:"
        '
        'txtEncargado
        '
        Me.txtEncargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEncargado.Location = New System.Drawing.Point(173, 145)
        Me.txtEncargado.Name = "txtEncargado"
        Me.txtEncargado.Size = New System.Drawing.Size(290, 20)
        Me.txtEncargado.TabIndex = 40
        '
        'cboSexo
        '
        Me.cboSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadListDataItem1.Text = "Masculino"
        RadListDataItem1.TextWrap = True
        RadListDataItem2.Text = "Femenino"
        RadListDataItem2.TextWrap = True
        Me.cboSexo.Items.Add(RadListDataItem1)
        Me.cboSexo.Items.Add(RadListDataItem2)
        Me.cboSexo.Location = New System.Drawing.Point(173, 226)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(290, 20)
        Me.cboSexo.TabIndex = 51
        Me.cboSexo.Text = "Masculino"
        Me.cboSexo.ThemeName = "Office2013Light"
        '
        'RadLabel9
        '
        Me.RadLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel9.Location = New System.Drawing.Point(104, 224)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(50, 22)
        Me.RadLabel9.TabIndex = 49
        Me.RadLabel9.Text = "Sexo:"
        '
        'RadLabel7
        '
        Me.RadLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel7.Location = New System.Drawing.Point(77, 185)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(77, 22)
        Me.RadLabel7.TabIndex = 47
        Me.RadLabel7.Text = "Telefono:"
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(9, 264)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(145, 22)
        Me.RadLabel6.TabIndex = 46
        Me.RadLabel6.Text = "Fecha Nacimiento:"
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.Location = New System.Drawing.Point(73, 102)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(81, 22)
        Me.RadLabel5.TabIndex = 45
        Me.RadLabel5.Text = "Direccion:"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(83, 59)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(71, 22)
        Me.RadLabel4.TabIndex = 44
        Me.RadLabel4.Text = "Apellido:"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(83, 19)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(71, 22)
        Me.RadLabel3.TabIndex = 43
        Me.RadLabel3.Text = "Nombre:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(173, 187)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(290, 20)
        Me.txtTelefono.TabIndex = 44
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(173, 104)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(290, 20)
        Me.txtDireccion.TabIndex = 39
        '
        'txtapellido
        '
        Me.txtapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido.Location = New System.Drawing.Point(173, 61)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(290, 20)
        Me.txtapellido.TabIndex = 38
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(173, 21)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(290, 20)
        Me.txtNombre.TabIndex = 37
        '
        'panelGrupo
        '
        Me.panelGrupo.BackColor = System.Drawing.Color.White
        Me.panelGrupo.Controls.Add(Me.cboGrupo)
        Me.panelGrupo.Controls.Add(Me.RadLabel10)
        Me.panelGrupo.Controls.Add(Me.cboPromotor)
        Me.panelGrupo.Controls.Add(Me.RadLabel8)
        Me.panelGrupo.Controls.Add(Me.RadDropDownList1)
        Me.panelGrupo.Controls.Add(Me.RadLabel2)
        Me.panelGrupo.Location = New System.Drawing.Point(0, 77)
        Me.panelGrupo.Name = "panelGrupo"
        Me.panelGrupo.Size = New System.Drawing.Size(667, 303)
        Me.panelGrupo.TabIndex = 1
        '
        'cboGrupo
        '
        Me.cboGrupo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cboGrupo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrupo.Location = New System.Drawing.Point(269, 158)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(274, 27)
        Me.cboGrupo.TabIndex = 3
        Me.cboGrupo.Text = "RadDropDownList2"
        Me.cboGrupo.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel10
        '
        Me.RadLabel10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel10.Location = New System.Drawing.Point(163, 160)
        Me.RadLabel10.Name = "RadLabel10"
        Me.RadLabel10.Size = New System.Drawing.Size(57, 25)
        Me.RadLabel10.TabIndex = 2
        Me.RadLabel10.Text = "Grupo:"
        '
        'cboPromotor
        '
        Me.cboPromotor.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cboPromotor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPromotor.Location = New System.Drawing.Point(269, 103)
        Me.cboPromotor.Name = "cboPromotor"
        Me.cboPromotor.Size = New System.Drawing.Size(274, 27)
        Me.cboPromotor.TabIndex = 2
        Me.cboPromotor.Text = "RadDropDownList2"
        Me.cboPromotor.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel8
        '
        Me.RadLabel8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel8.Location = New System.Drawing.Point(139, 103)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(81, 25)
        Me.RadLabel8.TabIndex = 1
        Me.RadLabel8.Text = "Promotor:"
        '
        'RadDropDownList1
        '
        Me.RadDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.RadDropDownList1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadListDataItem3.Text = "Personal"
        RadListDataItem3.TextWrap = True
        RadListDataItem4.Text = "Promotor"
        RadListDataItem4.TextWrap = True
        Me.RadDropDownList1.Items.Add(RadListDataItem3)
        Me.RadDropDownList1.Items.Add(RadListDataItem4)
        Me.RadDropDownList1.Location = New System.Drawing.Point(269, 56)
        Me.RadDropDownList1.Name = "RadDropDownList1"
        Me.RadDropDownList1.Size = New System.Drawing.Size(274, 27)
        Me.RadDropDownList1.TabIndex = 1
        Me.RadDropDownList1.Text = "Personal"
        Me.RadDropDownList1.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(71, 58)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(149, 25)
        Me.RadLabel2.TabIndex = 0
        Me.RadLabel2.Text = "Tipo de Inscripcion:"
        '
        'WizardWelcomePage1
        '
        Me.WizardWelcomePage1.ContentArea = Me.panelEstudiante
        Me.WizardWelcomePage1.CustomizePageHeader = False
        Me.WizardWelcomePage1.HeaderVisibility = Telerik.WinControls.ElementVisibility.Visible
        Me.WizardWelcomePage1.Name = "WizardWelcomePage1"
        Me.WizardWelcomePage1.Title = "Incripcion de Alumnos"
        Me.WizardWelcomePage1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'WizardPage1
        '
        Me.WizardPage1.ContentArea = Me.panelGrupo
        Me.WizardPage1.CustomizePageHeader = False
        Me.WizardPage1.Header = ""
        Me.WizardPage1.HeaderVisibility = Telerik.WinControls.ElementVisibility.Hidden
        Me.WizardPage1.Name = "WizardPage1"
        Me.WizardPage1.Title = "Asignacion de Grupo"
        Me.WizardPage1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'alertaError
        '
        Me.alertaError.ContainerControl = Me
        '
        'FrmIncripcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 428)
        Me.Controls.Add(Me.wizarInscripcion)
        Me.Name = "FrmIncripcion"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Registro Inscripcion"
        Me.ThemeName = "TelerikMetro"
        CType(Me.wizarInscripcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.wizarInscripcion.ResumeLayout(False)
        CType(Me.btnAtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSiguiente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelEstudiante.ResumeLayout(False)
        Me.panelEstudiante.PerformLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEncargado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSexo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtapellido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelGrupo.ResumeLayout(False)
        Me.panelGrupo.PerformLayout()
        CType(Me.cboGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPromotor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alertaError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents wizarInscripcion As Telerik.WinControls.UI.RadWizard
    Friend WithEvents WizardCompletionPage1 As Telerik.WinControls.UI.WizardCompletionPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents panelEstudiante As System.Windows.Forms.Panel
    Friend WithEvents panelGrupo As System.Windows.Forms.Panel
    Friend WithEvents WizardWelcomePage1 As Telerik.WinControls.UI.WizardWelcomePage
    Friend WithEvents WizardPage1 As Telerik.WinControls.UI.WizardPage
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents btnAtras As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSiguiente As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtEncargado As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cboSexo As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtTelefono As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtDireccion As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtapellido As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtNombre As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents alertaError As System.Windows.Forms.ErrorProvider
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboGrupo As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel10 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents cboPromotor As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
End Class

