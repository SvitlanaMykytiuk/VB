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
        dgvSales = New DataGridView()
        dgvSummary = New DataGridView()
        btnLoad = New Button()
        btnAnalyse = New Button()
        cmbMonth = New ComboBox()
        lblTotal = New Label()
        CType(dgvSales, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvSummary, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvSales
        ' 
        dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSales.Location = New Point(22, 184)
        dgvSales.Name = "dgvSales"
        dgvSales.RowHeadersWidth = 62
        dgvSales.Size = New Size(360, 225)
        dgvSales.TabIndex = 0
        ' 
        ' dgvSummary
        ' 
        dgvSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSummary.Location = New Point(409, 186)
        dgvSummary.Name = "dgvSummary"
        dgvSummary.RowHeadersWidth = 62
        dgvSummary.Size = New Size(361, 223)
        dgvSummary.TabIndex = 1
        ' 
        ' btnLoad
        ' 
        btnLoad.Location = New Point(22, 23)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(112, 34)
        btnLoad.TabIndex = 2
        btnLoad.Text = "Load"
        btnLoad.UseVisualStyleBackColor = True
        ' 
        ' btnAnalyse
        ' 
        btnAnalyse.Location = New Point(22, 102)
        btnAnalyse.Name = "btnAnalyse"
        btnAnalyse.Size = New Size(112, 34)
        btnAnalyse.TabIndex = 3
        btnAnalyse.Text = "Analyse"
        btnAnalyse.UseVisualStyleBackColor = True
        ' 
        ' cmbMonth
        ' 
        cmbMonth.FormattingEnabled = True
        cmbMonth.Location = New Point(22, 63)
        cmbMonth.Name = "cmbMonth"
        cmbMonth.Size = New Size(182, 33)
        cmbMonth.TabIndex = 4
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(22, 148)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(49, 25)
        lblTotal.TabIndex = 5
        lblTotal.Text = "Total"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblTotal)
        Controls.Add(cmbMonth)
        Controls.Add(btnAnalyse)
        Controls.Add(btnLoad)
        Controls.Add(dgvSummary)
        Controls.Add(dgvSales)
        Name = "Form1"
        Text = "Form1"
        CType(dgvSales, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvSummary, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvSales As DataGridView
    Friend WithEvents dgvSummary As DataGridView
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnAnalyse As Button
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents lblTotal As Label

End Class
