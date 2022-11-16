<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Libro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cttitulo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbeditorial = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpublicacion = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ctejemplares = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ctpaginas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ctidioma = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ctedicion = New System.Windows.Forms.TextBox()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.ButtonNuevo = New System.Windows.Forms.Button()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.ButtonBorrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Titulo"
        '
        'cttitulo
        '
        Me.cttitulo.Location = New System.Drawing.Point(106, 231)
        Me.cttitulo.Name = "cttitulo"
        Me.cttitulo.Size = New System.Drawing.Size(150, 20)
        Me.cttitulo.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Editorial"
        '
        'cbeditorial
        '
        Me.cbeditorial.FormattingEnabled = True
        Me.cbeditorial.Location = New System.Drawing.Point(106, 261)
        Me.cbeditorial.Name = "cbeditorial"
        Me.cbeditorial.Size = New System.Drawing.Size(150, 21)
        Me.cbeditorial.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Publicación"
        '
        'dtpublicacion
        '
        Me.dtpublicacion.Location = New System.Drawing.Point(106, 296)
        Me.dtpublicacion.Name = "dtpublicacion"
        Me.dtpublicacion.Size = New System.Drawing.Size(200, 20)
        Me.dtpublicacion.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Ejemplares"
        '
        'ctejemplares
        '
        Me.ctejemplares.Location = New System.Drawing.Point(106, 325)
        Me.ctejemplares.Name = "ctejemplares"
        Me.ctejemplares.Size = New System.Drawing.Size(150, 20)
        Me.ctejemplares.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 362)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "N° de páginas"
        '
        'ctpaginas
        '
        Me.ctpaginas.Location = New System.Drawing.Point(106, 358)
        Me.ctpaginas.Name = "ctpaginas"
        Me.ctpaginas.Size = New System.Drawing.Size(150, 20)
        Me.ctpaginas.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Idioma"
        '
        'ctidioma
        '
        Me.ctidioma.Location = New System.Drawing.Point(106, 388)
        Me.ctidioma.Name = "ctidioma"
        Me.ctidioma.Size = New System.Drawing.Size(150, 20)
        Me.ctidioma.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 423)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Edición"
        '
        'ctedicion
        '
        Me.ctedicion.Location = New System.Drawing.Point(106, 419)
        Me.ctedicion.Name = "ctedicion"
        Me.ctedicion.Size = New System.Drawing.Size(150, 20)
        Me.ctedicion.TabIndex = 26
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(15, 139)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(120, 30)
        Me.ButtonSalir.TabIndex = 9
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'ButtonNuevo
        '
        Me.ButtonNuevo.Location = New System.Drawing.Point(15, 31)
        Me.ButtonNuevo.Name = "ButtonNuevo"
        Me.ButtonNuevo.Size = New System.Drawing.Size(120, 30)
        Me.ButtonNuevo.TabIndex = 12
        Me.ButtonNuevo.Text = "Nuevo"
        Me.ButtonNuevo.UseVisualStyleBackColor = True
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Location = New System.Drawing.Point(15, 67)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(120, 30)
        Me.ButtonGuardar.TabIndex = 12
        Me.ButtonGuardar.Text = "Guardar"
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'ButtonBorrar
        '
        Me.ButtonBorrar.Location = New System.Drawing.Point(15, 103)
        Me.ButtonBorrar.Name = "ButtonBorrar"
        Me.ButtonBorrar.Size = New System.Drawing.Size(120, 30)
        Me.ButtonBorrar.TabIndex = 12
        Me.ButtonBorrar.Text = "Borrar"
        Me.ButtonBorrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonNuevo)
        Me.GroupBox1.Controls.Add(Me.ButtonSalir)
        Me.GroupBox1.Controls.Add(Me.ButtonGuardar)
        Me.GroupBox1.Controls.Add(Me.ButtonBorrar)
        Me.GroupBox1.Location = New System.Drawing.Point(361, 237)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(149, 187)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(508, 201)
        Me.DataGridView1.TabIndex = 28
        '
        'Libro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ctedicion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ctidioma)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ctpaginas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ctejemplares)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpublicacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbeditorial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cttitulo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Libro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Biblioteca - Libro"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents cttitulo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbeditorial As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpublicacion As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents ctejemplares As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ctpaginas As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ctidioma As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ctedicion As TextBox
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents ButtonNuevo As Button
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents ButtonBorrar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
