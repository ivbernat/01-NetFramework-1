Public Class Form1

    Private Sub ButtonGetTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGetTime.Click
        TextBoxTime.Text = ProvideTime.TimeProvider.Getdatetime()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
