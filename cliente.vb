Public Class cliente
    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DataSet1.Clientes'. Você pode movê-la ou removê-la conforme necessário.
        Me.ClientesTableAdapter.Fill(Me.DataSet1.Clientes)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ClientesTableAdapter.Insert(txt_nome.Text, txt_telemovel.Text, txt_morada.Text, txt_email.Text)
        Me.ClientesTableAdapter.Update(DataSet1.Clientes)
        MessageBox.Show("Cliente registrado com sucesso!")
        Me.ClientesTableAdapter.Fill(Me.DataSet1.Clientes)
    End Sub
End Class