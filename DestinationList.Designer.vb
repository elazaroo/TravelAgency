<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DestinationList
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
        lblDestinations = New Label()
        lvDestinations = New ListView()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' lblDestinations
        ' 
        lblDestinations.AutoSize = True
        lblDestinations.Font = New Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDestinations.Location = New Point(12, 57)
        lblDestinations.Name = "lblDestinations"
        lblDestinations.Size = New Size(227, 36)
        lblDestinations.TabIndex = 2
        lblDestinations.Text = "Destinations"
        ' 
        ' lvDestinations
        ' 
        lvDestinations.Location = New Point(12, 118)
        lvDestinations.Name = "lvDestinations"
        lvDestinations.Size = New Size(549, 304)
        lvDestinations.TabIndex = 3
        lvDestinations.UseCompatibleStateImageBehavior = False
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(627, 359)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(161, 63)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' DestinationList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDelete)
        Controls.Add(lvDestinations)
        Controls.Add(lblDestinations)
        Name = "DestinationList"
        Text = "DestinationList"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblDestinations As Label
    Friend WithEvents lvDestinations As ListView
    Friend WithEvents btnDelete As Button
End Class
