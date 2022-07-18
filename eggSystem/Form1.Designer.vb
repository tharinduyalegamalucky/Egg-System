<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.ComboCompany = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboLocation = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.ComboCategory = New System.Windows.Forms.ComboBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.EggDataSet = New eggSystem.EggDataSet()
        Me.EggBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EggTableAdapter = New eggSystem.EggDataSetTableAdapters.eggTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EggcategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EggDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EggBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Black
        Me.ProgressBar1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ProgressBar1.Location = New System.Drawing.Point(-8, -3)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(897, 70)
        Me.ProgressBar1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SA No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(473, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Company"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(473, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Location"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Remark"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(443, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Qty"
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(112, 97)
        Me.txtno.Name = "txtno"
        Me.txtno.ReadOnly = True
        Me.txtno.Size = New System.Drawing.Size(95, 22)
        Me.txtno.TabIndex = 7
        Me.txtno.TabStop = False
        '
        'ComboCompany
        '
        Me.ComboCompany.FormattingEnabled = True
        Me.ComboCompany.Items.AddRange(New Object() {"FARMS PRIDE (PVT) LTD.", "MIDLAND BREEDERS (PVT) LTD.", "GOLDEN GRAINS (PVT) LTD.", "HARE PARK DAIRY (PVT) LTD.", "CONSOLIDATED", "ALTRA GUARD", "WAYAMBA DEVELOPMENT (PVT) LTD", "FORTUNE AGRO INDUSTRIES (PVT) LTD", "CASUAL WAGES - PPL", "CRYSBRO AUTO SERVICE"})
        Me.ComboCompany.Location = New System.Drawing.Point(575, 97)
        Me.ComboCompany.Name = "ComboCompany"
        Me.ComboCompany.Size = New System.Drawing.Size(249, 24)
        Me.ComboCompany.TabIndex = 8
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(112, 162)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 9
        '
        'ComboLocation
        '
        Me.ComboLocation.FormattingEnabled = True
        Me.ComboLocation.Items.AddRange(New Object() {"#272, JAYAMALAPURA,GAMPOLA", "#272, JAYAMALAPURA,GAMPOLA", "#272, JAYAMALAPURA,GAMPOLA", "#272, JAYAMALAPURA,GAMPOLA", "#272, JAYAMALAPURA,GAMPOLA", "#272, JAYAMALAPURA,GAMPOLA", "#272, JAYAMALAPURA,GAMPOLA", "#272, JAYAMALAPURA,GAMPOLA", "#272, JAYAMALAPURA,GAMPOLA", "#272, JAYAMALAPURA,GAMPOLA"})
        Me.ComboLocation.Location = New System.Drawing.Point(575, 164)
        Me.ComboLocation.Name = "ComboLocation"
        Me.ComboLocation.Size = New System.Drawing.Size(249, 24)
        Me.ComboLocation.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Egg Category"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(109, 208)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(712, 75)
        Me.txtRemark.TabIndex = 12
        '
        'ComboCategory
        '
        Me.ComboCategory.FormattingEnabled = True
        Me.ComboCategory.Items.AddRange(New Object() {"DAMAGED - FARM", "DIRTY - FARM", "MISSHAPEN - FARM", "SMALL - FARM", "THIN SHELL", "DISCARD", "DOUBLE YOLK", "TRANSPORT DAMAGE", "HATCHERY DAMAGE", "FARM DAMAGE - HATCHERY", "MISSHAPEN - HATCHERY", "DIRTY - HATCHERY", "< 50", "CONSUMPTION", "DAMAGED FARM (H/O)", "DAMAGED HATCHERY (H/O)", "NONE - HATCHABLE", "DISCARD H/O", "SMALL - HATCHERY", "SMALL - H/O", "HATCHABLE EGGS"})
        Me.ComboCategory.Location = New System.Drawing.Point(169, 324)
        Me.ComboCategory.Name = "ComboCategory"
        Me.ComboCategory.Size = New System.Drawing.Size(249, 24)
        Me.ComboCategory.TabIndex = 13
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(495, 328)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(172, 22)
        Me.txtQty.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(710, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 46)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.EggcategoryDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EggBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(34, 364)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(787, 150)
        Me.DataGridView1.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(34, 529)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 46)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(400, 529)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 46)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "NEW"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(556, 529)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 46)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "SAVE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(700, 529)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(111, 46)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "EXIT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'EggDataSet
        '
        Me.EggDataSet.DataSetName = "EggDataSet"
        Me.EggDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EggBindingSource
        '
        Me.EggBindingSource.DataMember = "egg"
        Me.EggBindingSource.DataSource = Me.EggDataSet
        '
        'EggTableAdapter
        '
        Me.EggTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 125
        '
        'EggcategoryDataGridViewTextBoxColumn
        '
        Me.EggcategoryDataGridViewTextBoxColumn.DataPropertyName = "Eggcategory"
        Me.EggcategoryDataGridViewTextBoxColumn.HeaderText = "Eggcategory"
        Me.EggcategoryDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EggcategoryDataGridViewTextBoxColumn.Name = "EggcategoryDataGridViewTextBoxColumn"
        Me.EggcategoryDataGridViewTextBoxColumn.Width = 300
        '
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "Qty"
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "Qty"
        Me.QtyDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        Me.QtyDataGridViewTextBoxColumn.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 587)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.ComboCategory)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboLocation)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboCompany)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EggDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EggBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtno As TextBox
    Friend WithEvents ComboCompany As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboLocation As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents ComboCategory As ComboBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents EggDataSet As EggDataSet
    Friend WithEvents EggBindingSource As BindingSource
    Friend WithEvents EggTableAdapter As EggDataSetTableAdapters.eggTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EggcategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
