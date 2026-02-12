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
        txtPass = New TextBox()
        Label1 = New Label()
        lblResult = New Label()
        btnReset = New Button()
        SuspendLayout()
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(326, 188)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(150, 31)
        txtPass.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(326, 139)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 25)
        Label1.TabIndex = 1
        Label1.Text = "Enter password"
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(326, 252)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(0, 25)
        lblResult.TabIndex = 2
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(348, 285)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 34)
        btnReset.TabIndex = 3
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnReset)
        Controls.Add(lblResult)
        Controls.Add(Label1)
        Controls.Add(txtPass)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnReset As Button

End Class
