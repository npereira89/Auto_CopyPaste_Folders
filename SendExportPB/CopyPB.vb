Public Class CopyPB
    Private Sub search_folder_copy_Click(sender As Object, e As EventArgs)
        'Define as propriedades do controle FolderBrowserDialog
        folder_copy.Description = "Selecione o projeto PB a copiar"
        folder_copy.RootFolder = Environment.SpecialFolder.MyComputer
        folder_copy.ShowNewFolderButton = True

        'Exibe a caixa de diálogo
        If folder_copy.ShowDialog = Windows.Forms.DialogResult.OK Then

            'Exibe a pasta selecionada
            path_local_copy.Text = folder_copy.SelectedPath

        End If
    End Sub

    Private Sub search_folder_paste_Click(sender As Object, e As EventArgs)
        'Define as propriedades do controle FolderBrowserDialog

        folder_paste.ShowDialog()
        folder_paste.Description = "Selecione uma pasta para realizar o Backup"
        folder_paste.RootFolder = Environment.SpecialFolder.MyComputer
        folder_paste.ShowNewFolderButton = True

        'Exibe a caixa de diálogo
        If folder_paste.ShowDialog = Windows.Forms.DialogResult.OK Then

            'Exibe a pasta selecionada
            path_local_paste.Text = folder_copy.SelectedPath

        End If
    End Sub

    Private Sub bt_transf_Click(sender As Object, e As EventArgs)
        My.Computer.FileSystem.CopyDirectory(path_local_copy.Text, path_local_paste.Text, True)
    End Sub
End Class
