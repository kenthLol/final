Public Class LeerLibros

    Dim conexion As conexion = New conexion()

    Private Sub LeerLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        RenderData()

    End Sub

    Public Sub RenderData()
        Dim sql As String
        sql = "call seleccionar_libros()"
        conexion.consulta(sql)
        Me.DataGridLibros.DataSource = conexion.ds.Tables(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Login.Show()
    End Sub
End Class