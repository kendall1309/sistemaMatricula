Imports Datos

Public Class FrmRegistrarEstudiantes
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles LblApellidosEstudiante.Click

    End Sub

    Private Sub TxTDireccionExactaEstudiante_TextChanged(sender As Object, e As EventArgs) Handles TxTDireccionExactaEstudiante.TextChanged

    End Sub

    Private Sub LblIdentificacionEstudiante_Click(sender As Object, e As EventArgs) Handles LblIdentificacionEstudiante.Click

    End Sub

    Private Sub TxtApellidosEstudiante_TextChanged(sender As Object, e As EventArgs) Handles TxtApellidosEstudiante.TextChanged

    End Sub

    Private Sub FrmRegistrarEstudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim frmEstudiantes As New Estudiante()
        Dim Nombre As String = Me.TxtNombreEstudiante.Text
        Dim Apellidos As String = Me.TxtApellidosEstudiante.Text
        Dim Identificacion As String = Me.TxtApellidosEstudiante.Text
        Dim Telefono As String = Me.TxtApellidosEstudiante.Text
        Dim CorreoElectronico As String = Me.TxtApellidosEstudiante.Text
        Dim Dirrecion As String = Me.TxtApellidosEstudiante.Text
        frmEstudiantes.RegistrarEstudiantes(Nombre, Apellidos, Identificacion, Telefono,
                                            CorreoElectronico, Dirrecion)
    End Sub
End Class