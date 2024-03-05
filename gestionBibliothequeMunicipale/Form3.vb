Imports MySql.Data.MySqlClient

Public Class Form3

    Dim str As String = "server=localhost; uid=root; pwd=; database=epreuveepdistag_gsi2023"
    Dim con As New MySqlConnection(str)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form2.Show()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand
            cmd.CommandText = "INSERT INTO PRET (COTEEXEMPLAIRELIVRE,MATRICULEABONNE,DATEDEPRET,DATEDERETOURPRET) VALUES (@COTEEXEMPLAIRELIVRE,@MATRICULEABONNE,@DATEDEPRET,@DATEDERETOURPRET);"
            cmd.Parameters.AddWithValue("@COTEEXEMPLAIRELIVRE", TextBox1.Text)
            cmd.Parameters.AddWithValue("@MATRICULEABONNE", TextBox2.Text)
            cmd.Parameters.AddWithValue("@DATEDEPRET", TextBox3.Text)
            cmd.Parameters.AddWithValue("@DATEDERETOURPRET", TextBox4.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("INSERTION OK.")
            Me.Close()
            Form2.MaLoad()
            Form2.Show()
        Catch ex As Exception

        End Try
    End Sub
End Class