Public Class FrmCursos
    Private Sub FrmCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAgregarCurso_Click(sender As Object, e As EventArgs) Handles btnAgregarCurso.Click

        Try
            If Me.validardatosCursos Then

                Dim iCursos As New Datos.Cursos

                iCursos.strCodigoCurso = Me.txtNombreCurso.Text
                iCursos.IntCantidadCreditos = Me.cbCreditos.Text
                iCursos.IntNotaMinima = Me.txtNotaMinima.Text
                iCursos.IntCantidadMAxEstudiantes = Me.txtCantidadMax.Text
                iCursos.IntCantidadMinEstudiantes = Me.txtCantidadMax.Text
                iCursos.IntCostoCurso = Me.txtCostoCurso.Text





                'crear la ruta
                Dim srtRuta As String = System.Configuration.ConfigurationManager.AppSettings("rutaArchivo") 'el nombre que se puso en App.config

                iCursos.RegistrarCursos(srtRuta) 'ruta del archivo donde se va a guardar la info


                MessageBox.Show("Se ha registrado de forma correcta:")
                ' MessageBox.Show(iCursos.CalcularEdad, "Edad del estudiante:")'para lo de edad 
            End If



        Catch ex As Exception
            MessageBox.Show("Se ha producido una exepcion al momneto de resgistrar al estudiante, el cual indica" & ex.Message)


        End Try

    End Sub

#Region "validar_datos_de_cursos"
    Private Function validardatosCursos() As Boolean
        Dim strMensaje As New System.Text.StringBuilder("Favor verificar los datos que se indican")
        'variable blnDatosValidos para empezar a validar 
        Dim blnDatosValidos As Boolean = True
        With strMensaje
            .Append(vbCrLf) 'cambio de linea  = dar un enter en el teclado para cambio de linea 


            'validaciones de datos de entrada
            'valida que se haya ingresado un dato en el nombre

            If String.IsNullOrEmpty(Me.txtNombreCurso.Text.Trim) Then

                .AppendLine("* Favor indicar el nombre del curso.")
                blnDatosValidos = False

            End If
            'validar primer apellido y asi sucesivamente
            If String.IsNullOrEmpty(Me.txtCodigoCurso.Text.Trim) Then

                .AppendLine("* Favor indicar el codigo del curso.")
                blnDatosValidos = False

            End If

            If String.IsNullOrEmpty(Me.txtNotaMinima.Text.Trim) Then

                .AppendLine("* Favor indicar la nota minima del curso.")
                blnDatosValidos = False

            End If

            If String.IsNullOrEmpty(Me.txtGradoCurso.Text.Trim) Then

                .AppendLine("* Favor indicar el grado del curso.")
                blnDatosValidos = False

            End If

            If String.IsNullOrEmpty(Me.cbCreditos.Text.Trim) Then

                .AppendLine("* Favor indicar la cantidad de creditos.")
                blnDatosValidos = False

            End If

            If String.IsNullOrEmpty(Me.txtCantidadMax.Text.Trim) Then

                .AppendLine("* Favor indicar la cantidad maxima de estudiantes.")
                blnDatosValidos = False

            End If

            If String.IsNullOrEmpty(Me.txtCantidadMin.Text.Trim) Then

                .AppendLine("* Favor indicar la cantidad minima de estudiantes.")
                blnDatosValidos = False

            End If

            If String.IsNullOrEmpty(Me.cbEstado.Text.Trim) Then

                .AppendLine("* Favor indicar la cantidad de creditos.")
                blnDatosValidos = False

            End If
        End With

        'muestra mensaje 
        If Not blnDatosValidos Then

            MessageBox.Show(strMensaje.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End If



        Return blnDatosValidos

    End Function

#End Region

End Class