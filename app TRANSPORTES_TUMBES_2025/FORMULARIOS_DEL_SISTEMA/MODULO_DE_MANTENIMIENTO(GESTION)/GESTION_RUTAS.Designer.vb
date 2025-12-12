<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GESTION_RUTAS
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
        Dim ID_RutaLabel As System.Windows.Forms.Label
        Dim OrigenLabel As System.Windows.Forms.Label
        Dim DestinoLabel As System.Windows.Forms.Label
        Dim PrecioBaseLabel As System.Windows.Forms.Label
        Dim DuracionAprox_MinLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GESTION_RUTAS))
        Me.btnDarDeBaja = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me._TRANSPORTE_TUMBESDataSet = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSet()
        Me.RUTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RUTATableAdapter = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.RUTATableAdapter()
        Me.TableAdapterManager = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.TableAdapterManager()
        Me.RUTABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ID_RutaTextBox = New System.Windows.Forms.TextBox()
        Me.OrigenTextBox = New System.Windows.Forms.TextBox()
        Me.DestinoTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioBaseTextBox = New System.Windows.Forms.TextBox()
        Me.DuracionAprox_MinTextBox = New System.Windows.Forms.TextBox()
        Me.RUTADataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.RUTABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        ID_RutaLabel = New System.Windows.Forms.Label()
        OrigenLabel = New System.Windows.Forms.Label()
        DestinoLabel = New System.Windows.Forms.Label()
        PrecioBaseLabel = New System.Windows.Forms.Label()
        DuracionAprox_MinLabel = New System.Windows.Forms.Label()
        CType(Me._TRANSPORTE_TUMBESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RUTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RUTABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RUTABindingNavigator.SuspendLayout()
        CType(Me.RUTADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_RutaLabel
        '
        ID_RutaLabel.AutoSize = True
        ID_RutaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_RutaLabel.Location = New System.Drawing.Point(212, 36)
        ID_RutaLabel.Name = "ID_RutaLabel"
        ID_RutaLabel.Size = New System.Drawing.Size(140, 22)
        ID_RutaLabel.TabIndex = 48
        ID_RutaLabel.Text = "Codigo de Ruta:"
        AddHandler ID_RutaLabel.Click, AddressOf Me.ID_RutaLabel_Click
        '
        'OrigenLabel
        '
        OrigenLabel.AutoSize = True
        OrigenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OrigenLabel.Location = New System.Drawing.Point(283, 77)
        OrigenLabel.Name = "OrigenLabel"
        OrigenLabel.Size = New System.Drawing.Size(69, 22)
        OrigenLabel.TabIndex = 50
        OrigenLabel.Text = "Origen:"
        '
        'DestinoLabel
        '
        DestinoLabel.AutoSize = True
        DestinoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DestinoLabel.Location = New System.Drawing.Point(276, 120)
        DestinoLabel.Name = "DestinoLabel"
        DestinoLabel.Size = New System.Drawing.Size(76, 22)
        DestinoLabel.TabIndex = 52
        DestinoLabel.Text = "Destino:"
        '
        'PrecioBaseLabel
        '
        PrecioBaseLabel.AutoSize = True
        PrecioBaseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecioBaseLabel.Location = New System.Drawing.Point(240, 171)
        PrecioBaseLabel.Name = "PrecioBaseLabel"
        PrecioBaseLabel.Size = New System.Drawing.Size(112, 22)
        PrecioBaseLabel.TabIndex = 54
        PrecioBaseLabel.Text = "Precio Base:"
        '
        'DuracionAprox_MinLabel
        '
        DuracionAprox_MinLabel.AutoSize = True
        DuracionAprox_MinLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DuracionAprox_MinLabel.Location = New System.Drawing.Point(180, 216)
        DuracionAprox_MinLabel.Name = "DuracionAprox_MinLabel"
        DuracionAprox_MinLabel.Size = New System.Drawing.Size(172, 22)
        DuracionAprox_MinLabel.TabIndex = 56
        DuracionAprox_MinLabel.Text = "Duracion Aprox Min:"
        '
        'btnDarDeBaja
        '
        Me.btnDarDeBaja.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnDarDeBaja.FlatAppearance.BorderSize = 0
        Me.btnDarDeBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDarDeBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDarDeBaja.ForeColor = System.Drawing.Color.White
        Me.btnDarDeBaja.Location = New System.Drawing.Point(312, 257)
        Me.btnDarDeBaja.Name = "btnDarDeBaja"
        Me.btnDarDeBaja.Size = New System.Drawing.Size(152, 36)
        Me.btnDarDeBaja.TabIndex = 43
        Me.btnDarDeBaja.Text = "Dar de Baja"
        Me.btnDarDeBaja.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(311, 469)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(152, 36)
        Me.btnNuevo.TabIndex = 41
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(1000, 469)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(152, 36)
        Me.btnEditar.TabIndex = 40
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Uighur", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(733, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 56)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Gestionar Rutas"
        '
        '_TRANSPORTE_TUMBESDataSet
        '
        Me._TRANSPORTE_TUMBESDataSet.DataSetName = "_TRANSPORTE_TUMBESDataSet"
        Me._TRANSPORTE_TUMBESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RUTABindingSource
        '
        Me.RUTABindingSource.DataMember = "RUTA"
        Me.RUTABindingSource.DataSource = Me._TRANSPORTE_TUMBESDataSet
        '
        'RUTATableAdapter
        '
        Me.RUTATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CHOFERTableAdapter = Nothing
        Me.TableAdapterManager.CLIENTETableAdapter = Nothing
        Me.TableAdapterManager.MOVILIDADTableAdapter = Nothing
        Me.TableAdapterManager.PASAJETableAdapter = Nothing
        Me.TableAdapterManager.ROLTableAdapter = Nothing
        Me.TableAdapterManager.RUTATableAdapter = Me.RUTATableAdapter
        Me.TableAdapterManager.TIPO_DOCUMENTOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USUARIOTableAdapter = Nothing
        Me.TableAdapterManager.VENTATableAdapter = Nothing
        Me.TableAdapterManager.VIAJETableAdapter = Nothing
        '
        'RUTABindingNavigator
        '
        Me.RUTABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RUTABindingNavigator.BindingSource = Me.RUTABindingSource
        Me.RUTABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RUTABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RUTABindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.RUTABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RUTABindingNavigatorSaveItem})
        Me.RUTABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RUTABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RUTABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RUTABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RUTABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RUTABindingNavigator.Name = "RUTABindingNavigator"
        Me.RUTABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RUTABindingNavigator.Size = New System.Drawing.Size(1469, 27)
        Me.RUTABindingNavigator.TabIndex = 48
        Me.RUTABindingNavigator.Text = "BindingNavigator1"
        Me.RUTABindingNavigator.Visible = False
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
        'ID_RutaTextBox
        '
        Me.ID_RutaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RUTABindingSource, "ID_Ruta", True))
        Me.ID_RutaTextBox.Enabled = False
        Me.ID_RutaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_RutaTextBox.Location = New System.Drawing.Point(389, 28)
        Me.ID_RutaTextBox.Name = "ID_RutaTextBox"
        Me.ID_RutaTextBox.Size = New System.Drawing.Size(330, 30)
        Me.ID_RutaTextBox.TabIndex = 49
        '
        'OrigenTextBox
        '
        Me.OrigenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RUTABindingSource, "Origen", True))
        Me.OrigenTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrigenTextBox.Location = New System.Drawing.Point(389, 69)
        Me.OrigenTextBox.Name = "OrigenTextBox"
        Me.OrigenTextBox.Size = New System.Drawing.Size(330, 30)
        Me.OrigenTextBox.TabIndex = 51
        '
        'DestinoTextBox
        '
        Me.DestinoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RUTABindingSource, "Destino", True))
        Me.DestinoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DestinoTextBox.Location = New System.Drawing.Point(389, 115)
        Me.DestinoTextBox.Name = "DestinoTextBox"
        Me.DestinoTextBox.Size = New System.Drawing.Size(330, 30)
        Me.DestinoTextBox.TabIndex = 53
        '
        'PrecioBaseTextBox
        '
        Me.PrecioBaseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RUTABindingSource, "PrecioBase", True))
        Me.PrecioBaseTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioBaseTextBox.Location = New System.Drawing.Point(389, 163)
        Me.PrecioBaseTextBox.Name = "PrecioBaseTextBox"
        Me.PrecioBaseTextBox.Size = New System.Drawing.Size(330, 30)
        Me.PrecioBaseTextBox.TabIndex = 55
        '
        'DuracionAprox_MinTextBox
        '
        Me.DuracionAprox_MinTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RUTABindingSource, "DuracionAprox_Min", True))
        Me.DuracionAprox_MinTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DuracionAprox_MinTextBox.Location = New System.Drawing.Point(389, 208)
        Me.DuracionAprox_MinTextBox.Name = "DuracionAprox_MinTextBox"
        Me.DuracionAprox_MinTextBox.Size = New System.Drawing.Size(330, 30)
        Me.DuracionAprox_MinTextBox.TabIndex = 57
        '
        'RUTADataGridView
        '
        Me.RUTADataGridView.AllowUserToAddRows = False
        Me.RUTADataGridView.AllowUserToDeleteRows = False
        Me.RUTADataGridView.AutoGenerateColumns = False
        Me.RUTADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RUTADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn1})
        Me.RUTADataGridView.DataSource = Me.RUTABindingSource
        Me.RUTADataGridView.Location = New System.Drawing.Point(395, 531)
        Me.RUTADataGridView.Name = "RUTADataGridView"
        Me.RUTADataGridView.ReadOnly = True
        Me.RUTADataGridView.RowHeadersWidth = 51
        Me.RUTADataGridView.RowTemplate.Height = 24
        Me.RUTADataGridView.Size = New System.Drawing.Size(808, 220)
        Me.RUTADataGridView.TabIndex = 59
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Ruta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Ruta"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Origen"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Origen"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Destino"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Destino"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PrecioBase"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PrecioBase"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DuracionAprox_Min"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DuracionAprox_Min"
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Ivory
        Me.GroupBox1.Controls.Add(ID_RutaLabel)
        Me.GroupBox1.Controls.Add(Me.ID_RutaTextBox)
        Me.GroupBox1.Controls.Add(Me.DuracionAprox_MinTextBox)
        Me.GroupBox1.Controls.Add(OrigenLabel)
        Me.GroupBox1.Controls.Add(DuracionAprox_MinLabel)
        Me.GroupBox1.Controls.Add(Me.OrigenTextBox)
        Me.GroupBox1.Controls.Add(Me.btnDarDeBaja)
        Me.GroupBox1.Controls.Add(Me.PrecioBaseTextBox)
        Me.GroupBox1.Controls.Add(DestinoLabel)
        Me.GroupBox1.Controls.Add(PrecioBaseLabel)
        Me.GroupBox1.Controls.Add(Me.DestinoTextBox)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(463, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 315)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        '
        'btn_actualizar
        '
        Me.btn_actualizar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_actualizar.Enabled = False
        Me.btn_actualizar.FlatAppearance.BorderSize = 0
        Me.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizar.ForeColor = System.Drawing.Color.White
        Me.btn_actualizar.Location = New System.Drawing.Point(559, 469)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(152, 36)
        Me.btn_actualizar.TabIndex = 61
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.FlatAppearance.BorderSize = 0
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Location = New System.Drawing.Point(775, 469)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(152, 36)
        Me.btn_guardar.TabIndex = 62
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
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
        'RUTABindingNavigatorSaveItem
        '
        Me.RUTABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RUTABindingNavigatorSaveItem.Image = CType(resources.GetObject("RUTABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RUTABindingNavigatorSaveItem.Name = "RUTABindingNavigatorSaveItem"
        Me.RUTABindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.RUTABindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'GESTION_RUTAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(1783, 968)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RUTADataGridView)
        Me.Controls.Add(Me.RUTABindingNavigator)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnEditar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GESTION_RUTAS"
        Me.Text = "FORMULARIO_GESTION_RUTAS"
        CType(Me._TRANSPORTE_TUMBESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RUTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RUTABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RUTABindingNavigator.ResumeLayout(False)
        Me.RUTABindingNavigator.PerformLayout()
        CType(Me.RUTADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDarDeBaja As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents _TRANSPORTE_TUMBESDataSet As _TRANSPORTE_TUMBESDataSet
    Friend WithEvents RUTABindingSource As BindingSource
    Friend WithEvents RUTATableAdapter As _TRANSPORTE_TUMBESDataSetTableAdapters.RUTATableAdapter
    Friend WithEvents TableAdapterManager As _TRANSPORTE_TUMBESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RUTABindingNavigator As BindingNavigator
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
    Friend WithEvents RUTABindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ID_RutaTextBox As TextBox
    Friend WithEvents OrigenTextBox As TextBox
    Friend WithEvents DestinoTextBox As TextBox
    Friend WithEvents PrecioBaseTextBox As TextBox
    Friend WithEvents DuracionAprox_MinTextBox As TextBox
    Friend WithEvents RUTADataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents btn_guardar As Button
End Class
