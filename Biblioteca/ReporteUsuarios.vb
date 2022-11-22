Public Class ReporteUsuarios

    Dim conexion As conexion = New conexion()

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
    End Sub

    Private Sub DataGridAutores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridUsuarios.CellContentClick
    End Sub

    Public Sub RenderData()
        Dim sql As String
        sql = "call seleccionar_autores()"
        conexion.consulta(sql)
        Me.DataGridUsuarios.DataSource = conexion.ds.Tables(0)
    End Sub

    Private Sub ReporteUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        RenderData()
    End Sub
End Class