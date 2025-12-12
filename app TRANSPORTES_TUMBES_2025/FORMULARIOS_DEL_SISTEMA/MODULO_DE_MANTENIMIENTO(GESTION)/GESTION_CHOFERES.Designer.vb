<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GESTION_CHOFERES
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
        Dim ID_ChoferLabel As System.Windows.Forms.Label
        Dim ID_TipoDocumentoLabel As System.Windows.Forms.Label
        Dim NumeroDocumentoLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim NumeroLicenciaLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GESTION_CHOFERES))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.CHOFERBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CHOFERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._TRANSPORTE_TUMBESDataSet = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CHOFERBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CHOFERDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHOFERTableAdapter = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.CHOFERTableAdapter()
        Me.TableAdapterManager = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.TableAdapterManager()
        Me.TIPO_DOCUMENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIPO_DOCUMENTOTableAdapter = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.TIPO_DOCUMENTOTableAdapter()
        Me.ID_ChoferTextBox = New System.Windows.Forms.TextBox()
        Me.ID_TipoDocumentoComboBox = New System.Windows.Forms.ComboBox()
        Me.NumeroDocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroLicenciaTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        ID_ChoferLabel = New System.Windows.Forms.Label()
        ID_TipoDocumentoLabel = New System.Windows.Forms.Label()
        NumeroDocumentoLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        NumeroLicenciaLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.CHOFERBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CHOFERBindingNavigator.SuspendLayout()
        CType(Me.CHOFERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._TRANSPORTE_TUMBESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHOFERDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPO_DOCUMENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_ChoferLabel
        '
        ID_ChoferLabel.AutoSize = True
        ID_ChoferLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_ChoferLabel.Location = New System.Drawing.Point(229, 30)
        ID_ChoferLabel.Name = "ID_ChoferLabel"
        ID_ChoferLabel.Size = New System.Drawing.Size(172, 25)
        ID_ChoferLabel.TabIndex = 57
        ID_ChoferLabel.Text = "Codigo de Chofer:"
        '
        'ID_TipoDocumentoLabel
        '
        ID_TipoDocumentoLabel.AutoSize = True
        ID_TipoDocumentoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_TipoDocumentoLabel.Location = New System.Drawing.Point(241, 66)
        ID_TipoDocumentoLabel.Name = "ID_TipoDocumentoLabel"
        ID_TipoDocumentoLabel.Size = New System.Drawing.Size(162, 25)
        ID_TipoDocumentoLabel.TabIndex = 59
        ID_TipoDocumentoLabel.Text = "Tipo Documento:"
        '
        'NumeroDocumentoLabel
        '
        NumeroDocumentoLabel.AutoSize = True
        NumeroDocumentoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumeroDocumentoLabel.Location = New System.Drawing.Point(209, 111)
        NumeroDocumentoLabel.Name = "NumeroDocumentoLabel"
        NumeroDocumentoLabel.Size = New System.Drawing.Size(192, 25)
        NumeroDocumentoLabel.TabIndex = 61
        NumeroDocumentoLabel.Text = "Numero Documento:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombresLabel.Location = New System.Drawing.Point(305, 151)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(97, 25)
        NombresLabel.TabIndex = 63
        NombresLabel.Text = "Nombres:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidosLabel.Location = New System.Drawing.Point(305, 194)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(98, 25)
        ApellidosLabel.TabIndex = 65
        ApellidosLabel.Text = "Apellidos:"
        '
        'NumeroLicenciaLabel
        '
        NumeroLicenciaLabel.AutoSize = True
        NumeroLicenciaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumeroLicenciaLabel.Location = New System.Drawing.Point(239, 242)
        NumeroLicenciaLabel.Name = "NumeroLicenciaLabel"
        NumeroLicenciaLabel.Size = New System.Drawing.Size(164, 25)
        NumeroLicenciaLabel.TabIndex = 67
        NumeroLicenciaLabel.Text = "Numero Licencia:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.Location = New System.Drawing.Point(308, 285)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(95, 25)
        TelefonoLabel.TabIndex = 69
        TelefonoLabel.Text = "Telefono:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(305, 332)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(102, 25)
        Label1.TabIndex = 72
        Label1.Text = "ESTADO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(1138, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(329, 38)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Gestión de choferes"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(242, 12)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(152, 36)
        Me.btnGuardar.TabIndex = 55
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(12, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(152, 36)
        Me.btnNuevo.TabIndex = 54
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(545, 12)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(152, 36)
        Me.btnEditar.TabIndex = 53
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnActualizar.Enabled = False
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(763, 12)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(152, 36)
        Me.btnActualizar.TabIndex = 52
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'CHOFERBindingNavigator
        '
        Me.CHOFERBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CHOFERBindingNavigator.BindingSource = Me.CHOFERBindingSource
        Me.CHOFERBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CHOFERBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CHOFERBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CHOFERBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CHOFERBindingNavigatorSaveItem})
        Me.CHOFERBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CHOFERBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CHOFERBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CHOFERBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CHOFERBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CHOFERBindingNavigator.Name = "CHOFERBindingNavigator"
        Me.CHOFERBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CHOFERBindingNavigator.Size = New System.Drawing.Size(1924, 27)
        Me.CHOFERBindingNavigator.TabIndex = 57
        Me.CHOFERBindingNavigator.Text = "BindingNavigator1"
        Me.CHOFERBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'CHOFERBindingSource
        '
        Me.CHOFERBindingSource.DataMember = "CHOFER"
        Me.CHOFERBindingSource.DataSource = Me._TRANSPORTE_TUMBESDataSet
        '
        '_TRANSPORTE_TUMBESDataSet
        '
        Me._TRANSPORTE_TUMBESDataSet.DataSetName = "_TRANSPORTE_TUMBESDataSet"
        Me._TRANSPORTE_TUMBESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'CHOFERBindingNavigatorSaveItem
        '
        Me.CHOFERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CHOFERBindingNavigatorSaveItem.Image = CType(resources.GetObject("CHOFERBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CHOFERBindingNavigatorSaveItem.Name = "CHOFERBindingNavigatorSaveItem"
        Me.CHOFERBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.CHOFERBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CHOFERDataGridView
        '
        Me.CHOFERDataGridView.AllowUserToAddRows = False
        Me.CHOFERDataGridView.AllowUserToDeleteRows = False
        Me.CHOFERDataGridView.AutoGenerateColumns = False
        Me.CHOFERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CHOFERDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.CHOFERDataGridView.DataSource = Me.CHOFERBindingSource
        Me.CHOFERDataGridView.Location = New System.Drawing.Point(319, 576)
        Me.CHOFERDataGridView.Name = "CHOFERDataGridView"
        Me.CHOFERDataGridView.ReadOnly = True
        Me.CHOFERDataGridView.RowHeadersWidth = 51
        Me.CHOFERDataGridView.RowTemplate.Height = 24
        Me.CHOFERDataGridView.Size = New System.Drawing.Size(1059, 220)
        Me.CHOFERDataGridView.TabIndex = 57
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Chofer"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Chofer"
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
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NumeroDocumento"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NumeroDocumento"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nombres"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombres"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Apellidos"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NumeroLicencia"
        Me.DataGridViewTextBoxColumn6.HeaderText = "NumeroLicencia"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'CHOFERTableAdapter
        '
        Me.CHOFERTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CHOFERTableAdapter = Me.CHOFERTableAdapter
        Me.TableAdapterManager.CLIENTETableAdapter = Nothing
        Me.TableAdapterManager.MOVILIDADTableAdapter = Nothing
        Me.TableAdapterManager.PASAJETableAdapter = Nothing
        Me.TableAdapterManager.ROLTableAdapter = Nothing
        Me.TableAdapterManager.RUTATableAdapter = Nothing
        Me.TableAdapterManager.TIPO_DOCUMENTOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USUARIOTableAdapter = Nothing
        Me.TableAdapterManager.VENTATableAdapter = Nothing
        Me.TableAdapterManager.VIAJETableAdapter = Nothing
        '
        'TIPO_DOCUMENTOBindingSource
        '
        Me.TIPO_DOCUMENTOBindingSource.DataMember = "TIPO_DOCUMENTO"
        Me.TIPO_DOCUMENTOBindingSource.DataSource = Me._TRANSPORTE_TUMBESDataSet
        '
        'TIPO_DOCUMENTOTableAdapter
        '
        Me.TIPO_DOCUMENTOTableAdapter.ClearBeforeFill = True
        '
        'ID_ChoferTextBox
        '
        Me.ID_ChoferTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ID_ChoferTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CHOFERBindingSource, "ID_Chofer", True))
        Me.ID_ChoferTextBox.Enabled = False
        Me.ID_ChoferTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_ChoferTextBox.Location = New System.Drawing.Point(443, 27)
        Me.ID_ChoferTextBox.Name = "ID_ChoferTextBox"
        Me.ID_ChoferTextBox.Size = New System.Drawing.Size(239, 28)
        Me.ID_ChoferTextBox.TabIndex = 58
        '
        'ID_TipoDocumentoComboBox
        '
        Me.ID_TipoDocumentoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CHOFERBindingSource, "ID_TipoDocumento", True))
        Me.ID_TipoDocumentoComboBox.DataSource = Me.TIPO_DOCUMENTOBindingSource
        Me.ID_TipoDocumentoComboBox.DisplayMember = "Abreviatura"
        Me.ID_TipoDocumentoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_TipoDocumentoComboBox.FormattingEnabled = True
        Me.ID_TipoDocumentoComboBox.Location = New System.Drawing.Point(443, 61)
        Me.ID_TipoDocumentoComboBox.Name = "ID_TipoDocumentoComboBox"
        Me.ID_TipoDocumentoComboBox.Size = New System.Drawing.Size(239, 30)
        Me.ID_TipoDocumentoComboBox.TabIndex = 60
        Me.ID_TipoDocumentoComboBox.ValueMember = "ID_TipoDocumento"
        '
        'NumeroDocumentoTextBox
        '
        Me.NumeroDocumentoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumeroDocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CHOFERBindingSource, "NumeroDocumento", True))
        Me.NumeroDocumentoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDocumentoTextBox.Location = New System.Drawing.Point(443, 108)
        Me.NumeroDocumentoTextBox.Name = "NumeroDocumentoTextBox"
        Me.NumeroDocumentoTextBox.Size = New System.Drawing.Size(239, 28)
        Me.NumeroDocumentoTextBox.TabIndex = 62
        '
        'NombresTextBox
        '
        Me.NombresTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CHOFERBindingSource, "Nombres", True))
        Me.NombresTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombresTextBox.Location = New System.Drawing.Point(443, 148)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(239, 28)
        Me.NombresTextBox.TabIndex = 64
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CHOFERBindingSource, "Apellidos", True))
        Me.ApellidosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(443, 191)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(239, 28)
        Me.ApellidosTextBox.TabIndex = 66
        '
        'NumeroLicenciaTextBox
        '
        Me.NumeroLicenciaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumeroLicenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CHOFERBindingSource, "NumeroLicencia", True))
        Me.NumeroLicenciaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroLicenciaTextBox.Location = New System.Drawing.Point(443, 239)
        Me.NumeroLicenciaTextBox.Name = "NumeroLicenciaTextBox"
        Me.NumeroLicenciaTextBox.Size = New System.Drawing.Size(239, 28)
        Me.NumeroLicenciaTextBox.TabIndex = 68
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CHOFERBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(443, 285)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(239, 28)
        Me.TelefonoTextBox.TabIndex = 70
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Ivory
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.EstadoTextBox)
        Me.GroupBox1.Controls.Add(ID_ChoferLabel)
        Me.GroupBox1.Controls.Add(Me.ID_ChoferTextBox)
        Me.GroupBox1.Controls.Add(ID_TipoDocumentoLabel)
        Me.GroupBox1.Controls.Add(Me.TelefonoTextBox)
        Me.GroupBox1.Controls.Add(Me.ID_TipoDocumentoComboBox)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Controls.Add(NumeroDocumentoLabel)
        Me.GroupBox1.Controls.Add(Me.NumeroLicenciaTextBox)
        Me.GroupBox1.Controls.Add(Me.NumeroDocumentoTextBox)
        Me.GroupBox1.Controls.Add(NumeroLicenciaLabel)
        Me.GroupBox1.Controls.Add(NombresLabel)
        Me.GroupBox1.Controls.Add(Me.ApellidosTextBox)
        Me.GroupBox1.Controls.Add(Me.NombresTextBox)
        Me.GroupBox1.Controls.Add(ApellidosLabel)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(460, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1007, 424)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CHOFERBindingSource, "Estado", True))
        Me.EstadoTextBox.Location = New System.Drawing.Point(443, 335)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(239, 22)
        Me.EstadoTextBox.TabIndex = 71
        '
        'GESTION_CHOFERES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(1924, 817)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CHOFERDataGridView)
        Me.Controls.Add(Me.CHOFERBindingNavigator)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.Label4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GESTION_CHOFERES"
        Me.Text = "GESTION_CHOFERES"
        CType(Me.CHOFERBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CHOFERBindingNavigator.ResumeLayout(False)
        Me.CHOFERBindingNavigator.PerformLayout()
        CType(Me.CHOFERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._TRANSPORTE_TUMBESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHOFERDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPO_DOCUMENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents _TRANSPORTE_TUMBESDataSet As _TRANSPORTE_TUMBESDataSet
    Friend WithEvents CHOFERBindingSource As BindingSource
    Friend WithEvents CHOFERTableAdapter As _TRANSPORTE_TUMBESDataSetTableAdapters.CHOFERTableAdapter
    Friend WithEvents TableAdapterManager As _TRANSPORTE_TUMBESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CHOFERBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CHOFERBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CHOFERDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents TIPO_DOCUMENTOBindingSource As BindingSource
    Friend WithEvents TIPO_DOCUMENTOTableAdapter As _TRANSPORTE_TUMBESDataSetTableAdapters.TIPO_DOCUMENTOTableAdapter
    Friend WithEvents ID_ChoferTextBox As TextBox
    Friend WithEvents ID_TipoDocumentoComboBox As ComboBox
    Friend WithEvents NumeroDocumentoTextBox As TextBox
    Friend WithEvents NombresTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents NumeroLicenciaTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents EstadoTextBox As TextBox
End Class
