Imports MySql.Data.MySqlClient
Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        aktifkan(False)
        aktifkantombol(True)
        IsiGridJenis()
        DataGridView1.Enabled = True
        ubah = False
    End Sub
 
    Sub aktifkantombol(ByVal x As Boolean)
        btntambah.Enabled = x
        btnubah.Enabled = x
        btnhapus.Enabled = x
        btnsimpan.Enabled = Not x
        btnbatal.Enabled = Not x
        DataGridView1.Enabled = x
        btnkeluar.Enabled = x
    End Sub

    Sub IsiGridJenis()
        KoneksiDB.bukadb()
        da = New MySqlDataAdapter("select Area_ID,Zona from area", conn)
        ds = New DataSet
        da.Fill(ds, "area")
        DataGridView1.DataSource = ds.Tables("area")
        DataGridView1.ReadOnly = True
    End Sub
    Sub aktifkan(ByVal x As Boolean) 'untuk aktifkan textbox dan datagridview
        txtareaid.Enabled = x
        txtzona.Enabled = x
        DataGridView1.Enabled = x
    End Sub
    Sub kosong()
        txtareaid.Text = ""
        txtzona.Text = ""
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        ubah = False
        aktifkan(True)
        aktifkantombol(False)
        kosong()
        txtareaid.Focus()
    End Sub
    Sub bacakodesatuan()
        bukadb()
        cmd = New MySqlCommand("select area from satuan where Area_ID= '" & txtareaid.Text & "'", conn)
        rd = cmd.ExecuteReader
    End Sub
End Class