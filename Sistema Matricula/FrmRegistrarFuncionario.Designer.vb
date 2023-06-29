<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarFuncionario
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
        Me.LblNombreFuncionario = New System.Windows.Forms.Label()
        Me.LblEstadoFuncionario = New System.Windows.Forms.Label()
        Me.LblClaveFuncionario = New System.Windows.Forms.Label()
        Me.LblUsuariofuncionario = New System.Windows.Forms.Label()
        Me.LblSegundoApellidoFuncionario = New System.Windows.Forms.Label()
        Me.LblPrimerApellidoFuncionario = New System.Windows.Forms.Label()
        Me.LblIdentificacionFuncionario = New System.Windows.Forms.Label()
        Me.txtIdentificacionUsuario = New System.Windows.Forms.TextBox()
        Me.TxtClavefuncionario = New System.Windows.Forms.TextBox()
        Me.TxtUsuarioFuncionario = New System.Windows.Forms.TextBox()
        Me.txtSegundoApellidoUsuario = New System.Windows.Forms.TextBox()
        Me.TxtPrimerApellidoUsuario = New System.Windows.Forms.TextBox()
        Me.TxtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.CcbActivoFuncionario = New System.Windows.Forms.CheckedListBox()
        Me.BtnRegistrarFuncionario = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificarFuncionario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblNombreFuncionario
        '
        Me.LblNombreFuncionario.AutoSize = True
        Me.LblNombreFuncionario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LblNombreFuncionario.Location = New System.Drawing.Point(20, 60)
        Me.LblNombreFuncionario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombreFuncionario.Name = "LblNombreFuncionario"
        Me.LblNombreFuncionario.Size = New System.Drawing.Size(44, 13)
        Me.LblNombreFuncionario.TabIndex = 0
        Me.LblNombreFuncionario.Text = "Nombre"
        '
        'LblEstadoFuncionario
        '
        Me.LblEstadoFuncionario.AutoSize = True
        Me.LblEstadoFuncionario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LblEstadoFuncionario.Location = New System.Drawing.Point(20, 341)
        Me.LblEstadoFuncionario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblEstadoFuncionario.Name = "LblEstadoFuncionario"
        Me.LblEstadoFuncionario.Size = New System.Drawing.Size(40, 13)
        Me.LblEstadoFuncionario.TabIndex = 1
        Me.LblEstadoFuncionario.Text = "Estado"
        '
        'LblClaveFuncionario
        '
        Me.LblClaveFuncionario.AutoSize = True
        Me.LblClaveFuncionario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LblClaveFuncionario.Location = New System.Drawing.Point(20, 284)
        Me.LblClaveFuncionario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblClaveFuncionario.Name = "LblClaveFuncionario"
        Me.LblClaveFuncionario.Size = New System.Drawing.Size(34, 13)
        Me.LblClaveFuncionario.TabIndex = 2
        Me.LblClaveFuncionario.Text = "Clave"
        '
        'LblUsuariofuncionario
        '
        Me.LblUsuariofuncionario.AutoSize = True
        Me.LblUsuariofuncionario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LblUsuariofuncionario.Location = New System.Drawing.Point(21, 215)
        Me.LblUsuariofuncionario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblUsuariofuncionario.Name = "LblUsuariofuncionario"
        Me.LblUsuariofuncionario.Size = New System.Drawing.Size(43, 13)
        Me.LblUsuariofuncionario.TabIndex = 3
        Me.LblUsuariofuncionario.Text = "Usuario"
        '
        'LblSegundoApellidoFuncionario
        '
        Me.LblSegundoApellidoFuncionario.AutoSize = True
        Me.LblSegundoApellidoFuncionario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LblSegundoApellidoFuncionario.Location = New System.Drawing.Point(20, 160)
        Me.LblSegundoApellidoFuncionario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSegundoApellidoFuncionario.Name = "LblSegundoApellidoFuncionario"
        Me.LblSegundoApellidoFuncionario.Size = New System.Drawing.Size(90, 13)
        Me.LblSegundoApellidoFuncionario.TabIndex = 4
        Me.LblSegundoApellidoFuncionario.Text = "Segundo Apellido"
        '
        'LblPrimerApellidoFuncionario
        '
        Me.LblPrimerApellidoFuncionario.AutoSize = True
        Me.LblPrimerApellidoFuncionario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LblPrimerApellidoFuncionario.Location = New System.Drawing.Point(20, 112)
        Me.LblPrimerApellidoFuncionario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPrimerApellidoFuncionario.Name = "LblPrimerApellidoFuncionario"
        Me.LblPrimerApellidoFuncionario.Size = New System.Drawing.Size(76, 13)
        Me.LblPrimerApellidoFuncionario.TabIndex = 5
        Me.LblPrimerApellidoFuncionario.Text = "Primer Apellido"
        '
        'LblIdentificacionFuncionario
        '
        Me.LblIdentificacionFuncionario.AutoSize = True
        Me.LblIdentificacionFuncionario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LblIdentificacionFuncionario.Location = New System.Drawing.Point(20, 20)
        Me.LblIdentificacionFuncionario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblIdentificacionFuncionario.Name = "LblIdentificacionFuncionario"
        Me.LblIdentificacionFuncionario.Size = New System.Drawing.Size(70, 13)
        Me.LblIdentificacionFuncionario.TabIndex = 6
        Me.LblIdentificacionFuncionario.Text = "Identificacion"
        '
        'txtIdentificacionUsuario
        '
        Me.txtIdentificacionUsuario.Location = New System.Drawing.Point(231, 17)
        Me.txtIdentificacionUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdentificacionUsuario.Name = "txtIdentificacionUsuario"
        Me.txtIdentificacionUsuario.Size = New System.Drawing.Size(110, 20)
        Me.txtIdentificacionUsuario.TabIndex = 7
        '
        'TxtClavefuncionario
        '
        Me.TxtClavefuncionario.Location = New System.Drawing.Point(231, 284)
        Me.TxtClavefuncionario.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtClavefuncionario.Name = "TxtClavefuncionario"
        Me.TxtClavefuncionario.Size = New System.Drawing.Size(110, 20)
        Me.TxtClavefuncionario.TabIndex = 8
        '
        'TxtUsuarioFuncionario
        '
        Me.TxtUsuarioFuncionario.Location = New System.Drawing.Point(231, 215)
        Me.TxtUsuarioFuncionario.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtUsuarioFuncionario.Name = "TxtUsuarioFuncionario"
        Me.TxtUsuarioFuncionario.Size = New System.Drawing.Size(110, 20)
        Me.TxtUsuarioFuncionario.TabIndex = 9
        '
        'txtSegundoApellidoUsuario
        '
        Me.txtSegundoApellidoUsuario.Location = New System.Drawing.Point(231, 160)
        Me.txtSegundoApellidoUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSegundoApellidoUsuario.Name = "txtSegundoApellidoUsuario"
        Me.txtSegundoApellidoUsuario.Size = New System.Drawing.Size(110, 20)
        Me.txtSegundoApellidoUsuario.TabIndex = 10
        '
        'TxtPrimerApellidoUsuario
        '
        Me.TxtPrimerApellidoUsuario.Location = New System.Drawing.Point(231, 112)
        Me.TxtPrimerApellidoUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPrimerApellidoUsuario.Name = "TxtPrimerApellidoUsuario"
        Me.TxtPrimerApellidoUsuario.Size = New System.Drawing.Size(110, 20)
        Me.TxtPrimerApellidoUsuario.TabIndex = 11
        '
        'TxtNombreUsuario
        '
        Me.TxtNombreUsuario.Location = New System.Drawing.Point(231, 60)
        Me.TxtNombreUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNombreUsuario.Name = "TxtNombreUsuario"
        Me.TxtNombreUsuario.Size = New System.Drawing.Size(110, 20)
        Me.TxtNombreUsuario.TabIndex = 12
        '
        'CcbActivoFuncionario
        '
        Me.CcbActivoFuncionario.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CcbActivoFuncionario.FormattingEnabled = True
        Me.CcbActivoFuncionario.Items.AddRange(New Object() {"   Activo", "   Inactivo"})
        Me.CcbActivoFuncionario.Location = New System.Drawing.Point(231, 341)
        Me.CcbActivoFuncionario.Margin = New System.Windows.Forms.Padding(2)
        Me.CcbActivoFuncionario.Name = "CcbActivoFuncionario"
        Me.CcbActivoFuncionario.Size = New System.Drawing.Size(110, 34)
        Me.CcbActivoFuncionario.TabIndex = 13
        '
        'BtnRegistrarFuncionario
        '
        Me.BtnRegistrarFuncionario.Location = New System.Drawing.Point(34, 401)
        Me.BtnRegistrarFuncionario.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRegistrarFuncionario.Name = "BtnRegistrarFuncionario"
        Me.BtnRegistrarFuncionario.Size = New System.Drawing.Size(62, 30)
        Me.BtnRegistrarFuncionario.TabIndex = 14
        Me.BtnRegistrarFuncionario.Text = "Registrar"
        Me.BtnRegistrarFuncionario.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(407, 401)
        Me.BtnRegresar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(62, 30)
        Me.BtnRegresar.TabIndex = 15
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(179, 401)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(62, 30)
        Me.BtnEliminar.TabIndex = 16
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificarFuncionario
        '
        Me.BtnModificarFuncionario.Location = New System.Drawing.Point(305, 401)
        Me.BtnModificarFuncionario.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnModificarFuncionario.Name = "BtnModificarFuncionario"
        Me.BtnModificarFuncionario.Size = New System.Drawing.Size(62, 30)
        Me.BtnModificarFuncionario.TabIndex = 17
        Me.BtnModificarFuncionario.Text = "Modificar"
        Me.BtnModificarFuncionario.UseVisualStyleBackColor = True
        '
        'FrmRegistrarFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(494, 459)
        Me.Controls.Add(Me.BtnModificarFuncionario)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnRegistrarFuncionario)
        Me.Controls.Add(Me.CcbActivoFuncionario)
        Me.Controls.Add(Me.TxtNombreUsuario)
        Me.Controls.Add(Me.TxtPrimerApellidoUsuario)
        Me.Controls.Add(Me.txtSegundoApellidoUsuario)
        Me.Controls.Add(Me.TxtUsuarioFuncionario)
        Me.Controls.Add(Me.TxtClavefuncionario)
        Me.Controls.Add(Me.txtIdentificacionUsuario)
        Me.Controls.Add(Me.LblIdentificacionFuncionario)
        Me.Controls.Add(Me.LblPrimerApellidoFuncionario)
        Me.Controls.Add(Me.LblSegundoApellidoFuncionario)
        Me.Controls.Add(Me.LblUsuariofuncionario)
        Me.Controls.Add(Me.LblClaveFuncionario)
        Me.Controls.Add(Me.LblEstadoFuncionario)
        Me.Controls.Add(Me.LblNombreFuncionario)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmRegistrarFuncionario"
        Me.Text = "Registrar funcionario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNombreFuncionario As Label
    Friend WithEvents LblEstadoFuncionario As Label
    Friend WithEvents LblClaveFuncionario As Label
    Friend WithEvents LblUsuariofuncionario As Label
    Friend WithEvents LblSegundoApellidoFuncionario As Label
    Friend WithEvents LblPrimerApellidoFuncionario As Label
    Friend WithEvents LblIdentificacionFuncionario As Label
    Friend WithEvents txtIdentificacionUsuario As TextBox
    Friend WithEvents TxtClavefuncionario As TextBox
    Friend WithEvents TxtUsuarioFuncionario As TextBox
    Friend WithEvents txtSegundoApellidoUsuario As TextBox
    Friend WithEvents TxtPrimerApellidoUsuario As TextBox
    Friend WithEvents TxtNombreUsuario As TextBox
    Friend WithEvents CcbActivoFuncionario As CheckedListBox
    Friend WithEvents BtnRegistrarFuncionario As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificarFuncionario As Button
End Class
