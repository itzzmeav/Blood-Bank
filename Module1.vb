Imports System.Data.OleDb

Module Module1
    Public cn As OleDbConnection
    Public cmd As OleDbCommand
    Public ad As New OleDbDataAdapter
    Public re As OleDbDataReader
    Public ds As New DataSet

    Sub con()
        cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Blood managment\blood.mdb")
        cn.Open()
    End Sub

    Sub qry(ByVal s As String)
        cmd = New OleDbCommand(s, cn)


    End Sub
End Module
