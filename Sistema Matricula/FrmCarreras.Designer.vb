<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCarreras
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
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtNombreDeCarrera = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodigoAgergarCarrera = New System.Windows.Forms.TextBox()
        Me.TXT_GradoAgregarCarrera = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnAgergaAgreCarreras = New System.Windows.Forms.Button()
        Me.BtnEliminarAgergrCarreras = New System.Windows.Forms.Button()
        Me.BtnAgreVerCarreras = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.SystemColors.Window
        Me.LblNombre.Location = New System.Drawing.Point(28, 35)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(134, 13)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Ingrese nombre de carrera "
        '
        'TxtNombreDeCarrera
        '
        Me.TxtNombreDeCarrera.Location = New System.Drawing.Point(31, 77)
        Me.TxtNombreDeCarrera.Name = "TxtNombreDeCarrera"
        Me.TxtNombreDeCarrera.Size = New System.Drawing.Size(131, 20)
        Me.TxtNombreDeCarrera.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(28, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingrese Codigo de carrera "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(28, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ingrese grado de carrera "
        '
        'TxtCodigoAgergarCarrera
        '
        Me.TxtCodigoAgergarCarrera.Location = New System.Drawing.Point(29, 274)
        Me.TxtCodigoAgergarCarrera.Name = "TxtCodigoAgergarCarrera"
        Me.TxtCodigoAgergarCarrera.Size = New System.Drawing.Size(131, 20)
        Me.TxtCodigoAgergarCarrera.TabIndex = 4
        '
        'TXT_GradoAgregarCarrera
        '
        Me.TXT_GradoAgregarCarrera.Location = New System.Drawing.Point(31, 168)
        Me.TXT_GradoAgregarCarrera.Name = "TXT_GradoAgregarCarrera"
        Me.TXT_GradoAgregarCarrera.Size = New System.Drawing.Size(131, 20)
        Me.TXT_GradoAgregarCarrera.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(256, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(248, 259)
        Me.DataGridView1.TabIndex = 6
        '
        'BtnAgergaAgreCarreras
        '
        Me.BtnAgergaAgreCarreras.Location = New System.Drawing.Point(31, 361)
        Me.BtnAgergaAgreCarreras.Name = "BtnAgergaAgreCarreras"
        Me.BtnAgergaAgreCarreras.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgergaAgreCarreras.TabIndex = 7
        Me.BtnAgergaAgreCarreras.Text = "Agregar"
        Me.BtnAgergaAgreCarreras.UseVisualStyleBackColor = True
        '
        'BtnEliminarAgergrCarreras
        '
        Me.BtnEliminarAgergrCarreras.Location = New System.Drawing.Point(429, 361)
        Me.BtnEliminarAgergrCarreras.Name = "BtnEliminarAgergrCarreras"
        Me.BtnEliminarAgergrCarreras.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminarAgergrCarreras.TabIndex = 8
        Me.BtnEliminarAgergrCarreras.Text = "Eliminar"
        Me.BtnEliminarAgergrCarreras.UseVisualStyleBackColor = True
        '
        'BtnAgreVerCarreras
        '
        Me.BtnAgreVerCarreras.Location = New System.Drawing.Point(256, 361)
        Me.BtnAgreVerCarreras.Name = "BtnAgreVerCarreras"
        Me.BtnAgreVerCarreras.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgreVerCarreras.TabIndex = 9
        Me.BtnAgreVerCarreras.Text = "Ver Carreras"
        Me.BtnAgreVerCarreras.UseVisualStyleBackColor = True
        '
        'FrmCarreras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(553, 450)
        Me.Controls.Add(Me.BtnAgreVerCarreras)
        Me.Controls.Add(Me.BtnEliminarAgergrCarreras)
        Me.Controls.Add(Me.BtnAgergaAgreCarreras)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TXT_GradoAgregarCarrera)
        Me.Controls.Add(Me.TxtCodigoAgergarCarrera)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNombreDeCarrera)
        Me.Controls.Add(Me.LblNombre)
        Me.Name = "FrmCarreras"
        Me.Text = "Carreras"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNombre As Label
    Friend WithEvents TxtNombreDeCarrera As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCodigoAgergarCarrera As TextBox
    Friend WithEvents TXT_GradoAgregarCarrera As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnAgergaAgreCarreras As Button
    Friend WithEvents BtnEliminarAgergrCarreras As Button
    Friend WithEvents BtnAgreVerCarreras As Button
End Class
