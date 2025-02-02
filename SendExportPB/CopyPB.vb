Imports System.ComponentModel

Public Class CopyPB
    Private Sub search_folder_copy_Click(sender As Object, e As EventArgs) Handles search_folder_copy.Click

        Dim folder_copy = New FolderBrowserDialog()
        folder_copy.SelectedPath = Application.StartupPath
        If DialogResult.OK = folder_copy.ShowDialog() Then
            path_local_copy.Text = folder_copy.SelectedPath
        End If

    End Sub

    Private Sub search_folder_paste_Click(sender As Object, e As EventArgs) Handles search_folder_paste.Click
        'Define as propriedades do controle FolderBrowserDialog

        Dim folder_paste = New FolderBrowserDialog()
        folder_paste.SelectedPath = Application.StartupPath
        If DialogResult.OK = folder_paste.ShowDialog() Then
            path_local_paste.Text = folder_paste.SelectedPath
        End If

    End Sub

    Private Sub bt_transf_Click(sender As Object, e As EventArgs) Handles bt_transf.Click

        ' ----- Inicia o processo em segundo plano
        bt_transf.Enabled = False
        bt_stop_transf.Enabled = True
        estado_operacao.Text = "Em Progresso…"
        estado_operacao.Visible = True
        progesso_copy.Value = 0
        progesso_copy.Visible = True
        copy_process.RunWorkerAsync()
        My.Computer.FileSystem.CopyDirectory(path_local_copy.Text, path_local_paste.Text, True)
        MessageBox.Show("Cópia Finalizada com Sucesso", "Cópia Finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub copy_process_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles copy_process.ProgressChanged
        ' ----- A tarefa em segundo plano atualiza a barra de progresso
        progesso_copy.Value = e.ProgressPercentage
        perc_copy_complete.Text = e.ProgressPercentage '%'
    End Sub

    Private Sub copy_process_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles copy_process.RunWorkerCompleted
        ' ----- Termina.
        If (e.Cancelled = True) Then
            estado_operacao.Text = "Operação Cancelada!!"
        Else
            estado_operacao.Text = "Operação Completa!!"
            perc_copy_complete.Visible = False
        End If

        progesso_copy.Visible = False
        progesso_copy.Value = 0
        bt_stop_transf.Enabled = False
        bt_transf.Enabled = True

    End Sub

    Private Sub copy_process_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles copy_process.DoWork
        ' ----- O trabalho em segundo plano (background) começa aqui
        Dim segundoPlano As BackgroundWorker

        ' ----- Chama a thread em segundo plano (background)
        segundoPlano = CType(sender, BackgroundWorker)
        executaTrabalho(segundoPlano)

        ' ----- Verifica cancelamento
        If (segundoPlano.CancellationPending = True) Then e.Cancel = True
    End Sub

    Private Sub bt_stop_transf_Click(sender As Object, e As EventArgs) Handles bt_stop_transf.Click
        copy_process.CancelAsync()
    End Sub

    Private Sub executaTrabalho(ByVal processoAtivo As BackgroundWorker)
        ' ----- Realiza algum trabalho
        For contador As Integer = 1 To 10
            ' ----- Verifica se vai sair agora
            If (processoAtivo.CancellationPending = True) Then _
               Exit For
            ' ----- Aguarde por 1 segundos.
            Threading.Thread.Sleep(1000)
            ' ----- Informa a thread principal que temos feitos alterações
            processoAtivo.ReportProgress(contador * 10)
        Next contador
    End Sub
End Class
