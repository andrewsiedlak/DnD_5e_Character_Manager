
Public Class StatBlock

#Region "Fields"

#End Region

#Region "Enumerations"

#End Region

#Region "Constructors"

    Public Sub New(strScore As Integer, dexScore As Integer, conScore As Integer,
                   intScore As Integer, wisScore As Integer, charScore As Integer)

        _strength = New Stat(Stat.StatType.Strength, strScore)
        _dexterity = New Stat(Stat.StatType.Dexterity, dexScore)
        _constitution = New Stat(Stat.StatType.Constitution, conScore)
        _intelligence = New Stat(Stat.StatType.Intelligence, intScore)
        _wisdom = New Stat(Stat.StatType.Wisdom, wisScore)
        _charisma = New Stat(Stat.StatType.Charisma, charScore)

    End Sub

#End Region

#Region "Destructors"

#End Region

#Region "Properties"

    Public ReadOnly Property Strength As Stat
        Get
            Return _strength
        End Get
    End Property
    Private _strength As Stat

    Public ReadOnly Property Dexterity As Stat
        Get
            Return _dexterity
        End Get
    End Property
    Private _dexterity As Stat

    Public ReadOnly Property Constitution As Stat
        Get
            Return _constitution
        End Get
    End Property
    Private _constitution As Stat

    Public ReadOnly Property Intelligence As Stat
        Get
            Return _intelligence
        End Get
    End Property
    Private _intelligence As Stat

    Public ReadOnly Property Wisdom As Stat
        Get
            Return _wisdom
        End Get
    End Property
    Private _wisdom As Stat

    Public ReadOnly Property Charisma As Stat
        Get
            Return _charisma
        End Get
    End Property
    Private _charisma As Stat

#End Region

#Region "Methods"

    Public Function [Get](statType As Stat.StatType) As Stat

        Select Case statType

            Case Stat.StatType.Strength
                Return Me.Strength
            Case Stat.StatType.Dexterity
                Return Me.Dexterity
            Case Stat.StatType.Constitution
                Return Me.Constitution
            Case Stat.StatType.Intelligence
                Return Me.Intelligence
            Case Stat.StatType.Wisdom
                Return Me.Wisdom
            Case Stat.StatType.Charisma
                Return Me.Charisma

        End Select

    End Function

#End Region

#Region "Events"

#End Region

End Class
