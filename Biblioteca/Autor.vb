Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Autor

    Dim conexion As conexion = New conexion()
    Private Sub Autor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'llamar al metodo conectar para establecer la conexion con la 
        'base de datos
        conexion.conectar()
        'llamar a la funcion mostrardatos para visualizar los datos 
        'en el grid
        mostrardatos()

        'cargar los datos del combo pais
        Dim SQL As String
        SQL = "call seleccionar_paises()"
        conexion.consulta(SQL)
        If conexion.ds.Tables(0).Rows.Count > 0 Then
            With Me.cbpais
                .DataSource = Nothing
                .Items.Clear()
                .DataSource = conexion.ds.Tables(0)
                .DisplayMember = "nombre_pais"
                .ValueMember = "cod_pais"
                .SelectedIndex = -1
            End With
        End If
    End Sub

    Public Sub mostrardatos()
        Dim sql As String
        sql = "call seleccionar_autores()"
        conexion.consulta(sql)
        DataGridView1.DataSource = conexion.ds.Tables(0)
    End Sub

    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles ButtonNuevo.Click
        Me.ctcod_autor.Text = ""
        Me.ctnombre.Text = ""
        Me.cbpais.SelectedIndex = -1
        Me.ctnombre.Focus()
    End Sub
    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Dim sql, rot As String
        Dim res As Boolean
        Dim codigo As Integer
        If ctnombre.Text = "" Then
            MessageBox.Show("Digite el nombre del autor")
            ctnombre.Focus()
            Exit Sub
        End If
        If cbpais.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el pais")
            cbpais.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Desea guardar el registro?", "Sistema de Biblioteca ", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        'verificar si existe el registro
        If ctcod_autor.Text = "" Then
            ctcod_autor.Text = 0
        End If

        sql = "call ver_autor(" + ctcod_autor.Text + ")"
        conexion.fila(sql)

        If conexion.lector.HasRows Then
            rot = "Actualizado"
            codigo = ctcod_autor.Text
        Else
            rot = "Guardado"
            codigo = ctcod_autor.Text
        End If

        conexion.lector.Close()

        sql = "call insertar_autor(" & codigo & ",'" & ctnombre.Text & "'," & cbpais.SelectedValue & ")"
        res = conexion.ejecutar(sql)

        If res Then
            MessageBox.Show("Registro " & rot)
        Else
            MessageBox.Show("Error en el proceso de " & rot)
        End If
        ButtonNuevo_Click(Nothing, Nothing)
        mostrardatos()
    End Sub

    Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
        Dim SQL As String
        Dim res As Boolean
        If ctcod_autor.Text = "" Then
            MessageBox.Show("Seleccione un autor")
            Exit Sub
        End If
        If MessageBox.Show("Desea eliminar el registro?", "Sistema de Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        SQL = "call borrar_autor(" & ctcod_autor.Text & ")"
        res = conexion.ejecutar(SQL)

        If res Then
            MessageBox.Show("Registro Borrado")
        Else
            MessageBox.Show("Error al borrar el registro")
        End If
        ButtonNuevo_Click(Nothing, Nothing)
        mostrardatos()
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim codigo As String
        codigo = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Dim SQL As String
        SQL = "call ver_autor(" & codigo & ")"
        conexion.fila(SQL)
        If conexion.lector.Read = True Then
            Me.ctcod_autor.Text = conexion.lector("cod_autor").ToString
            Me.ctnombre.Text = conexion.lector("nombre_autor").ToString
            Me.cbpais.SelectedValue = conexion.lector("cod_pais").ToString
        End If
        conexion.lector.Close()
    End Sub
End Class