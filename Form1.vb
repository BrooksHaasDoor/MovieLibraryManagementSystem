Public Class MLMSForm
    ' Global variables
    Dim movieTitle As String = ""
    Dim releaseYear As String = ""
    Dim genre As String = ""
    Dim director As String = ""
    Dim description As String = ""
    Dim movieTitleList As New List(Of Object)

    Private Sub MLMSForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddMovie("Barbie", "2023", "Adventure/Comedy/Fantasy", "Greta Gerwig", "Barbie suffers a crisis that leads her to question her world and her existence.")
        AddMovie("The Shawshank Redemption", "1994", "Drama", "Frank Darabont", "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.")
        AddMovie("The Godfather", "1972", "Crime/Drama", "Francis Ford Coppola", "Don Vito Corleone, head of a mafia family, decides to hand over his empire to his youngest son Michael. However, his decision unintentionally puts the lives of his loved ones in grave danger.")
        AddMovie("The Lord of the Rings: The Fellowship of the Ring", "2001", "Action/Adventure/Drama", "Peter Jackson", "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.")
        AddMovie("Spider-Man: Across the Spiderverse", "2023", "Animation/Action/Adventure", "Joaquim Dos Santos/Kemp Powers/Justin K. Thompson", "Miles Morales catapults across the Multiverse, where he encounters a team of Spider-People charged with protecting its very existence. When the heroes clash on how to handle a new threat, Miles must redefine what it means to be a hero.")
    End Sub

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

    Private Sub AddMovie(mov, rel, gen, dir, des)
        ' Create and add a new movie to movieTitleList
        movieTitleList.Add(CreateNewMovie(mov, rel, gen, dir, des))

        ' Create a new row with value of mov
        MovieTitleDataGrid.Rows.Add($"{mov}")
    End Sub

    Private Function CreateNewMovie(mov, rel, gen, dir, des)
        ' Create a list of movie details
        Dim newList As New List(Of String) From {mov, rel, gen, dir, des}

        Return newList
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

        ' If the movie does not exist,
        ' then display a different MessageBox and Exit Sub
        If (movieTitle = "" AndAlso releaseYear = "" AndAlso genre = "" AndAlso director = "" AndAlso description = "") Then
            MessageBox.Show("There are no movies with that title.")
            Exit Sub
        End If

        MessageBox.Show(GetDisplayMessage())
        ResetGlobalVariables()
    End Sub

    Private Sub ResetGlobalVariables()
        ' Set global variable values to empty strings
        movieTitle = ""
        releaseYear = ""
        genre = ""
        director = ""
        description = ""
    End Sub

    Private Sub ResetInputs()
        ' Set input values to empty strings
        MovieTitleTxt.Text = ""
        ReleaseYearTxt.Text = ""
        GenreTxt.Text = ""
        DirectorTxt.Text = ""
        DescriptionTxt.Text = ""
    End Sub

    Private Function GetDisplayMessage() As String
        Return $"Movie Title: {movieTitle}" & vbCrLf & $"Release Year: {releaseYear}" & vbCrLf & $"Genre: {genre}" & vbCrLf & $"Director: {director}" & vbCrLf & $"Description: {description}"
    End Function
End Class
