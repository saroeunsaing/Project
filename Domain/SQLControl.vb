Imports DataAccess
Imports Common
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Collections
Imports System.Drawing
Imports System.IO

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
    Sub ReadData(itm As Object, table As String)
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
        cn.Close()
    End Sub
    Sub SaleCht(chrt As Object, ChrtView As String)
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
        cn.Close()
    End Sub
    'create generate button 
    Public Sub LoadButton(obj As Object, query As String)
        'varible save location of each button
        Dim intLeft As Integer = 0
        Dim intTop As Integer = 0

        'vaiable save width and height of each button
        Dim intWidth As Integer = 80
        Dim intHeight As Integer = 100
        Using cn = GetConnection()
            cn.Open()
            cmd = New SqlCommand(query, cn)
            dr = cmd.ExecuteReader

            ' itm.Items.Add(dr(1))
            'itm.Text = dr(1)
            'Loop from 1 to 25 to create button
            For i As Integer = 1 To 1
                While dr.Read
                    If intLeft >= obj.Width - intWidth Then 'out of right from form width 
                        'new line
                        intLeft = 0
                        intTop += 110

                    End If
                    Dim btn As New Button
                    btn.Text = dr(1) & vbNewLine & dr(2) ' & i.ToString
                    btn.Font = New Font("Khmer OS Siemreap", 8)
                    btn.ForeColor = Color.Black
                    btn.TextAlign = ContentAlignment.BottomCenter
                    ' btn.BackColor = Color.Transparent
                    btn.FlatStyle = FlatStyle.Flat
                    btn.FlatAppearance.BorderSize = 1
                    btn.FlatAppearance.MouseDownBackColor = Color.Linen

                    btn.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue


                    'btn.Image = dr(8)
                    btn.Image = System.Drawing.Image.FromFile(dr(8)).GetThumbnailImage(40, 60, Nothing, IntPtr.Zero)

                    ' Align the image and text on the button.  

                    btn.ImageAlign = ContentAlignment.TopCenter

                    btn.TextImageRelation = TextImageRelation.ImageAboveText

                    btn.Left = intLeft
                    btn.Top = intTop
                    btn.Width = intWidth
                    btn.Height = intHeight

                    btn.Visible = True

                    'add event for button here
                    AddHandler btn.Click, AddressOf OnButton_Click
                    AddHandler btn.MouseHover, AddressOf OnButton_MouseHover
                    AddHandler btn.MouseLeave, AddressOf OnButton_MouseLeave

                    'add btn to form
                    obj.Controls.Add(btn)


                    'move next button to right of current button
                    intLeft += intWidth + 5
                End While
            Next

        End Using
    End Sub
    Public Sub LoadIconButton(obj As Object, query As String)
        'varible save location of each button
        Dim intLeft As Integer = 0
        Dim intTop As Integer = 0

        'vaiable save width and height of each button
        Dim intWidth As Integer = 50
        Dim intHeight As Integer = 30
        Using cn = GetConnection()
            cn.Open()
            cmd = New SqlCommand(query, cn)
            dr = cmd.ExecuteReader

            ' itm.Items.Add(dr(1))
            'itm.Text = dr(1)
            'Loop from 1 to 25 to create button
            For i As Integer = 1 To 1
                While dr.Read
                    If intLeft >= obj.Width - intWidth Then 'out of right from form width 
                        'new line
                        intLeft = 0
                        intTop += 110

                    End If
                    Dim btn As New Button
                    btn.Text = dr(1) & vbNewLine & dr(2) ' & i.ToString
                    btn.Font = New Font("Khmer OS Siemreap", 6)
                    btn.ForeColor = Color.Black
                    btn.TextAlign = ContentAlignment.BottomCenter
                    ' btn.BackColor = Color.Transparent
                    btn.FlatStyle = FlatStyle.Flat
                    btn.FlatAppearance.BorderSize = 1
                    btn.FlatAppearance.MouseDownBackColor = Color.Linen

                    btn.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue

                    'btn.Image = dr(8)
                    ' btn.Image = Image.FromFile(dr(8)).GetThumbnailImage(40, 60, Nothing, IntPtr.Zero)

                    ' Align the image and text on the button.  

                    btn.ImageAlign = ContentAlignment.TopCenter

                    btn.TextImageRelation = TextImageRelation.ImageAboveText

                    btn.Left = intLeft
                    btn.Top = intTop
                    btn.Width = intWidth
                    btn.Height = intHeight

                    btn.Visible = True

                    'add event for button here
                    AddHandler btn.Click, AddressOf OnButton_Click
                    AddHandler btn.MouseHover, AddressOf OnButton_MouseHover
                    AddHandler btn.MouseLeave, AddressOf OnButton_MouseLeave

                    'add btn to form
                    obj.Controls.Add(btn)

                    'move next button to right of current button
                    intLeft += intWidth + 5
                End While
            Next
        End Using
    End Sub
    Private Sub OnButton_Click(sender As System.Object, ByVal e As System.EventArgs)

        Dim btn As New Button
        btn = CType(sender, Button) 'convert object to button
        MessageBox.Show(btn.Text & "Clicked", "Clicked", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub
    'create event onMouseHover for button
    Private Sub OnButton_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim btn As New Button
        btn = CType(sender, Button)
        'btn.Text = "Price"

    End Sub
    Private Sub OnButton_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim btn As New Button
        btn = CType(sender, Button)

    End Sub
    Sub lst(lstv As ListView)
        Dim ls As Integer
        Dim lst As New ListViewItem(ls)
        Dim temp As Integer

        Try


            For j = 0 To temp - 1

                If (lstv.Items(j).SubItems(1).Text = "") Then
                    MessageBox.Show("Product Code already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Text_Code.Text = ""
                    'Text_ProductName.Text = ""
                    'Text_Quantity.Text = ""
                    'Text_Price.Text = ""
                    'Text_TotalAmount.Text = ""
                    'Text_Amount.Text = ""
                    Exit Sub
                End If
            Next j
            'If Val(Form_Sales.DataGridView1.SelectedCells(2).Value.ToString) < Val(Text_Amount.Text) Then
            '    MessageBox.Show("Amount was gather than amount in stock", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Me.Text_Amount.Text = ""
            '    Text_Amount.Focus()
            '    Exit Sub
            'End If
            'If Text_Amount.Text = Nothing Then
            '    MsgBox("Please insert Amount!")
            '    Text_Amount.Text = ""
            '    Text_Amount.Focus()
            '    Exit Sub
            'Else
            lst.SubItems.Add("5")
            lst.SubItems.Add("4")
            lst.SubItems.Add("3")
            lst.SubItems.Add("2")

            lst.SubItems.Add("1")
            lstv.Items.Add(lst)
            'Form_Sales.Text_Subtotal.Text = subtot()
            ' Form_Sales.Text_Total.Text = subtot()
            ''Form_Sales.paid()
            ''Text_Amount.Text = ""
            'Text_Amount.Focus()
            'End If
            'Me.Close()
        Catch ex As Exception
            MsgBox("You Must Input Only Number")
            'Text_Amount.Text = ""
            'Text_Amount.Focus()
        End Try
    End Sub




    'temp
    Public Function GetData() As DataView
        Using cn = GetConnection()
            cn.Open()

            Dim SelectQry = "SELECT product_id as [កូដ],namekh​as [ផលិតផល],nameen as [ឡាតាំង],total as [តម្លៃ] from tbl_product "
            Dim SampleSource As New DataSet
            Dim TableView As DataView
            Try
                Dim SampleCommand As New SqlCommand()
                Dim SampleDataAdapter = New SqlDataAdapter()
                SampleCommand.CommandText = SelectQry
                SampleCommand.Connection = cn
                SampleDataAdapter.SelectCommand = SampleCommand
                SampleDataAdapter.Fill(SampleSource)
                TableView = SampleSource.Tables(0).DefaultView
            Catch ex As Exception
                Throw ex
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Return TableView
        End Using
    End Function
    Public Function GetDataParam(param1 As TextBox) As DataView
        Using cn = GetConnection()
            cn.Open()

            Dim SelectQry = "SELECT product_id as [កូដ],namekh ​as [ផលិតផល],nameen as [ឡាតាំង],total as [តម្លៃ] from tbl_product where namekh like N'" & param1.Text & "' or nameen like '" & param1.Text & "' or product_id like N'" & param1.Text & "'"
            Dim SampleSource As New DataSet
            Dim TableView As DataView
            Try
                Dim SampleCommand As New SqlCommand()
                Dim SampleDataAdapter = New SqlDataAdapter()
                SampleCommand.CommandText = SelectQry
                SampleCommand.Connection = cn
                SampleDataAdapter.SelectCommand = SampleCommand
                SampleDataAdapter.Fill(SampleSource)
                TableView = SampleSource.Tables(0).DefaultView
            Catch ex As Exception
                Throw ex
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Return TableView
        End Using
    End Function
#Region "Crystal Report"
    Sub Crst_Rpt(rpt As Object, ds As DataSet, qty As String, report As Object, table As String)
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter()

        Try
            cn = GetConnection()
            'cn.Open()

            cmd.Connection = cn
            cmd.CommandText = qty
            cmd.CommandType = CommandType.Text
            da.SelectCommand = cmd

            da.Fill(ds, table)
            rpt.SetDataSource(ds)
            report.ReportSource = rpt

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
#End Region
#Region "Image"
    Public Sub Image(pic As Object, qty As String)

        Using cn = GetConnection()

            cn.Open()
            cmd = New SqlCommand(qty, cn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim fname As String = dr(0)
                Dim pathstring As String = System.IO.Path.Combine(fname)
                pic.image = System.Drawing.Image.FromStream(New System.IO.MemoryStream(File.ReadAllBytes(pathstring)))




            End While
            dr.Close()
            cn.Close()
        End Using

    End Sub
    Public Sub ProductImg(pic As Object, qty As String)
        Dim folder As String = "D:\Files\Product"
        Using cn = GetConnection()
            cn.Open()
            Using cmd As SqlCommand = New SqlCommand(qty, cn)

                Dim fname As String = cmd.ExecuteScalar()
                Dim pathString As String = System.IO.Path.Combine(folder, fname)
                pic.image = System.Drawing.Image.FromFile(pathString)

            End Using
            cn.Close()
        End Using
    End Sub

    Public Sub browsImg(pic As Object)


        Dim op As OpenFileDialog = New OpenFileDialog

        If op.ShowDialog = DialogResult.OK Then

            pic.image = System.Drawing.Image.FromFile(op.FileName)
        End If
    End Sub
#End Region

#Region "Shop Name"
    Sub Shop(p2 As Object, p3 As Object, p4 As Object, p5 As Object, p6 As Object, pic As Object, table As String)
        Using cn = GetConnection()

            cn.Open()
            cmd = New SqlCommand(table, cn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim fname As String = dr(6)
                Dim pathstring As String = System.IO.Path.Combine(fname)
                pic.image = System.Drawing.Image.FromStream(New System.IO.MemoryStream(File.ReadAllBytes(pathstring)))



                p2.Text = dr(1)
                p3.Text = dr(2)
                p4.Text = dr(3)
                p5.Text = dr(4)
                p6.Text = dr(5)

            End While
        End Using
    End Sub
#End Region
End Class
