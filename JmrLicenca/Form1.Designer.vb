<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnGerarLicenca = New System.Windows.Forms.Button()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboSistemaDestino = New System.Windows.Forms.ComboBox()
        Me.cboDuracaoLicenca = New System.Windows.Forms.ComboBox()
        Me.txtUtilizadoresNumero = New System.Windows.Forms.TextBox()
        Me.txtLicencaSerie = New System.Windows.Forms.RichTextBox()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.txtClienteNuit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblErroMsg = New System.Windows.Forms.Label()
        Me.txtDuracaoAtivacao = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboClienteCodigo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtClienteNome = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtClienteMorada = New System.Windows.Forms.TextBox()
        Me.cboClienteFilial = New System.Windows.Forms.ComboBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(433, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 23)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "&Duração licença"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnFechar
        '
        Me.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFechar.Location = New System.Drawing.Point(658, 264)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(94, 23)
        Me.btnFechar.TabIndex = 25
        Me.btnFechar.Text = "&Fechar"
        '
        'btnGerarLicenca
        '
        Me.btnGerarLicenca.Location = New System.Drawing.Point(556, 264)
        Me.btnGerarLicenca.Name = "btnGerarLicenca"
        Me.btnGerarLicenca.Size = New System.Drawing.Size(94, 23)
        Me.btnGerarLicenca.TabIndex = 24
        Me.btnGerarLicenca.Text = "&Gerar Licença"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(173, 8)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(103, 23)
        Me.PasswordLabel.TabIndex = 23
        Me.PasswordLabel.Text = "&Numero Utilizadores"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(173, 303)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 21
        Me.UsernameLabel.Text = "&Licença Gerado"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(2, 4)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 404)
        Me.LogoPictureBox.TabIndex = 22
        Me.LogoPictureBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(323, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Sistema Destino"
        '
        'cboSistemaDestino
        '
        Me.cboSistemaDestino.FormattingEnabled = True
        Me.cboSistemaDestino.Items.AddRange(New Object() {"Selecionar", "PriConferenciaCaixa", "PriWebshop"})
        Me.cboSistemaDestino.Location = New System.Drawing.Point(326, 34)
        Me.cboSistemaDestino.Name = "cboSistemaDestino"
        Me.cboSistemaDestino.Size = New System.Drawing.Size(263, 21)
        Me.cboSistemaDestino.TabIndex = 40
        '
        'cboDuracaoLicenca
        '
        Me.cboDuracaoLicenca.FormattingEnabled = True
        Me.cboDuracaoLicenca.Items.AddRange(New Object() {"Selecionar ", "1 Mês", "3 Meses", "6 Meses", "1 Ano"})
        Me.cboDuracaoLicenca.Location = New System.Drawing.Point(433, 192)
        Me.cboDuracaoLicenca.Name = "cboDuracaoLicenca"
        Me.cboDuracaoLicenca.Size = New System.Drawing.Size(217, 21)
        Me.cboDuracaoLicenca.TabIndex = 41
        '
        'txtUtilizadoresNumero
        '
        Me.txtUtilizadoresNumero.Location = New System.Drawing.Point(176, 35)
        Me.txtUtilizadoresNumero.Name = "txtUtilizadoresNumero"
        Me.txtUtilizadoresNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtUtilizadoresNumero.TabIndex = 42
        '
        'txtLicencaSerie
        '
        Me.txtLicencaSerie.Enabled = False
        Me.txtLicencaSerie.Location = New System.Drawing.Point(173, 329)
        Me.txtLicencaSerie.Name = "txtLicencaSerie"
        Me.txtLicencaSerie.Size = New System.Drawing.Size(517, 79)
        Me.txtLicencaSerie.TabIndex = 43
        Me.txtLicencaSerie.Text = ""
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(701, 329)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(57, 23)
        Me.btnCopy.TabIndex = 44
        Me.btnCopy.Text = "&Copiar"
        '
        'txtClienteNuit
        '
        Me.txtClienteNuit.Location = New System.Drawing.Point(411, 130)
        Me.txtClienteNuit.Name = "txtClienteNuit"
        Me.txtClienteNuit.Size = New System.Drawing.Size(140, 20)
        Me.txtClienteNuit.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(411, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Cliente Nuit"
        '
        'lblErroMsg
        '
        Me.lblErroMsg.AutoSize = True
        Me.lblErroMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErroMsg.ForeColor = System.Drawing.Color.Red
        Me.lblErroMsg.Location = New System.Drawing.Point(176, 238)
        Me.lblErroMsg.Name = "lblErroMsg"
        Me.lblErroMsg.Size = New System.Drawing.Size(471, 15)
        Me.lblErroMsg.TabIndex = 47
        Me.lblErroMsg.Text = "ATENÇÃO: Certique de que preencheu todos campos  ou Selecione opções correctas"
        Me.lblErroMsg.Visible = False
        '
        'txtDuracaoAtivacao
        '
        Me.txtDuracaoAtivacao.Location = New System.Drawing.Point(656, 193)
        Me.txtDuracaoAtivacao.Name = "txtDuracaoAtivacao"
        Me.txtDuracaoAtivacao.Size = New System.Drawing.Size(96, 20)
        Me.txtDuracaoAtivacao.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(654, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Duração activação"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(176, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Cliente Codigo"
        '
        'cboClienteCodigo
        '
        Me.cboClienteCodigo.FormattingEnabled = True
        Me.cboClienteCodigo.Location = New System.Drawing.Point(179, 79)
        Me.cboClienteCodigo.Name = "cboClienteCodigo"
        Me.cboClienteCodigo.Size = New System.Drawing.Size(217, 21)
        Me.cboClienteCodigo.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(411, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Cliente Nome"
        '
        'txtClienteNome
        '
        Me.txtClienteNome.Location = New System.Drawing.Point(411, 80)
        Me.txtClienteNome.Name = "txtClienteNome"
        Me.txtClienteNome.Size = New System.Drawing.Size(341, 20)
        Me.txtClienteNome.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(176, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Cliente Morada"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(176, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Cliente Filial"
        '
        'txtClienteMorada
        '
        Me.txtClienteMorada.Location = New System.Drawing.Point(179, 192)
        Me.txtClienteMorada.Name = "txtClienteMorada"
        Me.txtClienteMorada.Size = New System.Drawing.Size(248, 20)
        Me.txtClienteMorada.TabIndex = 57
        '
        'cboClienteFilial
        '
        Me.cboClienteFilial.FormattingEnabled = True
        Me.cboClienteFilial.Items.AddRange(New Object() {"Selecionar ", "1 Mês", "3 Meses", "6 Meses", "1 Ano"})
        Me.cboClienteFilial.Location = New System.Drawing.Point(179, 129)
        Me.cboClienteFilial.Name = "cboClienteFilial"
        Me.cboClienteFilial.Size = New System.Drawing.Size(217, 21)
        Me.cboClienteFilial.TabIndex = 59
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 434)
        Me.Controls.Add(Me.cboClienteFilial)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtClienteMorada)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtClienteNome)
        Me.Controls.Add(Me.cboClienteCodigo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDuracaoAtivacao)
        Me.Controls.Add(Me.lblErroMsg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtClienteNuit)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.txtLicencaSerie)
        Me.Controls.Add(Me.txtUtilizadoresNumero)
        Me.Controls.Add(Me.cboDuracaoLicenca)
        Me.Controls.Add(Me.cboSistemaDestino)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnGerarLicenca)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Name = "Form1"
        Me.Text = "jmr gerador de licença"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnGerarLicenca As Button
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboSistemaDestino As ComboBox
    Friend WithEvents cboDuracaoLicenca As ComboBox
    Friend WithEvents txtUtilizadoresNumero As TextBox
    Friend WithEvents txtLicencaSerie As RichTextBox
    Friend WithEvents btnCopy As Button
    Friend WithEvents txtClienteNuit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblErroMsg As Label
    Friend WithEvents txtDuracaoAtivacao As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboClienteCodigo As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtClienteNome As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtClienteMorada As TextBox
    Friend WithEvents cboClienteFilial As ComboBox
End Class
