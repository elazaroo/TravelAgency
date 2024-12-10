<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewDestination
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
        lblName = New Label()
        tbName = New TextBox()
        tbGuide = New TextBox()
        lblGuide = New Label()
        bntSave = New Button()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(171, 169)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' tbName
        ' 
        tbName.Location = New Point(299, 166)
        tbName.Name = "tbName"
        tbName.Size = New Size(125, 27)
        tbName.TabIndex = 1
        ' 
        ' tbGuide
        ' 
        tbGuide.Location = New Point(299, 229)
        tbGuide.Name = "tbGuide"
        tbGuide.Size = New Size(125, 27)
        tbGuide.TabIndex = 3
        ' 
        ' lblGuide
        ' 
        lblGuide.AutoSize = True
        lblGuide.Location = New Point(171, 232)
        lblGuide.Name = "lblGuide"
        lblGuide.Size = New Size(48, 20)
        lblGuide.TabIndex = 2
        lblGuide.Text = "Guide"
        ' 
        ' bntSave
        ' 
        bntSave.Location = New Point(521, 191)
        bntSave.Name = "bntSave"
        bntSave.Size = New Size(94, 29)
        bntSave.TabIndex = 4
        bntSave.Text = "Save"
        bntSave.UseVisualStyleBackColor = True
        ' 
        ' NewDestination
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(bntSave)
        Controls.Add(tbGuide)
        Controls.Add(lblGuide)
        Controls.Add(tbName)
        Controls.Add(lblName)
        Name = "NewDestination"
        Text = "NewDestination"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents tbGuide As TextBox
    Friend WithEvents lblGuide As Label
    Friend WithEvents bntSave As Button
End Class
