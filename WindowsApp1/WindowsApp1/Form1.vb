Public Class Form1
    Dim navegador As String = "x"
    Dim contadorx As Integer = 0
    Dim contadory As Integer = 0
    Dim empate As Integer = 0
    Public Function xoy(ByVal nav As String)
        If nav = "x" Then
            navegador = "O"
            Return "x"
        Else
            navegador = "x"
            Return "O"
        End If
    End Function
    Public Sub ganarX()
        empate += 1
        If Button1.Text = "x" And Button2.Text = "x" And Button3.Text = "x" Then
            MsgBox("FELICIDADES X")
            final()
        ElseIf Button4.Text = "x" And Button5.Text = "x" And Button6.Text = "x" Then
            MsgBox("FELICIDADES X")
            final()
        ElseIf Button7.Text = "x" And Button8.Text = "x" And Button9.Text = "x" Then
            MsgBox("FELICIDADES X")
            final()
        ElseIf Button1.Text = "x" And Button4.Text = "x" And Button7.Text = "x" Then
            MsgBox("FELICIDADES X")
            final()
        ElseIf Button2.Text = "x" And Button5.Text = "x" And Button8.Text = "x" Then
            MsgBox("FELICIDADES X")
            final()
        ElseIf Button3.Text = "x" And Button6.Text = "x" And Button7.Text = "x" Then
            MsgBox("FELICIDADES X")
            final()
        ElseIf Button1.Text = "x" And Button5.Text = "x" And Button9.Text = "x" Then
            MsgBox("FELICIDADES X")
            final()
        ElseIf Button3.Text = "x" And Button6.Text = "x" And Button9.Text = "x" Then
            MsgBox("FELICIDADES X")
            final()
        ElseIf Button3.Text = "x" And Button5.Text = "x" And Button7.Text = "x" Then
            MsgBox("FELICIDADES X")
        ElseIf empate = 9 Then
            MsgBox(" OHHHH, LO SIENTO NADIE GANO")
            empate = 0
        End If
        ganarO()
    End Sub
    Public Sub ganarO()
        If Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
            MsgBox("FELICIDADES O")
            final2()
        ElseIf Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
            MsgBox("FELICIDADES O")
            final2()
        ElseIf Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
            MsgBox("FELICIDADES O")
            final2()
        ElseIf Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
            MsgBox("FELICIDADES O")
            final2()
        ElseIf Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
            MsgBox("FELICIDADES O")
            final2()
        ElseIf Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
            MsgBox("FELICIDADES O")
            final2()
        ElseIf Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
            MsgBox("FELICIDADES O")
            final2()
        ElseIf Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
            MsgBox("FELICIDADES O")
            final2()
        ElseIf empate = 9 Then
            MsgBox(" OHHHH, LO SIENTO NADIE GANO")
            empate = 0
        End If
    End Sub
    Public Sub final()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        contadorx += 1
        empate = 0
        Label2.Text = contadorx.ToString
    End Sub
    Public Sub final2()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        contadory += 1
        empate = 0
        Label4.Text = contadory.ToString
    End Sub
    Public Sub limpiar()
        Button1.Text = " "
        Button2.Text = " "
        Button3.Text = " "
        Button4.Text = " "
        Button5.Text = " "
        Button6.Text = " "
        Button7.Text = " "
        Button8.Text = " "
        Button9.Text = " "
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = xoy(navegador)
        Button1.Enabled = False
        ganarX()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Text = xoy(navegador)
        Button2.Enabled = False
        ganarX()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Text = xoy(navegador)
        Button3.Enabled = False
        ganarX()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Text = xoy(navegador)
        Button4.Enabled = False
        ganarX()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button5.Text = xoy(navegador)
        Button5.Enabled = False
        ganarX()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button6.Text = xoy(navegador)
        Button6.Enabled = False
        ganarX()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button7.Text = xoy(navegador)
        Button7.Enabled = False
        ganarX()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button8.Text = xoy(navegador)
        Button8.Enabled = False
        ganarX()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Button9.Text = xoy(navegador)
        Button9.Enabled = False
        ganarX()
    End Sub

    Private Sub NUEVOJUEGOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NUEVOJUEGOToolStripMenuItem.Click
        limpiar()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Me.Visible = False
        Form2.Show()
    End Sub

End Class