Public Class Form1

    Private Sub btnAddFiles_Click(sender As Object, e As EventArgs) Handles btnAddFiles.Click

        Dim strFiles() As String
        Dim strFile As String

        'dodaj zaznaczone pliki do lstFiles
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            strFiles = OpenFileDialog1.FileNames
            For Each strFile In strFiles
                lbxFileList.Items.Add(strFile)

            Next

        End If
    End Sub


    'wyswietl plik zaznaczony w lstFiles przy pomocy PictureBox
    Private Sub lbxFileList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxFileList.SelectedIndexChanged
        If lbxFileList.SelectedItems.Count > 0 Then 'jesli zaznnaczono minimum jeden plik

            Try
                PictureBox.Image = Image.FromFile(lbxFileList.SelectedItem)
            Catch ex As Exception
                MessageBox.Show("Nie udało się otworzyć pliku", "Błąd oczytu pliku", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub btnRemoveFiles_Click(sender As Object, e As EventArgs) Handles btnRemoveFiles.Click
        Do While (lbxFileList.SelectedItems.Count > 0)
            lbxFileList.Items.Remove(lbxFileList.SelectedItem)
        Loop
    End Sub

    Private Sub btnZastosuj_Click(sender As Object, e As EventArgs) Handles btnZastosuj.Click
        Dim ResizedImage As Image
        Dim NewSize As New Size
        Dim strFile As String
        Dim strResizedName As String
        If lbxFileList.Items.Count < 1 Then
            MessageBox.Show("Nie wybrano plików", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If cbxSizes.SelectedIndex < 0 Then
            MessageBox.Show("Nie wybrano rozmiaru", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If cbxSizes.SelectedIndex = 0 Then
            NewSize.Width = 1024
            NewSize.Height = 768
        End If
        If cbxSizes.SelectedIndex = 1 Then
            NewSize.Width = 800
            NewSize.Height = 600
        End If
        If cbxSizes.SelectedIndex = 2 Then
            NewSize.Width = 640
            NewSize.Height = 480
        End If
        PictureBox.Image = Nothing
        ProgressBar.Minimum = 0
        ProgressBar.Maximum = lbxFileList.Items.Count
        ProgressBar.Value = 0
        ProgressBar.Visible = True
        Try
            For Each strFile In lbxFileList.Items
                ResizedImage = New Bitmap(Image.FromFile(strFile), NewSize)
                strResizedName = strFile.Substring(0, strFile.LastIndexOf(".")) + "_resized" + ".jpg"
                ResizedImage.Save(strResizedName, System.Drawing.Imaging.ImageFormat.Jpeg)
                ProgressBar.Value = ProgressBar.Value + 1
                ResizedImage.Dispose()
            Next
            lbxFileList.Items.Clear()
        Catch ex As Exception
            MessageBox.Show("Zapis jednego lub więcej plików nie powiódł się", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MessageBox.Show("Zapisano pomyślnie wszystkie pliki", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.None)
        ProgressBar.Visible = False
        lblProgress.Visible = False
    End Sub
End Class

