Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace Example
	Public Class ItemInfoEventArgs
		Inherits EventArgs

		Public Sub New(ByVal _index As Integer, ByVal _ItemValue As Object)
			ItemIndex = _index
			ItemOffset = 0
			ItemValue = _ItemValue
		End Sub

		Public Property ItemOffset() As Integer
		Private privateItemIndex As Integer
		Public Property ItemIndex() As Integer
			Get
				Return privateItemIndex
			End Get
			Private Set(ByVal value As Integer)
				privateItemIndex = value
			End Set
		End Property
		Private privateItemValue As Object
		Public Property ItemValue() As Object
			Get
				Return privateItemValue
			End Get
			Private Set(ByVal value As Object)
				privateItemValue = value
			End Set
		End Property
	End Class
End Namespace
