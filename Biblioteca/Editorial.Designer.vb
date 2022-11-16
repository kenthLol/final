<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Editorial
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonNuevo = New System.Windows.Forms.Button()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.ButtonBorrar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.ctnombre_editorial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ctcod_editorial = New System.Windows.Forms.TextBox()
        Me.cbpais = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonNuevo)
        Me.GroupBox1.Controls.Add(Me.ButtonGuardar)
        Me.GroupBox1.Controls.Add(Me.ButtonBorrar)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 71)
        Me.GroupBox1.TabIndex = 16
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
        Me.ButtonSalir.Location = New System.Drawing.Point(22, 403)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(120, 30)
        Me.ButtonSalir.TabIndex = 15
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'ctnombre_editorial
        '
        Me.ctnombre_editorial.Location = New System.Drawing.Point(22, 42)
        Me.ctnombre_editorial.Name = "ctnombre_editorial"
        Me.ctnombre_editorial.Size = New System.Drawing.Size(150, 20)
        Me.ctnombre_editorial.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(354, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "País"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nombre"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 155)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(485, 230)
        Me.DataGridView1.TabIndex = 17
        '
        'ctcod_editorial
        '
        Me.ctcod_editorial.Location = New System.Drawing.Point(190, 42)
        Me.ctcod_editorial.Name = "ctcod_editorial"
        Me.ctcod_editorial.Size = New System.Drawing.Size(150, 20)
        Me.ctcod_editorial.TabIndex = 18
        Me.ctcod_editorial.Visible = False
        '
        'cbpais
        '
        Me.cbpais.FormattingEnabled = True
        Me.cbpais.Location = New System.Drawing.Point(357, 41)
        Me.cbpais.Name = "cbpais"
        Me.cbpais.Size = New System.Drawing.Size(122, 21)
        Me.cbpais.TabIndex = 19
        '
        'Editorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbpais)
        Me.Controls.Add(Me.ctcod_editorial)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ctnombre_editorial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Editorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Biblioteca - Editorial"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonNuevo As Button
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents ButtonBorrar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents ctnombre_editorial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ctcod_editorial As TextBox
    Friend WithEvents cbpais As ComboBox
End Class
