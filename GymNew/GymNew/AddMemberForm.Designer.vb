<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddMemberForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddMemberForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.upDownMonths = New System.Windows.Forms.NumericUpDown()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Member_txtAmountOwed = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDateExpired = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Member_NameTextBox = New System.Windows.Forms.TextBox()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllMembersDataSet = New GymNew.AllMembersDataSet()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Date_JoinedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MembersTableAdapter = New GymNew.AllMembersDataSetTableAdapters.MembersTableAdapter()
        Me.TableAdapterManager = New GymNew.AllMembersDataSetTableAdapters.TableAdapterManager()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.upDownMonths, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 3
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
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.upDownMonths)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.Member_txtAmountOwed)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.lblDateExpired)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Member_NameTextBox)
        Me.Panel2.Controls.Add(Me.PhoneTextBox)
        Me.Panel2.Controls.Add(Me.Date_JoinedDateTimePicker)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Location = New System.Drawing.Point(8, 61)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(671, 204)
        Me.Panel2.TabIndex = 4
        '
        'upDownMonths
        '
        Me.upDownMonths.Location = New System.Drawing.Point(503, 62)
        Me.upDownMonths.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.upDownMonths.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.upDownMonths.Name = "upDownMonths"
        Me.upDownMonths.Size = New System.Drawing.Size(56, 20)
        Me.upDownMonths.TabIndex = 33
        Me.upDownMonths.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(317, 163)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 35)
        Me.btnClear.TabIndex = 31
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Member_txtAmountOwed
        '
        Me.Member_txtAmountOwed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Member_txtAmountOwed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Member_txtAmountOwed.Location = New System.Drawing.Point(503, 89)
        Me.Member_txtAmountOwed.Name = "Member_txtAmountOwed"
        Me.Member_txtAmountOwed.Size = New System.Drawing.Size(73, 19)
        Me.Member_txtAmountOwed.TabIndex = 30
        Me.Member_txtAmountOwed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(411, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 20)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Amount:"
        '
        'lblDateExpired
        '
        Me.lblDateExpired.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateExpired.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDateExpired.Location = New System.Drawing.Point(148, 156)
        Me.lblDateExpired.Name = "lblDateExpired"
        Me.lblDateExpired.Size = New System.Drawing.Size(100, 23)
        Me.lblDateExpired.TabIndex = 28
        Me.lblDateExpired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(454, 163)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(212, 35)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Register Member"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(4, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 20)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Date Expired : "
        '
        'Member_NameTextBox
        '
        Me.Member_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Member_Name", True))
        Me.Member_NameTextBox.Location = New System.Drawing.Point(149, 62)
        Me.Member_NameTextBox.Name = "Member_NameTextBox"
        Me.Member_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Member_NameTextBox.TabIndex = 15
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
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(149, 101)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PhoneTextBox.TabIndex = 19
        '
        'Date_JoinedDateTimePicker
        '
        Me.Date_JoinedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MembersBindingSource, "Date_Joined", True))
        Me.Date_JoinedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_JoinedDateTimePicker.Location = New System.Drawing.Point(149, 130)
        Me.Date_JoinedDateTimePicker.Name = "Date_JoinedDateTimePicker"
        Me.Date_JoinedDateTimePicker.Size = New System.Drawing.Size(99, 20)
        Me.Date_JoinedDateTimePicker.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(11, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Date Joined :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(414, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Months:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(60, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Phone :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(65, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Name :"
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
        Me.Label2.Text = "Add Member"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MembersTableAdapter = Me.MembersTableAdapter
        Me.TableAdapterManager.UpdateOrder = GymNew.AllMembersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(418, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 41)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "1 month = RM100 monthly" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "6 months && above = 90 monthly" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "12 months = 85 monthly"
        '
        'AddMemberForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 282)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddMemberForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Member"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.upDownMonths, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllMembersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AllMembersDataSet As AllMembersDataSet
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents MembersTableAdapter As AllMembersDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents TableAdapterManager As AllMembersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Member_NameTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents Date_JoinedDateTimePicker As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblDateExpired As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Member_txtAmountOwed As Label
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents btnClear As Button
    Friend WithEvents upDownMonths As NumericUpDown
    Friend WithEvents Label9 As Label
End Class
