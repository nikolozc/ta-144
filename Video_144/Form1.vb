Public Class Form1
    Private myThread As Threading.Thread
    Private Sub btnThread_Click(sender As Object, e As EventArgs) Handles btnThread.Click
        myThread = New Threading.Thread(AddressOf showMessage)
        myThread.Start()
    End Sub

    Private Sub showMessage()
        MessageBox.Show("I am on thread myThread")

    End Sub
End Class
