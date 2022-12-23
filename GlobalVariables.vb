Imports MySql.Data.MySqlClient
Module GlobalVariables
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public ds As New DataSet

    Public ConnectionString As String = "Data source=localhost;database=dbluckylotto;user ID=root;password=;"
End Module
