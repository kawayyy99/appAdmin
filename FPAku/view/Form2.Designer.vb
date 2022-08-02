<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PerpusDBDataSet = New FPAku.PerpusDBDataSet()
        Me.PerpusDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PerpusCRUDDataSet = New FPAku.PerpusCRUDDataSet()
        Me.BIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BIOTableAdapter = New FPAku.PerpusCRUDDataSetTableAdapters.BIOTableAdapter()
        Me.PerpusDBDataSet1 = New FPAku.PerpusDBDataSet()
        Me.PerpusDBDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USERNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMAADMINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerpusDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerpusDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerpusCRUDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerpusDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerpusDBDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(187, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "TAMBAH"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(337, 298)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 51)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "SIMPAN"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(467, 298)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 51)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "HAPUS"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(601, 298)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(109, 51)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "CETAK"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(164, 116)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(134, 22)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(164, 176)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(134, 22)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(164, 229)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(134, 22)
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Uighur", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 46)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "DATA ADMIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "USERNAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "NAMA ADMIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "PASSWORD"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.USERNAMEDataGridViewTextBoxColumn, Me.NAMAADMINDataGridViewTextBoxColumn, Me.PASSDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BIOBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(347, 119)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(441, 130)
        Me.DataGridView1.TabIndex = 12
        '
        'PerpusDBDataSet
        '
        Me.PerpusDBDataSet.DataSetName = "PerpusDBDataSet"
        Me.PerpusDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PerpusDBDataSetBindingSource
        '
        Me.PerpusDBDataSetBindingSource.DataSource = Me.PerpusDBDataSet
        Me.PerpusDBDataSetBindingSource.Position = 0
        '
        'PerpusCRUDDataSet
        '
        Me.PerpusCRUDDataSet.DataSetName = "PerpusCRUDDataSet"
        Me.PerpusCRUDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BIOBindingSource
        '
        Me.BIOBindingSource.DataMember = "BIO"
        Me.BIOBindingSource.DataSource = Me.PerpusCRUDDataSet
        '
        'BIOTableAdapter
        '
        Me.BIOTableAdapter.ClearBeforeFill = True
        '
        'PerpusDBDataSet1
        '
        Me.PerpusDBDataSet1.DataSetName = "PerpusDBDataSet"
        Me.PerpusDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PerpusDBDataSet1BindingSource
        '
        Me.PerpusDBDataSet1BindingSource.DataSource = Me.PerpusDBDataSet1
        Me.PerpusDBDataSet1BindingSource.Position = 0
        '
        'USERNAMEDataGridViewTextBoxColumn
        '
        Me.USERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME"
        Me.USERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME"
        Me.USERNAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.USERNAMEDataGridViewTextBoxColumn.Name = "USERNAMEDataGridViewTextBoxColumn"
        Me.USERNAMEDataGridViewTextBoxColumn.Width = 125
        '
        'NAMAADMINDataGridViewTextBoxColumn
        '
        Me.NAMAADMINDataGridViewTextBoxColumn.DataPropertyName = "NAMA_ADMIN"
        Me.NAMAADMINDataGridViewTextBoxColumn.HeaderText = "NAMA_ADMIN"
        Me.NAMAADMINDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NAMAADMINDataGridViewTextBoxColumn.Name = "NAMAADMINDataGridViewTextBoxColumn"
        Me.NAMAADMINDataGridViewTextBoxColumn.Width = 125
        '
        'PASSDataGridViewTextBoxColumn
        '
        Me.PASSDataGridViewTextBoxColumn.DataPropertyName = "PASS"
        Me.PASSDataGridViewTextBoxColumn.HeaderText = "PASS"
        Me.PASSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PASSDataGridViewTextBoxColumn.Name = "PASSDataGridViewTextBoxColumn"
        Me.PASSDataGridViewTextBoxColumn.Width = 125
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(50, 339)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 13
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "DATA ADMIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerpusDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerpusDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerpusCRUDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerpusDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerpusDBDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PerpusDBDataSet As PerpusDBDataSet
    Friend WithEvents PerpusDBDataSetBindingSource As BindingSource
    Friend WithEvents PerpusCRUDDataSet As PerpusCRUDDataSet
    Friend WithEvents BIOBindingSource As BindingSource
    Friend WithEvents BIOTableAdapter As PerpusCRUDDataSetTableAdapters.BIOTableAdapter
    Friend WithEvents PerpusDBDataSet1BindingSource As BindingSource
    Friend WithEvents PerpusDBDataSet1 As PerpusDBDataSet
    Friend WithEvents USERNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMAADMINDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PASSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
End Class
