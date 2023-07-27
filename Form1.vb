Public Class MLMSForm
    ' Global variables
    Dim movieTitle As String = ""
    Dim releaseYear As String = ""
    Dim genre As String = ""
    Dim director As String = ""
    Dim description As String = ""
    Dim movieTitleList As New List(Of Object)

    Private Sub AddMovieBtn_Click(sender As Object, e As EventArgs) Handles AddMovieBtn.Click
        AddMovie($"{MovieTitleTxt.Text}", $"{ReleaseYearTxt.Text}", $"{GenreTxt.Text}", $"{DirectorTxt.Text}", $"{DescriptionTxt.Text}")
        ResetInputs()
    End Sub

    Private Sub MovieTitleDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MovieTitleDataGrid.CellContentClick
        ' Get the value of the selected cell and display it
        DisplayMovieList(MovieTitleDataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
    End Sub
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        ' Check if there is any data in MovieTitleDataGrid
        If MovieTitleDataGrid.Rows.Count = 0 Then
            ' Inform the user there are no movies saved
            MessageBox.Show("There are no movies saved.")
            Exit Sub
        End If

        DisplayMovieList(SearchTxt.Text)
    End Sub

    Private Function CreateNewMovie(mov, rel, gen, dir, des)
        ' Create a list of movie details
        Dim newList As New List(Of String) From {
                mov,
                rel,
                gen,
                dir,
                des
            }

        Return newList
    End Function

    Private Function GetDisplayMessage() As String
        Return $"Movie Title: {movieTitle}" & vbCrLf & $"Release Year: {releaseYear}" & vbCrLf & $"Genre: {genre}" & vbCrLf & $"Director: {director}" & vbCrLf & $"Description: {description}"
    End Function

    Private Sub DisplayMovieList(selectedMovie)
        ' Loop through movie titles
        For Each movie As List(Of String) In movieTitleList
            ' If the current movie is the selected movie,
            ' then assign global variables to their respective values
            If movie(0) = selectedMovie Then
                movieTitle = movie(0)
                releaseYear = movie(1)
                genre = movie(2)
                director = movie(3)
                description = movie(4)
            End If
        Next

        If (movieTitle = "" AndAlso releaseYear = "" AndAlso genre = "" AndAlso director = "" AndAlso description = "") Then
            MessageBox.Show("There are no movies with that title.")
            Exit Sub
        End If

        MessageBox.Show(GetDisplayMessage())
        ResetGlobalVariables()
    End Sub

    Private Sub AddMovie(mov, rel, gen, dir, des)
        ' Create and add a new movie to movieTitleList
        movieTitleList.Add(CreateNewMovie(mov, rel, gen, dir, des))

        ' Create a new row with value of movieTitle
        MovieTitleDataGrid.Rows.Add($"{mov}")
    End Sub

    Private Sub ResetGlobalVariables()
        ' Set globals to empty strings
        movieTitle = ""
        releaseYear = ""
        genre = ""
        director = ""
        description = ""
    End Sub

    Private Sub ResetInputs()
        ' Set inputs to empty strings
        MovieTitleTxt.Text = ""
        ReleaseYearTxt.Text = ""
        GenreTxt.Text = ""
        DirectorTxt.Text = ""
        DescriptionTxt.Text = ""
    End Sub

    Private Sub MLMSForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddMovie("Barbie", 2023, "Adventure/Comedy/Fantasy", "Greta Gerwig", "Barbie suffers a crisis that leads her to question her world and her existence.")
        AddMovie("The Shawshank Redemption", 1994, "Drama", "Frank Darabont", "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.")
    End Sub
End Class
