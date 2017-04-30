Option Strict On

Imports System.IO

Public Class FormMagicSquare

    'make magic square global to be accessed by save file dialog
    Dim magicSquare(,) As Integer

    'store if there are values in the magic square for saving
    Dim isMagicSquareFilled As Boolean = False

    ''' <summary>
    ''' Generate a magic square from on odd number
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ButtonGenerateMagicSquare_Click(sender As Object, e As EventArgs) Handles ButtonGenerateMagicSquare.Click

        'check if the input is valid
        If IsInputSmallOddInteger(TextBoxOddNumber) Then

            'variables for the magic square, all zero based
            Dim sideLength As Integer = Convert.ToInt16(TextBoxOddNumber.Text) - 1
            Dim startPosRow As Integer = 0
            Dim startPosColumn As Integer = Convert.ToInt16(Math.Ceiling(sideLength / 2))

            'the highest value for the magic square
            Dim highestValue As Integer = ((sideLength + 1) * (sideLength + 1))

            'create a magic square
            magicSquare = GenerateMagicSquare(sideLength, highestValue, startPosRow, startPosColumn)

            'write the magic square to the textbox
            DisplayMagicSquare(TextBoxMagicSquare)

            'get and write the sums for row, column and diagonal
            RowSum(LabelSumOfFirstRowValue)
            ColumnSum(LabelSumOfFirstColumnValue)
            DiagonalSum(LabelSumOfDiagonalValue)

            'the magic square is filled and all other proceedures are done
            isMagicSquareFilled = True

        End If

    End Sub

    ''' <summary>
    ''' determine if the input from the user is appropriate
    ''' </summary>
    ''' <param name="tBox"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function IsInputSmallOddInteger(tBox As TextBox) As Boolean

        Const MAX_DIGITS As Integer = 2

        'check if the input is valid
        If IsNumeric(tBox.Text) Then
            If tBox.Text.Contains("."c) = False Then
                If tBox.Text.Length <= MAX_DIGITS Then
                    If Convert.ToInt16(tBox.Text) > 0 Then
                        If (Convert.ToInt16(tBox.Text) Mod 2) <> 0 Then
                            Return True
                        Else
                            MessageBox.Show("Please enter an odd number", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                    Else
                        MessageBox.Show("Please enter a bigger number", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                Else
                    MessageBox.Show("Please enter a smaller number", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            Else
                MessageBox.Show("Please enter a whole number", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Else
            MessageBox.Show("Please enter a valid number", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

    End Function

    ''' <summary>
    ''' Creates a magic square with an odd amount of rows and columns
    ''' </summary>
    ''' <param name="sideLength"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GenerateMagicSquare(sideLength As Integer, highestValue As Integer, startRow As Integer, startColumn As Integer) As Integer(,)

        'store the values for magic square
        Dim aMagicSquare(sideLength, sideLength) As Integer

        'probes used for determining valid positions in the array
        Dim currentRow As Integer = startRow
        Dim currentColumn As Integer = startColumn

        'store current value to know which number to put in the array, and to judge the end
        Dim currentValue = 1

        'for each iteration; fill the current value in the probe x and y coordinates of the array,
        'then determine the coordinates for next loop through, then increment the current value,
        'starting in top middle. Origin is in top left.
        Do While currentValue <= highestValue

            'fill in the current value to the array
            aMagicSquare(currentRow, currentColumn) = currentValue

            'decrement row and increment column
            currentRow = IncrementWrap(currentRow, -1, sideLength)
            currentColumn = IncrementWrap(currentColumn, 1, sideLength)

            'determine if position is filled
            If aMagicSquare(currentRow, currentColumn) <> 0 Then
                'increment row twice and decrement column once
                currentRow = IncrementWrap(currentRow, 2, sideLength)
                currentColumn = IncrementWrap(currentColumn, -1, sideLength)
            End If

            'increment the current value
            currentValue += 1

        Loop

        Return aMagicSquare

    End Function

    ''' <summary>
    ''' Allows incrementing with wrap
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function IncrementWrap(currentIndex As Integer, totalIncrement As Integer, upperBound As Integer) As Integer

        currentIndex += totalIncrement

        If currentIndex > upperBound Then
            'use mod to get remainder which is new index
            currentIndex = currentIndex Mod (upperBound + 1)
        ElseIf currentIndex < 0 Then
            'convert index to positive and add to upper bounds
            currentIndex = (currentIndex * -1) + upperBound
            'mod the value to get amount above upperbounds
            currentIndex = currentIndex Mod (upperBound + 1)
            'subtract current index from upper bounds to get wrap in the right direction
            currentIndex = upperBound - currentIndex
        End If

        Return currentIndex

    End Function

    ''' <summary>
    ''' writes a magic square to a text box
    ''' </summary>
    ''' <param name="tBox"></param>
    ''' <remarks></remarks>
    Private Sub DisplayMagicSquare(tBox As TextBox)

        'clear the text box
        tBox.Text = vbNullString

        'save the biggest amount of digits to space appropriately
        Dim biggestNumberDigits As Integer = ((magicSquare.GetUpperBound(0) + 1) * (magicSquare.GetUpperBound(1) + 1)).ToString.Length()

        'index through each row and column
        For row = 0 To magicSquare.GetUpperBound(0)

            For column = 0 To magicSquare.GetUpperBound(1)

                tBox.Text &= magicSquare(row, column).ToString()

                'add spaces after all but last in the column
                If column < magicSquare.GetUpperBound(1) Then

                    'add more spaces if has fewer digits than highest digits
                    For digit = magicSquare(row, column).ToString.Length() To biggestNumberDigits - 1
                        tBox.Text &= " "
                    Next

                    'always have atleast one space
                    tBox.Text &= " "

                End If

            Next

            'add a new line after each row except the last
            If row < magicSquare.GetUpperBound(0) Then
                tBox.Text &= vbCrLf
            End If

        Next

    End Sub

    ''' <summary>
    ''' Returns the sum of all of the numbers in the first row of a magic square
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RowSum(tBox As Label)

        Dim sum As Integer = 0

        For column = 0 To magicSquare.GetUpperBound(1)
            sum += magicSquare(0, column)
        Next

        tBox.Text = sum.ToString()

    End Sub

    ''' <summary>
    ''' Returns the sum of all of the numbers in the first column of a magic square
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ColumnSum(tBox As Label)

        Dim sum As Integer = 0

        For row = 0 To magicSquare.GetUpperBound(0)
            sum += magicSquare(row, 0)
        Next

        tBox.Text = sum.ToString()

    End Sub


    ''' <summary>
    ''' Returns the sum of all of the numbers diagonally through a magic square
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DiagonalSum(tBox As Label)

        Dim sum As Integer = 0

        For rowColumn = 0 To magicSquare.GetUpperBound(0)
            sum += magicSquare(rowColumn, rowColumn)
        Next

        tBox.Text = sum.ToString()

    End Sub

    ''' <summary>
    ''' Save the magic square to a text file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        If isMagicSquareFilled = True Then
            'save to file if magic square has values
            If SaveFileDialogMagicSquare.ShowDialog = Windows.Forms.DialogResult.OK Then
                SaveToFile(SaveFileDialogMagicSquare.FileName)
            End If
        Else
            MessageBox.Show("Please create a Magic Square first", "No Magic Square", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    ''' <summary>
    ''' Writes the values of the magic square to a .txt file
    ''' </summary>
    ''' <param name="fileName"></param>
    ''' <remarks></remarks>
    Private Sub SaveToFile(fileName As String)

        Dim writer As StreamWriter = File.CreateText(fileName)

        'index through each row and column
        For row = 0 To MagicSquare.GetUpperBound(0)

            For column = 0 To MagicSquare.GetUpperBound(1)

                writer.Write(magicSquare(row, column).ToString())

                'add spaces after all but last in the column
                If column < MagicSquare.GetUpperBound(1) Then
                    writer.Write(",")
                End If

            Next

            'add a new line after each row except the last
            If row < MagicSquare.GetUpperBound(0) Then
                writer.WriteLine()
            End If

        Next

        MessageBox.Show("Results saved to " & fileName, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

        writer.Close()

    End Sub

End Class