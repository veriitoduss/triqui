Public Class Form2
    Private Sub INICIARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INICIARToolStripMenuItem.Click
        Me.Visible = False
        Form1.Show()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Me.Visible = False
        Form3.Show()
    End Sub
End Class