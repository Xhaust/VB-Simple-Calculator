Public Class Form1
    Dim firstValue, secondValue, result As Double
    Dim operatorClicked As String

    Private Sub numClick(sender As Object, e As EventArgs) Handles btn7.Click, btn3.Click, btn2.Click, btn5.Click, btn8.Click, btn9.Click, btn6.Click, btn4.Click, btn1.Click, btn0.Click, btnDot.Click
        Dim btn As Button = CType(sender, Button)
        txtDisplay.Text &= btn.Text
    End Sub

    Private Sub operatorClick(sender As Object, e As EventArgs) Handles btnSubtract.Click, btnAdd.Click
        Dim btn As Button = CType(sender, Button)
        operatorClicked = btn.Text
        firstValue = Val(txtDisplay.Text)
        txtDisplay.Text = ""
    End Sub
End Class
