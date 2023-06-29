Imports System.IO
Imports System.Xml

Public Class Carreras
#Region "variables"
    Public strCodigoCarrera As String
    Public strNombreC As String
    Public strGrados As String
    Public blnEstado As Boolean
#End Region
#Region "atributos de carreras"
    Public Property CodigoDeCarrera() As String
        Get
            Return strCodigoCarrera
        End Get
        Set(ByVal value As String)
            strCodigoCarrera = value
        End Set
    End Property

    Public Property NombreCarrera() As String
        Get
            Return strNombreC
        End Get
        Set(ByVal value As String)
            strNombreC = value
        End Set
    End Property


    Public Property Grado() As String
        Get
            Return strGrados
        End Get
        Set(ByVal value As String)
            strGrados = value
        End Set
    End Property

    Public Property Estado() As String
        Get
            Return blnEstado
        End Get
        Set(ByVal value As String)
            blnEstado = value
        End Set
    End Property
#End Region
#Region "Metodo para crear y escribir la info en Xml"
    Public Sub RegistrarCarreras(ByVal rutaArchivo As String)

        Dim mstnArchivo As New MemoryStream

        Dim xlmwCarreras As New XmlTextWriter(mstnArchivo, System.Text.Encoding.UTF8)

        With xlmwCarreras 'variable

            .Formatting = Formatting.Indented
            'crear documento
            .WriteStartDocument()

            'agregar la informacion de Carrera
            .WriteStartElement("Carreras") 'nodo raiz

            'agregar el nodo Carrera-----------------
            .WriteStartElement("Carrera")
            '--------------------------------------
            'agregar la informacion del  nombre
            .WriteStartElement("CodigoCarrera")
            .WriteString(Me.strCodigoCarrera)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion del  nombre
            .WriteStartElement("NomCarrera")
            .WriteString(Me.strNombreC)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion del  grado de carrera
            .WriteStartElement("Grado")
            .WriteString(Me.strGrados)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion del  estado
            .WriteStartElement("Estado")
            .WriteString(Me.blnEstado)
            .WriteEndElement()

            .WriteEndElement() 'fin nodo carrera-------- solo un end por nodo

            'cierra la informacion del nodo raiz carreras
            .WriteEndElement()

            'finaliza documento
            .WriteEndDocument()

        End With

        xlmwCarreras.Flush()

        Dim xmlArchivo As New Datos.ArchivosXml 'escribir en el archivo
        xmlArchivo.Grabar(mstnArchivo, rutaArchivo)

        xlmwCarreras.Close() 'cerrar el archivo
    End Sub
#End Region
#Region "Funcion para leer DatosXml"
    Public Function Leercarreras(rutaArchivo As String) As Carreras

        Dim iXmlFile As New Datos.ArchivosXml
        Dim xmlArchivo As XmlDocument = iXmlFile.leer(rutaArchivo)

        Dim lstNodeXMl As XmlNodeList = xmlArchivo.GetElementsByTagName("Estudiantes/Estudiante")
        ' lstNodeXMl = lstNodeXMl


        Dim iCarreras As New Carreras
        For Each xmlNode As XmlNode In lstNodeXMl

            With iCarreras
                .strCodigoCarrera = xmlNode("Codigo").InnerText
                .strNombreC = xmlNode("Nombre").InnerText
                .strGrados = xmlNode("Grado").InnerText
                .blnEstado = xmlNode("Estado").InnerText
            End With


        Next

        Return iCarreras
    End Function

#End Region
End Class
