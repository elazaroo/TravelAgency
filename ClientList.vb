Imports System.IO

Public Class ClientList
    Private Sub ClientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Configure the listview
        lvClients.Columns.Clear()
        lvClients.Columns.Add("NAME", 130, HorizontalAlignment.Left)
        lvClients.Columns.Add("SURNAME", 130, HorizontalAlignment.Left)
        lvClients.Columns.Add("PHONE", 130, HorizontalAlignment.Left)
        lvClients.Columns.Add("MONEY", 130, HorizontalAlignment.Left)
        lvClients.View = View.Details
        lvClients.FullRowSelect = True
        lvClients.GridLines = True

        Dim clients As String() = File.ReadAllText("Clients.txt").Split("#")
        For Each client As String In clients
            If client = clients.Last() Then
                Continue For
            End If

            Dim clientData As String() = client.Split("€")
            Dim clientObject As New Clients(clientData(0), clientData(1), clientData(2), Decimal.Parse(clientData(3)))

            ' Add the client to the listview
            Dim item As New ListViewItem(clientData(0))
            item.SubItems.Add(clientData(1))
            item.SubItems.Add(clientData(2))
            item.SubItems.Add(clientData(3))
            lvClients.Items.Add(item)

        Next
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Delete the selected client
        If lvClients.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a client to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim clientName As String = lvClients.SelectedItems(0).Text
        Dim clientSurname As String = lvClients.SelectedItems(0).SubItems(1).Text
        Dim clientPhone As String = lvClients.SelectedItems(0).SubItems(2).Text
        Dim clientMoney As Decimal = Decimal.Parse(lvClients.SelectedItems(0).SubItems(3).Text)

        Dim clients As String() = File.ReadAllText("Clients.txt").Split("#")
        Dim newClients As String = ""
        For Each client As String In clients
            If client = clients.Last() Then
                Continue For
            End If

            Dim clientData As String() = client.Split("€")
            If clientData(0) = clientName AndAlso clientData(1) = clientSurname AndAlso clientData(2) = clientPhone AndAlso Decimal.Parse(clientData(3)) = clientMoney Then
                Continue For
            End If

            newClients += client + "#"
        Next

        File.WriteAllText("Clients.txt", newClients)
        MessageBox.Show("Client deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        lvClients.Items.Clear()
        ClientList_Load(sender, e)
    End Sub
End Class