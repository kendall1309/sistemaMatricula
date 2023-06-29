<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblNombreUsuarioLogin = New System.Windows.Forms.Label()
        Me.LblContraseñaLogin = New System.Windows.Forms.Label()
        Me.TxtNombreUsuarioLogin = New System.Windows.Forms.TextBox()
        Me.TxtContraseñaLogin = New System.Windows.Forms.TextBox()
        Me.BtnIniciarSesion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblNombreUsuarioLogin
        '
        Me.LblNombreUsuarioLogin.AutoSize = True
        Me.LblNombreUsuarioLogin.BackColor = System.Drawing.SystemColors.Window
        Me.LblNombreUsuarioLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreUsuarioLogin.Location = New System.Drawing.Point(46, 86)
        Me.LblNombreUsuarioLogin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombreUsuarioLogin.Name = "LblNombreUsuarioLogin"
        Me.LblNombreUsuarioLogin.Size = New System.Drawing.Size(113, 13)
        Me.LblNombreUsuarioLogin.TabIndex = 0
        Me.LblNombreUsuarioLogin.Text = "Nombre de usuario"
        '
        'LblContraseñaLogin
        '
        Me.LblContraseñaLogin.AutoSize = True
        Me.LblContraseñaLogin.BackColor = System.Drawing.SystemColors.Window
        Me.LblContraseñaLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContraseñaLogin.Location = New System.Drawing.Point(46, 174)
        Me.LblContraseñaLogin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblContraseñaLogin.Name = "LblContraseñaLogin"
        Me.LblContraseñaLogin.Size = New System.Drawing.Size(71, 13)
        Me.LblContraseñaLogin.TabIndex = 1
        Me.LblContraseñaLogin.Text = "Contraseña"
        '
        'TxtNombreUsuarioLogin
        '
        Me.TxtNombreUsuarioLogin.Location = New System.Drawing.Point(220, 86)
        Me.TxtNombreUsuarioLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNombreUsuarioLogin.Name = "TxtNombreUsuarioLogin"
        Me.TxtNombreUsuarioLogin.Size = New System.Drawing.Size(138, 20)
        Me.TxtNombreUsuarioLogin.TabIndex = 2
        '
        'TxtContraseñaLogin
        '
        Me.TxtContraseñaLogin.Location = New System.Drawing.Point(220, 174)
        Me.TxtContraseñaLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtContraseñaLogin.Name = "TxtContraseñaLogin"
        Me.TxtContraseñaLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContraseñaLogin.Size = New System.Drawing.Size(138, 20)
        Me.TxtContraseñaLogin.TabIndex = 3
        '
        'BtnIniciarSesion
        '
        Me.BtnIniciarSesion.Location = New System.Drawing.Point(248, 228)
        Me.BtnIniciarSesion.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnIniciarSesion.Name = "BtnIniciarSesion"
        Me.BtnIniciarSesion.Size = New System.Drawing.Size(82, 32)
        Me.BtnIniciarSesion.TabIndex = 4
        Me.BtnIniciarSesion.Text = "Iniciar Sesion"
        Me.BtnIniciarSesion.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(427, 366)
        Me.Controls.Add(Me.BtnIniciarSesion)
        Me.Controls.Add(Me.TxtContraseñaLogin)
        Me.Controls.Add(Me.TxtNombreUsuarioLogin)
        Me.Controls.Add(Me.LblContraseñaLogin)
        Me.Controls.Add(Me.LblNombreUsuarioLogin)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNombreUsuarioLogin As Label
    Friend WithEvents LblContraseñaLogin As Label
    Friend WithEvents TxtNombreUsuarioLogin As TextBox
    Friend WithEvents TxtContraseñaLogin As TextBox
    Friend WithEvents BtnIniciarSesion As Button
End Class
