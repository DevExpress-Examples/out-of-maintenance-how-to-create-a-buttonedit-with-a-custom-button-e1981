Imports Microsoft.VisualBasic
Imports System.Windows

Namespace ButtonEdit_Creating
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub ButtonInfo_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			buttonEdit.EditValue = String.Empty
		End Sub
	End Class
End Namespace
