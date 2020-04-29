Imports DataAccess
Imports Common
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class SQLControl
    Inherits ConnectToSQL

#Region "Placehoder"
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal hWnd1 As IntPtr, ByVal hWnd2 As IntPtr, ByVal lpsz1 As String, ByVal lpsz2 As String) As IntPtr
    Private Const EM_SETCUEBANNER As Integer = &H1501

    Public Sub SetCueText(ByVal control As Control, ByVal text As String)
        If TypeOf control Is ComboBox Then
            Dim Edit_hWnd As IntPtr = FindWindowEx(control.Handle, IntPtr.Zero, "Edit", Nothing)
            If Not Edit_hWnd = IntPtr.Zero Then
                SendMessage(Edit_hWnd, EM_SETCUEBANNER, 0, text)
            End If
        ElseIf TypeOf control Is TextBox Then
            SendMessage(control.Handle, EM_SETCUEBANNER, 0, text)
        End If
    End Sub
#End Region

#Region "Add Data Function"
    ' QUERY PARAMETERS
    Public Params As New List(Of SqlParameter)
    ' QUERY STATISTICS
    Public RecordCount As Integer
    Public Exception As String
    Public Sub New()
        cn = GetConnection()
    End Sub
    ' ALLOW CONNECTION STRING OVERRIDE
    'Public Sub New(ConnectionString As String)
    '    cn = New SqlConnection(ConnectionString)
    'End Sub

    ' EXECUTE QUERY SUB
    Public Sub ExecQuery(Query As String, Optional ReturnIdentity As Boolean = False)
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""

        Try
            cn.Open()

            ' CREATE DB COMMAND
            cmd = New SqlCommand(Query, cn)

            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) cmd.Parameters.Add(p))

            ' CLEAR PARAM LIST
            Params.Clear()

            ' EXECUTE COMMAND & FILL DATASET
            dt = New DataTable
            da = New SqlDataAdapter(cmd)
            RecordCount = da.Fill(dt)

            If ReturnIdentity = True Then
                Dim ReturnQuery As String = "SELECT @@IDENTITY As LastID;"
                ' @@IDENTITY - SESSION
                ' SCOPE_IDENTITY() - SESSION & SCOPE
                ' IDENT_CURRENT(tablename) - LAST IDENT IN TABLE, ANY SCOPE, ANY SESSION
                cmd = New SqlCommand(ReturnQuery, cn)
                dt = New DataTable
                da = New SqlDataAdapter(cmd)
                RecordCount = da.Fill(dt)
            End If
        Catch ex As Exception
            ' CAPTURE ERROR
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
        Finally
            ' CLOSE CONNECTION
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    ' ADD PARAMS
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    ' ERROR CHECKING
    Public Function HasException(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception:")
        Return True
    End Function
#End Region

#Region "Update Function"

#End Region
#Region "Delete Function"

#End Region
#Region "Retrived Function"

#End Region
End Class
