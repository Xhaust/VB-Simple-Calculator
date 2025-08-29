Public Class Form1
    Dim firstValue, secondValue, result As Double

    Private Sub numClick(sender As Object, e As EventArgs) Handles btn7.Click, btn3.Click, btn2.Click, btn5.Click, btn8.Click, btn9.Click, btn6.Click, btn4.Click, btn1.Click, btn0.Click, btnDot.Click
        txtDisplay.Text = txtDisplay.Text & sender.text
    End Sub
End Class
