<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CopyPB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CopyPB))
        Me.to_copy = New System.Windows.Forms.Label()
        Me.to_transf = New System.Windows.Forms.Label()
        Me.bt_transf = New System.Windows.Forms.Button()
        Me.folder_copy = New System.Windows.Forms.FolderBrowserDialog()
        Me.folder_paste = New System.Windows.Forms.FolderBrowserDialog()
        Me.path_local_copy = New System.Windows.Forms.TextBox()
        Me.path_local_paste = New System.Windows.Forms.TextBox()
        Me.search_folder_copy = New System.Windows.Forms.Button()
        Me.search_folder_paste = New System.Windows.Forms.Button()
        Me.copy_process = New System.ComponentModel.BackgroundWorker()
        Me.perc_copy_complete = New System.Windows.Forms.Label()
        Me.bt_stop_transf = New System.Windows.Forms.Button()
        Me.progesso_copy = New System.Windows.Forms.ProgressBar()
        Me.estado_operacao = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'to_copy
        '
        Me.to_copy.AutoSize = True
        Me.to_copy.Location = New System.Drawing.Point(22, 22)
        Me.to_copy.Name = "to_copy"
        Me.to_copy.Size = New System.Drawing.Size(50, 15)
        Me.to_copy.TabIndex = 0
        Me.to_copy.Text = "To Copy"
        '
        'to_transf
        '
        Me.to_transf.AutoSize = True
        Me.to_transf.Location = New System.Drawing.Point(10, 51)
        Me.to_transf.Name = "to_transf"
        Me.to_transf.Size = New System.Drawing.Size(63, 15)
        Me.to_transf.TabIndex = 1
        Me.to_transf.Text = "To Transfer"
        '
        'bt_transf
        '
        Me.bt_transf.Location = New System.Drawing.Point(89, 180)
        Me.bt_transf.Name = "bt_transf"
        Me.bt_transf.Size = New System.Drawing.Size(61, 40)
        Me.bt_transf.TabIndex = 2
        Me.bt_transf.Text = "Inicia a cópia"
        Me.bt_transf.UseVisualStyleBackColor = True
        Me.bt_transf.UseWaitCursor = True
        '
        'folder_copy
        '
        Me.folder_copy.RootFolder = System.Environment.SpecialFolder.DesktopDirectory
        Me.folder_copy.SelectedPath = "C:\Users\3100945\Desktop"
        '
        'folder_paste
        '
        Me.folder_paste.Description = "ss"
        Me.folder_paste.RootFolder = System.Environment.SpecialFolder.CommonDesktopDirectory
        Me.folder_paste.SelectedPath = "C:\Users\3100945\Desktop"
        Me.folder_paste.UseDescriptionForTitle = True
        '
        'path_local_copy
        '
        Me.path_local_copy.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.path_local_copy.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.path_local_copy.Location = New System.Drawing.Point(74, 19)
        Me.path_local_copy.Name = "path_local_copy"
        Me.path_local_copy.ReadOnly = True
        Me.path_local_copy.Size = New System.Drawing.Size(218, 23)
        Me.path_local_copy.TabIndex = 3
        '
        'path_local_paste
        '
        Me.path_local_paste.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.path_local_paste.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.path_local_paste.Location = New System.Drawing.Point(74, 48)
        Me.path_local_paste.Name = "path_local_paste"
        Me.path_local_paste.ReadOnly = True
        Me.path_local_paste.Size = New System.Drawing.Size(218, 23)
        Me.path_local_paste.TabIndex = 4
        '
        'search_folder_copy
        '
        Me.search_folder_copy.Location = New System.Drawing.Point(298, 20)
        Me.search_folder_copy.Name = "search_folder_copy"
        Me.search_folder_copy.Size = New System.Drawing.Size(40, 22)
        Me.search_folder_copy.TabIndex = 5
        Me.search_folder_copy.Text = "..."
        Me.search_folder_copy.UseVisualStyleBackColor = True
        '
        'search_folder_paste
        '
        Me.search_folder_paste.Location = New System.Drawing.Point(298, 49)
        Me.search_folder_paste.Name = "search_folder_paste"
        Me.search_folder_paste.Size = New System.Drawing.Size(40, 22)
        Me.search_folder_paste.TabIndex = 6
        Me.search_folder_paste.Text = "..."
        Me.search_folder_paste.UseVisualStyleBackColor = True
        '
        'copy_process
        '
        Me.copy_process.WorkerReportsProgress = True
        Me.copy_process.WorkerSupportsCancellation = True
        '
        'perc_copy_complete
        '
        Me.perc_copy_complete.AutoSize = True
        Me.perc_copy_complete.Location = New System.Drawing.Point(51, 106)
        Me.perc_copy_complete.Name = "perc_copy_complete"
        Me.perc_copy_complete.Size = New System.Drawing.Size(17, 15)
        Me.perc_copy_complete.TabIndex = 7
        Me.perc_copy_complete.Text = "%"
        '
        'bt_stop_transf
        '
        Me.bt_stop_transf.Location = New System.Drawing.Point(156, 180)
        Me.bt_stop_transf.Name = "bt_stop_transf"
        Me.bt_stop_transf.Size = New System.Drawing.Size(61, 40)
        Me.bt_stop_transf.TabIndex = 8
        Me.bt_stop_transf.Text = "Stop a cópia"
        Me.bt_stop_transf.UseVisualStyleBackColor = True
        Me.bt_stop_transf.UseWaitCursor = True
        '
        'progesso_copy
        '
        Me.progesso_copy.Location = New System.Drawing.Point(74, 98)
        Me.progesso_copy.Name = "progesso_copy"
        Me.progesso_copy.Size = New System.Drawing.Size(218, 23)
        Me.progesso_copy.TabIndex = 9
        '
        'estado_operacao
        '
        Me.estado_operacao.AutoSize = True
        Me.estado_operacao.Location = New System.Drawing.Point(89, 147)
        Me.estado_operacao.Name = "estado_operacao"
        Me.estado_operacao.Size = New System.Drawing.Size(172, 15)
        Me.estado_operacao.TabIndex = 10
        Me.estado_operacao.Text = "Introduza os caminhos a copiar"
        Me.estado_operacao.Visible = False
        '
        'CopyPB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 248)
        Me.Controls.Add(Me.estado_operacao)
        Me.Controls.Add(Me.progesso_copy)
        Me.Controls.Add(Me.bt_stop_transf)
        Me.Controls.Add(Me.perc_copy_complete)
        Me.Controls.Add(Me.search_folder_paste)
        Me.Controls.Add(Me.search_folder_copy)
        Me.Controls.Add(Me.path_local_paste)
        Me.Controls.Add(Me.path_local_copy)
        Me.Controls.Add(Me.bt_transf)
        Me.Controls.Add(Me.to_transf)
        Me.Controls.Add(Me.to_copy)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CopyPB"
        Me.Text = "Copia Export Folders"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents to_copy As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bt_transf As Button
    Friend WithEvents path_local_copy As TextBox
    Friend WithEvents path_local_paste As TextBox
    Friend WithEvents search_folder_copy As Button
    Friend WithEvents search_folder_paste As Button
    Public WithEvents folder_copy As FolderBrowserDialog
    Public WithEvents folder_paste As FolderBrowserDialog
    Friend WithEvents to_transf As Label
    Friend WithEvents copy_process As System.ComponentModel.BackgroundWorker
    Friend WithEvents perc_copy_complete As Label
    Friend WithEvents bt_stop_transf As Button
    Friend WithEvents progesso_copy As ProgressBar
    Friend WithEvents estado_operacao As Label
End Class
