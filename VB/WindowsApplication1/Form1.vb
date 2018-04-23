Imports System
Imports DevExpress.XtraEditors

Namespace Example
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
			InitListBoxes()
		End Sub

		Private Sub InitListBoxes()
			For i As Integer = 0 To 9
				customCheckedListBoxControl1.Items.Add(String.Format("Item {0}", i))
				customListBoxControl1.Items.Add(String.Format("Item {0}", i))
			Next i

			AddHandler customCheckedListBoxControl1.ShiftItem, AddressOf OnShiftItem
			AddHandler customListBoxControl1.ShiftItem, AddressOf OnShiftItem
		End Sub

		Private Const Offset As Integer = 20
		Private Sub OnShiftItem(ByVal sender As Object, ByVal customEventArgs As ItemInfoEventArgs)
			If customEventArgs.ItemIndex Mod 2 = 1 Then
				customEventArgs.ItemOffset = Offset
			End If
		End Sub
	End Class
End Namespace