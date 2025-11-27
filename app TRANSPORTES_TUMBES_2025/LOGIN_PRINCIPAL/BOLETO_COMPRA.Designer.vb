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
        Me.Imprimirbtn = New System.Windows.Forms.Button()
        Me.Cerrarbtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(354, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(561, 731)
        Me.Panel1.TabIndex = 1
        '
        'Imprimirbtn
        '
        Me.Imprimirbtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.Imprimirbtn.FlatAppearance.BorderSize = 0
        Me.Imprimirbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Imprimirbtn.Font = New System.Drawing.Font("Nirmala Text", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Imprimirbtn.ForeColor = System.Drawing.Color.White
        Me.Imprimirbtn.Location = New System.Drawing.Point(1005, 696)
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
        Me.Cerrarbtn.Location = New System.Drawing.Point(1005, 611)
        Me.Cerrarbtn.Name = "Cerrarbtn"
        Me.Cerrarbtn.Size = New System.Drawing.Size(137, 51)
        Me.Cerrarbtn.TabIndex = 3
        Me.Cerrarbtn.Text = "Cerrar"
        Me.Cerrarbtn.UseVisualStyleBackColor = False
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Código / ID del boleto"
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
        Me.Text = "BOLETO_COMPRA"
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
End Class
