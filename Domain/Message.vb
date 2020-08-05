'' The author of this code is Hand Passant: 
'' ttp://stackoverflow.com/questions/2259027/bold-text-in-messagebox/2259213#2259213
''
'' I've just translated it to VB.NET and made very little modifications.

'Imports System.Drawing
'Imports System.Runtime.InteropServices
'Imports System.Text
'Imports System.Windows.Forms

Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms


Public Class Message : Implements IDisposable

    '    Private mTries As Integer = 0
    '    Private mOwner As Form
    '    Private mFont As Font

    '    ' P/Invoke declarations
    '    Private Const WM_SETFONT As Integer = &H30
    '    Private Const WM_GETFONT As Integer = &H31

    '    Private Delegate Function EnumThreadWndProc(hWnd As IntPtr, lp As IntPtr) As Boolean

    '    <DllImport("user32.dll")>
    '    Private Shared Function EnumThreadWindows(tid As Integer, callback As EnumThreadWndProc, lp As IntPtr) As Boolean
    '    End Function

    '    <DllImport("kernel32.dll")>
    '    Private Shared Function GetCurrentThreadId() As Integer
    '    End Function

    '    <DllImport("user32.dll")>
    '    Private Shared Function GetClassName(hWnd As IntPtr, buffer As StringBuilder, buflen As Integer) As Integer
    '    End Function

    '    <DllImport("user32.dll")>
    '    Private Shared Function GetDlgItem(hWnd As IntPtr, item As Integer) As IntPtr
    '    End Function

    '    <DllImport("user32.dll")>
    '    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wp As IntPtr, lp As IntPtr) As IntPtr
    '    End Function

    '    <DllImport("user32.dll")>
    '    Shared Function GetWindowRect(hWnd As IntPtr, ByRef rc As RECT) As Boolean
    '    End Function

    '    <DllImport("user32.dll")>
    '    Shared Function MoveWindow(hWnd As IntPtr, x As Integer, y As Integer, w As Integer, h As Integer, repaint As Boolean) As Boolean
    '    End Function

    '    Structure RECT
    '        Public Left As Integer
    '        Public Top As Integer
    '        Public Right As Integer
    '        Public Bottom As Integer
    '    End Structure

    '    Public Sub New(owner As Form, Optional Custom_Font As Font = Nothing)
    '        mOwner = owner
    '        mFont = Custom_Font
    '        owner.BeginInvoke(New MethodInvoker(AddressOf findDialog))
    '    End Sub

    '    Private Sub findDialog()

    '        ' Enumerate windows to find the message box
    '        If mTries < 0 Then
    '            Return
    '        End If

    '        Dim callback As New EnumThreadWndProc(AddressOf checkWindow)

    '        If EnumThreadWindows(GetCurrentThreadId(), callback, IntPtr.Zero) Then
    '            If System.Threading.Interlocked.Increment(mTries) < 10 Then
    '                mOwner.BeginInvoke(New MethodInvoker(AddressOf findDialog))
    '            End If
    '        End If

    '    End Sub

    '    Private Function checkWindow(hWnd As IntPtr, lp As IntPtr) As Boolean

    '        ' Checks if <hWnd> is a dialog
    '        Dim sb As New StringBuilder(260)
    '        GetClassName(hWnd, sb, sb.Capacity)
    '        If sb.ToString() <> "#32770" Then Return True

    '        ' Got it, get the STATIC control that displays the text
    '        Dim hText As IntPtr = GetDlgItem(hWnd, &HFFFF)

    '        Dim frmRect As New Rectangle(mOwner.Location, mOwner.Size)
    '        Dim dlgRect As RECT
    '        GetWindowRect(hWnd, dlgRect)
    '        MoveWindow(hWnd, frmRect.Left + (frmRect.Width - dlgRect.Right + dlgRect.Left) \ 2, frmRect.Top + (frmRect.Height - dlgRect.Bottom + dlgRect.Top) \ 2, dlgRect.Right - dlgRect.Left, dlgRect.Bottom - dlgRect.Top, True)
    '        If hText <> IntPtr.Zero Then

    '            If mFont Is Nothing Then
    '                ' Get the current font
    '                mFont = Font.FromHfont(SendMessage(hText, WM_GETFONT, IntPtr.Zero, IntPtr.Zero))
    '            End If

    '            SendMessage(hText, WM_SETFONT, mFont.ToHfont(), New IntPtr(1))

    '        End If

    '        ' Done
    '        Return False

    '    End Function

    '    Public Sub Dispose() Implements IDisposable.Dispose
    '        mTries = -1
    '        mOwner = Nothing
    '        If mFont IsNot Nothing Then mFont.Dispose()
    '    End Sub
    '    '  Using New CustomMessageBox(Me, New Font(New FontFamily("Lucida Console"), Font.SizeInPoints, FontStyle.Bold))
    '    '    MessageBox.Show("Test Text", "Test Title", MessageBoxButtons.OK)
    '    'End Using
    'End Class
