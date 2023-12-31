Imports System.Data

Public Class Form1
    Dim nextPlayer As Char = "X"
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        restart()
        showNext()
    End Sub
    Public Function restart()
        'Use the "Text" property to specify or determine the caption to display in the Button control.
        b1.Text = ""
        b2.Text = ""
        b3.Text = ""
        b4.Text = ""
        b5.Text = ""
        b6.Text = ""
        b7.Text = ""
        b8.Text = ""
        b9.Text = ""
        Return True
    End Function

    Public Function showNext()
        If (nextPlayer = "X") Then
            nextPlayer = "0"
        ElseIf (nextPlayer = "0") Then
            nextPlayer = "X"
        End If
        lblnext.Text = "Next is : " + nextPlayer
        Return nextPlayer
    End Function

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        PrintButtonText(b1)
    End Sub
    Public Function PrintButtonText(ByVal btn As Button)
        If btn.Text = "" Then
            btn.Text = nextPlayer
            checkWinner()
            showNext()
        End If
        Return True

    End Function

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        PrintButtonText(b2)
    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        PrintButtonText(b3)
    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        PrintButtonText(b4)
    End Sub

    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        PrintButtonText(b5)
    End Sub

    Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click
        PrintButtonText(b6)
    End Sub

    Private Sub b7_Click(sender As Object, e As EventArgs) Handles b7.Click
        PrintButtonText(b7)
    End Sub

    Private Sub b8_Click(sender As Object, e As EventArgs) Handles b8.Click
        PrintButtonText(b8)
    End Sub

    Private Sub b9_Click(sender As Object, e As EventArgs) Handles b9.Click
        PrintButtonText(b9)
    End Sub
    Public Function checkWinner()

        If b1.Text = b2.Text And b2.Text = b3.Text Then
            winner(b1, b2, b3)
        ElseIf b1.Text = b5.Text And b5.Text = b9.Text Then
            winner(b1, b5, b9)
        ElseIf b4.Text = b5.Text And b5.Text = b6.Text Then
            winner(b4, b5, b6)
        ElseIf b7.Text = b8.Text And b8.Text = b9.Text Then
            winner(b7, b8, b9)
        ElseIf b1.Text = b4.Text And b4.Text = b7.Text Then
            winner(b1, b4, b7)
        ElseIf b2.Text = b5.Text And b5.Text = b8.Text Then
            winner(b2, b5, b8)
        ElseIf b3.Text = b6.Text And b6.Text = b9.Text Then
            winner(b3, b6, b9)
        ElseIf b3.Text = b5.Text And b5.Text = b7.Text Then
            winner(b3, b5, b7)

        End If
    End Function

    Public Function winner(ByVal btn1 As Button, ByVal btn2 As Button, ByVal btn3 As Button)
        ' It checks If the text Of any Of the three buttons (btn1, btn2, btn3) Is empty (i.e., "")
        ' using the condition btn1.Text = "" Or btn2.Text = "" Or btn3.Text = "".
        ' If at Then least one Of the buttons doesn't have text in it (i.e., the condition is true),
        ' then nothing happens because the code block inside the If statement is empty. This means
        ' that no winner message is displayed when any of the buttons is empty.
        ' If all three buttons have text In them (i.e., the condition Is False),
        ' Then it uses the MsgBox Function To display a message box indicating that btn1.Text (the text Of the first button) Is the winner.
        ' The ToString method Is used To convert the text Of the button To a String before displaying it In the message box.
        If btn1.Text = "" Or btn2.Text = "" Or btn3.Text = "" Then
            Else
            '"ToString" is the major formatting method in the . NET Framework. It converts an object to its string representation so that it is suitable for display.
            MsgBox(btn1.Text.ToString + " is winner")
                'or  MsgBox(btn1.Text.& " is winner")
            End If
    End Function
    'Public Function Winner(ByVal btn1 As Button, ByVal btn2 As Button, ByVal btn3 As Button) As String
    'If btn1.Text = btn2.Text AndAlso btn2.Text = btn3.Text AndAlso btn1.Text <> "" Then
    ''Return btn1.Text & " is the winner"
    'Else
    'Return "No winner yet"
    'End If
    'End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close() 'for exit 

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
