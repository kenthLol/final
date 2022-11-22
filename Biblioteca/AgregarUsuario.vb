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
End Class