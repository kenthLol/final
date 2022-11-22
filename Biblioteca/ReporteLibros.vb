Imports System.IO

Public Class ReporteLibros

    Dim conexion As conexion = New conexion()
    Private Sub ReporteLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        RenderData()
    End Sub

    Public Sub RenderData()
        Dim sql As String
        sql = "call seleccionar_libros()"
        conexion.consulta(sql)
        Me.DataGridLibros.DataSource = conexion.ds.Tables(0)
    End Sub

    Private Sub ButtonExport_Click(sender As Object, e As EventArgs) Handles ButtonExport.Click
        GridAExcel(DataGridLibros)
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
    End Sub
End Class