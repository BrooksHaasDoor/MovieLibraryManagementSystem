﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        AddBtn = New Button()
        SearchBtn = New Button()
        SearchLbl = New Label()
        SearchTxt = New TextBox()
        ReleaseDateTime = New DateTimePicker()
        DeleteBtn = New Button()
        CType(MovieTitleDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MovieTitleTxt
        ' 
        MovieTitleTxt.Location = New Point(92, 12)
        MovieTitleTxt.Name = "MovieTitleTxt"
        MovieTitleTxt.Size = New Size(100, 23)
        MovieTitleTxt.TabIndex = 0
        ' 
        ' GenreTxt
        ' 
        GenreTxt.Location = New Point(92, 70)
        GenreTxt.Name = "GenreTxt"
        GenreTxt.Size = New Size(100, 23)
        GenreTxt.TabIndex = 2
        ' 
        ' DirectorTxt
        ' 
        DirectorTxt.Location = New Point(92, 99)
        DirectorTxt.Name = "DirectorTxt"
        DirectorTxt.Size = New Size(100, 23)
        DirectorTxt.TabIndex = 3
        ' 
        ' DescriptionTxt
        ' 
        DescriptionTxt.Location = New Point(92, 128)
        DescriptionTxt.Name = "DescriptionTxt"
        DescriptionTxt.Size = New Size(100, 23)
        DescriptionTxt.TabIndex = 4
        ' 
        ' MovieTitleLbl
        ' 
        MovieTitleLbl.AutoSize = True
        MovieTitleLbl.Location = New Point(21, 15)
        MovieTitleLbl.Name = "MovieTitleLbl"
        MovieTitleLbl.Size = New Size(65, 15)
        MovieTitleLbl.TabIndex = 10
        MovieTitleLbl.Text = "Movie Title"
        ' 
        ' ReleaseYearLbl
        ' 
        ReleaseYearLbl.AutoSize = True
        ReleaseYearLbl.Location = New Point(15, 44)
        ReleaseYearLbl.Name = "ReleaseYearLbl"
        ReleaseYearLbl.Size = New Size(71, 15)
        ReleaseYearLbl.TabIndex = 11
        ReleaseYearLbl.Text = "Release Year"
        ' 
        ' GenreLbl
        ' 
        GenreLbl.AutoSize = True
        GenreLbl.Location = New Point(45, 73)
        GenreLbl.Name = "GenreLbl"
        GenreLbl.Size = New Size(38, 15)
        GenreLbl.TabIndex = 12
        GenreLbl.Text = "Genre"
        ' 
        ' DirectorLbl
        ' 
        DirectorLbl.AutoSize = True
        DirectorLbl.Location = New Point(34, 102)
        DirectorLbl.Name = "DirectorLbl"
        DirectorLbl.Size = New Size(49, 15)
        DirectorLbl.TabIndex = 13
        DirectorLbl.Text = "Director"
        ' 
        ' DescriptionLbl
        ' 
        DescriptionLbl.AutoSize = True
        DescriptionLbl.Location = New Point(19, 131)
        DescriptionLbl.Name = "DescriptionLbl"
        DescriptionLbl.Size = New Size(67, 15)
        DescriptionLbl.TabIndex = 14
        DescriptionLbl.Text = "Description"
        ' 
        ' MovieTitleDataGrid
        ' 
        MovieTitleDataGrid.AllowUserToAddRows = False
        MovieTitleDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        MovieTitleDataGrid.Columns.AddRange(New DataGridViewColumn() {MovieTitleCol})
        MovieTitleDataGrid.Location = New Point(279, 12)
        MovieTitleDataGrid.Name = "MovieTitleDataGrid"
        MovieTitleDataGrid.RowTemplate.Height = 28
        MovieTitleDataGrid.RowTemplate.ReadOnly = True
        MovieTitleDataGrid.Size = New Size(394, 168)
        MovieTitleDataGrid.TabIndex = 9
        ' 
        ' MovieTitleCol
        ' 
        MovieTitleCol.HeaderText = "Movie Title"
        MovieTitleCol.Name = "MovieTitleCol"
        MovieTitleCol.Width = 350
        ' 
        ' AddBtn
        ' 
        AddBtn.Location = New Point(198, 12)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(75, 52)
        AddBtn.TabIndex = 5
        AddBtn.Text = "Add"
        AddBtn.UseVisualStyleBackColor = True
        ' 
        ' SearchBtn
        ' 
        SearchBtn.Location = New Point(198, 128)
        SearchBtn.Name = "SearchBtn"
        SearchBtn.Size = New Size(75, 52)
        SearchBtn.TabIndex = 8
        SearchBtn.Text = "Search"
        SearchBtn.UseVisualStyleBackColor = True
        ' 
        ' SearchLbl
        ' 
        SearchLbl.AutoSize = True
        SearchLbl.Location = New Point(41, 160)
        SearchLbl.Name = "SearchLbl"
        SearchLbl.Size = New Size(42, 15)
        SearchLbl.TabIndex = 15
        SearchLbl.Text = "Search"
        ' 
        ' SearchTxt
        ' 
        SearchTxt.Location = New Point(92, 157)
        SearchTxt.Name = "SearchTxt"
        SearchTxt.Size = New Size(100, 23)
        SearchTxt.TabIndex = 7
        ' 
        ' ReleaseDateTime
        ' 
        ReleaseDateTime.CustomFormat = "yyyy"
        ReleaseDateTime.Format = DateTimePickerFormat.Custom
        ReleaseDateTime.Location = New Point(92, 41)
        ReleaseDateTime.Name = "ReleaseDateTime"
        ReleaseDateTime.Size = New Size(100, 23)
        ReleaseDateTime.TabIndex = 1
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.Location = New Point(198, 70)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(75, 52)
        DeleteBtn.TabIndex = 6
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = True
        ' 
        ' MLMSForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(685, 192)
        Controls.Add(DeleteBtn)
        Controls.Add(ReleaseDateTime)
        Controls.Add(SearchBtn)
        Controls.Add(SearchLbl)
        Controls.Add(SearchTxt)
        Controls.Add(AddBtn)
        Controls.Add(MovieTitleDataGrid)
        Controls.Add(DescriptionLbl)
        Controls.Add(DirectorLbl)
        Controls.Add(GenreLbl)
        Controls.Add(ReleaseYearLbl)
        Controls.Add(MovieTitleLbl)
        Controls.Add(DescriptionTxt)
        Controls.Add(DirectorTxt)
        Controls.Add(GenreTxt)
        Controls.Add(MovieTitleTxt)
        Name = "MLMSForm"
        Text = "Movie Library Management System"
        CType(MovieTitleDataGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MovieTitleTxt As TextBox
    Friend WithEvents GenreTxt As TextBox
    Friend WithEvents DirectorTxt As TextBox
    Friend WithEvents DescriptionTxt As TextBox
    Friend WithEvents MovieTitleLbl As Label
    Friend WithEvents ReleaseYearLbl As Label
    Friend WithEvents GenreLbl As Label
    Friend WithEvents DirectorLbl As Label
    Friend WithEvents DescriptionLbl As Label
    Friend WithEvents MovieTitleDataGrid As DataGridView
    Friend WithEvents AddBtn As Button
    Friend WithEvents MovieTitleCol As DataGridViewTextBoxColumn
    Friend WithEvents SearchBtn As Button
    Friend WithEvents SearchLbl As Label
    Friend WithEvents SearchTxt As TextBox
    Friend WithEvents ReleaseDateTime As DateTimePicker
    Friend WithEvents DeleteBtn As Button
End Class
