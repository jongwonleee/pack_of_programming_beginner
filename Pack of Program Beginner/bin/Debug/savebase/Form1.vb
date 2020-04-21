Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b As Integer
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        Text.text = a + b
    End Sub
End Class
