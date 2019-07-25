Class SkillSet

#Region "Fields"

#End Region

#Region "Enumerations"

    Public Enum SkillTypes

        Athletics
        Acrobatics
        SleightOfHand
        Stealth
        Arcana
        History
        Investigation
        Nature
        Religion
        AnimalHandling
        Insight
        Medicine
        Perception
        Survival
        Deception
        Intimidation
        Performance
        Persuasion

    End Enum

#End Region

#Region "Constructors"

    Public Sub New(stats As StatBlock)

        Initialize(stats)

    End Sub

#End Region

#Region "Destructors"

#End Region

#Region "Properties"

#End Region

#Region "Methods"

    Private Sub Initialize(stats As StatBlock)

        With stats.Strength

        End With

    End Sub

#End Region

#Region "Events"

#End Region

End Class
