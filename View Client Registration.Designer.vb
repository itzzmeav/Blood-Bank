<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Client_Registration
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
        Me.TsendBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BloodDataSet8 = New blood__bank_management.bloodDataSet8
        Me.TsendBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BloodDataSet5 = New blood__bank_management.bloodDataSet5
        Me.TsendTableAdapter = New blood__bank_management.bloodDataSet5TableAdapters.tsendTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.TsendBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TsendTableAdapter1 = New blood__bank_management.bloodDataSet8TableAdapters.tsendTableAdapter
        Me.BloodDataSet8BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TsendBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BloodDataSet9 = New blood__bank_management.bloodDataSet9
        Me.TsendBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TsendTableAdapter2 = New blood__bank_management.bloodDataSet9TableAdapters.tsendTableAdapter
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TsendBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloodDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TsendBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloodDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TsendBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloodDataSet8BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TsendBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloodDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TsendBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 157)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(649, 239)
        Me.DataGridView1.TabIndex = 0
        '
        'TsendBindingSource3
        '
        Me.TsendBindingSource3.DataMember = "tsend"
        Me.TsendBindingSource3.DataSource = Me.BloodDataSet8
        '
        'BloodDataSet8
        '
        Me.BloodDataSet8.DataSetName = "bloodDataSet8"
        Me.BloodDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TsendBindingSource
        '
        Me.TsendBindingSource.DataMember = "tsend"
        Me.TsendBindingSource.DataSource = Me.BloodDataSet5
        '
        'BloodDataSet5
        '
        Me.BloodDataSet5.DataSetName = "bloodDataSet5"
        Me.BloodDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TsendTableAdapter
        '
        Me.TsendTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(645, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "View Client Registration"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TsendBindingSource1
        '
        Me.TsendBindingSource1.DataMember = "tsend"
        Me.TsendBindingSource1.DataSource = Me.BloodDataSet8
        '
        'TsendTableAdapter1
        '
        Me.TsendTableAdapter1.ClearBeforeFill = True
        '
        'BloodDataSet8BindingSource
        '
        Me.BloodDataSet8BindingSource.DataSource = Me.BloodDataSet8
        Me.BloodDataSet8BindingSource.Position = 0
        '
        'TsendBindingSource2
        '
        Me.TsendBindingSource2.DataMember = "tsend"
        Me.TsendBindingSource2.DataSource = Me.BloodDataSet8BindingSource
        '
        'BloodDataSet9
        '
        Me.BloodDataSet9.DataSetName = "bloodDataSet9"
        Me.BloodDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TsendBindingSource4
        '
        Me.TsendBindingSource4.DataMember = "tsend"
        Me.TsendBindingSource4.DataSource = Me.BloodDataSet9
        '
        'TsendTableAdapter2
        '
        Me.TsendTableAdapter2.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(23, 441)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "View data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(351, 107)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 29)
        Me.TextBox1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(506, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 33)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'View_Client_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(649, 496)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "View_Client_Registration"
        Me.Text = "View_Client_Registration"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TsendBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloodDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TsendBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloodDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TsendBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloodDataSet8BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TsendBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloodDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TsendBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BloodDataSet5 As blood__bank_management.bloodDataSet5
    Friend WithEvents TsendBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TsendTableAdapter As blood__bank_management.bloodDataSet5TableAdapters.tsendTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BloodDataSet8 As blood__bank_management.bloodDataSet8
    Friend WithEvents TsendBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TsendTableAdapter1 As blood__bank_management.bloodDataSet8TableAdapters.tsendTableAdapter
    Friend WithEvents TsendBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents BloodDataSet8BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TsendBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents BloodDataSet9 As blood__bank_management.bloodDataSet9
    Friend WithEvents TsendBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents TsendTableAdapter2 As blood__bank_management.bloodDataSet9TableAdapters.tsendTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
