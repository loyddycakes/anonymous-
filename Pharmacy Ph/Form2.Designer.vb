<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DistributionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.RegistrationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DistributorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StockIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicineCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicineNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VitaminTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CartonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PacketsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPacketsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PMSRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PMS_FileDataSet = New Pharmacy_Ph.PMS_FileDataSet()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PMS_RecordTableAdapter = New Pharmacy_Ph.PMS_FileDataSetTableAdapters.PMS_RecordTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMSRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMS_FileDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsersToolStripMenuItem, Me.DistributionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(826, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrationToolStripMenuItem})
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'RegistrationToolStripMenuItem
        '
        Me.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        Me.RegistrationToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RegistrationToolStripMenuItem.Text = "Registration"
        '
        'DistributionToolStripMenuItem
        '
        Me.DistributionToolStripMenuItem.Name = "DistributionToolStripMenuItem"
        Me.DistributionToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.DistributionToolStripMenuItem.Text = "Distribution"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(826, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(56, 17)
        Me.ToolStripStatusLabel1.Text = "Login As:"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Image = CType(resources.GetObject("ToolStripStatusLabel2.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(135, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(501, 17)
        Me.ToolStripStatusLabel3.Spring = True
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel4.Text = "ToolStripStatusLabel4"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrationToolStripMenuItem1, Me.DistributorToolStripMenuItem, Me.VendorToolStripMenuItem, Me.MedicToolStripMenuItem, Me.StockToolStripMenuItem, Me.InvoiceToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(826, 24)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'RegistrationToolStripMenuItem1
        '
        Me.RegistrationToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RegistrationToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SignUpToolStripMenuItem})
        Me.RegistrationToolStripMenuItem1.Image = CType(resources.GetObject("RegistrationToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.RegistrationToolStripMenuItem1.Name = "RegistrationToolStripMenuItem1"
        Me.RegistrationToolStripMenuItem1.Size = New System.Drawing.Size(98, 20)
        Me.RegistrationToolStripMenuItem1.Text = "Registration"
        '
        'SignUpToolStripMenuItem
        '
        Me.SignUpToolStripMenuItem.Name = "SignUpToolStripMenuItem"
        Me.SignUpToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SignUpToolStripMenuItem.Text = "Sign-Up"
        '
        'DistributorToolStripMenuItem
        '
        Me.DistributorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DistributorToolStripMenuItem.Image = CType(resources.GetObject("DistributorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DistributorToolStripMenuItem.Name = "DistributorToolStripMenuItem"
        Me.DistributorToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.DistributorToolStripMenuItem.Text = "Distributor"
        '
        'VendorToolStripMenuItem
        '
        Me.VendorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VendorToolStripMenuItem.Image = CType(resources.GetObject("VendorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VendorToolStripMenuItem.Name = "VendorToolStripMenuItem"
        Me.VendorToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.VendorToolStripMenuItem.Text = "Vendor"
        '
        'MedicToolStripMenuItem
        '
        Me.MedicToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MedicToolStripMenuItem.Image = CType(resources.GetObject("MedicToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MedicToolStripMenuItem.Name = "MedicToolStripMenuItem"
        Me.MedicToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.MedicToolStripMenuItem.Text = "Medicine"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.StockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockEntryToolStripMenuItem})
        Me.StockToolStripMenuItem.Image = CType(resources.GetObject("StockToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'StockEntryToolStripMenuItem
        '
        Me.StockEntryToolStripMenuItem.Name = "StockEntryToolStripMenuItem"
        Me.StockEntryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StockEntryToolStripMenuItem.Text = "Stock Entry "
        '
        'InvoiceToolStripMenuItem
        '
        Me.InvoiceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.InvoiceToolStripMenuItem.Image = CType(resources.GetObject("InvoiceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InvoiceToolStripMenuItem.Name = "InvoiceToolStripMenuItem"
        Me.InvoiceToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.InvoiceToolStripMenuItem.Text = "Invoice"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StockIdDataGridViewTextBoxColumn, Me.MedicineCodeDataGridViewTextBoxColumn, Me.MedicineNameDataGridViewTextBoxColumn, Me.VitaminTypeDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.StockDateDataGridViewTextBoxColumn, Me.CartonDataGridViewTextBoxColumn, Me.PacketsDataGridViewTextBoxColumn, Me.TotalPacketsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PMSRecordBindingSource
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.Location = New System.Drawing.Point(22, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(782, 343)
        Me.DataGridView1.TabIndex = 3
        '
        'StockIdDataGridViewTextBoxColumn
        '
        Me.StockIdDataGridViewTextBoxColumn.DataPropertyName = "StockId"
        Me.StockIdDataGridViewTextBoxColumn.HeaderText = "Stock Id"
        Me.StockIdDataGridViewTextBoxColumn.Name = "StockIdDataGridViewTextBoxColumn"
        '
        'MedicineCodeDataGridViewTextBoxColumn
        '
        Me.MedicineCodeDataGridViewTextBoxColumn.DataPropertyName = "MedicineCode"
        Me.MedicineCodeDataGridViewTextBoxColumn.HeaderText = "Medicine Code"
        Me.MedicineCodeDataGridViewTextBoxColumn.Name = "MedicineCodeDataGridViewTextBoxColumn"
        '
        'MedicineNameDataGridViewTextBoxColumn
        '
        Me.MedicineNameDataGridViewTextBoxColumn.DataPropertyName = "MedicineName"
        Me.MedicineNameDataGridViewTextBoxColumn.HeaderText = "Medicine Name"
        Me.MedicineNameDataGridViewTextBoxColumn.Name = "MedicineNameDataGridViewTextBoxColumn"
        '
        'VitaminTypeDataGridViewTextBoxColumn
        '
        Me.VitaminTypeDataGridViewTextBoxColumn.DataPropertyName = "VitaminType"
        Me.VitaminTypeDataGridViewTextBoxColumn.HeaderText = "Vitamin Type"
        Me.VitaminTypeDataGridViewTextBoxColumn.Name = "VitaminTypeDataGridViewTextBoxColumn"
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "Weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "Weight"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        '
        'StockDateDataGridViewTextBoxColumn
        '
        Me.StockDateDataGridViewTextBoxColumn.DataPropertyName = "StockDate"
        Me.StockDateDataGridViewTextBoxColumn.HeaderText = "Stock Date"
        Me.StockDateDataGridViewTextBoxColumn.Name = "StockDateDataGridViewTextBoxColumn"
        '
        'CartonDataGridViewTextBoxColumn
        '
        Me.CartonDataGridViewTextBoxColumn.DataPropertyName = "Carton"
        Me.CartonDataGridViewTextBoxColumn.HeaderText = "Carton"
        Me.CartonDataGridViewTextBoxColumn.Name = "CartonDataGridViewTextBoxColumn"
        '
        'PacketsDataGridViewTextBoxColumn
        '
        Me.PacketsDataGridViewTextBoxColumn.DataPropertyName = "Packets"
        Me.PacketsDataGridViewTextBoxColumn.HeaderText = "Packets"
        Me.PacketsDataGridViewTextBoxColumn.Name = "PacketsDataGridViewTextBoxColumn"
        '
        'TotalPacketsDataGridViewTextBoxColumn
        '
        Me.TotalPacketsDataGridViewTextBoxColumn.DataPropertyName = "TotalPackets"
        Me.TotalPacketsDataGridViewTextBoxColumn.HeaderText = "Total Packets"
        Me.TotalPacketsDataGridViewTextBoxColumn.Name = "TotalPacketsDataGridViewTextBoxColumn"
        '
        'PMSRecordBindingSource
        '
        Me.PMSRecordBindingSource.DataMember = "PMS_Record"
        Me.PMSRecordBindingSource.DataSource = Me.PMS_FileDataSet
        '
        'PMS_FileDataSet
        '
        Me.PMS_FileDataSet.DataSetName = "PMS_FileDataSet"
        Me.PMS_FileDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(110, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PMS_RecordTableAdapter
        '
        Me.PMS_RecordTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Stock"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMSRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMS_FileDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DistributionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents RegistrationToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DistributorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvoiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents PMS_FileDataSet As PMS_FileDataSet
    Friend WithEvents PMSRecordBindingSource As BindingSource
    Friend WithEvents PMS_RecordTableAdapter As PMS_FileDataSetTableAdapters.PMS_RecordTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents StockIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicineCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicineNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VitaminTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CartonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PacketsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPacketsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SignUpToolStripMenuItem As ToolStripMenuItem
End Class
