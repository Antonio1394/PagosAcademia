<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.RadRibbonBar1 = New Telerik.WinControls.UI.RadRibbonBar()
        Me.RibbonTab1 = New Telerik.WinControls.UI.RibbonTab()
        Me.RadRibbonBarGroup1 = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.RadButtonElement1 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadButtonElement2 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadButtonElement3 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibbonTab2 = New Telerik.WinControls.UI.RibbonTab()
        Me.RadRibbonBarGroup2 = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.RadButtonElement4 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadButtonElement5 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadButtonElement6 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadButtonElement7 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadButtonElement11 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadRibbonBarGroup3 = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.RadButtonElement8 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadButtonElement9 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadButtonElement10 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadRibbonFormBehavior1 = New Telerik.WinControls.UI.RadRibbonFormBehavior()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        CType(Me.RadRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadRibbonBar1
        '
        Me.RadRibbonBar1.CommandTabs.AddRange(New Telerik.WinControls.RadItem() {Me.RibbonTab1, Me.RibbonTab2})
        Me.RadRibbonBar1.Location = New System.Drawing.Point(0, 4)
        Me.RadRibbonBar1.Name = "RadRibbonBar1"
        Me.RadRibbonBar1.Size = New System.Drawing.Size(1308, 153)
        Me.RadRibbonBar1.StartButtonImage = CType(resources.GetObject("RadRibbonBar1.StartButtonImage"), System.Drawing.Image)
        Me.RadRibbonBar1.StartMenuItems.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItem1, Me.RadMenuItem2, Me.RadMenuItem3})
        Me.RadRibbonBar1.TabIndex = 0
        Me.RadRibbonBar1.Text = "Gestor de Academia"
        Me.RadRibbonBar1.ThemeName = "TelerikMetro"
        '
        'RibbonTab1
        '
        Me.RibbonTab1.AccessibleDescription = "Inicio"
        Me.RibbonTab1.AccessibleName = "Inicio"
        Me.RibbonTab1.IsSelected = True
        Me.RibbonTab1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadRibbonBarGroup1})
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Text = "Inicio"
        Me.RibbonTab1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadRibbonBarGroup1
        '
        Me.RadRibbonBarGroup1.AccessibleDescription = "Pagos"
        Me.RadRibbonBarGroup1.AccessibleName = "Pagos"
        Me.RadRibbonBarGroup1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadButtonElement1, Me.RadButtonElement2, Me.RadButtonElement3})
        Me.RadRibbonBarGroup1.Name = "RadRibbonBarGroup1"
        Me.RadRibbonBarGroup1.Text = "Pagos"
        Me.RadRibbonBarGroup1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadButtonElement1
        '
        Me.RadButtonElement1.AccessibleDescription = "Inscripciones"
        Me.RadButtonElement1.AccessibleName = "Inscripciones"
        Me.RadButtonElement1.Name = "RadButtonElement1"
        Me.RadButtonElement1.Text = "Inscripciones"
        Me.RadButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadButtonElement2
        '
        Me.RadButtonElement2.AccessibleDescription = "Mensualidades"
        Me.RadButtonElement2.AccessibleName = "Mensualidades"
        Me.RadButtonElement2.Name = "RadButtonElement2"
        Me.RadButtonElement2.Text = "Mensualidades"
        Me.RadButtonElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadButtonElement3
        '
        Me.RadButtonElement3.AccessibleDescription = "Otros"
        Me.RadButtonElement3.AccessibleName = "Otros"
        Me.RadButtonElement3.Name = "RadButtonElement3"
        Me.RadButtonElement3.Text = "Otros"
        Me.RadButtonElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RibbonTab2
        '
        Me.RibbonTab2.AccessibleDescription = "Mantenimientos"
        Me.RibbonTab2.AccessibleName = "Mantenimientos"
        Me.RibbonTab2.IsSelected = False
        Me.RibbonTab2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadRibbonBarGroup2, Me.RadRibbonBarGroup3})
        Me.RibbonTab2.Name = "RibbonTab2"
        Me.RibbonTab2.Text = "Mantenimientos"
        Me.RibbonTab2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadRibbonBarGroup2
        '
        Me.RadRibbonBarGroup2.AccessibleDescription = "Mantenimientos"
        Me.RadRibbonBarGroup2.AccessibleName = "Mantenimientos"
        Me.RadRibbonBarGroup2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadButtonElement4, Me.RadButtonElement5, Me.RadButtonElement6, Me.RadButtonElement7, Me.RadButtonElement11})
        Me.RadRibbonBarGroup2.Name = "RadRibbonBarGroup2"
        Me.RadRibbonBarGroup2.Text = "Mantenimientos"
        Me.RadRibbonBarGroup2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadButtonElement4
        '
        Me.RadButtonElement4.AccessibleDescription = "Horarios"
        Me.RadButtonElement4.AccessibleName = "Horarios"
        Me.RadButtonElement4.Image = Global.AcademiaComputacion.My.Resources.Resources.clock118
        Me.RadButtonElement4.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.RadButtonElement4.Name = "RadButtonElement4"
        Me.RadButtonElement4.Text = "Horarios"
        Me.RadButtonElement4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.RadButtonElement4.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadButtonElement5
        '
        Me.RadButtonElement5.AccessibleDescription = "Programas"
        Me.RadButtonElement5.AccessibleName = "Programas"
        Me.RadButtonElement5.Image = Global.AcademiaComputacion.My.Resources.Resources.user2
        Me.RadButtonElement5.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButtonElement5.Name = "RadButtonElement5"
        Me.RadButtonElement5.Text = "Programas"
        Me.RadButtonElement5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.RadButtonElement5.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.RadButtonElement5.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadButtonElement6
        '
        Me.RadButtonElement6.AccessibleDescription = "Laboratorios"
        Me.RadButtonElement6.AccessibleName = "Laboratorios"
        Me.RadButtonElement6.Image = Global.AcademiaComputacion.My.Resources.Resources.televisions1
        Me.RadButtonElement6.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButtonElement6.Name = "RadButtonElement6"
        Me.RadButtonElement6.Text = "Laboratorios"
        Me.RadButtonElement6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.RadButtonElement6.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadButtonElement7
        '
        Me.RadButtonElement7.AccessibleDescription = "Empleados"
        Me.RadButtonElement7.AccessibleName = "Empleados"
        Me.RadButtonElement7.Image = Global.AcademiaComputacion.My.Resources.Resources.professional6
        Me.RadButtonElement7.Name = "RadButtonElement7"
        Me.RadButtonElement7.Text = "Empleados"
        Me.RadButtonElement7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.RadButtonElement7.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadButtonElement11
        '
        Me.RadButtonElement11.AccessibleDescription = "Grupos"
        Me.RadButtonElement11.AccessibleName = "Grupos"
        Me.RadButtonElement11.Image = Global.AcademiaComputacion.My.Resources.Resources._class
        Me.RadButtonElement11.Name = "RadButtonElement11"
        Me.RadButtonElement11.Text = "Grupos"
        Me.RadButtonElement11.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.RadButtonElement11.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadRibbonBarGroup3
        '
        Me.RadRibbonBarGroup3.AccessibleDescription = "Extras"
        Me.RadRibbonBarGroup3.AccessibleName = "Extras"
        Me.RadRibbonBarGroup3.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadButtonElement8, Me.RadButtonElement9, Me.RadButtonElement10})
        Me.RadRibbonBarGroup3.Name = "RadRibbonBarGroup3"
        Me.RadRibbonBarGroup3.Text = "Extras"
        Me.RadRibbonBarGroup3.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadButtonElement8
        '
        Me.RadButtonElement8.AccessibleDescription = "Tipos de Empleados"
        Me.RadButtonElement8.AccessibleName = "Tipos de Empleados"
        Me.RadButtonElement8.Image = Global.AcademiaComputacion.My.Resources.Resources.businessman50
        Me.RadButtonElement8.Name = "RadButtonElement8"
        Me.RadButtonElement8.Text = "Tipos de Empleados"
        Me.RadButtonElement8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.RadButtonElement8.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadButtonElement9
        '
        Me.RadButtonElement9.AccessibleDescription = "Tipos de Pagos"
        Me.RadButtonElement9.AccessibleName = "Tipos de Pagos"
        Me.RadButtonElement9.Image = Global.AcademiaComputacion.My.Resources.Resources.payment7
        Me.RadButtonElement9.Name = "RadButtonElement9"
        Me.RadButtonElement9.Text = "Tipos de Pagos"
        Me.RadButtonElement9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.RadButtonElement9.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadButtonElement10
        '
        Me.RadButtonElement10.AccessibleDescription = "Usuario"
        Me.RadButtonElement10.AccessibleName = "Usuario"
        Me.RadButtonElement10.Image = Global.AcademiaComputacion.My.Resources.Resources.user197
        Me.RadButtonElement10.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButtonElement10.Name = "RadButtonElement10"
        Me.RadButtonElement10.Text = "Usuario"
        Me.RadButtonElement10.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.RadButtonElement10.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadMenuItem1
        '
        Me.RadMenuItem1.AccessibleDescription = "Cambiar Contraseña"
        Me.RadMenuItem1.AccessibleName = "Cambiar Contraseña"
        Me.RadMenuItem1.Image = Global.AcademiaComputacion.My.Resources.Resources.password13
        Me.RadMenuItem1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadMenuItem1.Name = "RadMenuItem1"
        Me.RadMenuItem1.Text = "Cambiar Contraseña"
        Me.RadMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadMenuItem2
        '
        Me.RadMenuItem2.AccessibleDescription = "Cerrar Sesion"
        Me.RadMenuItem2.AccessibleName = "Cerrar Sesion"
        Me.RadMenuItem2.Image = Global.AcademiaComputacion.My.Resources.Resources.key21
        Me.RadMenuItem2.Name = "RadMenuItem2"
        Me.RadMenuItem2.Text = "Cerrar Sesion"
        Me.RadMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadMenuItem3
        '
        Me.RadMenuItem3.AccessibleDescription = "Restablecer Contraseña"
        Me.RadMenuItem3.AccessibleName = "Restablecer Contraseña"
        Me.RadMenuItem3.Image = Global.AcademiaComputacion.My.Resources.Resources.password9
        Me.RadMenuItem3.Name = "RadMenuItem3"
        Me.RadMenuItem3.Text = "Restablecer Contraseña"
        Me.RadMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadRibbonFormBehavior1
        '
        Me.RadRibbonFormBehavior1.Form = Me
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1308, 493)
        Me.Controls.Add(Me.RadRibbonBar1)
        Me.FormBehavior = Me.RadRibbonFormBehavior1
        Me.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None
        Me.IsMdiContainer = True
        Me.Name = "FrmPrincipal"
        Me.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestor de Academia"
        Me.ThemeName = "HighContrastBlack"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RadRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadRibbonBar1 As Telerik.WinControls.UI.RadRibbonBar
    Friend WithEvents RibbonTab1 As Telerik.WinControls.UI.RibbonTab
    Friend WithEvents RadRibbonBarGroup1 As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents RadButtonElement1 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadButtonElement2 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadButtonElement3 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibbonTab2 As Telerik.WinControls.UI.RibbonTab
    Friend WithEvents RadRibbonBarGroup2 As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents RadButtonElement4 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadButtonElement5 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadButtonElement6 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadRibbonFormBehavior1 As Telerik.WinControls.UI.RadRibbonFormBehavior
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents RadMenuItem1 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem2 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadButtonElement7 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadRibbonBarGroup3 As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents RadButtonElement8 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadButtonElement9 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadButtonElement10 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadButtonElement11 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadMenuItem3 As Telerik.WinControls.UI.RadMenuItem
End Class

