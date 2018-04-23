Namespace Example
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
			Me.components = New System.ComponentModel.Container()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.customCheckedListBoxControl1 = New Example.CustomCheckedListBoxControl()
			Me.customListBoxControl1 = New Example.CustomListBoxControl()
			DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			DirectCast(Me.customCheckedListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.customListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013"
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.customListBoxControl1)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.customCheckedListBoxControl1)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(433, 249)
			Me.splitContainerControl1.SplitterPosition = 200
			Me.splitContainerControl1.TabIndex = 0
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' customCheckedListBoxControl1
			' 
			Me.customCheckedListBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.customCheckedListBoxControl1.Location = New System.Drawing.Point(0, 0)
			Me.customCheckedListBoxControl1.Name = "customCheckedListBoxControl1"
			Me.customCheckedListBoxControl1.Size = New System.Drawing.Size(221, 249)
			Me.customCheckedListBoxControl1.TabIndex = 0
			' 
			' customListBoxControl1
			' 
			Me.customListBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.customListBoxControl1.Location = New System.Drawing.Point(0, 0)
			Me.customListBoxControl1.Name = "customListBoxControl1"
			Me.customListBoxControl1.Size = New System.Drawing.Size(200, 249)
			Me.customListBoxControl1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(433, 249)
			Me.Controls.Add(Me.splitContainerControl1)
			Me.Name = "Form1"
			Me.Text = "ListBoxControl"
			DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			DirectCast(Me.customCheckedListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.customListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private customListBoxControl1 As CustomListBoxControl
		Private customCheckedListBoxControl1 As CustomCheckedListBoxControl


	End Class
End Namespace

