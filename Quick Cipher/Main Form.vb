' Project purpose:  To provide users with an interface with useful functions for converting
' plain text to base64, to binary, and vice-versa. The user also has direct access to the
' character and word counts of their input in addition to the complete elapsed time
' for each conversion process.
' @author      Solomon Colley
' @since       03/08/2019
' @file        Main Form.vb

Option Explicit On
Option Infer Off
Option Strict On

Imports System.Text.RegularExpressions

Public Class MainForm
    Private wordCount As MatchCollection
    Private base64Cipher As New Base64Cipher
    Private binaryCipher As New BinaryCipher
    Private stopWatch As New StopWatch

    ' On TextChanged method to display the character and word counts of the input textbox.
    Private Sub InputTextBox_TextChanged(sender As Object, e As EventArgs) Handles InputTextBox.TextChanged
        CharCountTextBox.Text = Convert.ToString(InputTextBox.TextLength)

        ' Separate words based on spaces.
        wordCount = Regex.Matches((InputTextBox.Text), "\S+")
        WordCountTextBox.Text = Convert.ToString(wordCount.Count)
    End Sub

    ' On Click method for closing the application.
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    ' On Click method for clearing all the textboxes in the main form.
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        For Each textBox As TextBox In Me.Controls.OfType(Of TextBox)
            textBox.Text = Nothing
        Next
    End Sub

    ' On Click method for converting the input text to base64.
    Private Sub ToBase64Button_Click(sender As Object, e As EventArgs) Handles ToBase64Button.Click
        stopWatch.StartNow()
        base64Cipher.SetText(InputTextBox.Text)
        OutputTextBox.Text = base64Cipher.GetBase64()
        stopWatch.StopNow()
        ConversionTimeTextBox.Text = String.Format(stopWatch.GetElapsedTime() & " s")
    End Sub

    ' On Click method for converting the input base64 to text.
    Private Sub FromBase64Button_Click(sender As Object, e As EventArgs) Handles FromBase64Button.Click
        stopWatch.StartNow()
        base64Cipher.SetBase64(InputTextBox.Text)
        OutputTextBox.Text = base64Cipher.GetText()
        stopWatch.StopNow()
        ConversionTimeTextBox.Text = String.Format(stopWatch.GetElapsedTime() & " s")
    End Sub

    ' On Click method for converting the input text to binary.
    Private Sub ToBinaryButton_Click(sender As Object, e As EventArgs) Handles ToBinaryButton.Click
        stopWatch.StartNow()
        binaryCipher.SetText(InputTextBox.Text)
        OutputTextBox.Text = binaryCipher.GetBinary()
        stopWatch.StopNow()
        ConversionTimeTextBox.Text = String.Format(stopWatch.GetElapsedTime() & " s")
    End Sub

    ' On Click method for converting the input binary to text.
    Private Sub FromBinaryButton_Click(sender As Object, e As EventArgs) Handles FromBinaryButton.Click
        stopWatch.StartNow()
        binaryCipher.SetBinary(InputTextBox.Text)
        OutputTextBox.Text = binaryCipher.GetText()
        stopWatch.StopNow()
        ConversionTimeTextBox.Text = String.Format(stopWatch.GetElapsedTime() & " s")
    End Sub

    ' On Click method to copy the output text to the clipboard.
    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        Clipboard.SetText(OutputTextBox.Text)
    End Sub
End Class
