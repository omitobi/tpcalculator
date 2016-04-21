Public Class calc1
    Dim calcStack As Collections.Stack
    'Dim calcArr(12) As System.Array
    'Dim value1(12) As Decimal
    Dim num As Integer
    Public dNumber As Double
    Public sOperation As String
    Public bFirst, bSecond, bHasOpern As Boolean
    '
    Dim takePlus As Integer
    Public Sub checkZero2()
        If Val(ResultBox1.Text) = 0 And ResultBox1.Text Is Nothing Then
            ResultBox1.Clear()

        End If
    End Sub
    Private Sub operWork()
        If (sOperation = plus.Text) Then
            dNumber = Val(Me.ResultBox1.Text) + dNumber
        ElseIf (sOperation = minus.Text) Then
            dNumber = Val(Me.ResultBox1.Text) - dNumber
        ElseIf (sOperation = mult.Text) Then
            dNumber = Val(Me.ResultBox1.Text) * dNumber
        ElseIf (sOperation = divide.Text) Then
            dNumber = dNumber / Val(Me.ResultBox1.Text)
        Else
            Exit Sub
        End If
    End Sub
    Public Sub if2()
        If bHasOpern Then
            bFirst = True
        End If
    End Sub
    Public Sub makeZero()
        ResultBox1.Text = 0
    End Sub
    '
    '
    '


    '
    '
    '
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResultBox1.TextChanged

    End Sub

    Private Sub StandardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StandardToolStripMenuItem.Click

    End Sub

    Private Sub ToolsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsToolStripMenuItem.Click

    End Sub

    'Private Sub calc1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    '   Select Case e.KeyCode
    '      Case Keys.A
    '         MsgBox("one")
    'End Select
    'End Sub

    Private Sub calc1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dNumber = 0
        sOperation = vbNullString
        bFirst = False
        bSecond = False
        'For Buttons
        ResultBox1.MaxLength = 10
        'Now for operator


    End Sub


    Private Sub one_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles one.Click

        checkZero2()
        ' ResultBox1.Text &= one.Text

        If bFirst Then
            If dNumber <> 0 Then
                If Me.ResultBox1.Text = 0 Then
                    Me.ResultBox1.Text = 1
                    bSecond = True
                    Exit Sub
                End If
                Me.ResultBox1.Text &= 1

                Exit Sub
            End If
            Me.ResultBox1.Text &= 1

        Else
            Me.ResultBox1.Text = 1
            bFirst = True
            bHasOpern = False
        End If

        

    End Sub

    Private Sub backspace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backspace.Click
        checkZero2()
        Try
            ResultBox1.Text = calcStack.Pop()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub plus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plus.Click
        'ResultBox1.SelectAll()
        'ResultBox1.Copy()
        'ResultBox1.Clear()
        'ResultBox1.Paste(plusCopy)

        'calcStack.CopyTo(calcArr(1), result)
        'resultBox2.Text = calcStack.ToString()
        'c()alcStack.Clear()
        'calcStack.ToArray()
        'resultBox2.Text = plusCopy
        checkZero2()
        If bSecond Then
            If bHasOpern Then
                operWork()

                sOperation = "+"
                bSecond = False
                Me.ResultBox1.Text = 0
                Exit Sub
            Else
      
                dNumber = dNumber + Val(Me.ResultBox1.Text)
                bHasOpern = False
                Me.ResultBox1.Text = 0
                Exit Sub
            End If
        End If
        If bFirst Or bHasOpern Then
            if2()
            sOperation="+"
            dNumber = Val(Me.ResultBox1.Text)
            Me.ResultBox1.Text = 0
        End If

    End Sub
    Private Sub eq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eq.Click
        'checkZero2()

        'takePlus = Val(ResultBox1.Text) + Val(resultBox2.Text)

        'ResultBox1.Text = takePlus
        'Now for the equal to
        If bFirst And bSecond Then
            If (sOperation = plus.Text) Then
                Me.ResultBox1.Text = Val(Me.ResultBox1.Text) + dNumber
            ElseIf (sOperation = minus.Text) Then
                Me.ResultBox1.Text = Val(Me.ResultBox1.Text) - dNumber
            ElseIf (sOperation = mult.Text) Then
                Me.ResultBox1.Text = Val(Me.ResultBox1.Text) * dNumber
            ElseIf (sOperation = divide.Text) Then
                Me.ResultBox1.Text = dNumber / Val(Me.ResultBox1.Text)
            Else
                Exit Sub
            End If
            dNumber = Val(Me.ResultBox1.Text)
            bFirst = False
            bSecond = False
            bHasOpern = True
            sOperation = ""
        End If
    End Sub



    Private Sub two_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles two.Click
        num = 2

        ' ResultBox1.Text &= one.Text
        'calcStack.Push(ResultBox1.Text)
        If bFirst Then

            If dNumber <> 0 Then
                If Me.ResultBox1.Text = 0 Then
                    Me.ResultBox1.Text = num
                    bSecond = True
                    Exit Sub
                End If
                Me.ResultBox1.Text &= num
                Exit Sub
            End If
            Me.ResultBox1.Text &= num
        Else
            Me.ResultBox1.Text = num
            bFirst = True
            bHasOpern = False
        End If

    End Sub

    Private Sub three_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles three.Click
        num = 3

        ' ResultBox1.Text &= one.Text
        'calcStack.Push(ResultBox1.Text)
        If bFirst Then

            If dNumber <> 0 Then
                If Me.ResultBox1.Text = 0 Then
                    Me.ResultBox1.Text = num
                    bSecond = True
                    Exit Sub
                End If
                Me.ResultBox1.Text &= num
                Exit Sub
            End If
            Me.ResultBox1.Text &= num
        Else
            Me.ResultBox1.Text = num
            bFirst = True
            bHasOpern = False
        End If

    End Sub

    Private Sub four_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles four.Click
        num = 4

        ' ResultBox1.Text &= one.Text
        'calcStack.Push(ResultBox1.Text)
        If bFirst Then

            If dNumber <> 0 Then
                If Me.ResultBox1.Text = 0 Then
                    Me.ResultBox1.Text = num
                    bSecond = True
                    Exit Sub
                End If
                Me.ResultBox1.Text &= num
                Exit Sub
            End If
            Me.ResultBox1.Text &= num
        Else
            Me.ResultBox1.Text = num
            bFirst = True
            bHasOpern = False
        End If

    End Sub

    Private Sub five_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles five.Click
        num = 5

        ' ResultBox1.Text &= one.Text
        'calcStack.Push(ResultBox1.Text)
        If bFirst Then

            If dNumber <> 0 Then
                If Me.ResultBox1.Text = 0 Then
                    Me.ResultBox1.Text = num
                    bSecond = True
                    Exit Sub
                End If
                Me.ResultBox1.Text &= num
                Exit Sub
            End If
            Me.ResultBox1.Text &= num
        Else
            Me.ResultBox1.Text = num
            bFirst = True
            bHasOpern = False
        End If

    End Sub

    Private Sub six_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles six.Click
        num = 6

        ' ResultBox1.Text &= one.Text
        'calcStack.Push(ResultBox1.Text)
        If bFirst Then

            If dNumber <> 0 Then
                If Me.ResultBox1.Text = 0 Then
                    Me.ResultBox1.Text = num
                    bSecond = True
                    Exit Sub
                End If
                Me.ResultBox1.Text &= num
                Exit Sub
            End If
            Me.ResultBox1.Text &= num
        Else
            Me.ResultBox1.Text = num
            bFirst = True
            bHasOpern = False
        End If

    End Sub

    Private Sub seven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seven.Click
        num = 7

        ' ResultBox1.Text &= one.Text
        'calcStack.Push(ResultBox1.Text)
        If bFirst Then

            If dNumber <> 0 Then
                If Me.ResultBox1.Text = 0 Then
                    Me.ResultBox1.Text = num
                    bSecond = True
                    Exit Sub
                End If
                Me.ResultBox1.Text &= num
                Exit Sub
            End If
            Me.ResultBox1.Text &= num
        Else
            Me.ResultBox1.Text = num
            bFirst = True
            bHasOpern = False
        End If

    End Sub

    Private Sub eight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eight.Click
        num = 8

        ' ResultBox1.Text &= one.Text
        'calcStack.Push(ResultBox1.Text)
        If bFirst Then

            If dNumber <> 0 Then
                If Me.ResultBox1.Text = 0 Then
                    Me.ResultBox1.Text = num
                    bSecond = True
                    Exit Sub
                End If
                Me.ResultBox1.Text &= num
                Exit Sub
            End If
            Me.ResultBox1.Text &= num
        Else
            Me.ResultBox1.Text = num
            bFirst = True
            bHasOpern = False
        End If

    End Sub

    Private Sub nine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nine.Click
        num = 9

        ' ResultBox1.Text &= one.Text
        'calcStack.Push(ResultBox1.Text)
        If bFirst Then

            If dNumber <> 0 Then
                If Me.ResultBox1.Text = 0 Then
                    Me.ResultBox1.Text = num
                    bSecond = True
                    Exit Sub
                End If
                Me.ResultBox1.Text &= num
                Exit Sub
            End If
            Me.ResultBox1.Text &= num
        Else
            Me.ResultBox1.Text = num
            bFirst = True
            bHasOpern = False
        End If

    End Sub
    Private Sub zero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zero.Click

        If bFirst Then
            If dNumber <> 0 Then
                If Me.ResultBox1.Text <> 0 Then
                    Me.ResultBox1.Text &= 0
                End If
                Exit Sub
            End If
            Me.ResultBox1.Text &= 0
        Else
            Me.ResultBox1.Text = 0
        End If

    End Sub

    Private Sub clr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clr.Click
        ResultBox1.Clear()
        makeZero()
    End Sub

    Private Sub ce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ce.Click
        ResultBox1.Clear()
        makeZero()
    End Sub

    Private Sub inverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inverse.Click
        Dim invTake As Single
        checkZero2()

        invTake = 1 / Val(ResultBox1.Text)
        ResultBox1.Text = invTake

    End Sub

    Private Sub minus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minus.Click
        If bSecond Then
            If bHasOpern Then
                operWork()

                sOperation = minus.Text
                bSecond = False
                Me.ResultBox1.Text = 0
                Exit Sub
            Else

                dNumber = dNumber - Val(Me.ResultBox1.Text)
                bHasOpern = False
                Me.ResultBox1.Text = 0
                Exit Sub
            End If
        End If
        If bFirst Or bHasOpern Then
            if2()
            sOperation = minus.Text
            dNumber = Val(Me.ResultBox1.Text)
            Me.ResultBox1.Text = 0
        End If
    End Sub

    Private Sub mult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mult.Click
        If bSecond Then
            If bHasOpern Then
                operWork()

                sOperation = mult.Text
                bSecond = False
                Me.ResultBox1.Text = 0
                Exit Sub
            Else

                dNumber = dNumber * Val(Me.ResultBox1.Text)
                bHasOpern = False
                Me.ResultBox1.Text = 0
                Exit Sub
            End If
        End If
        If bFirst Or bHasOpern Then
            if2()
            sOperation = mult.Text
            dNumber = Val(Me.ResultBox1.Text)
            Me.ResultBox1.Text = 0
        End If
    End Sub

    Private Sub divide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles divide.Click
        resultBox2.Text &= ResultBox1.Text & " " & divide.Text
        If bSecond Then
            If bHasOpern Then
                operWork()

                sOperation = divide.Text
                bSecond = False
                Me.ResultBox1.Text = 0
                Exit Sub
            Else

                dNumber = Val(Me.ResultBox1.Text) / dNumber
                bHasOpern = False
                Me.ResultBox1.Text = 0
                Exit Sub
            End If
        End If
        If bFirst Or bHasOpern Then
            if2()
            sOperation = divide.Text
            dNumber = Val(Me.ResultBox1.Text)
            Me.ResultBox1.Text = 0
        End If
    End Sub

    Private Sub sqRoot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sqRoot.Click
        checkZero2()
        Dim sqrtCal As Decimal
        sqrtCal = Val(ResultBox1.Text) ^ 0.5
        ResultBox1.Text = sqrtCal
    End Sub

    Private Sub MemR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemR.Click
        dNumber = Val(ResultBox1.Text)
        ResultBox1.Text = dNumber
    End Sub

    Private Sub plusMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plusMinus.Click
        checkZero2()
        ResultBox1.Text = "-" & Val(ResultBox1.Text)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutLTSAM.Show()
        AboutLTSAM.BringToFront()
    End Sub

    Private Sub percent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles percent.Click
        Dim perc As Decimal
        perc = Val(ResultBox1.Text) / 100
        ResultBox1.Text = perc
    End Sub

    Private Sub RedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedToolStripMenuItem.Click

        Me.BackColor = Color.Red
    End Sub

    Private Sub GreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GreenToolStripMenuItem.Click
        Me.BackColor = Color.Green
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.BackColor = Color.White
    End Sub

    Private Sub YellowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YellowToolStripMenuItem.Click
        Me.BackColor = Color.Yellow
    End Sub

    Private Sub OrangeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrangeToolStripMenuItem.Click
        Me.BackColor = Color.Orange
    End Sub

    Private Sub NoneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoneToolStripMenuItem.Click
        Me.BackColor = DefaultBackColor

    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        ResultBox1.Copy()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        ResultBox1.Cut()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        ResultBox1.Paste()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        resultBox2.Text = "Redo " & ResultBox1.Text
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        ResultBox1.Undo()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        AboutBox1.Show()
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        MsgBox("LTSAM Calculator Thanks")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
