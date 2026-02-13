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
        txtColor = New TextBox()
        btnReset = New Button()
        lblMessage = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtColor
        ' 
        txtColor.Location = New Point(329, 88)
        txtColor.Name = "txtColor"
        txtColor.Size = New Size(150, 31)
        txtColor.TabIndex = 0
        txtColor.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(329, 284)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(150, 34)
        btnReset.TabIndex = 1
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' lblMessage
        ' 
        lblMessage.AutoSize = True
        lblMessage.Location = New Point(376, 221)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(0, 25)
        lblMessage.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(359, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 3
        Label1.Text = "Enter color"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(lblMessage)
        Controls.Add(btnReset)
        Controls.Add(txtColor)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtColor As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents Label1 As Label

End Class
