Public Class FormLogin
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        FormEditar.Show()
        Me.Close()
    End Sub

    Private Sub BtnLeer_Click(sender As Object, e As EventArgs) Handles BtnLeer.Click
        FormLeer.Show()
        Me.Close()
    End Sub
End Class
