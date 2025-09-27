Public Class Calculator
    Private Sub btnClick(sender As Object, e As EventArgs) Handles btn7.Click, btn8.Click, btn9.Click, btn6.Click, btn5.Click, btn4.Click, btn1.Click, btn2.Click, btn0.Click, btnDot.Click, btn3.Click, btnSubtract.Click, btnAdd.Click, btnMultiply.Click, btnDivide.Click, btnStartBracket.Click, btnEndBracket.Click, btnExponentiation.Click
        Dim btn As Button = CType(sender, Button)
        txtDisplay.Text &= btn.Text
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Try
            ' Use Math.Pow for exponentiation, since DataTable.Compute does not support it
            If txtDisplay.Text.Contains("^") Then
                Dim parts As String() = txtDisplay.Text.Split("^"c)
                If parts.Length = 2 Then
                    Dim base As Double = Convert.ToDouble(parts(0))
                    Dim exponent As Double = Convert.ToDouble(parts(1))
                    txtDisplay.Text = Math.Pow(base, exponent).ToString()
                End If
            End If
            previousTxtDisplay.Text = txtDisplay.Text
            txtDisplay.Text = New DataTable().Compute(txtDisplay.Text, Nothing).ToString()
        Catch ex As Exception
            MsgBox("Invalid Expression!")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Text = ""
    End Sub

    Private Sub btnErase_Click(sender As Object, e As EventArgs) Handles btnErase.Click
        If txtDisplay.Text.Length > 0 Then
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1)
        End If

    End Sub

    Private Sub btnPlusMinus_Click(sender As Object, e As EventArgs) Handles btnPlusMinus.Click
        Try
            txtDisplay.Text = (-Convert.ToDouble(txtDisplay.Text)).ToString()
        Catch ex As Exception
            MsgBox("This function cannot be used with expressions or brackets!")
        End Try
    End Sub
End Class
