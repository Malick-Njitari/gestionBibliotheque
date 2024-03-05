Imports MySql.Data.MySqlClient

Public Class Form2

    Dim str As String = "server=localhost; uid=root; pwd=; database=epreuveepdistag_gsi2023"
    Dim con As New MySqlConnection(str)

    Sub MaLoad()
        Dim query As String = "SELECT * FROM PRET"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form3.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaLoad()

    End Sub
End Class