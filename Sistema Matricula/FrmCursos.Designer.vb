<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCursos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCodigoCurso = New System.Windows.Forms.TextBox()
        Me.txtNombreCurso = New System.Windows.Forms.TextBox()
        Me.txtNotaMinima = New System.Windows.Forms.TextBox()
        Me.txtCantidadMax = New System.Windows.Forms.TextBox()
        Me.txtGradoCurso = New System.Windows.Forms.TextBox()
        Me.txtCostoCurso = New System.Windows.Forms.TextBox()
        Me.cbCreditos = New System.Windows.Forms.ComboBox()
        Me.txtCantidadMin = New System.Windows.Forms.TextBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.btnAgregarCurso = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(16, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo del Curso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(16, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del Curso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(196, 31)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Creditos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(16, 138)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nota Minima Curso"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(196, 84)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cantidad Max Estudiantes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(196, 135)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cantidad Min Estudiantes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(16, 204)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Grado del Curso"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Location = New System.Drawing.Point(196, 204)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Estado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Location = New System.Drawing.Point(16, 257)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Costo del Curso"
        '
        'txtCodigoCurso
        '
        Me.txtCodigoCurso.Location = New System.Drawing.Point(19, 55)
        Me.txtCodigoCurso.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodigoCurso.Name = "txtCodigoCurso"
        Me.txtCodigoCurso.Size = New System.Drawing.Size(117, 20)
        Me.txtCodigoCurso.TabIndex = 9
        '
        'txtNombreCurso
        '
        Me.txtNombreCurso.Location = New System.Drawing.Point(19, 106)
        Me.txtNombreCurso.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreCurso.Name = "txtNombreCurso"
        Me.txtNombreCurso.Size = New System.Drawing.Size(117, 20)
        Me.txtNombreCurso.TabIndex = 10
        '
        'txtNotaMinima
        '
        Me.txtNotaMinima.Location = New System.Drawing.Point(19, 170)
        Me.txtNotaMinima.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNotaMinima.Name = "txtNotaMinima"
        Me.txtNotaMinima.Size = New System.Drawing.Size(117, 20)
        Me.txtNotaMinima.TabIndex = 11
        '
        'txtCantidadMax
        '
        Me.txtCantidadMax.Location = New System.Drawing.Point(199, 106)
        Me.txtCantidadMax.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidadMax.Name = "txtCantidadMax"
        Me.txtCantidadMax.Size = New System.Drawing.Size(117, 20)
        Me.txtCantidadMax.TabIndex = 12
        '
        'txtGradoCurso
        '
        Me.txtGradoCurso.Location = New System.Drawing.Point(19, 228)
        Me.txtGradoCurso.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGradoCurso.Name = "txtGradoCurso"
        Me.txtGradoCurso.Size = New System.Drawing.Size(117, 20)
        Me.txtGradoCurso.TabIndex = 13
        '
        'txtCostoCurso
        '
        Me.txtCostoCurso.Location = New System.Drawing.Point(19, 280)
        Me.txtCostoCurso.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCostoCurso.Name = "txtCostoCurso"
        Me.txtCostoCurso.Size = New System.Drawing.Size(117, 20)
        Me.txtCostoCurso.TabIndex = 14
        '
        'cbCreditos
        '
        Me.cbCreditos.FormattingEnabled = True
        Me.cbCreditos.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbCreditos.Location = New System.Drawing.Point(199, 55)
        Me.cbCreditos.Margin = New System.Windows.Forms.Padding(2)
        Me.cbCreditos.Name = "cbCreditos"
        Me.cbCreditos.Size = New System.Drawing.Size(92, 21)
        Me.cbCreditos.TabIndex = 15
        '
        'txtCantidadMin
        '
        Me.txtCantidadMin.Location = New System.Drawing.Point(199, 170)
        Me.txtCantidadMin.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidadMin.Name = "txtCantidadMin"
        Me.txtCantidadMin.Size = New System.Drawing.Size(117, 20)
        Me.txtCantidadMin.TabIndex = 16
        '
        'cbEstado
        '
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.cbEstado.Location = New System.Drawing.Point(199, 227)
        Me.cbEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(92, 21)
        Me.cbEstado.TabIndex = 17
        '
        'btnAgregarCurso
        '
        Me.btnAgregarCurso.Location = New System.Drawing.Point(199, 273)
        Me.btnAgregarCurso.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarCurso.Name = "btnAgregarCurso"
        Me.btnAgregarCurso.Size = New System.Drawing.Size(82, 32)
        Me.btnAgregarCurso.TabIndex = 18
        Me.btnAgregarCurso.Text = "Agregar"
        Me.btnAgregarCurso.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(286, 273)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(82, 32)
        Me.btnModificar.TabIndex = 19
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(371, 273)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(82, 32)
        Me.btnEliminar.TabIndex = 20
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'FrmCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(463, 321)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregarCurso)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.txtCantidadMin)
        Me.Controls.Add(Me.cbCreditos)
        Me.Controls.Add(Me.txtCostoCurso)
        Me.Controls.Add(Me.txtGradoCurso)
        Me.Controls.Add(Me.txtCantidadMax)
        Me.Controls.Add(Me.txtNotaMinima)
        Me.Controls.Add(Me.txtNombreCurso)
        Me.Controls.Add(Me.txtCodigoCurso)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmCursos"
        Me.Text = "Cursos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCodigoCurso As TextBox
    Friend WithEvents txtNombreCurso As TextBox
    Friend WithEvents txtNotaMinima As TextBox
    Friend WithEvents txtCantidadMax As TextBox
    Friend WithEvents txtGradoCurso As TextBox
    Friend WithEvents txtCostoCurso As TextBox
    Friend WithEvents cbCreditos As ComboBox
    Friend WithEvents txtCantidadMin As TextBox
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents btnAgregarCurso As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
End Class
