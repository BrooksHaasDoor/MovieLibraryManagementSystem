Public Class MLMSForm
    Private Sub MLMSForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get movies from server
        Dim movies = MovieFactory.LoadAll

        ' For each movie, add movie.Title to the DataGrid
        For Each movie In movies
            MovieTitleDataGrid.Rows.Add($"{movie.Title}")
        Next
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim textBoxes As Array = {MovieTitleTxt, ReleaseDateTime, GenreTxt, DirectorTxt, DescriptionTxt}

        For Each currentTextBox As Object In textBoxes
            ' Check if the TextBox is empty
            If String.IsNullOrEmpty(currentTextBox.Text) Then
                ' Show an error message to the user
                MessageBox.Show("Please fill in the required field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                ' Set focus to the TextBox to prompt the user to fill it
                currentTextBox.Focus()
                Exit Sub
            End If
        Next

        Dim movie = New Movie With {
            .Title = MovieTitleTxt.Text,
            .ReleaseDate = ReleaseDateTime.Value,
            .Genre = GenreTxt.Text,
            .Director = DirectorTxt.Text,
            .Description = DescriptionTxt.Text
        }

        AddMovie(movie)
        ResetInputs()
    End Sub

    Private Sub MovieTitleDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MovieTitleDataGrid.CellClick
        DisplayMovieList(MovieTitleDataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        ' Check if there is any data in MovieTitleDataGrid
        If MovieTitleDataGrid.Rows.Count = 0 Then
            ' Inform the user there are no movies saved
            MessageBox.Show("There are no movies saved.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        DisplayMovieList(SearchTxt.Text)
    End Sub

    Private Sub AddMovie(movie As Movie)
        movie.Save()

        ' Create a new row with the value of movie.Title
        MovieTitleDataGrid.Rows.Add($"{movie.Title}")
    End Sub

    Private Sub DisplayMovieList(searchText)
        ' Get movies from server
        Dim movies = MovieFactory.LoadAll

        ' If the movie does not exist,
        ' then display a different MessageBox and Exit Sub
        If (searchText = "") Then
            MessageBox.Show("There are no movies with that title.")
            Exit Sub
        End If

        ' Loop through movie titles
        For Each movie In movies
            ' If the current movie is the selected movie,
            ' then assign selectedMovie to the respective movie
            If movie.Title = searchText Then
                MessageBox.Show(GetDisplayMessage(movie))
                Exit For
            End If
        Next
    End Sub

    Private Sub ResetInputs()
        ' Set input values to empty strings
        MovieTitleTxt.Text = ""
        ReleaseDateTime.Text = ""
        GenreTxt.Text = ""
        DirectorTxt.Text = ""
        DescriptionTxt.Text = ""
    End Sub

    Private Function GetDisplayMessage(selectedMovie) As String
        Return $"Movie Title: {selectedMovie.Title}" & vbCrLf & vbCrLf &
               $"Release Year: {selectedMovie.ReleaseDate}" & vbCrLf & vbCrLf &
               $"Genre(s): {selectedMovie.Genre}" & vbCrLf & vbCrLf &
               $"Director(s): {selectedMovie.Director}" & vbCrLf & vbCrLf &
               $"Description: {selectedMovie.Description}"
    End Function
End Class
