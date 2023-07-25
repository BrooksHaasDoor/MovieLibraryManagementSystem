<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MLMSForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MovieTitleTxt = New TextBox()
        ReleaseYearTxt = New TextBox()
        GenreTxt = New TextBox()
        DirectorTxt = New TextBox()
        DescriptionTxt = New TextBox()
        MovieTitleLbl = New Label()
        ReleaseYearLbl = New Label()
        GenreLbl = New Label()
        DirectorLbl = New Label()
        DescriptionLbl = New Label()
        MovieTitleDataGrid = New DataGridView()
        MovieTitleCol = New DataGridViewTextBoxColumn()
        AddMovieBtn = New Button()
        CType(MovieTitleDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MovieTitleTxt
        ' 
        MovieTitleTxt.Location = New Point(493, 15)
        MovieTitleTxt.Name = "MovieTitleTxt"
        MovieTitleTxt.Size = New Size(100, 23)
        MovieTitleTxt.TabIndex = 0
        ' 
        ' ReleaseYearTxt
        ' 
        ReleaseYearTxt.Location = New Point(493, 44)
        ReleaseYearTxt.Name = "ReleaseYearTxt"
        ReleaseYearTxt.Size = New Size(100, 23)
        ReleaseYearTxt.TabIndex = 1
        ' 
        ' GenreTxt
        ' 
        GenreTxt.Location = New Point(493, 73)
        GenreTxt.Name = "GenreTxt"
        GenreTxt.Size = New Size(100, 23)
        GenreTxt.TabIndex = 2
        ' 
        ' DirectorTxt
        ' 
        DirectorTxt.Location = New Point(493, 102)
        DirectorTxt.Name = "DirectorTxt"
        DirectorTxt.Size = New Size(100, 23)
        DirectorTxt.TabIndex = 3
        ' 
        ' DescriptionTxt
        ' 
        DescriptionTxt.Location = New Point(493, 131)
        DescriptionTxt.Name = "DescriptionTxt"
        DescriptionTxt.Size = New Size(100, 23)
        DescriptionTxt.TabIndex = 4
        ' 
        ' MovieTitleLbl
        ' 
        MovieTitleLbl.AutoSize = True
        MovieTitleLbl.Location = New Point(422, 18)
        MovieTitleLbl.Name = "MovieTitleLbl"
        MovieTitleLbl.Size = New Size(65, 15)
        MovieTitleLbl.TabIndex = 6
        MovieTitleLbl.Text = "Movie Title"
        ' 
        ' ReleaseYearLbl
        ' 
        ReleaseYearLbl.AutoSize = True
        ReleaseYearLbl.Location = New Point(416, 47)
        ReleaseYearLbl.Name = "ReleaseYearLbl"
        ReleaseYearLbl.Size = New Size(71, 15)
        ReleaseYearLbl.TabIndex = 7
        ReleaseYearLbl.Text = "Release Year"
        ' 
        ' GenreLbl
        ' 
        GenreLbl.AutoSize = True
        GenreLbl.Location = New Point(446, 76)
        GenreLbl.Name = "GenreLbl"
        GenreLbl.Size = New Size(38, 15)
        GenreLbl.TabIndex = 8
        GenreLbl.Text = "Genre"
        ' 
        ' DirectorLbl
        ' 
        DirectorLbl.AutoSize = True
        DirectorLbl.Location = New Point(435, 105)
        DirectorLbl.Name = "DirectorLbl"
        DirectorLbl.Size = New Size(49, 15)
        DirectorLbl.TabIndex = 9
        DirectorLbl.Text = "Director"
        ' 
        ' DescriptionLbl
        ' 
        DescriptionLbl.AutoSize = True
        DescriptionLbl.Location = New Point(420, 134)
        DescriptionLbl.Name = "DescriptionLbl"
        DescriptionLbl.Size = New Size(67, 15)
        DescriptionLbl.TabIndex = 10
        DescriptionLbl.Text = "Description"
        ' 
        ' MovieTitleDataGrid
        ' 
        MovieTitleDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        MovieTitleDataGrid.Columns.AddRange(New DataGridViewColumn() {MovieTitleCol})
        MovieTitleDataGrid.Location = New Point(12, 15)
        MovieTitleDataGrid.Name = "MovieTitleDataGrid"
        MovieTitleDataGrid.RowTemplate.Height = 25
        MovieTitleDataGrid.Size = New Size(394, 139)
        MovieTitleDataGrid.TabIndex = 11
        ' 
        ' MovieTitleCol
        ' 
        MovieTitleCol.HeaderText = "Movie Title"
        MovieTitleCol.Name = "MovieTitleCol"
        MovieTitleCol.Width = 350
        ' 
        ' AddMovieBtn
        ' 
        AddMovieBtn.Location = New Point(599, 15)
        AddMovieBtn.Name = "AddMovieBtn"
        AddMovieBtn.Size = New Size(75, 139)
        AddMovieBtn.TabIndex = 12
        AddMovieBtn.Text = "Add Movie"
        AddMovieBtn.UseVisualStyleBackColor = True
        ' 
        ' MLMSForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(685, 170)
        Controls.Add(AddMovieBtn)
        Controls.Add(MovieTitleDataGrid)
        Controls.Add(DescriptionLbl)
        Controls.Add(DirectorLbl)
        Controls.Add(GenreLbl)
        Controls.Add(ReleaseYearLbl)
        Controls.Add(MovieTitleLbl)
        Controls.Add(DescriptionTxt)
        Controls.Add(DirectorTxt)
        Controls.Add(GenreTxt)
        Controls.Add(ReleaseYearTxt)
        Controls.Add(MovieTitleTxt)
        Name = "MLMSForm"
        Text = "Movie Library Management System"
        CType(MovieTitleDataGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MovieTitleTxt As TextBox
    Friend WithEvents ReleaseYearTxt As TextBox
    Friend WithEvents GenreTxt As TextBox
    Friend WithEvents DirectorTxt As TextBox
    Friend WithEvents DescriptionTxt As TextBox
    Friend WithEvents MovieTitleLbl As Label
    Friend WithEvents ReleaseYearLbl As Label
    Friend WithEvents GenreLbl As Label
    Friend WithEvents DirectorLbl As Label
    Friend WithEvents DescriptionLbl As Label
    Friend WithEvents MovieTitleDataGrid As DataGridView
    Friend WithEvents AddMovieBtn As Button
    Friend WithEvents MovieTitleCol As DataGridViewTextBoxColumn
End Class
