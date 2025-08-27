<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btn0 = New Button()
        btn1 = New Button()
        btn2 = New Button()
        btn3 = New Button()
        btn4 = New Button()
        btn5 = New Button()
        btn6 = New Button()
        btn7 = New Button()
        btn8 = New Button()
        btn9 = New Button()
        TextBox1 = New TextBox()
        btnDot = New Button()
        btnSubtract = New Button()
        btnAdd = New Button()
        btnEqual = New Button()
        SuspendLayout()
        ' 
        ' btn0
        ' 
        btn0.Location = New Point(12, 224)
        btn0.Name = "btn0"
        btn0.Size = New Size(56, 25)
        btn0.TabIndex = 0
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(12, 193)
        btn1.Name = "btn1"
        btn1.Size = New Size(25, 25)
        btn1.TabIndex = 1
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Location = New Point(43, 193)
        btn2.Name = "btn2"
        btn2.Size = New Size(25, 25)
        btn2.TabIndex = 2
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Location = New Point(74, 193)
        btn3.Name = "btn3"
        btn3.Size = New Size(25, 25)
        btn3.TabIndex = 3
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Location = New Point(12, 162)
        btn4.Name = "btn4"
        btn4.Size = New Size(25, 25)
        btn4.TabIndex = 4
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Location = New Point(43, 162)
        btn5.Name = "btn5"
        btn5.Size = New Size(25, 25)
        btn5.TabIndex = 5
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Location = New Point(74, 162)
        btn6.Name = "btn6"
        btn6.Size = New Size(25, 25)
        btn6.TabIndex = 6
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Location = New Point(12, 131)
        btn7.Name = "btn7"
        btn7.Size = New Size(25, 25)
        btn7.TabIndex = 7
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Location = New Point(43, 131)
        btn8.Name = "btn8"
        btn8.Size = New Size(25, 25)
        btn8.TabIndex = 8
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Location = New Point(74, 131)
        btn9.Name = "btn9"
        btn9.Size = New Size(25, 25)
        btn9.TabIndex = 9
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(149, 23)
        TextBox1.TabIndex = 10
        ' 
        ' btnDot
        ' 
        btnDot.Location = New Point(74, 224)
        btnDot.Name = "btnDot"
        btnDot.Size = New Size(25, 25)
        btnDot.TabIndex = 11
        btnDot.Text = "."
        btnDot.UseVisualStyleBackColor = True
        ' 
        ' btnSubtract
        ' 
        btnSubtract.Location = New Point(105, 193)
        btnSubtract.Name = "btnSubtract"
        btnSubtract.Size = New Size(25, 25)
        btnSubtract.TabIndex = 12
        btnSubtract.Text = "-"
        btnSubtract.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(105, 224)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(25, 25)
        btnAdd.TabIndex = 13
        btnAdd.Text = "+"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnEqual
        ' 
        btnEqual.Location = New Point(136, 193)
        btnEqual.Name = "btnEqual"
        btnEqual.Size = New Size(25, 56)
        btnEqual.TabIndex = 14
        btnEqual.Text = "="
        btnEqual.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(173, 261)
        Controls.Add(btnEqual)
        Controls.Add(btnAdd)
        Controls.Add(btnSubtract)
        Controls.Add(btnDot)
        Controls.Add(TextBox1)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(btn0)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn0 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnDot As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEqual As Button

End Class
