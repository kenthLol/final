Public Class Main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class
