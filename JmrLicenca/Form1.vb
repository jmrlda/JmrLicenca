Imports System.Text.RegularExpressions

Public Class Form1
    Dim licenca As New LicencaCrypt

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGerarLicenca_Click(sender As Object, e As EventArgs) Handles btnGerarLicenca.Click
        ' Adicionar cliente ou numero de cliente 

        If Me.txtClienteNuit.Text.Trim(" ").Length > 0 And Me.txtUtilizadoresNumero.Text.Trim(" ").Length > 0 And
            Me.cboDuracaoLicenca.SelectedIndex > 0 And cboSistemaDestino.SelectedIndex > 0 And Me.txtDuracaoAtivacao.Text.Trim(" ").Length > 0 And
            Me.txtClienteMorada.Text.Trim(" ").Length > 0 And Me.txtClienteNome.Text.Trim(" ").Length > 0 And Me.cboClienteCodigo.Text().Trim(" ").Length > 0 And
            cboClienteFilial.Text.Trim(" ").Length > 0 Then

            Dim dataInic As String = Date.Now().ToShortDateString()
            Dim encode_serie As String = Me.txtUtilizadoresNumero.Text + "_" + Me.cboSistemaDestino.Text + "_" + Me.cboDuracaoLicenca.Text + "_" + Me.txtClienteNuit.Text + "_" + dataInic + "_" + Me.txtDuracaoAtivacao.Text + "_" + Me.cboClienteCodigo.Text + "_" + Me.txtClienteNome.Text + "_" + Me.txtClienteMorada.Text + "_" + Me.cboClienteFilial.Text
            Dim decode_serie As String() = encode_serie.Split("_")

            Me.txtLicencaSerie.Text = licenca.Encrypt(encode_serie)
            licenca.criarFicheiro(licenca.Encrypt(encode_serie))
            Me.lblErroMsg.Visible = False

        Else
            Me.lblErroMsg.Visible = True
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.txtLicencaSerie.Text = licenca.Decrypt(licenca.lerFicheiro("jmrLicenca.lic"))

        Me.cboSistemaDestino.SelectedIndex = 0
        Me.cboDuracaoLicenca.SelectedIndex = 0

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Clipboard.Clear()
        Clipboard.SetText(Me.txtLicencaSerie.Text)
        'txtLicencaSerie.Text
    End Sub

    Private Sub txtUtilizadoresNumero_TextChanged(sender As Object, e As EventArgs) Handles txtUtilizadoresNumero.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtUtilizadoresNumero.Text = digitsOnly.Replace(txtUtilizadoresNumero.Text, "")
    End Sub

    Private Sub txtClienteNuit_TextChanged(sender As Object, e As EventArgs) Handles txtClienteNuit.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtClienteNuit.Text = digitsOnly.Replace(txtClienteNuit.Text, "")
    End Sub

    Private Sub txtDuracaoAtivacao_TextChanged(sender As Object, e As EventArgs) Handles txtDuracaoAtivacao.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtDuracaoAtivacao.Text = digitsOnly.Replace(txtDuracaoAtivacao.Text, "")
    End Sub

    Private Sub cboSistemaDestino_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboSistemaDestino.KeyPress
        e.Handled = True

    End Sub

    Private Sub cboDuracaoLicenca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboDuracaoLicenca.KeyPress
        e.Handled = True

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
