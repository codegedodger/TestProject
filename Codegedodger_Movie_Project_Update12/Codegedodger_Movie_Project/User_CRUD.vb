Imports System.Data.SqlClient

Public Class User_CRUD
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MoviesdbDataSet)

    End Sub

    Private Sub User_CRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MoviesdbDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.MoviesdbDataSet.Users)

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
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
            MessageBox.Show("User successfuly Inserted!")

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\documents\visual studio 2015\Projects\Codegedodger_Movie_Project\Codegedodger_Movie_Project\Moviesdb.mdf;Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "Update Users Set username='" & txtUName.Text & "', password='" & txtPassword.Text & "', DOB ='" & DateTimePicker1.Text & "' where Id='" & TextBox1.Text & "' "
        rd = cmd.ExecuteReader
        MessageBox.Show("Data Successfully Updated")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (txtPassword.Text IsNot Nothing) Then
            MessageBox.Show("Can only be deleted by id or username")
        End If

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\documents\visual studio 2015\Projects\Codegedodger_Movie_Project\Codegedodger_Movie_Project\Moviesdb.mdf;Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "Delete From Movies where username='" & txtUName.Text & "'  or Id='" & TextBox1.Text & "' "
        rd = cmd.ExecuteReader
        MessageBox.Show("User data Successfully Deleted")

    End Sub
End Class