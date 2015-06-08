<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadForm1
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
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.RadWizard1 = New Telerik.WinControls.UI.RadWizard()
        Me.WizardCompletionPage1 = New Telerik.WinControls.UI.WizardCompletionPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New Telerik.WinControls.UI.RadButton()
        Me.btnSiguiente = New Telerik.WinControls.UI.RadButton()
        Me.btnAtras = New Telerik.WinControls.UI.RadButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtEncargado = New Telerik.WinControls.UI.RadTextBox()
        Me.txtAlumno = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.lblResultado = New Telerik.WinControls.UI.RadLabel()
        Me.lblCuota = New Telerik.WinControls.UI.RadLabel()
        Me.lblMes = New Telerik.WinControls.UI.RadLabel()
        Me.txtCuota = New Telerik.WinControls.UI.RadTextBox()
        Me.txtMes = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtCodigoAlumno = New Telerik.WinControls.UI.RadTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.WizardWelcomePage1 = New Telerik.WinControls.UI.WizardWelcomePage()
        Me.WizardPage1 = New Telerik.WinControls.UI.WizardPage()
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadWizard1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadWizard1.SuspendLayout()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSiguiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAtras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txtEncargado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadWizard1
        '
        Me.RadWizard1.CompletionImage = Global.AcademiaComputacion.My.Resources.Resources.payment7
        Me.RadWizard1.CompletionPage = Me.WizardCompletionPage1
        Me.RadWizard1.Controls.Add(Me.btnCancelar)
        Me.RadWizard1.Controls.Add(Me.btnSiguiente)
        Me.RadWizard1.Controls.Add(Me.btnAtras)
        Me.RadWizard1.Controls.Add(Me.Panel1)
        Me.RadWizard1.Controls.Add(Me.Panel2)
        Me.RadWizard1.Controls.Add(Me.Panel3)
        Me.RadWizard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadWizard1.HideCompletionImage = True
        Me.RadWizard1.HideWelcomeImage = True
        Me.RadWizard1.Location = New System.Drawing.Point(0, 0)
        Me.RadWizard1.Name = "RadWizard1"
        Me.RadWizard1.PageHeaderIcon = Global.AcademiaComputacion.My.Resources.Resources.payment7
        Me.RadWizard1.Pages.Add(Me.WizardWelcomePage1)
        Me.RadWizard1.Pages.Add(Me.WizardPage1)
        Me.RadWizard1.Pages.Add(Me.WizardCompletionPage1)
        Me.RadWizard1.Size = New System.Drawing.Size(629, 412)
        Me.RadWizard1.TabIndex = 0
        Me.RadWizard1.Text = "RadWizard1"
        Me.RadWizard1.ThemeName = "TelerikMetro"
        Me.RadWizard1.WelcomeImage = Global.AcademiaComputacion.My.Resources.Resources.businessman50
        Me.RadWizard1.WelcomePage = Me.WizardWelcomePage1
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
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Panel3.TabIndex = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(516, 375)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(101, 25)
        Me.btnCancelar.TabIndex = 23
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.ThemeName = "TelerikMetro"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(409, 375)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(101, 25)
        Me.btnSiguiente.TabIndex = 22
        Me.btnSiguiente.Text = "Confirmar Pago"
        Me.btnSiguiente.ThemeName = "TelerikMetro"
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(302, 375)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(101, 25)
        Me.btnAtras.TabIndex = 21
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.ThemeName = "TelerikMetro"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.RadButton1)
        Me.Panel1.Controls.Add(Me.txtEncargado)
        Me.Panel1.Controls.Add(Me.txtAlumno)
        Me.Panel1.Controls.Add(Me.RadLabel3)
        Me.Panel1.Controls.Add(Me.RadLabel2)
        Me.Panel1.Controls.Add(Me.lblResultado)
        Me.Panel1.Controls.Add(Me.lblCuota)
        Me.Panel1.Controls.Add(Me.lblMes)
        Me.Panel1.Controls.Add(Me.txtCuota)
        Me.Panel1.Controls.Add(Me.txtMes)
        Me.Panel1.Controls.Add(Me.RadLabel1)
        Me.Panel1.Controls.Add(Me.txtCodigoAlumno)
        Me.Panel1.Location = New System.Drawing.Point(0, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(629, 295)
        Me.Panel1.TabIndex = 0
        '
        'txtEncargado
        '
        Me.txtEncargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEncargado.Location = New System.Drawing.Point(342, 128)
        Me.txtEncargado.Name = "txtEncargado"
        Me.txtEncargado.Size = New System.Drawing.Size(260, 24)
        Me.txtEncargado.TabIndex = 16
        Me.txtEncargado.ThemeName = "VisualStudio2012Light"
        '
        'txtAlumno
        '
        Me.txtAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlumno.Location = New System.Drawing.Point(45, 128)
        Me.txtAlumno.Name = "txtAlumno"
        Me.txtAlumno.ShortcutsEnabled = False
        Me.txtAlumno.Size = New System.Drawing.Size(237, 24)
        Me.txtAlumno.TabIndex = 14
        Me.txtAlumno.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(342, 100)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(88, 22)
        Me.RadLabel3.TabIndex = 20
        Me.RadLabel3.Text = "Encargado"
        Me.RadLabel3.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(45, 100)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(64, 22)
        Me.RadLabel2.TabIndex = 17
        Me.RadLabel2.Text = "Alumno"
        Me.RadLabel2.ThemeName = "VisualStudio2012Light"
        '
        'lblResultado
        '
        Me.lblResultado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(380, 42)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(147, 25)
        Me.lblResultado.TabIndex = 19
        Me.lblResultado.Text = "Ningun Resultado"
        Me.lblResultado.ThemeName = "VisualStudio2012Light"
        '
        'lblCuota
        '
        Me.lblCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuota.Location = New System.Drawing.Point(342, 178)
        Me.lblCuota.Name = "lblCuota"
        Me.lblCuota.Size = New System.Drawing.Size(119, 22)
        Me.lblCuota.TabIndex = 17
        Me.lblCuota.Text = "Cuota Mensual"
        Me.lblCuota.ThemeName = "VisualStudio2012Light"
        '
        'lblMes
        '
        Me.lblMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMes.Location = New System.Drawing.Point(45, 178)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(165, 22)
        Me.lblMes.TabIndex = 16
        Me.lblMes.Text = "Mes Correspondiente"
        Me.lblMes.ThemeName = "VisualStudio2012Light"
        '
        'txtCuota
        '
        Me.txtCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuota.Location = New System.Drawing.Point(342, 206)
        Me.txtCuota.Name = "txtCuota"
        Me.txtCuota.Size = New System.Drawing.Size(260, 24)
        Me.txtCuota.TabIndex = 15
        Me.txtCuota.ThemeName = "VisualStudio2012Light"
        '
        'txtMes
        '
        Me.txtMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMes.Location = New System.Drawing.Point(45, 206)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.ShortcutsEnabled = False
        Me.txtMes.Size = New System.Drawing.Size(237, 24)
        Me.txtMes.TabIndex = 13
        Me.txtMes.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(45, 15)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(141, 22)
        Me.RadLabel1.TabIndex = 7
        Me.RadLabel1.Text = "Codigo de alumno"
        Me.RadLabel1.ThemeName = "VisualStudio2012Light"
        '
        'txtCodigoAlumno
        '
        Me.txtCodigoAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoAlumno.Location = New System.Drawing.Point(45, 43)
        Me.txtCodigoAlumno.Name = "txtCodigoAlumno"
        Me.txtCodigoAlumno.Size = New System.Drawing.Size(237, 24)
        Me.txtCodigoAlumno.TabIndex = 5
        Me.txtCodigoAlumno.ThemeName = "VisualStudio2012Light"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.Panel2.Location = New System.Drawing.Point(0, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(629, 287)
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
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(629, 287)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'WizardWelcomePage1
        '
        Me.WizardWelcomePage1.ContentArea = Me.Panel1
        Me.WizardWelcomePage1.Name = "WizardWelcomePage1"
        Me.WizardWelcomePage1.Title = "Pago de Mensualidad"
        Me.WizardWelcomePage1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'WizardPage1
        '
        Me.WizardPage1.ContentArea = Me.Panel2
        Me.WizardPage1.Header = ""
        Me.WizardPage1.Name = "WizardPage1"
        Me.WizardPage1.Title = "Comprobante Mensualida"
        Me.WizardPage1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'RadButton1
        '
        Me.RadButton1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadButton1.Image = Global.AcademiaComputacion.My.Resources.Resources.write12
        Me.RadButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButton1.Location = New System.Drawing.Point(469, 178)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(26, 22)
        Me.RadButton1.TabIndex = 21
        Me.RadButton1.ThemeName = "VisualStudio2012Light"
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 412)
        Me.Controls.Add(Me.RadWizard1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mensualidad"
        Me.ThemeName = "TelerikMetro"
        CType(Me.RadWizard1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadWizard1.ResumeLayout(False)
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSiguiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAtras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtEncargado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents RadWizard1 As Telerik.WinControls.UI.RadWizard
    Friend WithEvents WizardCompletionPage1 As Telerik.WinControls.UI.WizardCompletionPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCuota As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblMes As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtCuota As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtMes As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtCodigoAlumno As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents WizardWelcomePage1 As Telerik.WinControls.UI.WizardWelcomePage
    Friend WithEvents WizardPage1 As Telerik.WinControls.UI.WizardPage
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents lblResultado As Telerik.WinControls.UI.RadLabel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents txtEncargado As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtAlumno As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnCancelar As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSiguiente As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnAtras As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
End Class

