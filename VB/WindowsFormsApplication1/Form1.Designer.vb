Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton
            Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
            CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'spinEdit1
            '
            Me.spinEdit1.EditValue = New Decimal(New Integer() {20, 0, 0, 0})
            Me.spinEdit1.Location = New System.Drawing.Point(12, 31)
            Me.spinEdit1.Name = "spinEdit1"
            Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.spinEdit1.Properties.IsFloatValue = False
            Me.spinEdit1.Properties.Mask.EditMask = "N00"
            Me.spinEdit1.Size = New System.Drawing.Size(259, 20)
            Me.spinEdit1.TabIndex = 0
            '
            'simpleButton1
            '
            Me.simpleButton1.Location = New System.Drawing.Point(13, 58)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(258, 23)
            Me.simpleButton1.TabIndex = 1
            Me.simpleButton1.Text = "Preview"
            '
            'LabelControl1
            '
            Me.LabelControl1.Location = New System.Drawing.Point(13, 11)
            Me.LabelControl1.Name = "LabelControl1"
            Me.LabelControl1.Size = New System.Drawing.Size(86, 13)
            Me.LabelControl1.TabIndex = 2
            Me.LabelControl1.Text = "Detail print count:"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(284, 262)
            Me.Controls.Add(Me.LabelControl1)
            Me.Controls.Add(Me.simpleButton1)
            Me.Controls.Add(Me.spinEdit1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private spinEdit1 As DevExpress.XtraEditors.SpinEdit
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace

