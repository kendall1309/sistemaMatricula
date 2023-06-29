Imports System.IO
Imports System.Xml

Public Class Cursos
    Inherits Carreras

#Region "Variables"
    Public strCodigoCurso As String
    Public IntCantidadCreditos As Integer
    Public IntNotaMinima As Integer
    Public IntCantidadMAxEstudiantes As Integer
    Public IntCantidadMinEstudiantes As Integer
    Public IntCostoCurso As Integer
    Public DtFecha
#End Region
#Region "Propiedades"
    Public Property fecha() As Date
        Get
            Return DtFecha
        End Get
        Set(ByVal value As Date)
            DtFecha = value
        End Set
    End Property
    Public Property CodigoCurso As String
        Get
            Return strCodigoCurso
        End Get
        Set(value As String)
            strCodigoCurso = value
        End Set
    End Property

    Public Property CantidadCreditos As Integer
        Get
            Return IntCantidadCreditos
        End Get
        Set(value As Integer)
            IntCantidadCreditos = value
        End Set
    End Property

    Public Property NotaMinima As Integer
        Get
            Return IntNotaMinima
        End Get
        Set(value As Integer)
            IntNotaMinima = value
        End Set
    End Property

    Public Property CantidadMaxEstudiantes As Integer
        Get
            Return IntCantidadMAxEstudiantes
        End Get
        Set(value As Integer)
            IntCantidadMAxEstudiantes = value
        End Set
    End Property

    Public Property CantidadMinEstudiantes As Integer
        Get
            Return IntCantidadMinEstudiantes
        End Get
        Set(value As Integer)
            IntCantidadMinEstudiantes = value
        End Set
    End Property

    Public Property CostoCurso As Integer
        Get
            Return IntCostoCurso
        End Get
        Set(value As Integer)
            IntCostoCurso = value
        End Set
    End Property

#End Region
#Region "Metodo para crear y escribir xml"
    Public Sub RegistrarCursos(ByVal rutaArchivo As String)

        Dim mstnArchivo As New MemoryStream

        Dim xlmwCursos As New XmlTextWriter(mstnArchivo, System.Text.Encoding.UTF8)

        With xlmwCursos 'variable

            .Formatting = Formatting.Indented
            'crear documento
            .WriteStartDocument()


            'agregar la informacion del Curso
            .WriteStartElement("Cursos") 'nodo raiz


            'agregar el nodo estudiante---------------------------------
            .WriteStartElement("Curso")

            'agregar la informacion de fecha
            .WriteStartElement("Fecha")
            .WriteString(Me.DtFecha)
            .WriteEndElement()

            'agregar la informacion del  codigo carreras
            .WriteStartElement("CodigoCurso")
            .WriteString(Me.strCodigoCarrera & strCodigoCarrera)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion del  codigo carreras
            .WriteStartElement("Nombre")
            .WriteString(Me.strNombreC)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion de la cantidad creditos
            .WriteStartElement("cantidadCreditos")
            .WriteString(Me.IntCantidadCreditos)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion de la nota minima
            .WriteStartElement("NotaMinima")
            .WriteString(Me.IntNotaMinima)
            .WriteEndElement()
            '-----------------------------------------------------------
            'agregar la informacion de la cantidad minima de estudiantes
            .WriteStartElement("cantidadMinEstudaintes")
            .WriteString(Me.IntCantidadMinEstudiantes)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion de la cantidad maxima de estudiantes
            .WriteStartElement("cantidadMaxEstudaintes")
            .WriteString(Me.IntCantidadMAxEstudiantes)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion de la Grado
            .WriteStartElement("GradoCurso")
            .WriteString(Me.strGrados)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion de la Estado
            .WriteStartElement("Estado")
            .WriteString(Me.blnEstado)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion del costo del curso
            .WriteStartElement("Costo")
            .WriteString(Me.IntCostoCurso)
            .WriteEndElement()
            '--------------------------------------
            .WriteEndElement() 'fin nodo curso---------------------------------- solo un end por nodo
            'cierra la informacion del nodo raiz curso
            .WriteEndElement()
            'finaliza documento
            .WriteEndDocument()

        End With

        xlmwCursos.Flush()

        Dim xmlArchivo As New Datos.ArchivosXml 'escribir en el archivo
        xmlArchivo.Grabar(mstnArchivo, rutaArchivo)

        xlmwCursos.Close() 'cerrar el archivo

    End Sub
#End Region
#Region "Funcion leer"
    Public Function LeerCursos(rutaArchivo As String) As Cursos

        Dim iXmlFile As New Datos.ArchivosXml
        Dim xmlArchivo As XmlDocument = iXmlFile.leer(rutaArchivo)
        Dim lstNodeXMl As XmlNodeList = xmlArchivo.GetElementsByTagName("Estudiantes/Estudiante")

        Dim iCursos As New Cursos
        For Each xmlNode As XmlNode In lstNodeXMl

            With iCursos
                .strCodigoCurso = xmlNode("codigoCurso").InnerText
                .strNombreC = xmlNode("Nombre").InnerText
                .IntCantidadCreditos = xmlNode("Creditos").InnerText
                .IntNotaMinima = xmlNode("NotaMinima").InnerText
                .IntCantidadMinEstudiantes = xmlNode("CantidadMinEstudiantes").InnerText
                .IntCantidadMAxEstudiantes = xmlNode("CantidadMAxEstudiantes").InnerText
                .strGrados = xmlNode("Grado").InnerText
                .blnEstado = xmlNode("Estado").InnerText
                .IntCostoCurso = xmlNode("CostoCurso").InnerText
            End With
        Next
        Return iCursos
    End Function

#End Region
End Class
