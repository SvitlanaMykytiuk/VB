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
        txtUserName = New TextBox()
        Label2 = New Label()
        txtPassword = New TextBox()
        lblResult = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(268, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 25)
        Label1.TabIndex = 0
        Label1.Text = "Enter UserName"
        ' 
        ' txtUserName
        ' 
        txtUserName.Location = New Point(268, 70)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(150, 31)
        txtUserName.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(268, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 25)
        Label2.TabIndex = 2
        Label2.Text = "Enter Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(268, 165)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(150, 31)
        txtPassword.TabIndex = 3
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(268, 306)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(0, 25)
        lblResult.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(286, 231)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 5
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(lblResult)
        Controls.Add(txtPassword)
        Controls.Add(Label2)
        Controls.Add(txtUserName)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents Button1 As Button

End Class
