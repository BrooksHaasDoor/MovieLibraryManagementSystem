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

					' .Parameters.Add("@IsError", SqlDbType.Bit).Direction = ParameterDirection.Output
					' .Parameters.Add("@ErrorNumber", SqlDbType.Int).Direction = ParameterDirection.Output
					' .Parameters.Add("@ErrorState", SqlDbType.Int).Direction = ParameterDirection.Output
					' .Parameters.Add("@ErrorProcedure", SqlDbType.VarChar, Int32.MaxValue).Direction = ParameterDirection.Output
					' .Parameters.Add("@ErrorLine", SqlDbType.Int).Direction = ParameterDirection.Output
					' .Parameters.Add("@ErrorMessage", SqlDbType.VarChar, Int32.MaxValue).Direction = ParameterDirection.Output
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

				' SPerrorInfo.Clear()

				' If SPerrorInfo.wasError(cm.Parameters("@IsError").Value) = True Or ExecError = True Then
				' 	SPerrorInfo.Fill(cm, ExecErrorMsg)

				' 	hdPlumbing.Logging.DiagLogFileWrite("SP Error in DoorColor.Save", "HaasCreate.txt", True)
				' 	hdPlumbing.Logging.DiagLogFileWrite(SPerrorInfo.ToLogFile(), "HaasCreate.txt", True)
				' 	hdPlumbing.Logging.DiagLogFileWrite(hdPlumbing.Logging.DiagLogFileWrite_SQLParms(cm), "HaasCreate.txt", True)

				' 	If Me.ThrowOnError = True Then
				' 		Err.Raise(921, SPerrorInfo.ToLogFile(), "Stored procedure error")
				' 	Else
				' 		RaiseEvent wasError(SPerrorInfo)
				' 	End If
				' 	TransHaas.Rollback()
				' 	Return False
				' Else

				TransHaas.Commit()

				Return True
				'End If
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

				' cm.Parameters.Add("@WorxName", SqlDbType.VarChar).Value = haasWorxName

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
		Dim obj = New Movie()

		obj.Id = dbLibrary.ReplaceDBNullAndColumnExists(drow, "Id")
		obj.Title = dbLibrary.ReplaceDBNullAndColumnExists(drow, "Title")
		obj.ReleaseDate = dbLibrary.ReplaceDBNullAndColumnExists(drow, "ReleaseDate")
		obj.Genre = dbLibrary.ReplaceDBNullAndColumnExists(drow, "Genre")
		obj.Director = dbLibrary.ReplaceDBNullAndColumnExists(drow, "Director")
		obj.Description = dbLibrary.ReplaceDBNullAndColumnExists(drow, "Description")

		Return obj
	End Function
End Class
