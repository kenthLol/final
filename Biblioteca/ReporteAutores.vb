﻿Public Class ReporteAutores
    Dim conexion As conexion = New conexion()
    Private Sub ReporteAutores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        RenderData()
    End Sub

    Public Sub RenderData()
        Dim sql As String
        sql = "call seleccionar_autores()"
        conexion.consulta(sql)
        Me.DataGridAutores.DataSource = conexion.ds.Tables(0)
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
    End Sub

    Private Sub ButtonExport_Click(sender As Object, e As EventArgs) Handles ButtonExport.Click
        GridAExcel(DataGridAutores)
    End Sub
End Class