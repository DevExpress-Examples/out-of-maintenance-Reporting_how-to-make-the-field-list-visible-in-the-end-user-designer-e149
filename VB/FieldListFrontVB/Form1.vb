Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UserDesigner
' ...

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles Button1.Click
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
