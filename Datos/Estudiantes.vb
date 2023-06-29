Imports System.IO
Imports System.Xml
Public Class Estudiante

#Region "Atributos de objetos estudiantes"
    Private strNombre As String
    Private intIdentificacion As Integer
    Private strApellidos As String
    Private strCarrerasMatri As String
    Private intTelefono As Integer
    Private strCorreoContacto As String
    Private datefecha_Naci As Date
    Private strDireccionExacta As String
    Private strCursos As String
    Private blnTieneBeca As Boolean
#End Region

#Region "Propiedades"

    ' Propiedad para establecer el nombre del estudiante
    Public Property Nombre() As String
        Get
            Return strNombre
        End Get
        Set(ByVal value As String)
            strNombre = value
        End Set
    End Property
    ' Propiedad para obtener la identificacion del estudiante
    Public Property identificacion As Integer
        Get
            Return intIdentificacion
        End Get
        Set(ByVal value As Integer)
            intIdentificacion = value
        End Set
    End Property
    ' Propiedad para obtener los apellidos del estudiante
    Public Property Apellidos As Integer
        Get
            Return strApellidos
        End Get
        Set(ByVal value As Integer)
            strApellidos = value
        End Set
    End Property

    ' Propiedad para obtener las carreras del estudiante
    Public Property CarrerasMatriculadas() As String
        Get
            Return strCarrerasMatri
        End Get
        Set(ByVal value As String)
            strCarrerasMatri = value
        End Set
    End Property
    ' Propiedad para obtener el telefono del estudiante
    Public Property Telefono() As Integer
        Get
            Return intTelefono
        End Get
        Set(ByVal value As Integer)
            intTelefono = value
        End Set
    End Property
    ' Propiedad para obtener el correo  del estudiante
    Public Property CorreoContacto() As String
        Get
            Return strCorreoContacto
        End Get
        Set(ByVal value As String)
            strCorreoContacto = value
        End Set
    End Property
    ' Propiedad para obtener la fecha de nacimiento del estudiante
    Public Property FechaNacimiento() As Date
        Get
            Return datefecha_Naci
        End Get
        Set(ByVal value As Date)
            datefecha_Naci = value
        End Set
    End Property
    ' Propiedad para obtener la direccion del estudiante
    Public Property DireccionExacta() As String
        Get
            Return strDireccionExacta
        End Get
        Set(ByVal value As String)
            strDireccionExacta = value
        End Set
    End Property
    ' Propiedad para obtener el curso del estudiante
    Public Property Cursos() As String
        Get
            Return strCursos
        End Get
        Set(ByVal value As String)
            strCursos = value
        End Set
    End Property
    ' Propiedad para obtener si o no posee beca el estudiante
    Public Property TieneBeca As Boolean
        Get
            Return blnTieneBeca
        End Get
        Set(value As Boolean)
            blnTieneBeca = value
        End Set
    End Property

#End Region

    Public Sub RegistrarEstudiantes(ByVal Nombre As String, ByVal Apellidos As String,
                                    ByVal Identificacion As String, ByVal Telefono As String,
                                            ByVal CorreoElectronico As String, ByVal Dirrecion As String) ''Metodo para crear y escrubir los datos en Xml

        Dim mstnArchivo As New MemoryStream

        Dim xlmwEstudiante As New XmlTextWriter(mstnArchivo, System.Text.Encoding.UTF8)

        With xlmwEstudiante 'variable

            .Formatting = Formatting.Indented
            'crear documento
            .WriteStartDocument()
            '-----------------------------------------------------------
            'agregar la informacion del estudiante
            .WriteStartElement("ESTUDIANTES") 'nodo raiz
            '-----------------------------------------------------------
            .WriteStartElement("Estudiante") 'agregar el nodo estudiante
            '-----------------------------------------------------------
            'agregar la informacion de idenficacion del estudiante
            .WriteStartElement("ID")
            .WriteString(Identificacion)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion del  nombre
            .WriteStartElement("Nombre")
            .WriteString(Nombre)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion de los apellidos
            .WriteStartElement("Apellidos")
            .WriteString(Me.strApellidos)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion de las carreras matriculadas
            .WriteStartElement("CarrerasMatriculadas")
            .WriteString(Me.strCarrerasMatri)
            .WriteEndElement()
            'y asi sucesivamente
            '--------------------------------------
            'agregar la informacion del Telefono
            .WriteStartElement("Telefono")
            .WriteString(Me.intTelefono)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion del Correo contacto
            .WriteStartElement("Correo")
            .WriteString(Me.strCorreoContacto)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion de la Fecha Nacimiento
            .WriteStartElement("FechaNacimiento")
            .WriteString(Me.datefecha_Naci)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion de la Direccion
            .WriteStartElement("Direccion")
            .WriteString(Me.strDireccionExacta)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion de los Cursos matriculadas
            .WriteStartElement("Cursos")
            .WriteString(Me.strCursos)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion de si posee Beca
            .WriteStartElement("Beca")
            .WriteString(Me.blnTieneBeca)
            .WriteEndElement()
            '-------------------------------------------------------------------------
            .WriteEndElement() 'fin nodo estudiante-------------- solo un end por nodo
            '-------------------------------------------------------------------------
            'cierra la informacion del nodo raiz estudiante
            .WriteEndElement()
            '-------------------------------------------------------------------------
            'finaliza documento
            .WriteEndDocument()
        End With
        '--------------------------------------
        xlmwEstudiante.Flush()
        Dim xmlArchivo As New Datos.ArchivosXml 'escribir en el archivo
        xmlArchivo.Grabar(mstnArchivo, "C:\SistemaMatricula\Estudiantes\" + Identificacion + ".xml")
        '--------------------------------------
        xlmwEstudiante.Close() 'cerrar el archivo
    End Sub
    '-------------------------------------------------------------------------
    'Funcion para leer la informacion de los estudiantes en los xml
    Public Function LeerEstudiante(rutaArchivo As String) As Estudiante

        Dim iXmlFile As New Datos.ArchivosXml ''crea el archivo 
        Dim xmlArchivo As XmlDocument = iXmlFile.leer(rutaArchivo) ''lo pone en la ruta establecida
        Dim lstNodeXMl As XmlNodeList = xmlArchivo.GetElementsByTagName("Estudiantes/Estudiante")
        Dim iEstudiante As New Estudiante
        For Each xmlNode As XmlNode In lstNodeXMl

            With iEstudiante ''datos que van dentro de el xml Estudiante
                .intIdentificacion = xmlNode("ID").InnerText
                .strNombre = xmlNode("Nombre").InnerText
                .strApellidos = xmlNode("Apellido").InnerText
                .strCarrerasMatri = xmlNode("CarrerasMatriculas").InnerText
                .intTelefono = xmlNode("Telefono").InnerText
                .strCorreoContacto = xmlNode("Correo").InnerText
                .datefecha_Naci = xmlNode("FechaNacimiento").InnerText
                .strDireccionExacta = xmlNode("Direccion").InnerText
                .strCursos = xmlNode("Cursos").InnerText
                .blnTieneBeca = xmlNode("Beca").InnerText
            End With
        Next
        Return iEstudiante
    End Function

End Class
