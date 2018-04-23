Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UserDesigner
' ...

Namespace docEUDFieldListBringToFront
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button1.Click
            ' Create a new design form.
            Dim DesignForm As New XRDesignFormEx()

            ' Obtain the Field List and bring it to front.
            DesignForm.DesignDockManager(DesignDockPanelType.FieldList).Show()

            ' Create a new blank report.
            DesignForm.DesignPanel.ExecCommand(ReportCommand.NewReport)

            ' Show the design form.
            DesignForm.ShowDialog()
        End Sub
    End Class
End Namespace