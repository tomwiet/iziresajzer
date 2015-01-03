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
        Me.btnZastosuj = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddFiles = New System.Windows.Forms.Button()
        Me.btnRemoveFiles = New System.Windows.Forms.Button()
        Me.cbxSizes = New System.Windows.Forms.ComboBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTargetPath = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.dgvListFiles = New System.Windows.Forms.DataGridView()
        Me.lblTest = New System.Windows.Forms.Label()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnZastosuj
        '
        Me.btnZastosuj.Location = New System.Drawing.Point(197, 227)
        Me.btnZastosuj.Name = "btnZastosuj"
        Me.btnZastosuj.Size = New System.Drawing.Size(75, 23)
        Me.btnZastosuj.TabIndex = 0
        Me.btnZastosuj.Text = "Zastosuj"
        Me.btnZastosuj.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pliki:"
        '
        'btnAddFiles
        '
        Me.btnAddFiles.Location = New System.Drawing.Point(114, 127)
        Me.btnAddFiles.Name = "btnAddFiles"
        Me.btnAddFiles.Size = New System.Drawing.Size(22, 23)
        Me.btnAddFiles.TabIndex = 3
        Me.btnAddFiles.Text = "+"
        Me.btnAddFiles.UseVisualStyleBackColor = True
        '
        'btnRemoveFiles
        '
        Me.btnRemoveFiles.Location = New System.Drawing.Point(151, 127)
        Me.btnRemoveFiles.Name = "btnRemoveFiles"
        Me.btnRemoveFiles.Size = New System.Drawing.Size(22, 23)
        Me.btnRemoveFiles.TabIndex = 4
        Me.btnRemoveFiles.Text = "-"
        Me.btnRemoveFiles.UseVisualStyleBackColor = True
        '
        'cbxSizes
        '
        Me.cbxSizes.FormattingEnabled = True
        Me.cbxSizes.Items.AddRange(New Object() {"1024x768", "800x600", "640x480"})
        Me.cbxSizes.Location = New System.Drawing.Point(12, 140)
        Me.cbxSizes.Name = "cbxSizes"
        Me.cbxSizes.Size = New System.Drawing.Size(87, 21)
        Me.cbxSizes.TabIndex = 5
        '
        'PictureBox
        '
        Me.PictureBox.Location = New System.Drawing.Point(197, 8)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(228, 169)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox.TabIndex = 6
        Me.PictureBox.TabStop = False
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(13, 227)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(178, 23)
        Me.ProgressBar.TabIndex = 7
        Me.ProgressBar.Visible = False
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Location = New System.Drawing.Point(16, 208)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(43, 13)
        Me.lblProgress.TabIndex = 8
        Me.lblProgress.Text = "Postęp:"
        Me.lblProgress.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Wszystkie pliki (*.*)|*.*|JPEG (*.jpg)|*.jpg"
        Me.OpenFileDialog1.FilterIndex = 2
        Me.OpenFileDialog1.Multiselect = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Wybierz rozmiar"
        '
        'txtTargetPath
        '
        Me.txtTargetPath.Location = New System.Drawing.Point(12, 185)
        Me.txtTargetPath.Name = "txtTargetPath"
        Me.txtTargetPath.Size = New System.Drawing.Size(207, 20)
        Me.txtTargetPath.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Zapisz w katalogu"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(236, 185)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(35, 23)
        Me.btnBrowse.TabIndex = 12
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'dgvListFiles
        '
        Me.dgvListFiles.AllowUserToAddRows = False
        Me.dgvListFiles.AllowUserToDeleteRows = False
        Me.dgvListFiles.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvListFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvListFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListFiles.ColumnHeadersVisible = False
        Me.dgvListFiles.Location = New System.Drawing.Point(12, 25)
        Me.dgvListFiles.Name = "dgvListFiles"
        Me.dgvListFiles.ReadOnly = True
        Me.dgvListFiles.RowHeadersVisible = False
        Me.dgvListFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListFiles.Size = New System.Drawing.Size(179, 96)
        Me.dgvListFiles.TabIndex = 13
        '
        'lblTest
        '
        Me.lblTest.AutoSize = True
        Me.lblTest.Location = New System.Drawing.Point(324, 227)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(24, 13)
        Me.lblTest.TabIndex = 14
        Me.lblTest.Text = "test"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 262)
        Me.Controls.Add(Me.lblTest)
        Me.Controls.Add(Me.dgvListFiles)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTargetPath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.cbxSizes)
        Me.Controls.Add(Me.btnRemoveFiles)
        Me.Controls.Add(Me.btnAddFiles)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnZastosuj)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnZastosuj As System.Windows.Forms.Button
    Friend WithEvents lbxFileList As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAddFiles As System.Windows.Forms.Button
    Friend WithEvents btnRemoveFiles As System.Windows.Forms.Button
    Friend WithEvents cbxSizes As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents lblProgress As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTargetPath As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents dgvListFiles As System.Windows.Forms.DataGridView
    Friend WithEvents lblTest As System.Windows.Forms.Label

End Class
