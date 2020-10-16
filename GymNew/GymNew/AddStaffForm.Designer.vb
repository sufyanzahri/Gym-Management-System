<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddStaffForm
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
        Dim Staff_NameLabel As System.Windows.Forms.Label
        Dim Staff_PositionLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Date_JoinedLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddStaffForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Staff_NameTextBox = New System.Windows.Forms.TextBox()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllStaffDataSet = New GymNew.AllStaffDataSet()
        Me.Staff_PositionTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Date_JoinedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StaffTableAdapter = New GymNew.AllStaffDataSetTableAdapters.StaffTableAdapter()
        Me.TableAdapterManager = New GymNew.AllStaffDataSetTableAdapters.TableAdapterManager()
        Me.btnClear = New System.Windows.Forms.Button()
        Staff_NameLabel = New System.Windows.Forms.Label()
        Staff_PositionLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Date_JoinedLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllStaffDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Staff_NameLabel
        '
        Staff_NameLabel.AutoSize = True
        Staff_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Staff_NameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Staff_NameLabel.Location = New System.Drawing.Point(31, 75)
        Staff_NameLabel.Name = "Staff_NameLabel"
        Staff_NameLabel.Size = New System.Drawing.Size(94, 20)
        Staff_NameLabel.TabIndex = 13
        Staff_NameLabel.Text = "Staff Name:"
        '
        'Staff_PositionLabel
        '
        Staff_PositionLabel.AutoSize = True
        Staff_PositionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Staff_PositionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Staff_PositionLabel.Location = New System.Drawing.Point(17, 107)
        Staff_PositionLabel.Name = "Staff_PositionLabel"
        Staff_PositionLabel.Size = New System.Drawing.Size(108, 20)
        Staff_PositionLabel.TabIndex = 15
        Staff_PositionLabel.Text = "Staff Position:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        PhoneLabel.Location = New System.Drawing.Point(66, 139)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(59, 20)
        PhoneLabel.TabIndex = 17
        PhoneLabel.Text = "Phone:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        AddressLabel.Location = New System.Drawing.Point(53, 171)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(72, 20)
        AddressLabel.TabIndex = 19
        AddressLabel.Text = "Address:"
        '
        'Date_JoinedLabel
        '
        Date_JoinedLabel.AutoSize = True
        Date_JoinedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_JoinedLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Date_JoinedLabel.Location = New System.Drawing.Point(26, 203)
        Date_JoinedLabel.Name = "Date_JoinedLabel"
        Date_JoinedLabel.Size = New System.Drawing.Size(99, 20)
        Date_JoinedLabel.TabIndex = 21
        Date_JoinedLabel.Text = "Date Joined:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(691, 54)
        Me.Panel1.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(627, 12)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(52, 33)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Tag = "btnClose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Gym Management System"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Staff_NameLabel)
        Me.Panel2.Controls.Add(Me.Staff_NameTextBox)
        Me.Panel2.Controls.Add(Staff_PositionLabel)
        Me.Panel2.Controls.Add(Me.Staff_PositionTextBox)
        Me.Panel2.Controls.Add(PhoneLabel)
        Me.Panel2.Controls.Add(Me.PhoneTextBox)
        Me.Panel2.Controls.Add(AddressLabel)
        Me.Panel2.Controls.Add(Me.AddressTextBox)
        Me.Panel2.Controls.Add(Date_JoinedLabel)
        Me.Panel2.Controls.Add(Me.Date_JoinedDateTimePicker)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.Sienna
        Me.Panel2.Location = New System.Drawing.Point(12, 61)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(667, 282)
        Me.Panel2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(443, 241)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(212, 35)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Register Staff"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Staff_NameTextBox
        '
        Me.Staff_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Staff_Name", True))
        Me.Staff_NameTextBox.Location = New System.Drawing.Point(147, 69)
        Me.Staff_NameTextBox.Name = "Staff_NameTextBox"
        Me.Staff_NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Staff_NameTextBox.TabIndex = 14
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.AllStaffDataSet
        '
        'AllStaffDataSet
        '
        Me.AllStaffDataSet.DataSetName = "AllStaffDataSet"
        Me.AllStaffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Staff_PositionTextBox
        '
        Me.Staff_PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Staff_Position", True))
        Me.Staff_PositionTextBox.Location = New System.Drawing.Point(147, 101)
        Me.Staff_PositionTextBox.Name = "Staff_PositionTextBox"
        Me.Staff_PositionTextBox.Size = New System.Drawing.Size(110, 26)
        Me.Staff_PositionTextBox.TabIndex = 16
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(147, 133)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(110, 26)
        Me.PhoneTextBox.TabIndex = 18
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(147, 165)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(508, 26)
        Me.AddressTextBox.TabIndex = 20
        '
        'Date_JoinedDateTimePicker
        '
        Me.Date_JoinedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffBindingSource, "Date_Joined", True))
        Me.Date_JoinedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_JoinedDateTimePicker.Location = New System.Drawing.Point(147, 198)
        Me.Date_JoinedDateTimePicker.Name = "Date_JoinedDateTimePicker"
        Me.Date_JoinedDateTimePicker.Size = New System.Drawing.Size(142, 26)
        Me.Date_JoinedDateTimePicker.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(4, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Add Staff"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StaffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.UpdateOrder = GymNew.AllStaffDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(147, 239)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 35)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'AddStaffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 349)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddStaffForm"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllStaffDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents AllStaffDataSet As AllStaffDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As AllStaffDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents TableAdapterManager As AllStaffDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaffBindingNavigator As BindingNavigator
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
    Friend WithEvents StaffBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Staff_NameTextBox As TextBox
    Friend WithEvents Staff_PositionTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Date_JoinedDateTimePicker As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents btnClear As Button
End Class
