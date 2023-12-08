Public Class WEBHERE
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WebfavoritosTableAdapter.Fill(Me.DatawebDataSet.webfavoritos)
        ComboBox1.Focus()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form2.Show()
    End Sub
    Private Sub SToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SToolStripMenuItem3.Click
        'navegar
        WebBrowser1.Stop()
        Application.Exit()
    End Sub

    Private Sub AvançarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvançarToolStripMenuItem.Click
        'voltar
        WebBrowser1.GoBack()
    End Sub

    Private Sub AvaçarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvaçarToolStripMenuItem.Click
        'avançar
        WebBrowser1.GoForward()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        'atualizar
        WebBrowser1.Refresh()
    End Sub

    Private Sub SToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SToolStripMenuItem1.Click
        'inicio
        WebBrowser1.GoHome()
        WebBrowser1.Navigate("https://www.google.com.br/" & ComboBox1.Text)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'direcionar pagina
        WebBrowser1.Navigate(ComboBox1.Text)
    End Sub

    Private Sub SToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SToolStripMenuItem.Click
        WebBrowser1.Navigate(ComboBox1.Text)
    End Sub

    Private Sub SToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SToolStripMenuItem2.Click
        If ComboBox1.Text <> "" Then

            Me.Validate()
            Me.WebfavoritosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DatawebDataSet)
            MsgBox("Salvo Com Susseso", MsgBoxStyle.Information)
        Else
            MsgBox("Digite Um Sat")
        End If
    End Sub

    Private Sub ComboBox1_KeyUp_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                WebBrowser1.Navigate(ComboBox1.Text)
            Case Keys.F1
                Form2.Show()
            Case Keys.F2
                If ComboBox1.Text <> "" Then
                    Me.WebfavoritosBindingSource.RemoveCurrent()
                Else
                    MsgBox("Selecione um sat", MsgBoxStyle.Information)
                End If
        End Select
    End Sub
End Class

 