<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BUSCAR_CLIENTES
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
        Me.components = New System.ComponentModel.Container()
        Dim ID_ClienteLabel As System.Windows.Forms.Label
        Dim ID_TipoDocumentoLabel As System.Windows.Forms.Label
        Dim NumeroDocumentoLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim ID_ClienteLabel1 As System.Windows.Forms.Label
        Dim ID_TipoDocumentoLabel1 As System.Windows.Forms.Label
        Dim NumeroDocumentoLabel1 As System.Windows.Forms.Label
        Dim NombresLabel1 As System.Windows.Forms.Label
        Dim ApellidosLabel1 As System.Windows.Forms.Label
        Dim TelefonoLabel1 As System.Windows.Forms.Label
        Dim EmailLabel1 As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me._TRANSPORTE_TUMBESDataSet = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSet()
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTETableAdapter = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.CLIENTETableAdapter()
        Me.TableAdapterManager = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.TableAdapterManager()
        Me.TIPO_DOCUMENTOTableAdapter = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.TIPO_DOCUMENTOTableAdapter()
        Me.CLIENTEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Searche_cliente = New System.Windows.Forms.TextBox()
        Me.Btn_editar = New System.Windows.Forms.Button()
        Me.Btn_agregar = New System.Windows.Forms.Button()
        Me.Group_editarCLI = New System.Windows.Forms.GroupBox()
        Me.ID_TipoDocumentoComboBox = New System.Windows.Forms.ComboBox()
        Me.TIPODOCUMENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroDocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.Group_clienteAGG = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBoxEMAIL = New System.Windows.Forms.TextBox()
        Me.TextBoxTEL = New System.Windows.Forms.TextBox()
        Me.TextBoxAPE = New System.Windows.Forms.TextBox()
        Me.TextBoxNOM = New System.Windows.Forms.TextBox()
        Me.TextBoxNROdoc = New System.Windows.Forms.TextBox()
        Me.TextBoxIDclie = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        ID_ClienteLabel = New System.Windows.Forms.Label()
        ID_TipoDocumentoLabel = New System.Windows.Forms.Label()
        NumeroDocumentoLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        ID_ClienteLabel1 = New System.Windows.Forms.Label()
        ID_TipoDocumentoLabel1 = New System.Windows.Forms.Label()
        NumeroDocumentoLabel1 = New System.Windows.Forms.Label()
        NombresLabel1 = New System.Windows.Forms.Label()
        ApellidosLabel1 = New System.Windows.Forms.Label()
        TelefonoLabel1 = New System.Windows.Forms.Label()
        EmailLabel1 = New System.Windows.Forms.Label()
        CType(Me._TRANSPORTE_TUMBESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_editarCLI.SuspendLayout()
        CType(Me.TIPODOCUMENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_clienteAGG.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_ClienteLabel
        '
        ID_ClienteLabel.AutoSize = True
        ID_ClienteLabel.Location = New System.Drawing.Point(65, 27)
        ID_ClienteLabel.Name = "ID_ClienteLabel"
        ID_ClienteLabel.Size = New System.Drawing.Size(67, 16)
        ID_ClienteLabel.TabIndex = 57
        ID_ClienteLabel.Text = "ID Cliente:"
        '
        'ID_TipoDocumentoLabel
        '
        ID_TipoDocumentoLabel.AutoSize = True
        ID_TipoDocumentoLabel.Location = New System.Drawing.Point(65, 55)
        ID_TipoDocumentoLabel.Name = "ID_TipoDocumentoLabel"
        ID_TipoDocumentoLabel.Size = New System.Drawing.Size(126, 16)
        ID_TipoDocumentoLabel.TabIndex = 59
        ID_TipoDocumentoLabel.Text = "ID Tipo Documento:"
        '
        'NumeroDocumentoLabel
        '
        NumeroDocumentoLabel.AutoSize = True
        NumeroDocumentoLabel.Location = New System.Drawing.Point(65, 83)
        NumeroDocumentoLabel.Name = "NumeroDocumentoLabel"
        NumeroDocumentoLabel.Size = New System.Drawing.Size(130, 16)
        NumeroDocumentoLabel.TabIndex = 61
        NumeroDocumentoLabel.Text = "Numero Documento:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(65, 111)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(66, 16)
        NombresLabel.TabIndex = 63
        NombresLabel.Text = "Nombres:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(65, 139)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(67, 16)
        ApellidosLabel.TabIndex = 65
        ApellidosLabel.Text = "Apellidos:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(65, 167)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(64, 16)
        TelefonoLabel.TabIndex = 67
        TelefonoLabel.Text = "Telefono:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(65, 195)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(44, 16)
        EmailLabel.TabIndex = 69
        EmailLabel.Text = "Email:"
        '
        'ID_ClienteLabel1
        '
        ID_ClienteLabel1.AutoSize = True
        ID_ClienteLabel1.Location = New System.Drawing.Point(46, 29)
        ID_ClienteLabel1.Name = "ID_ClienteLabel1"
        ID_ClienteLabel1.Size = New System.Drawing.Size(67, 16)
        ID_ClienteLabel1.TabIndex = 8
        ID_ClienteLabel1.Text = "ID Cliente:"
        '
        'ID_TipoDocumentoLabel1
        '
        ID_TipoDocumentoLabel1.AutoSize = True
        ID_TipoDocumentoLabel1.Location = New System.Drawing.Point(46, 57)
        ID_TipoDocumentoLabel1.Name = "ID_TipoDocumentoLabel1"
        ID_TipoDocumentoLabel1.Size = New System.Drawing.Size(126, 16)
        ID_TipoDocumentoLabel1.TabIndex = 10
        ID_TipoDocumentoLabel1.Text = "ID Tipo Documento:"
        '
        'NumeroDocumentoLabel1
        '
        NumeroDocumentoLabel1.AutoSize = True
        NumeroDocumentoLabel1.Location = New System.Drawing.Point(46, 85)
        NumeroDocumentoLabel1.Name = "NumeroDocumentoLabel1"
        NumeroDocumentoLabel1.Size = New System.Drawing.Size(130, 16)
        NumeroDocumentoLabel1.TabIndex = 12
        NumeroDocumentoLabel1.Text = "Numero Documento:"
        '
        'NombresLabel1
        '
        NombresLabel1.AutoSize = True
        NombresLabel1.Location = New System.Drawing.Point(46, 113)
        NombresLabel1.Name = "NombresLabel1"
        NombresLabel1.Size = New System.Drawing.Size(66, 16)
        NombresLabel1.TabIndex = 14
        NombresLabel1.Text = "Nombres:"
        '
        'ApellidosLabel1
        '
        ApellidosLabel1.AutoSize = True
        ApellidosLabel1.Location = New System.Drawing.Point(46, 141)
        ApellidosLabel1.Name = "ApellidosLabel1"
        ApellidosLabel1.Size = New System.Drawing.Size(67, 16)
        ApellidosLabel1.TabIndex = 16
        ApellidosLabel1.Text = "Apellidos:"
        '
        'TelefonoLabel1
        '
        TelefonoLabel1.AutoSize = True
        TelefonoLabel1.Location = New System.Drawing.Point(46, 169)
        TelefonoLabel1.Name = "TelefonoLabel1"
        TelefonoLabel1.Size = New System.Drawing.Size(64, 16)
        TelefonoLabel1.TabIndex = 18
        TelefonoLabel1.Text = "Telefono:"
        '
        'EmailLabel1
        '
        EmailLabel1.AutoSize = True
        EmailLabel1.Location = New System.Drawing.Point(46, 197)
        EmailLabel1.Name = "EmailLabel1"
        EmailLabel1.Size = New System.Drawing.Size(44, 16)
        EmailLabel1.TabIndex = 20
        EmailLabel1.Text = "Email:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(774, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(197, 62)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        '_TRANSPORTE_TUMBESDataSet
        '
        Me._TRANSPORTE_TUMBESDataSet.DataSetName = "_TRANSPORTE_TUMBESDataSet"
        Me._TRANSPORTE_TUMBESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CLIENTEBindingSource
        '
        Me.CLIENTEBindingSource.DataMember = "CLIENTE"
        Me.CLIENTEBindingSource.DataSource = Me._TRANSPORTE_TUMBESDataSet
        '
        'CLIENTETableAdapter
        '
        Me.CLIENTETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CHOFERTableAdapter = Nothing
        Me.TableAdapterManager.CLIENTETableAdapter = Me.CLIENTETableAdapter
        Me.TableAdapterManager.MOVILIDADTableAdapter = Nothing
        Me.TableAdapterManager.PASAJETableAdapter = Nothing
        Me.TableAdapterManager.ROLTableAdapter = Nothing
        Me.TableAdapterManager.RUTATableAdapter = Nothing
        Me.TableAdapterManager.TIPO_DOCUMENTOTableAdapter = Me.TIPO_DOCUMENTOTableAdapter
        Me.TableAdapterManager.UpdateOrder = app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USUARIOTableAdapter = Nothing
        Me.TableAdapterManager.VENTATableAdapter = Nothing
        Me.TableAdapterManager.VIAJETableAdapter = Nothing
        '
        'TIPO_DOCUMENTOTableAdapter
        '
        Me.TIPO_DOCUMENTOTableAdapter.ClearBeforeFill = True
        '
        'CLIENTEDataGridView
        '
        Me.CLIENTEDataGridView.AutoGenerateColumns = False
        Me.CLIENTEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CLIENTEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.CLIENTEDataGridView.DataSource = Me.CLIENTEBindingSource
        Me.CLIENTEDataGridView.Location = New System.Drawing.Point(883, 127)
        Me.CLIENTEDataGridView.Name = "CLIENTEDataGridView"
        Me.CLIENTEDataGridView.RowHeadersWidth = 51
        Me.CLIENTEDataGridView.RowTemplate.Height = 24
        Me.CLIENTEDataGridView.Size = New System.Drawing.Size(945, 220)
        Me.CLIENTEDataGridView.TabIndex = 46
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Cliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Cliente"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_TipoDocumento"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID_TipoDocumento"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NumeroDocumento"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NumeroDocumento"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nombres"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombres"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Apellidos"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'Searche_cliente
        '
        Me.Searche_cliente.Location = New System.Drawing.Point(1084, 53)
        Me.Searche_cliente.Name = "Searche_cliente"
        Me.Searche_cliente.Size = New System.Drawing.Size(394, 22)
        Me.Searche_cliente.TabIndex = 47
        '
        'Btn_editar
        '
        Me.Btn_editar.BackColor = System.Drawing.Color.Red
        Me.Btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_editar.ForeColor = System.Drawing.Color.White
        Me.Btn_editar.Location = New System.Drawing.Point(284, 29)
        Me.Btn_editar.Name = "Btn_editar"
        Me.Btn_editar.Size = New System.Drawing.Size(197, 62)
        Me.Btn_editar.TabIndex = 48
        Me.Btn_editar.Text = "Editar"
        Me.Btn_editar.UseVisualStyleBackColor = False
        '
        'Btn_agregar
        '
        Me.Btn_agregar.BackColor = System.Drawing.Color.Red
        Me.Btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_agregar.ForeColor = System.Drawing.Color.White
        Me.Btn_agregar.Location = New System.Drawing.Point(26, 29)
        Me.Btn_agregar.Name = "Btn_agregar"
        Me.Btn_agregar.Size = New System.Drawing.Size(197, 62)
        Me.Btn_agregar.TabIndex = 49
        Me.Btn_agregar.Text = "Agregar"
        Me.Btn_agregar.UseVisualStyleBackColor = False
        '
        'Group_editarCLI
        '
        Me.Group_editarCLI.Controls.Add(Me.ID_TipoDocumentoComboBox)
        Me.Group_editarCLI.Controls.Add(ID_ClienteLabel)
        Me.Group_editarCLI.Controls.Add(Me.ID_ClienteTextBox)
        Me.Group_editarCLI.Controls.Add(ID_TipoDocumentoLabel)
        Me.Group_editarCLI.Controls.Add(NumeroDocumentoLabel)
        Me.Group_editarCLI.Controls.Add(Me.NumeroDocumentoTextBox)
        Me.Group_editarCLI.Controls.Add(NombresLabel)
        Me.Group_editarCLI.Controls.Add(Me.NombresTextBox)
        Me.Group_editarCLI.Controls.Add(ApellidosLabel)
        Me.Group_editarCLI.Controls.Add(Me.ApellidosTextBox)
        Me.Group_editarCLI.Controls.Add(TelefonoLabel)
        Me.Group_editarCLI.Controls.Add(Me.TelefonoTextBox)
        Me.Group_editarCLI.Controls.Add(EmailLabel)
        Me.Group_editarCLI.Controls.Add(Me.EmailTextBox)
        Me.Group_editarCLI.Controls.Add(Me.Button3)
        Me.Group_editarCLI.Controls.Add(Me.btn_actualizar)
        Me.Group_editarCLI.Location = New System.Drawing.Point(453, 124)
        Me.Group_editarCLI.Name = "Group_editarCLI"
        Me.Group_editarCLI.Size = New System.Drawing.Size(407, 296)
        Me.Group_editarCLI.TabIndex = 62
        Me.Group_editarCLI.TabStop = False
        '
        'ID_TipoDocumentoComboBox
        '
        Me.ID_TipoDocumentoComboBox.DataSource = Me.TIPODOCUMENTOBindingSource
        Me.ID_TipoDocumentoComboBox.DisplayMember = "Abreviatura"
        Me.ID_TipoDocumentoComboBox.FormattingEnabled = True
        Me.ID_TipoDocumentoComboBox.Location = New System.Drawing.Point(201, 50)
        Me.ID_TipoDocumentoComboBox.Name = "ID_TipoDocumentoComboBox"
        Me.ID_TipoDocumentoComboBox.Size = New System.Drawing.Size(100, 24)
        Me.ID_TipoDocumentoComboBox.TabIndex = 71
        Me.ID_TipoDocumentoComboBox.ValueMember = "ID_TipoDocumento"
        '
        'TIPODOCUMENTOBindingSource
        '
        Me.TIPODOCUMENTOBindingSource.DataMember = "TIPO_DOCUMENTO"
        Me.TIPODOCUMENTOBindingSource.DataSource = Me._TRANSPORTE_TUMBESDataSet
        '
        'ID_ClienteTextBox
        '
        Me.ID_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "ID_Cliente", True))
        Me.ID_ClienteTextBox.Enabled = False
        Me.ID_ClienteTextBox.Location = New System.Drawing.Point(201, 24)
        Me.ID_ClienteTextBox.Name = "ID_ClienteTextBox"
        Me.ID_ClienteTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ID_ClienteTextBox.TabIndex = 58
        '
        'NumeroDocumentoTextBox
        '
        Me.NumeroDocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "NumeroDocumento", True))
        Me.NumeroDocumentoTextBox.Location = New System.Drawing.Point(201, 80)
        Me.NumeroDocumentoTextBox.Name = "NumeroDocumentoTextBox"
        Me.NumeroDocumentoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NumeroDocumentoTextBox.TabIndex = 62
        '
        'NombresTextBox
        '
        Me.NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "Nombres", True))
        Me.NombresTextBox.Location = New System.Drawing.Point(201, 108)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NombresTextBox.TabIndex = 64
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "Apellidos", True))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(201, 136)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ApellidosTextBox.TabIndex = 66
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(201, 164)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TelefonoTextBox.TabIndex = 68
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTEBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(201, 192)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 22)
        Me.EmailTextBox.TabIndex = 70
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Brown
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(349, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(38, 36)
        Me.Button3.TabIndex = 57
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btn_actualizar
        '
        Me.btn_actualizar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_actualizar.FlatAppearance.BorderSize = 0
        Me.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizar.ForeColor = System.Drawing.Color.White
        Me.btn_actualizar.Location = New System.Drawing.Point(133, 243)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(152, 36)
        Me.btn_actualizar.TabIndex = 57
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.UseVisualStyleBackColor = False
        '
        'Group_clienteAGG
        '
        Me.Group_clienteAGG.Controls.Add(Me.ComboBox1)
        Me.Group_clienteAGG.Controls.Add(Me.TextBoxEMAIL)
        Me.Group_clienteAGG.Controls.Add(Me.TextBoxTEL)
        Me.Group_clienteAGG.Controls.Add(Me.TextBoxAPE)
        Me.Group_clienteAGG.Controls.Add(Me.TextBoxNOM)
        Me.Group_clienteAGG.Controls.Add(Me.TextBoxNROdoc)
        Me.Group_clienteAGG.Controls.Add(Me.TextBoxIDclie)
        Me.Group_clienteAGG.Controls.Add(ID_ClienteLabel1)
        Me.Group_clienteAGG.Controls.Add(ID_TipoDocumentoLabel1)
        Me.Group_clienteAGG.Controls.Add(NumeroDocumentoLabel1)
        Me.Group_clienteAGG.Controls.Add(NombresLabel1)
        Me.Group_clienteAGG.Controls.Add(ApellidosLabel1)
        Me.Group_clienteAGG.Controls.Add(TelefonoLabel1)
        Me.Group_clienteAGG.Controls.Add(EmailLabel1)
        Me.Group_clienteAGG.Controls.Add(Me.btnCancelar)
        Me.Group_clienteAGG.Controls.Add(Me.btnGuardar)
        Me.Group_clienteAGG.Location = New System.Drawing.Point(26, 118)
        Me.Group_clienteAGG.Name = "Group_clienteAGG"
        Me.Group_clienteAGG.Size = New System.Drawing.Size(407, 287)
        Me.Group_clienteAGG.TabIndex = 63
        Me.Group_clienteAGG.TabStop = False
        Me.Group_clienteAGG.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TIPODOCUMENTOBindingSource
        Me.ComboBox1.DisplayMember = "Abreviatura"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(201, 54)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 24)
        Me.ComboBox1.TabIndex = 28
        Me.ComboBox1.ValueMember = "ID_TipoDocumento"
        '
        'TextBoxEMAIL
        '
        Me.TextBoxEMAIL.Location = New System.Drawing.Point(201, 194)
        Me.TextBoxEMAIL.Name = "TextBoxEMAIL"
        Me.TextBoxEMAIL.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxEMAIL.TabIndex = 27
        '
        'TextBoxTEL
        '
        Me.TextBoxTEL.Location = New System.Drawing.Point(201, 166)
        Me.TextBoxTEL.Name = "TextBoxTEL"
        Me.TextBoxTEL.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxTEL.TabIndex = 26
        '
        'TextBoxAPE
        '
        Me.TextBoxAPE.Location = New System.Drawing.Point(201, 141)
        Me.TextBoxAPE.Name = "TextBoxAPE"
        Me.TextBoxAPE.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxAPE.TabIndex = 25
        '
        'TextBoxNOM
        '
        Me.TextBoxNOM.Location = New System.Drawing.Point(201, 113)
        Me.TextBoxNOM.Name = "TextBoxNOM"
        Me.TextBoxNOM.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxNOM.TabIndex = 24
        '
        'TextBoxNROdoc
        '
        Me.TextBoxNROdoc.Location = New System.Drawing.Point(201, 85)
        Me.TextBoxNROdoc.Name = "TextBoxNROdoc"
        Me.TextBoxNROdoc.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxNROdoc.TabIndex = 23
        '
        'TextBoxIDclie
        '
        Me.TextBoxIDclie.Enabled = False
        Me.TextBoxIDclie.Location = New System.Drawing.Point(201, 26)
        Me.TextBoxIDclie.Name = "TextBoxIDclie"
        Me.TextBoxIDclie.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxIDclie.TabIndex = 21
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Brown
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(349, 6)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(38, 36)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "X"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(133, 230)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(152, 36)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'BUSCAR_CLIENTES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(1924, 671)
        Me.Controls.Add(Me.Group_clienteAGG)
        Me.Controls.Add(Me.Group_editarCLI)
        Me.Controls.Add(Me.Btn_agregar)
        Me.Controls.Add(Me.Btn_editar)
        Me.Controls.Add(Me.Searche_cliente)
        Me.Controls.Add(Me.CLIENTEDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Name = "BUSCAR_CLIENTES"
        Me.Text = "   "
        CType(Me._TRANSPORTE_TUMBESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_editarCLI.ResumeLayout(False)
        Me.Group_editarCLI.PerformLayout()
        CType(Me.TIPODOCUMENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_clienteAGG.ResumeLayout(False)
        Me.Group_clienteAGG.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents _TRANSPORTE_TUMBESDataSet As _TRANSPORTE_TUMBESDataSet
    Friend WithEvents CLIENTEBindingSource As BindingSource
    Friend WithEvents CLIENTETableAdapter As _TRANSPORTE_TUMBESDataSetTableAdapters.CLIENTETableAdapter
    Friend WithEvents TableAdapterManager As _TRANSPORTE_TUMBESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CLIENTEDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Searche_cliente As TextBox
    Friend WithEvents Btn_editar As Button
    Friend WithEvents Btn_agregar As Button
    Friend WithEvents Group_editarCLI As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents ID_ClienteTextBox As TextBox
    Friend WithEvents NumeroDocumentoTextBox As TextBox
    Friend WithEvents NombresTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Group_clienteAGG As GroupBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents TIPO_DOCUMENTOTableAdapter As _TRANSPORTE_TUMBESDataSetTableAdapters.TIPO_DOCUMENTOTableAdapter
    Friend WithEvents ID_TipoDocumentoComboBox As ComboBox
    Friend WithEvents TextBoxEMAIL As TextBox
    Friend WithEvents TextBoxTEL As TextBox
    Friend WithEvents TextBoxAPE As TextBox
    Friend WithEvents TextBoxNOM As TextBox
    Friend WithEvents TextBoxNROdoc As TextBox
    Friend WithEvents TextBoxIDclie As TextBox
    Friend WithEvents TIPODOCUMENTOBindingSource As BindingSource
    Friend WithEvents ComboBox1 As ComboBox
End Class
