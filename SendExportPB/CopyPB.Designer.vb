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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bt_transf = New System.Windows.Forms.Button()
        Me.folder_copy = New System.Windows.Forms.FolderBrowserDialog()
        Me.folder_paste = New System.Windows.Forms.FolderBrowserDialog()
        Me.path_local_copy = New System.Windows.Forms.TextBox()
        Me.path_local_paste = New System.Windows.Forms.TextBox()
        Me.search_folder_copy = New System.Windows.Forms.Button()
        Me.search_folder_paste = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "To Copy"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To Transfer"
        '
        'bt_transf
        '
        Me.bt_transf.Location = New System.Drawing.Point(74, 95)
        Me.bt_transf.Name = "bt_transf"
        Me.bt_transf.Size = New System.Drawing.Size(181, 66)
        Me.bt_transf.TabIndex = 2
        Me.bt_transf.Text = "Copia"
        Me.bt_transf.UseVisualStyleBackColor = True
        '
        'folder_copy
        '
        Me.folder_copy.Description = "ss"
        Me.folder_copy.RootFolder = System.Environment.SpecialFolder.CommonDesktopDirectory
        Me.folder_copy.SelectedPath = "C:\Users\3100945\Desktop"
        Me.folder_copy.UseDescriptionForTitle = True
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
        Me.path_local_copy.Location = New System.Drawing.Point(74, 19)
        Me.path_local_copy.Name = "path_local_copy"
        Me.path_local_copy.Size = New System.Drawing.Size(218, 23)
        Me.path_local_copy.TabIndex = 3
        '
        'path_local_paste
        '
        Me.path_local_paste.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.path_local_paste.Location = New System.Drawing.Point(74, 48)
        Me.path_local_paste.Name = "path_local_paste"
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
        'CopyPB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 179)
        Me.Controls.Add(Me.search_folder_paste)
        Me.Controls.Add(Me.search_folder_copy)
        Me.Controls.Add(Me.path_local_paste)
        Me.Controls.Add(Me.path_local_copy)
        Me.Controls.Add(Me.bt_transf)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CopyPB"
        Me.Text = "Copia Repositorio PowerBuilder OpenSGC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bt_transf As Button
    Friend WithEvents path_local_copy As TextBox
    Friend WithEvents path_local_paste As TextBox
    Friend WithEvents search_folder_copy As Button
    Friend WithEvents search_folder_paste As Button
    Public WithEvents folder_copy As FolderBrowserDialog
    Public WithEvents folder_paste As FolderBrowserDialog
End Class
