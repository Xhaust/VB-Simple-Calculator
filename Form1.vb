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

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If operatorClicked = "+" Then
            secondValue = Val(txtDisplay.Text)
            result = firstValue + secondValue
            txtDisplay.Text = result
        ElseIf operatorClicked = "-" Then
            secondValue = Val(txtDisplay.Text)
            result = firstValue - secondValue
            txtDisplay.Text = result
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Text = ""
    End Sub
End Class
