Public Class FrmPantall_Principal


    Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click

    End Sub

    Private Sub FuncionarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionarioToolStripMenuItem.Click


    End Sub


    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        'opcion para salir del menu principal
        Me.Close()



    End Sub


    Private Sub EstudiantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstudiantesToolStripMenuItem.Click
        'opcion para registar estudiantes del menu principal

    End Sub

    Private Sub AcercaDeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem1.Click
        'opcion para Acerca de del menu principal
        Try
            Dim frmpantalla As New FrmAcercaDe With {
                .MdiParent = Me
                }
            frmpantalla.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CarrerasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarrerasToolStripMenuItem.Click
        'opcion para carreras del menu principal
        Try
            Dim frmpantalla As New FrmCarreras With {
                .MdiParent = Me
                }
            frmpantalla.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AgregarCursosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarCursosToolStripMenuItem.Click
        'opcion para agregar cursos del menu principal
        Try
            Dim frmpantalla As New FrmCarreras With {
                .MdiParent = Me
                }
            frmpantalla.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub VerCursosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerCursosToolStripMenuItem.Click
        'opcion para agregar cursos del menu principal
        Try
            Dim frmpantalla As New FrmVerCursos With {
                .MdiParent = Me
                }
            frmpantalla.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RegistrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem1.Click
        Try
            Dim frmpantalla As New FrmRegistrarEstudiantes With {
                .MdiParent = Me
                }
            frmpantalla.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub VerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerToolStripMenuItem.Click
        Try
            Dim frmpantalla As New FrmRegistrarEstudiantes With {
                .MdiParent = Me
                }
            frmpantalla.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RegistrarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem2.Click
        'opcion para agregar funcionario del menu principal
        Try
            Dim frmpantalla As New FrmRegistrarFuncionario With {
                .MdiParent = Me
                }
            frmpantalla.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub VerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerToolStripMenuItem1.Click
        'opcion para agregar funcionario del menu principal
        Try
            Dim frmpantalla As New FrmRegistrarFuncionario With {
                .MdiParent = Me
                }
            frmpantalla.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class