<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarUsuario
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
        Me.DataGridUsuarios = New System.Windows.Forms.DataGridView()
        Me.TextBoxEmpty = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonNuevo = New System.Windows.Forms.Button()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.ButtonBorrar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.TextBoxNombres = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxApellidos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxTel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxDir = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxCentroEstudio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxEstadoCivil = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FechaNac = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxSexo = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridUsuarios
        '
        Me.DataGridUsuarios.BackgroundColor = System.Drawing.Color.White
        Me.DataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridUsuarios.Location = New System.Drawing.Point(24, 288)
        Me.DataGridUsuarios.Name = "DataGridUsuarios"
        Me.DataGridUsuarios.Size = New System.Drawing.Size(485, 229)
        Me.DataGridUsuarios.TabIndex = 20
        '
        'TextBoxEmpty
        '
        Me.TextBoxEmpty.Location = New System.Drawing.Point(359, 542)
        Me.TextBoxEmpty.Name = "TextBoxEmpty"
        Me.TextBoxEmpty.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxEmpty.TabIndex = 19
        Me.TextBoxEmpty.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ButtonNuevo)
        Me.GroupBox1.Controls.Add(Me.ButtonGuardar)
        Me.GroupBox1.Controls.Add(Me.ButtonBorrar)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 201)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 71)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'ButtonNuevo
        '
        Me.ButtonNuevo.Location = New System.Drawing.Point(20, 25)
        Me.ButtonNuevo.Name = "ButtonNuevo"
        Me.ButtonNuevo.Size = New System.Drawing.Size(120, 30)
        Me.ButtonNuevo.TabIndex = 5
        Me.ButtonNuevo.Text = "Nuevo"
        Me.ButtonNuevo.UseVisualStyleBackColor = True
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Location = New System.Drawing.Point(183, 25)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(120, 30)
        Me.ButtonGuardar.TabIndex = 6
        Me.ButtonGuardar.Text = "Guardar"
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'ButtonBorrar
        '
        Me.ButtonBorrar.Location = New System.Drawing.Point(337, 25)
        Me.ButtonBorrar.Name = "ButtonBorrar"
        Me.ButtonBorrar.Size = New System.Drawing.Size(120, 30)
        Me.ButtonBorrar.TabIndex = 7
        Me.ButtonBorrar.Text = "Borrar"
        Me.ButtonBorrar.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(24, 536)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(120, 30)
        Me.ButtonSalir.TabIndex = 16
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'TextBoxNombres
        '
        Me.TextBoxNombres.Location = New System.Drawing.Point(24, 37)
        Me.TextBoxNombres.Name = "TextBoxNombres"
        Me.TextBoxNombres.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxNombres.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(24, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nombres"
        '
        'TextBoxApellidos
        '
        Me.TextBoxApellidos.Location = New System.Drawing.Point(191, 37)
        Me.TextBoxApellidos.Name = "TextBoxApellidos"
        Me.TextBoxApellidos.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxApellidos.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(191, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Apellidos"
        '
        'TextBoxTel
        '
        Me.TextBoxTel.Location = New System.Drawing.Point(364, 37)
        Me.TextBoxTel.Name = "TextBoxTel"
        Me.TextBoxTel.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxTel.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(364, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Teléfono"
        '
        'TextBoxDir
        '
        Me.TextBoxDir.Location = New System.Drawing.Point(24, 94)
        Me.TextBoxDir.Name = "TextBoxDir"
        Me.TextBoxDir.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxDir.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(24, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Dirección"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(191, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Fecha de nacimiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(364, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Sexo"
        '
        'TextBoxCentroEstudio
        '
        Me.TextBoxCentroEstudio.Location = New System.Drawing.Point(191, 156)
        Me.TextBoxCentroEstudio.Name = "TextBoxCentroEstudio"
        Me.TextBoxCentroEstudio.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxCentroEstudio.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(191, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Centro de Estudio"
        '
        'TextBoxEstadoCivil
        '
        Me.TextBoxEstadoCivil.Location = New System.Drawing.Point(24, 155)
        Me.TextBoxEstadoCivil.Name = "TextBoxEstadoCivil"
        Me.TextBoxEstadoCivil.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxEstadoCivil.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(24, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Estado civil"
        '
        'FechaNac
        '
        Me.FechaNac.Location = New System.Drawing.Point(195, 98)
        Me.FechaNac.Name = "FechaNac"
        Me.FechaNac.Size = New System.Drawing.Size(146, 20)
        Me.FechaNac.TabIndex = 35
        '
        'ComboBoxSexo
        '
        Me.ComboBoxSexo.FormattingEnabled = True
        Me.ComboBoxSexo.Items.AddRange(New Object() {"M", "F"})
        Me.ComboBoxSexo.Location = New System.Drawing.Point(364, 98)
        Me.ComboBoxSexo.Name = "ComboBoxSexo"
        Me.ComboBoxSexo.Size = New System.Drawing.Size(145, 21)
        Me.ComboBoxSexo.TabIndex = 36
        '
        'AgregarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Biblioteca.My.Resources.Resources.Grade_Grey
        Me.ClientSize = New System.Drawing.Size(531, 582)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBoxSexo)
        Me.Controls.Add(Me.FechaNac)
        Me.Controls.Add(Me.TextBoxCentroEstudio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxEstadoCivil)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxDir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxTel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxApellidos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridUsuarios)
        Me.Controls.Add(Me.TextBoxEmpty)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.TextBoxNombres)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AgregarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Usuario"
        CType(Me.DataGridUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridUsuarios As DataGridView
    Friend WithEvents TextBoxEmpty As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonNuevo As Button
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents ButtonBorrar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents TextBoxNombres As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxApellidos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxTel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxDir As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxCentroEstudio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxEstadoCivil As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents FechaNac As DateTimePicker
    Friend WithEvents ComboBoxSexo As ComboBox
End Class
