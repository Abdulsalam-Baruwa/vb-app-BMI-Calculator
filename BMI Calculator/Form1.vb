
Public Class Form1
    Private Function BMI(Height As Single, weight As Single) As Double
        BMI = weight / Height ^ 2
    End Function


    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim h As Single, w As Single
        h = Val(TextBox1.Text)
        w = Val(TextBox2.Text)
        TextBox3.Text = BMI(h, w)

        If TextBox3.Text < 18.5 Then
            MsgBox("YOU ARE UNDERWEIGHTED. ")
        ElseIf TextBox3.Text = 18.5 And TextBox3.Text < 25 Then
            MsgBox("YOU HAVE A NORMAL WEIGHT. ")
        ElseIf TextBox3.Text = 25 And TextBox3.Text < 30 Then
            MsgBox("YOU ARE OVERWEIGHTED. ")
        ElseIf TextBox3.Text > 30 Then
            MsgBox("YOU HAVE OBESITY. ")

        Else
            MsgBox(" WE ARE UNABLE TO DETERMINE YOUR BODY MASS INDEX. ")
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""


    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("This Application Calculates Body Mass Index by dividing the weight of an individual by the square of the height. Then it Interprets it.")

    End Sub
End Class
