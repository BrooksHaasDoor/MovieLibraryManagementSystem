Public Class MLMSForm
    Private Sub AddMovieBtn_Click(sender As Object, e As EventArgs) Handles AddMovieBtn.Click
        MovieTitleDataGrid.Rows.Add(MovieTitleTxt.Text)

        'MovieTitleTxt.Text.SendToDatabase
        'ReleaseYearTxt.Text.SendToDatabase
        'GenreTxt.Text.SendToDatabase
        'DirectorTxt.Text.SendToDatabase
        'DescriptionTxt.Text.SendToDatabase
    End Sub

    'Private Sub MovieTitleDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MovieTitleDataGrid.CellContentClick
    '    If e.RowIndex >= 1 Then
    '        Dim selectedMovie As Movie = GetSelectedMovie(e.RowIndex)
    '        Dim movieDetailsForm As New MovieDetailsForm(selectedMovie)

    '        movieDetailsForm.ShowDialog()
    '    End If
    'End Sub

    'Private Function GetSelectedMovie(rowIndex As Integer) As MovieDetailsForm
    '    Dim selectedMovie As MovieDetailsForm = listOfMovies(rowIndex)

    '    Return selectedMovie
    'End Function
End Class
