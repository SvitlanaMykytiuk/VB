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
        Notepad = New Button()
        Calc = New Button()
        Edge = New Button()
        Ask = New Button()
        TextInput = New TextBox()
        ShowText = New Button()
        chatGPT = New Button()
        SuspendLayout()
        ' 
        ' Notepad
        ' 
        Notepad.Location = New Point(50, 110)
        Notepad.Name = "Notepad"
        Notepad.Size = New Size(225, 34)
        Notepad.TabIndex = 0
        Notepad.Text = "Notepad"
        Notepad.UseVisualStyleBackColor = True
        ' 
        ' Calc
        ' 
        Calc.BackColor = Color.White
        Calc.FlatAppearance.BorderColor = Color.Black
        Calc.FlatAppearance.BorderSize = 5
        Calc.Location = New Point(50, 48)
        Calc.Name = "Calc"
        Calc.Size = New Size(225, 34)
        Calc.TabIndex = 1
        Calc.Text = "Calc"
        Calc.UseVisualStyleBackColor = True
        ' 
        ' Edge
        ' 
        Edge.Location = New Point(50, 173)
        Edge.Name = "Edge"
        Edge.Size = New Size(225, 36)
        Edge.TabIndex = 2
        Edge.Text = "Google"
        Edge.UseVisualStyleBackColor = True
        ' 
        ' Ask
        ' 
        Ask.Location = New Point(462, 50)
        Ask.Name = "Ask"
        Ask.Size = New Size(209, 34)
        Ask.TabIndex = 3
        Ask.Text = "Ask"
        Ask.UseVisualStyleBackColor = True
        ' 
        ' TextInput
        ' 
        TextInput.Location = New Point(382, 332)
        TextInput.Name = "TextInput"
        TextInput.Size = New Size(308, 31)
        TextInput.TabIndex = 4
        ' 
        ' ShowText
        ' 
        ShowText.Location = New Point(471, 369)
        ShowText.Name = "ShowText"
        ShowText.Size = New Size(112, 34)
        ShowText.TabIndex = 5
        ShowText.Text = "ShowText"
        ShowText.UseVisualStyleBackColor = True
        ' 
        ' chatGPT
        ' 
        chatGPT.Location = New Point(50, 243)
        chatGPT.Name = "chatGPT"
        chatGPT.Size = New Size(225, 34)
        chatGPT.TabIndex = 6
        chatGPT.Text = "chatGPT"
        chatGPT.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(chatGPT)
        Controls.Add(ShowText)
        Controls.Add(TextInput)
        Controls.Add(Ask)
        Controls.Add(Edge)
        Controls.Add(Calc)
        Controls.Add(Notepad)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Notepad As Button
    Friend WithEvents Calc As Button
    Friend WithEvents Edge As Button
    Friend WithEvents Ask As Button
    Friend WithEvents TextInput As TextBox
    Friend WithEvents ShowText As Button
    Friend WithEvents chatGPT As Button

End Class
