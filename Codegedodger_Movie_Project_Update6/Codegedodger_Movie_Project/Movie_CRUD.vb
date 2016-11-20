Imports System.Data.SqlClient
Public Class Movie_CRUD
    Private Sub MoviesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MoviesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MoviesdbDataSet)

    End Sub

    Private Sub Movie_CRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MoviesdbDataSet.Movies' table. You can move, or remove it, as needed.
        Me.MoviesTableAdapter.Fill(Me.MoviesdbDataSet.Movies)

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        'con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\documents\visual studio 2015\Projects\Codegedodger_Movie_Project\Codegedodger_Movie_Project\Moviesdb.mdf;Integrated Security=True"
        ' cmd.Connection = con
        '  con.Open()
        'cmd.CommandText = "insert into Users ([username], [password], [DOB]) values ('" & txtUName.Text & "','" & txtPassword.Text & "','" & DateTimePicker1.Value.Date & "')"
        ' rd = cmd.ExecuteReader
        Dim rowCount As Integer = cmd.ExecuteNonQuery()
        If rowCount < 1 Then
            MessageBox.Show("Data is not inserted")
        Else
            MessageBox.Show("Data Successfully Inserted!")

        End If
    End Sub
End Class