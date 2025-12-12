<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mantenimiento_cliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Modificarbtn = New System.Windows.Forms.Button()
        Me.Eliminarbtn = New System.Windows.Forms.Button()
        Me.Actualizarbtn = New System.Windows.Forms.Button()
        Me.Guardarbtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nuevobtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Modificarbtn)
        Me.GroupBox1.Controls.Add(Me.Eliminarbtn)
        Me.GroupBox1.Controls.Add(Me.Actualizarbtn)
        Me.GroupBox1.Controls.Add(Me.Guardarbtn)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Nuevobtn)
        Me.GroupBox1.Location = New System.Drawing.Point(-2, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1773, 811)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1767, 82)
        Me.Panel1.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(680, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(688, 62)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Mantenimiento del cliente"
        '
        'Modificarbtn
        '
        Me.Modificarbtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Modificarbtn.FlatAppearance.BorderSize = 0
        Me.Modificarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Modificarbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modificarbtn.ForeColor = System.Drawing.Color.White
        Me.Modificarbtn.Location = New System.Drawing.Point(1229, 264)
        Me.Modificarbtn.Name = "Modificarbtn"
        Me.Modificarbtn.Size = New System.Drawing.Size(156, 52)
        Me.Modificarbtn.TabIndex = 9
        Me.Modificarbtn.Text = "Modificar"
        Me.Modificarbtn.UseVisualStyleBackColor = False
        '
        'Eliminarbtn
        '
        Me.Eliminarbtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Eliminarbtn.FlatAppearance.BorderSize = 0
        Me.Eliminarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Eliminarbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminarbtn.ForeColor = System.Drawing.Color.White
        Me.Eliminarbtn.Location = New System.Drawing.Point(1048, 264)
        Me.Eliminarbtn.Name = "Eliminarbtn"
        Me.Eliminarbtn.Size = New System.Drawing.Size(156, 52)
        Me.Eliminarbtn.TabIndex = 8
        Me.Eliminarbtn.Text = "Eliminar"
        Me.Eliminarbtn.UseVisualStyleBackColor = False
        '
        'Actualizarbtn
        '
        Me.Actualizarbtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Actualizarbtn.FlatAppearance.BorderSize = 0
        Me.Actualizarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Actualizarbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Actualizarbtn.ForeColor = System.Drawing.Color.White
        Me.Actualizarbtn.Location = New System.Drawing.Point(865, 264)
        Me.Actualizarbtn.Name = "Actualizarbtn"
        Me.Actualizarbtn.Size = New System.Drawing.Size(156, 52)
        Me.Actualizarbtn.TabIndex = 7
        Me.Actualizarbtn.Text = "Actualizar"
        Me.Actualizarbtn.UseVisualStyleBackColor = False
        '
        'Guardarbtn
        '
        Me.Guardarbtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Guardarbtn.FlatAppearance.BorderSize = 0
        Me.Guardarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Guardarbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardarbtn.ForeColor = System.Drawing.Color.White
        Me.Guardarbtn.Location = New System.Drawing.Point(684, 264)
        Me.Guardarbtn.Name = "Guardarbtn"
        Me.Guardarbtn.Size = New System.Drawing.Size(156, 52)
        Me.Guardarbtn.TabIndex = 6
        Me.Guardarbtn.Text = "Guardar"
        Me.Guardarbtn.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(502, 354)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(883, 384)
        Me.DataGridView1.TabIndex = 5
        '
        'Nuevobtn
        '
        Me.Nuevobtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Nuevobtn.FlatAppearance.BorderSize = 0
        Me.Nuevobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nuevobtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nuevobtn.ForeColor = System.Drawing.Color.White
        Me.Nuevobtn.Location = New System.Drawing.Point(502, 264)
        Me.Nuevobtn.Name = "Nuevobtn"
        Me.Nuevobtn.Size = New System.Drawing.Size(156, 52)
        Me.Nuevobtn.TabIndex = 0
        Me.Nuevobtn.Text = "Nuevo"
        Me.Nuevobtn.UseVisualStyleBackColor = False
        '
        'mantenimiento_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1766, 809)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "mantenimiento_cliente"
        Me.Text = "mantenimiento_cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Eliminarbtn As Button
    Friend WithEvents Actualizarbtn As Button
    Friend WithEvents Guardarbtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Nuevobtn As Button
    Friend WithEvents Modificarbtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
End Class
