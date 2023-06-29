<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarEstudiantes
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
        Me.LblNombreEstudiante = New System.Windows.Forms.Label()
        Me.LBLCorreoElecEstudiante = New System.Windows.Forms.Label()
        Me.LBL_Fecha_Nacimiento = New System.Windows.Forms.Label()
        Me.LblIdentificacionEstudiante = New System.Windows.Forms.Label()
        Me.LblApellidosEstudiante = New System.Windows.Forms.Label()
        Me.LblDireccionEstudiante = New System.Windows.Forms.Label()
        Me.LblCarerrasMatriculadasEstudiante = New System.Windows.Forms.Label()
        Me.LBlTelefonoEstudiante = New System.Windows.Forms.Label()
        Me.LblPoseeBecaEstudiante = New System.Windows.Forms.Label()
        Me.TxtNombreEstudiante = New System.Windows.Forms.TextBox()
        Me.TxtCorreoEstudiante = New System.Windows.Forms.TextBox()
        Me.TxTIdentificacionEstudiante = New System.Windows.Forms.TextBox()
        Me.TxtTelefonoEstudiante = New System.Windows.Forms.TextBox()
        Me.TxtApellidosEstudiante = New System.Windows.Forms.TextBox()
        Me.TxTDireccionExactaEstudiante = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.CcLBCarrerasMatriculadasEstudiante = New System.Windows.Forms.CheckedListBox()
        Me.CCB_poseeBeca = New System.Windows.Forms.CheckedListBox()
        Me.DtP_FechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.CLB_PorcentajeBecaEstudiantes = New System.Windows.Forms.CheckedListBox()
        Me.LblPoseBrcaEstudiante = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'LblNombreEstudiante
        '
        Me.LblNombreEstudiante.AutoSize = True
        Me.LblNombreEstudiante.BackColor = System.Drawing.SystemColors.Window
        Me.LblNombreEstudiante.Location = New System.Drawing.Point(37, 19)
        Me.LblNombreEstudiante.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombreEstudiante.Name = "LblNombreEstudiante"
        Me.LblNombreEstudiante.Size = New System.Drawing.Size(44, 13)
        Me.LblNombreEstudiante.TabIndex = 0
        Me.LblNombreEstudiante.Text = "Nombre"
        '
        'LBLCorreoElecEstudiante
        '
        Me.LBLCorreoElecEstudiante.AutoSize = True
        Me.LBLCorreoElecEstudiante.BackColor = System.Drawing.SystemColors.Window
        Me.LBLCorreoElecEstudiante.Location = New System.Drawing.Point(37, 246)
        Me.LBLCorreoElecEstudiante.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBLCorreoElecEstudiante.Name = "LBLCorreoElecEstudiante"
        Me.LBLCorreoElecEstudiante.Size = New System.Drawing.Size(94, 13)
        Me.LBLCorreoElecEstudiante.TabIndex = 1
        Me.LBLCorreoElecEstudiante.Text = "Correo Electronico"
        '
        'LBL_Fecha_Nacimiento
        '
        Me.LBL_Fecha_Nacimiento.AutoSize = True
        Me.LBL_Fecha_Nacimiento.BackColor = System.Drawing.SystemColors.Window
        Me.LBL_Fecha_Nacimiento.Location = New System.Drawing.Point(302, 200)
        Me.LBL_Fecha_Nacimiento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_Fecha_Nacimiento.Name = "LBL_Fecha_Nacimiento"
        Me.LBL_Fecha_Nacimiento.Size = New System.Drawing.Size(93, 13)
        Me.LBL_Fecha_Nacimiento.TabIndex = 2
        Me.LBL_Fecha_Nacimiento.Text = "Fecha Nacimiento"
        '
        'LblIdentificacionEstudiante
        '
        Me.LblIdentificacionEstudiante.AutoSize = True
        Me.LblIdentificacionEstudiante.BackColor = System.Drawing.SystemColors.Window
        Me.LblIdentificacionEstudiante.Location = New System.Drawing.Point(32, 136)
        Me.LblIdentificacionEstudiante.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblIdentificacionEstudiante.Name = "LblIdentificacionEstudiante"
        Me.LblIdentificacionEstudiante.Size = New System.Drawing.Size(70, 13)
        Me.LblIdentificacionEstudiante.TabIndex = 3
        Me.LblIdentificacionEstudiante.Text = "Identificacion"
        '
        'LblApellidosEstudiante
        '
        Me.LblApellidosEstudiante.AutoSize = True
        Me.LblApellidosEstudiante.BackColor = System.Drawing.SystemColors.Window
        Me.LblApellidosEstudiante.Location = New System.Drawing.Point(37, 72)
        Me.LblApellidosEstudiante.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblApellidosEstudiante.Name = "LblApellidosEstudiante"
        Me.LblApellidosEstudiante.Size = New System.Drawing.Size(49, 13)
        Me.LblApellidosEstudiante.TabIndex = 4
        Me.LblApellidosEstudiante.Text = "Apellidos"
        '
        'LblDireccionEstudiante
        '
        Me.LblDireccionEstudiante.AutoSize = True
        Me.LblDireccionEstudiante.BackColor = System.Drawing.SystemColors.Window
        Me.LblDireccionEstudiante.Location = New System.Drawing.Point(302, 274)
        Me.LblDireccionEstudiante.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDireccionEstudiante.Name = "LblDireccionEstudiante"
        Me.LblDireccionEstudiante.Size = New System.Drawing.Size(52, 13)
        Me.LblDireccionEstudiante.TabIndex = 5
        Me.LblDireccionEstudiante.Text = "Direccion"
        '
        'LblCarerrasMatriculadasEstudiante
        '
        Me.LblCarerrasMatriculadasEstudiante.AutoSize = True
        Me.LblCarerrasMatriculadasEstudiante.BackColor = System.Drawing.SystemColors.Window
        Me.LblCarerrasMatriculadasEstudiante.Location = New System.Drawing.Point(37, 302)
        Me.LblCarerrasMatriculadasEstudiante.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCarerrasMatriculadasEstudiante.Name = "LblCarerrasMatriculadasEstudiante"
        Me.LblCarerrasMatriculadasEstudiante.Size = New System.Drawing.Size(108, 13)
        Me.LblCarerrasMatriculadasEstudiante.TabIndex = 6
        Me.LblCarerrasMatriculadasEstudiante.Text = "Carreras matriculadas"
        '
        'LBlTelefonoEstudiante
        '
        Me.LBlTelefonoEstudiante.AutoSize = True
        Me.LBlTelefonoEstudiante.BackColor = System.Drawing.SystemColors.Window
        Me.LBlTelefonoEstudiante.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBlTelefonoEstudiante.Location = New System.Drawing.Point(37, 190)
        Me.LBlTelefonoEstudiante.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBlTelefonoEstudiante.Name = "LBlTelefonoEstudiante"
        Me.LBlTelefonoEstudiante.Size = New System.Drawing.Size(49, 13)
        Me.LBlTelefonoEstudiante.TabIndex = 7
        Me.LBlTelefonoEstudiante.Text = "Telefono"
        '
        'LblPoseeBecaEstudiante
        '
        Me.LblPoseeBecaEstudiante.AutoSize = True
        Me.LblPoseeBecaEstudiante.BackColor = System.Drawing.SystemColors.Window
        Me.LblPoseeBecaEstudiante.Location = New System.Drawing.Point(302, 19)
        Me.LblPoseeBecaEstudiante.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPoseeBecaEstudiante.Name = "LblPoseeBecaEstudiante"
        Me.LblPoseeBecaEstudiante.Size = New System.Drawing.Size(64, 13)
        Me.LblPoseeBecaEstudiante.TabIndex = 8
        Me.LblPoseeBecaEstudiante.Text = "Posee beca"
        '
        'TxtNombreEstudiante
        '
        Me.TxtNombreEstudiante.Location = New System.Drawing.Point(34, 42)
        Me.TxtNombreEstudiante.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNombreEstudiante.Name = "TxtNombreEstudiante"
        Me.TxtNombreEstudiante.Size = New System.Drawing.Size(76, 20)
        Me.TxtNombreEstudiante.TabIndex = 9
        '
        'TxtCorreoEstudiante
        '
        Me.TxtCorreoEstudiante.Location = New System.Drawing.Point(34, 274)
        Me.TxtCorreoEstudiante.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCorreoEstudiante.Name = "TxtCorreoEstudiante"
        Me.TxtCorreoEstudiante.Size = New System.Drawing.Size(124, 20)
        Me.TxtCorreoEstudiante.TabIndex = 10
        '
        'TxTIdentificacionEstudiante
        '
        Me.TxTIdentificacionEstudiante.Location = New System.Drawing.Point(34, 161)
        Me.TxTIdentificacionEstudiante.Margin = New System.Windows.Forms.Padding(2)
        Me.TxTIdentificacionEstudiante.Name = "TxTIdentificacionEstudiante"
        Me.TxTIdentificacionEstudiante.Size = New System.Drawing.Size(90, 20)
        Me.TxTIdentificacionEstudiante.TabIndex = 15
        '
        'TxtTelefonoEstudiante
        '
        Me.TxtTelefonoEstudiante.Location = New System.Drawing.Point(34, 214)
        Me.TxtTelefonoEstudiante.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTelefonoEstudiante.Name = "TxtTelefonoEstudiante"
        Me.TxtTelefonoEstudiante.Size = New System.Drawing.Size(76, 20)
        Me.TxtTelefonoEstudiante.TabIndex = 16
        '
        'TxtApellidosEstudiante
        '
        Me.TxtApellidosEstudiante.Location = New System.Drawing.Point(34, 99)
        Me.TxtApellidosEstudiante.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtApellidosEstudiante.Name = "TxtApellidosEstudiante"
        Me.TxtApellidosEstudiante.Size = New System.Drawing.Size(85, 20)
        Me.TxtApellidosEstudiante.TabIndex = 17
        '
        'TxTDireccionExactaEstudiante
        '
        Me.TxTDireccionExactaEstudiante.Location = New System.Drawing.Point(305, 299)
        Me.TxTDireccionExactaEstudiante.Margin = New System.Windows.Forms.Padding(2)
        Me.TxTDireccionExactaEstudiante.Multiline = True
        Me.TxTDireccionExactaEstudiante.Name = "TxTDireccionExactaEstudiante"
        Me.TxTDireccionExactaEstudiante.Size = New System.Drawing.Size(246, 49)
        Me.TxTDireccionExactaEstudiante.TabIndex = 19
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(284, 364)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(82, 32)
        Me.btnAgregar.TabIndex = 20
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(370, 364)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(82, 32)
        Me.btnModificar.TabIndex = 21
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'CcLBCarrerasMatriculadasEstudiante
        '
        Me.CcLBCarrerasMatriculadasEstudiante.FormattingEnabled = True
        Me.CcLBCarrerasMatriculadasEstudiante.Items.AddRange(New Object() {"Tecnologias de la informacion", "Enfermeria", "Medicinageneral", "Admistracionde empresas ", "Derecho"})
        Me.CcLBCarrerasMatriculadasEstudiante.Location = New System.Drawing.Point(34, 327)
        Me.CcLBCarrerasMatriculadasEstudiante.Margin = New System.Windows.Forms.Padding(2)
        Me.CcLBCarrerasMatriculadasEstudiante.Name = "CcLBCarrerasMatriculadasEstudiante"
        Me.CcLBCarrerasMatriculadasEstudiante.Size = New System.Drawing.Size(167, 79)
        Me.CcLBCarrerasMatriculadasEstudiante.TabIndex = 22
        '
        'CCB_poseeBeca
        '
        Me.CCB_poseeBeca.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CCB_poseeBeca.FormattingEnabled = True
        Me.CCB_poseeBeca.Items.AddRange(New Object() {"Si", "No"})
        Me.CCB_poseeBeca.Location = New System.Drawing.Point(305, 51)
        Me.CCB_poseeBeca.Margin = New System.Windows.Forms.Padding(2)
        Me.CCB_poseeBeca.Name = "CCB_poseeBeca"
        Me.CCB_poseeBeca.Size = New System.Drawing.Size(105, 34)
        Me.CCB_poseeBeca.TabIndex = 23
        '
        'DtP_FechaNacimiento
        '
        Me.DtP_FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtP_FechaNacimiento.Location = New System.Drawing.Point(305, 230)
        Me.DtP_FechaNacimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.DtP_FechaNacimiento.Name = "DtP_FechaNacimiento"
        Me.DtP_FechaNacimiento.Size = New System.Drawing.Size(97, 20)
        Me.DtP_FechaNacimiento.TabIndex = 24
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(458, 364)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(82, 32)
        Me.btnEliminar.TabIndex = 25
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'CLB_PorcentajeBecaEstudiantes
        '
        Me.CLB_PorcentajeBecaEstudiantes.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CLB_PorcentajeBecaEstudiantes.FormattingEnabled = True
        Me.CLB_PorcentajeBecaEstudiantes.Items.AddRange(New Object() {"0%", "30%", "50%", "60%"})
        Me.CLB_PorcentajeBecaEstudiantes.Location = New System.Drawing.Point(305, 117)
        Me.CLB_PorcentajeBecaEstudiantes.Margin = New System.Windows.Forms.Padding(2)
        Me.CLB_PorcentajeBecaEstudiantes.Name = "CLB_PorcentajeBecaEstudiantes"
        Me.CLB_PorcentajeBecaEstudiantes.Size = New System.Drawing.Size(139, 64)
        Me.CLB_PorcentajeBecaEstudiantes.TabIndex = 26
        '
        'LblPoseBrcaEstudiante
        '
        Me.LblPoseBrcaEstudiante.AutoSize = True
        Me.LblPoseBrcaEstudiante.BackColor = System.Drawing.SystemColors.Window
        Me.LblPoseBrcaEstudiante.Location = New System.Drawing.Point(302, 99)
        Me.LblPoseBrcaEstudiante.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPoseBrcaEstudiante.Name = "LblPoseBrcaEstudiante"
        Me.LblPoseBrcaEstudiante.Size = New System.Drawing.Size(100, 13)
        Me.LblPoseBrcaEstudiante.TabIndex = 27
        Me.LblPoseBrcaEstudiante.Text = "Porcentaje de beca"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(472, 51)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 28
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(472, 70)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 29
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(472, 93)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton3.TabIndex = 30
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'FrmRegistrarEstudiantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(558, 436)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.LblPoseBrcaEstudiante)
        Me.Controls.Add(Me.CLB_PorcentajeBecaEstudiantes)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.DtP_FechaNacimiento)
        Me.Controls.Add(Me.CCB_poseeBeca)
        Me.Controls.Add(Me.CcLBCarrerasMatriculadasEstudiante)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.TxTDireccionExactaEstudiante)
        Me.Controls.Add(Me.TxtApellidosEstudiante)
        Me.Controls.Add(Me.TxtTelefonoEstudiante)
        Me.Controls.Add(Me.TxTIdentificacionEstudiante)
        Me.Controls.Add(Me.TxtCorreoEstudiante)
        Me.Controls.Add(Me.TxtNombreEstudiante)
        Me.Controls.Add(Me.LblPoseeBecaEstudiante)
        Me.Controls.Add(Me.LBlTelefonoEstudiante)
        Me.Controls.Add(Me.LblCarerrasMatriculadasEstudiante)
        Me.Controls.Add(Me.LblDireccionEstudiante)
        Me.Controls.Add(Me.LblApellidosEstudiante)
        Me.Controls.Add(Me.LblIdentificacionEstudiante)
        Me.Controls.Add(Me.LBL_Fecha_Nacimiento)
        Me.Controls.Add(Me.LBLCorreoElecEstudiante)
        Me.Controls.Add(Me.LblNombreEstudiante)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmRegistrarEstudiantes"
        Me.Text = "Registrar Estudiantes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNombreEstudiante As Label
    Friend WithEvents LBLCorreoElecEstudiante As Label
    Friend WithEvents LBL_Fecha_Nacimiento As Label
    Friend WithEvents LblIdentificacionEstudiante As Label
    Friend WithEvents LblApellidosEstudiante As Label
    Friend WithEvents LblDireccionEstudiante As Label
    Friend WithEvents LblCarerrasMatriculadasEstudiante As Label
    Friend WithEvents LBlTelefonoEstudiante As Label
    Friend WithEvents LblPoseeBecaEstudiante As Label
    Friend WithEvents TxtNombreEstudiante As TextBox
    Friend WithEvents TxtCorreoEstudiante As TextBox
    Friend WithEvents TxTIdentificacionEstudiante As TextBox
    Friend WithEvents TxtTelefonoEstudiante As TextBox
    Friend WithEvents TxtApellidosEstudiante As TextBox
    Friend WithEvents TxTDireccionExactaEstudiante As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents CcLBCarrerasMatriculadasEstudiante As CheckedListBox
    Friend WithEvents CCB_poseeBeca As CheckedListBox
    Friend WithEvents DtP_FechaNacimiento As DateTimePicker
    Friend WithEvents btnEliminar As Button
    Friend WithEvents CLB_PorcentajeBecaEstudiantes As CheckedListBox
    Friend WithEvents LblPoseBrcaEstudiante As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
End Class
