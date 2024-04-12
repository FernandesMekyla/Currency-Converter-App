Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using reader As New StreamReader("D:\Output.txt")

            txtUSD.Text = If(reader.ReadLine(), "")
            txtINR.Text = If(reader.ReadLine(), "")
            txtEUR.Text = If(reader.ReadLine(), "")
            txtYEN.Text = If(reader.ReadLine(), "")
            txtGBP.Text = If(reader.ReadLine(), "")

        End Using
    End Sub

    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        Using writer As New StreamWriter("D:\Output.txt")

            writer.WriteLine(txtUSD.Text)
            writer.WriteLine(txtINR.Text)
            writer.WriteLine(txtEUR.Text)
            writer.WriteLine(txtYEN.Text)
            writer.WriteLine(txtGBP.Text)

        End Using
    End Sub
End Class
