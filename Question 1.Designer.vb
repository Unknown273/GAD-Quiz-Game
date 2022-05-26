<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question_1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Question = New System.Windows.Forms.Label()
        Me.Option1 = New System.Windows.Forms.RadioButton()
        Me.Option2 = New System.Windows.Forms.RadioButton()
        Me.Option3 = New System.Windows.Forms.RadioButton()
        Me.Option4 = New System.Windows.Forms.RadioButton()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Question
        '
        Me.Question.AutoSize = True
        Me.Question.Location = New System.Drawing.Point(318, 211)
        Me.Question.Name = "Question"
        Me.Question.Size = New System.Drawing.Size(541, 32)
        Me.Question.TabIndex = 0
        Me.Question.Text = "Q.1 What is the default return type of a function?"
        '
        'Option1
        '
        Me.Option1.AutoSize = True
        Me.Option1.Location = New System.Drawing.Point(161, 323)
        Me.Option1.Name = "Option1"
        Me.Option1.Size = New System.Drawing.Size(190, 36)
        Me.Option1.TabIndex = 1
        Me.Option1.TabStop = True
        Me.Option1.Text = "RadioButton1"
        Me.Option1.UseVisualStyleBackColor = True
        '
        'Option2
        '
        Me.Option2.AutoSize = True
        Me.Option2.Location = New System.Drawing.Point(408, 323)
        Me.Option2.Name = "Option2"
        Me.Option2.Size = New System.Drawing.Size(190, 36)
        Me.Option2.TabIndex = 2
        Me.Option2.TabStop = True
        Me.Option2.Text = "RadioButton2"
        Me.Option2.UseVisualStyleBackColor = True
        '
        'Option3
        '
        Me.Option3.AutoSize = True
        Me.Option3.Location = New System.Drawing.Point(673, 323)
        Me.Option3.Name = "Option3"
        Me.Option3.Size = New System.Drawing.Size(190, 36)
        Me.Option3.TabIndex = 3
        Me.Option3.TabStop = True
        Me.Option3.Text = "RadioButton3"
        Me.Option3.UseVisualStyleBackColor = True
        '
        'Option4
        '
        Me.Option4.AutoSize = True
        Me.Option4.Location = New System.Drawing.Point(912, 323)
        Me.Option4.Name = "Option4"
        Me.Option4.Size = New System.Drawing.Size(132, 36)
        Me.Option4.TabIndex = 4
        Me.Option4.TabStop = True
        Me.Option4.Text = "Option4"
        Me.Option4.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(1133, 460)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(150, 46)
        Me.NextButton.TabIndex = 5
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'Question_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 639)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.Option4)
        Me.Controls.Add(Me.Option3)
        Me.Controls.Add(Me.Option2)
        Me.Controls.Add(Me.Option1)
        Me.Controls.Add(Me.Question)
        Me.Name = "Question_1"
        Me.Text = "Question_1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Question As Label
    Friend WithEvents Option1 As RadioButton
    Friend WithEvents Option2 As RadioButton
    Friend WithEvents Option3 As RadioButton
    Friend WithEvents Option4 As RadioButton
    Friend WithEvents NextButton As Button
End Class
