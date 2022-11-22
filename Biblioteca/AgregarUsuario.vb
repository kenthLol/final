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

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Dim sql, rot As String
        Dim res As Boolean
        Dim codigo As Integer

        If Me.TextBoxNombres.Text = "" Then
            MessageBox.Show("Nombres vacíos", "Error")
            Me.TextBoxNombres.Focus()
            Exit Sub
        End If

        If Me.TextBoxApellidos.Text = "" Then
            MessageBox.Show("Apellidos vacíos", "Error")
            Me.TextBoxApellidos.Focus()
            Exit Sub
        End If

        If Me.TextBoxTel.Text = "" Then
            MessageBox.Show("Teléfono está vacío", "Error")
            Me.TextBoxTel.Focus()
            Exit Sub
        End If

        If Me.TextBoxDir.Text = "" Then
            MessageBox.Show("Dirección vacía", "Error")
            Me.TextBoxDir.Focus()
            Exit Sub
        End If

        If Me.ComboBoxSexo.SelectedIndex = -1 Then
            MessageBox.Show("Seleccionar sexo", "Error")
            Me.ComboBoxSexo.Focus()
            Exit Sub
        End If

        If Me.TextBoxEstadoCivil.Text = "" Then
            MessageBox.Show("Estado civil está vacío", "Error")
            Me.TextBoxEstadoCivil.Focus()
            Exit Sub
        End If

        If Me.TextBoxCentroEstudio.Text = "" Then
            MessageBox.Show("Centro de estudio vacío", "Error")
            Me.TextBoxCentroEstudio.Focus()
            Exit Sub
        End If

        If MessageBox.Show("¿Desea guardar este usuario?", "Sistema de Biblioteca ", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        If Me.TextBoxEmpty.Text = "" Then
            Me.TextBoxEmpty.Text = 0
        End If

        sql = "call ver_autor(" + Me.TextBoxEmpty.Text + ")"
        conexion.fila(sql)

        If conexion.lector.HasRows Then
            rot = "Actualizado"
            codigo = Me.TextBoxEmpty.Text
        Else
            rot = "Guardado"
            codigo = Me.TextBoxEmpty.Text
        End If

        conexion.lector.Close()

        sql = "call insertar_autor(" & codigo & ",'" & Me.TextBoxNombres.Text & "'," & "Nicaragua" & ")"
        res = conexion.ejecutar(sql)

        If res Then
            MessageBox.Show("Registro " & rot)
        Else
            MessageBox.Show("Error en el proceso de " & rot)
        End If

        ButtonNuevo_Click(Nothing, Nothing)
        RenderData()
    End Sub
End Class