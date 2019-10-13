Imports System.Runtime.InteropServices
Public Class Clientes
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Me.Close()
    End Sub

    Private Sub btn_maximizar_Click(sender As Object, e As EventArgs) Handles btn_maximizar.Click
        btn_maximizar.Visible = False
        btn_restaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub btn_restaurar_Click(sender As Object, e As EventArgs) Handles btn_restaurar.Click
        btn_restaurar.Visible = False
        btn_maximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btn_Minimizar_Click(sender As Object, e As EventArgs) Handles btn_Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub panel_cabecalho_MouseMove(sender As Object, e As MouseEventArgs) Handles panel_cabecalho.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub tm_ocultar_menu_Tick(sender As Object, e As EventArgs) Handles tm_ocultar_menu.Tick
        If Panel_menu.Width <= 60 Then
            Me.tm_ocultar_menu.Enabled = False
        Else
            Me.Panel_menu.Width = Panel_menu.Width - 20
        End If
    End Sub

    Private Sub tm_mostrar_menu_Tick(sender As Object, e As EventArgs) Handles tm_mostrar_menu.Tick
        If Panel_menu.Width >= 220 Then
            Me.tm_mostrar_menu.Enabled = False
        Else
            Me.Panel_menu.Width = Panel_menu.Width + 20
        End If
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        If Panel_menu.Width = 220 Then
            tm_ocultar_menu.Enabled = True
        ElseIf Panel_menu.Width = 60 Then
            tm_mostrar_menu.Enabled = True
        End If
    End Sub

    Private Sub AbrirFormNoPanel(ByVal Formhijo As Object)
        If Me.Panel_conteudo.Controls.Count > 0 Then
            Me.Panel_conteudo.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.Panel_conteudo.Controls.Add(fh)
        Me.Panel_conteudo.Tag = fh
        fh.Show()
    End Sub

    Private Sub btn_dashboard_Click(sender As Object, e As EventArgs) Handles btn_dashboard.Click
        AbrirFormNoPanel(New Dashboard)
    End Sub

    Private Sub btn_produtos_Click(sender As Object, e As EventArgs) Handles btn_produtos.Click
        AbrirFormNoPanel(New Produtos)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AbrirFormNoPanel(New cliente)
    End Sub
End Class