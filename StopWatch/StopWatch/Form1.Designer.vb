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
        LabelTime = New Label()
        ButtonStart = New Button()
        ButtonStop = New Button()
        ButtonReset = New Button()
        Timer = New Timer(components)
        SuspendLayout()
        ' 
        ' LabelTime
        ' 
        LabelTime.AutoSize = True
        LabelTime.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelTime.Location = New Point(277, 86)
        LabelTime.Name = "LabelTime"
        LabelTime.Size = New Size(204, 65)
        LabelTime.TabIndex = 0
        LabelTime.Text = "00:00:00"
        ' 
        ' ButtonStart
        ' 
        ButtonStart.Location = New Point(229, 191)
        ButtonStart.Name = "ButtonStart"
        ButtonStart.Size = New Size(112, 34)
        ButtonStart.TabIndex = 1
        ButtonStart.Text = "Start"
        ButtonStart.UseVisualStyleBackColor = True
        ' 
        ' ButtonStop
        ' 
        ButtonStop.Location = New Point(442, 191)
        ButtonStop.Name = "ButtonStop"
        ButtonStop.Size = New Size(112, 34)
        ButtonStop.TabIndex = 2
        ButtonStop.Text = "Stop"
        ButtonStop.UseVisualStyleBackColor = True
        ' 
        ' ButtonReset
        ' 
        ButtonReset.Location = New Point(360, 257)
        ButtonReset.Name = "ButtonReset"
        ButtonReset.Size = New Size(112, 34)
        ButtonReset.TabIndex = 3
        ButtonReset.Text = "Reset"
        ButtonReset.UseVisualStyleBackColor = True
        ' 
        ' Timer
        ' 
        Timer.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonReset)
        Controls.Add(ButtonStop)
        Controls.Add(ButtonStart)
        Controls.Add(LabelTime)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelTime As Label
    Friend WithEvents ButtonStart As Button
    Friend WithEvents ButtonStop As Button
    Friend WithEvents ButtonReset As Button
    Friend WithEvents Timer As Timer

End Class
