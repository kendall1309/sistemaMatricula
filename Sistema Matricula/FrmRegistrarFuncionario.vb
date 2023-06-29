Imports Datos
Imports System.Configuration

Public Class FrmRegistrarFuncionario
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblNombreFuncionario.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles LblIdentificacionFuncionario.Click

    End Sub

    Private Sub BtnRegistrarFuncionario_Click(sender As Object, e As EventArgs) Handles BtnRegistrarFuncionario.Click
        Try
            If Me.ValidarDatos Then
                Dim iFuncionario As New Datos.Funcionario
                iFuncionario.intIdentificacionFun = txtIdentificacionUsuario.Text
                iFuncionario.strNombreFun = TxtNombreUsuario.Text
                iFuncionario.strPrimerApellidoFun = TxtPrimerApellidoUsuario.Text
                iFuncionario.strSegundoApellidoFun = txtSegundoApellidoUsuario.Text
                iFuncionario.strClave = TxtClavefuncionario.Text
                iFuncionario.strUsuario = TxtUsuarioFuncionario.Text
                ''iFuncionario.blnEstado = CcbActivoFuncionario.CheckedItems.to


                'crear la ruta
                Dim srtRutaFuncionario As String = System.Configuration.ConfigurationManager.AppSettings("rutaArchivo") 'el nombre que se puso en App.config
                iFuncionario.RegistrarFuncionario(srtRutaFuncionario) 'ruta del archivo donde se va a guardar la info
                MessageBox.Show("Se ha registrado de forma correcta:")
            End If
        Catch ex As Exception
            MessageBox.Show("Se ha producido una exepcion al momneto de resgistrar al estudiante, el cual indica" & ex.Message)

        End Try
    End Sub
#Region "Metodo validar informacion"

    Private Function ValidarDatos() As Boolean
        Dim strMensaje As New System.Text.StringBuilder("Favor verificar los datos que se indican")
        'variable blnDatosValidos para empezar a validar 
        Dim blnDatosValidos As Boolean = True
        With strMensaje
            .Append(vbCrLf) 'cambio de linea  = dar un enter en el teclado para cambio de linea

            'validaciones de datos de entrada

            'valida que se haya ingresado un dato en el nombre
            If String.IsNullOrEmpty(Me.TxtNombreUsuario.Text.Trim) Then
                .AppendLine("* Favor indicar el nombre del funcionario.")
                blnDatosValidos = False
            End If

            'validar primer apellido 
            If String.IsNullOrEmpty(Me.TxtPrimerApellidoUsuario.Text.Trim) Then

                .AppendLine("* Favor indicar el primer apellido del funcionario.")
                blnDatosValidos = False

            End If

            'Validar segundo apellido
            If String.IsNullOrEmpty(Me.txtSegundoApellidoUsuario.Text.Trim) Then

                .AppendLine("* Favor indicar el segundo apellido del funcionario.")
                blnDatosValidos = False

            End If

            'validar usario 

            If String.IsNullOrEmpty(Me.TxtUsuarioFuncionario.Text.Trim) Then

                .AppendLine("* Favor indicar el nombre de usario del funcionario.")
                blnDatosValidos = False

            End If

            'valida clave 
            If String.IsNullOrEmpty(Me.TxtClavefuncionario.Text.Trim) Then

                .AppendLine("* Favor indicar la clave.")
                blnDatosValidos = False

            End If

            'validar estado

            If String.IsNullOrEmpty(Me.CcbActivoFuncionario.Text.Trim) Then

                .AppendLine("* Favor indicar el estado.")
                blnDatosValidos = False

            End If

        End With

        'mostrar mensaje 
        If Not blnDatosValidos Then
            MessageBox.Show(strMensaje.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
        Return blnDatosValidos
    End Function
#End Region
End Class