<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BOLETO_COMPRA
    Inherits System.Windows.Forms.Form

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Imprimirbtn = New System.Windows.Forms.Button()
        Me.Cerrarbtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblPasajeroValue = New System.Windows.Forms.Label()
        Me.lblDNIValue = New System.Windows.Forms.Label()
        Me.lblOrigenValue = New System.Windows.Forms.Label()
        Me.lbCodigoValue = New System.Windows.Forms.Label()
        Me.lblPrecioValue = New System.Windows.Forms.Label()
        Me.lblAsientoValue = New System.Windows.Forms.Label()
        Me.lblHoraValue = New System.Windows.Forms.Label()
        Me.lblFechaValue = New System.Windows.Forms.Label()
        Me.lblDestinoValue = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(211, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblDestinoValue)
        Me.Panel1.Controls.Add(Me.lblFechaValue)
        Me.Panel1.Controls.Add(Me.lblHoraValue)
        Me.Panel1.Controls.Add(Me.lblAsientoValue)
        Me.Panel1.Controls.Add(Me.lblPrecioValue)
        Me.Panel1.Controls.Add(Me.lbCodigoValue)
        Me.Panel1.Controls.Add(Me.lblOrigenValue)
        Me.Panel1.Controls.Add(Me.lblDNIValue)
        Me.Panel1.Controls.Add(Me.lblPasajeroValue)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(383, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(561, 731)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(171, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 28)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Fecha:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Label6.Location = New System.Drawing.Point(95, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(353, 45)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "TRAVEL TOURS"
        '
        'Imprimirbtn
        '
        Me.Imprimirbtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.Imprimirbtn.FlatAppearance.BorderSize = 0
        Me.Imprimirbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Imprimirbtn.Font = New System.Drawing.Font("Nirmala Text", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Imprimirbtn.ForeColor = System.Drawing.Color.White
        Me.Imprimirbtn.Location = New System.Drawing.Point(1015, 682)
        Me.Imprimirbtn.Name = "Imprimirbtn"
        Me.Imprimirbtn.Size = New System.Drawing.Size(137, 51)
        Me.Imprimirbtn.TabIndex = 2
        Me.Imprimirbtn.Text = "Imprimir"
        Me.Imprimirbtn.UseVisualStyleBackColor = False
        '
        'Cerrarbtn
        '
        Me.Cerrarbtn.BackColor = System.Drawing.Color.Red
        Me.Cerrarbtn.FlatAppearance.BorderSize = 0
        Me.Cerrarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cerrarbtn.Font = New System.Drawing.Font("Nirmala Text", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cerrarbtn.ForeColor = System.Drawing.Color.White
        Me.Cerrarbtn.Location = New System.Drawing.Point(1015, 588)
        Me.Cerrarbtn.Name = "Cerrarbtn"
        Me.Cerrarbtn.Size = New System.Drawing.Size(137, 51)
        Me.Cerrarbtn.TabIndex = 3
        Me.Cerrarbtn.Text = "Cerrar"
        Me.Cerrarbtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(187, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 28)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "DNI:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(161, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 28)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Origen:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(154, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 28)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Destino:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(147, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 28)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "pasajero:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(178, 389)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 28)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Hora:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(155, 446)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 28)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Asiento:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(166, 499)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 28)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "precio:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 564)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(213, 28)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Código / ID del boleto:"
        '
        'lblPasajeroValue
        '
        Me.lblPasajeroValue.AutoSize = True
        Me.lblPasajeroValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPasajeroValue.Location = New System.Drawing.Point(269, 134)
        Me.lblPasajeroValue.Name = "lblPasajeroValue"
        Me.lblPasajeroValue.Size = New System.Drawing.Size(0, 17)
        Me.lblPasajeroValue.TabIndex = 33
        '
        'lblDNIValue
        '
        Me.lblDNIValue.AutoSize = True
        Me.lblDNIValue.Location = New System.Drawing.Point(269, 193)
        Me.lblDNIValue.Name = "lblDNIValue"
        Me.lblDNIValue.Size = New System.Drawing.Size(0, 17)
        Me.lblDNIValue.TabIndex = 34
        '
        'lblOrigenValue
        '
        Me.lblOrigenValue.AutoSize = True
        Me.lblOrigenValue.Location = New System.Drawing.Point(300, 246)
        Me.lblOrigenValue.Name = "lblOrigenValue"
        Me.lblOrigenValue.Size = New System.Drawing.Size(0, 17)
        Me.lblOrigenValue.TabIndex = 35
        '
        'lbCodigoValue
        '
        Me.lbCodigoValue.AutoSize = True
        Me.lbCodigoValue.Location = New System.Drawing.Point(297, 574)
        Me.lbCodigoValue.Name = "lbCodigoValue"
        Me.lbCodigoValue.Size = New System.Drawing.Size(0, 17)
        Me.lbCodigoValue.TabIndex = 36
        '
        'lblPrecioValue
        '
        Me.lblPrecioValue.AutoSize = True
        Me.lblPrecioValue.Location = New System.Drawing.Point(297, 509)
        Me.lblPrecioValue.Name = "lblPrecioValue"
        Me.lblPrecioValue.Size = New System.Drawing.Size(0, 17)
        Me.lblPrecioValue.TabIndex = 37
        '
        'lblAsientoValue
        '
        Me.lblAsientoValue.AutoSize = True
        Me.lblAsientoValue.Location = New System.Drawing.Point(300, 446)
        Me.lblAsientoValue.Name = "lblAsientoValue"
        Me.lblAsientoValue.Size = New System.Drawing.Size(0, 17)
        Me.lblAsientoValue.TabIndex = 38
        '
        'lblHoraValue
        '
        Me.lblHoraValue.AutoSize = True
        Me.lblHoraValue.Location = New System.Drawing.Point(297, 389)
        Me.lblHoraValue.Name = "lblHoraValue"
        Me.lblHoraValue.Size = New System.Drawing.Size(0, 17)
        Me.lblHoraValue.TabIndex = 39
        '
        'lblFechaValue
        '
        Me.lblFechaValue.AutoSize = True
        Me.lblFechaValue.Location = New System.Drawing.Point(297, 336)
        Me.lblFechaValue.Name = "lblFechaValue"
        Me.lblFechaValue.Size = New System.Drawing.Size(0, 17)
        Me.lblFechaValue.TabIndex = 40
        '
        'lblDestinoValue
        '
        Me.lblDestinoValue.AutoSize = True
        Me.lblDestinoValue.Location = New System.Drawing.Point(300, 288)
        Me.lblDestinoValue.Name = "lblDestinoValue"
        Me.lblDestinoValue.Size = New System.Drawing.Size(28, 17)
        Me.lblDestinoValue.TabIndex = 41
        Me.lblDestinoValue.Text = "     "
        '
        'BOLETO_COMPRA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(1251, 872)
        Me.Controls.Add(Me.Cerrarbtn)
        Me.Controls.Add(Me.Imprimirbtn)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BOLETO_COMPRA"
        Me.Text = "         "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Imprimirbtn As Button
    Friend WithEvents Cerrarbtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPasajeroValue As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDestinoValue As Label
    Friend WithEvents lblFechaValue As Label
    Friend WithEvents lblHoraValue As Label
    Friend WithEvents lblAsientoValue As Label
    Friend WithEvents lblPrecioValue As Label
    Friend WithEvents lbCodigoValue As Label
    Friend WithEvents lblOrigenValue As Label
    Friend WithEvents lblDNIValue As Label
End Class
