Public Class MainForm
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Admin_login.Show()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        UserForm.Show()
    End Sub
End Class