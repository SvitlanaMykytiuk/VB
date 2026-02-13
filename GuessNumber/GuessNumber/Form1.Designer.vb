<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        TextBox1 = New TextBox()
        ButtonGuess = New Button()
        LabelResult = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(310, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 25)
        Label1.TabIndex = 0
        Label1.Text = "Enter a number from 1 to 100"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(355, 85)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 1
        ' 
        ' ButtonGuess
        ' 
        ButtonGuess.Location = New Point(374, 211)
        ButtonGuess.Name = "ButtonGuess"
        ButtonGuess.Size = New Size(112, 34)
        ButtonGuess.TabIndex = 2
        ButtonGuess.Text = "Guess"
        ButtonGuess.UseVisualStyleBackColor = True
        ' 
        ' LabelResult
        ' 
        LabelResult.AutoSize = True
        LabelResult.Location = New Point(399, 147)
        LabelResult.Name = "LabelResult"
        LabelResult.Size = New Size(0, 25)
        LabelResult.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LabelResult)
        Controls.Add(ButtonGuess)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtonGuess As Button
    Friend WithEvents LabelResult As Label

End Class
