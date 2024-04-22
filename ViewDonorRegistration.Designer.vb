<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewDonorRegistration
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
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DonorBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BloodDataSet7BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BloodDataSet7 = New blood__bank_management.bloodDataSet7
        Me.DonorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BloodDataSet6 = New blood__bank_management.bloodDataSet6
        Me.BloodDataSet5 = New blood__bank_management.bloodDataSet5
        Me.BloodDataSet5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DonorTableAdapter = New blood__bank_management.bloodDataSet6TableAdapters.donorTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.TsendBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TsendTableAdapter = New blood__bank_management.bloodDataSet6TableAdapters.tsendTableAdapter
        Me.DonorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DonorTableAdapter1 = New blood__bank_management.bloodDataSet7TableAdapters.donorTableAdapter
        Me.BloodDataSet = New blood__bank_management.bloodDataSet
        Me.BloodDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonorBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloodDataSet7BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloodDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloodDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloodDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloodDataSet5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TsendBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloodDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 112)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(817, 235)
        Me.DataGridView1.TabIndex = 0
        '
        'DonorBindingSource2
        '
        Me.DonorBindingSource2.DataMember = "donor"
        Me.DonorBindingSource2.DataSource = Me.BloodDataSet7BindingSource
        '
        'BloodDataSet7BindingSource
        '
        Me.BloodDataSet7BindingSource.DataSource = Me.BloodDataSet7
        Me.BloodDataSet7BindingSource.Position = 0
        '
        'BloodDataSet7
        '
        Me.BloodDataSet7.DataSetName = "bloodDataSet7"
        Me.BloodDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DonorBindingSource
        '
        Me.DonorBindingSource.DataMember = "donor"
        Me.DonorBindingSource.DataSource = Me.BloodDataSet6
        '
        'BloodDataSet6
        '
        Me.BloodDataSet6.DataSetName = "bloodDataSet6"
        Me.BloodDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BloodDataSet5
        '
        Me.BloodDataSet5.DataSetName = "bloodDataSet5"
        Me.BloodDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BloodDataSet5BindingSource
        '
        Me.BloodDataSet5BindingSource.DataSource = Me.BloodDataSet5
        Me.BloodDataSet5BindingSource.Position = 0
        '
        'DonorTableAdapter
        '
        Me.DonorTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(817, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "View Donor Registration"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TsendBindingSource
        '
        Me.TsendBindingSource.DataMember = "tsend"
        Me.TsendBindingSource.DataSource = Me.BloodDataSet6
        '
        'TsendTableAdapter
        '
        Me.TsendTableAdapter.ClearBeforeFill = True
        '
        'DonorBindingSource1
        '
        Me.DonorBindingSource1.DataMember = "donor"
        Me.DonorBindingSource1.DataSource = Me.BloodDataSet7
        '
        'DonorTableAdapter1
        '
        Me.DonorTableAdapter1.ClearBeforeFill = True
        '
        'BloodDataSet
        '
        Me.BloodDataSet.DataSetName = "bloodDataSet"
        Me.BloodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BloodDataSetBindingSource
        '
        Me.BloodDataSetBindingSource.DataSource = Me.BloodDataSet
        Me.BloodDataSetBindingSource.Position = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(10, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "View data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(666, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 31)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(493, 75)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(150, 30)
        Me.TextBox1.TabIndex = 0
        '
        'ViewDonorRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(820, 410)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ViewDonorRegistration"
        Me.Text = "ViewDonorRegistration"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonorBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloodDataSet7BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloodDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloodDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloodDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloodDataSet5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TsendBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloodDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BloodDataSet5BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BloodDataSet5 As blood__bank_management.bloodDataSet5
    Friend WithEvents BloodDataSet6 As blood__bank_management.bloodDataSet6
    Friend WithEvents DonorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DonorTableAdapter As blood__bank_management.bloodDataSet6TableAdapters.donorTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TsendBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TsendTableAdapter As blood__bank_management.bloodDataSet6TableAdapters.tsendTableAdapter
    Friend WithEvents BloodDataSet7 As blood__bank_management.bloodDataSet7
    Friend WithEvents DonorBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DonorTableAdapter1 As blood__bank_management.bloodDataSet7TableAdapters.donorTableAdapter
    Friend WithEvents DonorBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents BloodDataSet7BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BloodDataSet As blood__bank_management.bloodDataSet
    Friend WithEvents BloodDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
