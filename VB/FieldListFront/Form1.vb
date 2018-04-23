Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UserDesigner
' ...

Namespace FieldListFront
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			' Create a new Design form.
			Dim designForm As New XRDesignForm()

			' Obtain the Field List and bring it to front.
			designForm.DesignDockManager(DesignDockPanelType.FieldList).Show()

			' Create a new blank report.
			designForm.OpenReport(New XtraReport1())

			' Show the Design form.
			designForm.ShowDialog()
		End Sub

	End Class
End Namespace
