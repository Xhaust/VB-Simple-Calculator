Public Class Form1
    Private Sub btnClick(sender As Object, e As EventArgs) Handles btn7.Click, btn8.Click, btn9.Click, btn6.Click, btn5.Click, btn4.Click, btn1.Click, btn2.Click, btn0.Click, btnDot.Click, btn3.Click, btnSubtract.Click, btnAdd.Click, btnMultiply.Click, btnDivide.Click, btnStartBracket.Click, btnEndBracket.Click, btnExponentiation.Click
        Dim btn As Button = CType(sender, Button)
        txtDisplay.Text &= btn.Text
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        txtDisplay.Text = New DataTable().Compute(txtDisplay.Text, Nothing).ToString()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Text = ""
    End Sub

    Private Sub btnErase_Click(sender As Object, e As EventArgs) Handles btnErase.Click
        txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1)
    End Sub

    Private Sub btnPlusMinus_Click(sender As Object, e As EventArgs) Handles btnPlusMinus.Click
        txtDisplay.Text = (-Convert.ToDouble(txtDisplay.Text)).ToString()
    End Sub
End Class
