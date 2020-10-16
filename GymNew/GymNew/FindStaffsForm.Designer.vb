<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindStaffsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FindStaffsForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvMembers = New System.Windows.Forms.DataGridView()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FindStaffsDataSet = New GymNew.FindStaffsDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.StaffTableAdapter = New GymNew.FindStaffsDataSetTableAdapters.StaffTableAdapter()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffPositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateJoinedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FindStaffsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(671, 54)
        Me.Panel1.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(623, 8)
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
        Me.Panel2.Controls.Add(Me.dgvMembers)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(12, 61)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(651, 282)
        Me.Panel2.TabIndex = 5
        '
        'dgvMembers
        '
        Me.dgvMembers.AllowUserToAddRows = False
        Me.dgvMembers.AllowUserToDeleteRows = False
        Me.dgvMembers.AutoGenerateColumns = False
        Me.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffIDDataGridViewTextBoxColumn, Me.StaffNameDataGridViewTextBoxColumn, Me.StaffPositionDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.DateJoinedDataGridViewTextBoxColumn})
        Me.dgvMembers.DataSource = Me.StaffBindingSource
        Me.dgvMembers.Location = New System.Drawing.Point(18, 58)
        Me.dgvMembers.Name = "dgvMembers"
        Me.dgvMembers.ReadOnly = True
        Me.dgvMembers.RowHeadersVisible = False
        Me.dgvMembers.Size = New System.Drawing.Size(603, 219)
        Me.dgvMembers.TabIndex = 7
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.FindStaffsDataSet
        '
        'FindStaffsDataSet
        '
        Me.FindStaffsDataSet.DataSetName = "FindStaffsDataSet"
        Me.FindStaffsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search Staff"
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGo.ForeColor = System.Drawing.Color.White
        Me.btnGo.Location = New System.Drawing.Point(451, 357)
        Me.btnGo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(212, 35)
        Me.btnGo.TabIndex = 8
        Me.btnGo.Text = "Search By Name"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(345, 372)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 7
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff_ID"
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
        Me.StaffIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.StaffIDDataGridViewTextBoxColumn.Width = 40
        '
        'StaffNameDataGridViewTextBoxColumn
        '
        Me.StaffNameDataGridViewTextBoxColumn.DataPropertyName = "Staff_Name"
        Me.StaffNameDataGridViewTextBoxColumn.HeaderText = "Staff_Name"
        Me.StaffNameDataGridViewTextBoxColumn.Name = "StaffNameDataGridViewTextBoxColumn"
        Me.StaffNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.StaffNameDataGridViewTextBoxColumn.Width = 150
        '
        'StaffPositionDataGridViewTextBoxColumn
        '
        Me.StaffPositionDataGridViewTextBoxColumn.DataPropertyName = "Staff_Position"
        Me.StaffPositionDataGridViewTextBoxColumn.HeaderText = "Staff_Position"
        Me.StaffPositionDataGridViewTextBoxColumn.Name = "StaffPositionDataGridViewTextBoxColumn"
        Me.StaffPositionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn.Width = 250
        '
        'DateJoinedDataGridViewTextBoxColumn
        '
        Me.DateJoinedDataGridViewTextBoxColumn.DataPropertyName = "Date_Joined"
        Me.DateJoinedDataGridViewTextBoxColumn.HeaderText = "Date_Joined"
        Me.DateJoinedDataGridViewTextBoxColumn.Name = "DateJoinedDataGridViewTextBoxColumn"
        Me.DateJoinedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FindStaffsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 398)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FindStaffsForm"
        Me.Text = "FindStaffsForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FindStaffsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvMembers As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGo As Button
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents FindStaffsDataSet As FindStaffsDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As FindStaffsDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffPositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateJoinedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
