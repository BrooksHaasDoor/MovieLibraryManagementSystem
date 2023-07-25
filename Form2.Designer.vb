<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovieDetailsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MovieInfoDataGrid = New DataGridView()
        MovieTitleCol = New DataGridViewTextBoxColumn()
        ReleaseYearCol = New DataGridViewTextBoxColumn()
        GenreCol = New DataGridViewTextBoxColumn()
        DirectorCol = New DataGridViewTextBoxColumn()
        DescriptionCol = New DataGridViewTextBoxColumn()
        CType(MovieInfoDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MovieInfoDataGrid
        ' 
        MovieInfoDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        MovieInfoDataGrid.Columns.AddRange(New DataGridViewColumn() {MovieTitleCol, ReleaseYearCol, GenreCol, DirectorCol, DescriptionCol})
        MovieInfoDataGrid.Location = New Point(12, 12)
        MovieInfoDataGrid.Name = "MovieInfoDataGrid"
        MovieInfoDataGrid.RowTemplate.Height = 25
        MovieInfoDataGrid.Size = New Size(843, 150)
        MovieInfoDataGrid.TabIndex = 0
        ' 
        ' MovieTitleCol
        ' 
        MovieTitleCol.HeaderText = "Movie Title"
        MovieTitleCol.Name = "MovieTitleCol"
        MovieTitleCol.Width = 200
        ' 
        ' ReleaseYearCol
        ' 
        ReleaseYearCol.HeaderText = "Release Year"
        ReleaseYearCol.Name = "ReleaseYearCol"
        ReleaseYearCol.Width = 50
        ' 
        ' GenreCol
        ' 
        GenreCol.HeaderText = "Genre"
        GenreCol.Name = "GenreCol"
        GenreCol.Width = 125
        ' 
        ' DirectorCol
        ' 
        DirectorCol.HeaderText = "Director"
        DirectorCol.Name = "DirectorCol"
        DirectorCol.Width = 125
        ' 
        ' DescriptionCol
        ' 
        DescriptionCol.HeaderText = "Description"
        DescriptionCol.Name = "DescriptionCol"
        DescriptionCol.Width = 300
        ' 
        ' MovieDetailsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(868, 176)
        Controls.Add(MovieInfoDataGrid)
        Name = "MovieDetailsForm"
        Text = "Movie Details"
        CType(MovieInfoDataGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MovieInfoDataGrid As DataGridView
    Friend WithEvents MovieTitleCol As DataGridViewTextBoxColumn
    Friend WithEvents ReleaseYearCol As DataGridViewTextBoxColumn
    Friend WithEvents GenreCol As DataGridViewTextBoxColumn
    Friend WithEvents DirectorCol As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionCol As DataGridViewTextBoxColumn
End Class
