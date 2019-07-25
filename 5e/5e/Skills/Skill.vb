Public Class Skill

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

#End Region

#Region "Destructors"

#End Region

#Region "Properties"

    Public ReadOnly Property SkillType As SkillTypes
        Get
            Return _skillType
        End Get
    End Property
    Private _skillType As SkillTypes

    Public ReadOnly Property StatType As Stat.StatType
        Get
            Select Case Me.SkillType
                Case SkillTypes.Athletics
                    Return Stat.StatType.Strength
                Case SkillTypes.Acrobatics, SkillTypes.SleightOfHand, SkillTypes.Stealth
                    Return Stat.StatType.Dexterity
                Case SkillTypes.Arcana, SkillTypes.History, SkillTypes.Investigation, SkillTypes.Nature, SkillTypes.Religion
                    Return Stat.StatType.Intelligence
                Case SkillTypes.AnimalHandling, SkillTypes.Insight, SkillTypes.Medicine, SkillTypes.Perception, SkillTypes.Survival
                    Return Stat.StatType.Wisdom
                Case SkillTypes.Deception, SkillTypes.Intimidation, SkillTypes.Performance, SkillTypes.Persuasion
                    Return Stat.StatType.Charisma
            End Select
        End Get
    End Property



#End Region

#Region "Methods"

#End Region

#Region "Events"

#End Region

End Class
