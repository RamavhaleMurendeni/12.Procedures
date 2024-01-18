Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim firtNumber, secondNumber As Integer
        firtNumber = Val(TextBox1.Text)
        secondNumber = Val(TextBox2.Text)

        Sum(firtNumber, secondNumber)

    End Sub

    Sub Sum(a As Integer, b As Integer)
        Dim total = a + b

        total = a + b

        TextBox3.Text = total



    End Sub
End Class
