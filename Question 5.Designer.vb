<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question_5
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
        Me.NextButton = New System.Windows.Forms.Button()
        Me.Option4 = New System.Windows.Forms.RadioButton()
        Me.Option3 = New System.Windows.Forms.RadioButton()
        Me.Option2 = New System.Windows.Forms.RadioButton()
        Me.Option1 = New System.Windows.Forms.RadioButton()
        Me.Question = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NextButton
        '
        Me.NextButton.BackColor = System.Drawing.Color.Black
        Me.NextButton.ForeColor = System.Drawing.Color.White
        Me.NextButton.Location = New System.Drawing.Point(1086, 437)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(150, 46)
        Me.NextButton.TabIndex = 29
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = False
        '
        'Option4
        '
        Me.Option4.AutoSize = True
        Me.Option4.ForeColor = System.Drawing.Color.White
        Me.Option4.Location = New System.Drawing.Point(865, 295)
        Me.Option4.Name = "Option4"
        Me.Option4.Size = New System.Drawing.Size(127, 36)
        Me.Option4.TabIndex = 28
        Me.Option4.Text = "strcset()"
        Me.Option4.UseVisualStyleBackColor = True
        '
        'Option3
        '
        Me.Option3.AutoSize = True
        Me.Option3.ForeColor = System.Drawing.Color.White
        Me.Option3.Location = New System.Drawing.Point(675, 295)
        Me.Option3.Name = "Option3"
        Me.Option3.Size = New System.Drawing.Size(116, 36)
        Me.Option3.TabIndex = 27
        Me.Option3.Text = "strset()"
        Me.Option3.UseVisualStyleBackColor = True
        '
        'Option2
        '
        Me.Option2.AutoSize = True
        Me.Option2.ForeColor = System.Drawing.Color.White
        Me.Option2.Location = New System.Drawing.Point(485, 295)
        Me.Option2.Name = "Option2"
        Me.Option2.Size = New System.Drawing.Size(130, 36)
        Me.Option2.TabIndex = 26
        Me.Option2.Text = "strnset()"
        Me.Option2.UseVisualStyleBackColor = True
        '
        'Option1
        '
        Me.Option1.AutoSize = True
        Me.Option1.ForeColor = System.Drawing.Color.White
        Me.Option1.Location = New System.Drawing.Point(336, 295)
        Me.Option1.Name = "Option1"
        Me.Option1.Size = New System.Drawing.Size(119, 36)
        Me.Option1.TabIndex = 25
        Me.Option1.Text = "strinit()"
        Me.Option1.UseVisualStyleBackColor = True
        '
        'Question
        '
        Me.Question.AutoSize = True
        Me.Question.ForeColor = System.Drawing.Color.White
        Me.Question.Location = New System.Drawing.Point(204, 176)
        Me.Question.Name = "Question"
        Me.Question.Size = New System.Drawing.Size(971, 32)
        Me.Question.TabIndex = 24
        Me.Question.Text = "Q.5 Which of the following function sets first n characters of a string to a give" &
    "n character?"
        '
        'Question_5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1362, 639)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.Option4)
        Me.Controls.Add(Me.Option3)
        Me.Controls.Add(Me.Option2)
        Me.Controls.Add(Me.Option1)
        Me.Controls.Add(Me.Question)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Question_5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Question_5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NextButton As Button
    Friend WithEvents Option4 As RadioButton
    Friend WithEvents Option3 As RadioButton
    Friend WithEvents Option2 As RadioButton
    Friend WithEvents Option1 As RadioButton
    Friend WithEvents Question As Label
End Class
