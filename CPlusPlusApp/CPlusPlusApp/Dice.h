Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GameLogicLibrary
    
    Public Class Dice
        
        '.Publicly used object references
        Private r As Random = New Random(Environment.TickCount)
        
        '.Fields parallel arrays to facilitate shorter coding as well as to check the selected dice against it's sides
        Private diceName() As String
        
        Private diceSides() As Integer
        
        Private selectedDice As List(Of String) = New List(Of String)
        
        Private numberOfDice As Integer
        
        '.Constructors to set the dice from there or have no selected dice by default
        Public Sub New()
            MyBase.New
            
        End Sub
        
        '.SETS FOR ONLY ONE DIE --> CONSTRUCTOR
        Public Sub New(ByVal selectedDie As String)
            MyBase.New
            Dim i As Integer = 0
            Do While (i < diceSides.Length)
                If Me.diceName(i).Equals(selectedDie.ToLower) Then
                    Me.selectedDice.Add(selectedDie.ToLower)
                    Exit For
                End If
                i = (i + 1)
            Loop
        End Sub
        
        '.Sets the number of dice to use as well as asks the user which dice to use CONSTRUCTOR
        Public Sub New(ByVal numberOfDice As Integer)
            MyBase.New
            Me.numberOfDice = numberOfDice
            Dim i As Integer = 0
            Do While (i < Me.numberOfDice)
                Dim choice As String = Console.ReadLine
                '.------>Change this line of code to match whatever input you are using<------.//
                Dim j As Integer = 0
                Do While (j < Me.diceName.Length)
                    If Me.diceName(j).Equals(choice.ToLower) Then
                        Me.selectedDice.Add(choice)
                    End If
                    j = (j + 1)
                Loop
                i = (i + 1)
            Loop
        End Sub
        
        '.Gets and sets the number of dice to use
        Public Property NumberOfDice As Integer
            Get
                Return Me.numberOfDice
            End Get
            Set
                Me.numberOfDice = value
            End Set
        End Property
        
        '.sets the selected Dice to the proper and needed die ONLY ONE DIE
        Public Sub setSelectedDice(ByVal selectedDie As String)
            If (Me.selectedDice.Contains(selectedDie) = true) Then
                Dim i As Integer = 0
                Do While (i < Me.diceSides.Length)
                    If Me.diceName(i).Equals(selectedDie.ToLower) Then
                        Me.selectedDice.Add(selectedDie.ToLower)
                        Exit For
                    End If
                    i = (i + 1)
                Loop
            End If
        End Sub
        
        '.Use if the user needs to or wants to use more than one die
        Public Sub setMultipleDice()
            Dim i As Integer = 0
            Do While (i < Me.numberOfDice)
                Dim choice As String = Console.ReadLine
                '.------>Change this line of code to match whatever input you are using<------.//
                Dim j As Integer = 0
                Do While (j < Me.diceName.Length)
                    If Me.diceName(j).Equals(choice) Then
                        Me.selectedDice.Add(choice)
                    End If
                    j = (j + 1)
                Loop
                i = (i + 1)
            Loop
        End Sub
        
        Public Function getSelectedDie() As String()
            Me.selectedDice.Sort
            Dim result() As String = New String((Me.selectedDice.Count) - 1) {}
            Dim i As Integer = 0
            For Each item As String In Me.selectedDice
                result(i++) = item
            Next
            Return result
        End Function
        
        '.Rolls the selected die
        Public Function rollDice() As Integer()
            Me.selectedDice.Sort
            Dim results() As Integer = New Integer((Me.selectedDice.Count) - 1) {}
            Dim counterForResults As Integer = 0
            For Each item As String In Me.selectedDice
                Dim i As Integer = 0
                Do While (i < Me.diceSides.Length)
                    If item.ToLower.Equals(Me.diceName(i)) Then
                        results(counterForResults++) = r.Next(1, Me.diceSides(i))
                    End If
                    i = (i + 1)
                Loop
            Next
            Return results
        End Function
        
        '.Removes all the dice from the selectedDie Array List field 
        Public Sub resetDice()
            Me.selectedDice.Clear
        End Sub
    End Class
End Namespace
