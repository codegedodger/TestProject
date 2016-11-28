

Imports Codegedodger_Movie_Project.MoviesdbDataSet
Imports Codegedodger_Movie_Project.MoviesdbDataSetTableAdapters
Imports System.Data.SqlClient


Public Class Admin_login

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\documents\visual studio 2015\Projects\Codegedodger_Movie_Project\Codegedodger_Movie_Project\Moviesdb.mdf;Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select A_username,A_password from Admin where A_username= '" & txtUName.Text & "' and A_password='" & btnPassword.Text & "' "
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Admin_MainMenu.Show()
        Else
            MessageBox.Show("Invalid username or password")

        End If
    End Sub
End Class