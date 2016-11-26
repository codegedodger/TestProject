Imports System.Data.SqlClient


Public Class User_Registration
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\documents\visual studio 2015\Projects\Codegedodger_Movie_Project\Codegedodger_Movie_Project\Moviesdb.mdf;Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "insert into Users ([username], [password], [DOB]) values ('" & txtUName.Text & "','" & txtPassword.Text & "','" & DateTimePicker1.Value.Date & "')"
        ' rd = cmd.ExecuteReader
        Dim rowCount As Integer = cmd.ExecuteNonQuery()
        If rowCount < 1 Then
            MessageBox.Show("Data is not inserted")
        Else
            MessageBox.Show("Data Successfully Inserted!")

        End If
    End Sub
End Class