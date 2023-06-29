<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPantall_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstudiantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarrerasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarCursosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerCursosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarToolStripMenuItem, Me.CarrerasToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.AcercaDeToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuPrincipal.Size = New System.Drawing.Size(504, 24)
        Me.MenuPrincipal.TabIndex = 0
        Me.MenuPrincipal.Text = "Menu Principal"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FuncionarioToolStripMenuItem, Me.EstudiantesToolStripMenuItem})
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.RegistrarToolStripMenuItem.Text = "Registrar"
        '
        'FuncionarioToolStripMenuItem
        '
        Me.FuncionarioToolStripMenuItem.Name = "FuncionarioToolStripMenuItem"
        Me.FuncionarioToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.FuncionarioToolStripMenuItem.Text = "Funcionario"
        '
        'EstudiantesToolStripMenuItem
        '
        Me.EstudiantesToolStripMenuItem.Name = "EstudiantesToolStripMenuItem"
        Me.EstudiantesToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.EstudiantesToolStripMenuItem.Text = "Estudiantes"
        '
        'CarrerasToolStripMenuItem
        '
        Me.CarrerasToolStripMenuItem.Name = "CarrerasToolStripMenuItem"
        Me.CarrerasToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CarrerasToolStripMenuItem.Text = "Carreras"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarCursosToolStripMenuItem, Me.VerCursosToolStripMenuItem})
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Cursos"
        '
        'AcercaDeToolStripMenuItem1
        '
        Me.AcercaDeToolStripMenuItem1.Name = "AcercaDeToolStripMenuItem1"
        Me.AcercaDeToolStripMenuItem1.Size = New System.Drawing.Size(71, 20)
        Me.AcercaDeToolStripMenuItem1.Text = "Acerca de"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AgregarCursosToolStripMenuItem
        '
        Me.AgregarCursosToolStripMenuItem.Name = "AgregarCursosToolStripMenuItem"
        Me.AgregarCursosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AgregarCursosToolStripMenuItem.Text = "Agregar cursos"
        '
        'VerCursosToolStripMenuItem
        '
        Me.VerCursosToolStripMenuItem.Name = "VerCursosToolStripMenuItem"
        Me.VerCursosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VerCursosToolStripMenuItem.Text = "ver cursos"
        '
        'FrmPantall_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(504, 366)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuPrincipal
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmPantall_Principal"
        Me.Text = "FrmPantall_Principal"
        Me.MenuPrincipal.ResumeLayout(False)
        Me.MenuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuPrincipal As MenuStrip
    Friend WithEvents RegistrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstudiantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarrerasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarCursosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerCursosToolStripMenuItem As ToolStripMenuItem
End Class
