Imports System.Xml


Public Class FrmLogin

    Private Sub LblNombreUsuarioLogin_Click(sender As Object, e As EventArgs) Handles LblNombreUsuarioLogin.Click

    End Sub

    Private Sub BtnAgrergar_Click(sender As Object, e As EventArgs) Handles BtnIniciarSesion.Click

        Dim xmlFile As String = "C:\SistemaMatricula\Funcionarios\" + Me.TxtNombreUsuarioLogin.Text + ".xml"
        Dim frmPrincipal As New FrmPantall_Principal()
        Dim frmLogin As New FrmLogin()

        ' Cargar el archivo XML en un objeto XmlDocument

        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(xmlFile)

        ' Obtiene el nodo raíz del documento
        Dim raiz As XmlNode = xmlDoc.DocumentElement
        Dim lbbandera As Boolean = False
        ' Verifica que el nodo raíz sea "Funcionarios"
        If raiz.Name = "Funcionarios" Then
            ' Recorre los nodos "Funcionario"
            For Each nodoFuncionario As XmlNode In raiz.ChildNodes
                ' Verifica que el nodo sea "Funcionario"
                If nodoFuncionario.Name = "Funcionario" Then
                    ' Recorre los elementos dentro del nodo "Funcionario"
                    For Each elemento As XmlNode In nodoFuncionario.ChildNodes
                        ' Accede a los elementos o atributos según sea necesario
                        Dim nombreElemento As String = elemento.Name
                        If nombreElemento = "Clave" Then
                            Dim valorElemento As String = elemento.InnerText
                            If valorElemento = Me.TxtContraseñaLogin.Text Then
                                lbbandera = True
                            Else
                                lbbandera = False
                            End If
                        End If
                        If nombreElemento = "Usuario" Then
                            Dim valorElemento As String = elemento.InnerText
                            If valorElemento = Me.TxtNombreUsuarioLogin.Text Then

                                lbbandera = True
                            Else
                                lbbandera = False
                            End If
                        End If
                    Next
                End If
            Next
        End If
        If lbbandera Then
            'Console.WriteLine("Inicio de sesión exitoso.")
            MsgBox("Inicio de sesión exitoso.")


            Me.TxtNombreUsuarioLogin.Clear()
            Me.TxtContraseñaLogin.Clear()
            frmPrincipal.Show()

        Else
            MsgBox("Usuario o contraseña incorrectos.")
            Me.TxtNombreUsuarioLogin.Clear()
            Me.TxtContraseñaLogin.Clear()
            'Console.WriteLine("Usuario o contraseña incorrectos.")
        End If
        ' Obtener todos los elementos "user" en el archivo XML

        'Dim userNodes As XmlNodeList = xmlDoc.GetElementsByTagName("Usuario")

        'Dim FuncionariosNodes As XmlNode = xmlDoc.SelectNodes("Funcionarios")
        'Dim FuncionarioNodes As XmlNode = FuncionariosNodes.SelectNodes("Funcionario")
        'Dim usuarioValue As String = userNodes.InnerText

        ' Iterar sobre los elementos "user" para verificar el inicio de sesión

        'Dim loggedIn As Boolean = False
        'For Each userNode As XmlNode In FuncionarioNodes
        '    Dim userElement As XmlElement = DirectCast(userNode, XmlElement)
        '    Dim usernameNode As XmlNode = userElement.SelectSingleNode("usuario")
        '    Dim passwordNode As XmlNode = userElement.SelectSingleNode("clave")

        '    ' Verificar si el usuario y la contraseña coinciden
        '    If usernameNode.InnerText = usuario AndAlso passwordNode.InnerText = clave Then
        '        loggedIn = True
        '        Exit For
        '    End If
        'Next

        ' Verificar el resultado del inicio de sesión

    End Sub


End Class