<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllMembersForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AllMembersForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvMembers = New System.Windows.Forms.DataGridView()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllMembersDataSet = New GymNew.AllMembersDataSet()
        Me.MembersTableAdapter = New GymNew.AllMembersDataSetTableAdapters.MembersTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberPackageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateJoinedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_Expired = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount_Owed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllMembersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(691, 54)
        Me.Panel1.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(636, 12)
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
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.dgvMembers)
        Me.Panel2.Location = New System.Drawing.Point(0, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(688, 322)
        Me.Panel2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(3, 281)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 35)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(545, 281)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(138, 35)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "View/Edit Members"
        '
        'dgvMembers
        '
        Me.dgvMembers.AllowUserToAddRows = False
        Me.dgvMembers.AllowUserToDeleteRows = False
        Me.dgvMembers.AutoGenerateColumns = False
        Me.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.MemberNameDataGridViewTextBoxColumn, Me.MemberPackageDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.DateJoinedDataGridViewTextBoxColumn, Me.Date_Expired, Me.Amount_Owed})
        Me.dgvMembers.DataSource = Me.MembersBindingSource
        Me.dgvMembers.Location = New System.Drawing.Point(3, 56)
        Me.dgvMembers.Name = "dgvMembers"
        Me.dgvMembers.Size = New System.Drawing.Size(675, 218)
        Me.dgvMembers.TabIndex = 5
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.AllMembersDataSet
        '
        'AllMembersDataSet
        '
        Me.AllMembersDataSet.DataSetName = "AllMembersDataSet"
        Me.AllMembersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 30
        '
        'MemberNameDataGridViewTextBoxColumn
        '
        Me.MemberNameDataGridViewTextBoxColumn.DataPropertyName = "Member_Name"
        Me.MemberNameDataGridViewTextBoxColumn.HeaderText = "Member_Name"
        Me.MemberNameDataGridViewTextBoxColumn.Name = "MemberNameDataGridViewTextBoxColumn"
        Me.MemberNameDataGridViewTextBoxColumn.Width = 170
        '
        'MemberPackageDataGridViewTextBoxColumn
        '
        Me.MemberPackageDataGridViewTextBoxColumn.DataPropertyName = "Member_Package"
        Me.MemberPackageDataGridViewTextBoxColumn.HeaderText = "Months"
        Me.MemberPackageDataGridViewTextBoxColumn.Name = "MemberPackageDataGridViewTextBoxColumn"
        Me.MemberPackageDataGridViewTextBoxColumn.Width = 50
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'DateJoinedDataGridViewTextBoxColumn
        '
        Me.DateJoinedDataGridViewTextBoxColumn.DataPropertyName = "Date_Joined"
        Me.DateJoinedDataGridViewTextBoxColumn.HeaderText = "Date_Joined"
        Me.DateJoinedDataGridViewTextBoxColumn.Name = "DateJoinedDataGridViewTextBoxColumn"
        '
        'Date_Expired
        '
        Me.Date_Expired.DataPropertyName = "Date_Expired"
        Me.Date_Expired.HeaderText = "Date_Expired"
        Me.Date_Expired.Name = "Date_Expired"
        '
        'Amount_Owed
        '
        Me.Amount_Owed.DataPropertyName = "Amount_Owed"
        Me.Amount_Owed.HeaderText = "Package Amount"
        Me.Amount_Owed.Name = "Amount_Owed"
        '
        'AllMembersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 391)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AllMembersForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllMembersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvMembers As DataGridView
    Friend WithEvents AllMembersDataSet As AllMembersDataSet
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents MembersTableAdapter As AllMembersDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberPackageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateJoinedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Date_Expired As DataGridViewTextBoxColumn
    Friend WithEvents Amount_Owed As DataGridViewTextBoxColumn
End Class
