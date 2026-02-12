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
        txtCelsius = New TextBox()
        btnReset = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' txtCelsius
        ' 
        txtCelsius.Location = New Point(521, 70)
        txtCelsius.Name = "txtCelsius"
        txtCelsius.Size = New Size(150, 31)
        txtCelsius.TabIndex = 0
        txtCelsius.Text = "Enter Celsius"
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(541, 181)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 34)
        btnReset.TabIndex = 2
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(567, 129)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(59, 25)
        lblResult.TabIndex = 3
        lblResult.Text = "Result"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResult)
        Controls.Add(btnReset)
        Controls.Add(txtCelsius)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCelsius As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents lblResult As Label

End Class
