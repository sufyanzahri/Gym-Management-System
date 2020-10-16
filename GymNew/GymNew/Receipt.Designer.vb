<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReceiptForm
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
        Dim Member_NameLabel As System.Windows.Forms.Label
        Dim Member_PackageLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim Date_JoinedLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim Date_ExpiredLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReceiptForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.comboID = New System.Windows.Forms.ComboBox()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllMembersDataSet = New GymNew.AllMembersDataSet()
        Me.MembersTableAdapter = New GymNew.AllMembersDataSetTableAdapters.MembersTableAdapter()
        Me.TableAdapterManager = New GymNew.AllMembersDataSetTableAdapters.TableAdapterManager()
        Me.Member_NameLabel1 = New System.Windows.Forms.Label()
        Me.Member_PackageLabel1 = New System.Windows.Forms.Label()
        Me.PhoneLabel1 = New System.Windows.Forms.Label()
        Me.Date_JoinedLabel1 = New System.Windows.Forms.Label()
        Me.IDLabel1 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Date_ExpiredLabel1 = New System.Windows.Forms.Label()
        Member_NameLabel = New System.Windows.Forms.Label()
        Member_PackageLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        Date_JoinedLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        Date_ExpiredLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllMembersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Member_NameLabel
        '
        Member_NameLabel.AutoSize = True
        Member_NameLabel.Location = New System.Drawing.Point(60, 290)
        Member_NameLabel.Name = "Member_NameLabel"
        Member_NameLabel.Size = New System.Drawing.Size(79, 13)
        Member_NameLabel.TabIndex = 13
        Member_NameLabel.Text = "Member Name:"
        '
        'Member_PackageLabel
        '
        Member_PackageLabel.AutoSize = True
        Member_PackageLabel.Location = New System.Drawing.Point(94, 323)
        Member_PackageLabel.Name = "Member_PackageLabel"
        Member_PackageLabel.Size = New System.Drawing.Size(45, 13)
        Member_PackageLabel.TabIndex = 14
        Member_PackageLabel.Text = "Months:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(75, 355)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(64, 13)
        PhoneLabel.TabIndex = 15
        PhoneLabel.Text = "Contact No:"
        '
        'Date_JoinedLabel
        '
        Date_JoinedLabel.AutoSize = True
        Date_JoinedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_JoinedLabel.Location = New System.Drawing.Point(352, 299)
        Date_JoinedLabel.Name = "Date_JoinedLabel"
        Date_JoinedLabel.Size = New System.Drawing.Size(79, 13)
        Date_JoinedLabel.TabIndex = 16
        Date_JoinedLabel.Text = "Date Joined:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(77, 258)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(62, 13)
        IDLabel.TabIndex = 17
        IDLabel.Text = "Member ID:"
        '
        'Date_ExpiredLabel
        '
        Date_ExpiredLabel.AutoSize = True
        Date_ExpiredLabel.Location = New System.Drawing.Point(360, 258)
        Date_ExpiredLabel.Name = "Date_ExpiredLabel"
        Date_ExpiredLabel.Size = New System.Drawing.Size(71, 13)
        Date_ExpiredLabel.TabIndex = 25
        Date_ExpiredLabel.Text = "Invoice Date:"
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
        Me.Panel1.Size = New System.Drawing.Size(634, 54)
        Me.Panel1.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(579, 8)
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
        Me.Label1.Size = New System.Drawing.Size(224, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Muscle Cage Gym"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(245, 154)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'comboID
        '
        Me.comboID.DataSource = Me.MembersBindingSource
        Me.comboID.DisplayMember = "ID"
        Me.comboID.FormattingEnabled = True
        Me.comboID.Location = New System.Drawing.Point(265, 106)
        Me.comboID.Name = "comboID"
        Me.comboID.Size = New System.Drawing.Size(38, 21)
        Me.comboID.TabIndex = 13
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MembersTableAdapter = Me.MembersTableAdapter
        Me.TableAdapterManager.UpdateOrder = GymNew.AllMembersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Member_NameLabel1
        '
        Me.Member_NameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Member_NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Member_Name", True))
        Me.Member_NameLabel1.Location = New System.Drawing.Point(145, 280)
        Me.Member_NameLabel1.Name = "Member_NameLabel1"
        Me.Member_NameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Member_NameLabel1.TabIndex = 14
        '
        'Member_PackageLabel1
        '
        Me.Member_PackageLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Member_PackageLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Member_Package", True))
        Me.Member_PackageLabel1.Location = New System.Drawing.Point(145, 313)
        Me.Member_PackageLabel1.Name = "Member_PackageLabel1"
        Me.Member_PackageLabel1.Size = New System.Drawing.Size(33, 23)
        Me.Member_PackageLabel1.TabIndex = 15
        '
        'PhoneLabel1
        '
        Me.PhoneLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PhoneLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Phone", True))
        Me.PhoneLabel1.Location = New System.Drawing.Point(145, 345)
        Me.PhoneLabel1.Name = "PhoneLabel1"
        Me.PhoneLabel1.Size = New System.Drawing.Size(100, 23)
        Me.PhoneLabel1.TabIndex = 16
        '
        'Date_JoinedLabel1
        '
        Me.Date_JoinedLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Date_JoinedLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Date_Joined", True))
        Me.Date_JoinedLabel1.Location = New System.Drawing.Point(442, 289)
        Me.Date_JoinedLabel1.Name = "Date_JoinedLabel1"
        Me.Date_JoinedLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Date_JoinedLabel1.TabIndex = 17
        Me.Date_JoinedLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IDLabel1
        '
        Me.IDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "ID", True))
        Me.IDLabel1.Location = New System.Drawing.Point(145, 248)
        Me.IDLabel1.Name = "IDLabel1"
        Me.IDLabel1.Size = New System.Drawing.Size(33, 23)
        Me.IDLabel1.TabIndex = 18
        '
        'lblTime
        '
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTime.Location = New System.Drawing.Point(442, 248)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(100, 23)
        Me.lblTime.TabIndex = 19
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Gray
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(12, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(201, 34)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Service Invoice"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(199, 99)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "A-G-11 , Glomac Damansara " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bukit Kiara" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "60000 Kuala Lumpur " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "musclecage@gmail." &
    "com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "01137998750"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(-3, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(637, 11)
        Me.Label2.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(335, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Expiry Date :"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(77, 382)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(465, 33)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "THANK YOU FOR CHOOSING US "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(372, 67)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(242, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Date_ExpiredLabel1
        '
        Me.Date_ExpiredLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Date_ExpiredLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Date_Expired", True))
        Me.Date_ExpiredLabel1.Location = New System.Drawing.Point(442, 329)
        Me.Date_ExpiredLabel1.Name = "Date_ExpiredLabel1"
        Me.Date_ExpiredLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Date_ExpiredLabel1.TabIndex = 26
        Me.Date_ExpiredLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReceiptForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 435)
        Me.Controls.Add(Date_ExpiredLabel)
        Me.Controls.Add(Me.Date_ExpiredLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDLabel1)
        Me.Controls.Add(Date_JoinedLabel)
        Me.Controls.Add(Me.Date_JoinedLabel1)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneLabel1)
        Me.Controls.Add(Member_PackageLabel)
        Me.Controls.Add(Me.Member_PackageLabel1)
        Me.Controls.Add(Member_NameLabel)
        Me.Controls.Add(Me.Member_NameLabel1)
        Me.Controls.Add(Me.comboID)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReceiptForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllMembersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents comboID As ComboBox
    Friend WithEvents AllMembersDataSet As AllMembersDataSet
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents MembersTableAdapter As AllMembersDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents Date_JoinedLabel1 As Label
    Friend WithEvents PhoneLabel1 As Label
    Friend WithEvents Member_PackageLabel1 As Label
    Friend WithEvents Member_NameLabel1 As Label
    Friend WithEvents TableAdapterManager As AllMembersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDLabel1 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Date_ExpiredLabel1 As Label
End Class
