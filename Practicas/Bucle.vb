Public Class Bucle
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        Dim salida As String = ""
        Dim cont As Integer
        Dim parcial As Integer

        num = TextBox1.Text

        For cont = 0 To 10
            parcial = num * cont
            salida = salida + num.ToString() + "x" + cont.ToString() + "=" + parcial.ToString() + " / " + Environment.NewLine
        Next
        MessageBox.Show(salida)

    End Sub
End Class