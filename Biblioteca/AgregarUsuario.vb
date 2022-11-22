Public Class AgregarUsuario

    Dim conexion As conexion = New conexion()

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
    End Sub

    Private Sub AgregarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        RenderData()
    End Sub

    Public Sub RenderData()
        Dim sql As String
        sql = "call seleccionar_autores()"
        conexion.consulta(sql)
        Me.DataGridUsuarios.DataSource = conexion.ds.Tables(0)
    End Sub

    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles ButtonNuevo.Click
        Me.TextBoxApellidos.Text = ""
        Me.TextBoxCentroEstudio.Text = ""
        Me.TextBoxDir.Text = ""
        Me.TextBoxEstadoCivil.Text = ""
        Me.TextBoxNombres.Text = ""
        Me.TextBoxTel.Text = ""
    End Sub

    Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
        Dim SQL As String
        Dim res As Boolean

        If Me.TextBoxEmpty.Text = "" Then
            MessageBox.Show("Seleccionar usuario")
            Exit Sub
        End If

        If MessageBox.Show("¿Desea eliminar el registro?", "Sistema de Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        SQL = "call borrar_autor(" & Me.TextBoxEmpty.Text & ")"
        res = conexion.ejecutar(SQL)

        If res Then
            MessageBox.Show("Usuario borrado")
        Else
            MessageBox.Show("Error al borrar el registro.")
        End If

        ButtonNuevo_Click(Nothing, Nothing)

        RenderData()
    End Sub

    Private Sub DataGridUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridUsuarios.CellContentClick
        Dim user_code As String
        Dim SQL As String

        user_code = Me.DataGridUsuarios.Rows(e.RowIndex).Cells(0).Value

        SQL = "call ver_autor(" & user_code & ")"

        conexion.fila(SQL)

        If conexion.lector.Read = True Then
            Me.TextBoxEmpty.Text = conexion.lector("cod_autor").ToString
            Me.TextBoxApellidos.Text = conexion.lector("nombre_autor").ToString
            Me.TextBoxCentroEstudio.Text = conexion.lector("nombre_autor").ToString
            Me.TextBoxDir.Text = conexion.lector("nombre_autor").ToString
            Me.TextBoxEstadoCivil.Text = "M"
            Me.TextBoxNombres.Text = conexion.lector("nombre_autor").ToString
            Me.TextBoxTel.Text = conexion.lector("nombre_autor").ToString
        End If

        conexion.lector.Close()
    End Sub
End Class