Imports System.IO

Public Class NewClient
    Public Sub SaveClient(ByVal cliente As Clients)
        Using writer As New StreamWriter("Clients.txt", True)
            Try
                writer.Write(cliente.toString)
                MessageBox.Show("Client saved succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error when saving client: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (String.IsNullOrEmpty(tbName.Text) Or String.IsNullOrEmpty(tbSurname.Text) Or String.IsNullOrEmpty(tbPhone.Text) Or String.IsNullOrEmpty(tbMoney.Text)) Then
            MessageBox.Show("You must fill all gaps")
        Else
            Dim client As New Clients(tbName.Text, tbSurname.Text, tbPhone.Text, Decimal.Parse(tbMoney.Text.Replace(".", ",")))
            SaveClient(client)
        End If
    End Sub
End Class