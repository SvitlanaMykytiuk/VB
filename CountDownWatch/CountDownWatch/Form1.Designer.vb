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
        components = New ComponentModel.Container()
        LabelInfo = New Label()
        TextBoxSeconds = New TextBox()
        LabelTime = New Label()
        ButtonStart = New Button()
        ButtonReset = New Button()
        ButtonStop = New Button()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' LabelInfo
        ' 
        LabelInfo.AutoSize = True
        LabelInfo.Location = New Point(309, 30)
        LabelInfo.Name = "LabelInfo"
        LabelInfo.Size = New Size(126, 25)
        LabelInfo.TabIndex = 0
        LabelInfo.Text = "Enter seconds:"
        ' 
        ' TextBoxSeconds
        ' 
        TextBoxSeconds.Location = New Point(296, 88)
        TextBoxSeconds.Name = "TextBoxSeconds"
        TextBoxSeconds.Size = New Size(150, 31)
        TextBoxSeconds.TabIndex = 1
        ' 
        ' LabelTime
        ' 
        LabelTime.AutoSize = True
        LabelTime.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelTime.Location = New Point(351, 166)
        LabelTime.Name = "LabelTime"
        LabelTime.Size = New Size(80, 65)
        LabelTime.TabIndex = 2
        LabelTime.Text = "00"
        ' 
        ' ButtonStart
        ' 
        ButtonStart.Location = New Point(212, 247)
        ButtonStart.Name = "ButtonStart"
        ButtonStart.Size = New Size(112, 34)
        ButtonStart.TabIndex = 3
        ButtonStart.Text = "Start"
        ButtonStart.UseVisualStyleBackColor = True
        ' 
        ' ButtonReset
        ' 
        ButtonReset.Location = New Point(351, 319)
        ButtonReset.Name = "ButtonReset"
        ButtonReset.Size = New Size(112, 34)
        ButtonReset.TabIndex = 4
        ButtonReset.Text = "Reset"
        ButtonReset.UseVisualStyleBackColor = True
        ' 
        ' ButtonStop
        ' 
        ButtonStop.Location = New Point(432, 247)
        ButtonStop.Name = "ButtonStop"
        ButtonStop.Size = New Size(112, 34)
        ButtonStop.TabIndex = 5
        ButtonStop.Text = "Stop"
        ButtonStop.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonStop)
        Controls.Add(ButtonReset)
        Controls.Add(ButtonStart)
        Controls.Add(LabelTime)
        Controls.Add(TextBoxSeconds)
        Controls.Add(LabelInfo)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelInfo As Label
    Friend WithEvents TextBoxSeconds As TextBox
    Friend WithEvents LabelTime As Label
    Friend WithEvents ButtonStart As Button
    Friend WithEvents ButtonReset As Button
    Friend WithEvents ButtonStop As Button
    Friend WithEvents Timer1 As Timer

End Class
