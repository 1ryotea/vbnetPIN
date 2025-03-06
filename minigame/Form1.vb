Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txt1.Text &= btn1.Text
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txt1.Text &= btn2.Text
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txt1.Text &= btn3.Text
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txt1.Text &= btn4.Text
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txt1.Text &= btn5.Text
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txt1.Text &= btn6.Text
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txt1.Text &= btn7.Text
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txt1.Text &= btn8.Text
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txt1.Text &= btn9.Text
    End Sub

    Private Sub btnZERO_Click(sender As Object, e As EventArgs) Handles btnZERO.Click
        txt1.Text &= btnZERO.Text
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txt1.Text.Length > 0 Then
            txt1.Text = txt1.Text.Remove(txt1.Text.Length - 1)
        End If

    End Sub
    Dim pin As Integer
    Private Sub SavePin(sender As Object, e As EventArgs) Handles btnSAVE.Click
        pin = txt1.Text
        MessageBox.Show("TERSIMPAN")
        txt1.Text = ""
        Console.WriteLine(pin)
        btncek.Visible = True
        btnSAVE.Visible = False
    End Sub

    Private Sub btncek_Click(sender As Object, e As EventArgs) Handles btncek.Click
        If txt1.Text = pin Then
            MessageBox.Show("Pin Benar")
        Else
            MessageBox.Show("Pin Salah")
        End If
        'messagebox digunakan untuk memuncul windows baru untuk menampilkan pesan
    End Sub
End Class
