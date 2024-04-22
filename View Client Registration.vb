Public Class View_Client_Registration

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub View_Client_Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BloodDataSet9.tsend' table. You can move, or remove it, as needed.
        Me.TsendTableAdapter2.Fill(Me.BloodDataSet9.tsend)
        'TODO: This line of code loads data into the 'BloodDataSet8.tsend' table. You can move, or remove it, as needed.
        Me.TsendTableAdapter1.Fill(Me.BloodDataSet8.tsend)
        'TODO: This line of code loads data into the 'BloodDataSet5.tsend' table. You can move, or remove it, as needed.
        Me.TsendTableAdapter.Fill(Me.BloodDataSet5.tsend)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim connectionstring As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\Blood managment\blood.mdb; Persist Security Info =False;"
        Dim sql As String = ("select * from tsend  order by sid")
        Dim conn As New OleDb.OleDbConnection(connectionstring)
        Dim dataadapter As New OleDb.OleDbDataAdapter(sql, conn)
        Dim ds As New DataSet()

        conn.Open()
        dataadapter.Fill(ds, "tsend")
        conn.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "tsend"

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim connectionstring As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\Blood managment\blood.mdb; Persist Security Info =False;"
        Dim sql As String = ("select * from tsend where name like'" + TextBox1.Text + "'or sid like'%" + TextBox1.Text + "%'or gendar ='" + TextBox1.Text + "' or blood  like'%" + TextBox1.Text + "%' order by sid")
        Dim conn As New OleDb.OleDbConnection(connectionstring)
        Dim dataadapter As New OleDb.OleDbDataAdapter(sql, conn)
        Dim ds As New DataSet()

        conn.Open()
        dataadapter.Fill(ds, "tsend")
        conn.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "tsend"

    End Sub
End Class