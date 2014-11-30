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
        Me.lbxFileList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddFiles = New System.Windows.Forms.Button()
        Me.btnRemoveFiles = New System.Windows.Forms.Button()
        Me.cbxSizes = New System.Windows.Forms.ComboBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lbxFileList
        '
        Me.lbxFileList.FormattingEnabled = True
        Me.lbxFileList.Location = New System.Drawing.Point(13, 27)
        Me.lbxFileList.Name = "lbxFileList"
        Me.lbxFileList.Size = New System.Drawing.Size(259, 69)
        Me.lbxFileList.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'btnAddFiles
        '
        Me.btnAddFiles.Location = New System.Drawing.Point(16, 102)
        Me.btnAddFiles.Name = "btnAddFiles"
        Me.btnAddFiles.Size = New System.Drawing.Size(22, 23)
        Me.btnAddFiles.TabIndex = 3
        Me.btnAddFiles.Text = "+"
        Me.btnAddFiles.UseVisualStyleBackColor = True
        '
        'btnRemoveFiles
        '
        Me.btnRemoveFiles.Location = New System.Drawing.Point(41, 102)
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
        Me.cbxSizes.Location = New System.Drawing.Point(13, 132)
        Me.cbxSizes.Name = "cbxSizes"
        Me.cbxSizes.Size = New System.Drawing.Size(81, 21)
        Me.cbxSizes.TabIndex = 5
        '
        'PictureBox
        '
        Me.PictureBox.Location = New System.Drawing.Point(105, 103)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(167, 103)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.cbxSizes)
        Me.Controls.Add(Me.btnRemoveFiles)
        Me.Controls.Add(Me.btnAddFiles)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbxFileList)
        Me.Controls.Add(Me.btnZastosuj)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
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

End Class