#Region " Centered MessageBox Class"


    Private mTries As Integer = 0
    Private mOwner As Form
    Private mFont As Font

    ' P/Invoke declarations
    Private Const WM_SETFONT As Integer = &H30
    Private Const WM_GETFONT As Integer = &H31

    Friend Declare Function SetWindowPos Lib "user32" (ByVal hwnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As UInt32) As Boolean
    Private Delegate Function EnumThreadWndProc(hWnd As IntPtr, lp As IntPtr) As Boolean

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function EnumThreadWindows(tid As Integer, callback As EnumThreadWndProc, lp As IntPtr) As Boolean
    End Function

    <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function GetCurrentThreadId() As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function GetClassName(hWnd As IntPtr, buffer As StringBuilder, buflen As Integer) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function GetDlgItem(hWnd As IntPtr, item As Integer) As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wp As IntPtr, lp As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Shared Function GetWindowRect(hWnd As IntPtr, ByRef rc As RECT) As Boolean
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Shared Function MoveWindow(hWnd As IntPtr, x As Integer, y As Integer, w As Integer, h As Integer, repaint As Boolean) As Boolean
    End Function

    Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure

    Public Sub New(owner As Form, Optional Custom_Font As Font = Nothing)
        mOwner = owner
        mFont = Custom_Font
        owner.BeginInvoke(New MethodInvoker(AddressOf findDialog))
    End Sub

    Private Sub findDialog()

        ' Enumerate windows to find the message box
        If mTries < 0 Then
            Return
        End If

        Dim callback As New EnumThreadWndProc(AddressOf checkWindow)

        If EnumThreadWindows(GetCurrentThreadId(), callback, IntPtr.Zero) Then
            If System.Threading.Interlocked.Increment(mTries) < 10 Then
                mOwner.BeginInvoke(New MethodInvoker(AddressOf findDialog))
            End If
        End If

    End Sub

    Private Function checkWindow(hWnd As IntPtr, lp As IntPtr) As Boolean


        ' Checks if <hWnd> is a dialog
        Dim sb As New StringBuilder(260)
        GetClassName(hWnd, sb, sb.Capacity)
        If sb.ToString() <> "#32770" Then Return True


        ' Got it, get the STATIC control that displays the text
        Dim hText As IntPtr = GetDlgItem(hWnd, &HFFFF)

        Dim frmRect As New Rectangle(mOwner.Location, mOwner.Size)
        Dim dlgRect As RECT
        GetWindowRect(hWnd, dlgRect)
        MoveWindow(hWnd, frmRect.Left + (frmRect.Width - dlgRect.Right + dlgRect.Left) \ 2, frmRect.Top + (frmRect.Height - dlgRect.Bottom + dlgRect.Top) \ 2, dlgRect.Right - dlgRect.Left, dlgRect.Bottom - dlgRect.Top, True)
        If hText <> IntPtr.Zero Then

            If mFont Is Nothing Then
                ' Get the current font
                mFont = Font.FromHfont(SendMessage(SetWindowPos(hText, 0, 70, 30, 170, 30, 0), WM_GETFONT, IntPtr.Zero, IntPtr.Zero))
            End If

            SendMessage(hText, WM_SETFONT, mFont.ToHfont(), New IntPtr(1))

        End If

        ' Done
        Return False

    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        mTries = -1
        mOwner = Nothing
        If mFont IsNot Nothing Then mFont.Dispose()
    End Sub

End Class

#End Region
