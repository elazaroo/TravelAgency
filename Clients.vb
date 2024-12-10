Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class Clients
    Protected Name As String
    Protected Surname As String
    Protected Phone As String
    Protected Money As Decimal

    Public Property _Name() As String
        Get
            Return Name
        End Get
        Set(ByVal value As String)
            Name = value
        End Set
    End Property

    Public Property _Surname() As String
        Get
            Return Surname
        End Get
        Set(ByVal value As String)
            Surname = value
        End Set
    End Property

    Public Property _Phone() As String
        Get
            Return Phone
        End Get
        Set(ByVal value As String)
            Phone = value
        End Set
    End Property

    Public Property _Money() As Decimal
        Get
            Return Money
        End Get
        Set(ByVal value As Decimal)
            Money = value
        End Set
    End Property

    Public Sub New(ByVal _name As String, ByVal _surname As String, ByVal _phone As String, ByVal _money As Decimal)
        Name = _name
        Surname = _surname
        Phone = _phone
        Money = _money
    End Sub

    Public Overrides Function toString() As String
        Return $"{Name}€{Surname}€{Phone}€{Money}#"
    End Function
End Class
