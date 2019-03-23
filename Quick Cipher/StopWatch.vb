' Class purpose: To provide users with an interface for simulating
' the functionality of a stop watch in Visual Basic.
' @author       Solomon Colley
' @since        03/22/2019
' @file         StopWatch.vb

Public Class StopWatch
    Private startTime As DateTime
    Private stopTime As DateTime
    Private elapsedTime As TimeSpan

    ' Default constructor.
    Public Sub New()
    End Sub

    ' Public Subroutine to record the current instance of time
    ' as the start of some operation.
    ' @return   Void
    Public Sub StartNow()
        startTime = Now
    End Sub

    ' Public Subroutine to record the current instance of time
    ' as the end of some operation.
    ' @return   Void
    Public Sub StopNow()
        stopTime = Now
    End Sub

    ' Public Function to retrieve the elapsed time by subtracting
    ' the stop time from the start time.
    ' @retunr   Elapsed time as a string
    Public Function GetElapsedTime() As String
        elapsedTime = stopTime.Subtract(startTime)
        Return elapsedTime.TotalSeconds.ToString("0.000000")
    End Function
End Class
