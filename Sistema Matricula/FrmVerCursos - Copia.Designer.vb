<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVerCursos
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
        Me.DGV_VerCursos = New System.Windows.Forms.DataGridView()
        Me.LBL_Nombre_de_Carrera_Ver_Curso = New System.Windows.Forms.Label()
        Me.TxtNombreCarreraVerCursos = New System.Windows.Forms.TextBox()
        Me.BtnBuscarVerCursos = New System.Windows.Forms.Button()
        Me.BtnRegresarVerCursos = New System.Windows.Forms.Button()
        CType(Me.DGV_VerCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_VerCursos
        '
        Me.DGV_VerCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_VerCursos.Location = New System.Drawing.Point(38, 127)
        Me.DGV_VerCursos.Name = "DGV_VerCursos"
        Me.DGV_VerCursos.Size = New System.Drawing.Size(458, 189)
        Me.DGV_VerCursos.TabIndex = 0
        '
        'LBL_Nombre_de_Carrera_Ver_Curso
        '
        Me.LBL_Nombre_de_Carrera_Ver_Curso.AutoSize = True
        Me.LBL_Nombre_de_Carrera_Ver_Curso.BackColor = System.Drawing.SystemColors.Window
        Me.LBL_Nombre_de_Carrera_Ver_Curso.Location = New System.Drawing.Point(35, 37)
        Me.LBL_Nombre_de_Carrera_Ver_Curso.Name = "LBL_Nombre_de_Carrera_Ver_Curso"
        Me.LBL_Nombre_de_Carrera_Ver_Curso.Size = New System.Drawing.Size(131, 13)
        Me.LBL_Nombre_de_Carrera_Ver_Curso.TabIndex = 1
        Me.LBL_Nombre_de_Carrera_Ver_Curso.Text = "Ingrese nombre de carrera"
        '
        'TxtNombreCarreraVerCursos
        '
        Me.TxtNombreCarreraVerCursos.Location = New System.Drawing.Point(38, 78)
        Me.TxtNombreCarreraVerCursos.Name = "TxtNombreCarreraVerCursos"
        Me.TxtNombreCarreraVerCursos.Size = New System.Drawing.Size(185, 20)
        Me.TxtNombreCarreraVerCursos.TabIndex = 2
        '
        'BtnBuscarVerCursos
        '
        Me.BtnBuscarVerCursos.Location = New System.Drawing.Point(47, 375)
        Me.BtnBuscarVerCursos.Name = "BtnBuscarVerCursos"
        Me.BtnBuscarVerCursos.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarVerCursos.TabIndex = 3
        Me.BtnBuscarVerCursos.Text = "Buscar"
        Me.BtnBuscarVerCursos.UseVisualStyleBackColor = True
        '
        'BtnRegresarVerCursos
        '
        Me.BtnRegresarVerCursos.Location = New System.Drawing.Point(421, 375)
        Me.BtnRegresarVerCursos.Name = "BtnRegresarVerCursos"
        Me.BtnRegresarVerCursos.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegresarVerCursos.TabIndex = 4
        Me.BtnRegresarVerCursos.Text = "Regresar"
        Me.BtnRegresarVerCursos.UseVisualStyleBackColor = True
        '
        'FrmVerCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(551, 450)
        Me.Controls.Add(Me.BtnRegresarVerCursos)
        Me.Controls.Add(Me.BtnBuscarVerCursos)
        Me.Controls.Add(Me.TxtNombreCarreraVerCursos)
        Me.Controls.Add(Me.LBL_Nombre_de_Carrera_Ver_Curso)
        Me.Controls.Add(Me.DGV_VerCursos)
        Me.Name = "FrmVerCursos"
        Me.Text = "Ver  Cursos"
        CType(Me.DGV_VerCursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_VerCursos As DataGridView
    Friend WithEvents LBL_Nombre_de_Carrera_Ver_Curso As Label
    Friend WithEvents TxtNombreCarreraVerCursos As TextBox
    Friend WithEvents BtnBuscarVerCursos As Button
    Friend WithEvents BtnRegresarVerCursos As Button
End Class
