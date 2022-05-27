<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question_3
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
        Me.NextButton.Location = New System.Drawing.Point(1097, 427)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(150, 46)
        Me.NextButton.TabIndex = 17
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = False
        '
        'Option4
        '
        Me.Option4.AutoSize = True
        Me.Option4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Option4.ForeColor = System.Drawing.Color.White
        Me.Option4.Location = New System.Drawing.Point(944, 286)
        Me.Option4.Name = "Option4"
        Me.Option4.Size = New System.Drawing.Size(225, 36)
        Me.Option4.TabIndex = 16
        Me.Option4.Text = "Call by reference"
        Me.Option4.UseVisualStyleBackColor = True
        '
        'Option3
        '
        Me.Option3.AutoSize = True
        Me.Option3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Option3.ForeColor = System.Drawing.Color.White
        Me.Option3.Location = New System.Drawing.Point(690, 286)
        Me.Option3.Name = "Option3"
        Me.Option3.Size = New System.Drawing.Size(213, 36)
        Me.Option3.TabIndex = 15
        Me.Option3.Text = "Call by function"
        Me.Option3.UseVisualStyleBackColor = True
        '
        'Option2
        '
        Me.Option2.AutoSize = True
        Me.Option2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Option2.ForeColor = System.Drawing.Color.White
        Me.Option2.Location = New System.Drawing.Point(469, 286)
        Me.Option2.Name = "Option2"
        Me.Option2.Size = New System.Drawing.Size(184, 36)
        Me.Option2.TabIndex = 14
        Me.Option2.Text = "Call by name"
        Me.Option2.UseVisualStyleBackColor = True
        '
        'Option1
        '
        Me.Option1.AutoSize = True
        Me.Option1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Option1.ForeColor = System.Drawing.Color.White
        Me.Option1.Location = New System.Drawing.Point(210, 286)
        Me.Option1.Name = "Option1"
        Me.Option1.Size = New System.Drawing.Size(233, 36)
        Me.Option1.TabIndex = 13
        Me.Option1.Text = "Call by procedure"
        Me.Option1.UseVisualStyleBackColor = True
        '
        'Question
        '
        Me.Question.AutoSize = True
        Me.Question.ForeColor = System.Drawing.Color.White
        Me.Question.Location = New System.Drawing.Point(478, 178)
        Me.Question.Name = "Question"
        Me.Question.Size = New System.Drawing.Size(395, 32)
        Me.Question.TabIndex = 12
        Me.Question.Text = "Q.3 Pointers can be used to achieve"
        '
        'Question_3
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
        Me.Name = "Question_3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Question_3"
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
