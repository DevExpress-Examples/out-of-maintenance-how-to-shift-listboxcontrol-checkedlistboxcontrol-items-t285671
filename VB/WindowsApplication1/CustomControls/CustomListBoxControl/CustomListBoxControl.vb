Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo
Imports System

Namespace Example
	<ToolboxItem(True)>
	Public Class CustomListBoxControl
		Inherits ListBoxControl

		Protected Overrides Function CreateViewInfo() As BaseStyleControlViewInfo
			Return New CustomListBoxViewInfo(Me)
		End Function

		#Region "ShiftItem"
		Public Event ShiftItem As EventHandler(Of ItemInfoEventArgs)
			Protected Friend Sub RaiseShiftItem(ByVal ea As ItemInfoEventArgs)
            RaiseEvent ShiftItem(Me, ea)
        End Sub
		#End Region
	End Class
End Namespace
