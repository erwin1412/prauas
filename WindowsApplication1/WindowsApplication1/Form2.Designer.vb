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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtzona = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtareaid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btntambah = New System.Windows.Forms.ToolStripButton()
        Me.btnubah = New System.Windows.Forms.ToolStripButton()
        Me.btnhapus = New System.Windows.Forms.ToolStripButton()
        Me.btnsimpan = New System.Windows.Forms.ToolStripButton()
        Me.btnbatal = New System.Windows.Forms.ToolStripButton()
        Me.btncari = New System.Windows.Forms.ToolStripButton()
        Me.btnkeluar = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 107)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(565, 150)
        Me.DataGridView1.TabIndex = 13
        '
        'txtzona
        '
        Me.txtzona.Location = New System.Drawing.Point(112, 72)
        Me.txtzona.Name = "txtzona"
        Me.txtzona.Size = New System.Drawing.Size(243, 20)
        Me.txtzona.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Zona"
        '
        'txtareaid
        '
        Me.txtareaid.Location = New System.Drawing.Point(112, 46)
        Me.txtareaid.Name = "txtareaid"
        Me.txtareaid.Size = New System.Drawing.Size(100, 20)
        Me.txtareaid.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Area ID"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btntambah, Me.btnubah, Me.btnhapus, Me.btnsimpan, Me.btnbatal, Me.btncari, Me.btnkeluar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(577, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btntambah
        '
        Me.btntambah.Image = CType(resources.GetObject("btntambah.Image"), System.Drawing.Image)
        Me.btntambah.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(69, 22)
        Me.btntambah.Text = "Tambah"
        '
        'btnubah
        '
        Me.btnubah.Image = CType(resources.GetObject("btnubah.Image"), System.Drawing.Image)
        Me.btnubah.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(55, 22)
        Me.btnubah.Text = "Ubah"
        '
        'btnhapus
        '
        Me.btnhapus.Image = CType(resources.GetObject("btnhapus.Image"), System.Drawing.Image)
        Me.btnhapus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(61, 22)
        Me.btnhapus.Text = "Hapus"
        '
        'btnsimpan
        '
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(67, 22)
        Me.btnsimpan.Text = "Simpan"
        '
        'btnbatal
        '
        Me.btnbatal.Image = CType(resources.GetObject("btnbatal.Image"), System.Drawing.Image)
        Me.btnbatal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(53, 22)
        Me.btnbatal.Text = "Batal"
        '
        'btncari
        '
        Me.btncari.Image = CType(resources.GetObject("btncari.Image"), System.Drawing.Image)
        Me.btncari.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(79, 22)
        Me.btncari.Text = "Pencarian"
        '
        'btnkeluar
        '
        Me.btnkeluar.Image = CType(resources.GetObject("btnkeluar.Image"), System.Drawing.Image)
        Me.btnkeluar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(60, 22)
        Me.btnkeluar.Text = "Keluar"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 261)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtzona)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtareaid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtzona As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtareaid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btntambah As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnubah As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnhapus As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnsimpan As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnbatal As System.Windows.Forms.ToolStripButton
    Friend WithEvents btncari As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnkeluar As System.Windows.Forms.ToolStripButton
End Class
