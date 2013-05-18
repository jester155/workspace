Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GameLogicLibrary
    
    Class Coin
        
        '.Publicly used object references
        Private r As Random = New Random(Environment.TickCount)
        
        '.Fields
        Private coin As Boolean
        
        '.Constructor that returns true or false. (Heads or Tails)
        Public Sub New()
            MyBase.New
            If (r.Next(2) = 0) Then
                Me.coin = true
            Else
                Me.coin = false
            End If
        End Sub
        
        '.Reset the coin field if another flip result is needed.
        Public Property Coins As Boolean
            Get
                Return Me.coin
            End Get
            Set
                If (r.Next(2) = 0) Then
                    Me.coin = true
                Else
                    Me.coin = false
                End If
            End Set
        End Property
    End Class
End Namespace
