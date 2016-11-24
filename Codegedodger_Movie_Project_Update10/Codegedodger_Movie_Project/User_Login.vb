Imports System.Data.SqlClient

Public Class User_Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\documents\visual studio 2015\Projects\Codegedodger_Movie_Project\Codegedodger_Movie_Project\Moviesdb.mdf;Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select username,password from users where username= '" & TextBox1.Text & "' and password='" & TextBox2.Text & "' "
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            MovieSearch.Show()
        Else
            MessageBox.Show("Invalid username or password")

        End If
    End Sub
End Class