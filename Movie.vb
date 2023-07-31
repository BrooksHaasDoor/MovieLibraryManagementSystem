Imports System.Configuration.Provider
Imports System.Data.SqlClient
Imports hdPlumbing

Public Class Movie
    Public Property Id As Integer
    Public Property Title As String
	Public Property ReleaseDate As Date
	Public Property Genre As String
	Public Property Director As String
	Public Property Description As String

	Public Function Save() As Boolean
		Dim cnStr As String = "data source=BSUSOR\BROOKSSQL2022;initial catalog=MovieDatabase;persist security info=True;Integrated Security=SSPI;"
		Dim TransHaas As SqlTransaction

		Using cn As New SqlConnection(cnStr)
			cn.Open()
			TransHaas = cn.BeginTransaction

			Using cm As New SqlCommand("insert into Movie values (@name, @releaseDate, @genre, @director, @description)", cn)
				cm.CommandType = CommandType.Text
				With cm
					.Parameters.Add("@name", SqlDbType.NVarChar).Value = Me.Title
					.Parameters.Add("@releaseDate", SqlDbType.NVarChar).Value = Me.ReleaseDate
					.Parameters.Add("@genre", SqlDbType.NVarChar).Value = Me.Genre
					.Parameters.Add("@director", SqlDbType.NVarChar).Value = Me.Director
					.Parameters.Add("@description", SqlDbType.NVarChar).Value = Me.Description
				End With

				cm.Transaction = TransHaas
				Dim ExecError As Boolean = False
				Dim ExecErrorMsg As String = String.Empty

				Try
					cm.ExecuteNonQuery()
				Catch ex As Exception
					ExecError = True
					ExecErrorMsg = ex.Message.ToString()
				End Try

				TransHaas.Commit()

				Return True
			End Using
		End Using

		Return True
	End Function
End Class

Public Class MovieFactory
	Public Shared Function LoadAll(Optional haasWorxName As String = Nothing) As List(Of Movie)
		Dim ds = New DataSet()

		Using cn = New SqlConnection("data source=BSUSOR\BROOKSSQL2022;initial catalog=MovieDatabase;persist security info=True;Integrated Security=SSPI;")
			Using cm = New SqlCommand("Select * from Movie", cn)
				Dim da = New SqlDataAdapter()

				cm.CommandType = CommandType.Text
				da.SelectCommand = cm
				cn.Open()
				da.Fill(ds, "data")
				da.Dispose()
			End Using
		End Using

		Dim rtn As List(Of Movie) = Populate(ds)

		Return rtn
	End Function

	Private Shared Function Populate(ByVal ds As DataSet) As List(Of Movie)
		Dim rows As DataRowCollection
		Dim oLst = New List(Of Movie)()
		Dim dt = New DataTable()

		dt = ds.Tables("data")
		rows = dt.Rows

		For Each drow As DataRow In rows
			Dim obj = New Movie()
			obj = PopulateRow(drow)
			oLst.Add(obj)
		Next

		Return oLst
	End Function

	Private Shared Function PopulateRow(ByVal drow As DataRow) As Movie
		Dim obj = New Movie With {
			.Id = dbLibrary.ReplaceDBNullAndColumnExists(drow, "Id"),
			.Title = dbLibrary.ReplaceDBNullAndColumnExists(drow, "Title"),
			.ReleaseDate = dbLibrary.ReplaceDBNullAndColumnExists(drow, "ReleaseDate"),
			.Genre = dbLibrary.ReplaceDBNullAndColumnExists(drow, "Genre"),
			.Director = dbLibrary.ReplaceDBNullAndColumnExists(drow, "Director"),
			.Description = dbLibrary.ReplaceDBNullAndColumnExists(drow, "Description")
		}

		Return obj
	End Function
End Class
