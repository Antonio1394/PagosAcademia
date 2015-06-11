<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagosExtras
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
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.RadWizard1 = New Telerik.WinControls.UI.RadWizard()
        Me.btnSiguiente = New Telerik.WinControls.UI.RadButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEditar = New Telerik.WinControls.UI.RadButton()
        Me.lblResultado = New Telerik.WinControls.UI.RadLabel()
        Me.cboPagoExtra = New Telerik.WinControls.UI.RadDropDownList()
        Me.txtMonto = New Telerik.WinControls.UI.RadTextBox()
        Me.txtEncargado = New Telerik.WinControls.UI.RadTextBox()
        Me.txtNombreAlumnos = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCodigoAlumno = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.WizardWelcomePage1 = New Telerik.WinControls.UI.WizardWelcomePage()
        Me.WizardPage1 = New Telerik.WinControls.UI.WizardPage()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCancelar = New Telerik.WinControls.UI.RadButton()
        Me.btnAtras = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadWizard1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadWizard1.SuspendLayout()
        CType(Me.btnSiguiente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btnEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPagoExtra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEncargado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadWizard1
        '
        Me.RadWizard1.CompletionPage = Nothing
        Me.RadWizard1.Controls.Add(Me.btnAtras)
        Me.RadWizard1.Controls.Add(Me.btnCancelar)
        Me.RadWizard1.Controls.Add(Me.btnSiguiente)
        Me.RadWizard1.Controls.Add(Me.Panel1)
        Me.RadWizard1.Controls.Add(Me.Panel2)
        Me.RadWizard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadWizard1.HideWelcomeImage = True
        Me.RadWizard1.Location = New System.Drawing.Point(0, 0)
        Me.RadWizard1.Name = "RadWizard1"
        Me.RadWizard1.PageHeaderIcon = Global.AcademiaComputacion.My.Resources.Resources.payment7
        Me.RadWizard1.Pages.Add(Me.WizardWelcomePage1)
        Me.RadWizard1.Pages.Add(Me.WizardPage1)
        Me.RadWizard1.Size = New System.Drawing.Size(724, 396)
        Me.RadWizard1.TabIndex = 0
        Me.RadWizard1.Text = "RadWizard1"
        Me.RadWizard1.ThemeName = "TelerikMetro"
        Me.RadWizard1.WelcomePage = Me.WizardWelcomePage1
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(502, 360)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(105, 24)
        Me.btnSiguiente.TabIndex = 22
        Me.btnSiguiente.Text = "Confirmar Pago"
        Me.btnSiguiente.ThemeName = "TelerikMetro"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnEditar)
        Me.Panel1.Controls.Add(Me.lblResultado)
        Me.Panel1.Controls.Add(Me.cboPagoExtra)
        Me.Panel1.Controls.Add(Me.txtMonto)
        Me.Panel1.Controls.Add(Me.txtEncargado)
        Me.Panel1.Controls.Add(Me.txtNombreAlumnos)
        Me.Panel1.Controls.Add(Me.txtCodigoAlumno)
        Me.Panel1.Controls.Add(Me.RadLabel5)
        Me.Panel1.Controls.Add(Me.RadLabel4)
        Me.Panel1.Controls.Add(Me.RadLabel3)
        Me.Panel1.Controls.Add(Me.RadLabel2)
        Me.Panel1.Controls.Add(Me.RadLabel1)
        Me.Panel1.Location = New System.Drawing.Point(0, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(724, 279)
        Me.Panel1.TabIndex = 0
        '
        'btnEditar
        '
        Me.btnEditar.Image = Global.AcademiaComputacion.My.Resources.Resources.write12
        Me.btnEditar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEditar.Location = New System.Drawing.Point(469, 180)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(30, 25)
        Me.btnEditar.TabIndex = 21
        Me.btnEditar.ThemeName = "VisualStudio2012Light"
        '
        'lblResultado
        '
        Me.lblResultado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(472, 56)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(147, 25)
        Me.lblResultado.TabIndex = 20
        Me.lblResultado.Text = "Ningun Resultado"
        Me.lblResultado.ThemeName = "VisualStudio2012Light"
        '
        'cboPagoExtra
        '
        Me.cboPagoExtra.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cboPagoExtra.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPagoExtra.Location = New System.Drawing.Point(43, 211)
        Me.cboPagoExtra.Name = "cboPagoExtra"
        Me.cboPagoExtra.Size = New System.Drawing.Size(292, 27)
        Me.cboPagoExtra.TabIndex = 9
        Me.cboPagoExtra.ThemeName = "VisualStudio2012Light"
        '
        'txtMonto
        '
        Me.txtMonto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Location = New System.Drawing.Point(402, 211)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(292, 27)
        Me.txtMonto.TabIndex = 8
        Me.txtMonto.ThemeName = "VisualStudio2012Light"
        '
        'txtEncargado
        '
        Me.txtEncargado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEncargado.Location = New System.Drawing.Point(402, 133)
        Me.txtEncargado.Name = "txtEncargado"
        Me.txtEncargado.Size = New System.Drawing.Size(292, 27)
        Me.txtEncargado.TabIndex = 7
        Me.txtEncargado.ThemeName = "VisualStudio2012Light"
        '
        'txtNombreAlumnos
        '
        Me.txtNombreAlumnos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreAlumnos.Location = New System.Drawing.Point(43, 133)
        Me.txtNombreAlumnos.Name = "txtNombreAlumnos"
        Me.txtNombreAlumnos.Size = New System.Drawing.Size(292, 27)
        Me.txtNombreAlumnos.TabIndex = 6
        Me.txtNombreAlumnos.ThemeName = "VisualStudio2012Light"
        '
        'txtCodigoAlumno
        '
        Me.txtCodigoAlumno.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoAlumno.Location = New System.Drawing.Point(43, 56)
        Me.txtCodigoAlumno.Name = "txtCodigoAlumno"
        Me.txtCodigoAlumno.Size = New System.Drawing.Size(292, 27)
        Me.txtCodigoAlumno.TabIndex = 5
        Me.txtCodigoAlumno.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.Location = New System.Drawing.Point(402, 180)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(61, 25)
        Me.RadLabel5.TabIndex = 4
        Me.RadLabel5.Text = "Monto "
        Me.RadLabel5.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(402, 102)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(85, 25)
        Me.RadLabel4.TabIndex = 3
        Me.RadLabel4.Text = "Encargado"
        Me.RadLabel4.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(43, 180)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(92, 25)
        Me.RadLabel3.TabIndex = 2
        Me.RadLabel3.Text = "Pago Extras"
        Me.RadLabel3.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(43, 102)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(137, 25)
        Me.RadLabel2.TabIndex = 1
        Me.RadLabel2.Text = "Nombre Alumnos"
        Me.RadLabel2.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(43, 25)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(129, 25)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Codigo Alumnos"
        Me.RadLabel1.ThemeName = "VisualStudio2012Light"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.Panel2.Location = New System.Drawing.Point(0, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(724, 271)
        Me.Panel2.TabIndex = 1
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.CachedPageNumberPerDoc = 10
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(724, 271)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'WizardWelcomePage1
        '
        Me.WizardWelcomePage1.ContentArea = Me.Panel1
        Me.WizardWelcomePage1.Name = "WizardWelcomePage1"
        Me.WizardWelcomePage1.Title = "Pagos Extras"
        Me.WizardWelcomePage1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'WizardPage1
        '
        Me.WizardPage1.ContentArea = Me.Panel2
        Me.WizardPage1.Header = ""
        Me.WizardPage1.Name = "WizardPage1"
        Me.WizardPage1.Title = "Comrobante Pago"
        Me.WizardPage1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(611, 360)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(105, 24)
        Me.btnCancelar.TabIndex = 23
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.ThemeName = "TelerikMetro"
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(394, 360)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(105, 24)
        Me.btnAtras.TabIndex = 24
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.ThemeName = "TelerikMetro"
        '
        'FrmPagosExtras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 396)
        Me.Controls.Add(Me.RadWizard1)
        Me.Name = "FrmPagosExtras"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPagosExtras"
        Me.ThemeName = "TelerikMetro"
        CType(Me.RadWizard1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadWizard1.ResumeLayout(False)
        CType(Me.btnSiguiente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPagoExtra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEncargado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents RadWizard1 As Telerik.WinControls.UI.RadWizard
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboPagoExtra As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txtMonto As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtEncargado As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtNombreAlumnos As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtCodigoAlumno As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents WizardWelcomePage1 As Telerik.WinControls.UI.WizardWelcomePage
    Friend WithEvents WizardPage1 As Telerik.WinControls.UI.WizardPage
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblResultado As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnEditar As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSiguiente As Telerik.WinControls.UI.RadButton
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnAtras As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnCancelar As Telerik.WinControls.UI.RadButton
End Class

