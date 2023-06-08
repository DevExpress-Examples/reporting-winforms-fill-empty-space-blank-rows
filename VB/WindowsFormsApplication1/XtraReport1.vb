Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Collections.Generic

Namespace WindowsFormsApplication1

    Public Partial Class XtraReport1
        Inherits XtraReport

        Private source As List(Of Data)

        Public Sub New(ByVal source As List(Of Data), ByVal detailPrintCount As Integer)
            InitializeComponent()
            Me.source = source
            ReportPrintOptions.DetailCountOnEmptyDataSource = detailPrintCount
        End Sub

        Private printCount As Integer = -1

        Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
            printCount += 1
            Dim data As Data = Nothing
            If printCount < source.Count Then
                data = source(printCount)
            End If

            xrTableCell1.Text = If(data Is Nothing, String.Empty, data.Name)
            xrTableCell2.Text = If(data Is Nothing, String.Empty, data.Category)
            xrTableCell3.Text = If(data Is Nothing, String.Empty, String.Format("{0:c2}", data.Price))
        End Sub
    End Class
End Namespace
