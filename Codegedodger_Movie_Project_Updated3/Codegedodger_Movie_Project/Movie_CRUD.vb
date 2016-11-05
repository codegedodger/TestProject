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
End Class