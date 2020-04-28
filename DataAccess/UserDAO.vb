Imports System.Data.SqlClient
Imports System.Data
Imports Common

Public Class UserDAO
    'import class ConnectToSQL to open connection
    Inherits ConnectToSQL

    'user login function
    Public Function Login(user As String, pass As String) As Boolean
        Using cn = GetConnection()
            cn.Open()
            Using cmd = New SqlCommand()
                cmd.Connection = cn
                cmd.CommandText = "Select * from tbl_User where username=@user AND password=@pass"

                cmd.Parameters.AddWithValue("@user", user)
                cmd.Parameters.AddWithValue("@pass", pass)
                cmd.CommandType = CommandType.Text

                Dim dr = cmd.ExecuteReader()
                If dr.HasRows Then
                    While dr.Read()
                        ActiveUser.idUser = dr.GetString(0)
                        ActiveUser.fullname = dr.GetString(1)
                        ActiveUser.position = dr.GetString(4)
                        '  ActiveUser.idUser = dr.GetString(0)
                    End While
                    dr.Dispose()
                    Return True
                Else
                    Return False
                End If

            End Using
        End Using
    End Function
    'check user existing user login
    Public Function existsUser(id As String) As Boolean
        Using cn = GetConnection()
            cn.Open()
            Using cmd = New SqlCommand()
                cmd.Connection = cn
                cmd.CommandText = "Select * from tbl_User where userID = @id"

                cmd.Parameters.AddWithValue("@id", id)
                cmd.CommandType = CommandType.Text

                Dim dr = cmd.ExecuteReader()
                If dr.HasRows Then
                    Return True

                Else
                    Return False
                End If

            End Using
        End Using
    End Function
End Class
