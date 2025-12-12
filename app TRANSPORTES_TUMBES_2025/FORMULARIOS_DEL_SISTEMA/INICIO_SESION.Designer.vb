<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INICIO_SESION
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
        Me.components = New System.ComponentModel.Container()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Textcorreo = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ROLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._TRANSPORTE_TUMBESDataSet = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSet()
        Me.ROLTableAdapter = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.ROLTableAdapter()
        Me.ojo_cerrado = New System.Windows.Forms.PictureBox()
        Me.ojo_abierto = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ROLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._TRANSPORTE_TUMBESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ojo_cerrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ojo_abierto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(618, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(371, 62)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Iniciar sesión"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(798, 443)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "¿Olvidastes tu contraseña?"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.Location = New System.Drawing.Point(704, 495)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(245, 41)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Textcorreo
        '
        Me.Textcorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textcorreo.Location = New System.Drawing.Point(594, 290)
        Me.Textcorreo.Name = "Textcorreo"
        Me.Textcorreo.Size = New System.Drawing.Size(418, 28)
        Me.Textcorreo.TabIndex = 19
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(594, 385)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(418, 28)
        Me.txtContraseña.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(588, 350)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 32)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(588, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 32)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Usuario"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1924, 82)
        Me.Panel1.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Label6.Location = New System.Drawing.Point(737, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(353, 45)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "TRAVEL TOURS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.app_TRANSPORTES_TUMBES_2025.My.Resources.Resources._580b57fbd9996e24bc43bcb7
        Me.PictureBox1.Location = New System.Drawing.Point(1165, 149)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(466, 302)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'ROLBindingSource
        '
        Me.ROLBindingSource.DataMember = "ROL"
        Me.ROLBindingSource.DataSource = Me._TRANSPORTE_TUMBESDataSet
        '
        '_TRANSPORTE_TUMBESDataSet
        '
        Me._TRANSPORTE_TUMBESDataSet.DataSetName = "_TRANSPORTE_TUMBESDataSet"
        Me._TRANSPORTE_TUMBESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ROLTableAdapter
        '
        Me.ROLTableAdapter.ClearBeforeFill = True
        '
        'ojo_cerrado
        '
        Me.ojo_cerrado.Image = Global.app_TRANSPORTES_TUMBES_2025.My.Resources.Resources.cerrar_ojo
        Me.ojo_cerrado.Location = New System.Drawing.Point(1018, 385)
        Me.ojo_cerrado.Name = "ojo_cerrado"
        Me.ojo_cerrado.Size = New System.Drawing.Size(35, 28)
        Me.ojo_cerrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ojo_cerrado.TabIndex = 30
        Me.ojo_cerrado.TabStop = False
        Me.ojo_cerrado.Visible = False
        '
        'ojo_abierto
        '
        Me.ojo_abierto.Image = Global.app_TRANSPORTES_TUMBES_2025.My.Resources.Resources.ojo_abierto
        Me.ojo_abierto.Location = New System.Drawing.Point(1018, 385)
        Me.ojo_abierto.Name = "ojo_abierto"
        Me.ojo_abierto.Size = New System.Drawing.Size(35, 28)
        Me.ojo_abierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ojo_abierto.TabIndex = 31
        Me.ojo_abierto.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Administrador", "Recepcionista"})
        Me.ComboBox1.Location = New System.Drawing.Point(594, 443)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(165, 24)
        Me.ComboBox1.TabIndex = 32
        '
        'INICIO_SESION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ojo_abierto)
        Me.Controls.Add(Me.ojo_cerrado)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Textcorreo)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "INICIO_SESION"
        Me.Text = "INICIO_SESION"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ROLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._TRANSPORTE_TUMBESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ojo_cerrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ojo_abierto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Textcorreo As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents _TRANSPORTE_TUMBESDataSet As _TRANSPORTE_TUMBESDataSet
    Friend WithEvents ROLBindingSource As BindingSource
    Friend WithEvents ROLTableAdapter As _TRANSPORTE_TUMBESDataSetTableAdapters.ROLTableAdapter
    Friend WithEvents ojo_cerrado As PictureBox
    Friend WithEvents ojo_abierto As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
