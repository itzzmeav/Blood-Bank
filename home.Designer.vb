<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.BloodDataSet11 = New blood__bank_management.bloodDataSet1
        Me.DonorTableAdapter1 = New blood__bank_management.bloodDataSetTableAdapters.donorTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.BloodDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "1682075502202.jpg")
        Me.ImageList1.Images.SetKeyName(1, "IMG-20230424-WA0003.jpg")
        Me.ImageList1.Images.SetKeyName(2, "png-red-search-icon-button-11640084036hxyfzazl4w.png")
        Me.ImageList1.Images.SetKeyName(3, "IMG-20230422-WA0025.jpg")
        Me.ImageList1.Images.SetKeyName(4, "IMG-20230422-WA0031.jpg")
        Me.ImageList1.Images.SetKeyName(5, "1682075619973.jpg")
        Me.ImageList1.Images.SetKeyName(6, "IMG-20230424-WA0006.jpg")
        Me.ImageList1.Images.SetKeyName(7, "IMG-20230424-WA0004.jpg")
        Me.ImageList1.Images.SetKeyName(8, "IMG-20230424-WA0005.jpg")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageIndex = 6
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(0, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(285, 60)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Donor Registration"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.ImageIndex = 7
        Me.Button6.ImageList = Me.ImageList1
        Me.Button6.Location = New System.Drawing.Point(445, 317)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(285, 60)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Exit"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImageIndex = 4
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(445, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(285, 60)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Client Registration"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.ImageIndex = 5
        Me.Button5.ImageList = Me.ImageList1
        Me.Button5.Location = New System.Drawing.Point(0, 317)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(285, 60)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Contact Us"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.ImageIndex = 3
        Me.Button3.ImageList = Me.ImageList1
        Me.Button3.Location = New System.Drawing.Point(0, 238)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(285, 60)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "View Client Request"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.ImageIndex = 2
        Me.Button4.Location = New System.Drawing.Point(445, 238)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(285, 60)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "View Donor Registration"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'BloodDataSet11
        '
        Me.BloodDataSet11.DataSetName = "bloodDataSet1"
        Me.BloodDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DonorTableAdapter1
        '
        Me.DonorTableAdapter1.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Image = Global.blood__bank_management.My.Resources.Resources.IMG_20230508_0807171
        Me.Label1.Location = New System.Drawing.Point(-3, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(742, 128)
        Me.Label1.TabIndex = 6
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.BackgroundImage = Global.blood__bank_management.My.Resources.Resources._1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(736, 416)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "home"
        Me.Text = "home"
        CType(Me.BloodDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents BloodDataSet11 As blood__bank_management.bloodDataSet1
    Friend WithEvents DonorTableAdapter1 As blood__bank_management.bloodDataSetTableAdapters.donorTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
