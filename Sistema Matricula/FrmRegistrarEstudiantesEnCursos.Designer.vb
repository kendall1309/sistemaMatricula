<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarEstudiantesEnCursos
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
        Me.LblIngresarDatoIdentificacion = New System.Windows.Forms.Label()
        Me.Txt_Id_RegistrarEst_Carreras = New System.Windows.Forms.TextBox()
        Me.CLB_Selccione_carrera_RegistarEstuCursos = New System.Windows.Forms.CheckedListBox()
        Me.LblIngresarDatoCarrera = New System.Windows.Forms.Label()
        Me.CLB_CursosDeCarrera = New System.Windows.Forms.CheckedListBox()
        Me.LblIngresarCursosdeCarrera = New System.Windows.Forms.Label()
        Me.BtnRegistrarCarreras = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.LblIngreseFecha = New System.Windows.Forms.Label()
        Me.DTP_FechaRegistrarCursos = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'LblIngresarDatoIdentificacion
        '
        Me.LblIngresarDatoIdentificacion.AutoSize = True
        Me.LblIngresarDatoIdentificacion.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblIngresarDatoIdentificacion.Location = New System.Drawing.Point(12, 27)
        Me.LblIngresarDatoIdentificacion.Name = "LblIngresarDatoIdentificacion"
        Me.LblIngresarDatoIdentificacion.Size = New System.Drawing.Size(161, 13)
        Me.LblIngresarDatoIdentificacion.TabIndex = 0
        Me.LblIngresarDatoIdentificacion.Text = "Ingrese numero de Identificacion"
        '
        'Txt_Id_RegistrarEst_Carreras
        '
        Me.Txt_Id_RegistrarEst_Carreras.Location = New System.Drawing.Point(12, 78)
        Me.Txt_Id_RegistrarEst_Carreras.Name = "Txt_Id_RegistrarEst_Carreras"
        Me.Txt_Id_RegistrarEst_Carreras.Size = New System.Drawing.Size(158, 20)
        Me.Txt_Id_RegistrarEst_Carreras.TabIndex = 1
        '
        'CLB_Selccione_carrera_RegistarEstuCursos
        '
        Me.CLB_Selccione_carrera_RegistarEstuCursos.FormattingEnabled = True
        Me.CLB_Selccione_carrera_RegistarEstuCursos.Items.AddRange(New Object() {"Tecnologias de la informacion", "Enfermeria", "Medicinageneral", "Admistracionde empresas ", "Derecho"})
        Me.CLB_Selccione_carrera_RegistarEstuCursos.Location = New System.Drawing.Point(12, 151)
        Me.CLB_Selccione_carrera_RegistarEstuCursos.Name = "CLB_Selccione_carrera_RegistarEstuCursos"
        Me.CLB_Selccione_carrera_RegistarEstuCursos.Size = New System.Drawing.Size(158, 94)
        Me.CLB_Selccione_carrera_RegistarEstuCursos.TabIndex = 2
        '
        'LblIngresarDatoCarrera
        '
        Me.LblIngresarDatoCarrera.AutoSize = True
        Me.LblIngresarDatoCarrera.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblIngresarDatoCarrera.Location = New System.Drawing.Point(9, 116)
        Me.LblIngresarDatoCarrera.Name = "LblIngresarDatoCarrera"
        Me.LblIngresarDatoCarrera.Size = New System.Drawing.Size(89, 13)
        Me.LblIngresarDatoCarrera.TabIndex = 3
        Me.LblIngresarDatoCarrera.Text = "Ingrese la carrera"
        '
        'CLB_CursosDeCarrera
        '
        Me.CLB_CursosDeCarrera.FormattingEnabled = True
        Me.CLB_CursosDeCarrera.Location = New System.Drawing.Point(256, 151)
        Me.CLB_CursosDeCarrera.Name = "CLB_CursosDeCarrera"
        Me.CLB_CursosDeCarrera.Size = New System.Drawing.Size(158, 94)
        Me.CLB_CursosDeCarrera.TabIndex = 4
        '
        'LblIngresarCursosdeCarrera
        '
        Me.LblIngresarCursosdeCarrera.AutoSize = True
        Me.LblIngresarCursosdeCarrera.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblIngresarCursosdeCarrera.Location = New System.Drawing.Point(263, 116)
        Me.LblIngresarCursosdeCarrera.Name = "LblIngresarCursosdeCarrera"
        Me.LblIngresarCursosdeCarrera.Size = New System.Drawing.Size(92, 13)
        Me.LblIngresarCursosdeCarrera.TabIndex = 5
        Me.LblIngresarCursosdeCarrera.Text = "Ingrese los cursos"
        '
        'BtnRegistrarCarreras
        '
        Me.BtnRegistrarCarreras.Location = New System.Drawing.Point(41, 338)
        Me.BtnRegistrarCarreras.Name = "BtnRegistrarCarreras"
        Me.BtnRegistrarCarreras.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegistrarCarreras.TabIndex = 6
        Me.BtnRegistrarCarreras.Text = "Registrar"
        Me.BtnRegistrarCarreras.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(293, 338)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 7
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(165, 338)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 8
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(381, 448)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 9
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'LblIngreseFecha
        '
        Me.LblIngreseFecha.AutoSize = True
        Me.LblIngreseFecha.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblIngreseFecha.Location = New System.Drawing.Point(263, 27)
        Me.LblIngreseFecha.Name = "LblIngreseFecha"
        Me.LblIngreseFecha.Size = New System.Drawing.Size(83, 13)
        Me.LblIngreseFecha.TabIndex = 10
        Me.LblIngreseFecha.Text = "Ingrese la fecha"
        '
        'DTP_FechaRegistrarCursos
        '
        Me.DTP_FechaRegistrarCursos.Location = New System.Drawing.Point(266, 62)
        Me.DTP_FechaRegistrarCursos.Name = "DTP_FechaRegistrarCursos"
        Me.DTP_FechaRegistrarCursos.Size = New System.Drawing.Size(200, 20)
        Me.DTP_FechaRegistrarCursos.TabIndex = 11
        '
        'FrmRegistrarEstudiantesEnCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(478, 483)
        Me.Controls.Add(Me.DTP_FechaRegistrarCursos)
        Me.Controls.Add(Me.LblIngreseFecha)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.BtnRegistrarCarreras)
        Me.Controls.Add(Me.LblIngresarCursosdeCarrera)
        Me.Controls.Add(Me.CLB_CursosDeCarrera)
        Me.Controls.Add(Me.LblIngresarDatoCarrera)
        Me.Controls.Add(Me.CLB_Selccione_carrera_RegistarEstuCursos)
        Me.Controls.Add(Me.Txt_Id_RegistrarEst_Carreras)
        Me.Controls.Add(Me.LblIngresarDatoIdentificacion)
        Me.Name = "FrmRegistrarEstudiantesEnCursos"
        Me.Text = "Registrar Estudiantes En Cursos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblIngresarDatoIdentificacion As Label
    Friend WithEvents Txt_Id_RegistrarEst_Carreras As TextBox
    Friend WithEvents CLB_Selccione_carrera_RegistarEstuCursos As CheckedListBox
    Friend WithEvents LblIngresarDatoCarrera As Label
    Friend WithEvents CLB_CursosDeCarrera As CheckedListBox
    Friend WithEvents LblIngresarCursosdeCarrera As Label
    Friend WithEvents BtnRegistrarCarreras As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents LblIngreseFecha As Label
    Friend WithEvents DTP_FechaRegistrarCursos As DateTimePicker
End Class
