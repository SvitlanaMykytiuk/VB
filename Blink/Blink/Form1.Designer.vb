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
        btnStartStop = New Button()
        lblBlink = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' btnStartStop
        ' 
        btnStartStop.Location = New Point(336, 55)
        btnStartStop.Name = "btnStartStop"
        btnStartStop.Size = New Size(112, 34)
        btnStartStop.TabIndex = 0
        btnStartStop.Text = "Start/Stop"
        btnStartStop.UseVisualStyleBackColor = True
        ' 
        ' lblBlink
        ' 
        lblBlink.AutoSize = True
        lblBlink.Location = New Point(359, 122)
        lblBlink.Name = "lblBlink"
        lblBlink.Size = New Size(58, 25)
        lblBlink.TabIndex = 2
        lblBlink.Text = "Hallo!"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 500
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblBlink)
        Controls.Add(btnStartStop)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnStartStop As Button
    Friend WithEvents lblBlink As Label
    Friend WithEvents Timer1 As Timer

End Class
