Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication1
	Public Class Data
		Public Sub New()
			Name = String.Empty
			Category = String.Empty
			Price = 0
		End Sub

		Public Sub New(ByVal name As String, ByVal category As String, ByVal price As Double)
			Me.Name = name
			Me.Category = category
			Me.Price = price
		End Sub

		Public Property Name() As String
		Public Property Category() As String
		Public Property Price() As Double
	End Class
End Namespace
