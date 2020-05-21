Imports DataAccess
Imports Common
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Collections
Imports System.Drawing

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
        ElseIf TypeOf control Is RichTextBox Then
            SendMessage(control.Handle, EM_SETCUEBANNER, 0, text)
        End If
    End Sub
#End Region

#Region "SQL Command Function"
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

#Region "Auto id with string"
    Public Function getMaxID(ByVal tablename As String, ByVal fieldName As String, pre As String, numL As Integer, numR As Integer)
        Dim id As String

        Try
            Using cn = GetConnection()


                cn.Open()
                Dim sql As String
                sql = "SELECT top 1 " + fieldName + " FROM " + tablename + " order by " + fieldName + " desc"
                cmd = New SqlCommand(sql, cn)
                dr = cmd.ExecuteReader
                'While reader.Read
                '    'id = reader.Item(0) + 1
                '    id = Format(Mid(dr(fieldName), 5, 7) + 1, "Cat-000000#")
                'End While
                If dr.HasRows = False Then
                    dr.Close()
                    id = pre + "1"

                Else
                    dr.Read()
                    id = Format(Mid(dr(fieldName), numL, numR) + 1, pre + "#")
                End If
                dr.Close()
                cn.Close()
                Return id
            End Using
        Catch ex As Exception
            'reader.Close()
            cn.Close()
            Return id
        End Try
        'reader.Close()
        cn.Close()
        Return 0
    End Function

#End Region
    Sub labelS(itm As Object, table As String)
        Using cn = GetConnection()

            cn.Open()
            cmd = New SqlCommand(table, cn)
            dr = cmd.ExecuteReader
            While dr.Read
                ' itm.Items.Add(dr(1))
                itm.Text = dr(1)

            End While
        End Using

    End Sub
    Sub ReadData(itm As TextBox, table As String)
        Using cn = GetConnection()

            cn.Open()
            cmd = New SqlCommand(table, cn)
            dr = cmd.ExecuteReader
            While dr.Read
                ' itm.Items.Add(dr(1))
                itm.Text = dr(0)
            End While
        End Using
    End Sub
    Sub cmbox(itm As ComboBox, table As String, index As String, id As String)
        Using cn = GetConnection()
            cn.Open()

            'Create Dat.a Adapter (Using the stored procedure Command created earlier)
            ' Create a data table and Fill the Data adapter 
            Dim da As New SqlDataAdapter(table, cn)
            Dim dt As New DataTable
            da.Fill(dt)
            'Your Combobox 
            itm.DataSource = dt
            itm.DisplayMember = index
            itm.ValueMember = id
            'User will see DisplayMember in the Combobox
        End Using
    End Sub

    'danuag char in home
    Sub CategoryCht(chrt As Object, ChrtView As String)
        Dim itm1 As New ArrayList
        Dim itm2 As New ArrayList
        Using cn = GetConnection()

            cn.Open()
            cmd = New SqlCommand(ChrtView, cn)
            cmd.CommandType = CommandType.Text
            cmd.Connection = cn
            dr = cmd.ExecuteReader()
            While (dr.Read())
                itm1.Add(dr.GetString(0))
                itm2.Add(dr.GetInt32(1))
            End While
            chrt.Series(0).Points.DataBindXY(itm1, itm2)
            dr.Close()
        End Using
        cn.Open()
    End Sub


    'create generate button 
    Public Sub LoadButton(obj As Object)
        'varible save location of each button
        Dim intLeft As Integer = 0
        Dim intTop As Integer = 0

        'vaiable save width and height of each button
        Dim intWidth As Integer = 80
        Dim intHeight As Integer = 100
        Using cn = GetConnection()
            cn.Open()
            cmd = New SqlCommand("select * from tbl_product", cn)
            dr = cmd.ExecuteReader
            While dr.Read
                ' itm.Items.Add(dr(1))
                'itm.Text = dr(1)
                'Loop from 1 to 25 to create button
                For i As Integer = 1 To 1
                    If intLeft >= obj.Width - intWidth Then 'out of right from form width 
                        'new line
                        intLeft = 0
                        intTop += 100

                    End If
                    Dim btn As New Button
                    btn.Text = dr(1) ' & i.ToString
                    btn.Font = New Font("Khmer OS Siemreap", 8)

                    'btn.Image = dr(8)
                    btn.Image = Image.FromFile(dr(8)).GetThumbnailImage(50, 60, Nothing, IntPtr.Zero)

                    ' Align the image and text on the button.  

                    btn.ImageAlign = ContentAlignment.TopCenter
                    btn.TextAlign = ContentAlignment.BottomCenter
                    btn.TextImageRelation = TextImageRelation.ImageAboveText

                    btn.Left = intLeft
                    btn.Top = intTop
                    btn.Width = intWidth
                    btn.Height = intHeight

                    btn.Visible = True

                    'add event for button here
                    AddHandler btn.Click, AddressOf OnButton_Click
                    AddHandler btn.MouseHover, AddressOf OnButton_MouseHover

                    'add btn to form
                    obj.Controls.Add(btn)


                    'move next button to right of current button
                    intLeft += intWidth + 5
                Next
            End While
        End Using
    End Sub

    Private Sub OnButton_Click(sender As System.Object, ByVal e As System.EventArgs)
        Dim btn As New Button
        btn = CType(sender, Button) 'convert object to button
        MessageBox.Show(btn.Text & "Clicked", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    'create event onMouseHover for button
    Private Sub OnButton_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btn As New Button
        btn = CType(sender, Button)

        ' Me.label1.text = "Mouse Hover ON:" & btn.text
    End Sub
End Class
