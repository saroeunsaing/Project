Imports DataAccess
Imports Common
Public Class UserModel
    'call userdao class to user
    Dim userDAO As New UserDAO()

    'login link with userdao class
    Public Function Login(user As String, pass As String) As Boolean
        Return userDAO.Login(user, pass)
    End Function
    'check user exist
    Public Function anyMethod() As Boolean
        If ActiveUser.idUser >= 1 Then
            If userDAO.existsUser(ActiveUser.idUser) = True Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
    'check user position with user type
    Public Function anyMethod2() As Boolean
        If ActiveUser.position = Positions.receptionist Then
            'code
        End If
        If ActiveUser.position = Positions.accounting Then
            'code
        End If

    End Function
End Class
