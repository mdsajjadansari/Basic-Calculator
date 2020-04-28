Public Class Form1

    Dim a, b, c As Integer


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        a = TextBox1.Text
        b = TextBox2.Text
        c = a + b
        TextBox3.Text = c
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = Date.Now.ToString("dd/MM/yyyy")

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        a = TextBox1.Text
        b = TextBox2.Text
        c = a * b
        TextBox3.Text = c
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        a = TextBox1.Text
        b = TextBox2.Text
        c = a / b
        TextBox3.Text = c
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        a = TextBox1.Text
        b = TextBox2.Text
        c = a - b
        TextBox3.Text = c
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
End Class
