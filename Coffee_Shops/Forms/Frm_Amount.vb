Public Class Frm_Amount


    Public Function subtot() As Double
        Dim i As Integer
        Dim j, k As Double
        i = 0
        j = 0
        k = 0

        Try
            j = Frm_Sale_Temp.Lst_data.Items.Count
            For i = 0 To j - 1
                k = k + CDbl(RTrim(Frm_Sale_Temp.Lst_data.Items(i).SubItems(6).Text))

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return k

    End Function


    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Dim ls As Integer
        Dim lst As New ListViewItem(ls)
        Dim temp As Integer

        Try
            For j = 0 To temp - 1
                If (Frm_Sale_Temp.Lst_data.Items(j).SubItems(1).Text = Frm_Sale_Temp.DVG_Product.SelectedCells(0).Value.ToString) Then
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
            'If Val(Frm_Sale_Temp.DVG_Product.SelectedCells(2).Value.ToString) < Val(Text_Amount.Text) Then
            '    MessageBox.Show("Amount was gather than amount in stock", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Me.Text_Amount.Text = ""
            '    Text_Amount.Focus()
            '    Exit Sub
            'End If

            If Text_Amount.Text = Nothing Then
                MsgBox("Please insert Amount!")
                Text_Amount.Text = ""
                Text_Amount.Focus()
                Exit Sub

            Else

                lst.SubItems.Add(Frm_Sale_Temp.DVG_Product.SelectedCells(0).Value.ToString)
                lst.SubItems.Add(Frm_Sale_Temp.DVG_Product.SelectedCells(1).Value.ToString)
                lst.SubItems.Add(Frm_Sale_Temp.DVG_Product.SelectedCells(2).Value.ToString)
                lst.SubItems.Add(Frm_Sale_Temp.DVG_Product.SelectedCells(3).Value.ToString)
                lst.SubItems.Add(Text_Amount.Text)

                lst.SubItems.Add(Text_Amount.Text * Frm_Sale_Temp.DVG_Product.SelectedCells(3).Value.ToString)
                Frm_Sale_Temp.Lst_data.Items.Add(lst)

                'Frm_Sale_Temp.Text_Subtotal.Text = subtot()
                Frm_Sale_Temp.Txt_SubTotal.Text = subtot()
                'Frm_Sale_Temp.paid()
                Text_Amount.Text = ""
                Text_Amount.Focus()
            End If
            Me.Close()
        Catch ex As Exception
            MsgBox("You Must Input Only Number")
            Text_Amount.Text = ""
            Text_Amount.Focus()
        End Try
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub


End Class