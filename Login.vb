Public Class F_login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tb_user.Text = "hugo ferreira" And tb_pass.Text = "teste123" Or tb_user.Text = "pbarca" And tb_pass.Text = "prof12" Or tb_user.Text = "admin" And tb_pass.Text = "admin" Then
            Clientes.Show()
        Else : MsgBox("Login e/ou senha incorretos", MsgBoxStyle.Critical, "Erro")
        End If
    End Sub
End Class
