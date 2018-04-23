Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo
Imports System

Namespace Example
	<ToolboxItem(True)>
	Public Class CustomCheckedListBoxControl
		Inherits CheckedListBoxControl

		Protected Overrides Function CreateViewInfo() As BaseStyleControlViewInfo
			Return New CustomCheckedListBoxViewInfo(Me)
		End Function

		#Region "ShiftItem"
		Public Event ShiftItem As EventHandler(Of ItemInfoEventArgs)
		Protected Friend Sub RaiseShiftItem(ByVal ea As ItemInfoEventArgs)
            RaiseEvent ShiftItem(Me, ea)
		End Sub
		#End Region
	End Class
End Namespace
