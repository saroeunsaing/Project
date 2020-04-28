Imports System.Data.SqlClient
Public MustInherit Class ConnectToSQL
    'Server Configuration
    Public datasource As String = "ACER-PC"
    Public database As String = "Coffee_Shop"
    Public user_ID As String = "sa"
    Public pwd As String = "123"

    'Global Variable Declaration
    Public cn As SqlConnection
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Public dr As SqlDataReader
    Public dt As New DataTable
    Public ds As New DataSet
    Public cs As String
    Protected Sub New()
        cs = "Data Source=" + datasource + ";Initial Catalog=" + database + "; User ID=" + user_ID + ";Password=" + pwd


    End Sub
    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection(cs)
    End Function
End Class
