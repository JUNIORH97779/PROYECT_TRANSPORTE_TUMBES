<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GESTION_MOVILIDADES
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ID_MovilidadLabel As System.Windows.Forms.Label
        Dim PlacaLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim CapacidadLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GESTION_MOVILIDADES))
        Me._TRANSPORTE_TUMBESDataSet = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSet()
        Me.MOVILIDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MOVILIDADTableAdapter = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.MOVILIDADTableAdapter()
        Me.TableAdapterManager = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.TableAdapterManager()
        Me.MOVILIDADBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MOVILIDADDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ID_MovilidadTextBox = New System.Windows.Forms.TextBox()
        Me.PlacaTextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.CapacidadTextBox = New System.Windows.Forms.TextBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.GroupMovilidad = New System.Windows.Forms.GroupBox()
        Me.btnDardebaja = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.MOVILIDADBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        ID_MovilidadLabel = New System.Windows.Forms.Label()
        PlacaLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        CapacidadLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        CType(Me._TRANSPORTE_TUMBESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVILIDADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVILIDADBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MOVILIDADBindingNavigator.SuspendLayout()
        CType(Me.MOVILIDADDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupMovilidad.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_MovilidadLabel
        '
        ID_MovilidadLabel.AutoSize = True
        ID_MovilidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_MovilidadLabel.Location = New System.Drawing.Point(293, 61)
        ID_MovilidadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ID_MovilidadLabel.Name = "ID_MovilidadLabel"
        ID_MovilidadLabel.Size = New System.Drawing.Size(177, 22)
        ID_MovilidadLabel.TabIndex = 2
        ID_MovilidadLabel.Text = "Codigo de Movilidad:"
        AddHandler ID_MovilidadLabel.Click, AddressOf Me.ID_MovilidadLabel_Click
        '
        'PlacaLabel
        '
        PlacaLabel.AutoSize = True
        PlacaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PlacaLabel.Location = New System.Drawing.Point(406, 104)
        PlacaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PlacaLabel.Name = "PlacaLabel"
        PlacaLabel.Size = New System.Drawing.Size(60, 22)
        PlacaLabel.TabIndex = 4
        PlacaLabel.Text = "Placa:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoLabel.Location = New System.Drawing.Point(419, 151)
        TipoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(51, 22)
        TipoLabel.TabIndex = 6
        TipoLabel.Text = "Tipo:"
        AddHandler TipoLabel.Click, AddressOf Me.TipoLabel_Click
        '
        'CapacidadLabel
        '
        CapacidadLabel.AutoSize = True
        CapacidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CapacidadLabel.Location = New System.Drawing.Point(369, 201)
        CapacidadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CapacidadLabel.Name = "CapacidadLabel"
        CapacidadLabel.Size = New System.Drawing.Size(101, 22)
        CapacidadLabel.TabIndex = 8
        CapacidadLabel.Text = "Capacidad:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MarcaLabel.Location = New System.Drawing.Point(406, 252)
        MarcaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(64, 22)
        MarcaLabel.TabIndex = 10
        MarcaLabel.Text = "Marca:"
        '
        '_TRANSPORTE_TUMBESDataSet
        '
        Me._TRANSPORTE_TUMBESDataSet.DataSetName = "_TRANSPORTE_TUMBESDataSet"
        Me._TRANSPORTE_TUMBESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MOVILIDADBindingSource
        '
        Me.MOVILIDADBindingSource.DataMember = "MOVILIDAD"
        Me.MOVILIDADBindingSource.DataSource = Me._TRANSPORTE_TUMBESDataSet
        '
        'MOVILIDADTableAdapter
        '
        Me.MOVILIDADTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CHOFERTableAdapter = Nothing
        Me.TableAdapterManager.CLIENTETableAdapter = Nothing
        Me.TableAdapterManager.MOVILIDADTableAdapter = Me.MOVILIDADTableAdapter
        Me.TableAdapterManager.PASAJETableAdapter = Nothing
        Me.TableAdapterManager.ROLTableAdapter = Nothing
        Me.TableAdapterManager.RUTATableAdapter = Nothing
        Me.TableAdapterManager.TIPO_DOCUMENTOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USUARIOTableAdapter = Nothing
        Me.TableAdapterManager.VENTATableAdapter = Nothing
        Me.TableAdapterManager.VIAJETableAdapter = Nothing
        '
        'MOVILIDADBindingNavigator
        '
        Me.MOVILIDADBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MOVILIDADBindingNavigator.BindingSource = Me.MOVILIDADBindingSource
        Me.MOVILIDADBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MOVILIDADBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MOVILIDADBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MOVILIDADBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MOVILIDADBindingNavigatorSaveItem})
        Me.MOVILIDADBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MOVILIDADBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MOVILIDADBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MOVILIDADBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MOVILIDADBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MOVILIDADBindingNavigator.Name = "MOVILIDADBindingNavigator"
        Me.MOVILIDADBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MOVILIDADBindingNavigator.Size = New System.Drawing.Size(1755, 34)
        Me.MOVILIDADBindingNavigator.TabIndex = 0
        Me.MOVILIDADBindingNavigator.Text = "BindingNavigator1"
        Me.MOVILIDADBindingNavigator.Visible = False
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 31)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 34)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 34)
        '
        'MOVILIDADDataGridView
        '
        Me.MOVILIDADDataGridView.AllowUserToAddRows = False
        Me.MOVILIDADDataGridView.AllowUserToDeleteRows = False
        Me.MOVILIDADDataGridView.AutoGenerateColumns = False
        Me.MOVILIDADDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MOVILIDADDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn1})
        Me.MOVILIDADDataGridView.DataSource = Me.MOVILIDADBindingSource
        Me.MOVILIDADDataGridView.Location = New System.Drawing.Point(314, 669)
        Me.MOVILIDADDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.MOVILIDADDataGridView.Name = "MOVILIDADDataGridView"
        Me.MOVILIDADDataGridView.ReadOnly = True
        Me.MOVILIDADDataGridView.RowHeadersWidth = 51
        Me.MOVILIDADDataGridView.RowTemplate.Height = 24
        Me.MOVILIDADDataGridView.Size = New System.Drawing.Size(1030, 275)
        Me.MOVILIDADDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Movilidad"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Movilidad"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Placa"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Placa"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Capacidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Capacidad"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Marca"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Marca"
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
        'ID_MovilidadTextBox
        '
        Me.ID_MovilidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MOVILIDADBindingSource, "ID_Movilidad", True))
        Me.ID_MovilidadTextBox.Enabled = False
        Me.ID_MovilidadTextBox.Location = New System.Drawing.Point(516, 61)
        Me.ID_MovilidadTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ID_MovilidadTextBox.Name = "ID_MovilidadTextBox"
        Me.ID_MovilidadTextBox.Size = New System.Drawing.Size(419, 24)
        Me.ID_MovilidadTextBox.TabIndex = 3
        '
        'PlacaTextBox
        '
        Me.PlacaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MOVILIDADBindingSource, "Placa", True))
        Me.PlacaTextBox.Location = New System.Drawing.Point(516, 104)
        Me.PlacaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PlacaTextBox.Name = "PlacaTextBox"
        Me.PlacaTextBox.Size = New System.Drawing.Size(419, 24)
        Me.PlacaTextBox.TabIndex = 5
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MOVILIDADBindingSource, "Tipo", True))
        Me.TipoTextBox.Location = New System.Drawing.Point(516, 151)
        Me.TipoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(419, 24)
        Me.TipoTextBox.TabIndex = 7
        '
        'CapacidadTextBox
        '
        Me.CapacidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MOVILIDADBindingSource, "Capacidad", True))
        Me.CapacidadTextBox.Location = New System.Drawing.Point(516, 201)
        Me.CapacidadTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CapacidadTextBox.Name = "CapacidadTextBox"
        Me.CapacidadTextBox.Size = New System.Drawing.Size(419, 24)
        Me.CapacidadTextBox.TabIndex = 9
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MOVILIDADBindingSource, "Marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(516, 252)
        Me.MarcaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(419, 24)
        Me.MarcaTextBox.TabIndex = 11
        '
        'GroupMovilidad
        '
        Me.GroupMovilidad.BackColor = System.Drawing.Color.Ivory
        Me.GroupMovilidad.Controls.Add(Me.btnDardebaja)
        Me.GroupMovilidad.Controls.Add(ID_MovilidadLabel)
        Me.GroupMovilidad.Controls.Add(Me.MarcaTextBox)
        Me.GroupMovilidad.Controls.Add(Me.ID_MovilidadTextBox)
        Me.GroupMovilidad.Controls.Add(MarcaLabel)
        Me.GroupMovilidad.Controls.Add(PlacaLabel)
        Me.GroupMovilidad.Controls.Add(Me.CapacidadTextBox)
        Me.GroupMovilidad.Controls.Add(Me.PlacaTextBox)
        Me.GroupMovilidad.Controls.Add(CapacidadLabel)
        Me.GroupMovilidad.Controls.Add(TipoLabel)
        Me.GroupMovilidad.Controls.Add(Me.TipoTextBox)
        Me.GroupMovilidad.Enabled = False
        Me.GroupMovilidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupMovilidad.Location = New System.Drawing.Point(314, 125)
        Me.GroupMovilidad.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupMovilidad.Name = "GroupMovilidad"
        Me.GroupMovilidad.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupMovilidad.Size = New System.Drawing.Size(1030, 402)
        Me.GroupMovilidad.TabIndex = 12
        Me.GroupMovilidad.TabStop = False
        '
        'btnDardebaja
        '
        Me.btnDardebaja.BackColor = System.Drawing.Color.DimGray
        Me.btnDardebaja.Enabled = False
        Me.btnDardebaja.FlatAppearance.BorderSize = 0
        Me.btnDardebaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDardebaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDardebaja.ForeColor = System.Drawing.Color.White
        Me.btnDardebaja.Location = New System.Drawing.Point(249, 334)
        Me.btnDardebaja.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDardebaja.Name = "btnDardebaja"
        Me.btnDardebaja.Size = New System.Drawing.Size(611, 45)
        Me.btnDardebaja.TabIndex = 68
        Me.btnDardebaja.Text = "Dar de baja"
        Me.btnDardebaja.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.FlatAppearance.BorderSize = 0
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Location = New System.Drawing.Point(759, 580)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(190, 45)
        Me.btn_guardar.TabIndex = 67
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'btn_actualizar
        '
        Me.btn_actualizar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_actualizar.Enabled = False
        Me.btn_actualizar.FlatAppearance.BorderSize = 0
        Me.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizar.ForeColor = System.Drawing.Color.White
        Me.btn_actualizar.Location = New System.Drawing.Point(489, 580)
        Me.btn_actualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(190, 45)
        Me.btn_actualizar.TabIndex = 66
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(1281, 580)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(190, 45)
        Me.btnEliminar.TabIndex = 65
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(179, 580)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(190, 45)
        Me.btnNuevo.TabIndex = 64
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
        Me.btnEditar.Location = New System.Drawing.Point(1041, 580)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(190, 45)
        Me.btnEditar.TabIndex = 63
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Uighur", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(799, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(311, 48)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Gestionar de Movilidad:"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 31)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 31)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 31)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 31)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 31)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 31)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'MOVILIDADBindingNavigatorSaveItem
        '
        Me.MOVILIDADBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MOVILIDADBindingNavigatorSaveItem.Image = CType(resources.GetObject("MOVILIDADBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MOVILIDADBindingNavigatorSaveItem.Name = "MOVILIDADBindingNavigatorSaveItem"
        Me.MOVILIDADBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 31)
        Me.MOVILIDADBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'GESTION_MOVILIDADES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(1843, 1036)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.GroupMovilidad)
        Me.Controls.Add(Me.MOVILIDADDataGridView)
        Me.Controls.Add(Me.MOVILIDADBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GESTION_MOVILIDADES"
        Me.Text = "v"
        CType(Me._TRANSPORTE_TUMBESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVILIDADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVILIDADBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MOVILIDADBindingNavigator.ResumeLayout(False)
        Me.MOVILIDADBindingNavigator.PerformLayout()
        CType(Me.MOVILIDADDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupMovilidad.ResumeLayout(False)
        Me.GroupMovilidad.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _TRANSPORTE_TUMBESDataSet As _TRANSPORTE_TUMBESDataSet
    Friend WithEvents MOVILIDADBindingSource As BindingSource
    Friend WithEvents MOVILIDADTableAdapter As _TRANSPORTE_TUMBESDataSetTableAdapters.MOVILIDADTableAdapter
    Friend WithEvents TableAdapterManager As _TRANSPORTE_TUMBESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MOVILIDADBindingNavigator As BindingNavigator
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
    Friend WithEvents MOVILIDADBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MOVILIDADDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents ID_MovilidadTextBox As TextBox
    Friend WithEvents PlacaTextBox As TextBox
    Friend WithEvents TipoTextBox As TextBox
    Friend WithEvents CapacidadTextBox As TextBox
    Friend WithEvents MarcaTextBox As TextBox
    Friend WithEvents GroupMovilidad As GroupBox
    Friend WithEvents btnDardebaja As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents Label1 As Label
End Class
