Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace WindowsFormsApplication1

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim list As List(Of Data) = New List(Of Data)()
            Dim random As Random = New Random()
            For i As Integer = 0 To 10 - 1
                Dim data As Data = New Data(String.Format("Name {0}", i), String.Format("Category {0}", random.Next(4)), random.Next(1000))
                list.Add(data)
            Next

            Dim report As XtraReport1 = New XtraReport1()
            report.DataSource = list
            report.ShowPreviewDialog()
        End Sub
    End Class
End Namespace
