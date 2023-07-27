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
        Dim movieTitle As String = $"{MovieTitleTxt.Text}"
        Dim releaseYear As String = $"{ReleaseYearTxt.Text}"
        Dim genre As String = $"{GenreTxt.Text}"
        Dim director As String = $"{DirectorTxt.Text}"
        Dim description As String = $"{DescriptionTxt.Text}"
        Dim movieString As String = ""

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

        ' Temporary display functionality
        movieString = $"Movie Title: {movieTitle}" & vbCrLf & $"Release Year: {releaseYear}" & vbCrLf & $"Genre: {genre}" & vbCrLf & $"Director: {director}" & vbCrLf & $"Description: {description}"
        MessageBox.Show(movieString)
    End Sub
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        AccessDataInRows()
    End Sub

    Private Sub AccessDataInRows()
        ' Check if there is any data in the DataGrid
        If MovieTitleDataGrid.Rows.Count = 0 Then
            MessageBox.Show("No data in the DataGrid.")
            Exit Sub
        End If

        ' Loop through each row in the DataGrid
        For Each row As DataGridViewRow In MovieTitleDataGrid.Rows
            ' Check if the current row is a data row (not the NewRow at the end)
            If Not row.IsNewRow Then
                ' Access data in each cell of the current row
                Dim movieTitle As String = row.Cells("MovieTitleCol").Value
                Dim releaseYear As String = row.Cells("ReleaseYearCol").Value
                Dim genre As String = row.Cells("GenreCol").Value
                Dim director As String = row.Cells("DirectorCol").Value
                Dim description As String = row.Cells("DescriptionCol").Value

                Dim infoString As String = $"Movie Title: {movieTitle}" & vbCrLf & $"Release Year: {releaseYear}" & vbCrLf & $"Genre: {genre}" & vbCrLf & $"Director: {director}" & vbCrLf & $"Description: {description}"

                MessageBox.Show(infoString)
            End If
        Next
    End Sub
End Class
