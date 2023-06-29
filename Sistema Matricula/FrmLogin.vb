﻿Imports System.Xml


Public Class FrmLogin

    Private Sub LblNombreUsuarioLogin_Click(sender As Object, e As EventArgs) Handles LblNombreUsuarioLogin.Click

    End Sub

    Private Sub BtnAgrergar_Click(sender As Object, e As EventArgs) Handles BtnIniciarSesion.Click

        Dim xmlFile As String = "C:\Users\kenda\OneDrive\Escritorio\PrimerEjemplo"
        Dim usuario As String = "strUsuario"
        Dim clave As String = "strClave"

        ' Cargar el archivo XML en un objeto XmlDocument

        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(xmlFile)

        ' Obtener todos los elementos "user" en el archivo XML

        Dim userNodes As XmlNodeList = xmlDoc.GetElementsByTagName("Usuario")

        ' Iterar sobre los elementos "user" para verificar el inicio de sesión

        Dim loggedIn As Boolean = False
        For Each userNode As XmlNode In userNodes
            Dim userElement As XmlElement = DirectCast(userNode, XmlElement)
            Dim usernameNode As XmlNode = userElement.SelectSingleNode("usuario")
            Dim passwordNode As XmlNode = userElement.SelectSingleNode("clave")

            ' Verificar si el usuario y la contraseña coinciden
            If usernameNode.InnerText = usuario AndAlso passwordNode.InnerText = clave Then
                loggedIn = True
                Exit For
            End If
        Next

        ' Verificar el resultado del inicio de sesión
        If loggedIn Then
            Console.WriteLine("Inicio de sesión exitoso.")
        Else
            Console.WriteLine("Usuario o contraseña incorrectos.")
        End If
    End Sub


End Class