<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientList
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
        lvClients = New ListView()
        lblClients = New Label()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' lvClients
        ' 
        lvClients.Location = New Point(12, 125)
        lvClients.Name = "lvClients"
        lvClients.Size = New Size(533, 304)
        lvClients.TabIndex = 0
        lvClients.UseCompatibleStateImageBehavior = False
        ' 
        ' lblClients
        ' 
        lblClients.AutoSize = True
        lblClients.Font = New Font("Verdana", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblClients.Location = New Point(12, 54)
        lblClients.Name = "lblClients"
        lblClients.Size = New Size(130, 36)
        lblClients.TabIndex = 1
        lblClients.Text = "Clients"
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(627, 366)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(161, 63)
        btnDelete.TabIndex = 2
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' ClientList
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDelete)
        Controls.Add(lblClients)
        Controls.Add(lvClients)
        Name = "ClientList"
        Text = "ClientList"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lvClients As ListView
    Friend WithEvents lblClients As Label
    Friend WithEvents btnDelete As Button
End Class
