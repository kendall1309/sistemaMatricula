Public Class FrmRegistrarEstudiantesEnCursos
    Private Sub BtnRegistrarCarreras_Click(sender As Object, e As EventArgs) Handles BtnRegistrarCarreras.Click
        Try
            If Me.validardatosCursos Then

                Dim iCursos As New Datos.Cursos

                'iCursos.Sr = Me.txtNombre.Text
                'iCursos.SrtProvincia1 = Me.txtPrimerApellido.Text
                'iCursos.SrtSegundoApellido1 = Me.txtSegundoApellido.Text
                'iCursos.SrtProvincia1 = Me.txtProvincia.Text
                'iCursos.SrtDireccion1 = Me.txtDireccion.Text

                'Dar edad a base del metodo echo en la clase estudiante
                iCursos.DtFecha = Me.DTP_FechaRegistrarCursos.Value.Date


                'crear la ruta
                Dim srtRuta As String = System.Configuration.ConfigurationManager.AppSettings("rutaArchivo") 'el nombre que se puso en App.config

                'iCursos.Registrar(srtRuta) 'ruta del archivo donde se va a guardar la info


                MessageBox.Show("Se ha registrado de forma correcta:")
                ' MessageBox.Show(iCursos.CalcularEdad, "Edad del estudiante:")'para lo de edad 
            End If

        Catch ex As Exception
            MessageBox.Show("Se ha producido una exepcion al momneto de resgistrar al estudiante en la carrera, el cual indica" & ex.Message)

        End Try
    End Sub
#Region "Metodo para validar datos del estudiantes"
    Private Function validardatosCursos() As Boolean
        Dim strMensaje As New System.Text.StringBuilder("Favor verificar los datos que se indican")
        'variable blnDatosValidos para empezar a validar 
        Dim blnDatosValidos As Boolean = True
        With strMensaje
            .Append(vbCrLf) 'cambio de linea  = dar un enter en el teclado para cambio de linea 

            'valida que se haya ingresado un dato en ingrese numero de indentificacion

            If String.IsNullOrEmpty(Me.Txt_Id_RegistrarEst_Carreras.Text.Trim) Then

                .AppendLine("* Favor indicar la identificacion.")
                blnDatosValidos = False

            End If

            If String.IsNullOrEmpty(Me.DTP_FechaRegistrarCursos.Text.Trim) Then

                .AppendLine("* Favor ingrese la fecha.")
                blnDatosValidos = False

            End If

            If String.IsNullOrEmpty(Me.CLB_CursosDeCarrera.Text.Trim) Then

                .AppendLine("* Favor indicar los cursos a matricular.")
                blnDatosValidos = False

            End If

            If String.IsNullOrEmpty(Me.CLB_Selccione_carrera_RegistarEstuCursos.Text.Trim) Then

                .AppendLine("* Favor indicar carrera a matricular.")
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