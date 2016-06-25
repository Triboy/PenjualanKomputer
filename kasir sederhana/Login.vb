Public Class Login
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged, username.TextChanged

    End Sub

    Private Sub cancel(sender As Object, e As EventArgs)
    End Sub

    Private Sub masuk_Click(sender As Object, e As EventArgs) Handles masuk.Click
        If username.Text = "" Then
            MsgBox("Username Kosong")
        ElseIf password.Text = "" Then
            MsgBox("Password Kosong")
        Else
            If username.Text = "pransisco" And password.Text = "triboy" Then
                MsgBox("Berhasil Login")
                Form1.Show()

            Else
                MsgBox("Data Tidak Ditemukan")

            End If
        End If
    End Sub
    Dim pesan As Integer
    Private Sub batal_Click(sender As Object, e As EventArgs) Handles batal.Click
        pesan = MsgBox("Yakin ingin Keluar ???", vbYesNo + vbQuestion, "Peringatan!")
        If pesan = vbYes Then
            End
        End If
    End Sub

End Class