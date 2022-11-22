Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Libro

    Dim conexion As conexion = New conexion()
    Private Sub Libro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        mostrardatos()

        Dim SQL As String
        SQL = "call seleccionar_editorial_libro()"
        conexion.consulta(SQL)
        If conexion.ds.Tables(0).Rows.Count > 0 Then
            With Me.cbeditorial
                .DataSource = Nothing
                .Items.Clear()
                .DataSource = conexion.ds.Tables(0)
                .DisplayMember = "nombre_editorial"
                .ValueMember = "cod_editorial"
                .SelectedIndex = -1
            End With
        End If
    End Sub

    Public Sub mostrardatos()
        Dim sql As String
        sql = "call seleccionar_libros()"
        conexion.consulta(sql)
        DataGridView1.DataSource = conexion.ds.Tables(0)
    End Sub
    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
    End Sub

    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles ButtonNuevo.Click

    End Sub
End Class