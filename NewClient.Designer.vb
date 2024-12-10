<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewClient
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
        tbSurname = New TextBox()
        lblSurname = New Label()
        tbPhone = New TextBox()
        lblPhone = New Label()
        tbMoney = New TextBox()
        lblMoney = New Label()
        btnSave = New Button()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(148, 115)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' tbName
        ' 
        tbName.Location = New Point(234, 115)
        tbName.Name = "tbName"
        tbName.Size = New Size(125, 27)
        tbName.TabIndex = 1
        ' 
        ' tbSurname
        ' 
        tbSurname.Location = New Point(234, 165)
        tbSurname.Name = "tbSurname"
        tbSurname.Size = New Size(125, 27)
        tbSurname.TabIndex = 3
        ' 
        ' lblSurname
        ' 
        lblSurname.AutoSize = True
        lblSurname.Location = New Point(148, 165)
        lblSurname.Name = "lblSurname"
        lblSurname.Size = New Size(67, 20)
        lblSurname.TabIndex = 2
        lblSurname.Text = "Surname"
        ' 
        ' tbPhone
        ' 
        tbPhone.Location = New Point(234, 221)
        tbPhone.Name = "tbPhone"
        tbPhone.Size = New Size(125, 27)
        tbPhone.TabIndex = 5
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(148, 221)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(50, 20)
        lblPhone.TabIndex = 4
        lblPhone.Text = "Phone"
        ' 
        ' tbMoney
        ' 
        tbMoney.Location = New Point(234, 280)
        tbMoney.Name = "tbMoney"
        tbMoney.Size = New Size(125, 27)
        tbMoney.TabIndex = 7
        ' 
        ' lblMoney
        ' 
        lblMoney.AutoSize = True
        lblMoney.Location = New Point(148, 280)
        lblMoney.Name = "lblMoney"
        lblMoney.Size = New Size(54, 20)
        lblMoney.TabIndex = 6
        lblMoney.Text = "Money"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(499, 203)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 8
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' NewClient
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSave)
        Controls.Add(tbMoney)
        Controls.Add(lblMoney)
        Controls.Add(tbPhone)
        Controls.Add(lblPhone)
        Controls.Add(tbSurname)
        Controls.Add(lblSurname)
        Controls.Add(tbName)
        Controls.Add(lblName)
        Name = "NewClient"
        Text = "NewClient"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents tbSurname As TextBox
    Friend WithEvents lblSurname As Label
    Friend WithEvents tbPhone As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents tbMoney As TextBox
    Friend WithEvents lblMoney As Label
    Friend WithEvents btnSave As Button
End Class
