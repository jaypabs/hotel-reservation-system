<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChargeType
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
        Me.components = New System.ComponentModel.Container
        Dim ChargeTypeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChargeType))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.ChargeTypeTextBox = New System.Windows.Forms.TextBox
        Me.Charge_TypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HotelDataSet = New Hotel_Management_System.hotelDataSet
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Charge_TypeDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Charge_TypeTableAdapter = New Hotel_Management_System.hotelDataSetTableAdapters.Charge_TypeTableAdapter
        Me.TableAdapterManager = New Hotel_Management_System.hotelDataSetTableAdapters.TableAdapterManager
        Me.Charge_TypeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Charge_TypeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        ChargeTypeLabel = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Charge_TypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Charge_TypeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Charge_TypeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Charge_TypeBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChargeTypeLabel
        '
        ChargeTypeLabel.AutoSize = True
        ChargeTypeLabel.Location = New System.Drawing.Point(71, 106)
        ChargeTypeLabel.Name = "ChargeTypeLabel"
        ChargeTypeLabel.Size = New System.Drawing.Size(71, 13)
        ChargeTypeLabel.TabIndex = 2
        ChargeTypeLabel.Text = "Charge Type:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 57)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(431, 287)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(ChargeTypeLabel)
        Me.TabPage1.Controls.Add(Me.ChargeTypeTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(423, 261)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Entry"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ChargeTypeTextBox
        '
        Me.ChargeTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Charge_TypeBindingSource, "ChargeType", True))
        Me.ChargeTypeTextBox.Location = New System.Drawing.Point(148, 103)
        Me.ChargeTypeTextBox.Name = "ChargeTypeTextBox"
        Me.ChargeTypeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ChargeTypeTextBox.TabIndex = 3
        '
        'Charge_TypeBindingSource
        '
        Me.Charge_TypeBindingSource.DataMember = "Charge Type"
        Me.Charge_TypeBindingSource.DataSource = Me.HotelDataSet
        '
        'HotelDataSet
        '
        Me.HotelDataSet.DataSetName = "hotelDataSet"
        Me.HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Charge_TypeDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(423, 261)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Charge_TypeDataGridView
        '
        Me.Charge_TypeDataGridView.AutoGenerateColumns = False
        Me.Charge_TypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Charge_TypeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.Charge_TypeDataGridView.DataSource = Me.Charge_TypeBindingSource
        Me.Charge_TypeDataGridView.Location = New System.Drawing.Point(6, 6)
        Me.Charge_TypeDataGridView.Name = "Charge_TypeDataGridView"
        Me.Charge_TypeDataGridView.Size = New System.Drawing.Size(411, 249)
        Me.Charge_TypeDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ChargeType"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ChargeType"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 41)
        Me.Panel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Charge Type"
        '
        'Charge_TypeTableAdapter
        '
        Me.Charge_TypeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Accounts_ReceivableTableAdapter = Nothing
        Me.TableAdapterManager.AccountsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Business_InfoTableAdapter = Nothing
        Me.TableAdapterManager.Business_SourceTableAdapter = Nothing
        Me.TableAdapterManager.Charge_TypeTableAdapter = Me.Charge_TypeTableAdapter
        Me.TableAdapterManager.CompanyTableAdapter = Nothing
        Me.TableAdapterManager.CountriesTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.DateTempTableAdapter = Nothing
        Me.TableAdapterManager.FormTableAdapter = Nothing
        Me.TableAdapterManager.ID_TypeTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.Key_GeneratorTableAdapter = Nothing
        Me.TableAdapterManager.Other_ChargesTableAdapter = Nothing
        Me.TableAdapterManager.Payment_TypeTableAdapter = Nothing
        Me.TableAdapterManager.Payments_ReceivedTableAdapter = Nothing
        Me.TableAdapterManager.PaymentsTableAdapter = Nothing
        Me.TableAdapterManager.Rate_Per_Period_TempTableAdapter = Nothing
        Me.TableAdapterManager.Rate_Per_PeriodTableAdapter = Nothing
        Me.TableAdapterManager.Rate_TemplatesTableAdapter = Nothing
        Me.TableAdapterManager.Rate_TypeTableAdapter = Nothing
        Me.TableAdapterManager.ReservationTableAdapter = Nothing
        Me.TableAdapterManager.Room_RatesTableAdapter = Nothing
        Me.TableAdapterManager.Room_StatusTableAdapter = Nothing
        Me.TableAdapterManager.Room_TypeTableAdapter = Nothing
        Me.TableAdapterManager.RoomsTableAdapter = Nothing
        Me.TableAdapterManager.Transaction_TypeTableAdapter = Nothing
        Me.TableAdapterManager.TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Hotel_Management_System.hotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.User_PermissionTableAdapter = Nothing
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.VehiclesTableAdapter = Nothing
        '
        'Charge_TypeBindingNavigator
        '
        Me.Charge_TypeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Charge_TypeBindingNavigator.BindingSource = Me.Charge_TypeBindingSource
        Me.Charge_TypeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Charge_TypeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Charge_TypeBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.Charge_TypeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Charge_TypeBindingNavigatorSaveItem})
        Me.Charge_TypeBindingNavigator.Location = New System.Drawing.Point(80, 347)
        Me.Charge_TypeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Charge_TypeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Charge_TypeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Charge_TypeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Charge_TypeBindingNavigator.Name = "Charge_TypeBindingNavigator"
        Me.Charge_TypeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Charge_TypeBindingNavigator.Size = New System.Drawing.Size(277, 25)
        Me.Charge_TypeBindingNavigator.TabIndex = 5
        Me.Charge_TypeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Charge_TypeBindingNavigatorSaveItem
        '
        Me.Charge_TypeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Charge_TypeBindingNavigatorSaveItem.Image = CType(resources.GetObject("Charge_TypeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Charge_TypeBindingNavigatorSaveItem.Name = "Charge_TypeBindingNavigatorSaveItem"
        Me.Charge_TypeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Charge_TypeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'frmChargeType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 374)
        Me.Controls.Add(Me.Charge_TypeBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChargeType"
        Me.Text = "Charge Type"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.Charge_TypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Charge_TypeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Charge_TypeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Charge_TypeBindingNavigator.ResumeLayout(False)
        Me.Charge_TypeBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HotelDataSet As Hotel_Management_System.hotelDataSet
    Friend WithEvents Charge_TypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Charge_TypeTableAdapter As Hotel_Management_System.hotelDataSetTableAdapters.Charge_TypeTableAdapter
    Friend WithEvents TableAdapterManager As Hotel_Management_System.hotelDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Charge_TypeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Charge_TypeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ChargeTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Charge_TypeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
