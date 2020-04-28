Imports DataAccess
Public Class UserModel
    Dim userDAO As New UserDAO()

    Public Function Login(user As String, pass As String) As Boolean
        Return UserDAO.Login(user, pass)
    End Function


End Class
