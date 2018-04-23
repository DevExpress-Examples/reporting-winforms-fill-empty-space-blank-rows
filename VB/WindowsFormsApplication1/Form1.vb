Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsFormsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim list As New List(Of Data)()
			Dim random As New Random()

			For i As Integer = 0 To 9
				Dim data As New Data(String.Format("Name {0}", i), String.Format("Category {0}", random.Next(4)), random.Next(1000))
				list.Add(data)
			Next i

			Dim report As New XtraReport1(list, Convert.ToInt32(spinEdit1.EditValue))
			report.ShowPreviewDialog()
		End Sub
	End Class
End Namespace
