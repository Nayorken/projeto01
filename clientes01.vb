Public Class clientes01
    Private Sub clientes01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'ProjecttDataSet.clientes'. Você pode movê-la ou removê-la conforme necessário.
        Me.ClientesTableAdapter.Fill(Me.ProjecttDataSet.clientes)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ClientesTableAdapter.Insert(txt_nome.Text, txt_morada.Text, txt_pais.Text, txt_cidade.Text, txt_email.Text, txt_telemovel.Text)
        Me.ClientesTableAdapter.Update(ProjecttDataSet.clientes)
        MessageBox.Show("Registrado com sucesso!")
        Me.ClientesTableAdapter.Fill(Me.ProjecttDataSet.clientes)
    End Sub
End Class