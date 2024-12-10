Imports System.IO

Public Class NewTrip
    Private Sub NewTrip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDestination.Hide()
        cbDestination.Hide()
        dtpDate.Hide()
        btnSave.Hide()

        Dim arrClients As String() = File.ReadAllText("Clients.txt").Split("#"c)
        For Each sClient As String In arrClients
            If sClient = arrClients.Last() Then
                Continue For
            End If

            Dim arrClientData As String() = sClient.Split("€"c)
            Dim clientObject As New Clients(arrClientData(0), arrClientData(1), arrClientData(2), Decimal.Parse(arrClientData(3)))

            ' Add the client to the combobox
            cbClient.Items.Add(arrClientData(0) & " " & arrClientData(1))
        Next

        Dim arrDestinations As String() = File.ReadAllLines("Destinations.txt")
        For Each sDestination As String In arrDestinations
            Dim arrDestinationData As String() = sDestination.Split(","c)
            Dim destinationObject As New Destinations(arrDestinationData(0), arrDestinationData(1))

            ' Add the destination to the combobox
            cbDestination.Items.Add(arrDestinationData(0))
        Next
    End Sub

    Private Sub cbClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClient.SelectedIndexChanged
        lblDestination.Show()
        cbDestination.Show()
    End Sub

    Private Sub cbDestination_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDestination.SelectedIndexChanged
        dtpDate.Show()
        btnSave.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim sTimestamp As String = DateTime.Now.ToString("yyyy-MM-dd- HH-mm-ss")
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
            saveFileDialog.Title = "Save Trip"
            saveFileDialog.FileName = sTimestamp & ".txt"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim sFilePath As String = saveFileDialog.FileName

                Using writer As New StreamWriter(sFilePath, True)
                    writer.WriteLine(cbClient.SelectedItem.ToString() & " || " & cbDestination.SelectedItem.ToString() & " || " & dtpDate.Value.ToString("yyyy-MM-dd"))
                End Using

                MessageBox.Show("Trip Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Open file with notepad.exe
                Process.Start("notepad.exe", sFilePath)
            Else
                MessageBox.Show("Operation canceled", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error saving: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
