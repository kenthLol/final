Public Class Main

    Dim conexion As conexion = New conexion()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        RenderData()
    End Sub

    Public Sub RenderData()
        Dim sql As String
        sql = "call seleccionar_libros()"
        conexion.consulta(sql)
        'Me.DataGrid.DataSource = conexion.ds.Tables(0)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub AutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorToolStripMenuItem.Click
        Autor.ShowDialog()
    End Sub

    Private Sub EditorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditorialToolStripMenuItem.Click
        Editorial.ShowDialog()
    End Sub

    Private Sub LibrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosToolStripMenuItem.Click
        Libro.ShowDialog()
    End Sub

    Private Sub LibrosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LibrosToolStripMenuItem1.Click
        ReporteLibros.ShowDialog()
    End Sub

    Private Sub CatalogoEditorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalogoEditorialToolStripMenuItem.Click
        RepoterEditoriales.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CatalogoAutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalogoAutorToolStripMenuItem.Click
        ReporteAutores.ShowDialog()
    End Sub
End Class
