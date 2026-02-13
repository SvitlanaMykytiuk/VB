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
        LabelDate = New Label()
        LabelCategory = New Label()
        LabelAmount = New Label()
        LabelTotal = New Label()
        dtpDate = New DateTimePicker()
        cmbCategory = New ComboBox()
        txtAmount = New TextBox()
        btnAdd = New Button()
        btnDelete = New Button()
        dgvExpenses = New DataGridView()
        lblTotal = New Label()
        TextBox1 = New TextBox()
        btnSave = New Button()
        CType(dgvExpenses, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelDate
        ' 
        LabelDate.AutoSize = True
        LabelDate.Location = New Point(718, 34)
        LabelDate.Name = "LabelDate"
        LabelDate.Size = New Size(0, 25)
        LabelDate.TabIndex = 0
        ' 
        ' LabelCategory
        ' 
        LabelCategory.AutoSize = True
        LabelCategory.Location = New Point(683, 89)
        LabelCategory.Name = "LabelCategory"
        LabelCategory.Size = New Size(0, 25)
        LabelCategory.TabIndex = 1
        ' 
        ' LabelAmount
        ' 
        LabelAmount.AutoSize = True
        LabelAmount.Location = New Point(690, 144)
        LabelAmount.Name = "LabelAmount"
        LabelAmount.Size = New Size(0, 25)
        LabelAmount.TabIndex = 2
        ' 
        ' LabelTotal
        ' 
        LabelTotal.AutoSize = True
        LabelTotal.Location = New Point(709, 194)
        LabelTotal.Name = "LabelTotal"
        LabelTotal.Size = New Size(0, 25)
        LabelTotal.TabIndex = 3
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(28, 398)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(300, 31)
        dtpDate.TabIndex = 4
        ' 
        ' cmbCategory
        ' 
        cmbCategory.FormattingEnabled = True
        cmbCategory.Location = New Point(461, 109)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(182, 33)
        cmbCategory.TabIndex = 5
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(493, 34)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(150, 31)
        txtAmount.TabIndex = 6
        txtAmount.TextAlign = HorizontalAlignment.Right
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(531, 166)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 34)
        btnAdd.TabIndex = 7
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(531, 264)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 8
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' dgvExpenses
        ' 
        dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvExpenses.Location = New Point(28, 25)
        dgvExpenses.Name = "dgvExpenses"
        dgvExpenses.RowHeadersWidth = 62
        dgvExpenses.Size = New Size(360, 225)
        dgvExpenses.TabIndex = 9
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(253, 273)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(49, 25)
        lblTotal.TabIndex = 10
        lblTotal.Text = "Total"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(493, 71)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 11
        TextBox1.Text = "Choose category"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(531, 398)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 34)
        btnSave.TabIndex = 12
        btnSave.Text = "Save to CSV"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(850, 556)
        Controls.Add(btnSave)
        Controls.Add(TextBox1)
        Controls.Add(lblTotal)
        Controls.Add(dgvExpenses)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(txtAmount)
        Controls.Add(cmbCategory)
        Controls.Add(dtpDate)
        Controls.Add(LabelTotal)
        Controls.Add(LabelAmount)
        Controls.Add(LabelCategory)
        Controls.Add(LabelDate)
        Name = "Form1"
        Text = "Form1"
        CType(dgvExpenses, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelCategory As Label
    Friend WithEvents LabelAmount As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvExpenses As DataGridView
    Friend WithEvents lblTotal As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnSave As Button

End Class
