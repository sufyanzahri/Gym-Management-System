<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddPaymentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPaymentForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Member_IDTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddPaymentDataSet = New GymNew.AddPaymentDataSet()
        Me.Payment_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PaymentTableAdapter = New GymNew.AddPaymentDataSetTableAdapters.PaymentTableAdapter()
        Me.TableAdapterManager = New GymNew.AddPaymentDataSetTableAdapters.TableAdapterManager()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllMembersDataSet = New GymNew.AllMembersDataSet()
        Me.MembersTableAdapter = New GymNew.AllMembersDataSetTableAdapters.MembersTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountOwedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddPaymentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(689, 54)
        Me.Panel1.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(635, 13)
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
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Member_IDTextBox)
        Me.Panel2.Controls.Add(Me.Payment_DateDateTimePicker)
        Me.Panel2.Controls.Add(Me.AmountTextBox)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Location = New System.Drawing.Point(23, 61)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(639, 183)
        Me.Panel2.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(277, 136)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 35)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(422, 136)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(212, 35)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Register Payment"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Member_IDTextBox
        '
        Me.Member_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Member_ID", True))
        Me.Member_IDTextBox.Location = New System.Drawing.Point(144, 62)
        Me.Member_IDTextBox.Name = "Member_IDTextBox"
        Me.Member_IDTextBox.Size = New System.Drawing.Size(38, 20)
        Me.Member_IDTextBox.TabIndex = 14
        '
        'PaymentBindingSource
        '
        Me.PaymentBindingSource.DataMember = "Payment"
        Me.PaymentBindingSource.DataSource = Me.AddPaymentDataSet
        '
        'AddPaymentDataSet
        '
        Me.AddPaymentDataSet.DataSetName = "AddPaymentDataSet"
        Me.AddPaymentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Payment_DateDateTimePicker
        '
        Me.Payment_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PaymentBindingSource, "Payment_Date", True))
        Me.Payment_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Payment_DateDateTimePicker.Location = New System.Drawing.Point(144, 143)
        Me.Payment_DateDateTimePicker.Name = "Payment_DateDateTimePicker"
        Me.Payment_DateDateTimePicker.Size = New System.Drawing.Size(105, 20)
        Me.Payment_DateDateTimePicker.TabIndex = 16
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(144, 101)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(70, 20)
        Me.AmountTextBox.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(3, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Payment Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(62, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Amount: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(36, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Member ID:"
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
        Me.Label2.Text = "Add Payment"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PaymentTableAdapter = Me.PaymentTableAdapter
        Me.TableAdapterManager.UpdateOrder = GymNew.AddPaymentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.MemberNameDataGridViewTextBoxColumn, Me.AmountOwedDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MembersBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(168, 287)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(303, 129)
        Me.DataGridView1.TabIndex = 6
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(187, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(264, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "List of Registered Members"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 40
        '
        'MemberNameDataGridViewTextBoxColumn
        '
        Me.MemberNameDataGridViewTextBoxColumn.DataPropertyName = "Member_Name"
        Me.MemberNameDataGridViewTextBoxColumn.HeaderText = "Member_Name"
        Me.MemberNameDataGridViewTextBoxColumn.Name = "MemberNameDataGridViewTextBoxColumn"
        Me.MemberNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemberNameDataGridViewTextBoxColumn.Width = 200
        '
        'AmountOwedDataGridViewTextBoxColumn
        '
        Me.AmountOwedDataGridViewTextBoxColumn.DataPropertyName = "Amount_Owed"
        Me.AmountOwedDataGridViewTextBoxColumn.HeaderText = "Package Amount"
        Me.AmountOwedDataGridViewTextBoxColumn.Name = "AmountOwedDataGridViewTextBoxColumn"
        Me.AmountOwedDataGridViewTextBoxColumn.ReadOnly = True
        Me.AmountOwedDataGridViewTextBoxColumn.Width = 60
        '
        'AddPaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 428)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddPaymentForm"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddPaymentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllMembersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AddPaymentDataSet As AddPaymentDataSet
    Friend WithEvents PaymentBindingSource As BindingSource
    Friend WithEvents PaymentTableAdapter As AddPaymentDataSetTableAdapters.PaymentTableAdapter
    Friend WithEvents TableAdapterManager As AddPaymentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Member_IDTextBox As TextBox
    Friend WithEvents Payment_DateDateTimePicker As DateTimePicker
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AllMembersDataSet As AllMembersDataSet
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents MembersTableAdapter As AllMembersDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountOwedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
End Class
