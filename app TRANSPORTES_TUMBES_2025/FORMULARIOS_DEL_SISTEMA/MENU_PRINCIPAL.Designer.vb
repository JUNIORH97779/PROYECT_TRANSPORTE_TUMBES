<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MENU_PRINCIPAL
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_operaciones = New System.Windows.Forms.Button()
        Me.btn_reportes = New System.Windows.Forms.Button()
        Me.btn_mantenimiento = New System.Windows.Forms.Button()
        Me.panel_principal = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VENDERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTARCLIENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROGRAMARVIAJESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GESTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RUTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOVILIDADESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHOFERESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.REPORTESDEVENTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MANIFIESTODEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Label6.Location = New System.Drawing.Point(749, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(487, 62)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "TRAVEL TOURS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btn_operaciones)
        Me.Panel1.Controls.Add(Me.btn_reportes)
        Me.Panel1.Controls.Add(Me.btn_mantenimiento)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1924, 152)
        Me.Panel1.TabIndex = 29
        '
        'btn_operaciones
        '
        Me.btn_operaciones.BackColor = System.Drawing.Color.White
        Me.btn_operaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_operaciones.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.btn_operaciones.Location = New System.Drawing.Point(325, 93)
        Me.btn_operaciones.Name = "btn_operaciones"
        Me.btn_operaciones.Size = New System.Drawing.Size(254, 35)
        Me.btn_operaciones.TabIndex = 26
        Me.btn_operaciones.Text = "O P E R A C I O N E S"
        Me.btn_operaciones.UseVisualStyleBackColor = False
        '
        'btn_reportes
        '
        Me.btn_reportes.BackColor = System.Drawing.Color.White
        Me.btn_reportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reportes.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.btn_reportes.Location = New System.Drawing.Point(1294, 93)
        Me.btn_reportes.Name = "btn_reportes"
        Me.btn_reportes.Size = New System.Drawing.Size(254, 35)
        Me.btn_reportes.TabIndex = 25
        Me.btn_reportes.Text = "R E P O R T E S"
        Me.btn_reportes.UseVisualStyleBackColor = False
        '
        'btn_mantenimiento
        '
        Me.btn_mantenimiento.BackColor = System.Drawing.Color.White
        Me.btn_mantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mantenimiento.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.btn_mantenimiento.Location = New System.Drawing.Point(849, 93)
        Me.btn_mantenimiento.Name = "btn_mantenimiento"
        Me.btn_mantenimiento.Size = New System.Drawing.Size(276, 35)
        Me.btn_mantenimiento.TabIndex = 24
        Me.btn_mantenimiento.Text = "M A N T E N I M I E N T O"
        Me.btn_mantenimiento.UseVisualStyleBackColor = False
        '
        'panel_principal
        '
        Me.panel_principal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_principal.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.panel_principal.Location = New System.Drawing.Point(0, 144)
        Me.panel_principal.Name = "panel_principal"
        Me.panel_principal.Size = New System.Drawing.Size(1924, 928)
        Me.panel_principal.TabIndex = 31
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VENDERToolStripMenuItem, Me.CONSULTARCLIENTEToolStripMenuItem, Me.PROGRAMARVIAJESToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(285, 76)
        '
        'VENDERToolStripMenuItem
        '
        Me.VENDERToolStripMenuItem.Name = "VENDERToolStripMenuItem"
        Me.VENDERToolStripMenuItem.Size = New System.Drawing.Size(284, 24)
        Me.VENDERToolStripMenuItem.Text = "V E N D E R "
        '
        'CONSULTARCLIENTEToolStripMenuItem
        '
        Me.CONSULTARCLIENTEToolStripMenuItem.Name = "CONSULTARCLIENTEToolStripMenuItem"
        Me.CONSULTARCLIENTEToolStripMenuItem.Size = New System.Drawing.Size(284, 24)
        Me.CONSULTARCLIENTEToolStripMenuItem.Text = "C O N S U L T A R   C L I E N T E"
        '
        'PROGRAMARVIAJESToolStripMenuItem
        '
        Me.PROGRAMARVIAJESToolStripMenuItem.Name = "PROGRAMARVIAJESToolStripMenuItem"
        Me.PROGRAMARVIAJESToolStripMenuItem.Size = New System.Drawing.Size(284, 24)
        Me.PROGRAMARVIAJESToolStripMenuItem.Text = "P R O G R A M A R    V I A J E S"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GESTToolStripMenuItem, Me.RUTASToolStripMenuItem, Me.MOVILIDADESToolStripMenuItem, Me.CHOFERESToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(215, 100)
        '
        'GESTToolStripMenuItem
        '
        Me.GESTToolStripMenuItem.Name = "GESTToolStripMenuItem"
        Me.GESTToolStripMenuItem.Size = New System.Drawing.Size(214, 24)
        Me.GESTToolStripMenuItem.Text = "U S U A R I O S"
        '
        'RUTASToolStripMenuItem
        '
        Me.RUTASToolStripMenuItem.Name = "RUTASToolStripMenuItem"
        Me.RUTASToolStripMenuItem.Size = New System.Drawing.Size(214, 24)
        Me.RUTASToolStripMenuItem.Text = "R U T A S"
        '
        'MOVILIDADESToolStripMenuItem
        '
        Me.MOVILIDADESToolStripMenuItem.Name = "MOVILIDADESToolStripMenuItem"
        Me.MOVILIDADESToolStripMenuItem.Size = New System.Drawing.Size(214, 24)
        Me.MOVILIDADESToolStripMenuItem.Text = "M O V I L I D A D E S"
        '
        'CHOFERESToolStripMenuItem
        '
        Me.CHOFERESToolStripMenuItem.Name = "CHOFERESToolStripMenuItem"
        Me.CHOFERESToolStripMenuItem.Size = New System.Drawing.Size(214, 24)
        Me.CHOFERESToolStripMenuItem.Text = "C H O F E R E S"
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REPORTESDEVENTASToolStripMenuItem, Me.MANIFIESTODEToolStripMenuItem})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(367, 52)
        '
        'REPORTESDEVENTASToolStripMenuItem
        '
        Me.REPORTESDEVENTASToolStripMenuItem.Name = "REPORTESDEVENTASToolStripMenuItem"
        Me.REPORTESDEVENTASToolStripMenuItem.Size = New System.Drawing.Size(366, 24)
        Me.REPORTESDEVENTASToolStripMenuItem.Text = "R E P O R T E S   D E   V E N T A S"
        '
        'MANIFIESTODEToolStripMenuItem
        '
        Me.MANIFIESTODEToolStripMenuItem.Name = "MANIFIESTODEToolStripMenuItem"
        Me.MANIFIESTODEToolStripMenuItem.Size = New System.Drawing.Size(366, 24)
        Me.MANIFIESTODEToolStripMenuItem.Text = "M A N I F I E S T O   D E   P A S A J E R O S   "
        '
        'MENU_PRINCIPAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.panel_principal)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MENU_PRINCIPAL"
        Me.Text = "MENU_PRINCIPAL"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panel_principal As Panel
    Friend WithEvents btn_mantenimiento As Button
    Friend WithEvents btn_operaciones As Button
    Friend WithEvents btn_reportes As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents VENDERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTARCLIENTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents GESTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RUTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOVILIDADESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CHOFERESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
    Friend WithEvents REPORTESDEVENTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MANIFIESTODEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PROGRAMARVIAJESToolStripMenuItem As ToolStripMenuItem
End Class
