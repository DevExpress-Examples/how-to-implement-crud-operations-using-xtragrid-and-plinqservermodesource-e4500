﻿' Developer Express Code Central Example:
' How to implement CRUD operations using XtraGrid and PLinqServerModeSource
' 
' This example demonstrates how to implement the Create, Update and Delete
' operations using PLinqServerModeSource.
' This example works with the standard
' SQL Northwind database.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4500

Imports Microsoft.VisualBasic
Imports System
Namespace PLinqServerMode
	Partial Public Class EditForm
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
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
			Me.textEdit3 = New DevExpress.XtraEditors.TextEdit()
			Me.textEdit4 = New DevExpress.XtraEditors.TextEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' textEdit1
			' 
			Me.textEdit1.Location = New System.Drawing.Point(113, 52)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(100, 20)
			Me.textEdit1.TabIndex = 0
			' 
			' textEdit2
			' 
			Me.textEdit2.Location = New System.Drawing.Point(113, 78)
			Me.textEdit2.Name = "textEdit2"
			Me.textEdit2.Size = New System.Drawing.Size(100, 20)
			Me.textEdit2.TabIndex = 1
			' 
			' textEdit3
			' 
			Me.textEdit3.Location = New System.Drawing.Point(113, 104)
			Me.textEdit3.Name = "textEdit3"
			Me.textEdit3.Size = New System.Drawing.Size(100, 20)
			Me.textEdit3.TabIndex = 2
			' 
			' textEdit4
			' 
			Me.textEdit4.Location = New System.Drawing.Point(113, 130)
			Me.textEdit4.Name = "textEdit4"
			Me.textEdit4.Size = New System.Drawing.Size(100, 20)
			Me.textEdit4.TabIndex = 3
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(24, 59)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(72, 13)
			Me.labelControl1.TabIndex = 4
			Me.labelControl1.Text = "CompanyName"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(31, 85)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(65, 13)
			Me.labelControl2.TabIndex = 5
			Me.labelControl2.Text = "ContactName"
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(57, 111)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(39, 13)
			Me.labelControl3.TabIndex = 6
			Me.labelControl3.Text = "Address"
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(57, 137)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(39, 13)
			Me.labelControl4.TabIndex = 7
			Me.labelControl4.Text = "Country"
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(31, 176)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 8
			Me.simpleButton1.Text = "Ok"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(178, 176)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton2.TabIndex = 9
			Me.simpleButton2.Text = "Cancel"
'			Me.simpleButton2.Click += New System.EventHandler(Me.simpleButton2_Click);
			' 
			' EditForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(297, 211)
			Me.Controls.Add(Me.simpleButton2)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.labelControl4)
			Me.Controls.Add(Me.labelControl3)
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.textEdit4)
			Me.Controls.Add(Me.textEdit3)
			Me.Controls.Add(Me.textEdit2)
			Me.Controls.Add(Me.textEdit1)
			Me.Name = "EditForm"
			Me.Text = "EditForm"
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private textEdit2 As DevExpress.XtraEditors.TextEdit
		Private textEdit3 As DevExpress.XtraEditors.TextEdit
		Private textEdit4 As DevExpress.XtraEditors.TextEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace