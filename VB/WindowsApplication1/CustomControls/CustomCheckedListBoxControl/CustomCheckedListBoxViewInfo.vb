Imports System
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo

Namespace Example
	Public Class CustomCheckedListBoxViewInfo
		Inherits CheckedListBoxViewInfo

		Public Sub New(ByVal listBox As CheckedListBoxControl)
			MyBase.New(listBox)
		End Sub
		Private ReadOnly Property ListBox() As CustomCheckedListBoxControl
			Get
				Return TryCast(OwnerControl, CustomCheckedListBoxControl)
			End Get
		End Property

		Protected Overrides Function CreateItemInfo(ByVal bounds As Rectangle, ByVal item As Object, ByVal text As String, ByVal index As Integer) As ItemInfo
			Dim e As New ItemInfoEventArgs(index, item)
			ListBox.RaiseShiftItem(e)
			Dim itemBounds As New Rectangle(bounds.X + e.ItemOffset, bounds.Y, bounds.Width, bounds.Height)
			Dim itemInfo As ItemInfo = MyBase.CreateItemInfo(itemBounds, item, text, index)
			itemInfo.Bounds = bounds
			Return itemInfo
		End Function


	End Class
End Namespace