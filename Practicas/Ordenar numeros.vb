Public Class Ordenar_numeros

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim num3 As Integer
        num1 = CInt(TextBox1.Text)
        num2 = CInt(TextBox2.Text)
        num3 = CInt(TextBox3.Text)
        If num1 > num2 And num2 > num3 Then
            Label2.Text = num1.ToString() + " - " + num2.ToString() + " - " + num3.ToString()
        ElseIf num1 > num3 And num3 > num2 Then
            Label2.Text = num1.ToString() + " - " + num3.ToString() + " - " + num2.ToString()
        ElseIf num2 > num1 And num1 > num3 Then
            Label2.Text = num2.ToString() + " - " + num1.ToString() + " - " + num3.ToString()
        ElseIf num2 > num3 And num3 > num1 Then
            Label2.Text = num2.ToString() + " - " + num3.ToString() + " - " + num1.ToString()
        ElseIf num3 > num1 And num1 > num2 Then
            Label2.Text = num3.ToString() + " - " + num1.ToString() + " - " + num2.ToString()
        Else
            Label2.Text = num3.ToString() + " - " + num2.ToString() + " - " + num1.ToString()

        End If

    End Sub
End Class