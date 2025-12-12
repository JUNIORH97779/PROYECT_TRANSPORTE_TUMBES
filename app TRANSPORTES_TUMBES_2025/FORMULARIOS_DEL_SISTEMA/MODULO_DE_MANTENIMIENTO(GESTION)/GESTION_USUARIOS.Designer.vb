<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GESTION_USUARIOS
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
        Dim ID_UsuarioLabel As System.Windows.Forms.Label
        Dim ID_RolLabel As System.Windows.Forms.Label
        Dim NombreUsuarioLabel As System.Windows.Forms.Label
        Dim PasswordHashLabel As System.Windows.Forms.Label
        Dim NombreCompletoLabel As System.Windows.Forms.Label
        Dim ID_RolLabel1 As System.Windows.Forms.Label
        Dim NombreRolLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GESTION_USUARIOS))
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.USUARIOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.USUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._TRANSPORTE_TUMBESDataSet = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ID_UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.NombreUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordHashTextBox = New System.Windows.Forms.TextBox()
        Me.NombreCompletoTextBox = New System.Windows.Forms.TextBox()
        Me.Group_usuario = New System.Windows.Forms.GroupBox()
        Me.ID_RolComboBox = New System.Windows.Forms.ComboBox()
        Me.USUARIODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btn_añadirRol = New System.Windows.Forms.Button()
        Me.Group_rol = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_aceptarRol = New System.Windows.Forms.Button()
        Me.ID_RolTextBox1 = New System.Windows.Forms.TextBox()
        Me.ROLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreRolTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.USUARIOTableAdapter = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.USUARIOTableAdapter()
        Me.TableAdapterManager = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.TableAdapterManager()
        Me.ROLTableAdapter = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.ROLTableAdapter()
        Me.Group_editarUSU = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.ID_UsuarioTextBox1 = New System.Windows.Forms.TextBox()
        Me.ID_RolComboBox1 = New System.Windows.Forms.ComboBox()
        Me.NombreUsuarioTextBox1 = New System.Windows.Forms.TextBox()
        Me.PasswordHashTextBox1 = New System.Windows.Forms.TextBox()
        Me.NombreCompletoTextBox1 = New System.Windows.Forms.TextBox()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.USUARIOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        ID_UsuarioLabel = New System.Windows.Forms.Label()
        ID_RolLabel = New System.Windows.Forms.Label()
        NombreUsuarioLabel = New System.Windows.Forms.Label()
        PasswordHashLabel = New System.Windows.Forms.Label()
        NombreCompletoLabel = New System.Windows.Forms.Label()
        ID_RolLabel1 = New System.Windows.Forms.Label()
        NombreRolLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CType(Me.USUARIOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.USUARIOBindingNavigator.SuspendLayout()
        CType(Me.USUARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._TRANSPORTE_TUMBESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_usuario.SuspendLayout()
        CType(Me.USUARIODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_rol.SuspendLayout()
        CType(Me.ROLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_editarUSU.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_UsuarioLabel
        '
        ID_UsuarioLabel.AutoSize = True
        ID_UsuarioLabel.Location = New System.Drawing.Point(29, 33)
        ID_UsuarioLabel.Name = "ID_UsuarioLabel"
        ID_UsuarioLabel.Size = New System.Drawing.Size(120, 16)
        ID_UsuarioLabel.TabIndex = 46
        ID_UsuarioLabel.Text = "Código de usuario:"
        '
        'ID_RolLabel
        '
        ID_RolLabel.AutoSize = True
        ID_RolLabel.Location = New System.Drawing.Point(118, 71)
        ID_RolLabel.Name = "ID_RolLabel"
        ID_RolLabel.Size = New System.Drawing.Size(31, 16)
        ID_RolLabel.TabIndex = 48
        ID_RolLabel.Text = "Rol:"
        '
        'NombreUsuarioLabel
        '
        NombreUsuarioLabel.AutoSize = True
        NombreUsuarioLabel.Location = New System.Drawing.Point(21, 105)
        NombreUsuarioLabel.Name = "NombreUsuarioLabel"
        NombreUsuarioLabel.Size = New System.Drawing.Size(128, 16)
        NombreUsuarioLabel.TabIndex = 50
        NombreUsuarioLabel.Text = "Nombre del usuario:"
        '
        'PasswordHashLabel
        '
        PasswordHashLabel.AutoSize = True
        PasswordHashLabel.Location = New System.Drawing.Point(70, 141)
        PasswordHashLabel.Name = "PasswordHashLabel"
        PasswordHashLabel.Size = New System.Drawing.Size(79, 16)
        PasswordHashLabel.TabIndex = 52
        PasswordHashLabel.Text = "Contraseña:"
        '
        'NombreCompletoLabel
        '
        NombreCompletoLabel.AutoSize = True
        NombreCompletoLabel.Location = New System.Drawing.Point(32, 176)
        NombreCompletoLabel.Name = "NombreCompletoLabel"
        NombreCompletoLabel.Size = New System.Drawing.Size(120, 16)
        NombreCompletoLabel.TabIndex = 54
        NombreCompletoLabel.Text = "Nombre Completo:"
        '
        'ID_RolLabel1
        '
        ID_RolLabel1.AutoSize = True
        ID_RolLabel1.Location = New System.Drawing.Point(49, 58)
        ID_RolLabel1.Name = "ID_RolLabel1"
        ID_RolLabel1.Size = New System.Drawing.Size(94, 16)
        ID_RolLabel1.TabIndex = 0
        ID_RolLabel1.Text = "Código del rol:"
        '
        'NombreRolLabel
        '
        NombreRolLabel.AutoSize = True
        NombreRolLabel.Location = New System.Drawing.Point(51, 95)
        NombreRolLabel.Name = "NombreRolLabel"
        NombreRolLabel.Size = New System.Drawing.Size(83, 16)
        NombreRolLabel.TabIndex = 2
        NombreRolLabel.Text = "Nombre Rol:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(54, 135)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(82, 16)
        DescripcionLabel.TabIndex = 4
        DescripcionLabel.Text = "Descripcion:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(26, 63)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(120, 16)
        Label2.TabIndex = 57
        Label2.Text = "Código de usuario:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(37, 203)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(120, 16)
        Label3.TabIndex = 61
        Label3.Text = "Nombre Completo:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(115, 97)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(31, 16)
        Label4.TabIndex = 58
        Label4.Text = "Rol:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(29, 131)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(128, 16)
        Label6.TabIndex = 59
        Label6.Text = "Nombre del usuario:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(78, 162)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(79, 16)
        Label7.TabIndex = 57
        Label7.Text = "Contraseña:"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(147, 225)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(152, 36)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(242, 173)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(152, 36)
        Me.btnEditar.TabIndex = 6
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(687, 173)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(152, 36)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Brown
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(368, 13)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(38, 36)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "X"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Maroon
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(192, 236)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(152, 36)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Dar de baja"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Uighur", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(692, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(286, 48)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Gestionar de Usuarios"
        '
        'USUARIOBindingNavigator
        '
        Me.USUARIOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.USUARIOBindingNavigator.BindingSource = Me.USUARIOBindingSource
        Me.USUARIOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.USUARIOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.USUARIOBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.USUARIOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.USUARIOBindingNavigatorSaveItem})
        Me.USUARIOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.USUARIOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.USUARIOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.USUARIOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.USUARIOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.USUARIOBindingNavigator.Name = "USUARIOBindingNavigator"
        Me.USUARIOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.USUARIOBindingNavigator.Size = New System.Drawing.Size(1756, 27)
        Me.USUARIOBindingNavigator.TabIndex = 46
        Me.USUARIOBindingNavigator.Text = "BindingNavigator1"
        Me.USUARIOBindingNavigator.Visible = False
        '
        'USUARIOBindingSource
        '
        Me.USUARIOBindingSource.DataMember = "USUARIO"
        Me.USUARIOBindingSource.DataSource = Me._TRANSPORTE_TUMBESDataSet
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ID_UsuarioTextBox
        '
        Me.ID_UsuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ID_UsuarioTextBox.Enabled = False
        Me.ID_UsuarioTextBox.Location = New System.Drawing.Point(178, 30)
        Me.ID_UsuarioTextBox.Name = "ID_UsuarioTextBox"
        Me.ID_UsuarioTextBox.Size = New System.Drawing.Size(174, 22)
        Me.ID_UsuarioTextBox.TabIndex = 47
        '
        'NombreUsuarioTextBox
        '
        Me.NombreUsuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreUsuarioTextBox.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.NombreUsuarioTextBox.Location = New System.Drawing.Point(178, 102)
        Me.NombreUsuarioTextBox.Name = "NombreUsuarioTextBox"
        Me.NombreUsuarioTextBox.Size = New System.Drawing.Size(174, 22)
        Me.NombreUsuarioTextBox.TabIndex = 51
        '
        'PasswordHashTextBox
        '
        Me.PasswordHashTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordHashTextBox.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.PasswordHashTextBox.Location = New System.Drawing.Point(178, 139)
        Me.PasswordHashTextBox.Name = "PasswordHashTextBox"
        Me.PasswordHashTextBox.Size = New System.Drawing.Size(174, 22)
        Me.PasswordHashTextBox.TabIndex = 53
        '
        'NombreCompletoTextBox
        '
        Me.NombreCompletoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreCompletoTextBox.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.NombreCompletoTextBox.Location = New System.Drawing.Point(178, 170)
        Me.NombreCompletoTextBox.Name = "NombreCompletoTextBox"
        Me.NombreCompletoTextBox.Size = New System.Drawing.Size(174, 22)
        Me.NombreCompletoTextBox.TabIndex = 55
        '
        'Group_usuario
        '
        Me.Group_usuario.Controls.Add(Me.ID_RolComboBox)
        Me.Group_usuario.Controls.Add(ID_UsuarioLabel)
        Me.Group_usuario.Controls.Add(Me.NombreCompletoTextBox)
        Me.Group_usuario.Controls.Add(Me.ID_UsuarioTextBox)
        Me.Group_usuario.Controls.Add(NombreCompletoLabel)
        Me.Group_usuario.Controls.Add(ID_RolLabel)
        Me.Group_usuario.Controls.Add(Me.PasswordHashTextBox)
        Me.Group_usuario.Controls.Add(Me.btnCancelar)
        Me.Group_usuario.Controls.Add(PasswordHashLabel)
        Me.Group_usuario.Controls.Add(Me.btnGuardar)
        Me.Group_usuario.Controls.Add(NombreUsuarioLabel)
        Me.Group_usuario.Controls.Add(Me.NombreUsuarioTextBox)
        Me.Group_usuario.Location = New System.Drawing.Point(557, 215)
        Me.Group_usuario.Name = "Group_usuario"
        Me.Group_usuario.Size = New System.Drawing.Size(406, 282)
        Me.Group_usuario.TabIndex = 58
        Me.Group_usuario.TabStop = False
        Me.Group_usuario.Visible = False
        '
        'ID_RolComboBox
        '
        Me.ID_RolComboBox.FormattingEnabled = True
        Me.ID_RolComboBox.Location = New System.Drawing.Point(178, 68)
        Me.ID_RolComboBox.Name = "ID_RolComboBox"
        Me.ID_RolComboBox.Size = New System.Drawing.Size(121, 24)
        Me.ID_RolComboBox.TabIndex = 56
        '
        'USUARIODataGridView
        '
        Me.USUARIODataGridView.AllowUserToAddRows = False
        Me.USUARIODataGridView.AllowUserToDeleteRows = False
        Me.USUARIODataGridView.AutoGenerateColumns = False
        Me.USUARIODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.USUARIODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn1})
        Me.USUARIODataGridView.DataSource = Me.USUARIOBindingSource
        Me.USUARIODataGridView.Location = New System.Drawing.Point(387, 541)
        Me.USUARIODataGridView.Name = "USUARIODataGridView"
        Me.USUARIODataGridView.ReadOnly = True
        Me.USUARIODataGridView.RowHeadersWidth = 51
        Me.USUARIODataGridView.RowTemplate.Height = 24
        Me.USUARIODataGridView.Size = New System.Drawing.Size(809, 300)
        Me.USUARIODataGridView.TabIndex = 58
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Usuario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Usuario"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_Rol"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID_Rol"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NombreUsuario"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NombreUsuario"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PasswordHash"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PasswordHash"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NombreCompleto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NombreCompleto"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Estado"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Estado"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 125
        '
        'btn_añadirRol
        '
        Me.btn_añadirRol.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_añadirRol.FlatAppearance.BorderSize = 0
        Me.btn_añadirRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_añadirRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadirRol.ForeColor = System.Drawing.Color.White
        Me.btn_añadirRol.Location = New System.Drawing.Point(1136, 173)
        Me.btn_añadirRol.Name = "btn_añadirRol"
        Me.btn_añadirRol.Size = New System.Drawing.Size(152, 36)
        Me.btn_añadirRol.TabIndex = 59
        Me.btn_añadirRol.Text = "Añadir nuevo rol"
        Me.btn_añadirRol.UseVisualStyleBackColor = False
        '
        'Group_rol
        '
        Me.Group_rol.Controls.Add(Me.Button3)
        Me.Group_rol.Controls.Add(Me.btn_aceptarRol)
        Me.Group_rol.Controls.Add(ID_RolLabel1)
        Me.Group_rol.Controls.Add(Me.ID_RolTextBox1)
        Me.Group_rol.Controls.Add(NombreRolLabel)
        Me.Group_rol.Controls.Add(Me.NombreRolTextBox)
        Me.Group_rol.Controls.Add(DescripcionLabel)
        Me.Group_rol.Controls.Add(Me.DescripcionTextBox)
        Me.Group_rol.Location = New System.Drawing.Point(1016, 215)
        Me.Group_rol.Name = "Group_rol"
        Me.Group_rol.Size = New System.Drawing.Size(367, 282)
        Me.Group_rol.TabIndex = 60
        Me.Group_rol.TabStop = False
        Me.Group_rol.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Brown
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(323, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(38, 36)
        Me.Button3.TabIndex = 56
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btn_aceptarRol
        '
        Me.btn_aceptarRol.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_aceptarRol.FlatAppearance.BorderSize = 0
        Me.btn_aceptarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aceptarRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptarRol.ForeColor = System.Drawing.Color.White
        Me.btn_aceptarRol.Location = New System.Drawing.Point(120, 218)
        Me.btn_aceptarRol.Name = "btn_aceptarRol"
        Me.btn_aceptarRol.Size = New System.Drawing.Size(152, 36)
        Me.btn_aceptarRol.TabIndex = 56
        Me.btn_aceptarRol.Text = "Aceptar"
        Me.btn_aceptarRol.UseVisualStyleBackColor = False
        '
        'ID_RolTextBox1
        '
        Me.ID_RolTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ID_RolTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ROLBindingSource, "ID_Rol", True))
        Me.ID_RolTextBox1.Enabled = False
        Me.ID_RolTextBox1.Location = New System.Drawing.Point(149, 56)
        Me.ID_RolTextBox1.Name = "ID_RolTextBox1"
        Me.ID_RolTextBox1.Size = New System.Drawing.Size(174, 22)
        Me.ID_RolTextBox1.TabIndex = 1
        '
        'ROLBindingSource
        '
        Me.ROLBindingSource.DataMember = "ROL"
        Me.ROLBindingSource.DataSource = Me._TRANSPORTE_TUMBESDataSet
        '
        'NombreRolTextBox
        '
        Me.NombreRolTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreRolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ROLBindingSource, "NombreRol", True))
        Me.NombreRolTextBox.Location = New System.Drawing.Point(149, 93)
        Me.NombreRolTextBox.Name = "NombreRolTextBox"
        Me.NombreRolTextBox.Size = New System.Drawing.Size(174, 22)
        Me.NombreRolTextBox.TabIndex = 3
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ROLBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(149, 133)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(174, 22)
        Me.DescripcionTextBox.TabIndex = 5
        '
        'USUARIOTableAdapter
        '
        Me.USUARIOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CHOFERTableAdapter = Nothing
        Me.TableAdapterManager.CLIENTETableAdapter = Nothing
        Me.TableAdapterManager.MOVILIDADTableAdapter = Nothing
        Me.TableAdapterManager.PASAJETableAdapter = Nothing
        Me.TableAdapterManager.ROLTableAdapter = Me.ROLTableAdapter
        Me.TableAdapterManager.RUTATableAdapter = Nothing
        Me.TableAdapterManager.TIPO_DOCUMENTOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USUARIOTableAdapter = Me.USUARIOTableAdapter
        Me.TableAdapterManager.VENTATableAdapter = Nothing
        Me.TableAdapterManager.VIAJETableAdapter = Nothing
        '
        'ROLTableAdapter
        '
        Me.ROLTableAdapter.ClearBeforeFill = True
        '
        'Group_editarUSU
        '
        Me.Group_editarUSU.Controls.Add(Label7)
        Me.Group_editarUSU.Controls.Add(Me.Button1)
        Me.Group_editarUSU.Controls.Add(Me.btn_actualizar)
        Me.Group_editarUSU.Controls.Add(Label2)
        Me.Group_editarUSU.Controls.Add(Label3)
        Me.Group_editarUSU.Controls.Add(Me.ID_UsuarioTextBox1)
        Me.Group_editarUSU.Controls.Add(Me.ID_RolComboBox1)
        Me.Group_editarUSU.Controls.Add(Me.btnEliminar)
        Me.Group_editarUSU.Controls.Add(Label4)
        Me.Group_editarUSU.Controls.Add(Me.NombreUsuarioTextBox1)
        Me.Group_editarUSU.Controls.Add(Me.PasswordHashTextBox1)
        Me.Group_editarUSU.Controls.Add(Me.NombreCompletoTextBox1)
        Me.Group_editarUSU.Controls.Add(Label6)
        Me.Group_editarUSU.Location = New System.Drawing.Point(132, 215)
        Me.Group_editarUSU.Name = "Group_editarUSU"
        Me.Group_editarUSU.Size = New System.Drawing.Size(370, 296)
        Me.Group_editarUSU.TabIndex = 61
        Me.Group_editarUSU.TabStop = False
        Me.Group_editarUSU.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Brown
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(329, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 36)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_actualizar
        '
        Me.btn_actualizar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_actualizar.FlatAppearance.BorderSize = 0
        Me.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizar.ForeColor = System.Drawing.Color.White
        Me.btn_actualizar.Location = New System.Drawing.Point(16, 236)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(152, 36)
        Me.btn_actualizar.TabIndex = 57
        Me.btn_actualizar.Text = "Actualizar:"
        Me.btn_actualizar.UseVisualStyleBackColor = False
        '
        'ID_UsuarioTextBox1
        '
        Me.ID_UsuarioTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ID_UsuarioTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOBindingSource, "ID_Usuario", True))
        Me.ID_UsuarioTextBox1.Enabled = False
        Me.ID_UsuarioTextBox1.Location = New System.Drawing.Point(170, 60)
        Me.ID_UsuarioTextBox1.Name = "ID_UsuarioTextBox1"
        Me.ID_UsuarioTextBox1.Size = New System.Drawing.Size(174, 22)
        Me.ID_UsuarioTextBox1.TabIndex = 1
        '
        'ID_RolComboBox1
        '
        Me.ID_RolComboBox1.CausesValidation = False
        Me.ID_RolComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOBindingSource, "ID_Rol", True))
        Me.ID_RolComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ID_RolComboBox1.FormattingEnabled = True
        Me.ID_RolComboBox1.Location = New System.Drawing.Point(170, 94)
        Me.ID_RolComboBox1.Name = "ID_RolComboBox1"
        Me.ID_RolComboBox1.Size = New System.Drawing.Size(174, 24)
        Me.ID_RolComboBox1.TabIndex = 3
        '
        'NombreUsuarioTextBox1
        '
        Me.NombreUsuarioTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreUsuarioTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOBindingSource, "NombreUsuario", True))
        Me.NombreUsuarioTextBox1.Location = New System.Drawing.Point(170, 129)
        Me.NombreUsuarioTextBox1.Name = "NombreUsuarioTextBox1"
        Me.NombreUsuarioTextBox1.Size = New System.Drawing.Size(174, 22)
        Me.NombreUsuarioTextBox1.TabIndex = 5
        '
        'PasswordHashTextBox1
        '
        Me.PasswordHashTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordHashTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOBindingSource, "PasswordHash", True))
        Me.PasswordHashTextBox1.Location = New System.Drawing.Point(170, 160)
        Me.PasswordHashTextBox1.Name = "PasswordHashTextBox1"
        Me.PasswordHashTextBox1.Size = New System.Drawing.Size(174, 22)
        Me.PasswordHashTextBox1.TabIndex = 7
        '
        'NombreCompletoTextBox1
        '
        Me.NombreCompletoTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreCompletoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOBindingSource, "NombreCompleto", True))
        Me.NombreCompletoTextBox1.Location = New System.Drawing.Point(170, 197)
        Me.NombreCompletoTextBox1.Name = "NombreCompletoTextBox1"
        Me.NombreCompletoTextBox1.Size = New System.Drawing.Size(174, 22)
        Me.NombreCompletoTextBox1.TabIndex = 9
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
        'USUARIOBindingNavigatorSaveItem
        '
        Me.USUARIOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.USUARIOBindingNavigatorSaveItem.Image = CType(resources.GetObject("USUARIOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.USUARIOBindingNavigatorSaveItem.Name = "USUARIOBindingNavigatorSaveItem"
        Me.USUARIOBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.USUARIOBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'GESTION_USUARIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(1766, 938)
        Me.Controls.Add(Me.Group_editarUSU)
        Me.Controls.Add(Me.Group_rol)
        Me.Controls.Add(Me.btn_añadirRol)
        Me.Controls.Add(Me.USUARIODataGridView)
        Me.Controls.Add(Me.Group_usuario)
        Me.Controls.Add(Me.USUARIOBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnEditar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GESTION_USUARIOS"
        Me.Text = "GESTION_USUARIOS"
        CType(Me.USUARIOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.USUARIOBindingNavigator.ResumeLayout(False)
        Me.USUARIOBindingNavigator.PerformLayout()
        CType(Me.USUARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._TRANSPORTE_TUMBESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_usuario.ResumeLayout(False)
        Me.Group_usuario.PerformLayout()
        CType(Me.USUARIODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_rol.ResumeLayout(False)
        Me.Group_rol.PerformLayout()
        CType(Me.ROLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_editarUSU.ResumeLayout(False)
        Me.Group_editarUSU.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents _TRANSPORTE_TUMBESDataSet As _TRANSPORTE_TUMBESDataSet
    Friend WithEvents USUARIOBindingSource As BindingSource
    Friend WithEvents USUARIOTableAdapter As _TRANSPORTE_TUMBESDataSetTableAdapters.USUARIOTableAdapter
    Friend WithEvents TableAdapterManager As _TRANSPORTE_TUMBESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents USUARIOBindingNavigator As BindingNavigator
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
    Friend WithEvents USUARIOBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ID_UsuarioTextBox As TextBox
    Friend WithEvents NombreUsuarioTextBox As TextBox
    Friend WithEvents PasswordHashTextBox As TextBox
    Friend WithEvents NombreCompletoTextBox As TextBox
    Friend WithEvents Group_usuario As GroupBox
    Friend WithEvents USUARIODataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents btn_añadirRol As Button
    Friend WithEvents ROLTableAdapter As _TRANSPORTE_TUMBESDataSetTableAdapters.ROLTableAdapter
    Friend WithEvents Group_rol As GroupBox
    Friend WithEvents ROLBindingSource As BindingSource
    Friend WithEvents Button3 As Button
    Friend WithEvents btn_aceptarRol As Button
    Friend WithEvents ID_RolTextBox1 As TextBox
    Friend WithEvents NombreRolTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents ID_RolComboBox As ComboBox
    Friend WithEvents Group_editarUSU As GroupBox
    Friend WithEvents ID_UsuarioTextBox1 As TextBox
    Friend WithEvents ID_RolComboBox1 As ComboBox
    Friend WithEvents NombreUsuarioTextBox1 As TextBox
    Friend WithEvents PasswordHashTextBox1 As TextBox
    Friend WithEvents NombreCompletoTextBox1 As TextBox
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents Button1 As Button
End Class
