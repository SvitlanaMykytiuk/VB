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
        ButtonAdd = New Button()
        ButtonSub = New Button()
        ButtonMul = New Button()
        ButtonDiv = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' ButtonAdd
        ' 
        ButtonAdd.Location = New Point(665, 29)
        ButtonAdd.Name = "ButtonAdd"
        ButtonAdd.Size = New Size(112, 34)
        ButtonAdd.TabIndex = 0
        ButtonAdd.Text = "+"
        ButtonAdd.UseVisualStyleBackColor = True
        ' 
        ' ButtonSub
        ' 
        ButtonSub.Location = New Point(665, 82)
        ButtonSub.Name = "ButtonSub"
        ButtonSub.Size = New Size(112, 34)
        ButtonSub.TabIndex = 1
        ButtonSub.Text = "-"
        ButtonSub.UseVisualStyleBackColor = True
        ' 
        ' ButtonMul
        ' 
        ButtonMul.Location = New Point(665, 154)
        ButtonMul.Name = "ButtonMul"
        ButtonMul.Size = New Size(112, 34)
        ButtonMul.TabIndex = 2
        ButtonMul.Text = "*"
        ButtonMul.UseVisualStyleBackColor = True
        ' 
        ' ButtonDiv
        ' 
        ButtonDiv.Location = New Point(665, 217)
        ButtonDiv.Name = "ButtonDiv"
        ButtonDiv.Size = New Size(112, 34)
        ButtonDiv.TabIndex = 3
        ButtonDiv.Text = "/"
        ButtonDiv.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(674, 288)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 25)
        Label1.TabIndex = 4
        Label1.Text = "Label1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(ButtonDiv)
        Controls.Add(ButtonMul)
        Controls.Add(ButtonSub)
        Controls.Add(ButtonAdd)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonSub As Button
    Friend WithEvents ButtonMul As Button
    Friend WithEvents ButtonDiv As Button
    Friend WithEvents Label1 As Label

End Class
