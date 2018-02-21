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
        Me.Length = New System.Windows.Forms.TextBox()
        Me.Breadth = New System.Windows.Forms.TextBox()
        Me.Result = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.Close = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Length
        '
        Me.Length.Location = New System.Drawing.Point(170, 25)
        Me.Length.Name = "Length"
        Me.Length.Size = New System.Drawing.Size(100, 20)
        Me.Length.TabIndex = 0
        '
        'Breadth
        '
        Me.Breadth.Location = New System.Drawing.Point(170, 102)
        Me.Breadth.Name = "Breadth"
        Me.Breadth.Size = New System.Drawing.Size(100, 20)
        Me.Breadth.TabIndex = 1
        '
        'Result
        '
        Me.Result.Location = New System.Drawing.Point(170, 172)
        Me.Result.Name = "Result"
        Me.Result.ReadOnly = True
        Me.Result.Size = New System.Drawing.Size(100, 20)
        Me.Result.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Length"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Breadth"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Area"
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(12, 226)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(75, 23)
        Me.Calculate.TabIndex = 6
        Me.Calculate.Text = "Calculate"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'Close
        '
        Me.Close.Location = New System.Drawing.Point(206, 226)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(75, 23)
        Me.Close.TabIndex = 8
        Me.Close.Text = "Exit"
        Me.Close.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(105, 226)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(75, 23)
        Me.Clear.TabIndex = 7
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 261)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.Breadth)
        Me.Controls.Add(Me.Length)
        Me.Name = "Form1"
        Me.Text = "Area of Rectangle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Length As TextBox
    Friend WithEvents Breadth As TextBox
    Friend WithEvents Result As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Calculate As Button
    Friend WithEvents Close As Button
    Friend WithEvents Clear As Button
End Class
