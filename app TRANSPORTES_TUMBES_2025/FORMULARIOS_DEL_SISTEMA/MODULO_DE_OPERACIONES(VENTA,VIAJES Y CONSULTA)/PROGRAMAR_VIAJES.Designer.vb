<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PROGRAMAR_VIAJES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PROGRAMAR_VIAJES))
        Dim ID_ViajeLabel As System.Windows.Forms.Label
        Dim ID_RutaLabel As System.Windows.Forms.Label
        Dim ID_MovilidadLabel As System.Windows.Forms.Label
        Dim ID_ChoferLabel As System.Windows.Forms.Label
        Dim FechaHoraSalidaLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Me._TRANSPORTE_TUMBESDataSet = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSet()
        Me.VIAJEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VIAJETableAdapter = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.VIAJETableAdapter()
        Me.TableAdapterManager = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.TableAdapterManager()
        Me.VIAJEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.VIAJEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VIAJEDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_ViajeTextBox = New System.Windows.Forms.TextBox()
        Me.FechaHoraSalidaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBoxviaje = New System.Windows.Forms.GroupBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.ComboBoxRUTA = New System.Windows.Forms.ComboBox()
        Me.ComboBoxMOVILIAD = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCHOFER = New System.Windows.Forms.ComboBox()
        Me.RUTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RUTATableAdapter = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.RUTATableAdapter()
        Me.MOVILIDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MOVILIDADTableAdapter = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.MOVILIDADTableAdapter()
        Me.CHOFERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CHOFERTableAdapter = New app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.CHOFERTableAdapter()
        ID_ViajeLabel = New System.Windows.Forms.Label()
        ID_RutaLabel = New System.Windows.Forms.Label()
        ID_MovilidadLabel = New System.Windows.Forms.Label()
        ID_ChoferLabel = New System.Windows.Forms.Label()
        FechaHoraSalidaLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CType(Me._TRANSPORTE_TUMBESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VIAJEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VIAJEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VIAJEBindingNavigator.SuspendLayout()
        CType(Me.VIAJEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxviaje.SuspendLayout()
        CType(Me.RUTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVILIDADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHOFERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_TRANSPORTE_TUMBESDataSet
        '
        Me._TRANSPORTE_TUMBESDataSet.DataSetName = "_TRANSPORTE_TUMBESDataSet"
        Me._TRANSPORTE_TUMBESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VIAJEBindingSource
        '
        Me.VIAJEBindingSource.DataMember = "VIAJE"
        Me.VIAJEBindingSource.DataSource = Me._TRANSPORTE_TUMBESDataSet
        '
        'VIAJETableAdapter
        '
        Me.VIAJETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CHOFERTableAdapter = Me.CHOFERTableAdapter
        Me.TableAdapterManager.CLIENTETableAdapter = Nothing
        Me.TableAdapterManager.MOVILIDADTableAdapter = Me.MOVILIDADTableAdapter
        Me.TableAdapterManager.PASAJETableAdapter = Nothing
        Me.TableAdapterManager.ROLTableAdapter = Nothing
        Me.TableAdapterManager.RUTATableAdapter = Me.RUTATableAdapter
        Me.TableAdapterManager.TIPO_DOCUMENTOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = app_TRANSPORTES_TUMBES_2025._TRANSPORTE_TUMBESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USUARIOTableAdapter = Nothing
        Me.TableAdapterManager.VENTATableAdapter = Nothing
        Me.TableAdapterManager.VIAJETableAdapter = Me.VIAJETableAdapter
        '
        'VIAJEBindingNavigator
        '
        Me.VIAJEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VIAJEBindingNavigator.BindingSource = Me.VIAJEBindingSource
        Me.VIAJEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VIAJEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VIAJEBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.VIAJEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VIAJEBindingNavigatorSaveItem})
        Me.VIAJEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VIAJEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VIAJEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VIAJEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VIAJEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VIAJEBindingNavigator.Name = "VIAJEBindingNavigator"
        Me.VIAJEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VIAJEBindingNavigator.Size = New System.Drawing.Size(1316, 27)
        Me.VIAJEBindingNavigator.TabIndex = 0
        Me.VIAJEBindingNavigator.Text = "BindingNavigator1"
        Me.VIAJEBindingNavigator.Visible = False
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
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
        'VIAJEBindingNavigatorSaveItem
        '
        Me.VIAJEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VIAJEBindingNavigatorSaveItem.Image = CType(resources.GetObject("VIAJEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VIAJEBindingNavigatorSaveItem.Name = "VIAJEBindingNavigatorSaveItem"
        Me.VIAJEBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.VIAJEBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'VIAJEDataGridView
        '
        Me.VIAJEDataGridView.AutoGenerateColumns = False
        Me.VIAJEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VIAJEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.VIAJEDataGridView.DataSource = Me.VIAJEBindingSource
        Me.VIAJEDataGridView.Location = New System.Drawing.Point(112, 441)
        Me.VIAJEDataGridView.Name = "VIAJEDataGridView"
        Me.VIAJEDataGridView.RowHeadersWidth = 51
        Me.VIAJEDataGridView.RowTemplate.Height = 24
        Me.VIAJEDataGridView.Size = New System.Drawing.Size(812, 220)
        Me.VIAJEDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Viaje"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Viaje"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_Ruta"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID_Ruta"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ID_Movilidad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID_Movilidad"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID_Chofer"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID_Chofer"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FechaHoraSalida"
        Me.DataGridViewTextBoxColumn5.HeaderText = "FechaHoraSalida"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'ID_ViajeLabel
        '
        ID_ViajeLabel.AutoSize = True
        ID_ViajeLabel.Location = New System.Drawing.Point(70, 47)
        ID_ViajeLabel.Name = "ID_ViajeLabel"
        ID_ViajeLabel.Size = New System.Drawing.Size(57, 16)
        ID_ViajeLabel.TabIndex = 2
        ID_ViajeLabel.Text = "ID Viaje:"
        '
        'ID_ViajeTextBox
        '
        Me.ID_ViajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIAJEBindingSource, "ID_Viaje", True))
        Me.ID_ViajeTextBox.Enabled = False
        Me.ID_ViajeTextBox.Location = New System.Drawing.Point(216, 41)
        Me.ID_ViajeTextBox.Name = "ID_ViajeTextBox"
        Me.ID_ViajeTextBox.Size = New System.Drawing.Size(200, 22)
        Me.ID_ViajeTextBox.TabIndex = 3
        '
        'ID_RutaLabel
        '
        ID_RutaLabel.AutoSize = True
        ID_RutaLabel.Location = New System.Drawing.Point(70, 75)
        ID_RutaLabel.Name = "ID_RutaLabel"
        ID_RutaLabel.Size = New System.Drawing.Size(54, 16)
        ID_RutaLabel.TabIndex = 4
        ID_RutaLabel.Text = "ID Ruta:"
        '
        'ID_MovilidadLabel
        '
        ID_MovilidadLabel.AutoSize = True
        ID_MovilidadLabel.Location = New System.Drawing.Point(70, 103)
        ID_MovilidadLabel.Name = "ID_MovilidadLabel"
        ID_MovilidadLabel.Size = New System.Drawing.Size(85, 16)
        ID_MovilidadLabel.TabIndex = 6
        ID_MovilidadLabel.Text = "ID Movilidad:"
        '
        'ID_ChoferLabel
        '
        ID_ChoferLabel.AutoSize = True
        ID_ChoferLabel.Location = New System.Drawing.Point(70, 131)
        ID_ChoferLabel.Name = "ID_ChoferLabel"
        ID_ChoferLabel.Size = New System.Drawing.Size(65, 16)
        ID_ChoferLabel.TabIndex = 8
        ID_ChoferLabel.Text = "ID Chofer:"
        '
        'FechaHoraSalidaLabel
        '
        FechaHoraSalidaLabel.AutoSize = True
        FechaHoraSalidaLabel.Location = New System.Drawing.Point(70, 160)
        FechaHoraSalidaLabel.Name = "FechaHoraSalidaLabel"
        FechaHoraSalidaLabel.Size = New System.Drawing.Size(123, 16)
        FechaHoraSalidaLabel.TabIndex = 10
        FechaHoraSalidaLabel.Text = "Fecha Hora Salida:"
        '
        'FechaHoraSalidaDateTimePicker
        '
        Me.FechaHoraSalidaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VIAJEBindingSource, "FechaHoraSalida", True))
        Me.FechaHoraSalidaDateTimePicker.Location = New System.Drawing.Point(216, 159)
        Me.FechaHoraSalidaDateTimePicker.Name = "FechaHoraSalidaDateTimePicker"
        Me.FechaHoraSalidaDateTimePicker.Size = New System.Drawing.Size(251, 22)
        Me.FechaHoraSalidaDateTimePicker.TabIndex = 11
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(70, 187)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(53, 16)
        EstadoLabel.TabIndex = 12
        EstadoLabel.Text = "Estado:"
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VIAJEBindingSource, "Estado", True))
        Me.EstadoTextBox.Location = New System.Drawing.Point(216, 187)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EstadoTextBox.TabIndex = 13
        '
        'GroupBoxviaje
        '
        Me.GroupBoxviaje.Controls.Add(Me.ComboBoxCHOFER)
        Me.GroupBoxviaje.Controls.Add(Me.ComboBoxMOVILIAD)
        Me.GroupBoxviaje.Controls.Add(Me.ComboBoxRUTA)
        Me.GroupBoxviaje.Controls.Add(Me.ID_ViajeTextBox)
        Me.GroupBoxviaje.Controls.Add(ID_ViajeLabel)
        Me.GroupBoxviaje.Controls.Add(Me.EstadoTextBox)
        Me.GroupBoxviaje.Controls.Add(EstadoLabel)
        Me.GroupBoxviaje.Controls.Add(ID_RutaLabel)
        Me.GroupBoxviaje.Controls.Add(Me.FechaHoraSalidaDateTimePicker)
        Me.GroupBoxviaje.Controls.Add(FechaHoraSalidaLabel)
        Me.GroupBoxviaje.Controls.Add(ID_MovilidadLabel)
        Me.GroupBoxviaje.Controls.Add(ID_ChoferLabel)
        Me.GroupBoxviaje.Enabled = False
        Me.GroupBoxviaje.Location = New System.Drawing.Point(82, 40)
        Me.GroupBoxviaje.Name = "GroupBoxviaje"
        Me.GroupBoxviaje.Size = New System.Drawing.Size(496, 270)
        Me.GroupBoxviaje.TabIndex = 14
        Me.GroupBoxviaje.TabStop = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.FlatAppearance.BorderSize = 0
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Location = New System.Drawing.Point(322, 336)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(152, 36)
        Me.btn_guardar.TabIndex = 66
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
        Me.btn_actualizar.Location = New System.Drawing.Point(772, 336)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(152, 36)
        Me.btn_actualizar.TabIndex = 65
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(112, 336)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(152, 36)
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
        Me.btnEditar.Location = New System.Drawing.Point(563, 336)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(152, 36)
        Me.btnEditar.TabIndex = 63
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'ComboBoxRUTA
        '
        Me.ComboBoxRUTA.DataSource = Me.RUTABindingSource
        Me.ComboBoxRUTA.DisplayMember = "ID_Ruta"
        Me.ComboBoxRUTA.FormattingEnabled = True
        Me.ComboBoxRUTA.Location = New System.Drawing.Point(216, 69)
        Me.ComboBoxRUTA.Name = "ComboBoxRUTA"
        Me.ComboBoxRUTA.Size = New System.Drawing.Size(200, 24)
        Me.ComboBoxRUTA.TabIndex = 14
        Me.ComboBoxRUTA.ValueMember = "ID_Ruta"
        '
        'ComboBoxMOVILIAD
        '
        Me.ComboBoxMOVILIAD.DataSource = Me.MOVILIDADBindingSource
        Me.ComboBoxMOVILIAD.DisplayMember = "Tipo"
        Me.ComboBoxMOVILIAD.FormattingEnabled = True
        Me.ComboBoxMOVILIAD.Location = New System.Drawing.Point(216, 99)
        Me.ComboBoxMOVILIAD.Name = "ComboBoxMOVILIAD"
        Me.ComboBoxMOVILIAD.Size = New System.Drawing.Size(200, 24)
        Me.ComboBoxMOVILIAD.TabIndex = 15
        Me.ComboBoxMOVILIAD.ValueMember = "ID_Movilidad"
        '
        'ComboBoxCHOFER
        '
        Me.ComboBoxCHOFER.DataSource = Me.CHOFERBindingSource
        Me.ComboBoxCHOFER.DisplayMember = "Nombres"
        Me.ComboBoxCHOFER.FormattingEnabled = True
        Me.ComboBoxCHOFER.Location = New System.Drawing.Point(216, 129)
        Me.ComboBoxCHOFER.Name = "ComboBoxCHOFER"
        Me.ComboBoxCHOFER.Size = New System.Drawing.Size(200, 24)
        Me.ComboBoxCHOFER.TabIndex = 16
        Me.ComboBoxCHOFER.ValueMember = "ID_Chofer"
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
        'MOVILIDADBindingSource
        '
        Me.MOVILIDADBindingSource.DataMember = "MOVILIDAD"
        Me.MOVILIDADBindingSource.DataSource = Me._TRANSPORTE_TUMBESDataSet
        '
        'MOVILIDADTableAdapter
        '
        Me.MOVILIDADTableAdapter.ClearBeforeFill = True
        '
        'CHOFERBindingSource
        '
        Me.CHOFERBindingSource.DataMember = "CHOFER"
        Me.CHOFERBindingSource.DataSource = Me._TRANSPORTE_TUMBESDataSet
        '
        'CHOFERTableAdapter
        '
        Me.CHOFERTableAdapter.ClearBeforeFill = True
        '
        'PROGRAMAR_VIAJES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1316, 825)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.GroupBoxviaje)
        Me.Controls.Add(Me.VIAJEDataGridView)
        Me.Controls.Add(Me.VIAJEBindingNavigator)
        Me.Name = "PROGRAMAR_VIAJES"
        Me.Text = "PROGRAMAR_VIAJES"
        CType(Me._TRANSPORTE_TUMBESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VIAJEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VIAJEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VIAJEBindingNavigator.ResumeLayout(False)
        Me.VIAJEBindingNavigator.PerformLayout()
        CType(Me.VIAJEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxviaje.ResumeLayout(False)
        Me.GroupBoxviaje.PerformLayout()
        CType(Me.RUTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVILIDADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHOFERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _TRANSPORTE_TUMBESDataSet As _TRANSPORTE_TUMBESDataSet
    Friend WithEvents VIAJEBindingSource As BindingSource
    Friend WithEvents VIAJETableAdapter As _TRANSPORTE_TUMBESDataSetTableAdapters.VIAJETableAdapter
    Friend WithEvents TableAdapterManager As _TRANSPORTE_TUMBESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VIAJEBindingNavigator As BindingNavigator
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
    Friend WithEvents VIAJEBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents VIAJEDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents ID_ViajeTextBox As TextBox
    Friend WithEvents FechaHoraSalidaDateTimePicker As DateTimePicker
    Friend WithEvents EstadoTextBox As TextBox
    Friend WithEvents GroupBoxviaje As GroupBox
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents ComboBoxRUTA As ComboBox
    Friend WithEvents RUTATableAdapter As _TRANSPORTE_TUMBESDataSetTableAdapters.RUTATableAdapter
    Friend WithEvents ComboBoxCHOFER As ComboBox
    Friend WithEvents ComboBoxMOVILIAD As ComboBox
    Friend WithEvents RUTABindingSource As BindingSource
    Friend WithEvents MOVILIDADTableAdapter As _TRANSPORTE_TUMBESDataSetTableAdapters.MOVILIDADTableAdapter
    Friend WithEvents MOVILIDADBindingSource As BindingSource
    Friend WithEvents CHOFERTableAdapter As _TRANSPORTE_TUMBESDataSetTableAdapters.CHOFERTableAdapter
    Friend WithEvents CHOFERBindingSource As BindingSource
End Class
