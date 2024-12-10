Imports System.IO
Public Class NewDestination

    Public Sub SaveDestination(ByVal destination As Destinations)
        Using writer As New StreamWriter("Destinations.txt", True)
            Try
                writer.Write(destination.ToString)
                writer.WriteLine()
                MessageBox.Show("Destination saved succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error when saving destination: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub bntSave_Click(sender As Object, e As EventArgs) Handles bntSave.Click
        If (String.IsNullOrEmpty(tbName.Text) Or String.IsNullOrEmpty(tbGuide.Text)) Then
            MessageBox.Show("You must fill all gaps")
        Else
            Dim destination As New Destinations(tbName.Text, tbGuide.Text)
            SaveDestination(destination)
        End If
    End Sub
End Class