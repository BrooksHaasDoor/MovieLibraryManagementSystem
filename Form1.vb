Public Class MLMSForm
    Private Sub AddMovieBtn_Click(sender As Object, e As EventArgs) Handles AddMovieBtn.Click
        MovieTitleDataGrid.Rows.Add(MovieTitleTxt.Text)

        ' Database stuff
        ' TODO: Add database, then send this information to the database
        ' MovieTitleTxt.Text.SendToDatabase
        ' ReleaseYearTxt.Text.SendToDatabase
        ' GenreTxt.Text.SendToDatabase
        ' DirectorTxt.Text.SendToDatabase
        ' DescriptionTxt.Text.SendToDatabase
    End Sub

    Private Sub MovieTitleDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MovieTitleDataGrid.CellContentClick
        '    Database stuff
        '    If e.RowIndex >= 1 Then
        '        Dim selectedMovie As Movie = GetSelectedMovie(e.RowIndex)
        '        Dim movieDetailsForm As New MovieDetailsForm(selectedMovie)

        '        movieDetailsForm.ShowDialog()
        '    End If

        ' Private Function GetSelectedMovie(rowIndex As Integer) As MovieDetailsForm
        '    Dim selectedMovie As MovieDetailsForm = listOfMovies(rowIndex)

        '    Return selectedMovie
        ' End Function

        Dim displayForm As New MovieDetailsForm()

        ' Temporary display functionality
        displayForm.MovieInfoDataGrid.Rows.Add()
        displayForm.MovieInfoDataGrid.Rows(0).Cells("MovieTitleCol").Value = MovieTitleTxt.Text
        displayForm.MovieInfoDataGrid.Rows(0).Cells("ReleaseYearCol").Value = ReleaseYearTxt.Text
        displayForm.MovieInfoDataGrid.Rows(0).Cells("GenreCol").Value = GenreTxt.Text
        displayForm.MovieInfoDataGrid.Rows(0).Cells("DirectorCol").Value = DirectorTxt.Text
        displayForm.MovieInfoDataGrid.Rows(0).Cells("DescriptionCol").Value = DescriptionTxt.Text
        displayForm.Show()
    End Sub
End Class
