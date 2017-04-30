<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMagicSquare
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelEnterOdd = New System.Windows.Forms.Label()
        Me.TextBoxOddNumber = New System.Windows.Forms.TextBox()
        Me.ButtonGenerateMagicSquare = New System.Windows.Forms.Button()
        Me.LabelSumOfFirstRowPrompt = New System.Windows.Forms.Label()
        Me.LabelSumOfFirstRowValue = New System.Windows.Forms.Label()
        Me.LabelSumOfFirstColumnPrompt = New System.Windows.Forms.Label()
        Me.LabelSumOfFirstColumnValue = New System.Windows.Forms.Label()
        Me.LabelSumOfDiagonalPrompt = New System.Windows.Forms.Label()
        Me.LabelSumOfDiagonalValue = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.TextBoxMagicSquare = New System.Windows.Forms.TextBox()
        Me.SaveFileDialogMagicSquare = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'LabelEnterOdd
        '
        Me.LabelEnterOdd.AutoSize = True
        Me.LabelEnterOdd.Location = New System.Drawing.Point(12, 9)
        Me.LabelEnterOdd.Name = "LabelEnterOdd"
        Me.LabelEnterOdd.Size = New System.Drawing.Size(113, 13)
        Me.LabelEnterOdd.TabIndex = 0
        Me.LabelEnterOdd.Text = "Enter an Odd Number:"
        '
        'TextBoxOddNumber
        '
        Me.TextBoxOddNumber.Location = New System.Drawing.Point(15, 25)
        Me.TextBoxOddNumber.Name = "TextBoxOddNumber"
        Me.TextBoxOddNumber.Size = New System.Drawing.Size(103, 20)
        Me.TextBoxOddNumber.TabIndex = 1
        '
        'ButtonGenerateMagicSquare
        '
        Me.ButtonGenerateMagicSquare.Location = New System.Drawing.Point(15, 60)
        Me.ButtonGenerateMagicSquare.Name = "ButtonGenerateMagicSquare"
        Me.ButtonGenerateMagicSquare.Size = New System.Drawing.Size(165, 66)
        Me.ButtonGenerateMagicSquare.TabIndex = 2
        Me.ButtonGenerateMagicSquare.Text = "Generate Magic Square"
        Me.ButtonGenerateMagicSquare.UseVisualStyleBackColor = True
        '
        'LabelSumOfFirstRowPrompt
        '
        Me.LabelSumOfFirstRowPrompt.AutoSize = True
        Me.LabelSumOfFirstRowPrompt.Location = New System.Drawing.Point(12, 149)
        Me.LabelSumOfFirstRowPrompt.Name = "LabelSumOfFirstRowPrompt"
        Me.LabelSumOfFirstRowPrompt.Size = New System.Drawing.Size(100, 13)
        Me.LabelSumOfFirstRowPrompt.TabIndex = 3
        Me.LabelSumOfFirstRowPrompt.Text = "Sum of First Row is:"
        '
        'LabelSumOfFirstRowValue
        '
        Me.LabelSumOfFirstRowValue.AutoSize = True
        Me.LabelSumOfFirstRowValue.Location = New System.Drawing.Point(118, 149)
        Me.LabelSumOfFirstRowValue.Name = "LabelSumOfFirstRowValue"
        Me.LabelSumOfFirstRowValue.Size = New System.Drawing.Size(0, 13)
        Me.LabelSumOfFirstRowValue.TabIndex = 4
        '
        'LabelSumOfFirstColumnPrompt
        '
        Me.LabelSumOfFirstColumnPrompt.AutoSize = True
        Me.LabelSumOfFirstColumnPrompt.Location = New System.Drawing.Point(12, 171)
        Me.LabelSumOfFirstColumnPrompt.Name = "LabelSumOfFirstColumnPrompt"
        Me.LabelSumOfFirstColumnPrompt.Size = New System.Drawing.Size(113, 13)
        Me.LabelSumOfFirstColumnPrompt.TabIndex = 5
        Me.LabelSumOfFirstColumnPrompt.Text = "Sum of First Column is:"
        '
        'LabelSumOfFirstColumnValue
        '
        Me.LabelSumOfFirstColumnValue.AutoSize = True
        Me.LabelSumOfFirstColumnValue.Location = New System.Drawing.Point(131, 171)
        Me.LabelSumOfFirstColumnValue.Name = "LabelSumOfFirstColumnValue"
        Me.LabelSumOfFirstColumnValue.Size = New System.Drawing.Size(0, 13)
        Me.LabelSumOfFirstColumnValue.TabIndex = 6
        '
        'LabelSumOfDiagonalPrompt
        '
        Me.LabelSumOfDiagonalPrompt.AutoSize = True
        Me.LabelSumOfDiagonalPrompt.Location = New System.Drawing.Point(12, 193)
        Me.LabelSumOfDiagonalPrompt.Name = "LabelSumOfDiagonalPrompt"
        Me.LabelSumOfDiagonalPrompt.Size = New System.Drawing.Size(123, 13)
        Me.LabelSumOfDiagonalPrompt.TabIndex = 7
        Me.LabelSumOfDiagonalPrompt.Text = "Sum of Diagonal Row is:"
        '
        'LabelSumOfDiagonalValue
        '
        Me.LabelSumOfDiagonalValue.AutoSize = True
        Me.LabelSumOfDiagonalValue.Location = New System.Drawing.Point(141, 193)
        Me.LabelSumOfDiagonalValue.Name = "LabelSumOfDiagonalValue"
        Me.LabelSumOfDiagonalValue.Size = New System.Drawing.Size(0, 13)
        Me.LabelSumOfDiagonalValue.TabIndex = 8
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(15, 230)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(163, 39)
        Me.ButtonSave.TabIndex = 9
        Me.ButtonSave.Text = "Save Result to File"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'TextBoxMagicSquare
        '
        Me.TextBoxMagicSquare.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMagicSquare.Location = New System.Drawing.Point(186, 18)
        Me.TextBoxMagicSquare.Multiline = True
        Me.TextBoxMagicSquare.Name = "TextBoxMagicSquare"
        Me.TextBoxMagicSquare.Size = New System.Drawing.Size(373, 319)
        Me.TextBoxMagicSquare.TabIndex = 10
        '
        'SaveFileDialogMagicSquare
        '
        Me.SaveFileDialogMagicSquare.DefaultExt = "txt"
        Me.SaveFileDialogMagicSquare.Filter = "Text files (*.txt)|*.txt"
        '
        'FormMagicSquare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 353)
        Me.Controls.Add(Me.TextBoxMagicSquare)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.LabelSumOfDiagonalValue)
        Me.Controls.Add(Me.LabelSumOfDiagonalPrompt)
        Me.Controls.Add(Me.LabelSumOfFirstColumnValue)
        Me.Controls.Add(Me.LabelSumOfFirstColumnPrompt)
        Me.Controls.Add(Me.LabelSumOfFirstRowValue)
        Me.Controls.Add(Me.LabelSumOfFirstRowPrompt)
        Me.Controls.Add(Me.ButtonGenerateMagicSquare)
        Me.Controls.Add(Me.TextBoxOddNumber)
        Me.Controls.Add(Me.LabelEnterOdd)
        Me.Name = "FormMagicSquare"
        Me.Text = "Magic Square Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelEnterOdd As System.Windows.Forms.Label
    Friend WithEvents TextBoxOddNumber As System.Windows.Forms.TextBox
    Friend WithEvents ButtonGenerateMagicSquare As System.Windows.Forms.Button
    Friend WithEvents LabelSumOfFirstRowPrompt As System.Windows.Forms.Label
    Friend WithEvents LabelSumOfFirstRowValue As System.Windows.Forms.Label
    Friend WithEvents LabelSumOfFirstColumnPrompt As System.Windows.Forms.Label
    Friend WithEvents LabelSumOfFirstColumnValue As System.Windows.Forms.Label
    Friend WithEvents LabelSumOfDiagonalPrompt As System.Windows.Forms.Label
    Friend WithEvents LabelSumOfDiagonalValue As System.Windows.Forms.Label
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents TextBoxMagicSquare As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialogMagicSquare As System.Windows.Forms.SaveFileDialog

End Class
