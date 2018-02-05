<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PushButton = New System.Windows.Forms.Button()
        Me.Message = New System.Windows.Forms.TextBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.PushButton.Location = New System.Drawing.Point(170, 173)
        Me.PushButton.Name = "Push"
        Me.PushButton.Size = New System.Drawing.Size(75, 23)
        Me.PushButton.TabIndex = 0
        Me.PushButton.Text = "Push Me"
        Me.PushButton.UseVisualStyleBackColor = True
        '
        'Message
        '
        Me.Message.Location = New System.Drawing.Point(96, 37)
        Me.Message.Name = "Message"
        Me.Message.Size = New System.Drawing.Size(249, 20)
        Me.Message.TabIndex = 1
        '
        'Button2
        '
        Me.ExitButton.Location = New System.Drawing.Point(170, 234)
        Me.ExitButton.Name = "Exit"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 312)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Message)
        Me.Controls.Add(Me.PushButton)
        Me.Name = "Form1"
        Me.Text = "Hello World"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PushButton As Button
    Friend WithEvents Message As TextBox
    Friend WithEvents ExitButton As Button
End Class
