' Class purpose: To provide users with an interface for converting
' text to base64 and base64 to text.
' @author       Solomon Colley
' @since        03/22/2019
' @file         Base64Cipher.vb

Public Class Base64Cipher
    Private base64 As String, text As String
    Private bytes As Byte()

    ' Default constructor.
    Public Sub New()
        Init()
    End Sub

    ' Destructor.
    Protected Overrides Sub Finalize()
        Init()
    End Sub

    ' Private Subroutine to initialize the class private member
    ' variables to default values.
    ' @return       Void
    Private Sub Init()
        text = Nothing
        base64 = Nothing
        bytes = Nothing
    End Sub

    ' Public Subroutine to reset the class member variables and
    ' assign the argument to the base64 variable.
    ' @param        The input string s in base64 format
    ' @return       Void
    Public Sub SetBase64(ByRef s As String)
        Init()
        base64 = s
    End Sub

    ' Public Subroutine to reset the class member variables and
    ' assign the argument to the text variable.
    ' @param        The input string s as plain text
    ' @return       Void
    Public Sub SetText(ByRef s As String)
        Init()
        text = s
    End Sub

    ' Public Function to convert an input string in plain text format
    ' to base64. If the conversion fails, the user is informed
    ' via a message box and an empty string is returned.
    ' @return       A base64 conversion or an empty string
    Public Function GetBase64() As String
        Try
            bytes = System.Text.Encoding.Default.GetBytes(text)
            base64 = Convert.ToBase64String(bytes)
        Catch ex As Exception
            Init()
            MessageBox.Show(String.Format("Error converting the text " &
                                          "to base64. Is it in your system's " &
                                          "default format?"))
        End Try

        Return base64
    End Function

    ' Public Function to convert an input string in base64 format
    ' to its original text. If the conversion fails, the user is informed
    ' via a message box and an empty string is returned.
    ' @return       The decrypted base64 string or an empty string
    Public Function GetText() As String
        Try
            bytes = Convert.FromBase64String(base64)
            text = System.Text.Encoding.Default.GetString(bytes)
        Catch ex As Exception
            Init()
            MessageBox.Show(String.Format("Error converting the base64 " &
                                          "to text. Is in in base64 and your system's " &
                                          "default format?"))
        End Try

        Return text
    End Function
End Class
