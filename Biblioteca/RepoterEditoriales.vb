Public Class RepoterEditoriales

    Dim conexion As conexion = New conexion()

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
    End Sub

    Private Sub RepoterEditoriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        RenderData()
    End Sub

    Public Sub RenderData()
        Dim sql As String
        sql = "call seleccionar_editorial()"
        conexion.consulta(sql)
        Me.DataGridEditoriales.DataSource = conexion.ds.Tables(0)
    End Sub

End Class