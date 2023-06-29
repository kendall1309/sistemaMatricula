Public Class FrmCarreras
    Private Sub BtnAgergaAgreCarreras_Click(sender As Object, e As EventArgs) Handles BtnAgergaAgreCarreras.Click
        Try
            If Me.validardatosDatosCarrera Then

                Dim iCarreras As New Datos.Carreras

                iCarreras.strCodigoCarrera = Me.TXT_GradoAgregarCarrera.Text
                iCarreras.strNombreC = Me.TxtNombreDeCarrera.Text
                iCarreras.strGrados = Me.TXT_GradoAgregarCarrera.Text

                'crear la ruta
                Dim srtRuta As String = System.Configuration.ConfigurationManager.AppSettings("rutaArchivo") 'el nombre que se puso en App.config

                ''iCarreras.Registrar(srtRuta) 'ruta del archivo donde se va a guardar la info


                MessageBox.Show("Se ha registrado de forma correcta:")

            End If

        Catch ex As Exception
            MessageBox.Show("Se ha producido una exepcion al momneto de resgistrar la carrera, el cual indica" & ex.Message)

        End Try

    End Sub

#Region "Metodo para validar datos"

    Private Function validardatosDatosCarrera() As Boolean
        Dim strMensaje As New System.Text.StringBuilder("Favor verificar los datos que se indican")
        'variable blnDatosValidos para empezar a validar 
        Dim blnDatosValidos As Boolean = True
        With strMensaje
            .Append(vbCrLf) 'cambio de linea  = dar un enter en el teclado para cambio de linea 


            'validaciones de datos de entrada
            'valida que se haya ingresado un dato en el nombre

            If String.IsNullOrEmpty(Me.TxtNombreDeCarrera.Text.Trim) Then

                .AppendLine("* Favor indicar el nombre de carrera.")
                blnDatosValidos = False

            End If
            'validar primer apellido y asi sucesivamente
            If String.IsNullOrEmpty(Me.TXT_GradoAgregarCarrera.Text.Trim) Then

                .AppendLine("* Favor indicar el gardo de carrera.")
                blnDatosValidos = False

            End If

            If String.IsNullOrEmpty(Me.TxtCodigoAgergarCarrera.Text.Trim) Then

                .AppendLine("* Favor indicar el cosdigo de carrera.")
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