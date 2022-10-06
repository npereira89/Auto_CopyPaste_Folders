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

        My.Computer.FileSystem.CopyDirectory(path_local_copy.Text, path_local_paste.Text, True)

    End Sub
End Class
