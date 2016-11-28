Imports System.Data.SqlClient

Public Class Rent_A_Movie
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\documents\visual studio 2015\Projects\Codegedodger_Movie_Project\Codegedodger_Movie_Project\Moviesdb.mdf;Integrated Security=True"
        cmd.Connection = con
        con.Open()

        cmd.CommandText = "insert into Rentmovie ([u_id], [m_id], [Datefrom],[Dateto]) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & DateTimePicker1.Text & "','" & DateTimePickerSchedule.Text & "')"

        'rd = cmd.ExecuteReader
        Dim rowCount As Integer = cmd.ExecuteNonQuery()
        If rowCount < 1 Then
            MessageBox.Show("Movie Successfully Rented")
        Else
            MessageBox.Show("User Id or Movie Id inserted is not valid!")


        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class