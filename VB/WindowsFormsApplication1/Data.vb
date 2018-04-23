Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication1
	Public Class Data
		Public Sub New()
            Me.Name = String.Empty
            Me.Category = String.Empty
            Me.Price = 0
		End Sub

		Public Sub New(ByVal name As String, ByVal category As String, ByVal price As Double)
            Me.Name = name
            Me.Category = category
            Me.Price = price
		End Sub

		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
		Private privateCategory As String
		Public Property Category() As String
			Get
				Return privateCategory
			End Get
			Set(ByVal value As String)
				privateCategory = value
			End Set
		End Property
		Private privatePrice As Double
		Public Property Price() As Double
			Get
				Return privatePrice
			End Get
			Set(ByVal value As Double)
				privatePrice = value
			End Set
		End Property
	End Class
End Namespace
