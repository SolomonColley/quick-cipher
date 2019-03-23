' Class purpose: To provide users with an interface for converting
' text to binary and binary to text.
' @author       Solomon Colley
' @since        03/22/2019
' @file         BinaryCipher.vb

Imports System.Text
Imports System.Text.RegularExpressions

Public Class BinaryCipher
    Private binary As String, text As String
    Private bytes As Byte()

    ' Default constructor
    Public Sub New()
        Init()
    End Sub

    ' Destructor
    Protected Overrides Sub Finalize()
        Init()
    End Sub

    ' Private Subroutine to initialize the class private member
    ' variables to default values.
    ' @return       Void
    Private Sub Init()
        binary = Nothing
        text = Nothing
        bytes = Nothing
    End Sub

    ' Private Function to determine if a character is a binary bit
    ' or not.
    ' @param        ByVal c As Char
    ' @return       True if the character is a binary bit, or false if not
    Private Function IsBinary(ByVal c As Char)
        If c = "0" Or c = "1" Then
            Return True
        Else
            Return False
        End If

        Return False
    End Function

    ' Public Subroutine to reset the class member variables and
    ' assign the argument to the binary variable.
    ' @param        The input string s in base64 format
    ' @return       Void
    Public Sub SetBinary(ByRef s As String)
        Init()
        binary = s
    End Sub

    ' Public Subroutine to reset the class member variables and
    ' assign the argument to the text variable.
    ' @param        The input string s in base64 format
    ' @return       Void
    Public Sub SetText(ByRef s As String)
        Init()
        text = s
    End Sub

    ' Public Function to convert an input string in plain text format
    ' to binary. If the conversion fails, the user is informed
    ' via a message box and an empty string is returned.
    ' @return       A binary conversion or an empty string
    Public Function GetBinary() As String
        Try
            Dim newBin As New StringBuilder
            bytes = System.Text.Encoding.Default.GetBytes(text)

            For Each c In bytes
                newBin.Append(Convert.ToString(c, 2).PadLeft(8, "0"))
            Next

            binary = newBin.ToString
        Catch ex As Exception
            Init()
            MessageBox.Show(String.Format("Error converting the text " &
                                          "to binary. Is it text in your system's " &
                                          "default format?"))
        End Try

        Return binary
    End Function

    ' Public Function to convert an input string in binary format
    ' to text. If the conversion fails, the user is informed
    ' via a message box and an empty string is returned.
    ' @return       A plain text conversion or an empty string
    Public Function GetText() As String
        For Each c As Char In binary
            ' If the binary string is not in binary format, return an empty string.
            If IsBinary(c) = False Then
                MessageBox.Show(String.Format("Error converting the binary " &
                                          "to text. Is it binary in your system's " &
                                          "default format?"))
                Init()

                Return text
            End If
        Next

        Try
            Dim tempChars As String = Regex.Replace(binary, "[^01]", "")
            Dim tempByteArr((tempChars.Length / 8) - 1) As Byte

            For i As Integer = 0 To tempByteArr.Length - 1
                tempByteArr(i) = Convert.ToByte(tempChars.Substring(i * 8, 8), 2)
            Next

            text = Encoding.Default.GetString(tempByteArr)
        Catch ex As Exception
            Init()
            MessageBox.Show(String.Format("Error converting the binary " &
                                          "to text. Is it binary in your system's " &
                                          "default format?"))
        End Try

        Return text
    End Function
End Class
