﻿Public Class Presentacion

    Dim contador As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            contador = contador + 5
            ProgressBar1.Value = contador
        Else
            Me.Hide()
            Login.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Presentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class