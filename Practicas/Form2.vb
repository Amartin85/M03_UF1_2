Public Class Form2
    Dim op1 As Integer
    Dim op2 As Integer
    Dim res As New Random

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        op1 = CInt(TextBox1.Text())
        op2 = CInt(TextBox2.Text())

        TextBox3.Text = res.Next(op1, op2 + 1)

    End Sub
End Class