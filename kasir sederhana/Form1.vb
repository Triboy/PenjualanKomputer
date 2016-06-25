Public Class Form1

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged, ComboBox5.SelectedIndexChanged, ComboBox4.SelectedIndexChanged, ComboBox3.SelectedIndexChanged, ComboBox2.SelectedIndexChanged
        If ComboBox1.Text = "Acer N57C" Then
            nmbarang.Text = "Acer Aspire One Happy N57C"
            harga.Text = "1400000"
            stock1.Text = "50"
        ElseIf ComboBox1.Text = "Asus 1015B" Then
            nmbarang.Text = "Asus Eee PC 1015B"
            harga.Text = "1427000"
            stock2.Text = "40"
        ElseIf ComboBox1.Text = "Lenovo S10" Then
            nmbarang.Text = "Lenovo Ideapad S10"
            harga.Text = "1500000"
            stock3.Text = "30"
        ElseIf ComboBox1.Text = "Acer D270" Then
            nmbarang.Text = "Acer Aspire One D270"
            harga.Text = "2725000"
            stock4.Text = "25"
        ElseIf ComboBox1.Text = "Toshiba L640" Then
            nmbarang.Text = "Toshiba Satellite L640-1181"
            harga.Text = "3200000"
            stock5.Text = "20"
        ElseIf ComboBox1.Text = "Dell 3442" Then
            nmbarang.Text = "Dell Inspiron 14-3442"
            harga.Text = "3300000"
            stock6.Text = "15"

        End If
        If ComboBox2.Text = "Acer N57C" Then
            nmbarang1.Text = "Acer Aspire One Happy N57C"
            harga1.Text = "1400000"
        ElseIf ComboBox2.Text = "Asus 1015B" Then
            nmbarang1.Text = "Asus Eee PC 1015B"
            harga1.Text = "1427000"
        ElseIf ComboBox2.Text = "Lenovo S10" Then
            nmbarang1.Text = "Lenovo Ideapad S10"
            harga1.Text = "1500000"
        ElseIf ComboBox2.Text = "Acer D270" Then
            nmbarang1.Text = "Acer Aspire One D270"
            harga1.Text = "2725000"
        ElseIf ComboBox2.Text = "Toshiba L640" Then
            nmbarang1.Text = "Toshiba Satellite L640-1181"
            harga1.Text = "3200000"
        ElseIf ComboBox2.Text = "Dell 3442" Then
            nmbarang1.Text = "Dell Inspiron 14-3442"
            harga1.Text = "3300000"

        End If

        If ComboBox3.Text = "Acer N57C" Then
            nmbarang2.Text = "Acer Aspire One Happy N57C"
            harga2.Text = "1400000"
        ElseIf ComboBox3.Text = "Asus 1015B" Then
            nmbarang2.Text = "Asus Eee PC 1015B"
            harga2.Text = "1427000"
        ElseIf ComboBox3.Text = "Lenovo S10" Then
            nmbarang2.Text = "Lenovo Ideapad S10"
            harga2.Text = "1500000"
        ElseIf ComboBox3.Text = "Acer D270" Then
            nmbarang2.Text = "Acer Aspire One D270"
            harga2.Text = "2725000"
        ElseIf ComboBox3.Text = "Toshiba L640" Then
            nmbarang2.Text = "Toshiba Satellite L640-1181"
            harga2.Text = "3200000"
        ElseIf ComboBox3.Text = "Dell 3442" Then
            nmbarang2.Text = "Dell Inspiron 14-3442"
            harga2.Text = "3300000"

        End If

        If ComboBox4.Text = "Acer N57C" Then
            nmbarang3.Text = "Acer Aspire One Happy N57C"
            harga3.Text = "1400000"
        ElseIf ComboBox4.Text = "Asus 1015B" Then
            nmbarang3.Text = "Asus Eee PC 1015B"
            harga3.Text = "1427000"
        ElseIf ComboBox4.Text = "Lenovo S10" Then
            nmbarang3.Text = "Lenovo Ideapad S10"
            harga3.Text = "1500000"
        ElseIf ComboBox4.Text = "Acer D270" Then
            nmbarang3.Text = "Acer Aspire One D270"
            harga3.Text = "2725000"
        ElseIf ComboBox4.Text = "Toshiba L640" Then
            nmbarang3.Text = "Toshiba Satellite L640-1181"
            harga3.Text = "3200000"
        ElseIf ComboBox4.Text = "Dell 3442" Then
            nmbarang3.Text = "Dell Inspiron 14-3442"
            harga3.Text = "3300000"

        End If

        If ComboBox5.Text = "Acer N57C" Then
            nmbarang4.Text = "Acer Aspire One Happy N57C"
            harga4.Text = "1400000"
        ElseIf ComboBox5.Text = "Asus 1015B" Then
            nmbarang4.Text = "Asus Eee PC 1015B"
            harga4.Text = "1427000"
        ElseIf ComboBox5.Text = "Lenovo S10" Then
            nmbarang4.Text = "Lenovo Ideapad S10"
            harga4.Text = "1500000"
        ElseIf ComboBox5.Text = "Acer D270" Then
            nmbarang4.Text = "Acer Aspire One D270"
            harga4.Text = "2725000"
        ElseIf ComboBox5.Text = "Toshiba L640" Then
            nmbarang4.Text = "Toshiba Satellite L640-1181"
            harga4.Text = "3200000"
        ElseIf ComboBox5.Text = "Dell 3442" Then
            nmbarang4.Text = "Dell Inspiron 14-3442"
            harga4.Text = "3300000"

        End If
    End Sub

    Private Sub bayar_Click(sender As Object, e As EventArgs) Handles bayar.Click
        total.Text = Val(harga.Text) * Val(orderan.Text) - ((Val(harga.Text) * Val(orderan.Text) / 100) * Val(diskon.Text))
        total1.Text = Val(harga1.Text) * Val(orderan1.Text) - ((Val(harga1.Text) * Val(orderan1.Text) / 100) * Val(diskon1.Text))
        total2.Text = Val(harga2.Text) * Val(orderan2.Text) - ((Val(harga2.Text) * Val(orderan2.Text) / 100) * Val(diskon2.Text))
        total3.Text = Val(harga3.Text) * Val(orderan3.Text) - ((Val(harga3.Text) * Val(orderan3.Text) / 100) * Val(diskon3.Text))
        total4.Text = Val(harga4.Text) * Val(orderan4.Text) - ((Val(harga4.Text) * Val(orderan4.Text) / 100) * Val(diskon4.Text))
        stock1.Text = Val(stock1.Text) - Val(orderan.Text)
        stock2.Text = Val(stock2.Text) - Val(orderan.Text)
        stock3.Text = Val(stock3.Text) - Val(orderan.Text)
        stock4.Text = Val(stock4.Text) - Val(orderan.Text)
        stock5.Text = Val(stock5.Text) - Val(orderan.Text)
        stock6.Text = Val(stock6.Text) - Val(orderan.Text)
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        ComboBox3.ResetText()
        ComboBox4.ResetText()
        ComboBox5.ResetText()
        nmbarang.Clear()
        nmbarang1.Clear()
        nmbarang2.Clear()
        nmbarang3.Clear()
        nmbarang4.Clear()
        harga.Clear()
        harga1.Clear()
        harga2.Clear()
        harga3.Clear()
        harga4.Clear()
        diskon.Clear()
        diskon1.Clear()
        diskon2.Clear()
        diskon3.Clear()
        diskon4.Clear()
        total.Clear()
        total1.Clear()
        total2.Clear()
        total3.Clear()
        total4.Clear()
        orderan.Clear()
        orderan1.Clear()
        orderan2.Clear()
        orderan3.Clear()
        orderan4.Clear()
        diskon.Focus()
        diskon1.Focus()
        diskon2.Focus()
        diskon3.Focus()
        diskon4.Focus()
        totall.Clear()
        kembali.Clear()
        tunai.Clear()
    End Sub

    Private Sub tutup_Click(sender As Object, e As EventArgs) Handles tutup.Click
        Me.Close()
    End Sub

    Private Sub diskon_TextChanged(sender As Object, e As EventArgs) Handles diskon.TextChanged, diskon2.TextChanged, diskon1.TextChanged, diskon4.TextChanged, diskon3.TextChanged

    End Sub

    Private Sub total_TextChanged(sender As Object, e As EventArgs) Handles total.TextChanged, total4.TextChanged, total3.TextChanged, total2.TextChanged, total1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub hitung_Click(sender As Object, e As EventArgs) Handles hitung.Click
        kembali.Text = Val(tunai.Text) - Val(totall.Text)
    End Sub

    Private Sub nmbarang_TextChanged(sender As Object, e As EventArgs) Handles nmbarang.TextChanged, nmbarang3.TextChanged, nmbarang2.TextChanged, nmbarang4.TextChanged, nmbarang1.TextChanged, nmbarang1.Click

    End Sub

    Private Sub orderan_TextChanged(sender As Object, e As EventArgs) Handles orderan.TextChanged

    End Sub

    Private Sub harga_TextChanged(sender As Object, e As EventArgs) Handles harga.TextChanged

    End Sub

    Private Sub totall_TextChanged(sender As Object, e As EventArgs) Handles totall.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        totall.Text = Val(total.Text) + Val(total1.Text) + Val(total2.Text) + Val(total3.Text) + Val(total4.Text)
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub nama_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub stock2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub stock6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub f_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub stock1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ca_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub orderan4_TextChanged(sender As Object, e As EventArgs) Handles orderan4.TextChanged

    End Sub

    Private Sub harga4_TextChanged(sender As Object, e As EventArgs) Handles harga4.TextChanged

    End Sub

    Private Sub orderan3_TextChanged(sender As Object, e As EventArgs) Handles orderan3.TextChanged

    End Sub

    Private Sub harga3_TextChanged(sender As Object, e As EventArgs) Handles harga3.TextChanged

    End Sub

    Private Sub orderan2_TextChanged(sender As Object, e As EventArgs) Handles orderan2.TextChanged

    End Sub

    Private Sub harga2_TextChanged(sender As Object, e As EventArgs) Handles harga2.TextChanged

    End Sub

    Private Sub orderan1_TextChanged(sender As Object, e As EventArgs) Handles orderan1.TextChanged

    End Sub

    Private Sub harga1_TextChanged(sender As Object, e As EventArgs) Handles harga1.TextChanged

    End Sub

    Private Sub kembali_TextChanged(sender As Object, e As EventArgs) Handles kembali.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub tunai_TextChanged(sender As Object, e As EventArgs) Handles tunai.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        waktu.Text = Format(Now, "HH:mm:ss")
        tanggal.Text = Format(Now, "dd / MMM / yyyy")
        Timer1.Enabled = True
    End Sub
End Class
