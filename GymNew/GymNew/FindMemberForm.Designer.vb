<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FindMemberForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FindMemberForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvMembers = New System.Windows.Forms.DataGridView()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FindMembersDataSet = New GymNew.FindMembersDataSet()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MembersTableAdapter = New GymNew.FindMembersDataSetTableAdapters.MembersTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberPackageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateJoinedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateExpiredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FindMembersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.Panel1.TabIndex = 3
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
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(345, 372)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 5
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGo.ForeColor = System.Drawing.Color.White
        Me.btnGo.Location = New System.Drawing.Point(451, 357)
        Me.btnGo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(212, 35)
        Me.btnGo.TabIndex = 6
        Me.btnGo.Text = "Search By Name"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search Members"
        '
        'dgvMembers
        '
        Me.dgvMembers.AllowUserToAddRows = False
        Me.dgvMembers.AllowUserToDeleteRows = False
        Me.dgvMembers.AutoGenerateColumns = False
        Me.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.MemberNameDataGridViewTextBoxColumn, Me.MemberPackageDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.DateJoinedDataGridViewTextBoxColumn, Me.DateExpiredDataGridViewTextBoxColumn})
        Me.dgvMembers.DataSource = Me.MembersBindingSource
        Me.dgvMembers.Location = New System.Drawing.Point(18, 58)
        Me.dgvMembers.Name = "dgvMembers"
        Me.dgvMembers.ReadOnly = True
        Me.dgvMembers.RowHeadersVisible = False
        Me.dgvMembers.Size = New System.Drawing.Size(594, 219)
        Me.dgvMembers.TabIndex = 7
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.FindMembersDataSet
        '
        'FindMembersDataSet
        '
        Me.FindMembersDataSet.DataSetName = "FindMembersDataSet"
        Me.FindMembersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.dgvMembers)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(12, 61)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(651, 289)
        Me.Panel2.TabIndex = 4
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
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 30
        '
        'MemberNameDataGridViewTextBoxColumn
        '
        Me.MemberNameDataGridViewTextBoxColumn.DataPropertyName = "Member_Name"
        Me.MemberNameDataGridViewTextBoxColumn.HeaderText = "Member_Name"
        Me.MemberNameDataGridViewTextBoxColumn.Name = "MemberNameDataGridViewTextBoxColumn"
        Me.MemberNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemberNameDataGridViewTextBoxColumn.Width = 200
        '
        'MemberPackageDataGridViewTextBoxColumn
        '
        Me.MemberPackageDataGridViewTextBoxColumn.DataPropertyName = "Member_Package"
        Me.MemberPackageDataGridViewTextBoxColumn.HeaderText = "Months"
        Me.MemberPackageDataGridViewTextBoxColumn.Name = "MemberPackageDataGridViewTextBoxColumn"
        Me.MemberPackageDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemberPackageDataGridViewTextBoxColumn.Width = 60
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateJoinedDataGridViewTextBoxColumn
        '
        Me.DateJoinedDataGridViewTextBoxColumn.DataPropertyName = "Date_Joined"
        Me.DateJoinedDataGridViewTextBoxColumn.HeaderText = "Date_Joined"
        Me.DateJoinedDataGridViewTextBoxColumn.Name = "DateJoinedDataGridViewTextBoxColumn"
        Me.DateJoinedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateExpiredDataGridViewTextBoxColumn
        '
        Me.DateExpiredDataGridViewTextBoxColumn.DataPropertyName = "Date_Expired"
        Me.DateExpiredDataGridViewTextBoxColumn.HeaderText = "Date_Expired"
        Me.DateExpiredDataGridViewTextBoxColumn.Name = "DateExpiredDataGridViewTextBoxColumn"
        Me.DateExpiredDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FindMemberForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 398)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FindMemberForm"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FindMembersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents btnGo As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvMembers As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FindMembersDataSet As FindMembersDataSet
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents MembersTableAdapter As FindMembersDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberPackageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateJoinedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateExpiredDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
