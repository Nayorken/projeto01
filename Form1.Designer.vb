<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.panel_cabecalho = New System.Windows.Forms.Panel()
        Me.Panel_menu = New System.Windows.Forms.Panel()
        Me.Panel_conteudo = New System.Windows.Forms.Panel()
        Me.tm_ocultar_menu = New System.Windows.Forms.Timer(Me.components)
        Me.tm_mostrar_menu = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_produtos = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_dashboard = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_menu = New System.Windows.Forms.PictureBox()
        Me.btn_restaurar = New System.Windows.Forms.Button()
        Me.btn_Minimizar = New System.Windows.Forms.Button()
        Me.btn_maximizar = New System.Windows.Forms.Button()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.panel_cabecalho.SuspendLayout()
        Me.Panel_menu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_cabecalho
        '
        Me.panel_cabecalho.BackColor = System.Drawing.Color.Goldenrod
        Me.panel_cabecalho.Controls.Add(Me.btn_restaurar)
        Me.panel_cabecalho.Controls.Add(Me.btn_Minimizar)
        Me.panel_cabecalho.Controls.Add(Me.btn_maximizar)
        Me.panel_cabecalho.Controls.Add(Me.btn_fechar)
        Me.panel_cabecalho.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_cabecalho.Location = New System.Drawing.Point(0, 0)
        Me.panel_cabecalho.Name = "panel_cabecalho"
        Me.panel_cabecalho.Size = New System.Drawing.Size(1084, 40)
        Me.panel_cabecalho.TabIndex = 0
        '
        'Panel_menu
        '
        Me.Panel_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel_menu.Controls.Add(Me.Panel6)
        Me.Panel_menu.Controls.Add(Me.btn_produtos)
        Me.Panel_menu.Controls.Add(Me.Panel5)
        Me.Panel_menu.Controls.Add(Me.Button5)
        Me.Panel_menu.Controls.Add(Me.Panel4)
        Me.Panel_menu.Controls.Add(Me.Button4)
        Me.Panel_menu.Controls.Add(Me.Panel3)
        Me.Panel_menu.Controls.Add(Me.Button3)
        Me.Panel_menu.Controls.Add(Me.Panel2)
        Me.Panel_menu.Controls.Add(Me.Button2)
        Me.Panel_menu.Controls.Add(Me.Panel1)
        Me.Panel_menu.Controls.Add(Me.btn_dashboard)
        Me.Panel_menu.Controls.Add(Me.PictureBox1)
        Me.Panel_menu.Controls.Add(Me.btn_menu)
        Me.Panel_menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_menu.Location = New System.Drawing.Point(0, 40)
        Me.Panel_menu.Name = "Panel_menu"
        Me.Panel_menu.Size = New System.Drawing.Size(220, 501)
        Me.Panel_menu.TabIndex = 1
        '
        'Panel_conteudo
        '
        Me.Panel_conteudo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_conteudo.Location = New System.Drawing.Point(220, 40)
        Me.Panel_conteudo.Name = "Panel_conteudo"
        Me.Panel_conteudo.Size = New System.Drawing.Size(864, 501)
        Me.Panel_conteudo.TabIndex = 2
        '
        'tm_ocultar_menu
        '
        '
        'tm_mostrar_menu
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel1.Location = New System.Drawing.Point(0, 158)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 50)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel2.Location = New System.Drawing.Point(0, 270)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 50)
        Me.Panel2.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel3.Location = New System.Drawing.Point(0, 326)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 50)
        Me.Panel3.TabIndex = 11
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel5.Location = New System.Drawing.Point(0, 438)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 50)
        Me.Panel5.TabIndex = 15
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel6.Location = New System.Drawing.Point(0, 214)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 50)
        Me.Panel6.TabIndex = 17
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel4.Location = New System.Drawing.Point(0, 382)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 50)
        Me.Panel4.TabIndex = 13
        '
        'btn_produtos
        '
        Me.btn_produtos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_produtos.FlatAppearance.BorderSize = 0
        Me.btn_produtos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btn_produtos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_produtos.ForeColor = System.Drawing.Color.White
        Me.btn_produtos.Image = Global.Sistema_Projeto.My.Resources.Resources.producto
        Me.btn_produtos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_produtos.Location = New System.Drawing.Point(0, 214)
        Me.btn_produtos.Name = "btn_produtos"
        Me.btn_produtos.Size = New System.Drawing.Size(220, 50)
        Me.btn_produtos.TabIndex = 16
        Me.btn_produtos.Text = "  Produtos"
        Me.btn_produtos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_produtos.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Image = Global.Sistema_Projeto.My.Resources.Resources.empleados
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(0, 438)
        Me.Button5.Name = "Button5"
        Me.Button5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button5.Size = New System.Drawing.Size(220, 50)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "  Utilizadores"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.Sistema_Projeto.My.Resources.Resources.compras
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(0, 382)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(220, 50)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "  Compras"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.Sistema_Projeto.My.Resources.Resources.clientes
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 326)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(220, 50)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "  Clientes"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.Sistema_Projeto.My.Resources.Resources.venta
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(3, 270)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(220, 50)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "  Vendas"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_dashboard
        '
        Me.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_dashboard.FlatAppearance.BorderSize = 0
        Me.btn_dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btn_dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dashboard.ForeColor = System.Drawing.Color.White
        Me.btn_dashboard.Image = Global.Sistema_Projeto.My.Resources.Resources.reportes
        Me.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dashboard.Location = New System.Drawing.Point(0, 158)
        Me.btn_dashboard.Name = "btn_dashboard"
        Me.btn_dashboard.Size = New System.Drawing.Size(220, 50)
        Me.btn_dashboard.TabIndex = 6
        Me.btn_dashboard.Text = "  Dashboard"
        Me.btn_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_dashboard.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistema_Projeto.My.Resources.Resources.LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(3, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(238, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btn_menu
        '
        Me.btn_menu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_menu.Image = Global.Sistema_Projeto.My.Resources.Resources.Mobile_Menu_Icon
        Me.btn_menu.Location = New System.Drawing.Point(170, 2)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(49, 33)
        Me.btn_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_menu.TabIndex = 4
        Me.btn_menu.TabStop = False
        '
        'btn_restaurar
        '
        Me.btn_restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_restaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_restaurar.FlatAppearance.BorderSize = 0
        Me.btn_restaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_restaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btn_restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_restaurar.Image = Global.Sistema_Projeto.My.Resources.Resources.Icono_Restaurar
        Me.btn_restaurar.Location = New System.Drawing.Point(998, 0)
        Me.btn_restaurar.Name = "btn_restaurar"
        Me.btn_restaurar.Size = New System.Drawing.Size(40, 40)
        Me.btn_restaurar.TabIndex = 3
        Me.btn_restaurar.UseVisualStyleBackColor = True
        Me.btn_restaurar.Visible = False
        '
        'btn_Minimizar
        '
        Me.btn_Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Minimizar.FlatAppearance.BorderSize = 0
        Me.btn_Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Minimizar.Image = Global.Sistema_Projeto.My.Resources.Resources.Icono_Minimizar
        Me.btn_Minimizar.Location = New System.Drawing.Point(952, 0)
        Me.btn_Minimizar.Name = "btn_Minimizar"
        Me.btn_Minimizar.Size = New System.Drawing.Size(40, 40)
        Me.btn_Minimizar.TabIndex = 2
        Me.btn_Minimizar.UseVisualStyleBackColor = True
        '
        'btn_maximizar
        '
        Me.btn_maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_maximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_maximizar.FlatAppearance.BorderSize = 0
        Me.btn_maximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_maximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btn_maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_maximizar.Image = Global.Sistema_Projeto.My.Resources.Resources.Icono_Maximizar
        Me.btn_maximizar.Location = New System.Drawing.Point(998, 0)
        Me.btn_maximizar.Name = "btn_maximizar"
        Me.btn_maximizar.Size = New System.Drawing.Size(40, 40)
        Me.btn_maximizar.TabIndex = 1
        Me.btn_maximizar.UseVisualStyleBackColor = True
        '
        'btn_fechar
        '
        Me.btn_fechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_fechar.FlatAppearance.BorderSize = 0
        Me.btn_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fechar.Image = Global.Sistema_Projeto.My.Resources.Resources.Icono_cerrar_FN
        Me.btn_fechar.Location = New System.Drawing.Point(1044, 0)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(40, 40)
        Me.btn_fechar.TabIndex = 0
        Me.btn_fechar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 541)
        Me.Controls.Add(Me.Panel_conteudo)
        Me.Controls.Add(Me.Panel_menu)
        Me.Controls.Add(Me.panel_cabecalho)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panel_cabecalho.ResumeLayout(False)
        Me.Panel_menu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_cabecalho As Panel
    Friend WithEvents Panel_menu As Panel
    Friend WithEvents btn_fechar As Button
    Friend WithEvents Panel_conteudo As Panel
    Friend WithEvents btn_maximizar As Button
    Friend WithEvents btn_Minimizar As Button
    Friend WithEvents btn_restaurar As Button
    Friend WithEvents btn_menu As PictureBox
    Friend WithEvents tm_ocultar_menu As Timer
    Friend WithEvents tm_mostrar_menu As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_dashboard As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btn_produtos As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
End Class
