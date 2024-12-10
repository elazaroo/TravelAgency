Imports System.IO

Public Class DestinationList
    Private Sub DestinationList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Configure the listview
        lvDestinations.Columns.Clear()
        lvDestinations.Columns.Add("NAME", 130, HorizontalAlignment.Left)
        lvDestinations.Columns.Add("GUIDE", 130, HorizontalAlignment.Left)
        lvDestinations.View = View.Details
        lvDestinations.FullRowSelect = True
        lvDestinations.GridLines = True

        Dim destinations As String() = File.ReadAllLines("Destinations.txt")
        For Each destination As String In destinations
            Dim destinationData As String() = destination.Split(",")
            Dim destinationObject As New Destinations(destinationData(0), destinationData(1))

            ' Add destinations to listview
            Dim item As New ListViewItem(destinationData(0))
            item.SubItems.Add(destinationData(1))
            lvDestinations.Items.Add(item)
        Next
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Delete selected item
        If lvDestinations.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lvDestinations.SelectedItems(0)
            Dim destinationName As String = selectedItem.Text
            Dim destinationGuide As String = selectedItem.SubItems(1).Text

            Dim destinations As String() = File.ReadAllLines("Destinations.txt")
            Dim newDestinations As New List(Of String)
            For Each destination As String In destinations
                Dim destinationData As String() = destination.Split(",")
                If destinationData(0) <> destinationName Then
                    newDestinations.Add(destination)
                End If
            Next

            File.WriteAllLines("Destinations.txt", newDestinations)
            lvDestinations.Items.Remove(selectedItem)
        End If
    End Sub
End Class