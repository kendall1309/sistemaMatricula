Imports System.IO
Imports System.Net.Security
Imports System.Xml

Public Class ArchivosXml
    ''Guardar los datos en Xml
    Public Sub Grabar(archivo As MemoryStream, Ruta_archivos As String)
        Dim FileXMl As FileStream = New FileStream(Ruta_archivos, FileMode.Create, FileAccess.Write)
        archivo.WriteTo(FileXMl)
        FileXMl.Close()
        archivo.Close()
    End Sub

    ''Lee los datos de los archivos del Xml
    Public Function leer(Ruta_Archivo As String) As XmlDocument
        Dim xmlArchivo As New XmlDocument
        xmlArchivo.Load(Ruta_Archivo)
        Return xmlArchivo
    End Function

End Class
