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
        txtTask = New TextBox()
        btnDelete = New Button()
        lstTasks = New ListBox()
        LabelAttempts = New Label()
        SuspendLayout()
        ' 
        ' txtTask
        ' 
        txtTask.Location = New Point(483, 75)
        txtTask.Name = "txtTask"
        txtTask.Size = New Size(150, 31)
        txtTask.TabIndex = 0
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(521, 170)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 2
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' lstTasks
        ' 
        lstTasks.FormattingEnabled = True
        lstTasks.Location = New Point(181, 75)
        lstTasks.Name = "lstTasks"
        lstTasks.Size = New Size(180, 129)
        lstTasks.TabIndex = 3
        ' 
        ' LabelAttempts
        ' 
        LabelAttempts.AutoSize = True
        LabelAttempts.Location = New Point(182, 224)
        LabelAttempts.Name = "LabelAttempts"
        LabelAttempts.Size = New Size(63, 25)
        LabelAttempts.TabIndex = 4
        LabelAttempts.Text = "Label1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LabelAttempts)
        Controls.Add(lstTasks)
        Controls.Add(btnDelete)
        Controls.Add(txtTask)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTask As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents lstTasks As ListBox
    Friend WithEvents LabelAttempts As Label

End Class
