<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_login))
        Me.tb_user = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_pass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_info = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_user
        '
        Me.tb_user.Location = New System.Drawing.Point(188, 91)
        Me.tb_user.Name = "tb_user"
        Me.tb_user.Size = New System.Drawing.Size(168, 27)
        Me.tb_user.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Goldenrod
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(219, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 44)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "User Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(100, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password:"
        '
        'tb_pass
        '
        Me.tb_pass.Location = New System.Drawing.Point(188, 141)
        Me.tb_pass.Name = "tb_pass"
        Me.tb_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_pass.Size = New System.Drawing.Size(168, 27)
        Me.tb_pass.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ainda não tens conta ?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label5.Location = New System.Drawing.Point(215, 319)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "SignUp"
        '
        'lbl_info
        '
        Me.lbl_info.AutoSize = True
        Me.lbl_info.Location = New System.Drawing.Point(14, 276)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(0, 21)
        Me.lbl_info.TabIndex = 10
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Sistema_Projeto.My.Resources.Resources._6f00edc3_1f38_455c_abf5_fb59e0543a65_200x200
        Me.PictureBox3.Location = New System.Drawing.Point(-109, -30)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(398, 165)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(661, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.Sistema_Projeto.My.Resources.Resources.pfs_login
        Me.PictureBox1.Location = New System.Drawing.Point(342, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(356, 349)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'F_login
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(698, 349)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_pass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_user)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lbl_info)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "F_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tb_user As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_pass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbl_info As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
