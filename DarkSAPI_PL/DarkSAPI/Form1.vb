﻿Public Class Form1

    Private Sub ZakończToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2_Click()
        Dim SAPI
        SAPI = CreateObject("sapi.spvoice")
        SAPI.Speak(TextBox1.Text)
    End Sub

    Private Sub Button2_Click()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub
End Class

