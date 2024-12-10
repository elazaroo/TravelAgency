<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewTrip
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        cbClient = New ComboBox()
        cbDestination = New ComboBox()
        lblClient = New Label()
        lblDestination = New Label()
        btnSave = New Button()
        dtpDate = New DateTimePicker()
        SuspendLayout()
        ' 
        ' cbClient
        ' 
        cbClient.FormattingEnabled = True
        cbClient.Location = New Point(51, 151)
        cbClient.Name = "cbClient"
        cbClient.Size = New Size(151, 28)
        cbClient.TabIndex = 0
        ' 
        ' cbDestination
        ' 
        cbDestination.FormattingEnabled = True
        cbDestination.Location = New Point(51, 246)
        cbDestination.Name = "cbDestination"
        cbDestination.Size = New Size(151, 28)
        cbDestination.TabIndex = 1
        ' 
        ' lblClient
        ' 
        lblClient.AutoSize = True
        lblClient.Location = New Point(51, 128)
        lblClient.Name = "lblClient"
        lblClient.Size = New Size(47, 20)
        lblClient.TabIndex = 2
        lblClient.Text = "Client"
        ' 
        ' lblDestination
        ' 
        lblDestination.AutoSize = True
        lblDestination.Location = New Point(51, 223)
        lblDestination.Name = "lblDestination"
        lblDestination.Size = New Size(85, 20)
        lblDestination.TabIndex = 3
        lblDestination.Text = "Destination"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(610, 214)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 5
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(301, 123)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(268, 27)
        dtpDate.TabIndex = 6
        ' 
        ' NewTrip
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dtpDate)
        Controls.Add(btnSave)
        Controls.Add(lblDestination)
        Controls.Add(lblClient)
        Controls.Add(cbDestination)
        Controls.Add(cbClient)
        Name = "NewTrip"
        Text = "NewTrip"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbClient As ComboBox
    Friend WithEvents cbDestination As ComboBox
    Friend WithEvents lblClient As Label
    Friend WithEvents lblDestination As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents dtpDate As DateTimePicker
End Class
