Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Editorial

    Dim conexion As conexion = New conexion()
    Private Sub Editorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llamar al metodo conectar para establecer la conexion con la 
        'base de datos
        conexion.conectar()
        'llamar a la funcion mostrardatos para visualizar los datos 
        'en el grid
        mostrardatos()
        ' seleccionar_libros
        'cargar los datos del combo pais
        Dim SQL As String
        SQL = "call seleccionar_paises_editorial()"
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
        sql = "call seleccionar_editorial()"
        conexion.consulta(sql)
        DataGridView1.DataSource = conexion.ds.Tables(0)
    End Sub

    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles ButtonNuevo.Click
        Me.ctcod_editorial.Text = ""
        Me.ctnombre_editorial.Text = ""
        Me.cbpais.SelectedIndex = -1
        Me.ctnombre_editorial.Focus()
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Dim sql, rot As String
        Dim res As Boolean
        Dim codigo As Integer
        If ctnombre_editorial.Text = "" Then
            MessageBox.Show("Digite el nombre de la editorial")
            ctnombre_editorial.Focus()
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
        If ctcod_editorial.Text = "" Then
            ctcod_editorial.Text = 0
        End If

        sql = "call ver_editorial(" + ctcod_editorial.Text + ")"
        conexion.fila(sql)

        If conexion.lector.HasRows Then
            rot = "Actualizado"
            codigo = ctcod_editorial.Text
        Else
            rot = "Guardado"
            codigo = ctcod_editorial.Text
        End If

        conexion.lector.Close()

        sql = "call insertar_editorial(" & codigo & ",'" & ctnombre_editorial.Text & "'," & cbpais.SelectedValue & ")"
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
        If ctcod_editorial.Text = "" Then
            MessageBox.Show("Seleccione una editorial")
            Exit Sub
        End If
        If MessageBox.Show("Desea eliminar el registro?", "Sistema de Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        SQL = "call borrar_editorial(" & ctcod_editorial.Text & ")"
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
        SQL = "call ver_editorial(" & codigo & ")"
        conexion.fila(SQL)
        If conexion.lector.Read = True Then
            Me.ctcod_editorial.Text = conexion.lector("cod_editorial").ToString
            Me.ctnombre_editorial.Text = conexion.lector("nombre_editorial").ToString
            Me.cbpais.SelectedValue = conexion.lector("cod_pais").ToString
        End If
        conexion.lector.Close()
    End Sub
End Class