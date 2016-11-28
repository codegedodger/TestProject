Public Class MovieSearch
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub MoviesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.MoviesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MoviesdbDataSet)

    End Sub

    Private Sub MovieSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MoviesdbDataSet.Movies' table. You can move, or remove it, as needed.
        Me.MoviesTableAdapter.Fill(Me.MoviesdbDataSet.Movies)

    End Sub
End Class