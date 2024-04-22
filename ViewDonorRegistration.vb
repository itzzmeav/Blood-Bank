Public Class ViewDonorRegistration

    Private Sub ViewDonorRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BloodDataSet7.donor' table. You can move, or remove it, as needed.
        Me.DonorTableAdapter1.Fill(Me.BloodDataSet7.donor)
        'TODO: This line of code loads data into the 'BloodDataSet6.tsend' table. You can move, or remove it, as needed.
        Me.TsendTableAdapter.Fill(Me.BloodDataSet6.tsend)
        'TODO: This line of code loads data into the 'BloodDataSet6.donor' table. You can move, or remove it, as needed.
        Me.DonorTableAdapter.Fill(Me.BloodDataSet6.donor)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim connectionstring As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\Blood managment\blood.mdb; Persist Security Info =False;"
        Dim sql As String = ("select * from donor  order by Registrationno")
        Dim conn As New OleDb.OleDbConnection(connectionstring)
        Dim dataadapter As New OleDb.OleDbDataAdapter(sql, conn)
        Dim ds As New DataSet()

        conn.Open()
        dataadapter.Fill(ds, "donor")
        conn.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "donor"

    End Sub

   

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim connectionstring As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\Blood managment\blood.mdb; Persist Security Info =False;"
        Dim sql As String = ("select * from donor where dname like'%" + TextBox1.Text + "%'or Registrationno like'%" + TextBox1.Text + "%'or fname like'%" + TextBox1.Text + "%' or mname like'%" + TextBox1.Text + "%'or gendar ='" + TextBox1.Text + "'or blood like'%" + TextBox1.Text + "%'or age like'%" + TextBox1.Text + "%'or address like'%" + TextBox1.Text + "%'or mobile like'%" + TextBox1.Text + "%'or email like'%" + TextBox1.Text + "%' order by Registrationno")
        Dim conn As New OleDb.OleDbConnection(connectionstring)
        Dim dataadapter As New OleDb.OleDbDataAdapter(sql, conn)
        Dim ds As New DataSet()

        conn.Open()
        dataadapter.Fill(ds, "donor")
        conn.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "donor"
    End Sub
End Class