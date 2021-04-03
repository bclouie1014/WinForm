Public Class Form1
    Dim c, t1, t2 As Integer
    Dim t, s, q, r, m, s1, s2, s3 As Double
    Dim V As Date = #12:00:00 AM#

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        V = DateAdd("s", 1, V)
        計時器Label.Text = CStr(Format(V, "HH:mm:ss"))
    End Sub
    Private Sub 離開ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 離開ToolStripMenuItem.Click
        End
    End Sub

    Private Sub 產生算式Button_Click(sender As Object, e As EventArgs) Handles 產生算式Button.Click
        德氏速乘法ToolStripMenuItem.Enabled = False
        德氏速除法ToolStripMenuItem.Enabled = False
        德氏平方法ToolStripMenuItem.Enabled = False
        德氏開平方根ToolStripMenuItem.Enabled = False
        Select Case c
            Case 1
                If (位數一TextBox.Text = "") Or (位數二TextBox.Text = "") Then
                    MsgBox("請輸入數字", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")
                ElseIf (IsNumeric(位數一TextBox.Text) = False) Or (IsNumeric(位數二TextBox.Text) = False) Then
                    MsgBox("數字錯誤，請再檢查一次", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")
                ElseIf (Int(CInt(位數一TextBox.Text)) <> CInt(位數一TextBox.Text)) Or (Int(CInt(位數二TextBox.Text)) <> CInt(位數二TextBox.Text)) Then
                    MsgBox("位數必須是整數", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")
                ElseIf (CInt(位數一TextBox.Text) < 1) Or (CInt(位數二TextBox.Text) < 1) Then
                    MsgBox("位數不得小於1", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")
                ElseIf (CInt(位數一TextBox.Text) > 15) Or (CInt(位數二TextBox.Text) > 15) Then
                    MsgBox("位數不得超過15", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")

                Else
                    t1 = CInt(位數一TextBox.Text)
                    t2 = CInt(位數二TextBox.Text)

                    Randomize()
                    s1 = CDbl(Int((((10 ^ t1) - 1) - 10 ^ (t1 - 1) + 1) * Rnd() + 10 ^ (t1 - 1)))
                    Randomize()
                    s2 = CDbl(Int((((10 ^ t2) - 1) - 10 ^ (t2 - 1) + 1) * Rnd() + 10 ^ (t2 - 1)))

                    If (s1 < s2) Then
                        t = s1
                        s1 = s2
                        s2 = t
                    End If
                    s = s1 * s2
                    算式Label.Visible = True
                    算式Label.Enabled = True
                    算式Label.Text = CStr(s1) & "ｘ" & CStr(s2) & "="
                    作答完畢Button.Enabled = True
                    產生算式Button.Enabled = False
                    Timer1.Enabled = True
                End If
            Case 2
                Randomize()
                s1 = CDbl(Int(10 * Rnd()))
                Randomize()
                s2 = CDbl(Int(10 * Rnd()))
                Randomize()
                s3 = CDbl(Int(10 * Rnd()))
                s = ((s3 * s1) Mod 10) + ((s3 * s2) \ 10)

                算式Label.Visible = True
                算式Label.Enabled = True
                算式Label.Text = CStr(s1) & " " & CStr(s2) & "ｘ" & " " & CStr(s3)
                作答完畢Button.Enabled = True
                產生算式Button.Enabled = False
                Timer1.Enabled = True
            Case 3
                If (位數一TextBox.Text = "") Or (位數二TextBox.Text = "") Then
                    MsgBox("請輸入數字", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")
                ElseIf (IsNumeric(位數一TextBox.Text) = False) Or (IsNumeric(位數二TextBox.Text) = False) Then
                    MsgBox("數字錯誤，請再檢查一次", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")
                ElseIf (Int(CInt(位數一TextBox.Text)) <> CInt(位數一TextBox.Text)) Or (Int(CInt(位數二TextBox.Text)) <> CInt(位數二TextBox.Text)) Then
                    MsgBox("位數必須是整數", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")
                ElseIf (CInt(位數一TextBox.Text) < 1) Or (CInt(位數二TextBox.Text) < 1) Then
                    MsgBox("位數不得小於1", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")
                ElseIf (CInt(位數一TextBox.Text) > 15) Or (CInt(位數二TextBox.Text) > 15) Then
                    MsgBox("位數不得超過15", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")

                Else
                    t1 = CInt(位數一TextBox.Text)
                    t2 = CInt(位數二TextBox.Text)

                    Randomize()
                    s1 = CDbl(Int((((10 ^ t1) - 1) - 10 ^ (t1 - 1) + 1) * Rnd() + 10 ^ (t1 - 1)))
                    Randomize()
                    s2 = CDbl(Int((((10 ^ t2) - 1) - 10 ^ (t2 - 1) + 1) * Rnd() + 10 ^ (t2 - 1)))

                    If (s1 < s2) Then
                        t = s1
                        s1 = s2
                        s2 = t
                    End If

                    q = s1 \ s2
                    m = s1 Mod s2

                    算式Label.Visible = True
                    算式Label.Enabled = True
                    算式Label.Text = CStr(s1) & "÷" & CStr(s2) & "=" & "(格式:商/餘數)"
                    作答完畢Button.Enabled = True
                    產生算式Button.Enabled = False
                    Timer1.Enabled = True
                End If
            Case 4
                Randomize()
                s1 = CDbl(Int(10 * Rnd()))
                Randomize()
                s2 = CDbl(Int(10 * Rnd()))
                Randomize()
                s3 = CDbl(Int(10 * Rnd()))
                s = (s3 * s1) + ((s3 * s2) \ 10)

                算式Label.Visible = True
                算式Label.Enabled = True
                算式Label.Text = CStr(s1) & " " & CStr(s2) & "ｘ" & " " & CStr(s3)
                作答完畢Button.Enabled = True
                產生算式Button.Enabled = False
                Timer1.Enabled = True
            Case 5
                Randomize()
                s1 = CDbl(Int(10 * Rnd()))
                Randomize()
                s2 = CDbl(Int(10 * Rnd()))
                Randomize()
                s3 = CDbl(Int(10 * Rnd()))
                s = ((s3 * s2) Mod 10)

                算式Label.Visible = True
                算式Label.Enabled = True
                算式Label.Text = CStr(s1) & " " & CStr(s2) & "ｘ" & " " & CStr(s3)
                作答完畢Button.Enabled = True
                產生算式Button.Enabled = False
                Timer1.Enabled = True
            Case 6
                If (位數三ComboBox.Text = "") Then
                    MsgBox("請選擇數字", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")
                Else
                    t1 = CInt(位數三ComboBox.Text)
                    Randomize()
                    s1 = CDbl(Int((((10 ^ t1) - 1) - 10 ^ (t1 - 1) + 1) * Rnd() + 10 ^ (t1 - 1)))
                    s = s1 ^ 2
                    算式Label.Visible = True
                    算式Label.Enabled = True
                    算式Label.Text = CStr(s1) & "的平方="
                    作答完畢Button.Enabled = True
                    產生算式Button.Enabled = False
                    Timer1.Enabled = True
                End If
            Case 7
                Randomize()
                s1 = CDbl(Int(10 * Rnd()))
                Randomize()
                s2 = CDbl(Int(10 * Rnd()))
                s = s1 * s2 * 2

                算式Label.Visible = True
                算式Label.Enabled = True
                算式Label.Text = CStr(s1) & CStr(s2)
                作答完畢Button.Enabled = True
                產生算式Button.Enabled = False
                Timer1.Enabled = True
            Case 8
                If (位數四TextBox.Text = "") Then
                    MsgBox("請輸入數字", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")
                ElseIf (IsNumeric(位數四TextBox.Text) = False) Then
                    MsgBox("數字錯誤，請再檢查一次", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")
                ElseIf (Int(CInt(位數四TextBox.Text)) <> CInt(位數四TextBox.Text)) Then
                    MsgBox("位數必須是整數", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")
                ElseIf (CInt(位數四TextBox.Text) < 2) Then
                    MsgBox("位數不得小於2", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")
                ElseIf (CInt(位數四TextBox.Text) > 15) Then
                    MsgBox("位數不得超過15", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")
                Else
                    t1 = CInt(位數四TextBox.Text)
                    Randomize()
                    s1 = CDbl(Int((((10 ^ t1) - 1) - 10 ^ (t1 - 1) + 1) * Rnd() + 10 ^ (t1 - 1)))
                    r = 1
                    Do
                        r += 1
                    Loop Until (r ^ 2 >= s1)
                    If (r ^ 2 > s1) Then
                        r -= 1
                    End If
                    m = s1 - r ^ 2

                    算式Label.Visible = True
                    算式Label.Enabled = True
                    算式Label.Text = "√" & CStr(s1) & "=" & "(格式:平方根/餘數)"
                    作答完畢Button.Enabled = True
                    產生算式Button.Enabled = False
                    Timer1.Enabled = True
                End If
        End Select
    End Sub

    Private Sub 作答完畢Button_Click(sender As Object, e As EventArgs) Handles 作答完畢Button.Click
        Select Case c
            Case 1
                If (作答TextBox.Text = "") Then
                    MsgBox("請輸入答案", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Trachtenberg")
                ElseIf ((IsNumeric(作答TextBox.Text)) = True) And (CDbl(作答TextBox.Text) <> s) Then
                    MsgBox("答案錯誤，請再檢查一次", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")
                ElseIf ((IsNumeric(作答TextBox.Text)) = False) Then
                    MsgBox("請輸入數字", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Trachtenberg")
                ElseIf (CDbl(作答TextBox.Text) = s) Then
                    Timer1.Enabled = False
                    MsgBox("正確答案！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Trachtenberg")
                    作答完畢Button.Enabled = False
                    歸零Button.Enabled = True
                End If
            Case 2
                If (作答TextBox.Text = "") Then
                    MsgBox("請輸入答案", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Trachtenberg")
                ElseIf ((IsNumeric(作答TextBox.Text)) = True) And (CDbl(作答TextBox.Text) <> s) Then
                    MsgBox("答案錯誤，請再檢查一次", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")
                ElseIf ((IsNumeric(作答TextBox.Text)) = False) Then
                    MsgBox("請輸入數字", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Trachtenberg")
                ElseIf (CDbl(作答TextBox.Text) = s) Then
                    Timer1.Enabled = False
                    MsgBox("正確答案！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Trachtenberg")
                    作答完畢Button.Enabled = False
                    歸零Button.Enabled = True
                End If
            Case 3
                If (作答TextBox.Text = "") Then
                    MsgBox("請輸入答案(格式:商/餘數)", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Trachtenberg")
                ElseIf (作答TextBox.Text <> CStr(q) & "/" & CStr(m)) Then
                    MsgBox("答案錯誤，請再檢查一次(格式:商/餘數)", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")
                ElseIf (作答TextBox.Text = CStr(q) & "/" & CStr(m)) Then
                    Timer1.Enabled = False
                    MsgBox("正確答案！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Trachtenberg")
                    作答完畢Button.Enabled = False
                    歸零Button.Enabled = True
                End If
            Case 4
                If (作答TextBox.Text = "") Then
                    MsgBox("請輸入答案", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Trachtenberg")
                ElseIf ((IsNumeric(作答TextBox.Text)) = True) And (CDbl(作答TextBox.Text) <> s) Then
                    MsgBox("答案錯誤，請再檢查一次", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")
                ElseIf ((IsNumeric(作答TextBox.Text)) = False) Then
                    MsgBox("請輸入數字", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Trachtenberg")
                ElseIf (CDbl(作答TextBox.Text) = s) Then
                    Timer1.Enabled = False
                    MsgBox("正確答案！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Trachtenberg")
                    作答完畢Button.Enabled = False
                    歸零Button.Enabled = True
                End If
            Case 5
                If (作答TextBox.Text = "") Then
                    MsgBox("請輸入答案", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Trachtenberg")
                ElseIf ((IsNumeric(作答TextBox.Text)) = True) And (CDbl(作答TextBox.Text) <> s) Then
                    MsgBox("答案錯誤，請再檢查一次", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")
                ElseIf ((IsNumeric(作答TextBox.Text)) = False) Then
                    MsgBox("請輸入數字", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Trachtenberg")
                ElseIf (CDbl(作答TextBox.Text) = s) Then
                    Timer1.Enabled = False
                    MsgBox("正確答案！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Trachtenberg")
                    作答完畢Button.Enabled = False
                    歸零Button.Enabled = True
                End If
            Case 6
                If (作答TextBox.Text = "") Then
                    MsgBox("請輸入答案", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Trachtenberg")
                ElseIf ((IsNumeric(作答TextBox.Text)) = True) And (CDbl(作答TextBox.Text) <> s) Then
                    MsgBox("答案錯誤，請再檢查一次", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")
                ElseIf ((IsNumeric(作答TextBox.Text)) = False) Then
                    MsgBox("請輸入數字", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Trachtenberg")
                ElseIf (CDbl(作答TextBox.Text) = s) Then
                    Timer1.Enabled = False
                    MsgBox("正確答案！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Trachtenberg")
                    作答完畢Button.Enabled = False
                    歸零Button.Enabled = True
                End If
            Case 7
                If (作答TextBox.Text = "") Then
                    MsgBox("請輸入答案", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Trachtenberg")
                ElseIf ((IsNumeric(作答TextBox.Text)) = True) And (CDbl(作答TextBox.Text) <> s) Then
                    MsgBox("答案錯誤，請再檢查一次", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")
                ElseIf ((IsNumeric(作答TextBox.Text)) = False) Then
                    MsgBox("請輸入數字", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Trachtenberg")
                ElseIf (CDbl(作答TextBox.Text) = s) Then
                    Timer1.Enabled = False
                    MsgBox("正確答案！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Trachtenberg")
                    作答完畢Button.Enabled = False
                    歸零Button.Enabled = True
                End If
            Case 8
                If (作答TextBox.Text = "") Then
                    MsgBox("請輸入答案(格式:平方根/餘數)", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Trachtenberg")
                ElseIf (作答TextBox.Text <> CStr(r) & "/" & CStr(m)) Then
                    MsgBox("答案錯誤，請再檢查一次(格式:平方根/餘數)", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Trachtenberg")
                ElseIf (作答TextBox.Text = CStr(r) & "/" & CStr(m)) Then
                    Timer1.Enabled = False
                    MsgBox("正確答案！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Trachtenberg")
                    作答完畢Button.Enabled = False
                    歸零Button.Enabled = True
                End If
        End Select
    End Sub

    Private Sub 歸零Button_Click(sender As Object, e As EventArgs) Handles 歸零Button.Click
        位數一TextBox.Text = ""
        位數二TextBox.Text = ""
        位數四TextBox.Text = ""
        算式Label.Text = ""
        算式Label.Enabled = False
        算式Label.Visible = False
        作答TextBox.Text = ""
        計算紙RichTextBox.Text = ""
        產生算式Button.Enabled = True
        V = #12:00:00 AM#
        計時器Label.Text = Format(V, "HH:mm:ss")
        歸零Button.Enabled = False
        德氏速乘法ToolStripMenuItem.Enabled = True
        德氏速除法ToolStripMenuItem.Enabled = True
        德氏平方法ToolStripMenuItem.Enabled = True
        德氏開平方根ToolStripMenuItem.Enabled = True
    End Sub


    Private Sub 速乘法練習ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 速乘法練習ToolStripMenuItem.Click
        c = 1
        文字一Label.Enabled = True
        文字二Label.Enabled = True
        文字二Label.Text = "位數乘以"
        文字三Label.Enabled = True
        位數一TextBox.Enabled = True
        位數二TextBox.Enabled = True
        文字四Label.Enabled = False
        文字五Label.Enabled = False
        位數三ComboBox.Enabled = False
        文字六Label.Enabled = False
        文字七Label.Enabled = False
        位數四TextBox.Enabled = False
        文字八Label.Enabled = False
        作答TextBox.Enabled = True
        算式Label.Enabled = True
        算式Label.Visible = True
        計時器Label.Enabled = True
        產生算式Button.Enabled = True
    End Sub
    Private Sub 個十積練習ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 個十積練習ToolStripMenuItem.Click
        c = 2
        文字一Label.Enabled = False
        文字二Label.Enabled = False
        文字三Label.Enabled = False
        位數一TextBox.Enabled = False
        位數二TextBox.Enabled = False
        文字四Label.Enabled = True
        文字四Label.Text = "隨機產生一個個十積的算式"
        文字五Label.Enabled = False
        位數三ComboBox.Enabled = False
        文字六Label.Enabled = False
        文字七Label.Enabled = False
        位數四TextBox.Enabled = False
        文字八Label.Enabled = False
        作答TextBox.Enabled = True
        算式Label.Enabled = True
        算式Label.Visible = True
        計時器Label.Enabled = True
        產生算式Button.Enabled = True
    End Sub

    Private Sub 速除法練習ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 速除法練習ToolStripMenuItem.Click
        c = 3
        文字一Label.Enabled = True
        文字二Label.Enabled = True
        文字二Label.Text = "位數除以"
        文字三Label.Enabled = True
        位數一TextBox.Enabled = True
        位數二TextBox.Enabled = True
        文字四Label.Enabled = False
        文字五Label.Enabled = False
        位數三ComboBox.Enabled = False
        文字六Label.Enabled = False
        文字七Label.Enabled = False
        位數四TextBox.Enabled = False
        文字八Label.Enabled = False
        作答TextBox.Enabled = True
        算式Label.Enabled = True
        算式Label.Visible = True
        計時器Label.Enabled = True
        產生算式Button.Enabled = True
    End Sub

    Private Sub 數十積練習ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 數十積練習ToolStripMenuItem.Click
        c = 4
        文字一Label.Enabled = False
        文字二Label.Enabled = False
        文字三Label.Enabled = False
        位數一TextBox.Enabled = False
        位數二TextBox.Enabled = False
        文字四Label.Enabled = True
        文字四Label.Text = "隨機產生一個數十積的算式"
        文字五Label.Enabled = False
        位數三ComboBox.Enabled = False
        文字六Label.Enabled = False
        文字七Label.Enabled = False
        位數四TextBox.Enabled = False
        文字八Label.Enabled = False
        作答TextBox.Enabled = True
        算式Label.Enabled = True
        算式Label.Visible = True
        計時器Label.Enabled = True
        產生算式Button.Enabled = True
    End Sub

    Private Sub 個位積練習ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 個位積練習ToolStripMenuItem.Click
        c = 5
        文字一Label.Enabled = False
        文字二Label.Enabled = False
        文字三Label.Enabled = False
        位數一TextBox.Enabled = False
        位數二TextBox.Enabled = False
        文字四Label.Enabled = True
        文字四Label.Text = "隨機產生一個個位積的算式"
        文字五Label.Enabled = False
        位數三ComboBox.Enabled = False
        文字六Label.Enabled = False
        文字七Label.Enabled = False
        位數四TextBox.Enabled = False
        文字八Label.Enabled = False
        作答TextBox.Enabled = True
        算式Label.Enabled = True
        算式Label.Visible = True
        計時器Label.Enabled = True
        產生算式Button.Enabled = True
    End Sub
    Private Sub 平方練習ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 平方練習ToolStripMenuItem.Click
        c = 6
        文字一Label.Enabled = False
        文字二Label.Enabled = False
        文字三Label.Enabled = False
        位數一TextBox.Enabled = False
        位數二TextBox.Enabled = False
        文字四Label.Enabled = False
        文字五Label.Enabled = True
        位數三ComboBox.Enabled = True
        文字六Label.Enabled = True
        文字七Label.Enabled = False
        位數四TextBox.Enabled = False
        文字八Label.Enabled = False
        作答TextBox.Enabled = True
        算式Label.Enabled = True
        算式Label.Visible = True
        計時器Label.Enabled = True
        產生算式Button.Enabled = True
    End Sub
    Private Sub 橫積練習ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 橫積練習ToolStripMenuItem.Click
        c = 7
        文字一Label.Enabled = False
        文字二Label.Enabled = False
        文字三Label.Enabled = False
        位數一TextBox.Enabled = False
        位數二TextBox.Enabled = False
        文字四Label.Enabled = True
        文字四Label.Text = "隨機產生一個橫積的算式"
        文字五Label.Enabled = False
        位數三ComboBox.Enabled = False
        文字六Label.Enabled = False
        文字七Label.Enabled = False
        位數四TextBox.Enabled = False
        文字八Label.Enabled = False
        作答TextBox.Enabled = True
        算式Label.Enabled = True
        算式Label.Visible = True
        計時器Label.Enabled = True
        產生算式Button.Enabled = True
    End Sub
    Private Sub 開平方根練習ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 開平方根練習ToolStripMenuItem.Click
        c = 8
        文字一Label.Enabled = False
        文字二Label.Enabled = False
        文字三Label.Enabled = False
        位數一TextBox.Enabled = False
        位數二TextBox.Enabled = False
        文字四Label.Enabled = False
        文字五Label.Enabled = False
        位數三ComboBox.Enabled = False
        文字六Label.Enabled = False
        文字七Label.Enabled = True
        位數四TextBox.Enabled = True
        文字八Label.Enabled = True
        作答TextBox.Enabled = True
        算式Label.Enabled = True
        算式Label.Visible = True
        計時器Label.Enabled = True
        產生算式Button.Enabled = True
    End Sub
End Class