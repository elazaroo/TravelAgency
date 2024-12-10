<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitle = New Label()
        btnClientList = New Button()
        lblTextClient = New Label()
        btnAddClient = New Button()
        lblTextDestination = New Label()
        btnCLientsList = New Button()
        btnAddDestination = New Button()
        lblNewTrip = New Label()
        btnNewTrip = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(212, 18)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(340, 48)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Travel Agency"
        ' 
        ' btnClientList
        ' 
        btnClientList.Location = New Point(47, 215)
        btnClientList.Name = "btnClientList"
        btnClientList.Size = New Size(94, 29)
        btnClientList.TabIndex = 1
        btnClientList.Text = "Client List"
        btnClientList.UseVisualStyleBackColor = True
        ' 
        ' lblTextClient
        ' 
        lblTextClient.AutoSize = True
        lblTextClient.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTextClient.Location = New Point(47, 159)
        lblTextClient.Name = "lblTextClient"
        lblTextClient.Size = New Size(106, 20)
        lblTextClient.TabIndex = 2
        lblTextClient.Text = "Client Actions"
        ' 
        ' btnAddClient
        ' 
        btnAddClient.Location = New Point(47, 289)
        btnAddClient.Name = "btnAddClient"
        btnAddClient.Size = New Size(94, 29)
        btnAddClient.TabIndex = 3
        btnAddClient.Text = "Add Client"
        btnAddClient.UseVisualStyleBackColor = True
        ' 
        ' lblTextDestination
        ' 
        lblTextDestination.AutoSize = True
        lblTextDestination.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTextDestination.Location = New Point(317, 159)
        lblTextDestination.Name = "lblTextDestination"
        lblTextDestination.Size = New Size(147, 20)
        lblTextDestination.TabIndex = 4
        lblTextDestination.Text = "Destination Actions"
        ' 
        ' btnCLientsList
        ' 
        btnCLientsList.Location = New Point(317, 215)
        btnCLientsList.Name = "btnCLientsList"
        btnCLientsList.Size = New Size(150, 29)
        btnCLientsList.TabIndex = 5
        btnCLientsList.Text = "Destination List"
        btnCLientsList.UseVisualStyleBackColor = True
        ' 
        ' btnAddDestination
        ' 
        btnAddDestination.Location = New Point(317, 289)
        btnAddDestination.Name = "btnAddDestination"
        btnAddDestination.Size = New Size(150, 29)
        btnAddDestination.TabIndex = 6
        btnAddDestination.Text = "Add Destination"
        btnAddDestination.UseVisualStyleBackColor = True
        ' 
        ' lblNewTrip
        ' 
        lblNewTrip.AutoSize = True
        lblNewTrip.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNewTrip.Location = New Point(627, 159)
        lblNewTrip.Name = "lblNewTrip"
        lblNewTrip.Size = New Size(80, 20)
        lblNewTrip.TabIndex = 7
        lblNewTrip.Text = "Plan a trip"
        ' 
        ' btnNewTrip
        ' 
        btnNewTrip.Location = New Point(594, 215)
        btnNewTrip.Name = "btnNewTrip"
        btnNewTrip.Size = New Size(150, 29)
        btnNewTrip.TabIndex = 8
        btnNewTrip.Text = "New Trip"
        btnNewTrip.UseVisualStyleBackColor = True
        ' 
        ' MainPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnNewTrip)
        Controls.Add(lblNewTrip)
        Controls.Add(btnAddDestination)
        Controls.Add(btnCLientsList)
        Controls.Add(lblTextDestination)
        Controls.Add(btnAddClient)
        Controls.Add(lblTextClient)
        Controls.Add(btnClientList)
        Controls.Add(lblTitle)
        Name = "MainPage"
        Text = "MainPage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClientList As Button
    Friend WithEvents lblTextClient As Label
    Friend WithEvents btnAddClient As Button
    Friend WithEvents lblTextDestination As Label
    Friend WithEvents btnCLientsList As Button
    Friend WithEvents btnAddDestination As Button
    Friend WithEvents lblNewTrip As Label
    Friend WithEvents btnNewTrip As Button

End Class
