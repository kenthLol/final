Imports System.Windows
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Login

    Dim conexion As conexion = New conexion()

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
    End Sub

    Private Sub ButtonIngresar_Click(sender As Object, e As EventArgs) Handles ButtonIngresar.Click
        Dim sql As String
        If ctusuario.Text = "" Then
            MessageBox.Show("Digite el usuario")
            ctusuario.Focus()
            Exit Sub
        End If
        If ctclave.Text = "" Then
            MessageBox.Show("Digite la clave")
            ctclave.Focus()
            Exit Sub
        End If
        sql = "call consultar_login('" & ctusuario.Text & "','" & ctclave.Text & "')"
        conexion.fila(sql)
        If conexion.lector.HasRows Then
            Main.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario o Clave Inválido")
            conexion.lector.Close()
            Exit Sub
        End If
        conexion.lector.Close()
        Me.Close()
    End Sub

    Private Sub ButtonConsultar_Click(sender As Object, e As EventArgs) Handles ButtonConsultar.
        LeerLibros.ShowDialog()
    End Sub
End Class