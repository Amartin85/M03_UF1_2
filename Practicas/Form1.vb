Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim op1 As Integer
        Dim op2 As Integer
        Dim op3 As Integer
        Dim menor As Integer

        op1 = CInt(TextBox1.Text())
        op2 = CInt(TextBox2.Text())
        op3 = CInt(TextBox3.Text())

        If (op1 < op2) And (op1 < op3) Then

            menor = op1
        ElseIf (op2 < op1) And (op2 < op3) Then
            menor = op2
        Else
            menor = op3

        End If

        TextBox4.Text = menor.ToString()


    End Sub
End Class
