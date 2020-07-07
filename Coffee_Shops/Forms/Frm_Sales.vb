Imports Domain


Public Class Frm_Sales
    Private sql As New SQLControl

    Private Sub Frm_Sales_Load(sender As Object, e As EventArgs) Handles Me.Load

        sql.LoadButton(Panel_Item, "select * from tbl_product")
        sql.LoadIconButton(Panel_Menu, "select * from tbl_category")
        ' Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        ' Lst_Data.Location = New System.Drawing.Point(Panel_Content.Location.Y, Panel_Content.Location.X)
        Lst_Data.Size = New System.Drawing.Size(Panel_Content.Width, Panel_Content.Height)

    End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		''Set view property
		Lst_data.View = View.Details
		Lst_data.GridLines = True
		Lst_data.FullRowSelect = True

		'Add column header
		'Lst_data.Columns.Add("ProductName", 100)
		'Lst_data.Columns.Add("Price", 70)
		'Lst_data.Columns.Add("Quantity", 70)

		'Add items in the listview
		Dim arr(3) As String
		Dim itm As ListViewItem

		'Add first item
		arr(0) = "product_1"
		arr(1) = "100"
		arr(2) = "10"
		itm = New ListViewItem(arr)
		Lst_data.Items.Add(itm)

		'Add second item
		arr(0) = "product_2"
		arr(1) = "200"
		arr(2) = "20"
		itm = New ListViewItem(arr)
		Lst_data.Items.Add(itm)


	End Sub
	Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click
		'Lst_data.View = View.Details
		'Lst_data.GridLines = True
		'Lst_data.FullRowSelect = True
		'''Add column header
		'Lst_data.Columns.Add("ProductName", 100)
		'Lst_data.Columns.Add("Price", 70)
		'Lst_data.Columns.Add("Quantity", 70)
		Dim ar() As String
		ar = {"1", "2", "3"}
		listViewItm(Lst_data, ar)
	End Sub

	Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
		Me.Close()
		Frm_Dashboard.Show()
	End Sub

	Public lst As ListView

	Function AddItems()
		'Dim lstModules As New ListBox()
		' if the object is nothing, create it
		'If lst Is Nothing Then
		'	lst = New ListView
		'End If
		lst.Items.Add("item_1")
		For Each lvi As ListViewItem In lst.Items
			lst.Items.Add("item_1")
		Next
		''ttps://stackoverflow.com/questions/1129066/adding-items-into-listbox-from-a-listview
	End Function
	'Add items in the listview
	Sub listViewItm(lst1 As Object, arr() As String)

		Dim itm As ListViewItem
		'Add first item


		itm = New ListViewItem(arr)
		lst1.Items.Add(itm)
	End Sub
End Class