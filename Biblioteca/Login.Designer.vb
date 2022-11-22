<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ctusuario = New System.Windows.Forms.TextBox()
        Me.ctclave = New System.Windows.Forms.TextBox()
        Me.ButtonIngresar = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.ButtonConsultar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Clave"
        '
        'ctusuario
        '
        Me.ctusuario.Location = New System.Drawing.Point(162, 114)
        Me.ctusuario.Name = "ctusuario"
        Me.ctusuario.Size = New System.Drawing.Size(150, 20)
        Me.ctusuario.TabIndex = 16
        '
        'ctclave
        '
        Me.ctclave.Location = New System.Drawing.Point(162, 184)
        Me.ctclave.Name = "ctclave"
        Me.ctclave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ctclave.Size = New System.Drawing.Size(150, 20)
        Me.ctclave.TabIndex = 17
        '
        'ButtonIngresar
        '
        Me.ButtonIngresar.Location = New System.Drawing.Point(80, 270)
        Me.ButtonIngresar.Name = "ButtonIngresar"
        Me.ButtonIngresar.Size = New System.Drawing.Size(120, 30)
        Me.ButtonIngresar.TabIndex = 18
        Me.ButtonIngresar.Text = "Ingresar"
        Me.ButtonIngresar.UseVisualStyleBackColor = True
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Location = New System.Drawing.Point(227, 270)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(120, 30)
        Me.ButtonCancelar.TabIndex = 19
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'ButtonConsultar
        '
        Me.ButtonConsultar.Location = New System.Drawing.Point(321, 363)
        Me.ButtonConsultar.Name = "ButtonConsultar"
        Me.ButtonConsultar.Size = New System.Drawing.Size(120, 43)
        Me.ButtonConsultar.TabIndex = 20
        Me.ButtonConsultar.Text = "Consultar Libro"
        Me.ButtonConsultar.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 450)
        Me.Controls.Add(Me.ButtonConsultar)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonIngresar)
        Me.Controls.Add(Me.ctclave)
        Me.Controls.Add(Me.ctusuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ctusuario As TextBox
    Friend WithEvents ctclave As TextBox
    Friend WithEvents ButtonIngresar As Button
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents ButtonConsultar As Button
End Class
