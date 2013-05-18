Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GameLogicLibrary
    
    Class PercentCounter
        
        '.Publicly used object references
        Private r As Random = New Random(Environment.TickCount)
        
        '.Gets a percent if needed (acts as a 10 sided die essentially returning "00,10,20,etc."
        Private intervalTen As Integer
        
        Private intervalFive As Integer
        
        Private intervalOne As Integer
        
        Public Sub New()
            MyBase.New
            Me.intervalTen = (r.Next(1, 10) * 10)
            Me.intervalFive = (r.Next(1, 20) * 5)
            Me.intervalFive = r.Next(1, 100)
        End Sub
        
        '.Returns percent value 10, 20, 30, 40, etc.
        Public Property IntervalTens As Integer
            Get
                Return Me.intervalTen
            End Get
            Set(value As Integer)
                Me.intervalTen = (r.Next(11) * 10)
            End Set
        End Property
        
        '.Return percent value 60, 65, 70, 75, etc.
        Public Property IntervalFives As Integer
            Get
                Return Me.intervalFive
            End Get
            Set(value As Integer)
                Me.intervalFive = (r.Next(1, 20) * 5)
            End Set
        End Property
        
        '.Esentially returns 1-100 for a precise percent. 
        Public Property InvervalOne As Integer
            Get
                Return Me.intervalOne
            End Get
            Set
                Me.intervalOne = r.Next(1, 100)
            End Set
        End Property
    End Class
End Namespace
