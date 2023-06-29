Imports System.IO
Imports System.Xml
Public Class Funcionario
#Region "Variable"
    Public strNombreFun As String
    Public intIdentificacionFun As Integer
    Public strPrimerApellidoFun As String
    Public strSegundoApellidoFun As String
    Public strClave As String
    Public strUsuario As String
    Public blnEstado As Boolean
#End Region
#Region "Propiedades"
    Public Property Nombre() As String
        Get
            Return strNombreFun

        End Get
        Set(ByVal value As String)
            strNombreFun = value
        End Set
    End Property

    Public Property identificacion As Integer
        Get
            Return intIdentificacionFun
        End Get
        Set(ByVal value As Integer)
            intIdentificacionFun = value
        End Set
    End Property

    Public Property PrimerApellido() As String
        Get
            Return strPrimerApellidoFun

        End Get
        Set(ByVal value As String)
            strPrimerApellidoFun = value
        End Set
    End Property

    Public Property SegundoApellido() As String
        Get
            Return strSegundoApellidoFun

        End Get
        Set(ByVal value As String)
            strSegundoApellidoFun = value
        End Set
    End Property

    Public Property Clave() As String
        Get
            Return strClave

        End Get
        Set(ByVal value As String)
            strClave = value
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Return strUsuario
        End Get
        Set(ByVal value As String)
            strUsuario = value
        End Set
    End Property

    Public Property EstadoFuncionario As Boolean
        Get
            Return blnEstado
        End Get
        Set(value As Boolean)
            blnEstado = value
        End Set
    End Property
#End Region

#Region "Metodo registrar en xml"
    Public Sub RegistrarFuncionario(ByVal rutaArchivo As String)

        Dim mstnArchivo As New MemoryStream

        Dim xlmwFuncionario As New XmlTextWriter(mstnArchivo, System.Text.Encoding.UTF8)

        With xlmwFuncionario 'variable

            .Formatting = Formatting.Indented
            'crear documento
            .WriteStartDocument()

            'agregar la informacion del funcionario
            .WriteStartElement("Funcionarios")

            'agregar el nodo Funcionario---------------------------------
            .WriteStartElement("Funcionario")

            'agregar la informacion del  ID
            .WriteStartElement("ID")
            .WriteString(Me.intIdentificacionFun)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion del  nombre
            .WriteStartElement("Nombre")
            .WriteString(Me.strNombreFun)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion del  primer apellido
            .WriteStartElement("Apellido1")
            .WriteString(Me.strPrimerApellidoFun)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion del  segundo apellido
            .WriteStartElement("Apellido2")
            .WriteString(Me.strSegundoApellidoFun)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion de la clave
            .WriteStartElement("Clave")
            .WriteString(Me.strClave)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion del  usuario
            .WriteStartElement("Usuario")
            .WriteString(Me.strUsuario)
            .WriteEndElement()
            '--------------------------------------
            'agregar la informacion del  estado
            .WriteStartElement("Estado")
            .WriteString(Me.blnEstado)
            .WriteEndElement()
            '--------------------------------------------------------------------
            .WriteEndElement() 'fin nodo Funcionario-------- solo un end por nodo
            'cierra la informacion del nodo raiz funcionario
            .WriteEndElement()
            'finaliza documento
            .WriteEndDocument()
        End With
        '------------------------------------------------------------------------
        xlmwFuncionario.Flush()
        Dim xmlArchivo As New Datos.ArchivosXml 'escribir en el archivo
        xmlArchivo.Grabar(mstnArchivo, "C:\SistemaMatricula\Funcionarios\" + Me.strUsuario + ".xml")
        xlmwFuncionario.Close() 'cerrar el archivo
    End Sub
#End Region

#Region "Funcion para leer los datos en xml"
    Public Function LeerFuncionario(rutaArchivo As String) As Funcionario

        Dim iXmlFile As New Datos.ArchivosXml
        Dim xmlArchivo As XmlDocument = iXmlFile.leer(rutaArchivo)
        Dim lstNodeXMl As XmlNodeList = xmlArchivo.GetElementsByTagName("Funcionarios/Funcionario")

        Dim iFuncionario As New Funcionario
        For Each xmlNode As XmlNode In lstNodeXMl

            With iFuncionario
                .intIdentificacionFun = xmlNode("ID").InnerText
                .strNombreFun = xmlNode("Nombre").InnerText
                .strPrimerApellidoFun = xmlNode("Primer Apellido").InnerText
                .strSegundoApellidoFun = xmlNode("Segundo Apellido").InnerText
                .strClave = xmlNode("Clave").InnerText
                .strUsuario = xmlNode("Usuario").InnerText
                .blnEstado = xmlNode("Estado").InnerText
            End With


        Next

        Return iFuncionario
    End Function
#End Region

End Class

