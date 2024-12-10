Public Class Destinations
    Protected Name As String
    Protected Guide As String

    Public Property _Name() As String
        Get
            Return Name
        End Get
        Set(ByVal value As String)
            Name = value
        End Set
    End Property

    Public Property _Guide() As String
        Get
            Return Guide
        End Get
        Set(ByVal value As String)
            Guide = value
        End Set
    End Property

    Public Sub New(_name As String, _guide As String)
        Me.Name = _name
        Me.Guide = _guide
    End Sub

    Public Overrides Function ToString() As String
        Return $"{Name},{Guide}"
    End Function
End Class
