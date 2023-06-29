Imports System.Xml

Public Class Login


    Sub Main()
            Dim xmlFile As String = "ruta_del_archivo.xml"
            Dim username As String = "nombre_de_usuario"
            Dim password As String = "contraseña"

            ' Cargar el archivo XML en un objeto XmlDocument

            Dim xmlDoc As New XmlDocument()
            xmlDoc.Load(xmlFile)

            ' Obtener todos los elementos "user" en el archivo XML

            Dim userNodes As XmlNodeList = xmlDoc.GetElementsByTagName("Usuario")

            ' Iterar sobre los elementos "user" para verificar el inicio de sesión

            Dim loggedIn As Boolean = False
            For Each userNode As XmlNode In userNodes
                Dim userElement As XmlElement = DirectCast(userNode, XmlElement)
                Dim usernameNode As XmlNode = userElement.SelectSingleNode("Usuario")
                Dim passwordNode As XmlNode = userElement.SelectSingleNode("Clave")

                ' Verificar si el usuario y la contraseña coinciden
                If usernameNode.InnerText = username AndAlso passwordNode.InnerText = password Then
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
