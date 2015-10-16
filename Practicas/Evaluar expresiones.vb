Public Class Evaluar_expresiones
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim expresion As Boolean
        Dim a As Boolean = False
        Dim b As Boolean = True
        expresion = ((5 + 2) < 8) And a
        MessageBox.Show(expresion)
    End Sub
End Class