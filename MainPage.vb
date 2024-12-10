Public Class MainPage
    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClientList_Click(sender As Object, e As EventArgs) Handles btnClientList.Click
        ClientList.Show()
    End Sub

    Private Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles btnAddClient.Click
        NewClient.Show()
    End Sub

    Private Sub btnCLientsList_Click(sender As Object, e As EventArgs) Handles btnCLientsList.Click
        DestinationList.Show()
    End Sub

    Private Sub btnAddDestination_Click(sender As Object, e As EventArgs) Handles btnAddDestination.Click
        NewDestination.Show()
    End Sub

    Private Sub btnNewTrip_Click(sender As Object, e As EventArgs) Handles btnNewTrip.Click
        NewTrip.Show()
    End Sub
End Class
